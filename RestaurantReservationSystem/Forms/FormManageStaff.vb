Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormManageStaff
    Private selectedStaffId As Integer = -1

    Private Sub FormManageStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaff()
    End Sub

    Private Sub LoadStaff()
        Try
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim query As String = "SELECT s.staff_id, u.username, s.first_name, s.last_name, s.position, s.phone, s.email FROM staff s JOIN users u ON s.user_id=u.user_id"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvStaff.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading staff: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFirst.Text.Trim() = "" Or txtLast.Text.Trim() = "" Then
            MessageBox.Show("Please enter first and last name.")
            Exit Sub
        End If

        Try
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim username = txtFirst.Text.ToLower() & "." & txtLast.Text.ToLower()
            ' create a user first (default password: staff123)
            Dim cmdUser As New MySqlCommand("INSERT INTO users(username,password_hash,role) VALUES(@u,@p,'staff')", conn)
            cmdUser.Parameters.AddWithValue("@u", username)
            cmdUser.Parameters.AddWithValue("@p", "staff123")
            cmdUser.ExecuteNonQuery()
            Dim newUserId As Integer = CInt(cmdUser.LastInsertedId)

            Dim cmdStaff As New MySqlCommand("INSERT INTO staff(user_id,first_name,last_name,position,phone,email) VALUES(@uid,@fn,@ln,@pos,@ph,@em)", conn)
            cmdStaff.Parameters.AddWithValue("@uid", newUserId)
            cmdStaff.Parameters.AddWithValue("@fn", txtFirst.Text)
            cmdStaff.Parameters.AddWithValue("@ln", txtLast.Text)
            cmdStaff.Parameters.AddWithValue("@pos", txtPos.Text)
            cmdStaff.Parameters.AddWithValue("@ph", txtPhone.Text)
            cmdStaff.Parameters.AddWithValue("@em", txtEmail.Text)
            cmdStaff.ExecuteNonQuery()

            conn.Close()
            LoadStaff()
            ClearFields()
            MessageBox.Show("Staff added successfully! Default password is 'staff123'")
        Catch ex As Exception
            MessageBox.Show("Error adding staff: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvStaff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaff.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvStaff.Rows(e.RowIndex)
            selectedStaffId = CInt(row.Cells("staff_id").Value)
            txtFirst.Text = row.Cells("first_name").Value.ToString()
            txtLast.Text = row.Cells("last_name").Value.ToString()
            txtPos.Text = row.Cells("position").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedStaffId = -1 Then
            MessageBox.Show("Select a row first.")
            Exit Sub
        End If

        Try
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE staff SET first_name=@fn,last_name=@ln,position=@pos,phone=@ph,email=@em WHERE staff_id=@id", conn)
            cmd.Parameters.AddWithValue("@fn", txtFirst.Text)
            cmd.Parameters.AddWithValue("@ln", txtLast.Text)
            cmd.Parameters.AddWithValue("@pos", txtPos.Text)
            cmd.Parameters.AddWithValue("@ph", txtPhone.Text)
            cmd.Parameters.AddWithValue("@em", txtEmail.Text)
            cmd.Parameters.AddWithValue("@id", selectedStaffId)
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadStaff()
            ClearFields()
            MessageBox.Show("Staff updated successfully!")
        Catch ex As Exception
            MessageBox.Show("Error updating staff: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedStaffId = -1 Then
            MessageBox.Show("Select a staff row first.")
            Exit Sub
        End If

        If MessageBox.Show("Delete this staff record?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Dim conn = DatabaseConnection.GetConnection()
                conn.Open()
                ' Delete user and staff
                Dim cmd As New MySqlCommand("DELETE u FROM users u JOIN staff s ON u.user_id = s.user_id WHERE s.staff_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", selectedStaffId)
                cmd.ExecuteNonQuery()
                conn.Close()
                LoadStaff()
                ClearFields()
                MessageBox.Show("Staff deleted.")
            Catch ex As Exception
                MessageBox.Show("Error deleting staff: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtFirst.Clear()
        txtLast.Clear()
        txtPos.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        selectedStaffId = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
