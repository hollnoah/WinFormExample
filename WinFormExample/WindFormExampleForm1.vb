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
        ReverseCheckBox.Checked = False
        WhiteSpaceCheckBox.Checked = False
        RandomCheckBox.Checked = False
        FirstTextBox.Focus() 'sets cursor priority to first text box

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
            FirstTextBox.Text = UCase(FirstTextBox.Text)
            LastTextBox.Text = UCase(LastTextBox.Text)
        ElseIf LowerRadioButton.Checked = True Then
            Me.Text = LCase(FirstTextBox.Text & " " & LastTextBox.Text)
        Else
            MsgBox($"Oh No! No Case Selected!")
        End If
    End Sub

    Sub ReverseString()
        If ReverseCheckBox.Checked Then
            Me.Text = StrReverse(Me.Text)
        End If
    End Sub

    Sub RemoveWhiteSpace()
        If WhiteSpaceCheckBox.Checked Then
            Me.Text = Replace(Me.Text, " ", "")
        End If
    End Sub

    Function UserInputIsValid() As Boolean
        Dim valid As Boolean = True
        Dim message As String
        If IsNumeric(AgeTextBox.Text) = False Then
            valid = False
            AgeTextBox.Focus()
            message &= "Please enter a valid age." & vbNewLine
        End If

        If LastTextBox.Text = "" Then
            valid = False
            LastTextBox.Focus()
            message &= "Last name is required." & vbNewLine

        End If

        If FirstTextBox.Text = "" Then
            valid = False
            FirstTextBox.Focus()
            message &= "First name is required." & vbNewLine

        End If

        If valid = False Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!!!")
        End If
        Return True
    End Function

    'Event Handlers ************************************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If UserInputIsValid() Then
            SetCase()
            SetFormat()
            ReverseString()
            RemoveWhiteSpace()
            SetDefaults()
        End If
    End Sub

    Private Sub WindFormExampleForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub


End Class
