Public Class TransactionReport
    Public SQL As New SQL_Connection
    Dim i As Integer
    Dim payment As Double

    Dim g, mg As Graphics
    Dim bmp As Bitmap
    Private Sub IconClose_Click(sender As Object, e As EventArgs) Handles IconClose.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "January" Then
            i = 1
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "February" Then
            i = 2
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "March" Then
            i = 3
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "April" Then
            i = 4
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "May" Then
            i = 5
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "June" Then
            i = 6
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "July" Then
            i = 7
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "August" Then
            i = 8
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "September" Then
            i = 9
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "October" Then
            i = 10
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "November" Then
            i = 11
            LoadGrid()
        ElseIf ComboBox1.SelectedItem = "December" Then
            i = 12
            LoadGrid()
        Else
            i = 0
        End If

        SQL.ExecQuery("SELECT * FROM PaymentTable")

        For x = 0 To (SQL.DBDT.Rows.Count - 1)
            If Month(SQL.DBDT.Rows(x).Item(2)) = i Then
                payment = payment + SQL.DBDT.Rows(x).Item(4)
            End If
        Next
    End Sub

    Public Sub LoadGrid(Optional Query As String = "")
        Dim x As String
        Dim total As Double
        ListBox1.Items.Clear()

        SQL.ExecQuery("SELECT * FROM PaymentTable")
        For j = 0 To (SQL.DBDT.Rows.Count - 1)
            Dim date1 As Date
            date1 = SQL.DBDT.Rows(j).Item(2).ToString()

            If Month(date1) = i Then
                x = date1.Date + Space(15 - Len(date1.Date))

                x = x + SQL.DBDT.Rows(j).Item(4).ToString() + Space(17 - Len(SQL.DBDT.Rows(j).Item(4).ToString()))
                total = total + SQL.DBDT.Rows(j).Item(4)
                x = x + SQL.DBDT.Rows(j).Item(3).ToString()
                ListBox1.Items.Add(x)
            End If
        Next

        totallbl.Text = ListBox1.Items.Count
        totalamountlbl.Text = Format((total), "0.00")

        If totallbl.Text = 0 Then
            averagelbl.Text = Format((0), "0.00")
        Else
            averagelbl.Text = Format((total / totallbl.Text), "0.00")
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub Printbtn_Click(sender As Object, e As EventArgs) Handles Printbtn.Click
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", 450, 700)
        g = CreateGraphics()
        bmp = New Bitmap(Size.Width, Size.Height, g)
        mg = Graphics.FromImage(bmp)
        mg.CopyFromScreen(Location.X, Location.Y, 0, 0, Size)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Dim Pos As Point

    Private Sub TransactionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


End Class