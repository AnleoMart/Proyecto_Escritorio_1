﻿Imports System.Xml
Imports MySqlConnector

Public Class Distribuidor
    Private adapter As MySqlDataAdapter
    Private command As New MySqlCommand

    Private _nit As Integer
    Private _nombre, _direccion, _ciudad, _categoria, _telefono, _descripcion As String

    Public Sub New(id As Integer, nombre As String)

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
    Public Function crearDistribuidor() As Boolean

        Dim create As Boolean = False
        Dim query As String = "INSERT INTO distribuidor ( nit, nombre, ciudad, direccion, telefono, categoria, descripcion) VALUES (@nit, @nombre, @ciudad, @direccion, @telefono, @categoria, @descripcion)"
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
            'Console.WriteLine("aqui ---- " & lector.Read())
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        closeConn()
        Return found
    End Function
End Class
