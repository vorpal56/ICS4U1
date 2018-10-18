<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLvl8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLvl8))
        Me.lblMessage = New System.Windows.Forms.Label
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblSecs = New System.Windows.Forms.Label
        Me.lblColon = New System.Windows.Forms.Label
        Me.lblMinute = New System.Windows.Forms.Label
        Me.picChar = New System.Windows.Forms.PictureBox
        Me.picBox16BLUE = New System.Windows.Forms.PictureBox
        Me.picBox3BLUE = New System.Windows.Forms.PictureBox
        Me.picBox8 = New System.Windows.Forms.PictureBox
        Me.picBox4 = New System.Windows.Forms.PictureBox
        Me.picBoxEnd = New System.Windows.Forms.PictureBox
        Me.picBox5 = New System.Windows.Forms.PictureBox
        Me.picBox7 = New System.Windows.Forms.PictureBox
        Me.picBox6 = New System.Windows.Forms.PictureBox
        Me.picBox12 = New System.Windows.Forms.PictureBox
        Me.picBox15 = New System.Windows.Forms.PictureBox
        Me.picBox17 = New System.Windows.Forms.PictureBox
        Me.picBox18 = New System.Windows.Forms.PictureBox
        Me.picBox13LITE = New System.Windows.Forms.PictureBox
        Me.picBox14LITE = New System.Windows.Forms.PictureBox
        Me.picBox9 = New System.Windows.Forms.PictureBox
        Me.picBox10 = New System.Windows.Forms.PictureBox
        Me.picBox11GREEN = New System.Windows.Forms.PictureBox
        Me.picBox2 = New System.Windows.Forms.PictureBox
        Me.picBox1 = New System.Windows.Forms.PictureBox
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox16BLUE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox3BLUE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox13LITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox14LITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox11GREEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Transparent
        Me.lblMessage.Font = New System.Drawing.Font("Abel", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblMessage.Location = New System.Drawing.Point(12, 352)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(366, 65)
        Me.lblMessage.TabIndex = 197
        Me.lblMessage.Text = "lblMessage"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        Me.tmrCheck.Interval = 1
        '
        'tmrTime
        '
        Me.tmrTime.Enabled = True
        Me.tmrTime.Interval = 1000
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 500
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
        Me.lblTime.TabIndex = 200
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
        Me.lblSecs.TabIndex = 203
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
        Me.lblColon.TabIndex = 202
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
        Me.lblMinute.TabIndex = 201
        Me.lblMinute.Text = "00"
        Me.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picChar
        '
        Me.picChar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.picChar.Location = New System.Drawing.Point(74, 183)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(30, 30)
        Me.picChar.TabIndex = 158
        Me.picChar.TabStop = False
        '
        'picBox16BLUE
        '
        Me.picBox16BLUE.BackColor = System.Drawing.Color.DodgerBlue
        Me.picBox16BLUE.Location = New System.Drawing.Point(195, 178)
        Me.picBox16BLUE.Name = "picBox16BLUE"
        Me.picBox16BLUE.Size = New System.Drawing.Size(40, 40)
        Me.picBox16BLUE.TabIndex = 199
        Me.picBox16BLUE.TabStop = False
        Me.picBox16BLUE.Tag = "greyobj"
        '
        'picBox3BLUE
        '
        Me.picBox3BLUE.BackColor = System.Drawing.Color.DodgerBlue
        Me.picBox3BLUE.Location = New System.Drawing.Point(153, 178)
        Me.picBox3BLUE.Name = "picBox3BLUE"
        Me.picBox3BLUE.Size = New System.Drawing.Size(40, 40)
        Me.picBox3BLUE.TabIndex = 198
        Me.picBox3BLUE.TabStop = False
        Me.picBox3BLUE.Tag = "greyobj"
        '
        'picBox8
        '
        Me.picBox8.BackColor = System.Drawing.Color.DarkGray
        Me.picBox8.Location = New System.Drawing.Point(153, 304)
        Me.picBox8.Name = "picBox8"
        Me.picBox8.Size = New System.Drawing.Size(40, 40)
        Me.picBox8.TabIndex = 196
        Me.picBox8.TabStop = False
        Me.picBox8.Tag = "greyobj"
        '
        'picBox4
        '
        Me.picBox4.BackColor = System.Drawing.Color.DarkGray
        Me.picBox4.Location = New System.Drawing.Point(153, 220)
        Me.picBox4.Name = "picBox4"
        Me.picBox4.Size = New System.Drawing.Size(40, 40)
        Me.picBox4.TabIndex = 193
        Me.picBox4.TabStop = False
        Me.picBox4.Tag = "greyobj"
        '
        'picBoxEnd
        '
        Me.picBoxEnd.BackColor = System.Drawing.Color.DarkRed
        Me.picBoxEnd.Location = New System.Drawing.Point(195, 51)
        Me.picBoxEnd.Name = "picBoxEnd"
        Me.picBoxEnd.Size = New System.Drawing.Size(40, 40)
        Me.picBoxEnd.TabIndex = 192
        Me.picBoxEnd.TabStop = False
        Me.picBoxEnd.Tag = "greyobj"
        '
        'picBox5
        '
        Me.picBox5.BackColor = System.Drawing.Color.DarkGray
        Me.picBox5.Location = New System.Drawing.Point(153, 262)
        Me.picBox5.Name = "picBox5"
        Me.picBox5.Size = New System.Drawing.Size(40, 40)
        Me.picBox5.TabIndex = 191
        Me.picBox5.TabStop = False
        Me.picBox5.Tag = "greyobj"
        '
        'picBox7
        '
        Me.picBox7.BackColor = System.Drawing.Color.DarkGray
        Me.picBox7.Location = New System.Drawing.Point(111, 304)
        Me.picBox7.Name = "picBox7"
        Me.picBox7.Size = New System.Drawing.Size(40, 40)
        Me.picBox7.TabIndex = 189
        Me.picBox7.TabStop = False
        Me.picBox7.Tag = "greyobj"
        '
        'picBox6
        '
        Me.picBox6.BackColor = System.Drawing.Color.DarkGray
        Me.picBox6.Location = New System.Drawing.Point(111, 262)
        Me.picBox6.Name = "picBox6"
        Me.picBox6.Size = New System.Drawing.Size(40, 40)
        Me.picBox6.TabIndex = 190
        Me.picBox6.TabStop = False
        Me.picBox6.Tag = "greyobj"
        '
        'picBox12
        '
        Me.picBox12.BackColor = System.Drawing.Color.DarkGray
        Me.picBox12.Location = New System.Drawing.Point(279, 262)
        Me.picBox12.Name = "picBox12"
        Me.picBox12.Size = New System.Drawing.Size(40, 40)
        Me.picBox12.TabIndex = 187
        Me.picBox12.TabStop = False
        Me.picBox12.Tag = "greyobj"
        '
        'picBox15
        '
        Me.picBox15.BackColor = System.Drawing.Color.DarkGray
        Me.picBox15.Location = New System.Drawing.Point(237, 178)
        Me.picBox15.Name = "picBox15"
        Me.picBox15.Size = New System.Drawing.Size(40, 40)
        Me.picBox15.TabIndex = 184
        Me.picBox15.TabStop = False
        Me.picBox15.Tag = "greyobj"
        '
        'picBox17
        '
        Me.picBox17.BackColor = System.Drawing.Color.DarkGray
        Me.picBox17.Location = New System.Drawing.Point(195, 136)
        Me.picBox17.Name = "picBox17"
        Me.picBox17.Size = New System.Drawing.Size(40, 40)
        Me.picBox17.TabIndex = 182
        Me.picBox17.TabStop = False
        Me.picBox17.Tag = "greyobj"
        '
        'picBox18
        '
        Me.picBox18.BackColor = System.Drawing.Color.DarkGray
        Me.picBox18.Location = New System.Drawing.Point(195, 94)
        Me.picBox18.Name = "picBox18"
        Me.picBox18.Size = New System.Drawing.Size(40, 40)
        Me.picBox18.TabIndex = 183
        Me.picBox18.TabStop = False
        Me.picBox18.Tag = "greyobj"
        '
        'picBox13LITE
        '
        Me.picBox13LITE.BackColor = System.Drawing.Color.GhostWhite
        Me.picBox13LITE.Location = New System.Drawing.Point(237, 262)
        Me.picBox13LITE.Name = "picBox13LITE"
        Me.picBox13LITE.Size = New System.Drawing.Size(40, 40)
        Me.picBox13LITE.TabIndex = 180
        Me.picBox13LITE.TabStop = False
        Me.picBox13LITE.Tag = "greyobj"
        Me.picBox13LITE.Visible = False
        '
        'picBox14LITE
        '
        Me.picBox14LITE.BackColor = System.Drawing.Color.GhostWhite
        Me.picBox14LITE.Location = New System.Drawing.Point(237, 220)
        Me.picBox14LITE.Name = "picBox14LITE"
        Me.picBox14LITE.Size = New System.Drawing.Size(40, 40)
        Me.picBox14LITE.TabIndex = 181
        Me.picBox14LITE.TabStop = False
        Me.picBox14LITE.Tag = "greyobj"
        Me.picBox14LITE.Visible = False
        '
        'picBox9
        '
        Me.picBox9.BackColor = System.Drawing.Color.DarkGray
        Me.picBox9.Location = New System.Drawing.Point(195, 304)
        Me.picBox9.Name = "picBox9"
        Me.picBox9.Size = New System.Drawing.Size(40, 40)
        Me.picBox9.TabIndex = 179
        Me.picBox9.TabStop = False
        Me.picBox9.Tag = "greyobj"
        '
        'picBox10
        '
        Me.picBox10.BackColor = System.Drawing.Color.DarkGray
        Me.picBox10.Location = New System.Drawing.Point(237, 304)
        Me.picBox10.Name = "picBox10"
        Me.picBox10.Size = New System.Drawing.Size(40, 40)
        Me.picBox10.TabIndex = 174
        Me.picBox10.TabStop = False
        Me.picBox10.Tag = "greyobj"
        '
        'picBox11GREEN
        '
        Me.picBox11GREEN.BackColor = System.Drawing.Color.ForestGreen
        Me.picBox11GREEN.Location = New System.Drawing.Point(279, 304)
        Me.picBox11GREEN.Name = "picBox11GREEN"
        Me.picBox11GREEN.Size = New System.Drawing.Size(40, 40)
        Me.picBox11GREEN.TabIndex = 170
        Me.picBox11GREEN.TabStop = False
        Me.picBox11GREEN.Tag = "greyobj"
        '
        'picBox2
        '
        Me.picBox2.BackColor = System.Drawing.Color.DarkGray
        Me.picBox2.Location = New System.Drawing.Point(111, 178)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(40, 40)
        Me.picBox2.TabIndex = 169
        Me.picBox2.TabStop = False
        Me.picBox2.Tag = "greyobj"
        '
        'picBox1
        '
        Me.picBox1.BackColor = System.Drawing.Color.DarkGray
        Me.picBox1.Location = New System.Drawing.Point(69, 178)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(40, 40)
        Me.picBox1.TabIndex = 157
        Me.picBox1.TabStop = False
        Me.picBox1.Tag = "greyobj"
        '
        'frmLvl8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(394, 426)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblSecs)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.lblMinute)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.picBox16BLUE)
        Me.Controls.Add(Me.picBox3BLUE)
        Me.Controls.Add(Me.picBox8)
        Me.Controls.Add(Me.picBox4)
        Me.Controls.Add(Me.picBoxEnd)
        Me.Controls.Add(Me.picBox5)
        Me.Controls.Add(Me.picBox7)
        Me.Controls.Add(Me.picBox6)
        Me.Controls.Add(Me.picBox12)
        Me.Controls.Add(Me.picBox15)
        Me.Controls.Add(Me.picBox17)
        Me.Controls.Add(Me.picBox18)
        Me.Controls.Add(Me.picBox13LITE)
        Me.Controls.Add(Me.picBox14LITE)
        Me.Controls.Add(Me.picBox9)
        Me.Controls.Add(Me.picBox10)
        Me.Controls.Add(Me.picBox11GREEN)
        Me.Controls.Add(Me.picBox2)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLvl8"
        Me.Text = "B² - Level 8"
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox16BLUE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox3BLUE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox13LITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox14LITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox11GREEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picChar As System.Windows.Forms.PictureBox
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents picBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxEnd As System.Windows.Forms.PictureBox
    Friend WithEvents picBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox13LITE As System.Windows.Forms.PictureBox
    Friend WithEvents picBox14LITE As System.Windows.Forms.PictureBox
    Friend WithEvents picBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox10 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox11GREEN As System.Windows.Forms.PictureBox
    Friend WithEvents picBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox3BLUE As System.Windows.Forms.PictureBox
    Friend WithEvents picBox16BLUE As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents tmrFlash As System.Windows.Forms.Timer
    Friend WithEvents picBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblSecs As System.Windows.Forms.Label
    Friend WithEvents lblColon As System.Windows.Forms.Label
    Friend WithEvents lblMinute As System.Windows.Forms.Label
End Class
