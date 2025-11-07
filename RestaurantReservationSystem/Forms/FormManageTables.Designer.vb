<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManageTables
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
        Me.lblNum = New System.Windows.Forms.Label()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTableNumber = New System.Windows.Forms.TextBox()
        Me.numCapacity = New System.Windows.Forms.NumericUpDown()
        Me.dgvTables = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.numCapacity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(89, 85)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(74, 13)
        Me.lblNum.TabIndex = 0
        Me.lblNum.Text = "Table Number"
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.Location = New System.Drawing.Point(89, 114)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(48, 13)
        Me.lblCap.TabIndex = 1
        Me.lblCap.Text = "Capacity"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(121, 194)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(121, 243)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(121, 305)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(121, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtTableNumber
        '
        Me.txtTableNumber.Location = New System.Drawing.Point(192, 85)
        Me.txtTableNumber.Name = "txtTableNumber"
        Me.txtTableNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtTableNumber.TabIndex = 6
        '
        'numCapacity
        '
        Me.numCapacity.Location = New System.Drawing.Point(192, 114)
        Me.numCapacity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCapacity.Name = "numCapacity"
        Me.numCapacity.Size = New System.Drawing.Size(100, 20)
        Me.numCapacity.TabIndex = 7
        Me.numCapacity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dgvTables
        '
        Me.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTables.Location = New System.Drawing.Point(405, 96)
        Me.dgvTables.Name = "dgvTables"
        Me.dgvTables.Size = New System.Drawing.Size(361, 290)
        Me.dgvTables.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(121, 385)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"available", "occupied", "reserved"})
        Me.cmbStatus.Location = New System.Drawing.Point(192, 149)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(100, 21)
        Me.cmbStatus.TabIndex = 10
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(121, 334)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 11
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Status"
        '
        'FormManageTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvTables)
        Me.Controls.Add(Me.numCapacity)
        Me.Controls.Add(Me.txtTableNumber)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblCap)
        Me.Controls.Add(Me.lblNum)
        Me.Name = "FormManageTables"
        Me.Text = "FormManageTables"
        CType(Me.numCapacity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNum As Label
    Friend WithEvents lblCap As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTableNumber As TextBox
    Friend WithEvents numCapacity As NumericUpDown
    Friend WithEvents dgvTables As DataGridView
    Friend WithEvents btnClose As Button
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label1 As Label
End Class
