Public Class FRM_MODICUSTOMER_A188417
    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub FRM_INSERTCUSTOMER_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
        GRD_CUSTOMER.DefaultCellStyle.BackColor = Color.LemonChiffon

        refresh_grid()

        TXT_ID.Text = generate_ID()

    End Sub

    Private Sub refresh_grid()
        GRD_CUSTOMER.DataSource = run_select("SELECT * FROM TBL_CUSTOMER_A188417 ORDER BY FLD_CUST_ID")

        CMB_GENDER.Items.Add("Male")
        CMB_GENDER.Items.Add("Female")
        CMB_GENDER.SelectedIndex = 0

        GRD_CUSTOMER.Columns(0).HeaderText = "ID"
        GRD_CUSTOMER.Columns(1).HeaderText = "FIRST NAME"
        GRD_CUSTOMER.Columns(2).HeaderText = "LAST NAME"
        GRD_CUSTOMER.Columns(3).HeaderText = "PHONE NUM"
        GRD_CUSTOMER.Columns(4).HeaderText = "EMAIL"
        GRD_CUSTOMER.Columns(5).HeaderText = "GENDER"

        TXT_ID.Text = generate_ID()
        TXT_FIRSTNAME.Text = ""
        TXT_LASTNAME.Text = ""
        TXT_PHONENUM.Text = ""
        TXT_EMAIL.Text = ""

    End Sub

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_MODIFY_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub get_current_code()

        Dim current_row As Integer = GRD_CUSTOMER.CurrentRow.Index
        current_code = GRD_CUSTOMER(0, current_row).Value

        TXT_ID.Text = current_code
        TXT_FIRSTNAME.Text = GRD_CUSTOMER(1, current_row).Value
        TXT_LASTNAME.Text = GRD_CUSTOMER(2, current_row).Value
        TXT_PHONENUM.Text = GRD_CUSTOMER(3, current_row).Value
        TXT_EMAIL.Text = GRD_CUSTOMER(4, current_row).Value
        CMB_GENDER.Text = GRD_CUSTOMER(5, current_row).Value

    End Sub

    Private Sub clear_fields()

        TXT_ID.Text = generate_ID()
        TXT_FIRSTNAME.Text = ""
        TXT_LASTNAME.Text = ""
        TXT_PHONENUM.Text = ""
        TXT_EMAIL.Text = ""
        CMB_GENDER.SelectedIndex = 0

    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub FRM_INSERTCUSTOMER_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Function generate_ID() As String
        Dim lastID As String = run_select("SELECT MAX(FLD_CUST_ID) AS MAXID FROM TBL_CUSTOMER_A188417").Rows(0).Item("MAXID")
        Dim nextID As String = "C000" & (Mid(lastID, 2) + 1)
        Return nextID

    End Function

    Private Sub BTN_INSERT_Click_1(sender As Object, e As EventArgs) Handles BTN_INSERT.Click
        Dim MYSQL As String = "INSERT INTO TBL_CUSTOMER_A188417 VALUES ('" & TXT_ID.Text & "', '" & TXT_FIRSTNAME.Text & "', '" & TXT_LASTNAME.Text & "', '" & TXT_PHONENUM.Text & "', '" & TXT_EMAIL.Text & "', '" & CMB_GENDER.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(MYSQL, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            refresh_grid()

        Catch ex As Exception

            Beep()
            MsgBox("there is a mistake in the data you entered: " & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        run_command("UPDATE tbl_customer_a188417 SET FLD_CUST_FIRSTNAME = '" & TXT_FIRSTNAME.Text & "', FLD_CUST_LASTNAME = '" & TXT_LASTNAME.Text & "', FLD_CUST_PHONENUM = '" & TXT_PHONENUM.Text & "', FLD_CUST_EMAIL = '" & TXT_EMAIL.Text & "', FLD_CUST_GENDER = '" & CMB_GENDER.Text & "' WHERE FLD_CUST_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this customer details """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("DELETE FROM TBL_CUSTOMER_A188417 WHERE FLD_CUST_ID='" & current_code & "'")
        Beep()
            MsgBox("The customer """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub BTN_CLEAR_Click(sender As Object, e As EventArgs) Handles BTN_CLEAR.Click
        clear_fields()
        generate_ID()
    End Sub

    Private Sub GRD_CUSTOMER_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_CUSTOMER.CellContentClick

    End Sub

    Private Sub GRD_CUSTOMER_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_CUSTOMER.CellClick
        get_current_code()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_grid()
    End Sub
End Class