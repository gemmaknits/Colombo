Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classInvoice
	Public Structure InvLocHeader
		Public h01_invid As Long
		Public h02_invno As String
		Public h03_invdt As String
		Public h04_cond As String
		Public h05_custcd As String
		Public h06_shipcd As String
		Public h07_credit As Integer
		Public h08_grossamt As Double
		Public h09_discamt As Double
		Public h10_pretaxamt As Double
		Public h11_vat As Double
		Public h12_vatamt As Double
		Public h13_netamt As Double
		Public h14_remark As String
		Public h15_log_empcd As String
	End Structure

	Public Structure InvExpHeader
		Dim h01_invid As Long
		Dim h02_invno As String
		Dim h03_invdt As String
		Dim h04_cond As String
		Dim h05_custcd As String
		Dim h06_agcd As String
		Dim h07_grossamt As Double
		Dim h08_discamt As Double
		Dim h09_pretaxamt As Double
		Dim h10_vat As Double
		Dim h11_vatamt As Double
		Dim h12_chargetxt As String
		Dim h13_chargeamt As Double
		Dim h14_netamt As Double
		Dim h15_remark As String
		Dim h16_enwrap_material As String
		Dim h17_enwrap_cost As Double
		Dim h18_gross_weight As Double
		Dim h19_net_weight As Double
		Dim h20_capacity As Double
		Dim h21_freight_type As String
		Dim h22_fob_loc As String
		Dim h23_receiver_code As String
		Dim h24_forwarder As String
		Dim h25_parcel_code As String
		Dim h26_register_dt As String
		Dim h27_depart_dt As String
		Dim h28_depart_time As String
		Dim h29_arrive_dt As String
		Dim h30_arrive_time As String
		Dim h31_depart_loc As String
		Dim h32_arrive_loc As String
		Dim h33_freight_amt As Double
		Dim h34_insurance_amt As Double
		Dim h35_lcno As String
		Dim h36_lcdt As String
		Dim h37_lcamt As Double
		Dim h38_bankcode As String
		Dim h39_bankname As String
		Dim h40_bankbranch As String
		Dim h41_bankacct As String
		Dim h42_shipvia As String
		Dim h43_log_empcd As String

		Dim f01_fr_inv_no As String
		Dim f02_fr_inv_date As String
		Dim f03_fr_due_date As String
		Dim f04_fr_ref_no As String
		Dim f05_fr_contact As String
		Dim f06_fr_tel As String
		Dim f07_fr_vat As Double
		Dim f08_fr_shipname As String
		Dim f09_fr_remark As String
	End Structure

	Public Function GetPackNo(Optional ByVal stock_type As String = "G", Optional ByVal strPackNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "", Optional ByVal strSoNo As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_packing_select"
		comm.Parameters.AddWithValue("@stock_type", stock_type)
		comm.Parameters.AddWithValue("@packno", strPackNo)
		comm.Parameters.AddWithValue("@datefr", strDateFr)
		comm.Parameters.AddWithValue("@dateto", strDateTo)
		comm.Parameters.AddWithValue("@custcd", strCustCD)
		comm.Parameters.AddWithValue("@sono", strSoNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvLocPacking(ByVal strPackNoCartNo As String, ByVal lngInvID As Long, ByVal lngInvOrd As Long)
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_local_packing"
		comm.Parameters.AddWithValue("@packno_cartno", strPackNoCartNo)
		comm.Parameters.AddWithValue("@invid", lngInvID)
		comm.Parameters.AddWithValue("@invord", lngInvOrd)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvLocLoad(Optional ByVal lngInvID As Long = 0, Optional ByVal strInvNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_local_select"
		comm.Parameters.AddWithValue("@invid", lngInvID)
		comm.Parameters.AddWithValue("@invno", strInvNo)
		comm.Parameters.AddWithValue("@invdtfr", strDateFr)
		comm.Parameters.AddWithValue("@invdtto", strDateTo)
		comm.Parameters.AddWithValue("@custcd", strCustCD)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvLocDetLoad(ByVal lngInvID As Long, Optional ByVal strInvNo As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_local_det_select"
		comm.Parameters.AddWithValue("@invid", lngInvID)
		comm.Parameters.AddWithValue("@invno", strInvNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvLocSave(ByVal InvH As classInvoice.InvLocHeader, ByVal InvD_ADD As DataView, ByVal InvD_UPD As DataView, ByVal InvD_DEL As DataView, ByRef msgerr As String, ByRef invid As Long, ByRef invno As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_local_update"
		With InvH
			comm.Parameters.AddWithValue("@invid", .h01_invid)
			comm.Parameters.AddWithValue("@invno", .h02_invno)
			comm.Parameters.AddWithValue("@invdt", .h03_invdt)
			comm.Parameters.AddWithValue("@cond", .h04_cond)
			comm.Parameters.AddWithValue("@custcd", .h05_custcd)
			comm.Parameters.AddWithValue("@shipcd", .h06_shipcd)
			comm.Parameters.AddWithValue("@credit", .h07_credit.ToString)
			comm.Parameters.AddWithValue("@grossamt", .h08_grossamt.ToString)
			comm.Parameters.AddWithValue("@discamt", .h09_discamt.ToString)
			comm.Parameters.AddWithValue("@pretaxamt", .h10_pretaxamt.ToString)
			comm.Parameters.AddWithValue("@vat", .h11_vat.ToString)
			comm.Parameters.AddWithValue("@vatamt", .h12_vatamt.ToString)
			comm.Parameters.AddWithValue("@netamt", .h13_netamt.ToString)
			comm.Parameters.AddWithValue("@remark", .h14_remark)
			comm.Parameters.AddWithValue("@log_empcd", .h15_log_empcd)
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
		invid = Val(dt.Rows(0)("invid").ToString)
		invno = dt.Rows(0)("invno").ToString

		'Add Detail----------

		i = 0
		comm.CommandText = "p_inv_local_det_update"

		For i = 0 To InvD_ADD.Count - 1
			With InvD_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@invord", config.IsNull(.Item(i)("invord").ToString, 0))
				comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), ""))
				comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), ""))
				comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), ""))
				comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), ""))
				comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), ""))
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), ""))
				comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), ""))
				comm.Parameters.AddWithValue("@lotno", config.IsNull(.Item(i)("lotno"), ""))
				comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), ""))
				comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), ""))
				comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), ""))
				comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty").ToString, 0))
				comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), ""))
				comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice").ToString, 0))
				comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt").ToString, 0))
				comm.Parameters.AddWithValue("@discper", config.IsNull(.Item(i)("discper").ToString, 0))
				comm.Parameters.AddWithValue("@linediscamt", config.IsNull(.Item(i)("linediscamt").ToString, 0))
				comm.Parameters.AddWithValue("@linenetamt", config.IsNull(.Item(i)("linenetamt").ToString, 0))
				comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), ""))
				comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate").ToString, 1))
				comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), ""))
				comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno").ToString, 0))
				comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt").ToString, 0))
				comm.Parameters.AddWithValue("@cust_design", config.IsNull(.Item(i)("cust_design"), ""))
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
		comm.CommandText = "p_inv_local_det_update"

		For i = 0 To InvD_UPD.Count - 1
			With InvD_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@invord", config.IsNull(.Item(i)("invord").ToString, 0))
				comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@lotno", config.IsNull(.Item(i)("lotno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty").ToString, 0))
				comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice").ToString, 0))
				comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt").ToString, 0))
				comm.Parameters.AddWithValue("@discper", config.IsNull(.Item(i)("discper").ToString, 0))
				comm.Parameters.AddWithValue("@linediscamt", config.IsNull(.Item(i)("linediscamt").ToString, 0))
				comm.Parameters.AddWithValue("@linenetamt", config.IsNull(.Item(i)("linenetamt").ToString, 0))
				comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate").ToString, 1))
				comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno").ToString, 0))
				comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt").ToString, 0))
				comm.Parameters.AddWithValue("@cust_design", config.IsNull(.Item(i)("cust_design"), "").ToString.Trim)
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
		comm.CommandText = "p_inv_local_det_delete"

		For i = 0 To InvD_DEL.Count - 1
			With InvD_DEL(i)
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@invdetid", ("invdetid"))
				comm.Parameters.AddWithValue("@log_empcd", InvH.h15_log_empcd)
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

	Public Function InvLocCancel(ByVal lngInvID As Long, ByVal strEmpCD As String) As Boolean
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_local_cancel"
		comm.Parameters.AddWithValue("@invid", lngInvID)
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

	Public Function InvExpPacking(ByVal strPackNoCartNo As String, ByVal lngInvID As Long, ByVal lngInvOrd As Long)
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_packing"
		comm.Parameters.AddWithValue("@packno_cartno", strPackNoCartNo)
		comm.Parameters.AddWithValue("@invid", lngInvID)
		comm.Parameters.AddWithValue("@invord", lngInvOrd)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvExpLabel(ByVal lngInvID As Long)
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_label_select"
		comm.Parameters.AddWithValue("@invid", lngInvID)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvExpProduct(ByVal lngInvID As Long)
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_product_select"
		comm.Parameters.AddWithValue("@invid", lngInvID)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvExpFreight(ByVal lngInvID As Long)
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_freight_select"
		comm.Parameters.AddWithValue("@invid", lngInvID)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvExpLoad(Optional ByVal lngInvID As Long = 0, Optional ByVal strInvNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strCustCD As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_select"
		comm.Parameters.AddWithValue("@invid", lngInvID)
		comm.Parameters.AddWithValue("@invno", strInvNo)
		comm.Parameters.AddWithValue("@invdtfr", strDateFr)
		comm.Parameters.AddWithValue("@invdtto", strDateTo)
		comm.Parameters.AddWithValue("@custcd", strCustCD)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvExpDetLoad(ByVal lngInvID As Long, Optional ByVal strInvNo As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_det_select"
		comm.Parameters.AddWithValue("@invid", lngInvID)
		comm.Parameters.AddWithValue("@invno", strInvNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function InvExpSave(ByVal InvH As classInvoice.InvExpHeader, _
	 ByVal InvD_ADD As DataView, ByVal InvD_UPD As DataView, ByVal InvD_DEL As DataView, _
	 ByVal InvL_ADD As DataView, ByVal InvL_UPD As DataView, ByVal InvL_DEL As DataView, _
	 ByVal InvP_ADD As DataView, ByVal InvP_UPD As DataView, ByVal InvP_DEL As DataView, _
	 ByVal InvF_ADD As DataView, ByVal InvF_UPD As DataView, ByVal InvF_DEL As DataView, _
	 ByRef msgerr As String, ByRef invid As Long, ByRef invno As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_update"
		With InvH
			comm.Parameters.AddWithValue("@invid", .h01_invid)
			comm.Parameters.AddWithValue("@invno", .h02_invno.Trim)
			comm.Parameters.AddWithValue("@invdt", .h03_invdt.Trim)
			comm.Parameters.AddWithValue("@cond", .h04_cond.Trim)
			comm.Parameters.AddWithValue("@custcd", .h05_custcd.Trim)
			comm.Parameters.AddWithValue("@agcd", .h06_agcd.Trim)
			comm.Parameters.AddWithValue("@grossamt", .h07_grossamt.ToString)
			comm.Parameters.AddWithValue("@discamt", .h08_discamt.ToString)
			comm.Parameters.AddWithValue("@pretaxamt", .h09_pretaxamt.ToString)
			comm.Parameters.AddWithValue("@vat", .h10_vat.ToString)
			comm.Parameters.AddWithValue("@vatamt", .h11_vatamt.ToString)
			comm.Parameters.AddWithValue("@chargetxt", .h12_chargetxt.Trim)
			comm.Parameters.AddWithValue("@chargeamt", .h13_chargeamt.ToString)
			comm.Parameters.AddWithValue("@netamt", .h14_netamt.ToString)
			comm.Parameters.AddWithValue("@remark", .h15_remark.Trim)
			comm.Parameters.AddWithValue("@enwrap_material", .h16_enwrap_material.Trim)
			comm.Parameters.AddWithValue("@enwrap_cost", .h17_enwrap_cost.ToString)
			comm.Parameters.AddWithValue("@gross_weight", .h18_gross_weight.ToString)
			comm.Parameters.AddWithValue("@net_weight", .h19_net_weight.ToString)
			comm.Parameters.AddWithValue("@capacity", .h20_capacity.ToString)
			comm.Parameters.AddWithValue("@freight_type", .h21_freight_type.Trim)
			comm.Parameters.AddWithValue("@fob_loc", .h22_fob_loc.Trim)
			comm.Parameters.AddWithValue("@receiver_code", .h23_receiver_code.Trim)
			comm.Parameters.AddWithValue("@forwarder", .h24_forwarder.Trim)
			comm.Parameters.AddWithValue("@parcel_code", .h25_parcel_code.Trim)
			comm.Parameters.AddWithValue("@register_dt", .h26_register_dt.Trim)
			comm.Parameters.AddWithValue("@depart_dt", .h27_depart_dt.Trim)
			comm.Parameters.AddWithValue("@depart_time", .h28_depart_time.Trim)
			comm.Parameters.AddWithValue("@arrive_dt", .h29_arrive_dt.Trim)
			comm.Parameters.AddWithValue("@arrive_time", .h30_arrive_time.Trim)
			comm.Parameters.AddWithValue("@depart_loc", .h31_depart_loc.Trim)
			comm.Parameters.AddWithValue("@arrive_loc", .h32_arrive_loc.Trim)
			comm.Parameters.AddWithValue("@freight_amt", .h33_freight_amt.ToString)
			comm.Parameters.AddWithValue("@insurance_amt", .h34_insurance_amt.ToString)
			comm.Parameters.AddWithValue("@lcno", .h35_lcno.Trim)
			comm.Parameters.AddWithValue("@lcdt", .h36_lcdt.Trim)
			comm.Parameters.AddWithValue("@lcamt", .h37_lcamt.ToString)
			comm.Parameters.AddWithValue("@bankcode", .h38_bankcode.Trim)
			comm.Parameters.AddWithValue("@bankname", .h39_bankname.Trim)
			comm.Parameters.AddWithValue("@bankbranch", .h40_bankbranch.Trim)
			comm.Parameters.AddWithValue("@bankacct", .h41_bankacct.Trim)
			comm.Parameters.AddWithValue("@shipvia", .h42_shipvia.Trim)
			comm.Parameters.AddWithValue("@log_empcd", .h43_log_empcd.Trim)

			comm.Parameters.AddWithValue("@fr_inv_no", .f01_fr_inv_no.Trim)
			comm.Parameters.AddWithValue("@fr_inv_date", .f02_fr_inv_date.Trim)
			comm.Parameters.AddWithValue("@fr_due_date", .f03_fr_due_date.Trim)
			comm.Parameters.AddWithValue("@fr_ref_no", .f04_fr_ref_no.Trim)
			comm.Parameters.AddWithValue("@fr_contact", .f05_fr_contact.Trim)
			comm.Parameters.AddWithValue("@fr_tel", .f06_fr_tel.Trim)
			comm.Parameters.AddWithValue("@fr_vat", .f07_fr_vat.ToString.Trim)
			comm.Parameters.AddWithValue("@fr_shipname", .f08_fr_shipname.Trim)
			comm.Parameters.AddWithValue("@fr_remark", .f09_fr_remark.Trim)
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
		invid = Val(dt.Rows(0)("invid").ToString)
		invno = dt.Rows(0)("invno").ToString

		'Add Label----------

		i = 0
		comm.CommandText = "p_inv_export_label_update"
		For i = 0 To InvL_ADD.Count - 1
			With InvL_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@lblid", 0)
				comm.Parameters.AddWithValue("@lblord", config.IsNull(.Item(i)("lblord").ToString, 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@line01", config.IsNull(.Item(i)("line01"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line02", config.IsNull(.Item(i)("line02"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line03", config.IsNull(.Item(i)("line03"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line04", config.IsNull(.Item(i)("line04"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line05", config.IsNull(.Item(i)("line05"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line06", config.IsNull(.Item(i)("line06"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line07", config.IsNull(.Item(i)("line07"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line08", config.IsNull(.Item(i)("line08"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line09", config.IsNull(.Item(i)("line09"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line10", config.IsNull(.Item(i)("line10"), "").ToString.Trim)
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

		'Update Label----------

		i = 0
		comm.CommandText = "p_inv_export_label_update"
		For i = 0 To InvL_UPD.Count - 1
			With InvL_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@lblid", config.IsNull(.Item(i)("lblid"), 0))
				comm.Parameters.AddWithValue("@lblord", config.IsNull(.Item(i)("lblord").ToString, 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@line01", config.IsNull(.Item(i)("line01"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line02", config.IsNull(.Item(i)("line02"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line03", config.IsNull(.Item(i)("line03"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line04", config.IsNull(.Item(i)("line04"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line05", config.IsNull(.Item(i)("line05"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line06", config.IsNull(.Item(i)("line06"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line07", config.IsNull(.Item(i)("line07"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line08", config.IsNull(.Item(i)("line08"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line09", config.IsNull(.Item(i)("line09"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@line10", config.IsNull(.Item(i)("line10"), "").ToString.Trim)
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

		'Delete Label----------

		i = 0
		comm.CommandText = "p_inv_export_label_delete"
		For i = 0 To InvL_DEL.Count - 1
			With InvL_DEL
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@lblid", config.IsNull(.Item(i)("lblid"), 0))
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

		'Add Product----------

		i = 0
		comm.CommandText = "p_inv_export_product_update"
		For i = 0 To InvP_ADD.Count - 1
			With InvP_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@prodid", 0)
				comm.Parameters.AddWithValue("@prodord", config.IsNull(.Item(i)("prodord").ToString, 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@prodname", config.IsNull(.Item(i)("prodname"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@composition", config.IsNull(.Item(i)("composition"), "").ToString.Trim)
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

		'Update Product----------

		i = 0
		comm.CommandText = "p_inv_export_product_update"
		For i = 0 To InvP_UPD.Count - 1
			With InvP_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@prodid", config.IsNull(.Item(i)("prodid"), 0))
				comm.Parameters.AddWithValue("@prodord", config.IsNull(.Item(i)("prodord").ToString, 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@prodname", config.IsNull(.Item(i)("prodname"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@composition", config.IsNull(.Item(i)("composition"), "").ToString.Trim)
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

		'Delete Product----------

		i = 0
		comm.CommandText = "p_inv_export_product_delete"
		For i = 0 To InvP_DEL.Count - 1
			With InvP_DEL
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@prodid", config.IsNull(.Item(i)("prodid"), 0))
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
		comm.CommandText = "p_inv_export_det_update"

		For i = 0 To InvD_ADD.Count - 1
			With InvD_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@invord", config.IsNull(.Item(i)("invord").ToString, 0))
				comm.Parameters.AddWithValue("@lblid", config.IsNull(.Item(i)("lblid"), 0))
				comm.Parameters.AddWithValue("@lblord", config.IsNull(.Item(i)("lblord").ToString, 0))
				comm.Parameters.AddWithValue("@prodid", config.IsNull(.Item(i)("prodid"), 0))
				comm.Parameters.AddWithValue("@prodord", config.IsNull(.Item(i)("prodord").ToString, 0))
				comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno").ToString, 0))
				comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@lotno", config.IsNull(.Item(i)("lotno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty").ToString, 0))
				comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice").ToString, 0))
				comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt").ToString, 0))
				comm.Parameters.AddWithValue("@discper", config.IsNull(.Item(i)("discper").ToString, 0))
				comm.Parameters.AddWithValue("@linediscamt", config.IsNull(.Item(i)("linediscamt").ToString, 0))
				comm.Parameters.AddWithValue("@linenetamt", config.IsNull(.Item(i)("linenetamt").ToString, 0))
				comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate").ToString, 0))
				comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt").ToString, 0))
				comm.Parameters.AddWithValue("@cust_design", config.IsNull(.Item(i)("cust_design"), "").ToString.Trim)
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
		comm.CommandText = "p_inv_export_det_update"

		For i = 0 To InvD_UPD.Count - 1
			With InvD_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@invdetid", config.IsNull(.Item(i)("invdetid"), 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@invord", config.IsNull(.Item(i)("invord").ToString, 0))
				comm.Parameters.AddWithValue("@lblid", config.IsNull(.Item(i)("lblid"), 0))
				comm.Parameters.AddWithValue("@lblord", config.IsNull(.Item(i)("lblord").ToString, 0))
				comm.Parameters.AddWithValue("@prodid", config.IsNull(.Item(i)("prodid"), 0))
				comm.Parameters.AddWithValue("@prodord", config.IsNull(.Item(i)("prodord").ToString, 0))
				comm.Parameters.AddWithValue("@outno", config.IsNull(.Item(i)("outno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@packno", config.IsNull(.Item(i)("packno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@cartno", config.IsNull(.Item(i)("cartno").ToString, 0))
				comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@design_no", config.IsNull(.Item(i)("design_no"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@gwth", config.IsNull(.Item(i)("gwth"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@subcod", config.IsNull(.Item(i)("subcod"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@grade", config.IsNull(.Item(i)("grade"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@lotno", config.IsNull(.Item(i)("lotno"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@pono", config.IsNull(.Item(i)("pono"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@qty", config.IsNull(.Item(i)("qty").ToString, 0))
				comm.Parameters.AddWithValue("@uom", config.IsNull(.Item(i)("uom"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@uprice", config.IsNull(.Item(i)("uprice").ToString, 0))
				comm.Parameters.AddWithValue("@lineamt", config.IsNull(.Item(i)("lineamt").ToString, 0))
				comm.Parameters.AddWithValue("@discper", config.IsNull(.Item(i)("discper").ToString, 0))
				comm.Parameters.AddWithValue("@linediscamt", config.IsNull(.Item(i)("linediscamt").ToString, 0))
				comm.Parameters.AddWithValue("@linenetamt", config.IsNull(.Item(i)("linenetamt").ToString, 0))
				comm.Parameters.AddWithValue("@currency", config.IsNull(.Item(i)("currency"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@exchange_rate", config.IsNull(.Item(i)("exchange_rate").ToString, 0))
				comm.Parameters.AddWithValue("@roll_cnt", config.IsNull(.Item(i)("roll_cnt").ToString, 0))
				comm.Parameters.AddWithValue("@cust_design", config.IsNull(.Item(i)("cust_design"), "").ToString.Trim)
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
		comm.CommandText = "p_inv_export_det_delete"

		For i = 0 To InvD_DEL.Count - 1
			With InvD_DEL
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@invdetid", .Item(i)("invdetid"))
				comm.Parameters.AddWithValue("@log_empcd", InvH.h43_log_empcd)
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

		'Add Freight----------

		i = 0
		comm.CommandText = "p_inv_export_freight_update"
		For i = 0 To InvF_ADD.Count - 1
			With InvF_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@fr_id", 0)
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@fr_ord", config.IsNull(.Item(i)("fr_ord"), 0).ToString)
				comm.Parameters.AddWithValue("@fr_item_code", config.IsNull(.Item(i)("fr_item_code"), "").Trim)
				comm.Parameters.AddWithValue("@fr_item_desc", config.IsNull(.Item(i)("fr_item_desc"), "").Trim)
				comm.Parameters.AddWithValue("@fr_amt_vat", config.IsNull(.Item(i)("fr_amt_vat"), 0).ToString)
				comm.Parameters.AddWithValue("@fr_amt_non_vat", config.IsNull(.Item(i)("fr_amt_non_vat"), 0).ToString)
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

		'Update Freight----------

		i = 0
		comm.CommandText = "p_inv_export_freight_update"
		For i = 0 To InvF_UPD.Count - 1
			With InvF_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@fr_id", config.IsNull(.Item(i)("fr_id"), 0))
				comm.Parameters.AddWithValue("@invid", invid)
				comm.Parameters.AddWithValue("@invno", invno)
				comm.Parameters.AddWithValue("@fr_ord", config.IsNull(.Item(i)("fr_ord"), 0).ToString)
				comm.Parameters.AddWithValue("@fr_item_code", config.IsNull(.Item(i)("fr_item_code"), "").Trim)
				comm.Parameters.AddWithValue("@fr_item_desc", config.IsNull(.Item(i)("fr_item_desc"), "").Trim)
				comm.Parameters.AddWithValue("@fr_amt_vat", config.IsNull(.Item(i)("fr_amt_vat"), 0).ToString)
				comm.Parameters.AddWithValue("@fr_amt_non_vat", config.IsNull(.Item(i)("fr_amt_non_vat"), 0).ToString)
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

		'Delete Freight----------

		i = 0
		comm.CommandText = "p_inv_export_freight_delete"
		For i = 0 To InvF_DEL.Count - 1
			With InvF_DEL
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@fr_id", config.IsNull(.Item(i)("fr_id"), 0))
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

	Public Function InvExpCancel(ByVal lngInvID As Long, ByVal strEmpCD As String) As Boolean
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_inv_export_cancel"
		comm.Parameters.AddWithValue("@invid", lngInvID)
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
End Class
