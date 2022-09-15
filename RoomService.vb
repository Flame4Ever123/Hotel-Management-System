Public Class RoomService
    Public SQL As New SQL_Connection
    Class FoodInfo
        Public Shared foodlist(5) As String

        Public Shared foodprice(5) As Double

    End Class
    Public Sub LoadGrid(Optional Query As String = "")
        Guestcb.Items.Clear()
        Foodcb.Items.Clear()
        Quantitycb.Items.Clear()

        If Query = "" Then
            SQL.ExecQuery("Select * FROM RoomServiceTable;")
        Else
            SQL.ExecQuery(Query)
        End If

        'Error Handling
        If SQL.HasException(True) Then Exit Sub
        RoomServicedgv.DataSource = SQL.DBDT

        'Selects all guests with booking and display in combobox
        SQL.ExecQuery("Select * FROM BookingTable WHERE Status LIKE 'Active';")
        For Each row As DataRow In SQL.DBDT.Rows
            Guestcb.Items.Add(row.Item(1).ToString())
        Next

        'Display food items in combobox
        FoodInfo.foodlist = {"Roti Canai", "Nasi Lemak", "Chicken Rice", "Spaghetti", "Hamburger", "Salad"}
        FoodInfo.foodprice = {4.0, 7.0, 9.0, 12.0, 10.0, 8.0}

        For i = 0 To (FoodInfo.foodlist.Length - 1)
            Foodcb.Items.Add(FoodInfo.foodlist(i))
        Next
        For i = 1 To 5
            Quantitycb.Items.Add(i)
        Next
    End Sub

    Public Sub FindItem()
        SQL.AddParam("@item", "%" & SearchBar.Text & "%")
        LoadGrid("SELECT * FROM RoomServiceTable WHERE Room_Service_ID LIKE @item OR Guest_ID LIKE @item")
    End Sub

    Private Sub InsertRoomService()
        SQL.AddParam("@id", "%" & Guestcb.Text & "%")
        SQL.ExecQuery("SELECT * FROM BillingTable WHERE Guest_ID LIKE @id AND Payment_Status = 'Active'")

        SQL.AddParam("@billingid", Convert.ToInt32(SQL.DBDT.Rows(0).Item(0)))
        SQL.AddParam("@guest", Guestcb.Text)
        SQL.AddParam("@food", Foodcb.Text)
        SQL.AddParam("@foodprice", FoodPricetb.Text)
        SQL.AddParam("@orderdate", DateTime.Now)
        SQL.AddParam("@status", "Active")
        SQL.AddParam("@quantity", Quantitycb.Text)

        SQL.ExecQuery("INSERT INTO RoomServiceTable (Guest_ID, Food_Name, Unit_Price, Order_Time, Order_Status, Order_Quantity, Billing_ID)" &
                      "VALUES (@guest, @food, @foodprice, @orderdate, @status, @quantity, @billingid);")

        If SQL.HasException(True) Then Exit Sub
        MsgBox("Room Service Added Successfully!")
    End Sub

    Private Sub Clear()
        RoomServiceIDtb.Clear()
        Guestcb.ResetText()
        Foodcb.ResetText()
        FoodPricetb.Clear()
        OrderDatetb.Clear()
        FoodStatustb.Clear()
        Quantitycb.ResetText()
    End Sub

    Private Sub RoomService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        FoodConfirm.GuestID = Guestcb.Text
        FoodConfirm.OrderDate = DateTime.Now
        FoodConfirm.Quantity = Quantitycb.Text
        FoodConfirm.OrderItem = Foodcb.Text
        FoodConfirm.UnitPrice = FoodPricetb.Text

        FoodConfirm.Show()
        LoadGrid()
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        Clear()
    End Sub

    Private Sub Foodcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Foodcb.SelectedIndexChanged
        For i = 0 To (FoodInfo.foodlist.Length - 1)
            If Foodcb.Text = FoodInfo.foodlist(i) Then
                FoodPricetb.Text = FoodInfo.foodprice(i)
            End If
        Next
    End Sub

    Private Sub RoomServicedgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles RoomServicedgv.CellMouseClick

        With RoomServicedgv
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.RoomServicedgv.Rows(e.RowIndex)

                RoomServiceIDtb.Text = row.Cells("Room_Service_ID").Value.ToString
                Guestcb.Text = row.Cells("Guest_ID").Value.ToString
                Foodcb.Text = row.Cells("Food_Name").Value.ToString
                FoodPricetb.Text = row.Cells("Unit_Price").Value.ToString
                OrderDatetb.Text = row.Cells("Order_Time").Value.ToString
                FoodStatustb.Text = row.Cells("Order_Status").Value.ToString
                Quantitycb.Text = row.Cells("Order_Quantity").Value.ToString
            End If
        End With
    End Sub

    Private Sub CurrentForm_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If Form1.AddCon = 1 Then
            InsertRoomService()
            LoadGrid()
            Form1.AddCon = 0
        End If

        If Guestcb.Text = "" Or Foodcb.Text = "" Or Quantitycb.Text = "" Or RoomServiceIDtb.Text <> "" Then
            Addbtn.Enabled = False
        Else
            Addbtn.Enabled = True
        End If
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        SQL.AddParam("@search", "%" & SearchBar.Text & "%")
        LoadGrid("Select * FROM RoomServiceTable WHERE Room_Service_ID LIKE @search OR Guest_ID LIKE @search " &
                 "OR Billing_ID LIKE @search OR Order_Status LIKE @search;")
    End Sub
End Class