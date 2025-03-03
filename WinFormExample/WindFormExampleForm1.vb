'Header
Option Strict On
Option Explicit On
Option Compare Text
Public Class WindFormExampleForm1
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Text = StrReverse(Me.Text)
        'Me.Text = "Racecar"
    End Sub
End Class
