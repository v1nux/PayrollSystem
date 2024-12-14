﻿Imports MySqlConnector

Public Class formLogin
    ' Init
    Dim username As String
    Dim password As String
    Dim query As String
    Dim reader As MySqlDataReader
    Dim userRole As String
    Dim personalID As String

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Session.GetInstance()
        databaseConnect()
        pnlForgotCred.Hide()
    End Sub
    '  ----------------------------------------------------------------------------------------------------------------------------------------------------------
    ' Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        username = txtUsername.Text
        password = txtPassword.Text

        query = "SELECT userRole, personalID FROM loginCreds WHERE logUser = @username AND logPass = @password"

        Try
            If datacon.State = ConnectionState.Closed Then
                datacon.Open()
            End If

            Using cmd As New MySqlCommand(query, datacon)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()

                    userRole = reader("userRole").ToString()
                    personalID = reader("personalID").ToString()

                    Dim userSession = Session.GetInstance()
                    userSession.CurrentUserPersonalID = personalID
                    userSession.CurrentUserRole = userRole

                    Select Case userRole.ToLower()
                        Case "admin"
                            formAdminDash.Show()
                        Case "employee"
                            formEmployeeDash.Show()
                        Case Else
                            MessageBox.Show("Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Select

                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                reader.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If datacon.State = ConnectionState.Open Then
                datacon.Close()
            End If
        End Try
    End Sub
    '  --------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub formMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub


    ' Custom Title Bar
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
End Class