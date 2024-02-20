Public Class Dashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim billingandsales As New billingandsales()
        billingandsales.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Product As New Product()
        Product.Show()
        Me.Hide()
    End Sub
End Class