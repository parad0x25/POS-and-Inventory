Imports MySql.Data.MySqlClient
Public Class Stock
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Product where Barcode='" & txtSearch.Text.Trim & "'" & "and QTY>0"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
                lv.SubItems.Add(dr!Barcode.ToString)
                lv.SubItems.Add(dr!Item.ToString)
                lv.SubItems.Add(dr!Price.ToString)
                lv.SubItems.Add(dr!Vat.ToString)
                lv.SubItems.Add(dr!QTY.ToString)
            Loop
        End If
        If RadioButton2.Checked = True Then
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Product where Item like '%" & txtSearch.Text.Trim & "%'" & "and QTY>0"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
                lv.SubItems.Add(dr!Barcode.ToString)
                lv.SubItems.Add(dr!Item.ToString)
                lv.SubItems.Add(dr!Price.ToString)
                lv.SubItems.Add(dr!Vat.ToString)
                lv.SubItems.Add(dr!QTY.ToString)
            Loop
        End If
    End Sub
End Class