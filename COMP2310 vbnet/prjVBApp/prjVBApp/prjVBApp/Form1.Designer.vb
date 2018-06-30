<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.addOrderBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.orderView = New System.Windows.Forms.Label()
        Me.orderTotal = New System.Windows.Forms.Label()
        Me.orderTax = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.orderCost = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sizeBox = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radioButtonSmall = New System.Windows.Forms.RadioButton()
        Me.radioButtonLarge = New System.Windows.Forms.RadioButton()
        Me.radioButtonMedium = New System.Windows.Forms.RadioButton()
        Me.drinkBox = New System.Windows.Forms.Panel()
        Me.radioButtonDrinkNone = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.radioButtonDrinkLarge = New System.Windows.Forms.RadioButton()
        Me.radioButtonDrinkSmall = New System.Windows.Forms.RadioButton()
        Me.radioButtonDrinkMed = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.mealComboBox = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.autoTip = New System.Windows.Forms.Button()
        Me.tipClear = New System.Windows.Forms.Button()
        Me.tipBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.picPopupBar = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.commentColorBtn = New System.Windows.Forms.Button()
        Me.commentFontBtn = New System.Windows.Forms.Button()
        Me.grndTotalLable = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.taxLable = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.totalLable = New System.Windows.Forms.Label()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.OrderClearBtn = New System.Windows.Forms.Button()
        Me.picPopUp = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picPopUpBtn = New System.Windows.Forms.Button()
        Me.CheckoutSendBtn = New System.Windows.Forms.Button()
        Me.commentClearBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.commentBox = New System.Windows.Forms.RichTextBox()
        Me.checkoutBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.sizeBox.SuspendLayout()
        Me.drinkBox.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.picPopupBar.SuspendLayout()
        Me.picPopUp.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(920, 631)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(912, 605)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Menu"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MaximumSize = New System.Drawing.Size(912, 605)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(912, 605)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(912, 605)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(912, 605)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Order"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 37)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Order Form"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.addOrderBtn)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(6, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 566)
        Me.Panel1.TabIndex = 0
        '
        'addOrderBtn
        '
        Me.addOrderBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addOrderBtn.Location = New System.Drawing.Point(3, 377)
        Me.addOrderBtn.Name = "addOrderBtn"
        Me.addOrderBtn.Size = New System.Drawing.Size(892, 184)
        Me.addOrderBtn.TabIndex = 3
        Me.addOrderBtn.Text = "Add To Order"
        Me.addOrderBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.orderTotal)
        Me.Panel3.Controls.Add(Me.orderTax)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.orderCost)
        Me.Panel3.Location = New System.Drawing.Point(348, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(547, 368)
        Me.Panel3.TabIndex = 78
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.orderView)
        Me.Panel5.Location = New System.Drawing.Point(-1, 214)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(547, 153)
        Me.Panel5.TabIndex = 24
        '
        'orderView
        '
        Me.orderView.AutoSize = True
        Me.orderView.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderView.Location = New System.Drawing.Point(8, 57)
        Me.orderView.Name = "orderView"
        Me.orderView.Size = New System.Drawing.Size(138, 31)
        Me.orderView.TabIndex = 78
        Me.orderView.Text = "Meal Here"
        '
        'orderTotal
        '
        Me.orderTotal.AutoSize = True
        Me.orderTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderTotal.Location = New System.Drawing.Point(147, 138)
        Me.orderTotal.Name = "orderTotal"
        Me.orderTotal.Size = New System.Drawing.Size(145, 55)
        Me.orderTotal.TabIndex = 23
        Me.orderTotal.Text = "$0.00"
        '
        'orderTax
        '
        Me.orderTax.AutoSize = True
        Me.orderTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderTax.Location = New System.Drawing.Point(147, 83)
        Me.orderTax.Name = "orderTax"
        Me.orderTax.Size = New System.Drawing.Size(145, 55)
        Me.orderTax.TabIndex = 22
        Me.orderTax.Text = "$0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(143, 55)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(34, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 55)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Tax:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(136, 55)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Cost:"
        '
        'orderCost
        '
        Me.orderCost.AutoSize = True
        Me.orderCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderCost.Location = New System.Drawing.Point(147, 28)
        Me.orderCost.Name = "orderCost"
        Me.orderCost.Size = New System.Drawing.Size(145, 55)
        Me.orderCost.TabIndex = 17
        Me.orderCost.Text = "$0.00"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.sizeBox)
        Me.Panel2.Controls.Add(Me.drinkBox)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.mealComboBox)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(348, 368)
        Me.Panel2.TabIndex = 0
        '
        'sizeBox
        '
        Me.sizeBox.Controls.Add(Me.Label9)
        Me.sizeBox.Controls.Add(Me.radioButtonSmall)
        Me.sizeBox.Controls.Add(Me.radioButtonLarge)
        Me.sizeBox.Controls.Add(Me.radioButtonMedium)
        Me.sizeBox.Location = New System.Drawing.Point(49, 156)
        Me.sizeBox.Name = "sizeBox"
        Me.sizeBox.Size = New System.Drawing.Size(82, 132)
        Me.sizeBox.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 31)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Size"
        '
        'radioButtonSmall
        '
        Me.radioButtonSmall.AutoSize = True
        Me.radioButtonSmall.Location = New System.Drawing.Point(9, 35)
        Me.radioButtonSmall.Name = "radioButtonSmall"
        Me.radioButtonSmall.Size = New System.Drawing.Size(50, 17)
        Me.radioButtonSmall.TabIndex = 0
        Me.radioButtonSmall.Text = "Small"
        Me.radioButtonSmall.UseVisualStyleBackColor = True
        '
        'radioButtonLarge
        '
        Me.radioButtonLarge.AutoSize = True
        Me.radioButtonLarge.Location = New System.Drawing.Point(9, 83)
        Me.radioButtonLarge.Name = "radioButtonLarge"
        Me.radioButtonLarge.Size = New System.Drawing.Size(52, 17)
        Me.radioButtonLarge.TabIndex = 2
        Me.radioButtonLarge.Text = "Large"
        Me.radioButtonLarge.UseVisualStyleBackColor = True
        '
        'radioButtonMedium
        '
        Me.radioButtonMedium.AutoSize = True
        Me.radioButtonMedium.Location = New System.Drawing.Point(9, 59)
        Me.radioButtonMedium.Name = "radioButtonMedium"
        Me.radioButtonMedium.Size = New System.Drawing.Size(62, 17)
        Me.radioButtonMedium.TabIndex = 1
        Me.radioButtonMedium.Text = "Medium"
        Me.radioButtonMedium.UseVisualStyleBackColor = True
        '
        'drinkBox
        '
        Me.drinkBox.Controls.Add(Me.radioButtonDrinkNone)
        Me.drinkBox.Controls.Add(Me.Label10)
        Me.drinkBox.Controls.Add(Me.radioButtonDrinkLarge)
        Me.drinkBox.Controls.Add(Me.radioButtonDrinkSmall)
        Me.drinkBox.Controls.Add(Me.radioButtonDrinkMed)
        Me.drinkBox.Location = New System.Drawing.Point(181, 156)
        Me.drinkBox.Name = "drinkBox"
        Me.drinkBox.Size = New System.Drawing.Size(82, 132)
        Me.drinkBox.TabIndex = 2
        '
        'radioButtonDrinkNone
        '
        Me.radioButtonDrinkNone.AutoSize = True
        Me.radioButtonDrinkNone.Location = New System.Drawing.Point(9, 34)
        Me.radioButtonDrinkNone.Name = "radioButtonDrinkNone"
        Me.radioButtonDrinkNone.Size = New System.Drawing.Size(51, 17)
        Me.radioButtonDrinkNone.TabIndex = 1
        Me.radioButtonDrinkNone.Text = "None"
        Me.radioButtonDrinkNone.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 31)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Drink"
        '
        'radioButtonDrinkLarge
        '
        Me.radioButtonDrinkLarge.AutoSize = True
        Me.radioButtonDrinkLarge.Location = New System.Drawing.Point(9, 105)
        Me.radioButtonDrinkLarge.Name = "radioButtonDrinkLarge"
        Me.radioButtonDrinkLarge.Size = New System.Drawing.Size(52, 17)
        Me.radioButtonDrinkLarge.TabIndex = 4
        Me.radioButtonDrinkLarge.Text = "Large"
        Me.radioButtonDrinkLarge.UseVisualStyleBackColor = True
        '
        'radioButtonDrinkSmall
        '
        Me.radioButtonDrinkSmall.AutoSize = True
        Me.radioButtonDrinkSmall.Location = New System.Drawing.Point(9, 57)
        Me.radioButtonDrinkSmall.Name = "radioButtonDrinkSmall"
        Me.radioButtonDrinkSmall.Size = New System.Drawing.Size(50, 17)
        Me.radioButtonDrinkSmall.TabIndex = 2
        Me.radioButtonDrinkSmall.Text = "Small"
        Me.radioButtonDrinkSmall.UseVisualStyleBackColor = True
        '
        'radioButtonDrinkMed
        '
        Me.radioButtonDrinkMed.AutoSize = True
        Me.radioButtonDrinkMed.Location = New System.Drawing.Point(9, 81)
        Me.radioButtonDrinkMed.Name = "radioButtonDrinkMed"
        Me.radioButtonDrinkMed.Size = New System.Drawing.Size(62, 17)
        Me.radioButtonDrinkMed.TabIndex = 3
        Me.radioButtonDrinkMed.Text = "Medium"
        Me.radioButtonDrinkMed.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 31)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Meal"
        '
        'mealComboBox
        '
        Me.mealComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mealComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mealComboBox.FormattingEnabled = True
        Me.mealComboBox.Items.AddRange(New Object() {"Buster", "Double D-Lux", "Full Rack"})
        Me.mealComboBox.Location = New System.Drawing.Point(49, 71)
        Me.mealComboBox.Name = "mealComboBox"
        Me.mealComboBox.Size = New System.Drawing.Size(214, 33)
        Me.mealComboBox.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.autoTip)
        Me.TabPage3.Controls.Add(Me.tipClear)
        Me.TabPage3.Controls.Add(Me.tipBox)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.picPopupBar)
        Me.TabPage3.Controls.Add(Me.commentColorBtn)
        Me.TabPage3.Controls.Add(Me.commentFontBtn)
        Me.TabPage3.Controls.Add(Me.grndTotalLable)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.taxLable)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.totalLable)
        Me.TabPage3.Controls.Add(Me.OrderBtn)
        Me.TabPage3.Controls.Add(Me.OrderClearBtn)
        Me.TabPage3.Controls.Add(Me.picPopUp)
        Me.TabPage3.Controls.Add(Me.CheckoutSendBtn)
        Me.TabPage3.Controls.Add(Me.commentClearBtn)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.commentBox)
        Me.TabPage3.Controls.Add(Me.checkoutBox)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(912, 605)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Checkout"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'autoTip
        '
        Me.autoTip.Location = New System.Drawing.Point(291, 477)
        Me.autoTip.Name = "autoTip"
        Me.autoTip.Size = New System.Drawing.Size(106, 50)
        Me.autoTip.TabIndex = 1
        Me.autoTip.Text = "Tip 15%"
        Me.autoTip.UseVisualStyleBackColor = True
        '
        'tipClear
        '
        Me.tipClear.Location = New System.Drawing.Point(291, 533)
        Me.tipClear.Name = "tipClear"
        Me.tipClear.Size = New System.Drawing.Size(106, 49)
        Me.tipClear.TabIndex = 2
        Me.tipClear.Text = "Clear Tip"
        Me.tipClear.UseVisualStyleBackColor = True
        '
        'tipBox
        '
        Me.tipBox.BackColor = System.Drawing.SystemColors.Menu
        Me.tipBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tipBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipBox.Location = New System.Drawing.Point(160, 532)
        Me.tipBox.Name = "tipBox"
        Me.tipBox.Size = New System.Drawing.Size(121, 35)
        Me.tipBox.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(94, 535)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 29)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Tip: $"
        '
        'picPopupBar
        '
        Me.picPopupBar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.picPopupBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPopupBar.Controls.Add(Me.Label3)
        Me.picPopupBar.Location = New System.Drawing.Point(515, 137)
        Me.picPopupBar.Name = "picPopupBar"
        Me.picPopupBar.Size = New System.Drawing.Size(360, 26)
        Me.picPopupBar.TabIndex = 2
        Me.picPopupBar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Info Popup"
        '
        'commentColorBtn
        '
        Me.commentColorBtn.Location = New System.Drawing.Point(831, 495)
        Me.commentColorBtn.Name = "commentColorBtn"
        Me.commentColorBtn.Size = New System.Drawing.Size(75, 26)
        Me.commentColorBtn.TabIndex = 8
        Me.commentColorBtn.Text = "Color"
        Me.commentColorBtn.UseVisualStyleBackColor = True
        '
        'commentFontBtn
        '
        Me.commentFontBtn.Location = New System.Drawing.Point(831, 463)
        Me.commentFontBtn.Name = "commentFontBtn"
        Me.commentFontBtn.Size = New System.Drawing.Size(75, 26)
        Me.commentFontBtn.TabIndex = 7
        Me.commentFontBtn.Text = "Font"
        Me.commentFontBtn.UseVisualStyleBackColor = True
        '
        'grndTotalLable
        '
        Me.grndTotalLable.AutoSize = True
        Me.grndTotalLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grndTotalLable.Location = New System.Drawing.Point(143, 573)
        Me.grndTotalLable.Name = "grndTotalLable"
        Me.grndTotalLable.Size = New System.Drawing.Size(71, 29)
        Me.grndTotalLable.TabIndex = 16
        Me.grndTotalLable.Text = "$0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 573)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Grand Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(90, 505)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 29)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tax:"
        '
        'taxLable
        '
        Me.taxLable.AutoSize = True
        Me.taxLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxLable.Location = New System.Drawing.Point(143, 505)
        Me.taxLable.Name = "taxLable"
        Me.taxLable.Size = New System.Drawing.Size(71, 29)
        Me.taxLable.TabIndex = 13
        Me.taxLable.Text = "$0.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 476)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total:"
        '
        'totalLable
        '
        Me.totalLable.AutoSize = True
        Me.totalLable.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLable.Location = New System.Drawing.Point(143, 476)
        Me.totalLable.Name = "totalLable"
        Me.totalLable.Size = New System.Drawing.Size(71, 29)
        Me.totalLable.TabIndex = 11
        Me.totalLable.Text = "$0.00"
        '
        'OrderBtn
        '
        Me.OrderBtn.Location = New System.Drawing.Point(403, 476)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Size = New System.Drawing.Size(106, 50)
        Me.OrderBtn.TabIndex = 3
        Me.OrderBtn.Text = "Confirm Order"
        Me.OrderBtn.UseVisualStyleBackColor = True
        '
        'OrderClearBtn
        '
        Me.OrderClearBtn.Location = New System.Drawing.Point(403, 532)
        Me.OrderClearBtn.Name = "OrderClearBtn"
        Me.OrderClearBtn.Size = New System.Drawing.Size(106, 50)
        Me.OrderClearBtn.TabIndex = 4
        Me.OrderClearBtn.Text = "Clear Order"
        Me.OrderClearBtn.UseVisualStyleBackColor = True
        '
        'picPopUp
        '
        Me.picPopUp.BackColor = System.Drawing.Color.Gainsboro
        Me.picPopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPopUp.Controls.Add(Me.Label2)
        Me.picPopUp.Controls.Add(Me.picPopUpBtn)
        Me.picPopUp.Location = New System.Drawing.Point(515, 137)
        Me.picPopUp.Name = "picPopUp"
        Me.picPopUp.Size = New System.Drawing.Size(391, 95)
        Me.picPopUp.TabIndex = 8
        Me.picPopUp.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(372, 55)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INFORMATION!"
        '
        'picPopUpBtn
        '
        Me.picPopUpBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.picPopUpBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.picPopUpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.picPopUpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.picPopUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.picPopUpBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.picPopUpBtn.Location = New System.Drawing.Point(358, -1)
        Me.picPopUpBtn.Name = "picPopUpBtn"
        Me.picPopUpBtn.Size = New System.Drawing.Size(32, 26)
        Me.picPopUpBtn.TabIndex = 10
        Me.picPopUpBtn.TabStop = False
        Me.picPopUpBtn.Text = "X"
        Me.picPopUpBtn.UseVisualStyleBackColor = False
        '
        'CheckoutSendBtn
        '
        Me.CheckoutSendBtn.Location = New System.Drawing.Point(831, 527)
        Me.CheckoutSendBtn.Name = "CheckoutSendBtn"
        Me.CheckoutSendBtn.Size = New System.Drawing.Size(75, 55)
        Me.CheckoutSendBtn.TabIndex = 9
        Me.CheckoutSendBtn.Text = "Send"
        Me.CheckoutSendBtn.UseVisualStyleBackColor = True
        '
        'commentClearBtn
        '
        Me.commentClearBtn.Location = New System.Drawing.Point(831, 431)
        Me.commentClearBtn.Name = "commentClearBtn"
        Me.commentClearBtn.Size = New System.Drawing.Size(75, 26)
        Me.commentClearBtn.TabIndex = 6
        Me.commentClearBtn.Text = "Clear"
        Me.commentClearBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(561, 402)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Tell us about your experience:"
        '
        'commentBox
        '
        Me.commentBox.BackColor = System.Drawing.SystemColors.Menu
        Me.commentBox.BulletIndent = 1
        Me.commentBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.commentBox.EnableAutoDragDrop = True
        Me.commentBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentBox.Location = New System.Drawing.Point(515, 431)
        Me.commentBox.Name = "commentBox"
        Me.commentBox.Size = New System.Drawing.Size(311, 151)
        Me.commentBox.TabIndex = 5
        Me.commentBox.Text = ""
        '
        'checkoutBox
        '
        Me.checkoutBox.BackColor = System.Drawing.SystemColors.Info
        Me.checkoutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.checkoutBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.checkoutBox.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoutBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.checkoutBox.Location = New System.Drawing.Point(3, 3)
        Me.checkoutBox.Multiline = True
        Me.checkoutBox.Name = "checkoutBox"
        Me.checkoutBox.ReadOnly = True
        Me.checkoutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.checkoutBox.Size = New System.Drawing.Size(506, 467)
        Me.checkoutBox.TabIndex = 3
        Me.checkoutBox.TabStop = False
        Me.checkoutBox.Text = "No Items In Cart"
        Me.checkoutBox.WordWrap = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(515, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(391, 396)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AllowFullOpen = False
        Me.ColorDialog1.SolidColorOnly = True
        '
        'FontDialog1
        '
        Me.FontDialog1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FontDialog1.MaxSize = 30
        Me.FontDialog1.MinSize = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 634)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(940, 673)
        Me.MinimumSize = New System.Drawing.Size(940, 673)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pizza Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.sizeBox.ResumeLayout(False)
        Me.sizeBox.PerformLayout()
        Me.drinkBox.ResumeLayout(False)
        Me.drinkBox.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.picPopupBar.ResumeLayout(False)
        Me.picPopupBar.PerformLayout()
        Me.picPopUp.ResumeLayout(False)
        Me.picPopUp.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents checkoutBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents commentBox As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents mealComboBox As ComboBox
    Friend WithEvents CheckoutSendBtn As Button
    Friend WithEvents commentClearBtn As Button
    Friend WithEvents picPopUp As Panel
    Friend WithEvents picPopUpBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents taxLable As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents totalLable As Label
    Friend WithEvents OrderBtn As Button
    Friend WithEvents OrderClearBtn As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents grndTotalLable As Label
    Friend WithEvents commentColorBtn As Button
    Friend WithEvents commentFontBtn As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents picPopupBar As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents radioButtonDrinkNone As RadioButton
    Friend WithEvents radioButtonDrinkLarge As RadioButton
    Friend WithEvents radioButtonDrinkMed As RadioButton
    Friend WithEvents radioButtonDrinkSmall As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents radioButtonLarge As RadioButton
    Friend WithEvents radioButtonMedium As RadioButton
    Friend WithEvents radioButtonSmall As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents drinkBox As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents orderView As Label
    Friend WithEvents orderTotal As Label
    Friend WithEvents orderTax As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents orderCost As Label
    Friend WithEvents addOrderBtn As Button
    Friend WithEvents sizeBox As Panel
    Friend WithEvents tipBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tipClear As Button
    Friend WithEvents autoTip As Button
End Class
