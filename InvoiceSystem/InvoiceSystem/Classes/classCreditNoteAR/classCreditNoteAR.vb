Imports System.Data
Imports System.Data.SqlClient

Public Class classCreditNoteAR
	Public Structure CreditNoteARHeader
		Dim h01_id_crnote As Long
		Dim h02_crnote_no As String
		Dim h03_crnote_date As String
		Dim h04_crnote_type_id As Integer
		Dim h05_present_status As String
		Dim h06_approval_status As String
		Dim h07_posting_status As String
		Dim h08_crnote_reqno As String
		Dim h09_crnote_reason1 As Integer
		Dim h10_crnote_reason2 As Integer
		Dim h11_crnote_reason3 As Integer
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
        Dim h41_crduom As String ' Sitthana 20201028
    End Structure

	Public Function GetInvNo() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_all_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function GetStkNo(ByVal strDocNo As String) As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_stk_return_select"
		comm.Parameters.AddWithValue("@invno", strDocNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

    Public Function GetCustCd(ByVal strDocNo As String) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_crnote_ar_get_custcd"
        comm.Parameters.AddWithValue("@invno", strDocNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("custcd")
        Else
            Return String.Empty
        End If

    End Function
    Public Function GetCustName(ByVal strDocNo As String) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_crnote_ar_get_custname"
        comm.Parameters.AddWithValue("@invno", strDocNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("custname")
        Else
            Return String.Empty
        End If

    End Function

    Public Function GetDocNo( 
	 ByVal lngDocID As Long, _
	 ByVal strDocNo As String, _
	 Optional ByVal strDateFr As String = "", _
	 Optional ByVal strDateTo As String = "", _
	 Optional ByVal strInvNo As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_crnote_ar_select"
        comm.Parameters.AddWithValue("@id_crnote", lngDocID)
		comm.Parameters.AddWithValue("@crnote_no", strDocNo)
		comm.Parameters.AddWithValue("@datefr", strDateFr)
		comm.Parameters.AddWithValue("@dateto", strDateTo)
        comm.Parameters.AddWithValue("@invno", strInvNo)
        'comm.Parameters.AddWithValue("@invno", strInvNo)
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
		comm.CommandText = "p_crnote_ar_det_select"
        comm.Parameters.AddWithValue("@id_crnote", lngDocID)
		comm.Parameters.AddWithValue("@crnote_no", strDocNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

    Public Function GetInvDetails(ByVal strDocNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_crnote_ar_det_inv_load"
        comm.Parameters.AddWithValue("@invno", strDocNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetTop1Inv(ByVal strDocNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_crnote_ar_select_top_1_inv"
        comm.Parameters.AddWithValue("@invno", strDocNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetStkDetails(ByVal strDocNo As String, ByVal strStkNo As String) As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_crnote_ar_det_stk_load"
		comm.Parameters.AddWithValue("@invno", strDocNo)
		comm.Parameters.AddWithValue("@stkno", strStkNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function SaveData(ByVal Header As classCreditNoteAR.CreditNoteARHeader, ByVal DV_ADD As DataView, ByVal DV_UPD As DataView, ByVal DV_DEL As DataView, ByRef msgerr As String, ByRef DocID As Long, ByRef DocNo As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_crnote_ar_update"
		With Header
            comm.Parameters.AddWithValue("@id_crnote", Header.h01_id_crnote)
            comm.Parameters.AddWithValue("@crnote_no", Header.h02_crnote_no.Trim)
            comm.Parameters.AddWithValue("@crnote_date", .h03_crnote_date.Trim)
            comm.Parameters.AddWithValue("@id_crnote_type", .h04_crnote_type_id.ToString)
			comm.Parameters.AddWithValue("@present_status", .h05_present_status.Trim)
			comm.Parameters.AddWithValue("@approval_status", .h06_approval_status.Trim)
			comm.Parameters.AddWithValue("@posting_status", .h07_posting_status.Trim)
			comm.Parameters.AddWithValue("@crnote_reqno", .h08_crnote_reqno.Trim)
			comm.Parameters.AddWithValue("@crnote_reason1", .h09_crnote_reason1.ToString)
			comm.Parameters.AddWithValue("@crnote_reason2", .h10_crnote_reason2.ToString)
			comm.Parameters.AddWithValue("@crnote_reason3", .h11_crnote_reason3.ToString)
			comm.Parameters.AddWithValue("@custcd", .h12_custcd.Trim)
			comm.Parameters.AddWithValue("@source_docno", .h13_source_docno.Trim)
			comm.Parameters.AddWithValue("@source_docdate", .h14_source_docdate.Trim)
			comm.Parameters.AddWithValue("@source_refno", .h15_source_refno.Trim)
			comm.Parameters.AddWithValue("@source_doctype", .h16_source_doctype.Trim)
            comm.Parameters.AddWithValue("@invid", Header.h17_invid)
            comm.Parameters.AddWithValue("@invno", Header.h18_invno.Trim)
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
        DocID = Val(dt.Rows(0)("id_crnote").ToString)
		DocNo = dt.Rows(0)("crnote_no").ToString

		'Add Detail----------

		i = 0
        comm.CommandText = "p_crnote_ar_det_update"

        For i = 0 To DV_ADD.Count - 1
            With DV_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_crnote_det", 0)
                comm.Parameters.AddWithValue("@id_crnote", DocID)
                comm.Parameters.AddWithValue("@crnote_no", DocNo)
                comm.Parameters.AddWithValue("@crnote_ord", config.IsNull(.Item(i)("crnote_ord"), 0))
                comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
                comm.Parameters.AddWithValue("@return_goods", config.IsNull(.Item(i)("return_goods"), False))
                comm.Parameters.AddWithValue("@stk_in_no", config.IsNull(.Item(i)("stk_in_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt"), 0).ToString)
                comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty"), 0).ToString)
                comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice"), 0).ToString)
                comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt"), 0).ToString)
                comm.Parameters.AddWithValue("@itdesc", config.IsNull(.Item(i)("itdesc"), "").ToString)
                comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate"), DBNull.Value))
                comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), DBNull.Value))
                comm.Parameters.AddWithValue("@uom", config.IsNull(DV_ADD.Item(i)("uom"), DBNull.Value)) 'Sitthana 20200313

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
		comm.CommandText = "p_crnote_ar_det_update"

		For i = 0 To DV_UPD.Count - 1
            With DV_UPD
                MsgBox(config.IsNull(.Item(i)("itdesc"), "").ToString)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@id_crnote_det", config.IsNull(.Item(i)("id_crnote_det"), 0))
                comm.Parameters.AddWithValue("@id_crnote", config.IsNull(.Item(i)("id_crnote"), 0))
                comm.Parameters.AddWithValue("@crnote_no", config.IsNull(.Item(i)("crnote_no"), ""))
                comm.Parameters.AddWithValue("@crnote_ord", config.IsNull(.Item(i)("crnote_ord"), 0))
                comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
                comm.Parameters.AddWithValue("@return_goods", config.IsNull(.Item(i)("return_goods"), False))
                comm.Parameters.AddWithValue("@stk_in_no", config.IsNull(.Item(i)("stk_in_no"), "").Trim)
                comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt"), 0).ToString)
                comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty"), 0).ToString)
                comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice"), 0).ToString)
                comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt"), 0).ToString)
                comm.Parameters.AddWithValue("@itdesc", config.IsNull(.Item(i)("itdesc"), "").ToString)
                comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate"), DBNull.Value))
                comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), DBNull.Value))
                comm.Parameters.AddWithValue("@uom", config.IsNull(DV_UPD.Item(i)("uom"), DBNull.Value)) 'Sitthana 20200313
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
		comm.CommandText = "p_crnote_ar_det_delete"

		For i = 0 To DV_DEL.Count - 1
			With DV_DEL
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@id_crnote_det", .Item(i)("id_crnote_det"))
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

	Public Function Approve(ByVal lngDocID As Long, ByVal strEmpCD As String) As Boolean
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_crnote_ar_approve"
        comm.Parameters.AddWithValue("@id_crnote", lngDocID)
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

	Public Function Cancel(ByVal lngDocID As Long, ByVal strEmpCD As String) As Boolean
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_crnote_ar_cancel"
        comm.Parameters.AddWithValue("@id_crnote", lngDocID)
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
End Class
