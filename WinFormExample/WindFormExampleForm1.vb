'Header
Option Strict On
Option Explicit On
Option Compare Text
Public Class WindFormExampleForm1
    Sub SetDefaults()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeTextBox.Text = ""
        UpperRadioButton.Checked = True
        FirstLastRadioButton.Checked = True
    End Sub

    Sub SetFormat()
        If FirstLastRadioButton.Checked = True Then
            Me.Text = FirstTextBox.Text & " " & LastTextBox.Text
        ElseIf LastFirstRadioButton.Checked = True Then
            Me.Text = $"{LastTextBox.Text}, {FirstTextBox.Text}"
        Else
            MsgBox($"Oh No! No Format Selected!")
        End If
    End Sub
    Sub SetCase()
        If UpperRadioButton.Checked = True Then
            Me.Text = UCase(FirstTextBox.Text & " " & LastTextBox.Text)
        ElseIf LowerRadioButton.Checked = True Then
            Me.Text = LCase(FirstTextBox.Text & " " & LastTextBox.Text)
        Else
            MsgBox($"Oh No! No Case Selected!")
        End If
    End Sub
    'Event Handlers ************************************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ' Me.Text = StrReverse(Me.Text)
        'Me.Text = "Racecar"
        SetCase()
        SetDefaults()
    End Sub

    Private Sub WindFormExampleForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub


End Class
