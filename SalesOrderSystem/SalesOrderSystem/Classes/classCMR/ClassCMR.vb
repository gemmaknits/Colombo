Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class ClassCMR
    Dim clsConfig As New clsConfig

    Public Function getLookupValueIdByValCd(pLookupType As String, pLookupValuecode As String)
        'Sitthana 11/10/2018
        Dim LookupValueId As Integer = 0
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_LOOKUP_PKG_get_lookup_value_id_by_valcd"
        comm.Parameters.AddWithValue("@p_lookup_type", pLookupType)
        comm.Parameters.AddWithValue("@p_lookup_value_code", pLookupValuecode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        If dt.Rows.Count > 0 Then
            LookupValueId = clsConfig.IsNull(dt.Rows(0).Item("lookup_value_id"), 0)
        Else
            LookupValueId = 0
        End If
        Return LookupValueId
    End Function

    Public Function GammaTransferDataAlready(pCmrNumber As String)
        'Sitthana 01/08/2023
        Dim GammaTransfered As String = "N"

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_check_gamma_transfer_already"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@pCmrNumber", pCmrNumber)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()

        If dt.Rows.Count > 0 Then
            GammaTransfered = clsConfig.IsNull(dt.Rows(0).Item("TransferAlready"), "N")
        Else
            GammaTransfered = "N"
        End If

        Return GammaTransfered
    End Function

    Public Function comboLookupCodesSelect(Optional ByVal pLookupType As String = "") As DataTable
        'Sitthana 12/06/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_combo_lookup_codes"
        comm.CommandText = "P_CMR_PKG_select_lookup_value" 'Sitthana 20231212
        comm.Parameters.AddWithValue("@p_lookup_type", pLookupType)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCmrDocPrefix() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_LOOKUP_PKG_cmr_doc_prefix"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCmrDocSuffix() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_LOOKUP_PKG_cmr_doc_suffix"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCmrFrontBackSide() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_LOOKUP_PKG_front_back_side"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCmrQuality() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_LOOKUP_PKG_quality"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    '--- Get Data For Browse Data
    Public Function getCMRNumberData(ByVal p_cmr_number As String) As DataTable
        'Sitthana 08/08/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_find_cmr_header"
        comm.Parameters.AddWithValue("@p_cmr_number", p_cmr_number)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCMRRevisionHistoryData(ByVal p_cmr_number As String) As DataTable
        'Sitthana 08/08/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_find_cmr_header_log"
        comm.Parameters.AddWithValue("@p_cmr_number", p_cmr_number)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326

        Return dt
    End Function

    Public Function getMasDyeFinFormulaData(ByVal p_Code As String) As DataTable
        'Sitthana 08/08/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_find_mas_dye_finishing_formula"
        comm.Parameters.AddWithValue("@p_code", p_Code)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getDesignData(ByVal p_Design_No As String) As DataTable
        'Sitthana 08/08/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_find_design"
        comm.Parameters.AddWithValue("@p_Design_No", p_Design_No)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getEndBuyerData(ByVal pEndBuyerId As Integer) As DataTable
        'Sitthana 08/08/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_find_endbuyers"
        comm.Parameters.AddWithValue("@p_endbuyerid", pEndBuyerId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getDinNoData(ByVal pDinNo As String) As DataTable
        'Sitthana 08/08/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SAMPLE_GREIGE_STOCK_IN_PKG_get_dinno"
        comm.Parameters.AddWithValue("@p_DinNo", pDinNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getRollData(ByVal pRollNo As String, pDesignNo As String _
                              , pMtlSubinvId As Integer
                                ) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            comm.CommandType = CommandType.StoredProcedure
            comm.CommandText = "P_CMR_PKG_find_stock_bal_by_rollno"
            comm.CommandTimeout = 300
            comm.Parameters.AddWithValue("@p_roll_no_d", pRollNo)
            comm.Parameters.AddWithValue("@p_design_no", pDesignNo)
            comm.Parameters.AddWithValue("@p_mtlSubinvId", pMtlSubinvId)
            da.SelectCommand = comm
            da.Fill(dt)
            getRollData = dt
            Return getRollData
        Catch ex As Exception
            'Throw ex
            conn.Close()  'Sitthana 20190326
            MessageBox.Show(ex.Message.ToString())
            Return dt
        End Try
        conn.Close()  'Sitthana 20190326
    End Function
    Public Function getDrSqDf(pDesignNo As String) As String
        'Sitthana 05/11/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_get_DR_SQ_DF"
        comm.Parameters.AddWithValue("@p_Design_NO", pDesignNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        If dt.Rows.Count > 0 Then
            Dim DrSqDt As String = ""
            If dt.Rows(0)("DR") <> "" Then
                If DrSqDt <> "" Then
                    DrSqDt &= ", "
                End If
                DrSqDt &= dt.Rows(0)("DR")
            End If
            'If dt.Rows(0)("DF") <> "" Then
            '    If DrSqDt <> "" Then
            '        DrSqDt &= ", "
            '    End If
            '    DrSqDt &= dt.Rows(0)("DF")
            'End If
            'If dt.Rows(0)("SQ") <> "" Then
            '    If DrSqDt <> "" Then
            '        DrSqDt &= ", "
            '    End If
            '    DrSqDt &= dt.Rows(0)("SQ")
            'End If
            'If dt.Rows(0)("SQP") <> "" Then
            '    If DrSqDt <> "" Then
            '        DrSqDt &= ", "
            '    End If
            '    DrSqDt &= dt.Rows(0)("SQP")
            'End If
            getDrSqDf = DrSqDt
        Else
            getDrSqDf = ""
        End If
    End Function
    '--- End Get Data For Browse Data

    Public Function getCmrHeaderRecord(p_cmr_header_id As Integer, p_cmr_number As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_select_cmr_header"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_cmr_header_id", p_cmr_header_id)
        comm.Parameters.AddWithValue("@p_cmr_number", p_cmr_number)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCmrHeaderLogRecord(p_cmr_header_id As Integer, p_cmr_number As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_select_cmr_header_log"
        comm.Parameters.AddWithValue("@p_cmr_header_id", p_cmr_header_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCMR_LINEMaxLineNum(p_cmr_header_id As Integer)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_cmr_line_get_max_line_num"
        comm.Parameters.AddWithValue("@p_cmr_header_id", p_cmr_header_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326

        Return dt.Rows(0).Item("MaxLineNum") 'dt
    End Function
    Public Function getCmrLinesRecord(p_cmr_header_id As Integer) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_select_cmr_lines"
        comm.Parameters.AddWithValue("@p_cmr_header_id", p_cmr_header_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCmrLinesLogRecord(p_cmr_header_id As Integer) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_select_cmr_lines_log"
        comm.Parameters.AddWithValue("@p_cmr_header_id", p_cmr_header_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function getCmrDeliveryRecord(p_cmr_number As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.Parameters.AddWithValue("@p_cmr_number", p_cmr_number)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        comm.CommandText = "P_CMR_PKG_select_delivery_detail_by_lab_request_no"
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function CMRNewSave(ByVal drvCMRHead As DataRowView, ByVal dtLines As DataTable, ByVal dv_del As DataView, p_CurCmrRevisionNumber As Integer, ByVal p_log_empcd As String, pLastLineNum As Integer) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        Dim cmrHeaderID As Integer = 0

        cmrHeaderID = config.IsNull(drvCMRHead("cmr_header_id"), -1)

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_update_cmr_header"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_cmr_header_id", cmrHeaderID)
        comm.Parameters.AddWithValue("@p_cmr_doc_prefix", drvCMRHead("cmr_doc_prefix").ToString.Trim)
        comm.Parameters.AddWithValue("@p_cmr_doc_suffix", drvCMRHead("cmr_doc_suffix").ToString.Trim) 'Sitthana 28/11/2018
        comm.Parameters.AddWithValue("@p_cmr_number", drvCMRHead("cmr_number").ToString.Trim)
        comm.Parameters.AddWithValue("@p_cmr_date", Format(drvCMRHead("cmr_date"), "yyyyMMdd"))
        comm.Parameters.AddWithValue("@p_need_by_date", Format(drvCMRHead("need_by_date"), "yyyyMMdd"))
        comm.Parameters.AddWithValue("@p_lab_type_id", clsConfig.IsNull(drvCMRHead("lab_type_id"), 0))
        comm.Parameters.AddWithValue("@p_so_header_id", clsConfig.IsNull(drvCMRHead("so_header_id"), 0))
        comm.Parameters.AddWithValue("@p_sono", drvCMRHead("sono"))
        '--- Customer Details
        comm.Parameters.AddWithValue("@p_customer_id", drvCMRHead("customer_id"))
        comm.Parameters.AddWithValue("@p_customer_name", drvCMRHead("customer_name"))
        comm.Parameters.AddWithValue("@p_Garment_type", config.IsNull(drvCMRHead("Garment_type"), String.Empty))
        comm.Parameters.AddWithValue("@p_endbuyerid", drvCMRHead("endbuyerid"))
        comm.Parameters.AddWithValue("@p_end_buyer_name", drvCMRHead("end_buyer_name"))
        comm.Parameters.AddWithValue("@p_contact_person", drvCMRHead("contact_person"))
        comm.Parameters.AddWithValue("@p_lab_dyeing_type_id", drvCMRHead("lab_dyeing_type_id"))
        '--- Material Details
        comm.Parameters.AddWithValue("@p_item_id", drvCMRHead("item_id"))
        comm.Parameters.AddWithValue("@p_item_code", drvCMRHead("item_code"))
        comm.Parameters.AddWithValue("@p_item_cust_code", drvCMRHead("item_cust_code"))
        comm.Parameters.AddWithValue("@p_item_name", drvCMRHead("item_name"))
        comm.Parameters.AddWithValue("@p_item_desc", drvCMRHead("item_desc"))
        comm.Parameters.AddWithValue("@p_source_design_no", drvCMRHead("source_design_no"))
        comm.Parameters.AddWithValue("@p_yarn_stitch", drvCMRHead("yarn_stitch"))
        comm.Parameters.AddWithValue("@p_greige_fabric_status_id", drvCMRHead("greige_fabric_status_id"))
        comm.Parameters.AddWithValue("@p_finished_width_cm", drvCMRHead("finished_width_cm"))
        comm.Parameters.AddWithValue("@p_finished_width_cm_max", drvCMRHead("finished_width_cm_max"))
        comm.Parameters.AddWithValue("@p_finished_gmpersqm", drvCMRHead("finished_gmpersqm"))
        comm.Parameters.AddWithValue("@p_finished_gmpersqm_max", drvCMRHead("finished_gmpersqm_max"))
        comm.Parameters.AddWithValue("@p_finished_mtkg", drvCMRHead("finished_mtkg"))
        comm.Parameters.AddWithValue("@p_fin_id", drvCMRHead("fin_id"))
        '--- Dip submit
        comm.Parameters.AddWithValue("@p_shades_per_color", drvCMRHead("shades_per_color"))
        comm.Parameters.AddWithValue("@p_num_of_sets", drvCMRHead("num_of_sets"))
        comm.Parameters.AddWithValue("@p_cmr_approval_by_id", drvCMRHead("cmr_approval_by_id"))
        comm.Parameters.AddWithValue("@p_end_use_id", drvCMRHead("end_use_id"))
        comm.Parameters.AddWithValue("@p_cmr_remarks", drvCMRHead("cmr_remarks"))
        '--- Technical Details
        comm.Parameters.AddWithValue("@p_fabric_selling_price_type ", drvCMRHead("fabric_selling_price_type"))
        comm.Parameters.AddWithValue("@p_matching_priority_1_id", drvCMRHead("matching_priority_1_id"))
        comm.Parameters.AddWithValue("@p_matching_priority_2_id", drvCMRHead("matching_priority_2_id"))
        comm.Parameters.AddWithValue("@p_matching_priority_3_id", drvCMRHead("matching_priority_3_id"))
        comm.Parameters.AddWithValue("@p_contrast_garment", drvCMRHead("contrast_garment"))
        comm.Parameters.AddWithValue("@p_contrast_garment_type_id", drvCMRHead("contrast_garment_type_id"))
        comm.Parameters.AddWithValue("@p_mix_match_part1_id", drvCMRHead("mix_match_part1_id"))
        comm.Parameters.AddWithValue("@p_mix_match_part2_id", drvCMRHead("mix_match_part2_id"))
        comm.Parameters.AddWithValue("@p_mix_match_part3_id", drvCMRHead("mix_match_part3_id"))
        comm.Parameters.AddWithValue("@p_bisphenol_control", drvCMRHead("bisphenol_control")) 'Sitthana 20250205
        comm.Parameters.AddWithValue("@p_condition_type", drvCMRHead("condition_type")) 'Sitthana 20250205
        comm.Parameters.AddWithValue("@p_laminate_condition_foam_no", drvCMRHead("laminate_condition_foam_no"))
        comm.Parameters.AddWithValue("@p_laminate_condition_temp", drvCMRHead("laminate_condition_temp"))
        comm.Parameters.AddWithValue("@p_laminate_condition_duration", drvCMRHead("laminate_condition_duration"))
        comm.Parameters.AddWithValue("@p_laminate_condition_duration_max", drvCMRHead("laminate_condition_duration_max")) 'Sitthana 20230605
        comm.Parameters.AddWithValue("@p_mold_condition_bubble_type", drvCMRHead("mold_condition_bubble_type"))
        comm.Parameters.AddWithValue("@p_mold_condition_rigid_type", drvCMRHead("mold_condition_rigid_type"))
        comm.Parameters.AddWithValue("@p_mold_condition_temp", drvCMRHead("mold_condition_temp"))
        comm.Parameters.AddWithValue("@p_mold_condition_duration", drvCMRHead("mold_condition_duration"))
        comm.Parameters.AddWithValue("@p_mold_condition_duration_max", drvCMRHead("mold_condition_duration_max")) 'Sitthana 20230605
        comm.Parameters.AddWithValue("@p_swatch_front_back_matching", drvCMRHead("swatch_front_back_matching"))
        comm.Parameters.AddWithValue("@p_material_front_back_matching", drvCMRHead("material_front_back_matching"))
        comm.Parameters.AddWithValue("@p_match_with_another_flag", drvCMRHead("match_with_another_flag"))
        comm.Parameters.AddWithValue("@p_match_with_reference", drvCMRHead("match_with_reference"))
        comm.Parameters.AddWithValue("@p_internal_doc_ref", drvCMRHead("internal_doc_ref"))
        comm.Parameters.AddWithValue("@p_quality_level", drvCMRHead("quality_level"))
        comm.Parameters.AddWithValue("@p_std_test_method_id", drvCMRHead("std_test_method_id"))
        comm.Parameters.AddWithValue("@p_test_method_others", drvCMRHead("test_method_others"))
        '--- Colour Comarison Method
        comm.Parameters.AddWithValue("@p_std_layers", drvCMRHead("std_layers"))
        comm.Parameters.AddWithValue("@p_sample_layers", drvCMRHead("sample_layers"))
        comm.Parameters.AddWithValue("@p_butt_to_std", drvCMRHead("butt_to_std"))
        comm.Parameters.AddWithValue("@p_lay_on_std", drvCMRHead("lay_on_std"))
        comm.Parameters.AddWithValue("@p_observer_type_id", drvCMRHead("observer_type_id"))
        comm.Parameters.AddWithValue("@p_light_box_id", drvCMRHead("light_box_id"))
        comm.Parameters.AddWithValue("@p_light_source_1_id", drvCMRHead("light_source_1_id"))
        comm.Parameters.AddWithValue("@p_light_source_2_id", drvCMRHead("light_source_2_id"))
        comm.Parameters.AddWithValue("@p_light_source_3_id", drvCMRHead("light_source_3_id"))
        comm.Parameters.AddWithValue("@p_std_thichness_layers", drvCMRHead("std_thichness_layers"))
        comm.Parameters.AddWithValue("@p_for_order", drvCMRHead("for_order"))
        comm.Parameters.AddWithValue("@p_for_sample", drvCMRHead("for_sample"))
        '--
        comm.Parameters.AddWithValue("@p_last_line_num", drvCMRHead("last_line_num"))
        comm.Parameters.AddWithValue("@p_log_empcd", p_log_empcd)

        '---John 06/03/2026
        comm.Parameters.AddWithValue("@p_master_color_ref", drvCMRHead("master_color_ref"))
        comm.Parameters.AddWithValue("@p_delta_e", drvCMRHead("delta_e"))
        comm.Parameters.AddWithValue("@p_test_report", drvCMRHead("test_report"))
        '-----------------

        Dim da As New SqlDataAdapter(comm)
        Dim dtHead As New DataTable
        Try
            da.Fill(dtHead)
            cmrHeaderID = dtHead.Rows(0)("cmr_header_id")
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190326
            Throw ex
        End Try

        Dim dtCurLine As New DataTable

        If dtLines.Rows.Count > 0 Then
            Dim LineNum As Integer = 0
            Dim NewLineNum As Integer = 0
            comm.CommandText = "P_CMR_PKG_update_cmr_Lines"

            For i = 0 To dtLines.Rows.Count - 1
                With dtLines.Rows(i)
                    If dtLines.Rows(i).RowState <> DataRowState.Deleted Then
                        Select Case dtLines.Rows(i).RowState
                            Case DataRowState.Added
                                NewLineNum += 1
                                LineNum = pLastLineNum + NewLineNum
                            Case DataRowState.Modified, DataRowState.Unchanged
                                LineNum = .Item("line_num")
                        End Select
                        comm.Parameters.Clear()
                        comm.Parameters.AddWithValue("@p_cmr_header_id", cmrHeaderID)
                        comm.Parameters.AddWithValue("@p_cmr_lines_id", .Item("cmr_lines_id"))
                        comm.Parameters.AddWithValue("@p_line_num", LineNum)
                        comm.Parameters.AddWithValue("@p_color_name", config.IsNull(.Item("color_name"), "").Trim)
                        comm.Parameters.AddWithValue("@p_shades_per_color", config.IsNull(.Item("shades_per_color"), 0))
                        comm.Parameters.AddWithValue("@p_num_of_sets", Val(config.IsNull(.Item("num_of_sets"), 0)))
                        comm.Parameters.AddWithValue("@p_need_by_date", config.IsNull(.Item("need_by_date"), "19000101"))
                        comm.Parameters.AddWithValue("@p_planned_submit_date", config.IsNull(.Item("planned_submit_date"), "19000101"))
                        comm.Parameters.AddWithValue("@p_cmr_line_remarks", config.IsNull(.Item("cmr_line_remarks"), "").Trim)
                        comm.Parameters.AddWithValue("@p_log_empcd", p_log_empcd)

                        da = New SqlDataAdapter(comm)
                        dtCurLine = New DataTable
                        Try
                            da.Fill(dtCurLine)
                        Catch ex As Exception
                            tran.Rollback()
                            conn.Close()  'Sitthana 20190326
                            Throw ex
                        End Try
                    End If
                End With
            Next 'End For Loop
        End If

        'dv_del
        comm.CommandText = "P_CMR_PKG_delete_cmr_lines"
        If dv_del.Count > 0 Then
            For i = 0 To dv_del.Count - 1
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@p_cmr_header_id", cmrHeaderID)
                comm.Parameters.AddWithValue("@p_cmr_lines_id", dv_del(i)("cmr_lines_id"))
                comm.Parameters.AddWithValue("@p_log_empcd", p_log_empcd)

                da = New SqlDataAdapter(comm)
                dtCurLine = New DataTable
                Try
                    da.Fill(dtCurLine)
                Catch ex As Exception
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190326
                    Throw ex
                End Try
            Next
        End If

        tran.Commit()
        conn.Close()  'Sitthana 20190326
        Return dtHead
    End Function
    Public Function CMRRelabSave(pCmrHeaderID As Integer, ByVal pLogEmpcd As String, pPlanDayAdd As Integer, pCmrRelabCause As String) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_create_cmr_relab"
        comm.Parameters.AddWithValue("@p_cmr_header_id", pCmrHeaderID)
        comm.Parameters.AddWithValue("@p_plan_day_add", pPlanDayAdd)
        comm.Parameters.AddWithValue("@p_cmr_relab_cause", pCmrRelabCause)
        comm.Parameters.AddWithValue("@p_log_empcd", pLogEmpcd)

        Dim da As New SqlDataAdapter(comm)
        Dim dtHead As New DataTable
        Try
            da.Fill(dtHead)
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190326
            Throw ex
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190326
        Return dtHead
    End Function
    Public Function CMRRevisionSave(p_cmrHeaderID As Integer, p_CmrRevisionNumber As Integer, p_Cmr_Revision_Cause As String, ByVal p_log_empcd As String) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_create_cmr_revision_log"
        comm.Parameters.AddWithValue("@p_cmr_header_id", p_cmrHeaderID)
        comm.Parameters.AddWithValue("@p_CmrRevisionNumber", p_CmrRevisionNumber)
        comm.Parameters.AddWithValue("@p_CmrRevisionCause", p_Cmr_Revision_Cause)
        comm.Parameters.AddWithValue("@p_log_empcd", p_log_empcd)

        Dim da As New SqlDataAdapter(comm)
        Dim dtHead As New DataTable
        Try
            da.Fill(dtHead)
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190326
            Throw ex
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190326
        Return dtHead
    End Function
    Public Function CMRNewColorSave(pCmrHeaderID As Integer, pCmrNumber As String, ByVal pLogEmpcd As String) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_create_cmr_newcolor"
        comm.Parameters.AddWithValue("@p_cmr_header_id", pCmrHeaderID)
        comm.Parameters.AddWithValue("@p_Cmr_Number", pCmrNumber)
        comm.Parameters.AddWithValue("@p_log_empcd", pLogEmpcd)

        Dim da As New SqlDataAdapter(comm)
        Dim dtHead As New DataTable
        Try
            da.Fill(dtHead)
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190326
            Throw ex
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190326
        Return dtHead
    End Function
    Public Function CMRCancelDoc(pCmrHeaderID As Integer, pCmrCancel As String, ByVal pEmpcd As String) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_update_Cmr_CancelDoc"
        comm.Parameters.AddWithValue("@p_cmr_header_id", pCmrHeaderID)
        comm.Parameters.AddWithValue("@p_cmr_cancel", pCmrCancel)
        comm.Parameters.AddWithValue("@p_empcd", pEmpcd)

        Dim da As New SqlDataAdapter(comm)
        Dim dtHead As New DataTable
        Try
            da.Fill(dtHead)
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190326
            Throw ex
        End Try

        tran.Commit()
        conn.Close()  'Sitthana 20190326
        Return dtHead
    End Function

    Public Function getCMRLabStatus(pCMRDateFrom, pCMRDateTo, pCMRStatus) As DataTable
        'saharat 20230619
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_select_cmr_lab_status"
        comm.CommandTimeout = 300
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_cmr_date_from", pCMRDateFrom)
        comm.Parameters.AddWithValue("@p_cmr_date_to", pCMRDateTo)
        comm.Parameters.AddWithValue("@p_cmr_status", pCMRStatus)
        'comm.Parameters.Add("@p_cmr_date_from", SqlDbType.Date).Value = pCMRDateFrom
        'comm.Parameters.Add("@p_cmr_date_to", SqlDbType.Date).Value = pCMRDateTo
        'comm.Parameters.Add("@p_cmr_status", SqlDbType.VarChar).Value = pCMRStatus
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getComboBoxCMRStatus()
        'saharat 20230619
        Dim sourceCMRStatus As New Dictionary(Of String, String)
        sourceCMRStatus.Add("ALL", "ALL")
        sourceCMRStatus.Add("PENDING", "PENDING")
        sourceCMRStatus.Add("APPROVED", "APPROVED")
        sourceCMRStatus.Add("REJECT", "REJECT")
        sourceCMRStatus.Add("WAIT", "WAIT")
        Return sourceCMRStatus
    End Function


End Class
