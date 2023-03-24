Imports System.ComponentModel
Imports System.Globalization

Public Class ConfigurarArticulo
    Public IdArticulo As Integer
    Private contrlAriculo As New ControlArticulos
    Private validacion As New Validaciones
    Private bodg, descr, cant, nom As Boolean
    Public Sub New(id As Integer)
        InitializeComponent()
        Me.IdArticulo = id
    End Sub

    Private Sub ConfigurarArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim art As Articulo = contrlAriculo.cargarDatos(Me.IdArticulo)
        Console.WriteLine(art.Codigo)
        txtCodigo.Text = art.Codigo
        txtNombre.Text = art.Nombre
        txtBodega.Text = art.Bodega
        txtcantidad.Text = art.Cantidad.ToString
        txtDescripcion.Text = art.Descripcion
        MCFechaVencimietto.SelectionStart = art.FechaVencimiento
        MCFechaVencimietto.SetSelectionRange(MCFechaVencimietto.SelectionStart, MCFechaVencimietto.SelectionStart)
        bodg = True
        descr = True
        cant = True
        nom = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codigo, nombre, bodega, cantidad, descripcion As String
        Dim feghaVencimiento As Date
        codigo = txtCodigo.Text
        nombre = txtNombre.Text
        bodega = txtBodega.Text
        cantidad = txtcantidad.Text
        descripcion = txtDescripcion.Text
        feghaVencimiento = MCFechaVencimietto.SelectionStart

        If codigo <> "" And nombre <> "" And bodega <> "" And cantidad <> "" And descripcion <> "" Then
            If bodg And descr And cant And nom Then
                If contrlAriculo.modificarArticulo(codigo, nombre, bodega, cantidad, descripcion, feghaVencimiento) Then
                    MsgBox("El articulo se ha modificado satisfactoriamente", vbInformation, "Modificado")
                    Dim result As DialogResult = MessageBox.Show("¿desea volver a la lista de productos?", "Articulos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If result = DialogResult.Yes Then
                        volverArticulos()
                    End If
                Else
                    MsgBox("No se ha podido modificar el articulo", vbCritical, "Error")
                End If
            Else
                MsgBox("Uno o mas campos estan mal diligenciados", vbCritical, "Error")
            End If
        End If

    End Sub
    Public Sub volverArticulos()
        Dim verArticulos As New verArticulos
        verArticulos.MdiParent = Form1
        verArticulos.StartPosition = FormStartPosition.Manual
        verArticulos.Left = 0
        verArticulos.Top = 0
        verArticulos.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = MessageBox.Show("¿desea eliminar el articulo seleccinado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            If contrlAriculo.eliminarArticulo(txtCodigo.Text) Then
                MsgBox("El articulo se ha eliminado satisfactoriamente", vbInformation, "Eliminado")
                volverArticulos()
            Else
                MsgBox("No se ha podido eliminar el articulo", vbCritical, "Error")
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim verArticulos As New verArticulos
        verArticulos.MdiParent = Form1
        verArticulos.StartPosition = FormStartPosition.Manual
        verArticulos.Left = 0
        verArticulos.Top = 0
        verArticulos.Show()
        Me.Hide()
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
                lblMsgBodega.Text = "Nombre de Bodega no aceptada"
                lblMsgBodega.Visible = True
                bodg = False

            End If
        Else
            lblMsgBodega.Visible = False
            bodg = False
        End If
    End Sub

    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If txtcantidad.Text <> "" Then
            If validacion.rxcCantidad(txtcantidad.Text) Then
                lblMsgCantidad.ForeColor = Color.Green
                lblMsgCantidad.Text = "aceptado"
                lblMsgCantidad.Visible = True
                cant = True
            Else
                lblMsgCantidad.ForeColor = Color.Red
                lblMsgCantidad.Text = "valor de cantidad aceptada, solo numeros"
                lblMsgCantidad.Visible = True
                cant = False

            End If
        Else
            lblMsgCantidad.Visible = False
            cant = False
        End If
    End Sub

    Private Sub txtDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtDescripcion.Validating
        If txtDescripcion.Text <> "" Then
            If validacion.rxDescripciono(txtDescripcion.Text) Then
                lblMsgDecripcion.ForeColor = Color.Green
                lblMsgDecripcion.Text = "aceptado"
                lblMsgDecripcion.Visible = True
                descr = True
            Else
                lblMsgDecripcion.ForeColor = Color.Red
                lblMsgDecripcion.Text = "deripcion no valida, max 300 caracteres"
                lblMsgDecripcion.Visible = True
                descr = False

            End If
        Else
            lblMsgDecripcion.Visible = False
            descr = False
        End If
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If txtNombre.Text <> "" Then
            If validacion.rxDescripciono(txtNombre.Text) Then
                lblMsgNombre.ForeColor = Color.Green
                lblMsgNombre.Text = "aceptado"
                lblMsgNombre.Visible = True
                nom = True
            Else
                lblMsgNombre.ForeColor = Color.Red
                lblMsgNombre.Text = "Nombre de Bodega no aceptada"
                lblMsgNombre.Visible = True
                nom = False

            End If
        Else
            lblMsgNombre.Visible = False
            nom = False
        End If
    End Sub
End Class