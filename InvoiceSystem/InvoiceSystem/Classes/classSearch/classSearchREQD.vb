Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchREQD

    Public Function SearchOutReqNo(Optional ByVal strStockType As String = "A", Optional ByVal strReqNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal strOutReqtyp As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_req_d_select_outreqno_search"
        comm.Parameters.AddWithValue("@stock_type", strStockType.Trim)
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@outreqtyp", strOutReqtyp)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

End Class