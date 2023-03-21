Public Class ControlDistribuidor
    Public Function crearDistribuidor(nit As String, nombre As String, direccion As String, cuidad As String, categoria As String, telefono As String, descripcion As String) As Boolean
        'Dim create As Boolean = False

        Dim id As Integer = CInt(nit)
        Dim dist = New Distribuidor(nit, nombre, direccion, cuidad, categoria, telefono, descripcion)
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


End Class
