Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class FormManageTables
    Private selectedTableId As Integer = -1

    Private Sub FormManageTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTables()
    End Sub

    Private Sub LoadTables()
        Dim conn = DatabaseConnection.GetConnection()
        Dim da As New MySqlDataAdapter("SELECT * FROM restaurant_tables", conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        dgvTables.DataSource = dt
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO restaurant_tables(table_number,capacity) VALUES(@num,@cap)", conn)
            cmd.Parameters.AddWithValue("@num", txtTableNum.Text)
            cmd.Parameters.AddWithValue("@cap", CInt(numCap.Value))
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadTables()
            MessageBox.Show("Table added.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvTables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTables.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvTables.Rows(e.RowIndex)
            selectedTableId = CInt(row.Cells("table_id").Value)
            txtTableNum.Text = row.Cells("table_number").Value.ToString()
            numCap.Value = CDec(row.Cells("capacity").Value)
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedTableId = -1 Then
            MessageBox.Show("Select a table first.") : Exit Sub
        End If
        Dim conn = DatabaseConnection.GetConnection()
        conn.Open()
        Dim cmd As New MySqlCommand("UPDATE restaurant_tables SET table_number=@num,capacity=@cap WHERE table_id=@id", conn)
        cmd.Parameters.AddWithValue("@num", txtTableNum.Text)
        cmd.Parameters.AddWithValue("@cap", CInt(numCap.Value))
        cmd.Parameters.AddWithValue("@id", selectedTableId)
        cmd.ExecuteNonQuery()
        conn.Close()
        LoadTables()
        MessageBox.Show("Table updated.")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedTableId = -1 Then
            MessageBox.Show("Select a table first.") : Exit Sub
        End If
        If MessageBox.Show("Delete this table?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Dim conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM restaurant_tables WHERE table_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", selectedTableId)
            cmd.ExecuteNonQuery()
            conn.Close()
            LoadTables()
            MessageBox.Show("Deleted.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTableNum.Clear()
        numCap.Value = 1
        selectedTableId = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
