<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.BookingIDtb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BookingStatustb = New System.Windows.Forms.TextBox()
        Me.BookingDatetb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Checkindtp = New System.Windows.Forms.DateTimePicker()
        Me.Checkoutdtp = New System.Windows.Forms.DateTimePicker()
        Me.Guestcb = New System.Windows.Forms.ComboBox()
        Me.Roomcb = New System.Windows.Forms.ComboBox()
        Me.Bookingdgv = New System.Windows.Forms.DataGridView()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.IconSearch = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.Bookingdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingIDtb
        '
        Me.BookingIDtb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingIDtb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BookingIDtb.Location = New System.Drawing.Point(147, 60)
        Me.BookingIDtb.Name = "BookingIDtb"
        Me.BookingIDtb.ReadOnly = True
        Me.BookingIDtb.Size = New System.Drawing.Size(194, 29)
        Me.BookingIDtb.TabIndex = 87
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(37, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 22)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Booking ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(60, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Guest ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(8, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 22)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Room Number"
        '
        'BookingStatustb
        '
        Me.BookingStatustb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingStatustb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BookingStatustb.Location = New System.Drawing.Point(147, 468)
        Me.BookingStatustb.Name = "BookingStatustb"
        Me.BookingStatustb.ReadOnly = True
        Me.BookingStatustb.Size = New System.Drawing.Size(194, 29)
        Me.BookingStatustb.TabIndex = 91
        '
        'BookingDatetb
        '
        Me.BookingDatetb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingDatetb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BookingDatetb.Location = New System.Drawing.Point(147, 402)
        Me.BookingDatetb.Name = "BookingDatetb"
        Me.BookingDatetb.ReadOnly = True
        Me.BookingDatetb.Size = New System.Drawing.Size(194, 29)
        Me.BookingDatetb.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(78, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 22)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(17, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 22)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Booking Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(61, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 22)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Check In"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(46, 342)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 22)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Check Out"
        '
        'Checkindtp
        '
        Me.Checkindtp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkindtp.Location = New System.Drawing.Point(147, 273)
        Me.Checkindtp.Name = "Checkindtp"
        Me.Checkindtp.Size = New System.Drawing.Size(247, 25)
        Me.Checkindtp.TabIndex = 97
        Me.Checkindtp.Value = New Date(2022, 7, 4, 12, 53, 24, 0)
        '
        'Checkoutdtp
        '
        Me.Checkoutdtp.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkoutdtp.Location = New System.Drawing.Point(147, 339)
        Me.Checkoutdtp.Name = "Checkoutdtp"
        Me.Checkoutdtp.Size = New System.Drawing.Size(247, 25)
        Me.Checkoutdtp.TabIndex = 98
        Me.Checkoutdtp.Value = New Date(2022, 7, 4, 12, 53, 33, 0)
        '
        'Guestcb
        '
        Me.Guestcb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guestcb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Guestcb.FormattingEnabled = True
        Me.Guestcb.Location = New System.Drawing.Point(147, 131)
        Me.Guestcb.Name = "Guestcb"
        Me.Guestcb.Size = New System.Drawing.Size(194, 30)
        Me.Guestcb.TabIndex = 99
        '
        'Roomcb
        '
        Me.Roomcb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Roomcb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Roomcb.FormattingEnabled = True
        Me.Roomcb.Location = New System.Drawing.Point(147, 204)
        Me.Roomcb.Name = "Roomcb"
        Me.Roomcb.Size = New System.Drawing.Size(194, 30)
        Me.Roomcb.TabIndex = 100
        '
        'Bookingdgv
        '
        Me.Bookingdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Bookingdgv.Location = New System.Drawing.Point(400, 60)
        Me.Bookingdgv.Name = "Bookingdgv"
        Me.Bookingdgv.Size = New System.Drawing.Size(600, 550)
        Me.Bookingdgv.TabIndex = 101
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.DimGray
        Me.Clearbtn.FlatAppearance.BorderSize = 0
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Clearbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Clearbtn.Location = New System.Drawing.Point(252, 539)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(99, 35)
        Me.Clearbtn.TabIndex = 103
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.DimGray
        Me.Addbtn.FlatAppearance.BorderSize = 0
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Addbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Addbtn.Location = New System.Drawing.Point(40, 539)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(99, 35)
        Me.Addbtn.TabIndex = 102
        Me.Addbtn.Text = "Book"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'SearchBar
        '
        Me.SearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBar.Location = New System.Drawing.Point(798, 24)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(172, 20)
        Me.SearchBar.TabIndex = 105
        '
        'IconSearch
        '
        Me.IconSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconSearch.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconSearch.IconColor = System.Drawing.Color.Gainsboro
        Me.IconSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSearch.IconSize = 25
        Me.IconSearch.Location = New System.Drawing.Point(976, 24)
        Me.IconSearch.Name = "IconSearch"
        Me.IconSearch.Size = New System.Drawing.Size(25, 25)
        Me.IconSearch.TabIndex = 127
        Me.IconSearch.TabStop = False
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.IconSearch)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Bookingdgv)
        Me.Controls.Add(Me.Roomcb)
        Me.Controls.Add(Me.Guestcb)
        Me.Controls.Add(Me.Checkoutdtp)
        Me.Controls.Add(Me.Checkindtp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BookingDatetb)
        Me.Controls.Add(Me.BookingStatustb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BookingIDtb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Booking"
        Me.Text = "Booking"
        CType(Me.Bookingdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BookingIDtb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BookingStatustb As TextBox
    Friend WithEvents BookingDatetb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Checkindtp As DateTimePicker
    Friend WithEvents Checkoutdtp As DateTimePicker
    Friend WithEvents Guestcb As ComboBox
    Friend WithEvents Roomcb As ComboBox
    Friend WithEvents Bookingdgv As DataGridView
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Addbtn As Button
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
End Class
