Imports system
Imports Imprime.My.Resources


Public Class ControladorAvisoSonoro


    Const SONIDO_CAPTURA = "\ding.wav"
    Const SONIDO_IMPRESIONCOMPLETA = "\Impresión completa de Windows XP.wav"


    Public Shared Sub EmitirSonido(ByVal advertir As Boolean)
        If advertir Then
            If IO.File.Exists(My.Settings.pathSonidoCapturas & SONIDO_IMPRESIONCOMPLETA) Then
                My.Computer.Audio.Play(My.Settings.pathSonidoCapturas & SONIDO_IMPRESIONCOMPLETA, AudioPlayMode.BackgroundLoop)
            End If
        Else
            If IO.File.Exists(My.Settings.pathSonidoCapturas & SONIDO_CAPTURA) Then
                My.Computer.Audio.Play(My.Settings.pathSonidoCapturas & SONIDO_CAPTURA, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub
End Class
