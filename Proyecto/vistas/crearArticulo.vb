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
        Dim create As Boolean
        Dim nombre, bodega, descripcion, codigo, cantidad As String
        nombre = txtNombreArt.Text
        bodega = txtBodega.Text
        descripcion = txtDescripArt.Text
        codigo = txtCodigoArt.Text
        cantidad = txtCantidadArt.Text
        'Console.WriteLine("-----------------------" & CBProveedor.SelectedValue.ToString())
        If nombre <> "" And bodega <> "" And descripcion <> "" And codigo <> "" And cantidad <> "" Then
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
        End If
    End Sub

    Private Sub LabArticuloArt_Click(sender As Object, e As EventArgs) Handles LabArticuloArt.Click

    End Sub
End Class