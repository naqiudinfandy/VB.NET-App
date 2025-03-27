Public Class FRM_MODIPRODUCT_A188417
    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub FRM_INSERTPRODUCT_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date

        GRD_PRODUCT.DefaultCellStyle.BackColor = Color.LemonChiffon

        refresh_grid()

        TXT_ID.Text = generate_ID()

        TXT_PICTURE.Text = defaultpicture
        PIC_PRODUCT.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Sub refresh_grid()
        GRD_PRODUCT.DataSource = run_select("SELECT * FROM TBL_PRODUCT_A188417 ORDER BY FLD_PRODUCT_ID")

        GRD_PRODUCT.Columns(0).HeaderText = "ID"
        GRD_PRODUCT.Columns(1).HeaderText = "Name"
        GRD_PRODUCT.Columns(2).HeaderText = "Price"
        GRD_PRODUCT.Columns(3).HeaderText = "Brand"
        GRD_PRODUCT.Columns(4).HeaderText = "Category"
        GRD_PRODUCT.Columns(5).HeaderText = "Quantity"
        GRD_PRODUCT.Columns(6).HeaderText = "Warranty Length"

        TXT_ID.Text = generate_ID()
        'TXT_NAME.Text = ""
        'TXT_PRICE.Text = ""
        'TXT_BRAND.Text = ""
        'TXT_CATEGORY.Text = ""
        'TXT_QUANTITY.Text = ""
        'TXT_WARRANTY.Text = ""

        TXT_PICTURE.Text = defaultpicture
        PIC_PRODUCT.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Function generate_ID() As String
        Dim lastID As String = run_select("SELECT MAX(FLD_PRODUCT_ID) AS MAXID FROM TBL_PRODUCT_A188417").Rows(0).Item("MAXID")
        Dim nextID As String = "P00" & (Mid(lastID, 2) + 1)
        Return nextID

    End Function

    Private Sub BTN_BACK_Click(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_MODIFY_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub FRM_INSERTPRODUCT_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub BTN_INSERT_Click(sender As Object, e As EventArgs) Handles BTN_INSERT.Click
        Dim MYSQL As String = "INSERT INTO TBL_PRODUCT_A188417 VALUES ('" & TXT_ID.Text & "', '" & TXT_NAME.Text & "', '" & TXT_PRICE.Text & "', '" & TXT_BRAND.Text & "', '" & TXT_CATEGORY.Text & "', '" & TXT_QUANTITY.Text & "',  '" & TXT_WARRANTY.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(MYSQL, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(TXT_PICTURE.Text, "Picture\" & TXT_ID.Text & ".jpg")

            refresh_grid()
            clear_fields()
            TXT_PICTURE.Text = defaultpicture
            PIC_PRODUCT.BackgroundImage = Image.FromFile(defaultpicture)

            Beep()
            MsgBox("You have successfully insert new product")

        Catch ex As Exception

            Beep()
            MsgBox("there is a mistake in the data you entered: " & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub BTN_PICTURE_Click(sender As Object, e As EventArgs) Handles BTN_PICTURE.Click
        Dim mydesktop As String = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.InitialDirectory = mydesktop
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "jpg files (*.jpg)|*.jpg"
        OpenFileDialog1.ShowDialog()

        If (OpenFileDialog1.FileName = "") Then
            OpenFileDialog1.FileName = defaultpicture
        End If


        TXT_PICTURE.Text = OpenFileDialog1.FileName
        PIC_PRODUCT.BackgroundImage = Image.FromFile(TXT_PICTURE.Text)
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

        Try
            PIC_PRODUCT.BackgroundImage = Image.FromFile("Picture/" & TXT_ID.Text & ".jpg")
        Catch ex As Exception
            PIC_PRODUCT.BackgroundImage = Image.FromFile("Picture/no_photo.jpg")
        End Try

    End Sub

    Private Sub clear_fields()

        TXT_ID.Text = generate_ID()
        TXT_NAME.Text = ""
        TXT_PRICE.Text = ""
        TXT_BRAND.Text = ""
        TXT_CATEGORY.Text = ""
        TXT_QUANTITY.Text = ""
        TXT_WARRANTY.Text = ""
        PIC_PRODUCT.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        run_command("UPDATE tbl_product_a188417 SET FLD_PRODUCT_NAME = '" & TXT_NAME.Text & "', FLD_PRODUCT_PRICE = " & TXT_PRICE.Text & ", FLD_PRODUCT_BRAND = '" & TXT_BRAND.Text & "', FLD_PRODUCT_CATEGORY = '" & TXT_CATEGORY.Text & "', FLD_PRODUCT_QUANTITY = '" & TXT_QUANTITY.Text & "', FLD_PRODUCT_WARRANTYLENGTH = '" & TXT_WARRANTY.Text & "' WHERE FLD_PRODUCT_ID='" & current_code & "'")

        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click

        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("DELETE FROM TBL_PRODUCT_A188417 WHERE FLD_PRODUCT_ID='" & current_code & "'")
            PIC_PRODUCT.BackgroundImage.Dispose()
            FileSystem.Kill("Picture\" & current_code & ".jpg")
            Beep()
            MsgBox("The product """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub GRD_PRODUCT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_PRODUCT.CellContentClick

    End Sub

    Private Sub GRD_PRODUCT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_PRODUCT.CellClick
        get_current_code()
    End Sub

    Private Sub BTN_CLEAR_Click(sender As Object, e As EventArgs) Handles BTN_CLEAR.Click
        clear_fields()
        generate_ID()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_grid()
    End Sub
End Class