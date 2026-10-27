Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classCuttingIN
    Dim oconfig As New clsConfig

    Public Structure CINHeader

        'strolls_d
        Dim dinno As String
        Dim dindt As Date
        Dim doctyp As String

    End Structure

    Public Function selectCuttingINRecord(Optional ByVal pDinNo As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUTTING_IN_PKG_select_cutting_in_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_dinno", pDinNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function selectDyedOutRecord(Optional ByVal pOutno As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUTTING_IN_PKG_select_dyed_out_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_outno", pOutno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function selectMtlWarehouseList(Optional ByVal pDinNo As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUTTING_IN_PKG_select_mtl_warehouse_list"
        comm.Parameters.Clear()
        'comm.Parameters.AddWithValue("@p_dinno", pDinNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function selectMtlSubInventoryList(Optional ByVal pMtlWareHouseId As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUTTING_IN_PKG_select_mtl_subinventory_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_warehouse_id", pMtlWareHouseId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function selectdefaultSubInventoryId(Optional ByVal pMtlWareHouseId As Nullable(Of Int64) = Nothing) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUTTING_IN_PKG_select_default_mtl_subinventory_id"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_warehouse_id", pMtlWareHouseId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Dim pMtlSubInventoryId As Nullable(Of Int64) = Nothing
        If dt.Rows.Count > 0 Then
            pMtlSubInventoryId = dt.Rows(0)("mtl_subinventory_id")
        End If
        Return pMtlSubInventoryId
    End Function
    Public Function selectdefaultLocationId(Optional ByVal pMtlWareHouseId As Nullable(Of Int64) = Nothing) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUTTING_IN_PKG_select_default_mtl_location_id"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_warehouse_id", pMtlWareHouseId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Dim pMtlSubInventoryId As Nullable(Of Int64) = Nothing
        If dt.Rows.Count > 0 Then
            pMtlSubInventoryId = dt.Rows(0)("mtl_locations_id")
        End If
        Return pMtlSubInventoryId
    End Function
    Public Function selectMtlLocationList(Optional ByVal pMtlSubInventoryId As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CUTTING_IN_PKG_select_mtl_location_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_subinventory_id", pMtlSubInventoryId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function SaveCuttingIN(ByRef StrollsDHeader As CINHeader, ByVal DV_ADD As DataView, ByVal DV_UPD As DataView, ByVal DV_DEL As DataView, ByRef msgerr As String, ByVal Userinfo As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        'Add Detail----------

        i = 0
        comm.CommandText = "P_CUTTING_IN_PKG_update_cutting_in_record"

        For i = 0 To DV_ADD.Count - 1
            With DV_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_dinno", StrollsDHeader.dinno)
                comm.Parameters.AddWithValue("@p_dindt", StrollsDHeader.dindt)
                comm.Parameters.AddWithValue("@p_doctyp", StrollsDHeader.doctyp)
                comm.Parameters.AddWithValue("@p_roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@p_roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@p_roll_no_p", config.IsNull(.Item(i)("roll_no_p"), "").Trim)
                comm.Parameters.AddWithValue("@p_design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@p_gr", config.IsNull(.Item(i)("gr"), "").Trim)
                comm.Parameters.AddWithValue("@p_sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@p_sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@p_fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@p_Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@p_lot", config.IsNull(.Item(i)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@p_kg", config.IsNull(.Item(i)("kg"), 0))
                comm.Parameters.AddWithValue("@p_mts", config.IsNull(.Item(i)("mts"), 0))
                comm.Parameters.AddWithValue("@p_yds", config.IsNull(.Item(i)("yds"), 0))
                comm.Parameters.AddWithValue("@p_col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@p_custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@p_mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@p_mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@p_mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@p_rem_qc", .Item(i)("rem_qc"))
                comm.Parameters.AddWithValue("@p_dfno", .Item(i)("dfno")) 'save outno
                comm.Parameters.AddWithValue("@p_logempcd", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            StrollsDHeader.dinno = dt.Rows(0)("dinno") '.ToString
            StrollsDHeader.dindt = dt.Rows(0)("dindt") '.ToString

        Next


        comm.CommandText = "P_CUTTING_IN_PKG_update_cutting_in_record"
        For i = 0 To DV_UPD.Count - 1
            With DV_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_dinno", StrollsDHeader.dinno)
                comm.Parameters.AddWithValue("@p_dindt", StrollsDHeader.dindt)
                comm.Parameters.AddWithValue("@p_doctyp", StrollsDHeader.doctyp)
                comm.Parameters.AddWithValue("@p_roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@p_roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@p_roll_no_p", config.IsNull(.Item(i)("roll_no_p"), "").Trim)
                comm.Parameters.AddWithValue("@p_design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@p_gr", config.IsNull(.Item(i)("gr"), "").Trim)
                comm.Parameters.AddWithValue("@p_sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@p_sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@p_fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@p_Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@p_lot", config.IsNull(.Item(i)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@p_kg", config.IsNull(.Item(i)("kg"), 0))
                comm.Parameters.AddWithValue("@p_mts", config.IsNull(.Item(i)("mts"), 0))
                comm.Parameters.AddWithValue("@p_yds", config.IsNull(.Item(i)("yds"), 0))
                comm.Parameters.AddWithValue("@p_col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@p_custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@p_mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@p_mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@p_mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@p_rem_qc", .Item(i)("rem_qc"))
                comm.Parameters.AddWithValue("@p_dfno", .Item(i)("dfno")) 'save outno
                comm.Parameters.AddWithValue("@p_logempcd", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            StrollsDHeader.dinno = dt.Rows(0)("dinno") '.ToString
            StrollsDHeader.dindt = dt.Rows(0)("dindt") '.ToString

        Next

        comm.CommandText = "P_CUTTING_IN_PKG_delete_cutting_in_record"
        For i = 0 To DV_DEL.Count - 1
            With DV_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)

                comm.Parameters.AddWithValue("@p_logempcd", Userinfo.UserID)
            End With
            Dim da = New SqlDataAdapter(comm)
            Dim dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            StrollsDHeader.dinno = dt.Rows(0)("dinno").ToString
            StrollsDHeader.dindt = dt.Rows(0)("dindt").ToString

        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class
