<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlvl9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmlvl9))
        Me.lblTime = New System.Windows.Forms.Label
        Me.lblSecs = New System.Windows.Forms.Label
        Me.lblColon = New System.Windows.Forms.Label
        Me.lblMinute = New System.Windows.Forms.Label
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.tmrTime = New System.Windows.Forms.Timer(Me.components)
        Me.lblMessage = New System.Windows.Forms.Label
        Me.picChar = New System.Windows.Forms.PictureBox
        Me.picBox20 = New System.Windows.Forms.PictureBox
        Me.picBox19 = New System.Windows.Forms.PictureBox
        Me.picBox24 = New System.Windows.Forms.PictureBox
        Me.picBox18 = New System.Windows.Forms.PictureBox
        Me.picBox8 = New System.Windows.Forms.PictureBox
        Me.picBox6GREEN = New System.Windows.Forms.PictureBox
        Me.picBox3 = New System.Windows.Forms.PictureBox
        Me.picBox1 = New System.Windows.Forms.PictureBox
        Me.picBox26 = New System.Windows.Forms.PictureBox
        Me.picBox2 = New System.Windows.Forms.PictureBox
        Me.picBox14 = New System.Windows.Forms.PictureBox
        Me.picBox25 = New System.Windows.Forms.PictureBox
        Me.picBox5 = New System.Windows.Forms.PictureBox
        Me.picBox4 = New System.Windows.Forms.PictureBox
        Me.picBox7LITE = New System.Windows.Forms.PictureBox
        Me.picBox22LITE = New System.Windows.Forms.PictureBox
        Me.picBoxEnd = New System.Windows.Forms.PictureBox
        Me.picBox13 = New System.Windows.Forms.PictureBox
        Me.picBox9 = New System.Windows.Forms.PictureBox
        Me.picBox10BLUE = New System.Windows.Forms.PictureBox
        Me.picBox23 = New System.Windows.Forms.PictureBox
        Me.picBox15 = New System.Windows.Forms.PictureBox
        Me.picBox16 = New System.Windows.Forms.PictureBox
        Me.picBox21GREEN = New System.Windows.Forms.PictureBox
        Me.picBox11 = New System.Windows.Forms.PictureBox
        Me.picBox12 = New System.Windows.Forms.PictureBox
        Me.picBox17 = New System.Windows.Forms.PictureBox
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox6GREEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox7LITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox22LITE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox10BLUE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox21GREEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.lblTime.TabIndex = 179
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
        Me.lblSecs.TabIndex = 182
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
        Me.lblColon.TabIndex = 181
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
        Me.lblMinute.TabIndex = 180
        Me.lblMinute.Text = "00"
        Me.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.lblMessage.TabIndex = 211
        Me.lblMessage.Text = "lblMessage"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picChar
        '
        Me.picChar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.picChar.Location = New System.Drawing.Point(35, 140)
        Me.picChar.Name = "picChar"
        Me.picChar.Size = New System.Drawing.Size(30, 30)
        Me.picChar.TabIndex = 184
        Me.picChar.TabStop = False
        '
        'picBox20
        '
        Me.picBox20.BackColor = System.Drawing.Color.DarkGray
        Me.picBox20.Location = New System.Drawing.Point(198, 219)
        Me.picBox20.Name = "picBox20"
        Me.picBox20.Size = New System.Drawing.Size(40, 40)
        Me.picBox20.TabIndex = 210
        Me.picBox20.TabStop = False
        Me.picBox20.Tag = "greyobj"
        '
        'picBox19
        '
        Me.picBox19.BackColor = System.Drawing.Color.DarkGray
        Me.picBox19.Location = New System.Drawing.Point(240, 219)
        Me.picBox19.Name = "picBox19"
        Me.picBox19.Size = New System.Drawing.Size(40, 40)
        Me.picBox19.TabIndex = 209
        Me.picBox19.TabStop = False
        Me.picBox19.Tag = "greyobj"
        '
        'picBox24
        '
        Me.picBox24.BackColor = System.Drawing.Color.DarkGray
        Me.picBox24.Location = New System.Drawing.Point(114, 219)
        Me.picBox24.Name = "picBox24"
        Me.picBox24.Size = New System.Drawing.Size(40, 40)
        Me.picBox24.TabIndex = 208
        Me.picBox24.TabStop = False
        Me.picBox24.Tag = "greyobj"
        '
        'picBox18
        '
        Me.picBox18.BackColor = System.Drawing.Color.DarkGray
        Me.picBox18.Location = New System.Drawing.Point(240, 177)
        Me.picBox18.Name = "picBox18"
        Me.picBox18.Size = New System.Drawing.Size(40, 40)
        Me.picBox18.TabIndex = 207
        Me.picBox18.TabStop = False
        Me.picBox18.Tag = "greyobj"
        '
        'picBox8
        '
        Me.picBox8.BackColor = System.Drawing.Color.DarkGray
        Me.picBox8.Location = New System.Drawing.Point(198, 93)
        Me.picBox8.Name = "picBox8"
        Me.picBox8.Size = New System.Drawing.Size(40, 40)
        Me.picBox8.TabIndex = 199
        Me.picBox8.TabStop = False
        Me.picBox8.Tag = "greyobj"
        '
        'picBox6GREEN
        '
        Me.picBox6GREEN.BackColor = System.Drawing.Color.ForestGreen
        Me.picBox6GREEN.Location = New System.Drawing.Point(114, 93)
        Me.picBox6GREEN.Name = "picBox6GREEN"
        Me.picBox6GREEN.Size = New System.Drawing.Size(40, 40)
        Me.picBox6GREEN.TabIndex = 198
        Me.picBox6GREEN.TabStop = False
        Me.picBox6GREEN.Tag = "greyobj"
        '
        'picBox3
        '
        Me.picBox3.BackColor = System.Drawing.Color.DarkGray
        Me.picBox3.Location = New System.Drawing.Point(72, 93)
        Me.picBox3.Name = "picBox3"
        Me.picBox3.Size = New System.Drawing.Size(40, 40)
        Me.picBox3.TabIndex = 197
        Me.picBox3.TabStop = False
        Me.picBox3.Tag = "greyobj"
        '
        'picBox1
        '
        Me.picBox1.BackColor = System.Drawing.Color.DarkGray
        Me.picBox1.Location = New System.Drawing.Point(30, 135)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(40, 40)
        Me.picBox1.TabIndex = 194
        Me.picBox1.TabStop = False
        Me.picBox1.Tag = "greyobj"
        '
        'picBox26
        '
        Me.picBox26.BackColor = System.Drawing.Color.DarkGray
        Me.picBox26.Location = New System.Drawing.Point(72, 177)
        Me.picBox26.Name = "picBox26"
        Me.picBox26.Size = New System.Drawing.Size(40, 40)
        Me.picBox26.TabIndex = 193
        Me.picBox26.TabStop = False
        Me.picBox26.Tag = "greyobj"
        '
        'picBox2
        '
        Me.picBox2.BackColor = System.Drawing.Color.DarkGray
        Me.picBox2.Location = New System.Drawing.Point(30, 93)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(40, 40)
        Me.picBox2.TabIndex = 192
        Me.picBox2.TabStop = False
        Me.picBox2.Tag = "greyobj"
        '
        'picBox14
        '
        Me.picBox14.BackColor = System.Drawing.Color.DarkGray
        Me.picBox14.Location = New System.Drawing.Point(324, 135)
        Me.picBox14.Name = "picBox14"
        Me.picBox14.Size = New System.Drawing.Size(40, 40)
        Me.picBox14.TabIndex = 191
        Me.picBox14.TabStop = False
        Me.picBox14.Tag = "greyobj"
        '
        'picBox25
        '
        Me.picBox25.BackColor = System.Drawing.Color.DarkGray
        Me.picBox25.Location = New System.Drawing.Point(114, 177)
        Me.picBox25.Name = "picBox25"
        Me.picBox25.Size = New System.Drawing.Size(40, 40)
        Me.picBox25.TabIndex = 187
        Me.picBox25.TabStop = False
        Me.picBox25.Tag = "greyobj"
        '
        'picBox5
        '
        Me.picBox5.BackColor = System.Drawing.Color.DarkGray
        Me.picBox5.Location = New System.Drawing.Point(114, 135)
        Me.picBox5.Name = "picBox5"
        Me.picBox5.Size = New System.Drawing.Size(40, 40)
        Me.picBox5.TabIndex = 190
        Me.picBox5.TabStop = False
        Me.picBox5.Tag = "greyobj"
        '
        'picBox4
        '
        Me.picBox4.BackColor = System.Drawing.Color.DarkGray
        Me.picBox4.Location = New System.Drawing.Point(72, 135)
        Me.picBox4.Name = "picBox4"
        Me.picBox4.Size = New System.Drawing.Size(40, 40)
        Me.picBox4.TabIndex = 185
        Me.picBox4.TabStop = False
        Me.picBox4.Tag = "greyobj"
        '
        'picBox7LITE
        '
        Me.picBox7LITE.BackColor = System.Drawing.Color.GhostWhite
        Me.picBox7LITE.Location = New System.Drawing.Point(156, 93)
        Me.picBox7LITE.Name = "picBox7LITE"
        Me.picBox7LITE.Size = New System.Drawing.Size(40, 40)
        Me.picBox7LITE.TabIndex = 186
        Me.picBox7LITE.TabStop = False
        Me.picBox7LITE.Tag = "greyobj"
        Me.picBox7LITE.Visible = False
        '
        'picBox22LITE
        '
        Me.picBox22LITE.BackColor = System.Drawing.Color.GhostWhite
        Me.picBox22LITE.Location = New System.Drawing.Point(156, 177)
        Me.picBox22LITE.Name = "picBox22LITE"
        Me.picBox22LITE.Size = New System.Drawing.Size(40, 40)
        Me.picBox22LITE.TabIndex = 183
        Me.picBox22LITE.TabStop = False
        Me.picBox22LITE.Tag = "greyobj"
        Me.picBox22LITE.Visible = False
        '
        'picBoxEnd
        '
        Me.picBoxEnd.BackColor = System.Drawing.Color.DarkRed
        Me.picBoxEnd.Location = New System.Drawing.Point(30, 177)
        Me.picBoxEnd.Name = "picBoxEnd"
        Me.picBoxEnd.Size = New System.Drawing.Size(40, 40)
        Me.picBoxEnd.TabIndex = 206
        Me.picBoxEnd.TabStop = False
        '
        'picBox13
        '
        Me.picBox13.BackColor = System.Drawing.Color.DarkGray
        Me.picBox13.Location = New System.Drawing.Point(324, 93)
        Me.picBox13.Name = "picBox13"
        Me.picBox13.Size = New System.Drawing.Size(40, 40)
        Me.picBox13.TabIndex = 205
        Me.picBox13.TabStop = False
        Me.picBox13.Tag = "greyobj"
        '
        'picBox9
        '
        Me.picBox9.BackColor = System.Drawing.Color.DarkGray
        Me.picBox9.Location = New System.Drawing.Point(198, 135)
        Me.picBox9.Name = "picBox9"
        Me.picBox9.Size = New System.Drawing.Size(40, 40)
        Me.picBox9.TabIndex = 204
        Me.picBox9.TabStop = False
        Me.picBox9.Tag = "greyobj"
        '
        'picBox10BLUE
        '
        Me.picBox10BLUE.BackColor = System.Drawing.Color.DodgerBlue
        Me.picBox10BLUE.Location = New System.Drawing.Point(240, 135)
        Me.picBox10BLUE.Name = "picBox10BLUE"
        Me.picBox10BLUE.Size = New System.Drawing.Size(40, 40)
        Me.picBox10BLUE.TabIndex = 203
        Me.picBox10BLUE.TabStop = False
        Me.picBox10BLUE.Tag = "greyobj"
        '
        'picBox23
        '
        Me.picBox23.BackColor = System.Drawing.Color.DarkGray
        Me.picBox23.Location = New System.Drawing.Point(156, 219)
        Me.picBox23.Name = "picBox23"
        Me.picBox23.Size = New System.Drawing.Size(40, 40)
        Me.picBox23.TabIndex = 202
        Me.picBox23.TabStop = False
        Me.picBox23.Tag = "greyobj"
        '
        'picBox15
        '
        Me.picBox15.BackColor = System.Drawing.Color.DarkGray
        Me.picBox15.Location = New System.Drawing.Point(324, 177)
        Me.picBox15.Name = "picBox15"
        Me.picBox15.Size = New System.Drawing.Size(40, 40)
        Me.picBox15.TabIndex = 201
        Me.picBox15.TabStop = False
        Me.picBox15.Tag = "greyobj"
        '
        'picBox16
        '
        Me.picBox16.BackColor = System.Drawing.Color.DarkGray
        Me.picBox16.Location = New System.Drawing.Point(282, 177)
        Me.picBox16.Name = "picBox16"
        Me.picBox16.Size = New System.Drawing.Size(40, 40)
        Me.picBox16.TabIndex = 200
        Me.picBox16.TabStop = False
        Me.picBox16.Tag = "greyobj"
        '
        'picBox21GREEN
        '
        Me.picBox21GREEN.BackColor = System.Drawing.Color.Green
        Me.picBox21GREEN.Location = New System.Drawing.Point(198, 177)
        Me.picBox21GREEN.Name = "picBox21GREEN"
        Me.picBox21GREEN.Size = New System.Drawing.Size(40, 40)
        Me.picBox21GREEN.TabIndex = 196
        Me.picBox21GREEN.TabStop = False
        Me.picBox21GREEN.Tag = "greyobj"
        '
        'picBox11
        '
        Me.picBox11.BackColor = System.Drawing.Color.DarkGray
        Me.picBox11.Location = New System.Drawing.Point(240, 93)
        Me.picBox11.Name = "picBox11"
        Me.picBox11.Size = New System.Drawing.Size(40, 40)
        Me.picBox11.TabIndex = 189
        Me.picBox11.TabStop = False
        Me.picBox11.Tag = "greyobj"
        '
        'picBox12
        '
        Me.picBox12.BackColor = System.Drawing.Color.DarkGray
        Me.picBox12.Location = New System.Drawing.Point(282, 93)
        Me.picBox12.Name = "picBox12"
        Me.picBox12.Size = New System.Drawing.Size(40, 40)
        Me.picBox12.TabIndex = 188
        Me.picBox12.TabStop = False
        Me.picBox12.Tag = "greyobj"
        '
        'picBox17
        '
        Me.picBox17.BackColor = System.Drawing.Color.DarkGray
        Me.picBox17.Location = New System.Drawing.Point(282, 135)
        Me.picBox17.Name = "picBox17"
        Me.picBox17.Size = New System.Drawing.Size(40, 40)
        Me.picBox17.TabIndex = 195
        Me.picBox17.TabStop = False
        Me.picBox17.Tag = "greyobj"
        '
        'frmlvl9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(394, 376)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.picChar)
        Me.Controls.Add(Me.picBox20)
        Me.Controls.Add(Me.picBox19)
        Me.Controls.Add(Me.picBox24)
        Me.Controls.Add(Me.picBox18)
        Me.Controls.Add(Me.picBox8)
        Me.Controls.Add(Me.picBox6GREEN)
        Me.Controls.Add(Me.picBox3)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.picBox26)
        Me.Controls.Add(Me.picBox2)
        Me.Controls.Add(Me.picBox14)
        Me.Controls.Add(Me.picBox25)
        Me.Controls.Add(Me.picBox5)
        Me.Controls.Add(Me.picBox4)
        Me.Controls.Add(Me.picBox7LITE)
        Me.Controls.Add(Me.picBox22LITE)
        Me.Controls.Add(Me.picBoxEnd)
        Me.Controls.Add(Me.picBox13)
        Me.Controls.Add(Me.picBox9)
        Me.Controls.Add(Me.picBox10BLUE)
        Me.Controls.Add(Me.picBox23)
        Me.Controls.Add(Me.picBox15)
        Me.Controls.Add(Me.picBox16)
        Me.Controls.Add(Me.picBox21GREEN)
        Me.Controls.Add(Me.picBox11)
        Me.Controls.Add(Me.picBox12)
        Me.Controls.Add(Me.picBox17)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblSecs)
        Me.Controls.Add(Me.lblColon)
        Me.Controls.Add(Me.lblMinute)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmlvl9"
        Me.Text = "B² - Level 9"
        CType(Me.picChar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox6GREEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox7LITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox22LITE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox10BLUE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox21GREEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblSecs As System.Windows.Forms.Label
    Friend WithEvents lblColon As System.Windows.Forms.Label
    Friend WithEvents lblMinute As System.Windows.Forms.Label
    Friend WithEvents picChar As System.Windows.Forms.PictureBox
    Friend WithEvents picBox20 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox19 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox24 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox6GREEN As System.Windows.Forms.PictureBox
    Friend WithEvents picBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox26 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox14 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox25 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox7LITE As System.Windows.Forms.PictureBox
    Friend WithEvents picBox22LITE As System.Windows.Forms.PictureBox
    Friend WithEvents picBoxEnd As System.Windows.Forms.PictureBox
    Friend WithEvents picBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox9 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox10BLUE As System.Windows.Forms.PictureBox
    Friend WithEvents picBox23 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox15 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox16 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox11 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox17 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox21GREEN As System.Windows.Forms.PictureBox
    Friend WithEvents picBox18 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    Friend WithEvents tmrFlash As System.Windows.Forms.Timer
    Friend WithEvents tmrTime As System.Windows.Forms.Timer
    Friend WithEvents lblMessage As System.Windows.Forms.Label
End Class
