Public Class ControladorCapturaDeImagenes
    Private m_reporte As Reporte
    Public Property reporte() As Reporte
        Get
            Return m_reporte
        End Get
        Set(ByVal value As Reporte)
            m_reporte = value
        End Set
    End Property

    Public Function guardarCapturaEnDisco() As Boolean
        Try
            reporte.guardar()
        Catch ex As Exception
            'loguear por que no se recupero del error
            Dim err As New errorHandler
            err.logError(ex, "Error en ControladorImagenes, metodo guardarCapturaEnDisco " & Me.ToString())
            Return False
        End Try
    End Function
    Public Sub reiniciarCapturas()
        crearNuevoReporte()

    End Sub

    Private Sub crearNuevoReporte()
        Me.reporte = New Reporte
    End Sub

    Public Sub New()
        Me.crearNuevoReporte()
    End Sub
End Class
