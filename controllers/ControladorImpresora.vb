Public Class ControladorImpresora

    Public Function imprimirImagenes(ByVal reporte As Reporte) As Boolean


        Dim rp As New report
        Try
            For Each img As Imagen In reporte.listaImagenes
                rp.SetParameterValue(img.nombre, img.path)
            Next
            rp.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception
            'error de nombre de archivo
            Dim err As New errorHandler
            err.logError(ex, Me.ToString)
            Return False
        Finally
            rp = Nothing
        End Try


    End Function
End Class
