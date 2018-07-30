Imports MySql.Data.MySqlClient
Public Class Delivery
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Delivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Product where QTY='" & 0 & "'"
        ListView1.Items.Clear()
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr!Barcode.ToString)
            lv.SubItems.Add(dr!Item.ToString)
            lv.SubItems.Add(dr!Supplier.ToString)
        Loop
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DeliveryReport1.ShowDialog()
    End Sub
End Class