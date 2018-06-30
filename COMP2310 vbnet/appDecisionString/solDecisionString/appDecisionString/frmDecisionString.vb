'frmDecisionString.vb
'Dustin Frandle - dafrandle@yahoo.com
'Project: Decision String
'Written 2/08/2017


Imports System.Text.RegularExpressions

Public Class frmDecisionString
    Public Const TAX As Double = 0.07775
    'discounts
    Public Const PDPRICE As Double = 1
    Public Const PDOVER As Double = 1
    Public Const NPDPRICE As Double = 0.8
    Public Const NPDOVER As Double = 0.5
    Public Const BDPRICE As Double = 3
    Public Const BDOVER As Double = 0.9
    'extr data
    Public Const PEXTRDT As Short = 1
    Public Const NPEXTRDT As Short = 3
    Public Const BEXTRDT As Short = 10
    'prices
    Public Const DIALUP As Double = 5
    Public Const LIFELN As Double = 20
    Public Const EXPRS As Double = 50
    Public Const HIGHSPD As Double = 95
    Public Const GIG As Double = 165
    'overages
    Public Const DIALUPOVER As Double = 0
    Public Const LIFELNOVER As Double = 10
    Public Const EXPRSOVER As Double = 5
    Public Const HIGHSPDOVER As Double = 20
    Public Const GIGOVER As Double = 50
    'limits
    Public Const DIALUPLIMIT As Short = -1
    Public Const LIFELNLIMIT As Short = 5
    Public Const EXPRSLIMIT As Short = 30
    Public Const HIGHSPLIMIT As Short = 100
    Public Const GIGLIMIT As Short = 300
    'radio button data holders
    Dim planSelect As Short = 0
    Dim lineSelect As Short = 0
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------User Info
    Private Sub userInfoSubmitButton_Click(sender As Object, e As EventArgs) Handles userInfoSubmitButton.Click
        Dim valid As Boolean = validateUserInfo()
        If valid Then
            formatPhoneNumber()
            genAccNum()
        Else
            Exit Sub
        End If

    End Sub

    Private Function validateUserInfo() '--------------------------- EXAMPLES OF IF THEN IF ELSE THEN ELSE - THIS WHOLE FUNCTION
        Dim valid As Boolean = False
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Name.StartsWith("nameBox") Then  'Check Names ----------------------------------------------------------------------------------
                    If ctrl.Text = "" Then
                        Dim nameBoxVar As String
                        If ctrl.Name.Contains("First") Then
                            nameBoxVar = "First name section"
                        Else
                            nameBoxVar = "Last name section"
                        End If
                        MessageBox.Show("Warning" & Environment.NewLine & nameBoxVar & " is blank!", "Blank Form Sections")
                        valid = False
                        Return valid
                    Else
                        valid = True
                    End If
                Else   'Check Phone Number ---------------------------------------------------------------------------------------------------------------
                    If ctrl.Text = "" Then
                        MessageBox.Show("Warning" & Environment.NewLine & "Phone number section is blank!", "Blank Form Sections")
                        valid = False
                        Return valid
                    Else
                        valid = True
                    End If
                    Dim usesHyphen As Boolean = ctrl.Text.Contains("-")
                    Dim usesDot As Boolean = ctrl.Text.Contains(".")
                    'prevent using mixed phone number formats
                    If usesDot And usesHyphen Then
                        MessageBox.Show("Invalid Phone Number" & Environment.NewLine & "Please use ONLY hyphens or ONLY dots, not both.", "Invalid Entry")
                        valid = False
                        Return valid
                    Else
                        valid = True
                    End If
                    Dim phoneNumber As New Regex("[(]?\d{3}[)-.]\d{3}[-.]\d{4}") 'regex validation
                    If phoneNumber.IsMatch(ctrl.Text) Then
                        valid = True
                    Else
                        MessageBox.Show("Error" & Environment.NewLine & Chr(34) & ctrl.Text & Chr(34) & " is an invalid phone number" & Environment.NewLine & "Try (###)###-####" & Environment.NewLine & "Note: number must be 10 digits long", "Invalid Entry")
                        valid = False
                        Return valid
                    End If
                End If
            End If
        Next
        Return valid
    End Function

    Private Sub formatPhoneNumber()
        Dim usesParenthesis As Boolean = phoneNumberBox.Text.Contains(")")
        Dim usesDot As Boolean = phoneNumberBox.Text.Contains(".")
        Dim phoneNumberIn As String = phoneNumberBox.Text
        Dim phoneNumberOut As String = vbNull
        Dim firstBreak As Short = 0
        Dim lastBreak As Short = 0
        Dim splitChar As Char = If(usesDot, ".", "-")
        '-------------------------------Format Phone Number
        firstBreak = If(usesParenthesis, phoneNumberIn.IndexOf(")"), phoneNumberIn.IndexOf(splitChar)) 'ternaries
        lastBreak = phoneNumberIn.IndexOf(splitChar, firstBreak + 1)
        phoneNumberOut = phoneNumberBox.Text.Substring(firstBreak - 3, 3) & "-" & phoneNumberBox.Text.Substring(firstBreak + 1, 3) & "-" & phoneNumberBox.Text.Substring(lastBreak + 1, 4)
        'print
        phoneNumFormat.Text = phoneNumberOut
        phoneNumFormat.Visible = True
    End Sub

    Private Sub genAccNum()
        'check name length
        Dim firstLong = If(nameBoxFirst.Text.Length > 3, True, False) 'ternaries
        Dim lastLong = If(nameBoxLast.Text.Length > 3, True, False)
        'set up vars for parts of number
        Dim partOne As String = If(firstLong, nameBoxFirst.Text.Substring(0, 3), nameBoxFirst.Text)
        Dim partTwo As String = phoneNumberBox.Text.Substring(phoneNumberBox.Text.Length - 4)
        Dim partThree As String = If(lastLong, nameBoxLast.Text.Substring(0, 3), nameBoxLast.Text)
        Dim accNum As String = partOne.ToUpper & "-" & partTwo & "-" & partThree.ToUpper
        'print
        lableIDNum.Text = accNum
        lableIDNum.Visible = True
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------End User Info
    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ISP Plan Input
    Private Sub plan2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles plan5.Click, plan4.Click, plan3.Click, plan2.Click, plan1.Click, plan5.KeyDown, plan4.KeyDown, plan3.KeyDown, plan2.KeyDown, plan1.KeyDown
        Dim RadioButton As RadioButton = CType(sender, RadioButton)
        If RadioButton.Name.Substring(RadioButton.Name.Length - 1) > 0 Then
            planSelect = RadioButton.Name.Substring(RadioButton.Name.Length - 1)
            calcPrice()
        Else
            MessageBox.Show("A plan has not been selected.", "No plan selected")
            planSelect = 0
            Exit Sub
        End If
    End Sub

    Private Sub line1_Click(sender As Object, e As EventArgs) Handles line3.Click, line2.Click, line1.Click, line3.KeyDown, line2.KeyDown, line1.KeyDown
        Dim RadioButton As RadioButton = CType(sender, RadioButton)
        If RadioButton.Name.Substring(RadioButton.Name.Length - 1) > 0 Then
            lineSelect = RadioButton.Name.Substring(RadioButton.Name.Length - 1)
            calcPrice()
        Else
            MessageBox.Show("A line has not be selected.", "No line selected")
            lineSelect = 0
            Exit Sub
        End If
    End Sub

    Private Sub dataUseBox_TextChanged(sender As Object, e As EventArgs) Handles dataUseBox.TextChanged
        calcPrice()
    End Sub

    Private Sub calcPrice()
        If planSelect = 0 Or lineSelect = 0 Then
            Exit Sub
        End If
        Dim dataUsed As Double
        Try 'covert data used number to double
            If dataUseBox.Text = "." Then
                dataUsed = 0
                Exit Try
            End If
            dataUsed = Double.Parse(dataUseBox.Text)
        Catch
            dataUsed = 0
            dataUseBox.Text = ""
        End Try
        If dataUsed > 744 Then
            dataUseBox.Text = "744" 'prevents you from entering more than your arbitrary number
            dataUsed = 744
            MessageBox.Show("Maximum value for data useage is 744", "Number too large")
        End If
        If IsNumeric(dataUseBox.Text) Then 'does IsNumeric and prints "True" to the output debug if true
            Dim can As Boolean = True
            Debug.WriteLine("dataUseBox IsNumeric True")
        End If
        'plan
        Dim price As Double
        Dim limit As Short
        Dim overage As Double
        'type
        Dim data As Short
        Dim planDiscount As Double
        Dim overDiscount As Double
        'plan set
        Select Case planSelect
            Case 1
                price = DIALUP
                limit = DIALUPLIMIT
                overage = DIALUPOVER
            Case 2
                price = LIFELN
                limit = LIFELNLIMIT
                overage = LIFELNOVER
            Case 3
                price = EXPRS
                limit = EXPRSLIMIT
                overage = EXPRSOVER
            Case 4
                price = HIGHSPD
                limit = HIGHSPLIMIT
                overage = HIGHSPDOVER
            Case 5
                price = GIG
                limit = GIGLIMIT
                overage = GIGOVER
            Case Else
                MessageBox.Show("A plan has not been selected.", "No plan selected")
                Exit Sub
        End Select
        'line type set
        Select Case lineSelect
            Case 1
                data = PEXTRDT
                planDiscount = PDPRICE
                overDiscount = PDOVER
                priceIndLable.Text = "Total Price"
            Case 2
                data = BEXTRDT
                planDiscount = BDPRICE
                overDiscount = BDOVER
                priceIndLable.Text = "Total Price"
            Case 3
                data = NPEXTRDT
                planDiscount = NPDPRICE
                overDiscount = NPDOVER
                priceIndLable.Text = "Non-Profit Discounted Total Price"
            Case Else
                MessageBox.Show("A line has not be selected.", "No line selected")
                Exit Sub
        End Select

        'formual: ((plan price * discount) + ((overage price * discount) * gigs over)) + tax
        'gigs over: gigs used - (limit * exstra data)
        'tax: total * tax + total

        Dim dataOver As Double = If((dataUsed - (limit * data)) < 0, 0, (dataUsed - (limit * data)))
        Dim total As Double = (price * planDiscount) + ((overage * overDiscount) * dataOver)
        Dim grandTotal = (total * TAX) + total
        Dim discount As Double = (price * planDiscount) - price
        receipt.Text = "Price: $" & price.ToString("0.00") & Environment.NewLine & If(planDiscount >= 1, "Line Fee: $", "Line Discount: -$") & If(discount >= 0, discount.ToString("0.00"), discount.ToString("0.00").Substring(1)) & Environment.NewLine & "Data Fee: $" & ((overage * overDiscount) * dataOver).ToString("0.00") & Environment.NewLine & "----" & Environment.NewLine & "Total: $" & total.ToString("0.00") & Environment.NewLine & "Tax: $" & (TAX * total).ToString("0.00") & Environment.NewLine & "Grand Total: $" & grandTotal.ToString("0.00")
        priceLable.Text = "$" & grandTotal.ToString("0.00")
        priceLable.Visible = True
    End Sub

    Private Sub dataUseBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dataUseBox.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = 8)
    End Sub
End Class

'** TESTS DONE LESS TAX **
'------------------------
'Test 1
'Dial-up Business 10gb used:  
'Expected: $15
'Got: $15

'Test 2
'Lifeline Personal 20gb used:  
'Expected: $170
'Got: $170

'Test 3
'Gig non-profit 400gb used:  
'Expected: $165 -- screwed up MY math forgot to add discount -- revaulting gave me $132
'Got: $132