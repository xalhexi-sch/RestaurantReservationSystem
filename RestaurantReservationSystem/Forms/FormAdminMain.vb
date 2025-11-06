Imports MySql.Data.MySqlClient

Public Class FormAdminMain
    Private _userId As Integer

    Public Sub New(userId As Integer)
        InitializeComponent()
        _userId = userId
    End Sub

    Private Sub FormAdminMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, Admin"
        LoadDashboardData()
    End Sub

    ' --- Load summary counts ---
    Private Sub LoadDashboardData()
        Try
            Using conn = DatabaseConnection.GetConnection()
                conn.Open()

                ' Total customers
                Dim cmdCustomers As New MySqlCommand("SELECT COUNT(*) FROM customers", conn)
                lblTotalCustomers.Text = cmdCustomers.ExecuteScalar().ToString()

                ' Total reservations
                Dim cmdReservations As New MySqlCommand("SELECT COUNT(*) FROM reservations", conn)
                lblTotalReservations.Text = cmdReservations.ExecuteScalar().ToString()

                ' Available tables
                Dim cmdAvailable As New MySqlCommand("SELECT COUNT(*) FROM restaurant_tables WHERE status='available'", conn)
                lblAvailableTables.Text = cmdAvailable.ExecuteScalar().ToString()

                ' Occupied tables
                Dim cmdOccupied As New MySqlCommand("SELECT COUNT(*) FROM restaurant_tables WHERE status='occupied'", conn)
                lblOccupiedTables.Text = cmdOccupied.ExecuteScalar().ToString()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading dashboard: " & ex.Message)
        End Try
    End Sub

    ' --- Navigation buttons ---
    Private Sub btnManageReservations_Click(sender As Object, e As EventArgs) Handles btnManageReservations.Click
        Dim f As New FormManageReservations()
        f.ShowDialog()
    End Sub

    Private Sub btnManageCustomers_Click(sender As Object, e As EventArgs) Handles btnManageCustomers.Click
        Dim f As New FormManageCustomers()
        f.ShowDialog()
    End Sub

    Private Sub btnManageTables_Click(sender As Object, e As EventArgs) Handles btnManageTables.Click
        Dim f As New FormManageTables()
        f.ShowDialog()
    End Sub

    Private Sub btnManageUsers_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Dim f As New FormManageUsers()
        f.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDashboardData()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs)
        Me.Close()
        FormLogin.Show()
    End Sub
End Class
