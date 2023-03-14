Public Class EditarPerfil
    Private controllerUser As New ControladorUsuario
    Private usu As Usuario
    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendar.MaxDate = DateTime.Now
        'Dim contUsuario As New ControladorUsuario
        usu = controllerUser.cargarDatos(Form1.idUuario)
        txtCedula.Text = usu.Id.ToString()
        txtNombre.Text = usu.Nombre
        txtApellido.Text = usu.Apellido
        txtCorreo.Text = usu.Correo
        txtTelefono.Text = usu.Telefono
        calendar.SelectionStart = usu.FechaNacimiento
        calendar.SetSelectionRange(calendar.SelectionStart, calendar.SelectionStart)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If valCampos() Then
            'If  Then
        End If
    End Sub
    Public Function valCampos() As Boolean
        If txtApellido.Text <> "" And txtCedula.Text <> "" And txtContrasena2.Text <> "" And txtContraseña.Text <> "" And txtCorreo.Text <> "" And txtNombre.Text <> "" And txtTelefono.Text <> "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class