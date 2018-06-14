Public Class HotelCE
    Private _idc As Integer
    Private _nomb As String
    Private _ape As String
    Private _dni As String
    Private _slot As Integer
    Private _placa As String
    Private _idh As String
    Private _usr As String
    Private _pass As String

    Public Property Pass As Integer
        Get
            Return _pass
        End Get
        Set(value As Integer)
            _pass = value
        End Set
    End Property
    Public Property Usr As Integer
        Get
            Return _usr
        End Get
        Set(value As Integer)
            _usr = value
        End Set
    End Property


    Public Property Idc As Integer
        Get
            Return _idc
        End Get
        Set(value As Integer)
            _idc = value
        End Set
    End Property

    Public Property Nomb As String
        Get
            Return _nomb
        End Get
        Set(value As String)
            _nomb = value
        End Set
    End Property

    Public Property Ape As String
        Get
            Return _ape
        End Get
        Set(value As String)
            _ape = value
        End Set
    End Property

    Public Property Dni As String
        Get
            Return _dni
        End Get
        Set(value As String)
            _dni = value
        End Set
    End Property

    Public Property Slot As Integer
        Get
            Return _slot
        End Get
        Set(value As Integer)
            _slot = value
        End Set
    End Property

    Public Property Placa As String
        Get
            Return _placa
        End Get
        Set(value As String)
            _placa = value
        End Set
    End Property

    Public Property Idh As String
        Get
            Return _idh
        End Get
        Set(value As String)
            _idh = value
        End Set
    End Property
End Class
