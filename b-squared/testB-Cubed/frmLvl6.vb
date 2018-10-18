Public Class frmLvl6
    'go to frmLvl10 for the comments since it incorporates all the different block properties
    Public platform(28) As Object
    Public done(28) As Boolean
    Public keyspressed As Boolean = True
    Public msgflash As Integer

    Private Sub frmLvl6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BringToFront()
        Me.Location = New Point(300, 300)
        Me.lblMinute.Text = overalltimeMin
        Me.lblSecs.Text = Format(overalltimeSec, "00")
        Me.lblMessage.Text = Nothing

        platform(0) = picBox1
        platform(1) = picBox2
        platform(2) = picBox3
        platform(3) = picBox4
        platform(4) = picBox5
        platform(5) = picBox6
        platform(6) = picBox7
        platform(7) = picBox8
        platform(8) = picBox9
        platform(9) = picBox10
        platform(10) = picBox11GREEN
        platform(11) = picBox12LITE
        platform(12) = picBox13LITE
        platform(13) = picBox14
        platform(14) = picBox15
        platform(15) = picBox16
        platform(16) = picBox17
        platform(17) = picBox18
        platform(18) = picBox19
        platform(19) = picBox20
        platform(20) = picBox21
        platform(21) = picBox22
        platform(22) = picBox23
        platform(23) = picBox24
        platform(24) = picBox25
        platform(25) = picBox26
        platform(26) = picBox27
        platform(27) = picBox28
        platform(28) = picBoxEnd

    End Sub

    Private Sub frmLvl6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If keyspressed = True Then
            If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
                picChar.Left -= 42
            End If
            If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
                picChar.Left += 42
            End If
            If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
                picChar.Top += 42
            End If
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
                picChar.Top -= 42
            End If
        End If

        If picChar.Bounds.IntersectsWith(picBoxEnd.Bounds) Then
            If picBox1.Size = New Size(0, 0) And picBox2.Size = New Size(0, 0) And picBox3.Size = New Size(0, 0) And _
            picBox4.Size = New Size(0, 0) And picBox5.Size = New Size(0, 0) And picBox6.Size = New Size(0, 0) And _
            picBox7.Size = New Size(0, 0) And picBox8.Size = New Size(0, 0) And picBox9.Size = New Size(0, 0) And _
            picBox10.Size = New Size(0, 0) And picBox11GREEN.Size = New Size(0, 0) And picBox12LITE.Size = New Size(0, 0) And _
            picBox13LITE.Size = New Size(0, 0) And picBox14.Size = New Size(0, 0) And picBox15.Size = New Size(0, 0) And _
            picBox16.Size = New Size(0, 0) And picBox17.Size = New Size(0, 0) And picBox18.Size = New Size(0, 0) And _
            picBox19.Size = New Size(0, 0) And picBox20.Size = New Size(0, 0) And picBox21.Size = New Size(0, 0) And _
            picBox22.Size = New Size(0, 0) And picBox23.Size = New Size(0, 0) And picBox24.Size = New Size(0, 0) And _
            picBox25.Size = New Size(0, 0) And picBox26.Size = New Size(0, 0) And picBox27.Size = New Size(0, 0) Then
                keyspressed = False
                tmrTime.Stop()
                tmrFlash.Start()
                Me.lblMessage.Text = "Level Complete! Press ENTER to move onto the next level."
                Delay(0.3)
                If e.KeyCode = Keys.Enter Then
                    Me.Hide()
                    frmLvl7.Show()
                End If
            Else
                keyspressed = False
                Delay(0.3)
                keyspressed = True
                picChar.Location = New Point(159, 144)
            End If
        End If

    End Sub

    Private Sub frmLvl6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Escape Then
            Application.Exit()
        End If

    End Sub

    Sub visibility(ByRef box As Object)

        box.visible = False
        'the size must be changed to 0 because the box is still visible
        'therefore are able to go backwards
        box.size = New Size(0, 0)

    End Sub

    Private Sub tmrCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheck.Tick

        For x As Integer = 0 To 28 'array of boxes
            If picChar.Bounds.IntersectsWith(platform(x).bounds) Then
                Exit For
            ElseIf x = 28 Then 'if char is not in any boxes reset location (214,148)
                System.Threading.Thread.Sleep(80)
                picChar.Location = New Point(159, 144)
                For i As Integer = 0 To 28 'Reseting Portion
                    picChar.Location = New Point(159, 144)
                    platform(i).visible = True
                    platform(i).size = New Size(40, 40)
                    platform(11).visible = False
                    platform(12).visible = False
                    done(i) = False 'resets program to think no blocks have been touched
                Next
            End If
        Next

        For x As Integer = 0 To 28 'finds the block you just left and puts it into asd
            If picChar.Bounds.IntersectsWith(platform(x).bounds) Then
                done(x) = True 'touched a block 
                'touched the block that has a different property
                If picChar.Bounds.IntersectsWith(platform(10).bounds) Then
                    platform(11).visible = True
                    platform(12).visible = True
                End If
            End If
            If done(x) = True Then 'if block x is touched and
                If picChar.Bounds.IntersectsWith(platform(x).bounds) Then
                Else 'you aren't on it anymore
                    Call visibility(platform(x)) 'makes block invisible and size(0,0), edit ASD for what happens to blocks
                End If
            End If
        Next

    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick

        overalltimeSec -= 1
        Me.lblMinute.Text = overalltimeMin
        Me.lblSecs.Text = overalltimeSec
        If overalltimeSec < 10 And overalltimeSec >= 0 Then
            Me.lblSecs.Text = (Format(overalltimeSec, "00"))
        ElseIf overalltimeSec < 0 Then
            overalltimeMin -= 1
            Me.lblMinute.Text = overalltimeMin
            overalltimeSec = 59
            Me.lblSecs.Text = overalltimeSec
        End If
        If overalltimeMin = 0 And overalltimeSec = 0 Then
            keyspressed = False
            tmrTime.Stop()
            tmrFlash.Start()
            Me.lblMessage.Text = "You ran out of time! Please press ESC to exit."
        End If

    End Sub

    Private Sub tmrFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlash.Tick

        msgflash += 1
        If msgflash >= 2 Then
            Me.lblMinute.Visible = False
            Me.lblColon.Visible = False
            Me.lblSecs.Visible = False
            msgflash = 0
        Else
            Me.lblMinute.Visible = True
            Me.lblColon.Visible = True
            Me.lblSecs.Visible = True
        End If

    End Sub

End Class