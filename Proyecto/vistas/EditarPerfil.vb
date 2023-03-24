Imports System.ComponentModel

Public Class EditarPerfil
    Private validacion As New Validaciones
    Private controllerUser As New ControladorUsuario
    Private usu As Usuario
    Private id As String
    Private doc, nom, apell, email, tel, pass As Boolean
    Public Sub New(id As Integer)
        InitializeComponent()
        Me.id = id
    End Sub
    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendar.MaxDate = DateTime.Now
        'Dim contUsuario As New ControladorUsuario
        usu = controllerUser.cargarDatos(id)
        Console.WriteLine(usu.Id.ToString())
        txtCedula.Text = usu.Id.ToString()
        txtNombre.Text = usu.Nombre
        txtApellido.Text = usu.Apellido
        txtCorreo.Text = usu.Correo
        txtTelefono.Text = usu.Telefono
        calendar.SelectionStart = usu.FechaNacimiento
        calendar.SetSelectionRange(calendar.SelectionStart, calendar.SelectionStart)

        nom = True
        apell = True
        tel = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If valCampos() Then
            If txtContraseña.Text = txtContraseña.Text Then
                If (controllerUser.modificarUsuario(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, txtContraseña.Text, calendar.SelectionStart)) Then
                    MsgBox("Se han modificado los valores exitosamente", vbInformation, "modificacion exitosa")
                Else
                    MsgBox("Ha ocurrido un error, no se ha podido completar la modificacion", vbCritical, "Error")
                End If
            End If
        ElseIf txtContraseña.Text <> "" And txtContraseña.Text <> "" Then
            If txtContraseña.Text = txtContraseña.Text Then
                If pass Then
                    If controllerUser.modificarUsuario(txtCorreo.Text, txtContraseña.Text) Then
                        MsgBox("Se han modificado los valores exitosamente", vbInformation, "modificacion exitosa")
                    Else
                        MsgBox("Ha ocurrido un error, no se ha podido completar la modificacion", vbCritical, "Error")
                    End If
                Else
                    MsgBox("lass cosnstraseñas no estan diligenciadas correctamente", vbCritical, "Error")
                End If
            End If
        ElseIf txtContraseña.Text = "" And txtContraseña.Text = "" Then
            If nom And apell And tel Then
                If controllerUser.modificarUsuario(txtCedula.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtTelefono.Text, calendar.SelectionStart) Then
                    MsgBox("Se han modificado los valores exitosamente", vbInformation, "modificacion exitosa")
                Else
                    MsgBox("Ha ocurrido un error, no se ha podido completar la modificacion", vbCritical, "Error")
                End If
            Else
                MsgBox("Uno o mas campos no esta diligenciados correctamente", vbCritical, "Error")
            End If
        End If
    End Sub
    Public Function valCampos() As Boolean
        If txtApellido.Text <> "" And txtCedula.Text <> "" And txtContrasena2.Text <> "" And txtContraseña.Text <> "" And txtCorreo.Text <> "" And txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            If nom And apell And tel And pass Then
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pregunta As String = MsgBox("seguro desea eliminar esta cuenta?", vbYesNo + vbQuestion, "Eliminar cuenta")
        If pregunta = vbYes Then
            If controllerUser.modificarEstado(txtCedula.Text) And txtCedula.Text = Form1.idUuario Then
                Dim Inicio_sesion As New Inicio_sesion
                Inicio_sesion.MdiParent = Form1
                Inicio_sesion.StartPosition = FormStartPosition.Manual
                Inicio_sesion.Left = 0
                Inicio_sesion.Top = 0
                Inicio_sesion.Show()
                Me.Hide()
            Else
                Dim BuscarUsuarios As New BuscarUsuarios
                BuscarUsuarios.MdiParent = Form1
                BuscarUsuarios.StartPosition = FormStartPosition.Manual
                BuscarUsuarios.Left = 0
                BuscarUsuarios.Top = 0
                BuscarUsuarios.Show()
                Me.Hide()
            End If
        End If

    End Sub



    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text <> "" Then
            If validacion.rxNombre(txtNombre.Text) Then
                lblMsgNombre.ForeColor = Color.Green
                lblMsgNombre.Text = "aceptado"
                lblMsgNombre.Visible = True
                nom = True
            Else
                lblMsgNombre.ForeColor = Color.Red
                lblMsgNombre.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgNombre.Visible = True
                nom = False
            End If
        Else
            lblMsgNombre.Visible = False
            nom = False
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If txtApellido.Text <> "" Then
            If validacion.rxNombre(txtApellido.Text) Then
                lblMsgApellidos.ForeColor = Color.Green
                lblMsgApellidos.Text = "aceptado"
                lblMsgApellidos.Visible = True
                apell = True
            Else
                lblMsgApellidos.ForeColor = Color.Red
                lblMsgApellidos.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgApellidos.Visible = True
                apell = False
            End If
        Else
            lblMsgApellidos.Visible = False
            apell = False
        End If
    End Sub



    Private Sub txtTelefono_Validating(sender As Object, e As CancelEventArgs) Handles txtTelefono.Validating
        If txtTelefono.Text <> "" Then
            If validacion.rxTelefono(txtTelefono.Text) Then
                lblTelefono.ForeColor = Color.Green
                lblTelefono.Text = "aceptado"
                lblTelefono.Visible = True
                nom = True
            Else
                lblTelefono.ForeColor = Color.Red
                lblTelefono.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblTelefono.Visible = True
                nom = False
            End If
        Else
            lblTelefono.Visible = False
            nom = False
        End If
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtContraseña.Validating
        If txtContraseña.Text <> "" Then
            If validacion.rxContraseña(txtContraseña.Text) Then
                lblMsgpass1.ForeColor = Color.Green
                lblMsgpass1.Text = "aceptado"
                lblMsgpass1.Visible = True

            Else
                lblMsgpass1.ForeColor = Color.Red
                lblMsgpass1.Text = "max 20 caracteres sin espacios en blanco"
                lblMsgpass1.Visible = True

            End If
        Else
            lblMsgpass1.Visible = False
        End If
    End Sub

    Private Sub txtContrasena2_Validating(sender As Object, e As CancelEventArgs) Handles txtContrasena2.Validating
        If txtContrasena2.Text <> "" Then
            If validacion.rxContraseña(txtContrasena2.Text) Then
                If txtContrasena2.Text <> txtContraseña.Text Then
                    pass2.ForeColor = Color.Orange
                    pass2.Text = "las contraseñas no coinciden"
                    pass2.Visible = True
                    pass = False
                Else
                    pass2.ForeColor = Color.Green
                    pass2.Text = "aceptado"
                    pass2.Visible = True
                    pass = True
                End If
            Else
                pass2.ForeColor = Color.Red
                pass2.Text = "max 20 caracteres sin espacios en blanco"
                pass2.Visible = True
                pass = False
            End If
        Else
            pass2.Visible = False
            pass = False
        End If
    End Sub

End Class