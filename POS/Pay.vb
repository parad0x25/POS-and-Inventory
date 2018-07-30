Imports MySql.Data.MySqlClient
Imports System.Random
Public Class Pay
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Dim a, b, c, d
    Dim objRandom As New System.Random(CType(System.DateTime.Now.Ticks Mod System.Int32.MaxValue, Integer))

    Public Function GetRandomNumber( _
      Optional ByVal Low As Integer = 1, _
      Optional ByVal High As Integer = 100) As Integer
        ' Returns a random number,
        ' between the optional Low and High parameters
        Return objRandom.Next(Low, High + 1)
    End Function


    Private Sub Pay_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Timer2.Start()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtDis.Text = "0"
        Label4.Visible = False
        txtDis.Visible = False
    End Sub
    Private Sub Pay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim intDiceRoll As Integer
        intDiceRoll = GetRandomNumber(100000000, 999999999)
        If e.KeyCode = Keys.Enter Then
            If Val(txtAmount.Text) < lblTotal.Text Then
                MsgBox("The cash is not enough")
                txtAmount.Text = ""
            Else
                CONNECTION.Close()
                strSQL = "SELECT * from Sales where UserID like '%" & MDIMain.lblID.Text & "%'"
                CONNECTION.Open()
                cmd = New MySqlCommand(strSQL, CONNECTION)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    CONNECTION.Close()
                    dr.Close()
                    cmd.Dispose()
                    strSQL = "Update sales set UserID = '" & "1" & "', StaffID = '" & MDIMain.lblID.Text & "', tran = '" & intDiceRoll.ToString & "' where UserID = '" & MDIMain.lblID.Text & "'"
                    Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                    da.Fill(ds)
                    CONNECTION.Close()
                    dr.Close()
                    ds.Dispose()
                    cmd.Dispose()
                    If RadioButton2.Checked = True Then
                        Main.lblDis.Text = txtDis.Text
                        Main.lblCash.Text = Val(txtAmount.Text) + Val(txtDis.Text)
                        Main.lblCash2.Text = txtAmount.Text
                        Me.Close()
                    ElseIf RadioButton1.Checked = True Then
                        Dim temp As String
                        Main.Label13.Visible = False
                        Main.lblDis.Text = "20%"
                        temp = Val(lblTotal.Text) * Val(txtPer.Text)
                        Main.lblCash.Text = Val(txtAmount.Text) + temp
                        Main.lblCash2.Text = txtAmount.Text
                        Main.lblChange.Text = Main.lblCash.Text - Main.lblGrandT.Text
                        CONNECTION.Close()
                        dr.Close()
                        cmd.Dispose()
                        strSQL = "Update sales set STOT = '" & Main.lblSubT.Text & "', GTOT = '" & Main.lblGrandT.Text & "', Cash = '" & Main.lblCash2.Text & "', Change1 = '" & Main.lblChange.Text & "', VatTot = '" & Main.lblTax.Text & "' where tran = '" & intDiceRoll.ToString & "'"
                        Dim da1 As New MySqlDataAdapter(strSQL, CONNECTION)
                        da1.Fill(ds)
                        Resibo.ShowDialog()
                        Me.Close()
                        CONNECTION.Close()
                        dr.Close()
                        cmd.Dispose()
                    Else
                        Main.lblCash.Text = Val(txtAmount.Text) + Val(txtDis.Text)
                        Main.lblCash2.Text = txtAmount.Text
                        Main.lblChange.Text = Main.lblCash.Text - Main.lblGrandT.Text
                        CONNECTION.Close()
                        dr.Close()
                        cmd.Dispose()
                        strSQL = "Update sales set STOT = '" & Main.lblSubT.Text & "', GTOT = '" & Main.lblGrandT.Text & "', Cash = '" & Main.lblCash2.Text & "', Change1 = '" & Main.lblChange.Text & "', VatTot = '" & Main.lblTax.Text & "' where tran = '" & intDiceRoll.ToString & "'"
                        Dim da1 As New MySqlDataAdapter(strSQL, CONNECTION)
                        da1.Fill(ds)
                        CONNECTION.Close()
                        dr.Close()
                        cmd.Dispose()
                        strSQL = "Insert into Receipt(ReceiptID,Receipt_Date,Sold_By,Cash,Change1,Total,Discount) values ('" & intDiceRoll.ToString & "', '" & Now & "', '" & MDIMain.lblName.Text & "','" & Main.lblCash2.Text & "', '" & Main.lblChange.Text & "', '" & Main.lblGrandT.Text & "', '" & Main.lblDis.Text & "')"
                        Dim da4 As New MySqlDataAdapter(strSQL, CONNECTION)
                        da4.Fill(ds)
                        Resibo.ShowDialog()
                        Me.Close()
                        CONNECTION.Close()
                        dr.Close()
                        cmd.Dispose()
                    End If
                End If
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Pay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Timer2.Stop()
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
           AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        If RadioButton2.Checked = True Then
            txtDis.Text = "0"
            Label4.Visible = True
            txtDis.Visible = True
        End If
    End Sub

    Private Sub txtDis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDis.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True Then
            txtDis.Text = "0"
            Label4.Visible = False
            txtDis.Visible = False
            txtPer.Text = "0.20"
        End If
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub

    Private Sub txtDis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDis.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class