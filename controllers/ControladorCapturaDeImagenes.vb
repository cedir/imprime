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

    Public Function GuardarCapturaEnDisco() As Boolean
        Try
            reporte.guardar()
        Catch ex As Exception
            'loguear por que no se recupero del error
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Public Sub ReiniciarCapturas(ui As frmScreenCapture)
        ReiniciarCapturas(ui, Me.reporte.imagenes)
    End Sub

    Public Sub ReiniciarCapturas(ui As frmScreenCapture, imagenes As Integer)
        CrearNuevoReporte(imagenes)
        ui.BorrarTodo()
    End Sub

    Private Sub CrearNuevoReporte(imagenes As Integer)
        Me.reporte = Nothing
        Me.reporte = New Reporte(imagenes)
    End Sub

    Public Sub New(imagenes As Integer)
        Me.CrearNuevoReporte(imagenes)
    End Sub

    Private Function CapturaPantalla() As Bitmap
        Dim screenSize As Size = Screen.PrimaryScreen.Bounds.Size()
        Dim screengrab As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Graphics.FromImage(screengrab).CopyFromScreen(Point.Empty, Point.Empty, screenSize)
        Return screengrab
    End Function

    Private Function NuevaCaptura() As Imagen

        Try

            Dim screengrab As Bitmap = Me.CapturaPantalla()
            Dim count As Integer = 1 + Me.reporte.listaImagenes.Count()

            Dim imagen As New Imagen
            imagen.imagen = screengrab
            imagen.indice = count
            imagen.nombre = count.ToString()

            Me.reporte.listaImagenes.Add(imagen)

            Return imagen

        Catch ex As Exception
            Dim eH As New errorHandler
            eH.logError(ex)
        End Try

    End Function

    Public Sub Procesar(ui As frmScreenCapture)

        If Not Me.reporte.Completo Then
            Dim imagen As Imagen = NuevaCaptura()

            ui.AgregaImagen(imagen)
            ControladorAvisoSonoro.EmitirSonido(Me.reporte.Completo)
            If Me.reporte.Completo Then
                Me.GuardarCapturaEnDisco()
                ControladorImpresora.ImprimirImagenes(Me.reporte)
                ui.BorrarTodo()
                Me.ReiniciarCapturas(ui)
            End If
        End If

    End Sub

End Class
