Public Class Receipt
    Public SQL As New SQL_Connection

    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Public GuestID, InvoiceNo, BookingID As Integer

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'center box labels for guest details
        SQL.AddParam("@id", "%" & GuestID & "%")
        SQL.ExecQuery("SELECT * FROM GuestTable WHERE Guest_ID LIKE @id")
        Namelbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()
        Emaillbl.Text = SQL.DBDT.Rows(0).Item(5).ToString()
        Phonelbl.Text = SQL.DBDT.Rows(0).Item(4).ToString()
        AddLine1lbl.Text = SQL.DBDT.Rows(0).Item(6).ToString()
        AddLine2lbl.Text = SQL.DBDT.Rows(0).Item(7).ToString()
        AddLine3lbl.Text = SQL.DBDT.Rows(0).Item(8).ToString()

        'Right box labels guest and booking info
        SQL.AddParam("@guestid", "%" & GuestID & "%")
        SQL.AddParam("@bookingid", "%" & BookingID & "%")
        SQL.ExecQuery("SELECT * FROM BookingTable WHERE Booking_ID LIKE @bookingid")

        BookingNolbl.Text = BookingID
        InvoiceNolbl.Text = InvoiceNo
        Dim checkin As DateTime
        Dim checkout As DateTime
        checkin = SQL.DBDT.Rows(0).Item(4)
        checkout = SQL.DBDT.Rows(0).Item(5)
        CheckInlbl.Text = checkin.ToString("dd/MM/yyyy")
        CheckOutlbl.Text = checkout.ToString("dd/MM/yyyy")
        IssueDatelbl.Text = Date.Now.ToString("dd/MM/yyyy")


        'Calculations for tax and total box labels
        SQL.AddParam("@id", "%" & InvoiceNo & "%")
        SQL.ExecQuery("SELECT * FROM BillingTable WHERE Billing_ID LIKE @id")
        Taxlbl.Text = SQL.DBDT.Rows(0).Item(6).ToString()
        SQL.AddParam("@id", "%" & InvoiceNo & "%")
        SQL.ExecQuery("SELECT * FROM PaymentTable WHERE Billing_ID LIKE @id")
        For i = 0 To (SQL.DBDT.Rows.Count - 1)
            If SQL.DBDT.Rows(i).Item(5).ToString() = 1 Then
                DepositPaidlbl.Text = SQL.DBDT.Rows(i).Item(4).ToString()
            Else
                BalancePaidlbl.Text = Format(SQL.DBDT.Rows(i).Item(4).ToString() - Convert.ToDecimal(Taxlbl.Text), "0.00")
            End If
        Next
        TotalPaidlbl.Text = Convert.ToDecimal(DepositPaidlbl.Text) + Convert.ToDecimal(BalancePaidlbl.Text) + Convert.ToDecimal(Taxlbl.Text)

        'Booking table items display
        Dim RoomID As Integer
        Dim DateDiffe As Integer
        Dim Price As Double
        Dim RoomType As String
        Dim Count As Integer = 1

        SQL.AddParam("@id", BookingID)
        SQL.ExecQuery("SELECT * FROM BookingTable WHERE Booking_ID LIKE @id")
        RoomID = SQL.DBDT.Rows(0).Item(2).ToString()

        SQL.AddParam("@id", "%" & RoomID & "%")
        SQL.ExecQuery("SELECT * FROM RoomTable WHERE Room_Number LIKE @id")

        Price = SQL.DBDT.Rows(0).Item(4).ToString()
        DateDiffe = DateDiff(DateInterval.Day, checkin, checkout)
        RoomType = SQL.DBDT.Rows(0).Item(2).ToString()

        Pricelb.Items.Add("RM " + Convert.ToString(Format(Price, "0.00")))
        Quantitylb.Items.Add(Convert.ToString(DateDiffe) + " Days")
        Itemlb.Items.Add(RoomType + " Room")
        SubTotallb.Items.Add("RM " + Convert.ToString(Format((DateDiffe * Price), "0.00")))
        Nolb.Items.Add(Count)

        'Room service table items display
        SQL.AddParam("@id", InvoiceNo)
        SQL.ExecQuery("SELECT * FROM RoomServiceTable WHERE Billing_ID LIKE @id")
        For i = 0 To (SQL.DBDT.Rows.Count - 1)
            Count = Count + 1
            Dim unitprice As Double
            Dim quantity As Integer
            unitprice = SQL.DBDT.Rows(i).Item(3)
            quantity = SQL.DBDT.Rows(i).Item(6)

            Pricelb.Items.Add("RM " + Convert.ToString(Format(unitprice, "0.00")))
            Quantitylb.Items.Add(quantity)
            Itemlb.Items.Add(SQL.DBDT.Rows(i).Item(2).ToString())
            SubTotallb.Items.Add("RM " + Convert.ToString(Format((unitprice * quantity), "0.00")))
            Nolb.Items.Add(Count)
        Next
    End Sub

    Private Sub Label43_Click(sender As Object, e As EventArgs) Handles Label43.Click

    End Sub

    Private Sub Cancelbtn_Click(sender As Object, e As EventArgs) Handles Cancelbtn.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", 720, 700)
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub
End Class