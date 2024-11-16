<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        btnShift = New Button()
        Label1 = New Label()
        btnPayroll = New Button()
        btnViewAllAtt = New Button()
        btnManageAccs = New Button()
        btnViewEmployees = New Button()
        btnManageEmployees = New Button()
        btnLogout = New Button()
        pnlViewShift = New Panel()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        TextBox1 = New TextBox()
        pnlManageEmpFormA = New Panel()
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
        AdminPanel.SuspendLayout()
        pnlViewShift.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlManageEmpFormA.SuspendLayout()
        SuspendLayout()
        ' 
        ' AdminPanel
        ' 
        AdminPanel.BackColor = Color.CornflowerBlue
        AdminPanel.Controls.Add(btnShift)
        AdminPanel.Controls.Add(Label1)
        AdminPanel.Controls.Add(btnPayroll)
        AdminPanel.Controls.Add(btnViewAllAtt)
        AdminPanel.Controls.Add(btnManageAccs)
        AdminPanel.Controls.Add(btnViewEmployees)
        AdminPanel.Controls.Add(btnManageEmployees)
        AdminPanel.Controls.Add(btnLogout)
        AdminPanel.Location = New Point(0, -2)
        AdminPanel.Margin = New Padding(3, 4, 3, 4)
        AdminPanel.Name = "AdminPanel"
        AdminPanel.Size = New Size(235, 549)
        AdminPanel.TabIndex = 2
        ' 
        ' btnShift
        ' 
        btnShift.BackColor = Color.LightBlue
        btnShift.FlatStyle = FlatStyle.Popup
        btnShift.Location = New Point(16, 427)
        btnShift.Margin = New Padding(3, 4, 3, 4)
        btnShift.Name = "btnShift"
        btnShift.Size = New Size(199, 45)
        btnShift.TabIndex = 8
        btnShift.Text = "View Shift Log"
        btnShift.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Helvetica", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(16, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 84)
        Label1.TabIndex = 7
        Label1.Text = "Admin Dashboard"
        ' 
        ' btnPayroll
        ' 
        btnPayroll.BackColor = Color.LightBlue
        btnPayroll.FlatStyle = FlatStyle.Popup
        btnPayroll.Location = New Point(16, 374)
        btnPayroll.Margin = New Padding(3, 4, 3, 4)
        btnPayroll.Name = "btnPayroll"
        btnPayroll.Size = New Size(199, 45)
        btnPayroll.TabIndex = 6
        btnPayroll.Text = "Payroll"
        btnPayroll.UseVisualStyleBackColor = False
        ' 
        ' btnViewAllAtt
        ' 
        btnViewAllAtt.BackColor = Color.LightBlue
        btnViewAllAtt.FlatStyle = FlatStyle.Popup
        btnViewAllAtt.Location = New Point(16, 319)
        btnViewAllAtt.Margin = New Padding(3, 4, 3, 4)
        btnViewAllAtt.Name = "btnViewAllAtt"
        btnViewAllAtt.Size = New Size(199, 47)
        btnViewAllAtt.TabIndex = 5
        btnViewAllAtt.Text = "View All Attendance"
        btnViewAllAtt.UseVisualStyleBackColor = False
        ' 
        ' btnManageAccs
        ' 
        btnManageAccs.BackColor = Color.LightBlue
        btnManageAccs.FlatStyle = FlatStyle.Popup
        btnManageAccs.Location = New Point(16, 269)
        btnManageAccs.Margin = New Padding(3, 4, 3, 4)
        btnManageAccs.Name = "btnManageAccs"
        btnManageAccs.Size = New Size(199, 42)
        btnManageAccs.TabIndex = 4
        btnManageAccs.Text = "Manage Accounts"
        btnManageAccs.UseVisualStyleBackColor = False
        ' 
        ' btnViewEmployees
        ' 
        btnViewEmployees.BackColor = Color.LightBlue
        btnViewEmployees.FlatStyle = FlatStyle.Popup
        btnViewEmployees.Location = New Point(16, 216)
        btnViewEmployees.Margin = New Padding(3, 4, 3, 4)
        btnViewEmployees.Name = "btnViewEmployees"
        btnViewEmployees.Size = New Size(199, 45)
        btnViewEmployees.TabIndex = 3
        btnViewEmployees.Text = "View Employees"
        btnViewEmployees.UseVisualStyleBackColor = False
        ' 
        ' btnManageEmployees
        ' 
        btnManageEmployees.BackColor = Color.LightBlue
        btnManageEmployees.FlatStyle = FlatStyle.Popup
        btnManageEmployees.Location = New Point(16, 161)
        btnManageEmployees.Margin = New Padding(3, 4, 3, 4)
        btnManageEmployees.Name = "btnManageEmployees"
        btnManageEmployees.Size = New Size(199, 47)
        btnManageEmployees.TabIndex = 2
        btnManageEmployees.Text = "Manage Employees"
        btnManageEmployees.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.LightPink
        btnLogout.FlatStyle = FlatStyle.Popup
        btnLogout.Location = New Point(61, 503)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(109, 33)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseMnemonic = False
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlViewShift
        ' 
        pnlViewShift.BackColor = Color.Cornsilk
        pnlViewShift.Controls.Add(DataGridView1)
        pnlViewShift.Controls.Add(Label2)
        pnlViewShift.Controls.Add(Label3)
        pnlViewShift.Controls.Add(Label4)
        pnlViewShift.Controls.Add(Button1)
        pnlViewShift.Controls.Add(TextBox1)
        pnlViewShift.Location = New Point(225, -2)
        pnlViewShift.Name = "pnlViewShift"
        pnlViewShift.Size = New Size(698, 549)
        pnlViewShift.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(28, 191)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(642, 346)
        DataGridView1.TabIndex = 7
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Column2"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Column3"
        Column3.Name = "Column3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(135, 76)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(431, 25)
        Label2.TabIndex = 6
        Label2.Text = "These are the employees on shift today.."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.DimGray
        Label3.Location = New Point(28, 11)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 12)
        Label3.TabIndex = 11
        Label3.Text = "> Viewing Employees..."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(36, 154)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 25)
        Label4.TabIndex = 10
        Label4.Text = "Search User:"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightCyan
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(574, 154)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 29)
        Button1.TabIndex = 9
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(160, 154)
        TextBox1.Margin = New Padding(4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(406, 29)
        TextBox1.TabIndex = 8
        ' 
        ' pnlManageEmpFormA
        ' 
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
        pnlManageEmpFormA.Location = New Point(225, -2)
        pnlManageEmpFormA.Name = "pnlManageEmpFormA"
        pnlManageEmpFormA.Size = New Size(698, 549)
        pnlManageEmpFormA.TabIndex = 12
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        ComboBox1.Location = New Point(365, 216)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(251, 29)
        ComboBox1.TabIndex = 14
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(365, 191)
        Label12.Name = "Label12"
        Label12.Size = New Size(73, 17)
        Label12.TabIndex = 12
        Label12.Text = "GENDER"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(365, 134)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(251, 29)
        DateTimePicker1.TabIndex = 11
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(365, 114)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 17)
        Label11.TabIndex = 10
        Label11.Text = "BIRTH DATE"
        ' 
        ' TextBox5
        ' 
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Location = New Point(28, 384)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(253, 29)
        TextBox5.TabIndex = 9
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(28, 349)
        Label10.Name = "Label10"
        Label10.Size = New Size(96, 17)
        Label10.TabIndex = 8
        Label10.Text = "LAST NAME"
        ' 
        ' TextBox4
        ' 
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Location = New Point(28, 298)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(253, 29)
        TextBox4.TabIndex = 7
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(28, 269)
        Label9.Name = "Label9"
        Label9.Size = New Size(115, 17)
        Label9.TabIndex = 6
        Label9.Text = "MIDDLE NAME"
        ' 
        ' TextBox3
        ' 
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Location = New Point(28, 216)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(253, 29)
        TextBox3.TabIndex = 5
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(28, 191)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 17)
        Label8.TabIndex = 4
        Label8.Text = "FIRST NAME"
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(28, 134)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(253, 29)
        TextBox2.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(28, 114)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 17)
        Label7.TabIndex = 2
        Label7.Text = "Employee ID"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DimGray
        Label6.Location = New Point(28, 57)
        Label6.Name = "Label6"
        Label6.Size = New Size(377, 13)
        Label6.TabIndex = 1
        Label6.Text = "Please fill out the following. Make sure to enter the correct information."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Helvetica", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(28, 38)
        Label5.Name = "Label5"
        Label5.Size = New Size(147, 19)
        Label5.TabIndex = 0
        Label5.Text = "Employee Details"
        ' 
        ' formMain
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cornsilk
        ClientSize = New Size(923, 547)
        ControlBox = False
        Controls.Add(pnlManageEmpFormA)
        Controls.Add(pnlViewShift)
        Controls.Add(AdminPanel)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MdiChildrenMinimizedAnchorBottom = False
        MinimizeBox = False
        Name = "formMain"
        Text = "Admin Dashboard"
        AdminPanel.ResumeLayout(False)
        pnlViewShift.ResumeLayout(False)
        pnlViewShift.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlManageEmpFormA.ResumeLayout(False)
        pnlManageEmpFormA.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents AdminPanel As Panel
    Friend WithEvents btnPayroll As Button
    Friend WithEvents btnViewAllAtt As Button
    Friend WithEvents btnManageAccs As Button
    Friend WithEvents btnViewEmployees As Button
    Friend WithEvents btnManageEmployees As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlViewShift As Panel

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pnlManageEmpFormA As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnShift As Button
End Class
