Public Class frmMenu
    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDescripcion.Visible = True
        ClearLabel(lblDescripcion)
    End Sub
    Private Sub bVentas_Click(sender As Object, e As EventArgs) Handles bVentas.Click
        frmPrincipal.AbrirFormulario(frmVenCli)
    End Sub

    Private Sub bServicios_Click(sender As Object, e As EventArgs) Handles bServicios.Click
        'frmPrincipal.AbrirFormulario(frmServicios)
    End Sub

    Private Sub bOperaciones_Click(sender As Object, e As EventArgs) Handles bOperaciones.Click
        'frmPrincipal.AbrirFormulario(frmOperaciones)
    End Sub

    Private Sub bPersonal_Click(sender As Object, e As EventArgs) Handles bPersonal.Click
        frmPrincipal.AbrirFormulario(frmEmpUsu)
    End Sub

    Private Sub MouseArriba(objeto As Object, mensaje As String)
        objeto.Cursor = Cursors.Hand
        lblDescripcion.Text = mensaje
    End Sub

    Private Sub bVentas_MouseHover(sender As Object, e As EventArgs) Handles bVentas.MouseHover
        MouseArriba(sender, "Permite la administración de las ventas y clientes.")
    End Sub

    Private Sub bServicios_MouseHover(sender As Object, e As EventArgs) Handles bServicios.MouseHover
        MouseArriba(sender, "Permite la administración de los servicios y proveedores.")
    End Sub

    Private Sub bOperaciones_MouseHover(sender As Object, e As EventArgs) Handles bOperaciones.MouseHover
        MouseArriba(sender, "Permite la administración de las operaciones, choferes y vehiculos.")
    End Sub

    Private Sub bPersonal_MouseHover(sender As Object, e As EventArgs) Handles bPersonal.MouseHover
        MouseArriba(sender, "Permite la administración de los usuarios y empleados.")
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


End Class