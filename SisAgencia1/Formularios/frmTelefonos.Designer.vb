<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelefonos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelefonos))
        dgvTelefonos = New DataGridView()
        gbTelefonos = New GroupBox()
        gbDatoTel = New GroupBox()
        Label1 = New Label()
        txtAgrTel = New TextBox()
        btnAgrMod = New Button()
        btnEliRes = New Button()
        btnCancelar = New Button()
        ep = New ErrorProvider(components)
        pnlMnuTool = New Panel()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnMiniMax = New Button()
        btnExit = New Button()
        btnMnuDesp = New Button()
        CType(dgvTelefonos, ComponentModel.ISupportInitialize).BeginInit()
        gbTelefonos.SuspendLayout()
        gbDatoTel.SuspendLayout()
        CType(ep, ComponentModel.ISupportInitialize).BeginInit()
        pnlMnuTool.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvTelefonos
        ' 
        dgvTelefonos.AllowUserToAddRows = False
        dgvTelefonos.AllowUserToDeleteRows = False
        dgvTelefonos.AllowUserToResizeColumns = False
        dgvTelefonos.AllowUserToResizeRows = False
        dgvTelefonos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTelefonos.BackgroundColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        dgvTelefonos.BorderStyle = BorderStyle.None
        dgvTelefonos.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgvTelefonos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTelefonos.Location = New Point(6, 15)
        dgvTelefonos.Name = "dgvTelefonos"
        dgvTelefonos.Size = New Size(768, 376)
        dgvTelefonos.TabIndex = 3
        ' 
        ' gbTelefonos
        ' 
        gbTelefonos.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        gbTelefonos.Controls.Add(dgvTelefonos)
        gbTelefonos.Location = New Point(12, 108)
        gbTelefonos.Name = "gbTelefonos"
        gbTelefonos.Size = New Size(780, 397)
        gbTelefonos.TabIndex = 7
        gbTelefonos.TabStop = False
        ' 
        ' gbDatoTel
        ' 
        gbDatoTel.Controls.Add(Label1)
        gbDatoTel.Controls.Add(txtAgrTel)
        gbDatoTel.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gbDatoTel.Location = New Point(12, 49)
        gbDatoTel.Name = "gbDatoTel"
        gbDatoTel.Size = New Size(399, 53)
        gbDatoTel.TabIndex = 15
        gbDatoTel.TabStop = False
        gbDatoTel.Text = "Datos Cliente"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 8.25F)
        Label1.Location = New Point(6, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 13)
        Label1.TabIndex = 32
        Label1.Text = "Teléfono"
        ' 
        ' txtAgrTel
        ' 
        txtAgrTel.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtAgrTel.Enabled = False
        txtAgrTel.Location = New Point(74, 21)
        txtAgrTel.MaxLength = 50
        txtAgrTel.Name = "txtAgrTel"
        txtAgrTel.Size = New Size(319, 22)
        txtAgrTel.TabIndex = 30
        ' 
        ' btnAgrMod
        ' 
        btnAgrMod.BackColor = Color.SteelBlue
        btnAgrMod.FlatAppearance.BorderColor = Color.SlateGray
        btnAgrMod.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnAgrMod.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnAgrMod.FlatStyle = FlatStyle.Flat
        btnAgrMod.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgrMod.ForeColor = Color.White
        btnAgrMod.Image = My.Resources.Resources.icons8_más_24
        btnAgrMod.ImageAlign = ContentAlignment.MiddleLeft
        btnAgrMod.Location = New Point(417, 70)
        btnAgrMod.Name = "btnAgrMod"
        btnAgrMod.Size = New Size(121, 31)
        btnAgrMod.TabIndex = 16
        btnAgrMod.Text = "    Agregar"
        btnAgrMod.UseVisualStyleBackColor = False
        ' 
        ' btnEliRes
        ' 
        btnEliRes.BackColor = Color.SteelBlue
        btnEliRes.FlatAppearance.BorderColor = Color.SlateGray
        btnEliRes.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnEliRes.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnEliRes.FlatStyle = FlatStyle.Flat
        btnEliRes.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliRes.ForeColor = Color.White
        btnEliRes.Image = My.Resources.Resources.icons8_menos_25
        btnEliRes.ImageAlign = ContentAlignment.MiddleLeft
        btnEliRes.Location = New Point(544, 70)
        btnEliRes.Name = "btnEliRes"
        btnEliRes.Size = New Size(121, 31)
        btnEliRes.TabIndex = 17
        btnEliRes.Text = "    Eliminar"
        btnEliRes.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.Firebrick
        btnCancelar.FlatAppearance.BorderColor = Color.Maroon
        btnCancelar.FlatAppearance.MouseDownBackColor = Color.Firebrick
        btnCancelar.FlatAppearance.MouseOverBackColor = Color.DarkRed
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancelar.ForeColor = Color.WhiteSmoke
        btnCancelar.Image = My.Resources.Resources.icons8_cancelar_25
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(671, 70)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(121, 31)
        btnCancelar.TabIndex = 18
        btnCancelar.Text = "    Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' ep
        ' 
        ep.ContainerControl = Me
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMnuTool.BackColor = Color.SteelBlue
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnMini)
        pnlMnuTool.Controls.Add(btnMiniMax)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Controls.Add(btnMnuDesp)
        pnlMnuTool.Location = New Point(0, 0)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(806, 34)
        pnlMnuTool.TabIndex = 20
        ' 
        ' tsslNomUsu
        ' 
        tsslNomUsu.AutoSize = True
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.White
        tsslNomUsu.Location = New Point(43, 8)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(159, 16)
        tsslNomUsu.TabIndex = 4
        tsslNomUsu.Text = "Teléfonos de Clientes"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.SteelBlue
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(695, 0)
        btnMini.Name = "btnMini"
        btnMini.Size = New Size(37, 34)
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
        btnMiniMax.Location = New Point(732, 0)
        btnMiniMax.Name = "btnMiniMax"
        btnMiniMax.Size = New Size(37, 34)
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
        btnExit.Location = New Point(769, 0)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(37, 34)
        btnExit.TabIndex = 1
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnMnuDesp
        ' 
        btnMnuDesp.BackColor = Color.SteelBlue
        btnMnuDesp.Dock = DockStyle.Left
        btnMnuDesp.FlatAppearance.BorderSize = 0
        btnMnuDesp.FlatStyle = FlatStyle.Flat
        btnMnuDesp.Image = My.Resources.Resources.icons8_teléfono_25
        btnMnuDesp.Location = New Point(0, 0)
        btnMnuDesp.Name = "btnMnuDesp"
        btnMnuDesp.Size = New Size(37, 34)
        btnMnuDesp.TabIndex = 0
        btnMnuDesp.UseVisualStyleBackColor = False
        ' 
        ' frmTelefonos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(804, 517)
        Controls.Add(pnlMnuTool)
        Controls.Add(btnCancelar)
        Controls.Add(btnEliRes)
        Controls.Add(btnAgrMod)
        Controls.Add(gbDatoTel)
        Controls.Add(gbTelefonos)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmTelefonos"
        Text = "Teléfonos de Clientes"
        CType(dgvTelefonos, ComponentModel.ISupportInitialize).EndInit()
        gbTelefonos.ResumeLayout(False)
        gbDatoTel.ResumeLayout(False)
        gbDatoTel.PerformLayout()
        CType(ep, ComponentModel.ISupportInitialize).EndInit()
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents dgvTelefonos As DataGridView
    Friend WithEvents gbTelefonos As GroupBox
    Friend WithEvents gbDatoTel As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAgrTel As TextBox
    Friend WithEvents btnAgrMod As Button
    Friend WithEvents btnEliRes As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents ep As ErrorProvider
    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnMiniMax As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMnuDesp As Button
End Class
