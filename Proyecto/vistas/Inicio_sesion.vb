Public Class Inicio_sesion
    Private Sub olvidoContraseña_Click(sender As Object, e As EventArgs) Handles olvidoContraseña.Click
        'Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = "Registro").SingleOrDefault()
        'If fr Is Nothing Then

        Dim RecuperarContrasena As New RecuperarContrasena
        RecuperarContrasena.MdiParent = Form1
        RecuperarContrasena.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        RecuperarContrasena.Left = 0
        RecuperarContrasena.Top = 0
        RecuperarContrasena.Show()
        Me.Hide()
        'End If


    End Sub
    Public Function iniciarSesion()
        Dim controllerUser As New ControladorUsuario

        Dim correo, contrasena As String
        correo = txtCorreo.Text
        contrasena = txtContrasena.Text
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
    End Function
    Private Sub EntrarReg_Click(sender As Object, e As EventArgs) Handles EntrarReg.Click
        iniciarSesion()

    End Sub
    Public Sub ocularMostrarBotones()
        If Form1.btnInicioSesion.Visible = False Then
            Form1.btnInicioSesion.Visible = True
            Form1.btnCerrarSesion.Visible = False
            Form1.BtnCrearPerfil.Visible = True

            Form1.btnPerfil.Visible = False
        Else
            Form1.btnInicioSesion.Visible = False
            Form1.btnCerrarSesion.Visible = True
            Form1.BtnCrearPerfil.Visible = False

            Form1.btnPerfil.Visible = True
        End If

    End Sub
    Public Sub navegacion(destino As String)
        Console.WriteLine("destino ---- " & destino)
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = destino).SingleOrDefault()
        If fr Is Nothing Then

            Dim RecuperarContrasena As New RecuperarContrasena
            RecuperarContrasena.MdiParent = Form1
            RecuperarContrasena.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
            RecuperarContrasena.Left = 0
            RecuperarContrasena.Top = 0
            RecuperarContrasena.Show()
            Me.Hide()
        End If
    End Sub



    Private Sub Inicio_sesion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            iniciarSesion()
        End If
    End Sub

    Private Sub txtCorreo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorreo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            iniciarSesion()
        End If
    End Sub

    Private Sub txtContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContrasena.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            iniciarSesion()
        End If
    End Sub
End Class