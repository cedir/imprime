Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms
Public Class frmScreenCapture

#Region "Variables de Instancia"
    Private m_Manejador As New ManejadorDeInterfaz
    Public Const KEY_ALT As Integer = &H1
    Public Const _HOTKEY As Integer = &H312

    Private imagenes As New List(Of Drawing.Bitmap)
#End Region

#Region "Eventos"
    Private Sub frmScreenCapture_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Application.DoEvents()
        RegisterHotKey(Me.Handle, 1, Nothing, Keys.F11)
        RegisterHotKey(Me.Handle, 2, KEY_ALT, Keys.Snapshot)
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

        Select Case True
            Case Me.imagenes.Count < 4
                Dim screenshot As Size = New Size(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
                Dim screengrab As New Bitmap(My.Computer.Screen.Bounds.Width, My.Computer.Screen.Bounds.Height)
                Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(screengrab)
                g.CopyFromScreen(New Point(0, 0), New Point(0, 0), screenshot)
                ImageList1.Images.Add(screengrab)
                imagenes.Add(screengrab)
                ListView1.Items.Add(imagenes.Count.ToString(), imagenes.Count - 1)
                m_Manejador.emitirSonido(Me.imagenes.Count)

            Case Me.imagenes.Count = 4
                Me.guardarCapturaDePantalla()
        End Select

       
    End Sub
    Private Sub guardarCapturaDePantalla()
        m_Manejador.guardarCapturaPantalla(imagenes)
        MessageBox.Show("se ha guardado imagen en disco")

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
   
    Private Sub BorrarCapturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrarCapturaToolStripMenuItem.Click
        'ImageList1.Images.Clear()
        imagenes.Clear()
        Me.ListView1.Items.Clear()
    End Sub

    Public Sub New()
        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        ImageList1.ImageSize = New Size(200, 200)

    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        imprimir()
    End Sub
    Public Sub imprimir()
        Dim r As New reportViewer

        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.ProcessingMode = ProcessingMode.Local
        Dim imagePath As String = ("d:\Test.bmp")

        Dim Param1 As New ReportParameter
        Dim Param2 As New ReportParameter
        Dim Param3 As New ReportParameter
        Dim Param4 As New ReportParameter

        Param1.Name = "pathImagen1" ' nombre del parametro del report
        Param2.Name = "pathImagen2" ' nombre del parametro del report
        Param3.Name = "pathImagen3" ' nombre del parametro del report
        Param4.Name = "pathImagen4" ' nombre del parametro del report

        Param1.Values.Add("file:///" + imagePath)
        Param2.Values.Add("file:///" + imagePath)
        Param3.Values.Add("file:///" + imagePath)
        Param4.Values.Add("file:///" + imagePath)

        ReportViewer1.LocalReport.SetParameters(New ReportParameter() {Param1, Param2, Param3, Param4})
        ReportViewer1.RefreshReport()


    End Sub
End Class
