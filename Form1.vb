Imports FontAwesome.Sharp


Public Class Form1
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private Currentchildform As Form

    Public AddCon As Integer

    Public Sub New() 
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DeactivateButton()

            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()

            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    Private Sub DeactivateButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        If Currentchildform IsNot Nothing Then
            Currentchildform.Close()
        End If
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    Private Sub RoomBtn_Click(sender As Object, e As EventArgs) Handles RoomBtn.Click
        ActivateButton(sender, Color.LightCyan)
        OpenChildForm(New Room)
    End Sub

    Private Sub BookingBtn_Click(sender As Object, e As EventArgs) Handles BookingBtn.Click
        ActivateButton(sender, Color.LightCyan)
        OpenChildForm(New Booking)
    End Sub

    Private Sub GuestBtn_Click(sender As Object, e As EventArgs) Handles GuestBtn.Click
        ActivateButton(sender, Color.LightCyan)
        OpenChildForm(New Guest)
    End Sub

    Private Sub BillingBtn_Click(sender As Object, e As EventArgs) Handles BillingBtn.Click
        ActivateButton(sender, Color.LightCyan)
        OpenChildForm(New Billing)
    End Sub

    Private Sub RecordBtn_Click(sender As Object, e As EventArgs) Handles RecordBtn.Click
        ActivateButton(sender, Color.LightCyan)
        OpenChildForm(New Record)
    End Sub

    Private Sub IconClose_Click(sender As Object, e As EventArgs) Handles IconClose.Click
        Me.Close()
    End Sub

    Private Sub RoomServiceBtn_Click(sender As Object, e As EventArgs) Handles RoomServiceBtn.Click
        ActivateButton(sender, Color.LightCyan)
        OpenChildForm(New RoomService)
    End Sub

    Private Sub SignOutbtn_Click(sender As Object, e As EventArgs) Handles SignOutbtn.Click
        Login.Show()
        Me.Close()
    End Sub

    Dim Pos As Point
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += Control.MousePosition - Pos
        End If
        Pos = Control.MousePosition
    End Sub


End Class

