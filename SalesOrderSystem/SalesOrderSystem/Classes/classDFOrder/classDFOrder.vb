Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classDFOrder
    Dim oconfig As New clsConfig
    Public Structure DFHeader
        Dim h01_dhcod As String
        Dim h02_dfno As String
        Dim h03_dfdt As String
        Dim h04_design_no As String
        Dim h05_gwth As String
        Dim h06_fwth As String
        Dim h07_lot As String
        Dim h08_yr As String
        Dim h09_compo As String
        Dim h10_mtkg As Double
        Dim h11_dyetyp As String
        Dim h12_sono As String
        Dim h13_rptlen_d As Double
        Dim h14_rptwth_d As Double
        Dim h15_rptlen_s As Double
        Dim h16_rptwth_s As Double
        Dim h17_rolltyp As String
        Dim h18_packtyp As String
        Dim h19_nob As Integer
        Dim h20_supcod As String
        Dim h21_dhcolref As String
        Dim h22_dhcoldt As String
        Dim h23_typ As String
        Dim h24_AB As String
        Dim h25_status As String
        Dim h26_usewth As String
        Dim h27_labsubmit As Boolean
        Dim h28_urgent As Boolean
        Dim h29_urgentdt As String
        Dim h30_nophenyell As Boolean
        Dim h31_noazo As Boolean
        Dim h32_dyestd As String
        Dim h33_finlikesmp As Boolean
        Dim h34_grading As Boolean
        Dim h35_bulksub As Boolean
        Dim h36_bulkappdh As Boolean
        Dim h37_labeldes As String
        Dim h38_labelwth As String
        Dim h39_ph As Boolean
        Dim h40_refspec As Boolean
        Dim h41_rollcode As String
        Dim h42_lblcode As String
        Dim h43_pclen As String
        Dim h44_remark As String
        Dim h45_inoutwear As String
        Dim h46_rwbands As Integer
        Dim h47_cond As String
        Dim h48_sample As String
        Dim h49_lights As String
        Dim h50_D65 As Boolean
        Dim h51_D65_order As String
        Dim h52_TL83 As Boolean
        Dim h53_TL83_order As String
        Dim h54_TL84 As Boolean
        Dim h55_TL84_order As String
        Dim h56_inc As Boolean
        Dim h57_inc_order As String
        Dim h58_cwf As Boolean
        Dim h59_cwf_order As String
        Dim h60_d65m As Boolean
        Dim h61_d65m_order As String
        Dim h62_outreqno As String
        Dim h63_outno As String
        Dim h64_red As Boolean
        Dim h65_ref As Boolean
        Dim h66_delidt As String
        Dim h67_cfno As String
        Dim h68_dftyp As String
        Dim h69_dfrem As String
        Dim h70_pleat As Boolean
        Dim h71_holog As Boolean
        Dim h72_rev As Integer
        Dim h73_diff As String
        Dim h74_style As String
        Dim h75_newdesign As Boolean
        Dim h76_len As String
        Dim h77_wth As String
        Dim h78_ka_std As Boolean
        Dim h79_ga_std As Boolean
        Dim h80_cus_std As Boolean
        Dim h81_csample As Boolean
        Dim h82_cbulk As Boolean
        Dim h83_empcd As String
        Dim h84_issuedt As String
        Dim h85_TL84M As Boolean
        Dim h86_TL84M_order As String
        Dim h87_printing As Boolean
        Dim h88_sample_fabric As Double
        Dim h89_sample_hank As Double
        Dim h90_sample_card As Double
        Dim h91_dye As Boolean
        Dim h92_finish As Boolean
        Dim h93_preset As Boolean
        Dim h94_deliver_to As String
        Dim h95_deliver_by As String
        Dim h96_design_no_fg As String
        Dim h97_pleat_rem As String
        Dim h98_holog_rem As String
        Dim h99_print_rem As String
        Dim h100_embroidary As Boolean
        Dim h101_embroidary_rem As String
        Dim h102_width_type As Integer
        Dim h103_dye_loss_percent As Single
        Dim h104_poc_pdf_header_id As Nullable(Of Int64)
        Dim h105_addl_remark As String
        Dim h106_addl As Boolean
        Dim mts_per_roll As Double

        Dim h107_DFType As Int32   'Sitthana 08/03/2018
        Dim h108_DFTypeRemark As String  'Sitthana 08/03/2018
        Dim h109_Sprit As Boolean 'Sitthana 09/03/2018
        Dim h110_Brushing As Boolean  'Sitthana 16/05/2019 'Not changed yet (Change in GMK Only)
        Dim h111_oth_std As Boolean 'Sitthana 20200724
        Dim h112_oth_std_comment As String 'Sitthana 20200724
        Dim h113_garment As String 'Sitthana 20240112
    End Structure

    Public Function DFPRESETLoad(Optional ByVal strDFNo As String = "",
      Optional ByVal strDateFr As String = "",
      Optional ByVal strDateTo As String = "",
      Optional ByVal strSoNo As String = "",
      Optional ByVal strCustCD As String = "",
      Optional ByVal strDHCod As String = "",
      Optional ByVal strDesignNo As String = "",
      Optional ByVal strEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_preset_select"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@dhcod", strDHCod)
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@empcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetSODesign(Optional ByVal strSoNo As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_designs_select"
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetSODesignGrid(Optional ByVal strSoNo As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strDesignNo_fg As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 60
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_designs_grid"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@design_no_fg", strDesignNo_fg.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetSORollNoGrid(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strCustColor As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_items_g_onhand"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@dfno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@custcolor", strCustColor.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetSORollNoGridPKG(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strCustColor As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_FORM_PKG_dforder_items_g_onhand"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@dfno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@custcolor", strCustColor.Trim)
        comm.CommandTimeout = 100 'Sitthana 20220317

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        conn.Close()
        Return dt
    End Function

    Public Function GetSOColor(Optional ByVal strSoNo As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_color"
        comm.Parameters.AddWithValue("@sono", strSoNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetStkOutDesign(Optional ByVal strOutNo As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_stk_out_designs_select"
        comm.Parameters.AddWithValue("@outno", strOutNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetStkOutDesignGrid(Optional ByVal strOutNo As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strDesignNo_FG As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_stk_out_designs_grid"
        comm.Parameters.AddWithValue("@outno", strOutNo.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        'comm.Parameters.AddWithValue("@design_no_fg", strDesignNo_FG.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetStkOutDesignNo(Optional ByVal strOutNo As String = "") As String
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_stk_out_design_no"
        comm.Parameters.AddWithValue("@outno", strOutNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count > 0 Then Return dt.Rows(0)("design_no") Else Return ""
    End Function

    Public Function GetStkDesignNo(Optional ByVal strFGdesignNo As String = "") As String
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_stk_design_no"
        comm.Parameters.AddWithValue("@fg_design_no", strFGdesignNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count > 0 Then Return dt.Rows(0)("design_no") Else Return ""
    End Function

    Public Function GetSoNoByOutNo(Optional ByVal strOutNo As String = "") As String
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        'comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_sono_by_outno"
        comm.Parameters.AddWithValue("@outno", strOutNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count > 0 Then Return dt.Rows(0)("sono").ToString Else Return ""

    End Function

    Public Function GetAutoCompleteSoNo() As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_autocomplete_sono"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetAutoCompleteOutReqNo() As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_autocomplete_outreqno"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetSONOByReqNo(Optional ByVal strOutReqNo As String = "") As String
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        'comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_sono_by_reqno"
        comm.Parameters.AddWithValue("@outreqno", strOutReqNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count > 0 Then Return dt.Rows(0)("sono").ToString Else Return ""

    End Function

    Public Function GetDesignNoByReqNo(Optional ByVal strOutReqNo As String = "") As String
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        'comm.CommandTimeout = 600
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_design_no_by_outreqno"
        comm.Parameters.AddWithValue("@outreqno", strOutReqNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count > 0 Then Return dt.Rows(0)("design_no").ToString Else Return ""

    End Function

    Public Function GetSoDetail(Optional ByVal strSoNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal strOrder_Type As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_so_detail"
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@sodtfr", strDateFr)
        comm.Parameters.AddWithValue("@sodtto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@order_type", strOrder_Type)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetStkOutRollNoGrid(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strCustColor As String = "", Optional ByVal strOutNo As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_items_re_dyed"
        comm.Parameters.AddWithValue("@dfno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@custcolor", strCustColor.Trim)
        comm.Parameters.AddWithValue("@outno", strOutNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function GetStkOutRollNoGridPKG(Optional ByVal strDFNo As String = "", Optional ByVal strSoNoID As String = "", Optional ByVal strDesignNo As String = "", Optional ByVal strGwth As String = "", Optional ByVal strCol As String = "", Optional ByVal strCustColor As String = "", Optional ByVal strOutNo As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_FORM_PKG_dforder_items_re_dyed"
        comm.Parameters.AddWithValue("@dfno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sonoid", strSoNoID.Trim)
        comm.Parameters.AddWithValue("@design_no", strDesignNo.Trim)
        comm.Parameters.AddWithValue("@gwth", strGwth.Trim)
        comm.Parameters.AddWithValue("@col", strCol.Trim)
        comm.Parameters.AddWithValue("@custcolor", strCustColor.Trim)
        comm.Parameters.AddWithValue("@outno", strOutNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function DFLoad(Optional ByVal strDFNo As String = "",
       Optional ByVal strDateFr As String = "",
       Optional ByVal strDateTo As String = "",
       Optional ByVal strSoNo As String = "",
       Optional ByVal strCustCD As String = "",
       Optional ByVal strDHCod As String = "",
       Optional ByVal strDesignNo As String = "",
       Optional ByVal strEmpCD As String = "") As DataTable

        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_select"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@sono", strSoNo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@dhcod", strDHCod)
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@empcd", strEmpCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function DFComboLoad() As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_combo"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function DFDetLoad(ByVal strDFNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_items_select"
        comm.Parameters.AddWithValue("@DFno", strDFNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function DFDetLoadPKG(ByVal strDFNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_FORM_PKG_dforder_items_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@DFno", strDFNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function DFDetLoad2(ByVal strDFNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_items_select2"
        comm.Parameters.AddWithValue("@DFno", strDFNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function DFDetLoadFromReq(ByVal strDFNo As String, ByVal strReqNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_items_select_req"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function getStatusFabric(pDfNo As String) As String
        'Writen By    : Sitthana Boonlom
        'Writen Date  : 20211027

        Dim StatusFabric As String = ""
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_PKG_get_status_fabric"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_dfno", pDfNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            StatusFabric = oconfig.isnull(dt.Rows(0)("inventory_type_name"), "")
        End If

        conn.Close()

        Return StatusFabric
    End Function

    Public Function DFDetLoadFromReqPKG(ByVal strDFNo As String, ByVal strReqNo As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_FORM_PKG_dforder_items_select_req"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function IsAlreadyGOUT(ByVal strDFNo As String) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_cancel_chk"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows(0)(0) = "" Then
            Return False
        Else
            MessageBox.Show(dt.Rows(0)(0), "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
    End Function

    Public Function DFSave(ByVal DFH As DFHeader, ByVal DFD_ADD As DataView, ByVal DFD_UPD As DataView, ByVal DFD_DEL As DataView, ByRef msgerr As String, ByRef DFNo As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_update"
        With DFH
            comm.Parameters.AddWithValue("@dhcod", .h01_dhcod.Trim)
            comm.Parameters.AddWithValue("@dfno", .h02_dfno.Trim)
            comm.Parameters.AddWithValue("@dfdt", .h03_dfdt.Trim)
            comm.Parameters.AddWithValue("@design_no", .h04_design_no.Trim)
            comm.Parameters.AddWithValue("@gwth", .h05_gwth.Trim)
            comm.Parameters.AddWithValue("@fwth", .h06_fwth.Trim)
            comm.Parameters.AddWithValue("@lot", .h07_lot.Trim)
            comm.Parameters.AddWithValue("@yr", .h08_yr.Trim)
            comm.Parameters.AddWithValue("@compo", .h09_compo.Trim)
            comm.Parameters.AddWithValue("@mtkg", .h10_mtkg)
            comm.Parameters.AddWithValue("@dyetyp", .h11_dyetyp.Trim)
            comm.Parameters.AddWithValue("@sono", .h12_sono.Trim)
            comm.Parameters.AddWithValue("@rptlen_d", .h13_rptlen_d)
            comm.Parameters.AddWithValue("@rptwth_d", .h14_rptwth_d)
            comm.Parameters.AddWithValue("@rptlen_s", .h15_rptlen_s)
            comm.Parameters.AddWithValue("@rptwth_s", .h16_rptwth_s)
            comm.Parameters.AddWithValue("@rolltyp", .h17_rolltyp.Trim)
            comm.Parameters.AddWithValue("@packtyp", .h18_packtyp.Trim)
            comm.Parameters.AddWithValue("@nob", .h19_nob.ToString)
            comm.Parameters.AddWithValue("@supcod", .h20_supcod.Trim)
            comm.Parameters.AddWithValue("@dhcolref", .h21_dhcolref.Trim)
            comm.Parameters.AddWithValue("@dhcoldt", .h22_dhcoldt.Trim)
            comm.Parameters.AddWithValue("@typ", .h23_typ.Trim)
            comm.Parameters.AddWithValue("@AB", .h24_AB.Trim)
            comm.Parameters.AddWithValue("@status", .h25_status.Trim)
            comm.Parameters.AddWithValue("@usewth", .h26_usewth.Trim)
            comm.Parameters.AddWithValue("@labsubmit", .h27_labsubmit)
            comm.Parameters.AddWithValue("@urgent", .h28_urgent)
            comm.Parameters.AddWithValue("@urgentdt", .h29_urgentdt.Trim)
            comm.Parameters.AddWithValue("@nophenyell", .h30_nophenyell)
            comm.Parameters.AddWithValue("@noazo", .h31_noazo)
            comm.Parameters.AddWithValue("@dyestd", .h32_dyestd.Trim)
            comm.Parameters.AddWithValue("@finlikesmp", .h33_finlikesmp)
            comm.Parameters.AddWithValue("@grading", .h34_grading)
            comm.Parameters.AddWithValue("@bulksub", .h35_bulksub)
            comm.Parameters.AddWithValue("@bulkappdh", .h36_bulkappdh)
            comm.Parameters.AddWithValue("@labeldes", .h37_labeldes.Trim)
            comm.Parameters.AddWithValue("@labelwth", .h38_labelwth.Trim)
            comm.Parameters.AddWithValue("@ph", .h39_ph)
            comm.Parameters.AddWithValue("@refspec", .h40_refspec)
            comm.Parameters.AddWithValue("@rollcode", .h41_rollcode.Trim)
            comm.Parameters.AddWithValue("@lblcode", .h42_lblcode.Trim)
            comm.Parameters.AddWithValue("@pclen", .h43_pclen.Trim)
            comm.Parameters.AddWithValue("@remark", .h44_remark.Trim)
            comm.Parameters.AddWithValue("@inoutwear", .h45_inoutwear.Trim)
            comm.Parameters.AddWithValue("@rwbands", .h46_rwbands.ToString)
            comm.Parameters.AddWithValue("@cond", .h47_cond.Trim)
            comm.Parameters.AddWithValue("@sample", .h48_sample.Trim)
            comm.Parameters.AddWithValue("@lights", .h49_lights.Trim)
            comm.Parameters.AddWithValue("@D65", .h50_D65)
            comm.Parameters.AddWithValue("@D65_order", .h51_D65_order.Trim)
            comm.Parameters.AddWithValue("@TL83", .h52_TL83)
            comm.Parameters.AddWithValue("@TL83_order", .h53_TL83_order.Trim)
            comm.Parameters.AddWithValue("@TL84", .h54_TL84)
            comm.Parameters.AddWithValue("@TL84_order", .h55_TL84_order.Trim)
            comm.Parameters.AddWithValue("@inc", .h56_inc)
            comm.Parameters.AddWithValue("@inc_order", .h57_inc_order.Trim)
            comm.Parameters.AddWithValue("@cwf", .h58_cwf)
            comm.Parameters.AddWithValue("@cwf_order", .h59_cwf_order.Trim)
            comm.Parameters.AddWithValue("@d65m", .h60_d65m)
            comm.Parameters.AddWithValue("@d65m_order", .h61_d65m_order.Trim)
            comm.Parameters.AddWithValue("@outreqno", .h62_outreqno.Trim)
            comm.Parameters.AddWithValue("@outno", .h63_outno.Trim)
            comm.Parameters.AddWithValue("@red", .h64_red)
            comm.Parameters.AddWithValue("@ref", .h65_ref)
            comm.Parameters.AddWithValue("@delidt", .h66_delidt.Trim)
            comm.Parameters.AddWithValue("@cfno", .h67_cfno.Trim)
            comm.Parameters.AddWithValue("@dftyp", .h68_dftyp.Trim)
            comm.Parameters.AddWithValue("@dfrem", .h69_dfrem.Trim)
            comm.Parameters.AddWithValue("@pleat", .h70_pleat)
            comm.Parameters.AddWithValue("@holog", .h71_holog)
            comm.Parameters.AddWithValue("@rev", .h72_rev.ToString)
            comm.Parameters.AddWithValue("@diff", .h73_diff.Trim)
            comm.Parameters.AddWithValue("@style", .h74_style.Trim)
            comm.Parameters.AddWithValue("@newdesign", .h75_newdesign)
            comm.Parameters.AddWithValue("@len", .h76_len.Trim)
            comm.Parameters.AddWithValue("@wth", .h77_wth.Trim)
            comm.Parameters.AddWithValue("@ka_std", .h78_ka_std)
            comm.Parameters.AddWithValue("@ga_std", .h79_ga_std)
            comm.Parameters.AddWithValue("@cus_std", .h80_cus_std)
            comm.Parameters.AddWithValue("@csample", .h81_csample)
            comm.Parameters.AddWithValue("@cbulk", .h82_cbulk)
            comm.Parameters.AddWithValue("@empcd", .h83_empcd.Trim)
            comm.Parameters.AddWithValue("@issuedt", .h84_issuedt.Trim)
            comm.Parameters.AddWithValue("@TL84M", .h85_TL84M)
            comm.Parameters.AddWithValue("@TL84M_order", .h86_TL84M_order.Trim)
            comm.Parameters.AddWithValue("@printing", .h87_printing)
            comm.Parameters.AddWithValue("@sample_fabric", .h88_sample_fabric.ToString)
            comm.Parameters.AddWithValue("@sample_hank", .h89_sample_hank.ToString)
            comm.Parameters.AddWithValue("@sample_card", .h90_sample_card.ToString)
            comm.Parameters.AddWithValue("@dye", .h91_dye)
            comm.Parameters.AddWithValue("@finish", .h92_finish)
            comm.Parameters.AddWithValue("@preset", .h93_preset)
            comm.Parameters.AddWithValue("@deliver_to", .h94_deliver_to.Trim)
            comm.Parameters.AddWithValue("@deliver_by", .h95_deliver_by.Trim)
            comm.Parameters.AddWithValue("@design_no_fg", .h96_design_no_fg.Trim)
            comm.Parameters.AddWithValue("@pleat_rem", .h97_pleat_rem.Trim)
            comm.Parameters.AddWithValue("@holog_rem", .h98_holog_rem.Trim)
            comm.Parameters.AddWithValue("@print_rem", .h99_print_rem.Trim)
            comm.Parameters.AddWithValue("@embroidary", .h100_embroidary)
            comm.Parameters.AddWithValue("@embroidary_rem", .h101_embroidary_rem.Trim)
            comm.Parameters.AddWithValue("@width_type", .h102_width_type)
            comm.Parameters.AddWithValue("@dye_loss_percent", .h103_dye_loss_percent)
            comm.Parameters.AddWithValue("@mts_per_roll", .mts_per_roll)
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
        DFNo = dt.Rows(0)("dfno").ToString.Trim
        strLotNo = dt.Rows(0)("lot").ToString.Trim

        'Delete Detail----------

        i = 0
        comm.CommandText = "p_dforder_items_delete"

        For i = 0 To DFD_DEL.Count - 1
            With DFD_DEL(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dfno", DFNo)
                comm.Parameters.AddWithValue("@roll_no", .Item("roll_no").ToString.Trim)
                comm.Parameters.AddWithValue("@col", .Item("col").ToString.Trim)
                comm.Parameters.AddWithValue("@id_dforder_items", .Item("id_dforder_items"))
                comm.Parameters.AddWithValue("@log_empcd", DFH.h83_empcd)
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

        'Add Detail----------

        i = 0
        comm.CommandText = "p_dforder_items_update"
        For i = 0 To DFD_ADD.Count - 1
            With DFD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dfno", DFNo)
                'comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", DFH.h04_design_no.Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                'comm.Parameters.AddWithValue("@gwth", DFH.h05_gwth.Trim)
                comm.Parameters.AddWithValue("@lot", strLotNo)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
                comm.Parameters.AddWithValue("@rolls", config.IsNull(.Item(i)("rolls"), 0).ToString)
                comm.Parameters.AddWithValue("@qc_kg", config.IsNull(.Item(i)("qc_kg"), 0))
                comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                'Edit By Neung User Need Use Fs_mts For Dyed House
                'comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                comm.Parameters.AddWithValue("@qc_yds", config.IsNull(.Item(i)("qc_yds"), 0))
                'comm.Parameters.AddWithValue("@fs_mts", config.IsNull(.Item(i)("fs_mts"), 0))
                'comm.Parameters.AddWithValue("@fs_yds", config.IsNull(.Item(i)("fs_yds"), Nothing))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "").Trim)
                comm.Parameters.AddWithValue("@outreqdt", CDate(config.IsNull(.Item(i)("outreqdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhcolref", config.IsNull(.Item(i)("dhcolref_d"), "").Trim)
                comm.Parameters.AddWithValue("@dhcoldt", CDate(config.IsNull(.Item(i)("dhcoldt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), "").Trim)
                comm.Parameters.AddWithValue("@labdipno", config.IsNull(.Item(i)("labdipno"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@flagpost", config.IsNull(.Item(i)("flagpost"), False))
                comm.Parameters.AddWithValue("@closed", config.IsNull(.Item(i)("closed"), False))
                comm.Parameters.AddWithValue("@closedt", CDate(config.IsNull(.Item(i)("closedt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@delidt", CDate(config.IsNull(.Item(i)("delidt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@REM", config.IsNull(.Item(i)("rem"), "").Trim)
                comm.Parameters.AddWithValue("@dhfabrcdt", CDate(config.IsNull(.Item(i)("dhfabrcdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhordref", config.IsNull(.Item(i)("dhordref"), "").Trim)
                comm.Parameters.AddWithValue("@design_no_fg", config.IsNull(DFH.h96_design_no_fg, "").Trim)
                comm.Parameters.AddWithValue("@id_dforder_items", config.IsNull(.Item(i)("id_dforder_items"), 0))

            End With
            Dim sql As String = config.BuildSQL(comm)
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

        'Update Detail----------

        i = 0
        comm.CommandText = "p_dforder_items_update"
        For i = 0 To DFD_UPD.Count - 1
            With DFD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dfno", DFNo)
                'comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", DFH.h04_design_no.Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                'comm.Parameters.AddWithValue("@gwth", DFH.h05_gwth.Trim)
                comm.Parameters.AddWithValue("@lot", strLotNo)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
                comm.Parameters.AddWithValue("@rolls", config.IsNull(.Item(i)("rolls"), 0).ToString)
                comm.Parameters.AddWithValue("@qc_kg", config.IsNull(.Item(i)("qc_kg"), 0))
                comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                'Edit By Neung User Need Use Fs_mts For Dyed House
                'comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                comm.Parameters.AddWithValue("@qc_yds", config.IsNull(.Item(i)("qc_yds"), 0))
                'comm.Parameters.AddWithValue("@fs_mts", config.IsNull(.Item(i)("fs_mts"), 0))
                'comm.Parameters.AddWithValue("@fs_yds", config.IsNull(.Item(i)("fs_yds"), Nothing))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "").Trim)
                comm.Parameters.AddWithValue("@outreqdt", CDate(config.IsNull(.Item(i)("outreqdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhcolref", config.IsNull(.Item(i)("dhcolref_d"), "").Trim)
                comm.Parameters.AddWithValue("@dhcoldt", CDate(config.IsNull(.Item(i)("dhcoldt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), "").Trim)
                comm.Parameters.AddWithValue("@labdipno", config.IsNull(.Item(i)("labdipno"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@flagpost", config.IsNull(.Item(i)("flagpost"), False))
                comm.Parameters.AddWithValue("@closed", config.IsNull(.Item(i)("closed"), False))
                comm.Parameters.AddWithValue("@closedt", CDate(config.IsNull(.Item(i)("closedt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@delidt", CDate(config.IsNull(.Item(i)("delidt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@rem", config.IsNull(.Item(i)("rem"), "").Trim)
                comm.Parameters.AddWithValue("@dhfabrcdt", CDate(config.IsNull(.Item(i)("dhfabrcdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhordref", config.IsNull(.Item(i)("dhordref"), "").Trim)
                comm.Parameters.AddWithValue("@design_no_fg", config.IsNull(DFH.h96_design_no_fg, "").Trim)
                comm.Parameters.AddWithValue("@id_dforder_items", config.IsNull(.Item(i)("id_dforder_items"), 0))

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

        comm.CommandText = "p_ko_yarn_update_lot2"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@dfno", DFNo)
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

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Public Function DFSave_DFORDER_FORM_PKG(ByVal DFH As DFHeader, ByVal DFD_ADD As DataView, ByVal DFD_UPD As DataView, ByVal DFD_DEL As DataView, ByRef msgerr As String, ByRef DFNo As String) As Boolean
        'ToDo : DFSave Sitthana 09/03/2018
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim strLotNo As String = ""
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DFORDER_FORM_PKG_dforder_update"
        With DFH
            comm.Parameters.AddWithValue("@dhcod", DFH.h01_dhcod.Trim)
            comm.Parameters.AddWithValue("@dfno", .h02_dfno.Trim)
            comm.Parameters.AddWithValue("@dfdt", .h03_dfdt.Trim)
            comm.Parameters.AddWithValue("@design_no", .h04_design_no.Trim)
            comm.Parameters.AddWithValue("@gwth", .h05_gwth.Trim)
            comm.Parameters.AddWithValue("@fwth", .h06_fwth.Trim)
            comm.Parameters.AddWithValue("@lot", .h07_lot.Trim)
            comm.Parameters.AddWithValue("@yr", .h08_yr.Trim)
            comm.Parameters.AddWithValue("@compo", .h09_compo.Trim)
            comm.Parameters.AddWithValue("@mtkg", .h10_mtkg)
            comm.Parameters.AddWithValue("@dyetyp", .h11_dyetyp.Trim)
            comm.Parameters.AddWithValue("@sono", .h12_sono.Trim)
            comm.Parameters.AddWithValue("@rptlen_d", .h13_rptlen_d)
            comm.Parameters.AddWithValue("@rptwth_d", .h14_rptwth_d)
            comm.Parameters.AddWithValue("@rptlen_s", .h15_rptlen_s)
            comm.Parameters.AddWithValue("@rptwth_s", .h16_rptwth_s)
            comm.Parameters.AddWithValue("@rolltyp", .h17_rolltyp.Trim)
            comm.Parameters.AddWithValue("@packtyp", .h18_packtyp.Trim)
            comm.Parameters.AddWithValue("@nob", .h19_nob.ToString)
            comm.Parameters.AddWithValue("@supcod", .h20_supcod.Trim)
            comm.Parameters.AddWithValue("@dhcolref", .h21_dhcolref.Trim)
            comm.Parameters.AddWithValue("@dhcoldt", .h22_dhcoldt.Trim)
            comm.Parameters.AddWithValue("@typ", .h23_typ.Trim)
            comm.Parameters.AddWithValue("@AB", .h24_AB.Trim)
            comm.Parameters.AddWithValue("@status", .h25_status.Trim)
            comm.Parameters.AddWithValue("@usewth", .h26_usewth.Trim)
            comm.Parameters.AddWithValue("@labsubmit", .h27_labsubmit)
            comm.Parameters.AddWithValue("@urgent", .h28_urgent)
            comm.Parameters.AddWithValue("@urgentdt", .h29_urgentdt.Trim)
            comm.Parameters.AddWithValue("@nophenyell", .h30_nophenyell)
            comm.Parameters.AddWithValue("@noazo", .h31_noazo)
            comm.Parameters.AddWithValue("@dyestd", .h32_dyestd.Trim)
            comm.Parameters.AddWithValue("@finlikesmp", .h33_finlikesmp)
            comm.Parameters.AddWithValue("@grading", .h34_grading)
            comm.Parameters.AddWithValue("@bulksub", .h35_bulksub)
            comm.Parameters.AddWithValue("@bulkappdh", .h36_bulkappdh)
            comm.Parameters.AddWithValue("@labeldes", .h37_labeldes.Trim)
            comm.Parameters.AddWithValue("@labelwth", .h38_labelwth.Trim)
            comm.Parameters.AddWithValue("@ph", .h39_ph)
            comm.Parameters.AddWithValue("@refspec", .h40_refspec)
            comm.Parameters.AddWithValue("@rollcode", .h41_rollcode.Trim)
            comm.Parameters.AddWithValue("@lblcode", .h42_lblcode.Trim)
            comm.Parameters.AddWithValue("@pclen", .h43_pclen.Trim)
            comm.Parameters.AddWithValue("@remark", .h44_remark.Trim)
            comm.Parameters.AddWithValue("@inoutwear", .h45_inoutwear.Trim)
            comm.Parameters.AddWithValue("@rwbands", .h46_rwbands.ToString)
            comm.Parameters.AddWithValue("@cond", .h47_cond.Trim)
            comm.Parameters.AddWithValue("@sample", .h48_sample.Trim)
            comm.Parameters.AddWithValue("@lights", .h49_lights.Trim)
            comm.Parameters.AddWithValue("@D65", .h50_D65)
            comm.Parameters.AddWithValue("@D65_order", .h51_D65_order.Trim)
            comm.Parameters.AddWithValue("@TL83", .h52_TL83)
            comm.Parameters.AddWithValue("@TL83_order", .h53_TL83_order.Trim)
            comm.Parameters.AddWithValue("@TL84", .h54_TL84)
            comm.Parameters.AddWithValue("@TL84_order", .h55_TL84_order.Trim)
            comm.Parameters.AddWithValue("@inc", .h56_inc)
            comm.Parameters.AddWithValue("@inc_order", .h57_inc_order.Trim)
            comm.Parameters.AddWithValue("@cwf", .h58_cwf)
            comm.Parameters.AddWithValue("@cwf_order", .h59_cwf_order.Trim)
            comm.Parameters.AddWithValue("@d65m", .h60_d65m)
            comm.Parameters.AddWithValue("@d65m_order", .h61_d65m_order.Trim)
            comm.Parameters.AddWithValue("@outreqno", .h62_outreqno.Trim)
            comm.Parameters.AddWithValue("@outno", .h63_outno.Trim)
            comm.Parameters.AddWithValue("@red", .h64_red)
            comm.Parameters.AddWithValue("@ref", .h65_ref)
            comm.Parameters.AddWithValue("@delidt", .h66_delidt.Trim)
            comm.Parameters.AddWithValue("@cfno", .h67_cfno.Trim)
            comm.Parameters.AddWithValue("@dftyp", .h68_dftyp.Trim)
            comm.Parameters.AddWithValue("@dfrem", .h69_dfrem.Trim)
            comm.Parameters.AddWithValue("@pleat", .h70_pleat)
            comm.Parameters.AddWithValue("@holog", .h71_holog)
            comm.Parameters.AddWithValue("@rev", .h72_rev.ToString)
            comm.Parameters.AddWithValue("@diff", .h73_diff.Trim)
            comm.Parameters.AddWithValue("@style", .h74_style.Trim)
            comm.Parameters.AddWithValue("@newdesign", .h75_newdesign)
            comm.Parameters.AddWithValue("@len", .h76_len.Trim)
            comm.Parameters.AddWithValue("@wth", .h77_wth.Trim)
            comm.Parameters.AddWithValue("@ka_std", .h78_ka_std)
            comm.Parameters.AddWithValue("@ga_std", .h79_ga_std)
            comm.Parameters.AddWithValue("@cus_std", .h80_cus_std)
            comm.Parameters.AddWithValue("@csample", .h81_csample)
            comm.Parameters.AddWithValue("@cbulk", .h82_cbulk)
            comm.Parameters.AddWithValue("@empcd", .h83_empcd.Trim)
            comm.Parameters.AddWithValue("@issuedt", .h84_issuedt.Trim)
            comm.Parameters.AddWithValue("@TL84M", .h85_TL84M)
            comm.Parameters.AddWithValue("@TL84M_order", .h86_TL84M_order.Trim)
            comm.Parameters.AddWithValue("@printing", .h87_printing)
            comm.Parameters.AddWithValue("@sample_fabric", .h88_sample_fabric.ToString)
            comm.Parameters.AddWithValue("@sample_hank", .h89_sample_hank.ToString)
            comm.Parameters.AddWithValue("@sample_card", .h90_sample_card.ToString)
            comm.Parameters.AddWithValue("@dye", .h91_dye)
            comm.Parameters.AddWithValue("@finish", .h92_finish)
            comm.Parameters.AddWithValue("@preset", .h93_preset)
            comm.Parameters.AddWithValue("@deliver_to", .h94_deliver_to.Trim)
            comm.Parameters.AddWithValue("@deliver_by", .h95_deliver_by.Trim)
            comm.Parameters.AddWithValue("@design_no_fg", .h96_design_no_fg.Trim)
            comm.Parameters.AddWithValue("@pleat_rem", .h97_pleat_rem.Trim)
            comm.Parameters.AddWithValue("@holog_rem", .h98_holog_rem.Trim)
            comm.Parameters.AddWithValue("@print_rem", .h99_print_rem.Trim)
            comm.Parameters.AddWithValue("@embroidary", .h100_embroidary)
            comm.Parameters.AddWithValue("@embroidary_rem", .h101_embroidary_rem.Trim)
            comm.Parameters.AddWithValue("@width_type", .h102_width_type)
            comm.Parameters.AddWithValue("@dye_loss_percent", .h103_dye_loss_percent)
            ''Sitthana copy from gmk 16/05/201
            comm.Parameters.AddWithValue("@poc_pdf_header_id", .h104_poc_pdf_header_id)
            comm.Parameters.AddWithValue("@addl_remark", .h105_addl_remark)
            comm.Parameters.AddWithValue("@addl", .h106_addl)
            comm.Parameters.AddWithValue("@mts_per_roll", .mts_per_roll)
            comm.Parameters.AddWithValue("@split", .h109_Sprit)  'Sitthana 08/03/2018
            comm.Parameters.AddWithValue("@df_type_id", .h107_DFType)  'Sitthana 08/03/2018
            comm.Parameters.AddWithValue("@df_type_remark", .h108_DFTypeRemark)  'Sitthana 08/03/2018
            'comm.Parameters.AddWithValue("@Brushing", .h110_Brushing)  'Sitthana 08/03/2018 'Not change in eschler yet
            comm.Parameters.AddWithValue("@p_oth_std", .h111_oth_std)  'Sitthana 20200724
            comm.Parameters.AddWithValue("@p_oth_std_comment", .h112_oth_std_comment)  'Sitthana 20200724
            'comm.Parameters.AddWithValue("@p_garment", .h113_garment)  'Sitthana 20240112
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
        DFNo = dt.Rows(0)("dfno").ToString.Trim
        strLotNo = dt.Rows(0)("lot").ToString.Trim

        'Delete Detail----------

        i = 0
        comm.CommandText = "p_dforder_items_delete"

        For i = 0 To DFD_DEL.Count - 1
            With DFD_DEL(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dfno", DFNo)
                comm.Parameters.AddWithValue("@roll_no", .Item("roll_no").ToString.Trim)
                comm.Parameters.AddWithValue("@col", .Item("col").ToString.Trim)
                comm.Parameters.AddWithValue("@id_dforder_items", .Item("id_dforder_items"))
                comm.Parameters.AddWithValue("@log_empcd", DFH.h83_empcd)
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

        'Add Detail----------

        i = 0
        comm.CommandText = "P_DFORDER_FORM_PKG_dforder_items_update"
        For i = 0 To DFD_ADD.Count - 1
            With DFD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dfno", DFNo)
                'comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", DFH.h04_design_no.Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                'comm.Parameters.AddWithValue("@gwth", DFH.h05_gwth.Trim)
                comm.Parameters.AddWithValue("@lot", strLotNo)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
                comm.Parameters.AddWithValue("@rolls", config.IsNull(.Item(i)("rolls"), 0).ToString)
                comm.Parameters.AddWithValue("@qc_kg", config.IsNull(.Item(i)("qc_kg"), 0))
                comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                'Edit By Neung User Need Use Fs_mts For Dyed House
                'comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                comm.Parameters.AddWithValue("@qc_yds", config.IsNull(.Item(i)("qc_yds"), 0))
                'comm.Parameters.AddWithValue("@fs_mts", config.IsNull(.Item(i)("fs_mts"), 0))
                'comm.Parameters.AddWithValue("@fs_yds", config.IsNull(.Item(i)("fs_yds"), Nothing))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "").Trim)
                comm.Parameters.AddWithValue("@outreqdt", CDate(config.IsNull(.Item(i)("outreqdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhcolref", config.IsNull(.Item(i)("dhcolref_d"), "").Trim)
                comm.Parameters.AddWithValue("@dhcoldt", CDate(config.IsNull(.Item(i)("dhcoldt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), "").Trim)
                comm.Parameters.AddWithValue("@labdipno", config.IsNull(.Item(i)("labdipno"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@flagpost", config.IsNull(.Item(i)("flagpost"), False))
                comm.Parameters.AddWithValue("@closed", config.IsNull(.Item(i)("closed"), False))
                comm.Parameters.AddWithValue("@closedt", CDate(config.IsNull(.Item(i)("closedt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@delidt", CDate(config.IsNull(.Item(i)("delidt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@rem", config.IsNull(.Item(i)("rem"), "").Trim)
                comm.Parameters.AddWithValue("@dhfabrcdt", CDate(config.IsNull(.Item(i)("dhfabrcdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhordref", config.IsNull(.Item(i)("dhordref"), "").Trim)
                comm.Parameters.AddWithValue("@design_no_fg", config.IsNull(DFH.h96_design_no_fg, "").Trim)
                comm.Parameters.AddWithValue("@id_dforder_items", config.IsNull(.Item(i)("id_dforder_items"), 0))
                'Sitthana copy from GMK
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "")) 'Add By Neung 20151204
                comm.Parameters.AddWithValue("@poc_pdf_header_id", config.IsNull(.Item(i)("poc_pdf_header_id"), "")) 'Add By Neung 20151204
                'Case ("@split")  'Sitthana 08/03/2018  -> Not
            End With
            Dim sql As String = config.BuildSQL(comm)
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

        'Update Detail----------

        i = 0
        comm.CommandText = "P_DFORDER_FORM_PKG_dforder_items_update"
        For i = 0 To DFD_UPD.Count - 1
            With DFD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@dfno", DFNo)
                'comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", DFH.h04_design_no.Trim)
                comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").Trim)
                'comm.Parameters.AddWithValue("@gwth", DFH.h05_gwth.Trim)
                comm.Parameters.AddWithValue("@lot", strLotNo)
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
                comm.Parameters.AddWithValue("@rolls", config.IsNull(.Item(i)("rolls"), 0).ToString)
                comm.Parameters.AddWithValue("@qc_kg", config.IsNull(.Item(i)("qc_kg"), 0))
                comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                'Edit By Neung User Need Use Fs_mts For Dyed House
                'comm.Parameters.AddWithValue("@qc_mts", config.IsNull(.Item(i)("qc_mts"), 0))
                comm.Parameters.AddWithValue("@qc_yds", config.IsNull(.Item(i)("qc_yds"), 0))
                'comm.Parameters.AddWithValue("@fs_mts", config.IsNull(.Item(i)("fs_mts"), 0))
                'comm.Parameters.AddWithValue("@fs_yds", config.IsNull(.Item(i)("fs_yds"), Nothing))
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "").Trim)
                comm.Parameters.AddWithValue("@outreqdt", CDate(config.IsNull(.Item(i)("outreqdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhcolref", config.IsNull(.Item(i)("dhcolref_d"), "").Trim)
                comm.Parameters.AddWithValue("@dhcoldt", CDate(config.IsNull(.Item(i)("dhcoldt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), "").Trim)
                comm.Parameters.AddWithValue("@labdipno", config.IsNull(.Item(i)("labdipno"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(.Item(i)("roll_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@flagpost", config.IsNull(.Item(i)("flagpost"), False))
                comm.Parameters.AddWithValue("@closed", config.IsNull(.Item(i)("closed"), False))
                comm.Parameters.AddWithValue("@closedt", CDate(config.IsNull(.Item(i)("closedt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@delidt", CDate(config.IsNull(.Item(i)("delidt_d2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@rem", config.IsNull(.Item(i)("rem"), "").Trim)
                comm.Parameters.AddWithValue("@dhfabrcdt", CDate(config.IsNull(.Item(i)("dhfabrcdt2"), "01/01/1900")).ToString("yyyyMMdd"))
                comm.Parameters.AddWithValue("@dhordref", config.IsNull(.Item(i)("dhordref"), "").Trim)
                comm.Parameters.AddWithValue("@design_no_fg", config.IsNull(DFH.h96_design_no_fg, "").Trim)
                comm.Parameters.AddWithValue("@id_dforder_items", config.IsNull(.Item(i)("id_dforder_items"), 0))
                'Sitthana 16/05/2018 Begin Copy From GMK
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "")) 'Add By Neung 20151204
                comm.Parameters.AddWithValue("@poc_pdf_header_id", config.IsNull(.Item(i)("poc_pdf_header_id"), "")) 'Add By Neung 20151204
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

        comm.CommandText = "p_ko_yarn_update_lot2"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@dfno", DFNo)
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

        tran.Commit()
        conn.Close()
        Return True
    End Function
    Public Function DFCancel(ByVal strDFNo As String, ByVal strEmpCD As String, ByRef message As String) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_cancel"
        comm.Parameters.AddWithValue("@dfno", strDFNo)
        comm.Parameters.AddWithValue("@log_empcd", strEmpCD)
        Dim da = New SqlDataAdapter(comm)
        Dim dt = New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            message = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
        'If comm.ExecuteNonQuery() = -1 Then
        '    tran.Commit()
        '    conn.Close()
        '    Return True
        'Else
        '    tran.Rollback()
        '    conn.Close()
        '    Return False
        'End If

    End Function

    Public Function DFClose(ByVal dt As DataTable, ByRef msgerr As String, ByVal strEmpCD As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_close"
        For i = 0 To dt.Rows.Count - 1
            If config.IsNull(dt.Rows(i)("dfno"), "").ToString.Trim.Length > 0 Then
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_dforder_items", config.IsNull(dt.Rows(i)("id_dforder_items"), 0))
                comm.Parameters.AddWithValue("@dfno", config.IsNull(dt.Rows(i)("dfno"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@roll_no", config.IsNull(dt.Rows(i)("roll_no"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@col", config.IsNull(dt.Rows(i)("col"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@closed", IIf(config.IsNull(dt.Rows(i)("closed"), False), 1, 0))
                comm.Parameters.AddWithValue("@closedt", dt.Rows(i)("closedt"))
                comm.Parameters.AddWithValue("@rem", config.IsNull(dt.Rows(i)("rem"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@log_empcd", strEmpCD)
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
        conn.Close()
        Return True
    End Function

    Public Function GetDFOrderItems(ByVal strDfno As String, ByVal strColor As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_approval_select"
        comm.Parameters.AddWithValue("@dfno", strDfno.Trim)
        comm.Parameters.AddWithValue("@col", strColor.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            If CStr(dt.Rows(i)("senttocustdt")) = "01/01/1900" Then
                dt.Rows(i)("senttocustdt") = System.DBNull.Value
            End If
        Next
        conn.Close()
        Return dt
    End Function

    Public Function DforderApproveUpdate(ByVal dt As DataTable, ByRef msgerr As String, ByRef success As Boolean, ByVal strEmpCD As String) As DataTable
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        'Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        'comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_approval_update"
        For i = 0 To dt.Rows.Count - 1
            comm.Parameters.Clear()

            comm.Parameters.AddWithValue("@id_dforder_result", config.IsNull(dt.Rows(i)("id_dforder_result"), 0))
            comm.Parameters.AddWithValue("@dfno", config.IsNull(dt.Rows(i)("dfno"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@col", config.IsNull(dt.Rows(i)("col"), "").ToString.Trim)

            comm.Parameters.AddWithValue("@senttocustdt", CDate(config.IsNull(dt.Rows(i).Item("senttocustdt"), "01/01/1900")).ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@custreplydt", CDate(config.IsNull(dt.Rows(i).Item("custreplydt"), "01/01/1900")).ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@bulkok", IIf(config.IsNull(dt.Rows(i)("bulkok"), False), "1", "0"))
            comm.Parameters.AddWithValue("@bulknotok", IIf(config.IsNull(dt.Rows(i)("bulknotok"), False), "1", "0"))
            ''comm.Parameters.AddWithValue("@bulknotok", IIf(config.IsNull(dt.Rows(i)("bulknotok"), False), 1, 0))
            comm.Parameters.AddWithValue("@custcomment", config.IsNull(dt.Rows(i)("custcomment"), "").ToString.Trim)
            comm.Parameters.AddWithValue("@remarks", config.IsNull(dt.Rows(i)("remarks"), ""))
            comm.Parameters.AddWithValue("@dyebatchno", config.IsNull(dt.Rows(i)("dyebatchno"), ""))
            'comm.Parameters.AddWithValue("@log_empcd", strEmpCD)

            Try
                Call comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
                'tran.Rollback()
                success = False
                conn.Close()  'Sitthana 20190325
                Return dt
            End Try

        Next
        'tran.Commit()
        msgerr = "Data has been saved succesfully.."
        success = True
        conn.Close()
        Return dt
    End Function

    Public Function getDfColors(ByVal strDfno As String) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_df_colors"
        comm.Parameters.AddWithValue("@dfno", strDfno.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetSODF(Optional ByVal strDFNo As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_df"
        comm.Parameters.AddWithValue("@dfno", strDFNo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function GetSODFColor(Optional ByVal strDFNo As String = "", Optional ByVal strSONo As String = "") As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_df_color"
        comm.Parameters.AddWithValue("@dfno", strDFNo.Trim)
        comm.Parameters.AddWithValue("@sono", strSONo.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function SaveDFChange(ByVal DFD_UPD As DataView, ByRef msgerr As String) As Boolean
        Dim conn As New SqlConnection((New ClassConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_sonoid_update"
        For i As Integer = 0 To DFD_UPD.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@id_dforder_items", DFD_UPD.Item(i)("id_dforder_items"))
            comm.Parameters.AddWithValue("@sonoid", DFD_UPD.Item(i)("sonoid"))
            Try
                comm.ExecuteNonQuery()
            Catch ex As Exception
                msgerr = ex.Message
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
