<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Clearbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StaffPasswordtb = New System.Windows.Forms.TextBox()
        Me.StaffNametb = New System.Windows.Forms.TextBox()
        Me.StaffIDtb = New System.Windows.Forms.TextBox()
        Me.Addbtn = New System.Windows.Forms.Button()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.Editbtn = New System.Windows.Forms.Button()
        Me.SearchBar = New System.Windows.Forms.TextBox()
        Me.Staffdgv = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Privilegecb = New System.Windows.Forms.ComboBox()
        Me.IconClose = New FontAwesome.Sharp.IconPictureBox()
        Me.IconSearch = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.Staffdgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(538, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 25)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Staff List"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(106, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 25)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Manage Staff"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DimGray
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button2.Location = New System.Drawing.Point(136, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 39)
        Me.Button2.TabIndex = 56
        Me.Button2.Text = "Log Out"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Clearbtn
        '
        Me.Clearbtn.BackColor = System.Drawing.Color.DimGray
        Me.Clearbtn.FlatAppearance.BorderSize = 0
        Me.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clearbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clearbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Clearbtn.Location = New System.Drawing.Point(221, 307)
        Me.Clearbtn.Name = "Clearbtn"
        Me.Clearbtn.Size = New System.Drawing.Size(100, 39)
        Me.Clearbtn.TabIndex = 55
        Me.Clearbtn.Text = "Clear"
        Me.Clearbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(46, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(77, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(107, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 22)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "ID"
        '
        'StaffPasswordtb
        '
        Me.StaffPasswordtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffPasswordtb.Location = New System.Drawing.Point(158, 196)
        Me.StaffPasswordtb.Name = "StaffPasswordtb"
        Me.StaffPasswordtb.Size = New System.Drawing.Size(163, 22)
        Me.StaffPasswordtb.TabIndex = 50
        '
        'StaffNametb
        '
        Me.StaffNametb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffNametb.Location = New System.Drawing.Point(158, 147)
        Me.StaffNametb.Name = "StaffNametb"
        Me.StaffNametb.Size = New System.Drawing.Size(163, 22)
        Me.StaffNametb.TabIndex = 49
        '
        'StaffIDtb
        '
        Me.StaffIDtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffIDtb.Location = New System.Drawing.Point(158, 102)
        Me.StaffIDtb.Name = "StaffIDtb"
        Me.StaffIDtb.ReadOnly = True
        Me.StaffIDtb.Size = New System.Drawing.Size(163, 22)
        Me.StaffIDtb.TabIndex = 48
        '
        'Addbtn
        '
        Me.Addbtn.BackColor = System.Drawing.Color.DimGray
        Me.Addbtn.FlatAppearance.BorderSize = 0
        Me.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Addbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Addbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Addbtn.Location = New System.Drawing.Point(58, 307)
        Me.Addbtn.Name = "Addbtn"
        Me.Addbtn.Size = New System.Drawing.Size(100, 39)
        Me.Addbtn.TabIndex = 47
        Me.Addbtn.Text = "Add"
        Me.Addbtn.UseVisualStyleBackColor = False
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.DimGray
        Me.Deletebtn.FlatAppearance.BorderSize = 0
        Me.Deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Deletebtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deletebtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Deletebtn.Location = New System.Drawing.Point(221, 374)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(100, 39)
        Me.Deletebtn.TabIndex = 46
        Me.Deletebtn.Text = "Delete"
        Me.Deletebtn.UseVisualStyleBackColor = False
        '
        'Editbtn
        '
        Me.Editbtn.BackColor = System.Drawing.Color.DimGray
        Me.Editbtn.FlatAppearance.BorderSize = 0
        Me.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Editbtn.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Editbtn.ForeColor = System.Drawing.Color.Gainsboro
        Me.Editbtn.Location = New System.Drawing.Point(58, 374)
        Me.Editbtn.Name = "Editbtn"
        Me.Editbtn.Size = New System.Drawing.Size(100, 39)
        Me.Editbtn.TabIndex = 45
        Me.Editbtn.Text = "Edit"
        Me.Editbtn.UseVisualStyleBackColor = False
        '
        'SearchBar
        '
        Me.SearchBar.Location = New System.Drawing.Point(597, 74)
        Me.SearchBar.Name = "SearchBar"
        Me.SearchBar.Size = New System.Drawing.Size(193, 20)
        Me.SearchBar.TabIndex = 43
        '
        'Staffdgv
        '
        Me.Staffdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Staffdgv.Location = New System.Drawing.Point(378, 102)
        Me.Staffdgv.Name = "Staffdgv"
        Me.Staffdgv.Size = New System.Drawing.Size(443, 382)
        Me.Staffdgv.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(54, 245)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 22)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Privilege"
        '
        'Privilegecb
        '
        Me.Privilegecb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Privilegecb.FormattingEnabled = True
        Me.Privilegecb.Items.AddRange(New Object() {"System User", "System Admin"})
        Me.Privilegecb.Location = New System.Drawing.Point(158, 245)
        Me.Privilegecb.Name = "Privilegecb"
        Me.Privilegecb.Size = New System.Drawing.Size(163, 24)
        Me.Privilegecb.TabIndex = 61
        '
        'IconClose
        '
        Me.IconClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.IconClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.IconClose.IconChar = FontAwesome.Sharp.IconChar.Multiply
        Me.IconClose.IconColor = System.Drawing.Color.Gainsboro
        Me.IconClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconClose.Location = New System.Drawing.Point(826, 2)
        Me.IconClose.Name = "IconClose"
        Me.IconClose.Size = New System.Drawing.Size(32, 32)
        Me.IconClose.TabIndex = 62
        Me.IconClose.TabStop = False
        '
        'IconSearch
        '
        Me.IconSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.IconSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconSearch.IconColor = System.Drawing.SystemColors.Control
        Me.IconSearch.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSearch.IconSize = 25
        Me.IconSearch.Location = New System.Drawing.Point(796, 69)
        Me.IconSearch.Name = "IconSearch"
        Me.IconSearch.Size = New System.Drawing.Size(25, 25)
        Me.IconSearch.TabIndex = 64
        Me.IconSearch.TabStop = False
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 517)
        Me.Controls.Add(Me.IconSearch)
        Me.Controls.Add(Me.IconClose)
        Me.Controls.Add(Me.Privilegecb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Clearbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StaffPasswordtb)
        Me.Controls.Add(Me.StaffNametb)
        Me.Controls.Add(Me.StaffIDtb)
        Me.Controls.Add(Me.Addbtn)
        Me.Controls.Add(Me.Deletebtn)
        Me.Controls.Add(Me.Editbtn)
        Me.Controls.Add(Me.SearchBar)
        Me.Controls.Add(Me.Staffdgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        CType(Me.Staffdgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Clearbtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents StaffPasswordtb As TextBox
    Friend WithEvents StaffNametb As TextBox
    Friend WithEvents StaffIDtb As TextBox
    Friend WithEvents Addbtn As Button
    Friend WithEvents Deletebtn As Button
    Friend WithEvents Editbtn As Button
    Friend WithEvents SearchBar As TextBox
    Friend WithEvents Staffdgv As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Privilegecb As ComboBox
    Friend WithEvents IconClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconSearch As FontAwesome.Sharp.IconPictureBox
End Class
