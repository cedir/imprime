Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms


Public Class frmScreenCapture

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ImageList1.ImageSize = New Size(200, 200)
        Me.controladorCaptura = New ControladorCapturaDeImagenes(4)
    End Sub

#Region "Variables de Instancia"
    Public Const KEY_ALT As Integer = &H1
    Public Const _HOTKEY As Integer = &H312
    Private controladorCaptura As ControladorCapturaDeImagenes
#End Region

#Region "Eventos"

    Private Sub frmScreenCapture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cerrarSegundaInstanciaDeAplicacion()
        Me.Visible = False
        Me.ntyCapturadorPantalla.Visible = True
        Me.ShowInTaskbar = True

        Application.DoEvents()
        RegisterHotKey(Me.Handle, 1, Nothing, Keys.F11)
        RegisterHotKey(Me.Handle, 2, KEY_ALT, Keys.Snapshot)
    End Sub
    Private Sub CapturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarToolStripMenuItem.Click
        Me.controladorCaptura.Procesar(Me)
    End Sub
    Private Sub GUARDARIMAGENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BorrarCapturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarCapturasToolStripMenuItem.Click
        Me.controladorCaptura.ReiniciarCapturas(Me)
    End Sub

    Private Sub ToolStripOpcion4_Click(sender As Object, e As EventArgs) Handles Opcion4.Click
        Me.Opcion4.Checked = True
        Me.Opcion6.Checked = False
        Me.controladorCaptura.ReiniciarCapturas(Me, 4)
    End Sub

    Private Sub ToolStripOpcion6_Click(sender As Object, e As EventArgs) Handles Opcion6.Click
        Me.Opcion4.Checked = False
        Me.Opcion6.Checked = True
        Me.controladorCaptura.ReiniciarCapturas(Me, 6)
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
            'creamos una espera, para que se ignoren otros procesos 
            SyncLock Me

                Dim id As IntPtr = m.WParam
                Select Case (id.ToString)
                    Case "1"
                        Me.controladorCaptura.Procesar(Me)
                    Case "2"
                        MessageBox.Show("APRETASTE SNAPSHIT")
                End Select

            End SyncLock
        End If
        MyBase.WndProc(m)
    End Sub
#End Region

#Region "Metodos de Instancia"

    Public Sub AgregaImagen(imagen As Imagen)
        ImageList1.Images.Add(imagen.imagen)
        ListView1.Items.Add(imagen.nombre, imagen.indice - 1)
    End Sub

    Public Sub BorrarTodo()
        Me.ImageList1.Images.Clear()
        Me.ListView1.Items.Clear()
    End Sub

    Private Sub cerrarSegundaInstanciaDeAplicacion()
        Dim procesos() As Process
        procesos = Process.GetProcessesByName(Application.ProductName.ToString)
        If (procesos.Length <= 1) Then
            ' Continuamos.
        Else 'Hay más de un proceso ejecutandose
            MessageBox.Show("Ya se está ejecutando el programa en otra ventana.La aplicacion se cerrará")
            Application.Exit()
        End If
    End Sub

#End Region

    Private Sub ntyCapturadorPantalla_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ntyCapturadorPantalla.MouseDoubleClick
        Me.Visible = True
        Me.SetTopLevel(True)
    End Sub

End Class
