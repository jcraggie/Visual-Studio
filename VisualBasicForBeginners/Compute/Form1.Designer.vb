﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Sum = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Second Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TOTAL"
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Location = New System.Drawing.Point(237, 9)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(19, 13)
        Me.Num1.TabIndex = 3
        Me.Num1.Text = "24"
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Location = New System.Drawing.Point(240, 50)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(19, 13)
        Me.Num2.TabIndex = 4
        Me.Num2.Text = "16"
        '
        'Sum
        '
        Me.Sum.AutoSize = True
        Me.Sum.Location = New System.Drawing.Point(240, 92)
        Me.Sum.Name = "Sum"
        Me.Sum.Size = New System.Drawing.Size(50, 13)
        Me.Sum.TabIndex = 5
        Me.Sum.Text = "RESULT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(240, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Sum)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Num1 As Label
    Friend WithEvents Num2 As Label
    Friend WithEvents Sum As Label
    Friend WithEvents Button1 As Button
End Class