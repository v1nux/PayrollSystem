Public Class formAdminDash

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlViewShift.Hide()
        pnlManageEmpFormA.Hide()
    End Sub

    Private Sub btnManageEmployees_Click(sender As Object, e As EventArgs) Handles btnManageEmployees.Click
        pnlManageEmpFormA.Show()
        pnlViewShift.Hide()
    End Sub
    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        pnlViewShift.Show()
        pnlManageEmpFormA.Hide()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Dim loginForm As New formLogin()
            loginForm.Show()
            Me.Dispose()
        End If
    End Sub
End Class