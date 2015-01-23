Public Class ControladorAvisoSonoro

    Const ubicacionSonido = "C:\Windows\Media\tada.wav"

    Public Sub EmitirSonido(ByVal reporte As Reporte)
        If reporte.listaImagenes.Count = 3 Then
            My.Computer.Audio.Play(ubicacionSonido, AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Public Sub New()

    End Sub
End Class
