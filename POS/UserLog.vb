
Public Class UserLog
    
    Private Sub UserLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'posDataSet2.userlog' table. You can move, or remove it, as needed.
        Me.userlogTableAdapter.Fill(Me.posDataSet2.userlog)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class