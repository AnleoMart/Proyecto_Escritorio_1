﻿Imports System.Data.SqlClient

Public Class CrearProveedor
    Private Sub CrearProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tboxNombreArt_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProv.TextChanged

    End Sub

    Private Sub tboxCodigoProv_TextChanged(sender As Object, e As EventArgs) Handles txtDireccionProv.TextChanged

    End Sub

    Private Sub tboxTelProv_TextChanged(sender As Object, e As EventArgs) Handles txtTelProv.TextChanged

    End Sub

    Private Sub tboxNitProv_TextChanged(sender As Object, e As EventArgs) Handles txtNitProv.TextChanged

    End Sub

    Private Sub tboxCiudadProv_TextChanged(sender As Object, e As EventArgs) Handles txtCiudadProv.TextChanged

    End Sub

    Private Sub TxtCategProv_TextChanged(sender As Object, e As EventArgs) Handles txtCategProv.TextChanged

    End Sub

    Private Sub tboxDescripProv_TextChanged(sender As Object, e As EventArgs) Handles txtDescripProv.TextChanged

    End Sub

    Private Sub btnGuardarProv_Click(sender As Object, e As EventArgs, ciudad As String, descripcion As String) Handles btnGuardarProv.Click

        Dim controlDistribuidor As New ControladorDistribuidor()
        Dim nit, nombre, direccion, ciudad, categoria, telefono, descripcion As String
        nit = txtNitProv.Text
        nombre = txtNombreProv.Text
        direccion = txtDireccionProv.Text
        ciudad = txtCiudadProv.Text
        categoria = txtCategProv.Text
        telefono = txtTelProv.Text
        If controlDistribuidor.ToString(nit, nombre, direccion, ciudad, categoria, telefono, descripcion) Then
            Dim verArticulos As New verArticulos
            verArticulos.MdiParent = Form1
            verArticulos.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
            verArticulos.Left = 0
            verArticulos.Top = 0
            verArticulos.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LabArticuloArt_Click(sender As Object, e As EventArgs) Handles LabArticuloArt.Click

    End Sub
End Class