Imports MySql.Data.MySqlClient

Public Class DatabaseConnection
    Private Shared _instance As DatabaseConnection
    Private _connection As MySqlConnection

    Private Sub New()
        Dim connStr As String = "server=172.188.19.125;user id=erica;password=erica;database=erica;"
        _connection = New MySqlConnection(connStr)
    End Sub

    Public Shared ReadOnly Property Instance As DatabaseConnection
        Get
            If _instance Is Nothing Then
                _instance = New DatabaseConnection()
            End If
            Return _instance
        End Get
    End Property

    Public ReadOnly Property Connection As MySqlConnection
        Get
            Return _connection
        End Get
    End Property

    Public Sub Open()
        If _connection.State = ConnectionState.Closed Then
            _connection.Open()
        End If
    End Sub

    Public Sub Close()
        If _connection.State = ConnectionState.Open Then
            _connection.Close()
        End If
    End Sub
End Class
