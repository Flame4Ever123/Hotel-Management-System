<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.RoomServiceBtn = New FontAwesome.Sharp.IconButton()
        Me.SignOutbtn = New FontAwesome.Sharp.IconButton()
        Me.RecordBtn = New FontAwesome.Sharp.IconButton()
        Me.BillingBtn = New FontAwesome.Sharp.IconButton()
        Me.GuestBtn = New FontAwesome.Sharp.IconButton()
        Me.BookingBtn = New FontAwesome.Sharp.IconButton()
        Me.RoomBtn = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconClose = New FontAwesome.Sharp.IconPictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Userlbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.IconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.RoomServiceBtn)
        Me.PanelMenu.Controls.Add(Me.SignOutbtn)
        Me.PanelMenu.Controls.Add(Me.RecordBtn)
        Me.PanelMenu.Controls.Add(Me.BillingBtn)
        Me.PanelMenu.Controls.Add(Me.GuestBtn)
        Me.PanelMenu.Controls.Add(Me.BookingBtn)
        Me.PanelMenu.Controls.Add(Me.RoomBtn)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(176, 700)
        Me.PanelMenu.TabIndex = 0
        '
        'RoomServiceBtn
        '
        Me.RoomServiceBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoomServiceBtn.FlatAppearance.BorderSize = 0
        Me.RoomServiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomServiceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomServiceBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.RoomServiceBtn.IconChar = FontAwesome.Sharp.IconChar.Burger
        Me.RoomServiceBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.RoomServiceBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RoomServiceBtn.IconSize = 32
        Me.RoomServiceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomServiceBtn.Location = New System.Drawing.Point(0, 453)
        Me.RoomServiceBtn.Name = "RoomServiceBtn"
        Me.RoomServiceBtn.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.RoomServiceBtn.Size = New System.Drawing.Size(176, 65)
        Me.RoomServiceBtn.TabIndex = 7
        Me.RoomServiceBtn.Text = "Room Service"
        Me.RoomServiceBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomServiceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RoomServiceBtn.UseVisualStyleBackColor = True
        '
        'SignOutbtn
        '
        Me.SignOutbtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SignOutbtn.FlatAppearance.BorderSize = 0
        Me.SignOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SignOutbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignOutbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.SignOutbtn.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight
        Me.SignOutbtn.IconColor = System.Drawing.Color.Gainsboro
        Me.SignOutbtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.SignOutbtn.IconSize = 32
        Me.SignOutbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignOutbtn.Location = New System.Drawing.Point(0, 639)
        Me.SignOutbtn.Name = "SignOutbtn"
        Me.SignOutbtn.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.SignOutbtn.Size = New System.Drawing.Size(176, 61)
        Me.SignOutbtn.TabIndex = 6
        Me.SignOutbtn.Text = "Sign Out"
        Me.SignOutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SignOutbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SignOutbtn.UseVisualStyleBackColor = True
        '
        'RecordBtn
        '
        Me.RecordBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RecordBtn.FlatAppearance.BorderSize = 0
        Me.RecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecordBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.RecordBtn.IconChar = FontAwesome.Sharp.IconChar.Book
        Me.RecordBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.RecordBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RecordBtn.IconSize = 32
        Me.RecordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordBtn.Location = New System.Drawing.Point(0, 388)
        Me.RecordBtn.Name = "RecordBtn"
        Me.RecordBtn.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.RecordBtn.Size = New System.Drawing.Size(176, 65)
        Me.RecordBtn.TabIndex = 5
        Me.RecordBtn.Text = "Payment Record"
        Me.RecordBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RecordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RecordBtn.UseVisualStyleBackColor = True
        '
        'BillingBtn
        '
        Me.BillingBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.BillingBtn.FlatAppearance.BorderSize = 0
        Me.BillingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BillingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.BillingBtn.IconChar = FontAwesome.Sharp.IconChar.SackDollar
        Me.BillingBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.BillingBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BillingBtn.IconSize = 32
        Me.BillingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BillingBtn.Location = New System.Drawing.Point(0, 323)
        Me.BillingBtn.Name = "BillingBtn"
        Me.BillingBtn.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.BillingBtn.Size = New System.Drawing.Size(176, 65)
        Me.BillingBtn.TabIndex = 4
        Me.BillingBtn.Text = "Billing"
        Me.BillingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BillingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BillingBtn.UseVisualStyleBackColor = True
        '
        'GuestBtn
        '
        Me.GuestBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GuestBtn.FlatAppearance.BorderSize = 0
        Me.GuestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuestBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.GuestBtn.IconChar = FontAwesome.Sharp.IconChar.Person
        Me.GuestBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.GuestBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.GuestBtn.IconSize = 32
        Me.GuestBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuestBtn.Location = New System.Drawing.Point(0, 258)
        Me.GuestBtn.Name = "GuestBtn"
        Me.GuestBtn.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.GuestBtn.Size = New System.Drawing.Size(176, 65)
        Me.GuestBtn.TabIndex = 3
        Me.GuestBtn.Text = "Guest"
        Me.GuestBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuestBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.GuestBtn.UseVisualStyleBackColor = True
        '
        'BookingBtn
        '
        Me.BookingBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.BookingBtn.FlatAppearance.BorderSize = 0
        Me.BookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.BookingBtn.IconChar = FontAwesome.Sharp.IconChar.DoorClosed
        Me.BookingBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.BookingBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BookingBtn.IconSize = 32
        Me.BookingBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookingBtn.Location = New System.Drawing.Point(0, 193)
        Me.BookingBtn.Name = "BookingBtn"
        Me.BookingBtn.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.BookingBtn.Size = New System.Drawing.Size(176, 65)
        Me.BookingBtn.TabIndex = 2
        Me.BookingBtn.Text = "Reservation"
        Me.BookingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BookingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BookingBtn.UseVisualStyleBackColor = True
        '
        'RoomBtn
        '
        Me.RoomBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RoomBtn.FlatAppearance.BorderSize = 0
        Me.RoomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RoomBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomBtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.RoomBtn.IconChar = FontAwesome.Sharp.IconChar.Bed
        Me.RoomBtn.IconColor = System.Drawing.Color.Gainsboro
        Me.RoomBtn.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.RoomBtn.IconSize = 32
        Me.RoomBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomBtn.Location = New System.Drawing.Point(0, 128)
        Me.RoomBtn.Name = "RoomBtn"
        Me.RoomBtn.Padding = New System.Windows.Forms.Padding(10, 0, 15, 0)
        Me.RoomBtn.Size = New System.Drawing.Size(176, 65)
        Me.RoomBtn.TabIndex = 1
        Me.RoomBtn.Text = "Room"
        Me.RoomBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RoomBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RoomBtn.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.PictureBox1)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(176, 128)
        Me.PanelLogo.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.IconClose)
        Me.Panel1.Controls.Add(Me.lblFormTitle)
        Me.Panel1.Controls.Add(Me.IconCurrentForm)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(176, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1024, 70)
        Me.Panel1.TabIndex = 0
        '
        'IconClose
        '
        Me.IconClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconClose.IconChar = FontAwesome.Sharp.IconChar.Multiply
        Me.IconClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IconClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconClose.Location = New System.Drawing.Point(967, 18)
        Me.IconClose.Name = "IconClose"
        Me.IconClose.Size = New System.Drawing.Size(32, 32)
        Me.IconClose.TabIndex = 1
        Me.IconClose.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(84, 18)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(114, 39)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Home"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.Color.Gainsboro
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 40
        Me.IconCurrentForm.Location = New System.Drawing.Point(38, 17)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(40, 40)
        Me.IconCurrentForm.TabIndex = 1
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.Label3)
        Me.PanelDesktop.Controls.Add(Me.Userlbl)
        Me.PanelDesktop.Controls.Add(Me.Label1)
        Me.PanelDesktop.Controls.Add(Me.PictureBox2)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(176, 70)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1024, 630)
        Me.PanelDesktop.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(243, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(604, 55)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Hotel Management System"
        '
        'Userlbl
        '
        Me.Userlbl.AutoSize = True
        Me.Userlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Userlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.Userlbl.Location = New System.Drawing.Point(543, 408)
        Me.Userlbl.Name = "Userlbl"
        Me.Userlbl.Size = New System.Drawing.Size(91, 39)
        Me.Userlbl.TabIndex = 4
        Me.Userlbl.Text = "User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(379, 408)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome, "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(319, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(438, 245)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.IconClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents RoomBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents RecordBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents BillingBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents GuestBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents BookingBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SignOutbtn As FontAwesome.Sharp.IconButton
    Friend WithEvents RoomServiceBtn As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Userlbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
