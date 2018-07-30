Public NotInheritable Class SplashScreen1


    Private _location As Point
    Private Sub SplashScreen1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub SplashScreen1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        _location = e.Location
    End Sub

    Private Sub SplashScreen1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If String.Compare(Control.MouseButtons.ToString(), "Left") = 0 Then

            Dim MSize As New Size(_location)
            MSize.Width = e.X - _location.X
            MSize.Height = e.Y - _location.Y
            Me.Location = Point.Add(Me.Location, MSize)

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Progressbar1.value = "0" Then
            Progressbar1.value = Progressbar1.value + 1
        ElseIf Progressbar1.value = "1" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\MySql.Data.dll") Then
                Timer1.Stop()
                MsgBox("Missing MySql.Data.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\MySql.Data.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "5" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\stdole.dll") Then
                Timer1.Stop()
                MsgBox("Missing stdole.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\stdole.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "10" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.configuration.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.configuration.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.configuration.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "15" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.Core.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.Core.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.Core.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "20" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.Data.DataSetExtensions.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.Data.DataSetExtensions.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.Core.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "25" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.Data.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.Data.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.Data.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "30" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.Drawing.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.Drawing.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.Drawing.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "35" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.Web.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.Web.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.Web.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "40" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.Xml.Linq.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.Xml.Linq.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.Xml.Linq.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "45" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\CrystalDecisions.CrystalReports.Engine.dll") Then
                Timer1.Stop()
                MsgBox("Missing CrystalDecisions.CrystalReports.Engine.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\CrystalDecisions.CrystalReports.Engine.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "50" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\config.ini") Then
                Timer1.Stop()
                MsgBox("Missing config.ini...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\config.ini"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "55" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\CrystalDecisions.Data.AdoDotNetInterop.dll") Then
                Timer1.Stop()
                MsgBox("Missing CrystalDecisions.Data.AdoDotNetInterop.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\CrystalDecisions.Data.AdoDotNetInterop.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "60" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\CrystalDecisions.ReportSource.dll") Then
                Timer1.Stop()
                MsgBox("Missing CrystalDecisions.ReportSource.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\CrystalDecisions.ReportSource.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "65" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\CrystalDecisions.Shared.dll") Then
                Timer1.Stop()
                MsgBox("Missing CrystalDecisions.Shared.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\CrystalDecisions.Shared.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "70" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\CrystalDecisions.VSDesigner.dll") Then
                Timer1.Stop()
                MsgBox("Missing CrystalDecisions.VSDesigner.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\CrystalDecisions.VSDesigner.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "75" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\CrystalDecisions.Web.dll") Then
                Timer1.Stop()
                MsgBox("Missing CrystalDecisions.Web.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\CrystalDecisions.Web.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "80" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\CrystalDecisions.Windows.Forms.dll") Then
                Timer1.Stop()
                MsgBox("Missing CrystalDecisions.Windows.Forms.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\CrystalDecisions.Windows.Forms.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "85" Then
            If Not System.IO.File.Exists(Application.StartupPath & "\System.Deployment.dll") Then
                Timer1.Stop()
                MsgBox("Missing System.Deployment.dll...")
                Application.Exit()
            Else
                lblDir.Text = Application.StartupPath & "\System.Deployment.dll"
                Progressbar1.value = Progressbar1.value + 1
            End If
        ElseIf Progressbar1.value = "99" Then
            lblDir.Text = "Successfully load system files"
            Progressbar1.value = Progressbar1.value + 1
        Else
            Progressbar1.value = Progressbar1.value + 1
        End If
        If Progressbar1.value = "100" Then
            Timer1.Stop()
            Login.Show()
            Login.Focus()
            Me.Hide()
        End If
    End Sub
End Class
