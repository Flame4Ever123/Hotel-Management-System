Public Class PaymentInfo
    Public SQL As New SQL_Connection

    Dim g, mg As Graphics
    Dim bmp As Bitmap

    Public BillingID As String
    Public PaymentID As String

    Private Sub PaymentInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL.AddParam("@id", "%" & BillingID & "%")
        SQL.ExecQuery("SELECT * FROM BillingTable WHERE Billing_ID LIKE @id")

        SQL.AddParam("@id", "%" & SQL.DBDT.Rows(0).Item(1).ToString() & "%")
        SQL.ExecQuery("SELECT * FROM GuestTable WHERE Guest_ID LIKE @id")

        GuestIDlbl.Text = SQL.DBDT.Rows(0).Item(0).ToString()
        Namelbl.Text = SQL.DBDT.Rows(0).Item(1).ToString()

        SQL.AddParam("@id", "%" & PaymentID & "%")
        SQL.ExecQuery("SELECT * FROM PaymentTable WHERE Payment_ID LIKE @id")
        PayAmountlbl.Text = SQL.DBDT.Rows(0).Item(4).ToString()
        PaymentIDlbl.Text = SQL.DBDT.Rows(0).Item(0).ToString()
        Datelbl.Text = SQL.DBDT.Rows(0).Item(2).ToString()
        PayMethodlbl.Text = SQL.DBDT.Rows(0).Item(3).ToString()

        Dim method As String
        If SQL.DBDT.Rows(0).Item(5) = 1 Then
            method = "Deposit"
        Else
            method = "Lump Sum"
        End If
        Infolbl.Text = method

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub IconClose_Click(sender As Object, e As EventArgs) Handles IconClose.Click
        Me.Close()
    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", 420, 460)
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