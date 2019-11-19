Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Yellow
        Label1.Text = "Initialized Text"
        Me.BackColor = Color.Blue
        Me.Text = "Initialized Caption"
    End Sub
End Class
