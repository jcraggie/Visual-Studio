Public Class Form1
    Dim oXinput As Integer
    Dim oYinput As Integer
    Dim oZinput As Integer



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub









    Private Sub OverWorldXinput_Enter(sender As Object, e As EventArgs) Handles OverworldXinput.Enter
        OverworldXinput.SelectAll()
    End Sub

    Private Sub OverWorldYinput_Enter(sender As Object, e As EventArgs) Handles OverworldYinput.Enter
        OverworldYinput.SelectAll()
    End Sub

    Private Sub OverWorldZinput_Enter(sender As Object, e As EventArgs) Handles OverworldZinput.Enter
        OverworldZinput.SelectAll()
    End Sub

    Private Sub NetherXout_Enter(sender As Object, e As EventArgs) Handles NetherXoutput.Enter
        NetherXoutput.SelectAll()
    End Sub

    Private Sub NetherYoutput_Enter(sender As Object, e As EventArgs) Handles NetherYoutput.Enter
        NetherYoutput.SelectAll()
    End Sub

    Private Sub NetherZoutput_Enter(sender As Object, e As EventArgs) Handles NetherZoutput.Enter
        NetherZoutput.SelectAll()
    End Sub





    Private Sub OverWorldX_TextChanged(sender As Object, e As EventArgs) Handles OverworldXinput.TextChanged
        oXinput = Val(OverworldXinput.Text)
        NetherXoutput.Text = Math.Truncate(oXinput / 8)
    End Sub

    Private Sub OverworldYinput_TextChanged(sender As Object, e As EventArgs) Handles OverworldYinput.TextChanged
        oYinput = Val(OverworldYinput.Text)
        NetherYoutput.Text = oYinput
    End Sub

    Private Sub OverworldZinput_TextChanged(sender As Object, e As EventArgs) Handles OverworldZinput.TextChanged
        oZinput = Val(OverworldZinput.Text)
        NetherZoutput.Text = Math.Truncate(oZinput / 8)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
