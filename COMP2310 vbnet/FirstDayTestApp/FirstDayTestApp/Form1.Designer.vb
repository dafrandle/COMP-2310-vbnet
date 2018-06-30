<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Input = New System.Windows.Forms.TextBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Location = New System.Drawing.Point(49, 73)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(168, 22)
        Me.Input.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(82, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(101, 17)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Taters'n'Gravy"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(85, 118)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(98, 37)
        Me.Submit.TabIndex = 2
        Me.Submit.Text = "&Yum"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Result
        '
        Me.Result.AutoSize = True
        Me.Result.Location = New System.Drawing.Point(107, 191)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(52, 17)
        Me.Result.TabIndex = 3
        Me.Result.Text = "No text"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Input)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input As TextBox
    Friend WithEvents Title As Label
    Friend WithEvents Submit As Button
    Friend WithEvents Result As Label
End Class
