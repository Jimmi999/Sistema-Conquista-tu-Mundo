<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmp))
        tsClientes = New ToolStrip()
        tbsNuevo = New ToolStripButton()
        tbsGuardar = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        tbsRestaurar = New ToolStripButton()
        tbsEliminar = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        tbsCancelar = New ToolStripButton()
        tbsSalir = New ToolStripButton()
        gbEmpleado = New GroupBox()
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
        txtBusEmp = New TextBox()
        dgvEmpleados = New DataGridView()
        rbEmpCan = New RadioButton()
        rbEmpAct = New RadioButton()
        Label5 = New Label()
        txtDom = New TextBox()
        tsClientes.SuspendLayout()
        gbEmpleado.SuspendLayout()
        gbDGVCliente.SuspendLayout()
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tsClientes
        ' 
        tsClientes.BackColor = Color.Azure
        tsClientes.Items.AddRange(New ToolStripItem() {tbsNuevo, tbsGuardar, ToolStripSeparator1, tbsRestaurar, tbsEliminar, ToolStripSeparator2, tbsCancelar, tbsSalir})
        tsClientes.Location = New Point(0, 0)
        tsClientes.Name = "tsClientes"
        tsClientes.RenderMode = ToolStripRenderMode.Professional
        tsClientes.Size = New Size(800, 25)
        tsClientes.TabIndex = 19
        tsClientes.Text = "ToolStrip1"
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
        ' gbEmpleado
        ' 
        gbEmpleado.Controls.Add(Label5)
        gbEmpleado.Controls.Add(txtDom)
        gbEmpleado.Controls.Add(Label1)
        gbEmpleado.Controls.Add(Label2)
        gbEmpleado.Controls.Add(txtTel)
        gbEmpleado.Controls.Add(txtMail)
        gbEmpleado.Controls.Add(Label6)
        gbEmpleado.Controls.Add(label11)
        gbEmpleado.Controls.Add(Label4)
        gbEmpleado.Controls.Add(Label3)
        gbEmpleado.Controls.Add(cmbPais)
        gbEmpleado.Controls.Add(txtApe)
        gbEmpleado.Controls.Add(txtNom)
        gbEmpleado.Controls.Add(txtDNI)
        gbEmpleado.Font = New Font("Microsoft Sans Serif", 8.25F)
        gbEmpleado.Location = New Point(12, 28)
        gbEmpleado.Name = "gbEmpleado"
        gbEmpleado.Size = New Size(696, 156)
        gbEmpleado.TabIndex = 20
        gbEmpleado.TabStop = False
        gbEmpleado.Text = "Datos Empleado"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(359, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 13)
        Label1.TabIndex = 32
        Label1.Text = "Teléfono"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(359, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 13)
        Label2.TabIndex = 31
        Label2.Text = "Correo"
        ' 
        ' txtTel
        ' 
        txtTel.Enabled = False
        txtTel.Location = New Point(436, 80)
        txtTel.MaxLength = 50
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(254, 20)
        txtTel.TabIndex = 30
        ' 
        ' txtMail
        ' 
        txtMail.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtMail.Enabled = False
        txtMail.Location = New Point(436, 52)
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
        gbDGVCliente.Controls.Add(txtBusEmp)
        gbDGVCliente.Controls.Add(dgvEmpleados)
        gbDGVCliente.Controls.Add(rbEmpCan)
        gbDGVCliente.Controls.Add(rbEmpAct)
        gbDGVCliente.Location = New Point(12, 195)
        gbDGVCliente.Name = "gbDGVCliente"
        gbDGVCliente.Size = New Size(776, 261)
        gbDGVCliente.TabIndex = 21
        gbDGVCliente.TabStop = False
        gbDGVCliente.Text = "Empleados"
        ' 
        ' txtBusEmp
        ' 
        txtBusEmp.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtBusEmp.Font = New Font("Microsoft Sans Serif", 8.25F)
        txtBusEmp.ForeColor = SystemColors.WindowFrame
        txtBusEmp.Location = New Point(202, 17)
        txtBusEmp.MaxLength = 50
        txtBusEmp.Name = "txtBusEmp"
        txtBusEmp.Size = New Size(559, 20)
        txtBusEmp.TabIndex = 3
        txtBusEmp.Text = "Buscar"
        ' 
        ' dgvEmpleados
        ' 
        dgvEmpleados.AllowUserToAddRows = False
        dgvEmpleados.AllowUserToDeleteRows = False
        dgvEmpleados.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvEmpleados.BackgroundColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvEmpleados.Location = New Point(6, 43)
        dgvEmpleados.Name = "dgvEmpleados"
        dgvEmpleados.ReadOnly = True
        dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvEmpleados.Size = New Size(755, 212)
        dgvEmpleados.TabIndex = 2
        ' 
        ' rbEmpCan
        ' 
        rbEmpCan.AutoSize = True
        rbEmpCan.Font = New Font("Microsoft Sans Serif", 8.25F)
        rbEmpCan.Location = New Point(77, 18)
        rbEmpCan.Name = "rbEmpCan"
        rbEmpCan.Size = New Size(75, 17)
        rbEmpCan.TabIndex = 1
        rbEmpCan.TabStop = True
        rbEmpCan.Text = "Eliminados"
        rbEmpCan.UseVisualStyleBackColor = True
        ' 
        ' rbEmpAct
        ' 
        rbEmpAct.AutoSize = True
        rbEmpAct.Font = New Font("Microsoft Sans Serif", 8.25F)
        rbEmpAct.Location = New Point(11, 18)
        rbEmpAct.Name = "rbEmpAct"
        rbEmpAct.Size = New Size(60, 17)
        rbEmpAct.TabIndex = 0
        rbEmpAct.TabStop = True
        rbEmpAct.Text = "Activos"
        rbEmpAct.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(359, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 13)
        Label5.TabIndex = 34
        Label5.Text = "Domicilio"
        ' 
        ' txtDom
        ' 
        txtDom.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtDom.Enabled = False
        txtDom.Location = New Point(436, 24)
        txtDom.MaxLength = 50
        txtDom.Name = "txtDom"
        txtDom.Size = New Size(254, 20)
        txtDom.TabIndex = 33
        ' 
        ' frmEmp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(800, 468)
        Controls.Add(gbDGVCliente)
        Controls.Add(gbEmpleado)
        Controls.Add(tsClientes)
        Name = "frmEmp"
        Text = "frmEmp"
        tsClientes.ResumeLayout(False)
        tsClientes.PerformLayout()
        gbEmpleado.ResumeLayout(False)
        gbEmpleado.PerformLayout()
        gbDGVCliente.ResumeLayout(False)
        gbDGVCliente.PerformLayout()
        CType(dgvEmpleados, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tsClientes As ToolStrip
    Friend WithEvents tbsNuevo As ToolStripButton
    Friend WithEvents tbsGuardar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tbsRestaurar As ToolStripButton
    Friend WithEvents tbsEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tbsCancelar As ToolStripButton
    Friend WithEvents tbsSalir As ToolStripButton
    Friend WithEvents gbEmpleado As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtMail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPais As ComboBox
    Friend WithEvents txtApe As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents gbDGVCliente As GroupBox
    Friend WithEvents txtBusEmp As TextBox
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents rbEmpCan As RadioButton
    Friend WithEvents rbEmpAct As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDom As TextBox
End Class
