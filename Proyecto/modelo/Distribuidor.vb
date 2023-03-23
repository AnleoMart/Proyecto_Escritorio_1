Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Xml
Imports MySqlConnector

Public Class Distribuidor
    Private adapter As MySqlDataAdapter
    Private command As New MySqlCommand

    Private _nit As Integer
    Private _nombre, _direccion, _ciudad, _categoria, _telefono, _descripcion As String

    Public Sub New()

    End Sub
    Public Sub New(id As Integer, nombre As String)
        Me.Nit = id
        Me.Nombre = nombre
    End Sub

    Public Sub New(nit As Integer, nombre As String, direccion As String, ciudad As String, categoria As String, telefono As String, descripcion As String)
        Me.Nit = nit
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Ciudad = ciudad
        Me.Categoria = categoria
        Me.Telefono = telefono
        Me.Descripcion = descripcion
    End Sub
    Public Sub New(nit As Integer, nombre As String, ciudad As String, categoria As String)
        Me.Nit = nit
        Me.Nombre = nombre
        Me.Ciudad = ciudad
        Me.Categoria = categoria
    End Sub

    Public Property Nit As Integer
        Get
            Return _nit
        End Get
        Set(value As Integer)
            _nit = value
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

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _ciudad
        End Get
        Set(value As String)
            _ciudad = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
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


    'funcion para devolver inicialmete la lista de los distribuidores a la hora de crear el articulo
    Public Function buscarDistribuidor() As List(Of Distribuidor)
        Dim listaDistribuidores As New List(Of Distribuidor)
        Dim query As String = "SELECT nit, nombre FROM distribuidor"
        Try
            openConn()
            command = New MySqlCommand(query, MysqlConex)
            Dim lector As MySqlDataReader = command.ExecuteReader()
            Do While lector.Read()
                listaDistribuidores.Add(New Distribuidor(lector.GetInt32("nit"), lector.GetString("nombre")))
            Loop
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        'Console.WriteLine("--------" & listaDistribuidores.Count)
        Return listaDistribuidores
    End Function
    Public Sub listarDitribuidores(data As Object)
        Dim query As String = "SELECT nit, nombre, direccion, ciudad, categoria, telefono, descripcion FROM distribuidor WHERE estado = 'activo'"
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
    Public Function crearDistribuidor() As Boolean
        Dim estado As String = "activo"
        Dim create As Boolean = False
        Dim query As String = "INSERT INTO distribuidor ( nit, nombre, ciudad, direccion, telefono, categoria, descripcion,estado) VALUES (@nit, @nombre, @ciudad, @direccion, @telefono, @categoria, @descripcion, @estado)"
        Try
            openConn()

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@nit", Nit)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@ciudad", Ciudad)
            comando.Parameters.AddWithValue("@direccion", Direccion)
            comando.Parameters.AddWithValue("@telefono", Telefono)
            comando.Parameters.AddWithValue("@categoria", Categoria)
            comando.Parameters.AddWithValue("@descripcion", Descripcion)
            comando.Parameters.AddWithValue("@estado", estado)
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
    Public Function modificarDistribuidor() As Boolean

        Dim modify As Boolean = False
        Dim query As String = "UPDATE Distribuidor SET telefono = @telefono, nombre = @Nombre, direccion = @Direccion, categoria = @categoria WHERE nit = @nit"
        Try
            openConn()
            Dim Modi As New MySqlCommand(query, MysqlConex)
            Modi.Parameters.AddWithValue("@nit", Nit)
            Modi.Parameters.AddWithValue("@Nombre", Nombre)
            Modi.Parameters.AddWithValue("@Direccion", Direccion)
            Modi.Parameters.AddWithValue("@Cuiudad", Ciudad)
            Modi.Parameters.AddWithValue("@Categoria", Categoria)
            Modi.Parameters.AddWithValue("@telefono", Telefono)
            Modi.Parameters.AddWithValue("@Descripcion", Descripcion)

            Dim datos As Integer = Modi.ExecuteNonQuery()
            Console.WriteLine("columnas afectadas ---- " & datos)
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
    Public Function validarCreacionDistribuidor() As Boolean
        Dim found As Boolean = False
        Dim query As String = "SELECT nit FROM distriudor WHERE nit =  @nit"
        Try
            openConn()
            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@nit", Nit)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                found = True
            Else
                found = False
            End If
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return found
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
    Public Function cargarInfoDitribuidor(nit As String) As Distribuidor
        Dim distri As Distribuidor
        Dim found As Boolean = False
        Dim query As String = "SELECT * FROM distribuidor WHERE nit =  @nit "
        Try
            openConn()
            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@nit", nit)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                Me.Nit = lector.GetInt32("nit")
                Me.Nombre = lector.GetString("nombre")
                Me.Direccion = lector.GetString("direccion")
                Me.Ciudad = lector.GetString("ciudad")
                Me.Categoria = lector.GetString("categoria")
                Me.Telefono = lector.GetString("telefono")
                Me.Descripcion = lector.GetString("descripcion")

            End If
            'Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally

            distri = New Distribuidor(Me.Nit, Me.Nombre, Me.Direccion, Me.Ciudad, Me.Categoria, Me.Telefono, Me.Descripcion)
        End Try

        closeConn()
        Console.WriteLine("me --------- " & distri.Nit)
        Return distri
    End Function
    Public Function modEstado(nit)
        Dim estado As String = "desactivo"
        Dim modify As Boolean = False
        Dim query As String = "UPDATE distribuidor SET estado = @estado WHERE nit = @nit"
        Try
            openConn()
            Dim Modi As New MySqlCommand(query, MysqlConex)
            Modi.Parameters.AddWithValue("@nit", nit)
            Modi.Parameters.AddWithValue("@estado", estado)

            Dim datos As Integer = Modi.ExecuteNonQuery()
            Console.WriteLine("columnas afectadas ---- " & datos)
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
