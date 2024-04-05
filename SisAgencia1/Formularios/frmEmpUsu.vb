Public Class frmEmpUsu







    Private Sub btnUsu_Click(sender As Object, e As EventArgs) Handles btnUsu.Click
        'AbrirFormPanel(frmUsuarios, pnlEmpUsu)
        ActualizarUltimosFormularios("frmUsuarios")
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        AbrirFormPanel(frmEmp, pnlEmpUsu)
        ActualizarUltimosFormularios("frmEmpleados")
    End Sub
End Class