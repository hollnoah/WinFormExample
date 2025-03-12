'Header
Option Strict On
Option Explicit On
Option Compare Text

'tool tips
'accept & cancel buttons
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
        RemoveButton.enabled = False

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

    Sub Scramble()
        Dim temp As String = FirstTextBox.Text
        Dim letters(Len(FirstTextBox.Text)) As String

        For i = 0 To UBound(letters)
            letters(i) = FirstTextBox.Text
        Next


        If RandomCheckBox.Checked Then

            Console.WriteLine($"The third letter is: {temp(2)}")
            For i = 0 To Len(temp) - 1
                Console.WriteLine($"Letter {i + 1} is: {temp(i)}")

            Next
        End If

        'For Each thingy In temp
        '    Randomize()

        'Next

    End Sub

    Sub AddToList(thisString As String)
        DataListBox1.Items.Add(thisString)
    End Sub

    'Event Handlers ************************************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If UserInputIsValid() Then
            Scramble()
            SetCase()
            SetFormat()
            ReverseString()
            RemoveWhiteSpace()
            AddToList(Me.Text)
            SetDefaults()
        End If
    End Sub

    Private Sub WindFormExampleForm1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Private Sub DataListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataListBox1.SelectedIndexChanged
        Me.Text = DataListBox1.SelectedIndex.ToString
        If DataListBox1.SelectedIndex = -1 Then
            RemoveButton.Enabled = False
        Else
            RemoveButton.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        ' Console.WriteLine($"The item at index {DataListBox1.SelectedIndex} is {DataListBox1.SelectedItem}!")
        DataListBox1.Items.RemoveAt(DataListBox1.SelectedIndex)
    End Sub
End Class
