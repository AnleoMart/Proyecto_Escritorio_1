Imports System.Data.SqlClient

Public Class ModiProveedor
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

    Private Sub btnGuardarProv_Click(sender As Object, e As EventArgs) Handles btnGuardarProv.Click

        Dim controlDistribuidor As New ControlDistribuidor()
        Dim nit, nombre, direccion, ciudad, categoria, telefono, descripcion As String
        nit = txtNitProv.Text
        nombre = txtNombreProv.Text
        direccion = txtDireccionProv.Text
        ciudad = txtCiudadProv.Text
        categoria = txtCategProv.Text
        telefono = txtTelProv.Text
        descripcion = txtCategProv.Text
        If controlDistribuidor.crearDistribuidor(nit, nombre, direccion, ciudad, categoria, telefono, descripcion) Then
            Dim BusquedaProveedor As New BusquedaProveedor
            BusquedaProveedor.MdiParent = Form1
            BusquedaProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
            BusquedaProveedor.Left = 0
            BusquedaProveedor.Top = 0
            BusquedaProveedor.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LabArticuloArt_Click(sender As Object, e As EventArgs)

    End Sub
End Class