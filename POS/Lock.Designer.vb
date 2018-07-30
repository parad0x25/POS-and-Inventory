<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lock
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblChange = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(110, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "(Enter) OK"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Red
        Me.Label37.Location = New System.Drawing.Point(17, 67)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(39, 37)
        Me.Label37.TabIndex = 25
        Me.Label37.Text = "₱"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(96, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 33)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Change"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblChange
        '
        Me.lblChange.BackColor = System.Drawing.Color.Silver
        Me.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblChange.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblChange.ForeColor = System.Drawing.Color.Red
        Me.lblChange.Location = New System.Drawing.Point(58, 61)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.ReadOnly = True
        Me.lblChange.Size = New System.Drawing.Size(194, 46)
        Me.lblChange.TabIndex = 26
        Me.lblChange.Text = "0"
        Me.lblChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(332, 158)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(400, 300)
        Me.Name = "Lock"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblChange As System.Windows.Forms.TextBox
End Class
