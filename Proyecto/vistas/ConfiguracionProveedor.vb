Imports System.ComponentModel

Public Class ConfiguracionProveedor
    Private nit As String
    Private cat, ciu, decr, direc, nom, tel As Boolean
    Private validacion As New Validaciones
    Private cntrlDitribuidor As ControlDistribuidor
    Public Sub New(nit As Integer)
        InitializeComponent()
        Me.nit = nit
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nit, nombre, direccion, ciudad, categoria, telefono, descripcion As String
        nit = txtNit.Text
        nombre = txtNombre.Text
        direccion = txtDireccion.Text
        ciudad = txtCiudad.Text
        categoria = txtCategoria.Text
        telefono = txtTelefono.Text
        descripcion = txtDescripcion.Text
        If cat And ciu And decr And direc And nom And tel Then
            cntrlDitribuidor = New ControlDistribuidor
            If cntrlDitribuidor.ModificarDistribuidor(nit, nombre, direccion, ciudad, categoria, telefono, descripcion) Then
                MsgBox("Se han modificado los valores exitosamente", vbInformation, "modificacion exitosa")
                Dim BusquedaProveedor As New BusquedaProveedor
                BusquedaProveedor.MdiParent = Form1
                BusquedaProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
                BusquedaProveedor.Left = 0
                BusquedaProveedor.Top = 0
                BusquedaProveedor.Show()
            Else
                MsgBox("Ha ocurrido un error, no se ha podido completar la modificacion", vbCritical, "Error")
            End If
        End If

    End Sub

    Private Sub ConfiguracionProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntrlDitribuidor = New ControlDistribuidor
        Console.WriteLine("me --------- " & Me.nit)
        Dim distri As Distribuidor = cntrlDitribuidor.cargarDatos(Me.nit)
        Console.WriteLine("me --------- " & distri.Nit)
        txtNit.Text = distri.Nit
        txtNombre.Text = distri.Nombre
        txtDireccion.Text = distri.Direccion
        txtCiudad.Text = distri.Ciudad
        txtCategoria.Text = distri.Categoria
        txtTelefono.Text = distri.Telefono
        txtDescripcion.Text = distri.Descripcion

        cat = True
        ciu = True
        decr = True
        direc = True
        nom = True
        tel = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        cntrlDitribuidor = New ControlDistribuidor
        Dim result As DialogResult = MessageBox.Show("¿desea eliminar el articulo seleccinado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If cntrlDitribuidor.modifEstado(nit) Then
                MsgBox("Se han eliminado este registro", vbInformation, "eliminacion exitosa")
                Dim BusquedaProveedor As New BusquedaProveedor
                BusquedaProveedor.MdiParent = Form1
                BusquedaProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
                BusquedaProveedor.Left = 0
                BusquedaProveedor.Top = 0
                BusquedaProveedor.Show()
            Else
                MsgBox("Ha ocurrido un error, no se ha podido completar la eliminacion", vbCritical, "Error")
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim BusquedaProveedor As New BusquedaProveedor
        BusquedaProveedor.MdiParent = Form1
        BusquedaProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        BusquedaProveedor.Left = 0
        BusquedaProveedor.Top = 0
        BusquedaProveedor.Show()
    End Sub

    Private Sub txtCategoria_Validating(sender As Object, e As CancelEventArgs) Handles txtCategoria.Validating
        If txtCategoria.Text <> "" Then
            If validacion.rxCategoriao(txtCategoria.Text) Then
                lblMsgCategoria.ForeColor = Color.Green
                lblMsgCategoria.Text = "aceptado"
                lblMsgCategoria.Visible = True
                cat = True
            Else
                lblMsgCategoria.ForeColor = Color.Red
                lblMsgCategoria.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgCategoria.Visible = True
                cat = False
            End If
        Else
            lblMsgCategoria.Visible = False
            cat = False
        End If
    End Sub

    Private Sub txtCiudad_Validating(sender As Object, e As CancelEventArgs) Handles txtCiudad.Validating
        If txtCiudad.Text <> "" Then
            If validacion.rxCiudad(txtCiudad.Text) Then
                lblMsgCiudad.ForeColor = Color.Green
                lblMsgCiudad.Text = "aceptado"
                lblMsgCiudad.Visible = True
                ciu = True
            Else
                lblMsgCiudad.ForeColor = Color.Red
                lblMsgCiudad.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgCiudad.Visible = True
                ciu = False
            End If
        Else
            lblMsgCiudad.Visible = False
            ciu = False
        End If
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If txtDescripcion.Text <> "" Then
            If validacion.rxDescripciono(txtDescripcion.Text) Then
                lblMsgDescripcion.ForeColor = Color.Green
                lblMsgDescripcion.Text = "aceptado"
                lblMsgDescripcion.Visible = True
                decr = True
            Else
                lblMsgDescripcion.ForeColor = Color.Red
                lblMsgDescripcion.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgDescripcion.Visible = True
                decr = False
            End If
        Else
            lblMsgDescripcion.Visible = False
            decr = False
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If txtDireccion.Text <> "" Then
            If validacion.rxDescripciono(txtDireccion.Text) Then
                lblMsgDireccion.ForeColor = Color.Green
                lblMsgDireccion.Text = "aceptado"
                lblMsgDireccion.Visible = True
                direc = True
            Else
                lblMsgDireccion.ForeColor = Color.Red
                lblMsgDireccion.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgDireccion.Visible = True
                direc = False
            End If
        Else
            lblMsgDireccion.Visible = False
            direc = False
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text <> "" Then
            If validacion.rxNombre(txtNombre.Text) Then
                lblMsgNombre.ForeColor = Color.Green
                lblMsgNombre.Text = "aceptado"
                lblMsgNombre.Visible = True
                nom = True
            Else
                lblMsgNombre.ForeColor = Color.Red
                lblMsgNombre.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgNombre.Visible = True
                nom = False
            End If
        Else
            lblMsgNombre.Visible = False
            nom = False
        End If
    End Sub

    Private Sub txtTelefono_Validating(sender As Object, e As CancelEventArgs) Handles txtTelefono.Validating
        If txtTelefono.Text <> "" Then
            If validacion.rxTelefono(txtTelefono.Text) Then
                lblMsgTelefono.ForeColor = Color.Green
                lblMsgTelefono.Text = "aceptado"
                lblMsgTelefono.Visible = True
                tel = True
            Else
                lblMsgTelefono.ForeColor = Color.Red
                lblMsgTelefono.Text = "letras de la 'a' a la 'z' minusculas o mayusculas, y espacios"
                lblMsgTelefono.Visible = True
                tel = False
            End If
        Else
            lblMsgTelefono.Visible = False
            tel = False
        End If
    End Sub

End Class