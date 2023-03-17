Public Class BuscarUsuarios
    Private Sub BuscarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contrUser As New ControladorUsuario
        contrUser.buscarUsuario(DgConsultaUsuarios)
    End Sub
End Class