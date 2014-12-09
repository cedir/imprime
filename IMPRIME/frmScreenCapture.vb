Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Public Class frmScreenCapture

#Region "Variables de Instancia"
    Private m_Manejador As New ManejadorDeInterfaz
    Public Const KEY_ALT As Integer = &H1
    Public Const _HOTKEY As Integer = &H312
#End Region

#Region "Eventos"
    Private Sub frmScreenCapture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start() 'hace falta un timer?
        Application.DoEvents()

        RegisterHotKey(Me.Handle, 1, KEY_ALT, Keys.F11)
        RegisterHotKey(Me.Handle, 2, Nothing, Keys.Snapshot)

    End Sub
    Private Sub TimerEventProcessor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        m_Manejador.emitirSonido()
    End Sub
    Private Sub CapturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarToolStripMenuItem.Click
        capturarPantalla()
    End Sub
    Private Sub GUARDARIMAGENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARIMAGENToolStripMenuItem.Click
        guardarCapturaDePantalla()
    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle, 1)
        UnregisterHotKey(Me.Handle, 2)
    End Sub
#End Region

#Region "Metodos de Instancia"
    Private Sub capturarPantalla()
        If Me.ListBox1.Items.Count <= 3 Then
            Dim area As Rectangle
            Dim capture As System.Drawing.Bitmap
            Dim graph As Graphics
            area = Screen.PrimaryScreen.Bounds
            capture = New System.Drawing.Bitmap(area.Width, area.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
            graph = Graphics.FromImage(capture)
            graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)
            PictureBox1.Image = capture
            capture.Tag = "captura uno"
            Me.ListBox1.Items.Add(capture)
        End If

        

    End Sub
    Private Sub guardarCapturaDePantalla()

        m_Manejador.capturarPantalla(PictureBox1.Image)
    End Sub

    <Runtime.InteropServices.DllImport("User32.dll")> _
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    End Function


    <Runtime.InteropServices.DllImport("User32.dll")> _
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    End Function

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = _HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "1"
                    Me.capturarPantalla()
                    
                Case "2"
                    MessageBox.Show("APRETASTE SNAPSHIT")
            End Select
        End If
        MyBase.WndProc(m)
    End Sub

#End Region

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.PictureBox1.Image = Me.ListBox1.SelectedItem
    End Sub

    Private Sub BorrarCapturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarCapturaToolStripMenuItem.Click
        Me.PictureBox1.Image = Nothing
        Me.ListBox1.Items.Clear()
    End Sub
End Class
