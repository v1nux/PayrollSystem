Imports MySqlConnector

Public Class formAdminDash

    Dim query As String
    Dim da As MySqlDataAdapter
    Dim dataTable As New DataTable
    Dim command As MySqlCommand
    Dim adapter As New MySqlDataAdapter(command)

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

    Private Sub btnSearchAttendance_Click(sender As Object, e As EventArgs) Handles btnSearchAttendance.Click

        SQLConnect.databaseConnect()

        query = "SELECT empID, FirstName, LastName, Shifts FROM empLogs WHERE 1=1"

        If Not String.IsNullOrWhiteSpace(txtEmpID.Text) Then
            query &= " AND empID = @empID"
        End If

        If Not String.IsNullOrWhiteSpace(txtFName.Text) Then
            query &= " AND FirstName LIKE @FirstName"
        End If

        If Not String.IsNullOrWhiteSpace(txtLName.Text) Then
            query &= " AND LastName LIKE @LastName"
        End If

        If dtpSearchAttendanceDate.Checked Then
            query &= " AND DATE(Shifts) = @Shifts"
        End If

        command = New MySqlCommand(query, datacon)

        If Not String.IsNullOrWhiteSpace(txtEmpID.Text) Then
            command.Parameters.AddWithValue("@empID", txtEmpID.Text)
        End If

        If Not String.IsNullOrWhiteSpace(txtFName.Text) Then
            command.Parameters.AddWithValue("@FirstName", "%" & txtFName.Text & "%")
        End If

        If Not String.IsNullOrWhiteSpace(txtLName.Text) Then
            command.Parameters.AddWithValue("@LastName", "%" & txtLName.Text & "%")
        End If

        If dtpSearchAttendanceDate.Checked Then
            command.Parameters.AddWithValue("@Shifts", dtpSearchAttendanceDate.Value.Date)
        End If

        adapter = New MySqlDataAdapter(command)

        Try
            dataTable.Clear()
            adapter.Fill(dataTable)

            If dataTable.Rows.Count > 0 Then
                dgvSearchAttendance.DataSource = dataTable
                dgvSearchAttendance.Columns("empID").HeaderText = "Employee ID"
                dgvSearchAttendance.Columns("FirstName").HeaderText = "First Name"
                dgvSearchAttendance.Columns("LastName").HeaderText = "Last Name"
                dgvSearchAttendance.Columns("Shifts").HeaderText = "Shifts"

                dgvSearchAttendance.Columns("Shifts").Width = 200

            Else
                MessageBox.Show("No results found.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
        Finally
            If datacon.State = ConnectionState.Open Then
                datacon.Close()
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