<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OverworldXinput = New System.Windows.Forms.TextBox()
        Me.NetherXoutput = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LabelNC1 = New System.Windows.Forms.Label()
        Me.LabelOWC1 = New System.Windows.Forms.Label()
        Me.OverworldZinput = New System.Windows.Forms.TextBox()
        Me.OverworldYinput = New System.Windows.Forms.TextBox()
        Me.NetherZoutput = New System.Windows.Forms.TextBox()
        Me.NetherYoutput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1879, 40)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 44)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'OverworldXinput
        '
        Me.OverworldXinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OverworldXinput.Font = New System.Drawing.Font("Cascadia Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverworldXinput.Location = New System.Drawing.Point(50, 184)
        Me.OverworldXinput.Name = "OverworldXinput"
        Me.OverworldXinput.Size = New System.Drawing.Size(363, 84)
        Me.OverworldXinput.TabIndex = 0
        Me.OverworldXinput.Text = "0"
        Me.OverworldXinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NetherXoutput
        '
        Me.NetherXoutput.BackColor = System.Drawing.Color.White
        Me.NetherXoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetherXoutput.Font = New System.Drawing.Font("Cascadia Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetherXoutput.ForeColor = System.Drawing.Color.Red
        Me.NetherXoutput.Location = New System.Drawing.Point(50, 470)
        Me.NetherXoutput.Name = "NetherXoutput"
        Me.NetherXoutput.ReadOnly = True
        Me.NetherXoutput.Size = New System.Drawing.Size(363, 84)
        Me.NetherXoutput.TabIndex = 3
        Me.NetherXoutput.Text = "0"
        Me.NetherXoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1799, 898)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LabelNC1)
        Me.TabPage1.Controls.Add(Me.LabelOWC1)
        Me.TabPage1.Controls.Add(Me.OverworldZinput)
        Me.TabPage1.Controls.Add(Me.OverworldYinput)
        Me.TabPage1.Controls.Add(Me.OverworldXinput)
        Me.TabPage1.Controls.Add(Me.NetherZoutput)
        Me.TabPage1.Controls.Add(Me.NetherYoutput)
        Me.TabPage1.Controls.Add(Me.NetherXoutput)
        Me.TabPage1.Location = New System.Drawing.Point(8, 39)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1783, 851)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Calc"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LabelNC1
        '
        Me.LabelNC1.BackColor = System.Drawing.Color.White
        Me.LabelNC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelNC1.Font = New System.Drawing.Font("Cascadia Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNC1.ForeColor = System.Drawing.Color.Red
        Me.LabelNC1.Location = New System.Drawing.Point(50, 357)
        Me.LabelNC1.Name = "LabelNC1"
        Me.LabelNC1.Size = New System.Drawing.Size(1101, 98)
        Me.LabelNC1.TabIndex = 4
        Me.LabelNC1.Text = "NETHER COORDINATES"
        Me.LabelNC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelOWC1
        '
        Me.LabelOWC1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelOWC1.Font = New System.Drawing.Font("Cascadia Code", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOWC1.Location = New System.Drawing.Point(50, 70)
        Me.LabelOWC1.Name = "LabelOWC1"
        Me.LabelOWC1.Size = New System.Drawing.Size(1101, 98)
        Me.LabelOWC1.TabIndex = 0
        Me.LabelOWC1.Text = "OVERWORLD COORDINATES"
        Me.LabelOWC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OverworldZinput
        '
        Me.OverworldZinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OverworldZinput.Font = New System.Drawing.Font("Cascadia Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverworldZinput.Location = New System.Drawing.Point(788, 184)
        Me.OverworldZinput.Name = "OverworldZinput"
        Me.OverworldZinput.Size = New System.Drawing.Size(363, 84)
        Me.OverworldZinput.TabIndex = 2
        Me.OverworldZinput.Text = "0"
        Me.OverworldZinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OverworldYinput
        '
        Me.OverworldYinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OverworldYinput.Font = New System.Drawing.Font("Cascadia Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OverworldYinput.Location = New System.Drawing.Point(419, 184)
        Me.OverworldYinput.Name = "OverworldYinput"
        Me.OverworldYinput.Size = New System.Drawing.Size(363, 84)
        Me.OverworldYinput.TabIndex = 1
        Me.OverworldYinput.Text = "0"
        Me.OverworldYinput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NetherZoutput
        '
        Me.NetherZoutput.BackColor = System.Drawing.Color.White
        Me.NetherZoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetherZoutput.Font = New System.Drawing.Font("Cascadia Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetherZoutput.ForeColor = System.Drawing.Color.Red
        Me.NetherZoutput.Location = New System.Drawing.Point(788, 470)
        Me.NetherZoutput.Name = "NetherZoutput"
        Me.NetherZoutput.ReadOnly = True
        Me.NetherZoutput.Size = New System.Drawing.Size(363, 84)
        Me.NetherZoutput.TabIndex = 5
        Me.NetherZoutput.Text = "0"
        Me.NetherZoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NetherYoutput
        '
        Me.NetherYoutput.BackColor = System.Drawing.Color.White
        Me.NetherYoutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NetherYoutput.Font = New System.Drawing.Font("Cascadia Code", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetherYoutput.ForeColor = System.Drawing.Color.Red
        Me.NetherYoutput.Location = New System.Drawing.Point(419, 470)
        Me.NetherYoutput.Name = "NetherYoutput"
        Me.NetherYoutput.ReadOnly = True
        Me.NetherYoutput.Size = New System.Drawing.Size(363, 84)
        Me.NetherYoutput.TabIndex = 4
        Me.NetherYoutput.Text = "0"
        Me.NetherYoutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1879, 1001)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "jcrAggie's Minecraft Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OverworldXinput As TextBox
    Friend WithEvents NetherXoutput As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LabelOWC1 As Label
    Friend WithEvents LabelNC1 As Label
    Friend WithEvents OverworldYinput As TextBox
    Friend WithEvents OverworldZinput As TextBox
    Friend WithEvents NetherZoutput As TextBox
    Friend WithEvents NetherYoutput As TextBox
End Class
