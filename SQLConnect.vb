Imports MySqlConnector

Module SQLConnect
    Public datacon As New MySqlConnection

    Dim server As String = "127.0.0.1"
    Dim dbasename As String = "PayrollSystem"
    Dim username As String = "root"
    Dim passwd As String = ""

    Public Sub databaseConnect()
        Try
            datacon.ConnectionString = $"server={server};user id={username};password={passwd};database={dbasename};"

            datacon.Open()

        Catch ex As MySqlException

            MsgBox($"Database Connection Error: {ex.Message}", MsgBoxStyle.Critical)
        Catch ex As Exception

            MsgBox($"Unexpected Error: {ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    'Public Sub databaseDisconnect()
    '    Try
    '        If datacon.State = ConnectionState.Open Then
    '            datacon.Close()
    '            MsgBox("Database Connection Closed", MsgBoxStyle.Information)
    '        End If
    '    Catch ex As Exception
    '        MsgBox($"Error Closing Connection: {ex.Message}", MsgBoxStyle.Critical)
    '    End Try
    'End Sub
End Module
