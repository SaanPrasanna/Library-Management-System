Imports MySql.Data.MySqlClient

Public Class Login
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Private Sub Username_tb_GotFocus(sender As Object, e As EventArgs) Handles Username_tb.GotFocus
        If (Username_tb.Text = "Enter Username") Then
            Username_tb.Text = ""
        End If
    End Sub

    Private Sub Username_tb_LostFocus(sender As Object, e As EventArgs) Handles Username_tb.LostFocus
        If (Username_tb.Text = "") Then
            Username_tb.Text = "Enter Username"
        End If
    End Sub

    Private Sub Password_tb_GotFocus(sender As Object, e As EventArgs) Handles Password_tb.GotFocus
        If (Password_tb.Text = "Enter Password") Then
            Password_tb.Text = ""
            Password_tb.PasswordChar = "*"
        End If
    End Sub

    Private Sub Password_tb_LostFocus(sender As Object, e As EventArgs) Handles Password_tb.LostFocus
        If (Password_tb.Text = "") Then
            Password_tb.Text = "Enter Password"
            Password_tb.PasswordChar = Nothing
        End If
    End Sub

    Private Sub Cmd_exit_Click(sender As Object, e As EventArgs) Handles Cmd_exit.Click

        Dim x As Integer = MessageBox.Show("Are You sure You want to Exit this Application", "Exiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (x = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub Cmd_login_Click(sender As Object, e As EventArgs) Handles Cmd_login.Click

        Dim uname, pw, type, name As String

        uname = Username_tb.Text
        pw = Password_tb.Text

        If (uname <> "") And (pw <> "") And (uname <> "Enter Username") And (pw <> "Enter Password") Then
            Dim cmd As New MySqlCommand("SELECT TYPE FROM login WHERE USERNAME = '" & uname & "' AND PASSWORD ='" & pw & "' LIMIT 1;", connection)
            Dim cmd2 As New MySqlCommand("SELECT USERNAME FROM login WHERE USERNAME = '" & uname & "' AND PASSWORD ='" & pw & "' LIMIT 1;", connection)

            'with Handling exception
            Try
                connection.Open()
                type = cmd.ExecuteScalar()
                name = cmd2.ExecuteScalar()
                connection.Close()
                If (type <> "") Then
                    'valid User found
                    If ((type = "admin") Or (type = "moderator")) Then

                        Username_tb.Text = ""
                        Password_tb.Text = ""
                        Loading.Show()
                        Main.uname_lbl.Text = name
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Wrong Username or Password !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Something Was going wrong, Database Not connected !", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Some Fields are Empty !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
