Public Class FRM_SPLASHSCREEN_A188417
    Private Sub FRM_SPLASHSCREEN_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_date.Text = current_date

    End Sub

    Private Sub FRM_SPLASHSCREEN_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub BTN_START_Click(sender As Object, e As EventArgs) Handles BTN_START.Click
        MsgBox("Welcome " & TXT_NAME.Text & " ( " & TXT_MATRIC.Text & " ) to the ARTISTIC ART SUPPLIER")
        username = TXT_NAME.Text
        matric = TXT_MATRIC.Text
        FRM_MAINMENU_A188417.Show()
        Me.Hide()

    End Sub

    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        lbl_date.Text = current_date
    End Sub

    Private Sub lbl_date_Click(sender As Object, e As EventArgs) Handles lbl_date.Click

    End Sub
End Class