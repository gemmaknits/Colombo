Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classJobOrderYarnSelectProductionLine

    Public Function SearchItems(Optional ByVal _itnaturecd As String = "", Optional ByVal _Kono As String = "", Optional ByVal _itcd As String = "", Optional ByVal StrFilter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_JOBORDER_YARN_SEARCH_PRODUCTION_LINE_PKG_select_mfg_production_order_lines"
        comm.Parameters.AddWithValue("@itnaturecd", _itnaturecd)
        comm.Parameters.AddWithValue("@kono", _Kono)
        comm.Parameters.AddWithValue("@itcd", _itcd)
        comm.Parameters.AddWithValue("@filter", StrFilter)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function

End Class
