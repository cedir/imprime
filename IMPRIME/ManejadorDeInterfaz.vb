Imports CapaDeNegocios
Public Class ManejadorDeInterfaz
    Dim controladorSonido As New ControladorAvisoSonoro
    Dim controladorImagenes As New ControladorCapturaDeImagenes

    Public Function guardarCapturaPantalla(ByVal lista As List(Of Drawing.Bitmap)) As Boolean

        If Not controladorImagenes.guardarCapturaEnDisco(lista) Then
            Return False
        End If
        Return True
    End Function
    Public Sub emitirSonido(ByVal nroImagenes)
        controladorSonido.emitirSonido(nroImagenes)
    End Sub
End Class
