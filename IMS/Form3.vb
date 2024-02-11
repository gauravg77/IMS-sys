Imports Microsoft.Data.SqlClient

Public Class Product
    Dim connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
    Private Sub btnaddcategory_Click(sender As Object, e As EventArgs) Handles btnaddcategory.Click
        Dim productcategory As String = txtcategoryname.Text

        Try
            connection.Open()
            Dim command As New SqlCommand("INSERT INTO tblcategory(categoryname) VALUES ('" & productcategory & "')", connection)
            command.ExecuteNonQuery()
            MessageBox.Show("Category added successfully.")
        Catch ex As Exception
            MessageBox.Show("Error adding category: " & ex.Message)
        Finally
            ' Close the connection
            connection.Close()
        End Try
    End Sub

    Private Sub btncategorysearch_Click(sender As Object, e As EventArgs) Handles btncategorysearch.Click
        Dim categoryid As String = txtcategoryid.Text
        connection.Open()
        Dim command As New SqlCommand("SELECT categoryname FROM tblcategory WHERE categoryid = @categoryid", connection)
            command.Parameters.AddWithValue("@categoryid", categoryid)
        Try
            Dim categorynameobj As Object = command.ExecuteScalar()

            If categorynameobj IsNot Nothing Then
                txtcategoryname.Text = categorynameobj.ToString()
            Else
                txtcategoryname.Text = ""
                MessageBox.Show("Category not found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error searching for category: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub
End Class