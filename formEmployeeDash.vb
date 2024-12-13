Public Class formEmployeeDash

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlEmpAttendance.Hide()
        pnlNewInstance.Hide()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show("This will end the current session", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Dim loginForm As New formLogin()
            loginForm.Show()
            Me.Dispose()
        End If
    End Sub

    Private isDragging As Boolean
    Private startPoint As Point

    Private Sub pnlTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseDown
        isDragging = True
        startPoint = New Point(e.X, e.Y)
    End Sub

    Private Sub pnlTitleBar_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseMove
        If isDragging Then
            Dim p As Point = PointToScreen(e.Location)
            Location = New Point(p.X - startPoint.X, p.Y - startPoint.Y)
        End If
    End Sub

    Private Sub pnlTitleBar_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlTitleBar.MouseUp
        isDragging = False
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub formAdminDash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ' Button Clicks

    Private Sub btnEmployeeAttendance_Click(sender As Object, e As EventArgs) Handles btnEmployeeAttendance.Click
        pnlNewInstance.Hide()
        pnlEmpAttendance.Show()
    End Sub

    Private Sub btnNewInstance_Click(sender As Object, e As EventArgs) Handles btnNewInstance.Click
        pnlEmpAttendance.Hide()
        pnlNewInstance.Show()
    End Sub
End Class