Public Class ControlArticulos
    Private articulo As Articulo
    Public Sub buscarArticulos(data As Object)
        Dim articulo = New Articulo()
        articulo.buscarArticulos(data)

    End Sub

    Public Function crearArticulo(codigo As String, nombre As String, bodega As String, cantidad As String, descripcion As String, idUser As Integer, nitProv As String, fechaVencimiento As Date) As Boolean
        Dim cod As Integer = convertInt(codigo)
        Dim cant As Integer = convertInt(cantidad)
        Dim nit As Integer = convertInt(nitProv)
        articulo = New Articulo(cod, nombre, cant, descripcion, idUser, nit, fechaVencimiento, bodega)

        Return articulo.nuevoArticulo()
    End Function
    Public Function convertInt(dato As String) As Integer
        Dim valor As Integer
        valor = CInt(dato)
        Return valor
    End Function
    Public Function cargarDatos(id As Integer) As Articulo
        Dim articulo As New Articulo()
        articulo = articulo.recuperarInfoArticulo(id)
        Console.WriteLine(articulo.Codigo)
        Return articulo
    End Function
    Public Function modificarArticulo(codigo As String, nombre As String, bodega As String, cantidad As String, descripcion As String, feghaVencimiento As Date) As Boolean
        Dim cod As Integer = convertInt(codigo)
        Dim cant As Integer = convertInt(cantidad)
        articulo = New Articulo(cod, nombre, bodega, cant, descripcion, feghaVencimiento)
        Dim modify As Boolean = articulo.modificarArticulo()
        Return modify
    End Function
    Public Function eliminarArticulo(codigo As String) As Boolean
        Dim cod As Integer = convertInt(codigo)
        articulo = New Articulo
        articulo.Codigo = cod
        Return articulo.eliminarArticulo()
    End Function
End Class
