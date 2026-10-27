
Public Class classConnection
    Public Shared servername As String = "172.16.3.10"    ' "ESCH-SVR-DB", "172.16.3.10" 
    Public Shared database As String = "Gemmasoft"
    Public Userid As String = "sa"
    Public Password As String = "sql@min"

    Dim connstr As String = "Data Source=" & servername & ";Initial Catalog=" & database & ";User ID=" & Userid & ";pwd=" & Password

    Public Function connection() As String 'For Connect
        Dim connStr As String = "Data Source=" & servername & ";Initial Catalog=" & database & ";User ID=" & Userid & ";pwd=" & Password

        Return connStr
    End Function
    Public Function getSQLConnection() As System.Data.SqlClient.SqlConnection
        Dim cn As New System.Data.SqlClient.SqlConnection
        cn.ConnectionString = connstr
        getSQLConnection = cn
    End Function
    Public Function ComboDatabase(Optional ByVal strUSerID As String = "") As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("short_name", System.Type.GetType("System.String"))
        dt.Columns.Add("servername", System.Type.GetType("System.String"))
        dt.Columns.Add("database", System.Type.GetType("System.String"))

        dt.Rows.Add("ESH", "172.16.3.10", "Gemmasoft")
        dt.Rows.Add("TEST", "172.16.3.10", "GemmasoftTest")
        ' dt.Rows.Add("CLA", "172.16.3.10", "ColomboDB")
        ' dt.Rows.Add("TEST", "172.16.3.10", "ColomboDBTest")
        Return dt

    End Function

    Public Function GetdefaultDatabase() As String
        Dim pDatabase As String = "ESH"

        Return pDatabase
    End Function
End Class


