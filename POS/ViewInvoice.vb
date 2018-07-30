Imports MySql.Data.MySqlClient
Public Class ViewInvoice
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from receipt where ReceiptID='" & txtSearch.Text.Trim & "'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!ReceiptID.ToString)
                lv.SubItems.Add(dr!Sold_By.ToString)
                lv.SubItems.Add(dr!Cash.ToString)
                lv.SubItems.Add(dr!Change1.ToString)
                lv.SubItems.Add(dr!Total.ToString)
                lv.SubItems.Add(dr!Discount.ToString)
                lv.SubItems.Add(dr!Receipt_Date.ToString)
            Loop
        End If
        If RadioButton2.Checked = True Then
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from receipt where Sold_by like '%" & txtSearch.Text.Trim & "%'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!ReceiptID.ToString)
                lv.SubItems.Add(dr!Sold_By.ToString)
                lv.SubItems.Add(dr!Cash.ToString)
                lv.SubItems.Add(dr!Change1.ToString)
                lv.SubItems.Add(dr!Total.ToString)
                lv.SubItems.Add(dr!Discount.ToString)
                lv.SubItems.Add(dr!Receipt_Date.ToString)
            Loop
        End If
    End Sub
End Class