Public Class AddCustomer
    Private cust As CustomerInfo
    Private custInfoList As New List(Of CustomerInfo)
    Private OldoperationForm As Form1

    Public Sub New(ByRef operationForm As Form1)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        OldoperationForm = operationForm

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim idExist As Boolean = False
        'If (cust) Then

        'End If
        cust = New CustomerInfo
        cust.setId = TextBox1.Text
        cust.setFname = TextBox2.Text
        cust.setLname = TextBox3.Text
        cust.setZipcode = TextBox4.Text

        If (custInfoList.Count > 0) Then
            For Each c As CustomerInfo In custInfoList
                If c.getId = cust.getId Then
                    idExist = True

                End If
            Next

        End If

        If idExist = False Then
            custInfoList.Add(cust)
            DataGridView1.Rows.Add(TextBox1.Text, TextBox2.Text + " " + TextBox3.Text)
            MessageBox.Show("Customer is added successfully")
            OldoperationForm.ArrayPass1 = custInfoList
        Else
            'cust id was used already.
            MessageBox.Show("Customer Id is already Exist")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'operationForm.ShowDialog()
        Me.Close()


    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim index As Integer


        If OldoperationForm.ArrayPass3.Count > 0 Then
            custInfoList = OldoperationForm.ArrayPass3


            For index = 0 To custInfoList.Count - 1
                cust = custInfoList.Item(index)
                DataGridView1.Rows.Add(cust.getId,
                                       cust.getFname + " " + cust.getLname,
                                       cust.getZipcode)

            Next index
        End If
    End Sub
End Class