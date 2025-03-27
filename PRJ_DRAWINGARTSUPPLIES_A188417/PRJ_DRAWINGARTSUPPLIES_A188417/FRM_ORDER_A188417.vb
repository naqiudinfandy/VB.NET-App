Public Class FRM_ORDER_A188417
    Private Sub FRM_ORDER_A188417_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_DATE.Text = current_date
        GRD_ORDER.DefaultCellStyle.BackColor = Color.LemonChiffon
        refresh_grid()

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

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Dim delete_confirmation = MsgBox("Are you sure want to end this session?", MsgBoxStyle.YesNo)
        If delete_confirmation = MsgBoxResult.Yes Then
            MsgBox("Thank you visiting Artistic Art Supplier, Goodbye!")
            End
        End If
    End Sub

    Private Sub refresh_grid()
        GRD_ORDER.DataSource = run_select("SELECT * FROM TBL_ORDER_A188417")

        'Dim mysql As String = "SELECT * FROM TBL_ORDER_A188417"
        'Dim mydatatable As New DataTable
        'Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        'myreader.Fill(mydatatable)
        'GRD_ORDER.DataSource = mydatatable

        GRD_ORDER.Columns(0).HeaderText = "ORDER ID"
        GRD_ORDER.Columns(1).HeaderText = "STAFF ID"
        GRD_ORDER.Columns(2).HeaderText = "CUSTOMER ID"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        refresh_grid()
    End Sub

    Private Sub GRD_ORDER_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GRD_ORDER.CellContentClick

    End Sub
End Class