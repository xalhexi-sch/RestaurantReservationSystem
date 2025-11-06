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
        Me.txtTableNum = New System.Windows.Forms.TextBox()
        Me.numCap = New System.Windows.Forms.NumericUpDown()
        Me.dgvTables = New System.Windows.Forms.DataGridView()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.numCap, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnClear.Location = New System.Drawing.Point(121, 334)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtTableNum
        '
        Me.txtTableNum.Location = New System.Drawing.Point(192, 85)
        Me.txtTableNum.Name = "txtTableNum"
        Me.txtTableNum.Size = New System.Drawing.Size(100, 20)
        Me.txtTableNum.TabIndex = 6
        '
        'numCap
        '
        Me.numCap.Location = New System.Drawing.Point(192, 114)
        Me.numCap.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCap.Name = "numCap"
        Me.numCap.Size = New System.Drawing.Size(100, 20)
        Me.numCap.TabIndex = 7
        Me.numCap.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dgvTables
        '
        Me.dgvTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTables.Location = New System.Drawing.Point(384, 67)
        Me.dgvTables.Name = "dgvTables"
        Me.dgvTables.Size = New System.Drawing.Size(361, 290)
        Me.dgvTables.TabIndex = 8
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(121, 363)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FormManageTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvTables)
        Me.Controls.Add(Me.numCap)
        Me.Controls.Add(Me.txtTableNum)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblCap)
        Me.Controls.Add(Me.lblNum)
        Me.Name = "FormManageTables"
        Me.Text = "FormManageTables"
        CType(Me.numCap, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtTableNum As TextBox
    Friend WithEvents numCap As NumericUpDown
    Friend WithEvents dgvTables As DataGridView
    Friend WithEvents btnClose As Button
End Class
