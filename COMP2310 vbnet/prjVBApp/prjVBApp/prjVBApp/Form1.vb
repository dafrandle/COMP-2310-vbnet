Imports System.Linq
Public Class Form1
    'Form1.vb
    'Dustin Frandle - dafrandle@yahoo.com
    'Project: VB Application
    'Written 1/25/2017

    Public Const tax As Double = 0.07775
    Dim mealSize As String = "Small"
    Dim mealSizeRadio As Integer = 0
    Dim drinkSize As String = "none"
    Dim drinkSizeRadio As Integer = 0
    '--------------------------------------- ON LOAD EVENT ----------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim path As String = My.Application.Info.DirectoryPath
        Dim pathString As Integer = path.IndexOf("bin") - 1
        WebBrowser1.Navigate("file://" + path.Substring(0, pathString) + "\webpage.html")
        PictureBox1.ImageLocation = path.Substring(0, pathString) + "\MenuResource\graphics\icon.png"
        mealComboBox.SelectedIndex = 0
        radioButtonSmall.Checked = True
        radioButtonDrinkNone.Checked = True
        orderUpdate()
    End Sub

    Private Sub RichTextBox1_MouseHover(sender As Object, e As EventArgs) Handles commentBox.MouseHover
        ToolTip1.SetToolTip(commentBox, "Tell us about your experience")
    End Sub

    Private Sub tipBox_Mouse_hover(sender As Object, e As EventArgs) Handles tipBox.MouseHover
        ToolTip1.SetToolTip(tipBox, "Enter a dollar amount you would like to give as a tip. Example: 1.99")
    End Sub

    Private Sub CheckoutClearBtn_Click(sender As Object, e As EventArgs) Handles commentClearBtn.Click
        commentBox.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        picPopUp.Visible = True
        picPopupBar.Visible = True
    End Sub

    Private Sub picPopUpBtn_Click(sender As Object, e As EventArgs) Handles picPopUpBtn.Click
        picPopUp.Visible = False
        picPopupBar.Visible = False
    End Sub

    Private Sub commentColorBtn_Click(sender As Object, e As EventArgs) Handles commentColorBtn.Click
        If (ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            commentBox.ForeColor = ColorDialog1.Color
        End If

    End Sub

    Private Sub commentFontBtn_Click(sender As Object, e As EventArgs) Handles commentFontBtn.Click
        If (FontDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            commentBox.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub orderUpdate()
        Dim meal As String = mealComboBox.Items(mealComboBox.SelectedIndex)
        If (drinkSizeRadio = 0) Then
            orderView.Text = mealSize & " " & meal
        Else
            orderView.Text = mealSize & " " & meal & " with a " & drinkSize & " Drink"
        End If
        Select Case mealComboBox.SelectedIndex
            Case 0
                calcOrderPrice((2 * mealSizeCost()) + drinkSizeCost())
            Case 1
                calcOrderPrice((5 * mealSizeCost()) + drinkSizeCost())
            Case 2
                calcOrderPrice((10 * mealSizeCost()) + drinkSizeCost())
            Case Else
                calcOrderPrice(0)
                MessageBox.Show("Error Seting Order Price")
        End Select


    End Sub

    Private Sub calcOrderPrice(cost As Double)
        orderCost.Text = "$" & cost.ToString("0.00")
        orderTax.Text = "$" & (cost * tax).ToString("0.00")
        orderTotal.Text = "$" & (cost + (cost * tax)).ToString("0.00")
    End Sub

    Private Function drinkSizeCost()
        Dim cost As Double
        Select Case drinkSizeRadio
            Case 0
                cost = 0
            Case 1
                cost = 0.25
            Case 2
                cost = 0.3
            Case 3
                cost = 0.5
            Case Else
                cost = 0
                MessageBox.Show("Error Seting Drink Price")
        End Select
        Return cost
    End Function

    Private Function mealSizeCost()
        Dim cost As Double
        Select Case mealSizeRadio
            Case 0
                cost = 1
            Case 1
                cost = 1.1
            Case 2
                cost = 1.15
            Case Else
                cost = 0
                MessageBox.Show("Error Seting Meal Price")
        End Select
        Return cost
    End Function

    Private Sub mealComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles mealComboBox.SelectedIndexChanged
        orderUpdate()
    End Sub

    '-------------------------------------------------- meal size -------------------------------------------------

    Private Sub radioButtonSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonSmall.CheckedChanged
        mealSize = "Small"
        mealSizeRadio = 0
        orderUpdate()
    End Sub

    Private Sub radioButtonMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonMedium.CheckedChanged
        mealSize = "Medium"
        mealSizeRadio = 1
        orderUpdate()
    End Sub

    Private Sub radioButtonLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonLarge.CheckedChanged
        mealSize = "Large"
        mealSizeRadio = 2
        orderUpdate()
    End Sub

    '--------------------------------------------------- drink size ----------------------------------------------

    Private Sub radioButtonDrinkNone_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonDrinkNone.CheckedChanged
        drinkSize = "none"
        drinkSizeRadio = 0
        orderUpdate()
    End Sub

    Private Sub radioButtonDrinkSmall_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonDrinkSmall.CheckedChanged
        drinkSize = "Small"
        drinkSizeRadio = 1
        orderUpdate()
    End Sub

    Private Sub radioButtonDrinkMed_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonDrinkMed.CheckedChanged
        drinkSize = "Medium"
        drinkSizeRadio = 2
        orderUpdate()
    End Sub

    Private Sub radioButtonDrinkLarge_CheckedChanged(sender As Object, e As EventArgs) Handles radioButtonDrinkLarge.CheckedChanged
        drinkSize = "Large"
        drinkSizeRadio = 3
        orderUpdate()
    End Sub
    '--------------------------------------------------------------------------------------------------------------

    Private Sub addOrderBtn_Click(sender As Object, e As EventArgs) Handles addOrderBtn.Click
        If (checkoutBox.Text = "No Items In Cart") Then
            checkoutBox.Text = orderView.Text & " - " & orderCost.Text
            totalLable.Text = orderCost.Text
            taxLable.Text = orderTax.Text
            grndTotalCalc()
        Else
            checkoutBox.Text = checkoutBox.Text & Environment.NewLine & orderView.Text & " - " & orderCost.Text
            totalLable.Text = "$" & (Double.Parse((totalLable.Text).Substring(1)) + Double.Parse((orderCost.Text).Substring(1))).ToString("0.00")
            taxLable.Text = "$" & (Double.Parse((totalLable.Text).Substring(1)) * tax).ToString("0.00")
            grndTotalCalc()
        End If

    End Sub

    Private Sub OrderClearBtn_Click(sender As Object, e As EventArgs) Handles OrderClearBtn.Click
        checkoutBox.Text = "No Items In Cart"
        totalLable.Text = "$0.00"
        taxLable.Text = "$0.00"
        grndTotalLable.Text = "$0.00"
        tipBox.Text = ""
    End Sub

    Private Sub tipBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tipBox.KeyPress
        Dim allowedChars As String = "0123456789."
        If allowedChars.IndexOf(e.KeyChar) = -1 Then
            ' Invalid Character
            e.Handled = True
        End If
    End Sub

    Private Sub tipBox_TextChanged(sender As Object, e As EventArgs) Handles tipBox.TextChanged
        grndTotalCalc()
    End Sub

    Private Sub grndTotalCalc()
        Try
            grndTotalLable.Text = "$" & (Double.Parse((totalLable.Text).Substring(1)) + Double.Parse((taxLable.Text).Substring(1)) + Double.Parse(tipBox.Text)).ToString("0.00")
        Catch
            grndTotalLable.Text = "$" & (Double.Parse((totalLable.Text).Substring(1)) + Double.Parse((taxLable.Text).Substring(1))).ToString("0.00")
        End Try
    End Sub

    Private Sub tipClear_Click(sender As Object, e As EventArgs) Handles tipClear.Click
        tipBox.Text = ""
    End Sub

    Private Sub autoTip_Click(sender As Object, e As EventArgs) Handles autoTip.Click
        tipBox.Text = (Double.Parse((totalLable.Text).Substring(1)) * 0.15).ToString("0.00")
    End Sub
End Class
