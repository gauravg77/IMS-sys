﻿Imports System.Windows.Input
Imports Microsoft.Data.SqlClient

Public Class Signup
    Dim loginForm As New Login()
    Dim connection As New SqlConnection("Data Source=THEG\SQLEXPRESS;Initial Catalog=PROJECT;Integrated Security=True;Persist Security Info=False;Multiple Active Result Sets=True;Trust Server Certificate=True;User Instance=False")
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnsignup.Click
        Dim CID As String = TextBoxCID.Text
        Dim username As String = TextBoxusername.Text
        Dim password As String = TextBoxpassword.Text
        Dim confirmpassword As String = TextBoxConfirmpassword.Text


        'to check two passwords and inserting details
        If username = "" Or password = "" Or confirmpassword = "" Then
            MessageBox.Show("Error: Please fill in all fields")
            Return
        End If
        If TextBoxConfirmpassword.Text = TextBoxpassword.Text Then
            Dim command As New SqlCommand("insert into tbllogindetails(username,Password,CID)values ('" & username & "','" & password & "','" & CID & "')", connection) 'sqlcommand lai duita parameter chaincha, one is query ani another is the variable for sql connection

            Try
                connection.Open()
                If command.ExecuteNonQuery() = 1 Then 'it doesnt return value but the integer value of how many rows effected
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
        Login.Show()
        Me.Hide()
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBoxpassword.UseSystemPasswordChar = True
            TextBoxConfirmpassword.UseSystemPasswordChar = True

        Else
            TextBoxpassword.UseSystemPasswordChar = False
            TextBoxConfirmpassword.UseSystemPasswordChar = False

        End If
    End Sub
End Class