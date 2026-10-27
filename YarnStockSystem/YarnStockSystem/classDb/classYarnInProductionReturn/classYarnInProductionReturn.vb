Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classYarnInProductionReturn
    Public Function Combomtlwarehouse() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_production_return_pkg_combo_mtl_warehouse"
        ' comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function ComboMtlsubinventory(Optional ByVal INt64mtl_warehouse_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_production_return_pkg_combo_mtl_subinventory"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function Combomtllocations(Optional ByVal strUSerID As String = "", Optional ByVal INt64mtl_warehouse_id As Int64 = Nothing, Optional ByVal Int64mtl_subinventory_id As Int64 = Nothing) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_production_return_pkg_combo_mtl_locations"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetYarnOutDet(ByVal StrOutno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_production_return_pkg_get_yarn_out_det"
        comm.Parameters.AddWithValue("@outno", StrOutno)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function

End Class
