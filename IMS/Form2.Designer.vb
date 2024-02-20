<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signup
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnsignup = New Guna.UI2.WinForms.Guna2Button()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        TextBoxusername = New TextBox()
        TextBoxpassword = New TextBox()
        TextBoxConfirmpassword = New TextBox()
        CheckBox1 = New CheckBox()
        TextBoxCID = New TextBox()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Location = New Point(33, 193)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(3, 2)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = Nothing
        ' 
        ' btnsignup
        ' 
        btnsignup.AccessibleName = ""
        btnsignup.CustomizableEdges = CustomizableEdges1
        btnsignup.DisabledState.BorderColor = Color.DarkGray
        btnsignup.DisabledState.CustomBorderColor = Color.DarkGray
        btnsignup.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnsignup.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnsignup.FillColor = Color.Black
        btnsignup.Font = New Font("Trebuchet MS", 13F, FontStyle.Regular, GraphicsUnit.Point)
        btnsignup.ForeColor = Color.White
        btnsignup.Location = New Point(112, 407)
        btnsignup.Name = "btnsignup"
        btnsignup.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnsignup.Size = New Size(265, 39)
        btnsignup.TabIndex = 7
        btnsignup.Text = "SIGN UP"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomBorderThickness = New Padding(2)
        Guna2Button2.CustomizableEdges = CustomizableEdges3
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.Transparent
        Guna2Button2.Font = New Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point)
        Guna2Button2.ForeColor = Color.DimGray
        Guna2Button2.Location = New Point(112, 452)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2Button2.Size = New Size(265, 53)
        Guna2Button2.TabIndex = 8
        Guna2Button2.Text = "Go back to login"
        ' 
        ' TextBoxusername
        ' 
        TextBoxusername.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxusername.Location = New Point(112, 202)
        TextBoxusername.Multiline = True
        TextBoxusername.Name = "TextBoxusername"
        TextBoxusername.PlaceholderText = "Username"
        TextBoxusername.Size = New Size(265, 40)
        TextBoxusername.TabIndex = 10
        ' 
        ' TextBoxpassword
        ' 
        TextBoxpassword.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxpassword.Location = New Point(112, 248)
        TextBoxpassword.Multiline = True
        TextBoxpassword.Name = "TextBoxpassword"
        TextBoxpassword.PasswordChar = "*"c
        TextBoxpassword.PlaceholderText = "Password"
        TextBoxpassword.Size = New Size(265, 40)
        TextBoxpassword.TabIndex = 11
        ' 
        ' TextBoxConfirmpassword
        ' 
        TextBoxConfirmpassword.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxConfirmpassword.Location = New Point(112, 294)
        TextBoxConfirmpassword.Multiline = True
        TextBoxConfirmpassword.Name = "TextBoxConfirmpassword"
        TextBoxConfirmpassword.PasswordChar = "*"c
        TextBoxConfirmpassword.PlaceholderText = "Confirm Password"
        TextBoxConfirmpassword.Size = New Size(265, 40)
        TextBoxConfirmpassword.TabIndex = 12
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(249, 340)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(132, 24)
        CheckBox1.TabIndex = 13
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBoxCID
        ' 
        TextBoxCID.Font = New Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TextBoxCID.Location = New Point(112, 155)
        TextBoxCID.Multiline = True
        TextBoxCID.Name = "TextBoxCID"
        TextBoxCID.PasswordChar = "*"c
        TextBoxCID.PlaceholderText = "Citizenship ID"
        TextBoxCID.Size = New Size(265, 40)
        TextBoxCID.TabIndex = 14
        TextBoxCID.UseSystemPasswordChar = True
        ' 
        ' Signup
        ' 
        AccessibleName = "Signup"
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(482, 648)
        Controls.Add(TextBoxCID)
        Controls.Add(CheckBox1)
        Controls.Add(TextBoxConfirmpassword)
        Controls.Add(TextBoxpassword)
        Controls.Add(TextBoxusername)
        Controls.Add(Guna2Button2)
        Controls.Add(btnsignup)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Signup"
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterScreen
        Text = "Signup"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnsignup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TextBoxusername As TextBox
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents TextBoxConfirmpassword As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBoxCID As TextBox
End Class
