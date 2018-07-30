<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDir = New System.Windows.Forms.Label
        Me.Progressbar1 = New POS.progressbar
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(149, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Checking :"
        '
        'lblDir
        '
        Me.lblDir.AutoSize = True
        Me.lblDir.BackColor = System.Drawing.Color.Transparent
        Me.lblDir.Location = New System.Drawing.Point(150, 125)
        Me.lblDir.Name = "lblDir"
        Me.lblDir.Size = New System.Drawing.Size(34, 13)
        Me.lblDir.TabIndex = 2
        Me.lblDir.Text = "Temp"
        '
        'Progressbar1
        '
        Me.Progressbar1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Progressbar1.BackgroundImage = CType(resources.GetObject("Progressbar1.BackgroundImage"), System.Drawing.Image)
        Me.Progressbar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Progressbar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Progressbar1.Location = New System.Drawing.Point(152, 140)
        Me.Progressbar1.Maximum = 100
        Me.Progressbar1.Name = "Progressbar1"
        Me.Progressbar1.Size = New System.Drawing.Size(370, 13)
        Me.Progressbar1.TabIndex = 0
        Me.Progressbar1.value = 0
        '
        'SplashScreen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(542, 158)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Progressbar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SplashScreen1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Progressbar1 As POS.progressbar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDir As System.Windows.Forms.Label

End Class
