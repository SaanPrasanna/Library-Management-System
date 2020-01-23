Module Functions
    Public Sub Books()
        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT ISBN,BOOK_NAME as 'Book Name',PUBLISHER AS 'Publisher',AUTHOR AS 'Author', CATEGORY AS 'Category', QUANTITY AS 'Quantity', DATE AS 'Date', TIME AS 'Time',UNAME AS 'By' FROM books ORDER BY DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        Main.DataGridView_books.DataSource = ds
        Main.DataGridView_books.DataMember = "books"

        Main.DataGridView_books.Columns(0).Width = 80
        Main.DataGridView_books.Columns(1).Width = 80
        Main.DataGridView_books.Columns(2).Width = 150
        Main.DataGridView_books.Columns(3).Width = 220
        Main.DataGridView_books.Columns(4).Width = 150
        Main.DataGridView_books.Columns(5).Width = 220
        Main.DataGridView_books.Columns(6).Width = 100
        Main.DataGridView_books.Columns(7).Width = 90
        Main.DataGridView_books.Columns(8).Width = 110
        Main.DataGridView_books.Columns(9).Width = 120
        Main.DataGridView_books.Columns(10).Width = 80
        Main.DataGridView_books.CurrentCell.Selected = False
        Main.DataGridView_books.DefaultCellStyle.SelectionBackColor = Color.Gray

        cn.Close()
    End Sub

    Public Sub Addbuttons_books()
        Dim btn2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn2.UseColumnTextForButtonValue = True
        btn2.HeaderText = "Modify"
        btn2.Name = "mybtn2"
        btn2.Text = "MODIFY"
        btn2.FlatStyle = FlatStyle.Flat
        btn2.InheritedStyle.BackColor = Color.Yellow
        btn2.InheritedStyle.SelectionBackColor = Color.Gold
        Main.DataGridView_books.Columns.Add(btn2)

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.UseColumnTextForButtonValue = True
        btn.HeaderText = "Delete"
        btn.Name = "mybtn"
        btn.Text = "DELETE"
        btn.FlatStyle = FlatStyle.Flat
        btn.InheritedStyle.BackColor = Color.OrangeRed
        btn.InheritedStyle.SelectionBackColor = Color.Red
        Main.DataGridView_books.Columns.Add(btn)

    End Sub

    Public Sub Members()
        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT INDEX_NO AS 'Index No',FNAME AS 'First Name',LNAME AS 'Last Name',ADDRESS AS 'Address',CATEGORY AS 'Category',DATE AS 'Date',TIME AS 'Time', RENEW_DATE AS 'Renew Date',FEE AS 'Fee', UNAME AS 'By',is_deleted FROM members WHERE is_deleted = 0 ORDER BY DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "members")
        Main.DataGridView_members.DataSource = ds
        Main.DataGridView_members.DataMember = "members"

        Main.DataGridView_members.Columns(0).Width = 80
        Main.DataGridView_members.Columns(1).Width = 80
        Main.DataGridView_members.Columns(2).Width = 100
        Main.DataGridView_members.Columns(3).Width = 130
        Main.DataGridView_members.Columns(4).Width = 130
        Main.DataGridView_members.Columns(5).Width = 180
        Main.DataGridView_members.Columns(6).Width = 90
        Main.DataGridView_members.Columns(7).Width = 100
        Main.DataGridView_members.Columns(8).Width = 100
        Main.DataGridView_members.Columns(9).Width = 130
        Main.DataGridView_members.Columns(10).Width = 100
        Main.DataGridView_members.Columns(11).Width = 100
        Main.DataGridView_members.Columns(12).Visible = False
        Main.DataGridView_members.Columns(8).Visible = False
        Main.DataGridView_members.DefaultCellStyle.SelectionBackColor = Color.Gray
        Main.DataGridView_members.CurrentCell.Selected = False

        Rowscolor()
        cn.Close()
    End Sub

    Public Sub Addbuttons_members()
        Dim btn2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn2.UseColumnTextForButtonValue = True
        btn2.HeaderText = "Modify"
        btn2.Name = "mybtn2"
        btn2.Text = "MODIFY"
        btn2.FlatStyle = FlatStyle.Flat
        btn2.InheritedStyle.BackColor = Color.Yellow
        btn2.InheritedStyle.SelectionBackColor = Color.Gold
        Main.DataGridView_members.Columns.Add(btn2)

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.UseColumnTextForButtonValue = True
        btn.HeaderText = "Delete"
        btn.Name = "mybtn"
        btn.Text = "DELETE"
        btn.FlatStyle = FlatStyle.Flat
        btn.InheritedStyle.BackColor = Color.OrangeRed
        btn.InheritedStyle.SelectionBackColor = Color.Red
        Main.DataGridView_members.Columns.Add(btn)

    End Sub

    Public Sub Rowscolor()


        For i As Integer = 0 To Main.DataGridView_members.Rows.Count() - 1 Step +1

            Dim now_date As New Date
            Dim renew_date As New Date

            now_date = Format(Now(), "yyyy-MM-dd")
            renew_date = Convert.ToDateTime(Main.DataGridView_members.Rows(i).Cells(9).Value)

            If now_date > renew_date Then

                Main.DataGridView_members.Rows(i).DefaultCellStyle.BackColor = Color.Tomato

            End If

        Next

    End Sub

    Public Sub Books_stockinGrid()

        Dim D1, D2 As String
        D1 = Format(Main.DateTimePickerfrom_bn.Value, "yyyy-MM-dd")
        D2 = Format(Main.DateTimePickerto_bn.Value, "yyyy-MM-dd")

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT REFNO AS 'Ref No',ISBN AS 'ISBN No', DESCRIPTION AS 'Description', QUANTITY AS 'Quantity',DATE AS 'Date', TIME AS 'Time', UNAME AS 'By' FROM books_stock_in WHERE DATE BETWEEN '" & D1 & "' AND '" & D2 & "' ORDER BY DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        Main.DataGridView_booksin.DataSource = ds
        Main.DataGridView_booksin.DataMember = "books"
        Main.DataGridView_booksin.Columns(0).Width = 120
        Main.DataGridView_booksin.Columns(1).Width = 150
        Main.DataGridView_booksin.Columns(2).Width = 500
        Main.DataGridView_booksin.Columns(3).Width = 100
        Main.DataGridView_booksin.Columns(4).Width = 100
        Main.DataGridView_booksin.Columns(5).Width = 100
        Main.DataGridView_booksin.Columns(6).Width = 100
        'Main.DataGridView_booksin.CurrentCell.Selected = False
        Main.DataGridView_booksin.DefaultCellStyle.SelectionBackColor = Color.Gray

        cn.Close()

    End Sub

    Public Sub Books_actionsGrid()

        Dim D1, D2 As String
        D1 = Format(Main.DateTimePickerfrom_ba.Value, "yyyy-MM-dd")
        D2 = Format(Main.DateTimePickerto_ba.Value, "yyyy-MM-dd")

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT REFNO AS 'Ref No',ISBN AS 'ISBN No', REASON AS 'Reason', QUANTITY AS 'Quantity',ACTION AS 'Action',DATE AS 'Date', TIME AS 'Time', UNAME AS 'By' FROM books_stock_manage WHERE DATE BETWEEN '" & D1 & "' AND '" & D2 & "' ORDER BY DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        Main.DataGridView_ba.DataSource = ds
        Main.DataGridView_ba.DataMember = "books"
        Main.DataGridView_ba.Columns(0).Width = 120
        Main.DataGridView_ba.Columns(1).Width = 150
        Main.DataGridView_ba.Columns(2).Width = 300
        Main.DataGridView_ba.Columns(3).Width = 200
        Main.DataGridView_ba.Columns(4).Width = 100
        Main.DataGridView_ba.Columns(5).Width = 100
        Main.DataGridView_ba.Columns(6).Width = 100
        Main.DataGridView_ba.Columns(7).Width = 100
        'Main.DataGridView_ba.CurrentCell.Selected = False
        Main.DataGridView_ba.DefaultCellStyle.SelectionBackColor = Color.Gray

        cn.Close()

    End Sub

    Public Sub BooksissueGrid()

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT INDEX_NO AS 'Index No',ISBN AS 'ISBN', BOOK_NAME AS 'Book Name',ISSUE_DATE AS 'Issue Date',ISSUE_EXPIRE_DATE AS 'Issue Expire Date',QUANTITY AS 'Quantity', STATUS AS 'Status', UNAME AS 'By' FROM books_issued ORDER BY ISSUE_DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        Main.DataGridView_bi.DataSource = ds
        Main.DataGridView_bi.DataMember = "books"
        Main.DataGridView_bi.DefaultCellStyle.SelectionBackColor = Color.Gray
        Main.DataGridView_bi.Columns(0).Width = 100
        Rowcolor_bi()
        cn.Close()

    End Sub



    Public Sub Rowcolor_bi()

        For i As Integer = 0 To Main.DataGridView_bi.Rows.Count() - 1 Step +1

            Dim today As New Date
            Dim expire_date As New Date
            Dim status As String

            today = Format(Now(), "yyyy-MM-dd")
            expire_date = Convert.ToDateTime(Main.DataGridView_bi.Rows(i).Cells(4).Value)
            status = Convert.ToString(Main.DataGridView_bi.Rows(i).Cells(6).Value)

            If (expire_date >= today And status = "Pending") Then

                Main.DataGridView_bi.Rows(i).DefaultCellStyle.BackColor = Color.Gold

            Else

                Main.DataGridView_bi.Rows(i).DefaultCellStyle.BackColor = Color.Tomato

            End If

            If status = "Returned" Then

                Main.DataGridView_bi.Rows(i).DefaultCellStyle.BackColor = Color.LawnGreen

            End If
        Next

    End Sub

    Public Sub Search_bi()

        Dim type As String

        If (Main.Searchbox_tb.Text.Trim <> "" And Main.Type_cb.Text.Trim <> "") Then

            type = Main.Type_cb.Text
            If (type = "Index No") Then
                type = "INDEX_NO"
            ElseIf (type = "ISBN") Then
                type = "ISBN"
            End If

            Try
                Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
                Dim cmd As Odbc.OdbcCommand
                Dim adp As Odbc.OdbcDataAdapter
                Dim ds As New DataSet

                cn.Open()
                cmd = New Odbc.OdbcCommand("SELECT INDEX_NO AS 'Index No',ISBN AS 'ISBN', BOOK_NAME AS 'Book Name',ISSUE_DATE AS 'Issue Date',ISSUE_EXPIRE_DATE AS 'Issue Expire Date',QUANTITY AS 'Quantity', STATUS AS 'Status', UNAME AS 'By' FROM books_issued WHERE " & type & " LIKE '%" & Main.Searchbox_tb.Text & "%' ORDER BY ISSUE_DATE,TIME", cn)
                adp = New Odbc.OdbcDataAdapter(cmd)
                adp.Fill(ds, "books")
                Main.DataGridView_bi.DataSource = ds
                Main.DataGridView_bi.DataMember = "books"
                Main.DataGridView_bi.DefaultCellStyle.SelectionBackColor = Color.Gray
                Main.DataGridView_bi.Columns(0).Width = 100
                Rowcolor_bi()
                cn.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        ElseIf (Main.Searchbox_tb.Text.Trim <> "" And Main.Type_cb.Text.Trim = "") Then
            MessageBox.Show("Please Select the Type First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf (Main.Type_cb.Text.Trim <> "" And Main.Searchbox_tb.Text = "") Then
            Main.Type_cb.Text = Nothing
            BooksissueGrid()
        End If

    End Sub

    Public Sub Temp()

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT book_issue_temp.ID AS 'ID',book_issue_temp.ISBN AS 'ISBN',books.BOOK_NAME AS 'Book Name',book_issue_temp.QUANTITY AS 'Quantity' from book_issue_temp,books where book_issue_temp.ISBN = books.ISBN ORDER BY ID ASC", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        Book_issue.DataGridView_bi.DataSource = ds
        Book_issue.DataGridView_bi.DataMember = "books"
        Book_issue.DataGridView_bi.DefaultCellStyle.SelectionBackColor = Color.Gray
        Book_issue.DataGridView_bi.Columns(0).Width = 50
        Book_issue.DataGridView_bi.Columns(1).Visible = False
        Book_issue.DataGridView_bi.Columns(3).Width = 200
        Book_issue.DataGridView_bi.Columns(2).Width = 150
        Book_issue.DataGridView_bi.Columns(4).Width = 100
        cn.Close()

    End Sub

    Public Sub Tempbtn()

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.UseColumnTextForButtonValue = True
        btn.HeaderText = "Acion"
        btn.Name = "remove"
        btn.Text = "REMOVE"
        btn.FlatStyle = FlatStyle.Flat
        btn.InheritedStyle.BackColor = Color.Tomato
        btn.InheritedStyle.SelectionBackColor = Color.OrangeRed
        Book_issue.DataGridView_bi.Columns.Add(btn)

    End Sub

    Public Sub SelectBooks()

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT ISBN,BOOK_NAME as 'Book Name', AUTHOR AS 'Author', CATEGORY AS 'Category' FROM books ORDER BY BOOK_NAME ASC", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        Selectbook.DataGridView_selectbook.DataSource = ds
        Selectbook.DataGridView_selectbook.DataMember = "books"
        Selectbook.DataGridView_selectbook.DefaultCellStyle.SelectionBackColor = Color.Gray
        Selectbook.DataGridView_selectbook.Columns(0).Width = 100
        Selectbook.DataGridView_selectbook.Columns(1).Width = 150
        Selectbook.DataGridView_selectbook.Columns(3).Width = 150
        Selectbook.DataGridView_selectbook.Columns(4).Width = 120
        cn.Close()

    End Sub
    Public Sub Checkoutbtn()

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.UseColumnTextForButtonValue = True
        btn.HeaderText = "Acion"
        btn.Name = "mybtn1"
        btn.Text = "CHECK OUT"
        btn.FlatStyle = FlatStyle.Flat
        btn.InheritedStyle.BackColor = Color.LimeGreen
        btn.InheritedStyle.SelectionBackColor = Color.ForestGreen
        Selectbook.DataGridView_selectbook.Columns.Add(btn)

    End Sub

    Public Sub Selectmembers()

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT INDEX_NO AS 'Index No', FNAME AS 'First Name',LNAME AS 'Last Name',CATEGORY AS 'Category' FROM members WHERE is_deleted=0", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "members")
        Selectmember.DataGridView_selectmember.DataSource = ds
        Selectmember.DataGridView_selectmember.DataMember = "members"
        Selectmember.DataGridView_selectmember.DefaultCellStyle.SelectionBackColor = Color.Gray
        Selectmember.DataGridView_selectmember.Columns(0).Width = 100
        cn.Close()

    End Sub

    Public Sub Selectmemberbtn()

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.UseColumnTextForButtonValue = True
        btn.HeaderText = "Acion"
        btn.Name = "mybtn1"
        btn.Text = "SELECT"
        btn.FlatStyle = FlatStyle.Flat
        btn.InheritedStyle.BackColor = Color.DodgerBlue
        btn.InheritedStyle.SelectionBackColor = Color.DeepSkyBlue
        Selectmember.DataGridView_selectmember.Columns.Add(btn)

    End Sub

    'Restore Books Grid and Button
    Public Sub RestoreBooksgrid()

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT REFNO AS 'Issue ID',INDEX_NO AS 'Index No',ISBN,BOOK_NAME AS 'Book Name',QUANTITY AS 'Quantity',ISSUE_DATE AS 'Issue Date',ISSUE_EXPIRE_DATE AS 'Expire Date' FROM books_issued WHERE STATUS='Pending' ORDER BY ISSUE_DATE,TIME ASC;", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        Restorebooks.DataGridView_restorebooks.DataSource = ds
        Restorebooks.DataGridView_restorebooks.DataMember = "books"
        Restorebooks.DataGridView_restorebooks.DefaultCellStyle.SelectionBackColor = Color.Gray
        Restorebooks.DataGridView_restorebooks.Columns(0).Width = 100
        cn.Close()

    End Sub

    Public Sub RestoreBooksbtn()

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.UseColumnTextForButtonValue = True
        btn.HeaderText = "Acion"
        btn.Name = "mybtn1"
        btn.Text = "RESTORE"
        btn.FlatStyle = FlatStyle.Flat
        btn.InheritedStyle.BackColor = Color.DodgerBlue
        btn.InheritedStyle.SelectionBackColor = Color.DeepSkyBlue
        Restorebooks.DataGridView_restorebooks.Columns.Add(btn)

    End Sub

    Public Sub UsersettingsGrid()

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT USERNAME AS 'Username', FNAME AS 'First Name', LNAME AS 'Last Name', ADDRESS AS 'Address', TP AS 'Telephone No', TYPE AS 'Type' FROM login;", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "users")
        Main.DataGridView_usersettings.DataSource = ds
        Main.DataGridView_usersettings.DataMember = "users"
        Main.DataGridView_usersettings.DefaultCellStyle.SelectionBackColor = Color.Gray
        Main.DataGridView_usersettings.Columns(0).Width = 100
        Main.DataGridView_usersettings.Columns(1).Width = 100
        cn.Close()

    End Sub

    Public Sub Usersettingsbtn()

        Dim btn2 As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn2.UseColumnTextForButtonValue = True
        btn2.HeaderText = "Modify"
        btn2.Name = "mybtn2"
        btn2.Text = "MODIFY"
        btn2.FlatStyle = FlatStyle.Flat
        btn2.InheritedStyle.BackColor = Color.Yellow
        btn2.InheritedStyle.SelectionBackColor = Color.Gold
        Main.DataGridView_usersettings.Columns.Add(btn2)

        Dim btn As DataGridViewButtonColumn = New DataGridViewButtonColumn()
        btn.UseColumnTextForButtonValue = True
        btn.HeaderText = "Delete"
        btn.Name = "mybtn"
        btn.Text = "DELETE"
        btn.FlatStyle = FlatStyle.Flat
        btn.InheritedStyle.BackColor = Color.OrangeRed
        btn.InheritedStyle.SelectionBackColor = Color.Red
        Main.DataGridView_usersettings.Columns.Add(btn)

    End Sub
End Module
