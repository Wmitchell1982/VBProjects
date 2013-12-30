Option Strict On
Public Class MortgageCalculator


    'Team A : William Mitchell and Dennis Chapman
    'Instructor : Ashish Gulati
    'Project : Mortgage Calculator
    'Date : 12/05/2013
    'Dennis and Will worked together on the GUI and most of the code colaboratively

    'Declares constants for Interest Rate Range
    Private Const INTEREST_RATE_MAX = 10
    Private Const INTEREST_RATE_MIN = 2

    'William Mitchell
    'Sets load events for the form
    Private Sub MortgageCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call toolTipHelp()
    End Sub

    'Dennis Chapman
    'sets action listener for exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Call exitApp()
    End Sub

    'Dennis Chapman
    'sets action lister for quit menu item
    Private Sub mnuQuit_Click(sender As Object, e As EventArgs) Handles mnuQuit.Click
        Call exitApp()
    End Sub

    'William Mitchell
    'defines tooltips
    Private Sub toolTipHelp()
        Me.ToolTipMortgageCalculator.SetToolTip(Me.tbSalesPrice, "Enter the Sales Price for the home")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.tbInterestRate, "Enter the Interest Rate as a % (ie. 6.5)")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.tbDownPayment, "Enter the Down Payment")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.tbExtraPayment, "Enter the extra ammount you will pay each period")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.rbBiWeekly, "Select for 26 payments per year")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.rbMonthly, "Select for 12 payments per year")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.cbxMortgageTerm, "Select the Term in Years")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.btnCalculate, "Calculate Payments and Display Amortization Table")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.btnExit, "Exit the Application")
        Me.ToolTipMortgageCalculator.SetToolTip(Me.btnReset, "Reset the Form")
    End Sub

    'Dennis Chapman
    'sets action listener for reset menu item
    Private Sub mnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click
        Call resetForm()
    End Sub

    'Dennis Chapman
    'Sets action listener for reset button
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call resetForm()
    End Sub

    'Dennis Chapman
    'Sets action listener for calculate button click
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Call calculatePayments()
    End Sub

    'William Mitchell
    'resets form
    Private Sub resetForm()
        Me.tbSalesPrice.Clear()
        Me.tbDownPayment.Clear()
        Me.tbInterestRate.Clear()
        Me.tbExtraPayment.Clear()
        Me.cbxMortgageTerm.SelectedIndex = -1
        Me.rbMonthly.Checked = False
        Me.rbBiWeekly.Checked = False
        Me.tbSalesPrice.Focus()
        Me.dgResults.DataSource = Nothing
        Me.errInfo.Clear()
    End Sub

    'Dennis Chapman
    Private Sub exitApp()
        Application.Exit()
    End Sub

    'William Mitchell
    Private Sub mnuCalculate_Click(sender As Object, e As EventArgs) Handles mnuCalculate.Click
        Call calculatePayments()
    End Sub


    'William Mitchell and Dennis Chapman
    'runs Calculation and populates table
    Private Sub calculatePayments()
        If validInput() = True Then


            Dim intYears As Integer 'declares variable for years
            Dim strYear As String = Me.cbxMortgageTerm.SelectedItem.ToString 'creates a string to be truncated based on selection from the combobox
            Dim intTerm As Integer 'creates variable for the term in payments
            Dim intCounter As Integer 'creates a counter variable
            Dim tblResults As DataTable = New DataTable 'Creates a datatable and names it amortization
            Dim dblRate As Double 'Declares variable for rate
            Dim dblPrinciple As Double 'Declares variable for principle
            Dim dblNewPrinciple As Double 'Declares variable for new principle used in table population
            Dim dblInterestPayment As Double 'Declares variable for ammount paid to interest
            Dim dblPrinciplePayment As Double 'declares variable for ammount paid to principle
            Dim dblPayment As Double 'Declares variable for scheduled payment
            Dim dblAdditionalPayment As Double = 0 ''Declares variable for additional payment
            Dim dblOriginalPrinciple As Double 'Sets variable for original principle amount
            Dim dblTotalInterestPaid As Double 'Sets variable for total interest paid
            Dim intPaymentNumber As Integer 'Sets variable for payment number
            Dim dblInterestSaved As Double 'Sets variable for interest Saved

            intYears = Integer.Parse(strYear.Substring(0, strYear.Length - 5)) 'shortes year string so it can be parsed to an Int

            'sets colum heading for table
            tblResults.Columns.Add("Payment #", GetType(Integer))
            tblResults.Columns.Add("Paid To Principle", GetType(String))
            tblResults.Columns.Add("Paid To Interest", GetType(String))
            tblResults.Columns.Add("Extra Payment", GetType(String))
            tblResults.Columns.Add("Scheduled Payment", GetType(String))
            tblResults.Columns.Add("Period ending balance", GetType(String))

            'conditional statement for determining starting principle value
            If String.IsNullOrEmpty(Me.tbDownPayment.Text) Then
                dblPrinciple = Double.Parse(Me.tbSalesPrice.Text)
                dblOriginalPrinciple = Double.Parse(Me.tbSalesPrice.Text)
            Else
                dblPrinciple = Double.Parse(Me.tbSalesPrice.Text) - Double.Parse(Me.tbDownPayment.Text)
                dblOriginalPrinciple = Double.Parse(Me.tbSalesPrice.Text) - Double.Parse(Me.tbDownPayment.Text)
            End If

            'Conditional statement for defining the value of extra payment
            If String.IsNullOrEmpty(Me.tbExtraPayment.Text) = False Then
                dblAdditionalPayment = Double.Parse(Me.tbExtraPayment.Text)
            End If

            'Conditional statement for setting the term and rate per period
            If rbBiWeekly.Checked = True Then
                intTerm = 26 * intYears
                dblRate = (Double.Parse(Me.tbInterestRate.Text) / 26) / 100
            Else
                intTerm = 12 * intYears
                dblRate = (Double.Parse(Me.tbInterestRate.Text) / 12) / 100
            End If

            'calculates the scheduled payment (amortization equation)
            dblPayment = (dblPrinciple * dblRate * (1 + dblRate) ^ intTerm) / ((1 + dblRate) ^ intTerm - 1)

            'For loop to populate the table
            For intCounter = 0 To intTerm - 1
                If dblPrinciple >= 0 Then 'sets condition for the table to end after the loan is paid off
                    dblNewPrinciple = dblPrinciple * (1 + dblRate) - (dblPayment + dblAdditionalPayment) 'sets value for the ending period principle
                    dblPrinciplePayment = (dblPrinciple - dblNewPrinciple) 'calculates ammount paid to principle
                    dblInterestPayment = dblPayment - (dblPrinciplePayment - dblAdditionalPayment) 'calculates the ammount paid to interest
                    intPaymentNumber = intCounter + 1
                    'populates the rows for the table
                    tblResults.Rows.Add(intPaymentNumber, FormatCurrency(dblPrinciplePayment), FormatCurrency(dblInterestPayment),
                                        FormatCurrency(dblAdditionalPayment), FormatCurrency(dblPayment), FormatCurrency(dblNewPrinciple))
                    dblPrinciple = dblNewPrinciple 'sets principle amount to the period ending principle amount for the next iteration
                End If

            Next
            'Total Interest Paid Formula
            dblTotalInterestPaid = (dblPayment + dblAdditionalPayment) * intPaymentNumber - dblOriginalPrinciple

            'Total Interest Saved Formula
            dblInterestSaved = (dblPayment * intTerm - dblOriginalPrinciple) - dblTotalInterestPaid

            tblResults.Rows.Add(DBNull.Value, "Total Interest Paid", FormatCurrency(dblTotalInterestPaid), "", "") 'Populates Final row Showing total interest paid
            tblResults.Rows.Add(DBNull.Value, "Interest Saved By Extra Pmt", FormatCurrency(dblInterestSaved), "", "")
            Me.dgResults.DataSource = tblResults 'displays the table

        Else : Exit Sub
        End If
    End Sub

    'William Mitchell and Dennis Chapman
    'Runs Validation Function
    Private Function validInput() As Boolean
        Dim dblExtraPayment As Double 'Declares Variable for extra payment
        Dim dblSalesPrice As Double 'Declares Variable for sales price
        Dim dblInterestRate As Double 'declares variable for interest rate
        Dim dblDownPayment As Double 'declares variable for down payment
        Dim isValid As Boolean = True 'sets another boolean for conditions

        Call errorReset() 'Resets the error message

        'If sales price is empty or not a number display error message
        If String.IsNullOrEmpty(Me.tbSalesPrice.Text) Then
            Me.errInfo.SetError(Me.tbSalesPrice, "Please enter the loan amount")
            Me.tbSalesPrice.Focus()
            isValid = False
        ElseIf Double.TryParse(tbSalesPrice.Text, dblSalesPrice) = False Then
            Me.errInfo.SetError(Me.tbSalesPrice, "Please enter the loan amount as a number")
            Me.tbSalesPrice.Clear()
            Me.tbSalesPrice.Focus()
            isValid = False
        End If

        'If down payment is filled out, but not a number returns an error message
        If String.IsNullOrEmpty(Me.tbDownPayment.Text) = False And Double.TryParse(Me.tbDownPayment.Text, dblDownPayment) = False Then
            Me.errInfo.SetError(Me.tbDownPayment, "Please enter the down payment amount as a number")
            Me.tbDownPayment.Clear()
            Me.tbDownPayment.Focus()
            isValid = False
        End If

        'If interest rate is empty or not a number between the min and max range display error message
        If String.IsNullOrEmpty(Me.tbInterestRate.Text) Then
            Me.errInfo.SetError(Me.tbInterestRate, "Please enter the interest rate")
            Me.tbInterestRate.Focus()
            isValid = False
        ElseIf Double.TryParse(Me.tbInterestRate.Text, dblInterestRate) = False Or dblInterestRate < INTEREST_RATE_MIN Or dblInterestRate > INTEREST_RATE_MAX Then
            Me.errInfo.SetError(Me.tbInterestRate, "Please enter the interest rate as a number between " & INTEREST_RATE_MIN & "% and " & INTEREST_RATE_MAX & "%")
            Me.tbInterestRate.Clear()
            Me.tbInterestRate.Focus()
            isValid = False
        End If


        'Makes sure a term is selected for years
        If String.IsNullOrEmpty(Me.cbxMortgageTerm.Text) Then
            Me.errInfo.SetError(Me.cbxMortgageTerm, "Please select the mortgage term")
            Me.cbxMortgageTerm.Focus()
            isValid = False
        End If

        'If extra payment is filled out and not a number it returns an error
        If String.IsNullOrEmpty(Me.tbExtraPayment.Text) = False And Double.TryParse(Me.tbExtraPayment.Text, dblExtraPayment) = False Then
            Me.errInfo.SetError(Me.tbExtraPayment, "Please enter the extra payment as a number")
            Me.tbExtraPayment.Clear()
            Me.tbExtraPayment.Focus()
            isValid = False
        End If

        'If radio button is not chosen then returns an error
        If Me.rbBiWeekly.Checked = False And Me.rbMonthly.Checked = False Then
            Me.errInfo.SetError(lblMonthlyorBiWeekly, "Please select monthly or bi-weekly")
            isValid = False
        End If

        'test isValid to return function


        Return isValid

    End Function

    'William Mitchell and Dennis Chapman
    'Resets Error Handler
    Private Sub errorReset()
        Me.errInfo.Clear()
    End Sub



End Class
