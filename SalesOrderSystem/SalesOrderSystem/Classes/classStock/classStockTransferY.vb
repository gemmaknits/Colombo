Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classStockTransferY
    Public Structure yarn_location_log
        Dim id_yarn_location As Nullable(Of Int64)
        Dim logno As String
        Dim logdate As String
        Dim logtime As String
        Dim yarn_in_no As String
        Dim itcd As String
        Dim boxno As String
        Dim grade As String
        Dim kg_gr As Decimal
        Dim kg_nt As Decimal
        Dim location_fr As String
        Dim location_to As String
        Dim log_empcd As String
        Dim actual_move_date As String
        Dim receive_date As String
        Dim spools As String
        Dim mtl_warehouse_id_ft As Nullable(Of Int64)
        Dim mtl_warehouse_id_to As Nullable(Of Int64)
        Dim mtl_subinventory_id_fr As Nullable(Of Int64)
        Dim mtl_subinventory_id_to As Nullable(Of Int64)
        Dim mtl_locations_id_fr As Nullable(Of Int64)
        Dim mtl_locations_id_to As Nullable(Of Int64)
        Dim location_remarks As String
    End Structure

    Public Function getYarnLocationLog(ByVal logno As String) As DataTable
        'Dim conn As New SqlConnection((New classConnection).ConnectionString) 'Sitthana 26/01/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_TRANSFER_PKG_select"
        comm.Parameters.AddWithValue("@logno", logno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetYarnInDet(ByVal StrBoxno As String) As DataTable
        'Dim conn As New SqlConnection((New classConnection).ConnectionString) 'Sitthana 26/01/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        'comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_YARN_TRANSFER_PKG_get_yarn_in_det"
        comm.Parameters.AddWithValue("@boxno", StrBoxno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnLocationBarcodeSave(ByRef yarn_location_log As classStockTransferY.yarn_location_log,
                                            ByVal dtYarnLocationLog As DataTable,
                                            ByVal log_empcd As String,
                                            ByRef msgerr As String
                                           ) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim i As Integer = 0
        Dim da As New SqlDataAdapter()
        Dim dt As New DataTable
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "P_YARN_TRANSFER_PKG_update"
        For Each dr As DataRow In dtYarnLocationLog.Rows
            If dr.RowState <> DataRowState.Deleted Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@logno", yarn_location_log.logno)
                comm.Parameters.AddWithValue("@logdate", yarn_location_log.logdate)
                comm.Parameters.AddWithValue("@logtime", yarn_location_log.logtime)
                comm.Parameters.AddWithValue("@actual_move_date", yarn_location_log.actual_move_date)
                comm.Parameters.AddWithValue("@receive_date", yarn_location_log.receive_date)
                comm.Parameters.AddWithValue("@yarn_in_no", dr("yarn_in_no"))
                comm.Parameters.AddWithValue("@itcd", dr("itcd"))
                comm.Parameters.AddWithValue("@boxno", dr("boxno"))
                comm.Parameters.AddWithValue("@kg_gr", dr("kg_gr"))
                comm.Parameters.AddWithValue("@kg_nt", dr("kg_nt"))
                comm.Parameters.AddWithValue("@spools", dr("spools"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id_fr", dr("mtl_warehouse_id_fr"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id_fr", dr("mtl_subinventory_id_fr"))
                comm.Parameters.AddWithValue("@mtl_locations_id_fr", dr("mtl_locations_id_fr"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id_to", dr("mtl_warehouse_id_to"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id_to", dr("mtl_subinventory_id_to"))
                comm.Parameters.AddWithValue("@mtl_locations_id_to", dr("mtl_locations_id_to"))
                comm.Parameters.AddWithValue("@location_fr", dr("location_fr"))
                comm.Parameters.AddWithValue("@location_to", dr("location_to"))
                comm.Parameters.AddWithValue("@grade_fr", dr("grade_fr"))
                comm.Parameters.AddWithValue("@grade_to", dr("grade_to"))
                comm.Parameters.AddWithValue("@grade_our_fr", dr("grade_our_fr"))
                comm.Parameters.AddWithValue("@grade_our_to", dr("grade_our_to"))
                comm.Parameters.AddWithValue("@location_remarks", yarn_location_log.location_remarks)
                comm.Parameters.AddWithValue("@log_empcd", log_empcd)
                da = New SqlDataAdapter(comm)
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
                yarn_location_log.logno = dt.Rows(0)("logno").ToString()
            End If
        Next

        comm.CommandText = "P_YARN_TRANSFER_PKG_delete"
        For Each dr As DataRow In dtYarnLocationLog.Rows
            If dr.RowState = DataRowState.Deleted Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_yarn_location_log_delete", dr("id_yarn_location"))
                Try
                    da.Fill(dt)
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try
            End If
        Next

        tran.Commit()
        comm.Dispose()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Dispose()
        Return True
    End Function

End Class

