<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Guest
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
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.GuestGendercb = New System.Windows.Forms.ComboBox()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GuestEmailtb = New System.Windows.Forms.TextBox()
        Me.GuestPhonetb = New System.Windows.Forms.TextBox()
        Me.GuestNametb = New System.Windows.Forms.TextBox()
        Me.GuestIDtb = New System.Windows.Forms.TextBox()
        Me.Guestdgv = New System.Windows.Forms.DataGridView()
        Me.IconSearch = New FontAwesome.Sharp.IconPictureBox()
        Me.GuestAddress2 = New System.Windows.Forms.TextBox()
        Me.GuestAddress3 = New System.Windows.Forms.TextBox()
        Me.GuestAddress1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PassportICtb = New System.Windows.Forms.TextBox()
        CType(Me.Guestdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.DimGray
        Me.Clearbtn.FlatAppearance.BorderSize = 0
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Clearbtn.Location = New System.Drawing.Point(41, 557)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(99, 35)
        Me.Clearbtn.TabIndex = 60
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'GuestGendercb
        '
        Me.GuestGendercb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GuestGendercb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestGendercb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestGendercb.FormattingEnabled = True
        Me.GuestGendercb.Items.AddRange(New Object() {"Male", "Female"})
        Me.GuestGendercb.Location = New System.Drawing.Point(156, 282)
        Me.GuestGendercb.Name = "GuestGendercb"
        Me.GuestGendercb.Size = New System.Drawing.Size(215, 24)
        Me.GuestGendercb.TabIndex = 59
        '
        'SearchBar
        '
        Me.SearchBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBar.Location = New System.Drawing.Point(798, 27)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(172, 20)
        Me.SearchBar.TabIndex = 57
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.DimGray
        Me.Addbtn.Enabled = False
        Me.Addbtn.FlatAppearance.BorderSize = 0
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Addbtn.Location = New System.Drawing.Point(41, 487)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(99, 35)
        Me.Addbtn.TabIndex = 56
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.DimGray
        Me.Deletebtn.Enabled = False
        Me.Deletebtn.FlatAppearance.BorderSize = 0
        Me.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Deletebtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Deletebtn.Location = New System.Drawing.Point(233, 557)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(99, 35)
        Me.Deletebtn.TabIndex = 55
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = False
        '
        'Editbtn
        '
        Me.Editbtn.BackColor = System.Drawing.Color.DimGray
        Me.Editbtn.Enabled = False
        Me.Editbtn.FlatAppearance.BorderSize = 0
        Me.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editbtn.ForeColor = System.Drawing.SystemColors.Control
        Me.Editbtn.Location = New System.Drawing.Point(233, 487)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(99, 35)
        Me.Editbtn.TabIndex = 54
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(85, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 22)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(78, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(70, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 22)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(82, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(61, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Guest ID"
        '
        'GuestEmailtb
        '
        Me.GuestEmailtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestEmailtb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestEmailtb.Location = New System.Drawing.Point(156, 236)
        Me.GuestEmailtb.Name = "GuestEmailtb"
        Me.GuestEmailtb.Size = New System.Drawing.Size(216, 22)
        Me.GuestEmailtb.TabIndex = 46
        '
        'GuestPhonetb
        '
        Me.GuestPhonetb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestPhonetb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestPhonetb.Location = New System.Drawing.Point(156, 190)
        Me.GuestPhonetb.Name = "GuestPhonetb"
        Me.GuestPhonetb.Size = New System.Drawing.Size(216, 22)
        Me.GuestPhonetb.TabIndex = 45
        '
        'GuestNametb
        '
        Me.GuestNametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestNametb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestNametb.Location = New System.Drawing.Point(157, 102)
        Me.GuestNametb.Name = "GuestNametb"
        Me.GuestNametb.Size = New System.Drawing.Size(216, 22)
        Me.GuestNametb.TabIndex = 44
        '
        'GuestIDtb
        '
        Me.GuestIDtb.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GuestIDtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestIDtb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestIDtb.Location = New System.Drawing.Point(157, 60)
        Me.GuestIDtb.Name = "GuestIDtb"
        Me.GuestIDtb.ReadOnly = True
        Me.GuestIDtb.Size = New System.Drawing.Size(216, 22)
        Me.GuestIDtb.TabIndex = 43
        '
        'Guestdgv
        '
        Me.Guestdgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Guestdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Guestdgv.Location = New System.Drawing.Point(400, 60)
        Me.Guestdgv.Name = "Guestdgv"
        Me.Guestdgv.Size = New System.Drawing.Size(600, 550)
        Me.Guestdgv.TabIndex = 42
        '
        'IconSearch
        '
        Me.IconSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconSearch.IconColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSearch.IconSize = 25
        Me.IconSearch.Location = New System.Drawing.Point(976, 24)
        Me.IconSearch.Name = "IconSearch"
        Me.IconSearch.Size = New System.Drawing.Size(25, 25)
        Me.IconSearch.TabIndex = 63
        Me.IconSearch.TabStop = False
        '
        'GuestAddress2
        '
        Me.GuestAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestAddress2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestAddress2.Location = New System.Drawing.Point(157, 372)
        Me.GuestAddress2.Name = "GuestAddress2"
        Me.GuestAddress2.Size = New System.Drawing.Size(216, 22)
        Me.GuestAddress2.TabIndex = 64
        '
        'GuestAddress3
        '
        Me.GuestAddress3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestAddress3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestAddress3.Location = New System.Drawing.Point(157, 418)
        Me.GuestAddress3.Name = "GuestAddress3"
        Me.GuestAddress3.Size = New System.Drawing.Size(215, 22)
        Me.GuestAddress3.TabIndex = 66
        '
        'GuestAddress1
        '
        Me.GuestAddress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestAddress1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.GuestAddress1.Location = New System.Drawing.Point(157, 328)
        Me.GuestAddress1.Name = "GuestAddress1"
        Me.GuestAddress1.Size = New System.Drawing.Size(215, 22)
        Me.GuestAddress1.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(10, 418)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 22)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Address Line 3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(11, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 22)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Address Line 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(10, 328)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 22)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Address Line 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label10.Location = New System.Drawing.Point(4, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 22)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Passport/IC No"
        '
        'PassportICtb
        '
        Me.PassportICtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassportICtb.ForeColor = System.Drawing.SystemColors.InfoText
        Me.PassportICtb.Location = New System.Drawing.Point(157, 146)
        Me.PassportICtb.Name = "PassportICtb"
        Me.PassportICtb.Size = New System.Drawing.Size(216, 22)
        Me.PassportICtb.TabIndex = 70
        '
        'Guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 630)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PassportICtb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GuestAddress1)
        Me.Controls.Add(Me.GuestAddress3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GuestAddress2)
        Me.Controls.Add(Me.IconSearch)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.GuestGendercb)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GuestEmailtb)
        Me.Controls.Add(Me.GuestPhonetb)
        Me.Controls.Add(Me.GuestNametb)
        Me.Controls.Add(Me.GuestIDtb)
        Me.Controls.Add(Me.Guestdgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Guest"
        Me.Text = "Guest"
        CType(Me.Guestdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Clearbtn As Button
    Friend WithEvents GuestGendercb As ComboBox
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents Addbtn As Button
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GuestEmailtb As TextBox
    Friend WithEvents GuestPhonetb As TextBox
    Friend WithEvents GuestNametb As TextBox
    Friend WithEvents GuestIDtb As TextBox
    Friend WithEvents Guestdgv As DataGridView
    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GuestAddress2 As TextBox
    Friend WithEvents GuestAddress3 As TextBox
    Friend WithEvents GuestAddress1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PassportICtb As TextBox
End Class
