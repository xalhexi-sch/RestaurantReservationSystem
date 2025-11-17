Public Class FrmMain
    Private _userId As Integer
    Private _customerId As Integer        ' 0 = not a customer account
    Private _fullName As String
    Private _role As String

    Private Sub OpenChild(child As Form)
        ' Close any existing MDI children
        For Each f As Form In Me.MdiChildren
            f.Close()
        Next

        child.MdiParent = Me
        child.WindowState = FormWindowState.Maximized
        child.Show()
    End Sub

    ' Designer uses this parameterless constructor
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Login form uses this one to pass info
    Public Sub New(userId As Integer, fullName As String, role As String, customerId As Integer)
        Me.New()
        _userId = userId
        _fullName = fullName
        _role = role
        _customerId = customerId
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Theme.ApplyTheme(Me)
        Catch ex As Exception
        End Try

        Me.BackColor = Color.WhiteSmoke

        ' Show user info
        If Not String.IsNullOrEmpty(_fullName) Then
            lblUser.Text = "Logged in as: " & _fullName
        Else
            lblUser.Text = "Logged in as: (design time)"
        End If

        If Not String.IsNullOrEmpty(_role) Then
            lblRole.Text = "Role: " & _role
        Else
            lblRole.Text = "Role: (design time)"
        End If

        ' Role-based permissions
        If _role = "Staff" Then
            ' Staff cannot manage users
            mnuUsers.Enabled = False

        ElseIf _role = "Customer" Then
            ' Customers: NO Maintenance menu at all
            mnuMaintenance.Visible = False
            ' (optionally hide File->Exit/Logout if you like, but usually keep them)

            ' Directly open their reservations screen
            OpenChild(New FrmReservations(_userId, _customerId, _fullName, _role))
        End If
    End Sub

    ' === Menu Handlers ===

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub

    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Dim login As New FrmLogin()
        login.Show()
        Me.Close()
    End Sub

    Private Sub mnuUsers_Click(sender As Object, e As EventArgs) Handles mnuUsers.Click
        OpenChild(New FrmUsers())
    End Sub

    Private Sub mnuCustomers_Click(sender As Object, e As EventArgs) Handles mnuCustomers.Click
        OpenChild(New FrmCustomers())
    End Sub

    Private Sub mnuTables_Click(sender As Object, e As EventArgs) Handles mnuTables.Click
        OpenChild(New FrmTables())
    End Sub

    Private Sub mnuReservations_Click(sender As Object, e As EventArgs) Handles mnuReservations.Click
        ' For Admin/Staff: generic reservations
        ' For Customer: open with their context
        If _role = "Customer" Then
            OpenChild(New FrmReservations(_userId, _customerId, _fullName, _role))
        Else
            OpenChild(New FrmReservations(_userId, _customerId, _fullName, _role))
        End If
    End Sub

End Class
