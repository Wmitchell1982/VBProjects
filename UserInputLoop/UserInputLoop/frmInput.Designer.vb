<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInput
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
        Me.tbStart = New System.Windows.Forms.TextBox()
        Me.tbIterations = New System.Windows.Forms.TextBox()
        Me.tbStep = New System.Windows.Forms.TextBox()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblIterations = New System.Windows.Forms.Label()
        Me.lblStep = New System.Windows.Forms.Label()
        Me.ttHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.mniFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.mnsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbStart
        '
        Me.tbStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStart.Location = New System.Drawing.Point(251, 45)
        Me.tbStart.Name = "tbStart"
        Me.tbStart.Size = New System.Drawing.Size(169, 44)
        Me.tbStart.TabIndex = 0
        '
        'tbIterations
        '
        Me.tbIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbIterations.Location = New System.Drawing.Point(251, 105)
        Me.tbIterations.Name = "tbIterations"
        Me.tbIterations.Size = New System.Drawing.Size(169, 44)
        Me.tbIterations.TabIndex = 1
        '
        'tbStep
        '
        Me.tbStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbStep.Location = New System.Drawing.Point(251, 165)
        Me.tbStep.Name = "tbStep"
        Me.tbStep.Size = New System.Drawing.Size(169, 44)
        Me.tbStep.TabIndex = 2
        '
        'rtbOutput
        '
        Me.rtbOutput.Location = New System.Drawing.Point(25, 224)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.ReadOnly = True
        Me.rtbOutput.Size = New System.Drawing.Size(805, 292)
        Me.rtbOutput.TabIndex = 4
        Me.rtbOutput.Text = ""
        '
        'btnRun
        '
        Me.btnRun.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRun.Location = New System.Drawing.Point(26, 538)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(234, 80)
        Me.btnRun.TabIndex = 5
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(311, 538)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(234, 80)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(596, 538)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(234, 80)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(26, 52)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(208, 37)
        Me.lblStart.TabIndex = 8
        Me.lblStart.Text = "Start Position"
        '
        'lblIterations
        '
        Me.lblIterations.AutoSize = True
        Me.lblIterations.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIterations.Location = New System.Drawing.Point(26, 112)
        Me.lblIterations.Name = "lblIterations"
        Me.lblIterations.Size = New System.Drawing.Size(148, 37)
        Me.lblIterations.TabIndex = 9
        Me.lblIterations.Text = "Iterations"
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep.Location = New System.Drawing.Point(26, 172)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(173, 37)
        Me.lblStep.TabIndex = 10
        Me.lblStep.Text = "Step Value"
        '
        'mniFile
        '
        Me.mniFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniExit})
        Me.mniFile.Name = "mniFile"
        Me.mniFile.Size = New System.Drawing.Size(53, 29)
        Me.mniFile.Text = "File"
        '
        'mniExit
        '
        Me.mniExit.Name = "mniExit"
        Me.mniExit.Size = New System.Drawing.Size(114, 30)
        Me.mniExit.Text = "Exit"
        '
        'mnsMain
        '
        Me.mnsMain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniFile})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(874, 33)
        Me.mnsMain.TabIndex = 12
        Me.mnsMain.Text = "MenuStrip2"
        '
        'frmInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 657)
        Me.Controls.Add(Me.lblStep)
        Me.Controls.Add(Me.lblIterations)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.tbStep)
        Me.Controls.Add(Me.tbIterations)
        Me.Controls.Add(Me.tbStart)
        Me.Controls.Add(Me.mnsMain)
        Me.Name = "frmInput"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "User Input Looper"
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbStart As System.Windows.Forms.TextBox
    Friend WithEvents tbIterations As System.Windows.Forms.TextBox
    Friend WithEvents tbStep As System.Windows.Forms.TextBox
    Friend WithEvents rtbOutput As System.Windows.Forms.RichTextBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblIterations As System.Windows.Forms.Label
    Friend WithEvents lblStep As System.Windows.Forms.Label
    Friend WithEvents ttHelp As System.Windows.Forms.ToolTip
    Friend WithEvents mniFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnsMain As System.Windows.Forms.MenuStrip

End Class
