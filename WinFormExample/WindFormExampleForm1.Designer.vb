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
        Me.CaseGroupBox.SuspendLayout()
        Me.FormatGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(639, 346)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(149, 92)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(484, 346)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(149, 92)
        Me.UpdateButton.TabIndex = 9
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(12, 30)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(72, 16)
        Me.FirstName.TabIndex = 2
        Me.FirstName.Text = "First Name"
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(90, 27)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(197, 22)
        Me.FirstTextBox.TabIndex = 0
        '
        'LastTextBox
        '
        Me.LastTextBox.Location = New System.Drawing.Point(90, 55)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(197, 22)
        Me.LastTextBox.TabIndex = 1
        '
        'LastLabel
        '
        Me.LastLabel.AutoSize = True
        Me.LastLabel.Location = New System.Drawing.Point(12, 58)
        Me.LastLabel.Name = "LastLabel"
        Me.LastLabel.Size = New System.Drawing.Size(72, 16)
        Me.LastLabel.TabIndex = 4
        Me.LastLabel.Text = "Last Name"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(90, 83)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(50, 22)
        Me.AgeTextBox.TabIndex = 2
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(52, 83)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(32, 16)
        Me.AgeLabel.TabIndex = 6
        Me.AgeLabel.Text = "Age"
        '
        'UpperRadioButton
        '
        Me.UpperRadioButton.AutoSize = True
        Me.UpperRadioButton.Location = New System.Drawing.Point(15, 21)
        Me.UpperRadioButton.Name = "UpperRadioButton"
        Me.UpperRadioButton.Size = New System.Drawing.Size(101, 20)
        Me.UpperRadioButton.TabIndex = 11
        Me.UpperRadioButton.TabStop = True
        Me.UpperRadioButton.Text = "Upper Case"
        Me.UpperRadioButton.UseVisualStyleBackColor = True
        '
        'LowerRadioButton
        '
        Me.LowerRadioButton.AutoSize = True
        Me.LowerRadioButton.Location = New System.Drawing.Point(15, 47)
        Me.LowerRadioButton.Name = "LowerRadioButton"
        Me.LowerRadioButton.Size = New System.Drawing.Size(99, 20)
        Me.LowerRadioButton.TabIndex = 12
        Me.LowerRadioButton.TabStop = True
        Me.LowerRadioButton.Text = "Lower Case"
        Me.LowerRadioButton.UseVisualStyleBackColor = True
        '
        'FirstLastRadioButton
        '
        Me.FirstLastRadioButton.AutoSize = True
        Me.FirstLastRadioButton.Location = New System.Drawing.Point(15, 21)
        Me.FirstLastRadioButton.Name = "FirstLastRadioButton"
        Me.FirstLastRadioButton.Size = New System.Drawing.Size(81, 20)
        Me.FirstLastRadioButton.TabIndex = 13
        Me.FirstLastRadioButton.TabStop = True
        Me.FirstLastRadioButton.Text = "First Last"
        Me.FirstLastRadioButton.UseVisualStyleBackColor = True
        '
        'LastFirstRadioButton
        '
        Me.LastFirstRadioButton.AutoSize = True
        Me.LastFirstRadioButton.Location = New System.Drawing.Point(15, 52)
        Me.LastFirstRadioButton.Name = "LastFirstRadioButton"
        Me.LastFirstRadioButton.Size = New System.Drawing.Size(81, 20)
        Me.LastFirstRadioButton.TabIndex = 14
        Me.LastFirstRadioButton.TabStop = True
        Me.LastFirstRadioButton.Text = "Last First"
        Me.LastFirstRadioButton.UseVisualStyleBackColor = True
        '
        'CaseGroupBox
        '
        Me.CaseGroupBox.Controls.Add(Me.UpperRadioButton)
        Me.CaseGroupBox.Controls.Add(Me.LowerRadioButton)
        Me.CaseGroupBox.Location = New System.Drawing.Point(90, 128)
        Me.CaseGroupBox.Name = "CaseGroupBox"
        Me.CaseGroupBox.Size = New System.Drawing.Size(124, 81)
        Me.CaseGroupBox.TabIndex = 15
        Me.CaseGroupBox.TabStop = False
        Me.CaseGroupBox.Text = "Case"
        '
        'FormatGroupBox
        '
        Me.FormatGroupBox.Controls.Add(Me.FirstLastRadioButton)
        Me.FormatGroupBox.Controls.Add(Me.LastFirstRadioButton)
        Me.FormatGroupBox.Location = New System.Drawing.Point(237, 128)
        Me.FormatGroupBox.Name = "FormatGroupBox"
        Me.FormatGroupBox.Size = New System.Drawing.Size(124, 81)
        Me.FormatGroupBox.TabIndex = 16
        Me.FormatGroupBox.TabStop = False
        Me.FormatGroupBox.Text = "Format"
        '
        'WindFormExampleForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
