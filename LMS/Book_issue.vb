Imports MySql.Data.MySqlClient
Public Class Book_issue
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub Book_issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        biid_tb.Text = GetIssueid()
        membername_tb.Text = "Select the Member"
        Cmd_new.Enabled = False
        Cmd_selectbook.Enabled = False
        Cmd_issuebook.Enabled = False

        If (DataGridView_bi.Columns.Count < 5) Then
            Tempbtn()
        End If
        Temp()


    End Sub

    Private Sub Book_issue_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then

            Dim ans As Integer = MessageBox.Show("Do you want to close Book Issue", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (ans = vbYes) Then
                Me.Close()
                TempDelete()
                membername_tb.Text = Nothing
            Else

            End If

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans As Integer = MessageBox.Show("Do you want to close Book Issue", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If (ans = vbYes) Then
            Me.Close()
            TempDelete()
            membername_tb.Text = Nothing
        Else

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_new.Click

        biid_tb.Text = GetIssueid()
        membername_tb.Text = Nothing
        Cmd_new.Enabled = False
        Cmd_selectbook.Enabled = False
        Cmd_issuebook.Enabled = False
        Cmd_selectmember.Enabled = True
        TempDelete()
        Temp()

    End Sub

    Private Sub Cmd_selectmember_Click(sender As Object, e As EventArgs) Handles Cmd_selectmember.Click

        Selectmember.Show()

    End Sub

    Private Sub Cmd_selectbook_Click(sender As Object, e As EventArgs) Handles Cmd_selectbook.Click

        Selectbook.Show()

    End Sub

    Private Sub DataGridView_bi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_bi.CellContentClick

        If (e.ColumnIndex = 0) Then

            Dim ans As Integer = MessageBox.Show("Do You want to Remove Book(s)", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If (ans = vbYes) Then

                Dim id As Integer = DataGridView_bi.Rows(e.RowIndex).Cells(1).Value
                Call Getconnection()
                con.Open()
                Dim sql As String = "DELETE FROM book_issue_temp WHERE ID = " & id & ";"
                Dim rs As New ADODB.Recordset
                rs = con.Execute(sql)
                Temp()

                con.Close()

            Else

            End If

        End If

    End Sub

    Private Sub Cmd_issuebook_Click(sender As Object, e As EventArgs) Handles Cmd_issuebook.Click

        Dim ans As Integer = MessageBox.Show("Confirm Book Issue", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If (ans = vbYes) Then
            Try

                'Counting Records
                connection.Open()
                Dim sql As String = "SELECT COUNT(*) FROM book_issue_temp"
                Dim cmd As New MySqlCommand(sql, connection)
                Dim books As Integer = cmd.ExecuteScalar()
                connection.Close()

                'Updating the books stock and insert the records for books issue table
                Dim refno As String = biid_tb.Text 'Get Issue id
                Dim user As String = Main.uname_lbl.Text 'Get username
                Dim now_date As String = Format(Now(), "yyyy-MM-dd") 'get date
                Dim now_time As String = Format(Now(), "HH:mm:ss") 'get time

                For i = 1 To books

                    Call Getconnection()
                    con.Open()

                    Dim sql_temp As String
                    Dim rs_temp, rs As New ADODB.Recordset

                    sql_temp = "SELECT book_issue_temp.ID,book_issue_temp.ISBN,book_issue_temp.INDEX_NO,books.BOOK_NAME,book_issue_temp.QUANTITY,category.days FROM book_issue_temp,books,members,category WHERE book_issue_temp.ID = " & i & " AND books.ISBN = book_issue_temp.ISBN AND book_issue_temp.INDEX_NO=members.INDEX_NO AND members.CATEGORY = category.category;"
                    rs_temp = con.Execute(sql_temp)
                    Dim book_name As String = rs_temp.Fields("BOOK_NAME").Value 'BOOK NAME
                    Dim isbn As String = rs_temp.Fields("ISBN").Value 'ISBN
                    Dim index_no As String = rs_temp.Fields("INDEX_NO").Value 'INDEX NO
                    Dim quantity As Integer = rs_temp.Fields("QUANTITY").Value 'QUANTITY
                    Dim days As Integer = rs_temp.Fields("days").Value 'CATEGORY DAYS to calculate return date or expire date

                    '********** Calculate Renew Time period
                    Dim s_day As New Date
                    s_day = Format(Now(), "yyyy-MM-dd")
                    s_day = DateAdd(DateInterval.Day, days, s_day)
                    Dim expire_date As String
                    expire_date = Format(s_day, "yyyy-MM-dd") 'ISSUE EXPIRE DATE

                    'Get books table books quantitys
                    Dim sql_booksquantity As String = "SELECT QUANTITY FROM books WHERE ISBN = '" & isbn & "';"
                    rs = con.Execute(sql_booksquantity)
                    Dim books_quantity As Integer = 0
                    books_quantity = rs.Fields("QUANTITY").Value 'NOW STOCK BOOKS

                    'QUANTITY BALANCE
                    books_quantity = books_quantity - quantity


                    'Inserting data into the Books Issued Table 
                    Dim sql_bookissue As String
                    Dim rs_bookissue As New ADODB.Recordset
                    sql_bookissue = "INSERT INTO books_issued VALUES('" & refno & "','" & index_no & "','" & isbn & "','" & book_name & "','" & now_date & "','" & expire_date & "','Pending'," & quantity & "," & 0 & ",'" & user & "','" & now_time & "');"
                    rs_bookissue = con.Execute(sql_bookissue)

                    'Update the Books Stock
                    Dim sql_update As String
                    Dim rs_update As New ADODB.Recordset
                    sql_update = "UPDATE books SET QUANTITY =" & books_quantity & " WHERE ISBN = '" & isbn & "';"
                    rs = con.Execute(sql_update)

                    con.Close()

                Next

                TempDelete()
                biid_tb.Text = GetIssueid()
                Temp()
                BooksissueGrid()
                membername_tb.Text = Nothing

                MessageBox.Show("Book(s) Issued !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Dashboard part
                Main.d_total_books.Text = Allbooks()
                Main.d_pending_books.Text = Allpending()
                Main.d_available.Text = (Allbooks() - Allpending())

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try


        End If

    End Sub
End Class