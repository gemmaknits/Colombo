Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports Classes

Public Class classSalesOrder
    Dim oConfig As New clsConfig
    Public Structure SOHeader
        Dim h01_sono As String
        Dim h02_sodt As String
        Dim h03_custcd As String
        Dim h04_agcd As String
        Dim h05_empcd As String
        Dim h06_rem As String
        Dim h07_gr_soamt As Double
        Dim h08_discamt As Double
        Dim h09_nt_soamt As Double
        Dim h10_attn As String
        Dim h11_shipcustcd As String
        Dim h12_payterms As String
        Dim h13_credit As Integer
        Dim h14_crdays As Double
        Dim h15_custpo As String
        Dim h15_custpo_unique As String
        Dim h15_contract_number As String
        Dim h15_custpo_suffix As String
        Dim h16_deli As String
        Dim h17_delicd As String
        Dim h18_ref As String
        Dim h19_rev As Integer
        Dim h20_sono1 As String
        Dim h21_cancel_status As Boolean
        Dim h22_lastsonoid As Integer
        Dim h23_endbuyercd As String
        Dim h24_prgorder As Boolean
        Dim h25_shipmark As String
        Dim h26_sample_order As Boolean
        Dim h33_stock_Order As Boolean
        Dim h34_devl_Order As Boolean
        Dim h35_clearance_Order As Boolean
        Dim h27_submit_bulk As Boolean
        Dim h31_submit_bulk_all_batch As Boolean
        Dim h32_no_of_batches As Integer
        Dim h28_shipvia As String
        Dim h29_exploc As Boolean
        Dim h30_log_empcd As String
        Dim h36_contact As String
        Dim h37_bulk_app_by_dh As Boolean
        Dim h38_bulk_app_by_mk As Boolean
        Dim h39_shipqty_tolerance As Integer
        Dim h40_paymodecd As String
        Dim h41_shipqty_tolerance_high As Integer
        Dim h42_shipqty_tolerance_low As Integer
        Dim h43_order_type As String
        Dim h44_agentcommper As Integer
        Dim h45_salescommper As Integer
        Dim h46_dye_standard As String
        Dim h47_quality_special_request As String
        Dim h48_pack_after_bulk_app_lookup_type As Nullable(Of Int64)
        Dim h49_id_bank As Nullable(Of Integer)
        Dim h50_bank_code As String
        Dim h51_id_banks As Nullable(Of Int64)
        Dim ship_from_warehouse_id As Nullable(Of Int64)
        Dim SO_FULFIL_SRC_ID As Nullable(Of Int64)
        Dim fulfilment_comment As String 'Sitthana 23/04/2018
        Dim flow_status_code As String   'Sitthana 23/04/2018 
        Dim mts_per_roll As Double       'Sitthana 23/04/2018
        Dim h52_sr_type_id As Nullable(Of Int64) 'Sitthana 20240523
        'John 20/10/2025 ---------
        Dim h53_refjobno1 As String
        Dim h54_refJobno2 As String
        Dim h55_refJobno3 As String
        Dim h56_refJobno4 As String
        Dim h57_jobnocomment1 As String
        Dim h58_jobnocomment2 As String
        Dim h59_jobnocomment3 As String
        Dim h60_jobnocomment4 As String
        Dim h61_design_properties_id As Nullable(Of Int64)
        Dim h62_cust_addl_info As String
        Dim h63_sample_fabric_qty As Double
        Dim h64_sample_bulk_qty As Double
        Dim h65_price_list_header_id As Nullable(Of Int64)
        '-------------------------
    End Structure


    Public Function SOSearch(Optional ByVal strSoNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional strUserID As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_search"
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@sodtfr", strDateFr)
        comm.Parameters.AddWithValue("@sodtto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@loginEmpcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SOLoad(Optional ByVal strSoNo As String = "", Optional ByVal strDateFr As String = "",
                           Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "",
                           Optional strUserID As String = "", Optional ByVal strOrder_Type As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_so_combo_select"
        comm.CommandText = "p_so_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@sodtfr", strDateFr)
        comm.Parameters.AddWithValue("@sodtto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@order_type", strOrder_Type)
        comm.Parameters.AddWithValue("@loginEmpcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SODetLoad(ByVal strSoNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_soitm_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCopySoitm(ByVal strSoNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_PKG_select_soitm_copy"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SalesOrderDesignNoExists(ByVal designNo As String) As Boolean
        designNo = oConfig.IsNull(designNo, "").ToString.Trim
        If designNo.Length = 0 Then Return False

        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dm_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@design_no", designNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325

        For Each dr As DataRow In dt.Rows
            If String.Equals(oConfig.IsNull(dr("design_no"), "").ToString.Trim, designNo, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Function GetSOFromPO(ByVal strPoNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_check_duplicate_po"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@custpo", strPoNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSOFromCustPOUnique(ByVal strPoNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_check_duplicate_custpo_unique"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@custpo_unique", strPoNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function Getfulfilment_typeFromSo_Type(ByVal StrSo_type As String) As DataTable
        Dim dt As New DataTable
        If String.IsNullOrWhiteSpace(StrSo_type) Then Return dt

        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_select_fulfilment_type_from_so_type"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@order_type", StrSo_type.Trim)
        Dim da As New SqlDataAdapter(comm)
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSo_TypeFromUserId(ByVal Strentitytype As String, ByVal Struserid As String) As DataTable
        Dim dt As New DataTable
        If String.IsNullOrWhiteSpace(Strentitytype) OrElse String.IsNullOrWhiteSpace(Struserid) Then Return dt

        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_select_so_type_from_userid"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@entitytype", Strentitytype.Trim)
        comm.Parameters.AddWithValue("@userid", Struserid.Trim)
        Dim da As New SqlDataAdapter(comm)
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SOSave(ByVal SOH As SOHeader, ByVal SOD_ADD As DataView, ByVal SOD_UPD As DataView, ByVal SOD_DEL As DataView, ByRef msgerr As String, ByRef sono As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_update"
        comm.Parameters.Clear()

        With SOH
            comm.Parameters.AddWithValue("@sono", .h01_sono.Trim)
            comm.Parameters.AddWithValue("@sodt", .h02_sodt)
            comm.Parameters.AddWithValue("@custcd", .h03_custcd.Trim)
            comm.Parameters.AddWithValue("@agcd", .h04_agcd.Trim)
            comm.Parameters.AddWithValue("@empcd", .h05_empcd.Trim)
            comm.Parameters.AddWithValue("@rem", .h06_rem.Trim)
            comm.Parameters.AddWithValue("@gr_soamt", .h07_gr_soamt)
            comm.Parameters.AddWithValue("@discamt", .h08_discamt)
            comm.Parameters.AddWithValue("@nt_soamt", .h09_nt_soamt)
            comm.Parameters.AddWithValue("@attn", .h10_attn.Trim)
            comm.Parameters.AddWithValue("@shipcustcd", oConfig.IsNull(.h11_shipcustcd, DBNull.Value))
            comm.Parameters.AddWithValue("@payterms", .h12_payterms.Trim)
            comm.Parameters.AddWithValue("@credit", .h13_credit)
            comm.Parameters.AddWithValue("@crdays", .h14_crdays)
            comm.Parameters.AddWithValue("@custpo", .h15_custpo.Trim)
            comm.Parameters.AddWithValue("@custpo_unique", .h15_custpo_unique.Trim)
            comm.Parameters.AddWithValue("@p_contract_number", .h15_contract_number.Trim)
            comm.Parameters.AddWithValue("@custpo_suffix", .h15_custpo_suffix.Trim)

            comm.Parameters.AddWithValue("@deli", .h16_deli.Trim)
            comm.Parameters.AddWithValue("@delicd", oConfig.IsNull(.h17_delicd, DBNull.Value))
            comm.Parameters.AddWithValue("@ref", .h18_ref.Trim)
            comm.Parameters.AddWithValue("@rev", .h19_rev.ToString)
            comm.Parameters.AddWithValue("@sono1", .h20_sono1.Trim)
            comm.Parameters.AddWithValue("@cancel_status", .h21_cancel_status)
            comm.Parameters.AddWithValue("@lastsonoid", .h22_lastsonoid.ToString)
            comm.Parameters.AddWithValue("@endbuyercd", .h23_endbuyercd.Trim)
            comm.Parameters.AddWithValue("@prgorder", .h24_prgorder)
            comm.Parameters.AddWithValue("@shipmark", .h25_shipmark.Trim)
            '            comm.Parameters.AddWithValue("@sample_order", .h26_sample_order)

            '           comm.Parameters.AddWithValue("@stock_order", .h33_stock_Order)
            '          comm.Parameters.AddWithValue("@devl_order", .h34_devl_Order)
            '         comm.Parameters.AddWithValue("@clearance_order", .h35_clearance_Order)

            comm.Parameters.AddWithValue("@submit_bulk", .h27_submit_bulk)

            comm.Parameters.AddWithValue("@submit_bulk_all_batch", .h31_submit_bulk_all_batch)
            comm.Parameters.AddWithValue("@no_of_batches", .h32_no_of_batches)

            comm.Parameters.AddWithValue("@shipvia", .h28_shipvia.Trim)
            comm.Parameters.AddWithValue("@exploc", .h29_exploc)
            comm.Parameters.AddWithValue("@log_empcd", .h30_log_empcd)
            comm.Parameters.AddWithValue("@contact", .h36_contact)
            comm.Parameters.AddWithValue("@bulk_app_by_dh", .h37_bulk_app_by_dh)
            comm.Parameters.AddWithValue("@bulk_app_by_mk", .h38_bulk_app_by_mk)
            comm.Parameters.AddWithValue("@shipqty_tolerance", .h39_shipqty_tolerance)
            comm.Parameters.AddWithValue("@paymodecd", .h40_paymodecd)
            comm.Parameters.AddWithValue("@shipqty_tolerance_high", .h41_shipqty_tolerance_high)
            comm.Parameters.AddWithValue("@shipqty_tolerance_low", .h42_shipqty_tolerance_low)
            comm.Parameters.AddWithValue("@order_type", .h43_order_type)
            comm.Parameters.AddWithValue("@agentcommper", .h44_agentcommper)
            comm.Parameters.AddWithValue("@salescommper", .h45_salescommper)
            comm.Parameters.AddWithValue("@dye_standard", .h46_dye_standard)
            comm.Parameters.AddWithValue("@quality_special_request", .h47_quality_special_request)
            comm.Parameters.AddWithValue("@pack_after_bulk_app_lookup_type", .h48_pack_after_bulk_app_lookup_type)
            comm.Parameters.AddWithValue("@bank_code", config.IsNull(.h50_bank_code, 1))
            comm.Parameters.AddWithValue("@id_banks", config.IsNull(.h51_id_banks, DBNull.Value))
            comm.Parameters.AddWithValue("@ship_from_warehouse_id", .ship_from_warehouse_id)
            comm.Parameters.AddWithValue("@SO_FULFIL_SRC_ID", .SO_FULFIL_SRC_ID)
            comm.Parameters.AddWithValue("@fulfilment_comment", .fulfilment_comment) 'Sitthana 23/04/2018
            comm.Parameters.AddWithValue("@Mts_per_roll", .mts_per_roll) 'Sitthana 23/04/2018
            comm.Parameters.AddWithValue("@pSrTypeId", config.IsNull(.h52_sr_type_id, DBNull.Value)) 'Sitthana 23/05/2024
            'John 20/10/2025 ------------
            comm.Parameters.AddWithValue("@p_ref_job_no1", .h53_refjobno1.Trim)
            comm.Parameters.AddWithValue("@p_ref_job_no2", .h54_refJobno2.Trim)
            comm.Parameters.AddWithValue("@p_ref_job_no3", .h55_refJobno3.Trim)
            comm.Parameters.AddWithValue("@p_ref_job_no4", .h56_refJobno4.Trim)
            comm.Parameters.AddWithValue("@p_ref_job_no_comment1", .h57_jobnocomment1.Trim)
            comm.Parameters.AddWithValue("@p_ref_job_no_comment2", .h58_jobnocomment2.Trim)
            comm.Parameters.AddWithValue("@p_ref_job_no_comment3", .h59_jobnocomment3.Trim)
            comm.Parameters.AddWithValue("@p_ref_job_no_comment4", .h60_jobnocomment4.Trim)
            comm.Parameters.AddWithValue("@p_design_properties_id", .h61_design_properties_id)
            '----------------------
            comm.Parameters.AddWithValue("@p_cust_addl_info", .h62_cust_addl_info.Trim)
            comm.Parameters.AddWithValue("@p_sample_fabric_qty", .h63_sample_fabric_qty)
            comm.Parameters.AddWithValue("@p_sample_bulk_qty", .h64_sample_bulk_qty)
            comm.Parameters.AddWithValue("@p_price_list_header_id", .h65_price_list_header_id)


            '-----------------------------------
        End With

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            sono = dt.Rows(0)("sono").ToString 'Move By Neung 20100124
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        ' sono = dt.Rows(0)("sono").ToString

        'Add Detail----------

        i = 0
        comm.CommandText = "p_soitm_update"

        For i = 0 To SOD_ADD.Count - 1
            With SOD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@slno", config.IsNull(.Item(i)("slno"), 0))
                comm.Parameters.AddWithValue("@sono", sono)
                comm.Parameters.AddWithValue("@sonoid", "")
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@custdes", config.IsNull(.Item(i)("custdes"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@custcol", config.IsNull(.Item(i)("custcol"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@labeldes", config.IsNull(.Item(i)("labeldes"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@custpono", config.IsNull(.Item(i)("custpono"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@rw", config.IsNull(.Item(i)("rw"), 0))
                comm.Parameters.AddWithValue("@rl", config.IsNull(.Item(i)("rl"), 0))
                comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty"), 0))
                comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@price", config.IsNull(.Item(i)("price"), 0))
                comm.Parameters.AddWithValue("@exrt", config.IsNull(.Item(i)("exrt"), 0).ToString)
                comm.Parameters.AddWithValue("@curr", config.IsNull(.Item(i)("curr"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@discamt", config.IsNull(.Item(i)("discamt"), 0))
                comm.Parameters.AddWithValue("@discper", config.IsNull(.Item(i)("discper"), 0))
                comm.Parameters.AddWithValue("@shipdt", CDate(config.IsNull(.Item(i)("shipdt"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@gr_itamt", config.IsNull(.Item(i)("gr_itamt"), 0))
                comm.Parameters.AddWithValue("@nt_itamt", config.IsNull(.Item(i)("nt_itamt"), 0))
                comm.Parameters.AddWithValue("@qtyship", config.IsNull(.Item(i)("qtyship"), 0))
                comm.Parameters.AddWithValue("@qtybal", config.IsNull(.Item(i)("qtybal"), 0))
                comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@closed", IIf(CBool(config.IsNull(.Item(i)("closed"), False)), 1, 0))
                comm.Parameters.AddWithValue("@closedt", CDate(config.IsNull(.Item(i)("closedt"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@show_price", config.IsNull(.Item(i)("show_price"), 0))
                comm.Parameters.AddWithValue("@cust_shipdt", CDate(config.IsNull(.Item(i)("cust_shipdt"), "01/01/1900")).ToString("yyyyMMdd"))

                comm.Parameters.AddWithValue("@sys_width_id", config.IsNull(.Item(i)("sys_width_id"), 0).ToString().Trim())
                comm.Parameters.AddWithValue("@ref_stnoid", config.IsNull(.Item(i)("ref_stnoid"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@confirmed_shipdt", IIf(.Item(i)("confirmed_shipdt").Equals(""), "", (CDate(config.IsNull(.Item(i)("confirmed_shipdt"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@knit_begin_date", IIf(.Item(i)("knit_begin_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("knit_begin_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@knit_end_date", IIf(.Item(i)("knit_end_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("knit_end_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@dye_end_date", IIf(.Item(i)("dye_end_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("dye_end_date"), "01/01/1900")).ToString("yyyyMMdd"))))

                comm.Parameters.AddWithValue("@yarn_available_date", IIf(.Item(i)("yarn_available_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("yarn_available_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@confirmed_appointment", IIf(config.IsNull(.Item(i)("confirmed_appointment"), False), "1", "0"))
                comm.Parameters.AddWithValue("@id_so_routing", config.IsNull(.Item(i)("id_so_routing"), Nothing))

                comm.Parameters.AddWithValue("@labelcolor", config.IsNull(.Item(i)("labelcolor"), Nothing))
                comm.Parameters.AddWithValue("@labelarticle", config.IsNull(.Item(i)("labelarticle"), Nothing))
                comm.Parameters.AddWithValue("@labeldata1", config.IsNull(.Item(i)("labeldata1"), Nothing))
                comm.Parameters.AddWithValue("@labeldata2", config.IsNull(.Item(i)("labeldata2"), Nothing))
                comm.Parameters.AddWithValue("@labdipno", config.IsNull(.Item(i)("labdipno"), Nothing)) 'Sitthana 23/04/2018
                comm.Parameters.AddWithValue("@labdip_comment", config.IsNull(.Item(i)("labdip_comment"), Nothing)) 'Sitthana 23/04/2018
                comm.Parameters.AddWithValue("@ship_from_warehouse_id", SOH.ship_from_warehouse_id)
                comm.Parameters.AddWithValue("@SO_FULFIL_SRC_ID", SOH.SO_FULFIL_SRC_ID)

                comm.Parameters.AddWithValue("@mtl_customer_items_xref_id", config.IsNull(.Item(i)("mtl_customer_items_xref_id"), Nothing)) 'Sitthana 16/02/2018
                comm.Parameters.AddWithValue("@mtl_customer_items_id", config.IsNull(.Item(i)("mtl_customer_items_id"), Nothing)) 'Sitthana 16/02/2018
                comm.Parameters.AddWithValue("@p_price_list_detail_id", config.IsNull(.Item(i)("price_list_detail_id"), Nothing)) 'John 30/09/2026
                comm.Parameters.AddWithValue("@pJobNo", config.IsNull(.Item(i)("JobNo"), Nothing)) 'Sitthana 23/05/2024
                comm.Parameters.AddWithValue("@pSentToId", config.IsNull(.Item(i)("sent_to_id"), Nothing)) 'Sitthana 23/05/2024

                comm.Parameters.AddWithValue("@p_prod_loss_perc", config.IsNull(.Item(i)("prod_loss_perc"), 0)) 'John 26/03/2026
                comm.Parameters.AddWithValue("@p_qty_with_loss", config.IsNull(.Item(i)("qty_with_loss"), 0)) 'John 26/03/2026
                comm.Parameters.AddWithValue("@p_hs_code", config.IsNull(.Item(i)("hs_code"), Nothing)) 'John 18/05/2026
                comm.Parameters.AddWithValue("@p_sample_fabric_qty", config.IsNull(.Item(i)("sample_fabric_qty"), 0))
                comm.Parameters.AddWithValue("@p_sample_bulk_qty", config.IsNull(.Item(i)("sample_bulk_qty"), 0))
                comm.Parameters.AddWithValue("@p_price_list_override_reason", config.IsNull(.Item(i)("price_list_override_reason"), Nothing))

                ' last Record update
                comm.Parameters.AddWithValue("@logempcd", SOH.h30_log_empcd) 'last record update
            End With
            Dim sql As String = config.BuildSQL(comm)
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                Return False
            End Try
        Next

        'Update Detail----------

        i = 0
        comm.CommandText = "p_soitm_update"

        For i = 0 To SOD_UPD.Count - 1
            With SOD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@slno", config.IsNull(.Item(i)("slno"), 0))
                comm.Parameters.AddWithValue("@sono", sono)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@custdes", config.IsNull(.Item(i)("custdes"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@custcol", config.IsNull(.Item(i)("custcol"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@labeldes", config.IsNull(.Item(i)("labeldes"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@custpono", config.IsNull(.Item(i)("custpono"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@rw", config.IsNull(.Item(i)("rw"), 0))
                comm.Parameters.AddWithValue("@rl", config.IsNull(.Item(i)("rl"), 0))
                comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty"), 0))
                comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@price", config.IsNull(.Item(i)("price"), 0))
                comm.Parameters.AddWithValue("@exrt", config.IsNull(.Item(i)("exrt"), 0).ToString)
                comm.Parameters.AddWithValue("@curr", config.IsNull(.Item(i)("curr"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@discamt", config.IsNull(.Item(i)("discamt"), 0))
                comm.Parameters.AddWithValue("@discper", config.IsNull(.Item(i)("discper"), 0))
                comm.Parameters.AddWithValue("@shipdt", CDate(config.IsNull(.Item(i)("shipdt"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@gr_itamt", config.IsNull(.Item(i)("gr_itamt"), 0))
                comm.Parameters.AddWithValue("@nt_itamt", config.IsNull(.Item(i)("nt_itamt"), 0))
                comm.Parameters.AddWithValue("@qtyship", config.IsNull(.Item(i)("qtyship"), 0))
                comm.Parameters.AddWithValue("@qtybal", config.IsNull(.Item(i)("qtybal"), 0))
                comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@closed", IIf(CBool(config.IsNull(.Item(i)("closed"), False)), 1, 0))
                comm.Parameters.AddWithValue("@closedt", CDate(config.IsNull(.Item(i)("closedt"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@show_price", config.IsNull(.Item(i)("show_price"), 0))
                comm.Parameters.AddWithValue("@cust_shipdt", CDate(config.IsNull(.Item(i)("cust_shipdt"), "01/01/1900")).ToString("yyyyMMdd")) 'Has Bug

                comm.Parameters.AddWithValue("@sys_width_id", config.IsNull(.Item(i)("sys_width_id"), 0).ToString().Trim())
                comm.Parameters.AddWithValue("@ref_stnoid", config.IsNull(.Item(i)("ref_stnoid"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@confirmed_shipdt", IIf(.Item(i)("confirmed_shipdt").Equals(""), "", (CDate(config.IsNull(.Item(i)("confirmed_shipdt"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@knit_begin_date", IIf(.Item(i)("knit_begin_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("knit_begin_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@knit_end_date", IIf(.Item(i)("knit_end_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("knit_end_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@dye_end_date", IIf(.Item(i)("dye_end_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("dye_end_date"), "01/01/1900")).ToString("yyyyMMdd"))))

                comm.Parameters.AddWithValue("@yarn_available_date", IIf(.Item(i)("yarn_available_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("yarn_available_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@confirmed_appointment", IIf(config.IsNull(.Item(i)("confirmed_appointment"), False), "1", "0"))
                comm.Parameters.AddWithValue("@id_so_routing", config.IsNull(.Item(i)("id_so_routing"), Nothing)) 'Add By Neung

                comm.Parameters.AddWithValue("@labelcolor", config.IsNull(.Item(i)("labelcolor"), Nothing))
                comm.Parameters.AddWithValue("@labelarticle", config.IsNull(.Item(i)("labelarticle"), Nothing))
                comm.Parameters.AddWithValue("@labeldata1", config.IsNull(.Item(i)("labeldata1"), Nothing))
                comm.Parameters.AddWithValue("@labeldata2", config.IsNull(.Item(i)("labeldata2"), Nothing))
                comm.Parameters.AddWithValue("@labdipno", config.IsNull(.Item(i)("labdipno"), Nothing)) 'Neung 20250619
                comm.Parameters.AddWithValue("@labdip_comment", config.IsNull(.Item(i)("labdip_comment"), Nothing)) 'Sitthana 23/04/2018

                comm.Parameters.AddWithValue("@ship_from_warehouse_id", SOH.ship_from_warehouse_id)
                comm.Parameters.AddWithValue("@SO_FULFIL_SRC_ID", SOH.SO_FULFIL_SRC_ID)
                comm.Parameters.AddWithValue("@mtl_customer_items_xref_id", config.IsNull(.Item(i)("mtl_customer_items_xref_id"), Nothing)) 'Sitthana 16/02/2018
                comm.Parameters.AddWithValue("@mtl_customer_items_id", config.IsNull(.Item(i)("mtl_customer_items_id"), Nothing)) 'Sitthana 16/02/2018
                comm.Parameters.AddWithValue("@p_price_list_detail_id", config.IsNull(.Item(i)("price_list_detail_id"), Nothing)) 'John 30/09/2026
                comm.Parameters.AddWithValue("@pJobNo", config.IsNull(.Item(i)("JobNo"), Nothing)) 'Sitthana 23/05/2024
                comm.Parameters.AddWithValue("@pSentToId", config.IsNull(.Item(i)("sent_to_id"), Nothing)) 'Sitthana 23/05/2024

                comm.Parameters.AddWithValue("@p_prod_loss_perc", config.IsNull(.Item(i)("prod_loss_perc"), 0)) 'John 26/03/2026
                comm.Parameters.AddWithValue("@p_qty_with_loss", config.IsNull(.Item(i)("qty_with_loss"), 0)) 'John 26/03/2026
                comm.Parameters.AddWithValue("@p_hs_code", config.IsNull(.Item(i)("hs_code"), Nothing)) 'John 18/05/2026
                comm.Parameters.AddWithValue("@p_sample_fabric_qty", config.IsNull(.Item(i)("sample_fabric_qty"), 0))
                comm.Parameters.AddWithValue("@p_sample_bulk_qty", config.IsNull(.Item(i)("sample_bulk_qty"), 0))
                comm.Parameters.AddWithValue("@p_price_list_override_reason", config.IsNull(.Item(i)("price_list_override_reason"), Nothing))

                ' last Record update
                comm.Parameters.AddWithValue("@logempcd", SOH.h30_log_empcd) 'last record update

            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        'Delete Detail----------

        i = 0
        comm.CommandText = "p_soitm_delete"

        For i = 0 To SOD_DEL.Count - 1
            With SOD_DEL(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item("sonoid"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", SOH.h30_log_empcd)
            End With
            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function SOCancel(ByVal strSoNo As String, ByVal strEmpCD As String) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_cancel"
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@log_empcd", strEmpCD)
        If comm.ExecuteNonQuery() = -1 Then
            tran.Commit()
            conn.Close()  'Sitthana 20190325
            Return True
        Else
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End If
    End Function
    Public Function SOUnCancelled(ByVal strSoNo As String, ByVal strEmpCD As String) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_uncancelled"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@log_empcd", strEmpCD)
        If comm.ExecuteNonQuery() = -1 Then
            tran.Commit()
            conn.Close()  'Sitthana 20190325
            Return True
        Else
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End If
    End Function
    Public Function SOClose(ByVal dt As DataTable, ByRef msgerr As String, ByVal strEmpCD As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_close"
        For i = 0 To dt.Rows.Count - 1
            If config.IsNull(dt.Rows(i)("sonoid"), "").ToString.Trim.Length > 0 Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(dt.Rows(i)("sonoid"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@closed", IIf(config.IsNull(dt.Rows(i)("closed"), False), 1, 0))
                comm.Parameters.AddWithValue("@log_empcd", strEmpCD)
                comm.Parameters.AddWithValue("@rem_soitm", config.IsNull(dt.Rows(i)("rem_soitm"), "").ToString.Trim)

                Try
                    Call comm.ExecuteNonQuery()
                Catch ex As Exception
                    msgerr = ex.Message
                    tran.Rollback()
                    conn.Close()  'Sitthana 20190325
                    Return False
                End Try
            End If
        Next
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Sub SOConfirm(ByVal sono As String, ByVal log_empcd As String)
        Dim config As New clsConfig
        Dim msgErr As String
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_confirm_order"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_sono", sono)
        comm.Parameters.AddWithValue("@log_empcd", log_empcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            tran.Commit()
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            msgErr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
        End Try
        conn.Close()
    End Sub
    Public Sub SOUnConfirm(ByVal sono As String, ByVal log_empcd As String)
        Dim config As New clsConfig
        Dim msgErr As String
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_unconfirm_order"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_sono", sono)
        comm.Parameters.AddWithValue("@log_empcd", log_empcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
            tran.Commit()
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            msgErr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
        End Try
        conn.Close()
    End Sub

    Public Function ValidateSOFlowStatus(ByVal StrSoNo As String) As Boolean

        Dim conn As New SqlConnection((New ClassConnection).connection())
        conn.Open()
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_PKG_validate_flow_status_code"
        comm.Parameters.AddWithValue("@sono", StrSoNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325

        End Try

        If dt.Rows.Count > 0 Then
            If (New clsConfig).IsNull(dt.Rows(0)("flow_status_code"), "").ToString = "CFM" Then Return True
            If (New clsConfig).IsNull(dt.Rows(0)("flow_status_code"), "").ToString = "ENT" Then Return False
        End If

        Return True
    End Function
    Public Function getSoData(ByVal pSoNo As String) As DataTable
        'Sitthana 15/08/2018
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_CMR_PKG_find_so"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_sono", pSoNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function getCustomersBillToFlag() As DataTable
        'Sitthana 15/08/2018
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_FORM_PKG_get_customers_bill_to_flag"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getCustomersShipToFlag() As DataTable
        'Sitthana 15/08/2018
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_FORM_PKG_get_customers_ship_to_flag"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    'Get data from report for export to excel
    Public Function getSoNotClosed(PM_DateFr As String, PM_DateTo As String, PM_Closed As Integer _
                                 , PM_LogEmpCd As String, PM_EmpCd As String, PM_EmpType As Integer _
                                 , PM_DesignNo As String, PM_CustomerName As String _
                                 , PM_SortBy As String, PM_DateOf As String
                                   ) As DataTable
        'Sitthana 05/08/2024
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_not_closed_export_to_excel"
        comm.Parameters.AddWithValue("@datefr", PM_DateFr)
        comm.Parameters.AddWithValue("@dateto", PM_DateTo)
        comm.Parameters.AddWithValue("@closed", PM_Closed)
        comm.Parameters.AddWithValue("@logempcd", PM_LogEmpCd)
        comm.Parameters.AddWithValue("@empcd", PM_EmpCd)
        comm.Parameters.AddWithValue("@emp_type", PM_EmpType)
        comm.Parameters.AddWithValue("@design_no", PM_DesignNo)
        comm.Parameters.AddWithValue("@customer_name", PM_CustomerName)
        comm.Parameters.AddWithValue("@Sort_By", PM_SortBy)
        comm.Parameters.AddWithValue("@dateof", PM_DateOf)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function getSoNotClosedRelateGamma(PM_DateFr As String, PM_DateTo As String, PM_Closed As Integer _
                                     , PM_LogEmpCd As String, PM_EmpCd As String, PM_EmpType As Integer _
                                     , PM_DesignNo As String, PM_CustomerName As String _
                                     , PM_SortBy As String, PM_DateOf As String
                                       ) As DataTable
        'Sitthana 05/08/2024
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_SO_PKG_so_not_closed_refer_gamma_rep"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@datefr", PM_DateFr)
        comm.Parameters.AddWithValue("@dateto", PM_DateTo)
        comm.Parameters.AddWithValue("@closed", PM_Closed)
        comm.Parameters.AddWithValue("@logempcd", PM_LogEmpCd)
        comm.Parameters.AddWithValue("@empcd", PM_EmpCd)
        comm.Parameters.AddWithValue("@emp_type", PM_EmpType)
        comm.Parameters.AddWithValue("@design_no", PM_DesignNo)
        comm.Parameters.AddWithValue("@customer_name", PM_CustomerName)
        comm.Parameters.AddWithValue("@Sort_By", PM_SortBy)
        comm.Parameters.AddWithValue("@dateof", PM_DateOf)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    ''' <summary>
    ''' The price line(s) that apply to one order line's design/color/uom/qty, or the
    ''' candidates to choose from when SO.P_SO_PRICE_LIST_PKG_select_price_line can't
    ''' decide on its own (see the "resolution" column: matched / design ambiguous /
    ''' quantity ambiguous / colour and quantity ambiguous). Empty result = no match.
    ''' -- John 29/09/2026
    ''' </summary>
    Public Function selectPriceLine(pSoPriceListHeaderId As Nullable(Of Int64), pDesignNo As String, pColorCode As String, pUom As String, pQty As Decimal, pCurr As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "SO.P_SO_PRICE_LIST_PKG_select_price_line"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_so_price_list_header_id", pSoPriceListHeaderId)
        comm.Parameters.AddWithValue("@p_design_no", pDesignNo)
        comm.Parameters.AddWithValue("@p_color_code", pColorCode)
        comm.Parameters.AddWithValue("@p_uom", pUom)
        comm.Parameters.AddWithValue("@p_qty", pQty)
        comm.Parameters.AddWithValue("@p_curr", If(String.IsNullOrEmpty(pCurr), "", pCurr))
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
End Class
