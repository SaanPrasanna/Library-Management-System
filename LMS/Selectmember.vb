Public Class Selectmember

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Selectmember_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub DataGridView_selectmember_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_selectmember.CellContentClick
        If (e.ColumnIndex() = 0) Then
            'Validate the Member is expire or no
            If (Isvalidatemember(DataGridView_selectmember.Rows(e.RowIndex).Cells(1).Value) = "can") Then
                Book_issue.membername_tb.Text = DataGridView_selectmember.Rows(e.RowIndex).Cells(1).Value
                Book_issue.Cmd_selectmember.Enabled = False
                Book_issue.Cmd_new.Enabled = True
                Book_issue.Cmd_selectbook.Enabled = True
                Me.Close()
            Else
                MessageBox.Show("Renew the Member first !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        End If
    End Sub

    Private Sub Selectmember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        searchbox_tb.Text = "Search By --> [INDEX NO]"
        If (DataGridView_selectmember.Columns.Count < 5) Then
            Selectmemberbtn()
        End If
        Selectmembers()

    End Sub

    Public Sub SearchGrid()

        If (searchbox_tb.Text.Trim <> "") Then

            Dim cn As New Odbc.OdbcConnection("Driver={MySQl ODBC 3.51 Driver};server=localhost;user=root;password=;database=lms;")
            Dim cmd As Odbc.OdbcCommand
            Dim adp As Odbc.OdbcDataAdapter
            Dim ds As New DataSet

            cn.Open()
            cmd = New Odbc.OdbcCommand("SELECT INDEX_NO AS 'Index No', FNAME AS 'First Name',LNAME AS 'Last Name',CATEGORY AS 'Category' FROM members WHERE INDEX_NO LIKE '%" & searchbox_tb.Text & "%' ORDER BY FNAME,LNAME ASC", cn)
            adp = New Odbc.OdbcDataAdapter(cmd)
            adp.Fill(ds, "members")
            DataGridView_selectmember.DataSource = ds
            DataGridView_selectmember.DataMember = "members"
            DataGridView_selectmember.DefaultCellStyle.SelectionBackColor = Color.Gray
            cn.Close()

        Else

            If (DataGridView_selectmember.Columns.Count < 5) Then
                Selectmemberbtn()
            End If
            Selectmembers()

        End If


    End Sub

    Private Sub Searchbox_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles searchbox_tb.KeyDown

        If (e.KeyCode = Keys.Enter) Then
            SearchGrid()
        End If

    End Sub

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
End Class