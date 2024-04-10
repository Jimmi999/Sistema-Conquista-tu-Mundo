<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        gbCliente = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        txtTel = New TextBox()
        txtMail = New TextBox()
        Label6 = New Label()
        label11 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        cmbPais = New ComboBox()
        txtApe = New TextBox()
        txtNom = New TextBox()
        txtDNI = New TextBox()
        gbDGVCliente = New GroupBox()
        PictureBox1 = New PictureBox()
        txtBusCli = New TextBox()
        dgvClientes = New DataGridView()
        rbCliCan = New RadioButton()
        rbCliAct = New RadioButton()
        ep = New ErrorProvider(components)
        tbsNuevo = New ToolStripButton()
        tbsGuardar = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        tbsRestaurar = New ToolStripButton()
        tbsEliminar = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        tbsCancelar = New ToolStripButton()
        tbsSalir = New ToolStripButton()
        tsClientes = New ToolStrip()
        btnAgrCom = New Button()
        BtnAgrTel = New Button()
        gbCliente.SuspendLayout()
        gbDGVCliente.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        tsClientes.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbCliente
        ' 
        gbCliente.Controls.Add(btnAgrCom)
        gbCliente.Controls.Add(BtnAgrTel)
        gbCliente.Controls.Add(Label1)
        gbCliente.Controls.Add(Label2)
        gbCliente.Controls.Add(txtTel)
        gbCliente.Controls.Add(txtMail)
        gbCliente.Controls.Add(Label6)
        gbCliente.Controls.Add(label11)
        gbCliente.Controls.Add(Label4)
        gbCliente.Controls.Add(Label3)
        gbCliente.Controls.Add(cmbPais)
        gbCliente.Controls.Add(txtApe)
        gbCliente.Controls.Add(txtNom)
        gbCliente.Controls.Add(txtDNI)
        gbCliente.Font = New Font("Microsoft Sans Serif", 8.25F)
        gbCliente.Location = New Point(12, 39)
        gbCliente.Name = "gbCliente"
        gbCliente.Size = New Size(696, 156)
        gbCliente.TabIndex = 14
        gbCliente.TabStop = False
        gbCliente.Text = "Datos Cliente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(357, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 13)
        Label1.TabIndex = 32
        Label1.Text = "Teléfono"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(357, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 13)
        Label2.TabIndex = 31
        Label2.Text = "Correo"
        ' 
        ' txtTel
        ' 
        txtTel.Enabled = False
        txtTel.Location = New Point(434, 52)
        txtTel.MaxLength = 50
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(254, 20)
        txtTel.TabIndex = 30
        ' 
        ' txtMail
        ' 
        txtMail.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtMail.Enabled = False
        txtMail.Location = New Point(434, 24)
        txtMail.MaxLength = 50
        txtMail.Name = "txtMail"
        txtMail.Size = New Size(254, 20)
        txtMail.TabIndex = 29
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(29, 13)
        Label6.TabIndex = 28
        Label6.Text = "País"
        ' 
        ' label11
        ' 
        label11.AutoSize = True
        label11.Location = New Point(11, 89)
        label11.Name = "label11"
        label11.Size = New Size(55, 13)
        label11.TabIndex = 27
        label11.Text = "Apellido(s)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 13)
        Label4.TabIndex = 26
        Label4.Text = "Nombre(s)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(26, 13)
        Label3.TabIndex = 25
        Label3.Text = "DNI"
        ' 
        ' cmbPais
        ' 
        cmbPais.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        cmbPais.Enabled = False
        cmbPais.FormattingEnabled = True
        cmbPais.Location = New Point(88, 110)
        cmbPais.MaxLength = 50
        cmbPais.Name = "cmbPais"
        cmbPais.Size = New Size(254, 21)
        cmbPais.TabIndex = 24
        ' 
        ' txtApe
        ' 
        txtApe.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtApe.Enabled = False
        txtApe.Location = New Point(88, 81)
        txtApe.MaxLength = 50
        txtApe.Name = "txtApe"
        txtApe.Size = New Size(254, 20)
        txtApe.TabIndex = 23
        ' 
        ' txtNom
        ' 
        txtNom.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtNom.Enabled = False
        txtNom.Location = New Point(88, 52)
        txtNom.MaxLength = 50
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(254, 20)
        txtNom.TabIndex = 22
        ' 
        ' txtDNI
        ' 
        txtDNI.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtDNI.Enabled = False
        txtDNI.Location = New Point(88, 24)
        txtDNI.MaxLength = 10
        txtDNI.Name = "txtDNI"
        txtDNI.Size = New Size(254, 20)
        txtDNI.TabIndex = 21
        ' 
        ' gbDGVCliente
        ' 
        gbDGVCliente.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gbDGVCliente.Controls.Add(PictureBox1)
        gbDGVCliente.Controls.Add(txtBusCli)
        gbDGVCliente.Controls.Add(dgvClientes)
        gbDGVCliente.Controls.Add(rbCliCan)
        gbDGVCliente.Controls.Add(rbCliAct)
        gbDGVCliente.Location = New Point(12, 195)
        gbDGVCliente.Name = "gbDGVCliente"
        gbDGVCliente.Size = New Size(776, 261)
        gbDGVCliente.TabIndex = 16
        gbDGVCliente.TabStop = False
        gbDGVCliente.Text = "Clientes"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.icons8_buscar_48
        PictureBox1.Location = New Point(256, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 32)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' txtBusCli
        ' 
        txtBusCli.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtBusCli.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtBusCli.ForeColor = SystemColors.WindowFrame
        txtBusCli.Location = New Point(290, 15)
        txtBusCli.MaxLength = 50
        txtBusCli.Name = "txtBusCli"
        txtBusCli.Size = New Size(471, 20)
        txtBusCli.TabIndex = 3
        txtBusCli.Text = "Buscar"
        ' 
        ' dgvClientes
        ' 
        dgvClientes.AllowUserToAddRows = False
        dgvClientes.AllowUserToDeleteRows = False
        dgvClientes.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvClientes.BackgroundColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(6, 43)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.ReadOnly = True
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvClientes.Size = New Size(755, 212)
        dgvClientes.TabIndex = 2
        ' 
        ' rbCliCan
        ' 
        rbCliCan.AutoSize = True
        rbCliCan.Font = New Font("Microsoft Sans Serif", 8.25F)
        rbCliCan.Location = New Point(126, 18)
        rbCliCan.Name = "rbCliCan"
        rbCliCan.Size = New Size(121, 17)
        rbCliCan.TabIndex = 1
        rbCliCan.TabStop = True
        rbCliCan.Text = "Clientes Cancelados"
        rbCliCan.UseVisualStyleBackColor = True
        ' 
        ' rbCliAct
        ' 
        rbCliAct.AutoSize = True
        rbCliAct.Font = New Font("Microsoft Sans Serif", 8.25F)
        rbCliAct.Location = New Point(11, 18)
        rbCliAct.Name = "rbCliAct"
        rbCliAct.Size = New Size(100, 17)
        rbCliAct.TabIndex = 0
        rbCliAct.TabStop = True
        rbCliAct.Text = "Clientes Activos"
        rbCliAct.UseVisualStyleBackColor = True
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ' 
        ' tbsNuevo
        ' 
        tbsNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbsNuevo.Image = CType(resources.GetObject("tbsNuevo.Image"), Image)
        tbsNuevo.ImageTransparentColor = Color.Magenta
        tbsNuevo.Name = "tbsNuevo"
        tbsNuevo.Size = New Size(23, 22)
        tbsNuevo.Text = "Nuevo"
        ' 
        ' tbsGuardar
        ' 
        tbsGuardar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbsGuardar.Image = CType(resources.GetObject("tbsGuardar.Image"), Image)
        tbsGuardar.ImageTransparentColor = Color.Magenta
        tbsGuardar.Name = "tbsGuardar"
        tbsGuardar.Size = New Size(23, 22)
        tbsGuardar.Text = "Guardar"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' tbsRestaurar
        ' 
        tbsRestaurar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbsRestaurar.Enabled = False
        tbsRestaurar.Image = CType(resources.GetObject("tbsRestaurar.Image"), Image)
        tbsRestaurar.ImageTransparentColor = Color.Magenta
        tbsRestaurar.Name = "tbsRestaurar"
        tbsRestaurar.Size = New Size(23, 22)
        tbsRestaurar.Text = "Restaurar"
        ' 
        ' tbsEliminar
        ' 
        tbsEliminar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbsEliminar.Enabled = False
        tbsEliminar.Image = CType(resources.GetObject("tbsEliminar.Image"), Image)
        tbsEliminar.ImageTransparentColor = Color.Magenta
        tbsEliminar.Name = "tbsEliminar"
        tbsEliminar.Size = New Size(23, 22)
        tbsEliminar.Text = "Eliminar"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' tbsCancelar
        ' 
        tbsCancelar.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbsCancelar.Enabled = False
        tbsCancelar.Image = CType(resources.GetObject("tbsCancelar.Image"), Image)
        tbsCancelar.ImageTransparentColor = Color.Magenta
        tbsCancelar.Name = "tbsCancelar"
        tbsCancelar.Size = New Size(23, 22)
        tbsCancelar.Text = "Cancelar"
        ' 
        ' tbsSalir
        ' 
        tbsSalir.DisplayStyle = ToolStripItemDisplayStyle.Image
        tbsSalir.Image = CType(resources.GetObject("tbsSalir.Image"), Image)
        tbsSalir.ImageTransparentColor = Color.Magenta
        tbsSalir.Name = "tbsSalir"
        tbsSalir.Size = New Size(23, 22)
        tbsSalir.Text = "Salir"
        ' 
        ' tsClientes
        ' 
        tsClientes.BackColor = Color.Azure
        tsClientes.Items.AddRange(New ToolStripItem() {tbsNuevo, tbsGuardar, ToolStripSeparator1, tbsRestaurar, tbsEliminar, ToolStripSeparator2, tbsCancelar, tbsSalir})
        tsClientes.Location = New Point(0, 0)
        tsClientes.Name = "tsClientes"
        tsClientes.RenderMode = ToolStripRenderMode.Professional
        tsClientes.Size = New Size(800, 25)
        tsClientes.TabIndex = 13
        tsClientes.Text = "ToolStrip1"
        ' 
        ' btnAgrCom
        ' 
        btnAgrCom.BackColor = Color.SteelBlue
        btnAgrCom.FlatAppearance.BorderColor = Color.SlateGray
        btnAgrCom.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnAgrCom.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnAgrCom.FlatStyle = FlatStyle.Flat
        btnAgrCom.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgrCom.ForeColor = Color.WhiteSmoke
        btnAgrCom.Image = My.Resources.Resources.icons8_carrito_de_compras_24
        btnAgrCom.ImageAlign = ContentAlignment.MiddleLeft
        btnAgrCom.Location = New Point(434, 89)
        btnAgrCom.Name = "btnAgrCom"
        btnAgrCom.Size = New Size(254, 44)
        btnAgrCom.TabIndex = 35
        btnAgrCom.Text = "Vender"
        btnAgrCom.UseVisualStyleBackColor = False
        ' 
        ' BtnAgrTel
        ' 
        BtnAgrTel.BackColor = Color.SteelBlue
        BtnAgrTel.FlatAppearance.BorderColor = Color.SlateGray
        BtnAgrTel.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        BtnAgrTel.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        BtnAgrTel.FlatStyle = FlatStyle.Flat
        BtnAgrTel.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAgrTel.ForeColor = Color.White
        BtnAgrTel.Image = My.Resources.Resources.icons8_teléfono_25
        BtnAgrTel.ImageAlign = ContentAlignment.MiddleLeft
        BtnAgrTel.Location = New Point(434, 52)
        BtnAgrTel.Name = "BtnAgrTel"
        BtnAgrTel.Size = New Size(254, 30)
        BtnAgrTel.TabIndex = 34
        BtnAgrTel.Text = "Agregar/Modificar"
        BtnAgrTel.UseVisualStyleBackColor = False
        BtnAgrTel.Visible = False
        ' 
        ' frmClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 468)
        Controls.Add(gbDGVCliente)
        Controls.Add(gbCliente)
        Controls.Add(tsClientes)
        DoubleBuffered = True
        Name = "frmClientes"
        Text = "frmDetVent"
        gbCliente.ResumeLayout(False)
        gbCliente.PerformLayout()
        gbDGVCliente.ResumeLayout(False)
        gbDGVCliente.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        tsClientes.ResumeLayout(False)
        tsClientes.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents gbCliente As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents gbDGVCliente As GroupBox
    Friend WithEvents rbCliAct As RadioButton
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents rbCliCan As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtBusCli As TextBox
    Friend WithEvents tsClientes As ToolStrip
    Friend WithEvents tbsNuevo As ToolStripButton
    Friend WithEvents tbsGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbsRestaurar As ToolStripButton
    Friend WithEvents tbsEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tbsCancelar As ToolStripButton
    Friend WithEvents tbsSalir As ToolStripButton
    Friend WithEvents btnAgrCom As Button
    Friend WithEvents BtnAgrTel As Button
End Class
