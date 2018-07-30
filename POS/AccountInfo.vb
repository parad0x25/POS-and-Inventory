Imports MySql.Data.MySqlClient
Public Class AccountInfo
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader


    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AccountInfo_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub AccountInfo_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMain.MenuStrip.Enabled = True
    End Sub

    Private Sub AccountInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MDIMain.MenuStrip.Enabled = False
    End Sub
    Public Sub list()
        strSQL = "SELECT * from Account"
        ListView1.Items.Clear()
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
            lv.SubItems.Add(dr!FName.ToString)
            lv.SubItems.Add(dr!UserName.ToString)
            lv.SubItems.Add(dr!Status.ToString)
        Loop
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
        Main.Timer2.Start()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(2).Text
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(2).Text
        Acount.Button1.Text = "Update"
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Account where UserName='" & txtTemp.Text & "'"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            Acount.lblID.Text = dr!ID.ToString
            Acount.txtFName.Text = dr!FName.ToString
            Acount.txtLname.Text = dr!LName.ToString
            Acount.txtContact.Text = dr!Contact.ToString
            Acount.txtAddress.Text = dr!Address.ToString
            Acount.txtuser.Text = dr!UserName.ToString
            Acount.cboStatus.Text = dr!Status.ToString
        End If
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        Acount.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "SELECT * from Account where UserName like '%" & txtSearch.Text.Trim & "%'"
        ListView1.Items.Clear()
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        dr = cmd.ExecuteReader()
        Do While dr.Read()
            Dim lv As ListViewItem = ListView1.Items.Add(dr!ID.ToString)
            lv.SubItems.Add(dr!FName.ToString & "," & dr!Lname.ToString)
            lv.SubItems.Add(dr!UserName.ToString)
            lv.SubItems.Add(dr!Status.ToString)
        Loop
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If ListView1.Items.Count > 0 Then
            For i = ListView1.Items.Count - 1 To 0 Step -1
                If ListView1.Items(i).Checked = True Then
                    strSQL = "DELETE FROM Account WHERE ID = '" & ListView1.Items(i).Text & "'"
                    Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                    da.Fill(ds)
                End If
            Next i
        End If
        list()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        If txtTemp.Text = "" Then
            MsgBox("Please Select Item")
        Else
            Acount.Button1.Text = "Update"
            strSQL = "SELECT * from Account where UserName='" & txtTemp.Text & "'"
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Acount.lblID.Text = dr!ID.ToString
                Acount.txtFName.Text = dr!FName.ToString
                Acount.txtLname.Text = dr!LName.ToString
                Acount.txtContact.Text = dr!Contact.ToString
                Acount.txtAddress.Text = dr!Address.ToString
                Acount.txtuser.Text = dr!UserName.ToString
                Acount.cboStatus.Text = dr!Status.ToString
            End If
            dr.Close()
            cmd.Dispose()
            CONNECTION.Close()
            Acount.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Acount.Button1.Text = "Save"
        Acount.ShowDialog()
    End Sub
End Class