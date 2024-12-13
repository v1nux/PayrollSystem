Public Class Session
    Private Shared _instance As Session

    Public Property CurrentUserRole As String
    Public Property CurrentUserPersonalID As String

    Private Sub New()
    End Sub

    Public Shared Function GetInstance() As Session
        If _instance Is Nothing Then
            _instance = New Session()
        End If
        Return _instance
    End Function
End Class
