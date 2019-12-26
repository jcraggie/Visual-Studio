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

        'PositionToolStripStatusLabel.Text =
        '    "Ln " +
        '    (TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart) + 1).ToString() +
        '    ", Col " + (TextBox1.SelectionStart - TextBox1.GetFirstCharIndexFromLine(TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart)) + 1).ToString()

        ChangePositionToolStripStatusLabel()

    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        My.Settings.MySize = Me.Size
        My.Settings.MyFont = MasterFont
        My.Settings.MyStatusBar = StatusStrip1.Visible
        My.Settings.MyWordWrap = WordWrapToolStripMenuItem.Checked
        My.Settings.TextColor = TextBox1.ForeColor
        My.Settings.BackgroundColor = TextBox1.BackColor
        My.Settings.MyAutoSave = AutoSaveToolStripMenuItem.Checked





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

        TextBox1.ForeColor = My.Settings.TextColor
        TextBox1.BackColor = My.Settings.BackgroundColor

        StatusStrip1.Visible = My.Settings.MyStatusBar
        StatusBarToolStripMenuItem.Checked = My.Settings.MyStatusBar

        TextBox1.WordWrap = My.Settings.MyWordWrap
        WordWrapToolStripMenuItem.Checked = My.Settings.MyWordWrap
        If TextBox1.WordWrap Then
            TextBox1.ScrollBars = ScrollBars.Vertical
        Else
            TextBox1.ScrollBars = ScrollBars.Both
        End If

        AutoSaveToolStripMenuItem.Checked = My.Settings.MyAutoSave
        If AutoSaveToolStripMenuItem.Checked Then
            Timer1.Enabled = True
            AutoSaveToolStripStatusLabel.Text = " Auto Save: ON"
        Else
            Timer1.Enabled = False
            AutoSaveToolStripStatusLabel.Text = " Auto Save: OFF"
        End If


        ZoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Plus"
        ZoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Minus"
        DeleteToolStripMenuItem.ShortcutKeyDisplayString = "Del"

        PageSetupDialog1.PageSettings = New Printing.PageSettings
        PageSetupDialog1.PrinterSettings = New Printing.PrinterSettings



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
        PositionToolStripStatusLabel.Text =
            "Ln " +
            (TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart) + 1).ToString() +
            ", Col " + (TextBox1.SelectionStart - TextBox1.GetFirstCharIndexFromLine(TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart)) + 1).ToString()

    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        'PositionToolStripStatusLabel.Text =
        '    "Ln " +
        '    (TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart) + 1).ToString() +
        '    ", Col " + (TextBox1.SelectionStart - TextBox1.GetFirstCharIndexFromLine(TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart)) + 1).ToString()

        ChangePositionToolStripStatusLabel()

    End Sub

    Private Sub BlackOnWhiteDefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackOnWhiteDefaultToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Black
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub BlackOnLightGrayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackOnLightGrayToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Black
        TextBox1.BackColor = Color.LightGray
    End Sub

    Private Sub AmberOnBlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AmberOnBlackToolStripMenuItem.Click
        TextBox1.ForeColor = Color.Orange
        TextBox1.BackColor = Color.Black
    End Sub

    Private Sub GreenOnBlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenOnBlackToolStripMenuItem.Click
        TextBox1.ForeColor = Color.LightGreen
        TextBox1.BackColor = Color.Black
    End Sub

    Private Sub SelectTextColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectTextColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = vbOK Then
            TextBox1.ForeColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub SelectBackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectBackgroundColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog = vbOK Then
            TextBox1.BackColor = ColorDialog1.Color

        End If
    End Sub

    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Process.Start(System.Reflection.Assembly.GetEntryAssembly().Location)
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        If PageSetupDialog1.ShowDialog = vbOK Then
            '
            PrintDocument1.DefaultPageSettings.PaperSize = PageSetupDialog1.PageSettings.PaperSize
            PrintDocument1.DefaultPageSettings.Landscape = PageSetupDialog1.PageSettings.Landscape
            PrintDocument1.DefaultPageSettings.Margins = PageSetupDialog1.PageSettings.Margins

        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog() = vbOK Then
            '
            PrintDialog1.Document = PrintDocument1
            PrintDocument1.DocumentName = TextBox1.Text

            AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintPageHandler

            PrintDocument1.Print()

        End If
    End Sub

    Private Sub PrintPageHandler(ByVal sender As Object, ByVal args As Printing.PrintPageEventArgs)
        Dim MyPoint As New Point(PrintDocument1.DefaultPageSettings.Margins.Top, PrintDocument1.DefaultPageSettings.Margins.Left)
        args.Graphics.DrawString(TextBox1.Text, TextBox1.Font, Brushes.Black, MyPoint)
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        ChangePositionToolStripStatusLabel()
    End Sub

    Private Sub ChangePositionToolStripStatusLabel()
        PositionToolStripStatusLabel.Text =
            "Ln " +
            (TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart) + 1).ToString() +
            ", Col " +
            (TextBox1.SelectionStart - TextBox1.GetFirstCharIndexFromLine(TextBox1.GetLineFromCharIndex(TextBox1.SelectionStart)) + 1).ToString()
    End Sub

    Private Sub ZoomToolStripStatusLabel_MouseUp(sender As Object, e As EventArgs) Handles ZoomToolStripStatusLabel.MouseUp
        ZoomContextMenuStrip.Show(Cursor.Position)

    End Sub

    Private Sub Percent250_Click(sender As Object, e As EventArgs) Handles Percent250.Click
        ZoomValue = 250
        ChangeZoom()
    End Sub

    Private Sub Percent125_Click(sender As Object, e As EventArgs) Handles Percent125.Click
        ZoomValue = 125
        ChangeZoom()
    End Sub

    Private Sub Percent100_Click(sender As Object, e As EventArgs) Handles Percent100.Click
        ZoomValue = 100
        ChangeZoom()
    End Sub

    Private Sub Percent75_Click(sender As Object, e As EventArgs) Handles Percent75.Click
        ZoomValue = 75
        ChangeZoom()
    End Sub

    Private Sub Percent50_Click(sender As Object, e As EventArgs) Handles Percent50.Click
        ZoomValue = 50
        ChangeZoom()
    End Sub

    Private Sub ChangeZoom()
        TextBox1.Font = New Font(TextBox1.Font.Name, ((MasterFont.Size * ZoomValue) / 100))
        ZoomToolStripStatusLabel.Text = " " + (ZoomValue).ToString + "%"
    End Sub

    Private Sub AutoSaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutoSaveToolStripMenuItem.Click
        If AutoSaveToolStripMenuItem.Checked Then
            If MessageBox.Show(Me, "Click OK to disable Auto Save.", "Disable Auto Save", vbOKCancel) = vbOK Then
                AutoSaveToolStripMenuItem.Checked = False
                AutoSaveToolStripStatusLabel.Text = " Auto Save: OFF"
                Timer1.Enabled = False
            End If
        Else
            If MessageBox.Show(Me, "Click OK to automatically save your document every 30 seconds.", "Enable Auto Save", vbOKCancel) = vbOK Then
                Timer1.Enabled = False
                AutoSaveToolStripMenuItem.Checked = True
                AutoSaveToolStripStatusLabel.Text = " Auto Save: ON"
                Timer1.Enabled = True
            End If
        End If

    End Sub

    Private Sub AutoSaveToolStripStatusLabel_Click(sender As Object, e As EventArgs) Handles AutoSaveToolStripStatusLabel.Click
        AutoSaveToolStripMenuItem_Click(sender, e)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TextHasChanged Then
            SaveToolStripMenuItem_Click(sender, e)
        End If
    End Sub
End Class
