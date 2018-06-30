Imports MySql.Data.MySqlClient

Partial Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Response.Redirect("myDataView.aspx")
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim valid As Boolean = False
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Dim result As Integer = 0
        Try
            con = New MySqlConnection("server = localhost; user id=root; password=mysql; database=dynamicSite")
            cmd = New MySqlCommand("SELECT COUNT(*) cnt FROM users WHERE username = '" & tbUsername.Text & "' AND password COLLATE latin1_general_cs = '" & tbPassword.Text & "';", con)
            con.Open()
            result = CInt(cmd.ExecuteScalar())
            If result = 1 Then
                valid = True
                con.Close()

            Else
                valid = False
                con.Close()
            End If
        Catch ex As Exception
            Dim exMsg As String = ex.Message
            exMsg = exMsg.Replace("'", ControlChars.Quote)
            Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('" & exMsg & "');", True)
        End Try

        If valid Then
            Response.Redirect("myDataView.aspx")
        Else
            Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('wrong password/username');", True)
        End If


    End Sub

End Class