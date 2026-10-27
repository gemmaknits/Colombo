Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classRoutingMaster
    Public Structure mfg_routing_header
        Dim mfg_routing_header_id As Nullable(Of Int32)
        Dim routing_code As String
        Dim routing_name As String
        Dim routing_status As String
        Dim created_by As String
        Dim creation_date As Nullable(Of DateTime)
        Dim last_modified_by As String
        Dim last_modified_date As Nullable(Of DateTime)
        Dim message As String
        Dim oConfig As clsConfig
    End Structure

    Public Function Getoperations(Optional ByVal Intmfg_operations_id As Nullable(Of Integer) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_operations_select_mfg_operations"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mfg_operations_id", Intmfg_operations_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        Return dt
    End Function
    Public Function selectRoutingHeaderRecord(Optional ByVal pMfgRoutingHeaderId As Nullable(Of Integer) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MFG_ROUTING_MASTER_FORM_PKG_select_mfg_routing_header_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mfg_routing_header_id", pMfgRoutingHeaderId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        Return dt
    End Function
    Public Function selectRoutingLinesList(Optional ByVal pMfgRoutingHeaderId As Nullable(Of Integer) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MFG_ROUTING_MASTER_FORM_PKG_select_mfg_routing_lines_list"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mfg_routing_header_id", pMfgRoutingHeaderId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        Return dt
    End Function
    Public Function GetRoutingMaster(Optional ByVal Intmfg_routing_header_id As Nullable(Of Integer) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_routing_master_select_mfg_routing"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mfg_routing_header_id", Intmfg_routing_header_id)
        comm.Parameters.AddWithValue("@mfg_routing_lines_id", DBNull.Value)
        comm.Parameters.AddWithValue("@routing_code", DBNull.Value)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        da.Fill(dt)
            conn.Close()  'Sitthana 20190325

        Return dt
    End Function

    Public Function Savedata(ByRef mfg_routing_header As classRoutingMaster.mfg_routing_header, ByRef dv_data_add As DataView, ByRef dv_data_upd As DataView, ByRef dv_data_del As DataView, ByVal clsuser As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim classConnection As New classConnection

        Dim conn As New SqlConnection(classConnection.connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Clear()
        comm.CommandText = "p_mfg_routing_header_update"
        i = 0
        'For i = 0 To dv_data_add.Count - 1
        With mfg_routing_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@mfg_routing_header_id", .mfg_routing_header_id)
            comm.Parameters.AddWithValue("@routing_code", .routing_code)
            comm.Parameters.AddWithValue("@routing_name", .routing_name)
            comm.Parameters.AddWithValue("@routing_status", .routing_status)
            comm.Parameters.AddWithValue("@created_by", .created_by)
            comm.Parameters.AddWithValue("@creation_date", .creation_date)
            comm.Parameters.AddWithValue("@last_modified_by", .last_modified_by)
            comm.Parameters.AddWithValue("@last_modified_date", .last_modified_date)
            comm.Parameters.AddWithValue("@log_empcd", clsuser.UserID)
        End With
        'Next
        Dim dac_int = New SqlDataAdapter(comm)
        Dim dtc_int = New DataTable
        Try
            dac_int.Fill(dtc_int)
        Catch ex As Exception
            mfg_routing_header.message = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try
        'PLGNo = dt.Rows(0)("packno").ToString.Trim
        mfg_routing_header.mfg_routing_header_id = dtc_int.Rows(0)("mfg_routing_header_id").ToString.Trim

        'dt.Rows(0)("packno").ToString.Trim()

        comm.CommandText = "p_mfg_routing_lines_insert"
        i = 0
        For i = 0 To dv_data_add.Count - 1
            With dv_data_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_routing_lines_id", .Item(i)("mfg_routing_lines_id"))
                comm.Parameters.AddWithValue("@mfg_routing_header_id", mfg_routing_header.mfg_routing_header_id)
                comm.Parameters.AddWithValue("@mfg_operation_id", .Item(i)("mfg_operation_id"))
                comm.Parameters.AddWithValue("@step_number", .Item(i)("step_number"))

            End With

            Dim darl_int = New SqlDataAdapter(comm)
            Dim dtrl_int = New DataTable
            Try
                darl_int.Fill(dtrl_int)
            Catch ex As Exception
                mfg_routing_header.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try

        Next

        comm.CommandText = "p_mfg_routing_lines_update"
        i = 0
        For i = 0 To dv_data_upd.Count - 1
            With dv_data_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_routing_lines_id", .Item(i)("mfg_routing_lines_id"))
                comm.Parameters.AddWithValue("@mfg_routing_header_id", .Item(i)("mfg_routing_header_id"))
                comm.Parameters.AddWithValue("@mfg_operation_id", .Item(i)("mfg_operation_id"))
                comm.Parameters.AddWithValue("@step_number", .Item(i)("step_number"))

            End With

            Dim darl_upd = New SqlDataAdapter(comm)
            Dim dtrl_upd = New DataTable
            Try
                darl_upd.Fill(dtrl_upd)
            Catch ex As Exception
                mfg_routing_header.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try

        Next

        comm.CommandText = "p_mfg_routing_lines_delete"
        i = 0
        For i = 0 To dv_data_del.Count - 1
            With dv_data_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_routing_lines_id", .Item(i)("mfg_routing_lines_id"))
                comm.Parameters.AddWithValue("@mfg_routing_header_id", .Item(i)("mfg_routing_header_id"))
                comm.Parameters.AddWithValue("@mfg_operation_id", .Item(i)("mfg_operation_id"))
                comm.Parameters.AddWithValue("@step_number", .Item(i)("step_number"))

            End With

            Dim darl_del = New SqlDataAdapter(comm)
            Dim dtrl_del = New DataTable
            Try
                darl_del.Fill(dtrl_del)
            Catch ex As Exception
                mfg_routing_header.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try

        Next

        tran.Commit()
        conn.Close()
        Return True
    End Function
End Class

