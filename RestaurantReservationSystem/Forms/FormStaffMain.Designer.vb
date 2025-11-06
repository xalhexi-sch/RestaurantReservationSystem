<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStaffMain
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnMarkSeated = New System.Windows.Forms.Button()
        Me.btnMarkCompleted = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.dgvStaffReservations = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Customer = New System.Windows.Forms.Label()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.numPax = New System.Windows.Forms.NumericUpDown()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvStaffReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(286, 74)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(94, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = """Staff Dashboard"""
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(299, 135)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(55, 13)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Welcome:"
        '
        'btnMarkSeated
        '
        Me.btnMarkSeated.Location = New System.Drawing.Point(494, 60)
        Me.btnMarkSeated.Name = "btnMarkSeated"
        Me.btnMarkSeated.Size = New System.Drawing.Size(112, 23)
        Me.btnMarkSeated.TabIndex = 3
        Me.btnMarkSeated.Text = "Mark as Seated"
        Me.btnMarkSeated.UseVisualStyleBackColor = True
        '
        'btnMarkCompleted
        '
        Me.btnMarkCompleted.Location = New System.Drawing.Point(494, 89)
        Me.btnMarkCompleted.Name = "btnMarkCompleted"
        Me.btnMarkCompleted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMarkCompleted.Size = New System.Drawing.Size(112, 23)
        Me.btnMarkCompleted.TabIndex = 4
        Me.btnMarkCompleted.Text = "Mark as Completed"
        Me.btnMarkCompleted.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(494, 135)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(112, 23)
        Me.btnLogout.TabIndex = 5
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'dgvStaffReservations
        '
        Me.dgvStaffReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaffReservations.Location = New System.Drawing.Point(12, 247)
        Me.dgvStaffReservations.Name = "dgvStaffReservations"
        Me.dgvStaffReservations.Size = New System.Drawing.Size(800, 191)
        Me.dgvStaffReservations.TabIndex = 6
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(494, 112)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(112, 23)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(663, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 8
        Me.txtSearch.Tag = ""
        '
        'Customer
        '
        Me.Customer.AutoSize = True
        Me.Customer.Location = New System.Drawing.Point(42, 74)
        Me.Customer.Name = "Customer"
        Me.Customer.Size = New System.Drawing.Size(51, 13)
        Me.Customer.TabIndex = 10
        Me.Customer.Text = "Customer"
        '
        'txtCustomer
        '
        Me.txtCustomer.Location = New System.Drawing.Point(100, 74)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomer.TabIndex = 11
        '
        'cmbTable
        '
        Me.cmbTable.FormattingEnabled = True
        Me.cmbTable.Location = New System.Drawing.Point(79, 107)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(121, 21)
        Me.cmbTable.TabIndex = 12
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(61, 134)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 13
        '
        'numPax
        '
        Me.numPax.Location = New System.Drawing.Point(61, 161)
        Me.numPax.Name = "numPax"
        Me.numPax.Size = New System.Drawing.Size(120, 20)
        Me.numPax.TabIndex = 14
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(45, 201)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cmbStatus.TabIndex = 15
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(254, 201)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(100, 20)
        Me.txtNotes.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(450, 201)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(557, 201)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(675, 38)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 19
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'FormStaffMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 450)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.numPax)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.cmbTable)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.Customer)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvStaffReservations)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnMarkCompleted)
        Me.Controls.Add(Me.btnMarkSeated)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FormStaffMain"
        Me.Text = "FormStaffMain"
        CType(Me.dgvStaffReservations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPax, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnMarkSeated As Button
    Friend WithEvents btnMarkCompleted As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents dgvStaffReservations As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Customer As Label
    Friend WithEvents txtCustomer As TextBox
    Friend WithEvents cmbTable As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents numPax As NumericUpDown
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
End Class
