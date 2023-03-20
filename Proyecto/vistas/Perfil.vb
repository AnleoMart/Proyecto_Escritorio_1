Public Class Perfil
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim EditarPerfil As New EditarPerfil(Form1.idUuario)
        EditarPerfil.MdiParent = Form1
        EditarPerfil.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        EditarPerfil.Left = 0
        EditarPerfil.Top = 0
        EditarPerfil.Show()
        Me.Hide()
    End Sub

    Private Sub usuarioPerfil_Click(sender As Object, e As EventArgs) Handles usuarioPerfil.Click

    End Sub

    Private Sub Perfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim contUsuario As New ControladorDistribuidor
        Dim usu As Usuario = contUsuario.cargarDatos(Form1.idUuario)
        'Console.WriteLine("--------- nombre" & Form1.idUuario)
        'Console.WriteLine("--------- nombre" & usu.Nombre)
        'Console.WriteLine("--------- Apellido" & usu.Apellido)
        'Console.WriteLine("--------- Correo" & usu.Correo)
        'Console.WriteLine("--------- Telefono" & usu.Telefono)
        txtNombre.Text = usu.Nombre
        txtApellido.Text = usu.Apellido
        txtEmail.Text = usu.Correo
        txtTelefono.Text = usu.Telefono
    End Sub
End Class