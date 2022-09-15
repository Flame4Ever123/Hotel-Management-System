<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Invoice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Me.Printbtn = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Balancelbl = New System.Windows.Forms.Label()
        Me.Depositlbl = New System.Windows.Forms.Label()
        Me.Taxlbl = New System.Windows.Forms.Label()
        Me.Totallbl = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.SubTotallb = New System.Windows.Forms.ListBox()
        Me.Pricelb = New System.Windows.Forms.ListBox()
        Me.Quantitylb = New System.Windows.Forms.ListBox()
        Me.Itemlb = New System.Windows.Forms.ListBox()
        Me.Nolb = New System.Windows.Forms.ListBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.CheckOutlbl = New System.Windows.Forms.Label()
        Me.CheckInlbl = New System.Windows.Forms.Label()
        Me.IssueDatelbl = New System.Windows.Forms.Label()
        Me.BookingNolbl = New System.Windows.Forms.Label()
        Me.InvoiceNolbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Phonelbl = New System.Windows.Forms.Label()
        Me.Emaillbl = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddLine3lbl = New System.Windows.Forms.Label()
        Me.AddLine2lbl = New System.Windows.Forms.Label()
        Me.AddLine1lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TotalTaxlbl = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Cancelbtn = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Printbtn
        '
        Me.Printbtn.Location = New System.Drawing.Point(311, 673)
        Me.Printbtn.Name = "Printbtn"
        Me.Printbtn.Size = New System.Drawing.Size(106, 36)
        Me.Printbtn.TabIndex = 94
        Me.Printbtn.Text = "Print Invoice"
        Me.Printbtn.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(-67, 650)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(805, 13)
        Me.Label32.TabIndex = 93
        Me.Label32.Text = "_________________________________________________________________________________" &
    "____________________________________________________"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(152, 673)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 36)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Make Payment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Balancelbl
        '
        Me.Balancelbl.AutoSize = True
        Me.Balancelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balancelbl.Location = New System.Drawing.Point(595, 632)
        Me.Balancelbl.Name = "Balancelbl"
        Me.Balancelbl.Size = New System.Drawing.Size(96, 15)
        Me.Balancelbl.TabIndex = 91
        Me.Balancelbl.Text = "Client's Email"
        '
        'Depositlbl
        '
        Me.Depositlbl.AutoSize = True
        Me.Depositlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Depositlbl.Location = New System.Drawing.Point(595, 612)
        Me.Depositlbl.Name = "Depositlbl"
        Me.Depositlbl.Size = New System.Drawing.Size(96, 15)
        Me.Depositlbl.TabIndex = 90
        Me.Depositlbl.Text = "Client's Email"
        '
        'Taxlbl
        '
        Me.Taxlbl.AutoSize = True
        Me.Taxlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Taxlbl.Location = New System.Drawing.Point(594, 570)
        Me.Taxlbl.Name = "Taxlbl"
        Me.Taxlbl.Size = New System.Drawing.Size(96, 15)
        Me.Taxlbl.TabIndex = 89
        Me.Taxlbl.Text = "Client's Email"
        '
        'Totallbl
        '
        Me.Totallbl.AutoSize = True
        Me.Totallbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totallbl.Location = New System.Drawing.Point(594, 550)
        Me.Totallbl.Name = "Totallbl"
        Me.Totallbl.Size = New System.Drawing.Size(96, 15)
        Me.Totallbl.TabIndex = 88
        Me.Totallbl.Text = "Client's Email"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(457, 631)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 16)
        Me.Label38.TabIndex = 87
        Me.Label38.Text = "Balance Due"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(457, 611)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(61, 16)
        Me.Label39.TabIndex = 86
        Me.Label39.Text = "Deposit"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(456, 568)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(33, 16)
        Me.Label40.TabIndex = 85
        Me.Label40.Text = "Tax"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(456, 548)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(64, 16)
        Me.Label41.TabIndex = 84
        Me.Label41.Text = "Subtotal"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(-27, 523)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(805, 13)
        Me.Label31.TabIndex = 83
        Me.Label31.Text = "_________________________________________________________________________________" &
    "____________________________________________________"
        '
        'SubTotallb
        '
        Me.SubTotallb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SubTotallb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubTotallb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotallb.FormattingEnabled = True
        Me.SubTotallb.ItemHeight = 16
        Me.SubTotallb.Location = New System.Drawing.Point(603, 283)
        Me.SubTotallb.Name = "SubTotallb"
        Me.SubTotallb.Size = New System.Drawing.Size(83, 224)
        Me.SubTotallb.TabIndex = 82
        '
        'Pricelb
        '
        Me.Pricelb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Pricelb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Pricelb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pricelb.FormattingEnabled = True
        Me.Pricelb.ItemHeight = 16
        Me.Pricelb.Location = New System.Drawing.Point(473, 282)
        Me.Pricelb.Name = "Pricelb"
        Me.Pricelb.Size = New System.Drawing.Size(88, 224)
        Me.Pricelb.TabIndex = 81
        '
        'Quantitylb
        '
        Me.Quantitylb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Quantitylb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Quantitylb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantitylb.FormattingEnabled = True
        Me.Quantitylb.ItemHeight = 16
        Me.Quantitylb.Location = New System.Drawing.Point(354, 283)
        Me.Quantitylb.Name = "Quantitylb"
        Me.Quantitylb.Size = New System.Drawing.Size(88, 224)
        Me.Quantitylb.TabIndex = 80
        '
        'Itemlb
        '
        Me.Itemlb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Itemlb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Itemlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itemlb.FormattingEnabled = True
        Me.Itemlb.ItemHeight = 16
        Me.Itemlb.Location = New System.Drawing.Point(86, 283)
        Me.Itemlb.Name = "Itemlb"
        Me.Itemlb.Size = New System.Drawing.Size(262, 224)
        Me.Itemlb.TabIndex = 79
        '
        'Nolb
        '
        Me.Nolb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Nolb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nolb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nolb.FormattingEnabled = True
        Me.Nolb.ItemHeight = 16
        Me.Nolb.Location = New System.Drawing.Point(22, 282)
        Me.Nolb.Name = "Nolb"
        Me.Nolb.Size = New System.Drawing.Size(41, 224)
        Me.Nolb.TabIndex = 78
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(20, 258)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(15, 16)
        Me.Label30.TabIndex = 77
        Me.Label30.Text = "#"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(600, 258)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 76
        Me.Label29.Text = "Subtotal"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(469, 258)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(74, 16)
        Me.Label28.TabIndex = 75
        Me.Label28.Text = "Unit Price"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(351, 258)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 16)
        Me.Label27.TabIndex = 74
        Me.Label27.Text = "Quantity"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(83, 258)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(36, 16)
        Me.Label26.TabIndex = 73
        Me.Label26.Text = "Item"
        '
        'CheckOutlbl
        '
        Me.CheckOutlbl.AutoSize = True
        Me.CheckOutlbl.Location = New System.Drawing.Point(586, 210)
        Me.CheckOutlbl.Name = "CheckOutlbl"
        Me.CheckOutlbl.Size = New System.Drawing.Size(53, 13)
        Me.CheckOutlbl.TabIndex = 72
        Me.CheckOutlbl.Text = "12/30/99"
        '
        'CheckInlbl
        '
        Me.CheckInlbl.AutoSize = True
        Me.CheckInlbl.Location = New System.Drawing.Point(586, 191)
        Me.CheckInlbl.Name = "CheckInlbl"
        Me.CheckInlbl.Size = New System.Drawing.Size(53, 13)
        Me.CheckInlbl.TabIndex = 71
        Me.CheckInlbl.Text = "12/12/99"
        '
        'IssueDatelbl
        '
        Me.IssueDatelbl.AutoSize = True
        Me.IssueDatelbl.Location = New System.Drawing.Point(586, 173)
        Me.IssueDatelbl.Name = "IssueDatelbl"
        Me.IssueDatelbl.Size = New System.Drawing.Size(53, 13)
        Me.IssueDatelbl.TabIndex = 70
        Me.IssueDatelbl.Text = "01/01/01"
        '
        'BookingNolbl
        '
        Me.BookingNolbl.AutoSize = True
        Me.BookingNolbl.Location = New System.Drawing.Point(586, 154)
        Me.BookingNolbl.Name = "BookingNolbl"
        Me.BookingNolbl.Size = New System.Drawing.Size(37, 13)
        Me.BookingNolbl.TabIndex = 69
        Me.BookingNolbl.Text = "43210"
        '
        'InvoiceNolbl
        '
        Me.InvoiceNolbl.AutoSize = True
        Me.InvoiceNolbl.Location = New System.Drawing.Point(586, 134)
        Me.InvoiceNolbl.Name = "InvoiceNolbl"
        Me.InvoiceNolbl.Size = New System.Drawing.Size(37, 13)
        Me.InvoiceNolbl.TabIndex = 68
        Me.InvoiceNolbl.Text = "01234"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(-13, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(805, 13)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "_________________________________________________________________________________" &
    "____________________________________________________"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(-27, 267)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(805, 13)
        Me.Label20.TabIndex = 66
        Me.Label20.Text = "_________________________________________________________________________________" &
    "____________________________________________________"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(476, 207)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 16)
        Me.Label19.TabIndex = 65
        Me.Label19.Text = "Check Out      :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(476, 189)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Check In         :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(476, 170)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 16)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "Issue Date     :  "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(476, 152)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 16)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "Booking No   :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(475, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 16)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Invoice No     :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(0, 352)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 13)
        Me.Label14.TabIndex = 60
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "03-3291 3091"
        '
        'Phonelbl
        '
        Me.Phonelbl.AutoSize = True
        Me.Phonelbl.Location = New System.Drawing.Point(4, 117)
        Me.Phonelbl.Name = "Phonelbl"
        Me.Phonelbl.Size = New System.Drawing.Size(76, 13)
        Me.Phonelbl.TabIndex = 58
        Me.Phonelbl.Text = "012-34567890"
        '
        'Emaillbl
        '
        Me.Emaillbl.AutoSize = True
        Me.Emaillbl.Location = New System.Drawing.Point(4, 100)
        Me.Emaillbl.Name = "Emaillbl"
        Me.Emaillbl.Size = New System.Drawing.Size(156, 13)
        Me.Emaillbl.TabIndex = 57
        Me.Emaillbl.Text = "johndoeunknown@hotmail.com"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "www.CherasQ.com.my"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "CherasQ123@gmail.com"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Location = New System.Drawing.Point(4, 31)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(102, 13)
        Me.Namelbl.TabIndex = 54
        Me.Namelbl.Text = "John Unknown Doe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Billed To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 39)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "12-39, Jalan Cheras, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cheras, 55170 Kuala Lumpur, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wilayah Persekutuan Kuala Lu" &
    "mpur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "CHERAS Q"
        '
        'AddLine3lbl
        '
        Me.AddLine3lbl.AutoSize = True
        Me.AddLine3lbl.Location = New System.Drawing.Point(4, 84)
        Me.AddLine3lbl.Name = "AddLine3lbl"
        Me.AddLine3lbl.Size = New System.Drawing.Size(77, 13)
        Me.AddLine3lbl.TabIndex = 96
        Me.AddLine3lbl.Text = "Address Line 3"
        '
        'AddLine2lbl
        '
        Me.AddLine2lbl.AutoSize = True
        Me.AddLine2lbl.Location = New System.Drawing.Point(4, 67)
        Me.AddLine2lbl.Name = "AddLine2lbl"
        Me.AddLine2lbl.Size = New System.Drawing.Size(77, 13)
        Me.AddLine2lbl.TabIndex = 97
        Me.AddLine2lbl.Text = "Address Line 2"
        '
        'AddLine1lbl
        '
        Me.AddLine1lbl.AutoSize = True
        Me.AddLine1lbl.Location = New System.Drawing.Point(4, 49)
        Me.AddLine1lbl.Name = "AddLine1lbl"
        Me.AddLine1lbl.Size = New System.Drawing.Size(77, 13)
        Me.AddLine1lbl.TabIndex = 98
        Me.AddLine1lbl.Text = "Address Line 1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AddLine1lbl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.AddLine2lbl)
        Me.Panel1.Controls.Add(Me.Namelbl)
        Me.Panel1.Controls.Add(Me.AddLine3lbl)
        Me.Panel1.Controls.Add(Me.Phonelbl)
        Me.Panel1.Controls.Add(Me.Emaillbl)
        Me.Panel1.Location = New System.Drawing.Point(248, 111)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(191, 139)
        Me.Panel1.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(554, 568)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = " :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(554, 549)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = " :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(555, 611)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 16)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = " :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(555, 631)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 16)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = " :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(555, 591)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 16)
        Me.Label10.TabIndex = 106
        Me.Label10.Text = " :"
        '
        'TotalTaxlbl
        '
        Me.TotalTaxlbl.AutoSize = True
        Me.TotalTaxlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTaxlbl.Location = New System.Drawing.Point(595, 592)
        Me.TotalTaxlbl.Name = "TotalTaxlbl"
        Me.TotalTaxlbl.Size = New System.Drawing.Size(96, 15)
        Me.TotalTaxlbl.TabIndex = 105
        Me.TotalTaxlbl.Text = "Client's Email"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(457, 590)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(43, 16)
        Me.Label123.TabIndex = 104
        Me.Label123.Text = "Total"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(564, 593)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 16)
        Me.Label12.TabIndex = 111
        Me.Label12.Text = " RM"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(564, 633)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 16)
        Me.Label21.TabIndex = 110
        Me.Label21.Text = " RM"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(564, 613)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 16)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = " RM"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(563, 551)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(34, 16)
        Me.Label23.TabIndex = 108
        Me.Label23.Text = " RM"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(563, 570)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 16)
        Me.Label24.TabIndex = 107
        Me.Label24.Text = " RM"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 119)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 112
        Me.PictureBox2.TabStop = False
        '
        'Cancelbtn
        '
        Me.Cancelbtn.Location = New System.Drawing.Point(473, 673)
        Me.Cancelbtn.Name = "Cancelbtn"
        Me.Cancelbtn.Size = New System.Drawing.Size(106, 36)
        Me.Cancelbtn.TabIndex = 113
        Me.Cancelbtn.Text = "Cancel"
        Me.Cancelbtn.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(271, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(143, 42)
        Me.Label25.TabIndex = 114
        Me.Label25.Text = "Invoice"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(700, 720)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Cancelbtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TotalTaxlbl)
        Me.Controls.Add(Me.Label123)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Printbtn)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Balancelbl)
        Me.Controls.Add(Me.Depositlbl)
        Me.Controls.Add(Me.Taxlbl)
        Me.Controls.Add(Me.Totallbl)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.SubTotallb)
        Me.Controls.Add(Me.Pricelb)
        Me.Controls.Add(Me.Quantitylb)
        Me.Controls.Add(Me.Itemlb)
        Me.Controls.Add(Me.Nolb)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.CheckOutlbl)
        Me.Controls.Add(Me.CheckInlbl)
        Me.Controls.Add(Me.IssueDatelbl)
        Me.Controls.Add(Me.BookingNolbl)
        Me.Controls.Add(Me.InvoiceNolbl)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Printbtn As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Balancelbl As Label
    Friend WithEvents Depositlbl As Label
    Friend WithEvents Taxlbl As Label
    Friend WithEvents Totallbl As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents SubTotallb As ListBox
    Friend WithEvents Pricelb As ListBox
    Friend WithEvents Quantitylb As ListBox
    Friend WithEvents Itemlb As ListBox
    Friend WithEvents Nolb As ListBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents CheckOutlbl As Label
    Friend WithEvents CheckInlbl As Label
    Friend WithEvents IssueDatelbl As Label
    Friend WithEvents BookingNolbl As Label
    Friend WithEvents InvoiceNolbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Phonelbl As Label
    Friend WithEvents Emaillbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Namelbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AddLine3lbl As Label
    Friend WithEvents AddLine2lbl As Label
    Friend WithEvents AddLine1lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TotalTaxlbl As Label
    Friend WithEvents Label123 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Cancelbtn As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
