
Public Class New_book
    Private Sub Cmd_add_Click(sender As Object, e As EventArgs) Handles cmd_add.Click

        Dim Now_date, Now_time, sql As String
        Dim quantity As String
        Dim rs As ADODB.Recordset

        quantity = 0
        Now_date = Format(Now(), "yyyy-MM-dd") 'get date
        Now_time = Format(Now(), "HH:mm:ss") 'get time

        If ((isbn_tb.Text.Trim <> "") And (bn_tb.Text.Trim <> "") And (publisher_tb.Text.Trim <> "") And (category_tb.Text.Trim <> "") And (author_tb.Text.Trim <> "")) Then
            Call Getconnection()
            Try
                con.Open()
                sql = "INSERT INTO books VALUES('" & isbn_tb.Text & "','" & bn_tb.Text & "','" & publisher_tb.Text & "','" & author_tb.Text & "','" & category_tb.Text & "'," & quantity & ",'" & Now_date & "','" & Now_time & "','" & Main.uname_lbl.Text & "');"
                rs = con.Execute(sql)
                MessageBox.Show("Add New Book", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                con.Close()
                Me.Close()

                'Dashboard part
                Main.d_total_books.Text = Allbooks()
                Main.d_pending_books.Text = Allpending()
                Main.d_available.Text = (Allbooks() - Allpending())
                Main.d_totalMembers.Text = Allmemvers()
                'Call Method
                Dim c As Integer
                c = Main.DataGridView_books.Columns.Count
                If (c < 11) Then
                    Addbuttons_books()
                End If
                Books()

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
        Else
            MessageBox.Show("Some Fields are Empty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub New_book_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

End Class