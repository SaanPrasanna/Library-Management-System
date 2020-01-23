Public Class Modify_users
    Private Sub Modify_users_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Cmd_modify_Click(sender As Object, e As EventArgs) Handles Cmd_modify.Click
        Try

            If (fname_tb.Text.Trim <> "" And lname_tb.Text.Trim <> "" And address_tb.Text.Trim <> "" And tp_tb.Text.Trim <> "" And type_cb.Text <> "") Then
                Call Getconnection()
                con.Open()
                Dim sql As String = "UPDATE login SET FNAME='" & fname_tb.Text & "',LNAME = '" & lname_tb.Text & "',ADDRESS='" & address_tb.Text & "',TP = '" & tp_tb.Text & "',TYPE = '" & type_cb.Text & "' WHERE USERNAME = '" & username_tb.Text & "';"
                Dim rs As New ADODB.Recordset
                rs = con.Execute(sql)
                MessageBox.Show("User Modified !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Refreshing the datagridview
                If (Main.DataGridView_usersettings.Columns.Count < 8) Then
                    Usersettingsbtn()
                End If
                UsersettingsGrid()

                con.Close()

            Else
                MessageBox.Show("Some Fields are Empty !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception

            MessageBox.Show("Error code : " & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub

    Private Sub tp_tb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tp_tb.KeyPress


        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class