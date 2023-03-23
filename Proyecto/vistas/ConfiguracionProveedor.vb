Public Class ConfiguracionProveedor
    Private nit As String
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
        cntrlDitribuidor = New ControlDistribuidor
        If cntrlDitribuidor.ModificarDistribuidor(nit, nombre, direccion, ciudad, categoria, telefono, descripcion) Then
            MsgBox("Se han modificado los valores exitosamente", vbInformation, "modificacion exitosa")
        Else
            MsgBox("Ha ocurrido un error, no se ha podido completar la modificacion", vbCritical, "Error")
        End If
    End Sub

    Private Sub ConfiguracionProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntrlDitribuidor = New ControlDistribuidor
        Dim distri As Distribuidor = cntrlDitribuidor.cargarDatos(Me.nit)
        txtNit.Text = distri.Nit
        txtNombre.Text = distri.Nombre
        txtDireccion.Text = distri.Direccion
        txtCiudad.Text = distri.Ciudad
        txtCategoria.Text = distri.Categoria
        txtTelefono.Text = distri.Telefono
        txtDescripcion.Text = distri.Descripcion
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim BusquedaProveedor As New BusquedaProveedor
        BusquedaProveedor.MdiParent = Form1
        BusquedaProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        BusquedaProveedor.Left = 0
        BusquedaProveedor.Top = 0
        BusquedaProveedor.Show()
    End Sub
End Class