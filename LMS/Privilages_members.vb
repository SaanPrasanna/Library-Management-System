Imports MySql.Data.MySqlClient

Public Class Privilages_members
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub Check_admin_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        password_tb.Text = "Enter Password"
        username_tb.Text = "Enter Username"
        username_tb.Select()
    End Sub
    Private Sub Username_tb_GotFocus(sender As Object, e As EventArgs) Handles username_tb.GotFocus
        If (username_tb.Text = "Enter Username") Then
            username_tb.Text = ""
        End If
    End Sub

    Private Sub Username_tb_LostFocus(sender As Object, e As EventArgs) Handles username_tb.LostFocus
        If (username_tb.Text = "") Then
            username_tb.Text = "Enter Username"
        End If
    End Sub

    Private Sub Password_tb_GotFocus(sender As Object, e As EventArgs) Handles password_tb.GotFocus
        If (password_tb.Text = "Enter Password") Then
            password_tb.Text = ""
            password_tb.PasswordChar = "*"
        End If
    End Sub

    Private Sub Password_tb_LostFocus(sender As Object, e As EventArgs) Handles password_tb.LostFocus
        If (password_tb.Text = "") Then
            password_tb.Text = "Enter Password"
            password_tb.PasswordChar = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Password_tb_KeyDown(sender As Object, e As KeyEventArgs) Handles password_tb.KeyDown, username_tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ((password_tb.Text <> "") And (username_tb.Text <> "")) Then
                Try

                    connection.Open()
                    Dim sql As String = "SELECT COUNT(*) FROM login where USERNAME = '" & username_tb.Text & "' AND PASSWORD = '" & password_tb.Text & "' AND TYPE = 'admin'"
                    Dim cmd As New MySqlCommand(sql, connection)
                    Dim count As Integer = cmd.ExecuteScalar()
                    If (count = 1) Then
                        Dim idx As String = idx_lbl.Text
                        Dim cmd2 As New MySqlCommand("UPDATE members SET is_deleted = 1 WHERE INDEX_NO='" & idx & "';", connection)
                        cmd2.ExecuteScalar()

                        'Call Method
                        Dim c As Integer
                        c = Main.DataGridView_members.Columns.Count
                        If (c < 12) Then
                            Addbuttons_members()
                        End If
                        Members()
                        MessageBox.Show("[" & idx & "] --> Member Deleted.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'Dashboard part
                        Main.d_total_books.Text = Allbooks()
                        Main.d_pending_books.Text = Allpending()
                        Main.d_available.Text = (Allbooks() - Allpending())
                        Main.d_totalMembers.Text = Allmemvers()
                        Me.Close()
                    Else
                        MessageBox.Show("Access Denied !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    connection.Close()

                Catch ex As Exception

                End Try
            Else

                MessageBox.Show("Empty Fields !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub Privilages_members_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
End Class