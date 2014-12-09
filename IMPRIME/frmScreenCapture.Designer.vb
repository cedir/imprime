<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScreenCapture
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PantallaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CapturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GUARDARIMAGENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BorrarCapturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 37)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(172, 186)
        Me.ListBox1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(190, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(580, 447)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaToolStripMenuItem, Me.BorrarCapturaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PantallaToolStripMenuItem
        '
        Me.PantallaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturarToolStripMenuItem, Me.GUARDARIMAGENToolStripMenuItem})
        Me.PantallaToolStripMenuItem.Name = "PantallaToolStripMenuItem"
        Me.PantallaToolStripMenuItem.Size = New System.Drawing.Size(114, 20)
        Me.PantallaToolStripMenuItem.Text = "Captura de pantalla"
        '
        'CapturarToolStripMenuItem
        '
        Me.CapturarToolStripMenuItem.Name = "CapturarToolStripMenuItem"
        Me.CapturarToolStripMenuItem.ShortcutKeyDisplayString = "c"
        Me.CapturarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CapturarToolStripMenuItem.Text = "Capturar"
        '
        'GUARDARIMAGENToolStripMenuItem
        '
        Me.GUARDARIMAGENToolStripMenuItem.Name = "GUARDARIMAGENToolStripMenuItem"
        Me.GUARDARIMAGENToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GUARDARIMAGENToolStripMenuItem.Text = "GUARDAR IMAGEN"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1500
        '
        'BorrarCapturaToolStripMenuItem
        '
        Me.BorrarCapturaToolStripMenuItem.Name = "BorrarCapturaToolStripMenuItem"
        Me.BorrarCapturaToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.BorrarCapturaToolStripMenuItem.Text = "borrar capturas"
        '
        'frmScreenCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 496)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmScreenCapture"
        Me.Text = "Capturador de Imágenes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PantallaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GUARDARIMAGENToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BorrarCapturaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
