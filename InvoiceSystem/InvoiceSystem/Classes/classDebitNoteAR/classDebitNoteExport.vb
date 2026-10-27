Imports System.Data
Imports System.Data.SqlClient

Public Class classDebitNoteExport
    Public Structure DebitNoteARHeader
        Dim h01_id_dbnote As Nullable(Of Int64)
        Dim h02_dbnote_no As String
        Dim h03_dbnote_date As String
        Dim h04_dbnote_type_id As Integer
        Dim h05_present_status As String
        Dim h06_approval_status As String
        Dim h07_posting_status As String
        Dim h08_dbnote_reqno As String
        Dim h09_dbnote_reason1 As Integer
        Dim h10_dbnote_reason2 As Integer
        Dim h11_dbnote_reason3 As Integer
        Dim h12_custcd As String
        Dim h13_source_docno As String
        Dim h14_source_docdate As String
        Dim h15_source_refno As String
        Dim h16_source_doctype As String
        Dim h17_invid As Long
        Dim h18_invno As String
        Dim h19_invtype As String
        Dim h20_reference As String
        Dim h21_remarks As String
        Dim h22_grossamt As Double
        Dim h23_discamt As Double
        Dim h24_pretaxamt As Double
        Dim h25_vat As Double
        Dim h26_vatamt As Double
        Dim h27_netamt As Double
        Dim h28_revise As Integer
        Dim h29_create_by As String
        Dim h30_create_date As String
        Dim h31_create_time As String
        Dim h32_update_by As String
        Dim h33_update_date As String
        Dim h34_update_time As String
        Dim h35_cancel_by As String
        Dim h36_cancel_date As String
        Dim h37_cancel_time As String
        Dim h38_approve_by As String
        Dim h39_approve_date As String
        Dim h40_approve_time As String
        Dim h41_empcd As String
    End Structure

    Public Function GetDocNo(ByVal lngDocID As Long, _
                             ByVal strDocNo As String, _
                             Optional ByVal strDateFr As String = "", _
                             Optional ByVal strDateTo As String = "", _
                             Optional ByVal strInvNo As String = "") As DataTable

        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_debit_note_export_select_dbnote_no"
        comm.Parameters.AddWithValue("@id_dbnote", lngDocID)
        comm.Parameters.AddWithValue("@dbnote_no", strDocNo)
        comm.Parameters.AddWithValue("@datefr", strDateFr)
        comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@invno", strInvNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDocDetails(ByVal lngDocID As Long, Optional ByVal strDocNo As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_debit_note_export_select_dbnote_ar_det"
        comm.Parameters.AddWithValue("@id_dbnote", lngDocID)
        comm.Parameters.AddWithValue("@dbnote_no", strDocNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetInvNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_debit_note_export_select_invno"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetInvExportDet(ByVal strDocNo As String, ByVal IntInvID As Nullable(Of Int64)) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_debit_note_export_select_inv_export_det"
        comm.Parameters.AddWithValue("@invno", strDocNo)
        comm.Parameters.AddWithValue("@invid", IntInvID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function SaveData(ByRef Header As classDebitNoteExport.DebitNoteARHeader, ByVal DV_ADD As DataView, ByVal DV_UPD As DataView, ByVal DV_DEL As DataView, ByRef msgerr As String, ByRef DocID As Long, ByRef DocNo As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim i As Integer = 0
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_debit_note_export_update_dbnote_ar"
        With Header
            comm.Parameters.AddWithValue("@id_dbnote", config.IsNull(.h01_id_dbnote, 0)) '
            comm.Parameters.AddWithValue("@dbnote_no", .h02_dbnote_no.Trim)
            comm.Parameters.AddWithValue("@dbnote_date", .h03_dbnote_date.Trim)
            comm.Parameters.AddWithValue("@id_dbnote_type", .h04_dbnote_type_id.ToString)
            comm.Parameters.AddWithValue("@present_status", .h05_present_status.Trim)
            comm.Parameters.AddWithValue("@approval_status", .h06_approval_status.Trim)
            comm.Parameters.AddWithValue("@posting_status", .h07_posting_status.Trim)
            comm.Parameters.AddWithValue("@dbnote_reqno", .h08_dbnote_reqno.Trim)
            comm.Parameters.AddWithValue("@dbnote_reason1", .h09_dbnote_reason1.ToString)
            comm.Parameters.AddWithValue("@dbnote_reason2", .h10_dbnote_reason2.ToString)
            comm.Parameters.AddWithValue("@dbnote_reason3", .h11_dbnote_reason3.ToString)
            comm.Parameters.AddWithValue("@custcd", .h12_custcd.Trim)
            comm.Parameters.AddWithValue("@source_docno", .h13_source_docno.Trim)
            comm.Parameters.AddWithValue("@source_docdate", .h14_source_docdate.Trim)
            comm.Parameters.AddWithValue("@source_refno", .h15_source_refno.Trim)
            comm.Parameters.AddWithValue("@source_doctype", .h16_source_doctype.Trim)
            comm.Parameters.AddWithValue("@invid", .h17_invid)
            comm.Parameters.AddWithValue("@invno", .h18_invno.Trim)
            comm.Parameters.AddWithValue("@invtype", .h19_invtype)
            comm.Parameters.AddWithValue("@reference", .h20_reference.Trim)
            comm.Parameters.AddWithValue("@remarks", .h21_remarks.Trim)
            comm.Parameters.AddWithValue("@grossamt", .h22_grossamt.ToString)
            comm.Parameters.AddWithValue("@discamt", .h23_discamt.ToString)
            comm.Parameters.AddWithValue("@pretaxamt", .h24_pretaxamt.ToString)
            comm.Parameters.AddWithValue("@vat", .h25_vat.ToString)
            comm.Parameters.AddWithValue("@vatamt", .h26_vatamt.ToString)
            comm.Parameters.AddWithValue("@netamt", .h27_netamt.ToString)
            comm.Parameters.AddWithValue("@revise", .h28_revise)
            comm.Parameters.AddWithValue("@create_by", .h29_create_by.Trim)
            comm.Parameters.AddWithValue("@create_date", .h30_create_date.Trim)
            comm.Parameters.AddWithValue("@create_time", .h31_create_time.Trim)
            comm.Parameters.AddWithValue("@update_by", .h32_update_by.Trim)
            comm.Parameters.AddWithValue("@update_date", .h33_update_date.Trim)
            comm.Parameters.AddWithValue("@update_time", .h34_update_time.Trim)
            comm.Parameters.AddWithValue("@cancel_by", .h35_cancel_by.Trim)
            comm.Parameters.AddWithValue("@cancel_date", .h36_cancel_date.Trim)
            comm.Parameters.AddWithValue("@cancel_time", .h37_cancel_time.Trim)
            comm.Parameters.AddWithValue("@approve_by", .h38_approve_by.Trim)
            comm.Parameters.AddWithValue("@approve_date", .h39_approve_date.Trim)
            comm.Parameters.AddWithValue("@approve_time", .h40_approve_time.Trim)
            comm.Parameters.AddWithValue("@empcd", .h41_empcd)
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
        Header.h01_id_dbnote = Val(dt.Rows(0)("id_dbnote").ToString)
        Header.h02_dbnote_no = dt.Rows(0)("dbnote_no").ToString
        DocID = Val(dt.Rows(0)("id_dbnote").ToString)
        DocNo = dt.Rows(0)("dbnote_no").ToString

        'Add Detail----------

        i = 0
        comm.CommandText = "p_debit_note_export_update_dbnote_ar_det"

        For i = 0 To DV_ADD.Count - 1
            With DV_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_dbnote_det", 0)
                comm.Parameters.AddWithValue("@id_dbnote", Header.h01_id_dbnote)
                comm.Parameters.AddWithValue("@dbnote_no", Header.h02_dbnote_no)
                comm.Parameters.AddWithValue("@dbnote_ord", config.IsNull(.Item(i)("dbnote_ord"), 0))
                comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
                comm.Parameters.AddWithValue("@return_goods", config.IsNull(.Item(i)("return_goods"), False))
                comm.Parameters.AddWithValue("@stk_in_no", config.IsNull(.Item(i)("stk_in_no"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt"), 0).ToString)
                comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty"), 0).ToString)
                comm.Parameters.AddWithValue("@uom_id", .Item(i)("uom_id"))
                comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice"), 0).ToString)
                comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt"), 0).ToString)
                comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate"), DBNull.Value))
                comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), DBNull.Value))
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
        comm.CommandText = "p_debit_note_export_update_dbnote_ar_det"

        For i = 0 To DV_UPD.Count - 1
            With DV_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_dbnote_det", config.IsNull(.Item(i)("id_dbnote_det"), 0))
                comm.Parameters.AddWithValue("@id_dbnote", Header.h01_id_dbnote)
                comm.Parameters.AddWithValue("@dbnote_no", Header.h02_dbnote_no)
                comm.Parameters.AddWithValue("@dbnote_ord", config.IsNull(.Item(i)("dbnote_ord"), 0))
                comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
                comm.Parameters.AddWithValue("@return_goods", config.IsNull(.Item(i)("return_goods"), False))
                comm.Parameters.AddWithValue("@stk_in_no", config.IsNull(.Item(i)("stk_in_no"), "").Trim)
                comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt"), 0).ToString)
                comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty"), 0).ToString)
                comm.Parameters.AddWithValue("@uom_id", .Item(i)("uom_id"))
                comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice"), 0).ToString)
                comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt"), 0).ToString)
                comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate"), DBNull.Value))
                comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), DBNull.Value))
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
        comm.CommandText = "p_debit_note_export_delete_dbnote_ar_det"

        For i = 0 To DV_DEL.Count - 1
            With DV_DEL
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_dbnote_det", .Item(i)("id_dbnote_det"))
                comm.Parameters.AddWithValue("@del_by", Header.h32_update_by)
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

    Public Function Cancel(ByVal lngDocID As Long, ByVal strEmpCD As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_debit_note_export_cancel_dbnote_ar"
        comm.Parameters.AddWithValue("@id_dbnote", lngDocID)
        comm.Parameters.AddWithValue("@cancel_by", strEmpCD)
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

    Public Function Approve(ByVal lngDocID As Long, ByVal strEmpCD As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_debit_note_export_approve_dbnote_ar"
        comm.Parameters.AddWithValue("@id_dbnote", lngDocID)
        comm.Parameters.AddWithValue("@approve_by", strEmpCD)
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

    Public Function Validate_InvNo(Optional ByVal StrInvno As String = "", Optional ByVal StrEmpcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure

        comm.CommandText = "p_debit_note_export_select_invno_validate"

        comm.Parameters.AddWithValue("@invno", StrInvno)
        comm.Parameters.AddWithValue("@logempcd", StrEmpcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return (dt)
    End Function
End Class
