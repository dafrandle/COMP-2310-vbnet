<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listApp))
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuant = New System.Windows.Forms.TextBox()
        Me.tbMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.msOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.msSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.msExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddList = New System.Windows.Forms.Button()
        Me.txtBoxList = New System.Windows.Forms.TextBox()
        Me.dilgSave = New System.Windows.Forms.SaveFileDialog()
        Me.dilgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.tbMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(469, 34)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(332, 29)
        Me.txtDesc.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Description :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Unit:"
        '
        'txtUnit
        '
        Me.txtUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit.Location = New System.Drawing.Point(216, 34)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(127, 29)
        Me.txtUnit.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Quantity:"
        '
        'txtQuant
        '
        Me.txtQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuant.Location = New System.Drawing.Point(101, 34)
        Me.txtQuant.Name = "txtQuant"
        Me.txtQuant.Size = New System.Drawing.Size(56, 29)
        Me.txtQuant.TabIndex = 0
        '
        'tbMenuStrip
        '
        Me.tbMenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tbMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.tbMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.tbMenuStrip.Name = "tbMenuStrip"
        Me.tbMenuStrip.Size = New System.Drawing.Size(960, 24)
        Me.tbMenuStrip.TabIndex = 6
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msNew, Me.msOpen, Me.toolStripSeparator, Me.msSave, Me.toolStripSeparator1, Me.msExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'msNew
        '
        Me.msNew.Image = CType(resources.GetObject("msNew.Image"), System.Drawing.Image)
        Me.msNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.msNew.Name = "msNew"
        Me.msNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.msNew.Size = New System.Drawing.Size(152, 22)
        Me.msNew.Text = "&New"
        '
        'msOpen
        '
        Me.msOpen.Image = CType(resources.GetObject("msOpen.Image"), System.Drawing.Image)
        Me.msOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.msOpen.Name = "msOpen"
        Me.msOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.msOpen.Size = New System.Drawing.Size(152, 22)
        Me.msOpen.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'msSave
        '
        Me.msSave.Image = CType(resources.GetObject("msSave.Image"), System.Drawing.Image)
        Me.msSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.msSave.Name = "msSave"
        Me.msSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.msSave.Size = New System.Drawing.Size(152, 22)
        Me.msSave.Text = "&Save"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'msExit
        '
        Me.msExit.Name = "msExit"
        Me.msExit.Size = New System.Drawing.Size(152, 22)
        Me.msExit.Text = "E&xit"
        '
        'btnAddList
        '
        Me.btnAddList.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddList.Location = New System.Drawing.Point(807, 34)
        Me.btnAddList.Name = "btnAddList"
        Me.btnAddList.Size = New System.Drawing.Size(141, 29)
        Me.btnAddList.TabIndex = 3
        Me.btnAddList.Text = "Add To list"
        Me.btnAddList.UseVisualStyleBackColor = True
        '
        'txtBoxList
        '
        Me.txtBoxList.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtBoxList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxList.Location = New System.Drawing.Point(12, 70)
        Me.txtBoxList.Multiline = True
        Me.txtBoxList.Name = "txtBoxList"
        Me.txtBoxList.ReadOnly = True
        Me.txtBoxList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBoxList.Size = New System.Drawing.Size(936, 564)
        Me.txtBoxList.TabIndex = 8
        Me.txtBoxList.TabStop = False
        '
        'dilgSave
        '
        Me.dilgSave.DefaultExt = "txt"
        Me.dilgSave.FileName = "list1.txt"
        Me.dilgSave.Filter = "Text Files | *.txt"
        Me.dilgSave.InitialDirectory = "%userprofile%\Documents\List App lists"
        '
        'dilgOpen
        '
        Me.dilgOpen.DefaultExt = "txt"
        Me.dilgOpen.Filter = "Text Files | *.txt"
        Me.dilgOpen.InitialDirectory = "%userprofile%\Documents\List App lists"
        '
        'listApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 646)
        Me.Controls.Add(Me.txtBoxList)
        Me.Controls.Add(Me.btnAddList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtQuant)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.tbMenuStrip)
        Me.MainMenuStrip = Me.tbMenuStrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(976, 685)
        Me.MinimumSize = New System.Drawing.Size(976, 685)
        Me.Name = "listApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List App"
        Me.tbMenuStrip.ResumeLayout(False)
        Me.tbMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUnit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuant As TextBox
    Friend WithEvents tbMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msOpen As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents msSave As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents msExit As ToolStripMenuItem
    Friend WithEvents btnAddList As Button
    Friend WithEvents txtBoxList As TextBox
    Friend WithEvents msNew As ToolStripMenuItem
    Friend WithEvents dilgSave As SaveFileDialog
    Friend WithEvents dilgOpen As OpenFileDialog
End Class
