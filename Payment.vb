Public Class Payment
    Public SQL As New SQL_Connection
    Public Deposit As Integer
    Public Tax As Decimal
    Private Sub DepositLoad()
        SQL.AddParam("@id", Confirmation.IDlbl.Text)
        SQL.AddParam("@name", Confirmation.Namelbl.Text)
        SQL.ExecQuery("Select * FROM BillingTable WHERE Guest_ID = @id AND Payment_Status LIKE 'Active';")

        Invoicelbl.Text = SQL.DBDT.Rows(0).Item(0).ToString()
        IDlbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()

        Infolbl.Text = "Deposit"
        Datelbl.Text = DateAndTime.Now()
        SQL.AddParam("@id", Confirmation.IDlbl.Text)
        SQL.ExecQuery("Select * FROM GuestTable WHERE Guest_ID LIKE @id;")

        Namelbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()
        Amounttb.Text = Confirmation.Depositlbl.Text

        PaymentMethodcb.Items.Add("Cash")
        PaymentMethodcb.Items.Add("Credit Card")
        PaymentMethodcb.Items.Add("Internet Banking")
    End Sub

    Private Sub NormalLoad()
        SQL.AddParam("invoiceno", Invoice.InvoiceNo)
        SQL.ExecQuery("Select * FROM BillingTable WHERE Billing_ID LIKE @invoiceno;")

        Invoicelbl.Text = Invoice.InvoiceNo
        IDlbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()

        SQL.AddParam("guestid", IDlbl.Text)
        SQL.ExecQuery("Select * FROM GuestTable WHERE Guest_ID LIKE @guestid;")
        Infolbl.Text = "Oustanding"
        Datelbl.Text = DateAndTime.Now()
        Namelbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()

        Amounttb.Text = Invoice.Balancelbl.Text

        PaymentMethodcb.Items.Add("Cash")
        PaymentMethodcb.Items.Add("Credit Card")
        PaymentMethodcb.Items.Add("Internet Banking")
    End Sub
    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Deposit = 1 Then
            DepositLoad()
        Else
            NormalLoad()
        End If
    End Sub

    Private Sub InsertPayment()
        SQL.AddParam("@billid", Invoicelbl.Text)
        SQL.AddParam("@paydate", Date.Now)
        SQL.AddParam("@paytype", PaymentMethodcb.Text)
        SQL.AddParam("@payamount", Amounttb.Text)
        SQL.AddParam("@deposit", Deposit)
        SQL.ExecQuery("INSERT PaymentTable (Billing_ID, Payment_Date, Payment_Type, Payment_Amount, Is_Deposit)" &
                      "VALUES (@billid, @paydate, @paytype, @payamount, @deposit);")
    End Sub


    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        InsertPayment()

        If Deposit = 1 Then
            SQL.AddParam("@id", Invoicelbl.Text)
            SQL.ExecQuery("SELECT * FROM BillingTable WHERE Billing_ID = @id;")
            Dim Balance As Decimal
            Balance = SQL.DBDT.Rows(0).Item(4) - Amounttb.Text

            SQL.AddParam("@balance", Balance)
            SQL.AddParam("@id", Invoicelbl.Text)
            SQL.AddParam("@tax", Tax)

            SQL.ExecQuery("UPDATE BillingTable SET Balance_Amount = @balance WHERE Billing_ID = @id;")


            Deposit = 0
            Form1.AddCon = 1
            Confirmation.Close()
            Me.Close()
        Else
            Form1.AddCon = 1
            SQL.AddParam("@id", Invoicelbl.Text)
            SQL.AddParam("@tax", Tax)

            SQL.ExecQuery("UPDATE BillingTable SET Balance_Amount = 0, Payment_Status = 'Completed', Tax_Amount = @tax WHERE Billing_ID LIKE @id;")

            SQL.AddParam("@id", Invoicelbl.Text)
            SQL.ExecQuery("SELECT * FROM BillingTable WHERE Billing_ID = @id;")
            Dim GuestID As Integer
            Dim RoomNum As Integer
            GuestID = SQL.DBDT.Rows(0).Item(1).ToString()

            SQL.AddParam("@id", GuestID)
            SQL.ExecQuery("UPDATE BookingTable SET Status = 'Completed' WHERE Guest_ID LIKE @id;")

            SQL.AddParam("@id", GuestID)
            SQL.ExecQuery("UPDATE RoomServiceTable SET Order_Status = 'Completed' WHERE Guest_ID LIKE @id;")

            SQL.AddParam("@id", GuestID)
            SQL.ExecQuery("SELECT * FROM BookingTable WHERE Guest_ID = @id;")
            RoomNum = SQL.DBDT.Rows(0).Item(2).ToString()

            SQL.AddParam("@roomnum", RoomNum)
            SQL.ExecQuery("UPDATE RoomTable SET Room_Status = 'Available' WHERE Room_Number LIKE @roomnum;")

            Invoice.Close()
            Me.Close()
        End If
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
End Class