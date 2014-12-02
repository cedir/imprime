Imports CapaDeNegocios
Public Class ManejadorDeInterfaz
    Dim controladorSonido As New ControladorAvisoSonoro
    Dim controladorImagenes As New ControladorCapturaDeImagenes

    Public Sub eventoTemporal()
        controladorSonido.emitirSonido()
    End Sub
End Class
