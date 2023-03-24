Imports System.Text.RegularExpressions

Public Class Validaciones
    Private nombre As New Regex("^[A-Za-zñÑáéíóúÁÉÍÓÚ\s]+$")
    Private documento As New Regex("^[0-9]{1,15}$")
    Private correo As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
    Private contrasena As New Regex("^[^\s]{6,20}$")
    Private telefono As New Regex("^[0-9]{6,12}$")
    Private nit As New Regex("^[0-9]{1,15}$")
    Private ciudad As New Regex("^[A-Za-z\s-]+$")
    Private categoria As New Regex("^[a-zA-Z ]+$")
    Private descripcion As New Regex("^.{0,300}$")
    Private cantidad As New Regex("^[0-9]{1,15}$")
    Private bodega As New Regex("^[A-Za-z0-9]+$")
    Public Function rxNombre(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = nombre.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxDocumentoId(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = documento.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxCorreo(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = correo.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxContraseña(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = contrasena.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxTelefono(cadena As String) As Boolean

        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = telefono.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxNit(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = nit.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxCiudad(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = ciudad.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxCategoriao(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = categoria.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxDescripciono(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = descripcion.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxcCantidad(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = cantidad.IsMatch(cadena)
        End If
        Return resp
    End Function
    Public Function rxcBodega(cadena As String) As Boolean
        Dim resp As Boolean = False
        If cadena <> "" Then
            resp = bodega.IsMatch(cadena)
        End If
        Return resp
    End Function
End Class
