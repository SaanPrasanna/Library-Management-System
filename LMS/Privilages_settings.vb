Imports MySql.Data.MySqlClient
Public Class Privilages_settings
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
                        Main.Panel_settings.Show()

                        Main.panel_books.Hide()
                        Main.Panel_members.Hide()
                        Main.Panel_booksin.Hide()
                        Main.Panel_ba.Hide()
                        Main.Panel_bi.Hide()
                        Main.Panel_reports.Hide()

                        If (Main.DataGridView_usersettings.Columns.Count < 8) Then
                            Usersettingsbtn()
                        End If
                        UsersettingsGrid()

                        'Members(Students/Others) seting auto filling part
                        Try

                            'Getting the valued of the Studuent data
                            Call Getconnection()
                            con.Open()
                            Dim sqls As String = "SELECT * FROM category WHERE category = 'Student';"
                            Dim rs As New ADODB.Recordset
                            rs = con.Execute(sqls)
                            Main.srf_tb.Text = Format(rs.Fields("Price").Value, "0.00")
                            Main.srt_tb.Text = rs.Fields("renew_after").Value
                            Main.sib_tb.Text = rs.Fields("Numof_books").Value
                            Main.sdays_tb.Text = rs.Fields("days").Value
                            Main.sfines_tb.Text = Format(rs.Fields("fines").Value, "0.00")

                            rs = Nothing
                            Dim sql_others As String = "SELECT * FROM category WHERE category = 'Others';"
                            rs = con.Execute(sql_others)
                            Main.orf_tb.Text = Format(rs.Fields("Price").Value, "0.00")
                            Main.ort_tb.Text = rs.Fields("renew_after").Value
                            Main.oib_tb.Text = rs.Fields("Numof_books").Value
                            Main.odays_tb.Text = rs.Fields("days").Value
                            Main.ofines_tb.Text = Format(rs.Fields("Fines").Value, "0.00")
                            con.Close()

                            Me.Close()
                        Catch ex As Exception
                            MsgBox(ex.ToString)
                        End Try
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

    Private Sub Privilages_settings_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class