Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class ModiProveedor
    Private validacion As New Validaciones
    Dim cat, nom, descrip, ciu, direc, nt, tel As Boolean
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
        If cat And nom And descrip And ciu And direc And nt And tel Then
            If controlDistribuidor.crearDistribuidor(nit, nombre, direccion, ciudad, categoria, telefono, descripcion) Then
                Dim BusquedaProveedor As New BusquedaProveedor
                BusquedaProveedor.MdiParent = Form1
                BusquedaProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
                BusquedaProveedor.Left = 0
                BusquedaProveedor.Top = 0
                BusquedaProveedor.Show()
                Me.Hide()
            End If
        Else
            MsgBox("uno o mas campos estan mal diligenciados, por favor verificar", vbCritical, "Error")
        End If

    End Sub

    Private Sub txtCategProv_ModifiedChanged(sender As Object, e As EventArgs) Handles txtCategProv.ModifiedChanged
        If txtCategProv.Text <> "" Then
            If validacion.rxCategoriao(txtCategProv.Text) Then
                lblMsgCategoria.ForeColor = Color.Green
                lblMsgCategoria.Text = "aceptado"
                lblMsgCategoria.Visible = True
                cat = True
            Else
                lblMsgCategoria.ForeColor = Color.Red
                lblMsgCategoria.Text = "Categoria no aceptado, por fvor verificar"
                lblMsgCategoria.Visible = True
                cat = False
            End If
        Else
            lblMsgCategoria.Visible = False
            cat = False
        End If
    End Sub

    Private Sub txtCiudadProv_Validating(sender As Object, e As CancelEventArgs) Handles txtCiudadProv.Validating
        If txtCiudadProv.Text <> "" Then
            If validacion.rxCiudad(txtCiudadProv.Text) Then
                lblMsgCiudad.ForeColor = Color.Green
                lblMsgCiudad.Text = "aceptado"
                lblMsgCiudad.Visible = True
                ciu = True
            Else
                lblMsgCiudad.ForeColor = Color.Red
                lblMsgCiudad.Text = "Ciudad no aceptado, por fvor verificar"
                lblMsgCiudad.Visible = True
                ciu = False
            End If
        Else
            lblMsgCiudad.Visible = False
            ciu = False
        End If
    End Sub

    Private Sub txtDescripProv_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripProv.Validating
        If txtDescripProv.Text <> "" Then
            If validacion.rxCiudad(txtDescripProv.Text) Then
                lblMsgDecripcion.ForeColor = Color.Green
                lblMsgDecripcion.Text = "aceptado"
                lblMsgDecripcion.Visible = True
                descrip = True
            Else
                lblMsgDecripcion.ForeColor = Color.Red
                lblMsgDecripcion.Text = "Descripcion no aceptada,se permite hasta 300 caracteress"
                lblMsgDecripcion.Visible = True
                descrip = False
            End If
        Else
            lblMsgDecripcion.Visible = False
            descrip = False
        End If
    End Sub

    Private Sub txtDireccionProv_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccionProv.Validating
        If txtDireccionProv.Text <> "" Then
            If validacion.rxDescripciono(txtDireccionProv.Text) Then
                lblMsgDireccion.ForeColor = Color.Green
                lblMsgDireccion.Text = "aceptado"
                lblMsgDireccion.Visible = True
                direc = True
            Else
                lblMsgDireccion.ForeColor = Color.Red
                lblMsgDireccion.Text = "Direccion no aceptada, por favor verificar"
                lblMsgDireccion.Visible = True
                direc = False
            End If
        Else
            lblMsgDireccion.Visible = False
            direc = False
        End If
    End Sub

    Private Sub txtNitProv_Validating(sender As Object, e As CancelEventArgs) Handles txtNitProv.Validating
        If txtNitProv.Text <> "" Then
            If validacion.rxNit(txtNitProv.Text) Then
                lblMsgNit.ForeColor = Color.Green
                lblMsgNit.Text = "aceptado"
                lblMsgNit.Visible = True
                nt = True
            Else
                lblMsgNit.ForeColor = Color.Red
                lblMsgNit.Text = "Nit no aceptada, por favor verificar"
                lblMsgNit.Visible = True
                nt = False
            End If
        Else
            lblMsgNit.Visible = False
            nt = False
        End If
    End Sub

    Private Sub txtNombreProv_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreProv.Validating
        If txtNombreProv.Text <> "" Then
            If validacion.rxNombre(txtNombreProv.Text) Then
                lblMsgNombre.ForeColor = Color.Green
                lblMsgNombre.Text = "aceptado"
                lblMsgNombre.Visible = True
                nom = True
            Else
                lblMsgNombre.ForeColor = Color.Red
                lblMsgNombre.Text = "Nombre no aceptada, por favor verificar"
                lblMsgNombre.Visible = True
                nom = False
            End If
        Else
            lblMsgNombre.Visible = False
            nom = False
        End If
    End Sub

    Private Sub txtTelProv_Validating(sender As Object, e As CancelEventArgs) Handles txtTelProv.Validating
        If txtTelProv.Text <> "" Then
            If validacion.rxTelefono(txtTelProv.Text) Then
                lblMsgTelefono.ForeColor = Color.Green
                lblMsgTelefono.Text = "aceptado"
                lblMsgTelefono.Visible = True
                tel = True
            Else
                lblMsgTelefono.ForeColor = Color.Red
                lblMsgTelefono.Text = "Telefono no aceptado, por favor verificar"
                lblMsgTelefono.Visible = True
                tel = False
            End If
        Else
            lblMsgTelefono.Visible = False
            tel = False
        End If
    End Sub
End Class