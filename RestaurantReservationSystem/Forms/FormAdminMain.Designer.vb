<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblTotalCustomers = New System.Windows.Forms.Label()
        Me.lblTotalReservations = New System.Windows.Forms.Label()
        Me.lblAvailableTables = New System.Windows.Forms.Label()
        Me.lblOccupiedTables = New System.Windows.Forms.Label()
        Me.btnManageReservations = New System.Windows.Forms.Button()
        Me.btnManageCustomers = New System.Windows.Forms.Button()
        Me.btnManageTables = New System.Windows.Forms.Button()
        Me.btnManageUsers = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(399, 108)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(87, 13)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome, Admin"
        '
        'lblTotalCustomers
        '
        Me.lblTotalCustomers.AutoSize = True
        Me.lblTotalCustomers.Location = New System.Drawing.Point(290, 181)
        Me.lblTotalCustomers.Name = "lblTotalCustomers"
        Me.lblTotalCustomers.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalCustomers.TabIndex = 1
        Me.lblTotalCustomers.Text = "0"
        '
        'lblTotalReservations
        '
        Me.lblTotalReservations.AutoSize = True
        Me.lblTotalReservations.Location = New System.Drawing.Point(290, 152)
        Me.lblTotalReservations.Name = "lblTotalReservations"
        Me.lblTotalReservations.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalReservations.TabIndex = 2
        Me.lblTotalReservations.Text = "0"
        '
        'lblAvailableTables
        '
        Me.lblAvailableTables.AutoSize = True
        Me.lblAvailableTables.Location = New System.Drawing.Point(290, 230)
        Me.lblAvailableTables.Name = "lblAvailableTables"
        Me.lblAvailableTables.Size = New System.Drawing.Size(13, 13)
        Me.lblAvailableTables.TabIndex = 4
        Me.lblAvailableTables.Text = "0"
        '
        'lblOccupiedTables
        '
        Me.lblOccupiedTables.AutoSize = True
        Me.lblOccupiedTables.Location = New System.Drawing.Point(290, 206)
        Me.lblOccupiedTables.Name = "lblOccupiedTables"
        Me.lblOccupiedTables.Size = New System.Drawing.Size(13, 13)
        Me.lblOccupiedTables.TabIndex = 5
        Me.lblOccupiedTables.Text = "0"
        '
        'btnManageReservations
        '
        Me.btnManageReservations.Location = New System.Drawing.Point(355, 147)
        Me.btnManageReservations.Name = "btnManageReservations"
        Me.btnManageReservations.Size = New System.Drawing.Size(206, 23)
        Me.btnManageReservations.TabIndex = 6
        Me.btnManageReservations.Text = "Manage Reservations"
        Me.btnManageReservations.UseVisualStyleBackColor = True
        '
        'btnManageCustomers
        '
        Me.btnManageCustomers.Location = New System.Drawing.Point(355, 176)
        Me.btnManageCustomers.Name = "btnManageCustomers"
        Me.btnManageCustomers.Size = New System.Drawing.Size(206, 23)
        Me.btnManageCustomers.TabIndex = 7
        Me.btnManageCustomers.Text = "Manage Customers"
        Me.btnManageCustomers.UseVisualStyleBackColor = True
        '
        'btnManageTables
        '
        Me.btnManageTables.Location = New System.Drawing.Point(355, 200)
        Me.btnManageTables.Name = "btnManageTables"
        Me.btnManageTables.Size = New System.Drawing.Size(206, 23)
        Me.btnManageTables.TabIndex = 8
        Me.btnManageTables.Text = "Manage Tables"
        Me.btnManageTables.UseVisualStyleBackColor = True
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Location = New System.Drawing.Point(355, 229)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(206, 23)
        Me.btnManageUsers.TabIndex = 9
        Me.btnManageUsers.Text = "Manage Users"
        Me.btnManageUsers.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(355, 258)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(206, 23)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(355, 287)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(206, 23)
        Me.btnLogout.TabIndex = 11
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total Reservations:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(201, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Total Customers:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Occupied Tables:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Available Tables:"
        '
        'FormAdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnManageUsers)
        Me.Controls.Add(Me.btnManageTables)
        Me.Controls.Add(Me.btnManageCustomers)
        Me.Controls.Add(Me.btnManageReservations)
        Me.Controls.Add(Me.lblOccupiedTables)
        Me.Controls.Add(Me.lblAvailableTables)
        Me.Controls.Add(Me.lblTotalReservations)
        Me.Controls.Add(Me.lblTotalCustomers)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "FormAdminMain"
        Me.Text = "FormAdminMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblTotalCustomers As Label
    Friend WithEvents lblTotalReservations As Label
    Friend WithEvents lblAvailableTables As Label
    Friend WithEvents lblOccupiedTables As Label
    Friend WithEvents btnManageReservations As Button
    Friend WithEvents btnManageCustomers As Button
    Friend WithEvents btnManageTables As Button
    Friend WithEvents btnManageUsers As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
