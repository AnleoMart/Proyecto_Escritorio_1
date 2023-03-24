Imports System.Text.RegularExpressions

Public Class Validaciones
    Private nombre As New Regex("^[a-zA-Z ]+$")
    Private documento As New Regex("^[1-9]{1,15}$")
    Private correo As New Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
    Private contrasena As New Regex("^[^\s]{1,20}$")
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
End Class
