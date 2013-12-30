Public Class frmInput
    '''''''''''''''''''''''''''''''''''''
    'Name:          William Mitchell    '
    'Application:   User Input Loop     '
    'Course:        POS/408             '
    'Instructor:    Ashish Gulati       '
    'Date:          11/14/2013          '
    '''''''''''''''''''''''''''''''''''''   

    'sets subs to run with form when it opens
    Private Sub frmInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call toolTipStart() 'Calls tool tip sub
    End Sub

    'defines the tooltips for the form
    Private Sub toolTipStart()
        Me.ttHelp.SetToolTip(Me.btnExit, "Exit Application") 'sets tool tip for exit button
        Me.ttHelp.SetToolTip(Me.btnReset, "Reset Form") 'sets tool tip for reset button
        Me.ttHelp.SetToolTip(Me.btnRun, "Display Calculation") 'sets tool tip for run button
        Me.ttHelp.SetToolTip(Me.tbStart, "Enter the initial value as an integer") 'sets tool tip forstart value text box
        Me.ttHelp.SetToolTip(Me.tbIterations, "Enter the number of times the loop should run as an integer") 'sets tool tip for iterations text box
        Me.ttHelp.SetToolTip(Me.tbStep, "Enter the value by which each itteration should increase the initial value as an integer") 'sets tool tip for step value text box
    End Sub

    'Sets Action listener for Exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'Sets Action listener for Exit menu item
    Private Sub mniExit_Click(sender As Object, e As EventArgs) Handles mniExit.Click
        Application.Exit()
    End Sub
    'Sets action listener for reset button, calls rest form sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call resetForm()
    End Sub

    'sets action listener for submit button, runs validation and then executes loop if valid
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        rtbOutput.Clear() 'Clears the rich text box in case there are error messages
        rtbOutput.BackColor = DefaultBackColor 'resets the background to the default color, clearing the error color if it is used
        Call validateInput() 'calls validate input sub to ensure values can be parsed
        If validateInput() = True Then
            Call executeWhileLoop() 'calls while loop or it exits the sub if it can not
        Else
            Exit Sub
        End If
    End Sub

    'Runs the while loop
    Private Sub executeWhileLoop()
        rtbOutput.Font = New Font(rtbOutput.Font.Name, 24, FontStyle.Bold) 'Sets text syle for output to rich text box
        Dim counter As Integer 'sets up counter variable for loop
        Dim finalValue As Integer 'sets up finalValue as available variable for calculation
        Dim increaser As Integer 'sets up increaser variable to be used to siplify equation
        Dim stepValue As Integer = Integer.Parse(Me.tbStep.Text) 'parses the user input for step to stepValue variable
        Dim iterations As Integer = Integer.Parse(Me.tbIterations.Text) 'parses the user input for iterations to iterations variable
        Dim startValue As Integer = Integer.Parse(Me.tbStart.Text) 'parses the user input for starts to startValue variable

        While counter < iterations 'executes the while loop
            increaser = counter * stepValue 'sets value for the increaser, saves room in equation since counter*stepvalue is used multiple times, calling it increaser saves code and makes the code less prone to erros
            finalValue = (startValue + increaser) + 2 * (startValue + increaser) 'sets final value for each iteration
            rtbOutput.AppendText((startValue + increaser) & " + " & 2 * (startValue + increaser) & " = " & finalValue & Environment.NewLine) 'outputs results for each itteration
            counter += 1 'bumps the counter by 1 each iteration
        End While

    End Sub

    'Resets the form
    Private Sub resetForm()
        Me.tbStart.Clear() 'Clears user input value for tbStart
        Me.tbIterations.Clear() 'Clears user input value for tbIterations
        Me.tbStep.Clear() 'Clears user input value for tbStep
        Me.rtbOutput.Clear() 'Clears the rich text box
        Me.rtbOutput.BackColor = DefaultBackColor 'resets the background of the rich text box to the default color
        Me.tbStart.Focus() 'sets the focus back on the start value text box for the user
    End Sub

    'Validates Input
    Private Function validateInput() As Boolean 'creates a Boolean value that will be used to either run or not run the loop
        Dim intStart As Integer 'defines variable to be used in validation for user input
        Dim intIterations As Integer 'defines variable to be used in validation for user input
        Dim intStep As Integer 'defines variable to be used in validation for user input

        If Integer.TryParse(Me.tbStart.Text, intStart) And Integer.TryParse(Me.tbIterations.Text, intIterations) And Integer.TryParse(Me.tbStep.Text, intStep) Then
            Return True 'returns true so the loop will run
        Else : errorProcess() 'calles the error handling sub if there is an error
            Return False 'returns a false value so the loop will not run
        End If

    End Function

    Private Sub errorProcess()
        Dim intStart As Integer 'defines variable to be used in error handling for user input
        Dim intIterations As Integer 'defines variable to be used in error handling for user input
        Dim intStep As Integer 'defines variable to be used in error handling for user input
        Dim startError As String = "Please Enter a valid integer value for start possition" 'sets variable for error message for start possition 
        Dim iterationError As String = "Please enter a valid integer value for iterations" 'sets variable for error message for iteration value
        Dim stepError As String = "Please enter a valid integer value for Step Value" 'sets variable for error message for step value
        rtbOutput.Font = New Font(rtbOutput.Font.Name, 24, FontStyle.Bold) 'Sets font for error message
        rtbOutput.BackColor = Color.Red 'sets background of rich text box to red for error message

        'Gives Error if valid value not used for start position
        If Integer.TryParse(Me.tbStart.Text, intStart) = False And Integer.TryParse(Me.tbIterations.Text, intIterations) And Integer.TryParse(Me.tbStep.Text, intStep) Then
            rtbOutput.BackColor = Color.Red 'sets background of rich text box to red for error message
            rtbOutput.Text = startError 'displays error message
            tbStart.Clear() 'clears tbstart user input
            tbStart.Focus() 'focus on tbStart text box
        End If

        'Gives Error if valid value not used for start and iterations
        If Integer.TryParse(Me.tbStart.Text, intStart) = False And Integer.TryParse(Me.tbIterations.Text, intIterations) = False And Integer.TryParse(Me.tbStep.Text, intStep) Then
            rtbOutput.Text = startError & Environment.NewLine & Environment.NewLine & iterationError 'displays error message
            tbStart.Clear() 'clears tbstart user input
            tbIterations.Clear() 'clears tbIterations user input
            tbStart.Focus() 'focus on tbStart text box
        End If

        'Gives Error if valid value not used for start and iterations and step
        If Integer.TryParse(Me.tbStart.Text, intStart) = False And Integer.TryParse(Me.tbIterations.Text, intIterations) = False And Integer.TryParse(Me.tbStep.Text, intStep) = False Then
            rtbOutput.Text = startError & Environment.NewLine & Environment.NewLine & iterationError & Environment.NewLine & Environment.NewLine & stepError 'displays error message
            tbStart.Clear() 'clears tbstart user input
            tbIterations.Clear() 'clears tbIterations user input
            tbStep.Clear() 'clears tbStep user input
            tbStart.Focus() 'focus on tbStart text box
        End If

        'Gives Error if valid value not used for iterations and step
        If Integer.TryParse(Me.tbStart.Text, intStart) And Integer.TryParse(Me.tbIterations.Text, intIterations) = False And Integer.TryParse(Me.tbStep.Text, intStep) = False Then
            rtbOutput.Text = iterationError & Environment.NewLine & Environment.NewLine & stepError 'displays error message
            tbIterations.Clear() 'clears tbIterations user input
            tbStep.Clear() 'clears tbStep user input
            tbIterations.Focus() 'focus on tbIteration text box
        End If

        'Gives Error if valid value not used for step
        If Integer.TryParse(Me.tbStart.Text, intStart) And Integer.TryParse(Me.tbIterations.Text, intIterations) And Integer.TryParse(Me.tbStep.Text, intStep) = False Then
            rtbOutput.Text = stepError 'displays error message
            tbStep.Clear()
            tbStep.Focus()
        End If

        'Gives Error if valid value not used for iterations
        If Integer.TryParse(Me.tbStart.Text, intStart) And Integer.TryParse(Me.tbIterations.Text, intIterations) = False And Integer.TryParse(Me.tbStep.Text, intStep) Then
            rtbOutput.Text = iterationError 'displays error message
            tbIterations.Clear() 'clears tbIterations user input
            tbIterations.Focus() 'focus on tbIteration text box
        End If
    End Sub





End Class
