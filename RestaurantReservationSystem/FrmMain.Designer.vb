<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.menuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMaintenance = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTables = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTransactions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReservations = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusMain = New System.Windows.Forms.StatusStrip()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menuMain.SuspendLayout()
        Me.statusMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuMain
        '
        Me.menuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuMaintenance, Me.mnuTransactions})
        Me.menuMain.Location = New System.Drawing.Point(0, 0)
        Me.menuMain.Name = "menuMain"
        Me.menuMain.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.menuMain.Size = New System.Drawing.Size(843, 24)
        Me.menuMain.TabIndex = 0
        Me.menuMain.Text = "menuMain"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(180, 22)
        Me.mnuLogout.Text = "Logout"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuMaintenance
        '
        Me.mnuMaintenance.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUsers, Me.mnuCustomers, Me.mnuTables})
        Me.mnuMaintenance.Name = "mnuMaintenance"
        Me.mnuMaintenance.Size = New System.Drawing.Size(88, 20)
        Me.mnuMaintenance.Text = "Maintenance"
        '
        'mnuUsers
        '
        Me.mnuUsers.Name = "mnuUsers"
        Me.mnuUsers.Size = New System.Drawing.Size(131, 22)
        Me.mnuUsers.Text = "Users"
        '
        'mnuCustomers
        '
        Me.mnuCustomers.Name = "mnuCustomers"
        Me.mnuCustomers.Size = New System.Drawing.Size(131, 22)
        Me.mnuCustomers.Text = "Customers"
        '
        'mnuTables
        '
        Me.mnuTables.Name = "mnuTables"
        Me.mnuTables.Size = New System.Drawing.Size(131, 22)
        Me.mnuTables.Text = "Tables"
        '
        'mnuTransactions
        '
        Me.mnuTransactions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReservations})
        Me.mnuTransactions.Name = "mnuTransactions"
        Me.mnuTransactions.Size = New System.Drawing.Size(85, 20)
        Me.mnuTransactions.Text = "Transactions"
        '
        'mnuReservations
        '
        Me.mnuReservations.Name = "mnuReservations"
        Me.mnuReservations.Size = New System.Drawing.Size(180, 22)
        Me.mnuReservations.Text = "Reservations"
        '
        'statusMain
        '
        Me.statusMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUser, Me.lblRole})
        Me.statusMain.Location = New System.Drawing.Point(0, 465)
        Me.statusMain.Name = "statusMain"
        Me.statusMain.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.statusMain.Size = New System.Drawing.Size(843, 22)
        Me.statusMain.TabIndex = 1
        Me.statusMain.Text = "statusMain"
        '
        'lblUser
        '
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(80, 17)
        Me.lblUser.Text = "Logged in as: "
        '
        'lblRole
        '
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(36, 17)
        Me.lblRole.Text = "Role: "
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 487)
        Me.Controls.Add(Me.statusMain)
        Me.Controls.Add(Me.menuMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menuMain
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restaurant Reservation System"
        Me.menuMain.ResumeLayout(False)
        Me.menuMain.PerformLayout()
        Me.statusMain.ResumeLayout(False)
        Me.statusMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMaintenance As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTables As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTransactions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReservations As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents statusMain As System.Windows.Forms.StatusStrip
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblRole As System.Windows.Forms.ToolStripStatusLabel
End Class
