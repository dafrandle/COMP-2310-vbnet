Imports System.Xml
Imports System.Xml.XPath
Imports System.Data
'frmCollection.vb
'Dustin Frandle - dafrandle@yahoo.com
'Project: SubFunction
'Written 2/20/2017

Public Class frmCollection
    Dim path As String = My.Application.Info.DirectoryPath 'gets local path the project
    Dim pathString As Integer = path.IndexOf("bin") - 1 ' used to remove bin\debug from path
    Dim xmlPath As String = "file://" & path.Substring(0, pathString) & "\myCollection.xml" 'constructs path to xml file

    Private Sub showXML_Click(sender As Object, e As EventArgs) Handles showXML.Click
        Dim doc As XmlDocument = New XmlDocument

        Dim platformName As String
        Dim platformDev As String
        Dim gameName As String
        Dim genre As String
        textBoxXML.Text = "" 'removes "XML GO HERE"
        doc.Load(xmlPath)
        For Each platformNode As XmlNode In doc.DocumentElement.SelectNodes("/Games/Platform") 'loops through the xml doc grabing data and printing it
            platformName = (platformNode.Attributes.ItemOf("PlatformName").InnerText)
            platformDev = (platformNode.Attributes.ItemOf("Dev").InnerText)
            textBoxXML.Text &= "-------------------------------------" & Environment.NewLine & "Platform: " & platformName & "(" & platformDev & ")" & Environment.NewLine & "-------------------------------------" & Environment.NewLine
            For Each gameNode As XmlNode In doc.DocumentElement.SelectNodes("/Games/Platform[@PlatformName='" + platformName + "']/Titles/Title")
                gameName = (gameNode.Attributes.ItemOf("GameName").InnerText)
                textBoxXML.Text &= "     Game: " & gameName & " - "
                For Each genreNode As XmlNode In doc.DocumentElement.SelectNodes("//Title[@GameName='" + gameName + "']/Genre")
                    genre = (genreNode.InnerText)
                    textBoxXML.Text &= genre & Environment.NewLine
                Next
            Next
        Next
    End Sub


    Private Function dashConcat(pName As String, pDev As String, gName As String, genre As String)
        Dim textToPrint As String = pName & "(" & pDev & ") - " & gName & " - " & genre
        Return textToPrint
    End Function

    Private Sub btnDashConcat_Click(sender As Object, e As EventArgs) Handles btnDashConcat.Click 'gets data for dashConcat then calls it
        Dim doc As XmlDocument = New XmlDocument
        doc.Load(xmlPath)
        Dim platformName As String = (doc.SelectSingleNode("/Games/Platform").Attributes.ItemOf("PlatformName").InnerText)
        Dim platformDev As String = (doc.SelectSingleNode("/Games/Platform").Attributes.ItemOf("Dev").InnerText)
        Dim gameName As String = (doc.SelectSingleNode("/Games/Platform[@PlatformName='" + platformName + "']/Titles/Title").Attributes.ItemOf("GameName").InnerText)
        Dim genre As String = doc.SelectSingleNode("//Title[@GameName='" + gameName + "']/Genre").InnerText
        concatData.Text = dashConcat(platformName, platformDev, gameName, genre)
    End Sub

    Private Sub byValRefBtn_Click(sender As Object, e As EventArgs) Handles byValRefBtn.Click
        Dim valNum As Short = 5
        Dim refNum As Short = 5
        byValBefore.Text = valNum
        byRefBefore.Text = refNum
        demoByRef(valNum, refNum)
        byValAfter.Text = valNum
        byRefAfter.Text = refNum
    End Sub

    Private Sub demoByRef(ByVal valPull As Short, ByRef refPull As Short)
        valPull -= 3
        byValOut.Text = valPull
        refPull -= 3
        byRefOut.Text = refPull
    End Sub

    Private Sub highScoreShow_Click(sender As Object, e As EventArgs) Handles highScoreShow.Click
        Dim highScoreForm As New highScore
        highScoreForm.Show()
    End Sub
End Class
