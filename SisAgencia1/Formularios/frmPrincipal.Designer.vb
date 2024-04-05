<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        pnlPpal = New Panel()
        niPpal = New NotifyIcon(components)
        pnlMnuDesp = New Panel()
        pnlHerr = New Panel()
        btnAyuda = New Button()
        btnConfig = New Button()
        btnHerr = New Button()
        pnlDatos = New Panel()
        btnUsuarios = New Button()
        btnOperaciones = New Button()
        btnServicios = New Button()
        btnVentas = New Button()
        btnDatos = New Button()
        pnlArchivo = New Panel()
        btnSalir = New Button()
        btnSalirLog = New Button()
        btnInicio = New Button()
        btnArchivo = New Button()
        pbMnuDesp = New PictureBox()
        btnMnuDesp = New Button()
        pnlMnuTool = New Panel()
        btnVolver = New Button()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnMiniMax = New Button()
        btnExit = New Button()
        pnlMnuDesp.SuspendLayout()
        pnlHerr.SuspendLayout()
        pnlDatos.SuspendLayout()
        pnlArchivo.SuspendLayout()
        CType(pbMnuDesp, ComponentModel.ISupportInitialize).BeginInit()
        pnlMnuTool.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlPpal
        ' 
        pnlPpal.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPpal.BackColor = Color.Azure
        pnlPpal.Location = New Point(0, 27)
        pnlPpal.Name = "pnlPpal"
        pnlPpal.Size = New Size(992, 556)
        pnlPpal.TabIndex = 1
        ' 
        ' niPpal
        ' 
        niPpal.Icon = CType(resources.GetObject("niPpal.Icon"), Icon)
        niPpal.Text = "Conquista Tu Mundo"
        niPpal.Visible = True
        ' 
        ' pnlMnuDesp
        ' 
        pnlMnuDesp.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnlMnuDesp.AutoScroll = True
        pnlMnuDesp.BackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        pnlMnuDesp.Controls.Add(pnlHerr)
        pnlMnuDesp.Controls.Add(btnHerr)
        pnlMnuDesp.Controls.Add(pnlDatos)
        pnlMnuDesp.Controls.Add(btnDatos)
        pnlMnuDesp.Controls.Add(pnlArchivo)
        pnlMnuDesp.Controls.Add(btnArchivo)
        pnlMnuDesp.Controls.Add(pbMnuDesp)
        pnlMnuDesp.Location = New Point(0, 27)
        pnlMnuDesp.Name = "pnlMnuDesp"
        pnlMnuDesp.Size = New Size(279, 556)
        pnlMnuDesp.TabIndex = 3
        pnlMnuDesp.Visible = False
        ' 
        ' pnlHerr
        ' 
        pnlHerr.BackColor = Color.FromArgb(CByte(61), CByte(116), CByte(160))
        pnlHerr.Controls.Add(btnAyuda)
        pnlHerr.Controls.Add(btnConfig)
        pnlHerr.Dock = DockStyle.Top
        pnlHerr.Location = New Point(0, 477)
        pnlHerr.Name = "pnlHerr"
        pnlHerr.Size = New Size(279, 77)
        pnlHerr.TabIndex = 9
        pnlHerr.Visible = False
        ' 
        ' btnAyuda
        ' 
        btnAyuda.Dock = DockStyle.Top
        btnAyuda.FlatAppearance.BorderSize = 0
        btnAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnAyuda.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnAyuda.FlatStyle = FlatStyle.Flat
        btnAyuda.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAyuda.ForeColor = Color.White
        btnAyuda.ImageAlign = ContentAlignment.MiddleLeft
        btnAyuda.Location = New Point(0, 38)
        btnAyuda.Name = "btnAyuda"
        btnAyuda.Size = New Size(279, 38)
        btnAyuda.TabIndex = 5
        btnAyuda.Text = "Ayuda"
        btnAyuda.TextAlign = ContentAlignment.MiddleLeft
        btnAyuda.UseVisualStyleBackColor = True
        ' 
        ' btnConfig
        ' 
        btnConfig.Dock = DockStyle.Top
        btnConfig.FlatAppearance.BorderSize = 0
        btnConfig.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnConfig.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnConfig.FlatStyle = FlatStyle.Flat
        btnConfig.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfig.ForeColor = Color.White
        btnConfig.ImageAlign = ContentAlignment.MiddleLeft
        btnConfig.Location = New Point(0, 0)
        btnConfig.Name = "btnConfig"
        btnConfig.Size = New Size(279, 38)
        btnConfig.TabIndex = 4
        btnConfig.Text = "Configuración"
        btnConfig.TextAlign = ContentAlignment.MiddleLeft
        btnConfig.UseVisualStyleBackColor = True
        ' 
        ' btnHerr
        ' 
        btnHerr.Dock = DockStyle.Top
        btnHerr.FlatAppearance.BorderSize = 0
        btnHerr.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnHerr.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(58), CByte(112), CByte(154))
        btnHerr.FlatStyle = FlatStyle.Flat
        btnHerr.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHerr.ForeColor = Color.White
        btnHerr.Image = My.Resources.Resources.icons8_herramientas_26
        btnHerr.ImageAlign = ContentAlignment.MiddleLeft
        btnHerr.Location = New Point(0, 439)
        btnHerr.Name = "btnHerr"
        btnHerr.Size = New Size(279, 38)
        btnHerr.TabIndex = 8
        btnHerr.Text = "        Herramientas"
        btnHerr.TextAlign = ContentAlignment.MiddleLeft
        btnHerr.UseVisualStyleBackColor = True
        ' 
        ' pnlDatos
        ' 
        pnlDatos.BackColor = Color.FromArgb(CByte(61), CByte(116), CByte(160))
        pnlDatos.Controls.Add(btnUsuarios)
        pnlDatos.Controls.Add(btnOperaciones)
        pnlDatos.Controls.Add(btnServicios)
        pnlDatos.Controls.Add(btnVentas)
        pnlDatos.Dock = DockStyle.Top
        pnlDatos.Location = New Point(0, 287)
        pnlDatos.Name = "pnlDatos"
        pnlDatos.Size = New Size(279, 152)
        pnlDatos.TabIndex = 7
        pnlDatos.Visible = False
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.Dock = DockStyle.Top
        btnUsuarios.FlatAppearance.BorderSize = 0
        btnUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnUsuarios.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnUsuarios.FlatStyle = FlatStyle.Flat
        btnUsuarios.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsuarios.ForeColor = Color.White
        btnUsuarios.ImageAlign = ContentAlignment.MiddleLeft
        btnUsuarios.Location = New Point(0, 114)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Size = New Size(279, 38)
        btnUsuarios.TabIndex = 5
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.TextAlign = ContentAlignment.MiddleLeft
        btnUsuarios.UseVisualStyleBackColor = True
        ' 
        ' btnOperaciones
        ' 
        btnOperaciones.Dock = DockStyle.Top
        btnOperaciones.FlatAppearance.BorderSize = 0
        btnOperaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnOperaciones.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnOperaciones.FlatStyle = FlatStyle.Flat
        btnOperaciones.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnOperaciones.ForeColor = Color.White
        btnOperaciones.ImageAlign = ContentAlignment.MiddleLeft
        btnOperaciones.Location = New Point(0, 76)
        btnOperaciones.Name = "btnOperaciones"
        btnOperaciones.Size = New Size(279, 38)
        btnOperaciones.TabIndex = 4
        btnOperaciones.Text = "Operaciones"
        btnOperaciones.TextAlign = ContentAlignment.MiddleLeft
        btnOperaciones.UseVisualStyleBackColor = True
        ' 
        ' btnServicios
        ' 
        btnServicios.Dock = DockStyle.Top
        btnServicios.FlatAppearance.BorderSize = 0
        btnServicios.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnServicios.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnServicios.FlatStyle = FlatStyle.Flat
        btnServicios.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnServicios.ForeColor = Color.White
        btnServicios.ImageAlign = ContentAlignment.MiddleLeft
        btnServicios.Location = New Point(0, 38)
        btnServicios.Name = "btnServicios"
        btnServicios.Size = New Size(279, 38)
        btnServicios.TabIndex = 3
        btnServicios.Text = "Servicios"
        btnServicios.TextAlign = ContentAlignment.MiddleLeft
        btnServicios.UseVisualStyleBackColor = True
        ' 
        ' btnVentas
        ' 
        btnVentas.Dock = DockStyle.Top
        btnVentas.FlatAppearance.BorderSize = 0
        btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnVentas.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnVentas.FlatStyle = FlatStyle.Flat
        btnVentas.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVentas.ForeColor = Color.White
        btnVentas.ImageAlign = ContentAlignment.MiddleLeft
        btnVentas.Location = New Point(0, 0)
        btnVentas.Name = "btnVentas"
        btnVentas.Size = New Size(279, 38)
        btnVentas.TabIndex = 2
        btnVentas.Text = "Ventas"
        btnVentas.TextAlign = ContentAlignment.MiddleLeft
        btnVentas.UseVisualStyleBackColor = True
        ' 
        ' btnDatos
        ' 
        btnDatos.Dock = DockStyle.Top
        btnDatos.FlatAppearance.BorderSize = 0
        btnDatos.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnDatos.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(58), CByte(112), CByte(154))
        btnDatos.FlatStyle = FlatStyle.Flat
        btnDatos.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDatos.ForeColor = Color.White
        btnDatos.Image = My.Resources.Resources.icons8_herramientas_26
        btnDatos.ImageAlign = ContentAlignment.MiddleLeft
        btnDatos.Location = New Point(0, 249)
        btnDatos.Name = "btnDatos"
        btnDatos.Size = New Size(279, 38)
        btnDatos.TabIndex = 6
        btnDatos.Text = "        Datos"
        btnDatos.TextAlign = ContentAlignment.MiddleLeft
        btnDatos.UseVisualStyleBackColor = True
        ' 
        ' pnlArchivo
        ' 
        pnlArchivo.BackColor = Color.FromArgb(CByte(61), CByte(116), CByte(160))
        pnlArchivo.Controls.Add(btnSalir)
        pnlArchivo.Controls.Add(btnSalirLog)
        pnlArchivo.Controls.Add(btnInicio)
        pnlArchivo.Dock = DockStyle.Top
        pnlArchivo.Location = New Point(0, 128)
        pnlArchivo.Name = "pnlArchivo"
        pnlArchivo.Size = New Size(279, 121)
        pnlArchivo.TabIndex = 3
        pnlArchivo.Visible = False
        ' 
        ' btnSalir
        ' 
        btnSalir.Dock = DockStyle.Top
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnSalir.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.White
        btnSalir.ImageAlign = ContentAlignment.MiddleLeft
        btnSalir.Location = New Point(0, 80)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(279, 38)
        btnSalir.TabIndex = 5
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.MiddleLeft
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnSalirLog
        ' 
        btnSalirLog.Dock = DockStyle.Top
        btnSalirLog.FlatAppearance.BorderSize = 0
        btnSalirLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnSalirLog.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnSalirLog.FlatStyle = FlatStyle.Flat
        btnSalirLog.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalirLog.ForeColor = Color.White
        btnSalirLog.ImageAlign = ContentAlignment.MiddleLeft
        btnSalirLog.Location = New Point(0, 38)
        btnSalirLog.Name = "btnSalirLog"
        btnSalirLog.Size = New Size(279, 42)
        btnSalirLog.TabIndex = 4
        btnSalirLog.Text = "Cerrar Sesión"
        btnSalirLog.TextAlign = ContentAlignment.MiddleLeft
        btnSalirLog.UseVisualStyleBackColor = True
        ' 
        ' btnInicio
        ' 
        btnInicio.Dock = DockStyle.Top
        btnInicio.FlatAppearance.BorderSize = 0
        btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnInicio.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnInicio.FlatStyle = FlatStyle.Flat
        btnInicio.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInicio.ForeColor = Color.White
        btnInicio.ImageAlign = ContentAlignment.MiddleLeft
        btnInicio.Location = New Point(0, 0)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(279, 38)
        btnInicio.TabIndex = 2
        btnInicio.Text = "Inicio"
        btnInicio.TextAlign = ContentAlignment.MiddleLeft
        btnInicio.UseVisualStyleBackColor = True
        ' 
        ' btnArchivo
        ' 
        btnArchivo.BackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnArchivo.Dock = DockStyle.Top
        btnArchivo.FlatAppearance.BorderSize = 0
        btnArchivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(45), CByte(83), CByte(115))
        btnArchivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(58), CByte(112), CByte(154))
        btnArchivo.FlatStyle = FlatStyle.Flat
        btnArchivo.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnArchivo.ForeColor = Color.White
        btnArchivo.Image = My.Resources.Resources.icons8_carpeta_26
        btnArchivo.ImageAlign = ContentAlignment.MiddleLeft
        btnArchivo.Location = New Point(0, 93)
        btnArchivo.Name = "btnArchivo"
        btnArchivo.Size = New Size(279, 35)
        btnArchivo.TabIndex = 2
        btnArchivo.Text = "         Archivo"
        btnArchivo.TextAlign = ContentAlignment.MiddleLeft
        btnArchivo.UseVisualStyleBackColor = False
        ' 
        ' pbMnuDesp
        ' 
        pbMnuDesp.Dock = DockStyle.Top
        pbMnuDesp.Image = My.Resources.Resources.output_onlinepngtools__1_3
        pbMnuDesp.Location = New Point(0, 0)
        pbMnuDesp.Name = "pbMnuDesp"
        pbMnuDesp.Size = New Size(279, 93)
        pbMnuDesp.SizeMode = PictureBoxSizeMode.CenterImage
        pbMnuDesp.TabIndex = 1
        pbMnuDesp.TabStop = False
        ' 
        ' btnMnuDesp
        ' 
        btnMnuDesp.BackColor = Color.SteelBlue
        btnMnuDesp.Dock = DockStyle.Left
        btnMnuDesp.FlatAppearance.BorderSize = 0
        btnMnuDesp.FlatStyle = FlatStyle.Flat
        btnMnuDesp.Image = My.Resources.Resources.icons8_menú_24
        btnMnuDesp.Location = New Point(0, 0)
        btnMnuDesp.Name = "btnMnuDesp"
        btnMnuDesp.Size = New Size(37, 31)
        btnMnuDesp.TabIndex = 0
        btnMnuDesp.UseVisualStyleBackColor = False
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMnuTool.BackColor = Color.SteelBlue
        pnlMnuTool.Controls.Add(btnVolver)
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnMini)
        pnlMnuTool.Controls.Add(btnMiniMax)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Controls.Add(btnMnuDesp)
        pnlMnuTool.Location = New Point(0, -2)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(992, 31)
        pnlMnuTool.TabIndex = 4
        ' 
        ' btnVolver
        ' 
        btnVolver.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnVolver.BackColor = Color.SteelBlue
        btnVolver.FlatAppearance.BorderColor = Color.MediumTurquoise
        btnVolver.FlatAppearance.BorderSize = 0
        btnVolver.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnVolver.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnVolver.FlatStyle = FlatStyle.Flat
        btnVolver.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.icons8_atrás_24
        btnVolver.ImageAlign = ContentAlignment.MiddleLeft
        btnVolver.Location = New Point(781, 1)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(94, 31)
        btnVolver.TabIndex = 6
        btnVolver.Text = "    Volver"
        btnVolver.UseVisualStyleBackColor = False
        btnVolver.Visible = False
        ' 
        ' tsslNomUsu
        ' 
        tsslNomUsu.AutoSize = True
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.White
        tsslNomUsu.Location = New Point(43, 8)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(54, 16)
        tsslNomUsu.TabIndex = 4
        tsslNomUsu.Text = "Label1"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.SteelBlue
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(881, 0)
        btnMini.Name = "btnMini"
        btnMini.Size = New Size(37, 31)
        btnMini.TabIndex = 3
        btnMini.UseVisualStyleBackColor = False
        ' 
        ' btnMiniMax
        ' 
        btnMiniMax.BackColor = Color.SteelBlue
        btnMiniMax.Dock = DockStyle.Right
        btnMiniMax.FlatAppearance.BorderSize = 0
        btnMiniMax.FlatStyle = FlatStyle.Flat
        btnMiniMax.Image = My.Resources.Resources.icons8_agrandar_25
        btnMiniMax.Location = New Point(918, 0)
        btnMiniMax.Name = "btnMiniMax"
        btnMiniMax.Size = New Size(37, 31)
        btnMiniMax.TabIndex = 2
        btnMiniMax.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.SteelBlue
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.icons8_eliminar_25
        btnExit.Location = New Point(955, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 31)
        btnExit.TabIndex = 1
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(992, 583)
        Controls.Add(pnlMnuTool)
        Controls.Add(pnlMnuDesp)
        Controls.Add(pnlPpal)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmPrincipal"
        Text = "Conquista Tu Mundo"
        pnlMnuDesp.ResumeLayout(False)
        pnlHerr.ResumeLayout(False)
        pnlDatos.ResumeLayout(False)
        pnlArchivo.ResumeLayout(False)
        CType(pbMnuDesp, ComponentModel.ISupportInitialize).EndInit()
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents msPrincipal As MenuStrip
    Friend WithEvents tsmArchivo As ToolStripMenuItem
    Friend WithEvents tsmiInicio As ToolStripMenuItem
    Friend WithEvents tsmiCerrar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmiSalir As ToolStripMenuItem
    Friend WithEvents tsmHerramientas As ToolStripMenuItem
    Friend WithEvents tsmAyuda As ToolStripMenuItem
    Friend WithEvents pnlPpal As Panel
    Friend WithEvents niPpal As NotifyIcon
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents pnlMnuDesp As Panel
    Friend WithEvents btnMnuDesp As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents btnMini As Button
    Friend WithEvents btnMiniMax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents pnlHerr As Panel
    Friend WithEvents btnAyuda As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnHerr As Button
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnOperaciones As Button
    Friend WithEvents btnServicios As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnDatos As Button
    Friend WithEvents pnlArchivo As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnSalirLog As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnArchivo As Button
    Friend WithEvents pbMnuDesp As PictureBox
    Friend WithEvents btnVolver As Button
End Class
