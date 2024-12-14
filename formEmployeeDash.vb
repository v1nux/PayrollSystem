Imports MySqlConnector

Public Class formEmployeeDash
    Dim personalID As String
    Dim query As String
    Dim userSession = Session.GetInstance()
    Dim dataTable As New DataTable()

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

    ' Button Clicks

    Private Sub btnEmployeeAttendance_Click(sender As Object, e As EventArgs) Handles btnEmployeeAttendance.Click
        pnlNewInstance.Hide()
        pnlEmpAttendance.Show()
    End Sub

    Private Sub btnNewInstance_Click(sender As Object, e As EventArgs) Handles btnNewInstance.Click
        pnlEmpAttendance.Hide()
        pnlNewInstance.Show()
    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click
        Try
            personalID = userSession.CurrentUserPersonalID

            query = "SELECT emp.empID, emp.TimeIn, emp.TimeOut, emp.FirstName, emp.LastName, emp.Shifts " &
                              "FROM empLogs emp " &
                              "INNER JOIN loginCreds loginCreds ON emp.empID = loginCreds.personalID " &
                              "WHERE loginCreds.personalID = @personalID"

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@personalID", personalID)
        }

            Dim dataTable As New DataTable()
            Using cmd As New MySqlCommand(query, SQLConnect.datacon)
                cmd.Parameters.AddRange(parameters.ToArray())
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dataTable)
            End Using

            If dataTable.Rows.Count > 0 Then
                dgvSearchAttendance.DataSource = dataTable

                dgvSearchAttendance.Columns("empID").HeaderText = "Employee ID"
                dgvSearchAttendance.Columns("TimeIn").HeaderText = "Time In"
                dgvSearchAttendance.Columns("TimeOut").HeaderText = "Time Out"
                dgvSearchAttendance.Columns("FirstName").HeaderText = "First Name"
                dgvSearchAttendance.Columns("LastName").HeaderText = "Last Name"
                dgvSearchAttendance.Columns("Shifts").HeaderText = "Shifts"

                dgvSearchAttendance.Columns("empID").Width = 120
                dgvSearchAttendance.Columns("TimeIn").Width = 100
                dgvSearchAttendance.Columns("TimeOut").Width = 100
                dgvSearchAttendance.Columns("Shifts").Width = 200
            Else
                MessageBox.Show("No records found.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            If SQLConnect.datacon.State = ConnectionState.Open Then
                SQLConnect.datacon.Close()
            End If
        End Try

    End Sub

    Private Sub btnSearchAttendance_Click(sender As Object, e As EventArgs) Handles btnSearchAttendance.Click

        Try
            personalID = userSession.CurrentUserPersonalID

            query = "SELECT emp.empID, emp.TimeIn, emp.TimeOut, emp.FirstName, emp.LastName, emp.Shifts " &
                              "FROM empLogs emp " &
                              "INNER JOIN loginCreds loginCreds ON emp.empID = loginCreds.personalID " &
                              "WHERE loginCreds.personalID = @personalID"

            If dtpSearchAttendanceDate.Checked Then
                query &= " AND DATE(emp.Shifts) = @Shifts"
            End If

            Dim parameters As New List(Of MySqlParameter) From {
            New MySqlParameter("@personalID", personalID)
        }
            If dtpSearchAttendanceDate.Checked Then
                parameters.Add(New MySqlParameter("@Shifts", dtpSearchAttendanceDate.Value.Date))
            End If

            Dim dataTable As New DataTable()
            Using cmd As New MySqlCommand(query, SQLConnect.datacon)
                cmd.Parameters.AddRange(parameters.ToArray())
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dataTable)
            End Using

            If dataTable.Rows.Count > 0 Then
                dgvSearchAttendance.DataSource = dataTable

                dgvSearchAttendance.Columns("empID").HeaderText = "Employee ID"
                dgvSearchAttendance.Columns("TimeIn").HeaderText = "Time In"
                dgvSearchAttendance.Columns("TimeOut").HeaderText = "Time Out"
                dgvSearchAttendance.Columns("FirstName").HeaderText = "First Name"
                dgvSearchAttendance.Columns("LastName").HeaderText = "Last Name"
                dgvSearchAttendance.Columns("Shifts").HeaderText = "Shifts"

                dgvSearchAttendance.Columns("empID").Width = 120
                dgvSearchAttendance.Columns("TimeIn").Width = 100
                dgvSearchAttendance.Columns("TimeOut").Width = 100
                dgvSearchAttendance.Columns("Shifts").Width = 200
            Else
                MessageBox.Show("No records found.")
            End If

        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            If SQLConnect.datacon.State = ConnectionState.Open Then
                SQLConnect.datacon.Close()
            End If
        End Try
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

    Private Sub formAdminDash_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class