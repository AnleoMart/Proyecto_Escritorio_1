Imports System.Xml
Imports MySqlConnector

Public Class Usuario
    Private adapter As MySqlDataAdapter
    Private command As New MySqlCommand

    Private _id As Integer
    Private _nombre, _apellido, _contraseña, _correo, _telefono, _estado As String
    Private _fechaNacimiento As Date
    Public Sub New()

    End Sub
    Public Sub New(correo As String, contraseña As String)
        With Me
            ._contraseña = contraseña
            ._correo = correo
        End With
    End Sub
    Public Sub New(id As Integer, nombre As String, correo As String, contraseña As String)
        With Me
            ._id = id
            ._nombre = nombre
            ._contraseña = contraseña
            ._correo = correo
        End With
    End Sub
    Public Sub New(id As Integer, nombre As String, apellido As String, contraseña As String, correo As String, telefono As String, estado As String, fechaNacimineto As Date)
        With Me
            ._id = id
            ._nombre = nombre
            ._apellido = apellido
            ._contraseña = contraseña
            ._correo = correo
            ._telefono = telefono
            ._estado = estado
            ._fechaNacimiento = fechaNacimineto
        End With
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
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

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property
    Public Function login() As Boolean
        Dim found As Boolean = False
        Dim query As String = "SELECT correo, contraseña FROM usuario WHERE correo =  @correo and contraseña =  @contrasena and estado= 'activo';"
        Try
            openConn()
            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@correo", _correo)
            comando.Parameters.AddWithValue("@contrasena", _contraseña)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                found = True
            Else
                found = False
            End If
            'Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return found
    End Function
    Public Function validarCeracionUsuario() As Boolean
        Dim found As Boolean = False
        Dim query As String = "SELECT cedula, correo FROM usuario WHERE cedula =  @cedula or contraseña =  @correo and estado= 'activo'"
        Try
            openConn()
            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@cedula", Id)
            comando.Parameters.AddWithValue("@correo", Correo)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                found = True
            Else
                found = False
            End If
            'Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return found
    End Function
    Public Function recuperarId() As Integer
        Dim id As Integer
        Dim found As Boolean = False
        Dim query As String = "SELECT cedula FROM usuario WHERE correo =  @correo "
        Try
            openConn()

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@correo", _correo)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                id = lector.GetInt32("cedula")
            Else
                id = -1
            End If
            Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return id
    End Function
    Public Function recuperarDatosPerfilUsuario(id As Integer) As Usuario
        Dim usu As Usuario
        Dim found As Boolean = False
        Dim query As String = "SELECT * FROM usuario WHERE cedula =  @cedula "
        Try
            openConn()
            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@cedula", id)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            If lector.Read() Then
                Console.WriteLine("----------------------------Si lee " & lector.GetString("apellido"))
                Me.Id = lector.GetInt32("cedula")
                Me.Nombre = lector.GetString("nombre")
                Me.Apellido = lector.GetString("apellido")
                Me.Contraseña = lector.GetString("contraseña")
                Me.Correo = lector.GetString("correo")
                Me.Telefono = lector.GetString("telefono")
                Me.FechaNacimiento = lector.GetDateTime("fecha_nacimiento")
                Me.Estado = lector.GetString("estado")

            End If
            'Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        Finally

            usu = New Usuario(Me.Id, Me.Nombre, Me.Apellido, Me.Contraseña, Me.Correo, Me.Telefono, Me.Estado, Me.FechaNacimiento)
        End Try

        closeConn()
        Return usu
    End Function

    Public Function crearUsuario() As Boolean
        Dim estado As String = "activo"
        Dim apellido As String = ""
        Dim telefono As String = ""
        Dim fchN As Date = "#1/1/2000#"
        Dim create As Boolean = False
        Dim query As String = "INSERT INTO usuario (cedula, nombre, correo, contraseña, fecha_nacimiento, estado, apellido, telefono ) VALUES (@cedula, @nombre, @correo, @contraseña, @fecha_nacimiento, @estado,@apellido, @telefono)"
        Try
            openConn()

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@cedula", Id)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@correo", Correo)
            comando.Parameters.AddWithValue("@contraseña", Contraseña)
            comando.Parameters.AddWithValue("@fecha_nacimiento", fchN)
            comando.Parameters.AddWithValue("@estado", estado)
            comando.Parameters.AddWithValue("@apellido", apellido)
            comando.Parameters.AddWithValue("@telefono", telefono)

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
    Public Function modificarUsuario() As Boolean

        Dim modify As Boolean = False
        Dim query As String = "UPDATE usuario SET nombre = @nombre, apellido = @apellido, telefono = @telefono, contraseña = @contraseña, fecha_nacimiento = @fecha_nacimiento WHERE cedula = @cedula"
        Try
            openConn()

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@cedula", Id)
            comando.Parameters.AddWithValue("@nombre", Nombre)
            comando.Parameters.AddWithValue("@apellido", Apellido)
            comando.Parameters.AddWithValue("@telefono", Telefono)
            comando.Parameters.AddWithValue("@contraseña", Contraseña)
            comando.Parameters.AddWithValue("@fecha_nacimiento", FechaNacimiento)


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
    Public Function modificarContraseña(pass As String) As Boolean
        Dim cedula As Integer = recuperarId()
        Dim modify As Boolean = False

        If cedula <> -1 Then
            Dim query As String = "UPDATE usuario SET contraseña = @contraseña  WHERE cedula = @cedula"
            Try
                openConn()

                Dim comando As New MySqlCommand(query, MysqlConex)
                comando.Parameters.AddWithValue("@cedula", cedula)
                comando.Parameters.AddWithValue("@contraseña", pass)


                Dim datos As Integer = comando.ExecuteNonQuery()
                'Console.WriteLine("columnas afectadas ---- " & datos)
                If datos > 0 Then
                    modify = True
                Else
                    modify = False
                End If
            Catch ex As Exception
                modify = False
                Console.WriteLine(ex)
            End Try

            closeConn()
        Else
            modify = False
        End If


        Return modify
    End Function
    Public Function modificarEstado() As Boolean
        Dim cedula As Integer = Me.Id
        Dim modify As Boolean = False

        If cedula <> -1 Then
            Dim query As String = "UPDATE usuario SET estado = @estado  WHERE cedula = @cedula"
            Try
                openConn()

                Dim comando As New MySqlCommand(query, MysqlConex)
                comando.Parameters.AddWithValue("@cedula", cedula)
                comando.Parameters.AddWithValue("@estado", "inactivo")


                Dim datos As Integer = comando.ExecuteNonQuery()
                'Console.WriteLine("columnas afectadas ---- " & datos)
                If datos > 0 Then
                    modify = True
                Else
                    modify = False
                End If
            Catch ex As Exception
                modify = False
                Console.WriteLine(ex)
            End Try

            closeConn()
        Else
            modify = False
        End If


        Return modify
    End Function
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
End Class
