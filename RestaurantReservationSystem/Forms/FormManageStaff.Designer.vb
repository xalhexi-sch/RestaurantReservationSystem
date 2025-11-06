<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManageStaff
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtPos = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.dgvStaff = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(201, 41)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(71, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Manage Staff"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(138, 97)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(60, 13)
        Me.lblFirst.TabIndex = 1
        Me.lblFirst.Text = "First Name:"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(138, 122)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(61, 13)
        Me.lblLast.TabIndex = 2
        Me.lblLast.Text = "Last Name:"
        '
        'lblPos
        '
        Me.lblPos.AutoSize = True
        Me.lblPos.Location = New System.Drawing.Point(137, 154)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(47, 13)
        Me.lblPos.TabIndex = 3
        Me.lblPos.Text = "Position:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(137, 182)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone:"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(204, 94)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 5
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(205, 122)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 6
        '
        'txtPos
        '
        Me.txtPos.Location = New System.Drawing.Point(204, 147)
        Me.txtPos.Name = "txtPos"
        Me.txtPos.Size = New System.Drawing.Size(100, 20)
        Me.txtPos.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(204, 179)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 8
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(138, 209)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(204, 209)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 10
        '
        'dgvStaff
        '
        Me.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStaff.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvStaff.Location = New System.Drawing.Point(0, 300)
        Me.dgvStaff.Name = "dgvStaff"
        Me.dgvStaff.Size = New System.Drawing.Size(800, 150)
        Me.dgvStaff.TabIndex = 11
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(129, 249)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add Staff"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(240, 249)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(345, 249)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(450, 249)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear Fields"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(558, 249)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'FormManageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvStaff)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtPos)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblPos)
        Me.Controls.Add(Me.lblLast)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FormManageStaff"
        Me.Text = "FormManageStaff"
        CType(Me.dgvStaff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblLast As Label
    Friend WithEvents lblPos As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtPos As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
End Class
