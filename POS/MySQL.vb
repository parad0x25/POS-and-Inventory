Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient



Module MySQL
    Public ConnString As String = "server=" & Login.txtServer.Text.Trim & ";user id=" & Login.txtUser.Text.Trim & ";password=" & Login.txtPass.Text.Trim & ";database=pos"
    Public CONNECTION As New MySqlConnection(ConnString)

    Public Function ToMD5(ByVal str As String) As String
        Dim md5 As New MD5CryptoServiceProvider

        Dim bt() As Byte = Encoding.ASCII.GetBytes(str)
        bt = md5.ComputeHash(bt)
        Dim fstr As String = ""

        For Each b As Byte In bt
            fstr &= b.ToString("x2")
        Next
        Return fstr.Remove(fstr.Length - 13).ToUpper
    End Function
End Module
