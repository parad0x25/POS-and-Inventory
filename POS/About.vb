Imports System.Windows.Forms

Public Class About

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub About_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMain.MenuStrip.Enabled = True
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim CPUName As String
        CPUName = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\SYSTEM\CentralProcessor\0", "ProcessorNameString", Nothing)
        Label33.Text = CPUName
        lblcname.Text = System.Environment.MachineName
        lblcuser.Text = System.Environment.UserName
        lblos.Text = My.Computer.Info.OSFullName
        lblplat.Text = My.Computer.Info.OSPlatform
        lblver.Text = My.Computer.Info.OSVersion
        lbllang.Text = My.Computer.Info.InstalledUICulture.ToString
    End Sub
End Class
