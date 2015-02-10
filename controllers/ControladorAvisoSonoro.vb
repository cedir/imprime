Public Class ControladorAvisoSonoro

    Const ubicacionSonidoCaptura = "C:\Windows\Media\Elemento emergente bloqueado de Windows XP.wav"
    Const ubicacionSonidoTercerCaptura = "C:\Windows\Media\Impresión completa de Windows XP.wav"
    Const ubicacionSonidoCuartaCaptura = "C:\Windows\Media\Notificación de Windows XP.wav"


    Public Sub EmitirSonido(ByVal reporte As Reporte)

        Select Case True

            Case reporte.listaImagenes.Count = 3
                My.Computer.Audio.Play(ubicacionSonidoTercerCaptura, AudioPlayMode.WaitToComplete)
            Case reporte.listaImagenes.Count = 4
                Dim i As Integer = 0
                Do Until i = 3
                    My.Computer.Audio.Play(ubicacionSonidoCuartaCaptura, AudioPlayMode.WaitToComplete)
                    i = i + 1
                Loop
            Case Else
                My.Computer.Audio.Play(ubicacionSonidoCaptura, AudioPlayMode.WaitToComplete)

        End Select

    End Sub

End Class
