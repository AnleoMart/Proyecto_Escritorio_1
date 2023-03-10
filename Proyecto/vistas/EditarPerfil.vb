Public Class EditarPerfil
    Private controllerUser As New ControladorUsuario

    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        calendar.MaxDate = DateTime.Now

    End Sub
End Class