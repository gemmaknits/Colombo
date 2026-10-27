Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classSalesOrder
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

    End Structure

	Public Function SOLoad(Optional ByVal strSoNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_so_select"
		comm.Parameters.AddWithValue("@sono", strSoNo)
		comm.Parameters.AddWithValue("@sodtfr", strDateFr)
		comm.Parameters.AddWithValue("@sodtto", strDateTo)
		comm.Parameters.AddWithValue("@custcd", strCustCD)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function SODetLoad(ByVal strSoNo As String) As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_soitm_select"
		comm.Parameters.AddWithValue("@sono", strSoNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetSOFromPO(ByVal strPoNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_check_duplicate_po"
        comm.Parameters.AddWithValue("@custpo", strPoNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

	Public Function SOSave(ByVal SOH As SOHeader, ByVal SOD_ADD As DataView, ByVal SOD_UPD As DataView, ByVal SOD_DEL As DataView, ByRef msgerr As String, ByRef sono As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_so_update"
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
			comm.Parameters.AddWithValue("@shipcustcd", .h11_shipcustcd.Trim)
			comm.Parameters.AddWithValue("@payterms", .h12_payterms.Trim)
			comm.Parameters.AddWithValue("@credit", .h13_credit)
			comm.Parameters.AddWithValue("@crdays", .h14_crdays)
			comm.Parameters.AddWithValue("@custpo", .h15_custpo.Trim)
			comm.Parameters.AddWithValue("@deli", .h16_deli.Trim)
			comm.Parameters.AddWithValue("@delicd", .h17_delicd.Trim)
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
		sono = dt.Rows(0)("sono").ToString

		'Add Detail----------

		i = 0
		comm.CommandText = "p_soitm_update"

		For i = 0 To sod_ADD.Count - 1
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
                comm.Parameters.AddWithValue("@cust_shipdt", CDate(config.IsNull(.Item(i)("cust_shipdt"), "01/01/1900")).ToString("yyyyMMdd"))

                comm.Parameters.AddWithValue("@sys_width_id", config.IsNull(.Item(i)("sys_width_id"), 0).ToString().Trim())
                comm.Parameters.AddWithValue("@ref_stnoid", config.IsNull(.Item(i)("ref_stnoid"), "").ToString.Trim)
                comm.Parameters.AddWithValue("@confirmed_shipdt", IIf(.Item(i)("confirmed_shipdt").Equals(""), "", (CDate(config.IsNull(.Item(i)("confirmed_shipdt"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@knit_begin_date", IIf(.Item(i)("knit_begin_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("knit_begin_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@knit_end_date", IIf(.Item(i)("knit_end_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("knit_end_date"), "01/01/1900")).ToString("yyyyMMdd"))))
                comm.Parameters.AddWithValue("@dye_end_date", IIf(.Item(i)("dye_end_date").Equals(""), "", (CDate(config.IsNull(.Item(i)("dye_end_date"), "01/01/1900")).ToString("yyyyMMdd"))))
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

		For i = 0 To sod_DEL.Count - 1
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
		Dim conn As New SqlConnection((New classConnection).connection)
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

    Public Function SOClose(ByVal dt As DataTable, ByRef msgerr As String, ByVal strEmpCD As String) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
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

    Public Function ValidateSOFlowStatus(ByVal StrSoNo As String) As Boolean

        Dim conn As New SqlConnection((New classConnection).connection())
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
End Class
