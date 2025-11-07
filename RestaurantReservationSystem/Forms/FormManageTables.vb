Imports MySql.Data.MySqlClient

Public Class FormManageTables
    Private selectedTableId As Integer = -1

    Private Sub FormManageTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange(New String() {"available", "occupied", "reserved"})
        LoadTables()
    End Sub

    ' -------------------------
    ' Load all tables
    ' -------------------------
    Private Sub LoadTables()
        Try
            Using conn = DatabaseConnection.GetConnection()
                Dim da As New MySqlDataAdapter("SELECT table_id, table_number, capacity, status FROM restaurant_tables", conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvTables.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading tables: " & ex.Message)
        End Try
    End Sub

    ' -------------------------
    ' Select table
    ' -------------------------
    Private Sub dgvTables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTables.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvTables.Rows(e.RowIndex)
            selectedTableId = CInt(row.Cells("table_id").Value)
            txtTableNumber.Text = row.Cells("table_number").Value.ToString()
            numCapacity.Value = CInt(row.Cells("capacity").Value)
            cmbStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

    ' -------------------------
    ' Add new table
    ' -------------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtTableNumber.Text = "" Then
            MessageBox.Show("Please enter a table number.") : Exit Sub
        End If
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO restaurant_tables (table_number, capacity, status) VALUES (@num,@cap,@stat)", conn)
                cmd.Parameters.AddWithValue("@num", txtTableNumber.Text)
                cmd.Parameters.AddWithValue("@cap", CInt(numCapacity.Value))
                cmd.Parameters.AddWithValue("@stat", cmbStatus.Text)
                cmd.ExecuteNonQuery()
            End Using
            LoadTables()
            MessageBox.Show("Table added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding table: " & ex.Message)
        End Try
    End Sub

    ' -------------------------
    ' Update table
    ' -------------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedTableId = -1 Then
            MessageBox.Show("Select a table first.") : Exit Sub
        End If
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE restaurant_tables SET table_number=@num, capacity=@cap, status=@stat WHERE table_id=@id", conn)
                cmd.Parameters.AddWithValue("@num", txtTableNumber.Text)
                cmd.Parameters.AddWithValue("@cap", CInt(numCapacity.Value))
                cmd.Parameters.AddWithValue("@stat", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@id", selectedTableId)
                cmd.ExecuteNonQuery()
            End Using
            LoadTables()
            MessageBox.Show("Table updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error updating table: " & ex.Message)
        End Try
    End Sub

    ' -------------------------
    ' Delete table
    ' -------------------------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedTableId = -1 Then
            MessageBox.Show("Select a table first.") : Exit Sub
        End If
        If MessageBox.Show("Delete this table?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM restaurant_tables WHERE table_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", selectedTableId)
                cmd.ExecuteNonQuery()
            End Using
            LoadTables()
            MessageBox.Show("Table deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Error deleting table: " & ex.Message)
        End Try
    End Sub

    ' -------------------------
    ' Refresh
    ' -------------------------
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadTables()
    End Sub

    ' -------------------------
    ' Clear
    ' -------------------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTableNumber.Clear()
        numCapacity.Value = 1
        cmbStatus.SelectedIndex = -1
        selectedTableId = -1
    End Sub

    ' -------------------------
    ' Close
    ' -------------------------
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
