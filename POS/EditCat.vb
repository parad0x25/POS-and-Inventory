Imports MySql.Data.MySqlClient
Public Class EditCat
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCatName.Text = "" Or txtCatName.Text = vbNullChar Then
            MsgBox("Error Category Name")
            txtCatName.Focus()
        Else
            CONNECTION.Close()
            cmd.Dispose()
            strSQL = "Update Category set CategoryName = '" & txtCatName.Text.Trim & "' where ID = '" & lblID.Text.Trim & "'"
            Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
            da.Fill(ds)
            CONNECTION.Close()
            Me.Close()
            category.list()
        End If
    End Sub

    Private Sub EditCat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class