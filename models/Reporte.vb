Imports System.IO
Imports System.Drawing.Imaging

Public Class Reporte

    Private m_lista As New List(Of Imagen)
    Private m_pathLocation As String

    Public Property listaImagenes() As List(Of Imagen)
        Get
            Return m_lista
        End Get
        Set(ByVal value As List(Of Imagen))
            m_lista = value
        End Set
    End Property
    Public Property pathLocation() As String
        Get
            Return m_pathLocation
        End Get
        Set(ByVal value As String)
            m_pathLocation = value
        End Set
    End Property
    Public Sub New()
        Me.listaImagenes = New List(Of Imagen)
        setPath()

    End Sub
    Private Sub setPath()
        Dim fecha As String = Date.Now.ToString()
        fecha = fecha.Replace(".", "")
        fecha = fecha.Replace("/", "-")
        fecha = fecha.Replace(":", "-")

        m_pathLocation = "z:\" + fecha + "\" 'prueba de directorio inexistente

    End Sub
    Public Function guardar() As Boolean

        Dim di As DirectoryInfo = Directory.CreateDirectory(Me.pathLocation)

        Try
            For Each img As Imagen In listaImagenes
                storeImage(img)
                img.guardar(Me.pathLocation)
            Next
            Return True

        Catch ex As Exception
            'logueo del error de escritura en disco
            Dim eH As New errorHandler
            eH.logError(ex)

            Return False
        End Try

    End Function
    Private Function storeImage(ByVal img As Imagen) As Object
        Dim ms As New MemoryStream
        Try
            img.imagen.Save(ms, ImageFormat.Jpeg)
            Return ms.GetBuffer
        Catch
            Return Nothing
        Finally
            ms = Nothing
        End Try
    End Function

End Class
