Public Class formMain

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlViewShift.Hide()
        pnlManageEmp.Hide()
    End Sub

    Private Sub btnManageEmployees_Click(sender As Object, e As EventArgs) Handles btnManageEmployees.Click
        pnlManageEmp.Show()
        pnlViewShift.Hide()
    End Sub
    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        pnlManageEmp.Hide()
        pnlViewShift.Show()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub
End Class