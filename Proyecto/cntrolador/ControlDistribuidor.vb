Public Class ControlDistribuidor
    Public Function crearDistribuidor(nombre As String, direccion As String, telefono As String, nit As String, cuidad As String, categoria As String) As Boolean
        'Dim create As Boolean = False

        Dim id As Integer = CInt(nit)
        Dim dist = New Distribuidor(nit, nombre, cuidad, categoria)
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
