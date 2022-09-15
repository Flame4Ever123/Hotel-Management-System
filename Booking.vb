Public Class Booking

    Public SQL As New SQL_Connection

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("Select * FROM BookingTable;")
        Else
            SQL.ExecQuery(Query)
        End If
        'Error Handling
        If SQL.HasException(True) Then Exit Sub
        Bookingdgv.DataSource = SQL.DBDT

        'Selects all the available rooms and put in combobox
        SQL.ExecQuery("Select * FROM RoomTable WHERE Room_Status = 'Available' ;")
        For i = 0 To (SQL.DBDT.Rows.Count - 1)
            Roomcb.Items.Add(SQL.DBDT.Rows(i).Item(1).ToString)
        Next
        'Selects all guests and display in combobox
        'SQL.ExecQuery("Select * FROM GuestTable;")
        SQL.ExecQuery("SELECT Guest_ID FROM GuestTable WHERE Guest_ID NOT " &
                      "IN(SELECT Guest_ID FROM BookingTable WHERE Status = 'Active');")

        For i = 0 To (SQL.DBDT.Rows.Count - 1)
            Guestcb.Items.Add(SQL.DBDT.Rows(i).Item(0).ToString)
        Next
    End Sub
    Public Sub FindItem()
        SQL.AddParam("@item", "%" & SearchBar.Text & "%")
        LoadGrid("SELECT * FROM BookingTable WHERE Booking_ID LIKE @item OR Guest_ID LIKE @item OR Room_ID LIKE @item")
    End Sub

    Private Sub InsertBooking()
        Dim bookingdate As Date
        bookingdate = DateTime.Now
        Dim status As String
        status = "Active"
        SQL.AddParam("@guest", Guestcb.Text)
        SQL.AddParam("@room", Roomcb.Text)
        SQL.AddParam("@datein", Checkindtp.Value.Date)
        SQL.AddParam("@dateout", Checkoutdtp.Value.Date)
        SQL.AddParam("@bookdate", bookingdate)
        SQL.AddParam("@status", status)
        SQL.ExecQuery("INSERT INTO BookingTable (Guest_ID, Room_ID, Checkin_Date, Checkout_Date, Booking_Date, Status)" &
                      "VALUES (@guest, @room, @datein, @dateout, @bookdate, @status);")
        BookRoom(Roomcb.Text)
        If SQL.HasException(True) Then Exit Sub
        MsgBox("Booking Added Successfully!")
        If Roomcb.Items.Count > 0 And Guestcb.Items.Count > 0 Then
            Roomcb.Items.Clear()
            Guestcb.Items.Clear()
        End If
    End Sub

    Private Sub Clear()
        BookingIDtb.Clear()
        Guestcb.ResetText()
        Roomcb.ResetText()
        Checkindtp.Value = DateTime.Now
        Checkoutdtp.Value = DateTime.Now
        BookingDatetb.Clear()
        BookingStatustb.Clear()
    End Sub

    Public Sub BookRoom(ByVal room As String)
        SQL.AddParam("@booked", "Booked")
        SQL.AddParam("@room", room)
        SQL.ExecQuery("UPDATE RoomTable " &
                      "SET Room_Status = @booked " &
                      "WHERE Room_Number LIKE @room;")
    End Sub

    Public Sub UnbookRoom(ByVal room As String)
        SQL.AddParam("@unbooked", "Available")
        SQL.AddParam("@room", room)
        SQL.ExecQuery("UPDATE RoomTable " &
                      "SET Room_Status = @unbooked " &
                      "WHERE Room_Number LIKE @room;")
    End Sub

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
        Checkindtp.Value = Date.Now
        Checkoutdtp.Value = Date.Now
    End Sub

    Class RoomCopy
        Public Shared Copy As String
    End Class
    Private Sub Bookingdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Bookingdgv.CellMouseClick
        With Bookingdgv
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.Bookingdgv.Rows(e.RowIndex)
                RoomCopy.Copy = row.Cells("Room_ID").Value.ToString
                BookingIDtb.Text = row.Cells("Booking_ID").Value.ToString
                Guestcb.Text = row.Cells("Guest_ID").Value.ToString
                Roomcb.Text = row.Cells("Room_ID").Value.ToString
                Checkindtp.Text = row.Cells("Checkin_Date").Value.ToString
                Checkoutdtp.Text = row.Cells("Checkout_Date").Value.ToString
                BookingDatetb.Text = row.Cells("Booking_Date").Value.ToString
                BookingStatustb.Text = row.Cells("Status").Value.ToString
            End If
        End With
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click

        Dim DateDiffe As Integer
        Dim checkin As DateTime
        Dim checkout As DateTime
        checkin = Checkindtp.Value
        checkout = Checkoutdtp.Value
        DateDiffe = DateDiff(DateInterval.Day, checkin.Date, checkout.Date)

        If DateDiffe > 0 Then
            Confirmation.GuestID = Guestcb.Text
            Confirmation.CheckIn = Checkindtp.Value
            Confirmation.CheckOut = Checkoutdtp.Value
            Confirmation.RoomNum = Roomcb.Text

            Confirmation.Show()
            LoadGrid()
        Else
            MsgBox("Invalid Date")
        End If
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Clear()
    End Sub

    Private Sub CurrentForm_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If Guestcb.Text = "" Or Roomcb.Text = "" Then
            Addbtn.Enabled = False
        ElseIf Guestcb.Text <> "" And BookingIDtb.Text <> "" Then
            Addbtn.Enabled = False
        Else
            Addbtn.Enabled = True
        End If

        If Form1.AddCon = 1 Then
            InsertBooking()

            SQL.AddParam("@guestid", Guestcb.Text)
            SQL.ExecQuery("SELECT * FROM BookingTable WHERE Guest_ID = @guestid AND Status = 'Active'")

            SQL.AddParam("@bookingid", SQL.DBDT.Rows(0).Item(0))
            SQL.AddParam("@guestid", SQL.DBDT.Rows(0).Item(1))
            SQL.ExecQuery("UPDATE BillingTable SET Booking_ID = @bookingid " &
                          "WHERE Guest_ID = @guestid AND Payment_Status = 'Active'")

            LoadGrid()
            Form1.AddCon = 0
        End If
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        SQL.AddParam("@search", "%" & SearchBar.Text & "%")
        LoadGrid("Select * FROM BookingTable WHERE Guest_ID LIKE @search OR Booking_ID LIKE @search " &
                 "OR Room_ID LIKE @search OR Status LIKE @search;")
    End Sub
End Class