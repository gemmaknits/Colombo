Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classMaster
	'Bank Of Thailand Website (BOT)
	Public Const WWW_BOT = "http://www.bot.or.th/bothomepage/index/index_e.asp"

	Public Function GetSupplier(Optional ByVal suppcd As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_suppliers_select"
		comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetAgent(Optional ByVal agcd As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_agents_select"
		comm.Parameters.AddWithValue("@agcd", agcd)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetCustomer(Optional ByVal custcd As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_customers_select"
		comm.Parameters.AddWithValue("@custcd", custcd)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetUOM() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_uom_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetColor() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_colors_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDesign(Optional ByVal design_no As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_dm_select"
		comm.Parameters.AddWithValue("@design_no", design_no)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDesign2(Optional ByVal design_no As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_designs_select5"
		comm.Parameters.AddWithValue("@design_no", design_no)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDesignGwth() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_designs_gwth_nob_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetGwth(Optional ByVal design_no As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_designs_gwth_select"
		comm.Parameters.AddWithValue("@design_no", design_no)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetCurrency() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_currency_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetEmp() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_emp_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDyedHouse() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_dyedhouse_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDyedCase() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_dyedcase_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetYesNo() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim strSql As String = ""
		strSql = "select cast(0 as bit) as value,'No' as YesNo,'False' as TrueFalse "
		strSql = strSql & " union all "
		strSql = strSql & " select cast(1 as bit) as value,'Yes' as YesNo,'True' as TrueFalse"
		Dim da As New SqlDataAdapter(strSql, conn)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetSoNo() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_so_select2"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetSoNoID() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_soitm_select2"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetOutNo() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_df_redye_outno"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetCountry() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_country_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetPaymode() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_paymode_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDesignGroup() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_design_group_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDesignType() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_design_type_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetFreightCharge() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_freight_charge_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDocType() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_doc_type_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetDyingMethod() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_dyed_method_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetLightSource() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_light_source_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetMCType() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_mctyp_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		da.Fill(dt)
		Return dt
	End Function

	Public Function GetUSExchnageRate() As Double
		On Error Resume Next
		Dim pageRequest As System.Net.WebRequest = System.Net.WebRequest.Create(WWW_BOT)
		Dim pageResponse As System.Net.WebResponse = CType(pageRequest.GetResponse, System.Net.HttpWebResponse)
		Dim pageSourceStream As System.IO.Stream = pageResponse.GetResponseStream
		Dim pageSourceReader As New System.IO.StreamReader(pageSourceStream)
		Dim strHtml As String = pageSourceReader.ReadToEnd
		strHtml = strHtml.Replace(vbCrLf, "")
		strHtml = strHtml.Replace("	", " ")
		Do While InStr(strHtml, "  ") > 0
			strHtml = strHtml.Replace("  ", " ")
		Loop
		strHtml = strHtml.Substring(InStr(strHtml, "&nbsp;&nbsp;&nbsp;US"), 100)
		strHtml = strHtml.Substring(InStr(strHtml, "</div>") - 8, 7)
		pageSourceReader.Dispose()
		pageSourceStream.Dispose()
		pageResponse.Close()
		Return Val(strHtml)
	End Function
End Class
