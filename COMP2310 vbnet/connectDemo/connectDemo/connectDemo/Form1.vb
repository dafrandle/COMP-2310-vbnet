Imports System
Imports System.Data
Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As OleDbConnection
        Dim strSQL As String
        Dim da As New OleDbDataAdapter()
        Dim ds As New DataSet()

        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=userDatabase.mdb")
        strSQL = "SELECT * FROM userList"
        da = New OleDbDataAdapter(strSQL, con)
        da.TableMappings.Add("Table", "UserList")
        da.Fill(ds)
        con.Close()
        dgResult.DataSource = ds
        dgResult.DataMember = "UserList"
    End Sub
End Class
