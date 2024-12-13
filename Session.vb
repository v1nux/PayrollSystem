' Create a new class file called UserSession.vb
Public Class Session
    ' Private static instance
    Private Shared _instance As Session

    ' Properties to store session data
    Public CurrentUserRole As String
    Public CurrentUserPersonalID As String

    ' Private constructor to prevent direct instantiation
    Private Sub New()
    End Sub

    ' Public method to access the singleton instance
    Public Shared Function GetInstance() As Session
        If _instance Is Nothing Then
            _instance = New Session()
        End If
        Return _instance
    End Function
End Class
