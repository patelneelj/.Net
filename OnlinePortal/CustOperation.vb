Public Class Form1

    Private arrayPass As New List(Of CustomerInfo)
    Private arrayOfOrderInfo As List(Of OrderInfo)
    Private arrayPass2 As List(Of OrderInfo)
    Private viewAllCustForm As New ViewAllCustomer
    Private orderForm As New PlaceOrder
    Private viewOrderForm As New ViewOrder
    ' Public fromPlaceOrder As List(Of OrderInfo)
    Public WriteOnly Property ArrayPass1 As List(Of CustomerInfo)
        Set(value As List(Of CustomerInfo))
            arrayPass = value
        End Set
    End Property
    Public ReadOnly Property ArrayPass3 As List(Of CustomerInfo)
        Get
            Return arrayPass
        End Get
    End Property
    'Public WriteOnly Property ArrayOrderList As List(Of OrderInfo)
    '    Set(value As List(Of OrderInfo))
    '        arrayPass2 = value
    '    End Set
    'End Property

    Public WriteOnly Property fromPlaceOrder As List(Of OrderInfo)
        Set(value As List(Of OrderInfo))
            arrayOfOrderInfo = value
        End Set
    End Property

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        viewAllCustForm.ArrayPassDisplay = arrayPass
        viewAllCustForm.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim addForm As New AddCustomer(Me)
        addForm.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        orderForm.ArrayPassPlaceOrderDisplay = arrayPass
        orderForm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        viewOrderForm.ArrayOrderList = arrayOfOrderInfo
        viewOrderForm.ShowDialog()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
