Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Structure mfg_production_lots
    Dim mfg_production_lots_id As Nullable(Of Int32)
    Dim system_lot_number As String
    Dim custom_lot_number As String
    Dim inventory_item_code As String
    Dim lot_delivered_to_inventory As String
    Dim production_order_id As Nullable(Of Int64)
    Dim production_order_no As String
    Dim primary_quantity As Nullable(Of Integer)
    Dim secondary_quantity As Nullable(Of Integer)
    Dim created_by As String
    Dim creation_date As Nullable(Of Date)
    Dim last_modified_by As String
    Dim last_modified_date As Nullable(Of Date)
    Dim mfg_production_steps_id As Nullable(Of Int32)
    Dim lot_grade As String
    Dim qc_remarks As String
    Dim mtl_warehouse_id As Nullable(Of Int64)
    Dim mtl_subinventory_id As Nullable(Of Int64)
    Dim mtl_locations_id As Nullable(Of Int64)
    Dim steam_condition As String
    Dim steam_date As Nullable(Of DateTime)
    Dim steam_time As Nullable(Of TimeSpan)
    Dim operator_lot_number As String

    Dim bar_weight As Nullable(Of Integer)
    Dim gwth As Nullable(Of Integer)
    Dim lot As String
    Dim grade_bdt As String
    Dim grade_adt As String
    Dim cliped As Boolean
    Dim shift As String
    Dim ProdFinishDate As Nullable(Of DateTime)
    Dim ProdFinishTime As Nullable(Of TimeSpan)
    Dim dyeing_pass As Boolean
    Dim adjust_loss_kg As Nullable(Of Integer)
    Dim qc_loss_kg As Nullable(Of Integer)
    Dim dyed_loss_kg As Nullable(Of Integer)
    Dim lab_loss_kg As Nullable(Of Integer)
    Dim defect_loss_kg As Nullable(Of Integer)

    Dim beam_total_weight As Nullable(Of Integer)

    Dim message As String

End Structure

Public Structure Defect_roll_Header
    Dim h01_id_defect_roll As Int64
    Dim h02_roll_no As String
    Dim h03_defect_code As String
    Dim h04_defect_details As String
    Dim h05_stock_code As String

End Structure
Public Class classProductionLots
    'Public Function ValidatePeriodClosed(Optional ByVal TranDate As String = "") As DataTable
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure

    '    comm.CommandText = "fn_CheckStockPeriodStatus"

    '    comm.Parameters.AddWithValue("@p_stock_code", "")
    '    comm.Parameters.AddWithValue("@p_tran_date", TranDate)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    conn.Close()  'Sitthana 20190325
    '    Return (dt)
    'End Function
    Public Function Validate_RollNo(Optional ByVal StrRollno As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_ko_manual_select_roll_no_validate"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@Roll_no", StrRollno)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function Validate_SetNo(Optional ByVal StrSetNo As String = "", Optional ByVal StrEmpcd As String = "", Optional ByRef Strmessage As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_mfg_production_lots_validate_set_no"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@setno", StrSetNo)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Strmessage = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return (dt)
            Exit Function
        End Try


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function Validate_Greige_IN(Optional ByVal StrRollno As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_mfg_production_lots_select_greige_validate"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@Roll_no", StrRollno)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function Validate_Yarn_IN(Optional ByVal StrBoxno As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_mfg_production_lots_select_yarn_validate"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@boxno", StrBoxno)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function Validate_Steps_id(Optional ByVal Intmfg_production_steps_id As Nullable(Of Integer) = Nothing, Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_mfg_production_steps_validate_id"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mfg_production_steps_id", Intmfg_production_steps_id)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function Validate_Routing_Code(Optional ByVal Strrouting_code As String = Nothing, Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_mfg_production_steps_validate_id"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mfg_production_steps_id", Strrouting_code)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function

    Public Function GetProductionLots(Optional ByVal Strsystem_lot_number As String = Nothing, Optional ByVal Intmfg_production_steps_id As Nullable(Of Integer) = Nothing, Optional ByVal Strproduction_order_no As String = Nothing, Optional ByVal Strlogempcd As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_lots_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@system_lot_number", Strsystem_lot_number)
        comm.Parameters.AddWithValue("@mfg_production_steps_id", Intmfg_production_steps_id)
        comm.Parameters.AddWithValue("@production_order_no", Strproduction_order_no)
        comm.Parameters.AddWithValue("@logempcd", Strlogempcd)
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

    Public Function GetProductionLotsWarp(Optional ByVal Strsystem_lot_number As String = Nothing, Optional ByVal Intmfg_production_steps_id As Nullable(Of Integer) = Nothing, Optional ByVal Strproduction_order_no As String = Nothing, Optional ByVal Strlogempcd As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_lots_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@system_lot_number", Strsystem_lot_number)
        comm.Parameters.AddWithValue("@mfg_production_steps_id", Intmfg_production_steps_id)
        comm.Parameters.AddWithValue("@production_order_no", Strproduction_order_no)
        comm.Parameters.AddWithValue("@logempcd", Strlogempcd)
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

    Public Function GetProductionLotsBySystemRolls(Optional ByVal Intmfg_production_lots_id As Nullable(Of Integer) = Nothing, Optional ByVal Strsystem_lot_number As String = Nothing, Optional ByVal Intmfg_production_steps_id As Nullable(Of Integer) = Nothing, Optional ByVal Strproduction_order_no As String = Nothing, Optional ByVal Strlogempcd As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_lots_select_system_lot_number"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("mfg_production_lots_id", Intmfg_production_lots_id)
        comm.Parameters.AddWithValue("@system_lot_number", Strsystem_lot_number)
        comm.Parameters.AddWithValue("@mfg_production_steps_id", Intmfg_production_steps_id)
        comm.Parameters.AddWithValue("@production_order_no", Strproduction_order_no)
        comm.Parameters.AddWithValue("@logempcd", Strlogempcd)
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

    Public Function GetLotsSteps(Optional ByVal Strsystem_lot_number As String = Nothing, Optional ByVal strProduction_order_no As String = Nothing, Optional ByVal Intmfg_production_lots_id As String = Nothing, Optional ByVal strEmpCD As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_lots_select_steps"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@roll_no", strProduction_order_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)

    End Function
    'Public Function ValidateProductionLineID(ByVal KoNo As String, ByVal MfgProductionOrderLines As Int64) As Boolean
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.CommandText = "P_KO_PKG_validate_mfg_production_order_lines_id"
    '    comm.Parameters.AddWithValue("@kono", KoNo)
    '    comm.Parameters.AddWithValue("@mfg_production_order_lines_id", MfgProductionOrderLines)
    '    comm.Parameters.Add("@pvalidate_line", SqlDbType.Bit)
    '    comm.Parameters("@pvalidate_line").Direction = ParameterDirection.Output
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    conn.Close()  'Sitthana 20190325

    '    Return comm.Parameters("@pvalidate_line").Value
    'End Function

    Public Function GenDataLots(ByRef mfg_production_lots As mfg_production_lots, ByVal grdDataLots As DataTable, ByVal set_per_lot As Integer, ByVal dv_add As DataView, ByVal dv_upd As DataView, ByVal dv_del As DataView, ByVal clsuser As classUserInfo) As DataTable
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
        comm.CommandText = "p_gen_lots"
        comm.Parameters.Clear()
        With mfg_production_lots
            comm.Parameters.AddWithValue("@inventory_item_code", mfg_production_lots.inventory_item_code)
            comm.Parameters.AddWithValue("@production_order_no", mfg_production_lots.production_order_no)
            comm.Parameters.AddWithValue("@mfg_production_steps_id", mfg_production_lots.mfg_production_steps_id)
            comm.Parameters.AddWithValue("@set_per_lot", set_per_lot)
        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            mfg_production_lots.message = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return (dt)
        End Try


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function



    Public Function SavaData(ByRef mfg_production_lots As mfg_production_lots, ByRef Defect_Roll_Header As Defect_roll_Header, ByVal dv_add As DataView, ByVal dv_upd As DataView, ByVal dv_del As DataView, ByVal dv_yarn_in_add As DataView, ByVal dv_yarn_in_upd As DataView, ByVal dv_yarn_in_del As DataView, ByVal dv_dtDefect_add As DataView, ByVal dv_dtDefect_upd As DataView, ByVal dv_dtDefect_del As DataView, ByVal clsuser As classUserInfo) As Boolean
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

        comm.CommandText = "p_mfg_production_lots_insert" 'In Process 
        i = 0
        For i = 0 To dv_add.Count - 1
            With dv_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_production_lots_id", .Item(i)("mfg_production_lots_id"))
                comm.Parameters.AddWithValue("@system_lot_number", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@custom_lot_number", .Item(i)("custom_lot_number"))
                comm.Parameters.AddWithValue("@inventory_item_code", mfg_production_lots.inventory_item_code)
                comm.Parameters.AddWithValue("@lot_delivered_to_inventory", .Item(i)("lot_delivered_to_inventory"))
                comm.Parameters.AddWithValue("@production_order_no", mfg_production_lots.production_order_no)
                comm.Parameters.AddWithValue("@primary_quantity", .Item(i)("primary_quantity"))
                comm.Parameters.AddWithValue("@secondary_quantity", .Item(i)("secondary_quantity"))
                comm.Parameters.AddWithValue("@created_by", mfg_production_lots.created_by)
                comm.Parameters.AddWithValue("@creation_date", mfg_production_lots.creation_date)
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
                comm.Parameters.AddWithValue("@mfg_production_steps_id", mfg_production_lots.mfg_production_steps_id)
                comm.Parameters.AddWithValue("@lot_grade", .Item(i)("lot_grade"))
                comm.Parameters.AddWithValue("@qc_remarks", .Item(i)("qc_remarks"))
                comm.Parameters.AddWithValue("@logempcd", clsuser.UserID)
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@steam_condition", .Item(i)("steam_condition"))
                comm.Parameters.AddWithValue("@steam_date", .Item(i)("steam_date"))
                comm.Parameters.AddWithValue("@steam_time", .Item(i)("steam_time"))
                comm.Parameters.AddWithValue("@operator_lot_number", .Item(i)("operator_lot_number"))
                comm.Parameters.AddWithValue("@operator", .Item(i)("operator"))
                comm.Parameters.AddWithValue("@work_shift", .Item(i)("work_shift"))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(i)("bar_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), DBNull.Value))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), DBNull.Value))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(i)("grade_bdt"), DBNull.Value))
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(i)("grade_adt"), DBNull.Value))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(i)("cliped"), DBNull.Value))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(i)("shift"), DBNull.Value))
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(i)("ProdFinishDate"), DBNull.Value))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(i)("ProdFinishTime"), DBNull.Value))
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(i)("dyeing_pass"), DBNull.Value))
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(i)("adjust_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(i)("qc_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(i)("dyed_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(i)("lab_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(i)("defect_loss_kg"), DBNull.Value))

                'Warp
                comm.Parameters.AddWithValue("@beam_length", config.IsNull(.Item(i)("beam_length"), DBNull.Value))
                comm.Parameters.AddWithValue("@weight_before_warp", config.IsNull(.Item(i)("weight_before_warp"), DBNull.Value))
                comm.Parameters.AddWithValue("@warp_speed", config.IsNull(.Item(i)("warp_speed"), DBNull.Value))
                comm.Parameters.AddWithValue("@tension_h", config.IsNull(.Item(i)("tension_h"), DBNull.Value))
                comm.Parameters.AddWithValue("@tension_per_g", config.IsNull(.Item(i)("tension_per_g"), DBNull.Value))
                comm.Parameters.AddWithValue("@tape_layer", config.IsNull(.Item(i)("tape_layer"), DBNull.Value))
                comm.Parameters.AddWithValue("@bobbin_weight_before", config.IsNull(.Item(i)("bobbin_weight_before"), DBNull.Value))
                comm.Parameters.AddWithValue("@bobbin_weight_after", config.IsNull(.Item(i)("bobbin_weight_after"), DBNull.Value))
                comm.Parameters.AddWithValue("@bobbin_tear_weight", config.IsNull(.Item(i)("bobbin_tear_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@beam_tear_weight", config.IsNull(.Item(i)("beam_tear_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@beam_total_weight", config.IsNull(.Item(i)("beam_total_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@waste_yarn", config.IsNull(.Item(i)("waste_yarn"), DBNull.Value))
                comm.Parameters.AddWithValue("@warping_time", config.IsNull(.Item(i)("warping_time"), DBNull.Value))
                comm.Parameters.AddWithValue("@kg_gr", config.IsNull(.Item(i)("kg_gr"), DBNull.Value))
                comm.Parameters.AddWithValue("@actual_cone_weight", config.IsNull(.Item(i)("actual_cone_weight"), DBNull.Value))
                'comm.Parameters.AddWithValue("@beam_item_id", config.IsNull(dv_upd.Item(i)("Beam_Item_Id"), DBNull.Value)) 'Sitthana 20181219

            End With
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next


        comm.CommandText = "p_mfg_production_lots_update" 'In Process 
        i = 0
        For i = 0 To dv_upd.Count - 1
            With dv_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_production_lots_id", .Item(i)("mfg_production_lots_id"))
                comm.Parameters.AddWithValue("@system_lot_number", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@custom_lot_number", .Item(i)("custom_lot_number"))
                comm.Parameters.AddWithValue("@inventory_item_code", .Item(i)("inventory_item_code"))
                comm.Parameters.AddWithValue("@lot_delivered_to_inventory", .Item(i)("lot_delivered_to_inventory"))
                comm.Parameters.AddWithValue("@production_order_no", .Item(i)("production_order_no"))
                comm.Parameters.AddWithValue("@primary_quantity", .Item(i)("primary_quantity"))
                comm.Parameters.AddWithValue("@secondary_quantity", .Item(i)("secondary_quantity"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@last_modified_by", mfg_production_lots.last_modified_by)
                comm.Parameters.AddWithValue("@last_modified_date", mfg_production_lots.last_modified_date)
                comm.Parameters.AddWithValue("@mfg_production_steps_id", .Item(i)("mfg_production_steps_id"))
                comm.Parameters.AddWithValue("@lot_grade", .Item(i)("lot_grade"))
                comm.Parameters.AddWithValue("@qc_remarks", .Item(i)("qc_remarks"))
                comm.Parameters.AddWithValue("@logempcd", clsuser.UserID)

                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@steam_condition", .Item(i)("steam_condition"))
                comm.Parameters.AddWithValue("@steam_date", .Item(i)("steam_date"))
                comm.Parameters.AddWithValue("@steam_time", .Item(i)("steam_time"))
                comm.Parameters.AddWithValue("@operator_lot_number", .Item(i)("operator_lot_number"))

                comm.Parameters.AddWithValue("@operator", .Item(i)("operator"))
                comm.Parameters.AddWithValue("@work_shift", .Item(i)("work_shift"))
                '2016/07/18
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(i)("bar_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), DBNull.Value))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), DBNull.Value))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(i)("grade_bdt"), DBNull.Value))
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(i)("grade_adt"), DBNull.Value))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(i)("cliped"), DBNull.Value))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(i)("shift"), DBNull.Value))
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(i)("ProdFinishDate"), DBNull.Value))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(i)("ProdFinishTime"), DBNull.Value))
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(i)("dyeing_pass"), DBNull.Value))
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(i)("adjust_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(i)("qc_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(i)("dyed_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(i)("lab_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(i)("defect_loss_kg"), DBNull.Value))

                'Warp
                comm.Parameters.AddWithValue("@beam_length", config.IsNull(.Item(i)("beam_length"), DBNull.Value))
                comm.Parameters.AddWithValue("@weight_before_warp", config.IsNull(.Item(i)("weight_before_warp"), DBNull.Value))
                comm.Parameters.AddWithValue("@warp_speed", config.IsNull(.Item(i)("warp_speed"), DBNull.Value))
                comm.Parameters.AddWithValue("@tension_h", config.IsNull(.Item(i)("tension_h"), DBNull.Value))
                comm.Parameters.AddWithValue("@tension_per_g", config.IsNull(.Item(i)("tension_per_g"), DBNull.Value))
                comm.Parameters.AddWithValue("@tape_layer", config.IsNull(.Item(i)("tape_layer"), DBNull.Value))
                comm.Parameters.AddWithValue("@bobbin_weight_before", config.IsNull(.Item(i)("bobbin_weight_before"), DBNull.Value)) '
                comm.Parameters.AddWithValue("@bobbin_weight_after", config.IsNull(.Item(i)("bobbin_weight_after"), DBNull.Value)) '
                comm.Parameters.AddWithValue("@bobbin_tear_weight", config.IsNull(.Item(i)("bobbin_tear_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@beam_tear_weight", config.IsNull(.Item(i)("beam_tear_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@beam_total_weight", config.IsNull(.Item(i)("beam_total_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@waste_yarn", config.IsNull(.Item(i)("waste_yarn"), DBNull.Value))
                comm.Parameters.AddWithValue("@warping_time", config.IsNull(.Item(i)("warping_time"), DBNull.Value))
                comm.Parameters.AddWithValue("@kg_gr", config.IsNull(.Item(i)("kg_gr"), DBNull.Value))
                comm.Parameters.AddWithValue("@actual_cone_weight", config.IsNull(.Item(i)("actual_cone_weight"), DBNull.Value))

                comm.Parameters.AddWithValue("@lotno_sup", config.IsNull(.Item(i)("lotno_sup"), DBNull.Value))
                comm.Parameters.AddWithValue("@lotno_our", config.IsNull(.Item(i)("lotno_our"), DBNull.Value))
                comm.Parameters.AddWithValue("@beam_item_id", config.IsNull(dv_upd.Item(i)("Beam_Item_Id"), DBNull.Value)) 'Sitthana 20181219
                comm.Parameters.AddWithValue("@docdt", config.IsNull(dv_upd.Item(i)("docdt"), DBNull.Value)) 'Sitthana 20200312
            End With

            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next

        comm.CommandText = "p_mfg_production_lots_delete" 'In Process 
        i = 0
        For i = 0 To dv_del.Count - 1
            With dv_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_production_lots_id", .Item(i)("mfg_production_lots_id"))
                comm.Parameters.AddWithValue("@system_lot_number", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@custom_lot_number", .Item(i)("custom_lot_number"))
                comm.Parameters.AddWithValue("@inventory_item_code", .Item(i)("inventory_item_code"))
                comm.Parameters.AddWithValue("@lot_delivered_to_inventory", .Item(i)("lot_delivered_to_inventory"))
                comm.Parameters.AddWithValue("@production_order_no", .Item(i)("production_order_no"))
                comm.Parameters.AddWithValue("@primary_quantity", .Item(i)("primary_quantity"))
                comm.Parameters.AddWithValue("@secondary_quantity", .Item(i)("secondary_quantity"))
                comm.Parameters.AddWithValue("@created_by", .Item(i)("created_by"))
                comm.Parameters.AddWithValue("@creation_date", .Item(i)("creation_date"))
                comm.Parameters.AddWithValue("@last_modified_by", .Item(i)("last_modified_by"))
                comm.Parameters.AddWithValue("@last_modified_date", .Item(i)("last_modified_date"))
                comm.Parameters.AddWithValue("@mfg_production_steps_id", .Item(i)("mfg_production_steps_id"))
                comm.Parameters.AddWithValue("@lot_grade", .Item(i)("lot_grade"))
                comm.Parameters.AddWithValue("@qc_remarks", .Item(i)("qc_remarks"))
                comm.Parameters.AddWithValue("@logempcd", clsuser.UserID)

                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))

                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@steam_condition", .Item(i)("steam_condition"))
                comm.Parameters.AddWithValue("@steam_date", .Item(i)("steam_date"))
                comm.Parameters.AddWithValue("@steam_time", .Item(i)("steam_time"))
                comm.Parameters.AddWithValue("@operator_lot_number", .Item(i)("operator_lot_number"))

                comm.Parameters.AddWithValue("@operator", .Item(i)("operator"))
                comm.Parameters.AddWithValue("@work_shift", .Item(i)("work_shift"))
                '2016/07/18
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(i)("bar_weight"), DBNull.Value))
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), DBNull.Value))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), DBNull.Value))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(i)("grade_bdt"), DBNull.Value))
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(i)("grade_adt"), DBNull.Value))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(i)("cliped"), DBNull.Value))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(i)("shift"), DBNull.Value))
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(i)("ProdFinishDate"), DBNull.Value))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(i)("ProdFinishTime"), DBNull.Value))
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(i)("dyeing_pass"), DBNull.Value))
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(i)("adjust_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(i)("qc_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(i)("dyed_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(i)("lab_loss_kg"), DBNull.Value))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(i)("defect_loss_kg"), DBNull.Value))
            End With

            Dim dac_del = New SqlDataAdapter(comm)
            Dim dtc_del = New DataTable
            Try
                dac_del.Fill(dtc_del)
            Catch ex As Exception
                mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next


        'START Insert Defect Roll
        comm.CommandText = "p_greige_in_ko_manual_insert_defect_roll"
        For i = 0 To dv_dtDefect_add.Count - 1
            With dv_dtDefect_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(dv_dtDefect_add.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", mfg_production_lots.system_lot_number)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

            End With
            Dim DA_DV_DTC_ADD = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_ADD = New DataTable
            Try
                DA_DV_DTC_ADD.Fill(DT_DV_DTC_ADD)
            Catch ex As Exception
                mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next

        'END INsert Defect Roll

        'START Update Defect Roll
        comm.CommandText = "p_greige_in_ko_manual_update_defect_roll"
        For i = 0 To dv_dtDefect_upd.Count - 1
            With dv_dtDefect_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", mfg_production_lots.system_lot_number)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

            End With
            Dim DA_DV_DTC_UPD = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_UPD = New DataTable
            Try
                DA_DV_DTC_UPD.Fill(DT_DV_DTC_UPD)
            Catch ex As Exception
                mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next
        'END Update Defect Roll

        'START Delete Defect Roll
        comm.CommandText = "p_greige_in_ko_manual_delete_defect_roll"
        For i = 0 To dv_dtDefect_del.Count - 1
            With dv_dtDefect_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", mfg_production_lots.system_lot_number)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

            End With
            Dim DA_DV_DTC_DEL = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_DEL = New DataTable
            Try
                DA_DV_DTC_DEL.Fill(DT_DV_DTC_DEL)
            Catch ex As Exception
                mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next

        comm.CommandText = "p_mfg_production_lots_update_yarn_in"
        For i = 0 To dv_yarn_in_add.Count - 1
            With dv_yarn_in_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@docdt", .Item(i)("docdt"))
                comm.Parameters.AddWithValue("@docno", .Item(i)("docno"))
                comm.Parameters.AddWithValue("@itcd", .Item(i)("inventory_item_code"))
                comm.Parameters.AddWithValue("@purno", .Item(i)("production_order_no")) 'production_order_no = Purno = Kono
                comm.Parameters.AddWithValue("@boxno", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_s", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_f", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_o", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@boxno_p", .Item(i)("system_lot_number"))
                comm.Parameters.AddWithValue("@lotno_sup", .Item(i)("lotno_sup"))
                comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our"))

                comm.Parameters.AddWithValue("@kg_nt", .Item(i)("beam_total_weight"))
                comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr"))
                comm.Parameters.AddWithValue("@spools", .Item(i)("beams_per_set"))
                comm.Parameters.AddWithValue("@cart_tearwt", 0)
                comm.Parameters.AddWithValue("@spool_tearwt", 0)
                comm.Parameters.AddWithValue("@actual_cone_weight", .Item(i)("actual_cone_weight"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(i)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@box_remark", .Item(i)("box_remark"))
                comm.Parameters.AddWithValue("@logempcd", clsuser.UserID)
            End With
            Dim DA_DV_Y_ADD = New SqlDataAdapter(comm)
            Dim DT_DV_Y_ADD = New DataTable
            Try
                DA_DV_Y_ADD.Fill(DT_DV_Y_ADD)

            Catch ex As Exception
                mfg_production_lots.message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()
        Return True

    End Function



End Class

