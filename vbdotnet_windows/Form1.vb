Imports System
Imports Microsoft
Imports Accessibility
Imports Microsoft.Win32
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Inhalt der Groupbox wird hier initalisiert
    ' Später soll hierdrauf auch die Ansteuerung und sub-classen laufen
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    ' Keine Ahnung


    ' Echt nutzlos hier
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Echt nutzlos hier
    End Sub


    Private Sub usernameTEXT_TextChanged(sender As Object, e As EventArgs) Handles usernameTEXT.TextChanged

    End Sub

    Private Sub passwortTEXT_TextChanged(sender As Object, e As EventArgs) Handles passwortTEXT.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Befehl
        '   net user /add [username] [password]#

        ' Variabalen
        Dim username = usernameTEXT.Text
        Dim password = passwortTEXT.Text
        Process.Start("CMD", "/C net user /add " + username + " " + password)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Enabled Then
            Dim folderhiddenKey As RegistryKey
            folderhiddenKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\Currentversion\Explorer\Advanced", True)
            folderhiddenKey.SetValue("HideFileExt", 0)
            Dim strg As Decimal
            strg = folderhiddenKey.GetValue("HideFileExt")
        End If
    End Sub

End Class
