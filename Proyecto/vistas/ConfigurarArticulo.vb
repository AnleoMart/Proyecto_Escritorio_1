Imports System.Globalization

Public Class ConfigurarArticulo
    Public IdArticulo As Integer
    Private contrlAriculo As New ControlArticulos
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
            If contrlAriculo.modificarArticulo(codigo, nombre, bodega, cantidad, descripcion, feghaVencimiento) Then
                MsgBox("El articulo se ha modificado satisfactoriamente", vbInformation, "Modificado")
                Dim result As DialogResult = MessageBox.Show("¿desea volver a la lista de productos?", "Articulos", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    volverArticulos()
                End If
            Else
                    MsgBox("No se ha podido modificar el articulo", vbCritical, "Error")
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
        If contrlAriculo.eliminarArticulo(txtCodigo.Text) Then
            MsgBox("El articulo se ha eliminado satisfactoriamente", vbInformation, "Eliminado")
            volverArticulos()
        Else
            MsgBox("No se ha podido eliminar el articulo", vbCritical, "Error")
        End If
    End Sub
End Class