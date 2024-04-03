<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVender
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
        GroupBox2 = New GroupBox()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        Label9 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox5 = New TextBox()
        Button2 = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        DataGridView2 = New DataGridView()
        Button3 = New Button()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        GroupBox2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(DataGridView1)
        GroupBox2.Location = New Point(384, 57)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(440, 245)
        GroupBox2.TabIndex = 21
        GroupBox2.TabStop = False
        GroupBox2.Text = "Servicios"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(6, 16)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(422, 23)
        ComboBox1.TabIndex = 25
        ComboBox1.Text = "Tipo Servicio"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(6, 42)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(422, 23)
        TextBox4.TabIndex = 24
        TextBox4.Text = "Buscar Servicio"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(6, 72)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(422, 167)
        DataGridView1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(688, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 23)
        Button1.TabIndex = 20
        Button1.Text = "Cancelar Venta"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox3)
        GroupBox1.Controls.Add(ComboBox2)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(12, 99)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(366, 203)
        GroupBox1.TabIndex = 19
        GroupBox1.TabStop = False
        GroupBox1.Text = "Datos Serv/Chof"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(18, 145)
        Label9.Name = "Label9"
        Label9.Size = New Size(38, 15)
        Label9.TabIndex = 34
        Label9.Text = "Fecha"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(95, 137)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(254, 23)
        DateTimePicker1.TabIndex = 33
        DateTimePicker1.Value = New Date(2024, 2, 21, 0, 0, 0, 0)
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(95, 108)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(254, 23)
        TextBox5.TabIndex = 31
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(95, 166)
        Button2.Name = "Button2"
        Button2.Size = New Size(254, 23)
        Button2.TabIndex = 29
        Button2.Text = "Agregar/Quitar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 116)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 28
        Label6.Text = "Monto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 27
        Label5.Text = "Prov Serv"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 26
        Label4.Text = "TpServ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 25
        Label3.Text = "NomServ"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(95, 22)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(254, 23)
        TextBox1.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(83, 484)
        Label2.Name = "Label2"
        Label2.Size = New Size(13, 15)
        Label2.TabIndex = 18
        Label2.Text = "0"
        Label2.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 484)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 17
        Label1.Text = "Precio Total:"
        Label1.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 73)
        Label7.Name = "Label7"
        Label7.Size = New Size(137, 15)
        Label7.TabIndex = 23
        Label7.Text = "NombreApellidosCliente"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(12, 308)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(812, 173)
        DataGridView2.TabIndex = 24
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(546, 28)
        Button3.Name = "Button3"
        Button3.Size = New Size(136, 23)
        Button3.TabIndex = 25
        Button3.Text = "Realizar Venta"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(95, 51)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(254, 23)
        ComboBox2.TabIndex = 35
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(95, 80)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(254, 23)
        ComboBox3.TabIndex = 36
        ' 
        ' frmVender
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(836, 507)
        Controls.Add(Button3)
        Controls.Add(DataGridView2)
        Controls.Add(Label7)
        Controls.Add(GroupBox2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmVender"
        Text = "frmVender"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
End Class
