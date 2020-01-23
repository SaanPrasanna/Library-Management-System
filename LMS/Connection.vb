Module Connection
    Dim server As String
    Dim user As String
    Dim password As String
    Dim database As String

    Public con As New ADODB.Connection

    Public Function Getconnection() As String
        server = "localhost"
        user = "root"
        password = ""
        database = "lms"
        con.ConnectionString = "DSN =lms;Driver={MYSQL ODBC 3.51 Driver};server=" & server & ";user=" & user & ";database=" & database & ";password=" & password & ";"
        Return True
    End Function
End Module
