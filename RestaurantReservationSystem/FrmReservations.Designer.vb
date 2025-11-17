<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReservations
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpReservationDetails = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.nudGuests = New System.Windows.Forms.NumericUpDown()
        Me.lblGuests = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.lblTable = New System.Windows.Forms.Label()
        Me.btnNewCustomerFromRes = New System.Windows.Forms.Button()
        Me.cmbCustomer = New System.Windows.Forms.ComboBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.txtReservationID = New System.Windows.Forms.TextBox()
        Me.lblReservationID = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCancelReservation = New System.Windows.Forms.Button()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.btnSearchDate = New System.Windows.Forms.Button()
        Me.dtpSearchDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSearchDate = New System.Windows.Forms.Label()
        Me.dgvReservations = New System.Windows.Forms.DataGridView()
        Me.grpReservationDetails.SuspendLayout()
        CType(Me.nudGuests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpReservationDetails
        '
        Me.grpReservationDetails.Controls.Add(Me.cmbStatus)
        Me.grpReservationDetails.Controls.Add(Me.lblStatus)
        Me.grpReservationDetails.Controls.Add(Me.nudGuests)
        Me.grpReservationDetails.Controls.Add(Me.lblGuests)
        Me.grpReservationDetails.Controls.Add(Me.dtpTime)
        Me.grpReservationDetails.Controls.Add(Me.lblTime)
        Me.grpReservationDetails.Controls.Add(Me.dtpDate)
        Me.grpReservationDetails.Controls.Add(Me.lblDate)
        Me.grpReservationDetails.Controls.Add(Me.cmbTable)
        Me.grpReservationDetails.Controls.Add(Me.lblTable)
        Me.grpReservationDetails.Controls.Add(Me.btnNewCustomerFromRes)
        Me.grpReservationDetails.Controls.Add(Me.cmbCustomer)
        Me.grpReservationDetails.Controls.Add(Me.lblCustomer)
        Me.grpReservationDetails.Controls.Add(Me.txtReservationID)
        Me.grpReservationDetails.Controls.Add(Me.lblReservationID)
        Me.grpReservationDetails.Location = New System.Drawing.Point(17, 17)
        Me.grpReservationDetails.Name = "grpReservationDetails"
        Me.grpReservationDetails.Size = New System.Drawing.Size(369, 243)
        Me.grpReservationDetails.TabIndex = 0
        Me.grpReservationDetails.TabStop = False
        Me.grpReservationDetails.Text = "Reservation Details"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(120, 199)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(146, 21)
        Me.cmbStatus.TabIndex = 14
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(21, 203)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = "Status:"
        '
        'nudGuests
        '
        Me.nudGuests.Location = New System.Drawing.Point(120, 173)
        Me.nudGuests.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudGuests.Name = "nudGuests"
        Me.nudGuests.Size = New System.Drawing.Size(69, 20)
        Me.nudGuests.TabIndex = 12
        Me.nudGuests.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblGuests
        '
        Me.lblGuests.AutoSize = True
        Me.lblGuests.Location = New System.Drawing.Point(21, 177)
        Me.lblGuests.Name = "lblGuests"
        Me.lblGuests.Size = New System.Drawing.Size(43, 13)
        Me.lblGuests.TabIndex = 11
        Me.lblGuests.Text = "Guests:"
        '
        'dtpTime
        '
        Me.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpTime.Location = New System.Drawing.Point(120, 147)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.ShowUpDown = True
        Me.dtpTime.Size = New System.Drawing.Size(103, 20)
        Me.dtpTime.TabIndex = 10
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(21, 151)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 9
        Me.lblTime.Text = "Time:"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(120, 121)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(103, 20)
        Me.dtpDate.TabIndex = 8
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(21, 125)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 7
        Me.lblDate.Text = "Date:"
        '
        'cmbTable
        '
        Me.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTable.FormattingEnabled = True
        Me.cmbTable.Location = New System.Drawing.Point(120, 95)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(146, 21)
        Me.cmbTable.TabIndex = 6
        '
        'lblTable
        '
        Me.lblTable.AutoSize = True
        Me.lblTable.Location = New System.Drawing.Point(21, 99)
        Me.lblTable.Name = "lblTable"
        Me.lblTable.Size = New System.Drawing.Size(37, 13)
        Me.lblTable.TabIndex = 5
        Me.lblTable.Text = "Table:"
        '
        'btnNewCustomerFromRes
        '
        Me.btnNewCustomerFromRes.Location = New System.Drawing.Point(274, 68)
        Me.btnNewCustomerFromRes.Name = "btnNewCustomerFromRes"
        Me.btnNewCustomerFromRes.Size = New System.Drawing.Size(64, 20)
        Me.btnNewCustomerFromRes.TabIndex = 4
        Me.btnNewCustomerFromRes.Text = "New..."
        Me.btnNewCustomerFromRes.UseVisualStyleBackColor = True
        '
        'cmbCustomer
        '
        Me.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomer.FormattingEnabled = True
        Me.cmbCustomer.Location = New System.Drawing.Point(120, 68)
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.Size = New System.Drawing.Size(146, 21)
        Me.cmbCustomer.TabIndex = 3
        '
        'lblCustomer
        '
        Me.lblCustomer.AutoSize = True
        Me.lblCustomer.Location = New System.Drawing.Point(21, 71)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(54, 13)
        Me.lblCustomer.TabIndex = 2
        Me.lblCustomer.Text = "Customer:"
        '
        'txtReservationID
        '
        Me.txtReservationID.Location = New System.Drawing.Point(120, 39)
        Me.txtReservationID.Name = "txtReservationID"
        Me.txtReservationID.ReadOnly = True
        Me.txtReservationID.Size = New System.Drawing.Size(86, 20)
        Me.txtReservationID.TabIndex = 1
        '
        'lblReservationID
        '
        Me.lblReservationID.AutoSize = True
        Me.lblReservationID.Location = New System.Drawing.Point(21, 42)
        Me.lblReservationID.Name = "lblReservationID"
        Me.lblReservationID.Size = New System.Drawing.Size(81, 13)
        Me.lblReservationID.TabIndex = 0
        Me.lblReservationID.Text = "Reservation ID:"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(17, 277)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 26)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(103, 277)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 26)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(189, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(77, 26)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnCancelReservation
        '
        Me.btnCancelReservation.Location = New System.Drawing.Point(274, 277)
        Me.btnCancelReservation.Name = "btnCancelReservation"
        Me.btnCancelReservation.Size = New System.Drawing.Size(111, 26)
        Me.btnCancelReservation.TabIndex = 4
        Me.btnCancelReservation.Text = "Cancel Reservation"
        Me.btnCancelReservation.UseVisualStyleBackColor = True
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.btnShowAll)
        Me.grpSearch.Controls.Add(Me.btnSearchDate)
        Me.grpSearch.Controls.Add(Me.dtpSearchDate)
        Me.grpSearch.Controls.Add(Me.lblSearchDate)
        Me.grpSearch.Location = New System.Drawing.Point(403, 17)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(429, 69)
        Me.grpSearch.TabIndex = 5
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(291, 26)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(77, 26)
        Me.btnShowAll.TabIndex = 3
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'btnSearchDate
        '
        Me.btnSearchDate.Location = New System.Drawing.Point(197, 26)
        Me.btnSearchDate.Name = "btnSearchDate"
        Me.btnSearchDate.Size = New System.Drawing.Size(77, 26)
        Me.btnSearchDate.TabIndex = 2
        Me.btnSearchDate.Text = "Search Date"
        Me.btnSearchDate.UseVisualStyleBackColor = True
        '
        'dtpSearchDate
        '
        Me.dtpSearchDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSearchDate.Location = New System.Drawing.Point(60, 30)
        Me.dtpSearchDate.Name = "dtpSearchDate"
        Me.dtpSearchDate.Size = New System.Drawing.Size(121, 20)
        Me.dtpSearchDate.TabIndex = 1
        '
        'lblSearchDate
        '
        Me.lblSearchDate.AutoSize = True
        Me.lblSearchDate.Location = New System.Drawing.Point(17, 34)
        Me.lblSearchDate.Name = "lblSearchDate"
        Me.lblSearchDate.Size = New System.Drawing.Size(33, 13)
        Me.lblSearchDate.TabIndex = 0
        Me.lblSearchDate.Text = "Date:"
        '
        'dgvReservations
        '
        Me.dgvReservations.AllowUserToAddRows = False
        Me.dgvReservations.AllowUserToDeleteRows = False
        Me.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReservations.Location = New System.Drawing.Point(403, 104)
        Me.dgvReservations.MultiSelect = False
        Me.dgvReservations.Name = "dgvReservations"
        Me.dgvReservations.ReadOnly = True
        Me.dgvReservations.RowTemplate.Height = 25
        Me.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReservations.Size = New System.Drawing.Size(429, 312)
        Me.dgvReservations.TabIndex = 6
        '
        'FrmReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 451)
        Me.Controls.Add(Me.dgvReservations)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.btnCancelReservation)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.grpReservationDetails)
        Me.Name = "FrmReservations"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservations"
        Me.grpReservationDetails.ResumeLayout(False)
        Me.grpReservationDetails.PerformLayout()
        CType(Me.nudGuests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.dgvReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpReservationDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents nudGuests As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGuests As System.Windows.Forms.Label
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents cmbTable As System.Windows.Forms.ComboBox
    Friend WithEvents lblTable As System.Windows.Forms.Label
    Friend WithEvents btnNewCustomerFromRes As System.Windows.Forms.Button
    Friend WithEvents cmbCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents lblCustomer As System.Windows.Forms.Label
    Friend WithEvents txtReservationID As System.Windows.Forms.TextBox
    Friend WithEvents lblReservationID As System.Windows.Forms.Label
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnCancelReservation As System.Windows.Forms.Button
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents btnSearchDate As System.Windows.Forms.Button
    Friend WithEvents dtpSearchDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSearchDate As System.Windows.Forms.Label
    Friend WithEvents dgvReservations As System.Windows.Forms.DataGridView
End Class
