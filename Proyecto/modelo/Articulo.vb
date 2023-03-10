Public Class Articulo
    Private _id, _codigo, _cantidad, _distribuidor, _usuario As Integer
    Private _nombre, _bodega, _descripcion As String
    Private _fechaVencimiento As Date

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, codigo As Integer, cantidad As Integer, distribuidor As Integer, usuario As Integer, nombre As String, bodega As String, descripcion As String, fechaVencimiento As Date)
        Me.Id = id
        Me.Codigo = codigo
        Me.Cantidad = cantidad
        Me.Distribuidor = distribuidor
        Me.Usuario = usuario
        Me.Nombre = nombre
        Me.Bodega = bodega
        Me.Descripcion = descripcion
        Me.FechaVencimiento = fechaVencimiento
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property Distribuidor As Integer
        Get
            Return _distribuidor
        End Get
        Set(value As Integer)
            _distribuidor = value
        End Set
    End Property

    Public Property Usuario As Integer
        Get
            Return _usuario
        End Get
        Set(value As Integer)
            _usuario = value
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

    Public Property Bodega As String
        Get
            Return _bodega
        End Get
        Set(value As String)
            _bodega = value
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

    Public Property FechaVencimiento As Date
        Get
            Return _fechaVencimiento
        End Get
        Set(value As Date)
            _fechaVencimiento = value
        End Set
    End Property
End Class
