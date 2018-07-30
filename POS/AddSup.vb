Imports MySql.Data.MySqlClient
Public Class AddSup
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ValidateChildren()
        If txtSupName.Text = "" Or txtSupName.Text = vbNullChar Then
            MsgBox("Error Supplier Name")
            txtSupName.Focus()
        ElseIf txtContact.Text = "" Or txtContact.Text = vbNullChar Then
            MsgBox("Error Contact")
            txtContact.Focus()
        ElseIf txtAddress.Text = "" Or txtAddress.Text = vbNullChar Then
            MsgBox("Error Address")
            txtAddress.Focus()
        ElseIf txtEmail1.Text = "" Or txtEmail1.Text = vbNullChar Then
            MsgBox("Error Email")
            txtEmail1.Focus()
        ElseIf txtEmail2.Text = "" Or txtEmail2.Text = vbNullChar Then
            MsgBox("Error Email")
            txtEmail2.Focus()
        ElseIf txtEmail3.Text = "" Or txtEmail3.Text = vbNullChar Then
            MsgBox("Error Email")
            txtEmail1.Focus()
        Else
            strSQL = "SELECT * from supplier where suppliername='" & txtSupName.Text.ToUpper & "'"
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                MsgBox("SuplierName is already use!")
                CONNECTION.Close()
                dr.Close()
                cmd.Dispose()
            Else
                CONNECTION.Close()
                dr.Close()
                cmd.Dispose()
                strSQL = "Insert into supplier(SupplierName,Address,Contact,Email) values ('" & txtSupName.Text.ToUpper & "', '" & txtAddress.Text.ToUpper & "', '" & txtContact.Text.ToUpper & "', '" & txtEmail1.Text.ToUpper & "@" & txtEmail2.Text.ToUpper & "." & txtEmail3.Text.ToUpper & "')"
                Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                da.Fill(ds)
                CONNECTION.Close()
                Me.Close()
                Supplier.list()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
End Class