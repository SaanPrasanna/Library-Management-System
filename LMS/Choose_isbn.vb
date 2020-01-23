Public Class Choose_isbn
    Private Sub Choose_isbn_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub Choose_isbn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
        Dim cmd As Odbc.OdbcCommand
        Dim adp As Odbc.OdbcDataAdapter
        Dim ds As New DataSet

        cn.Open()
        cmd = New Odbc.OdbcCommand("SELECT ISBN,BOOK_NAME as 'Name',PUBLISHER AS 'Publisher',AUTHOR AS 'Author', CATEGORY AS 'Category' FROM books ORDER BY DATE,TIME", cn)
        adp = New Odbc.OdbcDataAdapter(cmd)
        adp.Fill(ds, "books")
        DataGridView_isbn.DataSource = ds
        DataGridView_isbn.DataMember = "books"
        DataGridView_isbn.Columns(0).Width = 100
        DataGridView_isbn.Columns(1).Width = 210
        DataGridView_isbn.Columns(4).Width = 100
        DataGridView_isbn.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView_isbn.DefaultCellStyle.SelectionBackColor = Color.Gray

        cn.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub DataGridView_isbn_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_isbn.CellEnter

        Dim row As DataGridViewRow = DataGridView_isbn.CurrentRow
        Books_stockin.isbn_tb.Text = row.Cells(0).Value.ToString()

    End Sub
End Class