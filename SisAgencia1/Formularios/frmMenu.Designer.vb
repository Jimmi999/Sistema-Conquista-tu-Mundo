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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        tlpMenu = New TableLayoutPanel()
        gbMenu = New GroupBox()
        bOperaciones = New Button()
        bPersonal = New Button()
        bServicios = New Button()
        bVentas = New Button()
        lblDescripcion = New Label()
        PictureBox1 = New PictureBox()
        tlpMenu.SuspendLayout()
        gbMenu.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tlpMenu
        ' 
        tlpMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        tlpMenu.BackColor = Color.Azure
        tlpMenu.ColumnCount = 3
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.2231407F))
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 86.77686F))
        tlpMenu.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 85F))
        tlpMenu.Controls.Add(gbMenu, 1, 1)
        tlpMenu.Controls.Add(lblDescripcion, 1, 2)
        tlpMenu.Controls.Add(PictureBox1, 0, 2)
        tlpMenu.Location = New Point(12, 12)
        tlpMenu.Name = "tlpMenu"
        tlpMenu.RowCount = 3
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Percent, 13.8235292F))
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Percent, 86.17647F))
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 69F))
        tlpMenu.Size = New Size(776, 426)
        tlpMenu.TabIndex = 0
        ' 
        ' gbMenu
        ' 
        gbMenu.Anchor = AnchorStyles.None
        gbMenu.Controls.Add(bOperaciones)
        gbMenu.Controls.Add(bPersonal)
        gbMenu.Controls.Add(bServicios)
        gbMenu.Controls.Add(bVentas)
        gbMenu.FlatStyle = FlatStyle.Flat
        gbMenu.Location = New Point(207, 87)
        gbMenu.Name = "gbMenu"
        gbMenu.Size = New Size(366, 230)
        gbMenu.TabIndex = 0
        gbMenu.TabStop = False
        ' 
        ' bOperaciones
        ' 
        bOperaciones.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        bOperaciones.BackColor = Color.SteelBlue
        bOperaciones.FlatStyle = FlatStyle.Flat
        bOperaciones.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bOperaciones.ForeColor = Color.White
        bOperaciones.Image = CType(resources.GetObject("bOperaciones.Image"), Image)
        bOperaciones.Location = New Point(16, 120)
        bOperaciones.Name = "bOperaciones"
        bOperaciones.Size = New Size(164, 95)
        bOperaciones.TabIndex = 3
        bOperaciones.Text = "Operaciones"
        bOperaciones.TextAlign = ContentAlignment.BottomCenter
        bOperaciones.UseVisualStyleBackColor = False
        ' 
        ' bPersonal
        ' 
        bPersonal.BackColor = Color.SteelBlue
        bPersonal.FlatStyle = FlatStyle.Flat
        bPersonal.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bPersonal.ForeColor = Color.White
        bPersonal.Image = My.Resources.Resources.icons8_grupo_de_primer_plano_seleccionado_60
        bPersonal.Location = New Point(186, 120)
        bPersonal.Name = "bPersonal"
        bPersonal.Size = New Size(164, 95)
        bPersonal.TabIndex = 2
        bPersonal.Text = "Personal"
        bPersonal.TextAlign = ContentAlignment.BottomCenter
        bPersonal.UseVisualStyleBackColor = False
        ' 
        ' bServicios
        ' 
        bServicios.BackColor = Color.SteelBlue
        bServicios.FlatStyle = FlatStyle.Flat
        bServicios.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        bServicios.ForeColor = Color.White
        bServicios.Image = My.Resources.Resources.icons8_cascada_40
        bServicios.Location = New Point(186, 19)
        bServicios.Name = "bServicios"
        bServicios.Size = New Size(164, 95)
        bServicios.TabIndex = 1
        bServicios.Text = "Servicios"
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
        bVentas.Location = New Point(16, 19)
        bVentas.Name = "bVentas"
        bVentas.Size = New Size(164, 95)
        bVentas.TabIndex = 0
        bVentas.Text = "Ventas"
        bVentas.TextAlign = ContentAlignment.BottomCenter
        bVentas.UseVisualStyleBackColor = False
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.Anchor = AnchorStyles.Top
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.SteelBlue
        lblDescripcion.Location = New Point(359, 356)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(63, 20)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Label1"
        lblDescripcion.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.output_onlinepngtools__1_3
        PictureBox1.Location = New Point(3, 359)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(85, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' frmMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(800, 450)
        Controls.Add(tlpMenu)
        Name = "frmMenu"
        Text = "frmMenu"
        tlpMenu.ResumeLayout(False)
        tlpMenu.PerformLayout()
        gbMenu.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpMenu As TableLayoutPanel
    Friend WithEvents gbMenu As GroupBox
    Friend WithEvents bOperaciones As Button
    Friend WithEvents bPersonal As Button
    Friend WithEvents bServicios As Button
    Friend WithEvents bVentas As Button
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
