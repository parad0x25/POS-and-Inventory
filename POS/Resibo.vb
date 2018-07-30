Imports MySql.Data.MySqlClient
Public Class Resibo
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Dim a, b, c, d
    Private Sub Resibo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CONNECTION.Close()
        cmd.Dispose()
        strSQL = "SELECT * from sales where UserID like '%" & "1" & "%'"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            CONNECTION.Close()
            dr.Close()
            cmd.Dispose()
            strSQL = "Update sales set UserID = '" & "0" & "' where StaffID = '" & MDIMain.lblID.Text & "'"
            Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
            da.Fill(ds)
            CONNECTION.Close()
            dr.Close()
            ds.Dispose()
            cmd.Dispose()
        End If
    End Sub

    Private Sub Resibo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SalesTableAdapter.Fill(Me.Resibo5.sales)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class