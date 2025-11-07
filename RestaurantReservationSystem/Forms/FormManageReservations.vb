Imports MySql.Data.MySqlClient

Public Class FormManageReservations
    Private selectedResId As Integer = -1

    Private Sub FormManageReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombos()
        LoadReservations()
    End Sub

    ' ------------------------
    ' Load data into ComboBoxes
    ' ------------------------
    Private Sub LoadCombos()
        Try
            ' Load Customers
            Using conn = DatabaseConnection.GetConnection()
                Dim daC As New MySqlDataAdapter("SELECT customer_id, name FROM customers", conn)
                Dim dtC As New DataTable()
                daC.Fill(dtC)
                cmbCustomer.DisplayMember = "name"
                cmbCustomer.ValueMember = "customer_id"
                cmbCustomer.DataSource = dtC
            End Using

            ' Load Tables
            Using conn = DatabaseConnection.GetConnection()
                Dim daT As New MySqlDataAdapter("SELECT table_id, table_number FROM restaurant_tables WHERE status='available'", conn)
                Dim dtT As New DataTable()
                daT.Fill(dtT)
                cmbTable.DisplayMember = "table_number"
                cmbTable.ValueMember = "table_id"
                cmbTable.DataSource = dtT
            End Using

            ' Load Staff (from users table)
            Using conn = DatabaseConnection.GetConnection()
                Dim daS As New MySqlDataAdapter("SELECT user_id, username FROM users WHERE role='staff'", conn)
                Dim dtS As New DataTable()
                daS.Fill(dtS)
                cmbStaff.DisplayMember = "username"
                cmbStaff.ValueMember = "user_id"
                cmbStaff.DataSource = dtS
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading combos: " & ex.Message)
        End Try
    End Sub

    ' ------------------------
    ' Load reservations into DataGridView
    ' ------------------------
    Private Sub LoadReservations()
        Try
            Using conn = DatabaseConnection.GetConnection()
                Dim query As String =
                    "SELECT r.reservation_id, c.name AS customer, t.table_number, u.username AS staff, " &
                    "r.reservation_date, r.pax, r.status, r.notes " &
                    "FROM reservations r " &
                    "JOIN customers c ON r.customer_id=c.customer_id " &
                    "JOIN restaurant_tables t ON r.table_id=t.table_id " &
                    "LEFT JOIN users u ON r.staff_id=u.user_id " &
                    "ORDER BY r.reservation_date DESC"
                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvReservations.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reservations: " & ex.Message)
        End Try
    End Sub

    ' ------------------------
    ' Add Reservation
    ' ------------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("INSERT INTO reservations(customer_id, table_id, staff_id, reservation_date, pax, notes) VALUES(@c, @t, @s, @d, @p, @n)", conn)
                cmd.Parameters.AddWithValue("@c", cmbCustomer.SelectedValue)
                cmd.Parameters.AddWithValue("@t", cmbTable.SelectedValue)
                cmd.Parameters.AddWithValue("@s", cmbStaff.SelectedValue)
                cmd.Parameters.AddWithValue("@d", dtpDate.Value)
                cmd.Parameters.AddWithValue("@p", CInt(numPax.Value))
                cmd.Parameters.AddWithValue("@n", txtNotes.Text)
                cmd.ExecuteNonQuery()
            End Using
            LoadReservations()
            MessageBox.Show("Reservation added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding reservation: " & ex.Message)
        End Try
    End Sub

    ' ------------------------
    ' Select reservation in DataGridView
    ' ------------------------
    Private Sub dgvReservations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservations.CellClick
        If e.RowIndex >= 0 Then
            Dim row = dgvReservations.Rows(e.RowIndex)
            selectedResId = CInt(row.Cells("reservation_id").Value)
            dtpDate.Value = CDate(row.Cells("reservation_date").Value)
            numPax.Value = CDec(row.Cells("pax").Value)
            txtNotes.Text = row.Cells("notes").Value.ToString()
        End If
    End Sub

    ' ------------------------
    ' Update Reservation
    ' ------------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If selectedResId = -1 Then
            MessageBox.Show("Select a reservation first.") : Exit Sub
        End If
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("UPDATE reservations SET reservation_date=@d, pax=@p, notes=@n WHERE reservation_id=@id", conn)
                cmd.Parameters.AddWithValue("@d", dtpDate.Value)
                cmd.Parameters.AddWithValue("@p", CInt(numPax.Value))
                cmd.Parameters.AddWithValue("@n", txtNotes.Text)
                cmd.Parameters.AddWithValue("@id", selectedResId)
                cmd.ExecuteNonQuery()
            End Using
            LoadReservations()
            MessageBox.Show("Reservation updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error updating reservation: " & ex.Message)
        End Try
    End Sub

    ' ------------------------
    ' Delete Reservation
    ' ------------------------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedResId = -1 Then
            MessageBox.Show("Select one to delete.") : Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using conn = DatabaseConnection.GetConnection()
                    conn.Open()
                    Dim cmd As New MySqlCommand("DELETE FROM reservations WHERE reservation_id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", selectedResId)
                    cmd.ExecuteNonQuery()
                End Using
                LoadReservations()
                MessageBox.Show("Reservation deleted.")
            Catch ex As Exception
                MessageBox.Show("Error deleting reservation: " & ex.Message)
            End Try
        End If
    End Sub

    ' ------------------------
    ' Clear fields
    ' ------------------------
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNotes.Clear()
        numPax.Value = 1
        selectedResId = -1
    End Sub

    ' ------------------------
    ' Close form
    ' ------------------------
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If selectedResId = -1 Then
            MessageBox.Show("Select a reservation first.") : Exit Sub
        End If

        Using conn = DatabaseConnection.GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE reservations SET status='cancelled' WHERE reservation_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", selectedResId)
            cmd.ExecuteNonQuery()
        End Using

        LoadReservations()
        MessageBox.Show("Reservation rejected (cancelled).")
    End Sub

End Class
