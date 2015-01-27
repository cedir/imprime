Public Class errorHandler

    Private m_ex As Exception
    Public Property ex() As Exception
        Get
            Return m_ex
        End Get
        Set(ByVal value As Exception)
            m_ex = value
        End Set
    End Property

    Public Function logError(ByVal ex As Exception) As String
        Return ex.Message
    End Function

    Private Sub saveErrorToFile()

    End Sub

End Class
