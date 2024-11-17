Imports MySqlConnector

Public Class formLogin
    ' Init
    Dim username As String
    Dim password As String
    Dim query As String
    Dim reader As MySqlDataReader
    Dim userRole As String

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        databaseConnect()
        pnlForgotCred.Hide()
    End Sub
    '  ----------------------------------------------------------------------------------------------------------------------------------------------------------
    ' Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        username = txtUsername.Text
        password = txtPassword.Text

        query = "SELECT userRole FROM loginCreds WHERE logUser = @username AND logPass = @password"

        Try
            If datacon.State = ConnectionState.Closed Then
                datacon.Open()
            End If


            Using cmd As New MySqlCommand(query, datacon)

                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                reader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    userRole = reader("userRole").ToString()

                    Select Case userRole.ToLower()
                        Case "admin"
                            formAdminDash.Show()
                        Case "employee"
                            formEmployee.Show()
                            'Case "manager"
                            '    Dim managerForm As New formManagerDash()
                            '    managerForm.Show()
                        Case Else
                            MessageBox.Show("User role is not recognized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    ' -----------------------------------------------------------------------------------------------------------------------------------------------------------
    ' Button Click Handlers
    Private Sub linkForgot_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgot.LinkClicked
        pnlLoginForm.Hide()
        pnlForgotCred.Show()
    End Sub

    Private Sub btnCredReset_Click(sender As Object, e As EventArgs) Handles btnCredReset.Click
        MessageBox.Show("Your request has been submitted. Please wait for further instructions from our technical team.", "Ticket", MessageBoxButtons.OK, MessageBoxIcon.Information)
        pnlForgotCred.Hide()
        pnlLoginForm.Show()
    End Sub

    Private Sub linkBack_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBack.LinkClicked
        pnlForgotCred.Hide()
        pnlLoginForm.Show()
    End Sub
    '  --------------------------------------------------------------------------------------------------------------------------------------------------------
    Private Sub formMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
