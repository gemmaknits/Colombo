
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchCustomers
    Public Function GetGridCustomers(Optional ByVal strPOno As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strsuppcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_CUSTOMERS_SEARCH_PKG_get_customers"

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
