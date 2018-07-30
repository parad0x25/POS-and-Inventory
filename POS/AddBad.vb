Imports MySql.Data.MySqlClient
Public Class AddBad
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
            strSQL = "Insert into Badorder(Barcode,ItemName,Price,QTY,EXPdate) values ('" & txtBarcode.Text.ToUpper & "', '" & txtItem.Text.Trim & "', '" & txtPrice.Text & "','" & txtQTY.Text.ToUpper & "', '" & DTPExp.Value & "')"
            Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
            da.Fill(ds)
            CONNECTION.Close()
            Me.Close()
            BadOrder.glenox()
        End If
    End Sub

    Private Sub AddBad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub txtQTY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQTY.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
End Class