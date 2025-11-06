Imports MySql.Data.MySqlClient

Public Class FormGuestMain
    Private _userId As Integer
    Private _customerId As Integer
    Private _guestName As String

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Private Sub FormGuestMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, Guest!"
        LoadGuestInfo()
        LoadTables()
        LoadMyReservations()
    End Sub

    ' 🧩 Load guest info from customers table
    Private Sub LoadGuestInfo()
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT customer_id, name, phone, email FROM customers WHERE customer_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", _userId)
                Dim rd = cmd.ExecuteReader()
                If rd.Read() Then
                    _customerId = CInt(rd("customer_id"))
                    txtName.Text = rd("name").ToString()
                    txtPhone.Text = rd("phone").ToString()
                    txtEmail.Text = rd("email").ToString()
                Else
                    _customerId = _userId ' fallback just in case
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading guest info: " & ex.Message)
        End Try
    End Sub

    ' 🪑 Load available tables
    Private Sub LoadTables()
        Try
            Using conn = DatabaseConnection.GetConnection()
                Dim da As New MySqlDataAdapter("SELECT table_id, table_number, capacity FROM restaurant_tables WHERE status='available'", conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvTables.DataSource = dt
                cmbTable.DisplayMember = "table_number"
                cmbTable.ValueMember = "table_id"
                cmbTable.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading tables: " & ex.Message)
        End Try
    End Sub

    ' 📅 Load reservations made by this guest
    Private Sub LoadMyReservations()
        Try
            Using conn = DatabaseConnection.GetConnection()
                Dim query As String =
                    "SELECT r.reservation_id, t.table_number, r.reservation_date, r.pax, r.status, r.notes " &
                    "FROM reservations r " &
                    "JOIN customers c ON r.customer_id = c.customer_id " &
                    "JOIN restaurant_tables t ON r.table_id = t.table_id " &
                    "WHERE c.customer_id = @cid " &
                    "ORDER BY r.reservation_date DESC"

                Dim da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@cid", _customerId)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvMyReservations.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading your reservations: " & ex.Message)
        End Try
    End Sub

    ' ➕ Submit new reservation
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()
                Dim cmd As New MySqlCommand(
                    "INSERT INTO reservations (customer_id, table_id, reservation_date, pax, status) VALUES (@cid, @tid, @date, @pax, 'booked')", conn)
                cmd.Parameters.AddWithValue("@cid", _customerId)
                cmd.Parameters.AddWithValue("@tid", cmbTable.SelectedValue)
                cmd.Parameters.AddWithValue("@date", dtpResDate.Value)
                cmd.Parameters.AddWithValue("@pax", numPax.Value)
                cmd.ExecuteNonQuery()
            End Using
            MessageBox.Show("Reservation requested successfully!")
            LoadMyReservations()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' 🚪 Logout
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        FormLogin.Show()
    End Sub
End Class
