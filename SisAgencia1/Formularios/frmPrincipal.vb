Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Public Class frmPrincipal


#Region "Botones"
    Private Sub tsmiSalir_Click(sender As Object, e As EventArgs) Handles tsmiSalir.Click
        Me.Close()
    End Sub

    Private Sub tsmiCerrar_Click(sender As Object, e As EventArgs) Handles tsmiCerrar.Click
        CerrarSesion()
    End Sub

    Private Sub tsmiInicio_Click(sender As Object, e As EventArgs) Handles tsmiInicio.Click
        AbrirFormulario(frmLogin)
    End Sub


#End Region
#Region "Eventos"

    'SOMBRA














    '' Constante para la sombra
    'Private Const CS_DROPSHADOW As Integer = &H20000

    '' Importar funciones nativas de Windows
    '<DllImport("user32.dll", SetLastError:=True)>
    'Private Shared Function GetDesktopWindow() As IntPtr
    'End Function

    '<DllImport("user32.dll")>
    'Private Shared Function SetWindowLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    'End Function

    '<DllImport("user32.dll")>
    'Private Shared Function GetClassLong(hWnd As IntPtr, nIndex As Integer) As Integer
    'End Function

    '<DllImport("user32.dll")>
    'Private Shared Function SetClassLong(hWnd As IntPtr, nIndex As Integer, dwNewLong As Integer) As Integer
    'End Function

    'Public Sub New()
    '    InitializeComponent()
    'End Sub









    'SOMBRA FIN


    Dim FrmClientes As New frmClientes
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        CentrarForm(Me)
        WindowState = FormWindowState.Maximized
        bMax = True
        Me.btnMiniMax.Image = My.Resources.icons8_comprimir_25
        ' AddHandler Me.Resize, AddressOf frmPrincipal_Resize

        FormBorderStyle = FormBorderStyle.None

        ' Agrega la sombra
        ''SetWindowLong(Handle, -8, CInt(GetDesktopWindow()))
        ''SetClassLong(Handle, -26, GetClassLong(Handle, -26) Or CS_DROPSHADOW)
    End Sub

    Public Sub CerrarSesion()
        Me.Text = "A"
        Me.tsslNomUsu.Text = ""
        Me.tsslNomUsu.Visible = False





        Dim formulariosACerrar As Form() = {Me, frmMenu, frmVenCli, frmClientes, frmVender}
        CerrarFormularios(formulariosACerrar)


    End Sub

    Public Sub AbrirFormulario(f As Form)
        'Limpio los controles existentes en el panel
        pnlPpal.Controls.Clear()
        'Establezco la propiedad toplevel del formualrio en falso para poder agregar un formulario dentro de otro
        f.TopLevel = False
        'Quito los bordes del formulario a abrir dentro del panel
        f.FormBorderStyle = FormBorderStyle.None
        'Agrego el control al panel
        pnlPpal.Controls.Add(f)
        'Muestro el formulario en pantalla
        f.Show()
        f.Dock = DockStyle.Fill
    End Sub

    Private Sub frmPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' Verifica si ya hay una instancia del formulario de inicio de sesión abierta
        Dim loginForm As frmLogin = frmLogin.ObtenerInstancia()


        If loginForm Is Nothing OrElse Not loginForm.Visible Then
            ' Crea una nueva instancia del formulario de inicio de sesión
            loginForm = New frmLogin()
            ' Muestra el formulario de inicio de sesión
            loginForm.Show()
        End If
    End Sub



    Private Sub LoginFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Termina la aplicación cuando se cierre el formulario de inicio de sesión.
        Application.Exit()
    End Sub

    Private Sub btnMnuDesp_Click(sender As Object, e As EventArgs) Handles btnMnuDesp.Click
        If pnlMnuDesp.Visible = True Then
            pnlMnuDesp.Visible = False
        Else
            pnlMnuDesp.Visible = True
        End If

    End Sub

    Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
        If pnlArchivo.Visible = True Then
            pnlArchivo.Visible = False
        Else
            pnlArchivo.Visible = True
        End If
    End Sub





    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
        If respuesta = DialogResult.Yes Then
            Me.Close()

        End If

    End Sub
    Public bMax As Boolean = False
    Private Sub btnMiniMax_Click(sender As Object, e As EventArgs) Handles btnMiniMax.Click

        If bMax = False Then



            WindowState = FormWindowState.Maximized
            bMax = True
            Me.btnMiniMax.Image = My.Resources.icons8_comprimir_25
            frmVenCli.Mini()





        Else


            bMax = False
            Me.btnMiniMax.Image = My.Resources.icons8_agrandar_25
            WindowState = FormWindowState.Normal
            FrmClientes.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End If

    End Sub

    Private Sub btnMini_Click(sender As Object, e As EventArgs) Handles btnMini.Click
        WindowState = FormWindowState.Minimized
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function ReleaseCapture() As Boolean

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2

    Private Sub pnlMnuTool_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuTool.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If

        pnlMnuDesp.Visible = False
    End Sub

    Private Sub pnlPpal_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlPpal.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
        pnlMnuDesp.Visible = False
    End Sub

    Private Sub pnlMnuDesp_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlMnuDesp.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    'Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnSalirLog.Click

    '    Dim respuesta = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

    '    ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
    '    If respuesta = DialogResult.Yes Then
    '        CerrarSesion()

    '    End If


    'End Sub

    Private Sub btnHerr_Click(sender As Object, e As EventArgs) Handles btnHerr.Click
        If pnlHerr.Visible = True Then
            pnlHerr.Visible = False
        Else
            pnlHerr.Visible = True
        End If
    End Sub

    Private Sub btnDatos_Click(sender As Object, e As EventArgs) Handles btnDatos.Click
        If pnlDatos.Visible = True Then
            pnlDatos.Visible = False
        Else
            pnlDatos.Visible = True
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
        If respuesta = DialogResult.Yes Then
            Close()

        End If
    End Sub


    Public Sub CerrarForms()
        Dim formulariosACerrar As Form() = {frmVenCli, frmBase, frmVender, frmEmpUsu, frmEmp}
        CerrarFormularios(formulariosACerrar)


        AbrirFormPanel(frmMenu, pnlPpal)

        pnlMnuDesp.Visible = False
        btnVolver.Visible = False
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        If Application.OpenForms.OfType(Of frmBase)().Any() Then

            If frmVenCli.btnCliV.BackColor = Color.FromArgb(60, 113, 155) Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar el formulario clientes?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
                If respuesta = DialogResult.Yes Then
                    CerrarForms()

                End If
            Else
                CerrarForms()
            End If
        ElseIf Application.OpenForms.OfType(Of frmVenCli)().Any() Then
            CerrarForms()


        ElseIf Application.OpenForms.OfType(Of frmEmpUsu)().Any() Then
            CerrarForms()
            If Application.OpenForms.OfType(Of frmEmp)().Any() Then

                If frmEmpUsu.btnEmp.BackColor = Color.FromArgb(60, 113, 155) Then
                    Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar el formulario empleados?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
                    If respuesta = DialogResult.Yes Then
                        CerrarForms()

                    End If
                Else
                    CerrarForms()
                End If
            End If
        End If

        frmEmpUsu.btnEmp.BackColor = Color.SteelBlue
        frmVenCli.btnCliV.BackColor = Color.SteelBlue
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click




        If Application.OpenForms.OfType(Of frmBase)().Any() Then

            If frmVenCli.btnCliV.BackColor = Color.FromArgb(60, 113, 155) Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar el formulario " & frmBase.Text & "?
                ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
                If respuesta = DialogResult.Yes Then
                    frmBase.Close()
                    btnVolver.Visible = True
                    pnlMnuDesp.Visible = False

                End If
            Else
                frmBase.Close()
                btnVolver.Visible = True
                pnlMnuDesp.Visible = False
            End If
        ElseIf Application.OpenForms.OfType(Of frmVenCli)().Any() Then

        Else
            AbrirFormPanel(frmVenCli, pnlPpal)
            btnVolver.Visible = True
        End If
    End Sub

    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Normal Then
            bMax = False
            btnMiniMax.Image = My.Resources.icons8_agrandar_25
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            bMax = True
            btnMiniMax.Image = My.Resources.icons8_comprimir_25
        End If
    End Sub

    Private Sub tsslNomUsu_MouseDown(sender As Object, e As MouseEventArgs) Handles tsslNomUsu.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
        pnlMnuDesp.Visible = False
    End Sub

    Private Sub frmPrincipal_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If Not pnlMnuDesp.ClientRectangle.Contains(pnlMnuDesp.PointToClient(Cursor.Position)) Then
            ' Oculta el panel
            pnlMnuDesp.Visible = False
        End If
    End Sub

    Private Sub pnlMnuDesp_ControlClicked(sender As Object, e As EventArgs)
        ' Verifica si el control clickeado no es el panel1 ni el botón para abrir el panel
        If Not TypeOf ActiveControl Is Panel AndAlso ActiveControl IsNot btnMnuDesp Then
            ' Oculta el panel
            pnlMnuDesp.Visible = False
        End If
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        pnlMnuDesp.Visible = False
    End Sub

    Private Sub btnOperaciones_Click(sender As Object, e As EventArgs) Handles btnOperaciones.Click
        pnlMnuDesp.Visible = False
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        pnlMnuDesp.Visible = False
        If Application.OpenForms.OfType(Of frmEmp)().Any() Then

            If frmEmpUsu.btnEmp.BackColor = Color.FromArgb(60, 113, 155) Then
                Dim respuesta As DialogResult = MessageBox.Show("¿Estás seguro de que deseas cerrar el formulario " & frmEmp.Text & "?
                ", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Si el usuario confirma que quiere cerrar el formulario, cerrarlo
                If respuesta = DialogResult.Yes Then
                    frmEmp.Close()
                    btnVolver.Visible = True
                    pnlMnuDesp.Visible = False

                End If
            Else
                frmEmp.Close()
                btnVolver.Visible = True
                pnlMnuDesp.Visible = False
            End If
        ElseIf Application.OpenForms.OfType(Of frmEmpUsu)().Any() Then

        Else
            AbrirFormPanel(frmEmpUsu, pnlPpal)
            btnVolver.Visible = True
        End If
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        pnlMnuDesp.Visible = False
    End Sub

    Private Sub btnAyuda_Click(sender As Object, e As EventArgs) Handles btnAyuda.Click
        pnlMnuDesp.Visible = False
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If Application.OpenForms.OfType(Of frmBase)().Any() Then

            If frmVenCli.btnCliV.BackColor = Color.FromArgb(60, 113, 155) Then
                CerrarFormularioSuperiorEnPanelConConfirmacion(frmVenCli.pnlVenCli)
            Else
                CerrarFormularioSuperiorEnPanel(frmVenCli.pnlVenCli)
            End If
        ElseIf Application.OpenForms.OfType(Of frmVenCli)().Any() Then
            CerrarForms()


        ElseIf Application.OpenForms.OfType(Of frmEmp)().Any() Then

            If frmEmpUsu.btnEmp.BackColor = Color.FromArgb(60, 113, 155) Then
                CerrarFormularioSuperiorEnPanelConConfirmacion(frmEmpUsu.pnlEmpUsu)
            Else
                CerrarFormularioSuperiorEnPanel(frmEmpUsu.pnlEmpUsu)
            End If
        ElseIf Application.OpenForms.OfType(Of frmEmpUsu)().Any() Then
            CerrarForms()

        End If
        frmEmpUsu.btnEmp.BackColor = Color.SteelBlue
        frmVenCli.btnCliV.BackColor = Color.SteelBlue

    End Sub











#End Region

End Class




