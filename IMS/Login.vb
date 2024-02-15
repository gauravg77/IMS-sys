Imports Guna.UI2.WinForms
Imports Microsoft.Data.SqlClient

Public Class Login
    Dim connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Dim signinForm As New Signup()
        signinForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim username As String = textboxuserid.Text
        Dim password As String = textboxpassword.Text

        If username = "" Or password = "" Then
            MessageBox.Show("Error: Please fill in all fields")
            Return 'exit garcha
        End If

        Dim command As New SqlCommand("SELECT COUNT(*) FROM tbllogindetails WHERE username = @username ", connection)
        'LATIN1 FOR CS=CASESENSITIVE AND BIN for numbersensitive
        command.Parameters.AddWithValue("@username", username)
        command.Parameters.AddWithValue("@password", password)
        Try
            connection.Open()
            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            'command executes and executeScalar() counts the satisfied rows as objects and toint32 converts it into 32 bit integers

            If count > 0 Then

                'homeinterface ma navigate garnako lagi
                Dim form3 As New Product()
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

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged

        If Guna2CheckBox1.Checked = True Then
            textboxpassword.UseSystemPasswordChar = False
        Else
            textboxpassword.UseSystemPasswordChar = True
            'End If
            'If Guna2CheckBox1.Checked = False Then
            '  textboxpassword.UseSystemPasswordChar = True
            'Else
            '    textboxpassword.UseSystemPasswordChar = False
        End If
    End Sub
End Class
