<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentPrint))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Amounttb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PaymentMethodcb = New System.Windows.Forms.ComboBox()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Invoicelbl = New System.Windows.Forms.Label()
        Me.Namelbl = New System.Windows.Forms.Label()
        Me.Datelbl = New System.Windows.Forms.Label()
        Me.Infolbl = New System.Windows.Forms.Label()
        Me.Confirmbtn = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(84, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 39)
        Me.Label8.TabIndex = 128
        Me.Label8.Text = "Payment"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(74, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 129
        Me.PictureBox1.TabStop = False
        '
        'Amounttb
        '
        Me.Amounttb.Location = New System.Drawing.Point(186, 360)
        Me.Amounttb.Name = "Amounttb"
        Me.Amounttb.ReadOnly = True
        Me.Amounttb.Size = New System.Drawing.Size(100, 20)
        Me.Amounttb.TabIndex = 127
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
        'PaymentMethodcb
        '
        Me.PaymentMethodcb.FormattingEnabled = True
        Me.PaymentMethodcb.Location = New System.Drawing.Point(186, 321)
        Me.PaymentMethodcb.Name = "PaymentMethodcb"
        Me.PaymentMethodcb.Size = New System.Drawing.Size(121, 21)
        Me.PaymentMethodcb.TabIndex = 125
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDlbl.Location = New System.Drawing.Point(183, 195)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(61, 16)
        Me.IDlbl.TabIndex = 124
        Me.IDlbl.Text = "Deposit"
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
        'Invoicelbl
        '
        Me.Invoicelbl.AutoSize = True
        Me.Invoicelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoicelbl.Location = New System.Drawing.Point(183, 164)
        Me.Invoicelbl.Name = "Invoicelbl"
        Me.Invoicelbl.Size = New System.Drawing.Size(61, 16)
        Me.Invoicelbl.TabIndex = 122
        Me.Invoicelbl.Text = "Deposit"
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
        'Confirmbtn
        '
        Me.Confirmbtn.Location = New System.Drawing.Point(107, 405)
        Me.Confirmbtn.Name = "Confirmbtn"
        Me.Confirmbtn.Size = New System.Drawing.Size(106, 36)
        Me.Confirmbtn.TabIndex = 118
        Me.Confirmbtn.Text = "Print"
        Me.Confirmbtn.UseVisualStyleBackColor = True
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
        Me.Label15.Size = New System.Drawing.Size(136, 16)
        Me.Label15.TabIndex = 113
        Me.Label15.Text = "Invoice ID              :"
        '
        'PaymentPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Amounttb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PaymentMethodcb)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Invoicelbl)
        Me.Controls.Add(Me.Namelbl)
        Me.Controls.Add(Me.Datelbl)
        Me.Controls.Add(Me.Infolbl)
        Me.Controls.Add(Me.Confirmbtn)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentPrint"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Amounttb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PaymentMethodcb As ComboBox
    Friend WithEvents IDlbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Invoicelbl As Label
    Friend WithEvents Namelbl As Label
    Friend WithEvents Datelbl As Label
    Friend WithEvents Infolbl As Label
    Friend WithEvents Confirmbtn As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
