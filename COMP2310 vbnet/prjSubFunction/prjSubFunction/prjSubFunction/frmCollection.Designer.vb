<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCollection))
        Me.showXML = New System.Windows.Forms.Button()
        Me.textBoxXML = New System.Windows.Forms.TextBox()
        Me.btnDashConcat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.concatData = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.byRefAfter = New System.Windows.Forms.Label()
        Me.byValAfter = New System.Windows.Forms.Label()
        Me.byRefOut = New System.Windows.Forms.Label()
        Me.byValOut = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.byRefBefore = New System.Windows.Forms.Label()
        Me.byValBefore = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.byValRefBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.highScoreShow = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'showXML
        '
        Me.showXML.Location = New System.Drawing.Point(12, 12)
        Me.showXML.Name = "showXML"
        Me.showXML.Size = New System.Drawing.Size(75, 23)
        Me.showXML.TabIndex = 0
        Me.showXML.Text = "Display"
        Me.showXML.UseVisualStyleBackColor = True
        '
        'textBoxXML
        '
        Me.textBoxXML.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.textBoxXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textBoxXML.Location = New System.Drawing.Point(20, 41)
        Me.textBoxXML.Multiline = True
        Me.textBoxXML.Name = "textBoxXML"
        Me.textBoxXML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textBoxXML.Size = New System.Drawing.Size(473, 748)
        Me.textBoxXML.TabIndex = 1
        Me.textBoxXML.Text = "XML GO HERE"
        '
        'btnDashConcat
        '
        Me.btnDashConcat.Location = New System.Drawing.Point(515, 12)
        Me.btnDashConcat.Name = "btnDashConcat"
        Me.btnDashConcat.Size = New System.Drawing.Size(113, 23)
        Me.btnDashConcat.TabIndex = 2
        Me.btnDashConcat.Text = "DisplayConcat"
        Me.btnDashConcat.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(548, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data for first entry"
        '
        'concatData
        '
        Me.concatData.AutoSize = True
        Me.concatData.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.concatData.Location = New System.Drawing.Point(548, 79)
        Me.concatData.Name = "concatData"
        Me.concatData.Size = New System.Drawing.Size(21, 20)
        Me.concatData.TabIndex = 4
        Me.concatData.Text = "   "
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(499, 192)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(478, 535)
        Me.Panel1.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.byRefAfter, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.byValAfter, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.byRefOut, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.byValOut, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.byRefBefore, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.byValBefore, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.byValRefBtn, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(29, 26)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(419, 279)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'byRefAfter
        '
        Me.byRefAfter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byRefAfter.AutoSize = True
        Me.byRefAfter.Location = New System.Drawing.Point(281, 207)
        Me.byRefAfter.Name = "byRefAfter"
        Me.byRefAfter.Size = New System.Drawing.Size(135, 72)
        Me.byRefAfter.TabIndex = 15
        Me.byRefAfter.Text = "n/a"
        Me.byRefAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'byValAfter
        '
        Me.byValAfter.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byValAfter.AutoSize = True
        Me.byValAfter.Location = New System.Drawing.Point(142, 207)
        Me.byValAfter.Name = "byValAfter"
        Me.byValAfter.Size = New System.Drawing.Size(133, 72)
        Me.byValAfter.TabIndex = 14
        Me.byValAfter.Text = "n/a"
        Me.byValAfter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'byRefOut
        '
        Me.byRefOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byRefOut.AutoSize = True
        Me.byRefOut.Location = New System.Drawing.Point(281, 138)
        Me.byRefOut.Name = "byRefOut"
        Me.byRefOut.Size = New System.Drawing.Size(135, 69)
        Me.byRefOut.TabIndex = 13
        Me.byRefOut.Text = "n/a"
        Me.byRefOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'byValOut
        '
        Me.byValOut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byValOut.AutoSize = True
        Me.byValOut.Location = New System.Drawing.Point(142, 138)
        Me.byValOut.Name = "byValOut"
        Me.byValOut.Size = New System.Drawing.Size(133, 69)
        Me.byValOut.TabIndex = 12
        Me.byValOut.Text = "n/a"
        Me.byValOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 69)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Function output"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'byRefBefore
        '
        Me.byRefBefore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byRefBefore.AutoSize = True
        Me.byRefBefore.Location = New System.Drawing.Point(281, 69)
        Me.byRefBefore.Name = "byRefBefore"
        Me.byRefBefore.Size = New System.Drawing.Size(135, 69)
        Me.byRefBefore.TabIndex = 10
        Me.byRefBefore.Text = "n/a"
        Me.byRefBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'byValBefore
        '
        Me.byValBefore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byValBefore.AutoSize = True
        Me.byValBefore.Location = New System.Drawing.Point(142, 69)
        Me.byValBefore.Name = "byValBefore"
        Me.byValBefore.Size = New System.Drawing.Size(133, 69)
        Me.byValBefore.TabIndex = 9
        Me.byValBefore.Text = "n/a"
        Me.byValBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 69)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Original Vars Before"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 69)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ByRef"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 72)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "After"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 69)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ByVal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'byValRefBtn
        '
        Me.byValRefBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.byValRefBtn.Location = New System.Drawing.Point(3, 3)
        Me.byValRefBtn.Name = "byValRefBtn"
        Me.byValRefBtn.Size = New System.Drawing.Size(133, 63)
        Me.byValRefBtn.TabIndex = 16
        Me.byValRefBtn.Text = "Do It!"
        Me.byValRefBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(29, 330)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(419, 200)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'highScoreShow
        '
        Me.highScoreShow.Location = New System.Drawing.Point(499, 733)
        Me.highScoreShow.Name = "highScoreShow"
        Me.highScoreShow.Size = New System.Drawing.Size(478, 46)
        Me.highScoreShow.TabIndex = 6
        Me.highScoreShow.Text = "High Scores!!!!!!!!!!!!!!"
        Me.highScoreShow.UseVisualStyleBackColor = True
        '
        'frmCollection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 800)
        Me.Controls.Add(Me.highScoreShow)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.concatData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDashConcat)
        Me.Controls.Add(Me.textBoxXML)
        Me.Controls.Add(Me.showXML)
        Me.MaximumSize = New System.Drawing.Size(1019, 839)
        Me.MinimumSize = New System.Drawing.Size(1019, 839)
        Me.Name = "frmCollection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Project: SubFunction"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents showXML As Button
    Friend WithEvents textBoxXML As TextBox
    Friend WithEvents btnDashConcat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents concatData As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents byRefAfter As Label
    Friend WithEvents byValAfter As Label
    Friend WithEvents byRefOut As Label
    Friend WithEvents byValOut As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents byRefBefore As Label
    Friend WithEvents byValBefore As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents byValRefBtn As Button
    Friend WithEvents highScoreShow As Button
End Class
