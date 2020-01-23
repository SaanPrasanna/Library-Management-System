Imports MySql.Data.MySqlClient
Public Class Issue_popup
    Dim quantity As Integer
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub Item_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles item_tb.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            Dim request As Integer = Val(item_tb.Text)

            If (request <> 0) Then

                Try

                    connection.Open()
                    'Generate id
                    Dim sql_count As String = "SELECT COUNT(*) FROM book_issue_temp;"
                    Dim cmd_count As New MySqlCommand(sql_count, connection)
                    Dim id As Integer = cmd_count.ExecuteScalar() + 1

                    'Limit for the member
                    Dim sql As String = "SELECT category.Numof_books FROM members,category where category.category = members.CATEGORY and members.INDEX_NO='" & Book_issue.membername_tb.Text & "';"
                    Dim cmd As New MySqlCommand(sql, connection)

                    'Now issue books
                    Dim now_books As Integer = 0

                    Try
                        Dim sql_issuebooks As String = "SELECT SUM(QUANTITY) FROM book_issue_temp;"
                        Dim cmd_issuebooks As New MySqlCommand(sql_issuebooks, connection)
                        now_books = cmd_issuebooks.ExecuteScalar()
                    Catch ex As Exception

                    End Try

                    'PENDING BOOKS FOR THIS INDEX NO
                    Dim pendingbooks As Integer = 0
                    Try
                        Dim sql_pendingbooks As String = "SELECT SUM(QUANTITY) FROM books_issued WHERE INDEX_NO = '" & Book_issue.membername_tb.Text & "' AND STATUS ='Pending';"
                        Dim cmd_pendingbooks As New MySqlCommand(sql_pendingbooks, connection)
                        pendingbooks = pendingbooks + cmd_pendingbooks.ExecuteScalar() 'FINAL PENDING BOOKS OF THIS MEMBER
                    Catch ex As Exception

                    End Try


                    'Final limit
                    Dim limit As Integer = cmd.ExecuteScalar() - now_books   'MEMBERS BOOKS LIMIT IF(STUDETN/OTHER)

                    Dim books_quantity As Integer = Val(quantity_lbl.Text) 'REMAINING THE BOOKS IN THE BOOKS STOCK(LIBRARY)
                    connection.Close()

                    If (request <= limit) Then

                        limit = limit - pendingbooks

                        If (request <= limit) Then

                            If (request <= books_quantity) Then
                                'MsgBox("Request book pass " & request)
                                'Request found
                                Call Getconnection()
                                con.Open()
                                'MsgBox(isbn_lbl.Text & " " & Book_issue.membername_tb.Text & " " & request)
                                Dim sql_temp As String = "INSERT INTO book_issue_temp VALUES(" & id & ",'" & isbn_lbl.Text & "','" & Book_issue.membername_tb.Text & "'," & request & ");"
                                Dim rs As New ADODB.Recordset
                                rs = con.Execute(sql_temp)

                                If (Book_issue.DataGridView_bi.Columns.Count < 5) Then
                                    Tempbtn()
                                End If
                                Temp()

                                Me.Close()
                                con.Close()
                                Book_issue.Cmd_issuebook.Enabled = True

                            Else
                                MessageBox.Show("Stock have only [" & books_quantity & "] Book(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                        Else
                            MessageBox.Show(pendingbooks & " Pending Book(s) Found ! Restore first" & vbCrLf & "You can Issue only " & (limit) & " Book(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If

                    Else
                        MessageBox.Show("You Can only Issue [" & limit & "] Book(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Book Issue Failed ! " & vbCrLf & "Error Code : " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else

                MessageBox.Show("Select at least one Book", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If



        End If

    End Sub

    Private Sub Issue_popup_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub
End Class