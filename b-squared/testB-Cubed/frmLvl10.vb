Public Class frmLvl10

    'declare our variables
    Public platform(34) As Object 'the platform the player is on consists of "N" objects (including the end box)
    Public Done(34) As Boolean 'the platform consists of "N" objects which means the amount of incomplete blocks are the same
    Public msgflash As Integer 'for the time remaining flash
    Public keyspressed As Boolean = True 'allows the player to move or not move
    Public Changed(1) As Boolean 'the blue block property that checks if it has changed

    Private Sub frmLvl10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set the form out
        Me.BringToFront()
        Me.Location = New Point(300, 300)
        Me.lblMinute.Text = overalltimeMin
        Me.lblSecs.Text = Format(overalltimeSec, "00")
        Me.lblMessage.Text = Nothing
        'set each platform index to their own respective block
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
        platform(10) = picBox11BLUE 'blue means the player has to move over it twice
        platform(11) = picBox12
        platform(12) = picBox13BLUE
        platform(13) = picBox14
        platform(14) = picBox15GREEN 'green means it shows new blocks
        platform(15) = picBox16
        platform(16) = picBox17
        platform(17) = picBox18
        platform(18) = picBox19
        platform(19) = picBox20
        platform(20) = picBox21
        platform(21) = picBox22
        platform(22) = picBox23LITE 'lite means the new blocks that are shown from hitting the green block
        platform(23) = picBox24LITE
        platform(24) = picBox25LITE
        platform(25) = picBox26LITE
        platform(26) = picBox27LITE
        platform(27) = picBox28LITE
        platform(28) = picBox29LITE
        platform(29) = picBox30LITE
        platform(30) = picBox31LITE
        platform(31) = picBox32LITE
        platform(32) = picBox33LITE
        platform(33) = picBox34LITE
        platform(34) = picBoxEnd 'the end box coloured in red

    End Sub
    Private Sub frmLvl10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'allows the player to move
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

        'since the LITE picboxes are on the form and are invisible (which still means the player is able to go on invisible blocks), it resets the players location
        'if the player hasn't touched the green block. if they have, nothing happens
        If (picChar.Bounds.IntersectsWith(platform(33).bounds) Or picChar.Bounds.IntersectsWith(platform(29).bounds) Or _
            picChar.Bounds.IntersectsWith(platform(22).bounds) Or picChar.Bounds.IntersectsWith(platform(23).bounds)) _
            And platform(14).size = New Size(40, 40) Then
            System.Threading.Thread.Sleep(80)
            picChar.Location = New Point(75, 318)
        End If

        'checks if the player has made contact with the end box
        If picChar.Bounds.IntersectsWith(picBoxEnd.Bounds) Then
            'if it has, then it checks if all the pictureboxes within the form are gone (size is set to (0,0))
            If picBox1.Size = New Size(0, 0) And _
            picBox4.Size = New Size(0, 0) And picBox5.Size = New Size(0, 0) And picBox6.Size = New Size(0, 0) And _
            picBox7.Size = New Size(0, 0) And picBox8.Size = New Size(0, 0) And picBox9.Size = New Size(0, 0) And _
            picBox10.Size = New Size(0, 0) And picBox11BLUE.Size = New Size(0, 0) And picBox12.Size = New Size(0, 0) And _
            picBox13BLUE.Size = New Size(0, 0) And picBox14.Size = New Size(0, 0) And picBox15GREEN.Size = New Size(0, 0) And _
            picBox16.Size = New Size(0, 0) And picBox17.Size = New Size(0, 0) And picBox18.Size = New Size(0, 0) And _
            picBox19.Size = New Size(0, 0) And picBox20.Size = New Size(0, 0) And picBox21.Size = New Size(0, 0) And _
            picBox22.Size = New Size(0, 0) And picBox23LITE.Size = New Size(0, 0) And picBox24LITE.Size = New Size(0, 0) And _
           picBox25LITE.Size = New Size(0, 0) And picBox26LITE.Size = New Size(0, 0) And picBox27LITE.Size = New Size(0, 0) And _
           picBox28LITE.Size = New Size(0, 0) And picBox29LITE.Size = New Size(0, 0) And picBox30LITE.Size = New Size(0, 0) And _
           picBox31LITE.Size = New Size(0, 0) And picBox32LITE.Size = New Size(0, 0) And picBox33LITE.Size = New Size(0, 0) And _
           picBox34LITE.Size = New Size(0, 0) Then
                'if they're all gone then
                keyspressed = False 'disable the players movement so ENTER or ESC can only be pressed
                tmrTime.Stop() 'stops the timer
                tmrFlash.Start() 'starts the msg flash
                Me.lblMessage.Text = "Level Complete! Press ENTER to move onto the next level." 'shows this text
                Delay(0.3) 'delay
                If e.KeyCode = Keys.Enter Then 'move onto the next level if enter is pressed
                    Me.Hide()
                    frmTime.Show()
                End If
            Else
                'if however the block intersects with the endbox but the pictures are still on the form, reset the players location
                keyspressed = False
                Delay(0.3)
                keyspressed = True
                picChar.Location = New Point(75, 308)
            End If
        End If

    End Sub

    Private Sub frmLvl10_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.Escape Then 'If esc key is pressed then
            Application.Exit() 'close application
        End If

    End Sub
    Sub visibility(ByRef box As Object)
        'sub is created to reduce redundancy of code
        'this sub is called once the player moves onto the next block
        box.visible = False 'sets the box to invisible just incase and
        'the size must be changed to 0 because the box is still visible (therefore are able to go backwards) which is not allowed
        box.size = New Size(0, 0)

        'if the box that is left is one of the blue blocks and it hasn't been changed yet (because it only changes once you've left) then
        If box.Equals(picBox11BLUE) = True And Changed(0) = False Then
            box.visible = True 'sets that box back to visible
            box.size = New Size(40, 40) 'sets the box size to the initial size of (40,40)
            picBox11BLUE.BackColor = Color.DeepSkyBlue 'changes the colour of the box for clarity
            Changed(0) = True 'the block has been changed, therefore set to true
            Done(10) = False 'platform(10) or picBox11BLUE has not been finished
        ElseIf Changed(0) = True Then 'once the block has been changed, it has the same properties as the other grey blocks
            box.visible = False
            'the size must be changed to 0 because the box is still visible
            'therefore are able to go backwards
            box.size = New Size(0, 0)
        End If

        'the same as above but with another blue block
        If box.Equals(picBox13BLUE) = True And Changed(1) = False Then
            box.visible = True
            box.size = New Size(40, 40)
            picBox13BLUE.BackColor = Color.DeepSkyBlue
            Changed(1) = True
            Done(12) = False
        ElseIf Changed(1) = True Then
            box.visible = False
            'the size must be changed to 0 because the box is still visible
            'therefore are able to go backwards
            box.size = New Size(0, 0)
        End If

    End Sub

    Private Sub tmrCheck_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheck.Tick

        For x As Integer = 0 To 34 'array of boxes for the platform
            If picChar.Bounds.IntersectsWith(platform(x).bounds) Then 'checks if the player is on the platform, if they are, 
                'leave the loop because it will cotinuously reset the player as they move
                Exit For
            ElseIf x = 34 Then 'if the player is not on the platform, reset the following:
                System.Threading.Thread.Sleep(80) 'like a delay to disable the form for 80ms once the player has left the platform
                picChar.Location = New Point(75, 308) 'the players location
                For i As Integer = 0 To 34 'for loop to reduce redundancy of platform reseting
                    picChar.Location = New Point(75, 308) 'the players location again just incase
                    platform(i).visible = True 'resets the platform back to visible but the LITE blocks are invisible which is further down
                    platform(i).size = New Size(40, 40) 'resets the platform back to (40,40) size
                    platform(10).backcolor = Color.DodgerBlue 'resets the colour of the blue block if the player went over it initially
                    platform(12).backcolor = Color.DodgerBlue
                    For num As Integer = 22 To 33 'another for loop for the LITE blocks which consists of platform(22) - platform(33) which sets them to invisible
                        platform(num).visible = False
                    Next
                    Done(i) = False 'resets the platform so that none of them are finished
                    For f As Integer = 0 To 1 'another for loop for the blue block in terms of changed to reduce redundancy if more than 2 blue blocks exist on a form
                        Changed(f) = False
                    Next
                Next
            End If
        Next

        For x As Integer = 0 To 34 'the same as the previous where it creates an array of boxes for the platform
            If picChar.Bounds.IntersectsWith(platform(x).bounds) Then 'if the player is on the platform
                Done(x) = True 'done is set to true which means the player has went over that block which then calls the sub visibility later on
                'touched the block that has a different property
                If picChar.Bounds.IntersectsWith(platform(14).bounds) Then 'if it has touched the green block
                    For num As Integer = 22 To 33 'another for loop to reduce rundandancy which sets the LITE blocks to visible
                        platform(num).visible = True
                    Next
                End If
            End If

            If Done(x) = True Then 'the player is done with that block and if they're still on the platform, nothing happens
                If picChar.Bounds.IntersectsWith(platform(x).bounds) Then
                Else 'if they aren't on it anymore
                    Call visibility(platform(x)) 'makes the previous block invisible and size(0,0)
                End If
            End If
        Next

    End Sub

    Private Sub tmrTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTime.Tick
        'the time remaining labels on the form
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
        'if the player's time has hit 0:00 then it does the following: 
        If overalltimeMin = 0 And overalltimeSec = 0 Then
            keyspressed = False 'disables movement
            tmrTime.Stop() 'the time remaining has stopped
            tmrFlash.Start() 'the msgflash begins
            Me.lblMessage.BringToFront() 'brings the message forward
            'the player already has access to ESC to exit the program but is just not informed
            Me.lblMessage.Text = "You ran out of time! Please press ESC to exit." 'sets the message to this
        End If

    End Sub

    Private Sub tmrFlash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrFlash.Tick

        msgflash += 1
        If msgflash >= 2 Then
            Me.lblMinute.Visible = False
            Me.lblColon.Visible = False
            Me.lblSecs.Visible = False
            'Me.lblMessage.Visible = False
            msgflash = 0
        Else
            Me.lblMinute.Visible = True
            Me.lblColon.Visible = True
            Me.lblSecs.Visible = True
            'Me.lblMessage.Visible = True
        End If

    End Sub

End Class