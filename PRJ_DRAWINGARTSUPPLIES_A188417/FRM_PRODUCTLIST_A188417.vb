Public Class FRM_PRODUCTLIST_A188417


    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_MAINMENU_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub FRM_PRODUCTLIST_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date

        'GRD_PRODUCT.DefaultCellStyle.ForeColor = Color.black
        GRD_PRODUCT.DefaultCellStyle.BackColor = Color.LemonChiffon

        refresh_grid(TXT_SEARCH.Text)
        refresh_text(GRD_PRODUCT.Text)
    End Sub

    Private Sub refresh_text(ID As String)

        Dim current_row As Integer = GRD_PRODUCT.CurrentRow.Index
        current_code = GRD_PRODUCT(0, current_row).Value

        TXT_NAME.Text = GRD_PRODUCT(1, current_row).Value
        TXT_PRICE.Text = GRD_PRODUCT(2, current_row).Value
        TXT_BRAND.Text = GRD_PRODUCT(3, current_row).Value
        TXT_CATEGORY.Text = GRD_PRODUCT(4, current_row).Value
        TXT_QUANTITY.Text = GRD_PRODUCT(5, current_row).Value
        TXT_WARRANTY.Text = GRD_PRODUCT(6, current_row).Value

    End Sub

    Private Sub refresh_grid(search_text As String)
        GRD_PRODUCT.DataSource = run_select("SELECT * FROM TBL_PRODUCT_A188417 WHERE FLD_PRODUCT_NAME LIKE '%" & search_text & "%' ORDER BY FLD_PRODUCT_ID")

        GRD_PRODUCT.Columns(0).HeaderText = "ID"
        GRD_PRODUCT.Columns(1).HeaderText = "Name"
        GRD_PRODUCT.Columns(2).HeaderText = "Price (In 'RM')"
        GRD_PRODUCT.Columns(3).HeaderText = "Brand"
        GRD_PRODUCT.Columns(4).HeaderText = "Category"
        GRD_PRODUCT.Columns(5).HeaderText = "Quantity"
        GRD_PRODUCT.Columns(6).HeaderText = "Warranty Length"
    End Sub

    Private Sub FRM_PRODUCTLIST_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub TXT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXT_SEARCH.TextChanged
        refresh_grid(TXT_SEARCH.Text)
    End Sub

    Private Sub GRD_PRODUCT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_PRODUCT.CellContentClick

    End Sub

    Private Sub GRD_PRODUCT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_PRODUCT.CellClick
        get_current_code()
    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = GRD_PRODUCT.CurrentRow.Index
        current_code = GRD_PRODUCT(0, current_row).Value
        TXT_ID.Text = current_code
        TXT_NAME.Text = GRD_PRODUCT(1, current_row).Value
        TXT_PRICE.Text = GRD_PRODUCT(2, current_row).Value
        TXT_BRAND.Text = GRD_PRODUCT(3, current_row).Value
        TXT_CATEGORY.Text = GRD_PRODUCT(4, current_row).Value
        TXT_QUANTITY.Text = GRD_PRODUCT(5, current_row).Value
        TXT_WARRANTY.Text = GRD_PRODUCT(6, current_row).Value

    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_grid(TXT_SEARCH.Text)
    End Sub
End Class