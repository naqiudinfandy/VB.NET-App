Public Class FRM_MAKENEWORDER_A188417

    Dim number As Double
    Dim number1 As Double
    Dim c As String
    Dim duit As Double
    Dim num As Integer
    Dim current_code As String
    Dim current_code1 As String
    Dim current_code2 As String

    Private Sub FRM_MAKENEWORDER_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        get_current_code()
        Dim current_date As String = Date.Now
        tb_date.Text = current_date
        c = 100
        refresh_count()
        refresh_staff()
        btn_addcart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        grd_customer.DefaultCellStyle.BackColor = Color.LemonChiffon
        grd_customer.DefaultCellStyle.ForeColor = Color.Maroon
        grd_orderlist.DefaultCellStyle.BackColor = Color.LemonChiffon
        grd_orderlist.DefaultCellStyle.ForeColor = Color.Maroon

        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A188417 ORDER BY FLD_PRODUCT_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        lst_product.DataSource = mydatatable
        lst_product.DisplayMember = "FLD_PRODUCT_ID"

        refresh_text(lst_product.Text)
    End Sub
    Private Sub refresh_text(ByVal product As String)
        Dim mysql As String = "SELECT * FROM TBL_PRODUCT_A188417 WHERE FLD_PRODUCT_ID='" & product & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        LBL_PRODUCTID.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_ID")
        TXT_NAME.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_NAME")
        TXT_PRICE.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_PRICE")
        TXT_BRAND.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_BRAND")
        TXT_CATEGORY.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_CATEGORY")
        TXT_STOCK.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_QUANTITY")
        TXT_WARRANTY.Text = mydatatable.Rows(0).Item("FLD_PRODUCT_WARRANTYLENGTH")
        TXT_TOTAL.Text = num * TXT_PRICE.Text

        Try

            pic_product.BackgroundImage = Image.FromFile("Picture/" & LBL_PRODUCTID.Text & ".jpg")

        Catch ex As Exception

            pic_product.BackgroundImage = Image.FromFile("Picture/no_photo.jpg")

        End Try
    End Sub

    Private Sub refresh_list()
        lst_product.DataSource = run_select("SELECT * FROM TBL_PRODUCT_A188417 ORDER BY FLD_PRODUCT_ID")
        lst_product.DisplayMember = "FLD_STAFF_ID"
    End Sub

    Private Sub lst_product_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_product.MouseClick
        refresh_text(lst_product.Text)
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NUM_QUANTITY.ValueChanged
        num = NUM_QUANTITY.Value
        number1 = TXT_PRICE.Text()
        TXT_TOTAL.Text = num * number1
    End Sub

    Private Sub refresh_grid()
        Dim mysql2 As String = "SELECT * FROM TBL_CUSTOMER_A188417"
        Dim mydatatable2 As New DataTable
        Dim myreader2 As New OleDb.OleDbDataAdapter(mysql2, myconnection)
        myreader2.Fill(mydatatable2)
        grd_customer.DataSource = mydatatable2
        grd_customer.Columns(0).HeaderText = "ID"
        grd_customer.Columns(1).HeaderText = "FIRST NAME"
        grd_customer.Columns(2).HeaderText = "LAST NAME"
        grd_customer.Columns(3).HeaderText = "PHONE NUMBER"
        grd_customer.Columns(4).HeaderText = "EMAIL"
        grd_customer.Columns(5).HeaderText = "GENDER"


    End Sub

    Private Sub get_current_code()
        Dim current_row As Integer = grd_customer.CurrentRow.Index
        current_code = grd_customer(0, current_row).Value
        tb_id_customer.Text = current_code
        tb_custname.Text = grd_customer(1, current_row).Value
    End Sub

    Private Sub grd_customer_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_customer.CellContentClick
        get_current_code()
    End Sub

    Private Sub refresh_staff()

        Dim mysql As String = "SELECT FLD_STAFF_ID FROM TBL_STAFF_A188417 ORDER BY FLD_STAFF_ID"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        cmb_staffid.DataSource = mydatatable
        cmb_staffid.DisplayMember = "FLD_STAFF_ID"

    End Sub

    Private Sub refresh_count()

        Dim count As Integer = 1
        Dim mysql As String = "SELECT COUNT (FLD_ORDER_ID) As count_id FROM TBL_ORDER_A188417"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        count += mydatatable.Rows(0).Item("count_id")
        lbl_orderid.Text = "D-" + count.ToString("000")

    End Sub

    Private Sub btn_neworder_Click(sender As Object, e As EventArgs) Handles btn_neworder.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()
        mytransaction = myconnection2.BeginTransaction
        Try

            Dim mysql As String = "INSERT INTO TBL_ORDER_A188417 (FLD_ORDER_ID, FLD_STAFF_ID, FLD_CUST_ID) values (""" &
            lbl_orderid.Text & """,""" & cmb_staffid.Text & """,""" & tb_id_customer.Text & """)"

            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2,
            mytransaction)

            mywriter.ExecuteNonQuery()
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("You can make new order now!")
            refresh_grid()
            grd_orderlist.Rows.Clear()

        Catch ex As Exception

            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addcart.Enabled = True
        btn_confirm.Enabled = True
        btn_remove.Enabled = True
        btn_neworder.Enabled = False
    End Sub

    Private Sub btn_addcart_Click(sender As Object, e As EventArgs) Handles btn_addcart.Click
        grd_orderlist.Rows.Add(New String() {LBL_PRODUCTID.Text, TXT_NAME.Text, NUM_QUANTITY.Value, TXT_TOTAL.Text})
        TXT_TOTAL.Text = ""
        NUM_QUANTITY.Value = 0
        lbl_total.Text = " "
        refresh_price()
    End Sub
    Private Sub refresh_price()

        If grd_orderlist.RowCount > 0 Then
            duit = 0

            For index As Integer = 0 To grd_orderlist.RowCount - 1
                duit += Convert.ToDouble(grd_orderlist.Rows(index).Cells(3).Value)
            Next

            lbl_total.Text = "RM " & duit
        ElseIf grd_orderlist.RowCount = 1 Then

            lbl_total.Text = "RM 0"

        End If

    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim delete_order = MsgBox("Confirm to delete this item from list?", MsgBoxStyle.YesNo)

        If delete_order = MsgBoxResult.Yes Then
            grd_orderlist.Rows.Remove(grd_orderlist.CurrentRow)
            refresh_price()
        Else
            refresh_price()
        End If
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim mytransaction As OleDb.OleDbTransaction
        myconnection2.Open()

        mytransaction = myconnection2.BeginTransaction
        Try
            For i As Integer = 0 To grd_orderlist.RowCount - 1
                Dim productid As String = grd_orderlist(0, i).Value
                Dim productname As String = grd_orderlist(1, i).Value
                Dim quantity As String = grd_orderlist(2, i).Value
                Dim price As String = grd_orderlist(3, i).Value


                Dim mysql As String = "insert into TBL_DETAILSOFORDER_A188417 (FLD_ORDER_ID, FLD_PRODUCT_ID, FLD_PRODUCT_QUANTITY, FLD_PRODUCT_PRICE) values (""" & lbl_orderid.Text & """, """ & productid & """, """ & quantity & """, """ & price & """)"
                Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2, mytransaction)


                mywriter.ExecuteNonQuery()

            Next
            mytransaction.Commit()
            myconnection2.Close()
            Beep()
            MsgBox("Transaction successful!")
            refresh_grid()
            grd_orderlist.Rows.Clear()



        Catch ex As Exception
            Beep()
            MsgBox("Problem with transaction:" & vbCrLf & vbCrLf & ex.Message)
            mytransaction.Rollback()
            myconnection2.Close()
            refresh_grid()

        End Try

        btn_addcart.Enabled = False
        btn_confirm.Enabled = False
        btn_remove.Enabled = False
        btn_neworder.Enabled = True
        NUM_QUANTITY.Value = 0
        lbl_total.Text = "0"
        refresh_count()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        FRM_ORDER_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub btn_detail_Click(sender As Object, e As EventArgs) Handles btn_detail.Click
        FRM_DETAILSOFORDER_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_EXIT_Click_1(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
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

    Private Sub FRM_MAKENEWORDER_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tb_date.Text = current_date
        current_date = Date.Now
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        refresh_list()
    End Sub
End Class