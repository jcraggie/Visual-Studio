﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SearchWithBingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackOnWhiteDefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackOnLightGrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AmberOnBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenOnBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectTextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectBackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZoomOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDefaultZoomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutNotepadWFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.AutoSaveToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PositionToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ZoomToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.ZoomContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Percent250 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent125 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent75 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Percent50 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AutoSaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ZoomContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ViewToolStripMenuItem1, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(1075, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.NewWindowToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.AutoSaveToolStripMenuItem, Me.ToolStripSeparator1, Me.PageSetupToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ToolStripSeparator6, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NewWindowToolStripMenuItem.Text = "New &Window"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(217, 6)
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Set&up"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(217, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.ToolStripSeparator2, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator3, Me.SearchWithBingToolStripMenuItem, Me.ToolStripSeparator4, Me.SelectAllToolStripMenuItem, Me.TimeDateToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(208, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(208, 6)
        '
        'SearchWithBingToolStripMenuItem
        '
        Me.SearchWithBingToolStripMenuItem.Name = "SearchWithBingToolStripMenuItem"
        Me.SearchWithBingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.SearchWithBingToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SearchWithBingToolStripMenuItem.Text = "&Search with Bing..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(208, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'TimeDateToolStripMenuItem
        '
        Me.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem"
        Me.TimeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.TimeDateToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.TimeDateToolStripMenuItem.Text = "Time/&Date"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WordWrapToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(57, 22)
        Me.ViewToolStripMenuItem.Text = "F&ormat"
        '
        'WordWrapToolStripMenuItem
        '
        Me.WordWrapToolStripMenuItem.Checked = True
        Me.WordWrapToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
        Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.WordWrapToolStripMenuItem.Text = "&Word Wrap"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ViewToolStripMenuItem1
        '
        Me.ViewToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ZoomToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewToolStripMenuItem1.Name = "ViewToolStripMenuItem1"
        Me.ViewToolStripMenuItem1.Size = New System.Drawing.Size(44, 22)
        Me.ViewToolStripMenuItem1.Text = "&View"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlackOnWhiteDefaultToolStripMenuItem, Me.BlackOnLightGrayToolStripMenuItem, Me.AmberOnBlackToolStripMenuItem, Me.GreenOnBlackToolStripMenuItem, Me.ToolStripSeparator5, Me.SelectTextColorToolStripMenuItem, Me.SelectBackgroundColorToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.ToolStripMenuItem1.Text = "&Theme"
        '
        'BlackOnWhiteDefaultToolStripMenuItem
        '
        Me.BlackOnWhiteDefaultToolStripMenuItem.Name = "BlackOnWhiteDefaultToolStripMenuItem"
        Me.BlackOnWhiteDefaultToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.BlackOnWhiteDefaultToolStripMenuItem.Text = "Black on &White (Default)"
        '
        'BlackOnLightGrayToolStripMenuItem
        '
        Me.BlackOnLightGrayToolStripMenuItem.Name = "BlackOnLightGrayToolStripMenuItem"
        Me.BlackOnLightGrayToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.BlackOnLightGrayToolStripMenuItem.Text = "Black on &Light Gray"
        '
        'AmberOnBlackToolStripMenuItem
        '
        Me.AmberOnBlackToolStripMenuItem.Name = "AmberOnBlackToolStripMenuItem"
        Me.AmberOnBlackToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AmberOnBlackToolStripMenuItem.Text = "&Amber on Black"
        '
        'GreenOnBlackToolStripMenuItem
        '
        Me.GreenOnBlackToolStripMenuItem.Name = "GreenOnBlackToolStripMenuItem"
        Me.GreenOnBlackToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.GreenOnBlackToolStripMenuItem.Text = "&Green on Black"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(210, 6)
        '
        'SelectTextColorToolStripMenuItem
        '
        Me.SelectTextColorToolStripMenuItem.Name = "SelectTextColorToolStripMenuItem"
        Me.SelectTextColorToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SelectTextColorToolStripMenuItem.Text = "Select &Text Color..."
        '
        'SelectBackgroundColorToolStripMenuItem
        '
        Me.SelectBackgroundColorToolStripMenuItem.Name = "SelectBackgroundColorToolStripMenuItem"
        Me.SelectBackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.SelectBackgroundColorToolStripMenuItem.Text = "Select &Background Color..."
        '
        'ZoomToolStripMenuItem
        '
        Me.ZoomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInToolStripMenuItem, Me.ZoomOutToolStripMenuItem, Me.RestoreDefaultZoomToolStripMenuItem})
        Me.ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        Me.ZoomToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ZoomToolStripMenuItem.Text = "&Zoom"
        '
        'ZoomInToolStripMenuItem
        '
        Me.ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        Me.ZoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Plus"
        Me.ZoomInToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Oemplus), System.Windows.Forms.Keys)
        Me.ZoomInToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ZoomInToolStripMenuItem.Text = "Zoom &In"
        '
        'ZoomOutToolStripMenuItem
        '
        Me.ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        Me.ZoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Minus"
        Me.ZoomOutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.OemMinus), System.Windows.Forms.Keys)
        Me.ZoomOutToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.ZoomOutToolStripMenuItem.Text = "Zoom &Out"
        '
        'RestoreDefaultZoomToolStripMenuItem
        '
        Me.RestoreDefaultZoomToolStripMenuItem.Name = "RestoreDefaultZoomToolStripMenuItem"
        Me.RestoreDefaultZoomToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.RestoreDefaultZoomToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.RestoreDefaultZoomToolStripMenuItem.Text = "&Restore Default Zoom"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutNotepadWFToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutNotepadWFToolStripMenuItem
        '
        Me.AboutNotepadWFToolStripMenuItem.Name = "AboutNotepadWFToolStripMenuItem"
        Me.AboutNotepadWFToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AboutNotepadWFToolStripMenuItem.Text = "&About NotepadWF"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoSaveToolStripStatusLabel, Me.PositionToolStripStatusLabel, Me.ZoomToolStripStatusLabel, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1075, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'AutoSaveToolStripStatusLabel
        '
        Me.AutoSaveToolStripStatusLabel.Name = "AutoSaveToolStripStatusLabel"
        Me.AutoSaveToolStripStatusLabel.Size = New System.Drawing.Size(219, 19)
        Me.AutoSaveToolStripStatusLabel.Spring = True
        Me.AutoSaveToolStripStatusLabel.Text = " Auto Save: OFF"
        Me.AutoSaveToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PositionToolStripStatusLabel
        '
        Me.PositionToolStripStatusLabel.AutoSize = False
        Me.PositionToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.PositionToolStripStatusLabel.Name = "PositionToolStripStatusLabel"
        Me.PositionToolStripStatusLabel.Size = New System.Drawing.Size(100, 19)
        Me.PositionToolStripStatusLabel.Text = "Ln 1, Col 1"
        Me.PositionToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ZoomToolStripStatusLabel
        '
        Me.ZoomToolStripStatusLabel.AutoSize = False
        Me.ZoomToolStripStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ZoomToolStripStatusLabel.Name = "ZoomToolStripStatusLabel"
        Me.ZoomToolStripStatusLabel.Size = New System.Drawing.Size(130, 19)
        Me.ZoomToolStripStatusLabel.Text = " 100%"
        Me.ZoomToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.AutoSize = False
        Me.ToolStripStatusLabel4.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(300, 19)
        Me.ToolStripStatusLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.AutoSize = False
        Me.ToolStripStatusLabel5.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(280, 19)
        Me.ToolStripStatusLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 24)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1075, 402)
        Me.TextBox1.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text Documents (*.txt)|*.txt|All Files (*.*)|*.*"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "Text documents (*.txt)|*.txt"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ZoomContextMenuStrip
        '
        Me.ZoomContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Percent250, Me.Percent125, Me.Percent100, Me.Percent75, Me.Percent50})
        Me.ZoomContextMenuStrip.Name = "ZoomContextMenuStrip"
        Me.ZoomContextMenuStrip.Size = New System.Drawing.Size(103, 114)
        '
        'Percent250
        '
        Me.Percent250.Name = "Percent250"
        Me.Percent250.Size = New System.Drawing.Size(102, 22)
        Me.Percent250.Text = "250%"
        '
        'Percent125
        '
        Me.Percent125.Name = "Percent125"
        Me.Percent125.Size = New System.Drawing.Size(102, 22)
        Me.Percent125.Text = "125%"
        '
        'Percent100
        '
        Me.Percent100.Name = "Percent100"
        Me.Percent100.Size = New System.Drawing.Size(102, 22)
        Me.Percent100.Text = "100%"
        '
        'Percent75
        '
        Me.Percent75.Name = "Percent75"
        Me.Percent75.Size = New System.Drawing.Size(102, 22)
        Me.Percent75.Text = "75%"
        '
        'Percent50
        '
        Me.Percent50.Name = "Percent50"
        Me.Percent50.Size = New System.Drawing.Size(102, 22)
        Me.Percent50.Text = "50%"
        '
        'Timer1
        '
        Me.Timer1.Interval = 30000
        '
        'AutoSaveToolStripMenuItem
        '
        Me.AutoSaveToolStripMenuItem.Name = "AutoSaveToolStripMenuItem"
        Me.AutoSaveToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.AutoSaveToolStripMenuItem.Text = "Auto Sa&ve"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.NotepadWF.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = Global.NotepadWF.My.MySettings.Default.MyLocation
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Untitled - NotepadWF"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ZoomContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents AutoSaveToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents PositionToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ZoomToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreDefaultZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutNotepadWFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SearchWithBingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BlackOnWhiteDefaultToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlackOnLightGrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AmberOnBlackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreenOnBlackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents SelectTextColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectBackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ZoomContextMenuStrip As ContextMenuStrip
    Friend WithEvents Percent250 As ToolStripMenuItem
    Friend WithEvents Percent125 As ToolStripMenuItem
    Friend WithEvents Percent100 As ToolStripMenuItem
    Friend WithEvents Percent75 As ToolStripMenuItem
    Friend WithEvents Percent50 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AutoSaveToolStripMenuItem As ToolStripMenuItem
End Class
