Public Class FormSetting
    Private Sub btnwhat_Click(sender As Object, e As EventArgs) Handles btnwhat.Click
        If tbwhat.Visible = False Then
            animation2.ShowSync(tbwhat)
        Else

            animation2.HideSync(tbwhat)
        End If
    End Sub

    Private Sub FormSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles btncan.Click
        If tbcan.Visible = False Then
            animation2.ShowSync(tbcan)
        Else
            animation2.HideSync(tbcan)
        End If
    End Sub
End Class