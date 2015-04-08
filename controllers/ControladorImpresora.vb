Public Class ControladorImpresora

    'Public Sub imprimirImagenes(ByVal reporte As Reporte)

    '    Dim rp As New CrystalReport1
    '    Try
    '        For Each img As Imagen In reporte.listaImagenes
    '            ' rp.SetParameterValue(img.nombre, img.path)
    '        Next
    '        rp.PrintToPrinter(1, False, 0, 0)
    '    Catch ex As Exception
    '        'error de nombre de archivo
    '        MessageBox.Show("no se ha podido imprimir, debido a que la imagen no fue guardada.")
    '    Finally
    '        ' rp = Nothing
    '    End Try


    'End Sub


    Public Sub imprimirImagenes(ByVal reporte As Reporte)

        Dim ic As New ImageConverter


        Dim i As New imagenes

        Dim rp As New CrystalReport1

        Dim row As DataRow
        row = i.Tables("imagenes").NewRow

        row("imagen1") = DirectCast(reporte.listaImagenes(0).imagen, Byte)
        i.Tables(0).Rows.Add(row)
        'reporte.listaImagenes(0)


        rp.SetDataSource(i.Tables(0))
        rp.PrintToPrinter(1, False, 0, 0)

    End Sub

End Class
