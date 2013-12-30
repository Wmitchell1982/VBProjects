<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MortgageCalculator
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenuDropDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQuit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbxMortgageTerm = New System.Windows.Forms.ComboBox()
        Me.lblSalesPrice = New System.Windows.Forms.Label()
        Me.tbSalesPrice = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblMortgageTerm = New System.Windows.Forms.Label()
        Me.lblMonthlyorBiWeekly = New System.Windows.Forms.Label()
        Me.tbInterestRate = New System.Windows.Forms.TextBox()
        Me.lblDownPayment = New System.Windows.Forms.Label()
        Me.tbDownPayment = New System.Windows.Forms.TextBox()
        Me.ToolTipMortgageCalculator = New System.Windows.Forms.ToolTip(Me.components)
        Me.rbMonthly = New System.Windows.Forms.RadioButton()
        Me.rbBiWeekly = New System.Windows.Forms.RadioButton()
        Me.lblExtraPayment = New System.Windows.Forms.Label()
        Me.tbExtraPayment = New System.Windows.Forms.TextBox()
        Me.dgResults = New System.Windows.Forms.DataGridView()
        Me.errInfo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCalculate.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(28, 447)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(200, 69)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Wheat
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMenuDropDown})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(816, 33)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenuDropDown
        '
        Me.mnuMenuDropDown.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReset, Me.mnuQuit, Me.mnuCalculate})
        Me.mnuMenuDropDown.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMenuDropDown.Name = "mnuMenuDropDown"
        Me.mnuMenuDropDown.Size = New System.Drawing.Size(76, 29)
        Me.mnuMenuDropDown.Text = "Menu"
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.Size = New System.Drawing.Size(164, 30)
        Me.mnuReset.Text = "Reset"
        '
        'mnuQuit
        '
        Me.mnuQuit.Name = "mnuQuit"
        Me.mnuQuit.Size = New System.Drawing.Size(164, 30)
        Me.mnuQuit.Text = "Quit"
        '
        'mnuCalculate
        '
        Me.mnuCalculate.Name = "mnuCalculate"
        Me.mnuCalculate.Size = New System.Drawing.Size(164, 30)
        Me.mnuCalculate.Text = "Calculate"
        '
        'cbxMortgageTerm
        '
        Me.cbxMortgageTerm.BackColor = System.Drawing.SystemColors.Menu
        Me.cbxMortgageTerm.CausesValidation = False
        Me.cbxMortgageTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMortgageTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMortgageTerm.FormattingEnabled = True
        Me.cbxMortgageTerm.Items.AddRange(New Object() {"7 years", "15 years", "20 years", "30 years"})
        Me.cbxMortgageTerm.Location = New System.Drawing.Point(28, 151)
        Me.cbxMortgageTerm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbxMortgageTerm.Name = "cbxMortgageTerm"
        Me.cbxMortgageTerm.Size = New System.Drawing.Size(112, 30)
        Me.cbxMortgageTerm.TabIndex = 3
        '
        'lblSalesPrice
        '
        Me.lblSalesPrice.AutoSize = True
        Me.lblSalesPrice.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesPrice.Location = New System.Drawing.Point(28, 50)
        Me.lblSalesPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalesPrice.Name = "lblSalesPrice"
        Me.lblSalesPrice.Size = New System.Drawing.Size(101, 21)
        Me.lblSalesPrice.TabIndex = 9
        Me.lblSalesPrice.Text = "Sales Price "
        '
        'tbSalesPrice
        '
        Me.tbSalesPrice.BackColor = System.Drawing.SystemColors.Menu
        Me.tbSalesPrice.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSalesPrice.Location = New System.Drawing.Point(28, 74)
        Me.tbSalesPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbSalesPrice.Name = "tbSalesPrice"
        Me.tbSalesPrice.Size = New System.Drawing.Size(205, 27)
        Me.tbSalesPrice.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnReset.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(294, 447)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(200, 69)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnExit.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(560, 447)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 69)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(543, 50)
        Me.lblInterestRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(111, 21)
        Me.lblInterestRate.TabIndex = 10
        Me.lblInterestRate.Text = "Interest Rate"
        '
        'lblMortgageTerm
        '
        Me.lblMortgageTerm.AutoSize = True
        Me.lblMortgageTerm.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMortgageTerm.Location = New System.Drawing.Point(28, 118)
        Me.lblMortgageTerm.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMortgageTerm.Name = "lblMortgageTerm"
        Me.lblMortgageTerm.Size = New System.Drawing.Size(127, 21)
        Me.lblMortgageTerm.TabIndex = 11
        Me.lblMortgageTerm.Text = "Mortgage Term"
        '
        'lblMonthlyorBiWeekly
        '
        Me.lblMonthlyorBiWeekly.AutoSize = True
        Me.lblMonthlyorBiWeekly.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyorBiWeekly.Location = New System.Drawing.Point(543, 118)
        Me.lblMonthlyorBiWeekly.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMonthlyorBiWeekly.Name = "lblMonthlyorBiWeekly"
        Me.lblMonthlyorBiWeekly.Size = New System.Drawing.Size(188, 21)
        Me.lblMonthlyorBiWeekly.TabIndex = 12
        Me.lblMonthlyorBiWeekly.Text = "Monthly or Bi-Weekly"
        '
        'tbInterestRate
        '
        Me.tbInterestRate.BackColor = System.Drawing.SystemColors.Menu
        Me.tbInterestRate.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbInterestRate.Location = New System.Drawing.Point(547, 74)
        Me.tbInterestRate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbInterestRate.Name = "tbInterestRate"
        Me.tbInterestRate.Size = New System.Drawing.Size(75, 27)
        Me.tbInterestRate.TabIndex = 2
        '
        'lblDownPayment
        '
        Me.lblDownPayment.AutoSize = True
        Me.lblDownPayment.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownPayment.Location = New System.Drawing.Point(271, 50)
        Me.lblDownPayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDownPayment.Name = "lblDownPayment"
        Me.lblDownPayment.Size = New System.Drawing.Size(214, 21)
        Me.lblDownPayment.TabIndex = 13
        Me.lblDownPayment.Text = "Down Payment (Optional)"
        '
        'tbDownPayment
        '
        Me.tbDownPayment.BackColor = System.Drawing.SystemColors.Menu
        Me.tbDownPayment.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDownPayment.Location = New System.Drawing.Point(275, 74)
        Me.tbDownPayment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbDownPayment.Name = "tbDownPayment"
        Me.tbDownPayment.Size = New System.Drawing.Size(205, 27)
        Me.tbDownPayment.TabIndex = 1
        '
        'ToolTipMortgageCalculator
        '
        Me.ToolTipMortgageCalculator.AutomaticDelay = 100
        Me.ToolTipMortgageCalculator.IsBalloon = True
        '
        'rbMonthly
        '
        Me.rbMonthly.AutoSize = True
        Me.rbMonthly.Font = New System.Drawing.Font("Modern No. 20", 13.8!)
        Me.rbMonthly.Location = New System.Drawing.Point(547, 153)
        Me.rbMonthly.Name = "rbMonthly"
        Me.rbMonthly.Size = New System.Drawing.Size(95, 25)
        Me.rbMonthly.TabIndex = 5
        Me.rbMonthly.TabStop = True
        Me.rbMonthly.Text = "Mo&nthly"
        Me.rbMonthly.UseVisualStyleBackColor = True
        '
        'rbBiWeekly
        '
        Me.rbBiWeekly.AutoSize = True
        Me.rbBiWeekly.Font = New System.Drawing.Font("Modern No. 20", 13.8!)
        Me.rbBiWeekly.Location = New System.Drawing.Point(648, 154)
        Me.rbBiWeekly.Name = "rbBiWeekly"
        Me.rbBiWeekly.Size = New System.Drawing.Size(113, 25)
        Me.rbBiWeekly.TabIndex = 6
        Me.rbBiWeekly.TabStop = True
        Me.rbBiWeekly.Text = "&Bi-Weekly"
        Me.rbBiWeekly.UseVisualStyleBackColor = True
        '
        'lblExtraPayment
        '
        Me.lblExtraPayment.AutoSize = True
        Me.lblExtraPayment.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtraPayment.Location = New System.Drawing.Point(271, 118)
        Me.lblExtraPayment.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExtraPayment.Name = "lblExtraPayment"
        Me.lblExtraPayment.Size = New System.Drawing.Size(268, 21)
        Me.lblExtraPayment.TabIndex = 18
        Me.lblExtraPayment.Text = "Extra Payment/Period (Optional)"
        '
        'tbExtraPayment
        '
        Me.tbExtraPayment.BackColor = System.Drawing.SystemColors.Menu
        Me.tbExtraPayment.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbExtraPayment.Location = New System.Drawing.Point(275, 154)
        Me.tbExtraPayment.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbExtraPayment.Name = "tbExtraPayment"
        Me.tbExtraPayment.Size = New System.Drawing.Size(112, 27)
        Me.tbExtraPayment.TabIndex = 4
        '
        'dgResults
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgResults.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgResults.Location = New System.Drawing.Point(32, 205)
        Me.dgResults.Name = "dgResults"
        Me.dgResults.Size = New System.Drawing.Size(728, 216)
        Me.dgResults.TabIndex = 20
        '
        'errInfo
        '
        Me.errInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errInfo.ContainerControl = Me
        '
        'MortgageCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(816, 547)
        Me.Controls.Add(Me.dgResults)
        Me.Controls.Add(Me.tbExtraPayment)
        Me.Controls.Add(Me.lblExtraPayment)
        Me.Controls.Add(Me.rbBiWeekly)
        Me.Controls.Add(Me.rbMonthly)
        Me.Controls.Add(Me.tbDownPayment)
        Me.Controls.Add(Me.lblDownPayment)
        Me.Controls.Add(Me.tbInterestRate)
        Me.Controls.Add(Me.lblMonthlyorBiWeekly)
        Me.Controls.Add(Me.lblMortgageTerm)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.tbSalesPrice)
        Me.Controls.Add(Me.lblSalesPrice)
        Me.Controls.Add(Me.cbxMortgageTerm)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "MortgageCalculator"
        Me.Text = "Mortgage Calculator"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents cbxMortgageTerm As System.Windows.Forms.ComboBox
    Friend WithEvents lblSalesPrice As System.Windows.Forms.Label
    Friend WithEvents tbSalesPrice As System.Windows.Forms.TextBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents mnuMenuDropDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblMortgageTerm As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyorBiWeekly As System.Windows.Forms.Label
    Friend WithEvents tbInterestRate As System.Windows.Forms.TextBox
    Friend WithEvents lblDownPayment As System.Windows.Forms.Label
    Friend WithEvents tbDownPayment As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipMortgageCalculator As System.Windows.Forms.ToolTip
    Friend WithEvents rbMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents rbBiWeekly As System.Windows.Forms.RadioButton
    Friend WithEvents lblExtraPayment As System.Windows.Forms.Label
    Friend WithEvents tbExtraPayment As System.Windows.Forms.TextBox
    Friend WithEvents dgResults As System.Windows.Forms.DataGridView
    Friend WithEvents mnuCalculate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents errInfo As System.Windows.Forms.ErrorProvider

End Class
