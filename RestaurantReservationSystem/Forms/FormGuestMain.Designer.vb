<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGuestMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.grpView = New System.Windows.Forms.GroupBox()
        Me.dgvTables = New System.Windows.Forms.DataGridView()
        Me.grpRequest = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpResDate = New System.Windows.Forms.DateTimePicker()
        Me.numPax = New System.Windows.Forms.NumericUpDown()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.dgvMyReservations = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMyReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Guest Dashboard"
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(255, 35)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(86, 13)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome Guest!"
        '
        'grpView
        '
        Me.grpView.Location = New System.Drawing.Point(500, 248)
        Me.grpView.Name = "grpView"
        Me.grpView.Size = New System.Drawing.Size(204, 160)
        Me.grpView.TabIndex = 2
        Me.grpView.TabStop = False
        Me.grpView.Text = "Available Tables"
        '
        'dgvTables
        '
        Me.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTables.Location = New System.Drawing.Point(34, 278)
        Me.dgvTables.Name = "dgvTables"
        Me.dgvTables.Size = New System.Drawing.Size(446, 175)
        Me.dgvTables.TabIndex = 3
        '
        'grpRequest
        '
        Me.grpRequest.Location = New System.Drawing.Point(500, 95)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(123, 137)
        Me.grpRequest.TabIndex = 3
        Me.grpRequest.TabStop = False
        Me.grpRequest.Text = "Request Reservation"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(52, 61)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(52, 95)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 5
        Me.lblPhone.Text = "Phone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(52, 137)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(97, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 7
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 137)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 8
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(96, 88)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Table:"
        '
        'cmbTable
        '
        Me.cmbTable.FormattingEnabled = True
        Me.cmbTable.Location = New System.Drawing.Point(99, 160)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(121, 21)
        Me.cmbTable.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date & Time:"
        '
        'dtpResDate
        '
        Me.dtpResDate.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpResDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpResDate.Location = New System.Drawing.Point(124, 196)
        Me.dtpResDate.Name = "dtpResDate"
        Me.dtpResDate.Size = New System.Drawing.Size(105, 20)
        Me.dtpResDate.TabIndex = 12
        '
        'numPax
        '
        Me.numPax.Location = New System.Drawing.Point(97, 222)
        Me.numPax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPax.Name = "numPax"
        Me.numPax.Size = New System.Drawing.Size(120, 20)
        Me.numPax.TabIndex = 13
        Me.numPax.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(292, 133)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 14
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(293, 164)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'dgvMyReservations
        '
        Me.dgvMyReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMyReservations.Location = New System.Drawing.Point(34, 461)
        Me.dgvMyReservations.Name = "dgvMyReservations"
        Me.dgvMyReservations.Size = New System.Drawing.Size(446, 142)
        Me.dgvMyReservations.TabIndex = 16
        '
        'FormGuestMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 648)
        Me.Controls.Add(Me.dgvMyReservations)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.numPax)
        Me.Controls.Add(Me.dtpResDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.grpRequest)
        Me.Controls.Add(Me.dgvTables)
        Me.Controls.Add(Me.grpView)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormGuestMain"
        Me.Text = "FormGuestMain"
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMyReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents grpView As GroupBox
    Friend WithEvents dgvTables As DataGridView
    Friend WithEvents grpRequest As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbTable As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpResDate As DateTimePicker
    Friend WithEvents numPax As NumericUpDown
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvMyReservations As DataGridView
End Class
