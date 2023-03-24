Imports System.ComponentModel
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CrearArticulo
    Private validacion As New Validaciones
    Private cntrlDistribuidor As ControlDistribuidor
    Private cntrlArticulos As ControlArticulos
    Private nom, bodg, cant, cod, descr As Boolean
    Private Sub crearArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntrlDistribuidor = New ControlDistribuidor()
        Dim list As List(Of Distribuidor)
        list = cntrlDistribuidor.CargarListaDistribuidor()
        CBProveedor.DataSource = list
        CBProveedor.ValueMember = "nit"
        CBProveedor.DisplayMember = "nombre"

    End Sub


    Private Sub btnGuardarArt_Click(sender As Object, e As EventArgs) Handles btnGuardarArt.Click
        Dim create As Boolean
        Dim nombre, bodega, descripcion, codigo, cantidad As String
        nombre = txtNombreArt.Text
        bodega = txtBodega.Text
        descripcion = txtDescripArt.Text
        codigo = txtCodigoArt.Text
        cantidad = txtCantidadArt.Text
        If nombre <> "" And bodega <> "" And descripcion <> "" And codigo <> "" And cantidad <> "" Then
            If nom And bodg And cant And cod And descr Then
                Dim idUser As Integer = Form1.idUuario
                Dim nitProv As String = CBProveedor.SelectedValue.ToString()
                cntrlArticulos = New ControlArticulos
                create = cntrlArticulos.crearArticulo(codigo, nombre, bodega, cantidad, descripcion, idUser, nitProv, MCFechaVencimiento.SelectionStart)
                If create Then
                    MsgBox("Se ha creado correctamente el articulo", vbInformation, "aprovado")
                    Dim verArticulos As New verArticulos
                    verArticulos.MdiParent = Form1
                    verArticulos.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
                    verArticulos.Left = 0
                    verArticulos.Top = 0
                    verArticulos.Show()
                    Me.Hide()
                Else
                    MsgBox(" No se ha podido crear correctamente el articulo", vbCritical, "Error")
                End If
            Else
                MsgBox("Uno o mas campos estan diligenciados erroneamente", vbCritical, "Error")
            End If
        End If
    End Sub

    Private Sub txtBodega_Validating(sender As Object, e As CancelEventArgs) Handles txtBodega.Validating
        If txtBodega.Text <> "" Then
            If validacion.rxcBodega(txtBodega.Text) Then
                lblMsgBodega.ForeColor = Color.Green
                lblMsgBodega.Text = "aceptado"
                lblMsgBodega.Visible = True
                bodg = True
            Else
                lblMsgBodega.ForeColor = Color.Red
                lblMsgBodega.Text = "Nombre de bodega no aceptada, por favor verificar"
                lblMsgBodega.Visible = True
                bodg = False
            End If
        Else
            lblMsgBodega.Visible = False
            bodg = False
        End If
    End Sub

    Private Sub txtCantidadArt_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidadArt.Validating
        If txtCantidadArt.Text <> "" Then
            If validacion.rxcCantidad(txtCantidadArt.Text) Then
                lblMsgCantidad.ForeColor = Color.Green
                lblMsgCantidad.Text = "aceptado"
                lblMsgCantidad.Visible = True
                cant = True
            Else
                lblMsgCantidad.ForeColor = Color.Red
                lblMsgCantidad.Text = "valor de cantidad invalido, solo numeros por favor."
                lblMsgCantidad.Visible = True
                cant = False
            End If
        Else
            lblMsgCantidad.Visible = False
            cant = False
        End If
    End Sub

    Private Sub txtCodigoArt_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigoArt.Validating
        If txtCodigoArt.Text <> "" Then
            If validacion.rxDocumentoId(txtCodigoArt.Text) Then
                lblCodigo.ForeColor = Color.Green
                lblCodigo.Text = "aceptado"
                lblCodigo.Visible = True
                cod = True
            Else
                lblCodigo.ForeColor = Color.Red
                lblCodigo.Text = "codigo invalido, solo numeros por favor."
                lblCodigo.Visible = True
                cod = False
            End If
        Else
            lblCodigo.Visible = False
            cod = False
        End If
    End Sub

    Private Sub txtDescripArt_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripArt.Validating
        If txtDescripArt.Text <> "" Then
            If validacion.rxDescripciono(txtDescripArt.Text) Then
                lblMsgDescripcion.ForeColor = Color.Green
                lblMsgDescripcion.Text = "aceptado"
                lblMsgDescripcion.Visible = True
                descr = True
            Else
                lblMsgDescripcion.ForeColor = Color.Red
                lblMsgDescripcion.Text = "descripcion invalida,maximo 300 caracteres."
                lblMsgDescripcion.Visible = True
                descr = False
            End If
        Else
            lblMsgDescripcion.Visible = False
            descr = False
        End If
    End Sub

    Private Sub txtNombreArt_Validating(sender As Object, e As CancelEventArgs) Handles txtNombreArt.Validating
        If txtNombreArt.Text <> "" Then
            If validacion.rxNombre(txtNombreArt.Text) Then
                lblMsgNombre.ForeColor = Color.Green
                lblMsgNombre.Text = "aceptado"
                lblMsgNombre.Visible = True
                nom = True
            Else
                lblMsgNombre.ForeColor = Color.Red
                lblMsgNombre.Text = "Nombre invalido."
                lblMsgNombre.Visible = True
                nom = False
            End If
        Else
            lblMsgNombre.Visible = False
            nom = False
        End If
    End Sub
End Class