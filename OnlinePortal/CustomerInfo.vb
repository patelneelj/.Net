Public Class CustomerInfo
    Private id As Integer
    Private fName As String
    Private lName As String
    Private zipcode As Integer

    Public ReadOnly Property getId As Integer
        Get
            Return id
        End Get
    End Property
    Public ReadOnly Property getFname As String
        Get
            Return fName
        End Get
    End Property
    Public ReadOnly Property getLname As String
        Get
            Return lName
        End Get
    End Property
    Public ReadOnly Property getZipcode As Integer
        Get
            Return zipcode
        End Get
    End Property

    Public WriteOnly Property setId As Integer
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public WriteOnly Property setFname As String
        Set(value As String)
            fName = value
        End Set
    End Property
    Public WriteOnly Property setLname As String
        Set(value As String)
            lName = value
        End Set
    End Property
    Public WriteOnly Property setZipcode As Integer
        Set(value As Integer)
            zipcode = value
        End Set
    End Property
End Class
