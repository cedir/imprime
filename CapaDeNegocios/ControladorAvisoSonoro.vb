Public Class ControladorAvisoSonoro

    'Private Function checkCantImagenes() As Integer
    '    Dim fileCount1 As Integer = My.Computer.FileSystem.GetFiles("C:\IMPRESION\IMAGENES ENDOSCOPIO\").Count
    '    'Dim fileCount1 As Integer = My.Computer.FileSystem.GetFiles("C:\IMPRESION\").Count
    '    Return fileCount1
    'End Function

    'Public Sub emitirSonido()
    '    Dim m_flag As Boolean = False
    '    Dim cantImagenes As Integer

    '    'aca ponemos codigo para checkear lo que se haga , cuando hay un evento termporal
    '    cantImagenes = checkCantImagenes()
    '    If cantImagenes = 1 Then
    '        m_flag = False
    '    End If

    '    If cantImagenes = 4 And m_flag = False Then
    '        For i As Integer = 0 To 4
    '            My.Computer.Audio.Play("C:\IMPRESION\ding.wav", AudioPlayMode.WaitToComplete)
    '            i = i + 1
    '        Next
    '        m_flag = True
    '        'My.Computer.Audio.Play("C:\IMPRESION\Fin Impresion.wav")
    '    End If
    ' End Sub

    'vamos a utilizar un metodo que no se ejectute con timer, y de esta manera, evitar un uso excesivo de 
    'recursos. 
    Public Sub emitirSonido(ByVal nro As Integer)
        If nro = 3 Then
            For i As Integer = 0 To 3
                My.Computer.Audio.Play("C:\WINDOWS\Media\notify.wav", AudioPlayMode.WaitToComplete)
                i = i + 1
            Next
        End If
    End Sub
End Class
