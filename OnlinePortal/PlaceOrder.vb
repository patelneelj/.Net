Public Class PlaceOrder
    Private arrayPass As List(Of CustomerInfo)
    Private getCustomer1 As CustomerInfo
    Private customerId As Integer
    Private listofItemsOrder As New ArrayList
    Private Total As Double
    Private orderInfo As OrderInfo
    Dim index As Integer
    Private listOfOrder As New List(Of OrderInfo)
    Dim operationForm1 As Form1
    Private orderid As Integer
    Public WriteOnly Property ArrayPassPlaceOrderDisplay As List(Of CustomerInfo)
        Set(value As List(Of CustomerInfo))
            arrayPass = value
        End Set
    End Property
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        operationForm1 = New Form1
        operationForm1.fromPlaceOrder = listOfOrder
        operationForm1.ShowDialog()
        Me.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (customerId = 0) Then
            MessageBox.Show("Please select customer")
        Else
            If CheckBox1.Checked = True Then
                listofItemsOrder.Add("Carrots")
                Total = 1 * TextBox3.Text
            End If
            If CheckBox2.Checked = True Then
                listofItemsOrder.Add("Milk")
                Total = (2 * TextBox4.Text) + Total

            End If
            If CheckBox3.Checked = True Then
                listofItemsOrder.Add("Grapes")
                Total = (0.75 * TextBox5.Text) + Total

            End If
            If CheckBox4.Checked = True Then
                listofItemsOrder.Add("Bread")
                Total = (3 * TextBox6.Text) + Total

            End If
            If CheckBox5.Checked = True Then
                listofItemsOrder.Add("Creal")
                Total = (5 * TextBox7.Text) + Total

            End If
            If CheckBox6.Checked = True Then
                listofItemsOrder.Add("Juice")
                Total = (4 * TextBox8.Text) + Total

            End If
        End If
        TextBox1.Text = Total
        For index = 0 To arrayPass.Count - 1
            If (arrayPass.Item(index).getId = customerId) Then
                orderid = orderid + 1
                orderInfo = New OrderInfo
                orderInfo.setOrderId = orderid
                orderInfo.setTotalBalance = Total
                orderInfo.setCustId = customerId
                orderInfo.setfName = arrayPass.Item(index).getFname
                orderInfo.setlName = arrayPass.Item(index).getLname
                orderInfo.setOrderList = listofItemsOrder
                listOfOrder.Add(orderInfo)
                MessageBox.Show("Order Placed Successfully")
            End If
        Next index


        Total = 0
    End Sub

    Private Sub PlaceOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 0 To arrayPass.Count - 1
            getCustomer1 = arrayPass.Item(index)
            DataGridView1.Rows.Add(getCustomer1.getId,
                                   getCustomer1.getFname + " " + getCustomer1.getLname)
        Next index

        TextBox3.Text = 1
        TextBox4.Text = 1
        TextBox5.Text = 1
        TextBox6.Text = 1
        TextBox7.Text = 1
        TextBox8.Text = 1

    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        customerId = selectedRow.Cells(0).Value.ToString
        TextBox2.Text = customerId

    End Sub
End Class