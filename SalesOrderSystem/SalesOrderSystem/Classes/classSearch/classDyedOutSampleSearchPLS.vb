Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classDyedOutSampleSearchPLS
    Public Function SearchPLS(Optional ByVal StrFilter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SAMPLE_STOCK_OUT_SEARCH_PLS_PKG_select_pls"
        comm.Parameters.AddWithValue("@filter", StrFilter)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class
