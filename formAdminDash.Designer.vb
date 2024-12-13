<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAdminDash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAdminDash))
        AdminPanel = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        btnShift = New Button()
        btnPayroll = New Button()
        btnViewAllAtt = New Button()
        btnManageAccs = New Button()
        btnViewEmployees = New Button()
        btnManageEmployees = New Button()
        btnLogout = New Button()
        pnlManageEmpFormA = New Panel()
        Label13 = New Label()
        ComboBox1 = New ComboBox()
        Label12 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label11 = New Label()
        TextBox5 = New TextBox()
        Label10 = New Label()
        TextBox4 = New TextBox()
        Label9 = New Label()
        TextBox3 = New TextBox()
        Label8 = New Label()
        TextBox2 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        pnlViewShift = New Panel()
        Label3 = New Label()
        dataGridEmployees = New DataGridView()
        columnID = New DataGridViewTextBoxColumn()
        columnName = New DataGridViewTextBoxColumn()
        columnTime = New DataGridViewTextBoxColumn()
        columnDate = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        Label15 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        pnlTitleBar = New Panel()
        Label22 = New Label()
        btnExit = New Button()
        pnlViewAttendance = New Panel()
        Label21 = New Label()
        dgvSearchAttendance = New DataGridView()
        searchID = New DataGridViewTextBoxColumn()
        searchFirstName = New DataGridViewTextBoxColumn()
        searchLastName = New DataGridViewTextBoxColumn()
        searchDate = New DataGridViewTextBoxColumn()
        btnSearchAttendance = New Button()
        dtpSearchAttendanceDate = New DateTimePicker()
        Label20 = New Label()
        txtLName = New TextBox()
        Label19 = New Label()
        txtFName = New TextBox()
        Label18 = New Label()
        txtEmpID = New TextBox()
        Label17 = New Label()
        Label16 = New Label()
        Label14 = New Label()
        AdminPanel.SuspendLayout()
        pnlManageEmpFormA.SuspendLayout()
        pnlViewShift.SuspendLayout()
        CType(dataGridEmployees, ComponentModel.ISupportInitialize).BeginInit()
        pnlTitleBar.SuspendLayout()
        pnlViewAttendance.SuspendLayout()
        CType(dgvSearchAttendance, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' AdminPanel
        ' 
        AdminPanel.BackColor = Color.FromArgb(CByte(31), CByte(32), CByte(48))
        AdminPanel.Controls.Add(Label1)
        AdminPanel.Controls.Add(Label2)
        AdminPanel.Controls.Add(btnShift)
        AdminPanel.Controls.Add(btnPayroll)
        AdminPanel.Controls.Add(btnViewAllAtt)
        AdminPanel.Controls.Add(btnManageAccs)
        AdminPanel.Controls.Add(btnViewEmployees)
        AdminPanel.Controls.Add(btnManageEmployees)
        AdminPanel.Controls.Add(btnLogout)
        AdminPanel.Location = New Point(-2, -8)
        AdminPanel.Margin = New Padding(3, 4, 3, 4)
        AdminPanel.Name = "AdminPanel"
        AdminPanel.Size = New Size(241, 688)
        AdminPanel.TabIndex = 2
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
        Label1.Text = "Admin Dashboard"
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
        ' btnShift
        ' 
        btnShift.Anchor = AnchorStyles.None
        btnShift.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnShift.FlatStyle = FlatStyle.Popup
        btnShift.Location = New Point(20, 460)
        btnShift.Margin = New Padding(3, 4, 3, 4)
        btnShift.Name = "btnShift"
        btnShift.Size = New Size(199, 50)
        btnShift.TabIndex = 8
        btnShift.Text = "View Shift Log"
        btnShift.UseVisualStyleBackColor = False
        ' 
        ' btnPayroll
        ' 
        btnPayroll.Anchor = AnchorStyles.None
        btnPayroll.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnPayroll.FlatStyle = FlatStyle.Popup
        btnPayroll.Location = New Point(20, 410)
        btnPayroll.Margin = New Padding(3, 4, 3, 4)
        btnPayroll.Name = "btnPayroll"
        btnPayroll.Size = New Size(199, 50)
        btnPayroll.TabIndex = 6
        btnPayroll.Text = "Payroll"
        btnPayroll.UseVisualStyleBackColor = False
        ' 
        ' btnViewAllAtt
        ' 
        btnViewAllAtt.Anchor = AnchorStyles.None
        btnViewAllAtt.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnViewAllAtt.FlatStyle = FlatStyle.Popup
        btnViewAllAtt.Location = New Point(20, 357)
        btnViewAllAtt.Margin = New Padding(3, 4, 3, 4)
        btnViewAllAtt.Name = "btnViewAllAtt"
        btnViewAllAtt.Size = New Size(199, 53)
        btnViewAllAtt.TabIndex = 5
        btnViewAllAtt.Text = "View Attendance"
        btnViewAllAtt.UseVisualStyleBackColor = False
        ' 
        ' btnManageAccs
        ' 
        btnManageAccs.Anchor = AnchorStyles.None
        btnManageAccs.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnManageAccs.FlatStyle = FlatStyle.Popup
        btnManageAccs.Location = New Point(20, 310)
        btnManageAccs.Margin = New Padding(3, 4, 3, 4)
        btnManageAccs.Name = "btnManageAccs"
        btnManageAccs.Size = New Size(199, 47)
        btnManageAccs.TabIndex = 4
        btnManageAccs.Text = "Manage Accounts"
        btnManageAccs.UseVisualStyleBackColor = False
        ' 
        ' btnViewEmployees
        ' 
        btnViewEmployees.Anchor = AnchorStyles.None
        btnViewEmployees.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnViewEmployees.FlatStyle = FlatStyle.Popup
        btnViewEmployees.Location = New Point(20, 260)
        btnViewEmployees.Margin = New Padding(3, 4, 3, 4)
        btnViewEmployees.Name = "btnViewEmployees"
        btnViewEmployees.Size = New Size(199, 50)
        btnViewEmployees.TabIndex = 3
        btnViewEmployees.Text = "View Employees"
        btnViewEmployees.UseVisualStyleBackColor = False
        ' 
        ' btnManageEmployees
        ' 
        btnManageEmployees.Anchor = AnchorStyles.None
        btnManageEmployees.BackColor = Color.FromArgb(CByte(138), CByte(173), CByte(244))
        btnManageEmployees.FlatStyle = FlatStyle.Popup
        btnManageEmployees.Location = New Point(20, 207)
        btnManageEmployees.Margin = New Padding(3, 4, 3, 4)
        btnManageEmployees.Name = "btnManageEmployees"
        btnManageEmployees.Size = New Size(199, 53)
        btnManageEmployees.TabIndex = 2
        btnManageEmployees.Text = "Manage Employees"
        btnManageEmployees.UseVisualStyleBackColor = False
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
        ' pnlManageEmpFormA
        ' 
        pnlManageEmpFormA.BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(58))
        pnlManageEmpFormA.Controls.Add(Label13)
        pnlManageEmpFormA.Controls.Add(ComboBox1)
        pnlManageEmpFormA.Controls.Add(Label12)
        pnlManageEmpFormA.Controls.Add(DateTimePicker1)
        pnlManageEmpFormA.Controls.Add(Label11)
        pnlManageEmpFormA.Controls.Add(TextBox5)
        pnlManageEmpFormA.Controls.Add(Label10)
        pnlManageEmpFormA.Controls.Add(TextBox4)
        pnlManageEmpFormA.Controls.Add(Label9)
        pnlManageEmpFormA.Controls.Add(TextBox3)
        pnlManageEmpFormA.Controls.Add(Label8)
        pnlManageEmpFormA.Controls.Add(TextBox2)
        pnlManageEmpFormA.Controls.Add(Label7)
        pnlManageEmpFormA.Controls.Add(Label6)
        pnlManageEmpFormA.Controls.Add(Label5)
        pnlManageEmpFormA.Location = New Point(233, 28)
        pnlManageEmpFormA.Name = "pnlManageEmpFormA"
        pnlManageEmpFormA.Size = New Size(987, 652)
        pnlManageEmpFormA.TabIndex = 14
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.FromArgb(CByte(183), CByte(189), CByte(248))
        Label13.Font = New Font("Coolvetica Rg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Label13.Location = New Point(818, 0)
        Label13.Margin = New Padding(10)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(4, 6, 4, 6)
        Label13.Size = New Size(169, 31)
        Label13.TabIndex = 15
        Label13.Text = "> Manage Employees <"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        ComboBox1.Location = New Point(365, 252)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(252, 29)
        ComboBox1.TabIndex = 14
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.WhiteSmoke
        Label12.Location = New Point(365, 227)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 17)
        Label12.TabIndex = 12
        Label12.Text = "GENDER"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(365, 170)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(252, 29)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.WhiteSmoke
        Label11.Location = New Point(365, 150)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 17)
        Label11.TabIndex = 10
        Label11.Text = "BIRTH DATE"
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(29, 420)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(253, 29)
        TextBox5.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.WhiteSmoke
        Label10.Location = New Point(29, 385)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 17)
        Label10.TabIndex = 8
        Label10.Text = "LAST NAME"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(29, 334)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(253, 29)
        TextBox4.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.WhiteSmoke
        Label9.Location = New Point(29, 305)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 17)
        Label9.TabIndex = 6
        Label9.Text = "MIDDLE NAME"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(29, 252)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(253, 29)
        TextBox3.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(29, 227)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 17)
        Label8.TabIndex = 4
        Label8.Text = "FIRST NAME"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(29, 170)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(253, 29)
        TextBox2.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(29, 150)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 17)
        Label7.TabIndex = 2
        Label7.Text = "Employee ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Gainsboro
        Label6.Location = New Point(29, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(377, 13)
        Label6.TabIndex = 1
        Label6.Text = "Please fill out the following. Make sure to enter the correct information."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(29, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 19)
        Label5.TabIndex = 0
        Label5.Text = "Employee Details"
        ' 
        ' pnlViewShift
        ' 
        pnlViewShift.BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(58))
        pnlViewShift.Controls.Add(Label3)
        pnlViewShift.Controls.Add(dataGridEmployees)
        pnlViewShift.Controls.Add(Label4)
        pnlViewShift.Controls.Add(Label15)
        pnlViewShift.Controls.Add(Button1)
        pnlViewShift.Controls.Add(TextBox1)
        pnlViewShift.Location = New Point(236, 28)
        pnlViewShift.Name = "pnlViewShift"
        pnlViewShift.Size = New Size(984, 652)
        pnlViewShift.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(183), CByte(189), CByte(248))
        Label3.Font = New Font("Coolvetica Rg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Label3.Location = New Point(851, -3)
        Label3.Margin = New Padding(10)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(4, 6, 4, 6)
        Label3.Size = New Size(136, 31)
        Label3.TabIndex = 16
        Label3.Text = "> View Shift Log <"
        ' 
        ' dataGridEmployees
        ' 
        dataGridEmployees.BackgroundColor = Color.FromArgb(CByte(91), CByte(96), CByte(120))
        dataGridEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dataGridEmployees.Columns.AddRange(New DataGridViewColumn() {columnID, columnName, columnTime, columnDate})
        dataGridEmployees.Location = New Point(10, 149)
        dataGridEmployees.Margin = New Padding(4)
        dataGridEmployees.Name = "dataGridEmployees"
        dataGridEmployees.Size = New Size(963, 486)
        dataGridEmployees.TabIndex = 7
        ' 
        ' columnID
        ' 
        columnID.HeaderText = "ID"
        columnID.Name = "columnID"
        columnID.Width = 130
        ' 
        ' columnName
        ' 
        columnName.HeaderText = "Name"
        columnName.Name = "columnName"
        columnName.Width = 130
        ' 
        ' columnTime
        ' 
        columnTime.HeaderText = "Time"
        columnTime.Name = "columnTime"
        columnTime.Width = 130
        ' 
        ' columnDate
        ' 
        columnDate.HeaderText = "Date"
        columnDate.Name = "columnDate"
        columnDate.Width = 130
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(240), CByte(198), CByte(198))
        Label4.Location = New Point(10, 36)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(274, 25)
        Label4.TabIndex = 6
        Label4.Text = "Employees on shift today"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(244), CByte(219), CByte(214))
        Label15.Location = New Point(10, 87)
        Label15.Margin = New Padding(4, 0, 4, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(122, 25)
        Label15.TabIndex = 10
        Label15.Text = "Search User:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCyan
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(427, 114)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 29)
        Button1.TabIndex = 9
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(13, 114)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(406, 29)
        TextBox1.TabIndex = 8
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.BackColor = Color.FromArgb(CByte(24), CByte(25), CByte(38))
        pnlTitleBar.Controls.Add(Label22)
        pnlTitleBar.Controls.Add(btnExit)
        pnlTitleBar.Location = New Point(-2, 1)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(1222, 24)
        pnlTitleBar.TabIndex = 17
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.ForeColor = Color.WhiteSmoke
        Label22.Location = New Point(248, 6)
        Label22.Name = "Label22"
        Label22.Size = New Size(129, 13)
        Label22.TabIndex = 1
        Label22.Text = "Payroll System (Admin)"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Transparent
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.IndianRed
        btnExit.Location = New Point(1191, 1)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(28, 23)
        btnExit.TabIndex = 0
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' pnlViewAttendance
        ' 
        pnlViewAttendance.BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(58))
        pnlViewAttendance.Controls.Add(Label21)
        pnlViewAttendance.Controls.Add(dgvSearchAttendance)
        pnlViewAttendance.Controls.Add(btnSearchAttendance)
        pnlViewAttendance.Controls.Add(dtpSearchAttendanceDate)
        pnlViewAttendance.Controls.Add(Label20)
        pnlViewAttendance.Controls.Add(txtLName)
        pnlViewAttendance.Controls.Add(Label19)
        pnlViewAttendance.Controls.Add(txtFName)
        pnlViewAttendance.Controls.Add(Label18)
        pnlViewAttendance.Controls.Add(txtEmpID)
        pnlViewAttendance.Controls.Add(Label17)
        pnlViewAttendance.Controls.Add(Label16)
        pnlViewAttendance.Controls.Add(Label14)
        pnlViewAttendance.Location = New Point(236, 28)
        pnlViewAttendance.Name = "pnlViewAttendance"
        pnlViewAttendance.Size = New Size(984, 652)
        pnlViewAttendance.TabIndex = 17
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.BackColor = Color.Transparent
        Label21.Font = New Font("Helvetica", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label21.ForeColor = Color.DarkGray
        Label21.Location = New Point(13, 65)
        Label21.Margin = New Padding(4, 0, 4, 0)
        Label21.Name = "Label21"
        Label21.Size = New Size(221, 14)
        Label21.TabIndex = 29
        Label21.Text = "Fill up the following to search the index."
        ' 
        ' dgvSearchAttendance
        ' 
        dgvSearchAttendance.BackgroundColor = Color.FromArgb(CByte(91), CByte(96), CByte(120))
        dgvSearchAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSearchAttendance.Columns.AddRange(New DataGridViewColumn() {searchID, searchFirstName, searchLastName, searchDate})
        dgvSearchAttendance.Location = New Point(232, 103)
        dgvSearchAttendance.Name = "dgvSearchAttendance"
        dgvSearchAttendance.Size = New Size(739, 532)
        dgvSearchAttendance.TabIndex = 28
        ' 
        ' searchID
        ' 
        searchID.HeaderText = "ID"
        searchID.Name = "searchID"
        searchID.ReadOnly = True
        searchID.Width = 200
        ' 
        ' searchFirstName
        ' 
        searchFirstName.HeaderText = "First Name"
        searchFirstName.Name = "searchFirstName"
        searchFirstName.ReadOnly = True
        searchFirstName.Width = 172
        ' 
        ' searchLastName
        ' 
        searchLastName.HeaderText = "Last Name"
        searchLastName.Name = "searchLastName"
        searchLastName.ReadOnly = True
        searchLastName.Width = 172
        ' 
        ' searchDate
        ' 
        searchDate.HeaderText = "Date"
        searchDate.Name = "searchDate"
        searchDate.ReadOnly = True
        searchDate.Width = 152
        ' 
        ' btnSearchAttendance
        ' 
        btnSearchAttendance.BackColor = Color.FromArgb(CByte(240), CByte(198), CByte(198))
        btnSearchAttendance.FlatStyle = FlatStyle.Flat
        btnSearchAttendance.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearchAttendance.Location = New Point(13, 417)
        btnSearchAttendance.Name = "btnSearchAttendance"
        btnSearchAttendance.Size = New Size(75, 32)
        btnSearchAttendance.TabIndex = 27
        btnSearchAttendance.Text = "Search"
        btnSearchAttendance.UseVisualStyleBackColor = False
        ' 
        ' dtpSearchAttendanceDate
        ' 
        dtpSearchAttendanceDate.Location = New Point(13, 361)
        dtpSearchAttendanceDate.Name = "dtpSearchAttendanceDate"
        dtpSearchAttendanceDate.Size = New Size(203, 29)
        dtpSearchAttendanceDate.TabIndex = 26
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Font = New Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.ForeColor = Color.WhiteSmoke
        Label20.Location = New Point(10, 337)
        Label20.Margin = New Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(46, 19)
        Label20.TabIndex = 25
        Label20.Text = "Date"
        ' 
        ' txtLName
        ' 
        txtLName.Location = New Point(13, 291)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(203, 29)
        txtLName.TabIndex = 24
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Font = New Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.ForeColor = Color.WhiteSmoke
        Label19.Location = New Point(10, 262)
        Label19.Margin = New Padding(4, 0, 4, 0)
        Label19.Name = "Label19"
        Label19.Size = New Size(92, 19)
        Label19.TabIndex = 23
        Label19.Text = "Last Name"
        ' 
        ' txtFName
        ' 
        txtFName.Location = New Point(13, 216)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(203, 29)
        txtFName.TabIndex = 22
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Transparent
        Label18.Font = New Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.WhiteSmoke
        Label18.Location = New Point(10, 187)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(92, 19)
        Label18.TabIndex = 21
        Label18.Text = "First Name"
        ' 
        ' txtEmpID
        ' 
        txtEmpID.Location = New Point(13, 138)
        txtEmpID.Name = "txtEmpID"
        txtEmpID.Size = New Size(203, 29)
        txtEmpID.TabIndex = 20
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Font = New Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.WhiteSmoke
        Label17.Location = New Point(10, 109)
        Label17.Margin = New Padding(4, 0, 4, 0)
        Label17.Name = "Label17"
        Label17.Size = New Size(108, 19)
        Label17.TabIndex = 19
        Label17.Text = "Empolyee ID"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Font = New Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.ForeColor = Color.FromArgb(CByte(240), CByte(198), CByte(198))
        Label16.Location = New Point(10, 36)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(206, 25)
        Label16.TabIndex = 18
        Label16.Text = "Search Attendance"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = Color.FromArgb(CByte(183), CByte(189), CByte(248))
        Label14.Font = New Font("Coolvetica Rg", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Label14.Location = New Point(830, 0)
        Label14.Margin = New Padding(10)
        Label14.Name = "Label14"
        Label14.Padding = New Padding(4, 6, 4, 6)
        Label14.Size = New Size(154, 31)
        Label14.TabIndex = 17
        Label14.Text = "> View Attendance <"
        ' 
        ' formAdminDash
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(36), CByte(39), CByte(58))
        ClientSize = New Size(1220, 680)
        ControlBox = False
        Controls.Add(AdminPanel)
        Controls.Add(pnlViewAttendance)
        Controls.Add(pnlViewShift)
        Controls.Add(pnlManageEmpFormA)
        Controls.Add(pnlTitleBar)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "formAdminDash"
        Padding = New Padding(10)
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payroll System (Admin)"
        AdminPanel.ResumeLayout(False)
        AdminPanel.PerformLayout()
        pnlManageEmpFormA.ResumeLayout(False)
        pnlManageEmpFormA.PerformLayout()
        pnlViewShift.ResumeLayout(False)
        pnlViewShift.PerformLayout()
        CType(dataGridEmployees, ComponentModel.ISupportInitialize).EndInit()
        pnlTitleBar.ResumeLayout(False)
        pnlTitleBar.PerformLayout()
        pnlViewAttendance.ResumeLayout(False)
        pnlViewAttendance.PerformLayout()
        CType(dgvSearchAttendance, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents btnViewAllAtt As Button
    Friend WithEvents btnManageAccs As Button
    Friend WithEvents btnViewEmployees As Button
    Friend WithEvents btnManageEmployees As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Friend WithEvents btnShift As Button
    Friend WithEvents btnPayroll As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pnlManageEmpFormA As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents pnlViewShift As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dataGridEmployees As DataGridView
    Friend WithEvents columnID As DataGridViewTextBoxColumn
    Friend WithEvents columnName As DataGridViewTextBoxColumn
    Friend WithEvents columnTime As DataGridViewTextBoxColumn
    Friend WithEvents columnDate As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pnlTitleBar As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents pnlViewAttendance As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSearchAttendance As Button
    Friend WithEvents dtpSearchAttendanceDate As DateTimePicker
    Friend WithEvents Label20 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtEmpID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvSearchAttendance As DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents searchID As DataGridViewTextBoxColumn
    Friend WithEvents searchFirstName As DataGridViewTextBoxColumn
    Friend WithEvents searchLastName As DataGridViewTextBoxColumn
    Friend WithEvents searchDate As DataGridViewTextBoxColumn
    Friend WithEvents Label22 As Label
End Class
