Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms


Public Class frmScreenCapture
    Private m_Manejador As New ManejadorDeInterfaz

    Private Sub GUARDARIMAGENToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARIMAGENToolStripMenuItem.Click
        guardar()
    End Sub
    Private Sub guardar()
        m_Manejador.capturarPantalla()
    End Sub

#Region "Eventos"
    Private Sub frmScreenCapture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
        Application.DoEvents()
    End Sub
    Private Sub TimerEventProcessor(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        m_Manejador.eventoTemporal()
    End Sub
    Private Sub CapturarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturarToolStripMenuItem.Click
        capturarPantalla()
    End Sub

#End Region

#Region "Metodos de Instancia"
    Private Sub capturarPantalla()
        Dim area As Rectangle
        Dim capture As System.Drawing.Bitmap
        Dim graph As Graphics
        area = Screen.PrimaryScreen.Bounds
        capture = New System.Drawing.Bitmap(area.Width, area.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(capture)
        graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size, CopyPixelOperation.SourceCopy)
        PictureBox1.Image = capture
    End Sub
#End Region

    
End Class
