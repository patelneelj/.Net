Public Class ViewOrder
    Private arrayPass2 As List(Of OrderInfo)
    Private orderInfo As OrderInfo
    Private index As Integer
    Private orderIndex As Integer
    Private cManager As CurrencyManager

    Public WriteOnly Property ArrayOrderList As List(Of OrderInfo)
        Set(value As List(Of OrderInfo))
            arrayPass2 = value
        End Set
    End Property
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ViewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For index = 0 To arrayPass2.Count - 1
        '    orderInfo = arrayPass2.Item(index)
        '    For orderIndex = 0 To orderInfo.getOrderList.Count

        '        'DataGridView1.Rows.Add(orderInfo.getOrderId, orderInfo.getCustId,
        '        '                   orderInfo.getfName + " " + orderInfo.getlName,
        '        '                   orderInfo.getToalBalance,
        '        '                   orderInfo.getOrderList(orderIndex)
        '        '                    )
        '        cManager = CType(DataGridView1.BindingContext(orderInfo.getOrderList.ToString), CurrencyManager)
        '        DataGridView1.DataSource = orderInfo.getOrderList
        '    Next orderIndex

        'Next index


        Dim i As ListViewItem
        For index = 0 To arrayPass2.Count - 1
            orderInfo = arrayPass2.Item(index)
            For orderIndex = 0 To orderInfo.getOrderList.Count - 1

                '    ListView1.Items.Add(New ListViewItem(orderInfo.getOrderList(orderIndex).ToString()))
                '  ListBox1.Items.Add(orderInfo.getOrderList(orderIndex).ToString)
                i = ListView1.Items.Add(orderInfo.getOrderId)
                i.SubItems.Add(orderInfo.getCustId)
                i.SubItems.Add(orderInfo.getfName + " " + orderInfo.getlName)
                i.SubItems.Add(orderInfo.getToalBalance)
                i.SubItems.Add(orderInfo.getOrderList(orderIndex).ToString)
            Next orderIndex
        Next index

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class