Public Class FRM_PRODUCT_A188417
    Private Sub FRM_PRODUCT_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date

        refresh_lst()
        refresh_text(LST_PRODUCT.Text)
    End Sub

    Private Sub refresh_lst()
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A188417 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        LST_PRODUCT.DataSource = mydatatable
        LST_PRODUCT.DisplayMember = "FLD_PRODUCT_ID"
    End Sub

    Private Sub refresh_text(ID As String)

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A188417 WHERE FLD_PRODUCT_ID ='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        TXT_ID.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        TXT_NAME.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        TXT_PRICE.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE")
        TXT_BRAND.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_BRAND")
        TXT_CATEGORY.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_CATEGORY")
        TXT_QUANTITY.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_QUANTITY")
        TXT_WARRANTY.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_WARRANTYLENGTH")

        PIC_PRODUCT.BackgroundImage = Image.FromFile("Picture/" & TXT_ID.Text & ".jpg")

    End Sub

    Private Sub LST_ID_MouseClick(sender As Object, e As MouseEventArgs) Handles LST_PRODUCT.MouseClick
        refresh_text(LST_PRODUCT.Text)
    End Sub

    Private Sub FRM_PRODUCT_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_MAINMENU_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_lst()
    End Sub
End Class