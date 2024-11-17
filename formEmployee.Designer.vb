<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEmployee
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
        pnlEmployee = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        btnClockShift = New Button()
        btnLogout = New Button()
        pnlClockShift = New Panel()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Button6 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        pnlEmployee.SuspendLayout()
        pnlClockShift.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlEmployee
        ' 
        pnlEmployee.BackColor = Color.DarkOrange
        pnlEmployee.Controls.Add(Button3)
        pnlEmployee.Controls.Add(Button2)
        pnlEmployee.Controls.Add(Button1)
        pnlEmployee.Controls.Add(Label2)
        pnlEmployee.Controls.Add(btnClockShift)
        pnlEmployee.Controls.Add(btnLogout)
        pnlEmployee.Location = New Point(0, -10)
        pnlEmployee.Margin = New Padding(3, 4, 3, 4)
        pnlEmployee.Name = "pnlEmployee"
        pnlEmployee.Size = New Size(245, 568)
        pnlEmployee.TabIndex = 3
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightBlue
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(16, 384)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(199, 45)
        Button3.TabIndex = 10
        Button3.Text = "View Payroll"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightBlue
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(16, 322)
        Button2.Margin = New Padding(3, 4, 3, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(199, 45)
        Button2.TabIndex = 9
        Button2.Text = "View Attendance"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightBlue
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(16, 259)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(199, 45)
        Button1.TabIndex = 8
        Button1.Text = "Profile"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Helvetica", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(16, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(203, 84)
        Label2.TabIndex = 7
        Label2.Text = "Employee Dashboard"
        ' 
        ' btnClockShift
        ' 
        btnClockShift.BackColor = Color.LightBlue
        btnClockShift.FlatStyle = FlatStyle.Popup
        btnClockShift.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClockShift.Location = New Point(16, 196)
        btnClockShift.Margin = New Padding(3, 4, 3, 4)
        btnClockShift.Name = "btnClockShift"
        btnClockShift.Size = New Size(199, 45)
        btnClockShift.TabIndex = 3
        btnClockShift.Text = "Clock-In"
        btnClockShift.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.Crimson
        btnLogout.FlatStyle = FlatStyle.Popup
        btnLogout.ForeColor = Color.WhiteSmoke
        btnLogout.Location = New Point(61, 503)
        btnLogout.Margin = New Padding(3, 4, 3, 4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(109, 33)
        btnLogout.TabIndex = 1
        btnLogout.Text = "Logout"
        btnLogout.UseMnemonic = False
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlClockShift
        ' 
        pnlClockShift.BackColor = Color.CornflowerBlue
        pnlClockShift.Controls.Add(Label3)
        pnlClockShift.Controls.Add(DataGridView1)
        pnlClockShift.Controls.Add(Button6)
        pnlClockShift.Controls.Add(Button4)
        pnlClockShift.Controls.Add(Label1)
        pnlClockShift.Location = New Point(242, -10)
        pnlClockShift.Name = "pnlClockShift"
        pnlClockShift.Size = New Size(683, 568)
        pnlClockShift.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkOrange
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(0, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 15)
        Label3.TabIndex = 14
        Label3.Text = "Clock-In"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.DimGray
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(32, 162)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(621, 374)
        DataGridView1.TabIndex = 13
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.LightCoral
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(382, 110)
        Button6.Margin = New Padding(3, 4, 3, 4)
        Button6.Name = "Button6"
        Button6.Size = New Size(199, 45)
        Button6.TabIndex = 12
        Button6.Text = "Time Out"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.PaleGreen
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(91, 110)
        Button4.Margin = New Padding(3, 4, 3, 4)
        Button4.Name = "Button4"
        Button4.Size = New Size(199, 45)
        Button4.TabIndex = 11
        Button4.Text = "Time in"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Helvetica", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(200, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(272, 45)
        Label1.TabIndex = 0
        Label1.Text = "Date and Time"
        ' 
        ' formEmployee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(924, 551)
        ControlBox = False
        Controls.Add(pnlClockShift)
        Controls.Add(pnlEmployee)
        MaximizeBox = False
        MinimizeBox = False
        Name = "formEmployee"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Employee Dashboard"
        pnlEmployee.ResumeLayout(False)
        pnlClockShift.ResumeLayout(False)
        pnlClockShift.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlEmployee As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClockShift As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents pnlClockShift As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
End Class
