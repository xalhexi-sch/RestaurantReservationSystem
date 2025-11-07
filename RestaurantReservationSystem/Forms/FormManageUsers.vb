Imports MySql.Data.MySqlClient

Public Class FormManageUsers
    Private selectedUserId As Integer = -1

    Private Sub FormManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.AddRange(New String() {"admin", "staff", "guest"})
        LoadUsers()
    End Sub

    Private Sub LoadUsers()
        Try
            Using conn = DatabaseConnection.GetConnection()
                Dim da As New MySqlDataAdapter("SELECT user_id, username, role FROM users", conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvUsers.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvUsers.Rows(e.RowIndex)
            selectedUserId = CInt(row.Cells("user_id").Value)
            txtUsername.Text = row.Cells("username").Value.ToString()
            cmbRole.Text = row.Cells("role").Value.ToString()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
            MessageBox.Show("Fill all fields.") : Exit Sub
        End If
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO users(username,password_hash,role) VALUES(@u,@p,@r)", conn)
                cmd.Parameters.AddWithValue("@u", txtUsername.Text)
                cmd.Parameters.AddWithValue("@p", txtPassword.Text)
                cmd.Parameters.AddWithValue("@r", cmbRole.Text)
                cmd.ExecuteNonQuery()
            End Using
            LoadUsers()
            MessageBox.Show("User added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding user: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedUserId = -1 Then
            MessageBox.Show("Select a user first.") : Exit Sub
        End If
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE users SET username=@u, role=@r WHERE user_id=@id", conn)
                cmd.Parameters.AddWithValue("@u", txtUsername.Text)
                cmd.Parameters.AddWithValue("@r", cmbRole.Text)
                cmd.Parameters.AddWithValue("@id", selectedUserId)
                cmd.ExecuteNonQuery()
            End Using
            LoadUsers()
            MessageBox.Show("User updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedUserId = -1 Then
            MessageBox.Show("Select a user first.") : Exit Sub
        End If
        If MessageBox.Show("Delete this user?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM users WHERE user_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", selectedUserId)
                cmd.ExecuteNonQuery()
            End Using
            LoadUsers()
            MessageBox.Show("User deleted.")
        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadUsers()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
