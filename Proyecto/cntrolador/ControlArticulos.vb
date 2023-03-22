Public Class ControlArticulos
    Private articulo As Articulo
    Public Sub buscarArticulos(data As Object)
        Dim usu = New Usuario()
        usu.buscarUsuarios(data)

    End Sub

    Public Function crearArticulo(codigo As String, nombre As String, area As String, cantidad As String, descripcion As String, idUser As Integer, nitProv As String, fechaVencimiento As Date) As Boolean
        Dim cod As Integer = convertInt(codigo)
        Dim cant As Integer = convertInt(cantidad)
        Dim nit As Integer = convertInt(nitProv)
        articulo = New Articulo(cod, nombre, area, cant, descripcion, idUser, nit, fechaVencimiento)
        articulo.nuevoArticulo()
    End Function
    Public Function convertInt(dato As String) As Integer
        Dim valor As Integer
        valor = CInt(dato)
        Return valor
    End Function
End Class
