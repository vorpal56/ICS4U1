Public Class frm1Open
    'Anthony Sukadil and David Neale
    'B² (B-squared)
    'ICS4U1
    'Mr. MacAskill
    'All comments are on frmLvl10 as it consists of all different block properties

    Private Sub frm1Open_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(300, 300)
    End Sub
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        'opens the first form
        frmLvl1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCredits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredits.Click
        'shows the credits form
        frmCredits.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'closes the program
        Application.Exit()
    End Sub

End Class