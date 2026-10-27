Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchDFOrder
    Public Function SearchDFOrder(Optional ByVal strDFNo As String = "",
       Optional ByVal strDateFr As String = "",
       Optional ByVal strDateTo As String = "",
       Optional ByVal strSoNo As String = "",
       Optional ByVal strCustCD As String = "",
       Optional ByVal strDHCod As String = "",
       Optional ByVal strDesignNo As String = "",
       Optional ByVal strEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_dforder_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@dhcod", strDHCod)
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@empcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
End Class
