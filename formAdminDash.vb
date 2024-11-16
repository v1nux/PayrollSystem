Public Class formMain

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlViewEmp.Hide()
        pnlPayroll.Hide()
    End Sub

    Private Sub btnViewEmployees_Click(sender As Object, e As EventArgs) Handles btnViewEmployees.Click
        pnlViewEmp.Show()
        pnlPayroll.Hide()
    End Sub

    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        pnlPayroll.Show()
        pnlViewEmp.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub
End Class