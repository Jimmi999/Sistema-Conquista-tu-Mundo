
Imports System.Drawing.Drawing2D

Public Class frmVenCli
    Dim boton1 As Boolean = False
    Dim boton2 As Boolean = False
    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Me.Resize, AddressOf frmClientes_Resize

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCliV.Click
        AbrirFormPanel(frmClientes, pnlVenCli)
        frmClientes.rbCliAct.Checked = True
        'FormularioAbierto(frmDetVent, Button1)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVenV.Click
        AbrirFormPanel(frmvender, pnlVenCli)
        FormularioAbierto(frmClientes, btnVenV)
    End Sub



    Dim bMax As Boolean = False
    Dim frmvender As New frmTelefonos
    Dim frmprincipal As New frmPrincipal 'hacer q al minimazar desde frmprincipal pase lo sig, eso



    Private Sub frmClientes_Resize(sender As Object, e As EventArgs)
        If WindowState = FormWindowState.Minimized Then

        ElseIf WindowState = FormWindowState.Maximized Then
            frmClientes.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ElseIf WindowState = FormWindowState.Normal Then
            frmClientes.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            frmClientes.dgvClientes.RowHeadersWidth = 15

        End If
    End Sub




    Public Sub Mini()
        frmClientes.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Configurar la propiedad de tamaño de filas para que las filas se ajusten al contenido
        frmClientes.dgvClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        ' Habilitar el ajuste automático de la altura de las filas
        frmClientes.dgvClientes.AllowUserToResizeRows = True

        ' Habilitar el ajuste automático del tamaño de las columnas
        frmClientes.dgvClientes.AllowUserToResizeColumns = True

        ' Opcional: Deshabilitar el ajuste automático del tamaño de la última columna

    End Sub


End Class