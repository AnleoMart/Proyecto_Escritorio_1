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

    Public Function cargarDatos(id As Integer) As List(Of Usuario)
        Dim lista As New List(Of Usuario)()

        Dim usuario As New Usuario()
        lista = usuario.recuperarDatosPerfilUsuario(id)
        Return lista
    End Function
End Class
