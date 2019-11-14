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
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtScrape = New System.Windows.Forms.TextBox()
        Me.txtFormatted = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(13, 13)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(75, 23)
        Me.btnExtract.TabIndex = 0
        Me.btnExtract.Text = "Extract"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(713, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtScrape
        '
        Me.txtScrape.Location = New System.Drawing.Point(13, 43)
        Me.txtScrape.Multiline = True
        Me.txtScrape.Name = "txtScrape"
        Me.txtScrape.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtScrape.Size = New System.Drawing.Size(775, 249)
        Me.txtScrape.TabIndex = 2
        '
        'txtFormatted
        '
        Me.txtFormatted.Location = New System.Drawing.Point(13, 299)
        Me.txtFormatted.Multiline = True
        Me.txtFormatted.Name = "txtFormatted"
        Me.txtFormatted.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFormatted.Size = New System.Drawing.Size(775, 233)
        Me.txtFormatted.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.txtFormatted)
        Me.Controls.Add(Me.txtScrape)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnExtract)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExtract As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtScrape As TextBox
    Friend WithEvents txtFormatted As TextBox
End Class
