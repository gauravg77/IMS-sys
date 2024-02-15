Imports System.Diagnostics.Eventing
Imports Microsoft.Data.SqlClient

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
    Private Sub bthclearcategory_Click(sender As Object, e As EventArgs) Handles bthclearcategory.Click
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

    'removing data and inserting it in the bin
    Private Sub btndeletecategory_Click(sender As Object, e As EventArgs) Handles btndeletecategory.Click
        Try
            Dim categoryid As String = txtcategoryid.Text
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
                connection.Open()

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

    Private Sub btndeleteproduct_Click(sender As Object, e As EventArgs) Handles btndeleteproduct.Click
        Try
            Dim productid As String = txtproductid.Text

            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust server certificate=True;User Instance=False")
                connection.Open()

                ' Select data before deleting
                Dim productName As String = ""
                Dim selectCommandText As String = "SELECT productname FROM tblproductmanagement WHERE productid = @productid"
                Using selectCommand As New SqlCommand(selectCommandText, connection)
                    selectCommand.Parameters.AddWithValue("@productid", productid)
                    productName = Convert.ToString(selectCommand.ExecuteScalar())
                End Using

                ' Delete
                Dim deleteCommandText As String = "DELETE FROM tblproductmanagement WHERE productid = @productid"
                Using deleteCommand As New SqlCommand(deleteCommandText, connection)
                    deleteCommand.Parameters.AddWithValue("@productid", productid)
                    deleteCommand.ExecuteNonQuery()
                End Using

                ' Insert into bin
                Dim insertCommandText As String = "INSERT INTO tblproductmanagementbin(productid, productname) VALUES (@productid, @productname)"
                Using insertCommand As New SqlCommand(insertCommandText, connection)
                    insertCommand.Parameters.AddWithValue("@productid", productid)
                    insertCommand.Parameters.AddWithValue("@productname", productName)
                    insertCommand.ExecuteNonQuery()
                End Using

                MessageBox.Show("Product removed successfully.")
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL insertion error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error removing product: " & ex.Message)
        End Try
    End Sub

    'for updating data of category
    Private Sub btnupdatecategory_Click(sender As Object, e As EventArgs) Handles btnupdatecategory.Click
        Try
            connection.Open()

            For Each row As DataGridViewRow In gridcategory.Rows
                If Not row.IsNewRow Then
                    Dim categoryid As String = row.Cells("categoryid").Value.ToString()
                    Dim categoryname As String = row.Cells("categoryname").Value.ToString()

                    Dim updateCommandText As String = "UPDATE tblcategory SET categoryname = @categoryname WHERE categoryid = @categoryid"
                    Using updateCommand As New SqlCommand(updateCommandText, connection)
                        updateCommand.Parameters.AddWithValue("@categoryid", categoryid)
                        updateCommand.Parameters.AddWithValue("@categoryname", categoryname)
                        updateCommand.ExecuteNonQuery()
                    End Using
                End If
            Next

            MessageBox.Show("Data updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    'for updating product
    Private Sub btnupdateproduct_Click(sender As Object, e As EventArgs) Handles btnupdateproduct.Click
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
            Next

            MessageBox.Show("Data updated successfully.")
        Catch ex As Exception
            MessageBox.Show("Error updating data: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


End Class
