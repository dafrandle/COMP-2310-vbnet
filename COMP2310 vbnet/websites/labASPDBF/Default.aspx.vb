
Imports System.Data
Imports MySql.Data.MySqlClient

Partial Class _Default
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim strSQL = "SELECT * FROM games"
            populateGridView(strSQL)
            strSQL = "SELECT DISTINCT name FROM games"
            populateList(strSQL)
        End If

    End Sub

    Sub populateGridView(ByVal sql As Object)
        Dim con As MySqlConnection
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()
        con = New MySqlConnection("server = localhost; user id=root; password=mysql; database=dynamicSite") 'TODO: add try catch
        da = New MySqlDataAdapter(sql, con)
        da.Fill(dt)
        con.Close()
        gv.DataSource = dt
        gv.DataBind()
    End Sub

    Sub populateList(ByVal sql As Object)
        'This will hold the code to populate the dropdown list
        'once it is added to the form.
    End Sub

End Class