<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Room
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RoomPricetb = New System.Windows.Forms.TextBox()
        Me.RoomStatustb = New System.Windows.Forms.TextBox()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoomNumbertb = New System.Windows.Forms.TextBox()
        Me.RoomIDtb = New System.Windows.Forms.TextBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Roomdgv = New System.Windows.Forms.DataGridView()
        Me.RoomTypecb = New System.Windows.Forms.ComboBox()
        Me.IconSearch = New FontAwesome.Sharp.IconPictureBox()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.Report = New System.Windows.Forms.Button()
        CType(Me.Roomdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(38, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Room Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(27, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 22)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Room Status"
        '
        'RoomPricetb
        '
        Me.RoomPricetb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomPricetb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RoomPricetb.Location = New System.Drawing.Point(164, 377)
        Me.RoomPricetb.Name = "RoomPricetb"
        Me.RoomPricetb.ReadOnly = True
        Me.RoomPricetb.Size = New System.Drawing.Size(208, 29)
        Me.RoomPricetb.TabIndex = 74
        '
        'RoomStatustb
        '
        Me.RoomStatustb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomStatustb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RoomStatustb.Location = New System.Drawing.Point(164, 310)
        Me.RoomStatustb.Name = "RoomStatustb"
        Me.RoomStatustb.ReadOnly = True
        Me.RoomStatustb.Size = New System.Drawing.Size(208, 29)
        Me.RoomStatustb.TabIndex = 73
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.DimGray
        Me.Clearbtn.FlatAppearance.BorderSize = 0
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Clearbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Clearbtn.Location = New System.Drawing.Point(52, 506)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(99, 35)
        Me.Clearbtn.TabIndex = 72
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(39, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 22)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Room Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(12, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 22)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Room Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(115, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 22)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "ID"
        '
        'RoomNumbertb
        '
        Me.RoomNumbertb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomNumbertb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RoomNumbertb.Location = New System.Drawing.Point(164, 157)
        Me.RoomNumbertb.Name = "RoomNumbertb"
        Me.RoomNumbertb.Size = New System.Drawing.Size(208, 29)
        Me.RoomNumbertb.TabIndex = 67
        '
        'RoomIDtb
        '
        Me.RoomIDtb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomIDtb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RoomIDtb.Location = New System.Drawing.Point(164, 78)
        Me.RoomIDtb.Name = "RoomIDtb"
        Me.RoomIDtb.ReadOnly = True
        Me.RoomIDtb.Size = New System.Drawing.Size(208, 29)
        Me.RoomIDtb.TabIndex = 66
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.DimGray
        Me.Addbtn.FlatAppearance.BorderSize = 0
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Addbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Addbtn.Location = New System.Drawing.Point(52, 435)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(99, 35)
        Me.Addbtn.TabIndex = 65
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.DimGray
        Me.Deletebtn.FlatAppearance.BorderSize = 0
        Me.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Deletebtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Deletebtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Deletebtn.Location = New System.Drawing.Point(240, 506)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(99, 35)
        Me.Deletebtn.TabIndex = 64
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = False
        '
        'Editbtn
        '
        Me.Editbtn.BackColor = System.Drawing.Color.DimGray
        Me.Editbtn.FlatAppearance.BorderSize = 0
        Me.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Editbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Editbtn.Location = New System.Drawing.Point(240, 435)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(99, 35)
        Me.Editbtn.TabIndex = 63
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = False
        '
        'Roomdgv
        '
        Me.Roomdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Roomdgv.Location = New System.Drawing.Point(400, 60)
        Me.Roomdgv.Name = "Roomdgv"
        Me.Roomdgv.Size = New System.Drawing.Size(600, 550)
        Me.Roomdgv.TabIndex = 60
        '
        'RoomTypecb
        '
        Me.RoomTypecb.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoomTypecb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RoomTypecb.FormattingEnabled = True
        Me.RoomTypecb.Location = New System.Drawing.Point(164, 235)
        Me.RoomTypecb.Name = "RoomTypecb"
        Me.RoomTypecb.Size = New System.Drawing.Size(208, 30)
        Me.RoomTypecb.TabIndex = 79
        '
        'IconSearch
        '
        Me.IconSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconSearch.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconSearch.IconColor = System.Drawing.Color.Gainsboro
        Me.IconSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSearch.IconSize = 25
        Me.IconSearch.Location = New System.Drawing.Point(976, 25)
        Me.IconSearch.Name = "IconSearch"
        Me.IconSearch.Size = New System.Drawing.Size(25, 25)
        Me.IconSearch.TabIndex = 128
        Me.IconSearch.TabStop = False
        '
        'SearchBar
        '
        Me.SearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBar.Location = New System.Drawing.Point(798, 25)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(172, 20)
        Me.SearchBar.TabIndex = 127
        '
        'Report
        '
        Me.Report.BackColor = System.Drawing.Color.DimGray
        Me.Report.FlatAppearance.BorderSize = 0
        Me.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Report.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Report.ForeColor = System.Drawing.Color.Gainsboro
        Me.Report.Location = New System.Drawing.Point(240, 575)
        Me.Report.Name = "Report"
        Me.Report.Size = New System.Drawing.Size(99, 35)
        Me.Report.TabIndex = 129
        Me.Report.Text = "Report"
        Me.Report.UseVisualStyleBackColor = False
        '
        'Room
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.Report)
        Me.Controls.Add(Me.IconSearch)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.RoomTypecb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RoomPricetb)
        Me.Controls.Add(Me.RoomStatustb)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RoomNumbertb)
        Me.Controls.Add(Me.RoomIDtb)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Roomdgv)
        Me.ForeColor = System.Drawing.SystemColors.InfoText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Room"
        Me.Text = "Room"
        CType(Me.Roomdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RoomPricetb As TextBox
    Friend WithEvents RoomStatustb As TextBox
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RoomNumbertb As TextBox
    Friend WithEvents RoomIDtb As TextBox
    Friend WithEvents Addbtn As Button
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents Roomdgv As DataGridView
    Friend WithEvents RoomTypecb As ComboBox
    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents Report As Button
End Class
