Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Sum.Text = Val(Num1.Text) + Val(Num2.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Sum.Text = "RESULT"
        Num1.Text = ""
        Num2.Text = ""

    End Sub
End Class
