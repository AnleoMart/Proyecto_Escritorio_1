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
            'adapter = New MySqlDataAdapter
            openConn()
            'With command
            ' .Connection = MysqlConex
            '.CommandText = query
            'End With
            'adapter.SelectCommand = command

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@correo", _correo)
            comando.Parameters.AddWithValue("@contrasena", _contraseña)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            'Validar las credenciales proporcionadas por el usuario
            If lector.Read() Then
                found = True
            Else
                found = False
            End If
            Console.WriteLine("aqui ---- " & lector.Read())
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

            'Validar las credenciales proporcionadas por el usuario
            If lector.Read() Then
                id = lector.GetInt32("cedula")
            End If
            Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return id
    End Function
    Public Function recuperarDatosPerfilUsuario(id As Integer) As List(Of Usuario)
        Dim lista As New List(Of Usuario)()
        Dim found As Boolean = False
        Dim query As String = "SELECT * FROM usuario WHERE cedula =  @cedula "
        Try
            openConn()

            Dim comando As New MySqlCommand(query, MysqlConex)
            comando.Parameters.AddWithValue("@cedula", id)
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            'Validar las credenciales proporcionadas por el usuario
            If lector.Read() Then
                Me._id = lector.GetInt32("cedula")
                Me._nombre = lector.GetString("nombre")
                Me._apellido = lector.GetString("nombre")
                Me._contraseña = lector.GetString("nombre")
                Me._correo = lector.GetString("nombre")
                Me._telefono = lector.GetString("nombre")
                Me._fechaNacimiento = lector.GetDateTime("nombre")
                Me._estado = lector.GetString("nombre")
                lista.Add(New Usuario(_id, _nombre, _apellido, _contraseña, _correo, _telefono, _estado, _fechaNacimiento))
            End If
            Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return lista
    End Function
End Class
