Imports System.Runtime.CompilerServices
Imports System.Security.Cryptography
Imports Microsoft.SqlServer.Server

Public Class Form1
    Private Const V As Integer = 0
    Public fr As Form
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        'If (Me.panelLateral.Controls.Count > V) Then'
        'panelLateral.Controls.Remove(V)'


        'End If'
    End Sub

    Private Sub BarraPerfil_Paint(sender As Object, e As PaintEventArgs) Handles BarraPerfil.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

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
End Class
