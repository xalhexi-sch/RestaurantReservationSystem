Imports MySql.Data.MySqlClient

Public Class FrmUsers

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Theme.ApplyTheme(Me)
        Catch ex As Exception
        End Try

        LoadRoles()
        LoadUsers()
    End Sub

    ' ================== HELPERS ==================

    Private Sub ClearFields()
        txtUserID.Text = ""
        txtFullName.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        If cmbUserRole.Items.Count > 0 Then
            cmbUserRole.SelectedIndex = 0
        End If
        txtFullName.Focus()
    End Sub

    Private Sub LoadRoles()
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()

            Dim sql As String = "SELECT role_id, role_name FROM roles ORDER BY role_name"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                da.Fill(dt)
            End Using

            cmbUserRole.DataSource = dt
            cmbUserRole.DisplayMember = "role_name"
            cmbUserRole.ValueMember = "role_id"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading roles", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub LoadUsers()
        Dim db = DatabaseConnection.Instance
        Dim dt As New DataTable()

        Try
            db.Open()

            Dim sql As String =
                "SELECT u.user_id, u.full_name, u.username, r.role_name, u.password_hash " &
                "FROM users u " &
                "JOIN roles r ON u.role_id = r.role_id " &
                "ORDER BY u.full_name"

            Using da As New MySqlDataAdapter(sql, db.Connection)
                da.Fill(dt)
            End Using

            dgvUsers.DataSource = dt

            If dgvUsers.Columns.Contains("user_id") Then
                dgvUsers.Columns("user_id").HeaderText = "ID"
                dgvUsers.Columns("user_id").Width = 60
            End If
            If dgvUsers.Columns.Contains("full_name") Then
                dgvUsers.Columns("full_name").HeaderText = "Full Name"
                dgvUsers.Columns("full_name").Width = 150
            End If
            If dgvUsers.Columns.Contains("username") Then
                dgvUsers.Columns("username").HeaderText = "Username"
                dgvUsers.Columns("username").Width = 120
            End If
            If dgvUsers.Columns.Contains("role_name") Then
                dgvUsers.Columns("role_name").HeaderText = "Role"
                dgvUsers.Columns("role_name").Width = 80
            End If
            ' Hide password column in grid
            If dgvUsers.Columns.Contains("password_hash") Then
                dgvUsers.Columns("password_hash").Visible = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' ================== BUTTONS ==================

    Private Sub btnNewUser_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        ClearFields()
    End Sub

    Private Sub btnSaveUser_Click(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If fullName = "" OrElse username = "" OrElse password = "" Then
            MessageBox.Show("Full Name, Username and Password are required.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If cmbUserRole.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a role.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim roleId As Integer = CInt(cmbUserRole.SelectedValue)
        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String =
                "INSERT INTO users (role_id, full_name, username, password_hash, is_active) " &
                "VALUES (@roleId, @name, @uname, @pwd, 1); " &
                "SELECT LAST_INSERT_ID();"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@roleId", roleId)
                cmd.Parameters.AddWithValue("@name", fullName)
                cmd.Parameters.AddWithValue("@uname", username)
                cmd.Parameters.AddWithValue("@pwd", password)  ' demo only – plain text
                Dim newId As Object = cmd.ExecuteScalar()
                If newId IsNot Nothing Then
                    txtUserID.Text = newId.ToString()
                End If
            End Using

            MessageBox.Show("User saved successfully.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()

        Catch ex As MySqlException
            MessageBox.Show("Error saving user: " & ex.Message, "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error saving user: " & ex.Message, "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnUpdateUser_Click(sender As Object, e As EventArgs) Handles btnUpdateUser.Click
        If txtUserID.Text.Trim() = "" Then
            MessageBox.Show("Select a user to update.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtUserID.Text.Trim())
        Dim fullName As String = txtFullName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim newPassword As String = txtPassword.Text.Trim()
        Dim roleId As Integer = CInt(cmbUserRole.SelectedValue)

        If fullName = "" OrElse username = "" Then
            MessageBox.Show("Full Name and Username are required.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' If password textbox is empty, keep existing password from grid
        Dim passwordToUse As String = newPassword
        If passwordToUse = "" AndAlso dgvUsers.CurrentRow IsNot Nothing AndAlso
           dgvUsers.CurrentRow.Cells("password_hash").Value IsNot Nothing Then
            passwordToUse = dgvUsers.CurrentRow.Cells("password_hash").Value.ToString()
        End If

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String =
                "UPDATE users " &
                "SET role_id=@roleId, full_name=@name, username=@uname, password_hash=@pwd " &
                "WHERE user_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@roleId", roleId)
                cmd.Parameters.AddWithValue("@name", fullName)
                cmd.Parameters.AddWithValue("@uname", username)
                cmd.Parameters.AddWithValue("@pwd", passwordToUse)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User updated successfully.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()

        Catch ex As Exception
            MessageBox.Show("Error updating user: " & ex.Message, "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If txtUserID.Text.Trim() = "" Then
            MessageBox.Show("Select a user to delete.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(txtUserID.Text.Trim())

        If MessageBox.Show("Are you sure you want to delete this user?",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim db = DatabaseConnection.Instance

        Try
            db.Open()

            Dim sql As String = "DELETE FROM users WHERE user_id=@id"

            Using cmd As New MySqlCommand(sql, db.Connection)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("User deleted successfully.", "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
            LoadUsers()

        Catch ex As Exception
            MessageBox.Show("Error deleting user: " & ex.Message, "Users",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.Close()
        End Try
    End Sub

    ' ================== GRID CLICK ==================

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex < 0 Then Return
        If dgvUsers.CurrentRow Is Nothing Then Return

        Dim row As DataGridViewRow = dgvUsers.Rows(e.RowIndex)

        If row.Cells("user_id").Value IsNot Nothing Then
            txtUserID.Text = row.Cells("user_id").Value.ToString()
        End If
        If row.Cells("full_name").Value IsNot Nothing Then
            txtFullName.Text = row.Cells("full_name").Value.ToString()
        End If
        If row.Cells("username").Value IsNot Nothing Then
            txtUsername.Text = row.Cells("username").Value.ToString()
        End If
        ' Don't show password in textbox; keep it blank unless user wants to set new password
        txtPassword.Text = ""

        If row.Cells("role_name").Value IsNot Nothing Then
            Dim roleName As String = row.Cells("role_name").Value.ToString()
            ' find item in combo with this role name
            For i As Integer = 0 To cmbUserRole.Items.Count - 1
                Dim drv As DataRowView = TryCast(cmbUserRole.Items(i), DataRowView)
                If drv IsNot Nothing AndAlso drv("role_name").ToString() = roleName Then
                    cmbUserRole.SelectedIndex = i
                    Exit For
                End If
            Next
        End If
    End Sub


End Class
