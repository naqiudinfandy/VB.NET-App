Public Class FRM_ORDER_A188417
    Dim lastrow As Integer
    Dim total As Double
    Private Sub FRM_ORDER_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
        GRD_ORDER.DefaultCellStyle.BackColor = Color.LemonChiffon
        refresh_frame()

    End Sub

    Private Sub FRM_ORDER_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
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
    Private Sub refresh_frame()

        refresh_lst()
        refresh_text(LST_ORDER.Text)

    End Sub

    Private Sub refresh_lst()

        Dim mysql As String = "SELECT FLD_ORDER_ID FROM TBL_ORDER_A188417"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        LST_ORDER.DataSource = mydatatable
        LST_ORDER.DisplayMember = "FLD_ORDER_ID"

        refresh_text(LST_ORDER.Text)

    End Sub
    Private Sub refresh_text(id As String)
        Dim mysql As String = "SELECT * FROM TBL_ORDER_A188417 WHERE FLD_ORDER_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        TXT_CUSTID.Text = mydatatable.Rows(0).Item("FLD_CUST_ID")
        TXT_STAFFID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        refresh_cust(TXT_CUSTID.Text)
        refresh_staff(TXT_STAFFID.Text)
        refresh_grid()

    End Sub
    Private Sub refresh_cust(id As String)

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A188417 WHERE FLD_CUST_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        TXT_FIRSTNAME.Text = mydatatable.Rows(0).Item("FLD_CUST_FIRSTNAME")
        TXT_LASTNAME.Text = mydatatable.Rows(0).Item("FLD_CUST_LASTNAME")
        TXT_PHONENUM.Text = mydatatable.Rows(0).Item("FLD_CUST_PHONENUM")
        TXT_EMAIL.Text = mydatatable.Rows(0).Item("FLD_CUST_EMAIL")
        TXT_GENDER.Text = mydatatable.Rows(0).Item("FLD_CUST_GENDER")

    End Sub
    Private Sub refresh_staff(id As String)

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A188417 WHERE FLD_STAFF_ID='" & id & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        TXT_STAFFNAME.Text = mydatatable.Rows(0).Item("FLD_STAFF_FIRSTNAME")

    End Sub
    Private Sub refresh_grid()

        GRD_ORDER.DataSource = run_select("SELECT FLD_PRODUCT_ID, FLD_PRODUCT_QUANTITY, FLD_PRODUCT_PRICE, [FLD_PRODUCT_PRICE]*[FLD_PRODUCT_QUANTITY] AS Subtotal FROM TBL_DETAILSOFORDER_A188417 WHERE FLD_ORDER_ID = '" & LST_ORDER.Text & "'")
        lastrow = GRD_ORDER.Rows.Count - 1

        For i As Integer = 0 To lastrow
            Dim price As String = GRD_ORDER(3, i).Value

            Dim PriceD As Double
            PriceD = Convert.ToDouble(price)

            Dim finalPrice As Double
            finalPrice = finalPrice + price

            lbl_totalprice.Text = finalPrice.ToString()
        Next
        GRD_ORDER.Columns(0).HeaderText = "Product ID"
        GRD_ORDER.Columns(1).HeaderText = "Quantity"
        GRD_ORDER.Columns(2).HeaderText = "Price per product"
    End Sub
    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub LST_ORDER_MouseClick(sender As Object, e As MouseEventArgs) Handles LST_ORDER.MouseClick
        refresh_text(LST_ORDER.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_frame()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FRM_RECEIPT_A188417.Show()
        Me.Hide()
    End Sub
End Class