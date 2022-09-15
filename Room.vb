Public Class Room
    Public SQL As New SQL_Connection

    Class RoomInfo
        Public Shared RoomType(4) As String
        Public Shared RoomPrice(4) As Double
    End Class
    Public Sub LoadGrid(Optional Query As String = "")
        RoomTypecb.Items.Clear()
        If Query = "" Then
            SQL.ExecQuery("Select * FROM RoomTable;")
        Else
            SQL.ExecQuery(Query)
        End If
        'Error Handling
        If SQL.HasException(True) Then Exit Sub
        Roomdgv.DataSource = SQL.DBDT

        RoomInfo.RoomType = {"Economy", "Deluxe", "Double Economy", "Double Deluxe"}
        RoomInfo.RoomPrice = {50.0, 100.0, 80.0, 160}
        For i = 0 To (RoomInfo.RoomType.Length - 1)
            RoomTypecb.Items.Add(RoomInfo.RoomType(i))
        Next
    End Sub

    Public Sub FindItem()
        Sql.AddParam("@item", "%" & SearchBar.Text & "%")
        LoadGrid("SELECT * FROM RoomTable WHERE Room_ID LIKE @item OR Room_Number LIKE @item")
    End Sub

    Private Sub InsertRoom()
        Sql.AddParam("@number", RoomNumbertb.Text)
        SQL.AddParam("@type", RoomTypecb.Text)
        SQL.AddParam("@status", "Available")
        Sql.AddParam("@price", RoomPricetb.Text)


        Sql.ExecQuery("INSERT INTO RoomTable (Room_Number, Room_Type, Room_Status, Room_Price)" &
                      "VALUES (@number, @type, @status, @price);")

        If Sql.HasException(True) Then Exit Sub
        MsgBox("Room Added Successfully!")
    End Sub

    Private Sub UpdateRoom()
        Sql.AddParam("@id", RoomIDtb.Text)
        Sql.AddParam("@number", RoomNumbertb.Text)
        SQL.AddParam("@type", RoomTypecb.Text)
        SQL.AddParam("@status", RoomStatustb.Text)
        Sql.AddParam("@price", RoomPricetb.Text)

        Sql.ExecQuery("UPDATE RoomTable " &
                      "SET Room_Number = @number, Room_Type = @type, Room_Status = @status, Room_Price = @price " &
                      "WHERE Room_ID LIKE @id;")
    End Sub

    Private Sub DeleteRoom()
        Sql.AddParam("@id", RoomIDtb.Text)
        Sql.AddParam("@number", RoomNumbertb.Text)
        Sql.ExecQuery("DELETE FROM RoomTable WHERE Room_ID LIKE @id AND Room_Number LIKE @number")
    End Sub

    Private Sub ClearFields()
        RoomIDtb.Clear()
        RoomNumbertb.Clear()
        RoomTypecb.ResetText()
        RoomPricetb.Clear()
        RoomStatustb.Clear()
    End Sub
    Private Sub Room_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadGrid()
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        InsertRoom()
        LoadGrid()
        ClearFields()
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        UpdateRoom()
        LoadGrid()
        ClearFields()
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        DeleteRoom()
        LoadGrid()
        ClearFields()
    End Sub

    Private Sub Roomdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Roomdgv.CellMouseClick
        With Roomdgv
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow

                row = Me.Roomdgv.Rows(e.RowIndex)
                RoomIDtb.Text = row.Cells("Room_ID").Value.ToString
                RoomNumbertb.Text = row.Cells("Room_Number").Value.ToString
                RoomTypecb.Text = row.Cells("Room_Type").Value.ToString
                RoomPricetb.Text = row.Cells("Room_Price").Value.ToString
                RoomStatustb.Text = row.Cells("Room_Status").Value.ToString

            End If
        End With
    End Sub
    Private Sub RoomTypecb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoomTypecb.SelectedIndexChanged

        For i = 0 To (RoomInfo.RoomType.Length - 1)
            If RoomTypecb.SelectedItem = RoomInfo.RoomType(i) Then
                RoomPricetb.Text = RoomInfo.RoomPrice(i)
            End If
        Next

    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        ClearFields()
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        SQL.AddParam("@search", "%" & SearchBar.Text & "%")
        LoadGrid("Select * FROM RoomTable WHERE Room_ID LIKE @search OR Room_Number LIKE @search " &
                 "OR Room_Type LIKE @search OR Room_Status LIKE @search;")
    End Sub

    Private Sub CurrentForm_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If RoomTypecb.Text = "" Or RoomNumbertb.Text = "" Then
            Addbtn.Enabled = False
            Deletebtn.Enabled = False
            Editbtn.Enabled = False
        ElseIf RoomIDtb.Text <> "" Then
            Addbtn.Enabled = False
            Deletebtn.Enabled = True
            Editbtn.Enabled = True
        Else
            Addbtn.Enabled = True
        End If
    End Sub

    Private Sub Report_Click(sender As Object, e As EventArgs) Handles Report.Click
        Occupancy.Show()
    End Sub
End Class