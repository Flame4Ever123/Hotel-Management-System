<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentInfo))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GuestIDlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PaymentIDlbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.Infolbl = New System.Windows.Forms.Label()
        Me.Printbtn = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PayMethodlbl = New System.Windows.Forms.Label()
        Me.PayAmountlbl = New System.Windows.Forms.Label()
        Me.IconClose = New FontAwesome.Sharp.IconPictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(117, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 39)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Payment"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(107, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 364)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 16)
        Me.Label7.TabIndex = 126
        Me.Label7.Text = "Payment Amount    :"
        '
        'GuestIDlbl
        '
        Me.GuestIDlbl.AutoSize = True
        Me.GuestIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestIDlbl.Location = New System.Drawing.Point(183, 195)
        Me.GuestIDlbl.Name = "GuestIDlbl"
        Me.GuestIDlbl.Size = New System.Drawing.Size(61, 16)
        Me.GuestIDlbl.TabIndex = 124
        Me.GuestIDlbl.Text = "Deposit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 16)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Guest ID                :"
        '
        'PaymentIDlbl
        '
        Me.PaymentIDlbl.AutoSize = True
        Me.PaymentIDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentIDlbl.Location = New System.Drawing.Point(183, 164)
        Me.PaymentIDlbl.Name = "PaymentIDlbl"
        Me.PaymentIDlbl.Size = New System.Drawing.Size(61, 16)
        Me.PaymentIDlbl.TabIndex = 122
        Me.PaymentIDlbl.Text = "Deposit"
        '
        'Namelbl
        '
        Me.Namelbl.AutoSize = True
        Me.Namelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namelbl.Location = New System.Drawing.Point(183, 227)
        Me.Namelbl.Name = "Namelbl"
        Me.Namelbl.Size = New System.Drawing.Size(61, 16)
        Me.Namelbl.TabIndex = 121
        Me.Namelbl.Text = "Deposit"
        '
        'Datelbl
        '
        Me.Datelbl.AutoSize = True
        Me.Datelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Datelbl.Location = New System.Drawing.Point(183, 260)
        Me.Datelbl.Name = "Datelbl"
        Me.Datelbl.Size = New System.Drawing.Size(61, 16)
        Me.Datelbl.TabIndex = 120
        Me.Datelbl.Text = "Deposit"
        '
        'Infolbl
        '
        Me.Infolbl.AutoSize = True
        Me.Infolbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Infolbl.Location = New System.Drawing.Point(183, 294)
        Me.Infolbl.Name = "Infolbl"
        Me.Infolbl.Size = New System.Drawing.Size(61, 16)
        Me.Infolbl.TabIndex = 119
        Me.Infolbl.Text = "Deposit"
        '
        'Printbtn
        '
        Me.Printbtn.Location = New System.Drawing.Point(138, 402)
        Me.Printbtn.Name = "Printbtn"
        Me.Printbtn.Size = New System.Drawing.Size(106, 36)
        Me.Printbtn.TabIndex = 118
        Me.Printbtn.Text = "Print"
        Me.Printbtn.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(35, 326)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 16)
        Me.Label19.TabIndex = 117
        Me.Label19.Text = "Payment Method   :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(35, 294)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(136, 16)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "Payment Info         :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(35, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(144, 16)
        Me.Label17.TabIndex = 115
        Me.Label17.Text = "Payment Date       :  "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(35, 227)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(136, 16)
        Me.Label16.TabIndex = 114
        Me.Label16.Text = "Guest Name          :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(35, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(134, 16)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "Payment ID           :"
        '
        'PayMethodlbl
        '
        Me.PayMethodlbl.AutoSize = True
        Me.PayMethodlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayMethodlbl.Location = New System.Drawing.Point(185, 328)
        Me.PayMethodlbl.Name = "PayMethodlbl"
        Me.PayMethodlbl.Size = New System.Drawing.Size(61, 16)
        Me.PayMethodlbl.TabIndex = 130
        Me.PayMethodlbl.Text = "Deposit"
        '
        'PayAmountlbl
        '
        Me.PayAmountlbl.AutoSize = True
        Me.PayAmountlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayAmountlbl.Location = New System.Drawing.Point(186, 364)
        Me.PayAmountlbl.Name = "PayAmountlbl"
        Me.PayAmountlbl.Size = New System.Drawing.Size(61, 16)
        Me.PayAmountlbl.TabIndex = 131
        Me.PayAmountlbl.Text = "Deposit"
        '
        'IconClose
        '
        Me.IconClose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.IconClose.ForeColor = System.Drawing.Color.DimGray
        Me.IconClose.IconChar = FontAwesome.Sharp.IconChar.Multiply
        Me.IconClose.IconColor = System.Drawing.Color.DimGray
        Me.IconClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconClose.Location = New System.Drawing.Point(368, 0)
        Me.IconClose.Name = "IconClose"
        Me.IconClose.Size = New System.Drawing.Size(32, 32)
        Me.IconClose.TabIndex = 132
        Me.IconClose.TabStop = False
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
        'PaymentInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(399, 450)
        Me.Controls.Add(Me.IconClose)
        Me.Controls.Add(Me.PayAmountlbl)
        Me.Controls.Add(Me.PayMethodlbl)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GuestIDlbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PaymentIDlbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.Infolbl)
        Me.Controls.Add(Me.Printbtn)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentInfo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GuestIDlbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PaymentIDlbl As Label
    Friend WithEvents Namelbl As Label
    Friend WithEvents Datelbl As Label
    Friend WithEvents Infolbl As Label
    Friend WithEvents Printbtn As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents PayMethodlbl As Label
    Friend WithEvents PayAmountlbl As Label
    Friend WithEvents IconClose As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
