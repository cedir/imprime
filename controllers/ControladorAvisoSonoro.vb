Public Class ControladorAvisoSonoro

    Const ubicacionSonidoCaptura = "D:\CEDIR CAPTURADOR\ding.wav"
    Const ubicacionSonidoTercerCaptura = "C:\Windows\Media\Impresión completa de Windows XP.wav"
    Const ubicacionSonidoCuartaCaptura = "C:\Windows\Media\Notificación de Windows XP.wav"


    Public Sub EmitirSonido(ByVal reporte As Reporte)

        Select Case True

            Case reporte.listaImagenes.Count = 3
                ' My.Computer.Audio.Play(ubicacionSonidoTercerCaptura, AudioPlayMode.Background)
            Case Else
                ' My.Computer.Audio.Play(ubicacionSonidoCaptura, AudioPlayMode.Background)
        End Select

    End Sub

End Class
