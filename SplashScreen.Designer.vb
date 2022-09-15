<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.PBLoading1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblReportProgress = New System.Windows.Forms.Label()
        Me.LblStatusText = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBLoading1
        '
        Me.PBLoading1.Location = New System.Drawing.Point(34, 299)
        Me.PBLoading1.Name = "PBLoading1"
        Me.PBLoading1.Size = New System.Drawing.Size(566, 23)
        Me.PBLoading1.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LblReportProgress
        '
        Me.LblReportProgress.AutoSize = True
        Me.LblReportProgress.BackColor = System.Drawing.Color.Transparent
        Me.LblReportProgress.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReportProgress.ForeColor = System.Drawing.Color.Black
        Me.LblReportProgress.Location = New System.Drawing.Point(274, 358)
        Me.LblReportProgress.Name = "LblReportProgress"
        Me.LblReportProgress.Size = New System.Drawing.Size(76, 33)
        Me.LblReportProgress.TabIndex = 10
        Me.LblReportProgress.Text = "00%"
        Me.LblReportProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblStatusText
        '
        Me.LblStatusText.AutoSize = True
        Me.LblStatusText.BackColor = System.Drawing.Color.Transparent
        Me.LblStatusText.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStatusText.ForeColor = System.Drawing.Color.Black
        Me.LblStatusText.Location = New System.Drawing.Point(252, 325)
        Me.LblStatusText.Name = "LblStatusText"
        Me.LblStatusText.Size = New System.Drawing.Size(125, 33)
        Me.LblStatusText.TabIndex = 9
        Me.LblStatusText.Text = "Loading"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(604, 55)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hotel Management System"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(100, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(438, 245)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.BackgroundImage = Global.Hotel_Better.My.Resources.Resources.HotelPic
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(643, 427)
        Me.Controls.Add(Me.LblReportProgress)
        Me.Controls.Add(Me.LblStatusText)
        Me.Controls.Add(Me.PBLoading1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SplashScreen"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PBLoading1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblReportProgress As Label
    Friend WithEvents LblStatusText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
