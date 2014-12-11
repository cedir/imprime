Imports CapaDeNegocios
Public Class ManejadorDeInterfaz
    Dim controladorSonido As New ControladorAvisoSonoro
    Dim controladorImagenes As New ControladorCapturaDeImagenes

    Public Sub capturarPantalla(ByVal l As ImageList.ImageCollection)
        controladorImagenes.guardarImagenEnDisco()
    End Sub
    Public Sub emitirSonido(ByVal nroImagenes)
        controladorSonido.emitirSonido(nroImagenes)
    End Sub
End Class
