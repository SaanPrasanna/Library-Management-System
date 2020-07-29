Public Class Main
    'Owner C3  https://github.com/SaanPrasanna
    Dim myResizer As New Resizer

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fix taskbar not showing error
        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.Manual
        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With

        myResizer.FindAllControls(Me)

        Timer1.Enabled = True

        panel_books.Hide()
        Panel_members.Hide()
        Panel_booksin.Hide()
        Panel_ba.Hide()
        Panel_bi.Hide()
        Panel_settings.Hide()
        Panel_reports.Hide()

        'Dashboard part
        d_total_books.Text = Allbooks()
        d_pending_books.Text = Allpending()
        d_available.Text = (Allbooks() - Allpending())
        d_totalMembers.Text = Allmemvers()

    End Sub

    Private Sub Cmd_books_Click(sender As Object, e As EventArgs) Handles Cmd_books.Click
        panel_books.Show()

        Panel_members.Hide()
        Panel_booksin.Hide()
        Panel_ba.Hide()
        Panel_bi.Hide()
        Panel_settings.Hide()
        Panel_reports.Hide()


        'Call Method
        Dim c As Integer
        c = DataGridView_books.Columns.Count
        If (c < 11) Then
            Addbuttons_books()
        End If
        Books()

    End Sub

    Private Sub Cmd_close_books_panel_Click_1(sender As Object, e As EventArgs) Handles Cmd_close_books_panel.Click
        panel_books.Hide()
    End Sub

    'tu_lbl_dashboard,ab_lbl_dashboard,tb_lbl_dashboard***********

    Private Sub Cmd_new_books_Click(sender As Object, e As EventArgs) Handles Cmd_new_books.Click
        New_book.Show()
    End Sub

    Private Sub DataGridView_books_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_books.CellContentClick
        Dim query_type As String
        Dim rs As ADODB.Recordset

        Try
            If e.ColumnIndex = 0 Then

                Dim x As String = DataGridView_books.Rows(e.RowIndex).Cells(2).Value
                Call Getconnection()
                con.Open()
                query_type = "SELECT * FROM books WHERE ISBN = '" & x & "';"
                rs = con.Execute(query_type)

                Modify_book.isbn_tb.Text = rs.Fields("ISBN").Value
                Modify_book.bn_tb.Text = rs.Fields("BOOK_NAME").Value
                Modify_book.publisher_tb.Text = rs.Fields("PUBLISHER").Value
                Modify_book.author_tb.Text = rs.Fields("AUTHOR").Value
                Modify_book.category_tb.Text = rs.Fields("CATEGORY").Value
                con.Close()
                Modify_book.Show()

            End If

            If (e.ColumnIndex = 1) Then
                Dim y As String = DataGridView_books.Rows(e.RowIndex).Cells(2).Value
                Privilages_books.isbn_lbl.Text = y
                Privilages_books.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Show Date and Time
        date_time_lbl.Text = Date.Now.ToString("dddddd, MMMM, dd, yyyy        hh:mm:ss tt")
    End Sub

    Private Sub Cmd_members_Click(sender As Object, e As EventArgs) Handles Cmd_members.Click
        Panel_members.Show()
        panel_books.Hide()
        Panel_booksin.Hide()
        Panel_ba.Hide()
        Panel_bi.Hide()
        Panel_settings.Hide()
        Panel_reports.Hide()

        'Call Method
        Dim c As Integer
        c = DataGridView_members.Columns.Count
        If (c < 12) Then
            Addbuttons_members()
        End If
        Members()

    End Sub

    Private Sub Cmd_members_close_Click(sender As Object, e As EventArgs) Handles Cmd_members_close.Click
        Panel_members.Hide()
    End Sub

    Private Sub Cmd_new_member_Click(sender As Object, e As EventArgs) Handles Cmd_new_member.Click
        New_Member.Show()
    End Sub

    Private Sub DataGridView_members_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_members.CellContentClick
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim idx_no As String = DataGridView_members.Rows(e.RowIndex).Cells(2).Value
        Dim now_date As New Date
        Dim renew_date As New Date

        Try
            If (e.ColumnIndex = 0) Then

                Try

                    now_date = Format(Now(), "yyyy-MM-dd")
                    renew_date = Convert.ToDateTime(DataGridView_members.Rows(e.RowIndex).Cells(9).Value)
                    If (now_date < renew_date) Then
                        Modify_members.Cmd_change.Visible = False
                    End If

                    Call Getconnection()
                    con.Open()

                    sql = "SELECT * FROM members WHERE INDEX_NO = '" & idx_no & "';"
                    rs = con.Execute(sql)
                    Modify_members.fname_tb.Text = rs.Fields("FNAME").Value
                    Modify_members.lname_tb.Text = rs.Fields("LNAME").Value
                    Modify_members.address_tb.Text = rs.Fields("ADDRESS").Value
                    Modify_members.email_tb.Text = rs.Fields("EMAIL").Value
                    Modify_members.category_tb.Text = rs.Fields("CATEGORY").Value
                    Modify_members.category_cb.Text = rs.Fields("CATEGORY").Value
                    Modify_members.fee_tb.Text = rs.Fields("FEE").Value
                    Modify_members.renew_tb.Text = Format(rs.Fields("RENEW_DATE").Value, "yyyy-MM-dd")
                    Modify_members.index_tb.Text = idx_no
                    con.Close()

                Catch ex As Exception
                End Try

                Modify_members.Show()

            ElseIf (e.ColumnIndex = 1) Then

                Privilages_members.Show()
                Privilages_members.idx_lbl.Text = idx_no

            End If
        Catch ex As Exception

            MessageBox.Show("Error Code :" & vbCrLf & ex.ToString, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub Cmd_close_Click(sender As Object, e As EventArgs) Handles Cmd_close.Click

        Dim close As Integer = MessageBox.Show("Do you want Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (close = vbYes) Then
            Login.Show()
            Login.Username_tb.Text = "Username"
            Login.Password_tb.Text = "Password"
            Login.Password_tb.PasswordChar = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub Cmd_booksin_Click(sender As Object, e As EventArgs) Handles Cmd_booksin.Click

        'Call method
        Books_stockinGrid()

        Panel_booksin.Show()
        panel_books.Hide()
        Panel_members.Hide()
        Panel_ba.Hide()
        Panel_bi.Hide()
        Panel_settings.Hide()
        Panel_reports.Hide()

    End Sub

    Private Sub Cmd_closebooksin_Click(sender As Object, e As EventArgs) Handles cmd_closebooksin.Click

        Panel_booksin.Hide()

    End Sub

    Private Sub Cmd_add_Click(sender As Object, e As EventArgs) Handles Cmd_add.Click

        Books_stockin.Show()

    End Sub

    Private Sub DateTimePickerto_bn_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerto_bn.ValueChanged
        Books_stockinGrid()
    End Sub

    Private Sub DateTimePickerfrom_bn_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerfrom_bn.ValueChanged
        Books_stockinGrid()
    End Sub

    Private Sub Cmd_booksactions_Click(sender As Object, e As EventArgs) Handles Cmd_booksactions.Click
        Panel_ba.Show()
        panel_books.Hide()
        Panel_booksin.Hide()
        Panel_members.Hide()
        Panel_bi.Hide()
        Panel_settings.Hide()
        Panel_reports.Hide()

        'Called Method 
        Books_actionsGrid()

    End Sub

    Private Sub Cmd_close_ba_Click(sender As Object, e As EventArgs) Handles Cmd_close_ba.Click

        Panel_ba.Hide()

    End Sub

    Private Sub Cmd_action_Click(sender As Object, e As EventArgs) Handles Cmd_action.Click

        Books_Actions.Show()

    End Sub

    Private Sub DateTimePickerfrom_ba_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerfrom_ba.ValueChanged, DateTimePickerto_ba.ValueChanged
        Books_actionsGrid()
    End Sub

    Private Sub Cmd_bookissue_Click(sender As Object, e As EventArgs) Handles Cmd_bookissue.Click
        Panel_bi.Show()
        Searchbox_tb.Text = "[Search By]"
        Type_cb.Text = Nothing
        'Call method to Load Datagrid
        BooksissueGrid()

        panel_books.Hide()
        Panel_members.Hide()
        Panel_booksin.Hide()
        Panel_ba.Hide()
        Panel_settings.Hide()
        Panel_reports.Hide()

    End Sub
    Private Sub Searchbox_tb_GotFocus(sender As Object, e As EventArgs) Handles Searchbox_tb.GotFocus

        If (Searchbox_tb.Text = "[Search By]") Then
            Searchbox_tb.Text = ""
        End If

    End Sub
    Private Sub Searchbox_tb_LostFocus(sender As Object, e As EventArgs) Handles Searchbox_tb.LostFocus

        If (Searchbox_tb.Text.Trim = "") Then
            Searchbox_tb.Text = "[Search By]"
            BooksissueGrid()
        End If

    End Sub
    Private Sub Cmd_closebi_Click(sender As Object, e As EventArgs) Handles Cmd_closebi.Click
        Panel_bi.Hide()
    End Sub

    'Tooptips
    Private Sub Cmd_close_MouseHover(sender As Object, e As EventArgs) Handles Cmd_close.MouseHover
        ToolTip1.SetToolTip(Cmd_close, "Click to Logout")
    End Sub

    Private Sub Cmd_minimize_MouseHover(sender As Object, e As EventArgs) Handles Cmd_minimize.MouseHover
        ToolTip1.SetToolTip(Cmd_minimize, "Minimize")
    End Sub
    Private Sub Cmd_help_MouseHover(sender As Object, e As EventArgs) Handles Cmd_help.MouseHover
        ToolTip1.SetToolTip(Cmd_help, "Help")
    End Sub
    Private Sub Searchbox_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles Searchbox_tb.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            Search_bi()
        End If

    End Sub
    Private Sub Cmd_issue_Click(sender As Object, e As EventArgs) Handles Cmd_issue.Click
        Book_issue.Show()
    End Sub

    Private Sub Cmd_restore_Click(sender As Object, e As EventArgs) Handles Cmd_restore.Click

        Restorebooks.Show()

    End Sub

    Private Sub Cmd_settingclose_Click(sender As Object, e As EventArgs) Handles Cmd_settingclose.Click
        Panel_settings.Hide()
    End Sub

    Private Sub Cmd_ettings_Click(sender As Object, e As EventArgs) Handles Cmd_ettings.Click
        Privilages_settings.Show()


        If (DataGridView_usersettings.Columns.Count < 8) Then
            Usersettingsbtn()
        End If
        UsersettingsGrid()

        'Members(Students/Others) seting auto filling part
        Try

            'Getting the valued of the Studuent data
            Call Getconnection()
            con.Open()
            Dim sql As String = "SELECT * FROM category WHERE category = 'Student';"
            Dim rs As New ADODB.Recordset
            rs = con.Execute(sql)
            srf_tb.Text = Format(rs.Fields("Price").Value, "0.00")
            srt_tb.Text = rs.Fields("renew_after").Value
            sib_tb.Text = rs.Fields("Numof_books").Value
            sdays_tb.Text = rs.Fields("days").Value
            sfines_tb.Text = Format(rs.Fields("fines").Value, "0.00")

            rs = Nothing
            Dim sql_others As String = "SELECT * FROM category WHERE category = 'Others';"
            rs = con.Execute(sql_others)
            orf_tb.Text = Format(rs.Fields("Price").Value, "0.00")
            ort_tb.Text = rs.Fields("renew_after").Value
            oib_tb.Text = rs.Fields("Numof_books").Value
            odays_tb.Text = rs.Fields("days").Value
            ofines_tb.Text = Format(rs.Fields("Fines").Value, "0.00")
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DataGridView_usersettings_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_usersettings.CellContentClick

        If (e.ColumnIndex() = 0) Then

            Modify_users.username_tb.Text = DataGridView_usersettings.Rows(e.RowIndex).Cells(2).Value
            Modify_users.fname_tb.Text = DataGridView_usersettings.Rows(e.RowIndex).Cells(3).Value
            Modify_users.lname_tb.Text = DataGridView_usersettings.Rows(e.RowIndex).Cells(4).Value
            Modify_users.address_tb.Text = DataGridView_usersettings.Rows(e.RowIndex).Cells(5).Value
            Modify_users.tp_tb.Text = DataGridView_usersettings.Rows(e.RowIndex).Cells(6).Value
            Modify_users.type_cb.Text = DataGridView_usersettings.Rows(e.RowIndex).Cells(7).Value
            Modify_users.Show()

        ElseIf (e.ColumnIndex() = 1) Then

            Dim username As String = DataGridView_usersettings.Rows(e.RowIndex).Cells(2).Value

            Dim ans As Integer = MessageBox.Show("Are you sure Delete " & username, "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If (ans = vbYes) Then
                Call Getconnection()
                con.Open()

                Dim sql As String = "DELETE FROM login WHERE USERNAME = '" & username & "' AND USERNAME <> '" & uname_lbl.Text & "';"
                Dim sql_chechadmin As String = "SELECT TYPE FROM login WHERE USERNAME = '" & username & "';"
                Dim rs As New ADODB.Recordset
                rs = con.Execute(sql_chechadmin)
                Dim type As String = rs.Fields("TYPE").Value

                If (type <> "admin") Then
                    rs = con.Execute(sql)
                    MessageBox.Show(username & " Deleted !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Sorry " & username & " is Admin User! Admin Can't Delete", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                con.Close()
                'Refreshing the datagridview
                If (DataGridView_usersettings.Columns.Count < 8) Then
                    Usersettingsbtn()
                End If
                UsersettingsGrid()


            End If

        End If




    End Sub

    Private Sub Cmd_adduser_Click(sender As Object, e As EventArgs) Handles Cmd_adduser.Click
        New_user.Show()
    End Sub

    Private Sub Cmd_updatestudent_Click(sender As Object, e As EventArgs) Handles Cmd_updatestudent.Click

        Try

            If (srf_tb.Text.Trim <> "" And srt_tb.Text.Trim <> "" And sib_tb.Text.Trim <> "" And sdays_tb.Text.Trim <> "" And sfines_tb.Text.Trim <> "") Then
                Call Getconnection()
                con.Open()
                Dim sql As String = "UPDATE category SET Price=" & Val(srf_tb.Text) & ",renew_after=" & Val(srt_tb.Text) & ",Numof_books=" & Val(sib_tb.Text) & ",days = " & Val(sdays_tb.Text) & ",fines = " & Val(sfines_tb.Text) & " WHERE category = 'Student';"
                Dim rs As New ADODB.Recordset
                rs = con.Execute(sql)
                con.Close()
                MessageBox.Show("Studnet Settings Updated Successfuly.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Some Fields are Empty !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub Cmd_updateothers_Click(sender As Object, e As EventArgs) Handles Cmd_updateothers.Click

        Try

            If (orf_tb.Text.Trim <> "" And ort_tb.Text.Trim <> "" And oib_tb.Text.Trim <> "" And odays_tb.Text.Trim <> "" And ofines_tb.Text.Trim <> "") Then
                Call Getconnection()
                con.Open()
                Dim sql As String = "UPDATE category SET Price=" & Val(orf_tb.Text) & ",renew_after=" & Val(ort_tb.Text) & ",Numof_books=" & Val(oib_tb.Text) & ",days = " & Val(odays_tb.Text) & ",fines = " & Val(ofines_tb.Text) & " WHERE category = 'Others';"
                Dim rs As New ADODB.Recordset
                rs = con.Execute(sql)
                con.Close()
                MessageBox.Show("Others Settings Updated Successfuly.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Some Fields are Empty !!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Cmd_closereports_Click(sender As Object, e As EventArgs) Handles Cmd_closereports.Click
        Panel_reports.Hide()
    End Sub

    Private Sub Cmd_reports_Click(sender As Object, e As EventArgs) Handles Cmd_reports.Click

        Privilages_reports.Show()

        panel_books.Hide()
        Panel_members.Hide()
        Panel_booksin.Hide()
        Panel_ba.Hide()
        Panel_bi.Hide()
        Panel_settings.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click

        Dim rpt As New CrystalReport1

        rpt.Refresh()
        rpt.SetParameterValue("name", uname_lbl.Text)
        Report.CrystalReportViewer1.ReportSource = rpt
        Report.CrystalReportViewer1.Zoom(75)
        Report.CrystalReportViewer1.Refresh()
        Report.Show()
    End Sub

    Private Sub Cmd_yearlyrpt_Click(sender As Object, e As EventArgs) Handles Cmd_yearlyrpt.Click
        Dim rpt As New CrystalReport2

        rpt.Refresh()
        rpt.SetParameterValue("name", uname_lbl.Text)
        Report.CrystalReportViewer1.ReportSource = rpt
        Report.CrystalReportViewer1.Zoom(75)
        Report.CrystalReportViewer1.Refresh()
        Report.Show()
    End Sub

    Private Sub Cmd_monthlyrpt_Click(sender As Object, e As EventArgs) Handles Cmd_monthlyrpt.Click
        Dim rpt As New Rptmonthly

        rpt.Refresh()
        rpt.SetParameterValue("name", uname_lbl.Text)
        Report.CrystalReportViewer1.ReportSource = rpt
        Report.CrystalReportViewer1.Zoom(75)
        Report.CrystalReportViewer1.Refresh()
        Report.Show()
    End Sub

    Private Sub Cmd_memberrpt_Click(sender As Object, e As EventArgs) Handles Cmd_memberrpt.Click
        Dim rpt As New Rptmembers

        rpt.Refresh()
        rpt.SetParameterValue("name", uname_lbl.Text)
        Report.CrystalReportViewer1.ReportSource = rpt
        Report.CrystalReportViewer1.Zoom(75)
        Report.CrystalReportViewer1.Refresh()
        Report.Show()
    End Sub

    Private Sub Cmd_booksissuerpt_Click(sender As Object, e As EventArgs) Handles Cmd_booksissuerpt.Click
        Dim rpt As New Rptissuedbook

        rpt.Refresh()
        rpt.SetParameterValue("name", uname_lbl.Text)
        Report.CrystalReportViewer1.ReportSource = rpt
        Report.CrystalReportViewer1.Zoom(75)
        Report.CrystalReportViewer1.Refresh()
        Report.Show()
    End Sub

    Private Sub Cmd_summery_Click(sender As Object, e As EventArgs) Handles Cmd_summery.Click

        Dim rpt As New Rptsummary

        rpt.Refresh()
        rpt.SetParameterValue("name", uname_lbl.Text)
        rpt.SetParameterValue("Allbooks", Allbooks())
        rpt.SetParameterValue("Pendingbooks", Allpending())
        rpt.SetParameterValue("Allmembers", Allmemvers())
        rpt.SetParameterValue("Available", (Allbooks() - Allpending()))
        Report.CrystalReportViewer1.ReportSource = rpt
        Report.CrystalReportViewer1.Zoom(75)
        Report.CrystalReportViewer1.Refresh()
        Report.Show()

    End Sub

    Private Sub Cmd_minimize_Click(sender As Object, e As EventArgs) Handles Cmd_minimize.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class
