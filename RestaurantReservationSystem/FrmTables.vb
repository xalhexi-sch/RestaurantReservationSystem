Imports MySql.Data.MySqlClient

Public Class FrmTables

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub FrmTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Theme.ApplyTheme(Me)
        Catch ex As Exception
        End Try

        ' Default status
        If cmbStatus.Items.Count > 0 Then
            cmbStatus.SelectedIndex = 0
        End If

        dgvTables.AutoGenerateColumns = True
        LoadTables()
    End Sub

    ' ============ HELPER METHODS ============

    Private Sub ClearInputs()
        txtTableID.Text = ""
        txtTableNumber.Text = ""
        numCapacity.Value = 2
        If cmbStatus.Items.Count > 0 Then
            cmbStatus.SelectedIndex = 0
        End If
        txtTableNumber.Focus()
    End Sub

    Private Sub LoadTables()
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()

            Dim sql As String =
                "SELECT table_id, table_number, capacity, status " &
                "FROM restaurant_tables " &
                "ORDER BY table_number"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                da.Fill(dt)
            End Using

            dgvTables.DataSource = dt

            ' make nice headers
            If dgvTables.Columns.Contains("table_id") Then
                dgvTables.Columns("table_id").HeaderText = "ID"
                dgvTables.Columns("table_id").Width = 50
            End If
            If dgvTables.Columns.Contains("table_number") Then
                dgvTables.Columns("table_number").HeaderText = "Table"
            End If
            If dgvTables.Columns.Contains("capacity") Then
                dgvTables.Columns("capacity").HeaderText = "Capacity"
            End If
            If dgvTables.Columns.Contains("status") Then
                dgvTables.Columns("status").HeaderText = "Status"
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' ============ BUTTON HANDLERS ============

    Private Sub btnNewTable_Click(sender As Object, e As EventArgs) Handles btnNewTable.Click
        ClearInputs()
    End Sub

    Private Sub btnSaveTable_Click(sender As Object, e As EventArgs) Handles btnSaveTable.Click
        If txtTableNumber.Text.Trim() = "" Then
            MessageBox.Show("Please enter a table number.", "Tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim tableNumber As String = txtTableNumber.Text.Trim()
        Dim capacity As Integer = CInt(numCapacity.Value)
        Dim status As String = cmbStatus.Text

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String =
                "INSERT INTO restaurant_tables (table_number, capacity, status) " &
                "VALUES (@num, @cap, @status); " &
                "SELECT LAST_INSERT_ID();"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@num", tableNumber)
                cmd.Parameters.AddWithValue("@cap", capacity)
                cmd.Parameters.AddWithValue("@status", status)

                Dim newId As Object = cmd.ExecuteScalar()
                If newId IsNot Nothing Then
                    txtTableID.Text = newId.ToString()
                End If
            End Using

            MessageBox.Show("Table saved.", "Tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadTables()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error saving table",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnUpdateTable_Click(sender As Object, e As EventArgs) Handles btnUpdateTable.Click
        If txtTableID.Text.Trim() = "" Then
            MessageBox.Show("Please select a table to update from the list.", "Tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtTableNumber.Text.Trim() = "" Then
            MessageBox.Show("Please enter a table number.", "Tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtTableID.Text.Trim())
        Dim tableNumber As String = txtTableNumber.Text.Trim()
        Dim capacity As Integer = CInt(numCapacity.Value)
        Dim status As String = cmbStatus.Text

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String =
                "UPDATE restaurant_tables SET " &
                "table_number=@num, capacity=@cap, status=@status " &
                "WHERE table_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@num", tableNumber)
                cmd.Parameters.AddWithValue("@cap", capacity)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Table updated.", "Tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadTables()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error updating table",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnDeleteTable_Click(sender As Object, e As EventArgs) Handles btnDeleteTable.Click
        If txtTableID.Text.Trim() = "" Then
            MessageBox.Show("Please select a table to delete.", "Tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtTableID.Text.Trim())

        If MessageBox.Show("Are you sure you want to delete this table?",
                           "Tables", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String = "DELETE FROM restaurant_tables WHERE table_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Table deleted.", "Tables",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearInputs()
            LoadTables()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error deleting table",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' ============ GRID HANDLER ============

    Private Sub dgvTables_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTables.CellClick
        If e.RowIndex < 0 Then Return
        If dgvTables.CurrentRow Is Nothing Then Return

        Dim row As DataGridViewRow = dgvTables.Rows(e.RowIndex)

        If row.Cells("table_id").Value IsNot Nothing Then
            txtTableID.Text = row.Cells("table_id").Value.ToString()
        End If
        If row.Cells("table_number").Value IsNot Nothing Then
            txtTableNumber.Text = row.Cells("table_number").Value.ToString()
        End If
        If row.Cells("capacity").Value IsNot Nothing Then
            numCapacity.Value = CDec(row.Cells("capacity").Value)
        End If
        If row.Cells("status").Value IsNot Nothing Then
            cmbStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

End Class
