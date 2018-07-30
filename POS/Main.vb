Imports System.Windows.Forms.KeyPressEventArgs
Imports MySql.Data.MySqlClient
Public Class Main
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    'Public Dis As Single = lblDis.Text
    Public tax As String
    Public temp As String
    Dim a, b, c, d


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim date1 As String = "yy-MM-dd"
        Label2.Text = TimeOfDay
        Label11.Text = Format$(Date.Today, date1)
    End Sub

    Private Sub Main_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Timer2.Start()
    End Sub

    Private Sub Main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMain.MenuStrip.Enabled = True
        MDIMain.Panel1.Enabled = True
    End Sub
    Private Sub Main_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            If lblSubT.Text = "0" Then
                MsgBox("Scan Barcode")
            Else
                Pay.lblID.Text = MDIMain.lblID.Text
                Pay.lblTotal.Text = lblGrandT.Text
                Pay.txtAmount.Text = "0"
                Pay.ShowDialog()
            End If
        End If
        If e.KeyCode = Keys.F7 Then
            qty.ShowDialog()
            qty.txtqty.Text = "0"
        End If

        If e.Alt = True And e.KeyCode = Keys.F4 Then
            e.Handled = True
        End If
        If e.Alt = True And e.KeyCode = Keys.Tab Then
            e.Handled = True
        End If
        If e.KeyCode = Keys.F12 Then
            If Not lblSubT.Text = "0" Then
                MsgBox("Please Finish before exit")
            Else
                Me.Close()
            End If
        End If
        'If e.KeyCode = Keys.F4 Then
        'Resibo.ShowDialog()
        'End If
    End Sub

    Public Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.TopMost = True
        lblSubT.Text = Format$(0)
        lblTax.Text = Format$(0)
        lblGrandT.Text = Format$(0, "##.##")
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Not txtBarcode.Focus = False Then
            txtBarcode.Focus()
        End If
        If txtBarcode.TextLength = 13 Then
            If txtqty.Text = 0 Or txtqty.Text = vbNullChar Then
                txtqty.Text = 1
            Else
                Dim temp1 As String
                cmd.Dispose()
                CONNECTION.Close()
                strSQL = "SELECT * from product where Barcode='" & txtBarcode.Text.Trim & "'"
                CONNECTION.Open()
                cmd = New MySqlCommand(strSQL, CONNECTION)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    txtItemName.Text = dr!Item.ToString
                    txtTax.Text = dr!Vat.ToString
                    txtItemPrice.Text = dr!Price.ToString
                    If txtqty.Text = 1 Then
                        txtqty.Text = 1
                    ElseIf txtqty.Text = vbNullChar Then
                        txtqty.Text = 1
                    End If
                    If dr!qty.ToString < txtqty.Text Then
                        Timer2.Stop()
                        txtBarcode.Text = ""
                        txtItemName.Text = ""
                        txtTax.Text = ""
                        txtItemPrice.Text = ""
                        MsgBox("No more item")
                    Else
                        temp1 = dr!QTY.ToString - txtqty.Text
                        CONNECTION.Close()
                        dr.Close()
                        cmd.Dispose()
                        strSQL = "Update product set QTY = '" & temp1 & "' where Barcode = '" & txtBarcode.Text.Trim & "'"
                        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                        da.Fill(ds)
                        CONNECTION.Close()
                        dr.Close()
                        cmd.Dispose()
                        strSQL = "SELECT * from Sales where Barcode='" & txtBarcode.Text.Trim & "'" & "and UserID='" & MDIMain.lblID.Text & "'"
                        CONNECTION.Open()
                        cmd = New MySqlCommand(strSQL, CONNECTION)
                        dr = cmd.ExecuteReader()
                        If dr.Read() Then
                            txtqty2.Text = Val(txtqty.Text) + Val(dr!QTY.ToString)
                            CONNECTION.Close()
                            dr.Close()
                            cmd.Dispose()
                            strSQL = "Update sales set QTY = '" & "+" & txtqty2.Text & "' where Barcode = '" & txtBarcode.Text.Trim & "'"
                            Dim da1 As New MySqlDataAdapter(strSQL, CONNECTION)
                            da1.Fill(ds)
                            CONNECTION.Close()
                            dr.Close()
                            cmd.Dispose()
                            strSQL = "Update saleslog set QTY = '" & "+" & txtqty2.Text & "' where Barcode = '" & txtBarcode.Text.Trim & "'"
                            Dim da2 As New MySqlDataAdapter(strSQL, CONNECTION)
                            da1.Fill(ds)
                        Else
                            CONNECTION.Close()
                            dr.Close()
                            cmd.Dispose()
                            strSQL = "Insert into sales(Barcode,UserID,ItemName,Price,Vat,QTY,Date) values ('" & txtBarcode.Text & "', '" & MDIMain.lblID.Text & "', '" & txtItemName.Text & "', '" & txtItemPrice.Text & "','" & txtTax.Text & "', '" & txtqty.Text & "', '" & Now & "')"
                            Dim da3 As New MySqlDataAdapter(strSQL, CONNECTION)
                            da3.Fill(ds)
                            CONNECTION.Close()
                            dr.Close()
                            cmd.Dispose()
                            strSQL = "Insert into saleslog(Barcode,StaffID,ItemName,Price,Vat,QTY) values ('" & txtBarcode.Text & "', '" & MDIMain.lblID.Text & "', '" & txtItemName.Text & "', '" & txtItemPrice.Text & "','" & txtTax.Text & "', '" & txtqty.Text & "')"
                            Dim da1 As New MySqlDataAdapter(strSQL, CONNECTION)
                            da1.Fill(ds)
                            CONNECTION.Close()
                            dr.Close()
                            cmd.Dispose()
                        End If
                        txtItemPrice.Text = Val(txtqty.Text) * Val(txtItemPrice.Text)
                        txtTax.Text = Val(txtqty.Text) * Val(txtTax.Text)
                        lblSubT.Text = Val(txtItemPrice.Text) + Val(lblSubT.Text)
                        lblTax.Text = Val(txtTax.Text) + Val(lblTax.Text)
                        lblGrandT.Text = Val(lblSubT.Text) + Val(lblTax.Text)
                        txtItemName.Clear()
                        txtItemPrice.Clear()
                        txtBarcode.Clear()
                        txtTax.Clear()
                        txtqty.Text = "1"
                        txtqty2.Text = "0"
                        dr.Close()
                        cmd.Dispose()
                        CONNECTION.Close()
                    End If
            End If
        End If
        Else
            cmd.Dispose()
            CONNECTION.Close()
            strSQL = "SELECT * from sales where UserID='" & MDIMain.lblID.Text.Trim & "'"
            ListView1.Items.Clear()
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            Do While dr.Read()
                Dim lv As ListViewItem = ListView1.Items.Add(dr!Barcode.ToString)
                lv.SubItems.Add(dr!ItemName.ToString)
                lv.SubItems.Add(dr!QTY.ToString)
                lv.SubItems.Add(dr!Price.ToString)
                lv.SubItems.Add(dr!Vat.ToString)
            Loop
        End If
        dr.Close()
        cmd.Dispose()
        CONNECTION.Close()
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Not lblChange.Text = "00" Then
            Lock.lblChange.Text = Me.lblChange.Text
            Lock.ShowDialog()
        End If
        Timer3.Stop()
    End Sub
    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If txtBarcode.TextLength = 13 Then
            Timer2.Start()
        Else
            Timer2.Stop()
        End If
        Dim tmp As String
        tmp = "taskmgr"
        For Each proc In Process.GetProcessesByName(tmp)
            proc.Kill()
        Next
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "DELETE FROM Sales WHERE UserID = '" & MDIMain.lblID.Text & "'"
        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds)
        cmd.Dispose()
        CONNECTION.Close()
        strSQL = "DELETE FROM Saleslog WHERE StaffID = '" & MDIMain.lblID.Text & "'"
        Dim da1 As New MySqlDataAdapter(strSQL, CONNECTION)
        da1.Fill(ds)
        cmd.Dispose()
        CONNECTION.Close()
        lblSubT.Text = "0"
        lblTax.Text = "0"
        lblGrandT.Text = "0"
        Timer2.Start()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        txtTemp.Text = ListView1.SelectedItems(0).SubItems(0).Text
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
