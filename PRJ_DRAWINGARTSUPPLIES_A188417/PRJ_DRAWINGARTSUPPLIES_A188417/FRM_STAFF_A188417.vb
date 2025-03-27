Public Class FRM_STAFF_A188417
    Private Sub FRM_STAFF_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
        refresh_lst()
        refresh_text(LST_ID.Text)
    End Sub

    Private Sub refresh_lst()
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A188417"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        LST_ID.DataSource = mydatatable
        LST_ID.DisplayMember = "FLD_STAFF_ID"
    End Sub

    Private Sub refresh_text(ID As String)

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A188417 WHERE fld_staff_id='" & ID & "'"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)

        TXT_ID.Text = mydatatable.Rows(0).Item("FLD_STAFF_ID")
        TXT_FIRSTNAME.Text = mydatatable.Rows(0).Item("FLD_STAFF_FIRSTNAME")
        TXT_SECONDNAME.Text = mydatatable.Rows(0).Item("FLD_STAFF_LASTNAME")
        TXT_AGE.Text = mydatatable.Rows(0).Item("FLD_STAFF_AGE")
        TXT_GENDER.Text = mydatatable.Rows(0).Item("FLD_STAFF_GENDER")
        TXT_JOBTYPE.Text = mydatatable.Rows(0).Item("FLD_STAFF_JOBTYPE")

        PIC_STAFF.BackgroundImage = Image.FromFile("Picture/" & TXT_ID.Text & ".jpg")

    End Sub

    Private Sub LST_ID_MouseClick(sender As Object, e As MouseEventArgs) Handles LST_ID.MouseClick
        refresh_text(LST_ID.Text)
    End Sub

    Private Sub FRM_STAFF_A188417_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub BTN_REFRESHDATE_Click(sender As Object, e As EventArgs) Handles BTN_REFRESHDATE.Click
        current_date = Date.Now
        LBL_DATE.Text = current_date
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub BTN_BACK_Click_1(sender As Object, e As EventArgs) Handles BTN_BACK.Click
        FRM_MAINMENU_A188417.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_lst()
    End Sub
End Class