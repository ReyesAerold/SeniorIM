Public Class MainDashboard
    Private Sub MainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable

    End Sub

    Private Sub btnRegisteredUser_Click(sender As Object, e As EventArgs) Handles btnRegisteredUser.Click
        RegisterHome.Show()
        Me.Hide()

    End Sub
End Class