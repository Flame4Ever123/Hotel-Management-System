Public Class Staff
    Public SQL As New SQL_Connection

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("Select * FROM StaffTable;")
        Else
            SQL.ExecQuery(Query)
        End If
        'Error Handling
        If SQL.HasException(True) Then Exit Sub
        Staffdgv.DataSource = SQL.DBDT
    End Sub

    Public Sub FindItem()
        SQL.AddParam("@item", "%" & SearchBar.Text & "%")
        LoadGrid("SELECT * FROM StaffTable WHERE Staff_ID LIKE @item OR Staff_Name LIKE @item")
    End Sub

    Private Function StaffStatus()
        If Privilegecb.Text = "System Admin" Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Private Sub InsertStaff()
        Dim Staff_Status As Integer
        Staff_Status = StaffStatus()


        SQL.AddParam("@name", StaffNametb.Text)
        SQL.AddParam("@password", StaffPasswordtb.Text)
        SQL.AddParam("@staffstatus", Staff_Status)


        SQL.ExecQuery("INSERT INTO StaffTable (Staff_Name, Password, Is_Admin)" &
                      "VALUES (@name, @password, @staffstatus);")

        If SQL.HasException(True) Then Exit Sub
        MsgBox("Staff Added Successfully!")
    End Sub

    Private Sub UpdateStaff()
        Dim Staff_Status As Integer
        Staff_Status = StaffStatus()
        SQL.AddParam("@id", StaffIDtb.Text)
        SQL.AddParam("@name", StaffNametb.Text)
        SQL.AddParam("@password", StaffPasswordtb.Text)
        SQL.AddParam("@staffstatus", Staff_Status)

        SQL.ExecQuery("UPDATE StaffTable " &
                      "SET Staff_Name = @name, Password = @password, Is_Admin = @staffstatus " &
                      "WHERE Staff_ID LIKE @id;")

    End Sub

    Private Sub DeleteStaff()
        SQL.AddParam("@id", StaffIDtb.Text)
        SQL.ExecQuery("DELETE FROM StaffTable WHERE Staff_ID LIKE @id")
    End Sub

    Private Sub ClearFields()
        StaffIDtb.Clear()
        StaffNametb.Clear()
        StaffPasswordtb.Clear()
        Privilegecb.SelectedIndex = -1
    End Sub

    Private Sub ManageStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles Addbtn.Click
        InsertStaff()
        LoadGrid()
        ClearFields()
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        UpdateStaff()
        LoadGrid()
        ClearFields()
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        DeleteStaff()
        LoadGrid()
        ClearFields()
    End Sub

    Private Sub Staffdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Staffdgv.CellMouseClick

        With Staffdgv
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow

                row = Me.Staffdgv.Rows(e.RowIndex)

                StaffIDtb.Text = row.Cells("Staff_ID").Value.ToString
                StaffNametb.Text = row.Cells("Staff_Name").Value.ToString
                StaffPasswordtb.Text = row.Cells("Password").Value.ToString


                If row.Cells("Is_Admin").Value Then
                    Privilegecb.Text = "System Admin"
                Else
                    Privilegecb.Text = "System User"
                End If

            End If
        End With
    End Sub


    Private Sub Clearbtn_Click(sender As Object, e As EventArgs) Handles Clearbtn.Click
        ClearFields()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs)
        FindItem()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub IconClose_Click(sender As Object, e As EventArgs) Handles IconClose.Click
        Me.Close()
    End Sub
    Private Sub SearchBar_TextChanged(sender As Object, e As EventArgs) Handles SearchBar.TextChanged
        SQL.AddParam("@search", "%" & SearchBar.Text & "%")
        LoadGrid("Select * FROM StaffTable WHERE Staff_Name LIKE @search")
    End Sub
End Class