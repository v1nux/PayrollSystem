Imports System.Drawing.Drawing2D
Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim mainForm As New formMain()
        mainForm.Show()

        Me.Hide()

    End Sub

    Private Sub formMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

End Class
