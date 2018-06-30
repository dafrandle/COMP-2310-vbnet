Imports System.Data
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient

Partial Class myDataView
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim strSQL = "SELECT * FROM games ORDER BY games.gameID ASC;"
            populateGridView(strSQL)
            strSQL = "SELECT gameID FROM games;"
            populateDropDown(strSQL)
            Dim sqlString As String = "DELETE FROM games WHERE gameID = " & ddSelect.Text
            hfSQLStatament.Value = sqlString
            hfGameId.Value = ddSelect.Text
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
            ddSelect.DataValueField = "gameID"
            ddSelect.DataTextField = "gameID"
            ddSelect.DataBind()

            con.Close()
        Catch ex As Exception
            Dim exMsg As String = ex.Message
            exMsg = exMsg.Replace("'", ControlChars.Quote)
            Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('" & exMsg & "');", True)
        End Try
    End Sub



    Public Sub btnDrop_Click(sender As Object, e As EventArgs) Handles btnDrop.Click
        Dim con As MySqlConnection
        Dim cmd As MySqlCommand
        Try
            con = New MySqlConnection("server = localhost; user id=root; password=mysql; database=dynamicSite")
            cmd = New MySqlCommand("DELETE FROM games WHERE gameID = " & ddSelect.Text & ";", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Response.Redirect("myDataView.aspx")
        Catch ex As Exception
            Dim exMsg As String = ex.Message
            exMsg = exMsg.Replace("'", ControlChars.Quote)
            Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('" & exMsg & "');", True)
        End Try
    End Sub

    Private Sub ddSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddSelect.SelectedIndexChanged
        Dim sqlString As String = "DELETE FROM games WHERE gameID = " & ddSelect.Text & ";"
        hfSQLStatament.Value = sqlString
        hfGameId.Value = ddSelect.SelectedItem.Value
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'sql connection
        Dim con As MySqlConnection
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()
        'excel
        Dim excelApp As Excel.Application
        Dim excelBook As Excel._Workbook
        Dim excelSheet As Excel._Worksheet
        Dim wkStRange As Excel.Range = Nothing

        excelApp = CreateObject("Excel.Application")
        excelApp.Visible = True
        excelBook = excelApp.Workbooks.Add
        excelSheet = excelBook.ActiveSheet

        Try
            'connection
            con = New MySqlConnection("server = localhost; user id=root; password=mysql; database=dynamicSite")
            da = New MySqlDataAdapter("SELECT * FROM games ORDER BY games.gameID ASC;", con)
            da.Fill(dt)
            Dim y = 0

            'table headers 
            While y < (Integer.Parse(dt.Columns.Count))
                excelSheet.Cells(1, y + 1).Value = dt.Columns.Item(y).ToString
                y += 1
            End While

            'table data
            Dim x = 1
            For Each row As DataRow In dt.Rows
                y = 0
                Dim loopX = 0
                While loopX < (Integer.Parse(dt.Columns.Count))
                    excelSheet.Cells(x + 1, y + 1).Value = row(y).ToString
                    y += 1
                    loopX += 1
                End While
                x += 1
            Next

        Catch ex As Exception
            Dim exMsg As String = ex.Message
            exMsg = exMsg.Replace("'", ControlChars.Quote)
            Page.ClientScript.RegisterStartupScript([GetType](), "doAlert", "doAlert('" & exMsg & "');", True)
        End Try



    End Sub

End Class

