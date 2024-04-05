Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescripcion.Visible = True
        Timer1.Start()
        Label2.Text = DateAndTime.Now.ToString("D")
        ClearLabel(lblDescripcion)

    End Sub
    Private Sub bVentas_Click(sender As Object, e As EventArgs) Handles bVentas.Click
        frmPrincipal.AbrirFormulario(frmVenCli)
        frmPrincipal.btnVolver.Visible = True
    End Sub





    Private Sub bServicios_Click(sender As Object, e As EventArgs) Handles bServicios.Click
        frmPrincipal.AbrirFormulario(frmTest)
        frmClientes.rbCliAct.Checked = True
        ActualizarUltimosFormularios("frmTest")
    End Sub

    Private Sub MostrarFormulariosEnLista()
        For Each nombreFormulario As String In UltimosFormularios
            MessageBox.Show(nombreFormulario)
        Next
    End Sub

    Private Sub bOperaciones_Click(sender As Object, e As EventArgs) Handles bOperaciones.Click
        MostrarFormulariosEnLista()
    End Sub

    Private Sub bPersonal_Click(sender As Object, e As EventArgs) Handles bPersonal.Click
        frmPrincipal.AbrirFormulario(frmEmpUsu)
    End Sub

    Private Sub MouseArriba(objeto As Object, mensaje As String)
        objeto.Cursor = Cursors.Hand
        lblDescripcion.Text = mensaje
    End Sub

    Private Sub bVentas_MouseHover(sender As Object, e As EventArgs) Handles bVentas.MouseHover
        MouseArriba(sender, "Ventas")
    End Sub

    Private Sub bServicios_MouseHover(sender As Object, e As EventArgs) Handles bServicios.MouseHover
        MouseArriba(sender, "Servicios")
    End Sub

    Private Sub bOperaciones_MouseHover(sender As Object, e As EventArgs) Handles bOperaciones.MouseHover
        MouseArriba(sender, "Operaciones")
    End Sub

    Private Sub bPersonal_MouseHover(sender As Object, e As EventArgs) Handles bPersonal.MouseHover
        MouseArriba(sender, "Usuarios")
    End Sub

    Private Sub bVentas_MouseLeave(sender As Object, e As EventArgs) Handles bVentas.MouseLeave
        ClearLabel(lblDescripcion)
    End Sub

    Private Sub bServicios_MouseLeave(sender As Object, e As EventArgs) Handles bServicios.MouseLeave
        ClearLabel(lblDescripcion)
    End Sub

    Private Sub bOperaciones_MouseLeave(sender As Object, e As EventArgs) Handles bOperaciones.MouseLeave
        ClearLabel(lblDescripcion)
    End Sub

    Private Sub bPersonal_MouseLeave(sender As Object, e As EventArgs) Handles bPersonal.MouseLeave
        ClearLabel(lblDescripcion)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = DateAndTime.Now.ToString("HH:mm")

    End Sub

    Private Sub frmMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        frmPrincipal.pnlMnuDesp.Visible = False
    End Sub

    Private Sub lblDescripcion_Click(sender As Object, e As EventArgs) Handles lblDescripcion.Click

    End Sub
End Class