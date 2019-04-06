Imports System
Imports System.Runtime.InteropServices


Friend Module NativeFunctions
    <DllImport("user32.dll")>
    Friend Function GetForegroundWindow() As IntPtr

    End Function

    <DllImport("user32.dll")>
    Friend Function SetForegroundWindow(ByVal hWnd As IntPtr) As Boolean

    End Function

    <DllImport("user32.dll")>
    Friend Function AnimateWindow(ByVal hWnd As IntPtr, ByVal dwTime As Integer, ByVal dwFlags As Integer) As Boolean

    End Function

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Friend Function CreateRoundRectRgn(ByVal nLeftRect As Integer, ByVal nTopRect As Integer, ByVal nRightRect As Integer, ByVal nBottomRect As Integer, ByVal nWidthEllipse As Integer, ByVal nHeightEllipse As Integer) As IntPtr

    End Function

End Module