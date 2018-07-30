Public Class progressbar
    Dim myval As Integer = 0
    Dim mymax As Integer = 100
    Sub Setval()
        PictureBox1.Width = (Me.Width / mymax) * myval
    End Sub
    Property value() As Integer
        Get
            Return myval
        End Get
        Set(ByVal value As Integer)
            myval = value
            Setval()
        End Set
    End Property
    Property Maximum() As Integer
        Get
            Return mymax
        End Get
        Set(ByVal value As Integer)
            mymax = value
        End Set
    End Property

    Private Sub myprogressbar_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Setval()
    End Sub
End Class
