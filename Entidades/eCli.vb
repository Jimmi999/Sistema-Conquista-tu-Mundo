Public Class eCli
    Dim _CodCli As Integer
    Dim _DNI As Integer
    Dim _Nombre As String
    Dim _Apellido As String
    Dim _CodPais As Integer
    Dim _FechaAlta As DateTime
    Dim _FechaBaja As DateTime
    Dim _IdBaja As Integer
    Dim _IdAlta As Integer
    Dim _Correo As String
    Dim _Telefono As String
    Dim _CodNum As Integer

    Public Property CodCli As Integer
        Get
            Return _CodCli
        End Get
        Set(value As Integer)
            _CodCli = value
        End Set
    End Property

    Public Property DNI As Integer
        Get
            Return _DNI
        End Get
        Set(value As Integer)
            _DNI = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property

    Public Property CodPais As Integer
        Get
            Return _CodPais
        End Get
        Set(value As Integer)
            _CodPais = value
        End Set
    End Property

    Public Property FechaAlta As Date
        Get
            Return _FechaAlta
        End Get
        Set(value As Date)
            _FechaAlta = value
        End Set
    End Property

    Public Property FechaBaja As Date
        Get
            Return _FechaBaja
        End Get
        Set(value As Date)
            _FechaBaja = value
        End Set
    End Property

    Public Property IdBaja As Integer
        Get
            Return _IdBaja
        End Get
        Set(value As Integer)
            _IdBaja = value
        End Set
    End Property

    Public Property IdAlta As Integer
        Get
            Return _IdAlta
        End Get
        Set(value As Integer)
            _IdAlta = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property CodNum As Integer
        Get
            Return _CodNum
        End Get
        Set(value As Integer)
            _CodNum = value
        End Set
    End Property
End Class
