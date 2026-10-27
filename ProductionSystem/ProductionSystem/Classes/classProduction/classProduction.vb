Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Structure KO

    Dim production_order_type_id As Nullable(Of Int64) 'Use
    Dim ko_type_code As Nullable(Of Int64) 'No Use
    Dim ko_type As String 'Nullable(Of Int64) ' No Use
    Dim suppcd As String
    Dim kono As String
    Dim kodt As String
    Dim mcno As String
    Dim needle As String
    Dim design_no As String
    Dim gwth As String
    Dim nob As String
    Dim remark As String
    Dim nop As Integer
    Dim sketch As String
    Dim setout As String
    Dim repwth As Single
    Dim replen As Single
    Dim width As String
    Dim elastic As Boolean
    Dim rigid As Boolean
    Dim ray As Boolean
    Dim cat As Boolean
    Dim crossdye As Boolean
    Dim sono As String
    Dim custcd As String
    Dim kstartdt As String
    Dim kenddt As String
    Dim ynchgcd As String
    Dim id_yarnchange As Nullable(Of Int32)
    Dim koclosed As String
    Dim koclosedt As String
    Dim cancel As Boolean
    Dim canceldt As String
    Dim rem_closed As String
    Dim rem_cancel As String
    Dim koclosed_final As Boolean
    Dim koclosed_final_date As String
    Dim rem_closed_final As String
    Dim adjustment As String
    Dim roll_kgs_std As Single
    Dim df_batch_kgs As Single
    Dim daily_capacity_kg As Single
    Dim qty As Single
    Dim steam_instruction As String
    Dim knit_loss_perc As String 'Production Loss
    Dim dyeding_loss_perc As String
    Dim mrp_qty As String

    Dim design_cross As String
    Dim production_order_no_cross As String
    Dim production_order_id As Nullable(Of Int64)
    Dim total_production_lots As Nullable(Of Single)
    Dim id_ko_hist As Nullable(Of Int32)

    Dim ko_mtl_warehouse_id As Nullable(Of Int64)

    Dim outsource_pono As String                       'Append By Sitthana 24/02/2018
    Dim outsource_job_id As Nullable(Of Int64)         'Append By Sitthana 24/12/2017
    Dim outsource_job_line_id As Nullable(Of Int64)    'Append By Sitthana 24/12/2017
    Dim Strmsgerr As String
End Structure

Public Structure MfgProductionOrderLines
    Dim MfgProductionOrderLinesId As Nullable(Of Int64)
    Dim mfg_production_order_id As Nullable(Of Int64)
    Dim mtl_warehouse_id As Nullable(Of Int64)
    Dim item_id As Nullable(Of Int64)
    Dim line_type As Nullable(Of Integer)

End Structure


Public Structure KOSchedulePlan
    Dim id As Long
    Dim code As String
    Dim name_en As String
    Dim name_th As String
    Dim active As Boolean
    Dim remark As String
    Dim create_by As String
    Dim create_date As String
    Dim create_time As String
    Dim mcno As String
    Dim gwth As String
    Dim id_yarnchange As Integer
    Dim kgs As Single
    Dim kstartdt As String
    Dim kstarttime As String
    Dim kenddt As String
    Dim kendtime As String
    Dim adjustment As String
    Dim roll_kgs_std As Single
    Dim df_batch_kgs As Single
    Dim daily_capacity As Single
    Dim loss_percent As Single
    Dim approved As Boolean
    Dim schedule_remark As String
End Structure

Public Structure YarnChange
    Dim design_no As String
    Dim ynchgdt As String
    Dim ynchgcd As String
    Dim remarke As String
    Dim tstamp As String
    Dim id_yarnchange As Integer
    Dim color_id As String   'Append By Sitthan 22/12/2017
    Dim bom_usage_code As String
    Dim required_qty As Double
    Dim uom As String
    Dim bom_uom_id As Integer      'Append By Sitthan 16/01/2018
    Dim bom_active As Boolean
    Dim bom_approved As Boolean
    Dim bom_remarks As String
    Dim design_ver As String
End Structure

Public Class classProduction
    Public Function GetBom(ByRef pIDYarnchange As String, ByRef pPlanQty As String, ByVal pUOMID As String, ByVal pMcNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_get_yarnchangedet"
        comm.Parameters.AddWithValue("@id_yarnchange", pIDYarnchange)
        comm.Parameters.AddWithValue("@plan_qty", pPlanQty)
        comm.Parameters.AddWithValue("@uom_id", pUOMID)
        comm.Parameters.AddWithValue("@mcno", pMcNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetKoNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_get_kono"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboKO() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSO() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_so_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboDesignNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_design_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboKoDesignItems(pKoType As String, pKoClosed As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ko_design_items"
        comm.Parameters.AddWithValue("@ko_type", pKoType)
        comm.Parameters.AddWithValue("@koclosed", pKoClosed)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboKoMachines(pKoType As String, pKoClosed As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ko_machines"
        comm.Parameters.AddWithValue("@ko_type", pKoType)
        comm.Parameters.AddWithValue("@koclosed", pKoClosed)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboKoDesignCross(pKoType As String, pKoClosed As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ko_design_cross"
        comm.Parameters.AddWithValue("@ko_type", pKoType)
        comm.Parameters.AddWithValue("@koclosed", pKoClosed)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboKoSystemLotNumber(pKoType As String, pKoClosed As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ko_system_lot_number"
        comm.Parameters.AddWithValue("@ko_type", pKoType)
        comm.Parameters.AddWithValue("@koclosed", pKoClosed)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboKoYarnchangeItems(pKoType As String, pKoClosed As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ko_yarnchange_items"
        comm.Parameters.AddWithValue("@ko_type", pKoType)
        comm.Parameters.AddWithValue("@koclosed", pKoClosed)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboMachine() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_machine_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function getMtlWarehouseIdByMcNo(pMcNo As String) As DataTable
        'Sitthana 19/10/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_machines_select"
        comm.Parameters.AddWithValue("@mcno", pMcNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        da.Fill(dt)
        comm.Connection.Close()
        Return dt
    End Function
    Public Function comboYarnCode() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_itcd_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSupplier() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_supplier_from_ko_unclosed"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboYarnChangeCode(ByVal strDesignNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_ynchgcd_from_ko"
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'Public Function KOSelect(ByVal strKONo As String, ByVal logempcd As String, ByVal KO As KO) As DataTable
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.CommandText = "p_ko_select2"
    '    comm.Parameters.AddWithValue("@kono", strKONo)
    '    comm.Parameters.AddWithValue("@logempcd", logempcd)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    Return dt
    'End Function

    Public Function ProdLineSelect(ByVal KO As KO, ByVal classUserInfo As classUserInfo) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_order_lines_select"
        comm.Parameters.AddWithValue("@mfg_production_order_lines_id", KO.production_order_id)
        comm.Parameters.AddWithValue("@producton_order_id", KO.production_order_id)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOSelect2(ByVal KO As KO, ByVal classUserInfo As classUserInfo) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_select_ko"
        comm.Parameters.AddWithValue("@kono", KO.kono)
        comm.Parameters.AddWithValue("@logempcd", classUserInfo.UserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function getKO(pKoNo As String, ByVal pUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_select_ko"
        comm.Parameters.AddWithValue("@kono", pKoNo)
        comm.Parameters.AddWithValue("@logempcd", pUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetCopyKo(ByVal KoNo As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_copy_ko"
        comm.Parameters.AddWithValue("@kono", KoNo)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ProductionSelect(ByVal ko As KO, ByVal classUserInfo As classUserInfo) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_select_mfg_production_order_lines"
        comm.Parameters.AddWithValue("@kono", ko.kono)
        comm.Parameters.AddWithValue("@logempcd", classUserInfo.UserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function getMfgProductionOrderLine(ByVal pKo As String, ByVal pUserId As String) As DataTable
        'Sitthana Boonlom
        '20210723

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_select_mfg_production_order_lines"
        comm.Parameters.AddWithValue("@kono", pKo)
        comm.Parameters.AddWithValue("@logempcd", pUserId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCopyProductionLines(ByVal KoNo As String, ByVal Logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_copy_mfg_production_order_lines"
        comm.Parameters.AddWithValue("@kono", KoNo)
        comm.Parameters.AddWithValue("@logempcd", Logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function KOSelectID(ByVal strKONo As String, ByVal logempcd As String) As Int64
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_select2"
        comm.Parameters.AddWithValue("@kono", strKONo)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return CInt(dt.Rows(0)("production_order_id"))
    End Function

    Public Function KOUpdate(ByRef objKO As KO, ByVal DTC As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByVal logempcd As String, ByRef errmsg As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_update_ko"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@production_order_type_id", objKO.production_order_type_id)
        comm.Parameters.AddWithValue("@ko_type", config.IsNull(objKO.ko_type, 1))
        comm.Parameters.AddWithValue("@suppcd", config.IsNull(objKO.suppcd, "").Trim)
        comm.Parameters.AddWithValue("@kono", config.IsNull(objKO.kono, "").Trim)
        comm.Parameters.AddWithValue("@kodt", config.IsNull(objKO.kodt, "").Trim)
        comm.Parameters.AddWithValue("@mcno", config.IsNull(objKO.mcno, "").Trim)
        comm.Parameters.AddWithValue("@needle", config.IsNull(objKO.needle, "").Trim)
        comm.Parameters.AddWithValue("@design_no", config.IsNull(objKO.design_no, "").Trim)
        comm.Parameters.AddWithValue("@gwth", config.IsNull(objKO.gwth, "").Trim)
        comm.Parameters.AddWithValue("@nob", config.IsNull(objKO.nob, "").Trim)
        comm.Parameters.AddWithValue("@remark", config.IsNull(objKO.remark, "").Trim)
        comm.Parameters.AddWithValue("@nop", config.IsNull(objKO.nop, 0).ToString)
        comm.Parameters.AddWithValue("@sketch", config.IsNull(objKO.sketch, "").Trim)
        comm.Parameters.AddWithValue("@setout", config.IsNull(objKO.setout, "").Trim)
        comm.Parameters.AddWithValue("@repwth", config.IsNull(objKO.repwth, 0).ToString)
        comm.Parameters.AddWithValue("@replen", config.IsNull(objKO.replen, 0).ToString)
        comm.Parameters.AddWithValue("@width", config.IsNull(objKO.width, "").Trim)
        comm.Parameters.AddWithValue("@elastic", config.IsNull(IIf(objKO.elastic, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@rigid", config.IsNull(IIf(objKO.rigid, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@ray", config.IsNull(IIf(objKO.ray, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@cat", config.IsNull(IIf(objKO.cat, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@crossdye", config.IsNull(IIf(objKO.crossdye, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@sono", config.IsNull(objKO.sono, "").Trim)
        comm.Parameters.AddWithValue("@custcd", config.IsNull(objKO.custcd, "").Trim)
        comm.Parameters.AddWithValue("@kstartdt", config.IsNull(objKO.kstartdt, "").Trim)
        comm.Parameters.AddWithValue("@kenddt", config.IsNull(objKO.kenddt, "").Trim)
        comm.Parameters.AddWithValue("@ynchgcd", config.IsNull(objKO.ynchgcd, "").Trim)
        comm.Parameters.AddWithValue("@id_yarnchange", config.IsNull(objKO.id_yarnchange, DBNull.Value)) 'Add By Neung 20200212
        comm.Parameters.AddWithValue("@koclosed", config.IsNull(IIf(objKO.koclosed, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@koclosedt", config.IsNull(objKO.koclosedt, "").Trim)
        comm.Parameters.AddWithValue("@cancel", config.IsNull(IIf(objKO.cancel, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@canceldt", config.IsNull(objKO.canceldt, "").Trim)
        comm.Parameters.AddWithValue("@rem_closed", config.IsNull(objKO.rem_closed, "").Trim)
        comm.Parameters.AddWithValue("@rem_cancel", config.IsNull(objKO.rem_cancel, "").Trim)
        comm.Parameters.AddWithValue("@koclosed_final", config.IsNull(IIf(objKO.koclosed_final, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@koclosed_final_date", config.IsNull(objKO.koclosed_final_date, "").Trim)
        comm.Parameters.AddWithValue("@rem_closed_final", config.IsNull(objKO.rem_closed_final, "").Trim)
        comm.Parameters.AddWithValue("@adjustment", config.IsNull(objKO.adjustment, "").Trim)
        comm.Parameters.AddWithValue("@roll_kgs_std", config.IsNull(objKO.roll_kgs_std, 0).ToString)
        comm.Parameters.AddWithValue("@df_batch_kgs", config.IsNull(objKO.df_batch_kgs, 0).ToString)
        comm.Parameters.AddWithValue("@daily_capacity_kg", config.IsNull(objKO.daily_capacity_kg, 0).ToString)
        comm.Parameters.AddWithValue("@qty", config.IsNull(objKO.qty, 0).ToString)
        comm.Parameters.AddWithValue("@steam_instruction", config.IsNull(objKO.steam_instruction, "").ToString)
        comm.Parameters.AddWithValue("@knit_loss_perc", config.IsNull(objKO.knit_loss_perc, "").ToString)
        comm.Parameters.AddWithValue("@dyeding_loss_perc", config.IsNull(objKO.dyeding_loss_perc, "").ToString)

        comm.Parameters.AddWithValue("@design_cross", config.IsNull(objKO.design_cross, "").ToString)
        comm.Parameters.AddWithValue("@production_order_no_cross", config.IsNull(objKO.production_order_no_cross, "").ToString)
        comm.Parameters.AddWithValue("@production_order_id", config.IsNull(objKO.production_order_id, 0))
        comm.Parameters.AddWithValue("@total_production_lots", config.IsNull(objKO.total_production_lots, 0))
        comm.Parameters.AddWithValue("@ko_mtl_warehouse_id", objKO.ko_mtl_warehouse_id)
        comm.Parameters.AddWithValue("@logempcd", logempcd)

        Dim strSQL As String = config.BuildSQL(comm)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            If dt.Rows.Count > 0 Then objKO.kono = dt.Rows(0)("kono")
            If dt.Rows.Count > 0 Then objKO.production_order_id = dt.Rows(0)("production_order_id")
            If dt.Rows.Count > 0 Then objKO.id_ko_hist = dt.Rows(0)("id_ko_hist")
        Catch ex As Exception
            errmsg = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        'Dim i As Integer
        Dim j As Integer
        comm.CommandText = "P_KO_PKG_delete_production_order_lines"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@mfg_production_order_lines_id", .Item(j)("mfg_production_order_lines_id"))
                comm.CommandTimeout = 360
            End With
            Dim dac_del = New SqlDataAdapter(comm)
            Dim dtc_del = New DataTable
            Try
                dac_del.Fill(dtc_del)
            Catch ex As Exception
                errmsg = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
        Next

        comm.CommandText = "P_KO_PKG_update_production_order_lines"
        For j = 0 To DTC.Rows.Count - 1
            With DTC
                If DTC.Rows(j).RowState <> DataRowState.Deleted Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@mfg_production_order_lines_id", .Rows(j)("mfg_production_order_lines_id"))
                    comm.Parameters.AddWithValue("@production_order_id", objKO.production_order_id)
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", .Rows(j)("mtl_warehouse_id"))
                    comm.Parameters.AddWithValue("@item_id", .Rows(j)("item_id"))
                    comm.Parameters.AddWithValue("@line_type", .Rows(j)("line_type"))
                    comm.Parameters.AddWithValue("@plan_qty", .Rows(j)("plan_qty"))
                    comm.Parameters.AddWithValue("@actual_qty", .Rows(j)("actual_qty"))
                    comm.Parameters.AddWithValue("@uom_id", .Rows(j)("uom_id"))
                    comm.Parameters.AddWithValue("@creation_date", .Rows(j)("creation_date"))
                    comm.Parameters.AddWithValue("@created_by", .Rows(j)("created_by"))
                    comm.Parameters.AddWithValue("@last_modified_date", .Rows(j)("last_modified_date"))
                    comm.Parameters.AddWithValue("@last_modified_by", logempcd)
                    comm.Parameters.AddWithValue("@source_subinventory_id", .Rows(j)("source_subinventory_id"))
                    comm.Parameters.AddWithValue("@bom_header_id", .Rows(j)("bom_header_id"))
                    comm.Parameters.AddWithValue("@bom_line_id", .Rows(j)("bom_line_id"))
                    comm.Parameters.AddWithValue("@id_ko_hist", objKO.id_ko_hist)
                    comm.Parameters.AddWithValue("@mfg_production_steps_id", .Rows(j)("mfg_production_steps_id")) ' Add by Neung 20191112
                    comm.CommandTimeout = 360

                    Dim dac_add = New SqlDataAdapter(comm)
                    Dim dtc_add = New DataTable
                    Try
                        dac_add.Fill(dtc_add)
                    Catch ex As Exception
                        errmsg = ex.Message
                        tran.Rollback()
                        conn.Close()
                        Return False
                    End Try
                End If
            End With
        Next

        comm.CommandText = "dbo.P_KO_PKG_update_final"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@kono", objKO.kono)
        da = New SqlDataAdapter(comm)
        dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            errmsg = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Public Function ProductionOrderLinesDelete(ByVal Int64mfg_production_order_lines_id As Nullable(Of Int64), ByRef errmsg As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_order_lines_delete"

        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mfg_production_order_lines_id", Int64mfg_production_order_lines_id)
        comm.CommandTimeout = 360

        Dim dac_del = New SqlDataAdapter(comm)
        Dim dtc_del = New DataTable
        Try
            dac_del.Fill(dtc_del)
        Catch ex As Exception
            errmsg = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
            Exit Function
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Public Function ValidateDesignNoNew(ByVal design_no As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_bom_form_pkg_validate_yarnchange_item"    'Append By Sitthana 23/12/2017
        comm.Parameters.AddWithValue("@itcd", design_no)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOBOMSelect(ByVal strKONo As String, ByVal strDesignNo As String, ByVal strBOM As String, ByVal SingleQty As Single, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_yarnchangedet_select"
        comm.Parameters.AddWithValue("@kono", strKONo)
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@ynchgcd", strBOM)
        comm.Parameters.AddWithValue("@Qty", SingleQty)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetKOProLineSelect(ByVal strKONo As String, ByVal strDesignNo As String, ByVal strBOM As String, ByVal SingleQty As Single, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_production_order_lines_select_yarnchange"
        comm.Parameters.AddWithValue("@kono", strKONo)
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@ynchgcd", strBOM)
        comm.Parameters.AddWithValue("@qty", SingleQty)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function


    Public Function KOSchedulePlanSelect(ByVal strKONo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_select"
        comm.Parameters.AddWithValue("@code", strKONo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOSchedulePlanHistory(ByVal strKONo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_hist"
        comm.Parameters.AddWithValue("@code", strKONo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOSchedulePlanUpdate(ByVal koSchedulePlan As KOSchedulePlan, ByRef msgerr As String, ByVal clsuser As classUserInfo) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_schedule_plan_update"

        With koSchedulePlan
            comm.Parameters.AddWithValue("@id", .id.ToString)
            comm.Parameters.AddWithValue("@code", .code.Trim)
            comm.Parameters.AddWithValue("@name_en", .name_en.Trim)
            comm.Parameters.AddWithValue("@name_th", .name_th.Trim)
            comm.Parameters.AddWithValue("@active", IIf(.active, "1", "0"))
            comm.Parameters.AddWithValue("@remark", .remark.Trim)
            comm.Parameters.AddWithValue("@create_by", .create_by.Trim)
            comm.Parameters.AddWithValue("@create_date", .create_date.Trim)
            comm.Parameters.AddWithValue("@create_time", .create_time.Trim)
            comm.Parameters.AddWithValue("@mcno", .mcno.Trim)
            comm.Parameters.AddWithValue("@gwth", .gwth.Trim)
            comm.Parameters.AddWithValue("@id_yarnchange", .id_yarnchange.ToString)
            comm.Parameters.AddWithValue("@kgs", .kgs.ToString)
            comm.Parameters.AddWithValue("@kstartdt", .kstartdt.Trim)
            comm.Parameters.AddWithValue("@kstarttime", .kstarttime.Trim)
            comm.Parameters.AddWithValue("@kenddt", .kenddt.Trim)
            comm.Parameters.AddWithValue("@kendtime", .kendtime.Trim)
            comm.Parameters.AddWithValue("@adjustment", .adjustment.Trim)
            comm.Parameters.AddWithValue("@roll_kgs_std", .roll_kgs_std)
            comm.Parameters.AddWithValue("@df_batch_kgs", .df_batch_kgs)
            comm.Parameters.AddWithValue("@daily_capacity", .daily_capacity)
            comm.Parameters.AddWithValue("@loss_percent", .loss_percent)
            comm.Parameters.AddWithValue("@approved", .approved)
            comm.Parameters.AddWithValue("@schedule_remark", .schedule_remark)
            comm.Parameters.AddWithValue("@logempcd", clsuser.UserID)
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

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
        'da.Fill(dt)

        'If dt.Rows.Count > 0 Then
        '    Return True
        'Else
        '    Return False
        'End If
    End Function

    'Machine
    Public Function getMachineInfo(ByVal pMCNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_PKG_select_machine_info"
        comm.Parameters.AddWithValue("@p_mcno", pMCNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function MachineCapacitySelect(ByVal strMCNo As String, strDesignGroup As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_machine_capacity_select"
        comm.Parameters.AddWithValue("@machine_code", strMCNo)
        comm.Parameters.AddWithValue("@design_group", strDesignGroup)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function MachineCapacityUpdate(ByVal dt As DataTable) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)

        For Each dr As DataRow In dt.Rows
            If IsNumeric(dr("id")) And IsNumeric(dr("monthly_capacity")) Then
                Dim comm As New SqlCommand("", conn)
                comm.CommandType = CommandType.StoredProcedure
                comm.CommandText = "p_machine_capacity_update"
                comm.Parameters.AddWithValue("@id", dr("id"))
                comm.Parameters.AddWithValue("@monthly_capacity", dr("monthly_capacity"))
                comm.Parameters.AddWithValue("@remark", (New clsConfig()).IsNull(dr("remark"), ""))

                Dim da As New SqlDataAdapter(comm)
                Dim dt2 As New DataTable
                da.Fill(dt2)

                If dt2.Rows.Count = 0 Then Return False
            Else
                Return False
            End If
        Next

        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function YarnChangeSelect(ByVal id_yarnchange As Nullable(Of Int32), ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarnchange_select"
        comm.Parameters.AddWithValue("@id_yarnchange", id_yarnchange)
        comm.Parameters.AddWithValue("@design_no", "")
        comm.Parameters.AddWithValue("@ynchgcd", "")
        comm.Parameters.AddWithValue("@bom_usage_code", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnChangeSelectNew(ByVal id_yarnchange As Nullable(Of Int32), ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_yarnchange_select"     'Comment By Sitthana 22/12/2017
        comm.CommandText = "p_bom_form_pkg_select_yarnchange"      'Append By Sitthana 22/12/2017
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@id_yarnchange", id_yarnchange)
        comm.Parameters.AddWithValue("@design_no", "")
        comm.Parameters.AddWithValue("@ynchgcd", "")
        comm.Parameters.AddWithValue("@bom_usage_code", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnChangeCopy(ByVal id_yarnchange As Nullable(Of Int32), ByVal bom_usage_code As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarnchange_copy"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@id_yarnchange", id_yarnchange)
        comm.Parameters.AddWithValue("@bom_usage_code", bom_usage_code)
        comm.Parameters.AddWithValue("@log_empcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnChangeCopyNew(ByVal id_yarnchange As Nullable(Of Int32), ByVal bom_usage_code As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_yarnchange_copy"                 'Comment By Sitthana 22/12/2017
        comm.CommandText = "p_bom_form_pkg_copy_yarnchange"     'Append By Sitthana 22/12/2017
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@id_yarnchange", id_yarnchange)
        comm.Parameters.AddWithValue("@bom_usage_code", bom_usage_code)
        comm.Parameters.AddWithValue("@log_empcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnChangeDetDelete(ByVal id_yarnchangedet As Nullable(Of Int32), ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarnchangedet_delete"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@id_yarnchangedet", id_yarnchangedet)
        comm.Parameters.AddWithValue("@log_empcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnChangeDetDeleteNew(ByVal id_yarnchangedet As Integer, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        '' comm.CommandText = "p_yarnchangedet_delete"                 'Comment By Sitthana 22/12/2017
        comm.CommandText = "p_bom_form_pkg_delete_yarnchangedet"    'Append By Sitthana 22/12/2017
        comm.Parameters.AddWithValue("@id_yarnchangedet", id_yarnchangedet)
        comm.Parameters.AddWithValue("@log_empcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnChangeUpdate(ByRef obj As YarnChange, ByVal dt As DataTable, ByVal logempcd As String, ByRef errmsg As String) As Boolean

        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_yarnchange_update"
        With obj
            comm.Parameters.AddWithValue("@design_no", config.IsNull(obj.design_no, "").Trim)
            comm.Parameters.AddWithValue("@ynchgdt", config.IsNull(obj.ynchgdt, Now))
            comm.Parameters.AddWithValue("@ynchgcd", config.IsNull(obj.ynchgcd, "").Trim)
            comm.Parameters.AddWithValue("@remarke", config.IsNull(obj.remarke, "").Trim)
            comm.Parameters.AddWithValue("@id_yarnchange", config.IsNull(obj.id_yarnchange, 0).ToString)
            comm.Parameters.AddWithValue("@bom_usage_code", config.IsNull(obj.bom_usage_code, "").Trim)
            comm.Parameters.AddWithValue("@log_empcd", logempcd)
            comm.Parameters.AddWithValue("@bom_active", IIf(obj.bom_active, 1, 0))
            comm.Parameters.AddWithValue("@bom_approved", IIf(obj.bom_approved, 1, 0))
            comm.Parameters.AddWithValue("@bom_remarks", config.IsNull(obj.bom_remarks, ""))
            comm.Parameters.AddWithValue("@design_ver", obj.design_ver)
        End With

        Dim sql As String = config.BuildSQL(comm)
        Dim da As New SqlDataAdapter(comm)
        Dim dt2 As New DataTable
        Try
            da.Fill(dt2)
            If dt.Rows.Count > 0 Then
                If obj.id_yarnchange = 0 Then
                    obj.id_yarnchange = Val(dt2.Rows(0)("id_yarnchange"))
                    obj.ynchgcd = dt2.Rows(0)("ynchgcd")
                End If
            Else
                errmsg = "Unknown Error"

                Return False
            End If
        Catch ex As Exception
            errmsg = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try


        comm.CommandText = "p_yarnchangedet_update"

        For i As Integer = 0 To dt.Rows.Count - 1
            With dt.Rows(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@design_no", config.IsNull(obj.design_no, "").Trim)
                comm.Parameters.AddWithValue("@ynchgcd", config.IsNull(obj.ynchgcd, "").Trim)
                comm.Parameters.AddWithValue("@yarnusage", config.IsNull(.Item("yarnusage"), "").Trim)
                comm.Parameters.AddWithValue("@itcd", config.IsNull(.Item("itcd"), "").Trim)
                comm.Parameters.AddWithValue("@itdesc", config.IsNull(.Item("itdesc"), "").Trim)
                comm.Parameters.AddWithValue("@ynmerge", config.IsNull(.Item("ynmerge"), "").Trim)
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@ynperc", config.IsNull(.Item("ynperc"), 0).ToString)
                comm.Parameters.AddWithValue("@id_yarnchange", config.IsNull(obj.id_yarnchange, 0).ToString)
                comm.Parameters.AddWithValue("@id_yarnchangedet", config.IsNull(.Item("id_yarnchangedet"), 0).ToString)
                comm.Parameters.AddWithValue("@bom_usage_code", config.IsNull(obj.bom_usage_code, "").Trim)
                comm.Parameters.AddWithValue("@log_empcd", logempcd)

                da = New SqlDataAdapter(comm)
                dt2 = New DataTable
                Try
                    da.Fill(dt2)
                Catch ex As Exception
                    errmsg = ex.Message
                    tran.Rollback()
                    conn.Close()
                    Return False
                End Try
            End With
        Next

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Public Function YarnChangeUpdateNew(ByRef obj As YarnChange, ByVal dt As DataTable, ByVal dv_del As DataView, ByVal logempcd As String, ByRef errmsg As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'comm.CommandText = "p_yarnchange_update "      'Comment By Sitthana 22/12/2017
        comm.CommandText = "p_bom_form_pkg_update_yarnchange"      'Append By Sitthana 22/12/2017
        With obj
            comm.Parameters.AddWithValue("@design_no", config.IsNull(obj.design_no, "").Trim)
            comm.Parameters.AddWithValue("@ynchgdt", config.IsNull(obj.ynchgdt, Now))
            comm.Parameters.AddWithValue("@ynchgcd", config.IsNull(obj.ynchgcd, "").Trim)
            comm.Parameters.AddWithValue("@remarke", config.IsNull(obj.remarke, "").Trim)
            comm.Parameters.AddWithValue("@id_yarnchange", config.IsNull(obj.id_yarnchange, 0).ToString)
            comm.Parameters.AddWithValue("@bom_usage_code", config.IsNull(obj.bom_usage_code, "").Trim)
            comm.Parameters.AddWithValue("@log_empcd", logempcd)
            comm.Parameters.AddWithValue("@bom_active", IIf(obj.bom_active, 1, 0))
            comm.Parameters.AddWithValue("@bom_approved", IIf(obj.bom_approved, 1, 0))
            comm.Parameters.AddWithValue("@bom_remarks", config.IsNull(obj.bom_remarks, ""))
            comm.Parameters.AddWithValue("@design_ver", config.IsNull(obj.design_ver, 0).ToString) 'Change id_yarnchange -> design_ver
            comm.Parameters.AddWithValue("@color_id", obj.color_id)  'Append By Sitthana 22/01/2017
            comm.Parameters.AddWithValue("@required_qty", config.IsNull(obj.required_qty, 0))  'Append By Sitthana 16/01/2018
            comm.Parameters.AddWithValue("@bom_uom_id", config.IsNull(obj.bom_uom_id, 0))  'Append By Sitthana 16/01/2018
            comm.Parameters.AddWithValue("@uom", config.IsNull(obj.uom, "").Trim)  'Append By Sitthana 16/01/2018
        End With
        'config.IsNull(obj.color_id, "").Trim) 
        Dim sql As String = config.BuildSQL(comm)
        Dim da As New SqlDataAdapter(comm)
        Dim dt2 As New DataTable
        Try
            da.Fill(dt2)
            If dt.Rows.Count > 0 Then
                If obj.id_yarnchange = 0 Then
                    obj.id_yarnchange = Val(dt2.Rows(0)("id_yarnchange"))
                    obj.ynchgcd = dt2.Rows(0)("ynchgcd")
                End If
            Else
                errmsg = "Unknown Error"
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End If
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325

            errmsg = ex.Message
            Return False
        End Try


        'comm.CommandText = "p_yarnchangedet_update"     'Comment By Sitthana 22/12/2017
        comm.CommandText = "p_bom_form_pkg_update_yarnchangedet"     'Append By Sitthana 22/12/2017

        For i As Integer = 0 To dt.Rows.Count - 1
            With dt.Rows(i)
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@design_no", config.IsNull(obj.design_no, "").Trim)
                    comm.Parameters.AddWithValue("@ynchgcd", config.IsNull(obj.ynchgcd, "").Trim)
                    comm.Parameters.AddWithValue("@yarnusage", config.IsNull(.Item("yarnusage"), "").Trim)
                    comm.Parameters.AddWithValue("@itcd", config.IsNull(.Item("itcd"), "").Trim)
                    comm.Parameters.AddWithValue("@itdesc", config.IsNull(.Item("itdesc"), "").Trim)
                    comm.Parameters.AddWithValue("@merge", config.IsNull(.Item("ynmerge"), "").Trim)
                    comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item("suppcd"), "").Trim)
                    comm.Parameters.AddWithValue("@ynperc", config.IsNull(.Item("ynperc"), 0).ToString)
                    comm.Parameters.AddWithValue("@id_yarnchange", config.IsNull(obj.id_yarnchange, 0).ToString)
                    comm.Parameters.AddWithValue("@id_yarnchangedet", config.IsNull(.Item("id_yarnchangedet"), 0).ToString)
                    comm.Parameters.AddWithValue("@bom_usage_code", config.IsNull(obj.bom_usage_code, "").Trim)
                    comm.Parameters.AddWithValue("@log_empcd", logempcd)
                    comm.Parameters.AddWithValue("@required_qty", config.IsNull(obj.required_qty, 0))  'config.IsNull(.Item("required_qty"), 0))  'Append By Sitthana 16/01/2018
                    comm.Parameters.AddWithValue("@bom_uom_id", config.IsNull(.Item("rqdet_bom_uom_id"), 0))  'Append By Sitthana 16/01/2018
                    comm.Parameters.AddWithValue("@uom", config.IsNull(.Item("rqdet_bom_uom_id"), ""))  'Append By Sitthana 16/01/2018

                    da = New SqlDataAdapter(comm)
                    dt2 = New DataTable
                    Try
                        da.Fill(dt2)
                    Catch ex As Exception
                        errmsg = ex.Message
                        tran.Rollback()
                        conn.Close()  'Sitthana 20190325
                        Return False
                    End Try
                End If
            End With
        Next

        'comm.CommandText = "p_yarnchangedet_delete"                'Comment By Sitthana 22/12/2017
        comm.CommandText = "p_bom_form_pkg_delete_yarnchangedet"    'Append By Sitthana 22/12/2017
        For i = 0 To dv_del.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@id_yarnchangedet", dv_del(i)("id_yarnchangedet"))
            comm.Parameters.AddWithValue("@log_empcd", logempcd)
            da = New SqlDataAdapter(comm)
            dt2 = New DataTable
            Try
                da.Fill(dt2)
            Catch ex As Exception
                errmsg = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function YarnChangeSelectBOM(ByVal id_yarnchange As Integer, ByVal StrDesignNo As String, ByVal Strynchgcd As String, ByVal Strbom_usage_code As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarnchange_select_bom"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@id_yarnchange", id_yarnchange)
        comm.Parameters.AddWithValue("@design_no", StrDesignNo)
        comm.Parameters.AddWithValue("@ynchgcd", Strynchgcd)
        comm.Parameters.AddWithValue("@bom_usage_code", Strbom_usage_code)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function YarnChangeCancel(ByVal obj As YarnChange, ByVal dt As DataTable, ByVal logempcd As String, ByRef errmsg As String) As Boolean

        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)

        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction

        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_yarnchange_delete"
        comm.Parameters.Clear()
        With obj
            comm.Parameters.AddWithValue("@id_yarnchange", obj.id_yarnchange)
            comm.Parameters.AddWithValue("@log_empcd", logempcd)
        End With

        Dim da As New SqlDataAdapter(comm)
        Dim dt1 As New DataTable
        Try
            da.Fill(dt1)
        Catch ex As Exception
            errmsg = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True

    End Function

    Public Function YarnChangeCancelNew(ByVal obj As YarnChange, ByVal dt As DataTable, ByVal logempcd As String, ByRef errmsg As String) As Boolean

        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)

        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction

        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'comm.CommandText = "p_yarnchange_delete"               'Comment By Sitthana 22/12/2017
        comm.CommandText = "p_bom_form_pkg_delete_yarnchange"   'Append By Sitthana 22/12/2017
        comm.Parameters.Clear()
        With obj
            comm.Parameters.AddWithValue("@id_yarnchange", obj.id_yarnchange)
            comm.Parameters.AddWithValue("@log_empcd", logempcd)
        End With

        Dim da As New SqlDataAdapter(comm)
        Dim dt1 As New DataTable
        Try
            da.Fill(dt1)
        Catch ex As Exception
            errmsg = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False

        End Try


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True

    End Function

    Public Function KOYarnReturnSelect(ByVal strKONo As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_yarn_return_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@kono", strKONo)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function KOYarnReturnUpdate(ByVal objKO As KO, ByVal logempcd As String, ByRef errmsg As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_yarn_return_update"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@kono", config.IsNull(objKO.kono, "").Trim)
        comm.Parameters.AddWithValue("@koclosed_final", config.IsNull(IIf(objKO.koclosed_final, 1, 0), 0).ToString)
        comm.Parameters.AddWithValue("@koclosed_final_date", config.IsNull(objKO.koclosed_final_date, "").Trim)
        comm.Parameters.AddWithValue("@rem_closed_final", config.IsNull(objKO.rem_closed_final, "").Trim)
        comm.Parameters.AddWithValue("@logempcd", logempcd)

        Dim strSQL As String = config.BuildSQL(comm)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
            If dt.Rows.Count > 0 Then errmsg = dt.Rows(0)("kono")
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            errmsg = ex.Message
            Return False
        End Try

        Return True
    End Function


    Public Function TransferYarn(ByVal konofr As String, ByVal konoto As String, ByVal logempcd As String) As DataSet
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_transfer_yarn"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@konofr", konofr)
        comm.Parameters.AddWithValue("@konoto", konoto)
        comm.Parameters.AddWithValue("@logempcd", logempcd)

        Dim strSQL As String = config.BuildSQL(comm)
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        'Dim dt As New DataTable
        Try
            da.Fill(ds)
            conn.Close()  'Sitthana 20190325
            Return ds
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Throw ex
        End Try
    End Function
    Public Function ValidateDesignNo(ByVal Design_no As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarnchange_validate_item"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@itcd", Design_no)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getBomFormItemUom(ByVal itcd As String) As DataTable
        'Create By : Sitthana 17/01/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_bom_form_pkg_get_item_uom"
        '  comm.Parameters.AddWithValue("@design_no", design_no)
        comm.Parameters.AddWithValue("@itcd", itcd)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function getSuppcd(ByVal pItCd As String) As DataTable
        'Create By : Sitthana 22/09/2018
        Dim suppcd As String = ""

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_get_yarn_suppcd"
        comm.Parameters.AddWithValue("@p_itcd", pItCd)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        Return dt
    End Function
    Public Function Validateyarnchange(ByVal design_no As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarnchange_validate_item_for_ko"
        comm.Parameters.AddWithValue("@itcd", design_no)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetKgOnBeam(ByVal StrSono As String, ByVal Strproduction_order_no As String, ByVal StrItcd As String, ByVal int_set_qty As Nullable(Of Integer)) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_get_kg_on_beam"
        comm.Parameters.AddWithValue("@sono", StrSono)
        comm.Parameters.AddWithValue("@production_order_no", Strproduction_order_no)
        comm.Parameters.AddWithValue("@itcd", StrItcd)
        comm.Parameters.AddWithValue("@set_qty", int_set_qty)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'EDIT BY NEUNG 16/01/2015
    Public Function Getkenddt(ByVal Strkono As String, ByVal Strkstartdt As String, ByVal Strkenddt As String, ByVal Intdaily_capacity_kg As Nullable(Of Integer), ByVal IntSetmc As Nullable(Of Integer), ByVal IntKgs As Nullable(Of Integer)) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_gen_kenddt"
        comm.Parameters.AddWithValue("@kono", Strkono)
        comm.Parameters.AddWithValue("@kstartdt", Strkstartdt)
        comm.Parameters.AddWithValue("@kenddt", Strkenddt)
        comm.Parameters.AddWithValue("@daily_capacity_kg", Intdaily_capacity_kg)
        comm.Parameters.AddWithValue("@setmc", IntSetmc)
        comm.Parameters.AddWithValue("@kgs", IntKgs)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        Return dt.Rows(0).Item("enddt")
    End Function

    Public Function AutoGenKendDt(ByVal Strkstartdate As String, ByVal Strkenddate As String, ByVal Strsetmc As Integer, ByVal Strdaily_capacity_kg As Integer) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_autogen_kenddt"
        comm.Parameters.AddWithValue("@kstartdt", Strkstartdate)
        comm.Parameters.AddWithValue("@kenddt", Strkenddate)
        comm.Parameters.AddWithValue("@setmc", Strsetmc)
        comm.Parameters.AddWithValue("@daily_capacity_kg", Strdaily_capacity_kg)


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt



    End Function

    Public Function PrintProductIssueTemplate(ByVal Strkono As String)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "poc.dbo.p_iss_product_issues_print_ko"
        comm.Parameters.AddWithValue("@p_kono", Strkono)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        Return dt
    End Function

    Public Function CANCELPRODNo(ByRef KOHeader As KO, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_KO_PKG_cancel_ko"
        j = 0
        With KOHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@kono", KOHeader.kono)
            comm.Parameters.AddWithValue("@kodt", KOHeader.kodt)
            comm.Parameters.AddWithValue("@canceldt", KOHeader.canceldt)
            comm.Parameters.AddWithValue("@rem_cancel", KOHeader.rem_cancel)
            comm.Parameters.AddWithValue("@logempcd", clsUSER.UserID)
        End With
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            KOHeader.Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function UnCanceledPRODNo(ByRef KOHeader As KO, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_KO_PKG_uncanceled_ko"
        j = 0
        With KOHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@kono", KOHeader.kono)
            comm.Parameters.AddWithValue("@kodt", KOHeader.kodt)
            comm.Parameters.AddWithValue("@canceldt", KOHeader.canceldt)
            comm.Parameters.AddWithValue("@rem_cancel", KOHeader.rem_cancel)
            comm.Parameters.AddWithValue("@logempcd", clsUSER.UserID)
        End With
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            KOHeader.Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function ClosedPRODNo(ByRef KOHeader As KO, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_KO_PKG_closed_ko"
        j = 0
        With KOHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@kono", KOHeader.kono)
            comm.Parameters.AddWithValue("@kodt", KOHeader.kodt)
            comm.Parameters.AddWithValue("@koclosedt", KOHeader.koclosedt)
            comm.Parameters.AddWithValue("@rem_closed", KOHeader.rem_closed)
            comm.Parameters.AddWithValue("@logempcd", clsUSER.UserID)
        End With
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            KOHeader.Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function UNClosedPRODNo(ByRef KOHeader As KO, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_KO_PKG_unclosed_ko"
        j = 0
        With KOHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@kono", KOHeader.kono)
            comm.Parameters.AddWithValue("@kodt", KOHeader.kodt)
            comm.Parameters.AddWithValue("@koclosedt", KOHeader.koclosedt)
            comm.Parameters.AddWithValue("@rem_closed", KOHeader.rem_closed)
            comm.Parameters.AddWithValue("@logempcd", clsUSER.UserID)
        End With
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            KOHeader.Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    'Delivered
    Public Function DeliveredPRODNo(ByRef KOHeader As KO, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_KO_PKG_delivered_ko"
        j = 0
        With KOHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@kono", KOHeader.kono)
            comm.Parameters.AddWithValue("@kodt", KOHeader.kodt)
            comm.Parameters.AddWithValue("@koclosed_final_date", KOHeader.koclosed_final_date)
            comm.Parameters.AddWithValue("@rem_closed_final", KOHeader.rem_closed_final)
            comm.Parameters.AddWithValue("@logempcd", clsUSER.UserID)
        End With
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            KOHeader.Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    'Delivered
    Public Function UNDeliveredPRODNo(ByRef KOHeader As KO, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        Dim Action As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "P_KO_PKG_undelivered_ko"
        j = 0
        With KOHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@kono", KOHeader.kono)
            comm.Parameters.AddWithValue("@kodt", KOHeader.kodt)
            comm.Parameters.AddWithValue("@koclosed_final_date", KOHeader.koclosed_final_date)
            comm.Parameters.AddWithValue("@rem_closed_final", KOHeader.rem_closed_final)
            comm.Parameters.AddWithValue("@logempcd", clsUSER.UserID)
        End With
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            KOHeader.Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    Public Function getRepeatPerRowFromPDR(pPdrNo As String) As Single
        'Create By : Sitthana 22 / 09 / 2018 
        'Copy From GMK 20190110
        Dim suppcd As String = ""

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_development_requirement_get_pdr_repeat_per_row"
        comm.Parameters.AddWithValue("@p_pdr_no", pPdrNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            getRepeatPerRowFromPDR = dt.Rows(0)("repeat_per_roll")
        Else
            getRepeatPerRowFromPDR = 0
        End If
    End Function
    Public Function getPDRDetail(pPdrNo As String) As DataTable
        'Create By : Sitthana 14/02/2019 

        Dim suppcd As String = ""

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_development_requirement_get_pdr_detail"
        comm.Parameters.AddWithValue("@p_pdr_new_develop_req_id", pPdrNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        ''If dt.Rows.Count > 0 Then
        ''    getRepeatPerRowFromPDR = dt.Rows(0)("repeat_per_roll")
        ''Else
        ''    getRepeatPerRowFromPDR = 0
        ''End If
        Return dt
    End Function
    Public Function DevelopmentRequirementSelectBOM(ByVal StrDesignNo As String, ByVal Strynchgcd As String) As DataTable
        'Copy From GMK 20190110
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_development_requirement_select_bom"
        comm.Parameters.AddWithValue("@design_no", StrDesignNo)
        comm.Parameters.AddWithValue("@ynchgcd", Strynchgcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetDesignBOM(strDesignNo As String, strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_get_yarnchange"
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function selectDesignByBeam(ByVal pItcdList As String _
                                       , pActived As String _
                                       , pApproved As String
                                         ) As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_BOM_PKG_select_bom_by_beam"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_itcd_list", pItcdList)
        comm.Parameters.AddWithValue("@p_bom_usage_code", "")
        comm.Parameters.AddWithValue("@p_actived", pActived)
        comm.Parameters.AddWithValue("@p_approved", pApproved)

        'Old Stored Procedure
        'comm.CommandText = "P_BOM_PKG_rep_Find_Design_From_Yarn"  'Old Stored Procedure
        'comm.Parameters.AddWithValue("@p_yarn_code1", pYarnCodeNo1)
        'comm.Parameters.AddWithValue("@p_yarn_code2", pYarnCodeNo2)
        'comm.Parameters.AddWithValue("@p_yarn_code3", pYarnCodeNo3)
        'comm.Parameters.AddWithValue("@p_yarn_code4", pYarnCodeNo4)
        'comm.Parameters.AddWithValue("@p_yarn_code5", pYarnCodeNo5)


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function selectDesignByYarn(ByVal pItcdList As String _
                                     , pActived As String _
                                     , pApproved As String
                                       ) As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_BOM_PKG_select_bom_by_yarn"
        comm.Parameters.AddWithValue("@p_itcd_list", pItcdList)
        comm.Parameters.AddWithValue("@p_bom_usage_code", "")
        comm.Parameters.AddWithValue("@p_actived", pActived)
        comm.Parameters.AddWithValue("@p_approved", pApproved)

        'Old Stored Procedure
        'comm.CommandText = "P_BOM_PKG_rep_Find_Design_From_Yarn"  'Old Stored Procedure
        'comm.Parameters.AddWithValue("@p_yarn_code1", pYarnCodeNo1)
        'comm.Parameters.AddWithValue("@p_yarn_code2", pYarnCodeNo2)
        'comm.Parameters.AddWithValue("@p_yarn_code3", pYarnCodeNo3)
        'comm.Parameters.AddWithValue("@p_yarn_code4", pYarnCodeNo4)
        'comm.Parameters.AddWithValue("@p_yarn_code5", pYarnCodeNo5)


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function selectDesignByDesignNo(ByVal pItcdList As String _
                                         , pActived As String _
                                         , pApproved As String
                                         ) As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_BOM_PKG_select_bom_by_design"
        comm.Parameters.AddWithValue("@p_itcd_list", pItcdList)
        comm.Parameters.AddWithValue("@p_bom_usage_code", "")
        comm.Parameters.AddWithValue("@p_actived", pActived)
        comm.Parameters.AddWithValue("@p_approved", pApproved)

        'Old Stored Procedure
        'comm.CommandText = "P_BOM_PKG_rep_Find_Design_From_Yarn"  'Old Stored Procedure
        'comm.Parameters.AddWithValue("@p_yarn_code1", pYarnCodeNo1)
        'comm.Parameters.AddWithValue("@p_yarn_code2", pYarnCodeNo2)
        'comm.Parameters.AddWithValue("@p_yarn_code3", pYarnCodeNo3)
        'comm.Parameters.AddWithValue("@p_yarn_code4", pYarnCodeNo4)
        'comm.Parameters.AddWithValue("@p_yarn_code5", pYarnCodeNo5)


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function selectItemByItGrp(ByVal pItNatureCd As String _
                                    , ByVal pItGroupCd As String
                                      ) As DataTable
        'Writen By   : Sitthana Boonlom
        'Date Writen : 20200422
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_PKG_select_items_by_nature_group"
        comm.Parameters.AddWithValue("@p_itnaturecd", pItNatureCd)
        comm.Parameters.AddWithValue("@p_itgroupcd", pItGroupCd)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function selectDesignNo() As DataTable
        'Writen By   : Sitthana Boonlom
        'Date Writen : 20200422
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_MASTER_PKG_select_dm"

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function ValidateProductionLineID(ByVal KoNo As String, ByVal MfgProductionOrderLines As Int64) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_validate_mfg_production_order_lines_id"
        comm.Parameters.AddWithValue("@kono", KoNo)
        comm.Parameters.AddWithValue("@mfg_production_order_lines_id", MfgProductionOrderLines)
        comm.Parameters.Add("@pvalidate_line", SqlDbType.Bit)
        comm.Parameters("@pvalidate_line").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        Return comm.Parameters("@pvalidate_line").Value
    End Function

    Public Function CheckChangeBomItems(ByVal KoNo As String, ByVal MfgProductionOrderLines As Nullable(Of Int64), ByVal logempcd As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_KO_PKG_validate_can_change_bom_items"
        comm.Parameters.AddWithValue("@kono", KoNo)
        comm.Parameters.AddWithValue("@mfg_production_order_lines_id", (New clsConfig).IsNull(MfgProductionOrderLines, DBNull.Value))
        comm.Parameters.AddWithValue("@logempcd", logempcd)

        comm.Parameters.Add("@pcanchangeitems", SqlDbType.Bit)
        comm.Parameters("@pcanchangeitems").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return comm.Parameters("@pcanchangeitems").Value
    End Function

    Public Function DevelopmentRequirementSelectSoitm(ByVal StrSono As String) As DataTable '01/15/2025 John
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "[dbo].[p_development_requirement_select_soitm]"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_sono", StrSono)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt

    End Function
End Class
