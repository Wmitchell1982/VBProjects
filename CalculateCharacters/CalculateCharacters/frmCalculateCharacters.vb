Public Class frmCalculateCharacters
    '''''''''''''''''''''''''''''''''''''
    'Name:          William Mitchell    '
    'Application:   Calculate Characters'
    'Course:        POS/408             '
    'Instructor:    Ashish Gulati       '
    'Date:          11/25/2013          '
    '''''''''''''''''''''''''''''''''''''
  
    Private Const TOTALCOUNT = 15
    ' Handles the Load event of the frmCalculateCharacters control.
    Private Sub frmCalculateCharacters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the size of the about label, this makes it so the text will wrap to the size of the form
        Me.lblAbout.MaximumSize = New Size(550, 0)
        Me.lblAbout.AutoSize = True
    End Sub

    ' Handles the Click event of the btnExit control. Exits the application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' Handles the Click event of the btnResetForm control.
    Private Sub btnResetForm_Click(sender As Object, e As EventArgs) Handles btnResetForm.Click
        Me.tbUserInput.Clear() 'clears the user input textbox
        Call resetForm() 'calls the resetForm sub
        Me.tbUserInput.Focus() 'sets focus on userInput textbox
    End Sub

   ' Resets the form.
    Private Sub resetForm()
        Me.lblError.Visible = False 'Sets Error Label to invisible
        Me.lblLowercase.Visible = False 'Sets lowercase label to invisible
        Me.lblUppercase.Visible = False 'Sets uppercase label to invisible
        Me.lblNumbers.Visible = False 'Sets numbers label to invisible
        Me.lblSymbols.Visible = False 'Sets symbols label to invisible
        Me.lblEmptyCharacters.Visible = False 'Sets emptyCharacters label to invisible
        Me.pbError.Visible = False 'Sets error picturebox to invisible
        Me.lblUppercase.Text = String.Empty 'Sets uppercase label string value to empty
        Me.lblLowercase.Text = String.Empty 'Sets lowercase label string value to empty
        Me.lblNumbers.Text = String.Empty 'Sets numbers label string value to empty
        Me.lblSymbols.Text = String.Empty 'Sets symbols label string value to empty
        Me.lblEmptyCharacters.Text = String.Empty 'Sets empty characters label string value to empty
    End Sub

   ' Handles the Click event of the btnCalculate control.
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Call resetForm() 'calls the reset form, this will clear out any previous results
        Call validateStringCharacters() 'calls the validation sub
    End Sub

    ' Validates the string characters. Validates that there are at least 15 characters in the string
    Private Sub validateStringCharacters()
        'Counts the number of characters in the string. If it is less than 15 it returns the error method. If it is 15 or more then it calls the calculation sub
        If Me.tbUserInput.Text.Length < TOTALCOUNT Then
            Me.lblError.Visible = True 'sets error label to visible
            Me.pbError.Visible = True 'sets error picturebox to visible
            Me.tbUserInput.Focus() 'sets focus on textbox to take more character input from the user
        Else : Call calculateStringValues() 'calls the calculation sub

        End If
    End Sub

    ' Calculates the string values.
    Private Sub calculateStringValues()
        Call resetForm() 'calls the reset form, this will clear out any previous results
        Dim userInput() As Char = Me.tbUserInput.Text.ToCharArray() 'creates an array of characters from the string input by the user. This array will be used to count the occurances of specific characters
        Dim uppercaseCharacters As Integer = 0 'creates variable for uppercaseCharacters
        Dim lowercaseCharacters As Integer = 0 'creates variable for lowercaseCharacters
        Dim numericCharacters As Integer = 0 'creates variable for numericCharacters
        Dim symbolCharacters As Integer = 0 'creates variable for symbolCharacters, will be used for symbol and puctuation characters
        Dim emptyCharacters As Integer = 0 'creates variable for emptyCharacters
        Dim forCount As Integer 'sets a variable for the for loop to use to contol the number of times the loop will count characters in the character array

        'For loop for counting the number of specific characters in the array
        For forCount = 0 To userInput.Length - 1 'sets boundaries for the for loop the count will go from 0 to at least 14 (one less than the legnth of the string since forCount starts at 0)
            If Char.IsUpper(userInput(forCount)) Then 'counts uppercase characters in the array and adds that number to the forCount
                uppercaseCharacters = uppercaseCharacters + 1 'adds number of uppercase characters to the variable uppercaseCharacters
            ElseIf Char.IsLower(userInput(forCount)) Then 'counts lowercase characters in the array and adds that number to the forCount
                lowercaseCharacters = lowercaseCharacters + 1 'adds number of punctuation characters to the variable symbolCharacters
            ElseIf Char.IsNumber(userInput(forCount)) Then 'counts numeric characters in the array and adds that number to the forCount
                numericCharacters = numericCharacters + 1 'adds number of punctuation characters to the variable symbolCharacters
            ElseIf Char.IsSymbol(userInput(forCount)) Then 'counts symbol characters in the array and adds that number to the forCount
                symbolCharacters = symbolCharacters + 1 'adds number of symbol characters to the variable symbolCharacters
            ElseIf Char.IsPunctuation(userInput(forCount)) Then 'counts punctuation characters in the array and adds that number to the forCount
                symbolCharacters = symbolCharacters + 1 'adds number of punctuation characters to the variable symbolCharacters
            ElseIf Char.IsWhiteSpace(userInput(forCount)) Then 'counts empty space characters in the array and adds that number to the forCount
                emptyCharacters = emptyCharacters + 1 'adds number of punctuation characters to the variable symbolCharacters
            End If
        Next

        'Sets message labels and sets the labels visible
        Me.lblUppercase.Text = "The number of uppercase letters in the string is " + uppercaseCharacters.ToString
        Me.lblLowercase.Text = "The number of lowercase characters is " + lowercaseCharacters.ToString
        Me.lblNumbers.Text = "The number of numerical digits is " + numericCharacters.ToString
        Me.lblSymbols.Text = "The number of symbols is " + symbolCharacters.ToString
        Me.lblEmptyCharacters.Text = "The total number of empty characters is " + emptyCharacters.ToString
        Me.lblUppercase.Visible = True
        Me.lblLowercase.Visible = True
        Me.lblNumbers.Visible = True
        Me.lblSymbols.Visible = True
        Me.lblEmptyCharacters.Visible = True

    End Sub

End Class
