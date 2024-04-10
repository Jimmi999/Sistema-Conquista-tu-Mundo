<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        gbMenu = New GroupBox()
        btnFav = New Button()
        Label4 = New Label()
        Label3 = New Label()
        pnlFavoritos = New Panel()
        pblBasBut = New Panel()
        bPersonal = New Button()
        bServicios = New Button()
        bVentas = New Button()
        bOperaciones = New Button()
        lblDescripcion = New Label()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Label2 = New Label()
        gbMenu.SuspendLayout()
        pblBasBut.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbMenu
        ' 
        gbMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        gbMenu.Controls.Add(btnFav)
        gbMenu.Controls.Add(Label4)
        gbMenu.Controls.Add(Label3)
        gbMenu.Controls.Add(pnlFavoritos)
        gbMenu.Controls.Add(pblBasBut)
        gbMenu.FlatStyle = FlatStyle.Flat
        gbMenu.Location = New Point(12, 0)
        gbMenu.Name = "gbMenu"
        gbMenu.Size = New Size(390, 812)
        gbMenu.TabIndex = 0
        gbMenu.TabStop = False
        ' 
        ' btnFav
        ' 
        btnFav.BackColor = Color.Azure
        btnFav.FlatAppearance.BorderColor = Color.SlateGray
        btnFav.FlatAppearance.BorderSize = 0
        btnFav.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(238), CByte(244), CByte(249))
        btnFav.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(200), CByte(219), CByte(234))
        btnFav.FlatStyle = FlatStyle.Flat
        btnFav.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnFav.ForeColor = Color.SteelBlue
        btnFav.Image = My.Resources.Resources.icons8_más_30
        btnFav.Location = New Point(87, 143)
        btnFav.Name = "btnFav"
        btnFav.Size = New Size(41, 39)
        btnFav.TabIndex = 8
        btnFav.TextAlign = ContentAlignment.MiddleLeft
        btnFav.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SteelBlue
        Label4.Location = New Point(6, 152)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 24)
        Label4.TabIndex = 7
        Label4.Text = "Favoritos"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SteelBlue
        Label3.Location = New Point(6, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 24)
        Label3.TabIndex = 6
        Label3.Text = "Herramientas"
        ' 
        ' pnlFavoritos
        ' 
        pnlFavoritos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFavoritos.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        pnlFavoritos.Location = New Point(0, 188)
        pnlFavoritos.Name = "pnlFavoritos"
        pnlFavoritos.Size = New Size(390, 615)
        pnlFavoritos.TabIndex = 5
        ' 
        ' pblBasBut
        ' 
        pblBasBut.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        pblBasBut.Controls.Add(bPersonal)
        pblBasBut.Controls.Add(bServicios)
        pblBasBut.Controls.Add(bVentas)
        pblBasBut.Controls.Add(bOperaciones)
        pblBasBut.Location = New Point(0, 48)
        pblBasBut.Name = "pblBasBut"
        pblBasBut.Size = New Size(390, 86)
        pblBasBut.TabIndex = 4
        ' 
        ' bPersonal
        ' 
        bPersonal.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        bPersonal.FlatAppearance.BorderSize = 0
        bPersonal.FlatStyle = FlatStyle.Flat
        bPersonal.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bPersonal.ForeColor = Color.SteelBlue
        bPersonal.Image = CType(resources.GetObject("bPersonal.Image"), Image)
        bPersonal.ImageAlign = ContentAlignment.TopCenter
        bPersonal.Location = New Point(292, 3)
        bPersonal.Name = "bPersonal"
        bPersonal.Size = New Size(88, 80)
        bPersonal.TabIndex = 3
        bPersonal.Text = "Usuarios"
        bPersonal.TextAlign = ContentAlignment.BottomCenter
        bPersonal.UseVisualStyleBackColor = False
        ' 
        ' bServicios
        ' 
        bServicios.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        bServicios.FlatAppearance.BorderSize = 0
        bServicios.FlatStyle = FlatStyle.Flat
        bServicios.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bServicios.ForeColor = Color.SteelBlue
        bServicios.Image = My.Resources.Resources.icons8_cascada_40
        bServicios.ImageAlign = ContentAlignment.TopCenter
        bServicios.Location = New Point(104, 3)
        bServicios.Name = "bServicios"
        bServicios.Size = New Size(88, 80)
        bServicios.TabIndex = 1
        bServicios.Text = "Servicios"
        bServicios.TextAlign = ContentAlignment.BottomCenter
        bServicios.UseVisualStyleBackColor = False
        ' 
        ' bVentas
        ' 
        bVentas.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        bVentas.FlatAppearance.BorderSize = 0
        bVentas.FlatStyle = FlatStyle.Flat
        bVentas.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bVentas.ForeColor = Color.SteelBlue
        bVentas.Image = My.Resources.Resources.icons8_barato_2_60
        bVentas.ImageAlign = ContentAlignment.TopCenter
        bVentas.Location = New Point(10, 3)
        bVentas.Name = "bVentas"
        bVentas.Size = New Size(88, 80)
        bVentas.TabIndex = 0
        bVentas.Text = "Ventas"
        bVentas.TextAlign = ContentAlignment.BottomCenter
        bVentas.UseVisualStyleBackColor = False
        ' 
        ' bOperaciones
        ' 
        bOperaciones.BackColor = Color.FromArgb(CByte(224), CByte(235), CByte(243))
        bOperaciones.FlatAppearance.BorderSize = 0
        bOperaciones.FlatStyle = FlatStyle.Flat
        bOperaciones.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bOperaciones.ForeColor = Color.SteelBlue
        bOperaciones.Image = CType(resources.GetObject("bOperaciones.Image"), Image)
        bOperaciones.ImageAlign = ContentAlignment.TopCenter
        bOperaciones.Location = New Point(198, 3)
        bOperaciones.Name = "bOperaciones"
        bOperaciones.Size = New Size(88, 80)
        bOperaciones.TabIndex = 2
        bOperaciones.Text = "Operaciones"
        bOperaciones.TextAlign = ContentAlignment.BottomCenter
        bOperaciones.UseVisualStyleBackColor = False
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.SteelBlue
        lblDescripcion.Location = New Point(518, 137)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(21, 20)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "S"
        lblDescripcion.TextAlign = ContentAlignment.MiddleCenter
        lblDescripcion.Visible = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(1360, 719)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 73)
        Label1.TabIndex = 5
        Label1.Text = "00:00"
        ' 
        ' Timer1
        ' 
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SteelBlue
        Label2.Location = New Point(1356, 792)
        Label2.Name = "Label2"
        Label2.Size = New Size(205, 20)
        Label2.TabIndex = 6
        Label2.Text = "Lunes, 15 de Junio de 2020"
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        BackgroundImage = My.Resources.Resources.output_onlinepngtools__1_
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(1566, 821)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(gbMenu)
        Controls.Add(lblDescripcion)
        DoubleBuffered = True
        Name = "frmMenu"
        Text = "A"
        gbMenu.ResumeLayout(False)
        gbMenu.PerformLayout()
        pblBasBut.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents bOperaciones As Button
    Friend WithEvents bPersonal As Button
    Friend WithEvents bServicios As Button
    Friend WithEvents bVentas As Button
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents pblBasBut As Panel
    Friend WithEvents pnlFavoritos As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents gbMenu As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFav As Button
End Class
