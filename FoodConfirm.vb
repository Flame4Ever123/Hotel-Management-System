Public Class FoodConfirm
    Public SQL As New SQL_Connection
    Public GuestID As Integer
    Public OrderDate As DateTime
    Public Quantity As Integer
    Public OrderItem As String
    Public UnitPrice As Double

    Private Sub FoodConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDlbl.Text = GuestID
        SQL.AddParam("@id", GuestID)
        SQL.ExecQuery("Select * FROM GuestTable WHERE Guest_ID = @id;")
        Namelbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()
        OrderDatelbl.Text = OrderDate.Date
        OrderTimelbl.Text = OrderDate.ToLongTimeString
        Quantitylbl.Text = Quantity
        UnitPricelbl.Text = UnitPrice
        ProductDesclbl.Text = OrderItem
        Totallbl.Text = UnitPrice * Quantity
    End Sub

    Private Sub Confirmbtn_Click(sender As Object, e As EventArgs) Handles Confirmbtn.Click
        SQL.AddParam("@id", IDlbl.Text)
        SQL.AddParam("@total", Totallbl.Text)

        SQL.ExecQuery("UPDATE BillingTable SET Total_Amount = Total_Amount + @total, " &
                      "Balance_Amount = Balance_Amount + @total " &
                      "WHERE Guest_ID LIKE @id AND Payment_Status LIKE 'Active';")

        Form1.AddCon = 1
        Me.Close()
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