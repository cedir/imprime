Imports System
Imports System.IO
Imports System.Text


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

    Private Sub catchErrorToFile()
        Dim path As String = "c:\ErrorCapturaImagenes.txt"

        Using sw As StreamWriter = New StreamWriter(path, True)
            sw.WriteLine("-------------------")
            sw.Write("Fecha ...: ")
            sw.WriteLine(DateTime.Now)
            sw.Write("Mensaje de error ...: ")
            sw.WriteLine(ex.Message())
            sw.WriteLine("-------------------")
            sw.Close()

        End Using


    End Sub

End Class
