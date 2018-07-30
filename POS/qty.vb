Public Class qty

    Private Sub qty_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Main.Timer2.Start()
        Main.Timer3.Start()
    End Sub

    Private Sub qty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not Val(txtqty.Text) = 0 Then
                Main.txtqty.Text = txtqty.Text
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub qty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.Timer2.Stop()
        Main.Timer3.Stop()
    End Sub

    Private Sub txtqty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtqty.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") _
         AndAlso e.KeyChar <> ControlChars.Back Then
            'cancel keys
            e.Handled = True
        End If
    End Sub
End Class