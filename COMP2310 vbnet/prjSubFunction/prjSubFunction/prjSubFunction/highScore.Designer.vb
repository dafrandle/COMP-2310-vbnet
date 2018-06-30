<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class highScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.TextBox()
        Me.theHighScore = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.newHighScoreFlasher = New System.Windows.Forms.Label()
        Me.playBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(353, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Score"
        '
        'score
        '
        Me.score.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.score.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score.Location = New System.Drawing.Point(109, 150)
        Me.score.Name = "score"
        Me.score.ReadOnly = True
        Me.score.Size = New System.Drawing.Size(340, 55)
        Me.score.TabIndex = 1
        Me.score.Text = "0"
        Me.score.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'theHighScore
        '
        Me.theHighScore.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.theHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.theHighScore.Location = New System.Drawing.Point(109, 445)
        Me.theHighScore.Name = "theHighScore"
        Me.theHighScore.ReadOnly = True
        Me.theHighScore.Size = New System.Drawing.Size(340, 55)
        Me.theHighScore.TabIndex = 2
        Me.theHighScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 73)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "High Score"
        '
        'newHighScoreFlasher
        '
        Me.newHighScoreFlasher.AutoSize = True
        Me.newHighScoreFlasher.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newHighScoreFlasher.ForeColor = System.Drawing.Color.Red
        Me.newHighScoreFlasher.Location = New System.Drawing.Point(134, 289)
        Me.newHighScoreFlasher.Name = "newHighScoreFlasher"
        Me.newHighScoreFlasher.Size = New System.Drawing.Size(298, 42)
        Me.newHighScoreFlasher.TabIndex = 4
        Me.newHighScoreFlasher.Text = "New High Score!"
        Me.newHighScoreFlasher.Visible = False
        '
        'playBtn
        '
        Me.playBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playBtn.Location = New System.Drawing.Point(109, 232)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(340, 54)
        Me.playBtn.TabIndex = 5
        Me.playBtn.Text = "Play"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'highScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 583)
        Me.Controls.Add(Me.playBtn)
        Me.Controls.Add(Me.newHighScoreFlasher)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.theHighScore)
        Me.Controls.Add(Me.score)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(599, 622)
        Me.MinimumSize = New System.Drawing.Size(599, 622)
        Me.Name = "highScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "highScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents score As TextBox
    Friend WithEvents theHighScore As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents newHighScoreFlasher As Label
    Friend WithEvents playBtn As Button
End Class
