Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmNotification
    Inherits Form

    Private Shared ReadOnly OpenNotifications As List(Of frmNotification) = New List(Of frmNotification)()
    Private _allowFocus As Boolean
    Private ReadOnly _animator As FormAnimations
    Private _currentForegroundWindow As IntPtr

    Public Sub New(ByVal title As String, ByVal body As String, ByVal duration As Integer, ByVal animation As FormAnimations.AnimationMethod, ByVal direction As FormAnimations.AnimationDirection)
        InitializeComponent()

        If duration < 0 Then
            duration = Integer.MaxValue
        Else
            duration = duration * 1000
        End If

        lifeTimer.Interval = duration
        labelTitle.Text = title
        labelBody.Text = body
        _animator = New FormAnimations(Me, animation, direction, 500)
        Region = Region.FromHrgn(NativeFunctions.CreateRoundRectRgn(0, 0, Width - 5, Height - 5, 20, 20))
    End Sub

    Public Overloads Sub Show()
        _currentForegroundWindow = NativeFunctions.GetForegroundWindow()
        MyBase.Show()
    End Sub

    Private Sub Notification_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Location = New Point(Screen.PrimaryScreen.WorkingArea.Width - Width, Screen.PrimaryScreen.WorkingArea.Height - Height)

        For Each openForm As frmNotification In OpenNotifications
            openForm.Top -= Height
        Next

        OpenNotifications.Add(Me)
        lifeTimer.Start()
    End Sub

    Private Sub Notification_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
        If Not _allowFocus Then
            NativeFunctions.SetForegroundWindow(_currentForegroundWindow)
        End If
    End Sub

    Private Sub Notification_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
        _allowFocus = True
        _animator.Duration = 0
        _animator.Direction = FormAnimations.AnimationDirection.Down
    End Sub

    Private Sub Notification_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        For Each openForm As frmNotification In OpenNotifications

            If openForm Is Me Then
                Exit For
            End If

            openForm.Top += Height
        Next

        OpenNotifications.Remove(Me)
    End Sub

    Private Sub lifeTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Close()
    End Sub

    Private Sub frmNotification_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Click
        Close()
    End Sub

    Private Sub labelTitle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles labelTitle.Click
        Close()
    End Sub

    Private Sub labelRO_Click(ByVal sender As Object, ByVal e As EventArgs) Handles labelBody.Click
        Close()
    End Sub
End Class
