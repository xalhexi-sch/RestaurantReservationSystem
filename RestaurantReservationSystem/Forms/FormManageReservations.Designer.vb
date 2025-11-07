<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageReservations
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numPax = New System.Windows.Forms.NumericUpDown()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.dgvReservations = New System.Windows.Forms.DataGridView()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.cmbStaff = New System.Windows.Forms.ComboBox()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(604, 156)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(637, 115)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(637, 84)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(556, 115)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(556, 84)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(43, 84)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(51, 13)
        Me.lblCustomer.TabIndex = 20
        Me.lblCustomer.Text = "Customer"
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(43, 110)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(34, 13)
        Me.lblTable.TabIndex = 21
        Me.lblTable.Text = "Table"
        '
        'cmbTable
        '
        Me.cmbTable.FormattingEnabled = True
        Me.cmbTable.Location = New System.Drawing.Point(101, 107)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(121, 21)
        Me.cmbTable.TabIndex = 23
        '
        'cmbCustomer
        '
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(101, 76)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(121, 21)
        Me.cmbCustomer.TabIndex = 24
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(114, 192)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(107, 20)
        Me.dtpDate.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Pax (People):"
        '
        'numPax
        '
        Me.numPax.Location = New System.Drawing.Point(101, 166)
        Me.numPax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPax.Name = "numPax"
        Me.numPax.Size = New System.Drawing.Size(120, 20)
        Me.numPax.TabIndex = 27
        Me.numPax.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(57, 234)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(38, 13)
        Me.lblNotes.TabIndex = 28
        Me.lblNotes.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(101, 231)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(100, 20)
        Me.txtNotes.TabIndex = 29
        '
        'dgvReservations
        '
        Me.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservations.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvReservations.Location = New System.Drawing.Point(0, 318)
        Me.dgvReservations.Name = "dgvReservations"
        Me.dgvReservations.Size = New System.Drawing.Size(939, 286)
        Me.dgvReservations.TabIndex = 30
        '
        'lblStaff
        '
        Me.lblStaff.AutoSize = True
        Me.lblStaff.Location = New System.Drawing.Point(36, 133)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(29, 13)
        Me.lblStaff.TabIndex = 31
        Me.lblStaff.Text = "Staff"
        '
        'cmbStaff
        '
        Me.cmbStaff.FormattingEnabled = True
        Me.cmbStaff.Location = New System.Drawing.Point(101, 133)
        Me.cmbStaff.Name = "cmbStaff"
        Me.cmbStaff.Size = New System.Drawing.Size(121, 21)
        Me.cmbStaff.TabIndex = 32
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnApprove.Location = New System.Drawing.Point(340, 84)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(183, 23)
        Me.btnApprove.TabIndex = 33
        Me.btnApprove.Text = "Approve Reservation"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReject.Location = New System.Drawing.Point(340, 115)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(183, 23)
        Me.btnReject.TabIndex = 34
        Me.btnReject.Text = "Reject Reservation"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'FormManageReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 604)
        Me.Controls.Add(Me.btnReject)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.cmbStaff)
        Me.Controls.Add(Me.lblStaff)
        Me.Controls.Add(Me.dgvReservations)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.numPax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.cmbCustomer)
        Me.Controls.Add(Me.cmbTable)
        Me.Controls.Add(Me.lblTable)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "FormManageReservations"
        Me.Text = "FormManageReservations"
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblTable As Label
    Friend WithEvents cmbTable As ComboBox
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents numPax As NumericUpDown
    Friend WithEvents lblNotes As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents dgvReservations As DataGridView
    Friend WithEvents lblStaff As Label
    Friend WithEvents cmbStaff As ComboBox
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnReject As Button
End Class
