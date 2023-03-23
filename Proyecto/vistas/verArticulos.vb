Public Class verArticulos
    Private Sub verArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contrUser As New ControlArticulos
        contrUser.buscarArticulos(DgConsultaArticulos)
    End Sub

    Private Sub DgConsultaArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgConsultaArticulos.CellClick
        Dim codigo As Integer = DgConsultaArticulos.CurrentRow.Cells(1).Value
        Dim ConfigurarArticulo As New ConfigurarArticulo(codigo)
        ConfigurarArticulo.MdiParent = Form1
        ConfigurarArticulo.StartPosition = FormStartPosition.Manual
        ConfigurarArticulo.Left = 0
        ConfigurarArticulo.Top = 0
        ConfigurarArticulo.Show()
        Me.Hide()
    End Sub

    Private Sub btnCrearArticulo_Click(sender As Object, e As EventArgs) Handles btnCrearArticulo.Click
        Dim CrearArticulo As New CrearArticulo
        CrearArticulo.MdiParent = Form1
        CrearArticulo.StartPosition = FormStartPosition.Manual
        CrearArticulo.Left = 0
        CrearArticulo.Top = 0
        CrearArticulo.Show()
        Me.Hide()
    End Sub
End Class