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
        gridproduct = New DataGridView()
        gridcategory = New DataGridView()
        btnrefreshproduct = New Button()
        btnrefreshcategory = New Button()
        CType(gridproduct, ComponentModel.ISupportInitialize).BeginInit()
        CType(gridcategory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Category
        ' 
        Category.AccessibleName = "Category"
        Category.AutoSize = True
        Category.Location = New Point(173, 76)
        Category.Name = "Category"
        Category.Size = New Size(117, 20)
        Category.TabIndex = 0
        Category.Text = "ADD CATEGORY"
        Category.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(57, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 1
        Label1.Text = " Category ID"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(57, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 2
        Label2.Text = "Category Name"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(966, 76)
        Label3.Name = "Label3"
        Label3.Size = New Size(181, 20)
        Label3.TabIndex = 3
        Label3.Text = "PRODUCT MANAGEMENT"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(864, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 4
        Label4.Text = "Product ID"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(864, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 5
        Label5.Text = "Category"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(864, 169)
        Label6.Name = "Label6"
        Label6.Size = New Size(104, 20)
        Label6.TabIndex = 6
        Label6.Text = "Product Name"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(864, 236)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 20)
        Label7.TabIndex = 7
        Label7.Text = "Quantity"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(864, 269)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 20)
        Label8.TabIndex = 8
        Label8.Text = "Selling Price"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(864, 302)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 20)
        Label9.TabIndex = 9
        Label9.Text = "Cost Price"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnaddcategory
        ' 
        btnaddcategory.AccessibleName = "btnaddcategory"
        btnaddcategory.Location = New Point(57, 366)
        btnaddcategory.Name = "btnaddcategory"
        btnaddcategory.Size = New Size(94, 29)
        btnaddcategory.TabIndex = 10
        btnaddcategory.Text = "ADD"
        btnaddcategory.UseVisualStyleBackColor = True
        ' 
        ' bthclearcategory
        ' 
        bthclearcategory.AccessibleName = "bthclearcategory"
        bthclearcategory.Location = New Point(483, 158)
        bthclearcategory.Name = "bthclearcategory"
        bthclearcategory.Size = New Size(94, 29)
        bthclearcategory.TabIndex = 11
        bthclearcategory.Text = "CLEAR"
        bthclearcategory.UseVisualStyleBackColor = True
        ' 
        ' btndeletecategory
        ' 
        btndeletecategory.AccessibleName = "btndeletecategory"
        btndeletecategory.Location = New Point(291, 366)
        btndeletecategory.Name = "btndeletecategory"
        btndeletecategory.Size = New Size(94, 29)
        btndeletecategory.TabIndex = 12
        btndeletecategory.Text = "DELETE"
        btndeletecategory.UseVisualStyleBackColor = True
        ' 
        ' btnupdatecategory
        ' 
        btnupdatecategory.AccessibleName = "btnupdatecategory"
        btnupdatecategory.Location = New Point(173, 366)
        btnupdatecategory.Name = "btnupdatecategory"
        btnupdatecategory.Size = New Size(94, 29)
        btnupdatecategory.TabIndex = 13
        btnupdatecategory.Text = "UPDATE"
        btnupdatecategory.UseVisualStyleBackColor = True
        ' 
        ' btnaddproduct
        ' 
        btnaddproduct.AccessibleName = "btnaddproduct"
        btnaddproduct.Location = New Point(844, 366)
        btnaddproduct.Name = "btnaddproduct"
        btnaddproduct.Size = New Size(94, 29)
        btnaddproduct.TabIndex = 14
        btnaddproduct.Text = "ADD"
        btnaddproduct.UseVisualStyleBackColor = True
        ' 
        ' btnupdateproduct
        ' 
        btnupdateproduct.AccessibleName = "btnupdateproduct"
        btnupdateproduct.Location = New Point(966, 366)
        btnupdateproduct.Name = "btnupdateproduct"
        btnupdateproduct.Size = New Size(94, 29)
        btnupdateproduct.TabIndex = 15
        btnupdateproduct.Text = "UPDATE"
        btnupdateproduct.UseVisualStyleBackColor = True
        ' 
        ' btndeleteproduct
        ' 
        btndeleteproduct.AccessibleName = "btndeleteproduct"
        btndeleteproduct.Location = New Point(1091, 366)
        btndeleteproduct.Name = "btndeleteproduct"
        btndeleteproduct.Size = New Size(94, 29)
        btndeleteproduct.TabIndex = 16
        btndeleteproduct.Text = "DELETE"
        btndeleteproduct.UseVisualStyleBackColor = True
        ' 
        ' btnclearproduct
        ' 
        btnclearproduct.AccessibleName = "btnclearproduct"
        btnclearproduct.Location = New Point(1308, 158)
        btnclearproduct.Name = "btnclearproduct"
        btnclearproduct.Size = New Size(94, 29)
        btnclearproduct.TabIndex = 17
        btnclearproduct.Text = "CLEAR"
        btnclearproduct.UseVisualStyleBackColor = True
        ' 
        ' txtcategoryid
        ' 
        txtcategoryid.AccessibleName = "txtcategoryid"
        txtcategoryid.Location = New Point(271, 125)
        txtcategoryid.Name = "txtcategoryid"
        txtcategoryid.Size = New Size(178, 27)
        txtcategoryid.TabIndex = 18
        ' 
        ' txtcategoryname
        ' 
        txtcategoryname.AccessibleName = "txtcategoryname"
        txtcategoryname.Location = New Point(271, 160)
        txtcategoryname.Name = "txtcategoryname"
        txtcategoryname.Size = New Size(178, 27)
        txtcategoryname.TabIndex = 19
        ' 
        ' txtsellingprice
        ' 
        txtsellingprice.AccessibleName = "txtsellingprice"
        txtsellingprice.Location = New Point(1091, 262)
        txtsellingprice.Name = "txtsellingprice"
        txtsellingprice.Size = New Size(178, 27)
        txtsellingprice.TabIndex = 20
        ' 
        ' txtquantity
        ' 
        txtquantity.AccessibleName = "txtquantity"
        txtquantity.Location = New Point(1091, 229)
        txtquantity.Name = "txtquantity"
        txtquantity.Size = New Size(178, 27)
        txtquantity.TabIndex = 21
        ' 
        ' txtproductid
        ' 
        txtproductid.AccessibleName = "txtproductid"
        txtproductid.Location = New Point(1091, 129)
        txtproductid.Name = "txtproductid"
        txtproductid.Size = New Size(178, 27)
        txtproductid.TabIndex = 22
        ' 
        ' txtproductname
        ' 
        txtproductname.AccessibleName = "txtproductname"
        txtproductname.Location = New Point(1091, 162)
        txtproductname.Name = "txtproductname"
        txtproductname.Size = New Size(178, 27)
        txtproductname.TabIndex = 23
        ' 
        ' comboboxcategory
        ' 
        comboboxcategory.AccessibleDescription = ""
        comboboxcategory.AccessibleName = " comboboxcategory"
        comboboxcategory.FormattingEnabled = True
        comboboxcategory.Location = New Point(1091, 195)
        comboboxcategory.Name = "comboboxcategory"
        comboboxcategory.Size = New Size(178, 28)
        comboboxcategory.TabIndex = 24
        ' 
        ' txtcostprice
        ' 
        txtcostprice.AccessibleName = "txtcostprice"
        txtcostprice.Location = New Point(1091, 295)
        txtcostprice.Name = "txtcostprice"
        txtcostprice.Size = New Size(178, 27)
        txtcostprice.TabIndex = 25
        ' 
        ' btncategorysearch
        ' 
        btncategorysearch.AccessibleName = "btncategorysearch"
        btncategorysearch.Location = New Point(483, 123)
        btncategorysearch.Name = "btncategorysearch"
        btncategorysearch.Size = New Size(94, 29)
        btncategorysearch.TabIndex = 26
        btncategorysearch.Text = "Search"
        btncategorysearch.UseVisualStyleBackColor = True
        ' 
        ' btnproductsearch
        ' 
        btnproductsearch.AccessibleName = "btnproductsearch"
        btnproductsearch.Location = New Point(1308, 123)
        btnproductsearch.Name = "btnproductsearch"
        btnproductsearch.Size = New Size(94, 29)
        btnproductsearch.TabIndex = 27
        btnproductsearch.Text = "Search"
        btnproductsearch.UseVisualStyleBackColor = True
        ' 
        ' gridproduct
        ' 
        gridproduct.AccessibleName = "gridproduct"
        gridproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridproduct.Location = New Point(844, 429)
        gridproduct.Name = "gridproduct"
        gridproduct.RowHeadersWidth = 51
        gridproduct.RowTemplate.Height = 29
        gridproduct.Size = New Size(866, 411)
        gridproduct.TabIndex = 29
        ' 
        ' gridcategory
        ' 
        gridcategory.AccessibleName = "gridcategory"
        gridcategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridcategory.Location = New Point(57, 438)
        gridcategory.Name = "gridcategory"
        gridcategory.RowHeadersWidth = 51
        gridcategory.RowTemplate.Height = 29
        gridcategory.Size = New Size(447, 411)
        gridcategory.TabIndex = 30
        ' 
        ' btnrefreshproduct
        ' 
        btnrefreshproduct.AccessibleName = "btnrefreshproduct"
        btnrefreshproduct.Location = New Point(1207, 366)
        btnrefreshproduct.Name = "btnrefreshproduct"
        btnrefreshproduct.Size = New Size(94, 29)
        btnrefreshproduct.TabIndex = 31
        btnrefreshproduct.Text = "RELOAD"
        btnrefreshproduct.UseVisualStyleBackColor = True
        ' 
        ' btnrefreshcategory
        ' 
        btnrefreshcategory.AccessibleName = "btnrefreshcategory"
        btnrefreshcategory.Location = New Point(410, 366)
        btnrefreshcategory.Name = "btnrefreshcategory"
        btnrefreshcategory.Size = New Size(94, 29)
        btnrefreshcategory.TabIndex = 32
        btnrefreshcategory.Text = "RELOAD"
        btnrefreshcategory.UseVisualStyleBackColor = True
        ' 
        ' Product
        ' 
        AccessibleName = "Product "
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(1766, 1003)
        Controls.Add(btnrefreshcategory)
        Controls.Add(btnrefreshproduct)
        Controls.Add(gridcategory)
        Controls.Add(gridproduct)
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
        StartPosition = FormStartPosition.CenterScreen
        Text = "Product"
        WindowState = FormWindowState.Maximized
        CType(gridproduct, ComponentModel.ISupportInitialize).EndInit()
        CType(gridcategory, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gridproduct As DataGridView
    Friend WithEvents gridcategory As DataGridView
    Friend WithEvents btnrefreshproduct As Button
    Friend WithEvents btnrefreshcategory As Button
End Class
