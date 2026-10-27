Public Class classConnection
    Public Shared servername As String = "172.16.3.10"    ' "ESCH-SVR-DB", "172.16.3.10"
    Public Shared database As String = "Gemmasoft"
    Public Userid As String = "sa"
    Public Password As String = "sql@min"

    Public Shared servernamePOC As String = "172.16.3.10"   '"ESCH-SVR-DB" , "172.16.3.10"
    Public Shared databasePOC As String = "POC"
    Public UseridPOC As String = "sa"
    Public PasswordPOC As String = "sql@min"

    '-------------Gemma POC Server
    Dim connstrPOC As String = "Data Source=" & servernamePOC & ";Initial Catalog=" & databasePOC & ";User ID=" & UseridPOC & ";pwd=" & PasswordPOC

    Public Function connection() As String
        'Build from the current values every time.  The selected database or
        'credentials may change after the class is instantiated.
        Dim builder As New System.Data.SqlClient.SqlConnectionStringBuilder
        builder.DataSource = servername
        builder.InitialCatalog = database
        builder.UserID = Userid
        builder.Password = Password
        builder.IntegratedSecurity = False

        Return builder.ConnectionString
    End Function
    Public Function getSQLConnection() As System.Data.SqlClient.SqlConnection
        Return New System.Data.SqlClient.SqlConnection(connection())
    End Function
    Public Function getSQLConnectionPOC() As System.Data.SqlClient.SqlConnection
        Dim cn As New System.Data.SqlClient.SqlConnection
        cn.ConnectionString = connstrPOC
        getSQLConnectionPOC = cn
    End Function
    Public Function ComboDatabase(Optional ByVal strUSerID As String = "") As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("short_name", System.Type.GetType("System.String"))
        dt.Columns.Add("servername", System.Type.GetType("System.String"))
        dt.Columns.Add("database", System.Type.GetType("System.String"))

        dt.Rows.Add("ESH", "172.16.3.10", "Gemmasoft")
        dt.Rows.Add("TEST", "172.16.3.10", "GemmasoftTest")
        'dt.Rows.Add("CLA", "172.16.3.10", "ColomboDB")
        ' dt.Rows.Add("TEST", "172.16.3.10", "ColomboDBTest")
        Return dt

    End Function
    Public Function GetdefaultDatabase() As String
        Dim pDatabase As String = "ESH"

        Return pDatabase
    End Function


End Class
