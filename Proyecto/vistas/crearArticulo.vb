Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CrearArticulo
    Private cntrlDistribuidor As ControlDistribuidor
    Private cntrlArticulos As ControlArticulos
    Private Sub crearArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cntrlDistribuidor = New ControlDistribuidor()
        Dim list As List(Of Distribuidor)
        list = cntrlDistribuidor.CargarListaDistribuidor()
        ' Console.WriteLine("----------" & list.Count)
        CBProveedor.DataSource = list
        CBProveedor.ValueMember = "nit"
        CBProveedor.DisplayMember = "nombre"

    End Sub

    Private Sub panelInfoArt_Paint(sender As Object, e As PaintEventArgs) Handles panelInfoArt.Paint

    End Sub

    Private Sub btnEliminarArt_Click(sender As Object, e As EventArgs) Handles btnEliminarArt.Click

    End Sub

    Private Sub btnGuardarArt_Click(sender As Object, e As EventArgs) Handles btnGuardarArt.Click
        Dim nombre, area, descripcion, codigo, cantidad As String
        nombre = txtNombreArt.Text
        area = txtAreaArt.Text
        descripcion = txtDescripArt.Text
        codigo = txtCodigoArt.Text
        cantidad = txtCantidadArt.Text
        Console.WriteLine("-----------------------" & CBProveedor.SelectedValue.ToString())
        If nombre <> "" And area <> "" And descripcion <> "" And codigo <> "" And cantidad <> "" Then
            Dim idUser As Integer = Form1.idUuario
            Dim nitProv As String = CBProveedor.SelectedValue.ToString()
            cntrlArticulos = New ControlArticulos
            cntrlArticulos.crearArticulo(codigo, nombre, area, cantidad, descripcion, idUser, nitProv, MCFechaVencimiento.SelectionStart)
        End If
    End Sub

    Private Sub LabArticuloArt_Click(sender As Object, e As EventArgs) Handles LabArticuloArt.Click

    End Sub
End Class