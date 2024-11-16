<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        btnLogin = New Button()
        Panel1 = New Panel()
        linkForgot = New LinkLabel()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Label5 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Location = New Point(329, 164)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(312, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Location = New Point(329, 242)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(312, 23)
        TextBox2.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Bisque
        btnLogin.Location = New Point(329, 308)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(118, 36)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(linkForgot)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btnLogin)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(86, 79)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(695, 404)
        Panel1.TabIndex = 3
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
        Label3.Location = New Point(326, 144)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 17)
        Label3.TabIndex = 6
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.DimGray
        Label2.Location = New Point(329, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 15)
        Label2.TabIndex = 5
        Label2.Text = "Please enter your credentials." & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Helvetica", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(322, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 29)
        Label1.TabIndex = 4
        Label1.Text = "Welcome!"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources._2830242
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FloralWhite
        ClientSize = New Size(883, 561)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents linkForgot As LinkLabel
    Friend WithEvents Label5 As Label

End Class
