Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Module Database
    Public connectionString As String = "Server=localhost;User ID=SystemAdmin;Password=systempassword;Database=systemdb;"
    Public connection As New MySqlConnection(connectionString)
    Public Sub OpenConnection()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Database Connection Error: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error closing connection: " & ex.Message)
        End Try
    End Sub
End Module
