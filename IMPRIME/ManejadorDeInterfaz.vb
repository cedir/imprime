Imports CapaDeNegocios
Public Class ManejadorDeInterfaz
    Dim controladorSonido As New ControladorAvisoSonoro
    Dim controladorImagenes As New ControladorCapturaDeImagenes

    Public Sub capturarPantalla()
        controladorImagenes.guardarImagenEnDisco()
    End Sub
    Public Sub eventoTemporal()
        controladorSonido.emitirSonido()
    End Sub
End Class
