Public Class formEmployee
    Private Sub formEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Dim loginForm As New formLogin()
            loginForm.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub btnClockShift_Click(sender As Object, e As EventArgs) Handles btnClockShift.Click
        pnlClockShift.Show()
    End Sub
End Class