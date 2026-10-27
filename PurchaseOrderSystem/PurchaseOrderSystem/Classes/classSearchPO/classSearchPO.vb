Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchPO
    Public Function SelectJobRecord(Optional ByVal pSuppcd As String = "", Optional ByVal pDateFr As Date = Nothing, Optional ByVal pDateTo As Date = Nothing, Optional ByVal pFilter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SEARCH_PO_FORM_PKG_select_job_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_suppcd", pSuppcd)
        comm.Parameters.AddWithValue("@p_datefr", pDateFr)
        comm.Parameters.AddWithValue("@p_dateto", pDateTo)
        comm.Parameters.AddWithValue("@p_filter", pFilter)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
    Public Function SelectSupplierList() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SEARH_PO_FORM_PKG_select_suppliers_list"
        comm.Parameters.Clear()
        ' comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
