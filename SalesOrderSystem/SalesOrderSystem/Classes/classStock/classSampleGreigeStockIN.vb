Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classSampleGreigeStockIN
    Public Structure DINHeader

        'strolls_d
        Dim h01_dinno As String
        Dim h02_dindt As Date
        Dim h03_doctyp As String
        Dim h04_dhcod As String
        Dim h05_dhdono As String
        Dim h06_dhdodt As String
        Dim h07_dfno As String
        Dim h08_dono As String
        Dim h09_dodt As Date
        Dim h10_design_no As String
        Dim h11_Gwth As String
        Dim h12_fwth As String
        Dim h13_lot As String
        Dim h14_yr As String
        Dim h15_sh As String
        Dim h16_col As String
        Dim h17_Gr As String
        Dim h18_mtkg As Double
        Dim h19_roll_no_d As String
        Dim h20_roll_no_g As String
        Dim h21_kg As Double
        Dim h22_mts As Double
        Dim h23_yds As Double
        Dim h24_sono As String
        Dim h25_nob As Double
        Dim h26_typ As String
        Dim h27_status As String
        Dim h28_outreqno As String
        Dim h29_outreqdt As Date
        Dim h30_mts_g As Double
        Dim h31_yds_g As Double
        Dim h32_allowmt As Double
        Dim h33_sonoid As String
        Dim h34_lotbatno As String
        Dim h35_sel As Boolean
        Dim h36_loc As String 'Same h01_cartno
        Dim h37_cost As Double 'Same h02_packno
        Dim h38_batch As String
        Dim h39_custcolor As String
        Dim h40_fload As Boolean
        Dim h41_cancel As Boolean
        Dim h42_dinno1 As String
        Dim h43_dinnot As String
        Dim h44_cost_d As Double
        Dim h45_unit As String
        Dim h46_roll_no_o As String
        Dim h47_roll_no_p As String
        Dim h48_roll_no_f As String
        Dim h49_rem_qc As String
        Dim h50_job_line_id As String
        Dim h51_fabric_cost As Double
        Dim h52_process_cost As Double
        Dim h53_process_loss_perc As Double
        Dim h54_other_cost As Double
        Dim h55_cost_per_unit As Double
    End Structure

    Public Function GetSampleStock(Optional ByVal StrDesignNo As String = Nothing,
                                          Optional ByVal StrRefdesno As String = Nothing,
                                          Optional ByVal StrLot As String = Nothing,
                                          Optional ByVal StrCol As String = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mfg_dout_sample_pkg_get_grid_stock"
        comm.Parameters.AddWithValue("@design_no", StrDesignNo)
        comm.Parameters.AddWithValue("@refdesno", StrRefdesno)
        comm.Parameters.AddWithValue("@lot", StrLot)
        comm.Parameters.AddWithValue("@col", StrCol)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.Connection.Close()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            MessageBox.Show(ex.Message, ex.GetType().ToString())
        End Try
        Return dt
    End Function

    Public Function GetDINReturn(ByVal strdinNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_get_greige_data"
        comm.Parameters.AddWithValue("@dinno", strdinNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDOutReturn(ByVal strOutNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_get_greige_out_data"
        comm.Parameters.AddWithValue("@outno", strOutNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SampleGreigeINSave(ByVal Din_header As DINHeader, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef DINno As String) As Boolean
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

        'Start Gen DIN No----------
        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_gen_dinno"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@checknew", "")
            comm.CommandTimeout = 360
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
        Din_header.h01_dinno = dt.Rows(0)("dinno").ToString.Trim

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_insert_sample_in"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                If CBool(DV_DTC_ADD.Item(j)("selected")) Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@dinno", Din_header.h01_dinno)
                    comm.Parameters.AddWithValue("@dindt", Din_header.h02_dindt)
                    comm.Parameters.AddWithValue("@doctyp", Din_header.h03_doctyp)
                    comm.Parameters.AddWithValue("@dhcod", Din_header.h04_dhcod)
                    comm.Parameters.AddWithValue("@dhdono", "")
                    comm.Parameters.AddWithValue("@dhdodt", "")
                    comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), Din_header.h07_dfno)) 'Keep Dyed out to D/F
                    comm.Parameters.AddWithValue("@dono", "")
                    comm.Parameters.AddWithValue("@dodt", "")
                    comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                    comm.Parameters.AddWithValue("@Gwth", "")
                    comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), 0))
                    comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), ""))
                    comm.Parameters.AddWithValue("@yr", "")
                    comm.Parameters.AddWithValue("@sh", "")
                    comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                    comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                    comm.Parameters.AddWithValue("@mtkg", 0)
                    comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                    comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_d"), "").trim) 'Old No
                    comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                    comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                    comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                    comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), ""))
                    comm.Parameters.AddWithValue("@nob", "")
                    comm.Parameters.AddWithValue("@typ", "")
                    comm.Parameters.AddWithValue("@status", "")
                    comm.Parameters.AddWithValue("@outreqno", "")
                    comm.Parameters.AddWithValue("@outreqdt", "")
                    comm.Parameters.AddWithValue("@mts_g", 0)
                    comm.Parameters.AddWithValue("@yds_g", 0)
                    comm.Parameters.AddWithValue("@allowmt", "")
                    comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), ""))
                    comm.Parameters.AddWithValue("@lotbatno", "")
                    comm.Parameters.AddWithValue("@sel", 0)
                    comm.Parameters.AddWithValue("@loc", "")
                    comm.Parameters.AddWithValue("@cost", 0.0)
                    comm.Parameters.AddWithValue("@batch", "")
                    comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                    comm.Parameters.AddWithValue("@fload", "")
                    comm.Parameters.AddWithValue("@dinno1", "")
                    comm.Parameters.AddWithValue("@dinnot", "")
                    comm.Parameters.AddWithValue("@cost_d", "")
                    comm.Parameters.AddWithValue("@unit", "")
                    comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), ""))
                    comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_d"), "")) 'Old No
                    comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_d"), "")) 'Old No
                    comm.Parameters.AddWithValue("@rem_qc", "")
                    comm.Parameters.AddWithValue("@job_line_id", "")
                    comm.Parameters.AddWithValue("@fabric_cost", 0.0)
                    comm.Parameters.AddWithValue("@process_cost", 0.0)
                    comm.Parameters.AddWithValue("@process_loss_perc", 0.0)
                    comm.Parameters.AddWithValue("@other_cost", 0.0)
                    comm.Parameters.AddWithValue("@cost_per_unit", 0.0)
                    comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(j)("mtl_warehouse_id")) '
                    comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(j)("mtl_subinventory_id"))
                    comm.Parameters.AddWithValue("@mtl_locations_id", .Item(j)("mtl_locations_id"))
                    comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                End If
                comm.CommandTimeout = 360
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_int = New SqlDataAdapter(comm)
            Dim dtc_int = New DataTable
            Try
                dac_int.Fill(dtc_int)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "ADD"

        Next
        'End Add Cartons----------

        'Start update Cartons----------

        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_update_sample_in"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("gwth"), ""))
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(j)("mtkg"), 0))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), "").trim)
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(j)("typ"), "").trim)
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(j)("status"), ""))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), ""))
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lotbatno"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0.0))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), ""))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), ""))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_p"), ""))
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), ""))
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0.0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0.0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0.0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(j)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(j)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(j)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                comm.CommandTimeout = 360
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "CHANGE"
        Next
        'End update Cartons----------

        'Start delete Cartons----------
        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_insert_backup_data"
        i = 0
        For i = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("gwth"), ""))
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(j)("mtkg"), 0))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), "").trim)
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(j)("typ"), "").trim)
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(j)("status"), ""))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), ""))
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0.0))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), ""))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), ""))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), ""))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_p"), ""))
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), ""))
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0.0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0.0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0.0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(j)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(j)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            End With

            Dim dap_add As New SqlDataAdapter(comm)
            Dim dtp_add As New DataTable
            Try
                dap_add.Fill(dtp_add)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False

            End Try

        Next

        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_delete_recode_data"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(j)("dinno"), "").Trim)
                comm.Parameters.AddWithValue("@dindt", config.IsNull(.Item(j)("dindt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), ""))
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), ""))
                comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(j)("dhdono"), ""))
                comm.Parameters.AddWithValue("@dhdodt", config.IsNull(.Item(j)("dhdodt"), ""))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").Trim)
                comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(j)("dono"), "").Trim)
                comm.Parameters.AddWithValue("@dodt", config.IsNull(.Item(j)("dodt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("gwth"), ""))
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(j)("fwth"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(j)("gr"), "").trim)
                comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(j)("mtkg"), 0))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(j)("roll_no_d"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), "").trim)
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(j)("typ"), "").trim)
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(j)("status"), ""))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), ""))
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(j)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(j)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(j)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(j)("lot"), "").Trim)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0.0))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(j)("batch"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(j)("custcolor"), "").trim)
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), ""))
                comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(j)("dinno1"), ""))
                comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(j)("dinnot"), ""))
                comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(j)("cost_d"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_p", config.IsNull(.Item(j)("roll_no_p"), ""))
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), ""))
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0.0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0.0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0.0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0.0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(j)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", .Item(j)("mtl_subinventory_id"))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                comm.CommandTimeout = 360
                '  comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            'Dim sql As String = config.BuildSQL(comm)
            Dim dac_del = New SqlDataAdapter(comm)
            Dim dtc_del = New DataTable
            Try
                dac_del.Fill(dtc_del)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try

            Action = "CHANGE"
        Next
        'End delete Cartons----------
        'Start Insert Action----------
        If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "DIN"
        With Din_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Din_header.h01_dinno)
            comm.Parameters.AddWithValue("@workdt", Now)
            comm.Parameters.AddWithValue("@doctyp", doctyp)
            comm.Parameters.AddWithValue("@worktyp", Action)
            comm.CommandTimeout = 360
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
        DINno = Din_header.h01_dinno
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

End Class
