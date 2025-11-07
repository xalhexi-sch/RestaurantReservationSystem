Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormRegister
    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.AddRange(New String() {"guest", "staff", "admin"})
        cmbRole.SelectedIndex = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim u = txtRegUser.Text.Trim()
        Dim p = txtRegPass.Text.Trim()
        Dim r = cmbRole.SelectedItem.ToString()

        If u = "" Or p = "" Then
            MessageBox.Show("Fill in all fields.") : Exit Sub
        End If

        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()

                ' Step 1: Insert new user
                Dim cmdUser As New MySqlCommand("INSERT INTO users (username, password_hash, role) VALUES (@u, @p, @r)", conn)
                cmdUser.Parameters.AddWithValue("@u", u)
                cmdUser.Parameters.AddWithValue("@p", p)
                cmdUser.Parameters.AddWithValue("@r", r)
                cmdUser.ExecuteNonQuery()

                ' Step 2: Get the new user_id (for guests)
                Dim newUserId As Integer = CInt(cmdUser.LastInsertedId)

                ' Step 3: If the new account is a guest, create a linked customer record
                If r = "guest" Then
                    Dim cmdCust As New MySqlCommand("INSERT INTO customers (customer_id, name, phone, email) VALUES (@id, @n, '', '')", conn)
                    cmdCust.Parameters.AddWithValue("@id", newUserId)  ' use same ID for easy linking
                    cmdCust.Parameters.AddWithValue("@n", u)
                    cmdCust.ExecuteNonQuery()
                End If

                MessageBox.Show("Account created successfully! You can now log in.")
            End Using

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
