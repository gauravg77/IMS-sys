<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billingandsales
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
        txtbill = New TextBox()
        txtaddress = New TextBox()
        txtinvoice = New TextBox()
        Label4 = New Label()
        dtinvoice = New DateTimePicker()
        txtinvoicefor = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        Label11 = New Label()
        txtproductname = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtquantity = New TextBox()
        txtsubtotal = New TextBox()
        txttotal = New TextBox()
        txtdiscount = New TextBox()
        Label10 = New Label()
        btnaddtolist = New Button()
        GroupBox3 = New GroupBox()
        txtunitprice = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        txttaxrate = New TextBox()
        Label15 = New Label()
        txtgrandtotal = New TextBox()
        Label16 = New Label()
        txtothers = New TextBox()
        gridbilling = New DataGridView()
        billpanel = New Panel()
        btnnewbill = New Button()
        btnprint = New Button()
        btnhome = New Button()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(gridbilling, ComponentModel.ISupportInitialize).BeginInit()
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
        ' txtbill
        ' 
        txtbill.AccessibleName = "txtbill"
        txtbill.Location = New Point(178, 113)
        txtbill.Name = "txtbill"
        txtbill.Size = New Size(429, 27)
        txtbill.TabIndex = 3
        ' 
        ' txtaddress
        ' 
        txtaddress.AccessibleName = "txtaddress"
        txtaddress.Location = New Point(116, 47)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(429, 27)
        txtaddress.TabIndex = 4
        ' 
        ' txtinvoice
        ' 
        txtinvoice.AccessibleName = "txtinvoice"
        txtinvoice.Location = New Point(789, 112)
        txtinvoice.Name = "txtinvoice"
        txtinvoice.Size = New Size(214, 27)
        txtinvoice.TabIndex = 5
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
        ' dtinvoice
        ' 
        dtinvoice.AccessibleName = "dtinvoice"
        dtinvoice.Location = New Point(789, 146)
        dtinvoice.Name = "dtinvoice"
        dtinvoice.Size = New Size(214, 27)
        dtinvoice.TabIndex = 8
        ' 
        ' txtinvoicefor
        ' 
        txtinvoicefor.AccessibleName = "txtinvoicefor"
        txtinvoicefor.Location = New Point(178, 179)
        txtinvoicefor.Name = "txtinvoicefor"
        txtinvoicefor.Size = New Size(825, 27)
        txtinvoicefor.TabIndex = 10
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
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(txtaddress)
        GroupBox1.Location = New Point(62, 95)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(952, 142)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
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
        ' txtproductname
        ' 
        txtproductname.AccessibleName = "txtproductname"
        txtproductname.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtproductname.Location = New Point(71, 303)
        txtproductname.Name = "txtproductname"
        txtproductname.Size = New Size(362, 27)
        txtproductname.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(71, 280)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 14
        Label6.Text = "Product Name"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(653, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 20)
        Label7.TabIndex = 15
        Label7.Text = "Discount (%)"
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
        ' txtquantity
        ' 
        txtquantity.AccessibleName = "txtquantity"
        txtquantity.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtquantity.Location = New Point(439, 303)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(81, 27)
        txtquantity.TabIndex = 18
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.AccessibleName = "txtsubtotal"
        txtsubtotal.BackColor = SystemColors.Control
        txtsubtotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtsubtotal.Location = New Point(742, 628)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.Size = New Size(272, 27)
        txtsubtotal.TabIndex = 19
        ' 
        ' txttotal
        ' 
        txttotal.AccessibleName = "txttotal"
        txttotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txttotal.Location = New Point(718, 41)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(121, 27)
        txttotal.TabIndex = 20
        ' 
        ' txtdiscount
        ' 
        txtdiscount.AccessibleName = "txtdiscount"
        txtdiscount.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtdiscount.Location = New Point(653, 303)
        txtdiscount.Name = "txtdiscount"
        txtdiscount.Size = New Size(121, 27)
        txtdiscount.TabIndex = 21
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
        GroupBox3.Controls.Add(txtunitprice)
        GroupBox3.Controls.Add(btnaddtolist)
        GroupBox3.Controls.Add(txttotal)
        GroupBox3.Location = New Point(62, 264)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(952, 104)
        GroupBox3.TabIndex = 25
        GroupBox3.TabStop = False
        ' 
        ' txtunitprice
        ' 
        txtunitprice.AccessibleName = "txtunitprice"
        txtunitprice.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtunitprice.Location = New Point(464, 39)
        txtunitprice.Name = "txtunitprice"
        txtunitprice.Size = New Size(121, 27)
        txtunitprice.TabIndex = 24
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(646, 635)
        Label12.Name = "Label12"
        Label12.Size = New Size(71, 20)
        Label12.TabIndex = 27
        Label12.Text = "Sub Total"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(646, 668)
        Label13.Name = "Label13"
        Label13.Size = New Size(90, 20)
        Label13.TabIndex = 29
        Label13.Text = "Tax Rate (%)"
        ' 
        ' txttaxrate
        ' 
        txttaxrate.AccessibleName = "txttaxrate"
        txttaxrate.BackColor = SystemColors.Control
        txttaxrate.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txttaxrate.Location = New Point(742, 661)
        txttaxrate.Name = "txttaxrate"
        txttaxrate.Size = New Size(272, 27)
        txttaxrate.TabIndex = 28
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(653, 734)
        Label15.Name = "Label15"
        Label15.Size = New Size(54, 20)
        Label15.TabIndex = 33
        Label15.Text = "TOTAL"
        ' 
        ' txtgrandtotal
        ' 
        txtgrandtotal.AccessibleName = "txtgrandtotal"
        txtgrandtotal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtgrandtotal.Location = New Point(742, 727)
        txtgrandtotal.Name = "txtgrandtotal"
        txtgrandtotal.Size = New Size(272, 27)
        txtgrandtotal.TabIndex = 32
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(646, 701)
        Label16.Name = "Label16"
        Label16.Size = New Size(52, 20)
        Label16.TabIndex = 35
        Label16.Text = "Others"
        ' 
        ' txtothers
        ' 
        txtothers.AccessibleName = "txtothers"
        txtothers.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtothers.Location = New Point(742, 694)
        txtothers.Name = "txtothers"
        txtothers.Size = New Size(272, 27)
        txtothers.TabIndex = 34
        ' 
        ' gridbilling
        ' 
        gridbilling.AccessibleName = "gridbilling"
        gridbilling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridbilling.Location = New Point(62, 374)
        gridbilling.Name = "gridbilling"
        gridbilling.RowHeadersWidth = 51
        gridbilling.RowTemplate.Height = 29
        gridbilling.Size = New Size(952, 188)
        gridbilling.TabIndex = 36
        ' 
        ' billpanel
        ' 
        billpanel.AccessibleName = "billpanel"
        billpanel.BackColor = SystemColors.AppWorkspace
        billpanel.Location = New Point(1217, 95)
        billpanel.Name = "billpanel"
        billpanel.Size = New Size(413, 593)
        billpanel.TabIndex = 37
        ' 
        ' btnnewbill
        ' 
        btnnewbill.AccessibleName = "btnnewbill"
        btnnewbill.Location = New Point(696, 846)
        btnnewbill.Name = "btnnewbill"
        btnnewbill.Size = New Size(145, 56)
        btnnewbill.TabIndex = 38
        btnnewbill.Text = "New Bill"
        btnnewbill.UseVisualStyleBackColor = True
        ' 
        ' btnprint
        ' 
        btnprint.AccessibleName = "btnprint"
        btnprint.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnprint.Location = New Point(869, 846)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(145, 56)
        btnprint.TabIndex = 39
        btnprint.Text = "Print"
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' btnhome
        ' 
        btnhome.AccessibleName = "btnhome"
        btnhome.Location = New Point(39, 26)
        btnhome.Name = "btnhome"
        btnhome.Size = New Size(94, 29)
        btnhome.TabIndex = 40
        btnhome.Text = "home"
        btnhome.UseVisualStyleBackColor = True
        ' 
        ' billingandsales
        ' 
        AccessibleName = "Billing and Sales"
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1766, 1003)
        Controls.Add(btnhome)
        Controls.Add(btnprint)
        Controls.Add(btnnewbill)
        Controls.Add(billpanel)
        Controls.Add(gridbilling)
        Controls.Add(Label16)
        Controls.Add(txtothers)
        Controls.Add(Label15)
        Controls.Add(txtgrandtotal)
        Controls.Add(Label13)
        Controls.Add(txttaxrate)
        Controls.Add(Label12)
        Controls.Add(Label10)
        Controls.Add(txtdiscount)
        Controls.Add(txtsubtotal)
        Controls.Add(txtquantity)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(txtproductname)
        Controls.Add(txtinvoicefor)
        Controls.Add(Label5)
        Controls.Add(dtinvoice)
        Controls.Add(Label4)
        Controls.Add(txtinvoice)
        Controls.Add(txtbill)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox3)
        Name = "billingandsales"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Billing and Sales"
        WindowState = FormWindowState.Maximized
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(gridbilling, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbill As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtinvoice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtinvoice As DateTimePicker
    Friend WithEvents txtinvoicefor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnaddtolist As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtunitprice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txttaxrate As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtgrandtotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtothers As TextBox
    Friend WithEvents gridbilling As DataGridView
    Friend WithEvents billpanel As Panel
    Friend WithEvents btnnewbill As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnhome As Button
End Class
