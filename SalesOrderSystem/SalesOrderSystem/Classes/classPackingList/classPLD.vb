Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classPLD
    Private ConnStr As classConnection

    Public Structure CartonsHeader
        Dim h01_cartno As Double
        Dim h02_packno As String
        Dim h03_netwt As String
        Dim h04_grswt As String
        Dim h05_dimension As String
        Dim h06_gout As Nullable(Of Byte)
        Dim h07_sel As Nullable(Of Boolean)
    End Structure

    Public Structure PackingListDHeader

        'Cartons
        Dim h01_cartno As Double
        Dim h02_packno As String
        Dim h03_netwt As String
        Dim h04_grswt As String
        Dim h05_dimension As String
        Dim h06_gout As Nullable(Of Byte)
        Dim h07_sel As Nullable(Of Boolean)
        'Cartons

        'Stroll_d_o
        Dim h08_design_no As String
        Dim h09_nob As Double
        Dim h10_Gwth As String
        Dim h11_roll_no_d As String
        Dim h12_outkg_g As Double
        Dim h13_outmt_g As Double
        Dim h14_outyd_g As Double
        Dim h15_grade As String
        Dim h16_loc As String
        Dim h17_outreqno As String
        Dim h18_outreqdt As Nullable(Of Date)
        Dim h19_outreqtyp As String
        Dim h20_outno As String
        Dim h21_outdt As Nullable(Of Date)
        Dim h22_sh As String
        Dim h23_dfno As String
        Dim h24_col As String
        Dim h25_sono As String
        Dim h26_sonoid As String
        Dim h27_roll_no_o As String
        Dim h28_startat As String
        Dim h29_flagL As String
        Dim h30_cost As String
        Dim h31_fload As Boolean
        Dim h32_rate As Double
        Dim h33_cost_g As Double
        Dim h34_outno1 As String
        Dim h35_outnot As String
        Dim h36_packno As String 'Same h01_cartno
        Dim h37_cartno As Double 'Same h02_packno
        Dim h38_packdt As Nullable(Of Date)
        Dim h39_pono As String
        Dim h40_invno As String
        Dim h41_cancel As Boolean
        Dim h42_cliped As Boolean
        Dim h43_preseted As Boolean
        Dim h44_id_greige_do As Double
        Dim h45_rack_no As String
        Dim h46_empcd As String
        Dim h47_checknew As String
    End Structure

    'Conversion Project
    Public Function ValidateOutNoByPackno(ByVal Strpackno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_packno_validate_outno"
        comm.Parameters.AddWithValue("@packno", Strpackno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SearchOutReqNo(Optional ByVal strStockType As String = "A", Optional ByVal strReqNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_outreqno_search"
        comm.Parameters.AddWithValue("@stock_type", strStockType.Trim)
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ValidateReqNoIsCancel(ByVal outreqno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_outreqno_validate_cancel"
        comm.Parameters.AddWithValue("@outreqno", outreqno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ValidateReqNoIsPack(ByVal outreqno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_outreqno_validate_packno"
        comm.Parameters.AddWithValue("@outreqno", outreqno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SearchPackno(Optional ByVal strPackno As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_search"
        comm.Parameters.AddWithValue("@packno", strPackno)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function
    Public Function GetOutno(Optional ByVal strOutno As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_d_out_select_search"
        comm.Parameters.AddWithValue("@outno", strOutno)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetPackinglistDDataCartons(Optional ByVal PackinglistNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_cartons"
        comm.Parameters.AddWithValue("@packno", PackinglistNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetPackinglistDDataDetail(Optional ByVal strPacking_no As String = "", Optional ByVal strcartno2 As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_data_detail"
        comm.Parameters.AddWithValue("@packno", strPacking_no)
        comm.Parameters.AddWithValue("@cartno", strcartno2)
        'comm.Parameters.AddWithValue("@cartno", strcartno.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetREQD(ByVal strREQGNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_d_select_req_det_dc"
        comm.Parameters.AddWithValue("@outreqno", strREQGNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function pldsave(ByVal PLDHeader As PackingListDHeader, ByVal DV_DTC_ADD As DataView, ByVal DV_DTP_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTP_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByVal DV_DTP_DEL As DataView, ByRef msgerr As String, ByRef PLDNo As String, ByRef OUTREQNo As String, ByRef PACKDT As String, ByRef OUTNO As String, ByRef OUTDT As String, ByRef USERID As String, ByRef CheckNEW As String, ByRef Doc_type As String) As Boolean
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

        'Start Gen PLD No----------
        comm.CommandText = "p_packing_list_d_gen_doc"
        With PLDHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@packno", PLDHeader.h02_packno)
            comm.Parameters.AddWithValue("@outno", PLDHeader.h20_outno)
            comm.Parameters.AddWithValue("@empcd", PLDHeader.h46_empcd)
            comm.Parameters.AddWithValue("@checknew", CheckNEW)
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
        PLDNo = dt.Rows(0)("packno").ToString.Trim
        PLDHeader.h36_packno = dt.Rows(0)("packno").ToString.Trim
        CheckNEW = dt.Rows(0)("checknew").ToString.Trim
        'END Gen PLD No----------
        'Start Insert PLD----------
        comm.CommandText = "p_packing_list_d_insert"
        i = 0
        For i = 0 To DV_DTP_ADD.Count - 1
            With DV_DTP_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(PLDHeader.h20_outno.Trim, ""))
                comm.Parameters.AddWithValue("@outdt", config.IsNull(PLDHeader.h21_outdt, ""))
                comm.Parameters.AddWithValue("@doctyp", Doc_type.Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
                comm.Parameters.AddWithValue("@yr", "")
                comm.Parameters.AddWithValue("@sh", "")
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@nob", "")
                comm.Parameters.AddWithValue("@typ", "")
                comm.Parameters.AddWithValue("@status", "")
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@rl_at_cut", "")
                comm.Parameters.AddWithValue("@rw_at_cut", "")
                comm.Parameters.AddWithValue("@mts_at_cut", "")
                comm.Parameters.AddWithValue("@yds_at_cut", "")
                comm.Parameters.AddWithValue("@mts_g", "")
                comm.Parameters.AddWithValue("@yds_g", "")
                comm.Parameters.AddWithValue("@allowmt", "")
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@cutcardno", "")
                comm.Parameters.AddWithValue("@cutcardsno", "")
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo.Trim)
                comm.Parameters.AddWithValue("@packdt", PACKDT.Trim)
                comm.Parameters.AddWithValue("@sel", "")
                comm.Parameters.AddWithValue("@cost", "")
                comm.Parameters.AddWithValue("@batch", "") 'Should Check it Again
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@invno", "")
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
                comm.Parameters.AddWithValue("@outno1", "")
                comm.Parameters.AddWithValue("@outnot", "")
                comm.Parameters.AddWithValue("@verno", "")
                comm.Parameters.AddWithValue("@dinno", "")
                comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            ' Dim sql As String = config.BuildSQL(comm)
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
            Action = "ADD"
            'PLGNo = dtp.Rows(0)("packno").ToString.Trim
            'CheckNEW = dt.Rows(0)("checknew").ToString.Trim
            ' strLotNo = dt.Rows(0)("lot").ToString.Trim
        Next
        'End  Add PLG-----------

        'Start Update PLD ----------

        i = 0
        comm.CommandText = "p_packing_list_d_update"

        For i = 0 To DV_DTP_UPD.Count - 1
            With DV_DTP_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").Trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(i)("outdt"), ""))
                comm.Parameters.AddWithValue("@doctyp", Doc_type.Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), ""))
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(i)("nob"), ""))
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(i)("typ"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), ""))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@rl_at_cut", config.IsNull(.Item(i)("rl_at_cut"), ""))
                comm.Parameters.AddWithValue("@rw_at_cut", config.IsNull(.Item(i)("rl_at_cut"), ""))
                comm.Parameters.AddWithValue("@mts_at_cut", config.IsNull(.Item(i)("mts_at_cut"), ""))
                comm.Parameters.AddWithValue("@yds_at_cut", config.IsNull(.Item(i)("yds_at_cut"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(i)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(i)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(i)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@cutcardno", config.IsNull(.Item(i)("cutcardno"), ""))
                comm.Parameters.AddWithValue("@cutcardsno", config.IsNull(.Item(i)("cutcardsno"), ""))
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), "").Trim)
                comm.Parameters.AddWithValue("@packdt", PLDHeader.h38_packdt)
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(i)("sel"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(i)("cost"), ""))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), ""))
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@invno", config.IsNull(.Item(i)("invno"), ""))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(i)("fload"), ""))
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
                comm.Parameters.AddWithValue("@outno1", config.IsNull(.Item(i)("outno1"), ""))
                comm.Parameters.AddWithValue("@outnot", config.IsNull(.Item(i)("outnot"), ""))
                comm.Parameters.AddWithValue("@verno", config.IsNull(.Item(i)("verno"), ""))
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(i)("dinno"), ""))
                comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("_kg"), 0))
                comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("_mts"), 0))
                comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("_yds"), 0))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

            Action = "CHANGE"
        Next
        'End Update PLD ----------
        ''Start Update PLD2 ----------

        'i = 0
        'comm.CommandText = "p_packing_list_d_update"

        'For i = 0 To DV_DTDT_UPD.Count - 1
        '    With DV_DTDT_UPD
        '        comm.Parameters.Clear()
        '        comm.Parameters.AddWithValue("@outno", "")
        '        comm.Parameters.AddWithValue("@outdt", "")
        '        comm.Parameters.AddWithValue("@doctyp", config.IsNull(.Item(i)("doctyp"), "").Trim)
        '        comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
        '        comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
        '        comm.Parameters.AddWithValue("@fwth", "")
        '        comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
        '        comm.Parameters.AddWithValue("@yr", "")
        '        comm.Parameters.AddWithValue("@sh", "")
        '        comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
        '        comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
        '        comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), ""))
        '        comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), ""))
        '        comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), ""))
        '        comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
        '        comm.Parameters.AddWithValue("@nob", "")
        '        comm.Parameters.AddWithValue("@typ", "")
        '        comm.Parameters.AddWithValue("@status", "")
        '        comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
        '        comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
        '        comm.Parameters.AddWithValue("@rl_at_cut", "")
        '        comm.Parameters.AddWithValue("@rw_at_cut", "")
        '        comm.Parameters.AddWithValue("@mts_at_cut", "")
        '        comm.Parameters.AddWithValue("@yds_at_cut", "")
        '        comm.Parameters.AddWithValue("@mts_g", "")
        '        comm.Parameters.AddWithValue("@yds_g", "")
        '        comm.Parameters.AddWithValue("@allowmt", "")
        '        comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
        '        comm.Parameters.AddWithValue("@cutcardno", "")
        '        comm.Parameters.AddWithValue("@cutcardsno", "")
        '        comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
        '        comm.Parameters.AddWithValue("@packno", PLGNo.Trim)
        '        comm.Parameters.AddWithValue("@packdt", PACKDT.Trim)
        '        comm.Parameters.AddWithValue("@sel", "")
        '        comm.Parameters.AddWithValue("@cost", "")
        '        comm.Parameters.AddWithValue("@batch", "") 'Should Check it Again
        '        comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
        '        comm.Parameters.AddWithValue("@invno", "")
        '        comm.Parameters.AddWithValue("@fload", "")
        '        comm.Parameters.AddWithValue("@pono", "")
        '        comm.Parameters.AddWithValue("@outno1", "")
        '        comm.Parameters.AddWithValue("@outnot", "")
        '        comm.Parameters.AddWithValue("@verno", "")
        '        comm.Parameters.AddWithValue("@dinno", "")
        '        comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("outkg_g"), ""))
        '        comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("outmt_g"), ""))
        '        comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("outyd_g"), ""))
        '        comm.Parameters.AddWithValue("@empcd", USERID.Trim)
        '        comm.Parameters.AddWithValue("@checknew", CheckNEW)
        '    End With
        '    Dim dap_upd = New SqlDataAdapter(comm)
        '    Dim dtp_upd = New DataTable
        '    Try
        '        dap_upd.Fill(dtp_upd)
        '    Catch ex As Exception
        '        msgerr = ex.Message
        '        tran.Rollback()
        '        Return False
        '    End Try

        '    Action = "CHANGE"
        'Next
        ''End Update PLD2 ----------

        'Start Delete PLG ----------

        i = 0
        comm.CommandText = "p_packing_list_d_delete"

        For i = 0 To DV_DTP_DEL.Count - 1
            With DV_DTP_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").Trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(i)("outdt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(Doc_type, "doctyp").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), ""))
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(i)("nob"), ""))
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(i)("typ"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), ""))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@rl_at_cut", config.IsNull(.Item(i)("rl_at_cut"), ""))
                comm.Parameters.AddWithValue("@rw_at_cut", config.IsNull(.Item(i)("rl_at_cut"), ""))
                comm.Parameters.AddWithValue("@mts_at_cut", config.IsNull(.Item(i)("mts_at_cut"), ""))
                comm.Parameters.AddWithValue("@yds_at_cut", config.IsNull(.Item(i)("yds_at_cut"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(i)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(i)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(i)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@cutcardno", config.IsNull(.Item(i)("cutcardno"), ""))
                comm.Parameters.AddWithValue("@cutcardsno", config.IsNull(.Item(i)("cutcardsno"), ""))
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), "").Trim)
                comm.Parameters.AddWithValue("@packdt", config.IsNull(.Item(i)("packdt"), ""))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(i)("sel"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(i)("cost"), ""))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), ""))
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@invno", config.IsNull(.Item(i)("invno"), ""))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(i)("fload"), ""))
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
                comm.Parameters.AddWithValue("@outno1", config.IsNull(.Item(i)("outno1"), ""))
                comm.Parameters.AddWithValue("@outnot", config.IsNull(.Item(i)("outnot"), ""))
                comm.Parameters.AddWithValue("@verno", config.IsNull(.Item(i)("verno"), ""))
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(i)("dinno"), ""))
                comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("_kg"), 0))
                comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("_mts"), 0))
                comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("_yds"), 0))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
            End With
            Dim dap_del = New SqlDataAdapter(comm)
            Dim dtp_del = New DataTable
            Try
                dap_del.Fill(dtp_del)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
            Action = "CHANGE"
        Next
        'End Delete PLG ----------



        'Start Add Cartons----------

        comm.CommandText = "p_packing_list_d_cartons_insert"
        j = 0
        For j = 0 To DV_DTC_ADD.Count - 1
            With DV_DTC_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo)
                comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                comm.Parameters.AddWithValue("@gout", config.IsNull(.Item(j)("gout"), ""))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

        comm.CommandText = "p_packing_list_d_update_cartons"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo)
                comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                comm.Parameters.AddWithValue("@gout", config.IsNull(.Item(j)("gout"), ""))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

        comm.CommandText = "p_packing_list_d_delete_cartons"
        j = 0
        For j = 0 To DV_DTC_DEL.Count - 1
            With DV_DTC_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo)
                comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                comm.Parameters.AddWithValue("@gout", config.IsNull(.Item(j)("gout"), 0))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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
        'If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "PACK_D"
        With PLDHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", USERID.Trim)
            comm.Parameters.AddWithValue("@docno", PLDNo)
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

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    Public Function pldsaveDOUT(ByVal PLDHeader As PackingListDHeader, ByVal DV_DTC_ADD As DataView, ByVal DV_DTP_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTP_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByVal DV_DTP_DEL As DataView, ByRef msgerr As String, ByRef PLDNo As String, ByRef OUTREQNo As String, ByRef PACKDT As String, ByRef OUTNO As String, ByRef OUTDT As String, ByRef USERID As String, ByRef CheckNEW As String, ByRef Doc_type As String, ByRef dtp2 As DataTable, ByRef dtc As DataTable, ByRef CartonsHeader As CartonsHeader) As Boolean
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

        'start
        'Start Gen PLD No----------
        comm.CommandText = "p_packing_list_d_gen_dout"

        With PLDHeader
            'With dt.Rows
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@packno", PLDHeader.h02_packno)
            comm.Parameters.AddWithValue("@outno", PLDHeader.h20_outno)
            comm.Parameters.AddWithValue("@empcd", PLDHeader.h46_empcd)
            comm.Parameters.AddWithValue("@doctyp", config.IsNull(Doc_type, "S").Trim)
            comm.Parameters.AddWithValue("@checknew", CheckNEW)
        End With
        'End With
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
        OUTNO = dt.Rows(0)("outno").ToString.Trim
        CheckNEW = dt.Rows(0)("checknew").ToString.Trim
        'END Gen PLD No----------
        'End


        'Strat Update Dout
        i = 0
        comm.CommandText = "p_packing_list_d_out_update"

        For i = 0 To dtp2.Rows.Count - 1
            With dtp2.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", OUTNO.Trim)
                comm.Parameters.AddWithValue("@outdt", OUTDT.Trim)
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(Doc_type, "S").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), ""))
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(i)("nob"), ""))
                comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(i)("typ"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), ""))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@rl_at_cut", config.IsNull(.Item(i)("rl_at_cut"), ""))
                comm.Parameters.AddWithValue("@rw_at_cut", config.IsNull(.Item(i)("rl_at_cut"), ""))
                comm.Parameters.AddWithValue("@mts_at_cut", config.IsNull(.Item(i)("mts_at_cut"), ""))
                comm.Parameters.AddWithValue("@yds_at_cut", config.IsNull(.Item(i)("yds_at_cut"), ""))
                comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(i)("mts_g"), ""))
                comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(i)("yds_g"), ""))
                comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(i)("allowmt"), ""))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@cutcardno", config.IsNull(.Item(i)("cutcardno"), ""))
                comm.Parameters.AddWithValue("@cutcardsno", config.IsNull(.Item(i)("cutcardsno"), ""))
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), ""))
                comm.Parameters.AddWithValue("@packdt", config.IsNull(.Item(i)("packdt"), ""))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(i)("sel"), ""))
                comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(i)("cost"), ""))
                comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), ""))
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@invno", config.IsNull(.Item(i)("invno"), ""))
                comm.Parameters.AddWithValue("@fload", config.IsNull(.Item(i)("fload"), ""))
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
                comm.Parameters.AddWithValue("@outno1", config.IsNull(.Item(i)("outno1"), ""))
                comm.Parameters.AddWithValue("@outnot", config.IsNull(.Item(i)("outnot"), ""))
                comm.Parameters.AddWithValue("@verno", config.IsNull(.Item(i)("verno"), ""))
                comm.Parameters.AddWithValue("@dinno", config.IsNull(.Item(i)("dinno"), ""))
                comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("_kg"), 0))
                comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("_mts"), 0))
                comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("_yds"), 0))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

            PLDNo = dtp_upd.Rows(0)("packno").ToString.Trim
        Next
        'End Update PLD ----------

        ''Start Add Cartons----------

        'comm.CommandText = "p_packing_list_d_cartons_insert"
        'j = 0
        'For j = 0 To DV_DTC_ADD.Count - 1
        '    With DV_DTC_ADD
        '        comm.Parameters.Clear()
        '        comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
        '        comm.Parameters.AddWithValue("@packno", PLGNo)
        '        comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
        '        comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
        '        comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
        '        comm.Parameters.AddWithValue("@gout", config.IsNull(.Item(j)("gout"), ""))
        '        comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
        '        comm.Parameters.AddWithValue("@empcd", USERID.Trim)
        '        comm.Parameters.AddWithValue("@checknew", CheckNEW)
        '    End With
        '    'Dim sql As String = config.BuildSQL(comm)
        '    Dim dac_int = New SqlDataAdapter(comm)
        '    Dim dtc_int = New DataTable
        '    Try
        '        dac_int.Fill(dtc_int)
        '    Catch ex As Exception
        '        msgerr = ex.Message
        '        tran.Rollback()
        '        Return False
        '    End Try
        '    Action = "ADD"

        'Next
        ''End Add Cartons----------

        ''Start update Cartons----------

        'comm.CommandText = "p_packing_list_d_cartons_update"
        'j = 0
        'For j = 0 To DV_DTC_UPD.Count - 1
        '    With DV_DTC_UPD
        '        comm.Parameters.Clear()
        '        comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
        '        comm.Parameters.AddWithValue("@packno", PLGNo)
        '        comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
        '        comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
        '        comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
        '        comm.Parameters.AddWithValue("@gout", config.IsNull(.Item(j)("gout"), ""))
        '        comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
        '        comm.Parameters.AddWithValue("@empcd", USERID.Trim)
        '        comm.Parameters.AddWithValue("@checknew", CheckNEW)
        '    End With
        '    'Dim sql As String = config.BuildSQL(comm)
        '    Dim dac_upd = New SqlDataAdapter(comm)
        '    Dim dtc_upd = New DataTable
        '    Try
        '        dac_upd.Fill(dtc_upd)
        '    Catch ex As Exception
        '        msgerr = ex.Message
        '        tran.Rollback()
        '        Return False
        '    End Try
        '    Action = "CHANGE"
        'Next
        ''End update Cartons----------

        ''Start delete Cartons----------

        'comm.CommandText = "p_packing_list_d_cartons_delete"
        'j = 0
        'For j = 0 To DV_DTC_DEL.Count - 1
        '    With DV_DTC_DEL
        '        comm.Parameters.Clear()
        '        comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
        '        comm.Parameters.AddWithValue("@packno", PLGNo)
        '        comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
        '        comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
        '        comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
        '        comm.Parameters.AddWithValue("@gout", config.IsNull(.Item(j)("gout"), 0))
        '        comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
        '        comm.Parameters.AddWithValue("@empcd", USERID.Trim)
        '        comm.Parameters.AddWithValue("@checknew", CheckNEW)
        '    End With
        '    'Dim sql As String = config.BuildSQL(comm)
        '    Dim dac_del = New SqlDataAdapter(comm)
        '    Dim dtc_del = New DataTable
        '    Try
        '        dac_del.Fill(dtc_del)
        '    Catch ex As Exception
        '        msgerr = ex.Message
        '        tran.Rollback()
        '        Return False
        '    End Try

        '    Action = "CHANGE"
        'Next
        'End delete Cartons----------

        'Start Insert Action----------
        'If Action = "" Then Action = "CHANGE"
        'Start update Cartons----------

        comm.CommandText = "p_packing_list_d_update_cartons"
        j = 0
        For j = 0 To dtc.Rows.Count - 1
            With dtc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo)
                comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                comm.Parameters.AddWithValue("@gout", config.IsNull(CartonsHeader.h06_gout, 1))
                comm.Parameters.AddWithValue("@sel", config.IsNull(CartonsHeader.h07_sel, 1))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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
            'Action = "CHANGE"
        Next
        'End update Cartons----------

        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "PACK_D"
        With PLDHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", USERID.Trim)
            comm.Parameters.AddWithValue("@docno", PLDNo)
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

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function pldcancel(ByVal PLDHeader As PackingListDHeader, ByVal DV_DTC_ADD As DataView, ByVal DV_DTP_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTP_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByVal DV_DTP_DEL As DataView, ByRef msgerr As String, ByRef PLDNo As String, ByRef PACKDT As String, ByRef OUTREQNo As String, ByRef OUTNo As String, ByRef OUTDT As String, ByRef USERID As String, ByRef CheckNEW As String, ByRef Doc_type As String, ByRef dtc As DataTable, ByRef dtp As DataTable) As Boolean
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
        comm.CommandText = "p_packing_list_d_insert_bin"
        i = 0
        For i = 0 To dtp.Rows.Count - 1
            With dtp.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", PLDNo.Trim)
                comm.Parameters.AddWithValue("@outdt", OUTDT.Trim)
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(Doc_type, "S").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
                comm.Parameters.AddWithValue("@yr", "")
                comm.Parameters.AddWithValue("@sh", "")
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@nob", "")
                comm.Parameters.AddWithValue("@typ", "")
                comm.Parameters.AddWithValue("@status", "")
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@rl_at_cut", "")
                comm.Parameters.AddWithValue("@rw_at_cut", "")
                comm.Parameters.AddWithValue("@mts_at_cut", "")
                comm.Parameters.AddWithValue("@yds_at_cut", "")
                comm.Parameters.AddWithValue("@mts_g", "")
                comm.Parameters.AddWithValue("@yds_g", "")
                comm.Parameters.AddWithValue("@allowmt", "")
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@cutcardno", "")
                comm.Parameters.AddWithValue("@cutcardsno", "")
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo.Trim)
                comm.Parameters.AddWithValue("@packdt", PACKDT.Trim)
                comm.Parameters.AddWithValue("@sel", "")
                comm.Parameters.AddWithValue("@cost", "")
                comm.Parameters.AddWithValue("@batch", "") 'Should Check it Again
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@invno", "")
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
                comm.Parameters.AddWithValue("@outno1", "")
                comm.Parameters.AddWithValue("@outnot", "")
                comm.Parameters.AddWithValue("@verno", "")
                comm.Parameters.AddWithValue("@dinno", "")
                comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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
        'End  Add PLD bin-----------

        'Start Delete PD ----------

        i = 0
        comm.CommandText = "p_packing_list_d_delete"

        For i = 0 To dtp.Rows.Count - 1
            With dtp.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", PLDNo.Trim)
                comm.Parameters.AddWithValue("@outdt", OUTDT.Trim)
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(Doc_type, "S").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
                comm.Parameters.AddWithValue("@yr", "")
                comm.Parameters.AddWithValue("@sh", "")
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@nob", "")
                comm.Parameters.AddWithValue("@typ", "")
                comm.Parameters.AddWithValue("@status", "")
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@rl_at_cut", "")
                comm.Parameters.AddWithValue("@rw_at_cut", "")
                comm.Parameters.AddWithValue("@mts_at_cut", "")
                comm.Parameters.AddWithValue("@yds_at_cut", "")
                comm.Parameters.AddWithValue("@mts_g", "")
                comm.Parameters.AddWithValue("@yds_g", "")
                comm.Parameters.AddWithValue("@allowmt", "")
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@cutcardno", "")
                comm.Parameters.AddWithValue("@cutcardsno", "")
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo.Trim)
                comm.Parameters.AddWithValue("@packdt", PACKDT.Trim)
                comm.Parameters.AddWithValue("@sel", "")
                comm.Parameters.AddWithValue("@cost", "")
                comm.Parameters.AddWithValue("@batch", "") 'Should Check it Again
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@invno", "")
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
                comm.Parameters.AddWithValue("@outno1", "")
                comm.Parameters.AddWithValue("@outnot", "")
                comm.Parameters.AddWithValue("@verno", "")
                comm.Parameters.AddWithValue("@dinno", "")
                comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

        'Start delete Cartons----------

        comm.CommandText = "p_packing_list_d_cartons_delete"
        j = 0
        For j = 0 To dtc.Rows.Count - 1
            With dtc.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLDNo)
                comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                comm.Parameters.AddWithValue("@gout", config.IsNull(.Item(j)("gout"), ""))
                comm.Parameters.AddWithValue("@sel", config.IsNull(.Item(j)("sel"), ""))
                comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                comm.Parameters.AddWithValue("@checknew", CheckNEW)
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

        Next
        'End delete Cartons----------

        'Strat Insert Action----------
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim Action As String = "CANCEL"
        Dim doctyp As String = "PACK_D"
        With PLDHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", USERID.Trim)
            comm.Parameters.AddWithValue("@docno", PLDNo)
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
End Class

