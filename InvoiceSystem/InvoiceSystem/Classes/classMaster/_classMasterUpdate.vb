Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classMasterUpdate
	Public Structure Customer
		Dim h01_custcd As String
		Dim h02_name As String
		Dim h03_namet As String
		Dim h04_addr1 As String
		Dim h05_addr2 As String
		Dim h06_addr3 As String
		Dim h07_addr1t As String
		Dim h08_addr2t As String
		Dim h09_addr3t As String
		Dim h10_city As String
		Dim h11_ctry As String
		Dim h12_tel As String
		Dim h13_fax As String
		Dim h14_email As String
		Dim h15_contact As String
		Dim h16_credit As Integer
		Dim h17_payterms As String
		Dim h18_agcd As String
		Dim h19_Custgroup As String
		Dim h20_active As Integer
		Dim h21_crdays As Integer
		Dim h22_log_empcd As String
	End Structure

	Public Structure Agency
		Dim h01_Agcd As String
		Dim h02_Nickname As String
		Dim h03_Name As String
		Dim h04_Addr1 As String
		Dim h05_Addr2 As String
		Dim h06_Addr3 As String
		Dim h07_Namet As String
		Dim h08_Addr1T As String
		Dim h09_Addr2T As String
		Dim h10_Addr3T As String
		Dim h11_ctry As String
		Dim h12_tel As String
		Dim h13_fax As String
		Dim h14_email As String
		Dim h15_bank As String
		Dim h16_currency As String
		Dim h17_comm As Double
		Dim h18_tax As Double
		Dim h19_commper As Double
		Dim h20_contact As String
	End Structure

	Public Structure Supplier
		Dim h01_suppcd As String
		Dim h02_name As String
		Dim h03_namet As String
		Dim h04_addr1 As String
		Dim h05_addr2 As String
		Dim h06_addr3 As String
		Dim h07_addr1t As String
		Dim h08_addr2t As String
		Dim h09_addr3t As String
		Dim h10_city As String
		Dim h11_ctry As String
		Dim h12_tel As String
		Dim h13_fax As String
		Dim h14_email As String
		Dim h15_contact As String
		Dim h16_dyer As Integer
		Dim h17_scalloper As Integer
		Dim h18_greige As Integer
		Dim h19_altcode As String
		Dim h20_abbrev As String
		Dim h21_abbrev2 As String
		Dim h22_crdays As Integer
		Dim h23_crterms As String
		Dim h24_paymodecd As String
		Dim h25_internal As Boolean
		Dim h26_log_empcd As String
	End Structure

	Public Structure DM
		Dim h01_StartDt As String
		Dim h02_Design_no As String
		Dim h03_Elastic As Boolean
		Dim h04_Type As String
		Dim h05_AB As String
		Dim h06_Bar As String
		Dim h07_Fine As String
		Dim h08_Bwth As Double
		Dim h09_Needle As String
		Dim h10_rptwth_d As Double
		Dim h11_rptlen_d As Double
		Dim h12_rptwth_s As Double
		Dim h13_rptlen_s As Double
		Dim h14_mtkg As Double
		Dim h15_compo As String
		Dim h16_rem As String
		Dim h17_supdes_no As String
		Dim h18_width As Double
		Dim h19_cust_design_no As String
		Dim h20_desdesc As String
		Dim h21_refdesno As String
		Dim h22_tstamp As Date
		Dim h23_ittypecd As String
		Dim h24_itgroupcd As String
		Dim h25_log_empcd As String
	End Structure

	Public Function CustomerSave(ByVal Cust As Customer, ByRef msgerr As String, ByRef CustCD As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		Dim strLotNo As String = ""
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_customers_update"
		With Cust
			comm.Parameters.AddWithValue("@custcd", .h01_custcd.Trim)
			comm.Parameters.AddWithValue("@name", .h02_name.Trim)
			comm.Parameters.AddWithValue("@namet", .h03_namet.Trim)
			comm.Parameters.AddWithValue("@addr1", .h04_addr1.Trim)
			comm.Parameters.AddWithValue("@addr2", .h05_addr2.Trim)
			comm.Parameters.AddWithValue("@addr3", .h06_addr3.Trim)
			comm.Parameters.AddWithValue("@addr1t", .h07_addr1t.Trim)
			comm.Parameters.AddWithValue("@addr2t", .h08_addr2t.Trim)
			comm.Parameters.AddWithValue("@addr3t", .h09_addr3t.Trim)
			comm.Parameters.AddWithValue("@city", .h10_city.Trim)
			comm.Parameters.AddWithValue("@ctry", .h11_ctry.Trim)
			comm.Parameters.AddWithValue("@tel", .h12_tel.Trim)
			comm.Parameters.AddWithValue("@fax", .h13_fax.Trim)
			comm.Parameters.AddWithValue("@email", .h14_email.Trim)
			comm.Parameters.AddWithValue("@contact", .h15_contact.Trim)
			comm.Parameters.AddWithValue("@credit", .h16_credit)
			comm.Parameters.AddWithValue("@payterms", .h17_payterms.Trim)
			comm.Parameters.AddWithValue("@agcd", .h18_agcd.Trim)
			comm.Parameters.AddWithValue("@Custgroup", .h19_Custgroup.Trim)
			comm.Parameters.AddWithValue("@active", IIf(.h20_active, 1, 0))
			comm.Parameters.AddWithValue("@crdays", .h21_crdays)
			comm.Parameters.AddWithValue("@log_empcd", .h22_log_empcd)
		End With

		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		End Try
		CustCD = dt.Rows(0)("custcd").ToString.Trim

		tran.Commit()
		Return True
	End Function

	Public Function AgencySave(ByVal Agent As Agency, ByRef msgerr As String, ByRef AgCD As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		Dim strLotNo As String = ""
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_agents_update"
		With Agent
			comm.Parameters.AddWithValue("@Agcd", .h01_Agcd.Trim)
			comm.Parameters.AddWithValue("@Nickname", .h02_Nickname.Trim)
			comm.Parameters.AddWithValue("@Name", .h03_Name.Trim)
			comm.Parameters.AddWithValue("@Addr1", .h04_Addr1.Trim)
			comm.Parameters.AddWithValue("@Addr2", .h05_Addr2.Trim)
			comm.Parameters.AddWithValue("@Addr3", .h06_Addr3.Trim)
			comm.Parameters.AddWithValue("@Namet", .h07_Namet.Trim)
			comm.Parameters.AddWithValue("@Addr1T", .h08_Addr1T.Trim)
			comm.Parameters.AddWithValue("@Addr2T", .h09_Addr2T.Trim)
			comm.Parameters.AddWithValue("@Addr3T", .h10_Addr3T.Trim)
			comm.Parameters.AddWithValue("@ctry", .h11_ctry.Trim)
			comm.Parameters.AddWithValue("@tel", .h12_tel.Trim)
			comm.Parameters.AddWithValue("@fax", .h13_fax.Trim)
			comm.Parameters.AddWithValue("@email", .h14_email.Trim)
			comm.Parameters.AddWithValue("@bank", .h15_bank.Trim)
			comm.Parameters.AddWithValue("@currency", .h16_currency.Trim)
			comm.Parameters.AddWithValue("@comm", .h17_comm)
			comm.Parameters.AddWithValue("@tax", .h18_tax)
			comm.Parameters.AddWithValue("@commper", .h19_commper)
			comm.Parameters.AddWithValue("@contact", .h20_contact.Trim)
		End With

		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		End Try
		AgCD = dt.Rows(0)("agcd").ToString.Trim

		tran.Commit()
		Return True
	End Function

	Public Function SupplierSave(ByVal Supplier As Supplier, ByRef msgerr As String, ByRef SuppCD As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		Dim strLotNo As String = ""
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_suppliers_update"
		With Supplier
			comm.Parameters.AddWithValue("@suppcd", .h01_suppcd.Trim)
			comm.Parameters.AddWithValue("@name", .h02_name.Trim)
			comm.Parameters.AddWithValue("@namet", .h03_namet.Trim)
			comm.Parameters.AddWithValue("@addr1", .h04_addr1.Trim)
			comm.Parameters.AddWithValue("@addr2", .h05_addr2.Trim)
			comm.Parameters.AddWithValue("@addr3", .h06_addr3.Trim)
			comm.Parameters.AddWithValue("@addr1t", .h07_addr1t.Trim)
			comm.Parameters.AddWithValue("@addr2t", .h08_addr2t.Trim)
			comm.Parameters.AddWithValue("@addr3t", .h09_addr3t.Trim)
			comm.Parameters.AddWithValue("@city", .h10_city.Trim)
			comm.Parameters.AddWithValue("@ctry", .h11_ctry.Trim)
			comm.Parameters.AddWithValue("@tel", .h12_tel.Trim)
			comm.Parameters.AddWithValue("@fax", .h13_fax.Trim)
			comm.Parameters.AddWithValue("@email", .h14_email.Trim)
			comm.Parameters.AddWithValue("@contact", .h15_contact.Trim)
			comm.Parameters.AddWithValue("@dyer", .h16_dyer.ToString)
			comm.Parameters.AddWithValue("@scalloper", .h17_scalloper.ToString)
			comm.Parameters.AddWithValue("@greige", .h18_greige.ToString)
			comm.Parameters.AddWithValue("@altcode", .h19_altcode.Trim)
			comm.Parameters.AddWithValue("@abbrev", .h20_abbrev.Trim)
			comm.Parameters.AddWithValue("@abbrev2", .h21_abbrev2.Trim)
			comm.Parameters.AddWithValue("@crdays", .h22_crdays.ToString)
			comm.Parameters.AddWithValue("@crterms", .h23_crterms.Trim)
			comm.Parameters.AddWithValue("@paymodecd", .h24_paymodecd.Trim)
			comm.Parameters.AddWithValue("@internal", IIf(.h25_internal, 1, 0))
			comm.Parameters.AddWithValue("@log_empcd", .h26_log_empcd.Trim)
		End With

		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		End Try
		SuppCD = dt.Rows(0)("suppcd").ToString.Trim

		tran.Commit()
		Return True
	End Function

	Public Function ColorSave(ByVal dv_add As DataView, ByVal dv_upd As DataView, ByRef msgerr As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable

		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_colors_update"

		For i = 0 To dv_add.Count - 1
			If dv_add(i)("col").ToString.Trim.Length > 0 Then
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@col", dv_add(i)("col").ToString.Trim)
				comm.Parameters.AddWithValue("@colname", dv_add(i)("colname").ToString.Trim)
				comm.Parameters.AddWithValue("@base_col", dv_add(i)("base_col").ToString.Trim)
				Try
					da.Fill(dt)
				Catch ex As Exception
					msgerr = ex.Message
					tran.Rollback()
					Return False
				End Try
			End If
		Next

		For i = 0 To dv_upd.Count - 1
			If dv_upd(i)("col").ToString.Trim.Length > 0 Then
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@col", dv_upd(i)("col").ToString.Trim)
				comm.Parameters.AddWithValue("@colname", dv_upd(i)("colname").ToString.Trim)
				comm.Parameters.AddWithValue("@base_col", dv_upd(i)("base_col").ToString.Trim)
				Try
					da.Fill(dt)
				Catch ex As Exception
					msgerr = ex.Message
					tran.Rollback()
					Return False
				End Try
			End If
		Next

		tran.Commit()
		Return True
	End Function

	Public Function DesignSave(ByVal DM As DM, ByVal GWTH_ADD As DataView, ByVal GWTH_UPD As DataView, ByVal GWTH_DEL As DataView, ByRef msgerr As String, ByRef DesignNo As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		Dim strLotNo As String = ""
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_dm_update2"
		With DM
			comm.Parameters.AddWithValue("@StartDt", .h01_StartDt.Trim)
			comm.Parameters.AddWithValue("@Design_no", .h02_Design_no.Trim)
			comm.Parameters.AddWithValue("@Elastic", IIf(.h03_Elastic, 1, 0))
			comm.Parameters.AddWithValue("@Type", .h04_Type.Trim)
			comm.Parameters.AddWithValue("@AB", .h05_AB.Trim)
			comm.Parameters.AddWithValue("@Bar", .h06_Bar.Trim)
			comm.Parameters.AddWithValue("@Fine", .h07_Fine.Trim)
			comm.Parameters.AddWithValue("@Bwth", .h08_Bwth)
			comm.Parameters.AddWithValue("@Needle", .h09_Needle.Trim)
			comm.Parameters.AddWithValue("@rptwth_d", .h10_rptwth_d)
			comm.Parameters.AddWithValue("@rptlen_d", .h11_rptlen_d)
			comm.Parameters.AddWithValue("@rptwth_s", .h12_rptwth_s)
			comm.Parameters.AddWithValue("@rptlen_s", .h13_rptlen_s)
			comm.Parameters.AddWithValue("@mtkg", .h14_mtkg)
			comm.Parameters.AddWithValue("@compo", .h15_compo.Trim)
			comm.Parameters.AddWithValue("@rem", .h16_rem.Trim)
			comm.Parameters.AddWithValue("@supdes_no", .h17_supdes_no.Trim)
			comm.Parameters.AddWithValue("@width", .h18_width)
			comm.Parameters.AddWithValue("@cust_design_no", .h19_cust_design_no.Trim)
			comm.Parameters.AddWithValue("@desdesc", .h20_desdesc.Trim)
			comm.Parameters.AddWithValue("@refdesno", .h21_refdesno.Trim)
			comm.Parameters.AddWithValue("@tstamp", .h22_tstamp.ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@ittypecd", .h23_ittypecd.Trim)
			comm.Parameters.AddWithValue("@itgroupcd", .h24_itgroupcd.Trim)
			comm.Parameters.AddWithValue("@log_empcd", .h25_log_empcd)
		End With

		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		End Try
		DesignNo = dt.Rows(0)("design_no").ToString.Trim

		'Add Detail----------

		i = 0
		comm.CommandText = "p_designs_update2"

		For i = 0 To GWTH_ADD.Count - 1
			With GWTH_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@StartDt", config.IsNull(.Item(i)("StartDt"), "").Trim)
				comm.Parameters.AddWithValue("@Design_no", DM.h02_Design_no)
				comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
				comm.Parameters.AddWithValue("@Elastic", DM.h03_Elastic)
				comm.Parameters.AddWithValue("@Type", config.IsNull(.Item(i)("Type"), "").Trim)
				comm.Parameters.AddWithValue("@AB", DM.h05_AB)
				comm.Parameters.AddWithValue("@Fwth", config.IsNull(.Item(i)("Fwth"), "").Trim)
				comm.Parameters.AddWithValue("@Bwth", config.IsNull(.Item(i)("Bwth"), 0))
				comm.Parameters.AddWithValue("@Nob", config.IsNull(.Item(i)("Nob"), 0).ToString)
				comm.Parameters.AddWithValue("@Bar", config.IsNull(.Item(i)("Bar"), "").Trim)
				comm.Parameters.AddWithValue("@Fine", config.IsNull(.Item(i)("Fine"), "").Trim)
				comm.Parameters.AddWithValue("@Usewth", config.IsNull(.Item(i)("Usewth"), "").Trim)
				comm.Parameters.AddWithValue("@rptwth_d", DM.h10_rptwth_d)
				comm.Parameters.AddWithValue("@rptlen_d", DM.h11_rptlen_d)
				comm.Parameters.AddWithValue("@rptwth_s", DM.h12_rptwth_s)
				comm.Parameters.AddWithValue("@rptlen_s", DM.h13_rptlen_s)
				comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(i)("mtkg"), 0).ToString)
				comm.Parameters.AddWithValue("@compo", DM.h15_compo)
				comm.Parameters.AddWithValue("@rem", DM.h16_rem)
				comm.Parameters.AddWithValue("@Needle", config.IsNull(.Item(i)("Needle"), "").Trim)
				comm.Parameters.AddWithValue("@Actual_Bar", config.IsNull(.Item(i)("Actual_Bar"), "").Trim)
				comm.Parameters.AddWithValue("@picture", config.IsNull(.Item(i)("picture"), "").Trim)
				comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(i)("ydkg_g"), 0).ToString)
				comm.Parameters.AddWithValue("@remark", config.IsNull(.Item(i)("remark"), "").Trim)
				comm.Parameters.AddWithValue("@designdt", config.IsNull(.Item(i)("designdt"), "").Trim)
				comm.Parameters.AddWithValue("@gwth_n", config.IsNull(.Item(i)("gwth_n"), "").Trim)
				comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(i)("supdes_no"), "").Trim)
				comm.Parameters.AddWithValue("@design", config.IsNull(.Item(i)("design"), "").Trim)
				comm.Parameters.AddWithValue("@clip", config.IsNull(.Item(i)("clip"), False))
				comm.Parameters.AddWithValue("@sketch", config.IsNull(.Item(i)("sketch"), "").Trim)
				comm.Parameters.AddWithValue("@gmpersqm", config.IsNull(.Item(i)("gmpersqm"), "").Trim)
				comm.Parameters.AddWithValue("@cpi", config.IsNull(.Item(i)("cpi"), 0).ToString)
				comm.Parameters.AddWithValue("@wpi", config.IsNull(.Item(i)("wpi"), 0).ToString)
				'comm.Parameters.AddWithValue("@tstamp", config.IsNull(IIf(IsDate(.Item(i)("tstamp")), .Item(i)("tstamp"), CDate("01/01/1900")), CDate("01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@tstamp", Now.ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@kg_per_roll", config.IsNull(.Item(i)("kg_per_roll"), 0).ToString)
				comm.Parameters.AddWithValue("@mts_per_roll", config.IsNull(.Item(i)("mts_per_roll"), 0).ToString)
				comm.Parameters.AddWithValue("@kg_per_day", config.IsNull(.Item(i)("kg_per_day"), 0).ToString)
				comm.Parameters.AddWithValue("@counter_per_roll", config.IsNull(.Item(i)("counter_per_roll"), 0).ToString)
				comm.Parameters.AddWithValue("@ydkg", config.IsNull(.Item(i)("ydkg"), 0).ToString)
				comm.Parameters.AddWithValue("@mtkg_g", config.IsNull(.Item(i)("mtkg_g"), 0).ToString)
				comm.Parameters.AddWithValue("@rpm", config.IsNull(.Item(i)("rpm"), 0).ToString)
				comm.Parameters.AddWithValue("@log_empcd", DM.h25_log_empcd)
			End With
			'Dim sql As String = config.BuildSQL(comm)
			da = New SqlDataAdapter(comm)
			dt = New DataTable
			Try
				da.Fill(dt)
			Catch ex As Exception
				msgerr = ex.Message
				tran.Rollback()
				Return False
			End Try
		Next

		'Update Detail----------

		i = 0
		comm.CommandText = "p_designs_update2"

		For i = 0 To GWTH_UPD.Count - 1
			With GWTH_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@StartDt", config.IsNull(.Item(i)("StartDt"), "").Trim)
				comm.Parameters.AddWithValue("@Design_no", DM.h02_Design_no)
				comm.Parameters.AddWithValue("@Gwth", config.IsNull(.Item(i)("Gwth"), "").Trim)
				comm.Parameters.AddWithValue("@Elastic", DM.h03_Elastic)
				comm.Parameters.AddWithValue("@Type", config.IsNull(.Item(i)("Type"), "").Trim)
				comm.Parameters.AddWithValue("@AB", DM.h05_AB)
				comm.Parameters.AddWithValue("@Fwth", config.IsNull(.Item(i)("Fwth"), "").Trim)
				comm.Parameters.AddWithValue("@Bwth", config.IsNull(.Item(i)("Bwth"), 0))
				comm.Parameters.AddWithValue("@Nob", config.IsNull(.Item(i)("Nob"), 0).ToString)
				comm.Parameters.AddWithValue("@Bar", config.IsNull(.Item(i)("Bar"), "").Trim)
				comm.Parameters.AddWithValue("@Fine", config.IsNull(.Item(i)("Fine"), "").Trim)
				comm.Parameters.AddWithValue("@Usewth", config.IsNull(.Item(i)("Usewth"), "").Trim)
				comm.Parameters.AddWithValue("@rptwth_d", DM.h10_rptwth_d)
				comm.Parameters.AddWithValue("@rptlen_d", DM.h11_rptlen_d)
				comm.Parameters.AddWithValue("@rptwth_s", DM.h12_rptwth_s)
				comm.Parameters.AddWithValue("@rptlen_s", DM.h13_rptlen_s)
				comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(i)("mtkg"), 0).ToString)
				comm.Parameters.AddWithValue("@compo", DM.h15_compo)
				comm.Parameters.AddWithValue("@rem", DM.h16_rem)
				comm.Parameters.AddWithValue("@Needle", config.IsNull(.Item(i)("Needle"), "").Trim)
				comm.Parameters.AddWithValue("@Actual_Bar", config.IsNull(.Item(i)("Actual_Bar"), "").Trim)
				comm.Parameters.AddWithValue("@picture", config.IsNull(.Item(i)("picture"), "").Trim)
				comm.Parameters.AddWithValue("@ydkg_g", config.IsNull(.Item(i)("ydkg_g"), 0).ToString)
				comm.Parameters.AddWithValue("@remark", config.IsNull(.Item(i)("remark"), "").Trim)
				comm.Parameters.AddWithValue("@designdt", config.IsNull(.Item(i)("designdt"), "").Trim)
				comm.Parameters.AddWithValue("@gwth_n", config.IsNull(.Item(i)("gwth_n"), "").Trim)
				comm.Parameters.AddWithValue("@supdes_no", config.IsNull(.Item(i)("supdes_no"), "").Trim)
				comm.Parameters.AddWithValue("@design", config.IsNull(.Item(i)("design"), "").Trim)
				comm.Parameters.AddWithValue("@clip", config.IsNull(.Item(i)("clip"), False))
				comm.Parameters.AddWithValue("@sketch", config.IsNull(.Item(i)("sketch"), "").Trim)
				comm.Parameters.AddWithValue("@gmpersqm", config.IsNull(.Item(i)("gmpersqm"), "").Trim)
				comm.Parameters.AddWithValue("@cpi", config.IsNull(.Item(i)("cpi"), 0).ToString)
				comm.Parameters.AddWithValue("@wpi", config.IsNull(.Item(i)("wpi"), 0).ToString)
				comm.Parameters.AddWithValue("@tstamp", config.IsNull(.Item(i)("tstamp"), "19000101"))
				comm.Parameters.AddWithValue("@kg_per_roll", config.IsNull(.Item(i)("kg_per_roll"), 0).ToString)
				comm.Parameters.AddWithValue("@mts_per_roll", config.IsNull(.Item(i)("mts_per_roll"), 0).ToString)
				comm.Parameters.AddWithValue("@kg_per_day", config.IsNull(.Item(i)("kg_per_day"), 0).ToString)
				comm.Parameters.AddWithValue("@counter_per_roll", config.IsNull(.Item(i)("counter_per_roll"), 0).ToString)
				comm.Parameters.AddWithValue("@ydkg", config.IsNull(.Item(i)("ydkg"), 0).ToString)
				comm.Parameters.AddWithValue("@mtkg_g", config.IsNull(.Item(i)("mtkg_g"), 0).ToString)
				comm.Parameters.AddWithValue("@rpm", config.IsNull(.Item(i)("rpm"), 0).ToString)
				comm.Parameters.AddWithValue("@log_empcd", DM.h25_log_empcd)
			End With
			da = New SqlDataAdapter(comm)
			dt = New DataTable
			Try
				da.Fill(dt)
			Catch ex As Exception
				msgerr = ex.Message
				tran.Rollback()
				Return False
			End Try
		Next

		tran.Commit()
		Return True
	End Function
End Class
