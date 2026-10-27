Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classInvoiceExportSearch
    Public Function InvExpSearchLoad(Optional ByVal lngInvID As Long = 0, Optional ByVal strInvNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal strDesign_No As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_inv_export_search_select"
        comm.Parameters.AddWithValue("@invid", lngInvID)
        comm.Parameters.AddWithValue("@invno", strInvNo)
        comm.Parameters.AddWithValue("@invdtfr", strDateFr)
        comm.Parameters.AddWithValue("@invdtto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@Design_No", strDesign_No)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
