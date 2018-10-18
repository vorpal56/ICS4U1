<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLvl1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLvl1))
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblSecs = New System.Windows.Forms.Label
        Me.lblColon = New System.Windows.Forms.Label
        Me.lblMinute = New System.Windows.Forms.Label
        Me.picChar = New System.Windows.Forms.PictureBox
        Me.picBox1 = New System.Windows.Forms.PictureBox
        Me.picBox2 = New System.Windows.Forms.PictureBox
        Me.picBox3 = New System.Windows.Forms.PictureBox
        Me.picBox4 = New System.Windows.Forms.PictureBox
        Me.picBox5 = New System.Windows.Forms.PictureBox
        Me.picBox6 = New System.Windows.Forms.PictureBox
        Me.picBox7 = New System.Windows.Forms.PictureBox
        Me.picBoxEnd = New System.Windows.Forms.PictureBox
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 1
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 500
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'lblMessage
        '
        Me.lblMessage.Font = New System.Drawing.Font("Abel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(12, 298)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(366, 65)
        Me.lblMessage.TabIndex = 58
        Me.lblMessage.Text = "lblMessage"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Abel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(66, 15)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(145, 25)
        Me.lblTime.TabIndex = 71
        Me.lblTime.Text = "Time Remaining:"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSecs
        '
        Me.lblSecs.BackColor = System.Drawing.Color.Transparent
        Me.lblSecs.Font = New System.Drawing.Font("Abel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblSecs.Location = New System.Drawing.Point(280, 13)
        Me.lblSecs.Name = "lblSecs"
        Me.lblSecs.Size = New System.Drawing.Size(38, 27)
        Me.lblSecs.TabIndex = 74
        Me.lblSecs.Text = "00"
        Me.lblSecs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblColon
        '
        Me.lblColon.BackColor = System.Drawing.Color.Transparent
        Me.lblColon.Font = New System.Drawing.Font("Abel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblColon.Location = New System.Drawing.Point(268, 13)
        Me.lblColon.Name = "lblColon"
        Me.lblColon.Size = New System.Drawing.Size(18, 27)
        Me.lblColon.TabIndex = 73
        Me.lblColon.Text = ":"
        Me.lblColon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMinute
        '
        Me.lblMinute.BackColor = System.Drawing.Color.Transparent
        Me.lblMinute.Font = New System.Drawing.Font("Abel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinute.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMinute.Location = New System.Drawing.Point(229, 13)
        Me.lblMinute.Name = "lblMinute"
        Me.lblMinute.Size = New System.Drawing.Size(44, 27)
        Me.lblMinute.TabIndex = 72
        Me.lblMinute.Text = "00"
        Me.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picChar
        '
        Me.picChar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.picChar.Location = New System.Drawing.Point(31, 146)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(30, 30)
        Me.picChar.TabIndex = 0
        Me.picChar.TabStop = False
        '
        'picBox1
        '
        Me.picBox1.BackColor = System.Drawing.Color.DarkGray
        Me.picBox1.Location = New System.Drawing.Point(26, 141)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(40, 40)
        Me.picBox1.TabIndex = 1
        Me.picBox1.TabStop = False
        Me.picBox1.Tag = "greyobj"
        '
        'picBox2
        '
        Me.picBox2.BackColor = System.Drawing.Color.DarkGray
        Me.picBox2.Location = New System.Drawing.Point(68, 141)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(40, 40)
        Me.picBox2.TabIndex = 2
        Me.picBox2.TabStop = False
        Me.picBox2.Tag = "greyobj"
        '
        'picBox3
        '
        Me.picBox3.BackColor = System.Drawing.Color.DarkGray
        Me.picBox3.Location = New System.Drawing.Point(110, 141)
        Me.picBox3.Name = "picBox3"
        Me.picBox3.Size = New System.Drawing.Size(40, 40)
        Me.picBox3.TabIndex = 3
        Me.picBox3.TabStop = False
        Me.picBox3.Tag = "greyobj"
        '
        'picBox4
        '
        Me.picBox4.BackColor = System.Drawing.Color.DarkGray
        Me.picBox4.Location = New System.Drawing.Point(152, 141)
        Me.picBox4.Name = "picBox4"
        Me.picBox4.Size = New System.Drawing.Size(40, 40)
        Me.picBox4.TabIndex = 11
        Me.picBox4.TabStop = False
        Me.picBox4.Tag = "greyobj"
        '
        'picBox5
        '
        Me.picBox5.BackColor = System.Drawing.Color.DarkGray
        Me.picBox5.Location = New System.Drawing.Point(194, 141)
        Me.picBox5.Name = "picBox5"
        Me.picBox5.Size = New System.Drawing.Size(40, 40)
        Me.picBox5.TabIndex = 10
        Me.picBox5.TabStop = False
        Me.picBox5.Tag = "greyobj"
        '
        'picBox6
        '
        Me.picBox6.BackColor = System.Drawing.Color.DarkGray
        Me.picBox6.Location = New System.Drawing.Point(236, 141)
        Me.picBox6.Name = "picBox6"
        Me.picBox6.Size = New System.Drawing.Size(40, 40)
        Me.picBox6.TabIndex = 9
        Me.picBox6.TabStop = False
        Me.picBox6.Tag = "greyobj"
        '
        'picBox7
        '
        Me.picBox7.BackColor = System.Drawing.Color.DarkGray
        Me.picBox7.Location = New System.Drawing.Point(278, 141)
        Me.picBox7.Name = "picBox7"
        Me.picBox7.Size = New System.Drawing.Size(40, 40)
        Me.picBox7.TabIndex = 8
        Me.picBox7.TabStop = False
        Me.picBox7.Tag = "greyobj"
        '
        'picBoxEnd
        '
        Me.picBoxEnd.BackColor = System.Drawing.Color.DarkRed
        Me.picBoxEnd.Location = New System.Drawing.Point(320, 141)
        Me.picBoxEnd.Name = "picBoxEnd"
        Me.picBoxEnd.Size = New System.Drawing.Size(40, 40)
        Me.picBoxEnd.TabIndex = 7
        Me.picBoxEnd.TabStop = False
        '
        'frmLvl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(394, 376)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblSecs)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.lblMinute)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.picBox2)
        Me.Controls.Add(Me.picBox3)
        Me.Controls.Add(Me.picBox4)
        Me.Controls.Add(Me.picBox5)
        Me.Controls.Add(Me.picBox6)
        Me.Controls.Add(Me.picBox7)
        Me.Controls.Add(Me.picBoxEnd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLvl1"
        Me.Text = "B² - Level 1"
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxEnd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picChar As System.Windows.Forms.PictureBox
    Friend WithEvents picBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxEnd As System.Windows.Forms.PictureBox
    Friend WithEvents picBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    Friend WithEvents tmrFlash As System.Windows.Forms.Timer
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblSecs As System.Windows.Forms.Label
    Friend WithEvents lblColon As System.Windows.Forms.Label
    Friend WithEvents lblMinute As System.Windows.Forms.Label

End Class
