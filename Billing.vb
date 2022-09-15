Public Class Billing
    Public SQL As New SQL_Connection
    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("Select * FROM BillingTable;")
        Else
            SQL.ExecQuery(Query)
        End If
        'Error Handling
        If SQL.HasException(True) Then Exit Sub
        Billingdgv.DataSource = SQL.DBDT
    End Sub
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Receiptbtn_Click(sender As Object, e As EventArgs) Handles Receiptbtn.Click
        Receipt.GuestID = GuestIDlbl.Text
        Receipt.BookingID = BookingIDlbl.Text
        Receipt.InvoiceNo = IDlbl.Text
        Receipt.Show()
    End Sub

    Private Sub Invoicebtn_Click(sender As Object, e As EventArgs) Handles Invoicebtn.Click
        Invoice.GuestID = GuestIDlbl.Text
        Invoice.Total = Totallbl.Text
        Invoice.Balance = Outstandinglbl.Text
        Invoice.InvoiceNo = IDlbl.Text

        SQL.AddParam("@id", "%" & IDlbl.Text & "%")
        SQL.ExecQuery("SELECT * FROM PaymentTable WHERE Billing_ID LIKE @id AND Is_Deposit = 1")
        Invoice.Deposit = SQL.DBDT.Rows(0).Item(4).ToString()
        Invoice.Show()
    End Sub

    Private Sub Guestdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Billingdgv.CellMouseClick
        Try
            With Billingdgv
                If e.RowIndex >= 0 Then
                    Dim row As DataGridViewRow
                    row = Me.Billingdgv.Rows(e.RowIndex)

                    Dim billdate As Date
                    billdate = row.Cells("Billing_Date").Value
                    IDlbl.Text = row.Cells("Billing_ID").Value.ToString
                    GuestIDlbl.Text = row.Cells("Guest_ID").Value.ToString
                    Outstandinglbl.Text = row.Cells("Balance_Amount").Value.ToString
                    Statuslbl.Text = row.Cells("Payment_Status").Value.ToString
                    Totallbl.Text = row.Cells("Total_Amount").Value.ToString
                    Datelbl.Text = billdate.ToString("dd/MM/yyyy")
                    BookingIDlbl.Text = row.Cells("Booking_ID").Value.ToString

                    If Statuslbl.Text = "Active" Then
                        Invoicebtn.Enabled = True
                        Receiptbtn.Enabled = False
                        Clearbtn.Enabled = True
                    ElseIf Statuslbl.Text = "Completed" Then
                        Receiptbtn.Enabled = True
                        Invoicebtn.Enabled = False
                        Clearbtn.Enabled = True
                    Else
                        Receiptbtn.Enabled = False
                        Invoicebtn.Enabled = False
                        Clearbtn.Enabled = True
                    End If
                End If
            End With
        Catch

        End Try
    End Sub

    Private Sub CurrentForm_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If Statuslbl.Text = "Completed" Then
            Invoicebtn.Enabled = False
            Receiptbtn.Enabled = True
            Clearbtn.Enabled = True
        ElseIf Statuslbl.Text = "Active" Then
            Invoicebtn.Enabled = True
            Receiptbtn.Enabled = False
            Clearbtn.Enabled = True
        Else
            Invoicebtn.Enabled = False
            Receiptbtn.Enabled = False
            Clearbtn.Enabled = False
        End If

        If Form1.AddCon = 1 Then
            LoadGrid()
            Form1.AddCon = 0
        End If
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        SQL.AddParam("@search", "%" & SearchBar.Text & "%")
        LoadGrid("Select * FROM BillingTable WHERE Billing_ID LIKE @search OR Guest_ID LIKE @search " &
                 "OR Booking_ID LIKE @search OR Payment_Status LIKE @search;")
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        BookingIDlbl.Text = ""
        Datelbl.Text = ""
        GuestIDlbl.Text = ""
        IDlbl.Text = ""
        Outstandinglbl.Text = ""
        Statuslbl.Text = ""
        Totallbl.Text = ""
    End Sub

End Class