Public Class Form1
    Private Structure Customer
        Public FirstName As String
        Public LastName As String
        Public Email As String
    End Structure

    Private objCustomer As Customer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ListBtn.Click
        objCustomer.FirstName = "Jim"
        objCustomer.LastName = "Jones"
        objCustomer.Email = "Jones@Gmail.com"
        displayUser(objCustomer)
    End Sub

    Private Sub displayUser(ByVal user As Customer)
        txtFName.Text = user.FirstName
        txtLName.Text = user.LastName
        txtMail.Text = user.Email
    End Sub
End Class
