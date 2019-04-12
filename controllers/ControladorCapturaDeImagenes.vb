Public Class ControladorCapturaDeImagenes

    Private m_reporte As Reporte
    Dim notifications As New List(Of frmNotification)
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
        ShowNotification(Me.reporte.listaImagenes.Count.ToString())
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

            Return imagen

        Catch ex As Exception
            Dim eH As New errorHandler
            eH.logError(ex)
        End Try

        Return Nothing
    End Function

    Public Sub BorrarUltimaCaptura(ui As frmScreenCapture)
        Me.reporte.BorrarUltimaImagen()
        ui.BorrarUltimaImagen()
        ShowNotification(Me.reporte.listaImagenes.Count.ToString())
    End Sub


    Public Sub Procesar(ui As frmScreenCapture)

        If Not Me.reporte.Completo Then
            Dim imagen As Imagen = NuevaCaptura()

            Me.reporte.listaImagenes.Add(imagen)
            ui.AgregaImagen(imagen)
            ui.NotifyIcon1.Icon = SystemIcons.Application

            ShowNotification(imagen.indice.ToString())

            ControladorAvisoSonoro.EmitirSonido(Me.reporte.Advertir)
            If Me.reporte.Completo Then
                Me.GuardarCapturaEnDisco()
                ControladorImpresora.ImprimirImagenes(Me.reporte)
                ui.BorrarTodo()
                Me.ReiniciarCapturas(ui)
            End If
        End If

    End Sub

    Public Sub ShowNotification(index As String)
        Dim toastNotification As frmNotification = New frmNotification("Capturas", index, -1, FormAnimations.AnimationMethod.Slide, FormAnimations.AnimationDirection.Up)
        Dim item As frmNotification
        For Each item In notifications
            item.Close()
        Next
        toastNotification.Show()
        notifications.Add(toastNotification)
    End Sub

End Class
