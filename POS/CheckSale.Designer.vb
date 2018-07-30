<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckSale
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
        Me.saleslogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.posDataSet1 = New POS.posDataSet1
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.PosDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.saleslogTableAdapter = New POS.posDataSet1TableAdapters.saleslogTableAdapter
        Me.SaleslogBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.saleslogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.posDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SaleslogBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'saleslogBindingSource
        '
        Me.saleslogBindingSource.DataMember = "saleslog"
        Me.saleslogBindingSource.DataSource = Me.posDataSet1
        '
        'posDataSet1
        '
        Me.posDataSet1.DataSetName = "posDataSet1"
        Me.posDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "posDataSet1_saleslog"
        ReportDataSource1.Value = Me.saleslogBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POS.ReportSale.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(640, 401)
        Me.ReportViewer1.TabIndex = 0
        '
        'PosDataSet1BindingSource
        '
        Me.PosDataSet1BindingSource.DataSource = Me.posDataSet1
        Me.PosDataSet1BindingSource.Position = 0
        '
        'saleslogTableAdapter
        '
        Me.saleslogTableAdapter.ClearBeforeFill = True
        '
        'SaleslogBindingSource1
        '
        Me.SaleslogBindingSource1.DataMember = "saleslog"
        Me.SaleslogBindingSource1.DataSource = Me.PosDataSet1BindingSource
        '
        'CheckSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 401)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CheckSale"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CheckSale"
        CType(Me.saleslogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.posDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PosDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SaleslogBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents saleslogBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents posDataSet1 As POS.posDataSet1
    Friend WithEvents saleslogTableAdapter As POS.posDataSet1TableAdapters.saleslogTableAdapter
    Friend WithEvents PosDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaleslogBindingSource1 As System.Windows.Forms.BindingSource
End Class
