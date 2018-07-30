Imports MySql.Data.MySqlClient

Public Class Login
    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Dim a, b, c, d
    Private _location As Point

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not System.IO.File.Exists(Application.StartupPath & "\config.ini") Then
            MsgBox("Missing config file...", MsgBoxStyle.Exclamation, "Error")
            MsgBox("Writing default setting!!!")
            WriteINI("Settings", "Server", "localhost", AppPath() & "\config.ini")
            WriteINI("Settings", "User", "root", AppPath() & "\config.ini")
            WriteINI("Settings", "Pwd", "pass", AppPath() & "\config.ini")
            MsgBox("Success!!! Change if wrong settings")
            End
        End If
        txtServer.Text = ReadIniValue(AppPath() & "\config.ini", "Settings", "Server")
        txtUser.Text = ReadIniValue(AppPath() & "\config.ini", "Settings", "User")
        txtPass.Text = ReadIniValue(AppPath() & "\config.ini", "Settings", "Pwd")
        txtID.Text = ""
        txtPassword.Text = ""
        txtID.Focus()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            strSQL = "SELECT * from Account where UserName='" & txtID.Text.Trim & "'" & "and Password='" & ToMD5(Me.txtPassword.Text.Trim) & "'"
            CONNECTION.Open()
            cmd = New MySqlCommand(strSQL, CONNECTION)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                MDIMain.Show()
                MDIMain.lblID.Text = dr!ID.ToString
                MDIMain.lblName.Text = dr!LName.ToString & "," & dr!FName.ToString
                MDIMain.lblUser.Text = dr!UserName.ToString
                MDIMain.lblStatus.Text = dr!Status.ToString
                MDIMain.lblTime.Text = TimeOfDay
                Me.Hide()
                dr.Close()
                CONNECTION.Close()
                Main.txtBarcode.Focus()
                cmd.Dispose()
                Dim date1 As String = "yy-MM-dd"
                strSQL = "Insert into UserLog(UserName,LoginTime,LoginDate) values ('" & txtID.Text.ToUpper & "', '" & TimeOfDay & "', '" & Format$(Date.Today, date1) & "')"
                Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
                da.Fill(ds)
                CONNECTION.Close()
            Else
                MsgBox("Login failed")
                CONNECTION.Close()
            End If
            dr.Close()
            CONNECTION.Close()
            cmd.Dispose()
        Catch ex As Exception
            Me.Hide()
            If MsgBox("No database found! do you want to restore?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "Error") = MsgBoxResult.Yes Then
                Database.Show()
            Else
                End
            End If
        End Try
        
    End Sub

    
    Private Sub Login_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        _location = e.Location
    End Sub


    Private Sub Login_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then

            Dim MSize As New Size(_location)
            MSize.Width = e.X - _location.X
            MSize.Height = e.Y - _location.Y
            Me.Location = Point.Add(Me.Location, MSize)

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        _location = e.Location
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then

            Dim MSize As New Size(_location)
            MSize.Width = e.X - _location.X
            MSize.Height = e.Y - _location.Y
            Me.Location = Point.Add(Me.Location, MSize)

        End If
    End Sub
End Class