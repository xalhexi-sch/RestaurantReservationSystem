Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormManageCustomers
    Private selectedCustomerId As Integer = -1

    Private Sub FormManageCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()
        Try
            Dim conn = DatabaseConnection.GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM customers", conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvCustomers.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading customers: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text.Trim() = "" Then
            MessageBox.Show("Please enter customer name.") : Exit Sub
        End If
        Try
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO customers(name, phone, email) VALUES(@n, @p, @e)", conn)
            cmd.Parameters.AddWithValue("@n", txtName.Text)
            cmd.Parameters.AddWithValue("@p", txtPhone.Text)
            cmd.Parameters.AddWithValue("@e", txtEmail.Text)
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadCustomers()
            ClearFields()
            MessageBox.Show("Customer added.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvCustomers.Rows(e.RowIndex)
            selectedCustomerId = CInt(row.Cells("customer_id").Value)
            txtName.Text = row.Cells("name").Value.ToString()
            txtPhone.Text = row.Cells("phone").Value.ToString()
            txtEmail.Text = row.Cells("email").Value.ToString()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedCustomerId = -1 Then
            MessageBox.Show("Select a customer first.") : Exit Sub
        End If
        Try
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE customers SET name=@n, phone=@p, email=@e WHERE customer_id=@id", conn)
            cmd.Parameters.AddWithValue("@n", txtName.Text)
            cmd.Parameters.AddWithValue("@p", txtPhone.Text)
            cmd.Parameters.AddWithValue("@e", txtEmail.Text)
            cmd.Parameters.AddWithValue("@id", selectedCustomerId)
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadCustomers()
            ClearFields()
            MessageBox.Show("Customer updated.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedCustomerId = -1 Then
            MessageBox.Show("Select a row first.") : Exit Sub
        End If
        If MessageBox.Show("Delete this customer?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM customers WHERE customer_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", selectedCustomerId)
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadCustomers()
            ClearFields()
            MessageBox.Show("Customer deleted.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtName.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
        selectedCustomerId = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
