Public Class classConnection
    Public Shared ServerName As String = "172.16.3.10"    ' "ESCH-SVR-DB", "172.16.3.10"
    Public Shared Database As String = "ColomboDB"
    Public UserName As String = "sa"
    Public Password As String = "sql@min"

    Public ReadOnly Property Connection As String
        Get
            Return "Data Source=" & ServerName & ";Initial Catalog=" & Database & ";User ID=" & UserName & ";pwd=" & Password
        End Get
    End Property

    Public Function getSQLConnection() As System.Data.SqlClient.SqlConnection
        Dim cn As New System.Data.SqlClient.SqlConnection
        cn.ConnectionString = Me.Connection
        getSQLConnection = cn
    End Function
    Public Function ComboDatabase(Optional ByVal strUSerID As String = "") As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("short_name", System.Type.GetType("System.String"))
        dt.Columns.Add("servername", System.Type.GetType("System.String"))
        dt.Columns.Add("database", System.Type.GetType("System.String"))

        ' dt.Rows.Add("ESH", "172.16.3.10", "gemmasoft")
        ' dt.Rows.Add("TEST", "172.16.3.10", "gemmasoftTest")
        dt.Rows.Add("CLA", "172.16.3.10", "ColomboDB")
        dt.Rows.Add("TEST", "172.16.3.10", "ColomboDBTest")
        Return dt

    End Function

    Public Function GetdefaultDatabase() As String
        Dim pDatabase As String = "CLA"

        Return pDatabase
    End Function
End Class
