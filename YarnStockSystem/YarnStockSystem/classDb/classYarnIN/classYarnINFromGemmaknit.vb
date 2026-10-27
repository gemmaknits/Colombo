Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classYarnINFromGemmaknit

    Public Structure YarnIn
        Dim docdt As Nullable(Of DateTime)
        Dim docno As String
        Dim jobno As String
        Dim purno As String
        Dim sinvno As String
        Dim sinvdt As String
        Dim suppcd As String
        Dim lotno_sup As String
        Dim lotno_our As String
        Dim srefno As String
        Dim totkg As Nullable(Of Decimal)
        Dim curr As String
        Dim exrt As Nullable(Of Decimal)
        Dim vat As Nullable(Of Decimal)
        Dim vatamt As Nullable(Of Decimal)
        Dim taxper As Nullable(Of Decimal)
        Dim taxamt As Nullable(Of Decimal)
        Dim freight As Nullable(Of Decimal)
        Dim insurance As Nullable(Of Decimal)
        Dim otheramt As Nullable(Of Decimal)
        Dim other_text As Nullable(Of Decimal)
        Dim discamt As Nullable(Of Decimal)
        Dim totamt As Nullable(Of Decimal)
        Dim tstamp As Nullable(Of DateTime)
        Dim tran_type As String
        Dim docapp As Nullable(Of Boolean)
        Dim cancel As Nullable(Of Boolean)
        Dim outno As String
        Dim remark As String
        Dim present_status As String
        Dim _have_stock As Nullable(Of Boolean)
        Dim locked As Nullable(Of Boolean)

        Dim Message As String




    End Structure

    'Public Function Validate_sinvno(ByVal StrSinvno As String) As Boolean
    '    Dim conn As New SqlConnection((New classConnection).ConnectionString)
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure

    '    comm.CommandText = "p_greige_in_ko_manual_select_ko_validate"

    '    'comm.Parameters.AddWithValue("@kono", Strkono)
    '    'comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    If dt.Rows.Count > 0 Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function
    Public Function GetYarnInFromGemmaknits(ByRef LogNo As String) As DataTable
        Dim dt As New DataTable
        'Dim sqlconnection As New SqlConnection
        'Dim classconnection As New classConnection

        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_location_log_select_from_gemmaknit"
        comm.Parameters.AddWithValue("@logno", LogNo)
        comm.CommandTimeout = 360
        Dim da As New SqlDataAdapter(comm)
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetYarnIn(ByRef DocNo As String) As DataTable
        Dim dt As New DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_location_log_select_yarn_in_det"
        comm.Parameters.AddWithValue("@docno", DocNo)
        Dim da As New SqlDataAdapter(comm)
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetComboYarnIn(ByRef clsuser As classUserInfo) As DataTable
        Dim dt As New DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_yarn_in_location_log_select_combo"
        comm.Parameters.AddWithValue("@userid", clsuser.UserID)
        Dim da As New SqlDataAdapter(comm)
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function


    Public Function SaveYarnIn(ByRef YarnIn As YarnIn, ByVal dv_add As DataView, ByVal dv_upd As DataView, ByVal dv_del As DataView, ByRef clsuser As classUserInfo) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).Connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        Dim j As Integer = 0

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure


        comm.CommandText = "p_yarn_in_location_log_update_yarn_in"
        With YarnIn
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@docdt", .docdt)
            comm.Parameters.AddWithValue("@docno", .docno)
            comm.Parameters.AddWithValue("@jobno", .jobno)
            comm.Parameters.AddWithValue("@purno", .purno)
            comm.Parameters.AddWithValue("@sinvno", .sinvno)
            comm.Parameters.AddWithValue("@sinvdt", .sinvdt)
            comm.Parameters.AddWithValue("@suppcd", .suppcd)
            comm.Parameters.AddWithValue("@lotno_sup", .lotno_sup)
            comm.Parameters.AddWithValue("@lotno_our", .lotno_our)
            comm.Parameters.AddWithValue("@srefno", .srefno)
            comm.Parameters.AddWithValue("@totkg", .totkg)
            comm.Parameters.AddWithValue("@curr", .curr)
            comm.Parameters.AddWithValue("@exrt", .exrt)
            comm.Parameters.AddWithValue("@vat", .vat)
            comm.Parameters.AddWithValue("@vatamt", .vatamt)
            comm.Parameters.AddWithValue("@taxper", .taxper)
            comm.Parameters.AddWithValue("@taxamt", .taxamt)
            comm.Parameters.AddWithValue("@freight", .freight)
            comm.Parameters.AddWithValue("@insurance", .insurance)
            comm.Parameters.AddWithValue("@otheramt", .otheramt)
            comm.Parameters.AddWithValue("@other_text", .other_text)
            comm.Parameters.AddWithValue("@discamt", .discamt)
            comm.Parameters.AddWithValue("@totamt", .totamt)
            comm.Parameters.AddWithValue("@tstamp", .tstamp)
            comm.Parameters.AddWithValue("@tran_type", .tran_type)
            comm.Parameters.AddWithValue("@docapp", .docapp)
            comm.Parameters.AddWithValue("@cancel", .cancel)
            comm.Parameters.AddWithValue("@outno", .outno)
            comm.Parameters.AddWithValue("@remark", .remark)
            comm.Parameters.AddWithValue("@present_status", .present_status)
            comm.Parameters.AddWithValue("@_have_stock", ._have_stock)
            comm.Parameters.AddWithValue("@locked", .locked)

            comm.Parameters.AddWithValue("@log_empcd", clsuser.UserID)

        End With
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            YarnIn.Message = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        YarnIn.docno = dt.Rows(0)("docno").ToString.Trim



        comm.CommandText = "p_yarn_in_location_log_insert_yarn_in_det"
        For i = 0 To dv_add.Count - 1
            With dv_add
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@docno", YarnIn.docno)
                comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd"))
                comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s"))
                comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno"))
                comm.Parameters.AddWithValue("@boxno_o", .Item(i)("boxno_o"))
                comm.Parameters.AddWithValue("@boxno_p", .Item(i)("boxno_p"))
                comm.Parameters.AddWithValue("@lotno_sup", .Item(i)("lotno_sup"))
                comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our"))
                comm.Parameters.AddWithValue("@spools", .Item(i)("spools"))
                comm.Parameters.AddWithValue("@grade", .Item(i)("grade"))
                comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr"))
                comm.Parameters.AddWithValue("@cart_tearwt", .Item(i)("cart_tearwt"))
                comm.Parameters.AddWithValue("@spool_tearwt", .Item(i)("spool_tearwt"))
                comm.Parameters.AddWithValue("@kg_nt", .Item(i)("kg_nt"))
                comm.Parameters.AddWithValue("@price", .Item(i)("price"))
                comm.Parameters.AddWithValue("@tstamp", .Item(i)("tstamp"))
                comm.Parameters.AddWithValue("@used", .Item(i)("used"))
                comm.Parameters.AddWithValue("@_have_stock", .Item(i)("_have_stock"))
                comm.Parameters.AddWithValue("@_stock_remarks", .Item(i)("_stock_remarks"))
                comm.Parameters.AddWithValue("@_boxno", .Item(i)("_boxno"))
                comm.Parameters.AddWithValue("@_boxno_o", .Item(i)("_boxno_o"))
                comm.Parameters.AddWithValue("@_boxno_p", .Item(i)("_boxno_p"))
                comm.Parameters.AddWithValue("@boxno_f", .Item(i)("boxno_f"))
                comm.Parameters.AddWithValue("@suppcd", .Item(i)("suppcd"))
                comm.Parameters.AddWithValue("@_lotno_our", .Item(i)("_lotno_our"))
                comm.Parameters.AddWithValue("@id_jobdet", .Item(i)("id_jobdet"))
                comm.Parameters.AddWithValue("@job_line_id", .Item(i)("job_line_id"))
                comm.Parameters.AddWithValue("@loc", .Item(i)("loc"))
                comm.Parameters.AddWithValue("@yarn_cost", .Item(i)("yarn_cost"))
                comm.Parameters.AddWithValue("@process_cost", .Item(i)("process_cost"))
                comm.Parameters.AddWithValue("@process_loss_perc", .Item(i)("process_loss_perc"))
                comm.Parameters.AddWithValue("@other_cost", .Item(i)("other_cost"))
                comm.Parameters.AddWithValue("@cost_per_unit", .Item(i)("cost_per_unit"))
                comm.Parameters.AddWithValue("@box_remark", .Item(i)("box_remark"))
                comm.Parameters.AddWithValue("@dye_test_result", .Item(i)("dye_test_result"))
                comm.Parameters.AddWithValue("@loc_sub", .Item(i)("loc_sub"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@log_empcd", .Item(i)("log_empcd"))

            End With
            Dim da_add As New SqlDataAdapter(comm)
            Dim dt_add As New DataTable
            Try
                da_add.Fill(dt_add)
            Catch ex As Exception
                YarnIn.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        comm.CommandText = "p_yarn_in_location_log_update_yarn_in_det"
        For i = 0 To dv_upd.Count - 1
            With dv_upd
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@docno", YarnIn.docno)
                comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd"))
                comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s"))
                comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno"))
                comm.Parameters.AddWithValue("@boxno_o", .Item(i)("boxno_o"))
                comm.Parameters.AddWithValue("@boxno_p", .Item(i)("boxno_p"))
                comm.Parameters.AddWithValue("@lotno_sup", .Item(i)("lotno_sup"))
                comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our"))
                comm.Parameters.AddWithValue("@spools", .Item(i)("spools"))
                comm.Parameters.AddWithValue("@grade", .Item(i)("grade"))
                comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr"))
                comm.Parameters.AddWithValue("@cart_tearwt", .Item(i)("cart_tearwt"))
                comm.Parameters.AddWithValue("@spool_tearwt", .Item(i)("spool_tearwt"))
                comm.Parameters.AddWithValue("@kg_nt", .Item(i)("kg_nt"))
                comm.Parameters.AddWithValue("@price", .Item(i)("price"))
                comm.Parameters.AddWithValue("@tstamp", .Item(i)("tstamp"))
                comm.Parameters.AddWithValue("@used", .Item(i)("used"))
                comm.Parameters.AddWithValue("@_have_stock", .Item(i)("_have_stock"))
                comm.Parameters.AddWithValue("@_stock_remarks", .Item(i)("_stock_remarks"))
                comm.Parameters.AddWithValue("@_boxno", .Item(i)("_boxno"))
                comm.Parameters.AddWithValue("@_boxno_o", .Item(i)("_boxno_o"))
                comm.Parameters.AddWithValue("@_boxno_p", .Item(i)("_boxno_p"))
                comm.Parameters.AddWithValue("@boxno_f", .Item(i)("boxno_f"))
                comm.Parameters.AddWithValue("@suppcd", .Item(i)("suppcd"))
                comm.Parameters.AddWithValue("@_lotno_our", .Item(i)("_lotno_our"))
                comm.Parameters.AddWithValue("@id_jobdet", .Item(i)("id_jobdet"))
                comm.Parameters.AddWithValue("@job_line_id", .Item(i)("job_line_id"))
                comm.Parameters.AddWithValue("@loc", .Item(i)("loc"))
                comm.Parameters.AddWithValue("@yarn_cost", .Item(i)("yarn_cost"))
                comm.Parameters.AddWithValue("@process_cost", .Item(i)("process_cost"))
                comm.Parameters.AddWithValue("@process_loss_perc", .Item(i)("process_loss_perc"))
                comm.Parameters.AddWithValue("@other_cost", .Item(i)("other_cost"))
                comm.Parameters.AddWithValue("@cost_per_unit", .Item(i)("cost_per_unit"))
                comm.Parameters.AddWithValue("@box_remark", .Item(i)("box_remark"))
                comm.Parameters.AddWithValue("@dye_test_result", .Item(i)("dye_test_result"))
                comm.Parameters.AddWithValue("@loc_sub", .Item(i)("loc_sub"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@log_empcd", .Item(i)("log_empcd"))

            End With
            Dim da_upd As New SqlDataAdapter(comm)
            Dim dt_upd As New DataTable
            Try
                da_upd.Fill(dt_upd)
            Catch ex As Exception
                YarnIn.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next

        comm.CommandText = "p_yarn_in_location_log_delete_yarn_in_det"
        For i = 0 To dv_del.Count - 1
            With dv_del
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@docno", YarnIn.docno)
                comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd"))
                comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s"))
                comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno"))
                comm.Parameters.AddWithValue("@boxno_o", .Item(i)("boxno_o"))
                comm.Parameters.AddWithValue("@boxno_p", .Item(i)("boxno_p"))
                comm.Parameters.AddWithValue("@lotno_sup", .Item(i)("lotno_sup"))
                comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our"))
                comm.Parameters.AddWithValue("@spools", .Item(i)("spools"))
                comm.Parameters.AddWithValue("@grade", .Item(i)("grade"))
                comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr"))
                comm.Parameters.AddWithValue("@cart_tearwt", .Item(i)("cart_tearwt"))
                comm.Parameters.AddWithValue("@spool_tearwt", .Item(i)("spool_tearwt"))
                comm.Parameters.AddWithValue("@kg_nt", .Item(i)("kg_nt"))
                comm.Parameters.AddWithValue("@price", .Item(i)("price"))
                comm.Parameters.AddWithValue("@tstamp", .Item(i)("tstamp"))
                comm.Parameters.AddWithValue("@used", .Item(i)("used"))
                comm.Parameters.AddWithValue("@_have_stock", .Item(i)("_have_stock"))
                comm.Parameters.AddWithValue("@_stock_remarks", .Item(i)("_stock_remarks"))
                comm.Parameters.AddWithValue("@_boxno", .Item(i)("_boxno"))
                comm.Parameters.AddWithValue("@_boxno_o", .Item(i)("_boxno_o"))
                comm.Parameters.AddWithValue("@_boxno_p", .Item(i)("_boxno_p"))
                comm.Parameters.AddWithValue("@boxno_f", .Item(i)("boxno_f"))
                comm.Parameters.AddWithValue("@suppcd", .Item(i)("suppcd"))
                comm.Parameters.AddWithValue("@_lotno_our", .Item(i)("_lotno_our"))
                comm.Parameters.AddWithValue("@id_jobdet", .Item(i)("id_jobdet"))
                comm.Parameters.AddWithValue("@job_line_id", .Item(i)("job_line_id"))
                comm.Parameters.AddWithValue("@loc", .Item(i)("loc"))
                comm.Parameters.AddWithValue("@yarn_cost", .Item(i)("yarn_cost"))
                comm.Parameters.AddWithValue("@process_cost", .Item(i)("process_cost"))
                comm.Parameters.AddWithValue("@process_loss_perc", .Item(i)("process_loss_perc"))
                comm.Parameters.AddWithValue("@other_cost", .Item(i)("other_cost"))
                comm.Parameters.AddWithValue("@cost_per_unit", .Item(i)("cost_per_unit"))
                comm.Parameters.AddWithValue("@box_remark", .Item(i)("box_remark"))
                comm.Parameters.AddWithValue("@dye_test_result", .Item(i)("dye_test_result"))
                comm.Parameters.AddWithValue("@loc_sub", .Item(i)("loc_sub"))
                comm.Parameters.AddWithValue("@mtl_warehouse_id", .Item(i)("mtl_warehouse_id"))
                comm.Parameters.AddWithValue("@mtl_locations_id", .Item(i)("mtl_locations_id"))
                comm.Parameters.AddWithValue("@log_empcd", .Item(i)("log_empcd"))

            End With
            Dim da_del As New SqlDataAdapter(comm)
            Dim dt_del As New DataTable
            Try
                da_del.Fill(dt_del)
            Catch ex As Exception
                YarnIn.Message = ex.Message
                tran.Rollback()
                conn.Close()  'Sitthana 20190325
                Return False
            End Try
        Next


        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function
End Class
