<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsers
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
        Me.grpUserDetails = New System.Windows.Forms.GroupBox()
        Me.cmbUserRole = New System.Windows.Forms.ComboBox()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.btnNewUser = New System.Windows.Forms.Button()
        Me.btnSaveUser = New System.Windows.Forms.Button()
        Me.btnUpdateUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.grpUserDetails.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpUserDetails
        '
        Me.grpUserDetails.Controls.Add(Me.cmbUserRole)
        Me.grpUserDetails.Controls.Add(Me.lblUserRole)
        Me.grpUserDetails.Controls.Add(Me.txtPassword)
        Me.grpUserDetails.Controls.Add(Me.lblPassword)
        Me.grpUserDetails.Controls.Add(Me.txtUsername)
        Me.grpUserDetails.Controls.Add(Me.lblUsername)
        Me.grpUserDetails.Controls.Add(Me.txtFullName)
        Me.grpUserDetails.Controls.Add(Me.lblFullName)
        Me.grpUserDetails.Controls.Add(Me.txtUserID)
        Me.grpUserDetails.Controls.Add(Me.lblUserID)
        Me.grpUserDetails.Location = New System.Drawing.Point(10, 10)
        Me.grpUserDetails.Name = "grpUserDetails"
        Me.grpUserDetails.Size = New System.Drawing.Size(309, 191)
        Me.grpUserDetails.TabIndex = 0
        Me.grpUserDetails.TabStop = False
        Me.grpUserDetails.Text = "User Details"
        '
        'cmbUserRole
        '
        Me.cmbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserRole.FormattingEnabled = True
        Me.cmbUserRole.Location = New System.Drawing.Point(96, 139)
        Me.cmbUserRole.Name = "cmbUserRole"
        Me.cmbUserRole.Size = New System.Drawing.Size(172, 21)
        Me.cmbUserRole.TabIndex = 9
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Location = New System.Drawing.Point(17, 141)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(32, 13)
        Me.lblUserRole.TabIndex = 8
        Me.lblUserRole.Text = "Role:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(96, 113)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(172, 20)
        Me.txtPassword.TabIndex = 7
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(17, 115)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(96, 87)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 20)
        Me.txtUsername.TabIndex = 5
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(17, 89)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(58, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username:"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(96, 61)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(172, 20)
        Me.txtFullName.TabIndex = 3
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(17, 63)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(57, 13)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "Full Name:"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(96, 35)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(69, 20)
        Me.txtUserID.TabIndex = 1
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(17, 37)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(21, 13)
        Me.lblUserID.TabIndex = 0
        Me.lblUserID.Text = "ID:"
        '
        'btnNewUser
        '
        Me.btnNewUser.Location = New System.Drawing.Point(10, 212)
        Me.btnNewUser.Name = "btnNewUser"
        Me.btnNewUser.Size = New System.Drawing.Size(69, 26)
        Me.btnNewUser.TabIndex = 1
        Me.btnNewUser.Text = "New"
        Me.btnNewUser.UseVisualStyleBackColor = True
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Location = New System.Drawing.Point(84, 212)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(69, 26)
        Me.btnSaveUser.TabIndex = 2
        Me.btnSaveUser.Text = "Save"
        Me.btnSaveUser.UseVisualStyleBackColor = True
        '
        'btnUpdateUser
        '
        Me.btnUpdateUser.Location = New System.Drawing.Point(158, 212)
        Me.btnUpdateUser.Name = "btnUpdateUser"
        Me.btnUpdateUser.Size = New System.Drawing.Size(69, 26)
        Me.btnUpdateUser.TabIndex = 3
        Me.btnUpdateUser.Text = "Update"
        Me.btnUpdateUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Location = New System.Drawing.Point(231, 212)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(69, 26)
        Me.btnDeleteUser.TabIndex = 4
        Me.btnDeleteUser.Text = "Delete"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'dgvUsers
        '
        Me.dgvUsers.AllowUserToAddRows = False
        Me.dgvUsers.AllowUserToDeleteRows = False
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(334, 10)
        Me.dgvUsers.MultiSelect = False
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.ReadOnly = True
        Me.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsers.Size = New System.Drawing.Size(369, 228)
        Me.dgvUsers.TabIndex = 5
        '
        'FrmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 252)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnUpdateUser)
        Me.Controls.Add(Me.btnSaveUser)
        Me.Controls.Add(Me.btnNewUser)
        Me.Controls.Add(Me.grpUserDetails)
        Me.Name = "FrmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Management"
        Me.grpUserDetails.ResumeLayout(False)
        Me.grpUserDetails.PerformLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpUserDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUserRole As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserRole As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents btnNewUser As System.Windows.Forms.Button
    Friend WithEvents btnSaveUser As System.Windows.Forms.Button
    Friend WithEvents btnUpdateUser As System.Windows.Forms.Button
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
End Class
