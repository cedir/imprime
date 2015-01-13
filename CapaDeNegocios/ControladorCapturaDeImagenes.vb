Imports System.Drawing.Imaging
Imports System.IO
Public Class ControladorCapturaDeImagenes

    Public Function guardarCapturaEnDisco(ByVal lista As List(Of Drawing.Bitmap)) As Boolean
        'Dim fecha As String = Date.Today.Year.ToString() + "-" + Date.Today.Month.ToString() + "-" + Date.Today.Day.ToString() + Date.Now.ToString()
        Dim fecha As String = Date.Now.ToString()
        fecha = fecha.Replace(".", "")
        fecha = fecha.Replace("/", "-")
        fecha = fecha.Replace(":", "-")

        Dim path As String = "d:\" + fecha
        Try

            Dim di As DirectoryInfo = Directory.CreateDirectory(path)
            For Each i As Drawing.Bitmap In lista
                StoreImage(i)
                i.Save(path, ImageFormat.Bmp)
            Next

             Return True

        Catch e As Exception
            Return False
            'aca hay que hacer una llamada a un log de errores, para ver si hubo error de directorios
            '  Return "nO SE HA PODIDO GUARDAR LA CAPTURA EN.....   " + path + e.ToString()
        Finally
        End Try
    End Function
    Private Function StoreImage(ByVal bm As Drawing.Bitmap) As Object

        Dim ms As New MemoryStream
        Try

            bm.Save(ms, ImageFormat.Bmp)


            Return ms.GetBuffer

        Catch
            Return Nothing
        End Try

    End Function

End Class
