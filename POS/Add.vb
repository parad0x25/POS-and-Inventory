Imports MySql.Data.MySqlClient

Public Class Add
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Private _location As Point


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Add_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        cboSup.DataSource.clear()
        cboCat.DataSource.clear()
        txtBarcode.Text = ""
        txtItem.Text = ""
        txtPrice.Text = ""
    End Sub
    Private Sub Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtVat.Text = Format$(0, "##.##")
        txttemp.Text = Format$(0, "##.##")
        CONNECTION.Close()
        cmd.Dispose()
        strSQL = "SELECT * from supplier"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds, "supplier")
        With cboSup
            .DataSource = ds.Tables("supplier")
            .DisplayMember = "suppliername"
            .ValueMember = "supplierID"
        End With
        CONNECTION.Close()
        cmd.Dispose()
        ds.Dispose()
        strSQL = "SELECT * from category"
        CONNECTION.Open()
        cmd = New MySqlCommand(strSQL, CONNECTION)
        Dim da1 As New MySqlDataAdapter(strSQL, CONNECTION)
        da1.Fill(ds, "category")
        With cboCat
            .DataSource = ds.Tables("category")
            .DisplayMember = "CategoryName"
            .ValueMember = "ID"
        End With

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not txtPrice.Text = "" Then
            txtVat.Text = Val(txtPrice.Text) * 0.12
            txttemp.Text = Val(txtPrice.Text) - Val(txtVat.Text)
        End If
    End Sub

    Private Sub txtItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.TextChanged

    End Sub

    Private Sub txtPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrice.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            'cancel keys
            e.Handled = True
        End If
    End Sub

    Private Sub txtSup_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
    Private Sub Add_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        _location = e.Location
    End Sub

    Private Sub Add_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then

            Dim MSize As New Size(_location)
            MSize.Width = e.X - _location.X
            MSize.Height = e.Y - _location.Y
            Me.Location = Point.Add(Me.Location, MSize)

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtPrice.Text = "0" Then
            MsgBox("Please input Price!")
        ElseIf txtBarcode.Text = "" Or txtBarcode.Text = vbNullChar Or txtBarcode.TextLength < 13 Then
            MsgBox("Error Barcode")
            txtBarcode.Focus()
        ElseIf txtItem.Text = "" Or txtItem.Text = vbNullChar Then
            MsgBox("Error Item")
            txtItem.Focus()
        ElseIf cboSup.Text = "" Then
            MsgBox("Error Supplier name")
            cboSup.Focus()
        Else
            If Button1.Text = "Add" Then
                strSQL = "SELECT * from Product where Barcode='" & txtBarcode.Text.ToUpper & "'"
                CONNECTION.Open()
                cmd = New MySqlCommand(strSQL, CONNECTION)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    MsgBox("Barcode is already taken!")
                    CONNECTION.Close()
                    dr.Close()
                    cmd.Dispose()
                Else
                    CONNECTION.Close()
                    dr.Close()
                    cmd.Dispose()
                    strSQL = "Insert into Product(Barcode,Supplier,Item,Category,Vat,Price,QTY) values ('" & txtBarcode.Text.ToUpper & "', '" & cboSup.Text.Trim & "', '" & txtItem.Text.ToUpper & "', '" & cboCat.Text.Trim & "','" & txtVat.Text.ToUpper & "', '" & txttemp.Text.ToUpper & "', '" & txtQTY.Text & "')"
                    Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                    da.Fill(ds)
                    CONNECTION.Close()
                    Me.Close()
                End If
            ElseIf Button1.Text = "Update" Then
                strSQL = "Update Product set Barcode = '" & txtBarcode.Text.Trim & "', Supplier = '" & cboSup.Text.Trim & "', Category = '" & cboCat.Text.Trim & "', Item = '" & txtItem.Text.ToUpper & "', QTY = '" & txtQTY.Text.ToUpper & "', Vat = '" & txtVat.Text.Trim & "', Price = '" & txttemp.Text & "' where ID = '" & lblID.Text.Trim & "'"
                Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                da.Fill(ds)
                CONNECTION.Close()
                Me.Close()
                ItemInfo.list()
            End If
        End If
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub txtQTY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQTY.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
          AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "," Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
End Class