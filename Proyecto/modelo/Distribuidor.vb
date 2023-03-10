Public Class Distribuidor
    Private _nit As Integer
    Private _nombre, _direccion, _ciudad, _categoria, _telefono, _descripcion As String

    Public Sub New()

    End Sub
    Public Sub New(nit As Integer, nombre As String, direccion As String, ciudad As String, categoria As String, telefono As String, descripcion As String)
        Me.Nit = nit
        Me.Nombre = nombre
        Me.Direccion = direccion
        Me.Ciudad = ciudad
        Me.Categoria = categoria
        Me.Telefono = telefono
        Me.Descripcion = descripcion
    End Sub

    Public Property Nit As Integer
        Get
            Return _nit
        End Get
        Set(value As Integer)
            _nit = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _ciudad
        End Get
        Set(value As String)
            _ciudad = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property
End Class
