Imports System.Windows.Input
Imports Microsoft.Data.SqlClient

Public Class Form2
    Dim loginForm As New Form1()
    Dim connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim username As String = TextBoxusername.Text
        Dim password As String = TextBoxpassword.Text
        Dim confirmpassword As String = TextBoxConfirmpassword.Text
        If username = "" Or password = "" Or confirmpassword = "" Then
            MessageBox.Show("Error: Please fill in all fields")
            Return
        End If
        If TextBoxConfirmpassword.Text = TextBoxpassword.Text Then
            Dim command As New SqlCommand("insert into tblsignup(Adminusername,Password)values ('" & TextBoxusername.Text & "','" & TextBoxpassword.Text & "')", connection) 'sqlcommand lai duita parameter chaincha, one is query ani another is the variable for sql connection

            Try
                connection.Open()
                If command.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Signed up successfully")

                    loginForm.Show()
                    Me.Hide()

                Else
                    MessageBox.Show("User not added")
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Passwords do not match")
        End If



    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        'to navigate control towards loginform
        Form1.Show()
        Me.Hide()
    End Sub
End Class