Imports System.IO



Public Class Auth
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textuser.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkproxy.CheckedChanged
        If checkproxy.Checked = True Then
            textphost.Enabled = True
            textpport.Enabled = True
        Else
            textphost.Enabled = False
            textpport.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles textphost.TextChanged

    End Sub

    Private Sub Auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkproxy.Checked = True
        checkproxyauth.Checked = True
        'radioptc.Enabled = False
    End Sub

    Private Sub checkproxyauth_CheckedChanged(sender As Object, e As EventArgs) Handles checkproxyauth.CheckedChanged
        If checkproxyauth.Checked = True Then
            textpuser.Enabled = True
            textppass.Enabled = True
        Else
            textpuser.Enabled = False
            textppass.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path As String = Directory.GetCurrentDirectory()
        'Dim config As String = "\config\"
        Dim fic As String = path & "\config\" & "authtemp.txt"
        'Const fic As String = "D:\authtemp.txt"
        Dim ficfinal As String = path & "\config\" & "auth.json"
        'Const ficfinal As String = "D:\auth.json"
        Dim tipo As String
        Dim nulo As String = "null"
        Dim proxy As String
        Dim proxyauth As String
        Dim usuario As String = textuser.Text
        Dim contraseña As String = textpass.Text
        Dim phost As String
        Dim pport As String
        Dim puser As String
        Dim ppass As String
        Dim usuariogg As String
        Dim contraseñagg As String
        Dim usuarioptc As String
        Dim contraseñaptc As String
        'Dim deviceid As String = "hz8zk5ulv3tvbu3l"
        Dim deviceconstante1 As String = "saeywf"
        Dim deviceconstante2 As String = "añkl"
        Dim deviceconstante3 As String = "ok"
        'empieza la generacion de valores random para el device id
        Dim numero As New Random
        Dim deviceid As String
        deviceid = numero.Next(0, 8).ToString("0")
        Dim Cargando_Letras As String = "abcdefghijklmnopqrstuvwxyz0123456789"
        Dim Letras As New Random
        Dim resultado1 As String = ""
        Dim resultado2 As String = ""
        Dim resultado3 As String = ""
        Dim resultado4 As String = ""
        Dim ag = 1
        Dim sp = 0
        Dim longitud As String = Cargando_Letras.Length()
        While sp < ag
            resultado1 = Cargando_Letras(Letras.Next(0, longitud))
            resultado2 = Cargando_Letras(Letras.Next(0, longitud))
            resultado3 = Cargando_Letras(Letras.Next(0, longitud))
            resultado4 = Cargando_Letras(Letras.Next(0, longitud))
            sp += 1
        End While
        deviceid = deviceconstante2 & resultado1 & resultado2 & deviceconstante1 & resultado3 & deviceconstante3 & resultado4
        'MsgBox(fic)
        'MsgBox(ficfinal)
        'MsgBox(deviceid)

        'verifica que se han rellenado los campos de login, se podria hacer con un while
        If textpass.Text = "Password" Or textuser.Text = "Username" Or textpass.Text = "" Or textuser.Text = "" Then
            MsgBox("Error. Please, fix your logging credentials")
        End If
        'mira si el auth existe, y si existe lo borra antes de seguir
        If File.Exists(ficfinal) Then
            File.Delete(ficfinal)
        End If
        'verificaciones para las modificaciones en el archivo
        If radiogoogle.Checked = True Then
                tipo = "google"
                usuariogg = usuario
                contraseñagg = contraseña
                usuarioptc = ""
                contraseñaptc = ""
            ElseIf radioptc.Checked = True Then
                tipo = "ptc"
                usuarioptc = usuario
                contraseñaptc = contraseña
                usuariogg = ""
                contraseñagg = ""
            End If
            If checkproxy.Checked = True Then
                proxy = "true"
                phost = textphost.Text
                pport = textpport.Text
            Else
                proxy = "false"
                phost = ""
                pport = ""
            End If
        If checkproxyauth.Checked = True Then
            proxyauth = "true"
            puser = textpuser.Text
            ppass = textppass.Text
        Else
            proxyauth = "false"
            puser = ""
            ppass = ""
        End If
        'empieza la escritura del archivo
        Dim sw As New System.IO.StreamWriter(fic, True)
        sw.WriteLine("{")
        sw.WriteLine("  ""AuthType""" & ": " & """" & tipo & """" & ",")
        sw.WriteLine("  ""GoogleUsername""" & ": " & """" & usuariogg & """" & ",")
        sw.WriteLine("  ""GooglePassword""" & ": " & """" & contraseñagg & """" & ",")
        sw.WriteLine("  ""PtcUsername""" & ": " & """" & usuarioptc & """" & ",")
        sw.WriteLine("  ""PtcPassword""" & ": " & """" & contraseñaptc & """" & ",")
        sw.WriteLine("  ""UseProxy""" & ": " & proxy & ",")
        sw.WriteLine("  ""UseProxyHost""" & ": " & """" & phost & """" & ",")
        sw.WriteLine("  ""UseProxyPort""" & ": " & """" & pport & """" & ",")
        sw.WriteLine("  ""UseProxyAuthentication""" & ": " & proxyauth & ",")
        sw.WriteLine("  ""UseProxyUsername""" & ": " & """" & puser & """" & ",")
        sw.WriteLine("  ""UseProxyPassword""" & ": " & """" & ppass & """" & ",")
        'sw.WriteLine("  ""DevicePackageName""" & ": " & """nexus7gen2""" & ",")
        sw.WriteLine("  ""DeviceId""" & ": " & """" & deviceid & """" & ",")
        sw.WriteLine("  ""AndroidBoardName""" & ": " & """flo""" & ",")
        sw.WriteLine("  ""AndroidBootloader""" & ": " & """FLO-04.07""" & ",")
        sw.WriteLine("  ""DeviceBrand""" & ": " & """google""" & ",")
        sw.WriteLine("  ""DeviceModel""" & ": " & """Nexus 7""" & ",")
        sw.WriteLine("  ""DeviceModelIdentifier""" & ": " & """razor""" & ",")
        sw.WriteLine("  ""DeviceModelBoot""" & ": " & """qcom""" & ",")
        sw.WriteLine("  ""HardwareManufacturer""" & ": " & """asus""" & ",")
        sw.WriteLine("  ""HardwareModel""" & ": " & """Nexus 7""" & ",")
        sw.WriteLine("  ""FirmwareBrand""" & ": " & """razor""" & ",")
        sw.WriteLine("  ""FirmwareTags""" & ": " & """release-keys""" & ",")
        sw.WriteLine("  ""FirmwareType""" & ": " & """user""" & ",")
        sw.WriteLine("  ""FirmwareFingerprint""" & ": " & """google/razor/flo:6.0.1/MOB30P/2960889:user/release-keys""" & ",")
        sw.WriteLine("}")
        sw.WriteLine("")
        sw.Close()
            Rename(fic, ficfinal)
        MsgBox("Auth.json generated in " & ficfinal & ".")
        Me.Close()
    End Sub
End Class