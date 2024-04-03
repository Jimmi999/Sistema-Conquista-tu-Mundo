
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip
Imports Datos
Imports Entidades
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmClientes

    Public CodCli As Integer = 0
    Dim ClientesSP As New clsCli
    Dim ClienteDatos As New eCli
    Dim bandera As Boolean
    Private Sub GetCliAct()
        dgvClientes.DataSource = ClientesSP.GetClientes()
    End Sub

    Private Sub GetCliCan()
        dgvClientes.DataSource = ClientesSP.GetClientesCancel()
    End Sub




    'Private Sub frmClientes_Resize(sender As Object, e As EventArgs)
    '    If WindowState = FormWindowState.Minimized Then

    '    ElseIf WindowState = FormWindowState.Maximized Then
    '        Me.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    '    ElseIf WindowState = FormWindowState.Normal Then
    '        Me.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    '        Me.dgvClientes.RowHeadersWidth = 15

    '    End If
    'End Sub





    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAgrCom.Visible = False
        dgvClientes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        dgvClientes.ColumnHeadersDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 9)
        txtBusCli.Text = "Buscar"
        txtBusCli.ForeColor = Color.Gray

        GetCliAct()
        CargaCmbPais()
        HabilitarNo()


        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        Me.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        Me.dgvClientes.RowHeadersWidth = 15

    End Sub


    Private Sub CargaCmbPais()
        cmbPais.DataSource = ClientesSP.GetPaises()
        cmbPais.ValueMember = "ID"
        cmbPais.DisplayMember = "NOMBRE"
    End Sub

    Private Sub btnAgrCom_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbCliAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliAct.CheckedChanged
        Determinar()

    End Sub

    Public Sub Determinar()
        If rbCliAct.Checked = True Then
            GetCliAct()


        Else
            GetCliCan()


        End If

    End Sub

    Private Sub HabilitarNuevo()
        ep.Clear()
        bandera = True
        ClearText(txtTel)
        tbsEliminar.Enabled = False
        tbsCancelar.Enabled = True
        tbsGuardar.Enabled = True
        tbsNuevo.Enabled = False
        tbsRestaurar.Enabled = False
        btnAgrCom.Enabled = True
        txtDNI.Enabled = True
        txtNom.Enabled = True
        txtApe.Enabled = True
        cmbPais.Enabled = True
        txtMail.Enabled = True
        txtTel.Enabled = True
        txtDNI.Focus()

        Determinar()
    End Sub

    Private Sub HabilitarNo()
        ep.Clear()
        txtDNI.Focus()
        btnAgrCom.Enabled = False
        ' Deshabilita los controles y limpia los datos
        tbsEliminar.Enabled = False
        tbsCancelar.Enabled = False
        tbsGuardar.Enabled = False
        tbsNuevo.Enabled = True
        tbsRestaurar.Enabled = False
        BtnAgrTel.Visible = False
        txtDNI.Enabled = False
        txtNom.Enabled = False
        txtApe.Enabled = False
        cmbPais.Enabled = False
        txtMail.Enabled = False
        txtTel.Enabled = False
        ClearText(txtDNI)
        ClearText(txtNom)
        ClearText(txtApe)
        ClearText(txtMail)
        ClearText(txtTel)

        cmbPais.Text = ""
        cmbPais.SelectedIndex = -1 ' Establece el ComboBox como vacío
        Determinar()
    End Sub

    Private Sub tbsNuevo_Click(sender As Object, e As EventArgs) Handles tbsNuevo.Click
        ' Restablecer el texto y el color de txtBusCli
        frmVenCli.btnCliV.BackColor = Color.Firebrick
        txtBusCli.Text = "Buscar"
        txtBusCli.ForeColor = Color.Gray
        HabilitarNuevo()
        btnAgrCom.Text = "Agregar Cliente"
        btnAgrCom.Visible = True
        BtnAgrTel.Visible = False
        txtTel.Visible = True
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        If dgvClientes.SelectedCells.Count > 0 Then ' Verifica si hay celdas seleccionadas
            HabilitarNuevo()
            bandera = False
            btnAgrCom.Enabled = True
            txtTel.Enabled = False

            btnAgrCom.Text = "Comenzar Compra"
            btnAgrCom.Visible = True

            If rbCliCan.Checked Then
                tbsEliminar.Enabled = False
                tbsRestaurar.Enabled = True
                btnAgrCom.Visible = False
                BtnAgrTel.Visible = False
                txtTel.Visible = True
            Else
                btnAgrCom.Text = "Comenzar Compra"
                btnAgrCom.Visible = True
                tbsEliminar.Enabled = True
                tbsRestaurar.Enabled = False
                txtTel.Visible = False
                BtnAgrTel.Visible = True
            End If



            If e.RowIndex >= 0 AndAlso e.RowIndex < dgvClientes.Rows.Count Then
                Dim row As DataGridViewRow = dgvClientes.Rows(e.RowIndex)
                If Not row.Cells.Cast(Of DataGridViewCell)().Any(Function(cell) cell.Value IsNot Nothing AndAlso Not cell.Value.Equals(DBNull.Value)) Then
                    ' Verifica si todas las celdas de la fila no son nulas
                    HabilitarNo()
                Else
                    CodCli = CInt(row.Cells(0)?.Value) ' Actualiza el código del cliente seleccionado
                    txtDNI.Text = row.Cells(1)?.Value?.ToString()
                    dnibus = row.Cells(1)?.Value?.ToString()
                    txtNom.Text = row.Cells(3)?.Value?.ToString()
                    NomCli = row.Cells(3)?.Value?.ToString()
                    txtApe.Text = row.Cells(2)?.Value?.ToString()
                    ApeCli = row.Cells(2)?.Value?.ToString()
                    cmbPais.SelectedValue = row.Cells(8)?.Value?.ToString() ' Suponiendo que la columna 8 contiene el código del país
                    txtMail.Text = row.Cells(5)?.Value?.ToString()
                    frmVenCli.btnCliV.BackColor = Color.Firebrick
                    'txtTel.Text = row.Cells(6)?.Value?.ToString()
                    'dtpFecNac.Value = If(row.Cells(6)?.Value IsNot Nothing, Convert.ToDateTime(row.Cells(6).Value), DateTime.MinValue)
                End If
            End If


        End If
    End Sub

    Private Sub rbCliCan_CheckedChanged(sender As Object, e As EventArgs) Handles rbCliCan.CheckedChanged
        Determinar()
    End Sub

    Private Sub tbsCancelar_Click(sender As Object, e As EventArgs) Handles tbsCancelar.Click
        ' Restablecer el texto y el color de txtBusCli
        CodCli = 0
        frmVenCli.btnCliV.BackColor = Color.SteelBlue
        txtBusCli.Text = "Buscar"
        txtBusCli.ForeColor = Color.Gray
        btnAgrCom.Text = ""
        btnAgrCom.Visible = False
        HabilitarNo()
        BtnAgrTel.Visible = False
        txtTel.Visible = True
    End Sub

    Private Sub dgvClientes_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgvClientes.DataBindingComplete
        If dgvClientes.Columns.Count > 0 Then
            dgvClientes.Columns(dgvClientes.Columns.Count - 1).Visible = False
        End If
    End Sub

    Private Sub txtDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNI.KeyPress
        SoloInt(sender, e)
    End Sub

    Private Sub txtDNI_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged
        FiltrarNoInt(sender, e)
    End Sub

    Private Sub txtTel_TextChanged(sender As Object, e As EventArgs) Handles txtTel.TextChanged
        FiltrarNoIntTel(sender, e)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        SoloIntTel(sender, e)
    End Sub

    Private Sub tbsEliminar_Click(sender As Object, e As EventArgs) Handles tbsEliminar.Click
        Dim resultado As DialogResult = MessageBox.Show("Esta por dar de baja un cliente, ¿Desea continuar?", "Eliminar cliente " & txtApe.Text & "," & txtNom.Text, MessageBoxButtons.YesNo)
        If resultado = DialogResult.Yes Then
            If ClientesSP.BajaClientes(CodCli, CodUsu) Then
                HabilitarNo()
                Determinar()
                btnAgrCom.Visible = False
                frmVenCli.btnCliV.BackColor = Color.SteelBlue
            Else
                MensajeError("Hubo un error al intentar dar de baja al cliente " & txtApe.Text)
            End If
        End If
    End Sub

    Private Sub tbsRestaurar_Click(sender As Object, e As EventArgs) Handles tbsRestaurar.Click
        CampoBlanco(Me.gbCliente, ep)
        If banbl = True Then
            If ClientesSP.RecClientes(CodCli) Then
                HabilitarNo()
                Determinar()
                frmVenCli.btnCliV.BackColor = Color.SteelBlue
            Else
                MensajeError("Hubo un error al intentar recuperar el cliente " & txtApe.Text)
            End If
        ElseIf banbl = False Then
            MensajeError("Hay uno o mas campos vacios")
            ep.Clear()
        End If
    End Sub

    Private Sub tbsGuardar_Click(sender As Object, e As EventArgs) Handles tbsGuardar.Click

        ep.Clear()
        CampoBlanco(Me.gbCliente, ep)

        Dim Usuario As New clsCli
        Dim tabla As New DataTable
        tabla = Usuario.VerificarCombo(cmbPais.SelectedValue)

        If tabla(0)(0) = 2 Then

            'crear bandera de mod o cre
            If banbl = True Then

                ClienteDatos.CodCli = CodCli
                ClienteDatos.DNI = txtDNI.Text
                ClienteDatos.Apellido = txtApe.Text
                ClienteDatos.Nombre = txtNom.Text
                ClienteDatos.Correo = txtMail.Text
                ClienteDatos.CodPais = cmbPais.SelectedValue
                ClienteDatos.Telefono = txtTel.Text
                ClienteDatos.IdAlta = CodUsu

                If CodCli = 0 Then
                    MensajeError("Ocurrio un error al intentar guardar los cambios (ID 0)")
                Else
                    If bandera = True Then
                        If ClientesSP.InsCli(ClienteDatos) Then
                            MensajeError("Cliente grabado exitosamente.")
                            frmVenCli.btnCliV.BackColor = Color.SteelBlue
                            btnAgrCom.Visible = False
                            HabilitarNo()
                            Determinar()
                        Else
                            MensajeError("Sucedio un error al intentar grabar el Cliente.")
                        End If
                    Else

                        If ClientesSP.ModCli(ClienteDatos) Then
                            ClienteDatos.CodCli = CodCli
                            MensajeError("Registro actualizado exitosamente.")
                            frmVenCli.btnCliV.BackColor = Color.SteelBlue
                            HabilitarNo()
                            Determinar()
                        Else
                            MensajeError("Ocurrio un error al intentar guardar los cambios")
                        End If
                    End If
                    btnAgrCom.Visible = False
                End If

            ElseIf banbl = False Then
                MensajeError("Hay uno o mas campos vacios")
                ep.Clear()
            End If



        Else
            'MensajeError("Contraseña incorrecta")
            ep.SetError(cmbPais, "El país es incorrecto.")
        End If


    End Sub




    Private Sub txtBusCli_Enter(sender As Object, e As EventArgs) Handles txtBusCli.Enter
        If txtBusCli.Text = "Buscar" Then
            txtBusCli.Text = ""
            txtBusCli.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBusCli_Leave(sender As Object, e As EventArgs) Handles txtBusCli.Leave
        If String.IsNullOrWhiteSpace(txtBusCli.Text) Then
            txtBusCli.Text = "Buscar"
            txtBusCli.ForeColor = Color.Gray
            Determinar()
        End If
    End Sub

    Private Sub Cargar()

        If txtBusCli.Text.Length = 0 Or txtBusCli.ForeColor = Color.Gray Then

            Determinar()


        Else
            If rbCliAct.Checked = True Then
                Me.dgvClientes.DataSource = ClientesSP.BuscarCliente(txtBusCli.Text)
            Else
                Me.dgvClientes.DataSource = ClientesSP.BuscarClienteBaja(txtBusCli.Text)
            End If
        End If
    End Sub


    Private Sub txtBusCli_TextChanged(sender As Object, e As EventArgs) Handles txtBusCli.TextChanged

        Cargar()
    End Sub

    Private Sub txtBusCli_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBusCli.MouseClick
        If txtBusCli.Text = "Buscar" Then
            txtBusCli.Text = ""
            txtBusCli.ForeColor = Color.Black
        Else
            Cargar()
        End If

    End Sub

    Private Sub tbsSalir_Click(sender As Object, e As EventArgs) Handles tbsSalir.Click
        If frmVenCli.btnCliV.BackColor = Color.Firebrick Then
            CerrarFormularioSuperiorEnPanelConConfirmacion(frmVenCli.pnlVenCli)
        Else
            CerrarFormularioSuperiorEnPanel(frmVenCli.pnlVenCli)
        End If
        FormularioAbierto(frmVender, frmVenCli.btnVenV)
        FormularioAbierto(Me, frmVenCli.btnCliV)
    End Sub

    Private Sub BtnAgrTel_Click(sender As Object, e As EventArgs) Handles BtnAgrTel.Click
        Dim frmTelefonos As New frmTelefonos()
        AddHandler frmTelefonos.FormClosed, AddressOf frmTelefonos_FormClosed
        Me.Enabled = False ' Deshabilitar Formulario 1
        frmVenCli.Enabled = False
        frmMenu.Enabled = False
        frmPrincipal.Enabled = False
        frmTelefonos.Show()
    End Sub

    Private Sub frmTelefonos_FormClosed(sender As Object, e As FormClosedEventArgs)
        Me.Enabled = True ' Volver a habilitar Formulario 1 cuando Formulario 2 se cierre
        frmVenCli.Enabled = True
        frmMenu.Enabled = True
        frmPrincipal.Enabled = True
    End Sub

    Private Sub btnAgrCom_Click_1(sender As Object, e As EventArgs) Handles btnAgrCom.Click

    End Sub
End Class