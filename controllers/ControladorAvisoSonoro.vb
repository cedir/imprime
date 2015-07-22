Imports system
Imports Imprime.My.Resources


Public Class ControladorAvisoSonoro


    Const SONIDO_CAPTURA = "\ding.wav"
    Const SONIDO_IMPRESIONCOMPLETA = "\Impresión completa de Windows XP.wav"


    Public Sub EmitirSonido(ByVal reporte As Reporte)
        Select Case True
            Case reporte.listaImagenes.Count = 3
                My.Computer.Audio.Play(My.Settings.pathSonidoCapturas & SONIDO_IMPRESIONCOMPLETA, AudioPlayMode.Background)
            Case Else
                My.Computer.Audio.Play(My.Settings.pathSonidoCapturas & SONIDO_CAPTURA, AudioPlayMode.Background)
        End Select

    End Sub

End Class
