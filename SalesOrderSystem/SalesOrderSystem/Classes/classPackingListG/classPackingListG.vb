Imports System.Data
Imports System.Data.SqlClient
Imports System.Text



Public Class classPackingListG
    Private ConnStr As classConnection
    Public Structure PackingListGHeader
        'Cartons
        Dim h01_cartno As Double
        Dim h02_packno As String
        Dim h03_netwt As String
        Dim h04_grswt As String
        Dim h05_dimension As String
        Dim h06_gout As Nullable(Of Byte)
        Dim h07_sel As Nullable(Of Boolean)
        'Cartons

        'Greide_do
        Dim h08_design_no As String
        Dim h09_nob As Double
        Dim h10_Gwth As String
        Dim h11_roll_no_g As String
        Dim h12_outkg_g As Double
        Dim h13_outmt_g As Double
        Dim h14_outyd_g As Double
        Dim h15_grade As String
        Dim h16_loc As String
        Dim h17_outreqno As String
        Dim h18_outreqdt As Date
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

    Public Function SearchOutReqNo(Optional ByVal strStockType As String = "A", Optional ByVal strReqNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_outreqno_search"
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

    Public Function ValidateOutNoByPackno(ByVal Strpackno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_packno_validate_outno"
        comm.Parameters.AddWithValue("@packno", Strpackno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ValidateReqNoisCancel(ByVal outreqno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_outreqno_validate_cancel"
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
        comm.CommandText = "p_packing_list_g_select_outreqno_validate_packno"
        comm.Parameters.AddWithValue("@outreqno", outreqno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
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
        comm.CommandText = "p_g_out_select_search"
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
    Public Function plgsave(ByRef PLGHeader As PackingListGHeader, ByVal dv_dtc_add As DataView, ByVal dv_dtc_upd As DataView, ByVal dv_dtc_del As DataView, ByVal dv_dtp_add As DataView, ByVal dv_dtp_upd As DataView, ByVal dv_dtp_del As DataView, ByRef msgerr As String, ByRef PLGNo As String, ByRef OUTREQNo As String, ByRef OUTNO As String, ByRef OUTDT As String, ByRef USERID As String, ByRef CheckNEW As String, ByRef Doc_Type As String) As Boolean
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

        'Start Gen PLG No----------
        comm.CommandText = "p_packing_list_g_gen_doc"
        With PLGHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno)
            comm.Parameters.AddWithValue("@outno", PLGHeader.h20_outno)
            comm.Parameters.AddWithValue("@packdt", PLGHeader.h38_packdt)
            comm.Parameters.AddWithValue("@empcd", PLGHeader.h46_empcd)
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
        PLGHeader.h02_packno = dt.Rows(0)("packno").ToString.Trim
        CheckNEW = dt.Rows(0)("checknew").ToString.Trim

        'add by neung 20230217 delete should be first ''
        'Start Delete PLG ----------
        i = 0
        comm.CommandText = "p_packing_list_g_delete"

        For i = 0 To dv_dtp_del.Count - 1
            With dv_dtp_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@nob", "")
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@outkg_g", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@outmt_g", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@outyd_g", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@loc", "")
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "")) 'Plese Check
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(i)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(i)("outreqtyp"), ""))
                'comm.Parameters.AddWithValue("@outno", PLGNo.Trim)
                'comm.Parameters.AddWithValue("@outdt", OUTDT.Trim) Edit By Neung
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), PLGHeader.h20_outno).Trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(i)("outdt"), PLGHeader.h21_outdt))
                comm.Parameters.AddWithValue("@sh", "")
                comm.Parameters.AddWithValue("@dfno", "")
                comm.Parameters.AddWithValue("@col", "")
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@startat", OUTDT.Trim)
                comm.Parameters.AddWithValue("@flagL", "")
                comm.Parameters.AddWithValue("@cost", "")
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@rate", "")
                comm.Parameters.AddWithValue("@cost_g", "")
                comm.Parameters.AddWithValue("@outno1", "")
                comm.Parameters.AddWithValue("@outnot", "")
                comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno.Trim)
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packdt", config.IsNull(.Item(i)("packdt"), PLGHeader.h38_packdt))
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), "").Trim)
                comm.Parameters.AddWithValue("@invno", "")
                comm.Parameters.AddWithValue("@cancel", "0")
                comm.Parameters.AddWithValue("@cliped", "")
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(i)("preseted"), 0))
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(i)("id_greige_do"), 0)) 'Should Check it Again
                comm.Parameters.AddWithValue("@rack_no", "")
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

        'Start Add PLG----------
        comm.CommandText = "p_packing_list_g_insert"
        i = 0
        For i = 0 To dv_dtp_add.Count - 1
            With dv_dtp_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@nob", "")
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@outkg_g", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@outmt_g", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@outyd_g", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@loc", "")
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(i)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(i)("outreqtyp"), ""))
                comm.Parameters.AddWithValue("@outno", PLGHeader.h20_outno)
                comm.Parameters.AddWithValue("@outdt", PLGHeader.h21_outdt)
                comm.Parameters.AddWithValue("@sh", "")
                comm.Parameters.AddWithValue("@dfno", "")
                comm.Parameters.AddWithValue("@col", "")
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@startat", OUTDT.Trim)
                comm.Parameters.AddWithValue("@flagL", "")
                comm.Parameters.AddWithValue("@cost", "")
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@rate", "")
                comm.Parameters.AddWithValue("@cost_g", "")
                comm.Parameters.AddWithValue("@outno1", "")
                comm.Parameters.AddWithValue("@outnot", "")
                comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno.Trim)
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packdt", config.IsNull(.Item(i)("packdt"), PLGHeader.h38_packdt))
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), "").Trim)
                comm.Parameters.AddWithValue("@invno", "")
                comm.Parameters.AddWithValue("@cancel", "0")
                comm.Parameters.AddWithValue("@cliped", "")
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(i)("preseted"), 0))
                comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(i)("id_greige_do"), 0)) 'Should Check it Again
                comm.Parameters.AddWithValue("@rack_no", "")
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

        'Start Update PLG ----------

        i = 0
        comm.CommandText = "p_packing_list_g_update"

        For i = 0 To dv_dtp_upd.Count - 1
            With dv_dtp_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@nob", "")
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(dv_dtp_upd.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), "").Trim)
                comm.Parameters.AddWithValue("@outkg_g", config.IsNull(.Item(i)("outkg_g"), ""))
                comm.Parameters.AddWithValue("@outmt_g", config.IsNull(.Item(i)("outmt_g"), ""))
                comm.Parameters.AddWithValue("@outyd_g", config.IsNull(.Item(i)("outyd_g"), ""))
                comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@loc", "")
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "")) 'Plese Check
                comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(i)("outreqdt"), ""))
                comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(i)("outreqtyp"), ""))
                'comm.Parameters.AddWithValue("@outno", PLGNo.Trim)
                'comm.Parameters.AddWithValue("@outdt", OUTDT.Trim) Edit By Neung
                comm.Parameters.AddWithValue("@outno", PLGHeader.h20_outno) 'i to 0
                comm.Parameters.AddWithValue("@outdt", PLGHeader.h21_outdt) 'i to 0
                comm.Parameters.AddWithValue("@sh", "")
                comm.Parameters.AddWithValue("@dfno", "")
                comm.Parameters.AddWithValue("@col", "")
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                comm.Parameters.AddWithValue("@startat", OUTDT.Trim)
                comm.Parameters.AddWithValue("@flagL", "")
                comm.Parameters.AddWithValue("@cost", "")
                comm.Parameters.AddWithValue("@fload", "")
                comm.Parameters.AddWithValue("@rate", "")
                comm.Parameters.AddWithValue("@cost_g", "")
                comm.Parameters.AddWithValue("@outno1", "")
                comm.Parameters.AddWithValue("@outnot", "")
                comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno.Trim)
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                comm.Parameters.AddWithValue("@packdt", config.IsNull(.Item(i)("packdt"), PLGHeader.h38_packdt))
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), "").Trim)
                comm.Parameters.AddWithValue("@invno", "")
                comm.Parameters.AddWithValue("@cancel", "0")
                comm.Parameters.AddWithValue("@cliped", "")
                comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(i)("preseted"), 0))
                comm.Parameters.AddWithValue("@id_greige_do", .Item(i)("id_greige_do"))
                'comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(i)("id_greige_do"), 0)) 'Should Check it Again
                comm.Parameters.AddWithValue("@rack_no", "")
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
        'End Update PLG ----------



        'Start delete Cartons----------

        comm.CommandText = "p_packing_list_g_delete_cartons"
        j = 0
        For j = 0 To dv_dtc_del.Count - 1
            With dv_dtc_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno.Trim)
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

        'Start Add Cartons----------

        comm.CommandText = "p_packing_list_g_insert_cartons"
        j = 0
        For j = 0 To dv_dtc_add.Count - 1
            With dv_dtc_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), 0))
                comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno.Trim)
                comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                comm.Parameters.AddWithValue("@CartonWide", config.IsNull(.Item(j)("carton_wide"), 0)) 'Sitthana 20220723
                comm.Parameters.AddWithValue("@CartonHigh", config.IsNull(.Item(j)("carton_high"), 0)) 'Sitthana 20220723
                comm.Parameters.AddWithValue("@CartonLong", config.IsNull(.Item(j)("carton_long"), 0)) 'Sitthana 20220723
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

        comm.CommandText = "p_packing_list_g_update_cartons"
        j = 0
        For j = 0 To dv_dtc_upd.Count - 1
            With dv_dtc_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno.Trim)
                comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                comm.Parameters.AddWithValue("@CartonWide", config.IsNull(.Item(j)("carton_wide"), 0)) 'Sitthana 20220723
                comm.Parameters.AddWithValue("@CartonHigh", config.IsNull(.Item(j)("carton_high"), 0)) 'Sitthana 20220723
                comm.Parameters.AddWithValue("@CartonLong", config.IsNull(.Item(j)("carton_long"), 0)) 'Sitthana 20220723
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



        'Start Insert Action----------
        'If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "PACK_G"
        With PLGHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", USERID.Trim)
            comm.Parameters.AddWithValue("@docno", PLGHeader.h02_packno.Trim)
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
    Public Function plgsaveGOUT(ByRef PLGHeader As PackingListGHeader, ByVal DV_DTC_ADD As DataView, ByVal DV_DTP_ADD As DataView, ByVal DV_DTC_UPD As DataView, ByVal DV_DTP_UPD As DataView, ByVal DV_DTC_DEL As DataView, ByVal DV_DTP_DEL As DataView, ByRef msgerr As String, ByRef PLGNo As String, ByRef OUTREQNo As String, ByRef OUTNo As String, ByRef OUTDT As String, ByRef USERID As String, ByRef CheckNEW As String, ByRef dtc As DataTable, ByRef dtp2 As DataTable, ByRef Doc_type As String) As Boolean
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

        'Start Gen OUT No----------
        comm.CommandText = "p_packing_list_g_gen_gout"
        With PLGHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno)
            comm.Parameters.AddWithValue("@outno", PLGHeader.h20_outno)
            comm.Parameters.AddWithValue("@outdt", PLGHeader.h21_outdt)
            comm.Parameters.AddWithValue("@empcd", PLGHeader.h46_empcd)
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

        PLGHeader.h20_outno = dt.Rows(0)("outno").ToString.Trim
        OUTNo = PLGHeader.h20_outno
        CheckNEW = dt.Rows(0)("checknew").ToString.Trim

        'Start Update PLG ----------

        i = 0
        comm.CommandText = "p_packing_list_g_update_outno"

        For i = 0 To dtp2.Rows.Count - 1
            With dtp2.Rows
                If dtc.Rows.Item(j).RowState <> DataRowState.Deleted Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                    comm.Parameters.AddWithValue("@nob", "")
                    comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                    comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), "").Trim)
                    comm.Parameters.AddWithValue("@outkg_g", config.IsNull(.Item(i)("outkg_g"), ""))
                    comm.Parameters.AddWithValue("@outmt_g", config.IsNull(.Item(i)("outmt_g"), ""))
                    comm.Parameters.AddWithValue("@outyd_g", config.IsNull(.Item(i)("outyd_g"), ""))
                    comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), "").Trim)
                    comm.Parameters.AddWithValue("@loc", "")
                    comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "")) 'Plese Check
                    comm.Parameters.AddWithValue("@outreqdt", config.IsNull(.Item(i)("outreqdt"), ""))
                    comm.Parameters.AddWithValue("@outreqtyp", config.IsNull(.Item(i)("outreqtyp"), ""))
                    comm.Parameters.AddWithValue("@outno", PLGHeader.h20_outno)
                    comm.Parameters.AddWithValue("@outdt", PLGHeader.h21_outdt)
                    comm.Parameters.AddWithValue("@sh", "")
                    comm.Parameters.AddWithValue("@dfno", "")
                    comm.Parameters.AddWithValue("@col", "")
                    comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                    comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                    comm.Parameters.AddWithValue("@roll_no_o", config.IsNull(.Item(i)("roll_no_o"), "").Trim)
                    comm.Parameters.AddWithValue("@startat", OUTDT.Trim)
                    comm.Parameters.AddWithValue("@flagL", "")
                    comm.Parameters.AddWithValue("@cost", "")
                    comm.Parameters.AddWithValue("@fload", "")
                    comm.Parameters.AddWithValue("@rate", "")
                    comm.Parameters.AddWithValue("@cost_g", "")
                    comm.Parameters.AddWithValue("@outno1", "")
                    comm.Parameters.AddWithValue("@outnot", "")
                    comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), ""))
                    comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), ""))
                    comm.Parameters.AddWithValue("@packdt", config.IsNull(.Item(i)("packdt"), PLGHeader.h38_packdt))
                    comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), "").Trim)
                    comm.Parameters.AddWithValue("@invno", "")
                    comm.Parameters.AddWithValue("@cancel", "0")
                    comm.Parameters.AddWithValue("@cliped", "")
                    comm.Parameters.AddWithValue("@preseted", config.IsNull(.Item(i)("preseted"), 0))
                    comm.Parameters.AddWithValue("@id_greige_do", config.IsNull(.Item(i)("id_greige_do"), 0)) 'Should Check it Again
                    comm.Parameters.AddWithValue("@rack_no", "")
                    comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                    comm.Parameters.AddWithValue("@checknew", CheckNEW)

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
                End If
            End With
            ' OUTNo = dtp_upd.Rows(0)("outno").ToString.Trim
        Next
        'End Update PLG ----------

        'Start update Cartons----------

        comm.CommandText = "p_packing_list_g_update_cartons"
        j = 0
        For j = 0 To dtc.Rows.Count - 1
            With dtc.Rows
                If dtc.Rows.Item(j).RowState <> DataRowState.Deleted Then
                    comm.Parameters.Clear()
                    comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(j)("cartno"), ""))
                    comm.Parameters.AddWithValue("@packno", PLGNo)
                    comm.Parameters.AddWithValue("@netwt", config.IsNull(.Item(j)("netwt"), ""))
                    comm.Parameters.AddWithValue("@grswt", config.IsNull(.Item(j)("grswt"), ""))
                    comm.Parameters.AddWithValue("@dimension", config.IsNull(.Item(j)("dimension"), "").Trim)
                    comm.Parameters.AddWithValue("@CartonWide", config.IsNull(.Item(j)("carton_wide"), 0)) 'Sitthana 20220723
                    comm.Parameters.AddWithValue("@CartonHigh", config.IsNull(.Item(j)("carton_high"), 0)) 'Sitthana 20220723
                    comm.Parameters.AddWithValue("@CartonLong", config.IsNull(.Item(j)("carton_long"), 0)) 'Sitthana 20220723
                    comm.Parameters.AddWithValue("@gout", config.IsNull(PLGHeader.h06_gout, 1))
                    comm.Parameters.AddWithValue("@sel", config.IsNull(PLGHeader.h07_sel, 1))
                    comm.Parameters.AddWithValue("@empcd", USERID.Trim)
                    comm.Parameters.AddWithValue("@checknew", CheckNEW)

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
                End If
            End With
        Next
        'End update Cartons----------

        'Start Insert Action----------

        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim Action As String = "NEW"
        Dim doctyp As String = "GOUT"
        With PLGHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", USERID.Trim)
            comm.Parameters.AddWithValue("@docno", PLGNo)
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

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
    Public Function plgcancel(ByVal PLGHeader As PackingListGHeader, ByVal UserID As String, ByRef msgerr As String) As Boolean
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

        'Strat Insert Action----------
        comm.CommandText = "P_PACKING_LIST_G_PKG_cancel"

        With PLGHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@packno", PLGHeader.h02_packno)
            comm.Parameters.AddWithValue("@empcd", UserID.Trim)

        End With
        Dim da = New SqlDataAdapter(comm)
        Dim dt = New DataTable
        Try
            da.Fill(dt)
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
    Public Function GetREQG(ByVal strREQGNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_req_det_g"
        comm.Parameters.AddWithValue("@outreqno", strREQGNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetPackinglistG(Optional ByVal stock_type As String = "G", Optional ByVal strPackNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal strSoNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetPackinglistGDataCartons(Optional ByVal PackinglistNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_cartons"
        comm.Parameters.AddWithValue("@packno", PackinglistNo)
        'comm.Parameters.AddWithValue("@cartno", Strcartno)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetPackinglistGDataDetail(Optional ByVal strPacking_no As String = "", Optional ByVal Strcartno As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_data_detail"
        comm.Parameters.AddWithValue("@packno", strPacking_no)
        comm.Parameters.AddWithValue("@cartno", Strcartno)
        'comm.Parameters.AddWithValue("@cartno", strcartno.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetCartNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_data_detail"
        comm.Parameters.AddWithValue("@packno", "")
        comm.Parameters.AddWithValue("@cartno", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function IsAlreadyGOUT(ByVal strPacking_no As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_cancel_chk"
        comm.Parameters.AddWithValue("@packno", strPacking_no)
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

    Public Function SearchPackno(Optional ByVal strPackno As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_search"
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

    Public Function GetBalanceGIN(ByVal strTRANNO As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_packing_list_g_select_greige_by_tran_no"
        comm.Parameters.AddWithValue("@tran_no", strTRANNO)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
End Class
