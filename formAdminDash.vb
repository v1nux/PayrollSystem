﻿Public Class formAdminDash



    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlViewShift.Hide()
        pnlManageEmpFormA.Hide()
        pnlViewAttendance.Hide()
    End Sub

    Private Sub btnManageEmployees_Click(sender As Object, e As EventArgs) Handles btnManageEmployees.Click
        pnlManageEmpFormA.Show()
        pnlViewShift.Hide()
        pnlViewAttendance.Hide()
    End Sub
    Private Sub btnShift_Click(sender As Object, e As EventArgs) Handles btnShift.Click
        pnlViewShift.Show()
        pnlManageEmpFormA.Hide()
        pnlViewAttendance.Hide()
    End Sub

    Private Sub btnViewAllAtt_Click(sender As Object, e As EventArgs) Handles btnViewAllAtt.Click
        pnlViewShift.Hide()
        pnlManageEmpFormA.Hide()
        pnlViewAttendance.Show()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show("This will end the current session", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            Dim loginForm As New formLogin()
            loginForm.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub dataGridEmployees_Load(sender As Object, e As EventArgs)
        MessageBox.Show("It works")

    End Sub

    ' Custom Title

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

    Private Sub AdminPanel_Paint(sender As Object, e As PaintEventArgs) Handles AdminPanel.Paint
        AdminPanel.BorderStyle = BorderStyle.None

        Dim radius As Integer = 15
        Dim rect As Rectangle = AdminPanel.ClientRectangle
        Dim path As New Drawing2D.GraphicsPath()

        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseFigure()

        AdminPanel.Region = New Region(path)
    End Sub
End Class