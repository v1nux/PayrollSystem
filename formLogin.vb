Imports System.Drawing.Drawing2D
Public Class Form1
    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlForgotCred.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim mainForm As New formMain()
        mainForm.Show()

        Me.Hide()

    End Sub

    Private Sub formMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub linkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgot.LinkClicked
        pnlLoginForm.Hide()
        pnlForgotCred.Show()
    End Sub

    Private Sub btnCredReset_Click(sender As Object, e As EventArgs) Handles btnCredReset.Click
        MessageBox.Show("Your request has been submitted. Please wait for further instructions from our techincal team.", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)

        pnlForgotCred.Hide()
        pnlLoginForm.Show()
    End Sub

    Private Sub linkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBack.LinkClicked
        pnlForgotCred.Hide()
        pnlLoginForm.Show()
    End Sub
End Class
