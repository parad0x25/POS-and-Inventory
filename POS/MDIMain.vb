Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class MDIMain

    Public ds As New DataSet
    Public strSQL As String
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Private Sub MDIMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        CONNECTION.Close()
        Dim pattern As String = "yy-MM-dd"
        strSQL = "Update UserLog set UserName = '" & lblUser.Text & "', LogoutTime = '" & TimeOfDay & "', LogoutDate = '" & Format$(Date.Today, pattern) & "' where LoginTime = '" & lblTime.Text & "'"
        Dim da As New MySqlDataAdapter(strSQL, CONNECTION)
        da.Fill(ds)
        CONNECTION.Close()
        Application.Exit()
    End Sub
    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoguotToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoguotToolStripMenuItem.Click
        Login.Show()
        Login.txtID.Text = ""
        Login.txtPassword.Text = ""
        Login.txtID.Focus()
        Me.Hide()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        About.ShowDialog()

    End Sub

    Private Sub ProductsMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductsMaintenanceToolStripMenuItem.Click
        ItemInfo.ShowDialog()
    End Sub

    Private Sub SuppliersMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersMaintenanceToolStripMenuItem.Click
        Supplier.ShowDialog()
    End Sub


    Private Sub UserMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserMaintenanceToolStripMenuItem.Click

        AccountInfo.ShowDialog()

    End Sub

    Private Sub BackupAndRestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupAndRestoreToolStripMenuItem.Click
        Database.ShowDialog()
    End Sub

    Private Sub AuditTrailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditTrailToolStripMenuItem.Click
        UserLog.ShowDialog()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        category.ShowDialog()
    End Sub

    Private Sub SalesInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesInvoiceToolStripMenuItem.Click
        Main.ShowDialog()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DeliveryOfItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryOfItemsToolStripMenuItem.Click
        Delivery.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("C:\WINDOWS\system32\calc.exe")
    End Sub

    Private Sub ProductStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductStockToolStripMenuItem.Click
        Stock.ShowDialog()
    End Sub

    Private Sub SystemInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SystemInformationToolStripMenuItem.Click
        Shell("C:\Program Files\Common Files\Microsoft Shared\MSInfo\msinfo32.exe")
    End Sub

    Private Sub UserManualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CategoryOfProductMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BadOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BadOrderToolStripMenuItem.Click
        BadOrder.ShowDialog()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceToolStripMenuItem.Click
        ViewInvoice.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Shell("C:\WINDOWS\system32\calc.exe")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ItemInfo.ShowDialog()
    End Sub
    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.BackColor = Color.Blue
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Main.ShowDialog()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        CheckSale.ShowDialog()
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.BackColor = Color.Blue
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.BackColor = Color.Blue
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.BackColor = Color.Transparent
    End Sub

    Private Sub PictureBox5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.BackColor = Color.Blue
    End Sub
End Class
