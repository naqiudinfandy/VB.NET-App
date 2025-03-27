Public Class FRM_ORDEROPTION_A188417
    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")

            End

        End If
    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_MAINMENU_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_ORDEROPTION_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
    End Sub

    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FRM_MAKENEWORDER_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FRM_DETAILSOFORDER_A188417.Show()
        Me.Hide()
    End Sub
End Class