Imports System.IO

Public Class Form1

    Public Shared Property TextHasChanged As Boolean


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        If StatusBarToolStripMenuItem.Checked Then
            StatusStrip1.Hide()
            StatusBarToolStripMenuItem.Checked = False
        Else
            StatusStrip1.Show()
            StatusBarToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.Checked Then
            WordWrapToolStripMenuItem.Checked = False
            TextBox1.WordWrap = False
        Else
            WordWrapToolStripMenuItem.Checked = True
            TextBox1.WordWrap = True
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font

        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                TextBox1.Text = File.ReadAllText(OpenFileDialog1.FileName)
                Me.Text = OpenFileDialog1.SafeFileName + "- NotepadWF"

            Catch ex As Exception
                MessageBox.Show("Something Happened.")
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextHasChanged = True
        'Me.Text = "*" + Me.Text
        If Me.Text.Substring(0, 1) <> "*" Then
            Me.Text = "*" + Me.Text
        End If

    End Sub
End Class
