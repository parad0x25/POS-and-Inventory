Public Class DeliveryReport1

    Private Sub DeliveryReport1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Delivery1.product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter1.Fill(Me.Delivery1.product)
        'TODO: This line of code loads data into the 'posDataSet.product' table. You can move, or remove it, as needed.
        Me.productTableAdapter.Fill(Me.posDataSet.product)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class