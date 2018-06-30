Imports System.IO

Public Class listApp
    Dim list As New ArrayList

    '-------------------------------------------------------------- exit file option
    Private Sub msExit_Click(sender As Object, e As EventArgs) Handles msExit.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frmSplash.Close()
        End If
    End Sub

    Private Sub listApp_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim result As Integer = MessageBox.Show("Are you sure you want to quit?", "Quit?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            frmSplash.Close()
        Else
            e.Cancel = True
        End If
    End Sub

    '------------------------------------------------------------------ new list file option
    Private Sub msNew_Click(sender As Object, e As EventArgs) Handles msNew.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to make a new list?", "New List?", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            txtDesc.Text = ""
            txtBoxList.Text = ""
            txtQuant.Text = ""
            txtUnit.Text = ""
            list.Clear()
        End If
    End Sub

    '------------------------------------------------------------------ Add to list
    Private Sub btnAddList_Click(sender As Object, e As EventArgs) Handles btnAddList.Click
        Dim recored As String
        recored = txtQuant.Text & " " & txtUnit.Text & " " & txtDesc.Text
        If recored = "  " Then
            MessageBox.Show("No data to add to the list.", "No Data")
        Else
            list.Add(recored)
            txtBoxList.Text += recored & Environment.NewLine
            txtQuant.Text = ""
            txtUnit.Text = ""
            txtDesc.Text = ""
            txtQuant.Focus()
        End If

    End Sub

    '------------------------------------------------------------ Save File
    Private Sub msSave_Click(sender As Object, e As EventArgs) Handles msSave.Click
        Dim saveData As String = ""
        If list.Count > 0 Then
            For Each elem As String In list
                saveData += elem & Environment.NewLine
            Next
            dilgSave.ShowDialog()
            Try
                File.WriteAllText(dilgSave.FileName, saveData)
            Catch ex As Exception
                MessageBox.Show("The file has failed to save." & Environment.NewLine & ex.Message, "Save Failure!")
            End Try
        Else
            MessageBox.Show("No data to save.", "No Data")
        End If
    End Sub

    '--------------------------------------------------------------------- Open File
    Private Sub msOpen_Click(sender As Object, e As EventArgs) Handles msOpen.Click
        open()
    End Sub

    Public Sub open()
        Dim result As DialogResult = dilgOpen.ShowDialog()
        If result = DialogResult.OK Then
            txtDesc.Text = ""
            txtBoxList.Text = ""
            txtQuant.Text = ""
            txtUnit.Text = ""
            list.Clear()
            Dim filePath As String = dilgOpen.FileName
            Try
                Dim lineCount As Integer = File.ReadAllLines(filePath).Length
                Dim arrayListData As New StreamReader(filePath)
                For c = 0 To lineCount
                    Dim readString As String = arrayListData.ReadLine()
                    If readString = "" Then
                    Else
                        list.Add(readString)
                    End If
                Next
                arrayListData.Close()
            Catch ex As Exception
                MessageBox.Show("The file has failed to open." & Environment.NewLine & ex.Message, "Open Failure!")
            End Try
            For Each elem As String In list
                txtBoxList.Text += elem & Environment.NewLine
            Next
        Else

        End If
    End Sub

    '-------------------------------------------------- prevents bad input
    Private Sub txtQuant_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtQuant.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtDesc.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txtUnit_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtUnit.KeyPress
        e.Handled = Not (Char.IsLetter(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub
End Class
