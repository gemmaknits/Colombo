Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classOperationKnittingNEW
    Public Structure Greige_Header

        'Greige
        Dim h01_suppcd As String
        Dim h02_source As String
        Dim h03_source_refno As String
        Dim h04_tran_no As String
        Dim h05_tran_dt As Date
        Dim h06_design_no As String
        Dim h07_supdes_no As String
        Dim h08_kono As String
        Dim h09_pieces As Double
        Dim h10_nob As Double
        Dim h11_Gwth As String
        Dim h12_Gwth_actual As String
        Dim h13_roll_no As String
        Dim h14_roll_no_g As String
        Dim h15_roll_no_n As Decimal
        Dim h16_racks As Double
        Dim h17_kg As Double
        Dim h18_mts As Double
        Dim h19_yds As Double
        Dim h20_kg_qc As Double
        Dim h21_mts_qc As Double
        Dim h22_yds_qc As Double
        Dim h23_grade As String
        Dim h24_rem_qc As String
        Dim h25_loc As String
        Dim h26_outreqno As String
        Dim h27_outreqdt As Nullable(Of Date)
        Dim h28_outreqtyp As String
        Dim h29_outno As String
        Dim h30_outdt As Nullable(Of Date)
        Dim h31_lot As String
        Dim h32_yr As String
        Dim h33_sh As String
        Dim h34_dfno As String
        Dim h35_col As String
        Dim h36_dhcod As String
        Dim h37_sono As String
        Dim h38_sonoid As String
        Dim h39_roll_no_o As String
        Dim h40_pn As Double
        Dim h41_ydkg_g As Double
        Dim h42_cost As Decimal
        Dim h43_fload As Boolean
        Dim h44_rate As Decimal
        Dim h45_sel As Boolean
        Dim h46_cost_g As Double
        Dim h47_cliped As Boolean
        Dim h48_unit As String
        Dim h49_g_cost As Double
        Dim h50_tran_no1 As String
        Dim h51_tran_not As String
        Dim h52_cancel As Boolean
        Dim h53_doctyp As String
        Dim h54_preseted As Boolean
        Dim h55_qcalertcd As String
        Dim h56_ProdFinishDate As Date
        Dim h57_ProdFinishTime As String
        Dim h58_mcno As String
        Dim h59_adjust_loss_kg As Double
        Dim h60_qc_loss_kg As Double
        Dim h61_dyed_loss_kg As Double
        Dim h62_grade_bdt As String
        Dim h63_grade_adt As String
        Dim h64_dyeing_pass As Boolean
        Dim h65_dyeing_fail As Boolean
        Dim h66_shift As String
        Dim h67_id_greige_do As Int64
        Dim h68_id_greige As Int64
        Dim h69_lab_loss_kg As Double
        Dim h70_defect_loss_kg As Double
        Dim h71_purno As String
        Dim h72_tran_type As String
        Dim h73_roll_no_f As String
        Dim h74_job_line_id As String
        Dim h75_fabric_cost As Double
        Dim h76_process_cost As Double
        Dim h77_process_loss_perc As Double
        Dim h78_other_cost As Double
        Dim h79_cost_per_unit As Double
        Dim h80_sub_location As String
        Dim h81_greige_status As Byte
        Dim h82_bar_weight As Double
        Dim h83_mtl_warehouse_id As Nullable(Of Int64)
        Dim h84_mtl_subinventory_id As Nullable(Of Int64)
        Dim h85_mtl_locations_id As Nullable(Of Int64)
        Dim h86_counter_per_roll As Nullable(Of Decimal)
        Dim h87_rpm As Nullable(Of Decimal)
        Dim h88_pcv_item_id As Nullable(Of Int64)

    End Structure

    Public Structure Defect_roll_Header
        Dim h01_id_defect_roll As Int64
        Dim h02_roll_no As String
        Dim h03_defect_code As String
        Dim h04_defect_details As String
        Dim h05_stock_code As String
    End Structure

    Public Function GetMfgOperationStepKnitting(Optional ByVal IntMfgProductionLotsID As Nullable(Of Integer) = Nothing,
                                               Optional ByVal StrSystemLotNumber As String = Nothing,
                                               Optional ByVal IntmfgProductionStepsID As Nullable(Of Integer) = Nothing,
                                               Optional ByVal StrProductionOrderNo As String = Nothing,
                                               Optional ByVal Strlogempcd As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_operations_step_knitting_pkg_get_roll_details"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mfg_production_lots_id", IntMfgProductionLotsID)  'Add @ By Sitthana 20180110'
        comm.Parameters.AddWithValue("@system_lot_number", StrSystemLotNumber)
        comm.Parameters.AddWithValue("@mfg_production_steps_id", IntmfgProductionStepsID)
        comm.Parameters.AddWithValue("@production_order_no", StrProductionOrderNo)
        comm.Parameters.AddWithValue("@logempcd", Strlogempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        'comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            'ex.Message
        End Try

        Return dt
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

        comm.CommandText = "P_OPERAION_KNITTING_PKG_insert_mfg_production_lots" 'In Process 
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


        comm.CommandText = "P_OPERAION_KNITTING_PKG_update_mfg_production_lots" 'In Process 
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

        comm.CommandText = "P_OPERAION_KNITTING_PKG_delete_mfg_production_lots" 'In Process 
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
        comm.CommandText = "[dbo].[p_greige_in_ko_manual_insert_defect_roll_NEW]"
        For i = 0 To dv_dtDefect_add.Count - 1
            With dv_dtDefect_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(dv_dtDefect_add.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", mfg_production_lots.system_lot_number)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                'comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

                comm.Parameters.AddWithValue("@p_length_start", config.IsNull(.Item(i)("length_start"), ""))
                comm.Parameters.AddWithValue("@p_length_defect", config.IsNull(.Item(i)("length_defect"), ""))
                comm.Parameters.AddWithValue("@p_bar_no", config.IsNull(.Item(i)("bar_no"), ""))
                comm.Parameters.AddWithValue("@p_guide_no", config.IsNull(.Item(i)("guide_no"), ""))
                comm.Parameters.AddWithValue("@p_defect_remark", config.IsNull(.Item(i)("defect_remark"), ""))

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
        comm.CommandText = "[dbo].[p_greige_in_ko_manual_update_defect_roll_NEW]"
        For i = 0 To dv_dtDefect_upd.Count - 1
            With dv_dtDefect_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", mfg_production_lots.system_lot_number)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                '  comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

                comm.Parameters.AddWithValue("@p_length_start", config.IsNull(.Item(i)("length_start"), ""))
                comm.Parameters.AddWithValue("@p_length_defect", config.IsNull(.Item(i)("length_defect"), ""))
                comm.Parameters.AddWithValue("@p_bar_no", config.IsNull(.Item(i)("bar_no"), ""))
                comm.Parameters.AddWithValue("@p_guide_no", config.IsNull(.Item(i)("guide_no"), ""))
                comm.Parameters.AddWithValue("@p_defect_remark", config.IsNull(.Item(i)("defect_remark"), ""))
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
        comm.CommandText = "[dbo].[p_greige_in_ko_manual_delete_defect_roll_NEW]"
        For i = 0 To dv_dtDefect_del.Count - 1
            With dv_dtDefect_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", mfg_production_lots.system_lot_number)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                'comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

                comm.Parameters.AddWithValue("@p_length_start", config.IsNull(.Item(i)("length_start"), ""))
                comm.Parameters.AddWithValue("@p_length_defect", config.IsNull(.Item(i)("length_defect"), ""))
                comm.Parameters.AddWithValue("@p_bar_no", config.IsNull(.Item(i)("bar_no"), ""))
                comm.Parameters.AddWithValue("@p_guide_no", config.IsNull(.Item(i)("guide_no"), ""))
                comm.Parameters.AddWithValue("@p_defect_remark", config.IsNull(.Item(i)("defect_remark"), ""))

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
                comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno"))
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

    Public Function GIN_KOManualsave(ByVal Gin_header As Greige_Header, ByVal Defect_Roll_Header As Defect_roll_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String, ByRef Roll_no As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim strRoll_no_o As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start Gen GIN No----------
        comm.CommandText = "P_GREIGE_IN_KO_MANUAL_PKG_gen_doc"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)
            comm.Parameters.AddWithValue("@tran_dt", Gin_header.h05_tran_dt) 'Tran_Dt = GIN Date
            comm.Parameters.AddWithValue("@kono", Gin_header.h08_kono)
            comm.Parameters.AddWithValue("@tran_type", Gin_header.h72_tran_type)            'Tran_Type = KNITTING
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@checknew", "")
        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try
        Gin_header.h04_tran_no = dt.Rows(0)("tran_no").ToString.Trim

        'END Gen GIN No----------

        'START Insert GIN KO Manual---
        'P_GREIGE_IN_KO_MANUAL_PKG_update_greige
        comm.CommandText = "P_GREIGE_IN_KO_MANUAL_PKG_update_greige"
        'comm.CommandText = "p_greige_in_ko_manual_update" 'Use 1 Stroreprocedure insert & update
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@suppcd", Gin_header.h01_suppcd)
            comm.Parameters.AddWithValue("@source", Gin_header.h02_source)
            comm.Parameters.AddWithValue("@source_refno", Gin_header.h03_source_refno)
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)    'Tran_No = GIN NO
            comm.Parameters.AddWithValue("@tran_dt", Gin_header.h05_tran_dt)         'Tran_Dt = GIN Date
            comm.Parameters.AddWithValue("@design_no", Gin_header.h06_design_no)
            comm.Parameters.AddWithValue("@supdes_no", Gin_header.h07_supdes_no)
            comm.Parameters.AddWithValue("@kono", Gin_header.h08_kono)
            comm.Parameters.AddWithValue("@pieces", Gin_header.h09_pieces)
            comm.Parameters.AddWithValue("@nob", Gin_header.h10_nob)
            comm.Parameters.AddWithValue("@Gwth", Gin_header.h11_Gwth)
            comm.Parameters.AddWithValue("@Gwth_actual", Gin_header.h12_Gwth_actual)
            comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
            comm.Parameters.AddWithValue("@roll_no_g", Gin_header.h14_roll_no_g)
            comm.Parameters.AddWithValue("@roll_no_n", Gin_header.h15_roll_no_n)
            comm.Parameters.AddWithValue("@racks", Gin_header.h16_racks)
            comm.Parameters.AddWithValue("@kg", Gin_header.h17_kg)
            comm.Parameters.AddWithValue("@mts", Gin_header.h18_mts)
            comm.Parameters.AddWithValue("@yds", Gin_header.h19_yds)
            comm.Parameters.AddWithValue("@kg_qc", Gin_header.h20_kg_qc)
            comm.Parameters.AddWithValue("@mts_qc", Gin_header.h21_mts_qc)
            comm.Parameters.AddWithValue("@yds_qc", Gin_header.h22_yds_qc)
            comm.Parameters.AddWithValue("@grade", Gin_header.h23_grade)
            comm.Parameters.AddWithValue("@rem_qc", Gin_header.h24_rem_qc)
            comm.Parameters.AddWithValue("@loc", Gin_header.h25_loc)           'Loc = ESC
            comm.Parameters.AddWithValue("@outreqno", Gin_header.h26_outreqno)
            comm.Parameters.AddWithValue("@outreqdt", Gin_header.h27_outreqdt)
            comm.Parameters.AddWithValue("@outreqtyp", Gin_header.h28_outreqtyp)
            comm.Parameters.AddWithValue("@outno", Gin_header.h29_outno)
            comm.Parameters.AddWithValue("@outdt", Gin_header.h30_outdt)
            comm.Parameters.AddWithValue("@lot", Gin_header.h31_lot)
            comm.Parameters.AddWithValue("@yr", Gin_header.h32_yr)
            comm.Parameters.AddWithValue("@sh", Gin_header.h33_sh)
            comm.Parameters.AddWithValue("@dfno", Gin_header.h34_dfno)
            comm.Parameters.AddWithValue("@col", Gin_header.h35_col)
            comm.Parameters.AddWithValue("@dhcod", Gin_header.h36_dhcod)
            comm.Parameters.AddWithValue("@sono", Gin_header.h37_sono)
            comm.Parameters.AddWithValue("@sonoid", Gin_header.h38_sonoid)
            comm.Parameters.AddWithValue("@roll_no_o", Gin_header.h39_roll_no_o)
            comm.Parameters.AddWithValue("@pn", Gin_header.h40_pn)
            comm.Parameters.AddWithValue("@ydkg_g", Gin_header.h41_ydkg_g)
            comm.Parameters.AddWithValue("@cost", Gin_header.h42_cost)
            comm.Parameters.AddWithValue("@fload", Gin_header.h43_fload)
            comm.Parameters.AddWithValue("@rate", Gin_header.h44_rate)
            comm.Parameters.AddWithValue("@sel", Gin_header.h45_sel)
            comm.Parameters.AddWithValue("@cost_g", Gin_header.h46_cost_g)
            comm.Parameters.AddWithValue("@cliped", Gin_header.h47_cliped)
            comm.Parameters.AddWithValue("@unit", Gin_header.h48_unit)
            comm.Parameters.AddWithValue("@g_cost", Gin_header.h49_g_cost)
            comm.Parameters.AddWithValue("@tran_no1", Gin_header.h50_tran_no1)
            comm.Parameters.AddWithValue("@tran_not", Gin_header.h51_tran_not)
            comm.Parameters.AddWithValue("@cancel", Gin_header.h52_cancel)
            comm.Parameters.AddWithValue("@doctyp", Gin_header.h53_doctyp)
            comm.Parameters.AddWithValue("@preseted", Gin_header.h54_preseted)                'Preseted = 0
            comm.Parameters.AddWithValue("@qcalertcd", Gin_header.h55_qcalertcd)
            comm.Parameters.AddWithValue("@ProdFinishDate", Gin_header.h56_ProdFinishDate)
            comm.Parameters.AddWithValue("@ProdFinishTime", Gin_header.h57_ProdFinishTime)
            comm.Parameters.AddWithValue("@mcno", Gin_header.h58_mcno)
            comm.Parameters.AddWithValue("@adjust_loss_kg", Gin_header.h59_adjust_loss_kg)
            comm.Parameters.AddWithValue("@qc_loss_kg", Gin_header.h60_qc_loss_kg)
            comm.Parameters.AddWithValue("@dyed_loss_kg", Gin_header.h61_dyed_loss_kg)
            comm.Parameters.AddWithValue("@grade_bdt", Gin_header.h62_grade_bdt)
            comm.Parameters.AddWithValue("@grade_adt", Gin_header.h63_grade_adt)
            comm.Parameters.AddWithValue("@dyeing_pass", Gin_header.h64_dyeing_pass)
            comm.Parameters.AddWithValue("@dyeing_fail", Gin_header.h65_dyeing_fail)
            comm.Parameters.AddWithValue("@shift", Gin_header.h66_shift)
            comm.Parameters.AddWithValue("@id_greige_do", Gin_header.h67_id_greige_do)
            comm.Parameters.AddWithValue("@id_greige", Gin_header.h68_id_greige)
            comm.Parameters.AddWithValue("@lab_loss_kg", Gin_header.h69_lab_loss_kg)
            comm.Parameters.AddWithValue("@defect_loss_kg", Gin_header.h70_defect_loss_kg)
            comm.Parameters.AddWithValue("@purno", Gin_header.h71_purno)
            comm.Parameters.AddWithValue("@tran_type", Gin_header.h72_tran_type)            'Tran_Type = KNITTING
            comm.Parameters.AddWithValue("@roll_no_f", Gin_header.h73_roll_no_f)
            comm.Parameters.AddWithValue("@job_line_id", Gin_header.h74_job_line_id)
            comm.Parameters.AddWithValue("@fabric_cost", Gin_header.h75_fabric_cost)
            comm.Parameters.AddWithValue("@process_cost", Gin_header.h76_process_cost)
            comm.Parameters.AddWithValue("@process_loss_perc", Gin_header.h77_process_loss_perc)
            comm.Parameters.AddWithValue("@other_cost", Gin_header.h78_other_cost)
            comm.Parameters.AddWithValue("@cost_per_unit", Gin_header.h79_cost_per_unit)
            comm.Parameters.AddWithValue("@sub_location", Gin_header.h80_sub_location)          'sub_location = ESC
            comm.Parameters.AddWithValue("@greige_status", Gin_header.h81_greige_status)
            comm.Parameters.AddWithValue("@bar_weight", Gin_header.h82_bar_weight)
            comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            comm.Parameters.AddWithValue("@mtl_warehouse_id", Gin_header.h83_mtl_warehouse_id)
            comm.Parameters.AddWithValue("@mtl_subinventory_id", Gin_header.h84_mtl_subinventory_id)
            comm.Parameters.AddWithValue("@mtl_locations_id", Gin_header.h85_mtl_locations_id)

        End With
        Dim dai As New SqlDataAdapter(comm)
        Dim dti As New DataTable
        Try
            dai.Fill(dti)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try

        'GET DATA FROM INSERT GIN
        Gin_header.h05_tran_dt = dti.Rows(0)("tran_dt").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h13_roll_no = dti.Rows(0)("roll_no").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h14_roll_no_g = dti.Rows(0)("roll_no_g").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h15_roll_no_n = dti.Rows(0)("roll_no_n").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h39_roll_no_o = dti.Rows(0)("roll_no_o").ToString.Trim   'GET DATA FROM INSERT GIN
        Gin_header.h56_ProdFinishDate = dti.Rows(0)("ProdFinishDate").ToString.Trim  'GET DATA FROM INSERT GIN
        Gin_header.h73_roll_no_f = dti.Rows(0)("roll_no_f").ToString.Trim    'GET DATA FROM INSERT GIN
        'END Insert GIN KO Manual

        'START Insert Defect Roll
        comm.CommandText = "[dbo].[p_greige_in_ko_manual_insert_defect_roll_NEW]"
        For i = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                'comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", Defect_Roll_Header.h05_stock_code)

                comm.Parameters.AddWithValue("@p_length_start", config.IsNull(.Item(i)("length_start"), ""))
                comm.Parameters.AddWithValue("@p_length_defect", config.IsNull(.Item(i)("length_defect"), ""))
                comm.Parameters.AddWithValue("@p_bar_no", config.IsNull(.Item(i)("bar_no"), ""))
                comm.Parameters.AddWithValue("@p_guide_no", config.IsNull(.Item(i)("guide_no"), ""))
                comm.Parameters.AddWithValue("@p_defect_remark", config.IsNull(.Item(i)("defect_remark"), ""))
            End With
            Dim DA_DV_DTC_ADD = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_ADD = New DataTable
            Try
                DA_DV_DTC_ADD.Fill(DT_DV_DTC_ADD)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next

        'END INsert Defect Roll

        'START Update Defect Roll
        comm.CommandText = "[dbo].[p_greige_in_ko_manual_update_defect_roll_NEW]"
        For i = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                ' comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", config.IsNull(.Item(i)("stock_code"), "G"))

                comm.Parameters.AddWithValue("@p_length_start", config.IsNull(.Item(i)("length_start"), ""))
                comm.Parameters.AddWithValue("@p_length_defect", config.IsNull(.Item(i)("length_defect"), ""))
                comm.Parameters.AddWithValue("@p_bar_no", config.IsNull(.Item(i)("bar_no"), ""))
                comm.Parameters.AddWithValue("@p_guide_no", config.IsNull(.Item(i)("guide_no"), ""))
                comm.Parameters.AddWithValue("@p_defect_remark", config.IsNull(.Item(i)("defect_remark"), ""))
            End With
            Dim DA_DV_DTC_UPD = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_UPD = New DataTable
            Try
                DA_DV_DTC_UPD.Fill(DT_DV_DTC_UPD)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next
        'END Update Defect Roll

        'START Delete Defect Roll
        comm.CommandText = "[dbo].[p_greige_in_ko_manual_delete_defect_roll_NEW]"
        For i = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_defect_roll", config.IsNull(.Item(i)("id_defect_roll"), 0))
                comm.Parameters.AddWithValue("@roll_no", Gin_header.h13_roll_no)
                comm.Parameters.AddWithValue("@defect_code", config.IsNull(.Item(i)("defect_code"), ""))
                ' comm.Parameters.AddWithValue("@defect_details", config.IsNull(.Item(i)("defect_details"), ""))
                comm.Parameters.AddWithValue("@stock_code", config.IsNull(.Item(i)("stock_code"), "G"))

                comm.Parameters.AddWithValue("@p_length_start", config.IsNull(.Item(i)("length_start"), ""))
                comm.Parameters.AddWithValue("@p_length_defect", config.IsNull(.Item(i)("length_defect"), ""))
                comm.Parameters.AddWithValue("@p_bar_no", config.IsNull(.Item(i)("bar_no"), ""))
                comm.Parameters.AddWithValue("@p_guide_no", config.IsNull(.Item(i)("guide_no"), ""))
                comm.Parameters.AddWithValue("@p_defect_remark", config.IsNull(.Item(i)("defect_remark"), ""))

            End With
            Dim DA_DV_DTC_DEL = New SqlDataAdapter(comm)
            Dim DT_DV_DTC_DEL = New DataTable
            Try
                DA_DV_DTC_DEL.Fill(DT_DV_DTC_DEL)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            'Action = "ADD"

        Next
        'END Delete Defect Roll

        'Start Insert Action----------
        If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "GIN"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Gin_header.h04_tran_no)
            comm.Parameters.AddWithValue("@workdt", Now)
            comm.Parameters.AddWithValue("@doctyp", doctyp)
            comm.Parameters.AddWithValue("@worktyp", Action)

        End With
        'Dim sql As String = config.BuildSQL(comm)
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------
        Tran_no = Gin_header.h04_tran_no
        Roll_no = Gin_header.h13_roll_no
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function GetDefaultSubInventoryId(pMtlWareHouseId As Nullable(Of Int64)) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_OPERAION_KNITTING_PKG_get_default_subinventory_id"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_warehouse_id", pMtlWareHouseId)
        conn.Open()
        Dim obj = comm.ExecuteScalar()
        If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
            Return Convert.ToInt64(obj)
        End If

    End Function

    Public Function GetDefaultLocationsId(pMtlWareHouseId As Nullable(Of Int64), pMtlSubInventoryId As Nullable(Of Int64)) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_OPERAION_KNITTING_PKG_get_default_locations_id"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_mtl_warehouse_id", pMtlWareHouseId)
        comm.Parameters.AddWithValue("@p_mtl_subinventory_id", pMtlSubInventoryId)
        conn.Open()
        Dim obj = comm.ExecuteScalar()
        If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
            Return Convert.ToInt64(obj)
        End If

    End Function
End Class
