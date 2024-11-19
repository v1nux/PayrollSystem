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
        btnExit = New Button()
        AdminPanel.SuspendLayout()
        pnlManageEmpFormA.SuspendLayout()
        pnlViewShift.SuspendLayout()
        CType(dataGridEmployees, ComponentModel.ISupportInitialize).BeginInit()
        pnlTitleBar.SuspendLayout()
        SuspendLayout()
        ' 
        ' AdminPanel
        ' 
        AdminPanel.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        AdminPanel.Controls.Add(Label1)
        AdminPanel.Controls.Add(Label2)
        AdminPanel.Controls.Add(btnShift)
        AdminPanel.Controls.Add(btnPayroll)
        AdminPanel.Controls.Add(btnViewAllAtt)
        AdminPanel.Controls.Add(btnManageAccs)
        AdminPanel.Controls.Add(btnViewEmployees)
        AdminPanel.Controls.Add(btnManageEmployees)
        AdminPanel.Controls.Add(btnLogout)
        AdminPanel.Location = New Point(1, 28)
        AdminPanel.Margin = New Padding(3, 4, 3, 4)
        AdminPanel.Name = "AdminPanel"
        AdminPanel.Size = New Size(235, 651)
        AdminPanel.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(0))
        Label1.Font = New Font("Helvetica", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        Label1.Location = New Point(0, 2)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10)
        Label1.Size = New Size(235, 106)
        Label1.TabIndex = 7
        Label1.Text = "Admin Dashboard"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Coolvetica Rg", 11.9999981F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 19)
        Label2.TabIndex = 10
        Label2.Text = "Menu"
        ' 
        ' btnShift
        ' 
        btnShift.BackColor = Color.Tomato
        btnShift.FlatStyle = FlatStyle.Popup
        btnShift.Location = New Point(0, 405)
        btnShift.Margin = New Padding(3, 4, 3, 4)
        btnShift.Name = "btnShift"
        btnShift.Size = New Size(199, 50)
        btnShift.TabIndex = 8
        btnShift.Text = "View Shift Log"
        btnShift.UseVisualStyleBackColor = False
        ' 
        ' btnPayroll
        ' 
        btnPayroll.BackColor = Color.Tomato
        btnPayroll.FlatStyle = FlatStyle.Popup
        btnPayroll.Location = New Point(0, 355)
        btnPayroll.Margin = New Padding(3, 4, 3, 4)
        btnPayroll.Name = "btnPayroll"
        btnPayroll.Size = New Size(199, 50)
        btnPayroll.TabIndex = 6
        btnPayroll.Text = "Payroll"
        btnPayroll.UseVisualStyleBackColor = False
        ' 
        ' btnViewAllAtt
        ' 
        btnViewAllAtt.BackColor = Color.Tomato
        btnViewAllAtt.FlatStyle = FlatStyle.Popup
        btnViewAllAtt.Location = New Point(0, 302)
        btnViewAllAtt.Margin = New Padding(3, 4, 3, 4)
        btnViewAllAtt.Name = "btnViewAllAtt"
        btnViewAllAtt.Size = New Size(199, 53)
        btnViewAllAtt.TabIndex = 5
        btnViewAllAtt.Text = "View All Attendance"
        btnViewAllAtt.UseVisualStyleBackColor = False
        ' 
        ' btnManageAccs
        ' 
        btnManageAccs.BackColor = Color.Tomato
        btnManageAccs.FlatStyle = FlatStyle.Popup
        btnManageAccs.Location = New Point(0, 255)
        btnManageAccs.Margin = New Padding(3, 4, 3, 4)
        btnManageAccs.Name = "btnManageAccs"
        btnManageAccs.Size = New Size(199, 47)
        btnManageAccs.TabIndex = 4
        btnManageAccs.Text = "Manage Accounts"
        btnManageAccs.UseVisualStyleBackColor = False
        ' 
        ' btnViewEmployees
        ' 
        btnViewEmployees.BackColor = Color.Tomato
        btnViewEmployees.FlatStyle = FlatStyle.Popup
        btnViewEmployees.Location = New Point(0, 205)
        btnViewEmployees.Margin = New Padding(3, 4, 3, 4)
        btnViewEmployees.Name = "btnViewEmployees"
        btnViewEmployees.Size = New Size(199, 50)
        btnViewEmployees.TabIndex = 3
        btnViewEmployees.Text = "View Employees"
        btnViewEmployees.UseVisualStyleBackColor = False
        ' 
        ' btnManageEmployees
        ' 
        btnManageEmployees.BackColor = Color.Tomato
        btnManageEmployees.FlatStyle = FlatStyle.Popup
        btnManageEmployees.Location = New Point(0, 152)
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
        btnLogout.Location = New Point(0, 490)
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
        pnlManageEmpFormA.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
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
        Label13.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(0))
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
        pnlViewShift.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
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
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(73), CByte(0))
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
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(73), CByte(0))
        Label4.Location = New Point(29, 36)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(431, 25)
        Label4.TabIndex = 6
        Label4.Text = "These are the employees on shift today.."
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.ForeColor = Color.FromArgb(CByte(255), CByte(73), CByte(0))
        Label15.Location = New Point(29, 84)
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
        Button1.Location = New Point(446, 113)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 29)
        Button1.TabIndex = 9
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(32, 113)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(406, 29)
        TextBox1.TabIndex = 8
        ' 
        ' pnlTitleBar
        ' 
        pnlTitleBar.BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(30))
        pnlTitleBar.Controls.Add(btnExit)
        pnlTitleBar.Location = New Point(-2, 1)
        pnlTitleBar.Name = "pnlTitleBar"
        pnlTitleBar.Size = New Size(1222, 28)
        pnlTitleBar.TabIndex = 17
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.IndianRed
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(1191, 3)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(28, 23)
        btnExit.TabIndex = 0
        btnExit.Text = "X"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' formAdminDash
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        ClientSize = New Size(1220, 680)
        ControlBox = False
        Controls.Add(pnlViewShift)
        Controls.Add(pnlTitleBar)
        Controls.Add(AdminPanel)
        Controls.Add(pnlManageEmpFormA)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "formAdminDash"
        Padding = New Padding(10)
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Dashboard"
        AdminPanel.ResumeLayout(False)
        AdminPanel.PerformLayout()
        pnlManageEmpFormA.ResumeLayout(False)
        pnlManageEmpFormA.PerformLayout()
        pnlViewShift.ResumeLayout(False)
        pnlViewShift.PerformLayout()
        CType(dataGridEmployees, ComponentModel.ISupportInitialize).EndInit()
        pnlTitleBar.ResumeLayout(False)
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
End Class
