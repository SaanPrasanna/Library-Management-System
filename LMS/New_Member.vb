Imports MySql.Data.MySqlClient
Public Class New_Member
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub New_Member_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub New_Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connection.Open()
        Dim sql As String = "SELECT COUNT(*) FROM members;"
        Dim cmd As New MySqlCommand(sql, connection)
        Dim count As Integer = cmd.ExecuteScalar()
        connection.Close()
        count = count + 1
        If (count < 10) Then
            index_tb.Text = "IDX0000" + count.ToString
        ElseIf (count < 100) Then
            index_tb.Text = "IDX000" + count.ToString
        ElseIf (count < 1000) Then
            index_tb.Text = "IDX00" + count.ToString
        ElseIf (count < 10000) Then
            index_tb.Text = "IDX0" + count.ToString
        Else
            index_tb.Text = "IDX" + count.ToString
        End If


    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim idx, fname, lname, category, address, email, sql, Now_time, Now_date As String
        Dim rs As New ADODB.Recordset
        Dim fee, is_deleted As Integer

        idx = index_tb.Text
        fname = fname_tb.Text.Trim
        lname = lname_tb.Text.Trim
        category = category_cb.Text.Trim
        address = address_tb.Text.Trim
        email = email_tb.Text.Trim
        fee = Val(fee_tb.Text.Trim)

        Now_date = Format(Now(), "yyyy-MM-dd") 'get date
        Now_time = Format(Now(), "HH:mm:ss") 'get time
        is_deleted = 0

        If ((fname <> "") And (lname <> "") And (category <> "") And (address <> "") And (email <> "") And (fee <> 0)) Then

            Try

                Call Getconnection()
                con.Open()



                sql = "INSERT INTO members values('" & idx & "','" & fname & "','" & lname & "','" & category & "','" & address & "','" & email & "','" & Now_date & "','" & Now_time & "','" & renew_tb.Text & "','" & fee & "','" & Main.uname_lbl.Text & "'," & is_deleted & ");"
                rs = con.Execute(sql)

                'Call Method
                Dim c As Integer
                c = Main.DataGridView_members.Columns.Count
                If (c < 12) Then
                    Addbuttons_members()
                End If
                Members()
                MessageBox.Show("[" & idx & "] --> New Member added.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Dashboard part
                Main.d_totalMembers.Text = Allmemvers()

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
            con.Close()
        Else
            MessageBox.Show("Some Fields are Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Category_cb_TextChanged(sender As Object, e As EventArgs) Handles category_cb.TextChanged

        Dim sql_renew_date As String
        Dim rs_renew_date As New ADODB.Recordset
        Dim renew_date As Integer

        Try
            Call Getconnection()
            con.Open()
            sql_renew_date = "SELECT * FROM category WHERE category = '" & category_cb.Text & "';"
            rs_renew_date = con.Execute(sql_renew_date)
            renew_date = rs_renew_date.Fields("renew_after").Value
            fee_tb.Text = rs_renew_date.Fields("price").Value

            '********** Calculate Renew Time period
            Dim s_day As New Date
            s_day = Format(Now(), "yyyy-MM-dd")
            s_day = DateAdd(DateInterval.Month, renew_date, s_day)
            Dim r_date As String
            r_date = Format(s_day, "yyyy-MM-dd")
            renew_tb.Text = r_date


        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class