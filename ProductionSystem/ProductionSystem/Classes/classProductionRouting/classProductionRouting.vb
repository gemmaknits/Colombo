Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Structure mfg_production_steps
    Dim mfg_production_steps_id As Nullable(Of Integer)
    Dim routing_id As Nullable(Of Integer)
    Dim operation_id As String
    Dim step_number As String
    Dim plan_start_date As Nullable(Of Date)
    Dim plan_end_date As Nullable(Of Date)
    Dim plan_step_qty As Nullable(Of Decimal)
    Dim actual_start_date As Nullable(Of Date)
    Dim actual_end_date As Nullable(Of Date)
    Dim actual_step_qty As Nullable(Of Decimal)
    Dim mcno As String
    Dim stroperator As String
    Dim work_shift As String
    Dim step_status As String
    Dim step_remarks As String

    Dim created_by As String
    Dim creation_date As Nullable(Of Date)
    Dim last_modified_by As String
    Dim last_modified_date As Nullable(Of Date)
    Dim production_order_no As String

    Dim message As String



End Structure



Public Structure mfg_routing_hearder
    Dim mfg_routing_header_id As Nullable(Of Int32)
    'Dim routing_id As Nullable(Of Long)
    'Dim operation_id As Nullable(Of Long)
    Dim routing_code As String
    Dim routing_name As String
    Dim routing_status As String
    Dim created_by As String
    Dim creation_date As Nullable(Of DateTime)
    Dim last_modified_by As String
    Dim last_modified_date As Nullable(Of DateTime)
    Dim message As String

End Structure

Public Class classProductionRouting
    Public Function Combomfgproductionstep(ByVal strproduction_order_no As String, strUserId As String) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_mfg_production_step"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@production_order_no", strproduction_order_no)
        comm.Parameters.AddWithValue("@logempcd", strUserId)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function Validate_KoNo(Optional ByVal Strkono As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_ko_manual_select_ko_validate"

        comm.Parameters.AddWithValue("@kono", Strkono)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function Validate_mfg_production_steps_id(Intmfg_production_steps_id As Nullable(Of Int32), Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_mfg_production_routing_select_step_id_validate"

        comm.Parameters.AddWithValue("@mfg_production_steps_id", Intmfg_production_steps_id)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function GetRoutingMaster(Optional ByVal Intmfg_routing_header_id As Nullable(Of Integer) = Nothing, Optional ByVal Intmfg_routing_lines_id As Nullable(Of Integer) = Nothing, Optional ByVal Strrouting_code As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_routing_select_mfg_routing"
        comm.Parameters.AddWithValue("@mfg_routing_header_id", Intmfg_routing_header_id)
        comm.Parameters.AddWithValue("@mfg_routing_lines_id", Intmfg_routing_lines_id)
        comm.Parameters.AddWithValue("@routing_code", Strrouting_code)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            'Message = ex.Message
        End Try

        Return dt
    End Function

    Public Function GetProductionRounting(Optional ByVal Intmfg_production_steps_id As Nullable(Of Integer) = Nothing, Optional ByVal Strproduction_order_no As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_steps_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mfg_production_steps_id", Intmfg_production_steps_id)
        comm.Parameters.AddWithValue("@production_order_no", Strproduction_order_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
        End Try
        Return dt
    End Function

    Public Function GetProductionRountingWarp(Optional ByVal Intmfg_production_steps_id As Nullable(Of Integer) = Nothing, Optional ByVal Strproduction_order_no As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_steps_warp_select"
        comm.Parameters.AddWithValue("@mfg_production_steps_id", Intmfg_production_steps_id)
        comm.Parameters.AddWithValue("@production_order_no", Strproduction_order_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
        End Try
        Return dt
    End Function
    Public Function SavaData(ByRef mfg_production_steps As mfg_production_steps, ByVal dv_add As DataView, ByVal dv_upd As DataView, ByVal dv_del As DataView, ByVal clsuser As classUserInfo) As Boolean
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

        comm.CommandText = "p_mfg_production_steps_insert"
        i = 0
        For i = 0 To dv_add.Count - 1
            With dv_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_production_steps_id", .Item(i)("mfg_production_steps_id"))
                comm.Parameters.AddWithValue("@routing_id", .Item(i)("routing_id"))
                comm.Parameters.AddWithValue("@operation_id", .Item(i)("operation_id"))
                comm.Parameters.AddWithValue("@plan_start_date", .Item(i)("plan_start_date"))
                comm.Parameters.AddWithValue("@plan_end_date", .Item(i)("plan_end_date"))
                comm.Parameters.AddWithValue("@plan_step_qty", mfg_production_steps.plan_step_qty)
                comm.Parameters.AddWithValue("@actual_start_date", .Item(i)("actual_start_date"))
                comm.Parameters.AddWithValue("@actual_end_date", .Item(i)("actual_end_date"))
                comm.Parameters.AddWithValue("@actual_step_qty", .Item(i)("actual_step_qty"))
                comm.Parameters.AddWithValue("@step_status", .Item(i)("step_status"))
                comm.Parameters.AddWithValue("@created_by", mfg_production_steps.created_by)
                comm.Parameters.AddWithValue("@creation_date", mfg_production_steps.creation_date)
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
                comm.Parameters.AddWithValue("@production_order_no", mfg_production_steps.production_order_no)
                comm.Parameters.AddWithValue("@mcno", .Item(i)("mcno")) '.Value.ToString())
                comm.Parameters.AddWithValue("@work_shift", .Item(i)("work_shift"))
                comm.Parameters.AddWithValue("@step_number", .Item(i)("step_number"))
                comm.Parameters.AddWithValue("@step_remarks", .Item(i)("step_remarks"))
                comm.Parameters.AddWithValue("@operator", .Item(i)("operator"))

            End With

            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                mfg_production_steps.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next


        comm.CommandText = "p_mfg_production_steps_update"
        i = 0
        For i = 0 To dv_upd.Count - 1
            With dv_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_production_steps_id", .Item(i)("mfg_production_steps_id"))
                comm.Parameters.AddWithValue("@routing_id", .Item(i)("routing_id"))
                comm.Parameters.AddWithValue("@operation_id", .Item(i)("operation_id"))
                comm.Parameters.AddWithValue("@plan_start_date", .Item(i)("plan_start_date"))
                comm.Parameters.AddWithValue("@plan_end_date", .Item(i)("plan_end_date"))
                comm.Parameters.AddWithValue("@plan_step_qty", .Item(i)("plan_step_qty"))
                comm.Parameters.AddWithValue("@actual_start_date", .Item(i)("actual_start_date"))
                comm.Parameters.AddWithValue("@actual_end_date", .Item(i)("actual_end_date"))
                comm.Parameters.AddWithValue("@actual_step_qty", .Item(i)("actual_step_qty"))
                comm.Parameters.AddWithValue("@step_status", .Item(i)("step_status"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@last_modified_by", mfg_production_steps.last_modified_by)
                comm.Parameters.AddWithValue("@last_modified_date", mfg_production_steps.last_modified_date)
                comm.Parameters.AddWithValue("@production_order_no", mfg_production_steps.production_order_no)
                comm.Parameters.AddWithValue("@mcno", .Item(i)("mcno"))
                comm.Parameters.AddWithValue("@work_shift", .Item(i)("work_shift"))
                comm.Parameters.AddWithValue("@step_number", .Item(i)("step_number"))
                comm.Parameters.AddWithValue("@step_remarks", .Item(i)("step_remarks"))
                comm.Parameters.AddWithValue("@operator", .Item(i)("operator"))

            End With

            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                mfg_production_steps.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next

        comm.CommandText = "p_mfg_production_steps_delete"
        i = 0
        For i = 0 To dv_del.Count - 1
            With dv_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_production_steps_id", .Item(i)("mfg_production_steps_id"))
                comm.Parameters.AddWithValue("@routing_id", .Item(i)("routing_id"))
                comm.Parameters.AddWithValue("@operation_id", .Item(i)("operation_id"))
                comm.Parameters.AddWithValue("@plan_start_date", .Item(i)("plan_start_date"))
                comm.Parameters.AddWithValue("@plan_end_date", .Item(i)("plan_end_date"))
                comm.Parameters.AddWithValue("@plan_step_qty", .Item(i)("plan_step_qty"))
                comm.Parameters.AddWithValue("@actual_start_date", .Item(i)("actual_start_date"))
                comm.Parameters.AddWithValue("@actual_end_date", .Item(i)("actual_end_date"))
                comm.Parameters.AddWithValue("@actual_step_qty", .Item(i)("actual_step_qty"))
                comm.Parameters.AddWithValue("@step_status", .Item(i)("step_status"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
                comm.Parameters.AddWithValue("@production_order_no", mfg_production_steps.production_order_no)
                comm.Parameters.AddWithValue("@mcno", .Item(i)("mcno"))
                comm.Parameters.AddWithValue("@work_shift", .Item(i)("work_shift"))
                comm.Parameters.AddWithValue("@step_number", .Item(i)("step_number"))
                comm.Parameters.AddWithValue("@step_remarks", .Item(i)("step_remarks"))
                comm.Parameters.AddWithValue("@operator", .Item(i)("operator"))

            End With

            Dim dac_del = New SqlDataAdapter(comm)
            Dim dtc_del = New DataTable
            Try
                dac_del.Fill(dtc_del)
            Catch ex As Exception
                mfg_production_steps.message = ex.Message
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

