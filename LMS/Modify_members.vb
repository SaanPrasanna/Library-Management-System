Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Modify_members
    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")
    Private Sub Modify_members_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Category_cb_TextChanged(sender As Object, e As EventArgs) Handles category_cb.TextChanged

        Dim renew_date As Integer
        Try

            connection.Open()
            Dim cmd_renew As New MySqlCommand("SELECT renew_after FROM category WHERE category = '" & category_cb.Text & "';", connection)
            Dim cmd_fee As New MySqlCommand("SELECT price FROM category WHERE category = '" & category_cb.Text & "';", connection)
            renew_date = cmd_renew.ExecuteScalar()
            fee_tb.Text = cmd_fee.ExecuteScalar()
            '********** Calculate Renew Time period
            Dim s_day As New Date
            s_day = Format(Now(), "yyyy-MM-dd")
            s_day = DateAdd(DateInterval.Month, renew_date, s_day)
            Dim r_date As String
            r_date = Format(s_day, "yyyy-MM-dd")
            renew_tb.Text = r_date


        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try
        connection.Close()

    End Sub

    Private Sub Cmd_modify_Click(sender As Object, e As EventArgs) Handles Cmd_modify.Click

        Try
            Dim sql As String
            Dim rs As ADODB.Recordset

            Call Getconnection()
            con.Open()
            sql = "UPDATE members SET FNAME = '" & fname_tb.Text & "',LNAME = '" & lname_tb.Text & "',ADDRESS = '" & address_tb.Text & "',EMAIL = '" & email_tb.Text & "', CATEGORY = '" & category_cb.Text & "', FEE = " & Val(fee_tb.Text) & " ,RENEW_DATE = '" & renew_tb.Text & "' WHERE INDEX_NO = '" & index_tb.Text & "';"
            rs = con.Execute(sql)

            MessageBox.Show("[" & index_tb.Text & "] --> Member is Modified")
            con.Close()

            'Call Method
            Dim c As Integer
            c = Main.DataGridView_members.Columns.Count
            If (c < 12) Then
                Addbuttons_members()
            End If
            Members()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error Code: " & vbCrLf & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Cmd_change_Click(sender As Object, e As EventArgs) Handles Cmd_change.Click

        category_tb.Visible = False
        category_cb.Visible = True
        category_tb.Text = category_cb.Text

    End Sub
End Class