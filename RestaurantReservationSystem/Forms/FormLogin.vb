Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user = txtUsername.Text.Trim()
        Dim pass = txtPassword.Text.Trim()
        If user = "" Or pass = "" Then
            MessageBox.Show("Please fill in all fields.") : Exit Sub
        End If

        Dim conn = DatabaseConnection.GetConnection()
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT user_id, role, password_hash FROM users WHERE username=@u", conn)
            cmd.Parameters.AddWithValue("@u", user)
            Dim rd = cmd.ExecuteReader()
            If rd.Read() Then
                Dim dbPass = rd("password_hash").ToString()
                Dim role = rd("role").ToString()
                Dim uid = CInt(rd("user_id"))
                rd.Close()

                If pass = dbPass Then
                    MessageBox.Show("Welcome " & role)
                    Me.Hide()
                    Select Case role
                        Case "admin"
                            Dim f As New FormAdminMain(uid)
                            f.Show()
                        Case "staff"
                            Dim f As New FormStaffMain(uid, user)   ' ← pass username here
                            f.Show()
                        Case "guest"
                            Dim f As New FormGuestMain(uid)
                            f.Show()
                    End Select
                Else
                    MessageBox.Show("Wrong password.")
                End If
            Else
                MessageBox.Show("User not found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim r As New FormRegister()
        r.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
