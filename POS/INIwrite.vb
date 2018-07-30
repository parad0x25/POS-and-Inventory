
Imports System.Runtime.InteropServices

Module INIwrite
    'API Function to write information to the INI File
    Private Declare Auto Function WritePrivateProfileString Lib "kernel32" (ByVal lpAppName As String, _
                            ByVal lpKeyName As String, _
                            ByVal lpString As String, _
                            ByVal lpFileName As String) As Boolean

    Public Function WriteINI(ByVal sSection As String, ByVal sKeyName As String, ByVal sNewString As String, ByVal sINIFileName As String) As Boolean


        Call WritePrivateProfileString(sSection, sKeyName, sNewString, sINIFileName)

        WriteINI = (Err.Number = 0)

    End Function
End Module
