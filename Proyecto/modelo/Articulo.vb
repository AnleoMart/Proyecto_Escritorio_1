Imports Microsoft.VisualBasic.ApplicationServices
Imports MySqlConnector

Public Class Articulo
    Private adapter As MySqlDataAdapter
    Private command As New MySqlCommand

    Private _id, _codigo, _cantidad, _distribuidor, _usuario As Integer
    Private _nombre, _bodega, _descripcion As String
    Private _fechaVencimiento As Date

    Public Sub New()

    End Sub
    Public Sub New(codigo As Integer, nombre As String, bodega As String, cantidad As Integer, descripcion As String, fechaVencimiento As Date)
        Me.Codigo = codigo
        Me.Cantidad = cantidad
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.FechaVencimiento = fechaVencimiento
        Me.Bodega = bodega
    End Sub

    Public Sub New(codigo As Integer, nombre As String, cantidad As Integer, descripcion As String, nitProv As Integer, fechaVencimiento As Date)
        Me.Codigo = codigo
        Me.Cantidad = cantidad
        Me.Distribuidor = nitProv
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.FechaVencimiento = fechaVencimiento

    End Sub
    Public Sub New(codigo As Integer, nombre As String, cantidad As Integer, descripcion As String, idUser As Integer, nitProv As Integer, fechaVencimiento As Date, bodega As String)

        Me.Codigo = codigo
        Me.Cantidad = cantidad
        Me.Distribuidor = nitProv
        Me.Usuario = idUser
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.FechaVencimiento = fechaVencimiento
        Me.Bodega = bodega
    End Sub
    Public Sub New(id As Integer, codigo As Integer, cantidad As Integer, distribuidor As Integer, usuario As Integer, nombre As String, bodega As String, descripcion As String, fechaVencimiento As Date)
        Me.Id = id
        Me.Codigo = codigo
        Me.Cantidad = cantidad
        Me.Distribuidor = distribuidor
        Me.Usuario = usuario
        Me.Nombre = nombre
        Me.Bodega = bodega
        Me.Descripcion = descripcion
        Me.FechaVencimiento = fechaVencimiento
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Distribuidor As Integer
        Get
            Return _distribuidor
        End Get
        Set(value As Integer)
            _distribuidor = value
        End Set
    End Property

    Public Property Usuario As Integer
        Get
            Return _usuario
        End Get
        Set(value As Integer)
            _usuario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Bodega As String
        Get
            Return _bodega
        End Get
        Set(value As String)
            _bodega = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property FechaVencimiento As Date
        Get
            Return _fechaVencimiento
        End Get
        Set(value As Date)
            _fechaVencimiento = value
        End Set
    End Property

    Public Sub buscarArticulos(data As Object)
        Dim query As String = "SELECT id, codigo, fecha_vencimiento, cantidad, descripcion FROM articulos"
        Dim datatable As New DataTable
        Try
            openConn()
            command = New MySqlCommand(query, MysqlConex)
            adapter = New MySqlDataAdapter
            adapter.SelectCommand = command
            adapter.Fill(datatable)
            data.datasource = datatable
            'Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)

        End Try

        closeConn()
        datatable.Dispose()
    End Sub
    Public Function nuevoArticulo() As Boolean
        Dim create As Boolean = False
        Dim query As String = "INSERT INTO articulos (codigo, nombre, fecha_vencimiento, cantidad, descripcion, FK_distribuidor, FK_usuario, bodega) VALUES (@codigo, @nombre, @fecha_vencimiento, @cantidad, @descripcion, @FK_distribuidor, @FK_usuario,@bodega )"
        Try
            openConn()
            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@codigo", Codigo)
            comando.Parameters.AddWithValue("@codigo2", Codigo)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@fecha_vencimiento", FechaVencimiento)
            comando.Parameters.AddWithValue("@cantidad", Cantidad)
            comando.Parameters.AddWithValue("@descripcion", Descripcion)
            comando.Parameters.AddWithValue("@FK_distribuidor", Distribuidor)
            comando.Parameters.AddWithValue("@FK_usuario", Usuario)
            comando.Parameters.AddWithValue("@bodega", Bodega)

            Dim datos As Integer = comando.ExecuteNonQuery()
            Console.WriteLine("columnas afectadas ---- " & datos)
            If datos > 0 Then
                create = True
            Else
                create = False
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return create
    End Function
    Public Function recuperarInfoArticulo(codigo As Integer) As Articulo
        Dim articulo As Articulo
        Dim found As Boolean = False
        Dim query As String = "SELECT * FROM articulos WHERE codigo =  @codigo "
        Try
            openConn()
            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@codigo", codigo)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                Console.WriteLine("----------------------------artiuclo " & lector.GetInt32("codigo"))
                Me.Codigo = lector.GetInt32("codigo")
                Me.Cantidad = lector.GetInt32("cantidad")
                Me.Distribuidor = lector.GetInt32("FK_distribuidor")
                Me.Nombre = lector.GetString("nombre")
                Me.Descripcion = lector.GetString("descripcion")
                Me.FechaVencimiento = lector.GetDateTime("fecha_vencimiento")
                Me.Bodega = lector.GetString("bodega")
            End If
            'Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally
            Console.WriteLine(Me.Codigo)
            articulo = New Articulo(Me.Codigo, Me.Nombre, Me.Cantidad, Me.Descripcion, Me.Usuario, Me.Distribuidor, Me.FechaVencimiento, Me.Bodega)
        End Try

        closeConn()
        Return articulo
    End Function
    Public Function modificarArticulo() As Boolean
        Dim modify As Boolean = False
        Dim query As String = "UPDATE articulos SET  nombre = @nombre, fecha_vencimiento = @fecha_vencimiento, bodega = @bodega, cantidad = @cantidad, descripcion=@descripcion WHERE codigo = @codigo"
        Try
            openConn()

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@fecha_vencimiento", FechaVencimiento)
            comando.Parameters.AddWithValue("@bodega", Bodega)
            comando.Parameters.AddWithValue("@cantidad", Cantidad)
            comando.Parameters.AddWithValue("@descripcion", Descripcion)
            comando.Parameters.AddWithValue("@codigo", Codigo)


            Dim datos As Integer = comando.ExecuteNonQuery()
            ' Console.WriteLine("columnas afectadas ---- " & datos)
            If datos > 0 Then
                modify = True
            Else
                modify = False
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return modify
    End Function
End Class
