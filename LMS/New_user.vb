Public Class New_user
    Private Sub Cmd_modify_Click(sender As Object, e As EventArgs) Handles Cmd_modify.Click

        Try
            If (username_tb.Text.Trim <> "" And pw_tb.Text.Trim <> "" And cpw_tb.Text.Trim <> "" And address_tb.Text.Trim <> "" And tp_tb.Text.Trim <> "" And type_cb.Text <> "") Then
                If (pw_tb.Text = cpw_tb.Text) Then

                    Call Getconnection()
                    con.Open()

                    Dim sql As String = "INSERT INTO login VALUES('" & username_tb.Text & "','" & pw_tb.Text & "','" & fname_tb.Text & "','" & lname_tb.Text & "','" & address_tb.Text & "','" & tp_tb.Text & "','" & type_cb.Text & "');"
                    Dim rs As New ADODB.Recordset
                    rs = con.Execute(sql)
                    con.Close()
                    MessageBox.Show(username_tb.Text & " Added !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Refreshing the datagridview
                    If (Main.DataGridView_usersettings.Columns.Count < 8) Then
                        Usersettingsbtn()
                    End If
                    UsersettingsGrid()

                    Me.Close()

                Else
                    MessageBox.Show("password Does not Matched", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Some Fields are Empty !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub New_user_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class