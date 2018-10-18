Public Class frmCredits

    Private Sub frmCredits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(300, 300)
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If creditsoption = 0 Then
            frm1Open.Show()
            frm1Open.BringToFront()
            Me.Hide()
        Else
            frmTime.Show()
            frmTime.BringToFront()
            Me.Hide()
        End If

    End Sub

End Class