Public Class Restorebooks

    Private Sub Searchbox_tb_GotFocus(sender As Object, e As EventArgs) Handles searchbox_tb.GotFocus

        If (searchbox_tb.Text = "Search By --> [INDEX NO]") Then
            searchbox_tb.Text = ""
        End If

    End Sub
    Private Sub Searchbox_tb_LostFocus(sender As Object, e As EventArgs) Handles searchbox_tb.LostFocus

        If (searchbox_tb.Text.Trim = "") Then
            searchbox_tb.Text = "Search By --> [INDEX NO]"
            Selectmembers()
        End If

    End Sub

    Private Sub Restorebooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (DataGridView_restorebooks.Columns.Count < 7) Then
            RestoreBooksbtn()
        End If
        RestoreBooksgrid()
        searchbox_tb.Text = "Search By --> [INDEX NO]"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Restorebooks_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Public Sub SearchGrid()

        If (searchbox_tb.Text.Trim <> "") Then

            Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
            Dim cmd As Odbc.OdbcCommand
            Dim adp As Odbc.OdbcDataAdapter
            Dim ds As New DataSet

            cn.Open()
            cmd = New Odbc.OdbcCommand("SELECT REFNO AS 'Issue ID',INDEX_NO AS 'Index No',ISBN,BOOK_NAME AS 'Book Name',QUANTITY AS 'Quantity',ISSUE_DATE AS 'Issue Date',ISSUE_EXPIRE_DATE AS 'Expire Date' FROM books_issued WHERE STATUS='Pending' AND INDEX_NO LIKE '%" & searchbox_tb.Text & "%' ORDER BY ISSUE_DATE,TIME ASC;", cn)
            adp = New Odbc.OdbcDataAdapter(cmd)
            adp.Fill(ds, "books")
            DataGridView_restorebooks.DataSource = ds
            DataGridView_restorebooks.DataMember = "books"
            DataGridView_restorebooks.DefaultCellStyle.SelectionBackColor = Color.Gray
            cn.Close()

        Else

            If (DataGridView_restorebooks.Columns.Count < 7) Then
                RestoreBooksbtn()
            End If
            RestoreBooksgrid()

        End If


    End Sub

    Private Sub Searchbox_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles searchbox_tb.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            SearchGrid()
        End If

    End Sub

    Private Sub DataGridView_restorebooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_restorebooks.CellContentClick

        If (e.ColumnIndex() = 0) Then
            Try
                Restorefinal.issueid_tb.Text = DataGridView_restorebooks.Rows(e.RowIndex).Cells(1).Value
                Restorefinal.indexno_tb.Text = DataGridView_restorebooks.Rows(e.RowIndex).Cells(2).Value
                Restorefinal.isbn_tb.Text = DataGridView_restorebooks.Rows(e.RowIndex).Cells(3).Value
                Restorefinal.bookname_tb.Text = DataGridView_restorebooks.Rows(e.RowIndex).Cells(4).Value
                Restorefinal.quantity_tb.Text = DataGridView_restorebooks.Rows(e.RowIndex).Cells(5).Value
                Dim issue_date As Date = DataGridView_restorebooks.Rows(e.RowIndex).Cells(6).Value
                Dim expire_date As Date = DataGridView_restorebooks.Rows(e.RowIndex).Cells(7).Value
                Dim now_date As Date = Format(Now(), "yyyy-MM-dd")
                Dim fine As Double

                Dim diff As Integer = DateDiff(DateInterval.Day, expire_date, now_date)

                If (diff > 0) Then
                    fine = Fines(diff, DataGridView_restorebooks.Rows(e.RowIndex).Cells(2).Value)
                    Restorefinal.days_tb.Text = diff
                Else
                    fine = 0
                    Restorefinal.days_tb.Text = 0
                End If
                Restorefinal.fines_tb.Text = Format(fine, "0.00")
                Restorefinal.Show()

            Catch ex As Exception

            End Try



        End If

    End Sub


End Class