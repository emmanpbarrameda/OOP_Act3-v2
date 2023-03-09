''by Emman P. Barrameda (@emmanpbarrameda)
''https://github.com/emmanpbarrameda/OOP_Act3-v2

Public Class Form1

    ''for brand values
    Public Brand1 As String = "iPhone"
    Public Brand2 As String = "Samsung"
    Public Brand3 As String = "Huawei"

    ''for price value
    Const ip1 = 45000, ip2 = 37000, ip3 = 28000
    Const s1 = 36000, s2 = 33000, s3 = 10500
    Const h1 = 39000, h2 = 19800, h3 = 13900

    ''important variables
    Dim model1Amount As Double
    Dim model2Amount As Double
    Dim model3Amount As Double
    Dim modelSubTotalAmount As Double
    Dim modelTotalAmount_Cash As Double
    Dim modelTotalAmount_Installment As Double
    Dim interestPercentage As Double

    ''hide and reset Customer Information
    Private Sub Reset_CustomerInformation()
        TXT_Name.ResetText()
        TXT_Name.Focus()
        TXT_Address.ResetText()
        CB_Brand.SelectedItem = Nothing

        TXT_Model1_Amount.Text = ""
        TXT_Model2_Amount.Text = ""
        TXT_Model3_Amount.Text = ""
        TXT_SubTotal.Text = "0.00"
    End Sub

    ''hide and reset Mode of Payment Group
    Private Sub Reset_ModeOfPaymentGroup()
        RBT_Cash.Checked = False
        RBT_Installment.Checked = False
        TXT_TotalAmount.Text = ""
    End Sub

    ''hide and reset Model Group
    Private Sub Reset_ModelGroup()
        CHK_Model1.Checked = False
        CHK_Model2.Checked = False
        CHK_Model3.Checked = False
    End Sub

    ''HIDE ModeOfPayment Automatically and RESET SubTotal WHEN the QUANTITY IS CHANGING
    Private Sub HideModeClearSubTotal_IfQuantityChange()
        TXT_SubTotal.Text = "0.00"
        GBO_ModeOfPayment.Visible = False
        Reset_ModeOfPaymentGroup()
    End Sub


    Private Sub CB_Model1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Model1.SelectedIndexChanged

        ''set the amount based on Model Product
        If CHK_Model1.Text = "iPhone 11" Then
            model1Amount = Val(CB_Model1.Text) * ip1

        ElseIf CHK_Model1.Text = "Samsung Galaxy Note 10" Then
            model1Amount = Val(CB_Model1.Text) * s1

        ElseIf CHK_Model1.Text = "Huawei Mate 30 Pro" Then
            model1Amount = Val(CB_Model1.Text) * h1
        End If

        ''hide ModeOfPayment Automatically
        'GBO_ModeOfPayment.Visible = False
        'Reset_ModeOfPaymentGroup()

        'set the amount on TextBox Label
        TXT_Model1_Amount.Text = Format(model1Amount, "#,###,##0.00")

    End Sub


    Private Sub CB_Model2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Model2.SelectedIndexChanged

        ''set the amount based on Model Product
        If CHK_Model2.Text = "iPhone 10" Then
            model2Amount = Val(CB_Model2.Text) * ip2

        ElseIf CHK_Model2.Text = "Samsung Galaxy S10" Then
            model2Amount = Val(CB_Model2.Text) * s2

        ElseIf CHK_Model2.Text = "Huawei Mate 20 Pro" Then
            model2Amount = Val(CB_Model2.Text) * h2
        End If

        'set the amount on TextBox Label
        TXT_Model2_Amount.Text = Format(model2Amount, "#,###,##0.00")

    End Sub

    Private Sub CB_Model3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Model3.SelectedIndexChanged

        ''set the amount based on Model Product
        If CHK_Model3.Text = "iPhone 8" Then
            model3Amount = Val(CB_Model3.Text) * ip3

        ElseIf CHK_Model3.Text = "Samsung Galaxy A21" Then
            model3Amount = Val(CB_Model3.Text) * s3

        ElseIf CHK_Model3.Text = "Huawei P30" Then
            model3Amount = Val(CB_Model3.Text) * h3
        End If

        ''set the amount on TextBox Label
        TXT_Model3_Amount.Text = Format(model3Amount, "#,###,##0.00")

    End Sub

    Private Sub BTN_SubTotal_Click(sender As Object, e As EventArgs) Handles BTN_SubTotal.Click

        ''compute the sub-total amount from models amount
        modelSubTotalAmount = model1Amount + model2Amount + model3Amount

        ''paste the formatted sub-total amount to TextBox
        TXT_SubTotal.Text = Format(modelSubTotalAmount, "#,###,##0.00")

        Reset_ModeOfPaymentGroup()

    End Sub

    Private Sub RBT_Cash_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_Cash.CheckedChanged

        If RBT_Cash.Checked = True Then
            ''compute the total amount from sub-total with 10% Discount
            modelTotalAmount_Cash = modelSubTotalAmount - 0.1 * modelSubTotalAmount

            ''paste the formatted total amount to Total TextBox
            TXT_TotalAmount.Text = Format(modelTotalAmount_Cash, "#,###,##0.00")
        Else
            TXT_TotalAmount.Text = ""
        End If

    End Sub

    Private Sub RBT_6months_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_6months.CheckedChanged

        ''compute the total amount from sub-total with 10% Interest
        interestPercentage = modelSubTotalAmount * 0.1
        modelTotalAmount_Installment = modelSubTotalAmount + interestPercentage

        ''paste the formatted total amount to Total TextBox
        TXT_TotalAmount.Text = Format(modelTotalAmount_Installment, "#,###,##0.00")

    End Sub

    Private Sub RBT_Installment_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_Installment.CheckedChanged

        ''radioButton Installment Click
        If RBT_Installment.Checked = True Then
            TXT_TotalAmount.ResetText()
            GBOX_InstallmentPlan.Visible = True
            GBOX_InstallmentPlan.Focus()
            TXT_TotalAmount.Text = ""
        Else
            GBOX_InstallmentPlan.Visible = False
            RBT_6months.Checked = False
            RBT_1year.Checked = False
            RBT_2years.Checked = False
        End If

    End Sub

    Private Sub RBT_1year_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_1year.CheckedChanged

        ''compute the total amount from sub-total with 15% Interest
        interestPercentage = modelSubTotalAmount * 0.15
        modelTotalAmount_Installment = modelSubTotalAmount + interestPercentage

        ''paste the formatted total amount to Total TextBox
        TXT_TotalAmount.Text = Format(modelTotalAmount_Installment, "#,###,##0.00")

    End Sub

    Private Sub RBT_2years_CheckedChanged(sender As Object, e As EventArgs) Handles RBT_2years.CheckedChanged

        ''compute the total amount from sub-total with 20% Interest
        interestPercentage = modelSubTotalAmount * 0.2
        modelTotalAmount_Installment = modelSubTotalAmount + interestPercentage

        ''paste the formatted total amount to Total TextBox
        TXT_TotalAmount.Text = Format(modelTotalAmount_Installment, "#,###,##0.00")

    End Sub


    Private Sub CBX_Model3_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_Model3.CheckedChanged

        ''enable and disable Model ComboBox
        If CHK_Model3.Checked = True Then
            CB_Model3.Enabled = True
            CB_Model3.DroppedDown = True 'opens combobox automatic
            TXT_Model3_Amount.Text = "0.00"
        Else
            CB_Model3.SelectedItem = Nothing
            CB_Model3.Enabled = False

            ''reset and hide ModeOfPaymentGroup() when click
            GBO_ModeOfPayment.Visible = False
            Reset_ModeOfPaymentGroup()

        End If

    End Sub

    Private Sub CBX_Model2_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_Model2.CheckedChanged

        ''enable and disable Model ComboBox
        If CHK_Model2.Checked = True Then
            CB_Model2.Enabled = True
            CB_Model2.DroppedDown = True ''opens combobox automatic
            TXT_Model2_Amount.Text = "0.00"
        Else
            CB_Model2.SelectedItem = Nothing
            CB_Model2.Enabled = False

            ''reset and hide ModeOfPaymentGroup() when click
            GBO_ModeOfPayment.Visible = False
            Reset_ModeOfPaymentGroup()

        End If

    End Sub

    Private Sub TXT_Model3_Amount_Click(sender As Object, e As EventArgs) Handles TXT_Model3_Amount.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''brand cbx
        CB_Brand.Items.Add(Brand1)
        CB_Brand.Items.Add(Brand2)
        CB_Brand.Items.Add(Brand3)

        ''models cbx quantity
        For i = 1 To 10
            CB_Model1.Items.Add(i)
            CB_Model2.Items.Add(i)
            CB_Model3.Items.Add(i)
        Next

    End Sub

    ''exit event
    Public Sub MyForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        If MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True ''cancel the form closing action if the user selects "No"
        End If
    End Sub


    Private Sub TXT_Name_TextChanged(sender As Object, e As EventArgs) Handles TXT_Name.TextChanged

        ''detect if the name txtfield is empty or not
        If String.IsNullOrEmpty(TXT_Name.Text) Then
            BTN_Reset.Enabled = False
        Else
            BTN_Reset.Enabled = True
        End If

    End Sub

    Private Sub BTN_Reset_Click(sender As Object, e As EventArgs) Handles BTN_Reset.Click

        ''reset customer information to reset everything
        Reset_CustomerInformation()

    End Sub

    Private Sub CB_Brand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Brand.SelectedIndexChanged

        ''check if the comboBox is Selected or Not
        If String.IsNullOrEmpty(CB_Brand.Text) Then
            CHK_Model1.Visible = False
            CHK_Model2.Visible = False
            CHK_Model3.Visible = False
        Else
            CHK_Model1.Visible = True
            CHK_Model2.Visible = True
            CHK_Model3.Visible = True
        End If

        ''change the models on checkbox
        Select Case (CB_Brand.Text)
            Case Brand1
                CHK_Model1.Text = "iPhone 11"
                CHK_Model2.Text = "iPhone 10"
                CHK_Model3.Text = "iPhone 8"

            Case Brand2
                CHK_Model1.Text = "Samsung Galaxy Note 10"
                CHK_Model2.Text = "Samsung Galaxy S10"
                CHK_Model3.Text = "Samsung Galaxy A21"

            Case Brand3
                CHK_Model1.Text = "Huawei Mate 30 Pro"
                CHK_Model2.Text = "Huawei Mate 20 Pro"
                CHK_Model3.Text = "Huawei P30"
        End Select

        ''if no selected, reset model group to RESET ALL.
        Reset_ModelGroup()

    End Sub

    Private Sub CBX_Model1_CheckedChanged(sender As Object, e As EventArgs) Handles CHK_Model1.CheckedChanged

        ''enable and disable Model ComboBox
        If CHK_Model1.Checked = True Then
            CB_Model1.Enabled = True
            CB_Model1.DroppedDown = True ''opens combobox automatic
            TXT_Model1_Amount.Text = "0.00"
        Else
            CB_Model1.SelectedItem = Nothing
            CB_Model1.Enabled = False

            ''reset and hide ModeOfPaymentGroup() when click
            GBO_ModeOfPayment.Visible = False
            Reset_ModeOfPaymentGroup()

        End If

    End Sub

    Private Sub TXT_Model1_Amount_TextChanged(sender As Object, e As EventArgs) Handles TXT_Model1_Amount.TextChanged

        ''disable and enable the Button from TXT_Model1_Amount
        If model1Amount = "0.00" And model2Amount = "0.00" And model3Amount = "0.00" Then
            BTN_SubTotal.PerformClick() ''auto click the Button to compute the TXT_SubTotal
            BTN_SubTotal.Enabled = False ''DISABLE the Button WHEN EMPTY
        Else
            BTN_SubTotal.Enabled = True ''ENABLED the Button
            'BTN_SubTotal.PerformClick()
        End If

    End Sub

    Private Sub TXT_Model2_Amount_TextChanged(sender As Object, e As EventArgs) Handles TXT_Model2_Amount.TextChanged

        ''disable and enable the Button from TXT_Model2_Amount
        If model1Amount = "0.00" And model2Amount = "0.00" And model3Amount = "0.00" Then
            BTN_SubTotal.PerformClick() ''auto click the Button to compute the TXT_SubTotal
            BTN_SubTotal.Enabled = False ''DISABLE the Button WHEN EMPTY
        Else
            BTN_SubTotal.Enabled = True ''ENABLED the Button
            ''BTN_SubTotal.PerformClick()
        End If

    End Sub

    Private Sub TXT_Model3_Amount_TextChanged(sender As Object, e As EventArgs) Handles TXT_Model3_Amount.TextChanged

        ''disable and enable the Button from TXT_Model3_Amount
        If model1Amount = "0.00" And model2Amount = "0.00" And model3Amount = "0.00" Then
            BTN_SubTotal.PerformClick() ''auto click the Button to compute the TXT_SubTotal
            BTN_SubTotal.Enabled = False ''DISABLE the Button WHEN EMPTY
        Else
            BTN_SubTotal.Enabled = True ''ENABLED the Button
            ''BTN_SubTotal.PerformClick()
        End If

    End Sub

    Private Sub TXT_SubTotal_TextChanged(sender As Object, e As EventArgs) Handles TXT_SubTotal.TextChanged

        ''disable and enable Mode of Payment Group
        If modelSubTotalAmount = "0.00" Then
            GBO_ModeOfPayment.Visible = False
        Else
            GBO_ModeOfPayment.Visible = True
            Reset_ModeOfPaymentGroup()
        End If

    End Sub

    Private Sub CB_Model1_TextChanged(sender As Object, e As EventArgs) Handles CB_Model1.TextChanged

        ''HIDE ModeOfPayment Automatically and RESET SubTotal WHEN the QUANTITY IS CHANGING
        HideModeClearSubTotal_IfQuantityChange()

    End Sub

    Private Sub CB_Model2_TextChanged(sender As Object, e As EventArgs) Handles CB_Model2.TextChanged

        ''HIDE ModeOfPayment Automatically and RESET SubTotal WHEN the QUANTITY IS CHANGING
        HideModeClearSubTotal_IfQuantityChange()

    End Sub

    Private Sub CB_Model3_TextChanged(sender As Object, e As EventArgs) Handles CB_Model3.TextChanged

        ''HIDE ModeOfPayment Automatically and RESET SubTotal WHEN the QUANTITY IS CHANGING
        HideModeClearSubTotal_IfQuantityChange()

    End Sub
End Class




''by Emman P. Barrameda (@emmanpbarrameda)
''https://github.com/emmanpbarrameda/OOP_Act3-v2
