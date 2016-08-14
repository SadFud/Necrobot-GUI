Imports System.IO
Public Class Splash
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Credits.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://github.com/SadFud")

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        System.Diagnostics.Process.Start("https://reversecodes.wordpress.com/")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        System.Diagnostics.Process.Start("https://twitter.com/SadFud")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Auth.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Config.Show()
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkLabel3.Visible = False
        Dim dir As String = Directory.GetCurrentDirectory()
        Dim dirfinal As String = Directory.GetCurrentDirectory() & "\NecroBot.exe"
        If Not File.Exists(dirfinal) Then
            MsgBox("Debes ejecutar la aplicacion en el directorio raiz de tu necrobot.")
            'MsgBox(dirfinal)
            Me.Close()
        Else

        End If
    End Sub
End Class
