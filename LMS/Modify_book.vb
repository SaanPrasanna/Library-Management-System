Public Class Modify_book
    Private Sub Cmd_modify_Click(sender As Object, e As EventArgs) Handles Cmd_modify.Click

        Try
            Dim sql As String
            Dim rs As ADODB.Recordset

            Call Getconnection()
            con.Open()
            sql = "UPDATE books SET BOOK_NAME = '" & bn_tb.Text & "',PUBLISHER = '" & publisher_tb.Text & "',AUTHOR = '" & author_tb.Text & "',CATEGORY = '" & category_tb.Text & "' WHERE ISBN = '" & isbn_tb.Text & "';"
            rs = con.Execute(sql)
            MessageBox.Show("[" & isbn_tb.Text & "] --> Book is Modified")
            con.Close()

            'Call Method
            Dim c As Integer
            c = Main.DataGridView_books.Columns.Count
            If (c < 11) Then
                Addbuttons_books()
            End If
            Books()

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error Code: " & vbCrLf & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Modify_book_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
End Class