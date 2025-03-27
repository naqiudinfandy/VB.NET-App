Public Class FRM_LOADINGPAGE_A188417
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.PROGBAR.Value = PROGBAR.Value + 1
        If PROGBAR.Value >= 100 Then
            Timer1.Stop()
            FRM_SPLASHSCREEN_A188417.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub FRM_LOADINGPAGE_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
