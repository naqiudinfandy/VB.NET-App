Public Class FRM_DETAILSOFORDER_A188417
    Dim t As Double

    Private Sub FRM_DETAILSOFORDER_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        refresh_grid()
        refresh_price()
    End Sub

    Private Sub refresh_grid()


        'Dim mysql As String = "SELECT TBL_DETAILSOFORDER_A188417.FLD_ORDER_ID, TBL_DETAILSOFORDER_A188417.FLD_PRODUCT_ID, TBL_DETAILSOFORDER_A188417.FLD_PRODUCT_QUANTITY ,TBL_PRODUCT_A188417.FLD_PRODUCT_PRICE FROM TBL_DETAILSOFORDER_A188417 INNER JOIN TBL_PRODUCT_A188417 ON TBL_DETAILSOFORDER_A188417.FLD_PRODUCT_ID=TBL_PRODUCTS_A188417.FLD_PRODUCT_ID where TBL_DETAILSOFORDER_A188417.FLD_ORDER_ID like""%" & cmb_id.Text & "%"" "
        Dim mysql As String = "SELECT * FROM TBL_DETAILSOFORDER_A188417 ORDER BY FLD_ORDER_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_detail.DataSource = mydatatable

        grd_detail.Columns(0).HeaderText = "ORDER ID"
        grd_detail.Columns(1).HeaderText = "Product ID"
        grd_detail.Columns(2).HeaderText = "Order Quantity"
        grd_detail.Columns(3).HeaderText = "Product Price"


    End Sub


    Private Sub cmb_id_SelectedIndexChanged(sender As Object, e As EventArgs)
        refresh_grid()

        refresh_price()
    End Sub



    Private Sub refresh_price()

        If grd_detail.RowCount > 1 Then
            t = 0
            For index As Integer = 0 To grd_detail.RowCount - 1
                t += Convert.ToDouble(grd_detail.Rows(index).Cells(3).Value) * (grd_detail.Rows(index).Cells(2).Value)
            Next
            lbl_total.Text = "RM " & t
        ElseIf grd_detail.RowCount = 1 Then
            lbl_total.Text = "RM 0"
        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")

            End

        End If
    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_ORDEROPTION_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_DETAILSOFORDER_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class