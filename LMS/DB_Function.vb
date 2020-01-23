Imports MySql.Data.MySqlClient
Module DB_Function

    Dim connection As New MySqlConnection("server=localhost;user=root;password=;database=lms;")

    Public Function GetIssueid() As String

        Dim now_date As String = Format(Now(), "yyyy-MM-dd")
        connection.Open()
        Dim cmd As New MySqlCommand("SELECT  COUNT(DISTINCT(REFNO)) FROM books_issued WHERE ISSUE_DATE='" & now_date & "';", connection)
        Dim count As Integer
        count = cmd.ExecuteScalar()
        connection.Close()

        'Generate the Next number Count
        count = Val(count) + 1
        Dim strNum As String = count.ToString

        'Generate the Book Issue ID
        Dim refNo As String = DateTime.Now.Year & DateTime.Now.Month.ToString("00") & DateTime.Now.Day.ToString & New String("0", 3 - strNum.Length) & strNum
        Return refNo

    End Function

    Public Sub TempDelete()
        connection.Open()
        Dim query_tableempty As String = "DELETE FROM book_issue_temp;"
        Dim cmd_tableempty As New MySqlCommand(query_tableempty, connection)
        cmd_tableempty.ExecuteScalar()
        connection.Close()
    End Sub

    Public Function Fines(ByVal fine As Integer, ByVal category As String) As Double

        connection.Open()
        Dim sql As String = "SELECT category.fines FROM category,members WHERE members.CATEGORY = category.category AND members.INDEX_NO ='" & category & "'"
        Dim cmd As New MySqlCommand(sql, connection)
        Dim cost As Double
        cost = cmd.ExecuteScalar()

        connection.Close()

        Return (cost * fine)

    End Function

    Public Function Isvalidatemember(ByVal indexno As String) As String

        Call Getconnection()
        con.Open()
        Dim result As String
        Dim sql As String = "SELECT RENEW_DATE FROM members WHERE INDEX_NO = '" & indexno & "';"
        Dim rs As New ADODB.Recordset
        rs = con.Execute(sql)
        Dim renewdate As Date = rs.Fields("RENEW_DATE").Value

        con.Close()

        Dim nowdate As Date = Format(Now(), "yyyy-MM-dd")

        If (nowdate > renewdate) Then
            result = "can't"
        Else
            result = "can"
        End If

        Return result

    End Function

    'Getting the all books from now stock have
    Public Function Allbooks() As Integer

        connection.Open()
        Dim count As Integer = 0
        Dim sql As String = "SELECT SUM(QUANTITY) FROM books"
        Dim cmd As New MySqlCommand(sql, connection)
        If (IsDBNull(cmd.ExecuteScalar())) Then
            count = 0
        Else
            count = cmd.ExecuteScalar()
        End If
        connection.Close()
        Return count

    End Function

    'Getting the all Members 
    Public Function Allmemvers() As Integer

        connection.Open()
        Dim count As Integer
        Dim sql As String = "SELECT COUNT(*) FROM members WHERE is_deleted = 0"
        Dim cmd As New MySqlCommand(sql, connection)
        If (IsDBNull(cmd.ExecuteScalar())) Then
            count = 0
        Else
            count = cmd.ExecuteScalar()
        End If
        connection.Close()
        Return count

    End Function

    'Getting All Pending books
    Public Function Allpending() As Integer

        connection.Open()
        Dim count As Integer
        Dim sql As String = "SELECT SUM(QUANTITY) FROM books_issued WHERE STATUS = 'Pending';"
        Dim cmd As New MySqlCommand(sql, connection)
        If (IsDBNull(cmd.ExecuteScalar())) Then
            count = 0
        Else
            count = cmd.ExecuteScalar()
        End If
        connection.Close()
        Return count

    End Function


End Module
