Imports MySql.Data.MySqlClient
Public Class BadOrder
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AddBad.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            cmd.Dispose()
            CONNECTION.Close()
            txtTemp.Text = ""
            strSQL = "SELECT * from Badorder where Barcode='" & txtSearch.Text.Trim & "'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!Barcode.ToString)
                lv.SubItems.Add(dr!ItemName.ToString)
                lv.SubItems.Add(dr!Price.ToString)
                lv.SubItems.Add(dr!QTY.ToString)
                lv.SubItems.Add(dr!EXPdate.ToString)
            Loop
        End If
        If RadioButton2.Checked = True Then
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            txtTemp.Text = ""
            strSQL = "SELECT * from Badorder where ItemName like '%" & txtSearch.Text.Trim & "%'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!Barcode.ToString)
                lv.SubItems.Add(dr!ItemName.ToString)
                lv.SubItems.Add(dr!Price.ToString)
                lv.SubItems.Add(dr!QTY.ToString)
                lv.SubItems.Add(dr!EXPdate.ToString)
            Loop
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If txtTemp.Text = "" Then
            MsgBox("Please Select Item")
        Else
            EditBadOrder.ShowDialog()
        End If
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If txtTemp.Text = "" Then
            MsgBox("Please Select Item")
        Else
            EditBadOrder.ShowDialog()
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub txtTemp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTemp.TextChanged

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "DELETE FROM Badorder WHERE Barcode = '" & txtTemp.Text & "'"
        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds)
        cmd.Dispose()
        CONNECTION.Close()
        glenox()
    End Sub

    Public Sub glenox()
        cmd.Dispose()
        CONNECTION.Close()
        txtTemp.Text = ""
        strSQL = "SELECT * from Badorder"
        ListView1.Items.Clear()
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr!Barcode.ToString)
            lv.SubItems.Add(dr!ItemName.ToString)
            lv.SubItems.Add(dr!Price.ToString)
            lv.SubItems.Add(dr!QTY.ToString)
            lv.SubItems.Add(dr!EXPdate.ToString)
        Loop
    End Sub
End Class