Public Class Form1
    Dim val1 As Integer 'use as a test2


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OverWorldX_TextChanged(sender As Object, e As EventArgs) Handles OverWorldX.TextChanged
        val1 = Val(OverWorldX.Text)
        TestText1.Text = Math.Truncate(val1 / 8)
    End Sub
End Class
