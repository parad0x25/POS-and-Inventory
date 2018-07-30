Imports MySql.Data.MySqlClient
Public Class CheckSale
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Private Sub CheckSale_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Timer2.Start()
    End Sub
    Private Sub CheckSale_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
      
    End Sub

    Private Sub CheckSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'posDataSet1.saleslog' table. You can move, or remove it, as needed.
        Me.saleslogTableAdapter.Fill(Me.posDataSet1.saleslog)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class