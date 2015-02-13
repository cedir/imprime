Imports System
Imports System.IO
Imports System.Text


Public Class errorHandler
    Const path As String = "c:\ErrorCapturaImagenes.txt"

    Public Sub logError(ByVal exeption As Exception, Optional ByVal mensajesAdicionales As String = "")

        Using sw As StreamWriter = New StreamWriter(path, True)
            sw.WriteLine("-------------------")
            sw.Write("Fecha ...: ")
            sw.WriteLine(DateTime.Now)
            sw.Write("Mensaje de error ...: ")
            sw.WriteLine(exeption.Message())
            If mensajesAdicionales <> "" Then
                sw.Write("Mensajes adicionales.: ")
                sw.WriteLine(mensajesAdicionales)
            End If
            sw.WriteLine("-------------------")
            sw.Close()

        End Using
    End Sub

    Public Sub New()
    End Sub
End Class
