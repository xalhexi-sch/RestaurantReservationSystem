Imports MySql.Data.MySqlClient

Public Class FrmRegisterCustomer

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmRegisterCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Theme.ApplyTheme(Me)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim contact As String = txtContact.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirm As String = txtConfirmPassword.Text.Trim()

        ' Basic validation
        If fullName = "" OrElse username = "" OrElse password = "" Then
            MessageBox.Show("Full Name, Username and Password are required.", "Register",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If password <> confirm Then
            MessageBox.Show("Passwords do not match.", "Register",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPassword.Focus()
            Return
        End If

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            ' 1) Insert into customers
            Dim customerId As Integer
            Dim sqlCust As String =
                "INSERT INTO customers (full_name, contact_no, email, notes) " &
                "VALUES (@name, @contact, @mail, @notes); " &
                "SELECT LAST_INSERT_ID();"

            Using cmdCust As New MySqlCommand(sqlCust, db.Connection)
                cmdCust.Parameters.AddWithValue("@name", fullName)
                cmdCust.Parameters.AddWithValue("@contact", contact)
                cmdCust.Parameters.AddWithValue("@mail", email)
                cmdCust.Parameters.AddWithValue("@notes", "Self-registered customer")

                customerId = Convert.ToInt32(cmdCust.ExecuteScalar())
            End Using

            ' 2) Insert into users with role = Customer
            Dim sqlUser As String =
                "INSERT INTO users (role_id, full_name, username, password_hash, is_active, customer_id) " &
                "VALUES ((SELECT role_id FROM roles WHERE role_name='Customer'), " &
                "        @name, @uname, @pwd, 1, @custId)"

            Using cmdUser As New MySqlCommand(sqlUser, db.Connection)
                cmdUser.Parameters.AddWithValue("@name", fullName)
                cmdUser.Parameters.AddWithValue("@uname", username)
                cmdUser.Parameters.AddWithValue("@pwd", password)  ' demo: plain text
                cmdUser.Parameters.AddWithValue("@custId", customerId)

                cmdUser.ExecuteNonQuery()
            End Using

            MessageBox.Show("Account created successfully! You can now log in.", "Register",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Return the username so login form can pre-fill (optional)
            Me.Tag = username
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As MySqlException
            ' Most likely duplicate username etc.
            MessageBox.Show("Error creating account: " & ex.Message, "Register",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error creating account: " & ex.Message, "Register",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

End Class
