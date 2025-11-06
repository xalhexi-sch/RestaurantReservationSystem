Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public ConnectionString As String = "server=172.188.19.125;userid=erica;password=erica;database=erica;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module
