Module MOD_GLOBAL_A188417
    Public username As String
    Public matric As String
    Public current_code As String
    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_DRAWINGARTSUPPLIES_A188417.accdb;Persist Security Info=False;"
    Public myconnection2 As New OleDb.OleDbConnection(myconnection)
    Public current_date = Date.Now
    Public defaultpicture As String = Application.StartupPath & "\Picture\no_photo.jpg"

    Public Function run_select(mysql As String) As DataTable

        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception
            Beep()
            MsgBox("There is an error in your Select sql : " & vbCrLf & vbCrLf & ex.Message & vbCrLf & mysql)
        End Try

        Return mydatatable

    End Function

    Public Sub run_command(mysql As String)

        'MsgBox(mysql)

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception

            Beep()
            MsgBox("there is a mistake in data you entered or changed: " & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub
End Module
