Imports MySql.Data.MySqlClient

Public Class FrmReservations

    Private _userId As Integer
    Private _customerId As Integer   ' 0 = not a customer login
    Private _fullName As String
    Private _role As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(userId As Integer, customerId As Integer, fullName As String, role As String)
        Me.New()
        _userId = userId
        _customerId = customerId
        _fullName = fullName
        _role = role
    End Sub

    Private Sub FrmReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Theme.ApplyTheme(Me)
        Catch ex As Exception
        End Try

        LoadTables()

        If _role = "Customer" AndAlso _customerId > 0 Then
            LoadSingleCustomerForCurrentUser()
        Else
            LoadAllCustomers()
        End If

        ClearFields()
        LoadReservations()
    End Sub

    ' ================== HELPERS ==================

    Private Sub ClearFields()
        txtReservationID.Text = ""
        dtpDate.Value = DateTime.Today
        dtpTime.Value = DateTime.Now
        nudGuests.Value = 1

        ' Default status
        If cmbStatus.Items.Count > 0 Then
            cmbStatus.SelectedItem = "Pending"
        End If

        ' Customers cannot change customer; admin/staff can
        If _role = "Customer" Then
            cmbCustomer.Enabled = False
            cmbStatus.Enabled = False      ' they can't set random statuses
            btnUpdate.Enabled = False      ' no direct editing
            ' you can decide: allow Cancel
            btnCancelReservation.Enabled = True
        Else
            cmbCustomer.Enabled = True
            cmbStatus.Enabled = True
            btnUpdate.Enabled = True
            btnCancelReservation.Enabled = True
        End If
    End Sub


    Private Sub LoadAllCustomers()
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()
            Dim sql As String = "SELECT customer_id, full_name FROM customers ORDER BY full_name"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                da.Fill(dt)
            End Using

            cmbCustomer.DataSource = dt
            cmbCustomer.DisplayMember = "full_name"
            cmbCustomer.ValueMember = "customer_id"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading customers", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub LoadSingleCustomerForCurrentUser()
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()
            Dim sql As String = "SELECT customer_id, full_name FROM customers WHERE customer_id=@id"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                da.SelectCommand.Parameters.AddWithValue("@id", _customerId)
                da.Fill(dt)
            End Using

            cmbCustomer.DataSource = dt
            cmbCustomer.DisplayMember = "full_name"
            cmbCustomer.ValueMember = "customer_id"
            cmbCustomer.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub LoadTables()
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()
            Dim sql As String = "SELECT table_id, table_number FROM restaurant_tables WHERE status <> 'Inactive' ORDER BY table_number"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                da.Fill(dt)
            End Using

            cmbTable.DataSource = dt
            cmbTable.DisplayMember = "table_number"
            cmbTable.ValueMember = "table_id"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading tables", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub LoadReservations(Optional filterByDate As Boolean = False)
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()

            Dim sql As String =
                "SELECT r.reservation_id, c.full_name AS customer_name, t.table_number, " &
                "       r.reservation_date, r.reservation_time, r.number_of_guests, r.status " &
                "FROM reservations r " &
                "JOIN customers c ON r.customer_id = c.customer_id " &
                "JOIN restaurant_tables t ON r.table_id = t.table_id "

            Dim whereParts As New List(Of String)()

            If _role = "Customer" AndAlso _customerId > 0 Then
                whereParts.Add("r.customer_id = @custId")
            End If

            If filterByDate Then
                whereParts.Add("r.reservation_date = @rdate")
            End If

            If whereParts.Count > 0 Then
                sql &= " WHERE " & String.Join(" AND ", whereParts)
            End If

            sql &= " ORDER BY r.reservation_date, r.reservation_time"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                If _role = "Customer" AndAlso _customerId > 0 Then
                    da.SelectCommand.Parameters.AddWithValue("@custId", _customerId)
                End If
                If filterByDate Then
                    da.SelectCommand.Parameters.AddWithValue("@rdate", dtpSearchDate.Value.Date)
                End If
                da.Fill(dt)
            End Using

            dgvReservations.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading reservations", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' =============== BUTTONS =====================

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearFields()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cmbTable.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a table.", "Reservations",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim customerId As Integer
        If _role = "Customer" AndAlso _customerId > 0 Then
            customerId = _customerId
        Else
            customerId = CInt(cmbCustomer.SelectedValue)
        End If

        Dim tableId As Integer = CInt(cmbTable.SelectedValue)
        Dim resDate As Date = dtpDate.Value.Date
        Dim resTime As TimeSpan = dtpTime.Value.TimeOfDay
        Dim guests As Integer = CInt(nudGuests.Value)
        Dim status As String
        If _role = "Customer" Then
            status = "Pending"   ' guests always create PENDING reservations
        Else
            status = cmbStatus.Text
        End If


        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String =
                "INSERT INTO reservations (customer_id, table_id, reservation_date, reservation_time, " &
                "       number_of_guests, status, created_by) " &
                "VALUES (@custId, @tableId, @rdate, @rtime, @guests, @status, @userId); " &
                "SELECT LAST_INSERT_ID();"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@custId", customerId)
                cmd.Parameters.AddWithValue("@tableId", tableId)
                cmd.Parameters.AddWithValue("@rdate", resDate)
                cmd.Parameters.AddWithValue("@rtime", resTime)
                cmd.Parameters.AddWithValue("@guests", guests)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@userId", _userId)

                Dim newId As Object = cmd.ExecuteScalar()
                If newId IsNot Nothing Then
                    txtReservationID.Text = newId.ToString()
                End If
            End Using

            MessageBox.Show("Reservation saved.", "Reservations",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadReservations()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error saving reservation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtReservationID.Text.Trim() = "" Then
            MessageBox.Show("Select a reservation to update.", "Reservations",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtReservationID.Text.Trim())

        Dim customerId As Integer
        If _role = "Customer" AndAlso _customerId > 0 Then
            customerId = _customerId
        Else
            customerId = CInt(cmbCustomer.SelectedValue)
        End If

        Dim tableId As Integer = CInt(cmbTable.SelectedValue)
        Dim resDate As Date = dtpDate.Value.Date
        Dim resTime As TimeSpan = dtpTime.Value.TimeOfDay
        Dim guests As Integer = CInt(nudGuests.Value)
        Dim status As String = cmbStatus.Text

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String =
                "UPDATE reservations SET " &
                " customer_id=@custId, table_id=@tableId, reservation_date=@rdate, " &
                " reservation_time=@rtime, number_of_guests=@guests, status=@status, " &
                " updated_at=NOW() " &
                "WHERE reservation_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@custId", customerId)
                cmd.Parameters.AddWithValue("@tableId", tableId)
                cmd.Parameters.AddWithValue("@rdate", resDate)
                cmd.Parameters.AddWithValue("@rtime", resTime)
                cmd.Parameters.AddWithValue("@guests", guests)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Reservation updated.", "Reservations",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadReservations()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error updating reservation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnCancelReservation_Click(sender As Object, e As EventArgs) Handles btnCancelReservation.Click
        If txtReservationID.Text.Trim() = "" Then
            MessageBox.Show("Select a reservation to cancel.", "Reservations",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtReservationID.Text.Trim())

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String = "UPDATE reservations SET status='Cancelled', updated_at=NOW() WHERE reservation_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Reservation cancelled.", "Reservations",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadReservations()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error cancelling reservation", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' =============== GRID & SEARCH =====================

    Private Sub dgvReservations_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReservations.CellClick
        If e.RowIndex < 0 Then Return
        If dgvReservations.CurrentRow Is Nothing Then Return

        Dim row As DataGridViewRow = dgvReservations.Rows(e.RowIndex)

        If row.Cells("reservation_id").Value IsNot Nothing Then
            txtReservationID.Text = row.Cells("reservation_id").Value.ToString()
        End If

        ' Customer combobox: only for admin/staff
        If _role <> "Customer" AndAlso row.Cells("customer_name").Value IsNot Nothing Then
            Dim custName As String = row.Cells("customer_name").Value.ToString()
            For i As Integer = 0 To cmbCustomer.Items.Count - 1
                Dim drv As DataRowView = TryCast(cmbCustomer.Items(i), DataRowView)
                If drv IsNot Nothing AndAlso drv("full_name").ToString() = custName Then
                    cmbCustomer.SelectedIndex = i
                    Exit For
                End If
            Next
        End If

        If row.Cells("table_number").Value IsNot Nothing Then
            Dim tbl As String = row.Cells("table_number").Value.ToString()
            For i As Integer = 0 To cmbTable.Items.Count - 1
                Dim drv As DataRowView = TryCast(cmbTable.Items(i), DataRowView)
                If drv IsNot Nothing AndAlso drv("table_number").ToString() = tbl Then
                    cmbTable.SelectedIndex = i
                    Exit For
                End If
            Next
        End If

        If row.Cells("reservation_date").Value IsNot Nothing Then
            dtpDate.Value = CDate(row.Cells("reservation_date").Value)
        End If
        If row.Cells("reservation_time").Value IsNot Nothing Then
            Dim t As TimeSpan = CType(row.Cells("reservation_time").Value, TimeSpan)
            dtpTime.Value = Date.Today.Add(t)
        End If
        If row.Cells("number_of_guests").Value IsNot Nothing Then
            nudGuests.Value = CDec(row.Cells("number_of_guests").Value)
        End If
        If row.Cells("status").Value IsNot Nothing Then
            cmbStatus.Text = row.Cells("status").Value.ToString()
        End If
    End Sub

    Private Sub btnSearchDate_Click(sender As Object, e As EventArgs) Handles btnSearchDate.Click
        LoadReservations(True)
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        LoadReservations(False)
    End Sub

End Class
