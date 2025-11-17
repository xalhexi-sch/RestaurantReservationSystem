<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegisterCustomer
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.Location = New System.Drawing.Point(65, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(227, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Create Guest Account"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Location = New System.Drawing.Point(30, 70)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(63, 15)
        Me.lblFullName.TabIndex = 1
        Me.lblFullName.Text = "Full Name:"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(130, 67)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(200, 23)
        Me.txtFullName.TabIndex = 2
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(30, 100)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(53, 15)
        Me.lblContact.TabIndex = 3
        Me.lblContact.Text = "Contact:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(130, 97)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(200, 23)
        Me.txtContact.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(30, 130)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(39, 15)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(130, 127)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 23)
        Me.txtEmail.TabIndex = 6
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(30, 170)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(63, 15)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(130, 167)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(200, 23)
        Me.txtUsername.TabIndex = 8
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(30, 200)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(60, 15)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(130, 197)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 23)
        Me.txtPassword.TabIndex = 10
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Location = New System.Drawing.Point(30, 230)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(99, 15)
        Me.lblConfirmPassword.TabIndex = 11
        Me.lblConfirmPassword.Text = "Confirm Pwd.     :"
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(130, 227)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(200, 23)
        Me.txtConfirmPassword.TabIndex = 12
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(130, 265)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(90, 30)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(240, 265)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 30)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmRegisterCustomer
        '
        Me.AcceptButton = Me.btnRegister
        Me.CancelButton = Me.btnCancel
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 321)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtFullName)
        Me.Controls.Add(Me.lblFullName)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegisterCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register - Restaurant Reservation System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblFullName As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class
