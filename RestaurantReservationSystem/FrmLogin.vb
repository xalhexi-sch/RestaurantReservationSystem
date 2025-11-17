Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FrmLogin

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply pink pastel theme (safe even if Theme module missing)
        Try
            Theme.ApplyTheme(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter username and password.", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim db = DatabaseConnection.Instance
            db.Open()

            Dim sql As String =
            "SELECT u.user_id, u.full_name, r.role_name, u.customer_id " &
            "FROM users u " &
            "JOIN roles r ON u.role_id = r.role_id " &
            "WHERE u.username=@uname " &
            "  AND u.password_hash=@pwd " &
            "  AND u.is_active = 1"

            Using cmd As New MySql.Data.MySqlClient.MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@uname", username)
                cmd.Parameters.AddWithValue("@pwd", password) ' plain text for school demo

                Using reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim userId As Integer = CInt(reader("user_id"))
                        Dim fullName As String = reader("full_name").ToString()
                        Dim roleName As String = reader("role_name").ToString()
                        Dim customerId As Integer = 0
                        If Not IsDBNull(reader("customer_id")) Then
                            customerId = CInt(reader("customer_id"))
                        End If

                        reader.Close()
                        db.Close()

                        If roleName = "Customer" Then
                            ' ⭐ GUEST / CUSTOMER: go straight to reservations, no FrmMain
                            Dim f As New FrmReservations(userId, customerId, fullName, roleName)
                            f.Show()
                            Me.Hide()
                        Else
                            ' ⭐ Admin / Staff: keep main admin window
                            Dim main As New FrmMain(userId, fullName, roleName, customerId)
                            main.Show()
                            Me.Hide()
                        End If
                    Else
                        reader.Close()
                        db.Close()
                        MessageBox.Show("Invalid username or password.", "Login",
                                    MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub



    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim reg As New FrmRegisterCustomer()
        Dim result As DialogResult = reg.ShowDialog(Me)

        ' If registration succeeded, reg.Tag contains the username
        If result = DialogResult.OK AndAlso reg.Tag IsNot Nothing Then
            txtUsername.Text = reg.Tag.ToString()
            txtPassword.Focus()
        End If
    End Sub


End Class
