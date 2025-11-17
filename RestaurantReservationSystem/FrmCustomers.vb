Imports MySql.Data.MySqlClient

Public Class FrmCustomers

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Theme.ApplyTheme(Me)
        Catch ex As Exception
        End Try

        LoadCustomers()
    End Sub

    ' ================== HELPERS ==================

    Private Sub ClearFields()
        txtCustomerID.Text = ""
        txtCustomerName.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txtNotes.Text = ""
        txtCustomerName.Focus()
    End Sub

    Private Sub LoadCustomers()
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()

            Dim sql As String = "SELECT customer_id, full_name, contact_no, email, notes " &
                                "FROM customers " &
                                "ORDER BY full_name"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                da.Fill(dt)
            End Using

            dgvCustomers.DataSource = dt

            If dgvCustomers.Columns.Contains("customer_id") Then
                dgvCustomers.Columns("customer_id").HeaderText = "ID"
                dgvCustomers.Columns("customer_id").Width = 60
            End If
            If dgvCustomers.Columns.Contains("full_name") Then
                dgvCustomers.Columns("full_name").HeaderText = "Name"
                dgvCustomers.Columns("full_name").Width = 150
            End If
            If dgvCustomers.Columns.Contains("contact_no") Then
                dgvCustomers.Columns("contact_no").HeaderText = "Contact"
            End If
            If dgvCustomers.Columns.Contains("email") Then
                dgvCustomers.Columns("email").HeaderText = "Email"
                dgvCustomers.Columns("email").Width = 150
            End If
            If dgvCustomers.Columns.Contains("notes") Then
                dgvCustomers.Columns("notes").HeaderText = "Notes"
                dgvCustomers.Columns("notes").Width = 200
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading customers", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' ================== BUTTONS ==================

    Private Sub btnNewCustomer_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click
        ClearFields()
    End Sub

    Private Sub btnSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnSaveCustomer.Click
        Dim name As String = txtCustomerName.Text.Trim()
        Dim contact As String = txtContact.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim notes As String = txtNotes.Text.Trim()

        If name = "" Then
            MessageBox.Show("Please enter customer name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return
        End If

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String = "INSERT INTO customers (full_name, contact_no, email, notes) " &
                                "VALUES (@name, @contact, @mail, @notes); " &
                                "SELECT LAST_INSERT_ID();"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@contact", contact)
                cmd.Parameters.AddWithValue("@mail", email)
                cmd.Parameters.AddWithValue("@notes", notes)

                Dim newId As Object = cmd.ExecuteScalar()
                If newId IsNot Nothing Then
                    txtCustomerID.Text = newId.ToString()
                End If
            End Using

            MessageBox.Show("Customer saved successfully.", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error saving customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        If txtCustomerID.Text.Trim() = "" Then
            MessageBox.Show("Select a customer to update.", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtCustomerID.Text.Trim())
        Dim name As String = txtCustomerName.Text.Trim()
        Dim contact As String = txtContact.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim notes As String = txtNotes.Text.Trim()

        If name = "" Then
            MessageBox.Show("Please enter customer name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return
        End If

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String = "UPDATE customers " &
                                "SET full_name=@name, contact_no=@contact, email=@mail, notes=@notes " &
                                "WHERE customer_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@contact", contact)
                cmd.Parameters.AddWithValue("@mail", email)
                cmd.Parameters.AddWithValue("@notes", notes)
                cmd.Parameters.AddWithValue("@id", id)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Customer updated successfully.", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCustomers()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error updating customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnDeleteCustomer_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomer.Click
        If txtCustomerID.Text.Trim() = "" Then
            MessageBox.Show("Select a customer to delete.", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtCustomerID.Text.Trim())

        If MessageBox.Show("Are you sure you want to delete this customer?",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String = "DELETE FROM customers WHERE customer_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Customer deleted successfully.", "Customers", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadCustomers()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error deleting customer", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' ================== GRID CLICK ==================

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick
        If e.RowIndex < 0 Then Return
        If dgvCustomers.CurrentRow Is Nothing Then Return

        Dim row As DataGridViewRow = dgvCustomers.Rows(e.RowIndex)

        If row.Cells("customer_id").Value IsNot Nothing Then
            txtCustomerID.Text = row.Cells("customer_id").Value.ToString()
        End If
        If row.Cells("full_name").Value IsNot Nothing Then
            txtCustomerName.Text = row.Cells("full_name").Value.ToString()
        End If
        If row.Cells("contact_no").Value IsNot Nothing Then
            txtContact.Text = row.Cells("contact_no").Value.ToString()
        End If
        If row.Cells("email").Value IsNot Nothing Then
            txtEmail.Text = row.Cells("email").Value.ToString()
        End If
        If row.Cells("notes").Value IsNot Nothing Then
            txtNotes.Text = row.Cells("notes").Value.ToString()
        End If
    End Sub

End Class
