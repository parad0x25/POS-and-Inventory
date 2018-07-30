<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserLog
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.posDataSet2 = New POS.posDataSet2
        Me.userlogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.userlogTableAdapter = New POS.posDataSet2TableAdapters.userlogTableAdapter
        CType(Me.posDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userlogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "posDataSet2_userlog"
        ReportDataSource1.Value = Me.userlogBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POS.UserLog.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(622, 463)
        Me.ReportViewer1.TabIndex = 0
        '
        'posDataSet2
        '
        Me.posDataSet2.DataSetName = "posDataSet2"
        Me.posDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'userlogBindingSource
        '
        Me.userlogBindingSource.DataMember = "userlog"
        Me.userlogBindingSource.DataSource = Me.posDataSet2
        '
        'userlogTableAdapter
        '
        Me.userlogTableAdapter.ClearBeforeFill = True
        '
        'UserLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 463)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserLog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Log"
        CType(Me.posDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userlogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents userlogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents posDataSet2 As POS.posDataSet2
    Friend WithEvents userlogTableAdapter As POS.posDataSet2TableAdapters.userlogTableAdapter
End Class
