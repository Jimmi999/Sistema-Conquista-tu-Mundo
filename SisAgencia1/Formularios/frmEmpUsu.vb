Public Class frmEmpUsu

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
        frmPrincipal.AbrirFormulario(frmMenu)
    End Sub

    Private Sub BtnEmplea_Click(sender As Object, e As EventArgs) Handles BtnEmplea.Click
        frmPrincipal.AbrirFormulario(frmEmp)
    End Sub
End Class