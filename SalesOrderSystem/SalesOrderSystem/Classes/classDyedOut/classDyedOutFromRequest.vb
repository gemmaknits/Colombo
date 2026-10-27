Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classDyedOutFromRequest
    Public Structure DyedOutFromRequestHeader

        'Stroll_d_o
        Dim design_no As String
        Dim nob As Double
        Dim Gwth As String
        Dim roll_no_d As String
        Dim outkg_g As Double
        Dim outmt_g As Double
        Dim outyd_g As Double
        Dim grade As String
        Dim loc As String
        Dim outreqno As String
        Dim outreqdt As Nullable(Of Date)
        Dim outreqtyp As String
        Dim outno As String
        Dim outdt As Nullable(Of Date)
        Dim sh As String
        Dim dfno As String
        Dim col As String
        Dim sono As String
        Dim sonoid As String
        Dim roll_no_o As String
        Dim startat As String
        Dim flagL As String
        Dim cost As String
        Dim fload As Boolean
        Dim rate As Double
        Dim cost_g As Double
        Dim outno1 As String
        Dim outnot As String
        Dim packno As String 'Same h01_cartno
        Dim cartno As Double 'Same h02_packno
        Dim packdt As Nullable(Of Date)
        Dim pono As String
        Dim invno As String
        Dim cancel As Boolean
        Dim cliped As Boolean
        Dim preseted As Boolean
        Dim id_greige_do As Double
        Dim rack_no As String
        Dim id_strolls_d_o As Double
        Dim empcd As String
        Dim checknew As String
        Dim msgerr As String
    End Structure

    Public Function GetREQD(ByVal strREQDNo As String, ByRef StrMessage As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_req_select_req_det_dc"
        comm.Parameters.AddWithValue("@outreqno", strREQDNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            StrMessage = ex.Message
            conn.Close()  'Sitthana 20190325
        End Try
        Return dt
    End Function

    Public Function GetBalanceDIN(ByVal strDINNO As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_req_select_strolls_d_by_dinno"
        comm.Parameters.AddWithValue("@dinno", strDINNO)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetBalanceLot(ByVal strLotNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_req_select_strolls_d_by_lot"
        comm.Parameters.AddWithValue("@lot", strLotNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SearchOutReqNo(Optional ByVal strStockType As String = "A", Optional ByVal strReqNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal strOutReqtyp As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_req_select_outreqno_search"
        comm.Parameters.AddWithValue("@stock_type", strStockType.Trim)
        comm.Parameters.AddWithValue("@outreqno", strReqNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@custcd", strCustCD)
        comm.Parameters.AddWithValue("@outreqtyp", strOutReqtyp)
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
        comm.CommandText = "p_dyed_out_from_req_select_outreqno_validate_cancel"
        comm.Parameters.AddWithValue("@outreqno", outreqno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ValidateReqNoIsOut(ByVal outreqno As String, ByVal logempcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_req_select_outreqno_validate_outno"
        comm.Parameters.AddWithValue("@outreqno", outreqno)
        comm.Parameters.AddWithValue("@logempcd", logempcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDOUTDataDetail(Optional ByVal stroutno As String = "", Optional ByVal strcartno As String = "", Optional ByVal strOutReqTyp As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_out_from_req_select_strolls_d_o"
        comm.Parameters.AddWithValue("@outno", stroutno)
        'comm.Parameters.AddWithValue("@cartno", strcartno)
        comm.Parameters.AddWithValue("@outreqtyp", strOutReqTyp)
        'comm.Parameters.AddWithValue("@cartno", strcartno.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SAVEDOUT(ByRef DOUTHeader As DyedOutFromRequestHeader, ByVal dtd As DataTable, ByVal dv_dtd_add As DataView, ByVal dv_dtd_upd As DataView, ByVal dv_dtd_del As DataView, ByRef clsUSER As classUserInfo) As Boolean
        Dim config As New clsConfig
        'Dim clsuser As New classUserInfo

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
        comm.CommandText = "p_dyed_out_from_req_select_gen_dout"

        With DOUTHeader
            'With dt.Rows
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@packno", DOUTHeader.packno)
            comm.Parameters.AddWithValue("@outno", DOUTHeader.outno)
            comm.Parameters.AddWithValue("@empcd", DOUTHeader.empcd)
            comm.Parameters.AddWithValue("@checknew", DOUTHeader.checknew)
            comm.Parameters.AddWithValue("@doctyp", DOUTHeader.outreqtyp)
        End With
        'End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            DOUTHeader.msgerr = ex.Message
            tran.Rollback()
            conn.Close() 'Sitthana 20190325
            Return False

        End Try
        DOUTHeader.outno = dt.Rows(0)("outno").ToString.Trim
        DOUTHeader.checknew = dt.Rows(0)("checknew").ToString.Trim
        'END Gen PLD No----------
        'End

        'Start Insert PLD----------
        comm.CommandText = "p_dyed_out_from_req_insert_strolls_d_o"
        i = 0
        For i = 0 To dv_dtd_add.Count - 1
            With dv_dtd_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(DOUTHeader.outno, ""))
                comm.Parameters.AddWithValue("@outdt", config.IsNull(DOUTHeader.outdt, ""))
                comm.Parameters.AddWithValue("@doctyp", DOUTHeader.outreqtyp.Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
                comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
                comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), ""))
                comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), ""))
                comm.Parameters.AddWithValue("@sh", .Item(i)("sh"))
                comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
                comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("grade"), "").Trim)
                comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("outkg_g"), 0))
                comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("outmt_g"), 0))
                comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("outyd_g"), 0))
                comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
                comm.Parameters.AddWithValue("@nob", .Item(i)("nob"))
                comm.Parameters.AddWithValue("@typ", .Item(i)("typ"))
                comm.Parameters.AddWithValue("@status", .Item(i)("status"))
                comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
                comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), ""))
                comm.Parameters.AddWithValue("@rl_at_cut", .Item(i)("rl_at_cut"))
                comm.Parameters.AddWithValue("@rw_at_cut", .Item(i)("rw_at_cut"))
                comm.Parameters.AddWithValue("@mts_at_cut", .Item(i)("mts_at_cut"))
                comm.Parameters.AddWithValue("@yds_at_cut", .Item(i)("yds_at_cut"))
                comm.Parameters.AddWithValue("@mts_g", .Item(i)("mts_g"))
                comm.Parameters.AddWithValue("@yds_g", .Item(i)("yds_g"))
                comm.Parameters.AddWithValue("@allowmt", .Item(i)("allowmt"))
                comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
                comm.Parameters.AddWithValue("@cutcardno", .Item(i)("cutcardno"))
                comm.Parameters.AddWithValue("@cutcardsno", .Item(i)("cutcardsno"))
                comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno"), 0))
                comm.Parameters.AddWithValue("@packno", .Item(i)("packno"))
                comm.Parameters.AddWithValue("@packdt", .Item(i)("packdt"))
                comm.Parameters.AddWithValue("@sel", .Item(i)("sel"))
                comm.Parameters.AddWithValue("@cost", .Item(i)("cost"))
                comm.Parameters.AddWithValue("@batch", .Item(i)("batch")) 'Should Check it Again
                comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), ""))
                comm.Parameters.AddWithValue("@invno", .Item(i)("invno"))
                comm.Parameters.AddWithValue("@fload", .Item(i)("fload"))
                comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
                'comm.Parameters.AddWithValue("@outno1", .Item(i)("outno1"))
                comm.Parameters.AddWithValue("@outno1", .Item(i)("outno1")) 'Roll_no_o on strolls_d = outno1 on strolls_d_o
                comm.Parameters.AddWithValue("@outnot", .Item(i)("outnot"))
                comm.Parameters.AddWithValue("@verno", .Item(i)("verno"))
                comm.Parameters.AddWithValue("@dinno", .Item(i)("dinno"))
                comm.Parameters.AddWithValue("@_kg", config.IsNull(.Item(i)("outkg_g"), 0))
                comm.Parameters.AddWithValue("@_mts", config.IsNull(.Item(i)("outmt_g"), 0))
                comm.Parameters.AddWithValue("@_yds", config.IsNull(.Item(i)("outyd_g"), 0))
                comm.Parameters.AddWithValue("@id_strolls_d_o", DOUTHeader.id_strolls_d_o)
                comm.Parameters.AddWithValue("@empcd", clsUSER.UserID.Trim)
                comm.Parameters.AddWithValue("@checknew", DOUTHeader.checknew)
            End With
            ' Dim sql As String = config.BuildSQL(comm)
            Dim dap_add As New SqlDataAdapter(comm)
            Dim dtp_add As New DataTable
            Try
                dap_add.Fill(dtp_add)
            Catch ex As Exception
                DOUTHeader.msgerr = ex.Message
                tran.Rollback()
                conn.Close() 'Sitthana 20190325
                Return False

            End Try
            Action = "ADD"
            'PLGNo = dtp.Rows(0)("packno").ToString.Trim
            'CheckNEW = dt.Rows(0)("checknew").ToString.Trim
            ' strLotNo = dt.Rows(0)("lot").ToString.Trim
        Next
        'End  Add strolls_d_o-----------

        'Start Update strolls_d_o
        i = 0
        comm.CommandText = "p_dyed_out_from_req_update_strolls_d_o"

        For i = 0 To dv_dtd_upd.Count - 1
            With dv_dtd_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", DOUTHeader.outno)
                comm.Parameters.AddWithValue("@outdt", DOUTHeader.outdt)
                comm.Parameters.AddWithValue("@doctyp", DOUTHeader.outreqtyp)
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
                comm.Parameters.AddWithValue("@id_strolls_d_o", DOUTHeader.id_strolls_d_o)
                comm.Parameters.AddWithValue("@empcd", clsUSER.UserID)
                comm.Parameters.AddWithValue("@checknew", DOUTHeader.checknew)
            End With
            Dim dap_upd = New SqlDataAdapter(comm)
            Dim dtp_upd = New DataTable
            Try
                dap_upd.Fill(dtp_upd)
            Catch ex As Exception
                DOUTHeader.msgerr = ex.Message
                tran.Rollback()
                conn.Close() 'Sitthana 20190325
                Return False
            End Try

            'DOUTHeader.outno = dtp_upd.Rows(0)("outno").ToString.Trim
        Next
        'End Update strolls_d_o

        'Start Delete PLG ----------

        i = 0
        comm.CommandText = "p_dyed_out_from_req_delete_strolls_d_o"

        For i = 0 To dv_dtd_del.Count - 1
            With dv_dtd_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").Trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(i)("outdt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(DOUTHeader.outreqtyp, "doctyp").Trim)
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
                comm.Parameters.AddWithValue("@id_strolls_d_o", config.IsNull(.Item(i)("id_strolls_d_o"), 0))
                comm.Parameters.AddWithValue("@empcd", clsUSER.UserID.Trim)
                comm.Parameters.AddWithValue("@checknew", DOUTHeader.checknew)
            End With
            Dim dap_del = New SqlDataAdapter(comm)
            Dim dtp_del = New DataTable
            Try
                dap_del.Fill(dtp_del)
            Catch ex As Exception
                DOUTHeader.msgerr = ex.Message
                tran.Rollback()
                conn.Close() 'Sitthana 20190325
                Return False
            End Try
            Action = "CHANGE"
        Next
        'End Delete PLG ----------



        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "DOUT"
        With DOUTHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", clsUSER.UserID)
            comm.Parameters.AddWithValue("@docno", DOUTHeader.outno)
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
            DOUTHeader.msgerr = ex.Message
            tran.Rollback()
            conn.Close() 'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

    Public Function CANCELDOUT(ByRef DOUTHeader As DyedOutFromRequestHeader, ByVal dtd As DataTable, ByVal dv_dtd_add As DataView, ByVal dv_dtd_upd As DataView, ByVal dv_dtd_del As DataView, ByRef clsUSER As classUserInfo) As Boolean
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

        'Start  Add PLD bin-----------
        comm.CommandText = "p_dyed_out_from_req_insert_strolls_d_o_bin"
        i = 0
        For i = 0 To dtd.Rows.Count - 1
            With dtd.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").Trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(i)("outdt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(DOUTHeader.outreqtyp, "doctyp").Trim)
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
                comm.Parameters.AddWithValue("@id_strolls_d_o", config.IsNull(.Item(i)("id_strolls_d_o"), 0))
                comm.Parameters.AddWithValue("@empcd", clsUSER.UserID.Trim)
                comm.Parameters.AddWithValue("@checknew", DOUTHeader.checknew)
            End With

            Dim dap_add As New SqlDataAdapter(comm)
            Dim dtp_add As New DataTable
            Try
                dap_add.Fill(dtp_add)
            Catch ex As Exception
                DOUTHeader.msgerr = ex.Message
                tran.Rollback()
                conn.Close() 'Sitthana 20190325
                Return False

            End Try

        Next
        'End  Add PLD bin-----------

        'Start CANCEL PLG ----------

        i = 0
        comm.CommandText = "p_dyed_out_from_req_delete_strolls_d_o"

        For i = 0 To dtd.Rows.Count - 1
            With dtd.Rows
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").Trim)
                comm.Parameters.AddWithValue("@outdt", config.IsNull(.Item(i)("outdt"), ""))
                comm.Parameters.AddWithValue("@doctyp", config.IsNull(DOUTHeader.outreqtyp, "doctyp").Trim)
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
                comm.Parameters.AddWithValue("@id_strolls_d_o", config.IsNull(.Item(i)("id_strolls_d_o"), 0))
                comm.Parameters.AddWithValue("@empcd", clsUSER.UserID.Trim)
                comm.Parameters.AddWithValue("@checknew", DOUTHeader.checknew)
            End With
            Dim dap_del = New SqlDataAdapter(comm)
            Dim dtp_del = New DataTable
            Try
                dap_del.Fill(dtp_del)
            Catch ex As Exception
                DOUTHeader.msgerr = ex.Message
                tran.Rollback()
                conn.Close() 'Sitthana 20190325
                Return False
            End Try
            Action = "CHANGE"
        Next
        'End Delete PLG ----------



        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "DOUT"
        With DOUTHeader
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@empcd", clsUSER.UserID)
            comm.Parameters.AddWithValue("@docno", DOUTHeader.outno)
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
            DOUTHeader.msgerr = ex.Message
            tran.Rollback()
            conn.Close() 'Sitthana 20190325
            Return False
        End Try


        'End Insert Action----------

        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class
