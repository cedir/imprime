<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScreenCapture
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScreenCapture))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PantallaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapturarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImágenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opcion4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Opcion6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarCapturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ntyCapturadorPantalla = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.BorrarÚltimaCapturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PantallaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(824, 35)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PantallaToolStripMenuItem
        '
        Me.PantallaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CapturarToolStripMenuItem, Me.ToolStripSeparator1, Me.ImágenesToolStripMenuItem, Me.BorrarCapturasToolStripMenuItem, Me.BorrarÚltimaCapturaToolStripMenuItem})
        Me.PantallaToolStripMenuItem.Name = "PantallaToolStripMenuItem"
        Me.PantallaToolStripMenuItem.Size = New System.Drawing.Size(178, 29)
        Me.PantallaToolStripMenuItem.Text = "Captura de pantalla"
        '
        'CapturarToolStripMenuItem
        '
        Me.CapturarToolStripMenuItem.Name = "CapturarToolStripMenuItem"
        Me.CapturarToolStripMenuItem.ShortcutKeyDisplayString = "F11"
        Me.CapturarToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.CapturarToolStripMenuItem.Text = "Capturar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(263, 6)
        '
        'ImágenesToolStripMenuItem
        '
        Me.ImágenesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Opcion4, Me.Opcion6})
        Me.ImágenesToolStripMenuItem.Name = "ImágenesToolStripMenuItem"
        Me.ImágenesToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.ImágenesToolStripMenuItem.Text = "Imágenes"
        '
        'Opcion4
        '
        Me.Opcion4.Name = "Opcion4"
        Me.Opcion4.Size = New System.Drawing.Size(107, 30)
        Me.Opcion4.Text = "4"
        '
        'Opcion6
        '
        Me.Opcion6.Checked = True
        Me.Opcion6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Opcion6.Name = "Opcion6"
        Me.Opcion6.Size = New System.Drawing.Size(107, 30)
        Me.Opcion6.Text = "6"
        '
        'BorrarCapturasToolStripMenuItem
        '
        Me.BorrarCapturasToolStripMenuItem.Name = "BorrarCapturasToolStripMenuItem"
        Me.BorrarCapturasToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.BorrarCapturasToolStripMenuItem.Text = "Borrar Capturas"
        '
        'ntyCapturadorPantalla
        '
        Me.ntyCapturadorPantalla.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntyCapturadorPantalla.Icon = CType(resources.GetObject("ntyCapturadorPantalla.Icon"), System.Drawing.Icon)
        Me.ntyCapturadorPantalla.Text = "CapturadorDePantalla"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(5, 5)
        Me.ImageList1.TransparentColor = System.Drawing.Color.White
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.GridLines = True
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 35)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(824, 730)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'BorrarÚltimaCapturaToolStripMenuItem
        '
        Me.BorrarÚltimaCapturaToolStripMenuItem.Name = "BorrarÚltimaCapturaToolStripMenuItem"
        Me.BorrarÚltimaCapturaToolStripMenuItem.Size = New System.Drawing.Size(266, 30)
        Me.BorrarÚltimaCapturaToolStripMenuItem.Text = "Borrar última Captura"
        '
        'frmScreenCapture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 765)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmScreenCapture"
        Me.Text = "Capturador de Imágenes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PantallaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapturarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ntyCapturadorPantalla As System.Windows.Forms.NotifyIcon
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BorrarCapturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImágenesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Opcion4 As ToolStripMenuItem
    Friend WithEvents Opcion6 As ToolStripMenuItem
    Friend WithEvents BorrarÚltimaCapturaToolStripMenuItem As ToolStripMenuItem
End Class
