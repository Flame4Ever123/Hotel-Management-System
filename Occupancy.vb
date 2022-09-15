Public Class Occupancy
    Public SQL As New SQL_Connection

    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub Occupancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As String

        SQL.ExecQuery("SELECT * FROM RoomTable WHERE Room_Status = 'Available'")
        availablelbl.Text = SQL.DBDT.Rows.Count
        For i = 0 To (SQL.DBDT.Rows.Count - 1)
            x = SQL.DBDT.Rows(i).Item(1).ToString() + Space(13)

            x = x + SQL.DBDT.Rows(i).Item(2).ToString() + Space((17 - Len(SQL.DBDT.Rows(i).Item(2).ToString())))

            x = x + SQL.DBDT.Rows(i).Item(3).ToString()

            ListBox1.Items.Add(x)
        Next

        SQL.ExecQuery("SELECT * FROM RoomTable WHERE Room_Status = 'Booked'")
        occupiedlbl.Text = SQL.DBDT.Rows.Count
        For i = 0 To (SQL.DBDT.Rows.Count - 1)
            x = SQL.DBDT.Rows(i).Item(1).ToString() + Space(13)

            x = x + SQL.DBDT.Rows(i).Item(2).ToString() + Space((17 - Len(SQL.DBDT.Rows(i).Item(2).ToString())))

            x = x + SQL.DBDT.Rows(i).Item(3).ToString()

            ListBox1.Items.Add(x)
        Next

        totallbl.Text = Convert.ToInt32(availablelbl.Text) + Convert.ToInt32(occupiedlbl.Text)
        ratelbl.Text = Format((occupiedlbl.Text / totallbl.Text) * 100, "0.00").ToString + "%"


    End Sub

    Private Sub IconClose_Click(sender As Object, e As EventArgs) Handles IconClose.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", 370, 700)
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