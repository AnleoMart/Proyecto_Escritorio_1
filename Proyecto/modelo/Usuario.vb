Imports System.Xml

Public Class Usuario
    Private id As Integer
    Private nombre, apellido, contraseña, correo, telefono, estado As String
    Private fechaNacimiento As Date

    Public Sub New(id As Integer, nombre As String, apellido As String, contraseña As String, correo As String, telefono As String, estado As String, fechaNacimineto As Date)
        With Me
            .id = id
            .nombre = nombre
            .apellido = apellido
            .contraseña = contraseña
            .correo = correo
            .telefono = telefono
            .estado = estado
            .fechaNacimiento = fechaNacimiento
        End With

    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Apellido1 As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    Public Property Contraseña1 As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property

    Public Property Correo1 As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Property Telefono1 As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property Estado1 As String
        Get
            Return estado
        End Get
        Set(value As String)
            estado = value
        End Set
    End Property

    Public Property FechaNacimiento1 As Date
        Get
            Return fechaNacimiento
        End Get
        Set(value As Date)
            fechaNacimiento = value
        End Set
    End Property

End Class
