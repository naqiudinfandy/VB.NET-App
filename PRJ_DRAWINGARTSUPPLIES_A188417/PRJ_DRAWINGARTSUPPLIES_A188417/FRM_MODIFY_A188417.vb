Public Class FRM_MODIFY_A188417
    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_MAINMENU_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub FRM_MODIFY_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
    End Sub

    Private Sub BTN_MODIPRODUCT_Click(sender As Object, e As EventArgs) Handles BTN_MODIPRODUCT.Click
        FRM_MODIPRODUCT_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_MODISTAFF_Click(sender As Object, e As EventArgs) Handles BTN_MODISTAFF.Click
        FRM_MODISTAFF_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_MODICUSTOMER_Click(sender As Object, e As EventArgs) Handles BTN_MODICUSTOMER.Click
        FRM_MODICUSTOMER_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_MODIFY_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub BTN_MODIPRODUCT_MouseHover(sender As Object, e As EventArgs) Handles BTN_MODIPRODUCT.MouseHover
        LBL_SUBTITLE.Text = "Click here to modify 
product details"
    End Sub

    Private Sub BTN_MODISTAFF_MouseHover(sender As Object, e As EventArgs) Handles BTN_MODISTAFF.MouseHover
        LBL_SUBTITLE.Text = "Click here to modify 
staff details"
    End Sub

    Private Sub BTN_MODICUSTOMER_MouseHover(sender As Object, e As EventArgs) Handles BTN_MODICUSTOMER.MouseHover
        LBL_SUBTITLE.Text = "Click here to modify 
customer details"
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub
End Class