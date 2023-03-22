Imports MySqlConnector

Public Class Articulo
    Private adapter As MySqlDataAdapter
    Private command As New MySqlCommand

    Private _id, _codigo, _cantidad, _distribuidor, _usuario As Integer
    Private _nombre, _bodega, _descripcion As String
    Private _fechaVencimiento As Date

    Public Sub New()

    End Sub

    Public Sub New(codigo As Integer, nombre As String, area As String, cantidad As Integer, descripcion As String, idUser As Integer, nitProv As Integer, fechaVencimiento As Date)

        Me.Codigo = codigo
        Me.Cantidad = nitProv
        Me.Distribuidor = nitProv
        Me.Usuario = idUser
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.FechaVencimiento = fechaVencimiento
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

    Public Sub buscarUsuarios(data As Object)
        Dim query As String = "SELECT cedula, nombre, apellido, correo, telefono, fecha_nacimiento, estado FROM usuario"
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
        Dim query As String = "INSERT INTO articulo (codigo, nombre, fecha_vencimiento, cantidad, descripcion, FK_distribuidor, FK_usuario ) VALUES (@codigo, @nombre, @fecha_vencimiento, @cantidad, @descripcion, @FK_distribuidor, @FK_usuario )"
        Try
            openConn()

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@codigo", Codigo)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@fecha_vencimiento", FechaVencimiento)
            comando.Parameters.AddWithValue("@cantidad", Cantidad)
            comando.Parameters.AddWithValue("@descripcion", Descripcion)
            comando.Parameters.AddWithValue("@FK_distribuidor", Distribuidor)
            comando.Parameters.AddWithValue("@FK_usuario", Usuario)


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
End Class
