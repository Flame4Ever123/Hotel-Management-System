Public Class Guest
    Public SQL As New SQL_Connection

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("Select * FROM GuestTable;")
        Else
            SQL.ExecQuery(Query)
        End If
        'Error Handling
        If SQL.HasException(True) Then Exit Sub
        Guestdgv.DataSource = SQL.DBDT
    End Sub


    Public Sub FindItem()
        SQL.AddParam("@item", "%" & SearchBar.Text & "%")
        LoadGrid("SELECT * FROM GuestTable WHERE Guest_ID LIKE @item OR Guest_Name LIKE @item 
                    OR Guest_Gender = @item OR Guest_Phone LIKE @item OR Guest_Email LIKE @item
                    OR Guest_Address LIKE @item OR Guest_Passport_IC LIKE @item")
    End Sub

    Private Sub InsertGuest()
        SQL.AddParam("@name", GuestNametb.Text)
        SQL.AddParam("@gender", GuestGendercb.Text)
        SQL.AddParam("@phone", GuestPhonetb.Text)
        SQL.AddParam("@email", GuestEmailtb.Text)
        SQL.AddParam("@passport", PassportICtb.Text)
        SQL.AddParam("@address1", GuestAddress1.Text)
        SQL.AddParam("@address2", GuestAddress2.Text)
        SQL.AddParam("@address3", GuestAddress3.Text)

        SQL.ExecQuery("INSERT INTO GuestTable " &
                      "(Guest_Name, Guest_Passport_IC, Guest_Gender, Guest_Phone, Guest_Email, " &
                      "Guest_Address1, Guest_Address2, Guest_Address3)" &
                      "VALUES (@name, @passport, @gender, @phone, @email, @address1, @address2, @address3);")

        If SQL.HasException(True) Then Exit Sub
        MsgBox("User Added Successfully!")
    End Sub

    Private Sub UpdateGuest()
        SQL.AddParam("@id", GuestIDtb.Text)
        SQL.AddParam("@name", GuestNametb.Text)
        SQL.AddParam("@gender", GuestGendercb.Text)
        SQL.AddParam("@phone", GuestPhonetb.Text)
        SQL.AddParam("@email", GuestEmailtb.Text)
        SQL.AddParam("@passport", PassportICtb.Text)
        SQL.AddParam("@address1", GuestAddress1.Text)
        SQL.AddParam("@address2", GuestAddress2.Text)
        SQL.AddParam("@address3", GuestAddress3.Text)

        SQL.ExecQuery("UPDATE GuestTable " &
                      "SET Guest_Name = @name, Guest_Gender = @gender, " &
                      "Guest_Phone = @phone, Guest_Email = @email, Guest_Passport_IC = @passport, " &
                      "Guest_Address1 = @address1, Guest_Address2 = @address2, Guest_Address3 = @address3 " &
                      "WHERE Guest_ID LIKE @id;")
    End Sub

    Private Sub DeleteGuest()
        SQL.AddParam("@id", GuestIDtb.Text)
        SQL.ExecQuery("DELETE FROM GuestTable WHERE Guest_ID LIKE @id")
    End Sub

    Private Sub ClearFields()
        GuestIDtb.Clear()
        GuestNametb.Clear()
        GuestGendercb.SelectedIndex = -1
        PassportICtb.Clear()
        GuestPhonetb.Clear()
        GuestEmailtb.Clear()
        GuestAddress1.Clear()
        GuestAddress2.Clear()
        GuestAddress3.Clear()
    End Sub

    Private Sub Guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        InsertGuest()
        LoadGrid()
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        UpdateGuest()
        LoadGrid()
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        DeleteGuest()
        LoadGrid()
    End Sub

    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        ClearFields()
    End Sub

    Private Sub Guestdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Guestdgv.CellMouseClick
        With Guestdgv
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.Guestdgv.Rows(e.RowIndex)

                GuestIDtb.Text = row.Cells("Guest_ID").Value.ToString
                GuestNametb.Text = row.Cells("Guest_Name").Value.ToString
                PassportICtb.Text = row.Cells("Guest_Passport_IC").Value.ToString
                GuestGendercb.Text = row.Cells("Guest_Gender").Value.ToString
                GuestEmailtb.Text = row.Cells("Guest_Email").Value.ToString
                GuestPhonetb.Text = row.Cells("Guest_Phone").Value.ToString
                GuestAddress1.Text = row.Cells("Guest_Address1").Value.ToString
                GuestAddress2.Text = row.Cells("Guest_Address2").Value.ToString
                GuestAddress3.Text = row.Cells("Guest_Address3").Value.ToString
            End If
        End With
    End Sub

    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        SQL.AddParam("@search", "%" & SearchBar.Text & "%")
        LoadGrid("Select * FROM GuestTable WHERE Guest_Name LIKE @search OR Guest_Passport_IC LIKE @search " &
                 "OR Guest_Email LIKE @search OR Guest_Phone LIKE @search;")
    End Sub
    Private Sub CurrentForm_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        If GuestNametb.Text = "" Or GuestAddress1.Text = "" Or
            PassportICtb.Text = "" Or GuestPhonetb.Text = "" Or
            GuestEmailtb.Text = "" Or GuestGendercb.Text = "" Then
            Addbtn.Enabled = False
            Deletebtn.Enabled = False
            Editbtn.Enabled = False
        ElseIf GuestIDtb.Text <> "" And GuestNametb.Text <> "" Then
            Addbtn.Enabled = False
            Deletebtn.Enabled = True
            Editbtn.Enabled = True
        Else
            Addbtn.Enabled = True
        End If
    End Sub
End Class