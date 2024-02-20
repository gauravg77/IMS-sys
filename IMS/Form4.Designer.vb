<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Nightmode = New CheckBox()
        btntologin = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(547, 383)
        Button1.Name = "Button1"
        Button1.Size = New Size(631, 62)
        Button1.TabIndex = 0
        Button1.Text = "SALES AND BILLING"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(547, 461)
        Button2.Name = "Button2"
        Button2.RightToLeft = RightToLeft.Yes
        Button2.Size = New Size(631, 62)
        Button2.TabIndex = 1
        Button2.Text = "PRODUCT AND CATEGORY MANAGEMENT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(547, 542)
        Button3.Name = "Button3"
        Button3.Size = New Size(631, 62)
        Button3.TabIndex = 2
        Button3.Text = "USE ME AS A GUIDE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Nightmode
        ' 
        Nightmode.AccessibleName = "Nightmode"
        Nightmode.AutoSize = True
        Nightmode.Location = New Point(1071, 704)
        Nightmode.Name = "Nightmode"
        Nightmode.Size = New Size(107, 24)
        Nightmode.TabIndex = 42
        Nightmode.Text = "Nightmode"
        Nightmode.UseVisualStyleBackColor = True
        ' 
        ' btntologin
        ' 
        btntologin.Location = New Point(547, 621)
        btntologin.Name = "btntologin"
        btntologin.Size = New Size(631, 62)
        btntologin.TabIndex = 43
        btntologin.Text = "BACK"
        btntologin.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AccessibleDescription = "Dashboard"
        AccessibleName = "Dashboard"
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1766, 1003)
        Controls.Add(btntologin)
        Controls.Add(Nightmode)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Nightmode As CheckBox
    Friend WithEvents btntologin As Button
End Class
