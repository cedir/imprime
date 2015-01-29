Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms


Public Class frmScreenCapture

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ImageList1.ImageSize = New Size(200, 200)
        controladorAvisoSonoro = New ControladorAvisoSonoro
        Me.controladorCaptura = New ControladorCapturaDeImagenes
    End Sub

#Region "Variables de Instancia"
    Public Const KEY_ALT As Integer = &H1
    Public Const _HOTKEY As Integer = &H312


    Private controladorAvisoSonoro As ControladorAvisoSonoro
    Private controladorCaptura As ControladorCapturaDeImagenes
#End Region

#Region "Eventos"

    Private Sub frmScreenCapture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Visible = False
        Me.ntyCapturadorPantalla.Visible = True
        Me.ShowInTaskbar = True

        Application.DoEvents()
        RegisterHotKey(Me.Handle, 1, Nothing, Keys.F11)
        RegisterHotKey(Me.Handle, 2, KEY_ALT, Keys.Snapshot)
    End Sub
    Private Sub CapturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarToolStripMenuItem.Click
        guardadoEnListaDeCapturaPantalla()
    End Sub
    Private Sub GUARDARIMAGENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        guardarCapturaDePantalla()
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        imprimir()
    End Sub
    Private Sub BorrarCapturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        reiniciarCapturas()

    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle, 1)
        UnregisterHotKey(Me.Handle, 2)
    End Sub

#End Region

#Region "hot keys"
    <Runtime.InteropServices.DllImport("User32.dll")> _
      Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function
    <Runtime.InteropServices.DllImport("User32.dll")> _
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = _HOTKEY Then
            SyncLock Me
                Dim id As IntPtr = m.WParam
                Select Case (id.ToString)
                    Case "1"

                        'creamos una espera, para que se ignoren otros procesos 
                        My.Computer.Audio.Play("C:\Windows\Media\ding.wav", AudioPlayMode.WaitToComplete)
                        Me.guardadoEnListaDeCapturaPantalla()
                   

                    Case "2"
                        MessageBox.Show("APRETASTE SNAPSHIT")
                End Select
            End SyncLock

        End If
        MyBase.WndProc(m)
    End Sub
#End Region

#Region "Metodos de Instancia"

    Private Sub guardadoEnListaDeCapturaPantalla()

        If Me.controladorCaptura.reporte.listaImagenes.Count < 4 Then
            capturarPantalla()
            Select Case True
                Case Me.controladorCaptura.reporte.listaImagenes.Count = 3
                    controladorAvisoSonoro.EmitirSonido(controladorCaptura.reporte)
                Case controladorCaptura.reporte.listaImagenes.Count = 4
                    'aca vamos a bloquear el proceso, para que se guarden imagenes en disco, y luego se continue

                    Me.guardarCapturaDePantalla()
                    imprimir()
                    reiniciarCapturas()


            End Select
        End If

    End Sub
    Private Sub capturarPantalla()
        Dim screenshot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim screengrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
        Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(screengrab)
        g.CopyFromScreen(New Point(0, 0), New Point(0, 0), screenshot)
        ImageList1.Images.Add(screengrab)
        Try
            Dim imagen As New Imagen
            imagen.imagen = screengrab
            imagen.nombre = (controladorCaptura.reporte.listaImagenes.Count() + 1).ToString()
            controladorCaptura.reporte.listaImagenes.Add(imagen)
            ListView1.Items.Add(controladorCaptura.reporte.listaImagenes.Count.ToString(), controladorCaptura.reporte.listaImagenes.Count - 1)
        Catch ex As Exception
            Dim eH As New errorHandler
            eH.logError(ex)
        End Try
       
    End Sub
    Private Sub guardarCapturaDePantalla()
        controladorCaptura.guardarCapturaEnDisco()
    End Sub
    Private Sub reiniciarCapturas()
        controladorCaptura.reiniciarCapturas()
        Me.ListView1.Items.Clear()
    End Sub
    Private Sub imprimir()
        Dim controlador As New ControladorImpresora
        controlador.imprimirImagenes(Me.controladorCaptura.reporte)
    End Sub
#End Region

    Private Sub ntyCapturadorPantalla_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ntyCapturadorPantalla.MouseDoubleClick
        Me.Visible = True
        Me.SetTopLevel(True)
    End Sub
End Class
