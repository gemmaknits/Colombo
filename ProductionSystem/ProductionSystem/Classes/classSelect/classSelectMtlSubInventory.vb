Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classSelectMtlSubInventory
    Public Function SearchSubInventory(Optional ByVal pMtlWareHouseID As String = "", Optional ByVal StrFilter As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SELECT_MTL_SUBINVENTORY_PKG_select"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", pMtlWareHouseID)
        comm.Parameters.AddWithValue("@filter", StrFilter)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
End Class

