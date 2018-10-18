Public Class frmTime
    Public msgflash As Integer
    Private Sub Overalltime_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmrFlash.Start()
        Me.BringToFront()
        Me.Location = New Point(300, 300)
        lblSecs.Text = Format(overalltimeSec, "00")
        lblMinute.Text = Format(overalltimeMin, "00")

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredits.Click
        frmCredits.Show()
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

    Private Sub btnReplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplay.Click
        frm1Open.Show()
        frmCredits.Close()
        frmLvl1.Close()
        frmLvl2.Close()
        frmLvl3.Close()
        frmLvl4.Close()
        frmLvl5.Close()
        frmLvl6.Close()
        frmLvl7.Close()
        frmLvl8.Close()
        frmlvl9.Close()
        frmLvl10.Close()
        Me.Hide()
        creditsoption = 0
    End Sub
End Class