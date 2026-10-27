Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class classStockG
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
        Dim h27_outreqdt As Date
        Dim h28_outreqtyp As String
        Dim h29_outno As String
        Dim h30_outdt As Nullable(Of DateTime)
        Dim h31_lot As String
        Dim h31_yr As String
        Dim h32_sh As String
        Dim h33_dfno As String
        Dim h34_col As String
        Dim h35_dhcod As String
        Dim h36_sono As String
        Dim h37_sonoid As String
        Dim h38_roll_no_o As String
        Dim h39_pn As Double
        Dim h40_ydkg_g As Double
        Dim h41_cost As Decimal
        Dim h42_fload As Boolean
        Dim h43_rate As Decimal
        Dim h44_sel As Boolean
        Dim h45_cost_g As Double
        Dim h46_cliped As Boolean
        Dim h47_unit As String
        Dim h48_g_cost As Double
        Dim h49_tran_no1 As String
        Dim h50_tran_not As String
        Dim h51_cancel As Boolean
        Dim h52_doctyp As String
        Dim h53_preseted As Boolean
        Dim h54_qcalertcd As String
        Dim h55_ProdFinishDate As Date
        Dim h56_ProdFinishTime As String
        Dim h57_mcno As String
        Dim h58_adjust_loss_kg As Boolean
        Dim h59_qc_loss_kg As Double
        Dim h60_dyed_loss_kg As Double
        Dim h61_grade_bdt As String
        Dim h62_grade_adt As String
        Dim h63_dyeing_pass As Boolean
        Dim h64_dyeing_fail As Boolean
        Dim h65_shift As String
        Dim h65_id_greige_do As Int64
        Dim h66_id_greige As Int64
        Dim h67_lab_loss_kg As Boolean
        Dim h68_defect_loss_kg As Boolean
        Dim h69_purno As String
        Dim h70_tran_type As String
        Dim h71_roll_no_f As String
        Dim h72_job_line_id As String
        Dim h73_fabric_cost As Boolean
        Dim h74_process_cost As Boolean
        Dim h75_process_loss_perc As Boolean
        Dim h76_other_cost As Boolean
        Dim h77_cost_per_unit As Boolean
        Dim h78_sub_location As String
        Dim h79_greige_status As Byte
        Dim h80_bar_weight As Double

    End Structure
    'Conversion Project
    Public Function ValidateOutNoByPackno(ByVal Strpackno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_validate_g_out"
        comm.Parameters.AddWithValue("@packno", Strpackno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINNoByDate(Optional ByVal strDONO As String = "", Optional ByVal strStockType As String = "A", Optional ByVal tran_no As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_do_manual_select_by_date"
        comm.Parameters.AddWithValue("@dono", strDONO)
        comm.Parameters.AddWithValue("@doctyp", strStockType.Trim)
        comm.Parameters.AddWithValue("@tran_no", tran_no)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetComboGOut() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_combo_gout_no"
        comm.CommandText = "p_greige_do_manual_combo_gout_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetComboGin(ByRef strDoctype As String, ByRef StrDocno As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandText = "p_greige_in_list_docno"
        comm.Parameters.AddWithValue("@type", strDoctype)
        comm.Parameters.AddWithValue("@docno", StrDocno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetCBOGINPFDmanualNo(Optional ByVal StrTran_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_pfd_manual_combo_din_no"
        comm.Parameters.AddWithValue("@tran_no", StrTran_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetCBOGINPOmanualNo(Optional ByVal StrTran_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_po_manual_select_cbo_gin"
        comm.Parameters.AddWithValue("@tran_no", StrTran_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetCBOGINReturnManualNo(Optional ByVal StrTran_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_return_manual_combo_gin_no"
        comm.Parameters.AddWithValue("@tran_no", StrTran_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINPOmanual(Optional ByVal StrTran_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_po_manual_select"
        comm.Parameters.AddWithValue("@tran_no", StrTran_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINPFDmanual(Optional ByVal StrTran_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_pfd_manual_select"
        comm.Parameters.AddWithValue("@tran_no", StrTran_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINReturnmanual(Optional ByVal StrTran_no As String = "", Optional ByVal strEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_return_manual_select"
        comm.Parameters.AddWithValue("@tran_no", StrTran_no)
        comm.Parameters.AddWithValue("@logempcd", strEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGOut(ByVal strOUTNo As String, ByVal strEmpCD As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_do_manual_select"
        'comm.CommandText = "p_greige_do_from_design_no"
        comm.Parameters.AddWithValue("@outno", strOUTNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINReturnManualByGOUT(Optional ByVal strOUTNo As String = "", Optional ByVal strEmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_return_manual_select_gout"
        'comm.CommandText = "p_greige_do_from_design_no"
        comm.Parameters.AddWithValue("@outno", strOUTNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINPOManualSearchPO(Optional ByVal strPOno As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strsuppcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_po_manual_select_po_search"

        comm.Parameters.AddWithValue("@jobno", strPOno)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@suppcd", strsuppcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINKOManualSearchKO(Optional ByVal strkono As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strsuppcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_ko_manual_select_ko_search"

        comm.Parameters.AddWithValue("@kono", strkono)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@suppcd", strsuppcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GetGINPOByPO(Optional ByVal strPOno As String = "", Optional ByVal strEmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_in_po_manual_select_po"

        comm.Parameters.AddWithValue("@jobno", strPOno)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
   
    'Conversion Project
    Public Function GetGOutByDesign(ByVal strDesignNo As String, ByVal strEmpCD As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_greige_do_manual_design_no_select"
        'comm.CommandText = "p_greige_do_from_design_no"
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function CancelGOut(outno As String, loginempcd As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_do_manual_delete"
        comm.Parameters.AddWithValue("@outno", outno)
        'EDIT BY NEUNG 06/02/2015 @logempcd is not member of p_greige_do_delete
        'comm.Parameters.AddWithValue("@logempcd", loginempcd)
        comm.Parameters.AddWithValue("@loginempcd", loginempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function GetDForder_Items(ByVal strDFNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_greige_in_from_df"
        comm.CommandText = "p_greige_in_pfd_manual_dforder_select"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function SaveGOutManual(ByRef Stroutno As String, ByVal dt As DataTable, ByVal strRackNo As String, ByVal logempcd As String) As Boolean
        If dt Is Nothing Or dt.Rows.Count = 0 Then Return False

        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim i As Integer = 0
        Dim outno As String = ""


        outno = dt.Rows(0)("outno").ToString().Trim()

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_do_manual_update"

        'Add Detail----------

        For Each dr As DataRow In dt.Rows
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@design_no", config.IsNull(dr("design_no"), "").Trim)
            comm.Parameters.AddWithValue("@nob", config.IsNull(dr("nob"), "").ToString)
            comm.Parameters.AddWithValue("@Gwth", config.IsNull(dr("Gwth"), "").Trim)
            comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(dr("roll_no_g"), "").Trim)
            comm.Parameters.AddWithValue("@outkg_g", config.IsNull(dr("outkg_g"), 0))
            comm.Parameters.AddWithValue("@outmt_g", config.IsNull(dr("outmt_g"), 0))
            comm.Parameters.AddWithValue("@outyd_g", config.IsNull(dr("outyd_g"), 0))
            comm.Parameters.AddWithValue("@grade", config.IsNull(dr("grade"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@loc", config.IsNull(dr("loc"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@outreqno", config.IsNull(dr("outreqno"), "").Trim)
            comm.Parameters.AddWithValue("@outreqdt", config.IsNull(dr("outreqdt"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(dr("outreqtyp"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@outno", config.IsNull(outno, "").ToString.Trim)
            comm.Parameters.AddWithValue("@outdt", config.IsNull(dr("outdt"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@sh", config.IsNull(dr("sh"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@dfno", config.IsNull(dr("dfno"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@col", config.IsNull(dr("col"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@sono", config.IsNull(dr("sono"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@sonoid", config.IsNull(dr("sonoid"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(dr("roll_no_o"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@startat", config.IsNull(dr("startat"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@flagL", config.IsNull(dr("flagL"), "").Trim)
            comm.Parameters.AddWithValue("@cost", config.IsNull(dr("cost"), 0))
            comm.Parameters.AddWithValue("@fload", config.IsNull(dr("fload"), 0).ToString)  'Check It Again
            comm.Parameters.AddWithValue("@rate", config.IsNull(dr("rate"), 0))
            comm.Parameters.AddWithValue("@cost_g", config.IsNull(dr("cost_g"), 0))
            comm.Parameters.AddWithValue("@outno1", config.IsNull(dr("outno1"), "").Trim)
            comm.Parameters.AddWithValue("@outnot", config.IsNull(dr("outnot"), "").Trim)
            comm.Parameters.AddWithValue("@packno", config.IsNull(dr("packno"), "").Trim)
            comm.Parameters.AddWithValue("@cartno", config.IsNull(dr("cartno"), "").ToString)
            comm.Parameters.AddWithValue("@packdt", config.IsNull(dr("packdt"), ""))
            comm.Parameters.AddWithValue("@pono", config.IsNull(dr("pono"), "").Trim)
            comm.Parameters.AddWithValue("@invno", config.IsNull(dr("invno"), "").Trim)
            comm.Parameters.AddWithValue("@cancel", config.IsNull(dr("cancel"), "").ToString)
            comm.Parameters.AddWithValue("@cliped", config.IsNull(dr("cliped"), "").ToString)
            comm.Parameters.AddWithValue("@preseted", config.IsNull(dr("preseted"), "").ToString)
            comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(dr("id_greige_do"), 0))
            comm.Parameters.AddWithValue("@rack_no", config.IsNull(strRackNo, ""))
            comm.Parameters.AddWithValue("@log_empcd", config.IsNull(logempcd, ""))

            'Dim xxx As String = config.BuildSQL(comm)
            'Debug.Print(xxx)

            da = New SqlDataAdapter(comm)
            dt = New DataTable
            Try
                da.Fill(dt)
            Catch ex As Exception
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Throw ex
            End Try

            outno = dt.Rows(0)("outno").ToString().Trim()
        Next

        Stroutno = outno
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    Public Function SaveGINPFDManual(ByVal strBillNo As String, ByVal strEmpCode As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_update_by_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        comm.CommandTimeout = 360
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    'Conversion Project
    Public Function GinPFDsave(ByVal Gin_header As Greige_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String) As Boolean
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

        'Start Gen DIN No----------
        comm.CommandText = "p_greige_in_pfd_manual_gen_doc"
        With Gin_header
            'comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)
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

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "p_greige_in_pfd_manual_insert"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)    'Tran_No = GIN NO
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))         'Tran_Dt = GIN Date
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(Gin_header.h25_loc, "").trim)           'Loc = NEW
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(Gin_header.h53_preseted, 0))                'Preseted = 1
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(Gin_header.h70_tran_type, "").trim)            'Tran_Type = PRESET
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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
            'strRoll_no_o = dt.Rows(0)("roll_no_o").ToString.Trim
        Next
        'End Add Cartons----------

        'Start update Cartons----------

        comm.CommandText = "p_greige_in_pfd_manual_update"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(.Item(j)("tran_no"), "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(.Item(j)("tran_dt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                'comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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

        comm.CommandText = "p_greige_in_pfd_manual_delete"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(.Item(j)("tran_no"), "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(.Item(j)("tran_dt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                'comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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
        Dim doctyp As String = "GIN"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Tran_no)
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
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function GINPOsave(ByVal Gin_header As Greige_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String) As Boolean
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

        'Start Gen DIN No----------
        comm.CommandText = "p_greige_in_po_manual_gen_doc"
        With Gin_header
            'comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)
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

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "p_greige_in_po_manual_insert"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)    'Tran_No = GIN NO
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))         'Tran_Dt = GIN Date
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(Gin_header.h25_loc, "").trim)           'Loc = NEW
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), ""))            'Preseted = 1
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(Gin_header.h70_tran_type, "").trim)            'Tran_Type = PRESET
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", config.IsNull(.Item(j)("mtl_warehouse_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", config.IsNull(.Item(j)("mtl_subinventory_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_locations_id", config.IsNull(.Item(j)("mtl_locations_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                comm.Parameters.AddWithValue("@id_jobdet", config.IsNull(.Item(j)("id_jobdet"), DBNull.Value))
                comm.Parameters.AddWithValue("@sinvno", config.IsNull(.Item(j)("sinvno"), DBNull.Value))
                comm.Parameters.AddWithValue("@sinvdt", config.IsNull(.Item(j)("sinvdt"), DBNull.Value))
                comm.Parameters.AddWithValue("@lotno_sup", config.IsNull(.Item(j)("lotno_sup"), DBNull.Value))
                comm.Parameters.AddWithValue("@srefno", config.IsNull(.Item(j)("srefno"), DBNull.Value))
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
            'strRoll_no_o = dt.Rows(0)("roll_no_o").ToString.Trim
        Next
        'End Add Cartons----------

        'Start update Cartons----------

        comm.CommandText = "p_greige_in_po_manual_update"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(.Item(j)("tran_no"), "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(.Item(j)("tran_dt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", config.IsNull(.Item(j)("mtl_warehouse_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", config.IsNull(.Item(j)("mtl_subinventory_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_locations_id", config.IsNull(.Item(j)("mtl_locations_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                comm.Parameters.AddWithValue("@id_jobdet", config.IsNull(.Item(j)("id_jobdet"), DBNull.Value))
                comm.Parameters.AddWithValue("@sinvno", config.IsNull(.Item(j)("sinvno"), DBNull.Value))
                comm.Parameters.AddWithValue("@sinvdt", config.IsNull(.Item(j)("sinvdt"), DBNull.Value))
                comm.Parameters.AddWithValue("@lotno_sup", config.IsNull(.Item(j)("lotno_sup"), DBNull.Value))
                comm.Parameters.AddWithValue("@srefno", config.IsNull(.Item(j)("srefno"), DBNull.Value))
                'comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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
        comm.CommandText = "p_greige_in_po_manual_insert_bin"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", config.IsNull(.Item(j)("mtl_warehouse_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", config.IsNull(.Item(j)("mtl_subinventory_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_locations_id", config.IsNull(.Item(j)("mtl_locations_id"), DBNull.Value))
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
            'Gin_header.h04_tran_no = dfc.Rows(0)("tran_no").ToString.Trim

        Next

        comm.CommandText = "p_greige_in_po_manual_delete"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(.Item(j)("tran_no"), "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(.Item(j)("tran_dt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", config.IsNull(.Item(j)("mtl_warehouse_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_subinventory_id", config.IsNull(.Item(j)("mtl_subinventory_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@mtl_locations_id", config.IsNull(.Item(j)("mtl_locations_id"), DBNull.Value))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                'comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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
        Dim doctyp As String = "GIN"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Tran_no)
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
        tran.Commit()
        Return True
    End Function
    
    'Conversion Project
    Public Function GinReturnManualsave(ByVal Gin_header As Greige_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String) As Boolean
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

        'Start Gen DIN No----------
        comm.CommandText = "p_greige_in_return_manual_gen_doc"
        With Gin_header
            'comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@tran_no", Gin_header.h04_tran_no)
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

        'END Gen PLD No----------
        'Start Add Cartons----------

        comm.CommandText = "p_greige_in_return_manual_insert"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(Gin_header.h03_source_refno, "").trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)    'Tran_No = GIN NO
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))         'Tran_Dt = GIN Date
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(Gin_header.h25_loc, "").trim)           'Loc = NEW
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(Gin_header.h29_outno, "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(Gin_header.h30_outdt, DBNull.Value))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(Gin_header.h52_doctyp, "").trim)      'doctyp = "K"
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(Gin_header.h70_tran_type, "").trim)            'Tran_Type = RETURN
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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
            'strRoll_no_o = dt.Rows(0)("roll_no_o").ToString.Trim
        Next
        'End Add Cartons----------

        'Start update Cartons----------

        comm.CommandText = "p_greige_in_return_manual_update"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(Gin_header.h03_source_refno, "").trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(.Item(j)("tran_no"), "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(.Item(j)("tran_dt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(Gin_header.h29_outno, "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(Gin_header.h30_outdt, DBNull.Value))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                'comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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

        comm.CommandText = "p_greige_in_return_manual_delete"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(.Item(j)("tran_no"), "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(.Item(j)("tran_dt"), ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(Gin_header.h29_outno, "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
                'comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
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
        Dim doctyp As String = "GIN"
        With Gin_header
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)
            comm.Parameters.AddWithValue("@docno", Tran_no)
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
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function GINPFDcancel(ByVal Gin_header As Greige_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start  Add PLD bin-----------
        comm.CommandText = "p_greige_in_pfd_manual_insert_bin"
        j = 0
        For j = 0 To dfc.Rows.Count - 1
            With dfc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
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
            Gin_header.h04_tran_no = dfc.Rows(0)("tran_no").ToString.Trim

        Next
        'End  Add PLG bin-----------

        'Start Delete PFD ----------

        j = 0
        comm.CommandText = "p_greige_in_pfd_manual_cancel"

        For j = 0 To dfc.Rows.Count - 1
            With dfc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            End With
            Dim dap_upd = New SqlDataAdapter(comm)
            Dim dtp_upd = New DataTable
            Try
                dap_upd.Fill(dtp_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try


        Next

        'Start Insert Action----------
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim Action As String = "CANCEL"
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
        'Strat Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function GINPOcancel(ByVal Gin_header As Greige_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start  Add PLD bin-----------
        comm.CommandText = "p_greige_in_po_manual_insert_bin"
        j = 0
        For j = 0 To dfc.Rows.Count - 1
            With dfc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
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
            Gin_header.h04_tran_no = dfc.Rows(0)("tran_no").ToString.Trim

        Next
        'End  Add PLG bin-----------

        'Start Delete PFD ----------

        j = 0
        comm.CommandText = "p_greige_in_po_manual_cancel"

        For j = 0 To dfc.Rows.Count - 1
            With dfc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            End With
            Dim dap_upd = New SqlDataAdapter(comm)
            Dim dtp_upd = New DataTable
            Try
                dap_upd.Fill(dtp_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try


        Next

        'Start Insert Action----------
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim Action As String = "CANCEL"
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
        'Strat Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    'Conversion Project
    Public Function GINRETURNcancel(ByVal Gin_header As Greige_Header, ByRef msgerr As String, ByVal dfc As DataTable, ByVal DV_DTC_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByRef UserID As String, ByRef Tran_no As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure

        'Start  Add PLD bin-----------
        comm.CommandText = "p_greige_in_return_manual_insert_bin"
        j = 0
        For j = 0 To dfc.Rows.Count - 1
            With dfc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
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
            'Gin_header.h04_tran_no = dfc.Rows(0)("tran_no").ToString.Trim

        Next
        'End  Add PLD bin-----------

        'Start Delete PD ----------

        j = 0
        comm.CommandText = "p_greige_in_return_manual_cancel"

        For j = 0 To dfc.Rows.Count - 1
            With dfc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@suppcd", config.IsNull(.Item(j)("suppcd"), "").Trim)
                comm.Parameters.AddWithValue("@source", config.IsNull(.Item(j)("source"), "").Trim)
                comm.Parameters.AddWithValue("@source_refno", config.IsNull(.Item(j)("source_refno"), "").Trim)
                comm.Parameters.AddWithValue("@tran_no", config.IsNull(Gin_header.h04_tran_no, "").Trim)
                comm.Parameters.AddWithValue("@tran_dt", config.IsNull(Gin_header.h05_tran_dt, ""))
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(j)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(j)("supdes_no"), "").Trim)
                comm.Parameters.AddWithValue("@kono", config.IsNull(.Item(j)("kono"), "").Trim)
                comm.Parameters.AddWithValue("@pieces", config.IsNull(.Item(j)("pieces"), 0))
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(j)("nob"), 0))
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(j)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth_actual", config.IsNull(.Item(j)("Gwth_actual"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(j)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(j)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_n", config.IsNull(.Item(j)("roll_no_n"), ""))
                comm.Parameters.AddWithValue("@racks", config.IsNull(.Item(j)("racks"), 0))
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(j)("kg"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(j)("mts"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(j)("yds"), 0))
                comm.Parameters.AddWithValue("@kg_qc", config.IsNull(.Item(j)("kg_qc"), 0))
                comm.Parameters.AddWithValue("@mts_qc", config.IsNull(.Item(j)("mts_qc"), 0))
                comm.Parameters.AddWithValue("@yds_qc", config.IsNull(.Item(j)("yds_qc"), 0))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(j)("grade"), ""))
                comm.Parameters.AddWithValue("@rem_qc", config.IsNull(.Item(j)("rem_qc"), "").trim)
                comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(j)("loc"), "").trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(j)("outreqno"), "").trim)
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(j)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(j)("outreqtyp"), "").trim)
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(j)("outno"), "").trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(j)("outdt"), ""))
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(j)("lot"), "").trim)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(j)("yr"), "").trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(j)("sh"), "").trim)
                comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(j)("dfno"), "").trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(j)("col"), "").trim)
                comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(j)("dhcod"), "").trim)
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(j)("sono"), "").trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(j)("sonoid"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(j)("roll_no_o"), "").trim)
                comm.Parameters.AddWithValue("@pn", config.IsNull(.Item(j)("pn"), 0))
                comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(j)("ydkg_g"), 0))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(j)("cost"), 0))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(j)("fload"), 0))
                comm.Parameters.AddWithValue("@rate", config.IsNull(.Item(j)("rate"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), 0))
                comm.Parameters.AddWithValue("@cost_g", config.IsNull(.Item(j)("cost_g"), 0))
                comm.Parameters.AddWithValue("@cliped", config.IsNull(.Item(j)("cliped"), 0))
                comm.Parameters.AddWithValue("@unit", config.IsNull(.Item(j)("unit"), "").trim)
                comm.Parameters.AddWithValue("@g_cost", config.IsNull(.Item(j)("g_cost"), 0))
                comm.Parameters.AddWithValue("@tran_no1", config.IsNull(.Item(j)("tran_no1"), "").trim)
                comm.Parameters.AddWithValue("@tran_not", config.IsNull(.Item(j)("tran_not"), "").trim)
                comm.Parameters.AddWithValue("@cancel", config.IsNull(.Item(j)("cancel"), 0))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(j)("doctyp"), "").trim)
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(j)("preseted"), 0))
                comm.Parameters.AddWithValue("@qcalertcd", config.IsNull(.Item(j)("qcalertcd"), "").trim)
                comm.Parameters.AddWithValue("@ProdFinishDate", config.IsNull(.Item(j)("ProdFinishDate"), ""))
                comm.Parameters.AddWithValue("@ProdFinishTime", config.IsNull(.Item(j)("ProdFinishTime"), ""))
                comm.Parameters.AddWithValue("@mcno", config.IsNull(.Item(j)("mcno"), "").trim)
                comm.Parameters.AddWithValue("@adjust_loss_kg", config.IsNull(.Item(j)("adjust_loss_kg"), 0))
                comm.Parameters.AddWithValue("@qc_loss_kg", config.IsNull(.Item(j)("qc_loss_kg"), 0))
                comm.Parameters.AddWithValue("@dyed_loss_kg", config.IsNull(.Item(j)("dyed_loss_kg"), 0))
                comm.Parameters.AddWithValue("@grade_bdt", config.IsNull(.Item(j)("grade_bdt"), "").trim)
                comm.Parameters.AddWithValue("@grade_adt", config.IsNull(.Item(j)("grade_adt"), "").trim)
                comm.Parameters.AddWithValue("@dyeing_pass", config.IsNull(.Item(j)("dyeing_pass"), 0))
                comm.Parameters.AddWithValue("@dyeing_fail", config.IsNull(.Item(j)("dyeing_fail"), 0))
                comm.Parameters.AddWithValue("@shift", config.IsNull(.Item(j)("shift"), "").trim)
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(j)("id_greige_do"), 0))
                comm.Parameters.AddWithValue("@id_greige", config.IsNull(.Item(j)("id_greige"), 0))
                comm.Parameters.AddWithValue("@lab_loss_kg", config.IsNull(.Item(j)("lab_loss_kg"), 0))
                comm.Parameters.AddWithValue("@defect_loss_kg", config.IsNull(.Item(j)("defect_loss_kg"), 0))
                comm.Parameters.AddWithValue("@purno", config.IsNull(.Item(j)("purno"), "").trim)
                comm.Parameters.AddWithValue("@tran_type", config.IsNull(.Item(j)("tran_type"), "").trim)
                comm.Parameters.AddWithValue("@roll_no_f", config.IsNull(.Item(j)("roll_no_f"), "").trim)
                comm.Parameters.AddWithValue("@job_line_id", config.IsNull(.Item(j)("job_line_id"), "").trim)
                comm.Parameters.AddWithValue("@fabric_cost", config.IsNull(.Item(j)("fabric_cost"), 0))
                comm.Parameters.AddWithValue("@process_cost", config.IsNull(.Item(j)("process_cost"), 0))
                comm.Parameters.AddWithValue("@process_loss_perc", config.IsNull(.Item(j)("process_loss_perc"), 0))
                comm.Parameters.AddWithValue("@other_cost", config.IsNull(.Item(j)("other_cost"), 0))
                comm.Parameters.AddWithValue("@cost_per_unit", config.IsNull(.Item(j)("cost_per_unit"), 0))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(j)("sub_location"), "").trim)
                comm.Parameters.AddWithValue("@greige_status", config.IsNull(.Item(j)("greige_status"), ""))
                comm.Parameters.AddWithValue("@bar_weight", config.IsNull(.Item(j)("bar_weight"), 0))
                comm.Parameters.AddWithValue("@logempcd", UserID.Trim)
            End With
            Dim dap_upd = New SqlDataAdapter(comm)
            Dim dtp_upd = New DataTable
            Try
                dap_upd.Fill(dtp_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try


        Next

        'Start Insert Action----------
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim Action As String = "CANCEL"
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
            Return False
        End Try
        'Strat Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class
