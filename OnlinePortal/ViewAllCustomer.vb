Public Class ViewAllCustomer
    Private arrayPass As List(Of CustomerInfo)
    Private getCustomer As CustomerInfo

    Public WriteOnly Property ArrayPassDisplay As List(Of CustomerInfo)
        Set(value As List(Of CustomerInfo))
            arrayPass = value
        End Set
    End Property
    Private Sub ViewAllCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim index As Integer
        For index = 0 To arrayPass.Count - 1
            getCustomer = arrayPass.Item(index)
            DataGridView1.Rows.Add(getCustomer.getId,
                                   getCustomer.getFname + " " + getCustomer.getLname,
                                   getCustomer.getZipcode)

        Next index


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class