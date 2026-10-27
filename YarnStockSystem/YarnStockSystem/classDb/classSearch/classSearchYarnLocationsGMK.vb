Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSearchYarnLocationsGMK
    Public Function GetYarnLocationsGMK(Optional ByVal StrFilter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SEARCH_YARN_LOCATIONS_GMK_PKG_select"
        comm.Parameters.AddWithValue("@filter", StrFilter)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class
