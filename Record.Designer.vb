<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record
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
        Me.Printbtn = New System.Windows.Forms.Button()
        Me.Paymentdgv = New System.Windows.Forms.DataGridView()
        Me.PayAmountlbl = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PayMethodlbl = New System.Windows.Forms.Label()
        Me.BillingIDlbl = New System.Windows.Forms.Label()
        Me.PayDatelbl = New System.Windows.Forms.Label()
        Me.PaymentIDlbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PayTypelbl = New System.Windows.Forms.Label()
        Me.Report = New System.Windows.Forms.Button()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paymentdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconSearch
        '
        Me.IconSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconSearch.IconColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSearch.IconSize = 25
        Me.IconSearch.Location = New System.Drawing.Point(984, 21)
        Me.IconSearch.Name = "IconSearch"
        Me.IconSearch.Size = New System.Drawing.Size(25, 25)
        Me.IconSearch.TabIndex = 154
        Me.IconSearch.TabStop = False
        '
        'SearchBar
        '
        Me.SearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBar.Location = New System.Drawing.Point(806, 24)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(172, 20)
        Me.SearchBar.TabIndex = 153
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.DimGray
        Me.Clearbtn.FlatAppearance.BorderSize = 0
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Clearbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Clearbtn.Location = New System.Drawing.Point(148, 553)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(99, 35)
        Me.Clearbtn.TabIndex = 142
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Printbtn
        '
        Me.Printbtn.BackColor = System.Drawing.Color.DimGray
        Me.Printbtn.FlatAppearance.BorderSize = 0
        Me.Printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Printbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Printbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Printbtn.Location = New System.Drawing.Point(16, 553)
        Me.Printbtn.Name = "Printbtn"
        Me.Printbtn.Size = New System.Drawing.Size(99, 35)
        Me.Printbtn.TabIndex = 137
        Me.Printbtn.Text = "Print"
        Me.Printbtn.UseVisualStyleBackColor = False
        '
        'Paymentdgv
        '
        Me.Paymentdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Paymentdgv.Location = New System.Drawing.Point(410, 60)
        Me.Paymentdgv.Name = "Paymentdgv"
        Me.Paymentdgv.Size = New System.Drawing.Size(600, 550)
        Me.Paymentdgv.TabIndex = 136
        '
        'PayAmountlbl
        '
        Me.PayAmountlbl.AutoSize = True
        Me.PayAmountlbl.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayAmountlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.PayAmountlbl.Location = New System.Drawing.Point(258, 339)
        Me.PayAmountlbl.Name = "PayAmountlbl"
        Me.PayAmountlbl.Size = New System.Drawing.Size(13, 19)
        Me.PayAmountlbl.TabIndex = 166
        Me.PayAmountlbl.Text = " "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label19.Location = New System.Drawing.Point(214, 339)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 19)
        Me.Label19.TabIndex = 173
        Me.Label19.Text = "RM"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label18.Location = New System.Drawing.Point(197, 405)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 22)
        Me.Label18.TabIndex = 172
        Me.Label18.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label17.Location = New System.Drawing.Point(199, 278)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 22)
        Me.Label17.TabIndex = 171
        Me.Label17.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label16.Location = New System.Drawing.Point(195, 339)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 22)
        Me.Label16.TabIndex = 170
        Me.Label16.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label15.Location = New System.Drawing.Point(197, 99)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 22)
        Me.Label15.TabIndex = 169
        Me.Label15.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label14.Location = New System.Drawing.Point(197, 217)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 22)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label13.Location = New System.Drawing.Point(195, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 22)
        Me.Label13.TabIndex = 167
        Me.Label13.Text = ":"
        '
        'PayMethodlbl
        '
        Me.PayMethodlbl.AutoSize = True
        Me.PayMethodlbl.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayMethodlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.PayMethodlbl.Location = New System.Drawing.Point(218, 278)
        Me.PayMethodlbl.Name = "PayMethodlbl"
        Me.PayMethodlbl.Size = New System.Drawing.Size(13, 19)
        Me.PayMethodlbl.TabIndex = 165
        Me.PayMethodlbl.Text = " "
        '
        'BillingIDlbl
        '
        Me.BillingIDlbl.AutoSize = True
        Me.BillingIDlbl.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillingIDlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.BillingIDlbl.Location = New System.Drawing.Point(214, 158)
        Me.BillingIDlbl.Name = "BillingIDlbl"
        Me.BillingIDlbl.Size = New System.Drawing.Size(13, 19)
        Me.BillingIDlbl.TabIndex = 163
        Me.BillingIDlbl.Text = " "
        '
        'PayDatelbl
        '
        Me.PayDatelbl.AutoSize = True
        Me.PayDatelbl.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayDatelbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.PayDatelbl.Location = New System.Drawing.Point(215, 222)
        Me.PayDatelbl.Name = "PayDatelbl"
        Me.PayDatelbl.Size = New System.Drawing.Size(13, 19)
        Me.PayDatelbl.TabIndex = 162
        Me.PayDatelbl.Text = " "
        '
        'PaymentIDlbl
        '
        Me.PaymentIDlbl.AutoSize = True
        Me.PaymentIDlbl.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentIDlbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.PaymentIDlbl.Location = New System.Drawing.Point(218, 102)
        Me.PaymentIDlbl.Name = "PaymentIDlbl"
        Me.PaymentIDlbl.Size = New System.Drawing.Size(0, 19)
        Me.PaymentIDlbl.TabIndex = 161
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(12, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 22)
        Me.Label7.TabIndex = 160
        Me.Label7.Text = "Payment Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(10, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 22)
        Me.Label6.TabIndex = 159
        Me.Label6.Text = "Payment Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(12, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "Payment ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(13, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 22)
        Me.Label3.TabIndex = 157
        Me.Label3.Text = "Payment Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(12, 278)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 22)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Payment Method"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(12, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 22)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Billing ID"
        '
        'PayTypelbl
        '
        Me.PayTypelbl.AutoSize = True
        Me.PayTypelbl.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayTypelbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.PayTypelbl.Location = New System.Drawing.Point(214, 405)
        Me.PayTypelbl.Name = "PayTypelbl"
        Me.PayTypelbl.Size = New System.Drawing.Size(13, 19)
        Me.PayTypelbl.TabIndex = 174
        Me.PayTypelbl.Text = " "
        '
        'Report
        '
        Me.Report.BackColor = System.Drawing.Color.DimGray
        Me.Report.FlatAppearance.BorderSize = 0
        Me.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Report.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Report.ForeColor = System.Drawing.Color.Gainsboro
        Me.Report.Location = New System.Drawing.Point(283, 553)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(99, 35)
        Me.Report.TabIndex = 175
        Me.Report.Text = "Report"
        Me.Report.UseVisualStyleBackColor = False
        '
        'Record
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.PayTypelbl)
        Me.Controls.Add(Me.PayAmountlbl)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PayMethodlbl)
        Me.Controls.Add(Me.BillingIDlbl)
        Me.Controls.Add(Me.PayDatelbl)
        Me.Controls.Add(Me.PaymentIDlbl)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconSearch)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Printbtn)
        Me.Controls.Add(Me.Paymentdgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Record"
        Me.Text = "Payment"
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paymentdgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Printbtn As Button
    Friend WithEvents Paymentdgv As DataGridView
    Friend WithEvents PayAmountlbl As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PayMethodlbl As Label
    Friend WithEvents BillingIDlbl As Label
    Friend WithEvents PayDatelbl As Label
    Friend WithEvents PaymentIDlbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PayTypelbl As Label
    Friend WithEvents Report As Button
End Class
