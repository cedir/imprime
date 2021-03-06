Imports CrystalDecisions.CrystalReports.Engine

Public Class ControladorImpresora

    Public Shared Sub ImprimirImagenes(ByVal reporte As Reporte)
        Dim rp As ReportClass = reporte.ClaseReporte()
        Try
            For Each img As Imagen In reporte.listaImagenes
                rp.SetParameterValue(img.nombre, img.path)
            Next
            rp.PrintToPrinter(1, False, 0, 0)
        Catch ex As Exception
            'error de nombre de archivo
            MessageBox.Show("no se ha podido imprimir, debido a que la imagen no fue guardada.")
        Finally
            rp = Nothing
        End Try
    End Sub
End Class
