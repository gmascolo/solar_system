<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstrellaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltaPlanetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SateliteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.ABMToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanetasToolStripMenuItem})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'PlanetasToolStripMenuItem
        '
        Me.PlanetasToolStripMenuItem.Name = "PlanetasToolStripMenuItem"
        Me.PlanetasToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.PlanetasToolStripMenuItem.Text = "Planetas"
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstrellaToolStripMenuItem, Me.AltaPlanetaToolStripMenuItem, Me.SateliteToolStripMenuItem})
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ABMToolStripMenuItem.Text = "ABM"
        '
        'EstrellaToolStripMenuItem
        '
        Me.EstrellaToolStripMenuItem.Name = "EstrellaToolStripMenuItem"
        Me.EstrellaToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EstrellaToolStripMenuItem.Text = "Estrella"
        '
        'AltaPlanetaToolStripMenuItem
        '
        Me.AltaPlanetaToolStripMenuItem.Name = "AltaPlanetaToolStripMenuItem"
        Me.AltaPlanetaToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.AltaPlanetaToolStripMenuItem.Text = "Planeta"
        '
        'SateliteToolStripMenuItem
        '
        Me.SateliteToolStripMenuItem.Name = "SateliteToolStripMenuItem"
        Me.SateliteToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.SateliteToolStripMenuItem.Text = "Satelite"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosDBToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'ParametrosDBToolStripMenuItem
        '
        Me.ParametrosDBToolStripMenuItem.Name = "ParametrosDBToolStripMenuItem"
        Me.ParametrosDBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ParametrosDBToolStripMenuItem.Text = "Parametros DB"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Inicio"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ABMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstrellaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltaPlanetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SateliteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParametrosDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
