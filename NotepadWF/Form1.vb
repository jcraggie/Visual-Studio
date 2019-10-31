Imports System.ComponentModel
Imports System.IO

Public Class Form1

    Public Shared Property TextHasChanged As Boolean = False

    Public Shared Property DocumentName As String = ""

    Public Shared Property SavePromptValue As String



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Application.Exit()
        Me.Close()
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
                TextHasChanged = False
                DocumentName = OpenFileDialog1.FileName
            Catch ex As Exception
                MessageBox.Show("Something Happened.")
            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'TextHasChanged = True
        ''Me.Text = "*" + Me.Text
        'If Me.Text.Substring(0, 1) <> "*" Then
        '    Me.Text = "*" + Me.Text
        'End If

        If TextHasChanged = False Then
            Me.Text = "*" + Me.Text
            TextHasChanged = True
        End If

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If TextHasChanged Then
            'SavePrompt.ShowDialog()
            Dim SavePrompt As DialogResult = MessageBox.Show("Do you want to save changes?", "NotepadWF", MessageBoxButtons.YesNoCancel)

            If SavePrompt = vbYes Then
                'display a save dialog here
            ElseIf SavePrompt = vbNo Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        Else
            Application.Exit()
            'Select Case SavePromptValue
            '    Case "Save"
            '        'more soon
            '    Case "DontSave"
            '        Application.Exit()
            '    Case Else
            '        e.Cancel = True

            'End Select

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TextHasChanged = False
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If DocumentName <> "" Then
            System.IO.File.WriteAllText(DocumentName, TextBox1.Text)
            TextHasChanged = False
            Me.Text = Me.Text.Replace("*", "")
        Else
            'call SaveAs event handler
            SaveAsToolStripMenuItem_Click(sender, e) 'sender and e are not used but are required
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As CancelEventArgs) Handles SaveFileDialog1.FileOk
        Try
            DocumentName = SaveFileDialog1.FileName
            Me.Text = System.IO.Path.GetFileNameWithoutExtension(DocumentName) + "- NotepadWF"
            TextHasChanged = False
            System.IO.File.WriteAllText(DocumentName, TextBox1.Text)
        Catch ex As Exception
            MessageBox.Show("Something has happened..")
        End Try
    End Sub
End Class
