Public Class Login
    Public SQL As New SQL_Connection

    Public Sub LoadGrid(Optional Query As String = "")
        If Query = "" Then
            SQL.ExecQuery("Select * FROM GuestTable;")
        Else
            SQL.ExecQuery(Query)
        End If
        'Error Handling
        If SQL.HasException(True) Then Exit Sub
    End Sub

    Private Sub SignInbtn_Click(sender As Object, e As EventArgs) Handles SignInbtn.Click
        SQL.AddParam("@name", Nametb.Text)
        SQL.AddParam("@password", Passwordtb.Text)

        LoadGrid("SELECT * FROM StaffTable WHERE Staff_Name LIKE @name AND Password LIKE @password")
        If SQL.DBDT.Rows.Count = 0 Then
            MsgBox("Invalid username or password")
        ElseIf SQL.DBDT.Rows.Count = 1 Then
            If SQL.DBDT.Rows(0).Item(3) = 1 Then
                Staff.Show()
                Me.Hide()
            Else
                Form1.Show()
                Form1.Userlbl.Text = Nametb.Text
                Me.Hide()
            End If
        Else
            MsgBox("More than one identical username and password")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Passwordtb.PasswordChar = "*"
        Else
            Passwordtb.PasswordChar = ""
        End If
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub

    Private Sub IconClose_Click(sender As Object, e As EventArgs) Handles IconClose.Click
        Me.Close()
    End Sub
End Class