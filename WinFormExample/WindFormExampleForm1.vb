'Header
Option Strict On
Option Explicit On
Option Compare Text
Public Class WindFormExampleForm1
    Sub clear()
        FirstTextBox.Text = ""
        LastTextBox.Text = ""
        AgeTextBox.Text = ""
    End Sub
    'event handlers ************************************************************************
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ' Me.Text = StrReverse(Me.Text)
        'Me.Text = "Racecar"
        Me.Text = FirstTextBox.Text & " " & LastTextBox.Text
        clear()
    End Sub
End Class
