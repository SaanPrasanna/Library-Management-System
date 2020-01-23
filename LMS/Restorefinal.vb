Public Class Restorefinal
    Private Sub Suppliedbooks_tb_KeyPress(sender As Object, e As KeyPressEventArgs)
        'Disabling the a to z and spaces from ascii
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Restorefinal_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub Cmd_change_Click(sender As Object, e As EventArgs) Handles Cmd_change.Click

        Try

            Call Getconnection()
            con.Open()

            Dim quantity As Integer
            Dim rs As New ADODB.Recordset
            'Updating the books_issued table 
            Dim sql As String = "UPDATE books_issued SET STATUS='Returned',FINES_FEE=" & Val(fines_tb.Text) & " WHERE REFNO='" & issueid_tb.Text & "' AND INDEX_NO= '" & indexno_tb.Text & "' AND ISBN = '" & isbn_tb.Text & "';"
            'Finding the quantity of the books the same isbn
            Dim sql_booksquantity As String = "SELECT QUANTITY FROM books WHERE ISBN = '" & isbn_tb.Text & "';"

            rs = con.Execute(sql_booksquantity)
            quantity = rs.Fields("QUANTITY").Value
            quantity = quantity + Val(quantity_tb.Text)
            'Update the books table add the issue book
            Dim sql_booksupdate As String = "UPDATE books SET QUANTITY = " & quantity & " WHERE ISBN='" & isbn_tb.Text & "';"
            rs = con.Execute(sql_booksupdate)
            rs = con.Execute(sql)
            con.Close()
            MessageBox.Show("Book(s) Restored !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

            'Dashboard part
            Main.d_total_books.Text = Allbooks()
            Main.d_pending_books.Text = Allpending()
            Main.d_available.Text = (Allbooks() - Allpending())

            'Refresh the Datagridview
            If (Restorebooks.DataGridView_restorebooks.Columns.Count < 7) Then
                RestoreBooksbtn()
            End If
            RestoreBooksgrid()

            'Main datagrid view refresh
            BooksissueGrid()

        Catch ex As Exception

            MessageBox.Show("Error : " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
End Class