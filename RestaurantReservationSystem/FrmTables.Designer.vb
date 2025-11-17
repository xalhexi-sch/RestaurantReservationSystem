<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTables
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
        Me.grpTableDetails = New System.Windows.Forms.GroupBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.numCapacity = New System.Windows.Forms.NumericUpDown()
        Me.lblCapacity = New System.Windows.Forms.Label()
        Me.txtTableNumber = New System.Windows.Forms.TextBox()
        Me.lblTableNumber = New System.Windows.Forms.Label()
        Me.txtTableID = New System.Windows.Forms.TextBox()
        Me.lblTableID = New System.Windows.Forms.Label()
        Me.btnNewTable = New System.Windows.Forms.Button()
        Me.btnSaveTable = New System.Windows.Forms.Button()
        Me.btnUpdateTable = New System.Windows.Forms.Button()
        Me.btnDeleteTable = New System.Windows.Forms.Button()
        Me.dgvTables = New System.Windows.Forms.DataGridView()
        Me.grpTableDetails.SuspendLayout()
        CType(Me.numCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTableDetails
        '
        Me.grpTableDetails.Controls.Add(Me.cmbStatus)
        Me.grpTableDetails.Controls.Add(Me.lblStatus)
        Me.grpTableDetails.Controls.Add(Me.numCapacity)
        Me.grpTableDetails.Controls.Add(Me.lblCapacity)
        Me.grpTableDetails.Controls.Add(Me.txtTableNumber)
        Me.grpTableDetails.Controls.Add(Me.lblTableNumber)
        Me.grpTableDetails.Controls.Add(Me.txtTableID)
        Me.grpTableDetails.Controls.Add(Me.lblTableID)
        Me.grpTableDetails.Location = New System.Drawing.Point(10, 10)
        Me.grpTableDetails.Name = "grpTableDetails"
        Me.grpTableDetails.Size = New System.Drawing.Size(309, 156)
        Me.grpTableDetails.TabIndex = 0
        Me.grpTableDetails.TabStop = False
        Me.grpTableDetails.Text = "Table Details"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Available", "Reserved", "Inactive"})
        Me.cmbStatus.Location = New System.Drawing.Point(96, 113)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(172, 21)
        Me.cmbStatus.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(17, 115)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status:"
        '
        'numCapacity
        '
        Me.numCapacity.Location = New System.Drawing.Point(96, 87)
        Me.numCapacity.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.numCapacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCapacity.Name = "numCapacity"
        Me.numCapacity.Size = New System.Drawing.Size(69, 20)
        Me.numCapacity.TabIndex = 5
        Me.numCapacity.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblCapacity
        '
        Me.lblCapacity.AutoSize = True
        Me.lblCapacity.Location = New System.Drawing.Point(17, 89)
        Me.lblCapacity.Name = "lblCapacity"
        Me.lblCapacity.Size = New System.Drawing.Size(51, 13)
        Me.lblCapacity.TabIndex = 4
        Me.lblCapacity.Text = "Capacity:"
        '
        'txtTableNumber
        '
        Me.txtTableNumber.Location = New System.Drawing.Point(96, 61)
        Me.txtTableNumber.Name = "txtTableNumber"
        Me.txtTableNumber.Size = New System.Drawing.Size(172, 20)
        Me.txtTableNumber.TabIndex = 3
        '
        'lblTableNumber
        '
        Me.lblTableNumber.AutoSize = True
        Me.lblTableNumber.Location = New System.Drawing.Point(17, 63)
        Me.lblTableNumber.Name = "lblTableNumber"
        Me.lblTableNumber.Size = New System.Drawing.Size(77, 13)
        Me.lblTableNumber.TabIndex = 2
        Me.lblTableNumber.Text = "Table Number:"
        '
        'txtTableID
        '
        Me.txtTableID.Location = New System.Drawing.Point(96, 35)
        Me.txtTableID.Name = "txtTableID"
        Me.txtTableID.ReadOnly = True
        Me.txtTableID.Size = New System.Drawing.Size(69, 20)
        Me.txtTableID.TabIndex = 1
        '
        'lblTableID
        '
        Me.lblTableID.AutoSize = True
        Me.lblTableID.Location = New System.Drawing.Point(17, 37)
        Me.lblTableID.Name = "lblTableID"
        Me.lblTableID.Size = New System.Drawing.Size(21, 13)
        Me.lblTableID.TabIndex = 0
        Me.lblTableID.Text = "ID:"
        '
        'btnNewTable
        '
        Me.btnNewTable.Location = New System.Drawing.Point(10, 178)
        Me.btnNewTable.Name = "btnNewTable"
        Me.btnNewTable.Size = New System.Drawing.Size(69, 26)
        Me.btnNewTable.TabIndex = 1
        Me.btnNewTable.Text = "New"
        Me.btnNewTable.UseVisualStyleBackColor = True
        '
        'btnSaveTable
        '
        Me.btnSaveTable.Location = New System.Drawing.Point(84, 178)
        Me.btnSaveTable.Name = "btnSaveTable"
        Me.btnSaveTable.Size = New System.Drawing.Size(69, 26)
        Me.btnSaveTable.TabIndex = 2
        Me.btnSaveTable.Text = "Save"
        Me.btnSaveTable.UseVisualStyleBackColor = True
        '
        'btnUpdateTable
        '
        Me.btnUpdateTable.Location = New System.Drawing.Point(158, 178)
        Me.btnUpdateTable.Name = "btnUpdateTable"
        Me.btnUpdateTable.Size = New System.Drawing.Size(69, 26)
        Me.btnUpdateTable.TabIndex = 3
        Me.btnUpdateTable.Text = "Update"
        Me.btnUpdateTable.UseVisualStyleBackColor = True
        '
        'btnDeleteTable
        '
        Me.btnDeleteTable.Location = New System.Drawing.Point(231, 178)
        Me.btnDeleteTable.Name = "btnDeleteTable"
        Me.btnDeleteTable.Size = New System.Drawing.Size(69, 26)
        Me.btnDeleteTable.TabIndex = 4
        Me.btnDeleteTable.Text = "Delete"
        Me.btnDeleteTable.UseVisualStyleBackColor = True
        '
        'dgvTables
        '
        Me.dgvTables.AllowUserToAddRows = False
        Me.dgvTables.AllowUserToDeleteRows = False
        Me.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTables.Location = New System.Drawing.Point(334, 10)
        Me.dgvTables.MultiSelect = False
        Me.dgvTables.Name = "dgvTables"
        Me.dgvTables.ReadOnly = True
        Me.dgvTables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTables.Size = New System.Drawing.Size(369, 193)
        Me.dgvTables.TabIndex = 5
        '
        'FrmTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 218)
        Me.Controls.Add(Me.dgvTables)
        Me.Controls.Add(Me.btnDeleteTable)
        Me.Controls.Add(Me.btnUpdateTable)
        Me.Controls.Add(Me.btnSaveTable)
        Me.Controls.Add(Me.btnNewTable)
        Me.Controls.Add(Me.grpTableDetails)
        Me.Name = "FrmTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table Management"
        Me.grpTableDetails.ResumeLayout(False)
        Me.grpTableDetails.PerformLayout()
        CType(Me.numCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTableDetails As System.Windows.Forms.GroupBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents numCapacity As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblCapacity As System.Windows.Forms.Label
    Friend WithEvents txtTableNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblTableNumber As System.Windows.Forms.Label
    Friend WithEvents txtTableID As System.Windows.Forms.TextBox
    Friend WithEvents lblTableID As System.Windows.Forms.Label
    Friend WithEvents btnNewTable As System.Windows.Forms.Button
    Friend WithEvents btnSaveTable As System.Windows.Forms.Button
    Friend WithEvents btnUpdateTable As System.Windows.Forms.Button
    Friend WithEvents btnDeleteTable As System.Windows.Forms.Button
    Friend WithEvents dgvTables As System.Windows.Forms.DataGridView
End Class
