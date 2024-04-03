Public Class eUsu
    Private _CodUsu As Integer
    Private _CodEmp As Integer
    Private _NomUsu As String
    Private _Password As String
    Private _CodTpUsu As Integer
    Private _IdAlta As Integer
    Private _IdBaja As Integer

    Public Property CodUsu As Integer
        Get
            Return _CodUsu
        End Get
        Set(value As Integer)
            _CodUsu = value
        End Set
    End Property

    Public Property CodEmp As Integer
        Get
            Return _CodEmp
        End Get
        Set(value As Integer)
            _CodEmp = value
        End Set
    End Property

    Public Property NomUsu As String
        Get
            Return _NomUsu
        End Get
        Set(value As String)
            _NomUsu = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Public Property CodTpUsu As Integer
        Get
            Return _CodTpUsu
        End Get
        Set(value As Integer)
            _CodTpUsu = value
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

    Public Property IdBaja As Integer
        Get
            Return _IdBaja
        End Get
        Set(value As Integer)
            _IdBaja = value
        End Set
    End Property
End Class
