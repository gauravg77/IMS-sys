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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        textboxuserid = New Guna.UI2.WinForms.Guna2TextBox()
        textboxpassword = New Guna.UI2.WinForms.Guna2TextBox()
        btnlogin = New Guna.UI2.WinForms.Guna2Button()
        Guna2CheckBox1 = New Guna.UI2.WinForms.Guna2CheckBox()
        btnsignup = New Guna.UI2.WinForms.Guna2Button()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges11
        Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), Image)
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(-6, -14)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2PictureBox1.Size = New Size(510, 660)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' textboxuserid
        ' 
        textboxuserid.CustomizableEdges = CustomizableEdges13
        textboxuserid.DefaultText = ""
        textboxuserid.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textboxuserid.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textboxuserid.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxuserid.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxuserid.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxuserid.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        textboxuserid.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxuserid.Location = New Point(112, 239)
        textboxuserid.Name = "textboxuserid"
        textboxuserid.PasswordChar = ChrW(0)
        textboxuserid.PlaceholderText = "UserID"
        textboxuserid.SelectedText = ""
        textboxuserid.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        textboxuserid.Size = New Size(265, 45)
        textboxuserid.TabIndex = 3
        ' 
        ' textboxpassword
        ' 
        textboxpassword.CustomizableEdges = CustomizableEdges15
        textboxpassword.DefaultText = ""
        textboxpassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        textboxpassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        textboxpassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        textboxpassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxpassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        textboxpassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        textboxpassword.Location = New Point(112, 290)
        textboxpassword.Name = "textboxpassword"
        textboxpassword.PasswordChar = "●"c
        textboxpassword.PlaceholderText = "Password"
        textboxpassword.SelectedText = ""
        textboxpassword.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        textboxpassword.Size = New Size(265, 45)
        textboxpassword.TabIndex = 4
        textboxpassword.UseSystemPasswordChar = True
        ' 
        ' btnlogin
        ' 
        btnlogin.CustomBorderThickness = New Padding(2)
        btnlogin.CustomizableEdges = CustomizableEdges17
        btnlogin.DisabledState.BorderColor = Color.DarkGray
        btnlogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnlogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnlogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnlogin.FillColor = Color.Black
        btnlogin.Font = New Font("Trebuchet MS", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(112, 407)
        btnlogin.Name = "btnlogin"
        btnlogin.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnlogin.Size = New Size(265, 39)
        btnlogin.TabIndex = 5
        btnlogin.Text = "LOG IN"
        ' 
        ' Guna2CheckBox1
        ' 
        Guna2CheckBox1.AutoSize = True
        Guna2CheckBox1.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.CheckedState.BorderRadius = 0
        Guna2CheckBox1.CheckedState.BorderThickness = 0
        Guna2CheckBox1.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Guna2CheckBox1.Location = New Point(248, 341)
        Guna2CheckBox1.Name = "Guna2CheckBox1"
        Guna2CheckBox1.Size = New Size(129, 24)
        Guna2CheckBox1.TabIndex = 6
        Guna2CheckBox1.Text = "Remember me"
        Guna2CheckBox1.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        Guna2CheckBox1.UncheckedState.BorderRadius = 0
        Guna2CheckBox1.UncheckedState.BorderThickness = 0
        Guna2CheckBox1.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' btnsignup
        ' 
        btnsignup.CustomizableEdges = CustomizableEdges19
        btnsignup.DisabledState.BorderColor = Color.DarkGray
        btnsignup.DisabledState.CustomBorderColor = Color.DarkGray
        btnsignup.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsignup.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnsignup.FillColor = SystemColors.ControlDarkDark
        btnsignup.Font = New Font("Trebuchet MS", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btnsignup.ForeColor = Color.White
        btnsignup.Location = New Point(112, 452)
        btnsignup.Name = "btnsignup"
        btnsignup.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnsignup.Size = New Size(265, 39)
        btnsignup.TabIndex = 7
        btnsignup.Text = "SIGN UP"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 648)
        Controls.Add(btnsignup)
        Controls.Add(Guna2CheckBox1)
        Controls.Add(btnlogin)
        Controls.Add(textboxpassword)
        Controls.Add(textboxuserid)
        Controls.Add(Guna2PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents textboxuserid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents textboxpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CheckBox1 As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btnsignup As Guna.UI2.WinForms.Guna2Button
End Class
