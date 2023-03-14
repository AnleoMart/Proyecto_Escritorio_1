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
        Console.WriteLine("cedula " & cedula)
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
    Private Function cambioContraseña(email As String) As String
        Dim usuario As New Usuario
        Dim nuevaContraseña As String = generarContraseñaRandom()
        usuario.Correo = email
        usuario.modificarContraseña(nuevaContraseña)
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
        Console.WriteLine("<<<<<nueva contraseña>>>> = " & nuevaContraseña)
        Return nuevaContraseña
    End Function
    Public Function recuperarContraseña(email As String)
        Dim nuevaPass As String = cambioContraseña(email)

        Dim correo As New MailMessage()
        Dim clienteSmtp As New SmtpClient()

        ' Establece el correo electrónico del remitente
        correo.From = New MailAddress("proyecto.escritorio2023@gmail.com")

        ' Establece el correo electrónico del destinatario
        correo.To.Add(email)

        ' Establece el asunto del correo
        correo.Subject = "Recuepracion de contraseña"

        ' Establece el cuerpo del correo
        correo.Body = "Se reestablecio la contraseña para su usuario '" & email & "' Su nueva contraseña es: " & nuevaPass & ". Por favor, al ingresar cambie su contraseña por cuestiones de seguridad"

        ' Establece las credenciales del correo electrónico del remitente (si es necesario)
        clienteSmtp.Credentials = New NetworkCredential("proyecto.escritorio2023@gmail.com", "proyectoEcritorio23")

        ' Establece el servidor SMTP y el puerto
        clienteSmtp.Host = "smtp.ejemplo.com"
        clienteSmtp.Port = 587

        ' Habilita SSL si es necesario
        clienteSmtp.EnableSsl = True

        ' Envía el correo electrónico
        clienteSmtp.Send(correo)

        ' Libera los recursos del correo electrónico
        correo.Dispose()
    End Function

End Class
