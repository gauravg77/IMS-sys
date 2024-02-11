<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product
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
        Category = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btnaddcategory = New Button()
        bthclearcategory = New Button()
        btndeletecategory = New Button()
        btnupdatecategory = New Button()
        btnaddproduct = New Button()
        btnupdateproduct = New Button()
        btndeleteproduct = New Button()
        btnclearproduct = New Button()
        txtcategoryid = New TextBox()
        txtcategoryname = New TextBox()
        txtsellingprice = New TextBox()
        txtquantity = New TextBox()
        txtproductid = New TextBox()
        txtproductname = New TextBox()
        comboboxcategory = New ComboBox()
        txtcostprice = New TextBox()
        btncategorysearch = New Button()
        btnproductsearch = New Button()
        SuspendLayout()
        ' 
        ' Category
        ' 
        Category.AccessibleName = "Category"
        Category.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Category.AutoSize = True
        Category.Location = New Point(43, 104)
        Category.Name = "Category"
        Category.Size = New Size(117, 20)
        Category.TabIndex = 0
        Category.Text = "ADD CATEGORY"
        Category.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(43, 153)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 1
        Label1.Text = " Category ID"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Location = New Point(43, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 2
        Label2.Text = "Category Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.AutoSize = True
        Label3.Location = New Point(482, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 20)
        Label3.TabIndex = 3
        Label3.Text = "PRODUCT MANAGEMENT"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Location = New Point(493, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 4
        Label4.Text = "Product ID"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Location = New Point(482, 220)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 5
        Label5.Text = "Category"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Location = New Point(482, 179)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 6
        Label6.Text = "Product Name"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Location = New Point(482, 258)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 20)
        Label7.TabIndex = 7
        Label7.Text = "Quantity"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Location = New Point(482, 301)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 20)
        Label8.TabIndex = 8
        Label8.Text = "Selling Price"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Location = New Point(482, 337)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 20)
        Label9.TabIndex = 9
        Label9.Text = "Cost Price"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnaddcategory
        ' 
        btnaddcategory.AccessibleName = "btnaddcategory"
        btnaddcategory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnaddcategory.Location = New Point(29, 366)
        btnaddcategory.Name = "btnaddcategory"
        btnaddcategory.Size = New Size(94, 29)
        btnaddcategory.TabIndex = 10
        btnaddcategory.Text = "ADD"
        btnaddcategory.UseVisualStyleBackColor = True
        ' 
        ' bthclearcategory
        ' 
        bthclearcategory.AccessibleName = "bthclearcategory"
        bthclearcategory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        bthclearcategory.Location = New Point(141, 416)
        bthclearcategory.Name = "bthclearcategory"
        bthclearcategory.Size = New Size(94, 29)
        bthclearcategory.TabIndex = 11
        bthclearcategory.Text = "CLEAR"
        bthclearcategory.UseVisualStyleBackColor = True
        ' 
        ' btndeletecategory
        ' 
        btndeletecategory.AccessibleName = "btndeletecategory"
        btndeletecategory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btndeletecategory.Location = New Point(29, 416)
        btndeletecategory.Name = "btndeletecategory"
        btndeletecategory.Size = New Size(94, 29)
        btndeletecategory.TabIndex = 12
        btndeletecategory.Text = "DELETE"
        btndeletecategory.UseVisualStyleBackColor = True
        ' 
        ' btnupdatecategory
        ' 
        btnupdatecategory.AccessibleName = "btnupdatecategory"
        btnupdatecategory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnupdatecategory.Location = New Point(141, 366)
        btnupdatecategory.Name = "btnupdatecategory"
        btnupdatecategory.Size = New Size(94, 29)
        btnupdatecategory.TabIndex = 13
        btnupdatecategory.Text = "UPDATE"
        btnupdatecategory.UseVisualStyleBackColor = True
        ' 
        ' btnaddproduct
        ' 
        btnaddproduct.AccessibleName = "btnaddproduct"
        btnaddproduct.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnaddproduct.Location = New Point(467, 366)
        btnaddproduct.Name = "btnaddproduct"
        btnaddproduct.Size = New Size(94, 29)
        btnaddproduct.TabIndex = 14
        btnaddproduct.Text = "ADD"
        btnaddproduct.UseVisualStyleBackColor = True
        ' 
        ' btnupdateproduct
        ' 
        btnupdateproduct.AccessibleName = "btnupdateproduct"
        btnupdateproduct.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnupdateproduct.Location = New Point(592, 366)
        btnupdateproduct.Name = "btnupdateproduct"
        btnupdateproduct.Size = New Size(94, 29)
        btnupdateproduct.TabIndex = 15
        btnupdateproduct.Text = "UPDATE"
        btnupdateproduct.UseVisualStyleBackColor = True
        ' 
        ' btndeleteproduct
        ' 
        btndeleteproduct.AccessibleName = "btndeleteproduct"
        btndeleteproduct.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btndeleteproduct.Location = New Point(701, 366)
        btndeleteproduct.Name = "btndeleteproduct"
        btndeleteproduct.Size = New Size(94, 29)
        btndeleteproduct.TabIndex = 16
        btndeleteproduct.Text = "DELETE"
        btndeleteproduct.UseVisualStyleBackColor = True
        ' 
        ' btnclearproduct
        ' 
        btnclearproduct.AccessibleName = "btnclearproduct"
        btnclearproduct.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnclearproduct.Location = New Point(813, 366)
        btnclearproduct.Name = "btnclearproduct"
        btnclearproduct.Size = New Size(94, 29)
        btnclearproduct.TabIndex = 17
        btnclearproduct.Text = "CLEAR"
        btnclearproduct.UseVisualStyleBackColor = True
        ' 
        ' txtcategoryid
        ' 
        txtcategoryid.AccessibleName = "txtcategoryid"
        txtcategoryid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtcategoryid.Location = New Point(162, 150)
        txtcategoryid.Name = "txtcategoryid"
        txtcategoryid.Size = New Size(125, 27)
        txtcategoryid.TabIndex = 18
        ' 
        ' txtcategoryname
        ' 
        txtcategoryname.AccessibleName = "txtcategoryname"
        txtcategoryname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtcategoryname.Location = New Point(162, 183)
        txtcategoryname.Name = "txtcategoryname"
        txtcategoryname.Size = New Size(125, 27)
        txtcategoryname.TabIndex = 19
        ' 
        ' txtsellingprice
        ' 
        txtsellingprice.AccessibleName = "txtsellingprice"
        txtsellingprice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtsellingprice.Location = New Point(592, 294)
        txtsellingprice.Name = "txtsellingprice"
        txtsellingprice.Size = New Size(125, 27)
        txtsellingprice.TabIndex = 20
        ' 
        ' txtquantity
        ' 
        txtquantity.AccessibleName = "txtquantity"
        txtquantity.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtquantity.Location = New Point(592, 251)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(125, 27)
        txtquantity.TabIndex = 21
        ' 
        ' txtproductid
        ' 
        txtproductid.AccessibleName = "txtproductid"
        txtproductid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtproductid.Location = New Point(592, 136)
        txtproductid.Name = "txtproductid"
        txtproductid.Size = New Size(125, 27)
        txtproductid.TabIndex = 22
        ' 
        ' txtproductname
        ' 
        txtproductname.AccessibleName = "txtproductname"
        txtproductname.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtproductname.Location = New Point(592, 176)
        txtproductname.Name = "txtproductname"
        txtproductname.Size = New Size(125, 27)
        txtproductname.TabIndex = 23
        ' 
        ' comboboxcategory
        ' 
        comboboxcategory.AccessibleDescription = ""
        comboboxcategory.AccessibleName = " comboboxcategory"
        comboboxcategory.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        comboboxcategory.FormattingEnabled = True
        comboboxcategory.Location = New Point(592, 212)
        comboboxcategory.Name = "comboboxcategory"
        comboboxcategory.Size = New Size(125, 28)
        comboboxcategory.TabIndex = 24
        ' 
        ' txtcostprice
        ' 
        txtcostprice.AccessibleName = "txtcostprice"
        txtcostprice.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtcostprice.Location = New Point(592, 327)
        txtcostprice.Name = "txtcostprice"
        txtcostprice.Size = New Size(125, 27)
        txtcostprice.TabIndex = 25
        ' 
        ' btncategorysearch
        ' 
        btncategorysearch.AccessibleName = "btncategorysearch"
        btncategorysearch.Location = New Point(313, 150)
        btncategorysearch.Name = "btncategorysearch"
        btncategorysearch.Size = New Size(94, 29)
        btncategorysearch.TabIndex = 26
        btncategorysearch.Text = "Search"
        btncategorysearch.UseVisualStyleBackColor = True
        ' 
        ' btnproductsearch
        ' 
        btnproductsearch.AccessibleName = "btnproductsearch"
        btnproductsearch.Location = New Point(745, 144)
        btnproductsearch.Name = "btnproductsearch"
        btnproductsearch.Size = New Size(94, 29)
        btnproductsearch.TabIndex = 27
        btnproductsearch.Text = "Search"
        btnproductsearch.UseVisualStyleBackColor = True
        ' 
        ' Product
        ' 
        AccessibleName = "Product "
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1021, 709)
        Controls.Add(btnproductsearch)
        Controls.Add(btncategorysearch)
        Controls.Add(txtcostprice)
        Controls.Add(comboboxcategory)
        Controls.Add(txtproductname)
        Controls.Add(txtproductid)
        Controls.Add(txtquantity)
        Controls.Add(txtsellingprice)
        Controls.Add(txtcategoryname)
        Controls.Add(txtcategoryid)
        Controls.Add(btnclearproduct)
        Controls.Add(btndeleteproduct)
        Controls.Add(btnupdateproduct)
        Controls.Add(btnaddproduct)
        Controls.Add(btnupdatecategory)
        Controls.Add(btndeletecategory)
        Controls.Add(bthclearcategory)
        Controls.Add(btnaddcategory)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Category)
        Name = "Product"
        Text = "Product"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Category As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnaddcategory As Button
    Friend WithEvents bthclearcategory As Button
    Friend WithEvents btndeletecategory As Button
    Friend WithEvents btnupdatecategory As Button
    Friend WithEvents btnaddproduct As Button
    Friend WithEvents btnupdateproduct As Button
    Friend WithEvents btndeleteproduct As Button
    Friend WithEvents btnclearproduct As Button
    Friend WithEvents txtcategoryid As TextBox
    Friend WithEvents txtcategoryname As TextBox
    Friend WithEvents txtsellingprice As TextBox
    Friend WithEvents txtquantity As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents txtproductname As TextBox
    Friend WithEvents comboboxcategory As ComboBox
    Friend WithEvents txtcostprice As TextBox
    Friend WithEvents btncategorysearch As Button
    Friend WithEvents btnproductsearch As Button
End Class
