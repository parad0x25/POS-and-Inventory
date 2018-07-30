Imports MySql.Data.MySqlClient
Public Class AddCat
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtCatName.Text = "" Or txtCatName.Text = vbNullChar Then
            MsgBox("Error Category Name")
            txtCatName.Focus()
        Else
            CONNECTION.Close()
            cmd.Dispose()
            strSQL = "SELECT * from Category where CategoryName='" & txtCatName.Text.ToUpper & "'"
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                MsgBox("Category Name is already use!")
                CONNECTION.Close()
                dr.Close()
                cmd.Dispose()
            Else
                CONNECTION.Close()
                dr.Close()
                cmd.Dispose()
                strSQL = "Insert into Category(CategoryName,UserEdit,DateAdded) values ('" & txtCatName.Text.ToUpper & "', '" & MDIMain.lblUser.Text.ToUpper & "', '" & Now & "')"
                Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                da.Fill(ds)
                CONNECTION.Close()
                Me.Close()
                category.list()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class