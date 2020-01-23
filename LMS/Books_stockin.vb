Imports MySql.Data.MySqlClient
Public Class Books_stockin
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub Cmd_close_Click(sender As Object, e As EventArgs) Handles Cmd_close.Click

        Me.Close()

    End Sub

    Private Sub Cmd_barcode_Click(sender As Object, e As EventArgs) Handles Cmd_barcode.Click

        Choose_isbn.Show()

    End Sub

    Private Sub Books_stockin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub Isbn_tb_TextChanged(sender As Object, e As EventArgs) Handles isbn_tb.TextChanged

        If (isbn_tb.Text <> "") Then
            Try

                Dim sql As String
                Dim rs As New ADODB.Recordset
                Call Getconnection()
                con.Open()
                sql = "SELECT * FROM books WHERE ISBN = '" & isbn_tb.Text & "';"
                rs = con.Execute(sql)
                name_tb.Text = rs.Fields("BOOK_NAME").Value
                publisher_tb.Text = rs.Fields("PUBLISHER").Value
                author_tb.Text = rs.Fields("AUTHOR").Value
                quantity_on_hand_tb.Text = rs.Fields("QUANTITY").Value
                con.Close()
                total_quantity_tb.Text = ""
                new_quantity_tb.Text = ""

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If

    End Sub

    Private Sub New_quantity_tb_TextChanged(sender As Object, e As EventArgs) Handles new_quantity_tb.TextChanged

        If (quantity_on_hand_tb.Text <> "") Then
            total_quantity_tb.Text = Val(quantity_on_hand_tb.Text) + Val(new_quantity_tb.Text)
        Else

            MessageBox.Show("First be Select ISBN Number", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If

        If (new_quantity_tb.Text = "") Then
            total_quantity_tb.Text = ""
        End If

    End Sub

    Private Sub Books_stockin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Books_in_Grid()
        connection.Open()
        Dim sql As String = "SELECT COUNT(*) FROM books_stock_in;"
        Dim cmd As New MySqlCommand(sql, connection)
        Dim count As Integer = cmd.ExecuteScalar()
        connection.Close()
        count = count + 1

        refno_tb.Text = "#REF" + count.ToString
    End Sub

    Private Sub Cmd_add_stock_Click(sender As Object, e As EventArgs) Handles Cmd_add_stock.Click

        If (new_quantity_tb.Text <> "") Then

            Try

                Dim sql_update, sql_insert, Now_date, Now_time, description As String
                Dim rs As New ADODB.Recordset

                Now_date = Format(Now(), "yyyy-MM-dd") 'get date
                Now_time = Format(Now(), "HH:mm:ss") 'get time

                If (description_tb.Text = "") Then
                    description = "Null"
                Else
                    description = description_tb.Text
                End If

                Call Getconnection()
                con.Open()
                sql_insert = "INSERT INTO books_stock_in VALUES('" & refno_tb.Text & "','" & isbn_tb.Text & "'," & Val(new_quantity_tb.Text) & ",'" & description & "','" & Now_date & "','" & Now_time & "','" & Main.uname_lbl.Text & "')"
                sql_update = "UPDATE books SET QUANTITY = " & Val(total_quantity_tb.Text) & " WHERE ISBN = '" & isbn_tb.Text & "';"
                rs = con.Execute(sql_insert)
                rs = con.Execute(sql_update)
                MessageBox.Show("[" & isbn_tb.Text & "] --> Added [" & new_quantity_tb.Text & "]")

                'Dashboard part
                Main.d_total_books.Text = Allbooks()
                Main.d_pending_books.Text = Allpending()
                Main.d_available.Text = (Allbooks() - Allpending())
                'Call Method to refresh the Datagridview
                Books_in_Grid()
            Catch ex As Exception

            End Try
            con.Close()

        Else

            MessageBox.Show("Some Fields are Empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If


    End Sub

    Private Sub New_quantity_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles new_quantity_tb.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Public Sub Books_in_Grid()

        Dim Now_date As String = Format(Now(), "yyyy-MM-dd") 'get date
        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT REFNO AS 'Ref No',ISBN AS 'ISBN No', DESCRIPTION AS 'Description', QUANTITY AS 'Quantity',DATE AS 'Date',TIME AS 'Time', UNAME AS 'By' FROM books_stock_in WHERE DATE = '" & Now_date & "' ORDER BY DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        DataGridView_books_in.DataSource = ds
        DataGridView_books_in.DataMember = "books"
        DataGridView_books_in.Columns(0).Width = 120
        DataGridView_books_in.Columns(1).Width = 150
        DataGridView_books_in.Columns(2).Width = 500
        DataGridView_books_in.Columns(3).Width = 100
        DataGridView_books_in.Columns(4).Width = 100
        DataGridView_books_in.Columns(5).Width = 100
        DataGridView_books_in.Columns(6).Width = 100
        ' DataGridView_books_in.CurrentCell.Selected = False
        DataGridView_books_in.DefaultCellStyle.SelectionBackColor = Color.Gray

        cn.Close()

    End Sub
End Class