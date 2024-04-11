Imports System.Reflection.Emit
Imports System.Runtime.InteropServices

Public Class frmAgrUsu

#Region "Variables"


    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    Private Const WM_MOUSEACTIVATE As Integer = &H21
    Private Const WM_NCACTIVATE As Integer = &H86


#End Region
#Region "Funciones"
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        If m.Msg = WM_MOUSEACTIVATE OrElse m.Msg = WM_NCACTIVATE Then
            Dim clickedOutside As Boolean = Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))
            If clickedOutside Then
                ' Coloca aquí el código que deseas ejecutar cuando se hace clic fuera del formulario
                If pnlMnuTool.BackColor = Color.SteelBlue Then
                    pnlMnuTool.BackColor = Color.FromArgb(60, 113, 155)
                    btnMnuDesp.BackColor = Color.FromArgb(60, 113, 155)

                    btnMini.BackColor = Color.FromArgb(60, 113, 155)
                    btnExit.BackColor = Color.FromArgb(60, 113, 155)
                Else
                    pnlMnuTool.BackColor = Color.SteelBlue
                    btnMnuDesp.BackColor = Color.SteelBlue

                    btnMini.BackColor = Color.SteelBlue
                    btnExit.BackColor = Color.SteelBlue
                End If
            End If
        End If
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function
    Private Sub Inicio()
        Label1.Image = My.Resources.icons8_empleadoazul_25
        Label1.Font = New Font("Microsoft Sans Serif", 12)
        Label1.Text = "       " & ApeEmpCreUsu & " " & NomEmpCreUsu
        ckbMostrar.Checked = False
    End Sub
    Private Sub VerificarNombreSize()
        If Label1.Text IsNot Nothing Then
            If Label1.Text.Length <= 33 Then
            Else
                If Label1.Text.Length > 33 AndAlso Label1.Text.Length <= 39 Then
                    Label1.Font = New Font("Microsoft Sans Serif", 10)
                    Label1.Image = My.Resources.icons8_empleado_20


                ElseIf Label1.Text.Length > 39 Then



                    Label1.Image = My.Resources.icons8_empleadoazul_25
                    Label1.Font = New Font("Microsoft Sans Serif", 12)
                    Label1.Text = "       " & ApeEmpCreUsu

                    If Label1.Text.Length <= 33 Then
                    Else
                        If Label1.Text.Length > 33 AndAlso Label1.Text.Length <= 39 Then
                            Label1.Font = New Font("Microsoft Sans Serif", 10)
                            Label1.Image = My.Resources.icons8_empleado_20
                        ElseIf Label1.Text.Length > 39 Then
                            Label1.Font = New Font("Microsoft Sans Serif", 12)
                            Label1.Image = My.Resources.icons8_barato_2_60
                            Label1.Text = ApeEmpCreUsu

                            If Label1.Text.Length <= 33 Then
                                Label1.Font = New Font("Microsoft Sans Serif", 11)
                            Else
                                If Label1.Text.Length > 33 AndAlso Label1.Text.Length <= 39 Then
                                    Label1.Font = New Font("Microsoft Sans Serif", 9)
                                    Label1.Image = My.Resources.icons8_barato_2_60
                                ElseIf Label1.Text.Length > 39 AndAlso Label1.Text.Length <= 47 Then
                                    Label1.Font = New Font("Microsoft Sans Serif", 8)
                                    Label1.Image = My.Resources.icons8_barato_2_60
                                Else
                                    Label1.Text = "      Ingrese los datos:"
                                    Label1.Image = My.Resources.icons8_empleadoazul_25
                                End If
                            End If

                        End If
                    End If

                End If

            End If
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmAgrUsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CentrarForm(Me)
        Inicio()
        VerificarNombreSize()

    End Sub

    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnMnuDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnMnuDesp.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub frmAgrUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        pnlMnuTool.BackColor = Color.SteelBlue
        btnMnuDesp.BackColor = Color.SteelBlue

        btnMini.BackColor = Color.SteelBlue
        btnExit.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ckbMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbMostrar.CheckedChanged
        If ckbMostrar.Checked = True Then
            txtCon.PasswordChar = ""
            txtReCon.PasswordChar = ""
        Else
            txtReCon.PasswordChar = "*"
            txtCon.PasswordChar = "*"
        End If
    End Sub


#End Region

End Class