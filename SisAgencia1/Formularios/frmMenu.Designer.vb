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
        Label3 = New Label()
        Panel2 = New Panel()
        Panel1 = New Panel()
        bPersonal = New Button()
        bOperaciones = New Button()
        bServicios = New Button()
        bVentas = New Button()
        lblDescripcion = New Label()
        Label1 = New Label()
        Timer1 = New Timer(components)
        Label2 = New Label()
        gbMenu.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbMenu
        ' 
        gbMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        gbMenu.Controls.Add(Label3)
        gbMenu.Controls.Add(Panel2)
        gbMenu.Controls.Add(Panel1)
        gbMenu.FlatStyle = FlatStyle.Flat
        gbMenu.Location = New Point(12, 4)
        gbMenu.Name = "gbMenu"
        gbMenu.Size = New Size(376, 747)
        gbMenu.TabIndex = 0
        gbMenu.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SteelBlue
        Label3.Location = New Point(10, 14)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 20)
        Label3.TabIndex = 6
        Label3.Text = "Herramientas"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.Location = New Point(6, 205)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(364, 533)
        Panel2.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(bPersonal)
        Panel1.Controls.Add(bOperaciones)
        Panel1.Controls.Add(bServicios)
        Panel1.Controls.Add(bVentas)
        Panel1.Controls.Add(lblDescripcion)
        Panel1.Location = New Point(6, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(364, 132)
        Panel1.TabIndex = 4
        ' 
        ' bPersonal
        ' 
        bPersonal.BackColor = Color.SteelBlue
        bPersonal.FlatStyle = FlatStyle.Flat
        bPersonal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bPersonal.ForeColor = Color.White
        bPersonal.Image = My.Resources.Resources.icons8_grupo_de_primer_plano_seleccionado_60
        bPersonal.Location = New Point(276, 3)
        bPersonal.Name = "bPersonal"
        bPersonal.Size = New Size(85, 85)
        bPersonal.TabIndex = 3
        bPersonal.TextAlign = ContentAlignment.BottomCenter
        bPersonal.UseVisualStyleBackColor = False
        ' 
        ' bOperaciones
        ' 
        bOperaciones.BackColor = Color.SteelBlue
        bOperaciones.FlatStyle = FlatStyle.Flat
        bOperaciones.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bOperaciones.ForeColor = Color.White
        bOperaciones.Image = CType(resources.GetObject("bOperaciones.Image"), Image)
        bOperaciones.Location = New Point(185, 3)
        bOperaciones.Name = "bOperaciones"
        bOperaciones.Size = New Size(85, 85)
        bOperaciones.TabIndex = 2
        bOperaciones.TextAlign = ContentAlignment.BottomCenter
        bOperaciones.UseVisualStyleBackColor = False
        ' 
        ' bServicios
        ' 
        bServicios.BackColor = Color.SteelBlue
        bServicios.FlatStyle = FlatStyle.Flat
        bServicios.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bServicios.ForeColor = Color.White
        bServicios.Image = My.Resources.Resources.icons8_cascada_40
        bServicios.Location = New Point(94, 3)
        bServicios.Name = "bServicios"
        bServicios.Size = New Size(85, 85)
        bServicios.TabIndex = 1
        bServicios.TextAlign = ContentAlignment.BottomCenter
        bServicios.UseVisualStyleBackColor = False
        ' 
        ' bVentas
        ' 
        bVentas.BackColor = Color.SteelBlue
        bVentas.FlatStyle = FlatStyle.Flat
        bVentas.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bVentas.ForeColor = Color.White
        bVentas.Image = My.Resources.Resources.icons8_barato_2_60
        bVentas.Location = New Point(3, 3)
        bVentas.Name = "bVentas"
        bVentas.Size = New Size(85, 85)
        bVentas.TabIndex = 0
        bVentas.TextAlign = ContentAlignment.BottomCenter
        bVentas.UseVisualStyleBackColor = False
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.SteelBlue
        lblDescripcion.Location = New Point(4, 100)
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
        DoubleBuffered = True
        Name = "frmMenu"
        Text = "A"
        gbMenu.ResumeLayout(False)
        gbMenu.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents gbMenu As GroupBox
End Class
