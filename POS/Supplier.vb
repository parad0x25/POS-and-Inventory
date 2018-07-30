Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class Supplier
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from supplier where SupplierName like '%" & txtSearch.Text.Trim & "%'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!SupplierID.ToString)
                lv.SubItems.Add(dr!SupplierName.ToString)
                lv.SubItems.Add(dr!Address.ToString)
                lv.SubItems.Add(dr!Contact.ToString)
                lv.SubItems.Add(dr!Email.ToString)
            Loop
        End If
        If RadioButton2.Checked = True Then
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from supplier where SupplierID='" & txtSearch.Text.Trim & "'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!SupplierID.ToString)
                lv.SubItems.Add(dr!SupplierName.ToString)
                lv.SubItems.Add(dr!Address.ToString)
                lv.SubItems.Add(dr!Contact.ToString)
                lv.SubItems.Add(dr!Email.ToString)
            Loop
        End If
    End Sub

    Public Sub list()
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Supplier"
        ListView1.Items.Clear()
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr!SupplierID.ToString)
            lv.SubItems.Add(dr!SupplierName.ToString)
            lv.SubItems.Add(dr!Address.ToString)
            lv.SubItems.Add(dr!Contact.ToString)
            lv.SubItems.Add(dr!Email.ToString)
        Loop
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(0).Text
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Supplier where SupplierID='" & txtTemp.Text & "'"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            EditSup.lblID.Text = dr!SupplierID.ToString
            EditSup.txtSupName.Text = dr!SupplierName.ToString
            EditSup.txtAddress.Text = dr!Address.ToString
            EditSup.txtContact.Text = dr!Contact.ToString
            EditSup.txtEmail.Text = dr!Email.ToString
        End If
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        EditSup.ShowDialog()
    End Sub

    Private Sub Supplier_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMain.MenuStrip.Enabled = True
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Supplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        AddSup.ShowDialog()
        cmd.Dispose()
        CONNECTION.Close()
        AddSup.txtSupName.Text = ""
        AddSup.txtAddress.Text = ""
        AddSup.txtContact.Text = ""
        AddSup.txtEmail1.Text = ""
        AddSup.txtEmail2.Text = ""
        AddSup.txtEmail3.Text = ""

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        cmd.Dispose()
        CONNECTION.Close()
        If txtTemp.Text = "" Then
            MsgBox("Select first")
        Else
            strSQL = "SELECT * from Supplier where SupplierID='" & txtTemp.Text & "'"
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                EditSup.lblID.Text = dr!SupplierID.ToString
                EditSup.txtSupName.Text = dr!SupplierName.ToString
                EditSup.txtAddress.Text = dr!Address.ToString
                EditSup.txtContact.Text = dr!Contact.ToString
                EditSup.txtEmail.Text = dr!Email.ToString
            End If
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            EditSup.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "DELETE FROM supplier WHERE SupplierID = '" & txtTemp.Text & "'"
        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds)
        cmd.Dispose()
        CONNECTION.Close()
        list()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
        cmd.Dispose()
        CONNECTION.Close()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class