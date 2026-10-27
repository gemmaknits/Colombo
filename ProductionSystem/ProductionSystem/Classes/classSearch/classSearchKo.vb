Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchKo
    Public Function SearchKo(Optional ByVal strkono As String = "",
                             Optional ByVal strDateFr As String = "",
                             Optional ByVal strDateTo As String = "",
                             Optional ByVal strsuppcd As String = "",
                             Optional ByVal StrDesignNo As String = "",
                             Optional ByVal pProductionOrderTypeId As Nullable(Of Int64) = 0) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_SEARCH_KO_PKG_select_ko"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@kono", strkono)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@suppcd", strsuppcd)
        comm.Parameters.AddWithValue("@design_no", StrDesignNo)
        comm.Parameters.AddWithValue("@production_order_type_id", pProductionOrderTypeId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function selectSupplierList() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SEARCH_KO_PKG_select_suppliers_list"
        comm.Parameters.Clear()
        ' comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function selectProductionTypeLookUpList() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SEARCH_KO_PKG_select_production_type_lookup_list"
        comm.Parameters.Clear()
        ' comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
