Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CrearArticulo
    Private Sub crearArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cntrlDistri As New ControlDistribuidor()
        Dim list As List(Of Distribuidor)
        list = cntrlDistri.cargarListaDistribuidor()
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

    End Sub

    Private Sub LabArticuloArt_Click(sender As Object, e As EventArgs) Handles LabArticuloArt.Click

    End Sub
End Class