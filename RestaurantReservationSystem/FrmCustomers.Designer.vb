<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomers
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
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.btnNewCustomer = New System.Windows.Forms.Button()
        Me.btnSaveCustomer = New System.Windows.Forms.Button()
        Me.btnUpdateCustomer = New System.Windows.Forms.Button()
        Me.btnDeleteCustomer = New System.Windows.Forms.Button()
        Me.dgvCustomers = New System.Windows.Forms.DataGridView()
        Me.grpCustomerDetails.SuspendLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.Controls.Add(Me.txtNotes)
        Me.grpCustomerDetails.Controls.Add(Me.lblNotes)
        Me.grpCustomerDetails.Controls.Add(Me.txtEmail)
        Me.grpCustomerDetails.Controls.Add(Me.lblEmail)
        Me.grpCustomerDetails.Controls.Add(Me.txtContact)
        Me.grpCustomerDetails.Controls.Add(Me.lblContact)
        Me.grpCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerName)
        Me.grpCustomerDetails.Controls.Add(Me.txtCustomerID)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerID)
        Me.grpCustomerDetails.Location = New System.Drawing.Point(10, 10)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(309, 208)
        Me.grpCustomerDetails.TabIndex = 0
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Customer Details"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(96, 139)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(189, 53)
        Me.txtNotes.TabIndex = 9
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Location = New System.Drawing.Point(17, 141)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(38, 13)
        Me.lblNotes.TabIndex = 8
        Me.lblNotes.Text = "Notes:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(96, 113)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(189, 20)
        Me.txtEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(17, 115)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(35, 13)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(96, 87)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(189, 20)
        Me.txtContact.TabIndex = 5
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(17, 89)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(47, 13)
        Me.lblContact.TabIndex = 4
        Me.lblContact.Text = "Contact:"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(96, 61)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(189, 20)
        Me.txtCustomerName.TabIndex = 3
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(17, 63)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(38, 13)
        Me.lblCustomerName.TabIndex = 2
        Me.lblCustomerName.Text = "Name:"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(96, 35)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.ReadOnly = True
        Me.txtCustomerID.Size = New System.Drawing.Size(69, 20)
        Me.txtCustomerID.TabIndex = 1
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Location = New System.Drawing.Point(17, 37)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(21, 13)
        Me.lblCustomerID.TabIndex = 0
        Me.lblCustomerID.Text = "ID:"
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.Location = New System.Drawing.Point(10, 230)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(69, 26)
        Me.btnNewCustomer.TabIndex = 1
        Me.btnNewCustomer.Text = "New"
        Me.btnNewCustomer.UseVisualStyleBackColor = True
        '
        'btnSaveCustomer
        '
        Me.btnSaveCustomer.Location = New System.Drawing.Point(84, 230)
        Me.btnSaveCustomer.Name = "btnSaveCustomer"
        Me.btnSaveCustomer.Size = New System.Drawing.Size(69, 26)
        Me.btnSaveCustomer.TabIndex = 2
        Me.btnSaveCustomer.Text = "Save"
        Me.btnSaveCustomer.UseVisualStyleBackColor = True
        '
        'btnUpdateCustomer
        '
        Me.btnUpdateCustomer.Location = New System.Drawing.Point(158, 230)
        Me.btnUpdateCustomer.Name = "btnUpdateCustomer"
        Me.btnUpdateCustomer.Size = New System.Drawing.Size(69, 26)
        Me.btnUpdateCustomer.TabIndex = 3
        Me.btnUpdateCustomer.Text = "Update"
        Me.btnUpdateCustomer.UseVisualStyleBackColor = True
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Location = New System.Drawing.Point(231, 230)
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Size = New System.Drawing.Size(69, 26)
        Me.btnDeleteCustomer.TabIndex = 4
        Me.btnDeleteCustomer.Text = "Delete"
        Me.btnDeleteCustomer.UseVisualStyleBackColor = True
        '
        'dgvCustomers
        '
        Me.dgvCustomers.AllowUserToAddRows = False
        Me.dgvCustomers.AllowUserToDeleteRows = False
        Me.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCustomers.Location = New System.Drawing.Point(334, 10)
        Me.dgvCustomers.MultiSelect = False
        Me.dgvCustomers.Name = "dgvCustomers"
        Me.dgvCustomers.ReadOnly = True
        Me.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCustomers.Size = New System.Drawing.Size(369, 245)
        Me.dgvCustomers.TabIndex = 5
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 270)
        Me.Controls.Add(Me.dgvCustomers)
        Me.Controls.Add(Me.btnDeleteCustomer)
        Me.Controls.Add(Me.btnUpdateCustomer)
        Me.Controls.Add(Me.btnSaveCustomer)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Name = "FrmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Management"
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        CType(Me.dgvCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents lblContact As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerName As System.Windows.Forms.Label
    Friend WithEvents txtCustomerID As System.Windows.Forms.TextBox
    Friend WithEvents lblCustomerID As System.Windows.Forms.Label
    Friend WithEvents btnNewCustomer As System.Windows.Forms.Button
    Friend WithEvents btnSaveCustomer As System.Windows.Forms.Button
    Friend WithEvents btnUpdateCustomer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteCustomer As System.Windows.Forms.Button
    Friend WithEvents dgvCustomers As DataGridView
End Class
