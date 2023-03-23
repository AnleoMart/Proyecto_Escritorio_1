Public Class BusquedaProveedor
    Private Sub BusquedaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cntrlDistribuidor As New ControlDistribuidor
        cntrlDistribuidor.buscarDistribuidor(DGDistribuidor)
    End Sub

    Private Sub btnCrearProveedor_Click(sender As Object, e As EventArgs) Handles btnCrearProveedor.Click
        Dim proveedor As New ModiProveedor
        proveedor.MdiParent = Form1
        proveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        proveedor.Left = 0
        proveedor.Top = 0
        proveedor.Show()
    End Sub

    Private Sub DGDistribuidor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDistribuidor.CellClick
        Dim id As Integer = DGDistribuidor.CurrentRow.Cells(0).Value
        Dim ModiProveedor As New ConfiguracionProveedor(id)
        ModiProveedor.MdiParent = Form1
        ModiProveedor.StartPosition = FormStartPosition.Manual ' establece posision inicial del formulario en 0, 0
        ModiProveedor.Left = 0
        ModiProveedor.Top = 0
        ModiProveedor.Show()
    End Sub
End Class