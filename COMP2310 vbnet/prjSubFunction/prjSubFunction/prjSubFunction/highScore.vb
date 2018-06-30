Public Class highScore
    Private Sub highScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theHighScore.Text = highScoreCode.highScore
    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs) Handles playBtn.Click
        Dim theScore As Integer = 10000 * Rnd()
        score.Text = theScore
        Dim newHighScore As Boolean = highScoreCode.checkHighScore(theScore)
        If newHighScore Then
            theHighScore.Text = highScoreCode.highScore
            newHighScoreFlasher.Visible = True
        Else
            newHighScoreFlasher.Visible = False
        End If

    End Sub
End Class