Public Class Confirmation
    Public SQL As New SQL_Connection
    Public GuestID As Integer
    Public CheckIn As Date
    Public CheckOut As Date
    Public RoomNum As Integer


    Private Sub Confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDlbl.Text = GuestID
        SQL.AddParam("@id", GuestID)
        SQL.ExecQuery("Select * FROM GuestTable WHERE Guest_ID = @id;")
        Namelbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()
        BookDatelbl.Text = DateTime.Now
        Checkinlbl.Text = CheckIn.ToString
        Checkoutlbl.Text = CheckOut.ToString
        RoomNumlbl.Text = RoomNum
        SQL.AddParam("@roomnum", RoomNumlbl.Text)
        SQL.ExecQuery("Select * FROM RoomTable WHERE Room_Number = @roomnum;")
        RoomTypelbl.Text = SQL.DBDT.Rows(0).Item(2).ToString()
        DescRoomlbl.Text = RoomTypelbl.Text

        Dim days As Integer
        days = DateDiff(DateInterval.Day, CheckIn.Date, CheckOut.Date)

        DescDaylbl.Text = days
        DescPricelbl.Text = SQL.DBDT.Rows(0).Item(4).ToString()

        Totallbl.Text = DescDaylbl.Text * DescPricelbl.Text
        Depositlbl.Text = DescPricelbl.Text * 0.2 * DescDaylbl.Text
    End Sub

    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        Dim bookingdate As Date
        bookingdate = DateTime.Now
        Dim status As String
        status = "Active"
        Dim price As Decimal
        Decimal.TryParse(Totallbl.Text, price)


        SQL.AddParam("@guestid", IDlbl.Text)
        SQL.AddParam("@billdate", bookingdate)
        SQL.AddParam("@paystatus", status)
        SQL.AddParam("@total", price)
        SQL.AddParam("@balance", price)
        SQL.AddParam("@tax", 0)
        SQL.AddParam("@bookingid", 0)

        SQL.ExecQuery("INSERT INTO BillingTable (Guest_ID, Billing_Date, Payment_Status, Total_Amount, Balance_Amount, Tax_Amount, Booking_ID)" &
                      "VALUES (@guestid, @billdate, @paystatus, @total, @balance, @tax, @bookingid);")

        Payment.Deposit = 1
        Payment.Show()
        Me.Hide()
    End Sub

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
End Class