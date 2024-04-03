<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenCli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVenCli))
        btnCliV = New Button()
        btnVenV = New Button()
        pnlVenCli = New Panel()
        SuspendLayout()
        ' 
        ' btnCliV
        ' 
        btnCliV.BackColor = Color.SteelBlue
        btnCliV.FlatAppearance.BorderColor = Color.FromArgb(CByte(134), CByte(26), CByte(26))
        btnCliV.FlatAppearance.BorderSize = 0
        btnCliV.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnCliV.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnCliV.FlatStyle = FlatStyle.Flat
        btnCliV.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCliV.ForeColor = Color.White
        btnCliV.Image = My.Resources.Resources.icons8_cliente_24
        btnCliV.ImageAlign = ContentAlignment.MiddleLeft
        btnCliV.Location = New Point(0, 0)
        btnCliV.Name = "btnCliV"
        btnCliV.Size = New Size(99, 31)
        btnCliV.TabIndex = 0
        btnCliV.Text = "       Clientes"
        btnCliV.UseVisualStyleBackColor = False
        ' 
        ' btnVenV
        ' 
        btnVenV.BackColor = Color.SteelBlue
        btnVenV.Enabled = False
        btnVenV.FlatAppearance.BorderColor = Color.MediumTurquoise
        btnVenV.FlatAppearance.BorderSize = 0
        btnVenV.FlatAppearance.MouseDownBackColor = Color.SteelBlue
        btnVenV.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(60), CByte(113), CByte(155))
        btnVenV.FlatStyle = FlatStyle.Flat
        btnVenV.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVenV.ForeColor = Color.White
        btnVenV.Image = My.Resources.Resources.icons8_ventas_24
        btnVenV.ImageAlign = ContentAlignment.MiddleLeft
        btnVenV.Location = New Point(99, 0)
        btnVenV.Name = "btnVenV"
        btnVenV.Size = New Size(99, 31)
        btnVenV.TabIndex = 1
        btnVenV.Text = "       Ventas"
        btnVenV.UseVisualStyleBackColor = False
        ' 
        ' pnlVenCli
        ' 
        pnlVenCli.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlVenCli.BackColor = Color.Azure
        pnlVenCli.BackgroundImage = CType(resources.GetObject("pnlVenCli.BackgroundImage"), Image)
        pnlVenCli.BackgroundImageLayout = ImageLayout.Center
        pnlVenCli.Location = New Point(0, 31)
        pnlVenCli.Name = "pnlVenCli"
        pnlVenCli.Size = New Size(802, 420)
        pnlVenCli.TabIndex = 2
        ' 
        ' frmVenCli
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(800, 450)
        Controls.Add(btnVenV)
        Controls.Add(pnlVenCli)
        Controls.Add(btnCliV)
        ForeColor = Color.Black
        Name = "frmVenCli"
        Text = "frmVentas"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnCliV As Button
    Friend WithEvents btnVenV As Button
    Friend WithEvents pnlVenCli As Panel
End Class
