Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtValue.Text = MsgBox("Click any button", vbYesNoCancel + vbQuestion)
    End Sub
End Class
