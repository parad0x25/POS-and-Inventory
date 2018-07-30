Imports MySql.Data.MySqlClient
Public Class EditSup
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtSupName.Text = "" Or txtSupName.Text = vbNullChar Then
            MsgBox("Error Supplier Name")
            txtSupName.Focus()
        ElseIf txtContact.Text = "" Or txtContact.Text = vbNullChar Then
            MsgBox("Error Contact")
            txtContact.Focus()
        ElseIf txtAddress.Text = "" Or txtAddress.Text = vbNullChar Then
            MsgBox("Error Address")
            txtAddress.Focus()
        ElseIf txtEmail.Text = "" Or txtEmail.Text = vbNullChar Then
            MsgBox("Error Email")
            txtEmail.Focus()
        Else
            CONNECTION.Close()
            cmd.Dispose()
            strSQL = "Update supplier set supplierName = '" & txtSupName.Text.Trim & "', Address = '" & txtAddress.Text.Trim & "', Contact = '" & txtContact.Text.ToUpper & "', Email = '" & txtEmail.Text.Trim & "' where SupplierID = '" & lblID.Text.Trim & "'"
            Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
            da.Fill(ds)
            CONNECTION.Close()
            Me.Close()
            Supplier.list()
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

    Private Sub EditSup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class