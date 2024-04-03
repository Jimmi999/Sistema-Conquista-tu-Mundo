<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpUsu))
        tlpMenu = New TableLayoutPanel()
        gbMenu = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        bServicios = New Button()
        bVentas = New Button()
        lblDescripcion = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        GroupBox1 = New GroupBox()
        BtnUsu = New Button()
        BtnEmplea = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        BtnVolver = New Button()
        tlpMenu.SuspendLayout()
        gbMenu.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
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
        tlpMenu.Location = New Point(0, 0)
        tlpMenu.Name = "tlpMenu"
        tlpMenu.RowCount = 2
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpMenu.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        tlpMenu.Size = New Size(200, 100)
        tlpMenu.TabIndex = 0
        ' 
        ' gbMenu
        ' 
        gbMenu.Anchor = AnchorStyles.None
        gbMenu.Controls.Add(Button1)
        gbMenu.Controls.Add(Button2)
        gbMenu.Controls.Add(bServicios)
        gbMenu.Controls.Add(bVentas)
        gbMenu.FlatStyle = FlatStyle.Flat
        gbMenu.Location = New Point(18, 23)
        gbMenu.Name = "gbMenu"
        gbMenu.Size = New Size(93, 74)
        gbMenu.TabIndex = 0
        gbMenu.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Button1.BackColor = Color.SteelBlue
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(16, 94)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 95)
        Button1.TabIndex = 3
        Button1.Text = "Operaciones"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.SteelBlue
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Image = My.Resources.Resources.icons8_grupo_de_primer_plano_seleccionado_60
        Button2.Location = New Point(186, 120)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 95)
        Button2.TabIndex = 2
        Button2.Text = "Personal"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = False
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
        lblDescripcion.Location = New Point(33, 236)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(63, 20)
        lblDescripcion.TabIndex = 1
        lblDescripcion.Text = "Label1"
        lblDescripcion.Visible = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TableLayoutPanel1.BackColor = Color.Azure
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 13.2231407F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 86.77686F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 85F))
        TableLayoutPanel1.Controls.Add(GroupBox1, 1, 1)
        TableLayoutPanel1.Controls.Add(Label1, 1, 2)
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 2)
        TableLayoutPanel1.Controls.Add(BtnVolver, 0, 0)
        TableLayoutPanel1.Location = New Point(12, 9)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.8235292F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 86.17647F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 69F))
        TableLayoutPanel1.Size = New Size(776, 426)
        TableLayoutPanel1.TabIndex = 1
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.None
        GroupBox1.Controls.Add(BtnUsu)
        GroupBox1.Controls.Add(BtnEmplea)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(207, 87)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(366, 230)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' BtnUsu
        ' 
        BtnUsu.BackColor = Color.SteelBlue
        BtnUsu.FlatStyle = FlatStyle.Flat
        BtnUsu.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnUsu.ForeColor = Color.White
        BtnUsu.Image = My.Resources.Resources.icons8_grupo_de_primer_plano_seleccionado_60
        BtnUsu.Location = New Point(196, 69)
        BtnUsu.Name = "BtnUsu"
        BtnUsu.Size = New Size(164, 95)
        BtnUsu.TabIndex = 5
        BtnUsu.Text = "Usuarios"
        BtnUsu.TextAlign = ContentAlignment.BottomCenter
        BtnUsu.UseVisualStyleBackColor = False
        ' 
        ' BtnEmplea
        ' 
        BtnEmplea.BackColor = Color.SteelBlue
        BtnEmplea.FlatStyle = FlatStyle.Flat
        BtnEmplea.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnEmplea.ForeColor = Color.White
        BtnEmplea.Image = My.Resources.Resources.icons8_grupo_de_primer_plano_seleccionado_60
        BtnEmplea.Location = New Point(6, 69)
        BtnEmplea.Name = "BtnEmplea"
        BtnEmplea.Size = New Size(164, 95)
        BtnEmplea.TabIndex = 4
        BtnEmplea.Text = "Empleados"
        BtnEmplea.TextAlign = ContentAlignment.BottomCenter
        BtnEmplea.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Location = New Point(359, 356)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        Label1.Visible = False
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
        ' BtnVolver
        ' 
        BtnVolver.BackColor = Color.SteelBlue
        BtnVolver.FlatStyle = FlatStyle.Flat
        BtnVolver.ForeColor = Color.Black
        BtnVolver.Location = New Point(3, 3)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(75, 23)
        BtnVolver.TabIndex = 4
        BtnVolver.Text = "Volver"
        BtnVolver.UseVisualStyleBackColor = False
        ' 
        ' frmEmpUsu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Name = "frmEmpUsu"
        Text = "frmEmpUsu"
        tlpMenu.ResumeLayout(False)
        gbMenu.ResumeLayout(False)
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tlpMenu As TableLayoutPanel
    Friend WithEvents gbMenu As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents bServicios As Button
    Friend WithEvents bVentas As Button
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnEmplea As Button
    Friend WithEvents BtnUsu As Button
    Friend WithEvents BtnVolver As Button
End Class
