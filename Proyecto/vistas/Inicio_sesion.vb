Imports System.ComponentModel

Public Class Inicio_sesion
    Private email, pass As Boolean
    Private validacion As New Validaciones
    Private Sub olvidoContraseña_Click(sender As Object, e As EventArgs) Handles olvidoContraseña.Click
        Dim RecuperarContrasena As New RecuperarContrasena
        RecuperarContrasena.MdiParent = Form1
        RecuperarContrasena.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        RecuperarContrasena.Left = 0
        RecuperarContrasena.Top = 0
        RecuperarContrasena.Show()
        Me.Hide()
    End Sub
    Public Sub iniciarSesion()
        Dim controllerUser As New ControladorUsuario

        Dim correo, contrasena As String
        correo = txtCorreo.Text
        contrasena = txtContrasena.Text
        If email And pass Then
            If controllerUser.login(correo, contrasena) Then
                ocularMostrarBotones()
                Dim verArticulos As New verArticulos
                verArticulos.MdiParent = Form1
                verArticulos.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
                verArticulos.Left = 0
                verArticulos.Top = 0
                verArticulos.Show()
                Me.Hide()
            Else
                MsgBox("Ha introducido usuario o contraseña erroneamente, por favor vuelva a intetntarlo", vbCritical, "Error")

            End If
        End If
    End Sub
    Private Sub EntrarReg_Click(sender As Object, e As EventArgs) Handles EntrarReg.Click

        iniciarSesion()

    End Sub
    Public Sub ocularMostrarBotones()
        If Form1.btnInicioSesion.Visible = False Then
            Form1.btnInicioSesion.Visible = True
            Form1.PanelIniciarSesion.Visible = True

            Form1.btnCerrarSesion.Visible = False
            Form1.PanelCS.Visible = False

            Form1.BtnCrearPerfil.Visible = True
            Form1.PanelCP.Visible = True

            Form1.btnPerfil.Visible = False
            Form1.Panelperfil.Visible = False

            Form1.btnUsuario.Visible = False
            Form1.PanelUsuario.Visible = False


            Form1.btnDistribuidor.Visible = False
            Form1.PanelDitribuidor.Visible = False


            Form1.btnArticulo.Visible = False
            Form1.Panelarticulo.Visible = False

        Else
            Form1.btnInicioSesion.Visible = False
            Form1.PanelIniciarSesion.Visible = False

            Form1.btnCerrarSesion.Visible = True
            Form1.PanelCS.Visible = True

            Form1.BtnCrearPerfil.Visible = False
            Form1.PanelCP.Visible = False

            Form1.btnPerfil.Visible = True
            Form1.Panelperfil.Visible = True

            Form1.btnUsuario.Visible = True
            Form1.PanelUsuario.Visible = True

            Form1.btnDistribuidor.Visible = True
            Form1.PanelDitribuidor.Visible = True

            Form1.btnArticulo.Visible = True
            Form1.Panelarticulo.Visible = True
        End If

    End Sub
    'Public Sub navegacion(destino As String)
    '   Console.WriteLine("destino ---- " & destino)
    'Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = destino).SingleOrDefault()
    'If fr Is Nothing Then
    '
    'Dim RecuperarContrasena As New RecuperarContrasena
    '       RecuperarContrasena.MdiParent = Form1
    '      RecuperarContrasena.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
    '     RecuperarContrasena.Left = 0
    '    RecuperarContrasena.Top = 0
    '   RecuperarContrasena.Show()
    'Me.Hide()
    'End If
    'End Sub



    Private Sub Inicio_sesion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            valEmail()
            valPass()
            iniciarSesion()
        End If
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            valEmail()
            valPass()
            iniciarSesion()
        End If
    End Sub

    Private Sub txtContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasena.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            valEmail()
            valPass()
            iniciarSesion()
        End If
    End Sub

    Private Sub valEmail()
        If txtCorreo.Text <> "" Then
            Console.Write("corro")
            If validacion.rxCorreo(txtCorreo.Text) Then

                lblMsgCorreo.ForeColor = Color.Green
                lblMsgCorreo.Text = "aceptado"
                lblMsgCorreo.Visible = True
                email = True
            Else
                lblMsgCorreo.ForeColor = Color.Red
                lblMsgCorreo.Text = "Correo no aceptado, por favor verificar"
                lblMsgCorreo.Visible = True
                email = False
            End If
        Else
            lblMsgCorreo.Visible = False
            email = False
        End If
    End Sub
    Private Sub valPass()
        If txtContrasena.Text <> "" Then
            Console.Write("pass")
            If validacion.rxContraseña(txtContrasena.Text) Then
                lblMsgContraseña.ForeColor = Color.Green
                lblMsgContraseña.Text = "aceptado"
                lblMsgContraseña.Visible = True
                pass = True
            Else
                lblMsgContraseña.ForeColor = Color.Red
                lblMsgContraseña.Text = "Correo no aceptado, por favor verificar"
                lblMsgContraseña.Visible = True
                pass = False
            End If
        Else
            lblMsgContraseña.Visible = False
            pass = False
        End If
    End Sub
    Private Sub txtContrasena_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena.Validating
        valPass()
    End Sub

    Private Sub txtCorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtCorreo.Validating

        valEmail()
    End Sub
End Class