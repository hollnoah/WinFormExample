﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WindFormExampleForm1
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.LastTextBox = New System.Windows.Forms.TextBox()
        Me.LastLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.UpperRadioButton = New System.Windows.Forms.RadioButton()
        Me.LowerRadioButton = New System.Windows.Forms.RadioButton()
        Me.FirstLastRadioButton = New System.Windows.Forms.RadioButton()
        Me.LastFirstRadioButton = New System.Windows.Forms.RadioButton()
        Me.CaseGroupBox = New System.Windows.Forms.GroupBox()
        Me.FormatGroupBox = New System.Windows.Forms.GroupBox()
        Me.RandomCheckBox = New System.Windows.Forms.CheckBox()
        Me.WhiteSpaceCheckBox = New System.Windows.Forms.CheckBox()
        Me.ReverseCheckBox = New System.Windows.Forms.CheckBox()
        Me.CaseGroupBox.SuspendLayout()
        Me.FormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(479, 281)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(112, 75)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(363, 281)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(112, 75)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(9, 24)
        Me.FirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(57, 13)
        Me.FirstName.TabIndex = 2
        Me.FirstName.Text = "First Name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(68, 22)
        Me.FirstTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(149, 20)
        Me.FirstTextBox.TabIndex = 0
        '
        'LastTextBox
        '
        Me.LastTextBox.Location = New System.Drawing.Point(68, 45)
        Me.LastTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(149, 20)
        Me.LastTextBox.TabIndex = 1
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(9, 47)
        Me.LastLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastLabel.TabIndex = 4
        Me.LastLabel.Text = "Last Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(68, 67)
        Me.AgeTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(38, 20)
        Me.AgeTextBox.TabIndex = 2
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(39, 67)
        Me.AgeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(26, 13)
        Me.AgeLabel.TabIndex = 6
        Me.AgeLabel.Text = "Age"
        '
        'UpperRadioButton
        '
        Me.UpperRadioButton.AutoSize = True
        Me.UpperRadioButton.Location = New System.Drawing.Point(11, 17)
        Me.UpperRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UpperRadioButton.Name = "UpperRadioButton"
        Me.UpperRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.UpperRadioButton.TabIndex = 11
        Me.UpperRadioButton.TabStop = True
        Me.UpperRadioButton.Text = "Upper Case"
        Me.UpperRadioButton.UseVisualStyleBackColor = True
        '
        'LowerRadioButton
        '
        Me.LowerRadioButton.AutoSize = True
        Me.LowerRadioButton.Location = New System.Drawing.Point(11, 38)
        Me.LowerRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LowerRadioButton.Name = "LowerRadioButton"
        Me.LowerRadioButton.Size = New System.Drawing.Size(81, 17)
        Me.LowerRadioButton.TabIndex = 12
        Me.LowerRadioButton.TabStop = True
        Me.LowerRadioButton.Text = "Lower Case"
        Me.LowerRadioButton.UseVisualStyleBackColor = True
        '
        'FirstLastRadioButton
        '
        Me.FirstLastRadioButton.AutoSize = True
        Me.FirstLastRadioButton.Location = New System.Drawing.Point(11, 17)
        Me.FirstLastRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FirstLastRadioButton.Name = "FirstLastRadioButton"
        Me.FirstLastRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.FirstLastRadioButton.TabIndex = 13
        Me.FirstLastRadioButton.TabStop = True
        Me.FirstLastRadioButton.Text = "First Last"
        Me.FirstLastRadioButton.UseVisualStyleBackColor = True
        '
        'LastFirstRadioButton
        '
        Me.LastFirstRadioButton.AutoSize = True
        Me.LastFirstRadioButton.Location = New System.Drawing.Point(11, 42)
        Me.LastFirstRadioButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LastFirstRadioButton.Name = "LastFirstRadioButton"
        Me.LastFirstRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.LastFirstRadioButton.TabIndex = 14
        Me.LastFirstRadioButton.TabStop = True
        Me.LastFirstRadioButton.Text = "Last First"
        Me.LastFirstRadioButton.UseVisualStyleBackColor = True
        '
        'CaseGroupBox
        '
        Me.CaseGroupBox.Controls.Add(Me.UpperRadioButton)
        Me.CaseGroupBox.Controls.Add(Me.LowerRadioButton)
        Me.CaseGroupBox.Location = New System.Drawing.Point(68, 104)
        Me.CaseGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CaseGroupBox.Name = "CaseGroupBox"
        Me.CaseGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CaseGroupBox.Size = New System.Drawing.Size(93, 66)
        Me.CaseGroupBox.TabIndex = 15
        Me.CaseGroupBox.TabStop = False
        Me.CaseGroupBox.Text = "Case"
        '
        'FormatGroupBox
        '
        Me.FormatGroupBox.Controls.Add(Me.FirstLastRadioButton)
        Me.FormatGroupBox.Controls.Add(Me.LastFirstRadioButton)
        Me.FormatGroupBox.Location = New System.Drawing.Point(178, 104)
        Me.FormatGroupBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FormatGroupBox.Name = "FormatGroupBox"
        Me.FormatGroupBox.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FormatGroupBox.Size = New System.Drawing.Size(93, 66)
        Me.FormatGroupBox.TabIndex = 16
        Me.FormatGroupBox.TabStop = False
        Me.FormatGroupBox.Text = "Format"
        '
        'RandomCheckBox
        '
        Me.RandomCheckBox.AutoSize = True
        Me.RandomCheckBox.Location = New System.Drawing.Point(68, 241)
        Me.RandomCheckBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RandomCheckBox.Name = "RandomCheckBox"
        Me.RandomCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.RandomCheckBox.TabIndex = 17
        Me.RandomCheckBox.Text = "Random"
        Me.RandomCheckBox.UseVisualStyleBackColor = True
        '
        'WhiteSpaceCheckBox
        '
        Me.WhiteSpaceCheckBox.AutoSize = True
        Me.WhiteSpaceCheckBox.Location = New System.Drawing.Point(68, 220)
        Me.WhiteSpaceCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.WhiteSpaceCheckBox.Name = "WhiteSpaceCheckBox"
        Me.WhiteSpaceCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.WhiteSpaceCheckBox.TabIndex = 18
        Me.WhiteSpaceCheckBox.Text = "White Space"
        Me.WhiteSpaceCheckBox.UseVisualStyleBackColor = True
        '
        'ReverseCheckBox
        '
        Me.ReverseCheckBox.AutoSize = True
        Me.ReverseCheckBox.Location = New System.Drawing.Point(68, 199)
        Me.ReverseCheckBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ReverseCheckBox.Name = "ReverseCheckBox"
        Me.ReverseCheckBox.Size = New System.Drawing.Size(66, 17)
        Me.ReverseCheckBox.TabIndex = 19
        Me.ReverseCheckBox.Text = "Reverse"
        Me.ReverseCheckBox.UseVisualStyleBackColor = True
        '
        'WindFormExampleForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.ReverseCheckBox)
        Me.Controls.Add(Me.WhiteSpaceCheckBox)
        Me.Controls.Add(Me.RandomCheckBox)
        Me.Controls.Add(Me.FormatGroupBox)
        Me.Controls.Add(Me.CaseGroupBox)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.AgeLabel)
        Me.Controls.Add(Me.LastTextBox)
        Me.Controls.Add(Me.LastLabel)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "WindFormExampleForm1"
        Me.Text = "Windows Form Example"
        Me.CaseGroupBox.ResumeLayout(False)
        Me.CaseGroupBox.PerformLayout()
        Me.FormatGroupBox.ResumeLayout(False)
        Me.FormatGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents FirstName As Label
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents LastTextBox As TextBox
    Friend WithEvents LastLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents UpperRadioButton As RadioButton
    Friend WithEvents LowerRadioButton As RadioButton
    Friend WithEvents FirstLastRadioButton As RadioButton
    Friend WithEvents LastFirstRadioButton As RadioButton
    Friend WithEvents CaseGroupBox As GroupBox
    Friend WithEvents FormatGroupBox As GroupBox
    Friend WithEvents RandomCheckBox As CheckBox
    Friend WithEvents WhiteSpaceCheckBox As CheckBox
    Friend WithEvents ReverseCheckBox As CheckBox
End Class
