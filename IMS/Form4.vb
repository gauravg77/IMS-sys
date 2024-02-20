Public Class Dashboard
    ' Variable to track dark mode state
    Private darkModeEnabled As Boolean = True ' Set default mode to dark mode

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default mode to dark mode
        Nightmode.Checked = True
        Nightmode_CheckedChanged(Nothing, EventArgs.Empty)
    End Sub

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

    Private Sub Nightmode_CheckedChanged(sender As Object, e As EventArgs) Handles Nightmode.CheckedChanged
        ' Toggle dark mode state
        darkModeEnabled = Nightmode.Checked

        ' Update form appearance
        If darkModeEnabled Then
            ' Set dark mode
            Me.BackColor = Color.FromArgb(31, 31, 31)

            ' Update button colors for dark mode
            Button1.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            Button2.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            Button3.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray
            btntologin.BackColor = Color.FromArgb(64, 64, 64) ' Dark gray


            ' Set text colors for dark mode
            Button1.ForeColor = Color.White
            Button2.ForeColor = Color.White
            Button3.ForeColor = Color.White
            btntologin.ForeColor = Color.White

            For Each ctrl As Control In GetAllControlsRecursive(Me)
                If TypeOf ctrl Is Label Then
                    ctrl.ForeColor = Color.White
                End If
            Next

        Else
            ' Set light mode
            Me.BackColor = Color.FromArgb(223, 240, 255) ' Light blue

            ' Update button colors for light mode
            Button1.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            Button2.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            Button3.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue
            btntologin.BackColor = Color.FromArgb(0, 70, 140) ' Dark blue


            ' Set text colors for light mode
            Button1.ForeColor = Color.White
            Button2.ForeColor = Color.White
            Button3.ForeColor = Color.White
            btntologin.ForeColor = Color.White


            ' Update labels
            For Each ctrl As Control In GetAllControlsRecursive(Me)
                If TypeOf ctrl Is Label Then
                    ctrl.ForeColor = Color.FromArgb(0, 50, 100) ' Darker blue
                End If
            Next
        End If
    End Sub

    ' Helper function to get all controls recursively
    Private Function GetAllControlsRecursive(container As Control) As IEnumerable(Of Control)
        Dim controls As New List(Of Control)

        For Each ctrl As Control In container.Controls
            controls.Add(ctrl)
            controls.AddRange(GetAllControlsRecursive(ctrl))
        Next

        Return controls
    End Function

    Private Sub btntologin_Click(sender As Object, e As EventArgs) Handles btntologin.Click
        Dim login As New Login()
        login.Show()
        Me.Hide()
    End Sub
End Class
