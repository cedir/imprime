Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Public NotInheritable Class FormAnimations
    Public Enum AnimationMethod
        Roll = &H0
        Center = &H10
        Slide = &H40000
        Fade = &H80000
    End Enum

    <Flags>
    Public Enum AnimationDirection
        Right = &H1
        Left = &H2
        Down = &H4
        Up = &H8
    End Enum

    Private Const AwHide As Integer = &H10000
    Private Const AwActivate As Integer = &H20000
    Private Const DefaultDuration As Integer = 250
    Private ReadOnly _form As Form
    Private _method As AnimationMethod
    Private _direction As AnimationDirection
    Private _duration As Integer

    Public Property Method As AnimationMethod
        Get
            Return _method
        End Get
        Set(ByVal value As AnimationMethod)
            _method = value
        End Set
    End Property

    Public Property Direction As AnimationDirection
        Get
            Return _direction
        End Get
        Set(ByVal value As AnimationDirection)
            _direction = value
        End Set
    End Property

    Public Property Duration As Integer
        Get
            Return _duration
        End Get
        Set(ByVal value As Integer)
            _duration = value
        End Set
    End Property

    Public ReadOnly Property Form As Form
        Get
            Return _form
        End Get
    End Property

    Public Sub New(ByVal form As Form)
        _form = form
        AddHandler _form.Load, AddressOf Form_Load
        AddHandler _form.VisibleChanged, AddressOf Form_VisibleChanged
        AddHandler _form.Closing, AddressOf Form_Closing
        _duration = DefaultDuration
    End Sub

    Public Sub New(ByVal form As Form, ByVal method As AnimationMethod, ByVal duration As Integer)
        Me.New(form)
        _method = method
        _duration = duration
    End Sub

    Public Sub New(ByVal form As Form, ByVal method As AnimationMethod, ByVal direction As AnimationDirection, ByVal duration As Integer)
        Me.New(form, method, duration)
        _direction = direction
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As EventArgs)
        If _form.MdiParent Is Nothing OrElse _method <> AnimationMethod.Fade Then
            NativeFunctions.AnimateWindow(_form.Handle, _duration, AwActivate Or CInt(_method) Or CInt(_direction))
        End If
    End Sub

    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As EventArgs)
        If _form.MdiParent Is Nothing Then
            Dim flags As Integer = CInt(_method) Or CInt(_direction)

            If _form.Visible Then
                flags = flags Or AwActivate
            Else
                flags = flags Or AwHide
            End If

            NativeFunctions.AnimateWindow(_form.Handle, _duration, flags)
        End If
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
        If Not e.Cancel Then

            If _form.MdiParent Is Nothing OrElse _method <> AnimationMethod.Fade Then
                NativeFunctions.AnimateWindow(_form.Handle, _duration, AwHide Or CInt(_method) Or CInt(_direction))
            End If
        End If
    End Sub
End Class
