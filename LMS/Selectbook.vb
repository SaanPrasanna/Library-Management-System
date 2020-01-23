Imports MySql.Data.MySqlClient
Public Class Selectbook
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Selectbook_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub Selectbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Call the method  to load the data grid
        If (DataGridView_selectbook.Columns.Count < 4) Then
            Checkoutbtn()
        End If
        SelectBooks()

    End Sub

    Public Sub SearchGrid()

        If (searchbox_tb.Text.Trim <> "") Then

            Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
            Dim cmd As Odbc.OdbcCommand
            Dim adp As Odbc.OdbcDataAdapter
            Dim ds As New DataSet

            cn.Open()
            cmd = New Odbc.OdbcCommand("SELECT ISBN,BOOK_NAME as 'Book Name', AUTHOR AS 'Author', CATEGORY AS 'Category' FROM books WHERE ISBN LIKE '" & searchbox_tb.Text & "%' ORDER BY DATE,TIME", cn)
            adp = New Odbc.OdbcDataAdapter(cmd)
            adp.Fill(ds, "books")
            DataGridView_selectbook.DataSource = ds
            DataGridView_selectbook.DataMember = "books"
            DataGridView_selectbook.DefaultCellStyle.SelectionBackColor = Color.Gray

            cn.Close()

        Else

            If (DataGridView_selectbook.Columns.Count < 4) Then
                Checkoutbtn()
            End If
            SelectBooks()

        End If


    End Sub

    Private Sub Searchbox_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles searchbox_tb.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            SearchGrid()
        End If

    End Sub

    Private Sub DataGridView_selectbook_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_selectbook.CellContentClick

        If (e.ColumnIndex = 0) Then

            connection.Open()
            'Stock on hand books
            Dim isbn As String = DataGridView_selectbook.Rows(e.RowIndex).Cells(1).Value
            Dim sql_bookscount As String = "SELECT QUANTITY FROM books WHERE ISBN = '" & isbn & "';"
            Dim rs As New ADODB.Recordset

            Call Getconnection()
            con.Open()
            rs = con.Execute(sql_bookscount)
            Dim books_quantity As Integer = rs.Fields("QUANTITY").Value 'final
            con.Close()

            connection.Close()

            Issue_popup.quantity_lbl.Text = books_quantity
            Issue_popup.isbn_lbl.Text = isbn

            Issue_popup.Show()

        End If

    End Sub

End Class