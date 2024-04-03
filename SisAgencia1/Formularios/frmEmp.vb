Public Class frmEmp
    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Me.Close()
        frmPrincipal.AbrirFormulario(frmMenu)

    End Sub
End Class