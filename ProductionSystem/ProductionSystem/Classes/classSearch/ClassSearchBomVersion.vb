Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class ClassSearchBomVersion

    Public Function comboYarn(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_bom_version_pkg_get_combo_items"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SearchBomVersion(Optional ByVal StrItcd As String = "", Optional ByVal Int64ColId As Int64 = 0) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_search_bom_version_pkg_get_grid_data"
        comm.Parameters.AddWithValue("@itcd", StrItcd)
        comm.Parameters.AddWithValue("@color_id", Int64ColId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        comm.Connection.Close()
        Return dt
    End Function

    Public Function GetBOMColorWay() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_bom_form_pkg_combo_color_way"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

End Class
