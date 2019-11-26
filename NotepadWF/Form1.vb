Imports System.ComponentModel
Imports System.IO

Public Class Form1

    Public Shared Property TextHasChanged As Boolean = False

    Public Shared Property DocumentName As String = ""

    Public Shared Property SavePromptValue As String

    Public Shared Property MasterFont As Font

    Public Shared Property ZoomValue As Integer = 100





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
            TextBox1.ScrollBars = ScrollBars.Both
        Else
            WordWrapToolStripMenuItem.Checked = True
            TextBox1.WordWrap = True
            TextBox1.ScrollBars = ScrollBars.Vertical
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.Font = MasterFont


        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBox1.Font = FontDialog1.Font
            MasterFont = FontDialog1.Font
            ZoomValue = 100
            ZoomToolStripStatusLabel.Text = " " + (ZoomValue).ToString + "%"

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

        PositionToolStripStatusLabel.Text =
            "Ln " +
            (TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart) + 1).ToString() +
            ", Col " + (TextBox1.SelectionStart - TextBox1.GetFirstCharIndexFromLine(TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart)) + 1).ToString()


    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        My.Settings.MySize = Me.Size
        My.Settings.MyFont = MasterFont
        My.Settings.MyStatusBar = StatusStrip1.Visible
        My.Settings.MyWordWrap = WordWrapToolStripMenuItem.Checked



        My.Settings.Save()

        If TextHasChanged Then
            'SavePrompt.ShowDialog()
            Dim SavePrompt As DialogResult = MessageBox.Show("Do you want to save changes?", "NotepadWF", MessageBoxButtons.YesNoCancel)

            If SavePrompt = vbYes Then
                'display a save dialog here
                SaveFileDialog1.ShowDialog()
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
        If Not My.Settings.MySize.IsEmpty Then
            Me.Size = My.Settings.MySize
        End If

        TextBox1.Font = My.Settings.MyFont
        MasterFont = TextBox1.Font

        StatusStrip1.Visible = My.Settings.MyStatusBar
        StatusBarToolStripMenuItem.Checked = My.Settings.MyStatusBar

        TextBox1.WordWrap = My.Settings.MyWordWrap
        WordWrapToolStripMenuItem.Checked = My.Settings.MyWordWrap
        If TextBox1.WordWrap Then
            TextBox1.ScrollBars = ScrollBars.Vertical
        Else
            TextBox1.ScrollBars = ScrollBars.Both
        End If


        ZoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Plus"
        ZoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Minus"
        DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Del"



    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If DocumentName <> "" Then
            Try
                System.IO.File.WriteAllText(DocumentName, TextBox1.Text)
                TextHasChanged = False
                Me.Text = Me.Text.Replace("*", "")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

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

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        If TextHasChanged Then
            'SavePrompt.ShowDialog()
            Dim SavePrompt As DialogResult = MessageBox.Show("Do you want to save changes?", "NotepadWF", MessageBoxButtons.YesNoCancel)

            If SavePrompt = vbYes Then
                'display a save dialog here
                SaveFileDialog1.ShowDialog()
            ElseIf SavePrompt = vbNo Then
                TextBox1.Text = ""

            End If
        Else
            TextBox1.Text = ""
        End If
        TextHasChanged = False
        DocumentName = ""
        Me.Text = "Untitled - NotepadWF"

    End Sub

    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        If ZoomValue < 500 Then
            ZoomValue += 10
            TextBox1.Font = New Font(TextBox1.Font.Name, ((MasterFont.Size * ZoomValue) / 100))
            ZoomToolStripStatusLabel.Text = " " + (ZoomValue).ToString + "%"
        End If
    End Sub

    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        If ZoomValue > 10 Then
            ZoomValue -= 10
            TextBox1.Font = New Font(TextBox1.Font.Name, ((MasterFont.Size * ZoomValue) / 100))
            ZoomToolStripStatusLabel.Text = " " + (ZoomValue).ToString + "%"

        End If
    End Sub

    Private Sub RestoreDefaultZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDefaultZoomToolStripMenuItem.Click
        'TextBox1.Font = New Font(TextBox1.Font.Name, 12)
        TextBox1.Font = MasterFont
        ZoomToolStripStatusLabel.Text = " 100%"
        ZoomValue = 100
    End Sub

    Private Sub AboutNotepadWFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutNotepadWFToolStripMenuItem.Click
        AboutBox1.ShowDialog()


    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        TextBox1.Undo()

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()

    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox1.Paste()

    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        TextBox1.SelectAll()

    End Sub

    Private Sub SearchWithBingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchWithBingToolStripMenuItem.Click
        'Process.Start("https://www.bing.com/search?q=" + TextBox1.SelectedText)
        Try
            If TextBox1.SelectedText <> "" Then
                Process.Start("https://www.bing.com/search?q=" + TextBox1.SelectedText)
            Else
                Process.Start("https://www.bing.com")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        TextBox1.SelectedText = Now.ToShortTimeString + " " + Now.ToShortDateString
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        SendKeys.Send("{DEL}")
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp

    End Sub
End Class
