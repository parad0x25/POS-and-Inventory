Imports MySql.Data.MySqlClient
Public Class Acount
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Dim a, b, c, d
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Save" Then
            If txtFName.Text = "" Or txtFName.Text = vbNullChar Then
                MsgBox("Error First Name")
                txtFName.Focus()
            ElseIf txtLname.Text = "" Or txtLname.Text = vbNullChar Then
                MsgBox("Error Last Name")
                txtLname.Focus()
            ElseIf txtContact.Text = "" Or txtContact.Text = vbNullChar Then
                MsgBox("Error Contact")
                txtContact.Focus()
            ElseIf txtAddress.Text = "" Or txtAddress.Text = vbNullChar Then
                MsgBox("Error Address")
                txtAddress.Focus()
            ElseIf txtuser.Text = "" Or txtuser.Text = vbNullChar Then
                MsgBox("Error User")
                txtuser.Focus()
            ElseIf txtPassword.Text <> txtPassword2.Text Then
                MsgBox("Password did not match")
                txtPassword.Text = ""
                txtPassword2.Text = ""
                txtPassword.Focus()
            ElseIf txtPassword.Text = "" Or txtPassword.Text = vbNullChar Then
                MsgBox("Error Password")
                txtPassword.Focus()
            Else
                cmd.Dispose()
                CONNECTION.Close()
                strSQL = "SELECT * from Account where UserName='" & txtuser.Text.ToUpper & "'"
                CONNECTION.Open()
                cmd = New MySqlCommand(strSQL, CONNECTION)
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    MsgBox("UserName is already taken!")
                    CONNECTION.Close()
                    dr.Close()
                    cmd.Dispose()
                Else
                    CONNECTION.Close()
                    dr.Close()
                    cmd.Dispose()
                    strSQL = "Insert into Account(FName,LName,Contact,Address,UserName,Password,Status) values ('" & txtFName.Text.ToUpper & "', '" & txtLname.Text.ToUpper & "', '" & txtContact.Text.ToUpper & "', '" & txtAddress.Text.ToUpper & "', '" & txtuser.Text.ToUpper & "', '" & ToMD5(txtPassword.Text.Trim) & "', '" & cboStatus.Text & "')"
                    Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                    da.Fill(ds)
                    CONNECTION.Close()
                    Me.Close()
                    AccountInfo.list()
                End If
            End If
        ElseIf Button1.Text = "Update" Then
            If txtFName.Text = "" Or txtFName.Text = vbNullChar Then
                MsgBox("Error First Name")
                txtFName.Focus()
            ElseIf txtLname.Text = "" Or txtLname.Text = vbNullChar Then
                MsgBox("Error Last Name")
                txtLname.Focus()
            ElseIf txtContact.Text = "" Or txtContact.Text = vbNullChar Then
                MsgBox("Error Contact")
                txtContact.Focus()
            ElseIf txtAddress.Text = "" Or txtAddress.Text = vbNullChar Then
                MsgBox("Error Address")
                txtAddress.Focus()
            ElseIf txtuser.Text = "" Or txtuser.Text = vbNullChar Then
                MsgBox("Error User")
                txtuser.Focus()
            ElseIf txtPassword.Text <> txtPassword2.Text Then
                MsgBox("Password did not match")
                txtPassword.Text = ""
                txtPassword2.Text = ""
                txtPassword.Focus()
            ElseIf txtPassword.Text = "" Or txtPassword.Text = vbNullChar Then
                MsgBox("Error Password")
                txtPassword.Focus()
            Else
                strSQL = "Update Account set FName = '" & txtFName.Text.Trim & "', Lname = '" & txtLname.Text.Trim & "', Contact = '" & txtContact.Text.Trim & "', Address = '" & txtAddress.Text.Trim & "', UserName = '" & txtuser.Text.Trim & "', Password = '" & ToMD5(txtPassword.Text.Trim) & "', Status = '" & cboStatus.Text & "' where ID = '" & lblID.Text.Trim & "'"
                Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                da.Fill(ds)
                CONNECTION.Close()
                Me.Close()
                AccountInfo.txtTemp.Text = ""
                AccountInfo.list()
            End If
        End If


    End Sub

    Private Sub Acount_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        cboStatus.Text = "CASHER"
        txtFName.Text = ""
        txtLname.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
        txtPassword.Text = ""
        txtPassword2.Text = ""
        txtuser.Text = ""
    End Sub

    Private Sub Acount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtContact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContact.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
            AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
End Class