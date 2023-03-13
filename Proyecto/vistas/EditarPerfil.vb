Public Class EditarPerfil
    Private controllerUser As New ControladorUsuario

    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendar.MaxDate = DateTime.Now
        Dim contUsuario As New ControladorUsuario
        Dim usu As Usuario = contUsuario.cargarDatos(Form1.idUuario)
        txtCedula.Text = usu.Id.ToString()
        txtNombre.Text = usu.Nombre
        txtApellido.Text = usu.Apellido
        txtCorreo.Text = usu.Correo
        txtTelefono.Text = usu.Telefono
        calendar.SelectionStart = usu.FechaNacimiento
        calendar.SetSelectionRange(calendar.SelectionStart, calendar.SelectionStart)

    End Sub
End Class