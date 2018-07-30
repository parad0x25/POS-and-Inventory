<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryReport1
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource
        Me.ProductBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.posDataSet = New POS.posDataSet
        Me.productBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.productTableAdapter = New POS.posDataSetTableAdapters.productTableAdapter
        Me.ProductBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer
        Me.Delivery1 = New POS.Delivery1
        Me.ProductBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter1 = New POS.Delivery1TableAdapters.productTableAdapter
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.posDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delivery1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductBindingSource1
        '
        Me.ProductBindingSource1.DataMember = "product"
        Me.ProductBindingSource1.DataSource = Me.PosDataSetBindingSource
        '
        'PosDataSetBindingSource
        '
        Me.PosDataSetBindingSource.DataSource = Me.posDataSet
        Me.PosDataSetBindingSource.Position = 0
        '
        'posDataSet
        '
        Me.posDataSet.DataSetName = "posDataSet"
        Me.posDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'productBindingSource
        '
        Me.productBindingSource.DataMember = "product"
        Me.productBindingSource.DataSource = Me.posDataSet
        '
        'productTableAdapter
        '
        Me.productTableAdapter.ClearBeforeFill = True
        '
        'ProductBindingSource2
        '
        Me.ProductBindingSource2.DataMember = "product"
        Me.ProductBindingSource2.DataSource = Me.PosDataSetBindingSource
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "posDataSet_product"
        ReportDataSource1.Value = Me.ProductBindingSource3
        ReportDataSource2.Name = "Delivery1_product"
        ReportDataSource2.Value = Me.ProductBindingSource4
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "POS.Delivery1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(566, 391)
        Me.ReportViewer1.TabIndex = 0
        '
        'Delivery1
        '
        Me.Delivery1.DataSetName = "Delivery1"
        Me.Delivery1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource3
        '
        Me.ProductBindingSource3.DataMember = "product"
        Me.ProductBindingSource3.DataSource = Me.PosDataSetBindingSource
        '
        'ProductBindingSource4
        '
        Me.ProductBindingSource4.DataMember = "product"
        Me.ProductBindingSource4.DataSource = Me.Delivery1
        '
        'ProductTableAdapter1
        '
        Me.ProductTableAdapter1.ClearBeforeFill = True
        '
        'DeliveryReport1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 391)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DeliveryReport1"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivery Report"
        CType(Me.ProductBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.posDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delivery1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents productBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents posDataSet As POS.posDataSet
    Friend WithEvents productTableAdapter As POS.posDataSetTableAdapters.productTableAdapter
    Friend WithEvents PosDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Delivery1 As POS.Delivery1
    Friend WithEvents ProductBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter1 As POS.Delivery1TableAdapters.productTableAdapter
End Class
