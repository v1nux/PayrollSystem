<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        pnlLoginForm = New Panel()
        linkForgot = New LinkLabel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        pnlForgotCred = New Panel()
        linkBack = New LinkLabel()
        btnCredReset = New Button()
        Label8 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        pnlLoginForm.SuspendLayout()
        Panel2.SuspendLayout()
        pnlForgotCred.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.LightSteelBlue
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(329, 164)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(312, 23)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.LightSteelBlue
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(329, 242)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(312, 23)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(238), CByte(187), CByte(196))
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(329, 308)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(118, 36)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' pnlLoginForm
        ' 
        pnlLoginForm.BackColor = Color.FromArgb(CByte(25), CByte(9), CByte(65))
        pnlLoginForm.Controls.Add(linkForgot)
        pnlLoginForm.Controls.Add(Label4)
        pnlLoginForm.Controls.Add(Label3)
        pnlLoginForm.Controls.Add(Label2)
        pnlLoginForm.Controls.Add(Label1)
        pnlLoginForm.Controls.Add(Panel2)
        pnlLoginForm.Controls.Add(btnLogin)
        pnlLoginForm.Controls.Add(txtUsername)
        pnlLoginForm.Controls.Add(txtPassword)
        pnlLoginForm.Location = New Point(86, 79)
        pnlLoginForm.Name = "pnlLoginForm"
        pnlLoginForm.Size = New Size(695, 404)
        pnlLoginForm.TabIndex = 3
        ' 
        ' linkForgot
        ' 
        linkForgot.AutoSize = True
        linkForgot.BackColor = Color.Transparent
        linkForgot.LinkColor = Color.PaleVioletRed
        linkForgot.Location = New Point(532, 329)
        linkForgot.Name = "linkForgot"
        linkForgot.Size = New Size(109, 15)
        linkForgot.TabIndex = 8
        linkForgot.TabStop = True
        linkForgot.Text = "Forgot Credentials?"
        linkForgot.VisitedLinkColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(15), CByte(255), CByte(255), CByte(255))
        Label4.Location = New Point(326, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(83, 17)
        Label4.TabIndex = 7
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Helvetica", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(15), CByte(255), CByte(255), CByte(255))
        Label3.Location = New Point(326, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 17)
        Label3.TabIndex = 6
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.ForeColor = Color.LightGray
        Label2.Location = New Point(329, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 15)
        Label2.TabIndex = 5
        Label2.Text = "Please enter your credentials." & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Coolvetica Rg", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(329, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 29)
        Label1.TabIndex = 4
        Label1.Text = "Welcome!"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(53), CByte(36), CByte(84))
        Panel2.BackgroundImageLayout = ImageLayout.Center
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(291, 404)
        Panel2.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Helvetica", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(12, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(242, 120)
        Label5.TabIndex = 0
        Label5.Text = "Payroll System"
        Label5.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' pnlForgotCred
        ' 
        pnlForgotCred.BackColor = Color.Salmon
        pnlForgotCred.Controls.Add(linkBack)
        pnlForgotCred.Controls.Add(btnCredReset)
        pnlForgotCred.Controls.Add(Label8)
        pnlForgotCred.Controls.Add(TextBox3)
        pnlForgotCred.Controls.Add(Label7)
        pnlForgotCred.Controls.Add(Label6)
        pnlForgotCred.Location = New Point(86, 79)
        pnlForgotCred.Name = "pnlForgotCred"
        pnlForgotCred.Size = New Size(695, 404)
        pnlForgotCred.TabIndex = 4
        ' 
        ' linkBack
        ' 
        linkBack.AutoSize = True
        linkBack.LinkColor = Color.Ivory
        linkBack.Location = New Point(37, 370)
        linkBack.Name = "linkBack"
        linkBack.Size = New Size(50, 15)
        linkBack.TabIndex = 5
        linkBack.TabStop = True
        linkBack.Text = "Go Back"
        ' 
        ' btnCredReset
        ' 
        btnCredReset.BackColor = Color.MistyRose
        btnCredReset.FlatStyle = FlatStyle.Popup
        btnCredReset.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCredReset.Location = New Point(37, 264)
        btnCredReset.Name = "btnCredReset"
        btnCredReset.Size = New Size(112, 41)
        btnCredReset.TabIndex = 4
        btnCredReset.Text = "Submit"
        btnCredReset.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Helvetica", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(30, 184)
        Label8.Name = "Label8"
        Label8.Size = New Size(143, 25)
        Label8.TabIndex = 3
        Label8.Text = "Employee ID"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(37, 221)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(530, 23)
        TextBox3.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(37, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(320, 15)
        Label7.TabIndex = 1
        Label7.Text = "Please enter your Employee ID below to verify your identity."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Helvetica", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(28, 33)
        Label6.Name = "Label6"
        Label6.Size = New Size(452, 45)
        Label6.TabIndex = 0
        Label6.Text = "Forgot your credentials?"
        ' 
        ' formLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(44), CByte(13), CByte(93))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(883, 561)
        Controls.Add(pnlLoginForm)
        Controls.Add(pnlForgotCred)
        MaximizeBox = False
        MinimizeBox = False
        Name = "formLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        pnlLoginForm.ResumeLayout(False)
        pnlLoginForm.PerformLayout()
        Panel2.ResumeLayout(False)
        pnlForgotCred.ResumeLayout(False)
        pnlForgotCred.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlLoginForm As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents linkForgot As LinkLabel
    Friend WithEvents pnlForgotCred As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCredReset As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents linkBack As LinkLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label

End Class
