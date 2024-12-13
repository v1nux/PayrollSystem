<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEmployeeDash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        EmployeePanel = New Panel()
        btnNewInstance = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnEmployeeAttendance = New Button()
        btnLogout = New Button()
        pnlTitleBar = New Panel()
        Label22 = New Label()
        btnExit = New Button()
        pnlEmpAttendance = New Panel()
        Label14 = New Label()
        dgvAttendance = New DataGridView()
        searchID = New DataGridViewTextBoxColumn()
        searchName = New DataGridViewTextBoxColumn()
        searchTimeIn = New DataGridViewTextBoxColumn()
        searchTimeOut = New DataGridViewTextBoxColumn()
        btnSearchAttendance = New Button()
        dtpAttendance = New DateTimePicker()
        Label16 = New Label()
        pnlNewInstance = New Panel()
        Label3 = New Label()
        EmployeePanel.SuspendLayout()
        pnlTitleBar.SuspendLayout()
        pnlEmpAttendance.SuspendLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).BeginInit()
        pnlNewInstance.SuspendLayout()
        SuspendLayout()
        ' 
        ' EmployeePanel
        ' 
        EmployeePanel.BackColor = Color.FromArgb(CByte(31), CByte(32), CByte(48))
        EmployeePanel.Controls.Add(btnNewInstance)
        EmployeePanel.Controls.Add(Label1)
        EmployeePanel.Controls.Add(Label2)
        EmployeePanel.Controls.Add(btnEmployeeAttendance)
        EmployeePanel.Controls.Add(btnLogout)
        EmployeePanel.Location = New Point(-2, -8)
        EmployeePanel.Margin = New Padding(3, 4, 3, 4)
        EmployeePanel.Name = "EmployeePanel"
        EmployeePanel.Size = New Size(241, 688)
        EmployeePanel.TabIndex = 3
        ' 
        ' btnNewInstance
        ' 
        btnNewInstance.Anchor = AnchorStyles.None
        btnNewInstance.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnNewInstance.FlatStyle = FlatStyle.Popup
        btnNewInstance.Location = New Point(19, 268)
        btnNewInstance.Margin = New Padding(3, 4, 3, 4)
        btnNewInstance.Name = "btnNewInstance"
        btnNewInstance.Size = New Size(199, 53)
        btnNewInstance.TabIndex = 11
        btnNewInstance.Text = "Another Button"
        btnNewInstance.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(53), CByte(57), CByte(80))
        Label1.Font = New Font("Helvetica", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(0, 7)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10)
        Label1.Size = New Size(244, 106)
        Label1.TabIndex = 7
        Label1.Text = "Employee Dashboard"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Coolvetica Rg", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(19, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 19)
        Label2.TabIndex = 10
        Label2.Text = "Menu"
        ' 
        ' btnEmployeeAttendance
        ' 
        btnEmployeeAttendance.Anchor = AnchorStyles.None
        btnEmployeeAttendance.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnEmployeeAttendance.FlatStyle = FlatStyle.Popup
        btnEmployeeAttendance.Location = New Point(19, 207)
        btnEmployeeAttendance.Margin = New Padding(3, 4, 3, 4)
        btnEmployeeAttendance.Name = "btnEmployeeAttendance"
        btnEmployeeAttendance.Size = New Size(199, 53)
        btnEmployeeAttendance.TabIndex = 2
        btnEmployeeAttendance.Text = "Attendance"
        btnEmployeeAttendance.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightPink
        btnLogout.FlatStyle = FlatStyle.Popup
        btnLogout.Location = New Point(64, 642)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(109, 33)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseMnemonic = False
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.BackColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        pnlTitleBar.Controls.Add(Label22)
        pnlTitleBar.Controls.Add(btnExit)
        pnlTitleBar.Location = New Point(0, 0)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(1225, 31)
        pnlTitleBar.TabIndex = 18
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.WhiteSmoke
        Label22.Location = New Point(248, 10)
        Label22.Name = "Label22"
        Label22.Size = New Size(145, 13)
        Label22.TabIndex = 1
        Label22.Text = "Payroll System (Employee)"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.IndianRed
        btnExit.Location = New Point(1190, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(28, 23)
        btnExit.TabIndex = 0
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' pnlEmpAttendance
        ' 
        pnlEmpAttendance.BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(58))
        pnlEmpAttendance.Controls.Add(Label14)
        pnlEmpAttendance.Controls.Add(dgvAttendance)
        pnlEmpAttendance.Controls.Add(btnSearchAttendance)
        pnlEmpAttendance.Controls.Add(dtpAttendance)
        pnlEmpAttendance.Controls.Add(Label16)
        pnlEmpAttendance.Location = New Point(233, 28)
        pnlEmpAttendance.Name = "pnlEmpAttendance"
        pnlEmpAttendance.Size = New Size(987, 652)
        pnlEmpAttendance.TabIndex = 19
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(183), CByte(189), CByte(248))
        Label14.Font = New Font("Coolvetica Rg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Label14.Location = New Point(867, 0)
        Label14.Margin = New Padding(10)
        Label14.Name = "Label14"
        Label14.Padding = New Padding(4, 6, 4, 6)
        Label14.Size = New Size(120, 31)
        Label14.TabIndex = 30
        Label14.Text = "> Attendance <"
        ' 
        ' dgvAttendance
        ' 
        dgvAttendance.BackgroundColor = Color.FromArgb(CByte(91), CByte(96), CByte(120))
        dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAttendance.Columns.AddRange(New DataGridViewColumn() {searchID, searchName, searchTimeIn, searchTimeOut})
        dgvAttendance.Location = New Point(15, 68)
        dgvAttendance.Name = "dgvAttendance"
        dgvAttendance.Size = New Size(960, 572)
        dgvAttendance.TabIndex = 29
        ' 
        ' searchID
        ' 
        searchID.HeaderText = "ID"
        searchID.Name = "searchID"
        searchID.ReadOnly = True
        searchID.Width = 200
        ' 
        ' searchName
        ' 
        searchName.HeaderText = "Name"
        searchName.Name = "searchName"
        searchName.ReadOnly = True
        searchName.Width = 172
        ' 
        ' searchTimeIn
        ' 
        searchTimeIn.HeaderText = "Time In"
        searchTimeIn.Name = "searchTimeIn"
        searchTimeIn.ReadOnly = True
        searchTimeIn.Width = 172
        ' 
        ' searchTimeOut
        ' 
        searchTimeOut.HeaderText = "Time Out"
        searchTimeOut.Name = "searchTimeOut"
        searchTimeOut.ReadOnly = True
        searchTimeOut.Width = 152
        ' 
        ' btnSearchAttendance
        ' 
        btnSearchAttendance.BackColor = Color.FromArgb(CByte(240), CByte(198), CByte(198))
        btnSearchAttendance.FlatStyle = FlatStyle.Flat
        btnSearchAttendance.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchAttendance.Location = New Point(466, 26)
        btnSearchAttendance.Name = "btnSearchAttendance"
        btnSearchAttendance.Size = New Size(75, 29)
        btnSearchAttendance.TabIndex = 28
        btnSearchAttendance.Text = "Search"
        btnSearchAttendance.UseVisualStyleBackColor = False
        ' 
        ' dtpAttendance
        ' 
        dtpAttendance.Location = New Point(168, 26)
        dtpAttendance.Name = "dtpAttendance"
        dtpAttendance.Size = New Size(292, 29)
        dtpAttendance.TabIndex = 20
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(240), CByte(198), CByte(198))
        Label16.Location = New Point(16, 29)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(145, 25)
        Label16.TabIndex = 19
        Label16.Text = "Search Date:"
        ' 
        ' pnlNewInstance
        ' 
        pnlNewInstance.Controls.Add(Label3)
        pnlNewInstance.Location = New Point(233, 28)
        pnlNewInstance.Name = "pnlNewInstance"
        pnlNewInstance.Size = New Size(987, 652)
        pnlNewInstance.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(430, 297)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 37)
        Label3.TabIndex = 0
        Label3.Text = "New Panel"
        ' 
        ' formEmployeeDash
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(58))
        ClientSize = New Size(1220, 680)
        Controls.Add(EmployeePanel)
        Controls.Add(pnlTitleBar)
        Controls.Add(pnlNewInstance)
        Controls.Add(pnlEmpAttendance)
        Font = New Font("Segoe UI", 12F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "formEmployeeDash"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Dashboard"
        EmployeePanel.ResumeLayout(False)
        EmployeePanel.PerformLayout()
        pnlTitleBar.ResumeLayout(False)
        pnlTitleBar.PerformLayout()
        pnlEmpAttendance.ResumeLayout(False)
        pnlEmpAttendance.PerformLayout()
        CType(dgvAttendance, ComponentModel.ISupportInitialize).EndInit()
        pnlNewInstance.ResumeLayout(False)
        pnlNewInstance.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents EmployeePanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEmployeeAttendance As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlEmpAttendance As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents dtpAttendance As DateTimePicker
    Friend WithEvents btnSearchAttendance As Button
    Friend WithEvents dgvAttendance As DataGridView
    Friend WithEvents searchID As DataGridViewTextBoxColumn
    Friend WithEvents searchName As DataGridViewTextBoxColumn
    Friend WithEvents searchTimeIn As DataGridViewTextBoxColumn
    Friend WithEvents searchTimeOut As DataGridViewTextBoxColumn
    Friend WithEvents btnNewInstance As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents pnlNewInstance As Panel
    Friend WithEvents Label3 As Label
End Class
