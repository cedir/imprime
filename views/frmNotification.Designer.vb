'Partial Class frmNotification
'    Inherits System.Windows.Forms.Form

'    'Form overrides dispose to clean up the component list.
'    <System.Diagnostics.DebuggerNonUserCode()> _
'    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
'        Try
'            If disposing AndAlso components IsNot Nothing Then
'                components.Dispose()
'            End If
'        Finally
'            MyBase.Dispose(disposing)
'        End Try
'    End Sub

'    'Required by the Windows Form Designer
'    Private components As System.ComponentModel.IContainer

'    'NOTE: The following procedure is required by the Windows Form Designer
'    'It can be modified using the Windows Form Designer.  
'    'Do not modify it using the code editor.
'    <System.Diagnostics.DebuggerStepThrough()> _
'    Private Sub InitializeComponent()
'        components = New System.ComponentModel.Container
'        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
'        Me.Text = "frmNotification"
'    End Sub
'End Class

Partial Class frmNotification
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.

    '    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer


    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lifeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.labelBody = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.Black
        Me.labelTitle.Location = New System.Drawing.Point(-1, -11)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(53, 21)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "title goes here"
        Me.labelTitle.Visible = False
        '
        'labelBody
        '
        Me.labelBody.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelBody.BackColor = System.Drawing.Color.Transparent
        Me.labelBody.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelBody.ForeColor = System.Drawing.Color.Black
        Me.labelBody.Location = New System.Drawing.Point(-5, 3)
        Me.labelBody.Name = "labelBody"
        Me.labelBody.Size = New System.Drawing.Size(71, 27)
        Me.labelBody.TabIndex = 0
        Me.labelBody.Text = "0"
        Me.labelBody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmNotification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(73, 39)
        Me.ControlBox = False
        Me.Controls.Add(Me.labelTitle)
        Me.Controls.Add(Me.labelBody)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmNotification"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "EDGE Shop Flag Notification"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lifeTimer As System.Windows.Forms.Timer
    Private WithEvents labelTitle As System.Windows.Forms.Label
    Private WithEvents labelBody As Label
End Class

