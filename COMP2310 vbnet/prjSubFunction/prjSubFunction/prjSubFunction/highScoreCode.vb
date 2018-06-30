Module highScoreCode
    Public highScore As Integer = 0

    Function checkHighScore(score As Integer)
        If score > highScore Then
            highScore = score
            Return True
        Else
            Return False
        End If
    End Function
End Module
