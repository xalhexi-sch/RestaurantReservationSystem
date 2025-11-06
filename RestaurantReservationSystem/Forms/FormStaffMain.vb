Imports MySql.Data.MySqlClient

Public Class FormStaffMain
    Private _userId As Integer
    Private _username As String
    Private selectedResId As Integer = -1

    Public Sub New(userId As Integer, username As String)
        InitializeComponent()
        _userId = userId
        _username = username
    End Sub

    Private Sub FormStaffMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & _username

        ' Populate status dropdown
        cmbStatus.Items.Clear()
        cmbStatus.Items.AddRange(New String() {"booked", "seated", "completed", "cancelled"})

        LoadTables()
        LoadReservations()
    End Sub

    ' 🔹 Load reservations (search optional)
    Private Sub LoadReservations(Optional search As String = "")
        Try
            Using conn = DatabaseConnection.GetConnection()
                Dim query As String =
                    "SELECT r.reservation_id, c.name AS customer, t.table_number, " &
                    "r.reservation_date, r.pax, r.status, r.notes " &
                    "FROM reservations r " &
                    "JOIN customers c ON r.customer_id = c.customer_id " &
                    "JOIN restaurant_tables t ON r.table_id = t.table_id " &
                    "WHERE (c.name LIKE @s OR t.table_number LIKE @s OR r.status LIKE @s OR r.notes LIKE @s) " &
                    "ORDER BY r.reservation_date DESC"

                Dim da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@s", "%" & search & "%")

                Dim dt As New DataTable()
                da.Fill(dt)
                dgvStaffReservations.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reservations: " & ex.Message)
        End Try
    End Sub

    ' 🔹 Load tables into combo
    Private Sub LoadTables()
        Try
            Using conn = DatabaseConnection.GetConnection()
                Dim da As New MySqlDataAdapter("SELECT table_id, table_number FROM restaurant_tables", conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                cmbTable.DisplayMember = "table_number"
                cmbTable.ValueMember = "table_id"
                cmbTable.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading tables: " & ex.Message)
        End Try
    End Sub

    ' 🔹 When a row is clicked
    Private Sub dgvStaffReservations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStaffReservations.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvStaffReservations.Rows(e.RowIndex)
            selectedResId = CInt(row.Cells("reservation_id").Value)
            txtCustomer.Text = row.Cells("customer").Value.ToString()
            dtpDate.Value = CDate(row.Cells("reservation_date").Value)
            numPax.Value = CInt(row.Cells("pax").Value)
            txtNotes.Text = row.Cells("notes").Value.ToString()
            cmbStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

    ' 🔹 Update selected reservation
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedResId = -1 Then
            MessageBox.Show("Select a reservation first.") : Exit Sub
        End If
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand(
                    "UPDATE reservations SET table_id=@t, reservation_date=@d, pax=@p, status=@s, notes=@n WHERE reservation_id=@id", conn)
                cmd.Parameters.AddWithValue("@t", cmbTable.SelectedValue)
                cmd.Parameters.AddWithValue("@d", dtpDate.Value)
                cmd.Parameters.AddWithValue("@p", CInt(numPax.Value))
                cmd.Parameters.AddWithValue("@s", cmbStatus.Text)
                cmd.Parameters.AddWithValue("@n", txtNotes.Text)
                cmd.Parameters.AddWithValue("@id", selectedResId)
                cmd.ExecuteNonQuery()
            End Using
            LoadReservations()
            MessageBox.Show("Reservation updated.")
        Catch ex As Exception
            MessageBox.Show("Error updating: " & ex.Message)
        End Try
    End Sub

    ' 🔹 Search button
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim term As String = txtSearch.Text.Trim()
        If term = "" Then
            LoadReservations()
        Else
            LoadReservations(term)
        End If
    End Sub

    ' 🔹 Refresh
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReservations()
    End Sub

    ' 🔹 Clear fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustomer.Clear()
        txtNotes.Clear()
        numPax.Value = 1
        cmbStatus.SelectedIndex = -1
        selectedResId = -1
    End Sub

    ' 🔹 Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        FormLogin.Show()
    End Sub
End Class
