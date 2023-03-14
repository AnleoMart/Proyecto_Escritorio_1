﻿Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySqlConnector

Public Class ControladorUsuario

    Public Function login(correo As String, contrasena As String) As Boolean
        Dim found As Boolean
        Dim hashPass As String = desHashear(contrasena)
        Dim usuario As New Usuario(correo, contrasena)
        found = usuario.login()
        Form1.idUuario = usuario.recuperarId()
        Return found
    End Function
    Public Function desHashear(contrasena As String) As String
        Dim sha256 As New SHA256Managed()
        Dim hashedBytes As Byte() = sha256.ComputeHash(Encoding.UTF8.GetBytes(contrasena))
        Dim hashedPassword As String = Convert.ToBase64String(hashedBytes)
        Return hashedPassword
    End Function

    Public Function cargarDatos(id As Integer) As Usuario
        Dim usuario As New Usuario()
        usuario = usuario.recuperarDatosPerfilUsuario(id)
        Return usuario
    End Function
    Public Function crearUsuario(cedula As String, nombre As String, email As String, contraseña As String) As Boolean
        'Dim create As Boolean = False
        Dim pass As String = desHashear(contraseña)
        Dim id As Integer = CInt(cedula)
        Dim usu = New Usuario(id, nombre, email, contraseña)
        If usu.validarCeracionUsuario() = False Then
            If usu.crearUsuario() Then
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("su numero de identificacion o correo ya se encuentra registrado", vbCritical, "Error")
            Return False
        End If


    End Function
End Class
