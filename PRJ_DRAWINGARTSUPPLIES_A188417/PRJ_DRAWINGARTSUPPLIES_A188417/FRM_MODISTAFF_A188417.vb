Public Class FRM_MODISTAFF_A188417
    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub FRM_INSERTSTAFF_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
        GRD_STAFF.DefaultCellStyle.BackColor = Color.LemonChiffon

        refresh_grid()

        CMB_GENDER.Items.Add("Male")
        CMB_GENDER.Items.Add("Female")
        CMB_GENDER.SelectedIndex = 0

        CMB_JOBTYPE.Items.Add("Full-time")
        CMB_JOBTYPE.Items.Add("Part-time")
        CMB_JOBTYPE.SelectedIndex = 0

        TXT_ID.Text = generate_ID()

        'CMB_GENDER.DataSource = run_select("SELECT FLD_STAFF_GENDER FROM TBL_STAFF_A188417 ORDER BY FLD_STAFF_GENDER")
        'CMB_GENDER.DisplayMember = "FLD_STAFF_GENDER"

        'CMB_JOBTYPE.DataSource = run_select("SELECT FLD_STAFF_JOBTYPE FROM TBL_STAFF_A188417 ORDER BY FLD_STAFF_JOBTYPE")
        'CMB_JOBTYPE.DisplayMember = "FLD_STAFF_JOBTYPE"

        TXT_PICTURE.Text = defaultpicture
        PIC_STAFF.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

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

    Private Sub refresh_grid()
        GRD_STAFF.DataSource = run_select("SELECT * FROM TBL_STAFF_A188417 ORDER BY FLD_STAFF_ID")

        GRD_STAFF.Columns(0).HeaderText = "ID"
        GRD_STAFF.Columns(1).HeaderText = "FIRST NAME"
        GRD_STAFF.Columns(2).HeaderText = "LAST NAME"
        GRD_STAFF.Columns(3).HeaderText = "AGE"
        GRD_STAFF.Columns(4).HeaderText = "GENDER"
        GRD_STAFF.Columns(5).HeaderText = "JOB TYPE"

        TXT_ID.Text = generate_ID()
        TXT_FIRSTNAME.Text = ""
        TXT_LASTNAME.Text = ""
        TXT_AGE.Text = ""


        TXT_PICTURE.Text = defaultpicture
        PIC_STAFF.BackgroundImage = Image.FromFile(defaultpicture)
    End Sub

    Private Function generate_ID() As String
        Dim lastID As String = run_select("SELECT MAX(FLD_STAFF_ID) AS MAXID FROM TBL_STAFF_A188417").Rows(0).Item("MAXID")
        Dim nextID As String = "S00" & (Mid(lastID, 2) + 1)
        Return nextID

    End Function

    Private Sub get_current_code()

        Dim current_row As Integer = GRD_STAFF.CurrentRow.Index
        current_code = GRD_STAFF(0, current_row).Value

        TXT_ID.Text = current_code
        TXT_FIRSTNAME.Text = GRD_STAFF(1, current_row).Value
        TXT_LASTNAME.Text = GRD_STAFF(2, current_row).Value
        TXT_AGE.Text = GRD_STAFF(3, current_row).Value
        CMB_GENDER.Text = GRD_STAFF(4, current_row).Value
        CMB_JOBTYPE.Text = GRD_STAFF(5, current_row).Value

        Try
            PIC_STAFF.BackgroundImage = Image.FromFile("Picture/" & TXT_ID.Text & ".jpg")
        Catch ex As Exception
            PIC_STAFF.BackgroundImage = Image.FromFile("Picture/no_photo.jpg")
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
        PIC_STAFF.BackgroundImage = Image.FromFile(TXT_PICTURE.Text)
    End Sub

    Private Sub clear_fields()

        TXT_ID.Text = generate_ID()
        TXT_FIRSTNAME.Text = ""
        TXT_LASTNAME.Text = ""
        TXT_AGE.Text = ""
        CMB_GENDER.SelectedIndex = 0
        CMB_JOBTYPE.SelectedIndex = 0
        PIC_STAFF.BackgroundImage = Image.FromFile(defaultpicture)

    End Sub

    Private Sub FRM_MODISTAFF_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub BTN_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click

        run_command("UPDATE TBL_STAFF_A188417 SET FLD_STAFF_FIRSTNAME = '" & TXT_FIRSTNAME.Text & "', FLD_STAFF_LASTNAME = '" & TXT_LASTNAME.Text & "', FLD_STAFF_AGE = '" & TXT_AGE.Text & "', FLD_STAFF_GENDER = '" & CMB_GENDER.Text & "', FLD_STAFF_JOBTYPE = '" & CMB_JOBTYPE.Text & "' WHERE FLD_STAFF_ID = '" & current_code & "'")


        Beep()
        MsgBox("You have successfully updated the product """ & current_code & """.")

        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs) Handles BTN_DELETE.Click
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete this staff details """ & current_code & """?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then

            run_command("DELETE FROM TBL_STAFF_A188417 WHERE FLD_STAFF_ID='" & current_code & "'")
            PIC_STAFF.BackgroundImage.Dispose()
            FileSystem.Kill("Picture\" & current_code & ".jpg")
            Beep()
            MsgBox("The staff """ & current_code & """ has been successfully deleted.")
            refresh_grid()
            clear_fields()
            get_current_code()

        End If
    End Sub

    Private Sub BTN_CLEAR_Click(sender As Object, e As EventArgs) Handles BTN_CLEAR.Click
        clear_fields()
        generate_ID()
    End Sub

    Private Sub GRD_STAFF_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_STAFF.CellContentClick

    End Sub

    Private Sub GRD_STAFF_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_STAFF.CellClick
        get_current_code()
    End Sub

    Private Sub BTN_INSERT_Click_1(sender As Object, e As EventArgs) Handles BTN_INSERT.Click
        Dim MYSQL As String = "INSERT INTO TBL_STAFF_A188417 VALUES ('" & TXT_ID.Text & "', '" & TXT_FIRSTNAME.Text & "', '" & TXT_LASTNAME.Text & "', '" & TXT_AGE.Text & "', '" & CMB_GENDER.Text & "', '" & CMB_JOBTYPE.Text & "')"
        Dim mywriter As New OleDb.OleDbCommand(MYSQL, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

            My.Computer.FileSystem.CopyFile(TXT_PICTURE.Text, "Picture\" & TXT_ID.Text & ".jpg")

            refresh_grid()
            clear_fields()
            TXT_PICTURE.Text = defaultpicture
            PIC_STAFF.BackgroundImage = Image.FromFile(defaultpicture)

            Beep()
            MsgBox("You have successfully insert new product")

        Catch ex As Exception

            Beep()
            MsgBox("there is a mistake in the data you entered: " & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_grid()
    End Sub
End Class