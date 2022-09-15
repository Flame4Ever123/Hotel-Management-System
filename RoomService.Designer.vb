<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomService
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FoodPricetb = New System.Windows.Forms.TextBox()
        Me.Foodcb = New System.Windows.Forms.ComboBox()
        Me.Guestcb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OrderDatetb = New System.Windows.Forms.TextBox()
        Me.FoodStatustb = New System.Windows.Forms.TextBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoomServiceIDtb = New System.Windows.Forms.TextBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.RoomServicedgv = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Quantitycb = New System.Windows.Forms.ComboBox()
        Me.IconSearch = New FontAwesome.Sharp.IconPictureBox()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        CType(Me.RoomServicedgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(48, 330)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Unit Price"
        '
        'FoodPricetb
        '
        Me.FoodPricetb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodPricetb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.FoodPricetb.Location = New System.Drawing.Point(173, 327)
        Me.FoodPricetb.Name = "FoodPricetb"
        Me.FoodPricetb.ReadOnly = True
        Me.FoodPricetb.Size = New System.Drawing.Size(204, 29)
        Me.FoodPricetb.TabIndex = 129
        '
        'Foodcb
        '
        Me.Foodcb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Foodcb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Foodcb.FormattingEnabled = True
        Me.Foodcb.Location = New System.Drawing.Point(173, 191)
        Me.Foodcb.Name = "Foodcb"
        Me.Foodcb.Size = New System.Drawing.Size(204, 30)
        Me.Foodcb.TabIndex = 128
        '
        'Guestcb
        '
        Me.Guestcb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guestcb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Guestcb.FormattingEnabled = True
        Me.Guestcb.Location = New System.Drawing.Point(173, 121)
        Me.Guestcb.Name = "Guestcb"
        Me.Guestcb.Size = New System.Drawing.Size(204, 30)
        Me.Guestcb.TabIndex = 127
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(41, 404)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 22)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Order Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(73, 471)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 22)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Status"
        '
        'OrderDatetb
        '
        Me.OrderDatetb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDatetb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.OrderDatetb.Location = New System.Drawing.Point(173, 401)
        Me.OrderDatetb.Name = "OrderDatetb"
        Me.OrderDatetb.ReadOnly = True
        Me.OrderDatetb.Size = New System.Drawing.Size(204, 29)
        Me.OrderDatetb.TabIndex = 124
        '
        'FoodStatustb
        '
        Me.FoodStatustb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FoodStatustb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.FoodStatustb.Location = New System.Drawing.Point(173, 468)
        Me.FoodStatustb.Name = "FoodStatustb"
        Me.FoodStatustb.ReadOnly = True
        Me.FoodStatustb.Size = New System.Drawing.Size(204, 29)
        Me.FoodStatustb.TabIndex = 123
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.DimGray
        Me.Clearbtn.FlatAppearance.BorderSize = 0
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Clearbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Clearbtn.Location = New System.Drawing.Point(239, 551)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(99, 35)
        Me.Clearbtn.TabIndex = 122
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(48, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 22)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Food Item"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(61, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 22)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Guest ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(5, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Room Service ID"
        '
        'RoomServiceIDtb
        '
        Me.RoomServiceIDtb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomServiceIDtb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RoomServiceIDtb.Location = New System.Drawing.Point(173, 62)
        Me.RoomServiceIDtb.Name = "RoomServiceIDtb"
        Me.RoomServiceIDtb.ReadOnly = True
        Me.RoomServiceIDtb.Size = New System.Drawing.Size(204, 29)
        Me.RoomServiceIDtb.TabIndex = 118
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.DimGray
        Me.Addbtn.FlatAppearance.BorderSize = 0
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Addbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Addbtn.Location = New System.Drawing.Point(64, 551)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(99, 35)
        Me.Addbtn.TabIndex = 117
        Me.Addbtn.Text = "Order"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'RoomServicedgv
        '
        Me.RoomServicedgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomServicedgv.Location = New System.Drawing.Point(400, 60)
        Me.RoomServicedgv.Name = "RoomServicedgv"
        Me.RoomServicedgv.Size = New System.Drawing.Size(600, 550)
        Me.RoomServicedgv.TabIndex = 114
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(60, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 22)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "Quantity"
        '
        'Quantitycb
        '
        Me.Quantitycb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantitycb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Quantitycb.FormattingEnabled = True
        Me.Quantitycb.Location = New System.Drawing.Point(173, 256)
        Me.Quantitycb.Name = "Quantitycb"
        Me.Quantitycb.Size = New System.Drawing.Size(204, 30)
        Me.Quantitycb.TabIndex = 133
        '
        'IconSearch
        '
        Me.IconSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconSearch.IconColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSearch.IconSize = 25
        Me.IconSearch.Location = New System.Drawing.Point(974, 21)
        Me.IconSearch.Name = "IconSearch"
        Me.IconSearch.Size = New System.Drawing.Size(25, 25)
        Me.IconSearch.TabIndex = 135
        Me.IconSearch.TabStop = False
        '
        'SearchBar
        '
        Me.SearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBar.Location = New System.Drawing.Point(796, 24)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(172, 20)
        Me.SearchBar.TabIndex = 134
        '
        'RoomService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.IconSearch)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.Quantitycb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.FoodPricetb)
        Me.Controls.Add(Me.Foodcb)
        Me.Controls.Add(Me.Guestcb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.OrderDatetb)
        Me.Controls.Add(Me.FoodStatustb)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RoomServiceIDtb)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.RoomServicedgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RoomService"
        Me.Text = "Room Service"
        CType(Me.RoomServicedgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents FoodPricetb As TextBox
    Friend WithEvents Foodcb As ComboBox
    Friend WithEvents Guestcb As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents OrderDatetb As TextBox
    Friend WithEvents FoodStatustb As TextBox
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoomServiceIDtb As TextBox
    Friend WithEvents Addbtn As Button
    Friend WithEvents RoomServicedgv As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Quantitycb As ComboBox
    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SearchBar As TextBox
End Class
