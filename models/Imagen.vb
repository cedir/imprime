Public Class Imagen

    Dim m_nombre As String
    Dim m_path As String
    Dim m_imagen As System.Drawing.Bitmap
    Dim m_extension As String

    Public Property path() As String
        Get
            Return m_path
        End Get
        Set(ByVal value As String)
            m_path = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return m_nombre
        End Get
        Set(ByVal value As String)
            m_nombre = value
        End Set
    End Property
    Public ReadOnly Property nombreCompleto() As String
        Get
            Return Me.nombre + Me.extension
        End Get
    End Property
    Public Property extension() As String
        Get
            Return m_extension
        End Get
        Set(ByVal value As String)
            m_extension = value
        End Set
    End Property
    Public Property imagen() As System.Drawing.Bitmap
        Get
            Return m_imagen
        End Get
        Set(ByVal value As System.Drawing.Bitmap)
            m_imagen = value
        End Set
    End Property
    Public Sub guardar(ByVal pathLocation As String)
        Me.path = pathLocation + Me.nombreCompleto
        Me.imagen.Save(Me.path)
    End Sub
    Public Sub New()
        Me.extension = ".jpg"
    End Sub
End Class
