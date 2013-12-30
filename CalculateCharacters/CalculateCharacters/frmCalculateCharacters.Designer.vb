<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculateCharacters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalculateCharacters))
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.tbUserInput = New System.Windows.Forms.TextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblUppercase = New System.Windows.Forms.Label()
        Me.lblLowercase = New System.Windows.Forms.Label()
        Me.lblNumbers = New System.Windows.Forms.Label()
        Me.lblSymbols = New System.Windows.Forms.Label()
        Me.lblEmptyCharacters = New System.Windows.Forms.Label()
        Me.pbError = New System.Windows.Forms.PictureBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnResetForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Location = New System.Drawing.Point(12, 21)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(1050, 20)
        Me.lblAbout.TabIndex = 0
        Me.lblAbout.Text = "Calculate Characters is used to determine the number of uppercase letters, lowerc" & _
    "ase letters, numbers, and symbols in a 15 or more character string"
        Me.lblAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(12, 74)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(343, 20)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = "Please Enter a String of 15 Characters or more:"
        '
        'tbUserInput
        '
        Me.tbUserInput.Location = New System.Drawing.Point(16, 113)
        Me.tbUserInput.Name = "tbUserInput"
        Me.tbUserInput.Size = New System.Drawing.Size(532, 26)
        Me.tbUserInput.TabIndex = 2
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(81, 153)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(372, 20)
        Me.lblError.TabIndex = 3
        Me.lblError.Text = "Error: Please enter a string of at least 15 characters"
        Me.lblError.Visible = False
        '
        'lblUppercase
        '
        Me.lblUppercase.AutoSize = True
        Me.lblUppercase.Location = New System.Drawing.Point(12, 199)
        Me.lblUppercase.Name = "lblUppercase"
        Me.lblUppercase.Size = New System.Drawing.Size(0, 20)
        Me.lblUppercase.TabIndex = 4
        Me.lblUppercase.Visible = False
        '
        'lblLowercase
        '
        Me.lblLowercase.AutoSize = True
        Me.lblLowercase.Location = New System.Drawing.Point(12, 252)
        Me.lblLowercase.Name = "lblLowercase"
        Me.lblLowercase.Size = New System.Drawing.Size(0, 20)
        Me.lblLowercase.TabIndex = 5
        Me.lblLowercase.Visible = False
        '
        'lblNumbers
        '
        Me.lblNumbers.AutoSize = True
        Me.lblNumbers.Location = New System.Drawing.Point(12, 305)
        Me.lblNumbers.Name = "lblNumbers"
        Me.lblNumbers.Size = New System.Drawing.Size(0, 20)
        Me.lblNumbers.TabIndex = 6
        Me.lblNumbers.Visible = False
        '
        'lblSymbols
        '
        Me.lblSymbols.AutoSize = True
        Me.lblSymbols.Location = New System.Drawing.Point(12, 358)
        Me.lblSymbols.Name = "lblSymbols"
        Me.lblSymbols.Size = New System.Drawing.Size(0, 20)
        Me.lblSymbols.TabIndex = 7
        Me.lblSymbols.Visible = False
        '
        'lblEmptyCharacters
        '
        Me.lblEmptyCharacters.AutoSize = True
        Me.lblEmptyCharacters.Location = New System.Drawing.Point(12, 411)
        Me.lblEmptyCharacters.Name = "lblEmptyCharacters"
        Me.lblEmptyCharacters.Size = New System.Drawing.Size(0, 20)
        Me.lblEmptyCharacters.TabIndex = 8
        Me.lblEmptyCharacters.Visible = False
        '
        'pbError
        '
        Me.pbError.Image = CType(resources.GetObject("pbError.Image"), System.Drawing.Image)
        Me.pbError.Location = New System.Drawing.Point(152, 173)
        Me.pbError.Name = "pbError"
        Me.pbError.Size = New System.Drawing.Size(260, 258)
        Me.pbError.TabIndex = 9
        Me.pbError.TabStop = False
        Me.pbError.Visible = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 448)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(152, 80)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnResetForm
        '
        Me.btnResetForm.Location = New System.Drawing.Point(204, 448)
        Me.btnResetForm.Name = "btnResetForm"
        Me.btnResetForm.Size = New System.Drawing.Size(152, 80)
        Me.btnResetForm.TabIndex = 11
        Me.btnResetForm.Text = "&Reset Form"
        Me.btnResetForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(396, 448)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 80)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCalculateCharacters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 560)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetForm)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.pbError)
        Me.Controls.Add(Me.lblEmptyCharacters)
        Me.Controls.Add(Me.lblSymbols)
        Me.Controls.Add(Me.lblNumbers)
        Me.Controls.Add(Me.lblLowercase)
        Me.Controls.Add(Me.lblUppercase)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.tbUserInput)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblAbout)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmCalculateCharacters"
        Me.ShowIcon = False
        Me.Text = "Calculate Characters"
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAbout As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents tbUserInput As System.Windows.Forms.TextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblUppercase As System.Windows.Forms.Label
    Friend WithEvents lblLowercase As System.Windows.Forms.Label
    Friend WithEvents lblNumbers As System.Windows.Forms.Label
    Friend WithEvents lblSymbols As System.Windows.Forms.Label
    Friend WithEvents lblEmptyCharacters As System.Windows.Forms.Label
    Friend WithEvents pbError As System.Windows.Forms.PictureBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnResetForm As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
