Imports System.Diagnostics.Eventing
Imports Microsoft.Data.SqlClient
Module NightModeHelper
    Public NightModeEnabled As Boolean = False
End Module


Public Class Product
    Dim connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")


    ' Method to show value taken as input in categoryname textbox
    Private Sub PopulateCategoryComboBox()
        Dim query As String = "SELECT categoryname FROM tblcategory"

        comboboxcategory.Items.Clear()

        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
                connection.Open()
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()

                While reader.Read()
                    comboboxcategory.Items.Add(reader("categoryname").ToString())
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error populating category names: " & ex.Message)
        End Try
    End Sub




    'to load product data in gridview
    Private Sub LoadProductData()
        Dim query As String = "SELECT * FROM tblproductmanagement"
        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")

                connection.Open()
                Dim adapter As New SqlDataAdapter(query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                gridproduct.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading product data: " & ex.Message)

        End Try
    End Sub

    'to load category in category grid view

    Private Sub LoadCategoryData()
        Dim query As String = "Select * from tblcategory"
        Try
            connection.Open()
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            gridcategory.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error loading category data:", ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub



    ' Call PopulateCategoryComboBox method in the form load event
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.WhiteSmoke ' Light blue
        ' Update textboxes
        txtcategoryname.BackColor = SystemColors.Window
        txtcategoryname.ForeColor = SystemColors.ControlText
        ' Update category management buttons
        btnaddcategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btnclearcategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btndeletecategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btnrefreshcategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btnupdatecategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btnproductsearch.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btncategorysearch.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue


        ' Update home button
        btnhome.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        ' Update combobox
        comboboxcategory.BackColor = SystemColors.Window
        comboboxcategory.ForeColor = SystemColors.ControlText
        ' Update product management buttons
        btnaddproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btnclearproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btndeleteproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btnrefreshproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        btnupdateproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
        ' Set text colors for light mode
        btnaddcategory.ForeColor = Color.White
        btnclearcategory.ForeColor = Color.White
        btndeletecategory.ForeColor = Color.White
        btnrefreshcategory.ForeColor = Color.White
        btnupdatecategory.ForeColor = Color.White
        btnhome.ForeColor = Color.White
        btnaddproduct.ForeColor = Color.White
        btnclearproduct.ForeColor = Color.White
        btndeleteproduct.ForeColor = Color.White
        btnrefreshproduct.ForeColor = Color.White
        btnupdateproduct.ForeColor = Color.White
        btnproductsearch.ForeColor = Color.White
        btncategorysearch.ForeColor = Color.White

        ' Update labels
        For Each ctrl As Control In GetAllControlsRecursive(Me)
            If TypeOf ctrl Is Label Then
                ctrl.ForeColor = Color.Black ' Darker blue
            End If
        Next
        PopulateCategoryComboBox()
        LoadProductData()
        LoadCategoryData()

    End Sub




    'to add category
    Private Sub btnaddcategory_Click(sender As Object, e As EventArgs) Handles btnaddcategory.Click
        Dim productcategory As String = txtcategoryname.Text
        If String.IsNullOrEmpty(productcategory) Then
            MessageBox.Show("Category name cannot be empty.")
            Return
        End If

        connection.Open()

        ' Check if the category name already exists
        Dim checkCommandText As String = "SELECT COUNT(*) FROM tblcategory WHERE categoryname = @categoryname"
        Using checkCommand As New SqlCommand(checkCommandText, connection)
            checkCommand.Parameters.AddWithValue("@categoryname", productcategory)
            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
            If count > 0 Then
                MessageBox.Show("Category name already exists.")
                Return
            End If
            connection.Close()
        End Using


        Try
            connection.Open()
            Dim command As New SqlCommand("INSERT INTO tblcategory(categoryname) VALUES ('" & productcategory & "')", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Category added successfully.")
            PopulateCategoryComboBox()
        Catch ex As Exception
            MessageBox.Show("Error adding category: " & ex.Message)
        Finally

            connection.Close()
        End Try
    End Sub

    Private Function GetTxtcategoryid() As TextBox
        Return txtcategoryid
    End Function



    'to search category
    Private Sub btncategorysearch_Click(sender As Object, e As EventArgs) Handles btncategorysearch.Click
        Dim categoryid As String = txtcategoryid.Text
        Dim categoryname As String = txtcategoryname.Text

        If String.IsNullOrEmpty(categoryid) AndAlso String.IsNullOrEmpty(categoryname) Then
            MessageBox.Show("Please enter a category ID or category name.")
            Return
        End If

        Try
            connection.Open()
            Dim query As String = "SELECT categoryid, categoryname FROM tblcategory WHERE categoryid = @categoryid OR categoryname = @categoryname"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@categoryid", categoryid)
            command.Parameters.AddWithValue("@categoryname", categoryname)

            Dim adapter As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                txtcategoryid.Text = dt.Rows(0)("categoryid").ToString()
                txtcategoryname.Text = dt.Rows(0)("categoryname").ToString()
                gridcategory.DataSource = dt
            Else
                MessageBox.Show("Category not found.")
                txtcategoryid.Clear()
                txtcategoryname.Clear()
                gridcategory.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching for category: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    'to add product
    Private Sub btnaddproduct_Click(sender As Object, e As EventArgs) Handles btnaddproduct.Click
        Dim productname As String = txtproductname.Text
        Dim category As String = comboboxcategory.Text
        Dim quantity As String = txtquantity.Text
        Dim sellingprice As String = txtsellingprice.Text
        Dim costprice As String = txtcostprice.Text


        If String.IsNullOrEmpty(productname) OrElse String.IsNullOrEmpty(category) OrElse String.IsNullOrEmpty(quantity) OrElse String.IsNullOrEmpty(sellingprice) OrElse String.IsNullOrEmpty(costprice) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        connection.Open()
        Dim checkCommand As New SqlCommand("SELECT COUNT(*) FROM tblproductmanagement WHERE productname = @productname", connection)
        checkCommand.Parameters.AddWithValue("@productname", productname)
        Dim count As Integer = checkCommand.ExecuteScalar()
        connection.Close()

        If count > 0 Then
            MessageBox.Show("Product already exists.")
            Return
        End If

        Try
            connection.Open()
            Dim command As New SqlCommand("INSERT INTO tblproductmanagement(productname, category, quantity, sellingprice, costprice) VALUES (@productname, @category, @quantity, @sellingprice, @costprice)", connection)
            command.Parameters.AddWithValue("@productname", productname)
            command.Parameters.AddWithValue("@category", category)
            command.Parameters.AddWithValue("@quantity", quantity)
            command.Parameters.AddWithValue("@sellingprice", sellingprice)
            command.Parameters.AddWithValue("@costprice", costprice)
            command.ExecuteNonQuery()
            MessageBox.Show("new product added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding new product: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    'product search garcha and fills the textbox
    Private Sub btnproductsearch_Click(sender As Object, e As EventArgs) Handles btnproductsearch.Click
        Dim productid As String = txtproductid.Text
        Dim productname As String = txtproductname.Text

        If String.IsNullOrEmpty(productid) AndAlso String.IsNullOrEmpty(productname) Then
            MessageBox.Show("Please enter a product ID or product name.")
            Return
        End If

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM tblproductmanagement WHERE productid = @productid OR productname = @productname"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@productid", productid)
            command.Parameters.AddWithValue("@productname", productname)

            Dim adapter As New SqlDataAdapter(command)
            Dim dt As New DataTable()
            adapter.Fill(dt)

            If dt.Rows.Count > 0 Then
                txtproductid.Text = dt.Rows(0)("productid").ToString()
                txtproductname.Text = dt.Rows(0)("productname").ToString()
                comboboxcategory.Text = dt.Rows(0)("category").ToString()
                txtquantity.Text = dt.Rows(0)("quantity").ToString()
                txtsellingprice.Text = dt.Rows(0)("sellingprice").ToString()
                txtcostprice.Text = dt.Rows(0)("costprice").ToString()
                gridproduct.DataSource = dt
            Else
                MessageBox.Show("Product not found.")
                txtproductid.Clear()
                txtproductname.Clear()
                comboboxcategory.Text = ""
                txtquantity.Clear()
                txtsellingprice.Clear()
                txtcostprice.Clear()
                gridproduct.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching for product: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    'to clear product
    Private Sub btnclearproduct_Click(sender As Object, e As EventArgs) Handles btnclearproduct.Click
        txtproductid.Clear()
        txtproductname.Clear()
        comboboxcategory.Text = ""
        txtquantity.Clear()
        txtsellingprice.Clear()
        txtcostprice.Clear()
    End Sub

    'automatic product clear
    Private Sub txtproductid_TextChanged(sender As Object, e As EventArgs) Handles txtproductid.TextChanged
        If String.IsNullOrEmpty(txtproductid.Text) Then
            txtproductname.Clear()
            comboboxcategory.Text = ""
            txtquantity.Clear()
            txtsellingprice.Clear()
            txtcostprice.Clear()
            gridproduct.DataSource = Nothing
        End If
    End Sub

    'to clear category
    Private Sub bthclearcategory_Click(sender As Object, e As EventArgs) Handles btnclearcategory.Click
        txtcategoryid.Clear()
        txtcategoryname.Clear()
    End Sub

    'automatic category clear
    Private Sub txtcategoryid_TextChanged(sender As Object, e As EventArgs) Handles txtcategoryid.TextChanged
        If String.IsNullOrEmpty(txtcategoryid.Text) Then
            txtcategoryname.Clear()
            gridcategory.DataSource = Nothing
        End If
    End Sub



    'refresh button category
    Private Sub btnrefreshcategory_Click(sender As Object, e As EventArgs) Handles btnrefreshcategory.Click
        Try
            Dim query As String = "SELECT * FROM tblcategory"
            Dim dt As New DataTable()

            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
                connection.Open()

                Dim adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dt) 'grid fill garcha

                gridcategory.DataSource = dt ' Display the category data in gridproduct
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading categories: " & ex.Message)
        End Try
    End Sub

    'refresh button product
    Private Sub btnrefreshproduct_Click(sender As Object, e As EventArgs) Handles btnrefreshproduct.Click
        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
                connection.Open()
                Dim query As String = "select * from tblproductmanagement"
                Dim dt As New DataTable()
                Dim adapter As New SqlDataAdapter(query, connection)
                adapter.Fill(dt)
                gridproduct.DataSource = dt
                connection.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("error loading product:" & ex.Message)
        End Try

    End Sub

    'removing category and inserting it in the bin
    Private Sub btndeletecategory_Click(sender As Object, e As EventArgs) Handles btndeletecategory.Click
        Try
            Dim categoryid As String = txtcategoryid.Text
            If String.IsNullOrWhiteSpace(categoryid) Then
                MessageBox.Show("Please enter a category ID.")
                Return
            End If

            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
                connection.Open()

                ' checks category if it exist or not 

                Dim categoryExists As Boolean = False
                Dim checkCommandText As String = "SELECT COUNT(*) FROM tblcategory WHERE categoryid = @categoryid"
                Using checkCommand As New SqlCommand(checkCommandText, connection)
                    checkCommand.Parameters.AddWithValue("@categoryid", categoryid)
                    categoryExists = Convert.ToInt32(checkCommand.ExecuteScalar()) > 0
                End Using

                If Not categoryExists Then
                    MessageBox.Show("Category with the specified ID does not exist.")
                    Return
                End If

                ' Select data before deleting
                Dim categoryName As String = ""
                Dim selectCommandText As String = "SELECT categoryname FROM tblcategory WHERE categoryid = @categoryid"
                Using selectCommand As New SqlCommand(selectCommandText, connection)
                    selectCommand.Parameters.AddWithValue("@categoryid", categoryid)
                    categoryName = Convert.ToString(selectCommand.ExecuteScalar())
                End Using

                ' Delete

                Dim deleteCommandText As String = "DELETE FROM tblcategory WHERE categoryid = @categoryid"
                Using deleteCommand As New SqlCommand(deleteCommandText, connection)
                    deleteCommand.Parameters.AddWithValue("@categoryid", categoryid)
                    deleteCommand.ExecuteNonQuery()
                End Using

                ' Insert into bin
                Dim insertCommandText As String = "INSERT INTO tblcategorybin(categoryid, categoryname) VALUES (@categoryid, @categoryname)"
                Using insertCommand As New SqlCommand(insertCommandText, connection)
                    insertCommand.Parameters.AddWithValue("@categoryid", categoryid)
                    insertCommand.Parameters.AddWithValue("@categoryname", categoryName)
                    insertCommand.ExecuteNonQuery()
                    connection.Close()
                End Using

                MessageBox.Show("Category removed successfully.")
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error removing category: " & ex.Message)
        End Try
    End Sub


    ' Removing product and moving to bin
    Private Sub btndeleteproduct_Click(sender As Object, e As EventArgs) Handles btndeleteproduct.Click
        Try
            Dim productid As String = txtproductid.Text
            If String.IsNullOrWhiteSpace(productid) Then
                MessageBox.Show("Please enter a product ID.")
                Return
            End If

            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
                connection.Open()

                ' Check if the product exists
                Dim productExists As Boolean = False
                Dim checkCommandText As String = "SELECT COUNT(*) FROM tblproductmanagement WHERE productid = @productid"
                Using checkCommand As New SqlCommand(checkCommandText, connection)
                    checkCommand.Parameters.AddWithValue("@productid", productid)
                    productExists = Convert.ToInt32(checkCommand.ExecuteScalar()) > 0
                End Using

                If Not productExists Then
                    MessageBox.Show("Product with the specified ID does not exist.")
                    Return
                End If

                ' Move product to bin
                Dim moveCommandText As String = "INSERT INTO tblproductmanagementbin (productid, productname, category, quantity, sellingprice, costprice) " &
                                             "SELECT productid, productname, category, quantity, sellingprice, costprice FROM tblproductmanagement WHERE productid = @productid"
                Using moveCommand As New SqlCommand(moveCommandText, connection)
                    moveCommand.Parameters.AddWithValue("@productid", productid)
                    moveCommand.ExecuteNonQuery()
                End Using

                ' Delete from product management table
                Dim deleteCommandText As String = "DELETE FROM tblproductmanagement WHERE productid = @productid"
                Using deleteCommand As New SqlCommand(deleteCommandText, connection)
                    deleteCommand.Parameters.AddWithValue("@productid", productid)
                    deleteCommand.ExecuteNonQuery()
                End Using

                MessageBox.Show("Product moved to bin successfully.")
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL insertion error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error moving product to bin: " & ex.Message)
        End Try
    End Sub



    ' for updating category
    Private Sub btnupdatecategory_Click(sender As Object, e As EventArgs) Handles btnupdatecategory.Click
        Dim changesMade As Boolean = False ' Flag to track changes

        Try
            connection.Open()

            For Each row As DataGridViewRow In gridcategory.Rows
                If Not row.IsNewRow Then
                    Dim categoryid As String = row.Cells("categoryid").Value.ToString()
                    Dim categoryname As String = row.Cells("categoryname").Value.ToString()

                    ' Check if there are any changes
                    Dim originalCategoryName As String = ""
                    Dim selectCommandText As String = "SELECT categoryname FROM tblcategory WHERE categoryid = @categoryid"
                    Using selectCommand As New SqlCommand(selectCommandText, connection)
                        selectCommand.Parameters.AddWithValue("@categoryid", categoryid)
                        originalCategoryName = Convert.ToString(selectCommand.ExecuteScalar())
                    End Using

                    If categoryname <> originalCategoryName Then ' Change detected
                        changesMade = True

                        ' Check if there is already an existing category with the same name
                        Dim checkCommandText As String = "SELECT COUNT(*) FROM tblcategory WHERE categoryname = @categoryname AND categoryid != @categoryid"
                        Using checkCommand As New SqlCommand(checkCommandText, connection)
                            checkCommand.Parameters.AddWithValue("@categoryname", categoryname)
                            checkCommand.Parameters.AddWithValue("@categoryid", categoryid)
                            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                            If count > 0 Then
                                MessageBox.Show("Category name '" & categoryname & "' already exists.")
                                Return
                            End If
                        End Using

                        ' Update the category name
                        Dim updateCommandText As String = "UPDATE tblcategory SET categoryname = @categoryname WHERE categoryid = @categoryid"
                        Using updateCommand As New SqlCommand(updateCommandText, connection)
                            updateCommand.Parameters.AddWithValue("@categoryid", categoryid)
                            updateCommand.Parameters.AddWithValue("@categoryname", categoryname)
                            updateCommand.ExecuteNonQuery()
                        End Using
                    End If
                End If
            Next

            If Not changesMade Then
                MessageBox.Show("Please make changes before updating.")
            Else
                MessageBox.Show("Data updated successfully.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    'for updating product
    Private Sub btnupdateproduct_Click(sender As Object, e As EventArgs) Handles btnupdateproduct.Click
        Dim changesMade As Boolean = False ' Flag to track changes

        Try
            connection.Open()

            For Each row As DataGridViewRow In gridproduct.Rows
                If Not row.IsNewRow Then
                    Dim productid As String = row.Cells("productid").Value.ToString()
                    Dim productname As String = row.Cells("productname").Value.ToString()
                    Dim category As String = row.Cells("category").Value.ToString()
                    Dim quantity As Integer = Convert.ToInt32(row.Cells("quantity").Value)
                    Dim sellingprice As Decimal = Convert.ToDecimal(row.Cells("sellingprice").Value)
                    Dim costprice As Decimal = Convert.ToDecimal(row.Cells("costprice").Value)

                    ' Check if there are any changes
                    Dim originalProductName As String = ""
                    Dim originalCategory As String = ""
                    Dim originalQuantity As Integer
                    Dim originalSellingPrice As Decimal
                    Dim originalCostPrice As Decimal
                    Dim selectCommandText As String = "SELECT productname, category, quantity, sellingprice, costprice FROM tblproductmanagement WHERE productid = @productid"
                    Using selectCommand As New SqlCommand(selectCommandText, connection)
                        selectCommand.Parameters.AddWithValue("@productid", productid)
                        Dim reader As SqlDataReader = selectCommand.ExecuteReader()
                        If reader.Read() Then
                            originalProductName = reader("productname").ToString()
                            originalCategory = reader("category").ToString()
                            originalQuantity = Convert.ToInt32(reader("quantity"))
                            originalSellingPrice = Convert.ToDecimal(reader("sellingprice"))
                            originalCostPrice = Convert.ToDecimal(reader("costprice"))
                        End If
                        reader.Close()
                    End Using

                    If productname <> originalProductName OrElse category <> originalCategory OrElse quantity <> originalQuantity OrElse sellingprice <> originalSellingPrice OrElse costprice <> originalCostPrice Then ' Change detected
                        changesMade = True

                        ' Check if the product name already exists
                        Dim checkCommandText As String = "SELECT COUNT(*) FROM tblproductmanagement WHERE productname = @productname AND productid != @productid"
                        Using checkCommand As New SqlCommand(checkCommandText, connection)
                            checkCommand.Parameters.AddWithValue("@productname", productname)
                            checkCommand.Parameters.AddWithValue("@productid", productid)
                            Dim count As Integer = Convert.ToInt32(checkCommand.ExecuteScalar())
                            If count > 0 Then
                                MessageBox.Show("Product name '" & productname & "' already exists.")
                                Return
                            End If
                        End Using

                        ' Update the product data
                        Dim updateCommandText As String = "UPDATE tblproductmanagement SET productname = @productname, category = @category, quantity = @quantity, sellingprice = @sellingprice, costprice = @costprice WHERE productid = @productid"
                        Using updateCommand As New SqlCommand(updateCommandText, connection)
                            updateCommand.Parameters.AddWithValue("@productid", productid)
                            updateCommand.Parameters.AddWithValue("@productname", productname)
                            updateCommand.Parameters.AddWithValue("@category", category)
                            updateCommand.Parameters.AddWithValue("@quantity", quantity)
                            updateCommand.Parameters.AddWithValue("@sellingprice", sellingprice)
                            updateCommand.Parameters.AddWithValue("@costprice", costprice)
                            updateCommand.ExecuteNonQuery()
                        End Using
                    End If
                End If
            Next

            If changesMade Then
                MessageBox.Show("Data updated successfully.")
            Else
                MessageBox.Show("Please make changes before updating.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim Dashboard As New Dashboard()
        Dashboard.Show()
        Me.Hide()
    End Sub


    'for darkmode and light mode
    Private darkModeEnabled As Boolean = False

    Private Sub Nightmode_CheckedChanged(sender As Object, e As EventArgs) Handles Nightmode.CheckedChanged
        ' Toggle dark mode state
        darkModeEnabled = Nightmode.Checked

        ' Update form appearance
        If darkModeEnabled Then
            ' Set dark mode
            Me.BackColor = Color.FromArgb(31, 31, 31)
            ' Update textboxes
            txtcategoryname.BackColor = Color.FromArgb(45, 45, 48)
            txtcategoryname.ForeColor = Color.White
            ' Update category management buttons
            btnaddcategory.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnclearcategory.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btndeletecategory.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnrefreshcategory.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnupdatecategory.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btncategorysearch.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnproductsearch.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnpbin.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btncbin.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray

            ' Update home button
            btnhome.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            ' Update combobox
            comboboxcategory.BackColor = Color.FromArgb(45, 45, 48)
            comboboxcategory.ForeColor = Color.White
            ' Update product management buttons
            btnaddproduct.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnclearproduct.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btndeleteproduct.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnrefreshproduct.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnupdateproduct.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btnpbin.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btncbin.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            ' Set text colors for dark mode
            btnaddcategory.ForeColor = Color.White
            btnclearcategory.ForeColor = Color.White
            btndeletecategory.ForeColor = Color.White
            btnrefreshcategory.ForeColor = Color.White
            btnupdatecategory.ForeColor = Color.White
            btnhome.ForeColor = Color.White
            btnaddproduct.ForeColor = Color.White
            btnclearproduct.ForeColor = Color.White
            btndeleteproduct.ForeColor = Color.White
            btnrefreshproduct.ForeColor = Color.White
            btnupdateproduct.ForeColor = Color.White
            btncategorysearch.ForeColor = Color.White
            btnproductsearch.ForeColor = Color.White
            btnpbin.ForeColor = Color.White
            btncbin.ForeColor = Color.White


            ' Update labels
            For Each ctrl As Control In GetAllControlsRecursive(Me)
                If TypeOf ctrl Is Label Then
                    ctrl.ForeColor = Color.White
                End If
            Next
        Else
            ' Set light mode
            Me.BackColor = Color.WhiteSmoke ' Light blue
            ' Update textboxes
            txtcategoryname.BackColor = SystemColors.Window
            txtcategoryname.ForeColor = SystemColors.ControlText
            ' Update category management buttons
            btnaddcategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnclearcategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btndeletecategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnrefreshcategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnupdatecategory.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnproductsearch.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btncategorysearch.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnpbin.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btncbin.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue



            ' Update home button
            btnhome.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            ' Update combobox
            comboboxcategory.BackColor = SystemColors.Window
            comboboxcategory.ForeColor = SystemColors.ControlText
            ' Update product management buttons
            btnaddproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnclearproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btndeleteproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnrefreshproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnupdateproduct.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btnpbin.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btncbin.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue

            ' Set text colors for light mode
            btnaddcategory.ForeColor = Color.White
            btnclearcategory.ForeColor = Color.White
            btndeletecategory.ForeColor = Color.White
            btnrefreshcategory.ForeColor = Color.White
            btnupdatecategory.ForeColor = Color.White
            btnhome.ForeColor = Color.White
            btnaddproduct.ForeColor = Color.White
            btnclearproduct.ForeColor = Color.White
            btndeleteproduct.ForeColor = Color.White
            btnrefreshproduct.ForeColor = Color.White
            btnupdateproduct.ForeColor = Color.White
            btnproductsearch.ForeColor = Color.White
            btncategorysearch.ForeColor = Color.White
            btnpbin.ForeColor = Color.White

            btncbin.ForeColor = Color.White


            ' Update labels
            For Each ctrl As Control In GetAllControlsRecursive(Me)
                If TypeOf ctrl Is Label Then
                    ctrl.ForeColor = Color.Black ' Darker blue
                End If
            Next
        End If
    End Sub

    Private Function GetAllControlsRecursive(ByVal parent As Control) As List(Of Control)
        Dim controlList As New List(Of Control)

        For Each childControl As Control In parent.Controls
            ' Add the current control to the list
            controlList.Add(childControl)
            ' Recursively call the function for child controls
            controlList.AddRange(GetAllControlsRecursive(childControl))
        Next

        Return controlList
    End Function

    Private Sub btncbin_Click(sender As Object, e As EventArgs) Handles btncbin.Click
        ' Assuming you have a connection established named "connectionString"
        Dim queryString As String = "SELECT * FROM tblcategorybin"

        Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
            Dim dataAdapter As New SqlDataAdapter(queryString, connection)
            Dim dataTable As New DataTable()

            ' Fill the DataTable with the data from the SQL query
            dataAdapter.Fill(dataTable)

            ' Assign the DataTable as the DataSource for the DataGridView
            gridcategory.DataSource = dataTable
        End Using
    End Sub

    Private Sub btnpbin_Click(sender As Object, e As EventArgs) Handles btnpbin.Click

        ' Define your SQL query to select data from the tblproductmanagementbin table
        Dim query As String = "SELECT * FROM tblproductmanagementbin"

        ' Create a new DataTable to hold the data
        Dim dataTable As New DataTable()

        ' Create a new SqlConnection using your connection string
        Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
            ' Create a new SqlDataAdapter with your query and connection
            Using adapter As New SqlDataAdapter(query, connection)
                Try
                    connection.Open()
                    ' Fill the DataTable with the data from the query
                    adapter.Fill(dataTable)

                    ' Bind the DataTable to the DataGridView
                    gridproduct.DataSource = dataTable
                Catch ex As Exception
                    ' Handle any exceptions
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class
