Imports MySql.Data.MySqlClient
Public Class category
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Category where CategoryName like '%" & txtSearch.Text.Trim & "%'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
                lv.SubItems.Add(dr!CategoryName.ToString)
                lv.SubItems.Add(dr!UserEdit.ToString)
                lv.SubItems.Add(dr!DateAdded.ToString)
            Loop
        End If
        If RadioButton2.Checked = True Then
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Category where ID='" & txtSearch.Text.Trim & "'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
                lv.SubItems.Add(dr!CategoryName.ToString)
                lv.SubItems.Add(dr!UserEdit.ToString)
                lv.SubItems.Add(dr!DateAdded.ToString)
            Loop
        End If
    End Sub
    Public Sub list()
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Category"
        ListView1.Items.Clear()
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
            lv.SubItems.Add(dr!CategoryName.ToString)
            lv.SubItems.Add(dr!UserEdit.ToString)
            lv.SubItems.Add(dr!DateAdded.ToString)
        Loop
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub category_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMain.MenuStrip.Enabled = True
    End Sub

    Private Sub category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIMain.MenuStrip.Enabled = False
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AddCat.ShowDialog()
        cmd.Dispose()
        CONNECTION.Close()
        AddCat.txtCatName.Text = ""
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(0).Text
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Category where ID='" & txtTemp.Text & "'"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            EditCat.lblID.Text = dr!ID.ToString
            EditCat.txtCatName.Text = dr!CategoryName.ToString
        End If
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        EditCat.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If txtTemp.Text = "" Then
            MsgBox("No Selected data")
        Else
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Category where ID='" & txtTemp.Text & "'"
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                EditCat.lblID.Text = dr!ID.ToString
                EditCat.txtCatName.Text = dr!CategoryName.ToString
            End If
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            EditCat.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "DELETE FROM Category WHERE ID = '" & txtTemp.Text & "'"
        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds)
        cmd.Dispose()
        CONNECTION.Close()
        list()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class