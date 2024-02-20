Imports Microsoft.Data.SqlClient

Public Class billingandsales

    'calculates total in the textbox
    Private Sub CalculateTotal()
        Dim quantity As Integer
        Dim unitPrice As Decimal
        Dim discount As Decimal

        If Integer.TryParse(txtquantity.Text, quantity) AndAlso Decimal.TryParse(txtunitprice.Text, unitPrice) Then
            If Decimal.TryParse(txtdiscount.Text, discount) Then
                Dim total As Decimal = quantity * unitPrice - (quantity * unitPrice * discount / 100)
                txttotal.Text = total.ToString()
            Else
                ' If discount is not provided, calculates total without discount
                Dim total As Decimal = quantity * unitPrice
                txttotal.Text = total.ToString()
            End If
        End If
    End Sub



    ' recalculates the total whenever any of the input fields change

    Private Sub txtproductname_TextChanged(sender As Object, e As EventArgs) Handles txtproductname.TextChanged, txtquantity.TextChanged, txtunitprice.TextChanged, txtdiscount.TextChanged
        ' Calculate total for the current item
        CalculateTotal()

        ' Update unit price based on the product name
        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
                connection.Open()

                Dim query As String = "SELECT sellingprice FROM tblproductmanagement WHERE productname = @ProductName"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductName", txtproductname.Text)
                    Dim sellingPrice As Object = command.ExecuteScalar()

                    If sellingPrice IsNot Nothing AndAlso Not DBNull.Value.Equals(sellingPrice) Then
                        txtunitprice.Text = sellingPrice.ToString()
                    Else
                        txtunitprice.Text = String.Empty ' Clear the textbox if product not found
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading selling price: " & ex.Message)
        End Try



        ' Calculate and fill txtsubtotal with the sum of total of tblInvoiceItemcache
        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
                connection.Open()

                Dim query As String = "SELECT SUM(Total) FROM tblInvoiceItemcache"

                Using command As New SqlCommand(query, connection)
                    Dim subtotal As Object = command.ExecuteScalar()

                    If subtotal IsNot Nothing AndAlso Not DBNull.Value.Equals(subtotal) Then
                        txtsubtotal.Text = subtotal.ToString()
                    Else
                        txtsubtotal.Text = "0" ' Set to 0 if no items in the cache
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading subtotal: " & ex.Message)
        End Try
    End Sub



    Private Sub btnaddtolist_Click(sender As Object, e As EventArgs) Handles btnaddtolist.Click
        ' Get data from textboxes
        Dim productName As String = txtproductname.Text
        Dim quantity As Integer = Integer.Parse(txtquantity.Text)
        Dim unitPrice As Decimal = Decimal.Parse(txtunitprice.Text)
        Dim discount As Decimal

        ' Check if discount textbox is empty
        If String.IsNullOrEmpty(txtdiscount.Text) Then
            discount = 0 ' Set default discount to 0%
        Else
            discount = Decimal.Parse(txtdiscount.Text)
        End If

        Dim total As Decimal
        If Not Decimal.TryParse(txttotal.Text, total) Then
            total = 0 ' Set a default value if parsing fails
        End If

        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
                connection.Open()

                ' Check if the product exists in tblproductmanagement
                Dim checkProductQuery As String = "SELECT COUNT(*) FROM tblproductmanagement WHERE productname = @ProductName"
                Using checkProductCommand As New SqlCommand(checkProductQuery, connection)
                    checkProductCommand.Parameters.AddWithValue("@ProductName", productName)
                    Dim productExists As Integer = Convert.ToInt32(checkProductCommand.ExecuteScalar())

                    If productExists > 0 Then
                        ' Insert data into tblInvoiceItemcache
                        Dim insertQuery As String = "INSERT INTO tblInvoiceItemcache (ProductName, Qty, UnitPrice, Discount, Total) VALUES (@ProductName, @Quantity, @UnitPrice, @Discount, @Total)"
                        Using insertCommand As New SqlCommand(insertQuery, connection)
                            insertCommand.Parameters.AddWithValue("@ProductName", productName)
                            insertCommand.Parameters.AddWithValue("@Quantity", quantity)
                            insertCommand.Parameters.AddWithValue("@UnitPrice", unitPrice)
                            insertCommand.Parameters.AddWithValue("@Discount", discount)
                            insertCommand.Parameters.AddWithValue("@Total", total)
                            insertCommand.ExecuteNonQuery()

                            ' Deduct the quantity from tblproductmanagement
                            Dim updateQuery As String = "UPDATE tblproductmanagement SET quantity = quantity - @Quantity WHERE productname = @ProductName"
                            Using updateCommand As New SqlCommand(updateQuery, connection)
                                updateCommand.Parameters.AddWithValue("@Quantity", quantity)
                                updateCommand.Parameters.AddWithValue("@ProductName", productName)
                                updateCommand.ExecuteNonQuery()
                            End Using
                            txtproductname.Text = ""
                            txtquantity.Text = ""
                            txtunitprice.Text = ""
                            txtdiscount.Text = ""
                            txttotal.Text = ""

                            ' Refresh the grid view
                            LoadInvoiceItemCacheData()
                        End Using
                    Else
                        MessageBox.Show("Item doesn't exist in the product list.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding item to the list: " & ex.Message)
        End Try

    End Sub


    'function to load data in gridbilling
    Private Sub LoadInvoiceItemCacheData()
        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
                connection.Open()

                Dim query As String = "SELECT * FROM tblInvoiceItemcache"

                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    ' Bind the DataTable to the DataGridView
                    gridbilling.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data from tblInvoiceItemcache: " & ex.Message)
        End Try
    End Sub



    'to turn the color of productname red if it doesnt exists


    Private Sub billingandsales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the default text color for the product name textbox
        txtproductname.ForeColor = SystemColors.ControlText
        CalculateGrandTotal()

    End Sub


    Private Sub txtproductname_Leave(sender As Object, e As EventArgs) Handles txtproductname.Leave
        ' Call the method to check product existence when the textbox loses focus
        CheckProductExistence()
        If String.IsNullOrEmpty(txtproductname.Text.Trim()) Then
            ' Clear other textboxes when the textbox is cleared up
            txtquantity.Clear()
            txtunitprice.Clear()
            txtdiscount.Clear()
            txttotal.Clear()
        End If
    End Sub

    ' Reset the text color to black
    Private Sub txtproductname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtproductname.KeyPress
        txtproductname.ForeColor = Color.Black
    End Sub

    Private Sub CheckProductExistence()
        Dim productName As String = txtproductname.Text.Trim()

        Try
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
                connection.Open()

                ' Check if the product exists in tblproductmanagement
                Dim checkProductQuery As String = "SELECT COUNT(*) FROM tblproductmanagement WHERE productname = @ProductName"
                Using checkProductCommand As New SqlCommand(checkProductQuery, connection)
                    checkProductCommand.Parameters.AddWithValue("@ProductName", productName)
                    Dim productExists As Integer = Convert.ToInt32(checkProductCommand.ExecuteScalar())

                    If productExists = 0 Then
                        ' Change the text color of the product name textbox to red if the product doesn't exist
                        txtproductname.ForeColor = Color.Red
                    Else
                        ' Reset the text color to default if the product exists
                        txtproductname.ForeColor = SystemColors.ControlText
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking product existence: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'tocalculate grand total with contantly being changed if anyof the textbox changes
    Private Sub CalculateGrandTotal()
        Dim subtotal As Decimal
        Dim other As Decimal
        Dim taxRate As Decimal

        If Decimal.TryParse(txtsubtotal.Text, subtotal) AndAlso
       Decimal.TryParse(txtothers.Text, other) AndAlso
       Decimal.TryParse(txttaxrate.Text, taxRate) Then
            Dim grandTotal As Decimal = subtotal + other + (subtotal * taxRate / 100)
            txtgrandtotal.Text = grandTotal.ToString()
        End If
    End Sub

    Private Sub txtsubtotal_TextChanged(sender As Object, e As EventArgs) Handles txtsubtotal.TextChanged
        CalculateGrandTotal()
        Try
            Dim subtotal As Decimal
            Dim others As Decimal
            Dim taxRate As Decimal

            ' Parse subtotal value
            If Not Decimal.TryParse(txtsubtotal.Text, subtotal) Then
                subtotal = 0 ' Set default value if parsing fails
            End If

            ' Parse others value
            If Not Decimal.TryParse(txtothers.Text, others) Then
                others = 0 ' Set default value if parsing fails
            End If

            ' Parse taxRate value
            If Not Decimal.TryParse(txttaxrate.Text, taxRate) Then
                taxRate = 0 ' Set default value if parsing fails
            End If

            ' Calculate grand total
            Dim grandTotal As Decimal = subtotal + others + (subtotal * taxRate / 100)
            txtgrandtotal.Text = grandTotal.ToString()
        Catch ex As Exception
            MessageBox.Show("Error calculating grand total: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtothers_TextChanged(sender As Object, e As EventArgs) Handles txtothers.TextChanged
        CalculateGrandTotal()
    End Sub



    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Try
            ' Establish connection to the database
            Using connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
                connection.Open()

                ' Create the SQL query to insert data into tblinvoices
                Dim insertQuery As String = "INSERT INTO tblinvoices (InvoiceDate, BillTo, Address, InvoiceFor, Total) VALUES (@InvoiceDate, @BillTo, @Address, @InvoiceFor, @Total)"

                ' Create and configure the command for inserting data into tblinvoices
                Using insertCommand As New SqlCommand(insertQuery, connection)
                    ' Set parameter values from the text boxes
                    insertCommand.Parameters.AddWithValue("@InvoiceDate", dtinvoice.Value)
                    insertCommand.Parameters.AddWithValue("@BillTo", txtbill.Text)
                    insertCommand.Parameters.AddWithValue("@Address", txtaddress.Text)
                    insertCommand.Parameters.AddWithValue("@InvoiceFor", txtinvoicefor.Text)
                    insertCommand.Parameters.AddWithValue("@Total", txtgrandtotal.Text)

                    ' Execute the insert command
                    insertCommand.ExecuteNonQuery()

                    MessageBox.Show("Data inserted into tblinvoices successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                ' Create the SQL query to delete data from tblInvoiceItemcache
                Dim deleteQuery As String = "DELETE FROM tblInvoiceItemcache"

                ' Create and configure the command for deleting data from tblInvoiceItemcache
                Using deleteCommand As New SqlCommand(deleteQuery, connection)
                    ' Execute the delete command
                    deleteCommand.ExecuteNonQuery()

                    MessageBox.Show("Data deleted from tblInvoiceItemcache.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'clear textboxes
    Private Sub btnnewbill_Click(sender As Object, e As EventArgs) Handles btnnewbill.Click

        txtbill.Text = ""
        txtaddress.Text = ""
        txtinvoicefor.Text = ""
        txtgrandtotal.Text = ""
        txtproductname.Text = ""
        txtquantity.Text = ""
        txtdiscount.Text = ""
        txttotal.Text = ""
        txtothers.Text = ""
        txttaxrate.Text = ""
        txtsubtotal.Text = ""

        gridbilling.DataSource = Nothing
    End Sub

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Dim Dashboard As New Dashboard()
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class







