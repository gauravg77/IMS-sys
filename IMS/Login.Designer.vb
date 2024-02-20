<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        btnlogin = New Guna.UI2.WinForms.Guna2Button()
        btnsignup = New Guna.UI2.WinForms.Guna2Button()
        textboxuserid = New TextBox()
        textboxpassword = New TextBox()
        CheckBoxpassword = New CheckBox()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(-6, -14)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(510, 660)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' btnlogin
        ' 
        btnlogin.CustomBorderThickness = New Padding(2)
        btnlogin.CustomizableEdges = CustomizableEdges3
        btnlogin.DisabledState.BorderColor = Color.DarkGray
        btnlogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogin.FillColor = Color.Black
        btnlogin.Font = New Font("Trebuchet MS", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(112, 407)
        btnlogin.Name = "btnlogin"
        btnlogin.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnlogin.Size = New Size(265, 39)
        btnlogin.TabIndex = 5
        btnlogin.Text = "LOG IN"
        ' 
        ' btnsignup
        ' 
        btnsignup.AccessibleName = ""
        btnsignup.CustomizableEdges = CustomizableEdges5
        btnsignup.DisabledState.BorderColor = Color.DarkGray
        btnsignup.DisabledState.CustomBorderColor = Color.DarkGray
        btnsignup.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsignup.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnsignup.FillColor = SystemColors.ControlDarkDark
        btnsignup.Font = New Font("Trebuchet MS", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btnsignup.ForeColor = Color.White
        btnsignup.Location = New Point(112, 452)
        btnsignup.Name = "btnsignup"
        btnsignup.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnsignup.Size = New Size(265, 39)
        btnsignup.TabIndex = 7
        btnsignup.Text = "SIGN UP"
        ' 
        ' textboxuserid
        ' 
        textboxuserid.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        textboxuserid.Location = New Point(115, 244)
        textboxuserid.Multiline = True
        textboxuserid.Name = "textboxuserid"
        textboxuserid.PlaceholderText = "Username"
        textboxuserid.Size = New Size(265, 40)
        textboxuserid.TabIndex = 9
        ' 
        ' textboxpassword
        ' 
        textboxpassword.Location = New Point(115, 290)
        textboxpassword.Multiline = True
        textboxpassword.Name = "textboxpassword"
        textboxpassword.PasswordChar = "*"c
        textboxpassword.PlaceholderText = "Password"
        textboxpassword.Size = New Size(265, 40)
        textboxpassword.TabIndex = 11
        ' 
        ' CheckBoxpassword
        ' 
        CheckBoxpassword.AutoSize = True
        CheckBoxpassword.Location = New Point(248, 336)
        CheckBoxpassword.Name = "CheckBoxpassword"
        CheckBoxpassword.Size = New Size(132, 24)
        CheckBoxpassword.TabIndex = 12
        CheckBoxpassword.Text = "Show Password"
        CheckBoxpassword.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AccessibleName = "Login"
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 648)
        Controls.Add(CheckBoxpassword)
        Controls.Add(textboxpassword)
        Controls.Add(textboxuserid)
        Controls.Add(btnsignup)
        Controls.Add(btnlogin)
        Controls.Add(Guna2PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnsignup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents textboxuserid As TextBox
    Friend WithEvents textboxpassword As TextBox
    Friend WithEvents CheckBoxpassword As CheckBox
End Class
