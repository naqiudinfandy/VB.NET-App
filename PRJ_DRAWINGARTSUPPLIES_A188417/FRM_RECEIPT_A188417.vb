Public Class FRM_RECEIPT_A188417
    Dim lastrow As Integer
    Dim total As Double
    Private Sub FRM_RECEIPT_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_frame()
    End Sub
    Private Sub refresh_frame()

        refresh_lst()
        refresh_text(lst_order.Text)

    End Sub
    Private Sub refresh_lst()

        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A188417"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        lst_order.DataSource = mydatatable
        lst_order.DisplayMember = "FLD_ORDER_ID"

        refresh_text(lst_order.Text)

    End Sub
    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A188417 WHERE FLD_ORDER_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lbl_orderid.Text = mydatatable.Rows(0).Item("FLD_ORDER_ID")
        lbl_custid.Text = mydatatable.Rows(0).Item("FLD_CUST_ID")
        lbl_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        refresh_cust(lbl_custid.Text)
        refresh_staff(lbl_staffid.Text)
        lbl_orderid.Text = lst_order.Text
        refresh_grid()

    End Sub

    Private Sub refresh_cust(id As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A188417 WHERE FLD_CUST_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lbl_firstname.Text = mydatatable.Rows(0).Item("FLD_CUST_FIRSTNAME")
        lbl_lastname.Text = mydatatable.Rows(0).Item("FLD_CUST_LASTNAME")
        lbl_phonenum.Text = mydatatable.Rows(0).Item("FLD_CUST_PHONENUM")
        lbl_email.Text = mydatatable.Rows(0).Item("FLD_CUST_EMAIL")
        lbl_gender.Text = mydatatable.Rows(0).Item("FLD_CUST_GENDER")


    End Sub
    Private Sub refresh_staff(id As String)

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A188417 WHERE FLD_STAFF_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        lbl_staffid.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")

    End Sub
    Private Sub refresh_grid()

        grd_order.DataSource = run_select("SELECT FLD_PRODUCT_ID, FLD_PRODUCT_QUANTITY, FLD_PRODUCT_PRICE, FLD_PRODUCT_PRICE AS Subtotal FROM TBL_DETAILSOFORDER_A188417 WHERE FLD_ORDER_ID='" & LST_ORDER.Text & "'")
        lastrow = grd_order.Rows.Count - 1

        For i As Integer = 0 To lastrow
            Dim price As String = grd_order(3, i).Value

            Dim PriceD As Double
            PriceD = Convert.ToDouble(price)

            Dim finalPrice As Double
            finalPrice = finalPrice + price

            lbl_autototal.Text = finalPrice.ToString()
        Next
        grd_order.Columns(0).HeaderText = "Product ID"
        grd_order.Columns(1).HeaderText = "Quantity"
        grd_order.Columns(2).HeaderText = "Price"
        grd_order.Columns(3).HeaderText = "Total Price"
    End Sub
    Private Sub lst_order_MouseClick(sender As Object, e As MouseEventArgs) Handles lst_order.MouseClick
        refresh_text(lst_order.Text)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FRM_ORDER_A188417.Show()
        Me.Hide()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FRM_MAINMENU_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        refresh_frame()
    End Sub

    Private Sub FRM_RECEIPT_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub
End Class