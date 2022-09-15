<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing
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
        Me.IconSearch = New FontAwesome.Sharp.IconPictureBox()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Receiptbtn = New System.Windows.Forms.Button()
        Me.Invoicebtn = New System.Windows.Forms.Button()
        Me.Billingdgv = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Totallbl = New System.Windows.Forms.Label()
        Me.Statuslbl = New System.Windows.Forms.Label()
        Me.Outstandinglbl = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.GuestIDlbl = New System.Windows.Forms.Label()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BookingIDlbl = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billingdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconSearch
        '
        Me.IconSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconSearch.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconSearch.IconColor = System.Drawing.Color.Gainsboro
        Me.IconSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSearch.IconSize = 25
        Me.IconSearch.Location = New System.Drawing.Point(975, 25)
        Me.IconSearch.Name = "IconSearch"
        Me.IconSearch.Size = New System.Drawing.Size(25, 25)
        Me.IconSearch.TabIndex = 126
        Me.IconSearch.TabStop = False
        '
        'SearchBar
        '
        Me.SearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBar.Location = New System.Drawing.Point(797, 25)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(172, 20)
        Me.SearchBar.TabIndex = 125
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.DimGray
        Me.Clearbtn.Enabled = False
        Me.Clearbtn.FlatAppearance.BorderSize = 0
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Clearbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Clearbtn.Location = New System.Drawing.Point(35, 571)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(137, 35)
        Me.Clearbtn.TabIndex = 124
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Receiptbtn
        '
        Me.Receiptbtn.BackColor = System.Drawing.Color.DimGray
        Me.Receiptbtn.Enabled = False
        Me.Receiptbtn.FlatAppearance.BorderSize = 0
        Me.Receiptbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Receiptbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Receiptbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Receiptbtn.Location = New System.Drawing.Point(206, 489)
        Me.Receiptbtn.Name = "Receiptbtn"
        Me.Receiptbtn.Size = New System.Drawing.Size(137, 35)
        Me.Receiptbtn.TabIndex = 123
        Me.Receiptbtn.Text = "Receipt"
        Me.Receiptbtn.UseVisualStyleBackColor = False
        '
        'Invoicebtn
        '
        Me.Invoicebtn.BackColor = System.Drawing.Color.DimGray
        Me.Invoicebtn.Enabled = False
        Me.Invoicebtn.FlatAppearance.BorderSize = 0
        Me.Invoicebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Invoicebtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Invoicebtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Invoicebtn.Location = New System.Drawing.Point(35, 489)
        Me.Invoicebtn.Name = "Invoicebtn"
        Me.Invoicebtn.Size = New System.Drawing.Size(137, 35)
        Me.Invoicebtn.TabIndex = 122
        Me.Invoicebtn.Text = "Invoice"
        Me.Invoicebtn.UseVisualStyleBackColor = False
        '
        'Billingdgv
        '
        Me.Billingdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Billingdgv.Location = New System.Drawing.Point(400, 60)
        Me.Billingdgv.Name = "Billingdgv"
        Me.Billingdgv.Size = New System.Drawing.Size(600, 550)
        Me.Billingdgv.TabIndex = 121
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(30, 345)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 26)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(30, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 26)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(30, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 26)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "Outstanding"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(30, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 26)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "Billing Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(30, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 26)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Guest ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(30, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 26)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Billing ID"
        '
        'Totallbl
        '
        Me.Totallbl.AutoSize = True
        Me.Totallbl.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totallbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.Totallbl.Location = New System.Drawing.Point(214, 348)
        Me.Totallbl.Name = "Totallbl"
        Me.Totallbl.Size = New System.Drawing.Size(18, 26)
        Me.Totallbl.TabIndex = 132
        Me.Totallbl.Text = " "
        '
        'Statuslbl
        '
        Me.Statuslbl.AutoSize = True
        Me.Statuslbl.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.Statuslbl.Location = New System.Drawing.Point(174, 284)
        Me.Statuslbl.Name = "Statuslbl"
        Me.Statuslbl.Size = New System.Drawing.Size(18, 26)
        Me.Statuslbl.TabIndex = 131
        Me.Statuslbl.Text = " "
        '
        'Outstandinglbl
        '
        Me.Outstandinglbl.AutoSize = True
        Me.Outstandinglbl.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Outstandinglbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.Outstandinglbl.Location = New System.Drawing.Point(214, 414)
        Me.Outstandinglbl.Name = "Outstandinglbl"
        Me.Outstandinglbl.Size = New System.Drawing.Size(18, 26)
        Me.Outstandinglbl.TabIndex = 130
        Me.Outstandinglbl.Text = " "
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.Datelbl.Location = New System.Drawing.Point(170, 113)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(18, 26)
        Me.Datelbl.TabIndex = 129
        Me.Datelbl.Text = " "
        '
        'GuestIDlbl
        '
        Me.GuestIDlbl.AutoSize = True
        Me.GuestIDlbl.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestIDlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.GuestIDlbl.Location = New System.Drawing.Point(172, 172)
        Me.GuestIDlbl.Name = "GuestIDlbl"
        Me.GuestIDlbl.Size = New System.Drawing.Size(18, 26)
        Me.GuestIDlbl.TabIndex = 128
        Me.GuestIDlbl.Text = " "
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.IDlbl.Location = New System.Drawing.Point(174, 54)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(18, 26)
        Me.IDlbl.TabIndex = 127
        Me.IDlbl.Text = " "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(151, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 26)
        Me.Label13.TabIndex = 133
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(153, 172)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(17, 26)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label15.Location = New System.Drawing.Point(155, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 26)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label16.Location = New System.Drawing.Point(151, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(17, 26)
        Me.Label16.TabIndex = 136
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label17.Location = New System.Drawing.Point(155, 284)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 26)
        Me.Label17.TabIndex = 137
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label18.Location = New System.Drawing.Point(153, 411)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(17, 26)
        Me.Label18.TabIndex = 138
        Me.Label18.Text = ":"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label19.Location = New System.Drawing.Point(170, 347)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 26)
        Me.Label19.TabIndex = 139
        Me.Label19.Text = "RM"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label20.Location = New System.Drawing.Point(171, 413)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 26)
        Me.Label20.TabIndex = 140
        Me.Label20.Text = "RM"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(153, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 26)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = ":"
        '
        'BookingIDlbl
        '
        Me.BookingIDlbl.AutoSize = True
        Me.BookingIDlbl.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookingIDlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.BookingIDlbl.Location = New System.Drawing.Point(172, 228)
        Me.BookingIDlbl.Name = "BookingIDlbl"
        Me.BookingIDlbl.Size = New System.Drawing.Size(18, 26)
        Me.BookingIDlbl.TabIndex = 142
        Me.BookingIDlbl.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label9.Location = New System.Drawing.Point(30, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 26)
        Me.Label9.TabIndex = 141
        Me.Label9.Text = "Booking ID"
        '
        'Billing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BookingIDlbl)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Totallbl)
        Me.Controls.Add(Me.Outstandinglbl)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Statuslbl)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.GuestIDlbl)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.IconSearch)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Receiptbtn)
        Me.Controls.Add(Me.Invoicebtn)
        Me.Controls.Add(Me.Billingdgv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Billing"
        Me.Text = "Billing"
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billingdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Receiptbtn As Button
    Friend WithEvents Invoicebtn As Button
    Friend WithEvents Billingdgv As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Totallbl As Label
    Friend WithEvents Statuslbl As Label
    Friend WithEvents Outstandinglbl As Label
    Friend WithEvents Datelbl As Label
    Friend WithEvents GuestIDlbl As Label
    Friend WithEvents IDlbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BookingIDlbl As Label
    Friend WithEvents Label9 As Label
End Class
