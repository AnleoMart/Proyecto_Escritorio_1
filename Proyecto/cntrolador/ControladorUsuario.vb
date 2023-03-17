Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports MySqlConnector

Public Class ControladorUsuario

    Public Function login(correo As String, contrasena As String) As Boolean
        Dim found As Boolean
        Dim hashPass As String = desHashear(contrasena)
        Dim usuario As New Usuario(correo, hashPass)
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
        Console.WriteLine("------------------- aqui pues " & usuario.Correo)
        Return usuario
    End Function
    Public Function crearUsuario(cedula As String, nombre As String, email As String, contraseña As String) As Boolean
        'Dim create As Boolean = False
        Dim pass As String = desHashear(contraseña)
        'Console.WriteLine("cedula " & cedula)
        Dim id As Integer = CInt(cedula)
        Dim usu = New Usuario(id, nombre, email, pass)
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
    Private Function cambioContraseña(email As String) As String
        Dim usuario As New Usuario
        Dim nuevaContraseña As String = generarContraseñaRandom()
        usuario.Correo = email
        usuario.modificarContraseña(desHashear(nuevaContraseña))
        Return nuevaContraseña
    End Function
    Private Function generarContraseñaRandom() As String
        Dim alfabeto As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim nuevaContraseña As String = ""
        Dim rnd As New Random()
        Dim letra As Integer

        For i As Integer = 1 To 15
            letra = rnd.Next(0, alfabeto.Length)
            nuevaContraseña = nuevaContraseña & alfabeto.Chars(letra)
        Next
        'Console.WriteLine("<<<<<nueva contraseña>>>> = " & nuevaContraseña)
        Return nuevaContraseña
    End Function
    Public Function recuperarContraseña(email As String)
        Dim nuevaPass As String = cambioContraseña(email)

        Dim correo As New MailMessage()
        Dim clienteSmtp As New SmtpClient()

        Try
            With correo
                .From = New System.Net.Mail.MailAddress("proyecto.escritorio2023@outlook.es")
                .To.Add(email)
                .Body = "Se reestablecio la contraseña para su usuario '" & email & "' Su nueva contraseña es: " & nuevaPass & ". Por favor, al ingresar cambie su contraseña por cuestiones de seguridad"
                .Subject = "Recuepracion de contraseña"
                .Priority = System.Net.Mail.MailPriority.Normal
            End With
            With clienteSmtp
                .EnableSsl = True
                .Port = "587"
                .Host = "smtp.outlook.com"
                .Credentials = New Net.NetworkCredential("proyecto.escritorio2023@outlook.es", "proyectoEcritorio23")
                .Send(correo)
            End With

            MsgBox("Por favor revise su bandeja de entrada, se ha enviado su nueva contraseña de acceso.", "Mensaje enviado", MessageBoxButtons.OK)
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al enviar el mensaje", vbCritical, "Error al enviar Mensaje")
        End Try
    End Function
    Public Function modificarUsuario(cedula As String, nombre As String, apellido As String, email As String, telefono As String, contraseña As String, fecha As Date) As Boolean

        Dim pass As String = desHashear(contraseña)
        'Console.WriteLine("cedula " & cedula)
        Dim id As Integer = CInt(cedula)
        Dim usu = New Usuario(id, nombre, apellido, pass, email, telefono, "activo", fecha)

        If usu.modificarUsuario() Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function modificarUsuario(correo As String, contraseña As String) As Boolean
        Dim pass As String = desHashear(contraseña)
        Dim usu = New Usuario()
        usu.Correo = correo
        If usu.modificarContraseña(pass) Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function modificarEstado(id As Integer) As Boolean
        Dim usu = New Usuario()
        usu.Id = id
        Return usu.modificarEstado()
    End Function
    Public Sub buscarUsuario(data As Object)
        Dim usu = New Usuario()
        usu.buscarUsuarios(data)

    End Sub

End Class
