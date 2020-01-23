Imports MySql.Data.MySqlClient
Public Class Books_Actions
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub DataGridView_ba_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ba.CellEnter

        Dim row As DataGridViewRow = DataGridView_ba.CurrentRow
        isnb_tb.Text = row.Cells(0).Value.ToString()
        bookname_tb.Text = row.Cells(1).Value.ToString()
        publisher_tb.Text = row.Cells(2).Value.ToString()
        author_tb.Text = row.Cells(3).Value.ToString()
        category_tb.Text = row.Cells(4).Value.ToString()
        quantity_tb.Text = row.Cells(5).Value.ToString()

    End Sub



    Private Sub Books_Actions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Call Method
        Books_actionGrid()
        searchbox_tb.Text = "Search By --> [ISBN]"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Books_Actions_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub
    Public Sub Books_actionGrid()

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT ISBN AS 'ISBN No', BOOK_NAME AS 'Book Name', PUBLISHER AS 'Publisher',AUTHOR AS 'Author', CATEGORY AS 'Category',QUANTITY AS 'Quantity' FROM books ORDER BY DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        DataGridView_ba.DataSource = ds
        DataGridView_ba.DataMember = "books"

        DataGridView_ba.Columns(0).Width = 120
        DataGridView_ba.Columns(1).Width = 200
        DataGridView_ba.Columns(4).Width = 80
        DataGridView_ba.Columns(5).Width = 80
        DataGridView_ba.DefaultCellStyle.SelectionBackColor = Color.Gray

        cn.Close()

    End Sub

    Private Sub Action_cb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles action_cb.SelectedIndexChanged, aq_tb.TextChanged, quantity_tb.TextChanged

        'Quantity management in the textbox or combobox change
        If (aq_tb.Text.Trim <> "" And action_cb.Text <> "") Then

            If (action_cb.Text = "Added") Then

                tq_tb.Text = Val(quantity_tb.Text) + Val(aq_tb.Text)

            ElseIf (action_cb.Text = "Removed") Then

                If (Val(quantity_tb.Text) >= Val(aq_tb.Text)) Then
                    tq_tb.Text = Val(quantity_tb.Text) - Val(aq_tb.Text)
                Else
                    MessageBox.Show("Book Stock have only [" & quantity_tb.Text & "] Book(s)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    action_cb.Text = ""
                    aq_tb.Text = ""
                    tq_tb.Text = ""
                End If

            End If
        End If

    End Sub

    Private Sub Cmd_save_Click(sender As Object, e As EventArgs) Handles Cmd_save.Click

        Dim sql_insert, sql_update, refno, Now_date, Now_time As String
        Dim rs As New ADODB.Recordset

        If (aq_tb.Text <> "" Or action_cb.Text <> "") Then

            Try
                'Generate the Ref No
                connection.Open()
                Dim query As String = "SELECT COUNT(*) FROM books_stock_manage;"
                Dim cmd As New MySqlCommand(query, connection)
                Dim count As Integer = cmd.ExecuteScalar()
                connection.Close()
                count = count + 1
                refno = "#REF" + count.ToString 'Final Reference Number here

                Now_date = Format(Now(), "yyyy-MM-dd") 'get date
                Now_time = Format(Now(), "HH:mm:ss") 'get time

                If (reason_tb.Text.Trim = "") Then
                    reason_tb.Text = "Null"
                End If

                Call Getconnection()
                con.Open()

                'Insert the values to the books_stock_manage table
                sql_insert = "INSERT INTO books_stock_manage VALUES('" & refno & "','" & isnb_tb.Text & "','" & reason_tb.Text & "'," & Val(aq_tb.Text) & ",'" & action_cb.Text & "','" & Now_date & "','" & Now_time & "','" & Main.uname_lbl.Text & "');"
                rs = con.Execute(sql_insert)

                'Update the Books table values
                sql_update = "UPDATE books SET QUANTITY ='" & Val(tq_tb.Text) & "' WHERE ISBN = '" & isnb_tb.Text & "';"
                rs = con.Execute(sql_update)

                'Call method to refresh the datagridview
                Books_actionGrid()
                Books_actionsGrid()

                MessageBox.Show(aq_tb.Text & ", [" & isnb_tb.Text & "] Book(s) " & action_cb.Text, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                aq_tb.Text = ""
                tq_tb.Text = ""
                reason_tb.Text = ""
                'Dashboard part
                Main.d_total_books.Text = Allbooks()
                Main.d_pending_books.Text = Allpending()
                Main.d_available.Text = (Allbooks() - Allpending())


                con.Close()
            Catch ex As Exception

            End Try

        Else

            MessageBox.Show("Some Fields are Empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

    End Sub

    Private Sub Searchbox_tb_GotFocus(sender As Object, e As EventArgs) Handles searchbox_tb.GotFocus

        If (searchbox_tb.Text = "Search By --> [ISBN]") Then
            searchbox_tb.Text = ""
        End If

    End Sub
    Private Sub Searchbox_tb_LostFocus(sender As Object, e As EventArgs) Handles searchbox_tb.LostFocus

        If (searchbox_tb.Text.Trim = "") Then
            searchbox_tb.Text = "Search By --> [ISBN]"
            Books_actionGrid()
        End If

    End Sub

    Private Sub Aq_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles aq_tb.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Public Sub SearchGrid()

        If (searchbox_tb.Text.Trim <> "") Then

            Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
            Dim cmd As Odbc.OdbcCommand
            Dim adp As Odbc.OdbcDataAdapter
            Dim ds As New DataSet

            cn.Open()
            cmd = New Odbc.OdbcCommand("SELECT ISBN AS 'ISBN No', BOOK_NAME AS 'Book Name', PUBLISHER AS 'Publisher',AUTHOR AS 'Author', CATEGORY AS 'Category',QUANTITY AS 'Quantity' FROM books WHERE ISBN LIKE '" & searchbox_tb.Text & "%' ORDER BY DATE,TIME", cn)
            adp = New Odbc.OdbcDataAdapter(cmd)
            adp.Fill(ds, "books")
            DataGridView_ba.DataSource = ds
            DataGridView_ba.DataMember = "books"

            DataGridView_ba.Columns(0).Width = 120
            DataGridView_ba.Columns(1).Width = 200
            DataGridView_ba.Columns(4).Width = 80
            DataGridView_ba.Columns(5).Width = 80
            DataGridView_ba.DefaultCellStyle.SelectionBackColor = Color.Gray

            cn.Close()

        Else

            Books_actionGrid()

        End If


    End Sub

    Private Sub Searchbox_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles searchbox_tb.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            SearchGrid()
        End If

    End Sub


End Class