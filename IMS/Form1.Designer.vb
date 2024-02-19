<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label4 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox4 = New TextBox()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        Label10 = New Label()
        btnaddtolist = New Button()
        GroupBox3 = New GroupBox()
        Label11 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(682, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "Invoice"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(71, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 1
        Label2.Text = "Bill To"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(71, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 20)
        Label3.TabIndex = 2
        Label3.Text = "Address"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(178, 113)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(429, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(178, 146)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(429, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(789, 112)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(214, 27)
        TextBox3.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(682, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 6
        Label4.Text = "Invoice Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(789, 146)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(214, 27)
        DateTimePicker1.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(178, 179)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(825, 27)
        TextBox4.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(-297, -70)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 20)
        Label5.TabIndex = 9
        Label5.Text = "Qty"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(62, 467)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(932, 188)
        DataGridView1.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Location = New Point(62, 95)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(952, 142)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(71, 303)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(362, 27)
        TextBox5.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(71, 280)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 20)
        Label6.TabIndex = 14
        Label6.Text = "Description"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(653, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 20)
        Label7.TabIndex = 15
        Label7.Text = "Discount"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(526, 280)
        Label8.Name = "Label8"
        Label8.Size = New Size(72, 20)
        Label8.TabIndex = 16
        Label8.Text = "Unit Price"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(439, 280)
        Label9.Name = "Label9"
        Label9.Size = New Size(32, 20)
        Label9.TabIndex = 17
        Label9.Text = "Qty"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(439, 303)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(81, 27)
        TextBox6.TabIndex = 18
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(526, 303)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(121, 27)
        TextBox7.TabIndex = 19
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(780, 303)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(121, 27)
        TextBox8.TabIndex = 20
        ' 
        ' TextBox9
        ' 
        TextBox9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox9.Location = New Point(653, 303)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(121, 27)
        TextBox9.TabIndex = 21
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(780, 280)
        Label10.Name = "Label10"
        Label10.Size = New Size(42, 20)
        Label10.TabIndex = 22
        Label10.Text = "Total"
        ' 
        ' btnaddtolist
        ' 
        btnaddtolist.AccessibleName = "btnaddtolist"
        btnaddtolist.BackColor = SystemColors.ActiveCaption
        btnaddtolist.Location = New Point(845, 39)
        btnaddtolist.Name = "btnaddtolist"
        btnaddtolist.Size = New Size(94, 29)
        btnaddtolist.TabIndex = 23
        btnaddtolist.Text = "ADD"
        btnaddtolist.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnaddtolist)
        GroupBox3.Location = New Point(62, 264)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(952, 104)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(9, 91)
        Label11.Name = "Label11"
        Label11.Size = New Size(81, 20)
        Label11.TabIndex = 26
        Label11.Text = "Invoice For"
        ' 
        ' Form1
        ' 
        AccessibleName = "Billing and Sales"
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1766, 1003)
        Controls.Add(Label10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox3)
        Name = "Form1"
        Text = "Billing and Sales"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnaddtolist As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
End Class
