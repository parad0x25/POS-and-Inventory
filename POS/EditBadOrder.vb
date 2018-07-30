Imports MySql.Data.MySqlClient
Public Class EditBadOrder
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtBarcode.Text = "" Or txtBarcode.Text = vbNullChar Or txtBarcode.TextLength < 13 Then
            MsgBox("Error Barcode!")
            txtBarcode.Focus()
        ElseIf txtItem.Text = "" Or txtItem.Text = vbNullChar Then
            MsgBox("Error Item Name!")
            txtItem.Focus()
        ElseIf txtQTY.Text = "" Or txtItem.Text = vbNullChar Then
            MsgBox("Error Quantity!")
        ElseIf txtPrice.Text = "" Or txtPrice.Text = vbNullChar Then
            MsgBox("Error Price!")
        Else
            CONNECTION.Close()
            cmd.Dispose()
            strSQL = "Update Badorder set Barcode = '" & txtBarcode.Text.Trim & "', ItemName = '" & txtItem.Text.Trim & "', Price = '" & txtPrice.Text.Trim & "', QTY = '" & txtQTY.Text.Trim & "', EXPdate = '" & DTPExp.Value & "' where ID = '" & lblID.Text.Trim & "'"
            Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
            da.Fill(ds)
            CONNECTION.Close()
            Me.Close()
            BadOrder.glenox()
        End If
    End Sub

    Private Sub EditBadOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Badorder where Barcode='" & BadOrder.txtTemp.Text & "'"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            lblID.Text = dr!ID.ToString
            txtBarcode.Text = dr!Barcode.ToString
            txtItem.Text = dr!ItemName.ToString
            txtPrice.Text = dr!Price.ToString
            txtQTY.Text = dr!QTY.ToString
            DTPExp.Value = dr!EXPdate.ToString
        End If
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
    End Sub
End Class