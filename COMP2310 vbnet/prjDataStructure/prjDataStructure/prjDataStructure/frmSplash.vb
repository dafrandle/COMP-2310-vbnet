Imports System.IO

Public Class frmSplash
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        listApp.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        listApp.open()
        listApp.Show()
    End Sub

    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        path += "\List App lists"
        If (Not System.IO.Directory.Exists(path)) Then
            System.IO.Directory.CreateDirectory(path)
        End If
        Dim pathString As Integer = Directory.GetCurrentDirectory.IndexOf("bin") - 1
        picBox.ImageLocation = ("file://" & Directory.GetCurrentDirectory.Substring(0, pathString) & "\img\earth.png")
    End Sub
End Class