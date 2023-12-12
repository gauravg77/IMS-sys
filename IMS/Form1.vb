Imports Microsoft.Data.SqlClient

Public Class Form1
    Dim connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim signinForm As New Form2()
        signinForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim username As String = textboxuserid.Text
        Dim password As String = textboxpassword.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Error: Please fill in all fields")
            Return 'exit garcha
        End If

        Dim command As New SqlCommand("SELECT COUNT(*) FROM tblsignup WHERE Adminusername = @username AND Password = @password", connection)
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        Try
            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            'command executes and executeScalar() counts the satisfied rows as objects and toint32 converts it into 32 bit integers

            If count > 0 Then

                'homeinterface ma navigate garnako lagi
                Dim form3 As New Form3()
                form3.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid username or password")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()

        End Try
    End Sub
End Class
