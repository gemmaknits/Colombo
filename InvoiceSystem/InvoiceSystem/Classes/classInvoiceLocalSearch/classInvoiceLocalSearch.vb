Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classInvoiceLocalSearch
    Dim oConfig As New clsConfig

    Public Function selectCustomerList() As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_INVOICE_LOCAL_SEARCH_FORM_PKG_select_customers_list"
        comm.Parameters.Clear()

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function selectInvLocalRecord(Optional ByVal lngInvID As Long = 0, Optional ByVal strInvNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_INVOICE_LOCAL_SEARCH_FORM_PKG_select_inv_local_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@invid", lngInvID)
        comm.Parameters.AddWithValue("@invno", strInvNo)
        comm.Parameters.AddWithValue("@invdtfr", strDateFr)
        comm.Parameters.AddWithValue("@invdtto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
