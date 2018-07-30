Imports System.IO
Public Class Database
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim BrowseFolder As New FolderBrowserDialog
        BrowseFolder.ShowDialog()
        txtDir1.Text = BrowseFolder.SelectedPath
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Database Files (*.sql)|*.sql"
        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            txtDir2.Text = FileName.Trim
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If txtDir2.Text = "" Then
            MsgBox("Select Directory")
        Else
            Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "--user=root --password=pass --host=localhost --databases pos -r""" & txtDir2.Text & "")
        End If
    End Sub

    Private Sub Database_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIMain.MenuStrip.Enabled = True
        Application.Exit()
        MsgBox("Exit System")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If txtDir1.Text = "" Then
            MsgBox("Select Directory")
        Else
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = txtDir1.Text
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("C:\xampp\mysql\bin\mysql.exe --host=localhost --user=root --password=pass pos < " & txtFile.Text & Label3.Text & "")
            Timer1.Start()
            Dim str As String = mystreamreader.ReadToEnd
            MessageBox.Show(str)
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
        End If

    End Sub

    Private Sub Database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim tmp As String
        tmp = "cmd"
        For Each proc In Process.GetProcessesByName(tmp)
            proc.Kill()
        Next
        Timer1.Stop()
    End Sub
End Class