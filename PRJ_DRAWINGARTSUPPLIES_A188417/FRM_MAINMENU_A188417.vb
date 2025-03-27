Public Class FRM_MAINMENU_A188417
    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_SPLASHSCREEN_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_MAINMENU_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
    End Sub

    Private Sub FRM_MAINMENU_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Goodbye >_<")
        End
    End Sub

    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub BTN_STAFF_Click(sender As Object, e As EventArgs) Handles BTN_STAFF.Click
        FRM_STAFF_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_CUSTOMER_Click(sender As Object, e As EventArgs) Handles BTN_CUSTOMER.Click
        FRM_CUSTOMER_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_ORDER_Click(sender As Object, e As EventArgs) Handles BTN_ORDER.Click
        FRM_ORDER_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_PRODUCT_Click(sender As Object, e As EventArgs) Handles BTN_PRODUCT.Click
        FRM_PRODUCT_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_STAFF_MouseHover(sender As Object, e As EventArgs) Handles BTN_STAFF.MouseHover
        LBL_SUBTITLE.Text = "Show the 
Staff Details"
    End Sub

    Private Sub BTN_CUSTOMER_MouseHover(sender As Object, e As EventArgs) Handles BTN_CUSTOMER.MouseHover
        LBL_SUBTITLE.Text = "Show the 
Customer Details"
    End Sub

    Private Sub BTN_CREATEORDER_MouseHover(sender As Object, e As EventArgs) Handles BTN_ORDER.MouseHover
        LBL_SUBTITLE.Text = "Show the 
Order List"
    End Sub

    Private Sub BTN_PRODUCT_MouseHover(sender As Object, e As EventArgs) Handles BTN_PRODUCT.MouseHover
        LBL_SUBTITLE.Text = "Show the 
Product Catalog"
    End Sub

    Private Sub BTN_ORDERHISTORY_MouseHover(sender As Object, e As EventArgs)
        LBL_SUBTITLE.Text = "Show the 
Order Records"
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")

            End

        End If
    End Sub

    Private Sub BTN_MODIFY_Click(sender As Object, e As EventArgs) Handles BTN_MODIFY.Click
        FRM_MODIFY_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_PRODUCTLIST_Click(sender As Object, e As EventArgs) Handles BTN_PRODUCTLIST.Click
        FRM_PRODUCTLIST_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_PRODUCTLIST_MouseHover(sender As Object, e As EventArgs) Handles BTN_PRODUCTLIST.MouseHover
        LBL_SUBTITLE.Text = "Show the 
Product List"
    End Sub

    Private Sub BTN_MODIFY_MouseHover(sender As Object, e As EventArgs) Handles BTN_MODIFY.MouseHover
        LBL_SUBTITLE.Text = "Show the 
Modify Option"
    End Sub

    Private Sub BTN_MAKEORDER_MouseHover(sender As Object, e As EventArgs) Handles BTN_MAKEORDER.MouseHover
        LBL_SUBTITLE.Text = "Show the 
Make Order"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FRM_MAKENEWORDER_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_MAKEORDER_Click(sender As Object, e As EventArgs) Handles BTN_MAKEORDER.Click
        FRM_ORDEROPTION_A188417.Show()
        Me.Hide()
    End Sub
End Class