Imports MySql.Data.MySqlClient
Public Class Lock
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private Sub Lock_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Timer2.Start()
        Main.Timer3.Start()
    End Sub

    Private Sub Lock_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Main.lblSubT.Text = "0"
            Main.lblTax.Text = "0"
            Main.lblGrandT.Text = "0"
            Main.lblDis.Text = "0"
            Main.lblCash.Text = "0"
            Main.lblCash2.Text = "0"
            Main.lblChange.Text = "00"
            Main.Label13.Visible = True
            Main.txtBarcode.Focus()
            Me.Close()
        End If
    End Sub

    Private Sub Lock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Timer2.Stop()
        Main.Timer3.Stop()
    End Sub
End Class