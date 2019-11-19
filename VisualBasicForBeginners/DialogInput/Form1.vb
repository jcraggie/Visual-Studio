Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = InputBox("Please enter a Caption..", "Caption Selector", "Default Window Title")
    End Sub
End Class
