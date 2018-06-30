Public Class Form1
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Result.Text = Input.Text & " You Clicked"
    End Sub

    Private Sub Submit_MouseHover(sender As Object, e As EventArgs) Handles Submit.MouseHover
        Result.Text = Input.Text
    End Sub

End Class
