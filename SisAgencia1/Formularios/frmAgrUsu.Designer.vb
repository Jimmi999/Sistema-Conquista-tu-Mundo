<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgrUsu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgrUsu))
        pnlMnuTool = New Panel()
        tsslNomUsu = New Label()
        btnMini = New Button()
        btnExit = New Button()
        btnMnuDesp = New Button()
        txtUsr = New TextBox()
        txtCon = New TextBox()
        txtReCon = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        label11 = New Label()
        Label1 = New Label()
        ckbMostrar = New CheckBox()
        btnAgrMod = New Button()
        pnlMnuTool.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMnuTool
        ' 
        pnlMnuTool.BackColor = Color.SteelBlue
        pnlMnuTool.Controls.Add(tsslNomUsu)
        pnlMnuTool.Controls.Add(btnMini)
        pnlMnuTool.Controls.Add(btnExit)
        pnlMnuTool.Controls.Add(btnMnuDesp)
        pnlMnuTool.Location = New Point(0, 0)
        pnlMnuTool.Name = "pnlMnuTool"
        pnlMnuTool.Size = New Size(318, 34)
        pnlMnuTool.TabIndex = 45
        ' 
        ' tsslNomUsu
        ' 
        tsslNomUsu.AutoSize = True
        tsslNomUsu.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tsslNomUsu.ForeColor = Color.White
        tsslNomUsu.Location = New Point(43, 8)
        tsslNomUsu.Name = "tsslNomUsu"
        tsslNomUsu.Size = New Size(103, 16)
        tsslNomUsu.TabIndex = 4
        tsslNomUsu.Text = "Crear Usuario"
        ' 
        ' btnMini
        ' 
        btnMini.BackColor = Color.SteelBlue
        btnMini.Dock = DockStyle.Right
        btnMini.FlatAppearance.BorderSize = 0
        btnMini.FlatStyle = FlatStyle.Flat
        btnMini.Image = My.Resources.Resources.icons8_minimizar_25
        btnMini.Location = New Point(244, 0)
        btnMini.Name = "btnMini"
        btnMini.Size = New Size(37, 34)
        btnMini.TabIndex = 3
        btnMini.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.SteelBlue
        btnExit.Dock = DockStyle.Right
        btnExit.FlatAppearance.BorderSize = 0
        btnExit.FlatStyle = FlatStyle.Flat
        btnExit.Image = My.Resources.Resources.icons8_eliminar_25
        btnExit.Location = New Point(281, 0)
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
        btnMnuDesp.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnMnuDesp.FlatAppearance.MouseOverBackColor = Color.SteelBlue
        btnMnuDesp.FlatStyle = FlatStyle.Flat
        btnMnuDesp.Image = My.Resources.Resources.icons8_usuario_251
        btnMnuDesp.Location = New Point(0, 0)
        btnMnuDesp.Name = "btnMnuDesp"
        btnMnuDesp.Size = New Size(37, 34)
        btnMnuDesp.TabIndex = 0
        btnMnuDesp.UseVisualStyleBackColor = False
        ' 
        ' txtUsr
        ' 
        txtUsr.Anchor = AnchorStyles.None
        txtUsr.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtUsr.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsr.Location = New Point(32, 116)
        txtUsr.MaxLength = 50
        txtUsr.Name = "txtUsr"
        txtUsr.Size = New Size(257, 22)
        txtUsr.TabIndex = 1
        txtUsr.Tag = "DNI"
        ' 
        ' txtCon
        ' 
        txtCon.Anchor = AnchorStyles.None
        txtCon.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtCon.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtCon.Location = New Point(32, 160)
        txtCon.MaxLength = 50
        txtCon.Name = "txtCon"
        txtCon.PasswordChar = "*"c
        txtCon.Size = New Size(257, 22)
        txtCon.TabIndex = 2
        txtCon.Tag = "Nombre(s)"
        ' 
        ' txtReCon
        ' 
        txtReCon.Anchor = AnchorStyles.None
        txtReCon.BackColor = Color.FromArgb(CByte(249), CByte(252), CByte(255))
        txtReCon.Font = New Font("Microsoft Sans Serif", 9.75F)
        txtReCon.Location = New Point(32, 204)
        txtReCon.MaxLength = 50
        txtReCon.Name = "txtReCon"
        txtReCon.PasswordChar = "*"c
        txtReCon.Size = New Size(257, 22)
        txtReCon.TabIndex = 4
        txtReCon.Tag = "Apellido(s)"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(32, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 16)
        Label3.TabIndex = 50
        Label3.Text = "Usuario"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F)
        Label4.Location = New Point(32, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 16)
        Label4.TabIndex = 51
        Label4.Text = "Contraseña"
        ' 
        ' label11
        ' 
        label11.Anchor = AnchorStyles.None
        label11.AutoSize = True
        label11.Font = New Font("Microsoft Sans Serif", 9.75F)
        label11.Location = New Point(32, 185)
        label11.Name = "label11"
        label11.Size = New Size(121, 16)
        label11.TabIndex = 52
        label11.Text = "Repetir contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SteelBlue
        Label1.Image = My.Resources.Resources.icons8_empleado_18
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(20, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(286, 13)
        Label1.TabIndex = 5
        Label1.Text = "       0123456789012012345678901234567890123456789"
        ' 
        ' ckbMostrar
        ' 
        ckbMostrar.Appearance = Appearance.Button
        ckbMostrar.AutoSize = True
        ckbMostrar.FlatAppearance.BorderSize = 0
        ckbMostrar.FlatStyle = FlatStyle.Flat
        ckbMostrar.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ckbMostrar.ForeColor = Color.SteelBlue
        ckbMostrar.Image = CType(resources.GetObject("ckbMostrar.Image"), Image)
        ckbMostrar.ImageAlign = ContentAlignment.MiddleLeft
        ckbMostrar.Location = New Point(32, 239)
        ckbMostrar.Name = "ckbMostrar"
        ckbMostrar.Size = New Size(35, 30)
        ckbMostrar.TabIndex = 5
        ckbMostrar.Text = "    "
        ckbMostrar.UseVisualStyleBackColor = True
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
        btnAgrMod.Location = New Point(32, 275)
        btnAgrMod.Name = "btnAgrMod"
        btnAgrMod.Size = New Size(257, 54)
        btnAgrMod.TabIndex = 6
        btnAgrMod.Text = "Agregar"
        btnAgrMod.UseVisualStyleBackColor = False
        ' 
        ' frmAgrUsu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(318, 373)
        Controls.Add(btnAgrMod)
        Controls.Add(ckbMostrar)
        Controls.Add(Label1)
        Controls.Add(txtUsr)
        Controls.Add(txtCon)
        Controls.Add(txtReCon)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(label11)
        Controls.Add(pnlMnuTool)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAgrUsu"
        Text = "frmAgrUsu"
        pnlMnuTool.ResumeLayout(False)
        pnlMnuTool.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlMnuTool As Panel
    Friend WithEvents tsslNomUsu As Label
    Friend WithEvents btnMini As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnMnuDesp As Button
    Friend WithEvents txtUsr As TextBox
    Friend WithEvents txtCon As TextBox
    Friend WithEvents txtReCon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ckbMostrar As CheckBox
    Friend WithEvents btnAgrMod As Button
End Class
