Imports System.Drawing.Text

Public Class ControlDistribuidor
    Public Function crearDistribuidor(nit As String, nombre As String, direccion As String, cuidad As String, categoria As String, telefono As String, descripcion As String) As Boolean
        'Dim create As Boolean = False
        Dim id As Integer = CInt(nit)
        Dim dist As New Distribuidor(nit, nombre, direccion, cuidad, categoria, telefono, descripcion)
        If dist.validarCreacionDistribuidor() = False Then
            If dist.crearDistribuidor() Then
                Return True
            Else
                Return False
            End If
        Else
            MsgBox("Creado correctamente", vbCritical, "Error")
            Return False
        End If
    End Function

    Public Function CargarListaDistribuidor() As List(Of Distribuidor)
        Dim dist As New Distribuidor
        Dim lista As New List(Of Distribuidor)
        lista = dist.buscarDistribuidor()
        'Console.WriteLine("--------" & lista.Count)

        Return lista
    End Function

    Public Sub buscarDistribuidor(data As Object)
        Dim dis = New Distribuidor()
        Dim distribuidors = dis.buscarDistribuidores(data)

    End Sub
    Public Function ModificarDistribuidor(nit As String, nombre As String, direccion As String, ciudad As String, categoria As String, telefono As Date) As Boolean

        Dim id As Integer = CInt(nit)
        Dim dis As New Distribuidor()
        dis.Nit = nit
        dis.Nombre = nombre
        dis.Direccion = direccion
        dis.Ciudad = ciudad
        dis.Categoria = categoria
        dis.Telefono = telefono

        If dis.modificarDistribuidor() Then
            Return True
        Else
            Return False
        End If
    End Function


End Class
