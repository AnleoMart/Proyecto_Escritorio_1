Public Class verArticulos
    Private Sub verArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contrUser As New ControlArticulos
        contrUser.buscarArticulos(DgConsultaArticulos)
    End Sub
End Class