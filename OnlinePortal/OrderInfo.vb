Public Class OrderInfo
    Private oid As String
    Private orderList As ArrayList
    Private custId As Integer
    Private TotalBalance As Integer
    Private customer As CustomerInfo
    Private fName As String
    Private lName As String
    Public ReadOnly Property getfName As String
        Get
            Return fName
        End Get
    End Property
    Public WriteOnly Property setfName As String
        Set(value As String)
            fName = value
        End Set
    End Property
    Public ReadOnly Property getlName As String
        Get
            Return lName
        End Get
    End Property
    Public WriteOnly Property setlName As String
        Set(value As String)
            lName = value
        End Set
    End Property
    Public ReadOnly Property getCustId As Integer
        Get
            Return custId
        End Get
    End Property
    Public WriteOnly Property setCustId As Integer
        Set(value As Integer)
            custId = value
        End Set
    End Property

    Public ReadOnly Property getOrderList As ArrayList
        Get
            Return orderList
        End Get
    End Property
    Public WriteOnly Property setOrderList As ArrayList
        Set(value As ArrayList)
            orderList = value
        End Set
    End Property
    Public ReadOnly Property getOrderId As Integer
        Get
            Return oid
        End Get
    End Property
    Public WriteOnly Property setOrderId As Integer
        Set(value As Integer)
            oid = value
        End Set
    End Property
    Public ReadOnly Property getToalBalance As Integer
        Get
            Return TotalBalance
        End Get
    End Property
    Public WriteOnly Property setTotalBalance As Integer
        Set(value As Integer)
            TotalBalance = value
        End Set
    End Property
    Public ReadOnly Property getCustomerInfo As CustomerInfo
        Get
            Return customer
        End Get
    End Property
    Public WriteOnly Property setCustomerInfo As CustomerInfo
        Set(value As CustomerInfo)
            customer = value
        End Set
    End Property

End Class
