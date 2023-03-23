Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports Microsoft.SqlServer.Server

Public Class Form1
    Private Const V As Integer = 0
    Public fr As Form
    Public idUuario As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ocularMostrarBotones()
        Dim fr As Form = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = "Inicio_sesion").SingleOrDefault()
        If fr Is Nothing Then

            Dim iniciarSesion As New Inicio_sesion
            iniciarSesion.MdiParent = Me
            iniciarSesion.Show()
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles panelLateral.Paint

    End Sub

    Private Sub AbrirFormPerfil()

    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Dim Perfil As New Perfil
        Perfil.MdiParent = Me
        Perfil.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        Perfil.Left = 0
        Perfil.Top = 0
        Perfil.Show()

        'If (Me.panelLateral.Controls.Count > V) Then'
        'panelLateral.Controls.Remove(V)'


        'End If'
    End Sub

    Private Sub BarraPerfil_Paint(sender As Object, e As PaintEventArgs) Handles BarraPerfil.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnCrearPerfil.Click

        'fr = Application.OpenForms.OfType(Of Form)().Where(Function(frm) frm.Name = "Registro").SingleOrDefault()
        'Console.WriteLine(fr)

        'If fr Is Nothing Then

        Dim registro As New Registro
        registro.MdiParent = Me
        registro.StartPosition = FormStartPosition.Manual
        registro.Left = 0
        registro.Top = 0
        registro.Show()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click

        Dim iniciarSesion As New Inicio_sesion
        iniciarSesion.MdiParent = Me
        iniciarSesion.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        iniciarSesion.Left = 0
        iniciarSesion.Top = 0
        iniciarSesion.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        Dim iniciarSesion As New Inicio_sesion
        iniciarSesion.MdiParent = Me
        iniciarSesion.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        iniciarSesion.Left = 0
        iniciarSesion.Top = 0
        iniciarSesion.Show()

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea cerrar Sesion?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ocularMostrarBotones()
            Dim iniciarSesion As New Inicio_sesion
            iniciarSesion.MdiParent = Me
            iniciarSesion.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
            iniciarSesion.Left = 0
            iniciarSesion.Top = 0
            iniciarSesion.Show()
        End If


    End Sub
    Public Sub ocularMostrarBotones()
        If btnInicioSesion.Visible = False Then
            btnInicioSesion.Visible = True
            btnCerrarSesion.Visible = False
            BtnCrearPerfil.Visible = True

            btnPerfil.Visible = False
        Else
            btnInicioSesion.Visible = False
            btnCerrarSesion.Visible = True
            BtnCrearPerfil.Visible = False

            btnPerfil.Visible = True
        End If

    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs)
        Dim Registro As New Registro
        Registro.MdiParent = Me
        Registro.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        Registro.Left = 0
        Registro.Top = 0
        Registro.Show()
    End Sub

    Private Sub btnBuscarUsuarios_Click(sender As Object, e As EventArgs)
        Dim BuscarUsuarios As New BuscarUsuarios
        BuscarUsuarios.MdiParent = Me
        BuscarUsuarios.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        BuscarUsuarios.Left = 0
        BuscarUsuarios.Top = 0
        BuscarUsuarios.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim proveedor As New ModiProveedor
        proveedor.MdiParent = Me
        proveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        proveedor.Left = 0
        proveedor.Top = 0
        proveedor.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim verArticulos As New verArticulos
        verArticulos.MdiParent = Me
        verArticulos.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        verArticulos.Left = 0
        verArticulos.Top = 0
        verArticulos.Show()
    End Sub



    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Dim ModiProveedor As New ModiProveedor
        ModiProveedor.MdiParent = Me
        ModiProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        ModiProveedor.Left = 0
        ModiProveedor.Top = 0
        ModiProveedor.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim BuscarUsuarios As New BuscarUsuarios
        BuscarUsuarios.MdiParent = Me
        BuscarUsuarios.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        BuscarUsuarios.Left = 0
        BuscarUsuarios.Top = 0
        BuscarUsuarios.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Dim BusquedaProveedor As New BusquedaProveedor
        BusquedaProveedor.MdiParent = Me
        BusquedaProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        BusquedaProveedor.Left = 0
        BusquedaProveedor.Top = 0
        BusquedaProveedor.Show()
    End Sub
End Class

