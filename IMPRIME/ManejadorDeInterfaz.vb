Imports CapaDeNegocios
Public Class ManejadorDeInterfaz
    Dim controladorSonido As New ControladorAvisoSonoro
    Dim controladorImagenes As New ControladorCapturaDeImagenes

    Public Sub capturarPantalla(ByVal captura As System.Drawing.Bitmap)

        controladorImagenes.guardarImagenEnDisco()
        emitirSonido()

    End Sub
    Public Sub emitirSonido()
        ' controladorSonido.emitirSonido()
    End Sub
End Class
