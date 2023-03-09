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
        Me.GBOX_CustomerInformation = New System.Windows.Forms.GroupBox()
        Me.CB_Brand = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_Address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBOX_Model = New System.Windows.Forms.GroupBox()
        Me.BTN_SubTotal = New System.Windows.Forms.Button()
        Me.TXT_SubTotal = New System.Windows.Forms.Label()
        Me.TXT_Model2_Amount = New System.Windows.Forms.Label()
        Me.TXT_Model3_Amount = New System.Windows.Forms.Label()
        Me.TXT_Model1_Amount = New System.Windows.Forms.Label()
        Me.CB_Model3 = New System.Windows.Forms.ComboBox()
        Me.CB_Model2 = New System.Windows.Forms.ComboBox()
        Me.CB_Model1 = New System.Windows.Forms.ComboBox()
        Me.CHK_Model3 = New System.Windows.Forms.CheckBox()
        Me.CHK_Model2 = New System.Windows.Forms.CheckBox()
        Me.CHK_Model1 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GBO_ModeOfPayment = New System.Windows.Forms.GroupBox()
        Me.GBOX_InstallmentPlan = New System.Windows.Forms.GroupBox()
        Me.RBT_2years = New System.Windows.Forms.RadioButton()
        Me.RBT_1year = New System.Windows.Forms.RadioButton()
        Me.RBT_6months = New System.Windows.Forms.RadioButton()
        Me.TXT_TotalAmount = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RBT_Installment = New System.Windows.Forms.RadioButton()
        Me.RBT_Cash = New System.Windows.Forms.RadioButton()
        Me.BTN_Reset = New System.Windows.Forms.Button()
        Me.GBOX_CustomerInformation.SuspendLayout()
        Me.GBOX_Model.SuspendLayout()
        Me.GBO_ModeOfPayment.SuspendLayout()
        Me.GBOX_InstallmentPlan.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBOX_CustomerInformation
        '
        Me.GBOX_CustomerInformation.Controls.Add(Me.CB_Brand)
        Me.GBOX_CustomerInformation.Controls.Add(Me.Label3)
        Me.GBOX_CustomerInformation.Controls.Add(Me.TXT_Address)
        Me.GBOX_CustomerInformation.Controls.Add(Me.Label2)
        Me.GBOX_CustomerInformation.Controls.Add(Me.TXT_Name)
        Me.GBOX_CustomerInformation.Controls.Add(Me.Label1)
        Me.GBOX_CustomerInformation.ForeColor = System.Drawing.Color.Black
        Me.GBOX_CustomerInformation.Location = New System.Drawing.Point(12, 12)
        Me.GBOX_CustomerInformation.Name = "GBOX_CustomerInformation"
        Me.GBOX_CustomerInformation.Size = New System.Drawing.Size(457, 122)
        Me.GBOX_CustomerInformation.TabIndex = 0
        Me.GBOX_CustomerInformation.TabStop = False
        Me.GBOX_CustomerInformation.Text = "Customer Information"
        '
        'CB_Brand
        '
        Me.CB_Brand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Brand.FormattingEnabled = True
        Me.CB_Brand.Location = New System.Drawing.Point(140, 83)
        Me.CB_Brand.Name = "CB_Brand"
        Me.CB_Brand.Size = New System.Drawing.Size(284, 21)
        Me.CB_Brand.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Brand"
        '
        'TXT_Address
        '
        Me.TXT_Address.Location = New System.Drawing.Point(140, 57)
        Me.TXT_Address.Name = "TXT_Address"
        Me.TXT_Address.Size = New System.Drawing.Size(284, 20)
        Me.TXT_Address.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Address"
        '
        'TXT_Name
        '
        Me.TXT_Name.Location = New System.Drawing.Point(140, 31)
        Me.TXT_Name.Name = "TXT_Name"
        Me.TXT_Name.Size = New System.Drawing.Size(284, 20)
        Me.TXT_Name.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'GBOX_Model
        '
        Me.GBOX_Model.Controls.Add(Me.BTN_SubTotal)
        Me.GBOX_Model.Controls.Add(Me.TXT_SubTotal)
        Me.GBOX_Model.Controls.Add(Me.TXT_Model2_Amount)
        Me.GBOX_Model.Controls.Add(Me.TXT_Model3_Amount)
        Me.GBOX_Model.Controls.Add(Me.TXT_Model1_Amount)
        Me.GBOX_Model.Controls.Add(Me.CB_Model3)
        Me.GBOX_Model.Controls.Add(Me.CB_Model2)
        Me.GBOX_Model.Controls.Add(Me.CB_Model1)
        Me.GBOX_Model.Controls.Add(Me.CHK_Model3)
        Me.GBOX_Model.Controls.Add(Me.CHK_Model2)
        Me.GBOX_Model.Controls.Add(Me.CHK_Model1)
        Me.GBOX_Model.Controls.Add(Me.Label6)
        Me.GBOX_Model.Controls.Add(Me.Label5)
        Me.GBOX_Model.Controls.Add(Me.Label4)
        Me.GBOX_Model.ForeColor = System.Drawing.Color.Black
        Me.GBOX_Model.Location = New System.Drawing.Point(12, 149)
        Me.GBOX_Model.Name = "GBOX_Model"
        Me.GBOX_Model.Size = New System.Drawing.Size(457, 179)
        Me.GBOX_Model.TabIndex = 6
        Me.GBOX_Model.TabStop = False
        Me.GBOX_Model.Text = "Model"
        '
        'BTN_SubTotal
        '
        Me.BTN_SubTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_SubTotal.Enabled = False
        Me.BTN_SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.BTN_SubTotal.Location = New System.Drawing.Point(236, 140)
        Me.BTN_SubTotal.Name = "BTN_SubTotal"
        Me.BTN_SubTotal.Size = New System.Drawing.Size(75, 29)
        Me.BTN_SubTotal.TabIndex = 18
        Me.BTN_SubTotal.Text = "Sub-Total"
        Me.BTN_SubTotal.UseVisualStyleBackColor = True
        '
        'TXT_SubTotal
        '
        Me.TXT_SubTotal.BackColor = System.Drawing.Color.White
        Me.TXT_SubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_SubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SubTotal.ForeColor = System.Drawing.Color.Black
        Me.TXT_SubTotal.Location = New System.Drawing.Point(324, 145)
        Me.TXT_SubTotal.Name = "TXT_SubTotal"
        Me.TXT_SubTotal.Size = New System.Drawing.Size(100, 19)
        Me.TXT_SubTotal.TabIndex = 17
        Me.TXT_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_Model2_Amount
        '
        Me.TXT_Model2_Amount.BackColor = System.Drawing.Color.White
        Me.TXT_Model2_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Model2_Amount.ForeColor = System.Drawing.Color.Black
        Me.TXT_Model2_Amount.Location = New System.Drawing.Point(324, 83)
        Me.TXT_Model2_Amount.Name = "TXT_Model2_Amount"
        Me.TXT_Model2_Amount.Size = New System.Drawing.Size(100, 19)
        Me.TXT_Model2_Amount.TabIndex = 16
        Me.TXT_Model2_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_Model3_Amount
        '
        Me.TXT_Model3_Amount.BackColor = System.Drawing.Color.White
        Me.TXT_Model3_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Model3_Amount.ForeColor = System.Drawing.Color.Black
        Me.TXT_Model3_Amount.Location = New System.Drawing.Point(324, 108)
        Me.TXT_Model3_Amount.Name = "TXT_Model3_Amount"
        Me.TXT_Model3_Amount.Size = New System.Drawing.Size(100, 19)
        Me.TXT_Model3_Amount.TabIndex = 16
        Me.TXT_Model3_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_Model1_Amount
        '
        Me.TXT_Model1_Amount.BackColor = System.Drawing.Color.White
        Me.TXT_Model1_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_Model1_Amount.ForeColor = System.Drawing.Color.Black
        Me.TXT_Model1_Amount.Location = New System.Drawing.Point(324, 56)
        Me.TXT_Model1_Amount.Name = "TXT_Model1_Amount"
        Me.TXT_Model1_Amount.Size = New System.Drawing.Size(100, 19)
        Me.TXT_Model1_Amount.TabIndex = 15
        Me.TXT_Model1_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CB_Model3
        '
        Me.CB_Model3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_Model3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Model3.Enabled = False
        Me.CB_Model3.FormattingEnabled = True
        Me.CB_Model3.Location = New System.Drawing.Point(173, 108)
        Me.CB_Model3.Name = "CB_Model3"
        Me.CB_Model3.Size = New System.Drawing.Size(90, 21)
        Me.CB_Model3.TabIndex = 14
        '
        'CB_Model2
        '
        Me.CB_Model2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_Model2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Model2.Enabled = False
        Me.CB_Model2.FormattingEnabled = True
        Me.CB_Model2.Location = New System.Drawing.Point(173, 81)
        Me.CB_Model2.Name = "CB_Model2"
        Me.CB_Model2.Size = New System.Drawing.Size(90, 21)
        Me.CB_Model2.TabIndex = 13
        '
        'CB_Model1
        '
        Me.CB_Model1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CB_Model1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Model1.Enabled = False
        Me.CB_Model1.FormattingEnabled = True
        Me.CB_Model1.Location = New System.Drawing.Point(173, 54)
        Me.CB_Model1.Name = "CB_Model1"
        Me.CB_Model1.Size = New System.Drawing.Size(90, 21)
        Me.CB_Model1.TabIndex = 12
        '
        'CHK_Model3
        '
        Me.CHK_Model3.AutoSize = True
        Me.CHK_Model3.Location = New System.Drawing.Point(24, 108)
        Me.CHK_Model3.Name = "CHK_Model3"
        Me.CHK_Model3.Size = New System.Drawing.Size(64, 17)
        Me.CHK_Model3.TabIndex = 11
        Me.CHK_Model3.Text = "Model 3"
        Me.CHK_Model3.UseVisualStyleBackColor = True
        Me.CHK_Model3.Visible = False
        '
        'CHK_Model2
        '
        Me.CHK_Model2.AutoSize = True
        Me.CHK_Model2.Location = New System.Drawing.Point(24, 82)
        Me.CHK_Model2.Name = "CHK_Model2"
        Me.CHK_Model2.Size = New System.Drawing.Size(64, 17)
        Me.CHK_Model2.TabIndex = 10
        Me.CHK_Model2.Text = "Model 2"
        Me.CHK_Model2.UseVisualStyleBackColor = True
        Me.CHK_Model2.Visible = False
        '
        'CHK_Model1
        '
        Me.CHK_Model1.AutoSize = True
        Me.CHK_Model1.Location = New System.Drawing.Point(24, 56)
        Me.CHK_Model1.Name = "CHK_Model1"
        Me.CHK_Model1.Size = New System.Drawing.Size(64, 17)
        Me.CHK_Model1.TabIndex = 9
        Me.CHK_Model1.Text = "Model 1"
        Me.CHK_Model1.UseVisualStyleBackColor = True
        Me.CHK_Model1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(347, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Amount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(190, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unit Model"
        '
        'GBO_ModeOfPayment
        '
        Me.GBO_ModeOfPayment.Controls.Add(Me.GBOX_InstallmentPlan)
        Me.GBO_ModeOfPayment.Controls.Add(Me.TXT_TotalAmount)
        Me.GBO_ModeOfPayment.Controls.Add(Me.Label11)
        Me.GBO_ModeOfPayment.Controls.Add(Me.RBT_Installment)
        Me.GBO_ModeOfPayment.Controls.Add(Me.RBT_Cash)
        Me.GBO_ModeOfPayment.ForeColor = System.Drawing.Color.Black
        Me.GBO_ModeOfPayment.Location = New System.Drawing.Point(12, 342)
        Me.GBO_ModeOfPayment.Name = "GBO_ModeOfPayment"
        Me.GBO_ModeOfPayment.Size = New System.Drawing.Size(344, 139)
        Me.GBO_ModeOfPayment.TabIndex = 6
        Me.GBO_ModeOfPayment.TabStop = False
        Me.GBO_ModeOfPayment.Text = "Mode of Payment"
        Me.GBO_ModeOfPayment.Visible = False
        '
        'GBOX_InstallmentPlan
        '
        Me.GBOX_InstallmentPlan.Controls.Add(Me.RBT_2years)
        Me.GBOX_InstallmentPlan.Controls.Add(Me.RBT_1year)
        Me.GBOX_InstallmentPlan.Controls.Add(Me.RBT_6months)
        Me.GBOX_InstallmentPlan.ForeColor = System.Drawing.Color.Black
        Me.GBOX_InstallmentPlan.Location = New System.Drawing.Point(157, 17)
        Me.GBOX_InstallmentPlan.Name = "GBOX_InstallmentPlan"
        Me.GBOX_InstallmentPlan.Size = New System.Drawing.Size(169, 100)
        Me.GBOX_InstallmentPlan.TabIndex = 4
        Me.GBOX_InstallmentPlan.TabStop = False
        Me.GBOX_InstallmentPlan.Text = "Installment Plan"
        Me.GBOX_InstallmentPlan.Visible = False
        '
        'RBT_2years
        '
        Me.RBT_2years.AutoSize = True
        Me.RBT_2years.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBT_2years.Location = New System.Drawing.Point(16, 69)
        Me.RBT_2years.Name = "RBT_2years"
        Me.RBT_2years.Size = New System.Drawing.Size(61, 17)
        Me.RBT_2years.TabIndex = 2
        Me.RBT_2years.TabStop = True
        Me.RBT_2years.Text = "2 Years"
        Me.RBT_2years.UseVisualStyleBackColor = True
        '
        'RBT_1year
        '
        Me.RBT_1year.AutoSize = True
        Me.RBT_1year.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBT_1year.Location = New System.Drawing.Point(16, 46)
        Me.RBT_1year.Name = "RBT_1year"
        Me.RBT_1year.Size = New System.Drawing.Size(56, 17)
        Me.RBT_1year.TabIndex = 1
        Me.RBT_1year.TabStop = True
        Me.RBT_1year.Text = "1 Year"
        Me.RBT_1year.UseVisualStyleBackColor = True
        '
        'RBT_6months
        '
        Me.RBT_6months.AutoSize = True
        Me.RBT_6months.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBT_6months.Location = New System.Drawing.Point(16, 23)
        Me.RBT_6months.Name = "RBT_6months"
        Me.RBT_6months.Size = New System.Drawing.Size(69, 17)
        Me.RBT_6months.TabIndex = 0
        Me.RBT_6months.TabStop = True
        Me.RBT_6months.Text = "6 Months"
        Me.RBT_6months.UseVisualStyleBackColor = True
        '
        'TXT_TotalAmount
        '
        Me.TXT_TotalAmount.BackColor = System.Drawing.Color.White
        Me.TXT_TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_TotalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TotalAmount.ForeColor = System.Drawing.Color.Black
        Me.TXT_TotalAmount.Location = New System.Drawing.Point(22, 102)
        Me.TXT_TotalAmount.Name = "TXT_TotalAmount"
        Me.TXT_TotalAmount.Size = New System.Drawing.Size(107, 19)
        Me.TXT_TotalAmount.TabIndex = 3
        Me.TXT_TotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Total Amount Due"
        '
        'RBT_Installment
        '
        Me.RBT_Installment.AutoSize = True
        Me.RBT_Installment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBT_Installment.Location = New System.Drawing.Point(25, 53)
        Me.RBT_Installment.Name = "RBT_Installment"
        Me.RBT_Installment.Size = New System.Drawing.Size(75, 17)
        Me.RBT_Installment.TabIndex = 1
        Me.RBT_Installment.TabStop = True
        Me.RBT_Installment.Text = "Installment"
        Me.RBT_Installment.UseVisualStyleBackColor = True
        '
        'RBT_Cash
        '
        Me.RBT_Cash.AutoSize = True
        Me.RBT_Cash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBT_Cash.Location = New System.Drawing.Point(24, 30)
        Me.RBT_Cash.Name = "RBT_Cash"
        Me.RBT_Cash.Size = New System.Drawing.Size(49, 17)
        Me.RBT_Cash.TabIndex = 0
        Me.RBT_Cash.TabStop = True
        Me.RBT_Cash.Text = "Cash"
        Me.RBT_Cash.UseVisualStyleBackColor = True
        '
        'BTN_Reset
        '
        Me.BTN_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_Reset.Enabled = False
        Me.BTN_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Reset.ForeColor = System.Drawing.Color.Black
        Me.BTN_Reset.Location = New System.Drawing.Point(394, 450)
        Me.BTN_Reset.Name = "BTN_Reset"
        Me.BTN_Reset.Size = New System.Drawing.Size(75, 37)
        Me.BTN_Reset.TabIndex = 19
        Me.BTN_Reset.Text = "RESET"
        Me.BTN_Reset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(481, 499)
        Me.Controls.Add(Me.BTN_Reset)
        Me.Controls.Add(Me.GBO_ModeOfPayment)
        Me.Controls.Add(Me.GBOX_Model)
        Me.Controls.Add(Me.GBOX_CustomerInformation)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barrameda_Activity3"
        Me.GBOX_CustomerInformation.ResumeLayout(False)
        Me.GBOX_CustomerInformation.PerformLayout()
        Me.GBOX_Model.ResumeLayout(False)
        Me.GBOX_Model.PerformLayout()
        Me.GBO_ModeOfPayment.ResumeLayout(False)
        Me.GBO_ModeOfPayment.PerformLayout()
        Me.GBOX_InstallmentPlan.ResumeLayout(False)
        Me.GBOX_InstallmentPlan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBOX_CustomerInformation As GroupBox
    Friend WithEvents CB_Brand As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_Address As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_Name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GBOX_Model As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Model2_Amount As Label
    Friend WithEvents TXT_Model3_Amount As Label
    Friend WithEvents TXT_Model1_Amount As Label
    Friend WithEvents CB_Model3 As ComboBox
    Friend WithEvents CB_Model2 As ComboBox
    Friend WithEvents CB_Model1 As ComboBox
    Friend WithEvents CHK_Model3 As CheckBox
    Friend WithEvents CHK_Model2 As CheckBox
    Friend WithEvents CHK_Model1 As CheckBox
    Friend WithEvents BTN_SubTotal As Button
    Friend WithEvents TXT_SubTotal As Label
    Friend WithEvents GBO_ModeOfPayment As GroupBox
    Friend WithEvents TXT_TotalAmount As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents RBT_Installment As RadioButton
    Friend WithEvents RBT_Cash As RadioButton
    Friend WithEvents GBOX_InstallmentPlan As GroupBox
    Friend WithEvents RBT_2years As RadioButton
    Friend WithEvents RBT_1year As RadioButton
    Friend WithEvents RBT_6months As RadioButton
    Friend WithEvents BTN_Reset As Button
End Class
