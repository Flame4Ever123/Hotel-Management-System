Public Class Record
    Public SQL As New SQL_Connection
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("Select * FROM PaymentTable;")
        Else
            SQL.ExecQuery(Query)
        End If
        'Error Handling
        If SQL.HasException(True) Then Exit Sub
        Paymentdgv.DataSource = SQL.DBDT
    End Sub
    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Paymentdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Paymentdgv.CellMouseClick
        Try
            With Paymentdgv
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.Paymentdgv.Rows(e.RowIndex)

                    PaymentIDlbl.Text = row.Cells("Payment_ID").Value.ToString
                    BillingIDlbl.Text = row.Cells("Billing_ID").Value.ToString
                    PayDatelbl.Text = row.Cells("Payment_Date").Value.ToString
                    PayAmountlbl.Text = row.Cells("Payment_Amount").Value.ToString
                    PayTypelbl.Text = row.Cells("Payment_Type").Value.ToString

                    Dim method As String
                    If row.Cells("Is_Deposit").Value.ToString = 1 Then
                        method = "Deposit"
                    Else
                        method = "Lump Sum"
                    End If
                    PayMethodlbl.Text = method
                End If
            End With
        Catch

        End Try

    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click
        PaymentInfo.BillingID = BillingIDlbl.Text
        PaymentInfo.PaymentID = PaymentIDlbl.Text
        PaymentInfo.Show()
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        SQL.AddParam("@search", "%" & SearchBar.Text & "%")
        LoadGrid("Select * FROM PaymentTable WHERE Payment_ID LIKE @search OR Billing_ID LIKE @search " &
             "OR Payment_Type LIKE @search OR Is_Deposit LIKE @search;")
    End Sub

    Private Sub CurrentForm_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If PaymentIDlbl.Text = "" Then
            Printbtn.Enabled = False
        Else
            Printbtn.Enabled = True
        End If
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        BillingIDlbl.Text = ""
        PayAmountlbl.Text = ""
        PayDatelbl.Text = ""
        PaymentIDlbl.Text = ""
        PayMethodlbl.Text = ""
        PayTypelbl.Text = ""
    End Sub

    Private Sub Report_Click(sender As Object, e As EventArgs) Handles Report.Click
        TransactionReport.Show()
    End Sub
End Class