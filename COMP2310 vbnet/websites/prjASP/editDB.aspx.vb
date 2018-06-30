Imports System.Data
Imports MySql.Data.MySqlClient

Partial Class editDB
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim strSQL = "SELECT games.gameID, games.name, games.developer, games.publisher, games.cost, platform.name AS 'platform' FROM games INNER JOIN platform ON games.platformID = platform.platformID ORDER BY games.gameID ASC;"
            populateGridView(strSQL)
            strSQL = "SELECT platformID, name FROM platform;"
            populateDropDown(strSQL)
            Dim sqlString As String = "DELETE FROM games WHERE gameID = " & ddSelect.Text
            hfSQLStatament.Value = sqlString
            hfPlatformId.Value = ddSelect.Text
        End If

    End Sub

    Sub populateGridView(ByVal sql As String)
        Dim con As MySqlConnection
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()
        Try
            con = New MySqlConnection("server = localhost; user id=root; password=mysql; database=dynamicSite")
            da = New MySqlDataAdapter(sql, con)
            da.Fill(dt)
            con.Close()
            gv.DataSource = dt
            gv.DataBind()
        Catch ex As Exception
            Dim exMsg As String = ex.Message
            exMsg = exMsg.Replace("'", ControlChars.Quote)
            Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('" & exMsg & "');", True)
        End Try
    End Sub

    Sub populateDropDown(ByVal sql As String)
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Try
            con = New MySqlConnection("server = localhost; user id=root; password=mysql; database=dynamicSite")
            cmd = New MySqlCommand(sql, con)
            con.Open()
            Dim ddDR As MySqlDataReader = cmd.ExecuteReader

            ddSelect.DataSource = ddDR
            ddSelect.DataValueField = "platformID"
            ddSelect.DataTextField = "name"
            ddSelect.DataBind()

            con.Close()
        Catch ex As Exception
            Dim exMsg As String = ex.Message
            exMsg = exMsg.Replace("'", ControlChars.Quote)
            Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('" & exMsg & "');", True)
        End Try
    End Sub

    Protected Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Try
            con = New MySqlConnection("server = localhost; user id=root; password=mysql; database=dynamicSite")
            cmd = New MySqlCommand("INSERT INTO games VALUES (" & gameID() & ", '" & tbName.Text & "', '" & tbDev.Text & "', '" & tbPub.Text & "', " & tbCost.Text & ", " & ddSelect.SelectedItem.Value & ");", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Response.Redirect("editDB.aspx")
        Catch ex As Exception
        Dim exMsg As String = ex.Message
        exMsg = exMsg.Replace("'", ControlChars.Quote)
        Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('" & exMsg & "');", True)
        End Try
    End Sub

    Private Sub upadteScripts()
        Dim sqlString As String = "INSERT INTO games VALUES (" & gameID() & ", '" & tbName.Text & "', '" & tbDev.Text & "', '" & tbPub.Text & "', " & tbCost.Text & ", " & ddSelect.SelectedItem.Value & ");"
        hfSQLStatament.Value = sqlString
        hfPlatformId.Value = ddSelect.SelectedItem.Value
    End Sub

    Private Function gameID() As String
        If tbID.Text = "" Then
            Return "NULL"
        Else
            Return tbID.Text
        End If
    End Function

    Private Sub ddSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddSelect.SelectedIndexChanged
        upadteScripts()
    End Sub

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged
        upadteScripts()
    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged
        upadteScripts()
    End Sub

    Private Sub tbDev_TextChanged(sender As Object, e As EventArgs) Handles tbDev.TextChanged
        upadteScripts()
    End Sub

    Private Sub tbPub_TextChanged(sender As Object, e As EventArgs) Handles tbPub.TextChanged
        upadteScripts()
    End Sub

    Private Sub tbCost_TextChanged(sender As Object, e As EventArgs) Handles tbCost.TextChanged
        upadteScripts()
    End Sub
End Class

