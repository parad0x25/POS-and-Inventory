Imports MySql.Data.MySqlClient
Public Class ItemInfo
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Product where Barcode like '%" & txtSearch.Text.Trim & "%'"
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
            Loop
        End If
        If RadioButton2.Checked = True Then
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Product where Item like '%" & txtSearch.Text.Trim & "%'"
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
            Loop
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Public Sub list()
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Product"
        ListView1.Items.Clear()
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
            lv.SubItems.Add(dr!Barcode.ToString)
            lv.SubItems.Add(dr!Item.ToString)
            lv.SubItems.Add(dr!Price.ToString)
            lv.SubItems.Add(dr!vat.ToString)
        Loop
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ItemInfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMain.MenuStrip.Enabled = True
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(1).Text
        Add.Button1.Text = "Update"
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Product where Barcode='" & txtTemp.Text & "'"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Add.lblID.Text = dr!ID.ToString
            Add.txtBarcode.Text = dr!Barcode.ToString
            Add.cboSup.Text = dr!Supplier.ToString
            Add.cboCat.Text = dr!Category.ToString
            Add.txtQTY.Text = dr!QTY.ToString
            Add.txtItem.Text = dr!Item.ToString
            Add.txtPrice.Text = Val(dr!Vat.ToString) + Val(dr!Price.ToString)
        End If
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        Add.ShowDialog()
    End Sub


    Private Sub MenuStrip1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _location = e.Location
    End Sub

    Private Sub MenuStrip1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then

            Dim MSize As New Size(_location)
            MSize.Width = e.X - _location.X
            MSize.Height = e.Y - _location.Y
            Me.Location = Point.Add(Me.Location, MSize)

        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Add.ShowDialog()
        Add.txtBarcode.Text = ""
        Add.txtItem.Text = ""
        Add.txtPrice.Text = ""
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If txtTemp.Text = "" Then
            MsgBox("Please Select Item")
        Else
            Add.Button1.Text = "Update"
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from Product where Barcode='" & txtTemp.Text & "'"
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Add.lblID.Text = dr!ID.ToString
                Add.txtBarcode.Text = dr!Barcode.ToString
                Add.txtPrice.Text = dr!Supplier.ToString
                Add.txtItem.Text = dr!Item.ToString
                Add.txtPrice.Text = Val(dr!Vat.ToString) + Val(dr!Price.ToString)
            End If
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            Add.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If ListView1.Items.Count > 0 Then
            For i = ListView1.Items.Count - 1 To 0 Step -1
                If ListView1.Items(i).Checked = True Then
                    strSQL = "DELETE FROM Product WHERE ID = '" & ListView1.Items(i).Text & "'"
                    Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                    da.Fill(ds)
                End If
            Next i
        End If
        list()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class