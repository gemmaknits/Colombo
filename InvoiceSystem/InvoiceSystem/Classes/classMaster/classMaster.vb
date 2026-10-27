Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports RestSharp
Public Class classMaster
	'Bank Of Thailand Website (BOT)
    'Public Const WWW_BOT = "http://www.bot.or.th/bothomepage/index/index_e.asp"
    Public Const WWW_BOT = "http://www2.bot.or.th/RSS/fxrates/fxrate-USD.xml" 'Add By Neung 2015/10/28
    Dim oConfig As New clsConfig
    Public Function GetOrder_type(Optional ByRef StrOrder_Type As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_so_type"
        comm.Parameters.AddWithValue("@order_type", StrOrder_Type)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        conn.Close()
        Return dt
    End Function

    Public Function GetSupplier(Optional ByVal suppcd As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_suppliers_select"
		comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function GetCustomer(Optional ByVal custcd As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_customers_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@custcd", custcd)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

    Public Function GetInvType() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_invtype_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetFreightType() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_freight_type_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetForwarder() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_forwarder_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
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
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function GetEndBuyers() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_endbuyers_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function GetReasons() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_reasons_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function GetUSExchnageRate() As Double
        'This Version is Not use Api Neung 20200109 Show Last Exchange Rate Update from BOT
        On Error Resume Next 'Not Show Error On Debug Mode Neung 20200109
        ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType) 'Protocol tls12 = 3072 'Add By Neung 
        Dim pageRequest As System.Net.WebRequest = System.Net.WebRequest.Create(WWW_BOT)
		Dim pageResponse As System.Net.WebResponse = CType(pageRequest.GetResponse, System.Net.HttpWebResponse)
		Dim pageSourceStream As System.IO.Stream = pageResponse.GetResponseStream
		Dim pageSourceReader As New System.IO.StreamReader(pageSourceStream)
		Dim strHtml As String = pageSourceReader.ReadToEnd
        'strHtml = strHtml.Replace(vbCrLf, "")
        'strHtml = strHtml.Replace("	", " ")
        'Do While InStr(strHtml, "  ") > 0
        '	strHtml = strHtml.Replace("  ", " ")
        'Loop
        '      'strHtml = strHtml.Substring(InStr(strHtml, "&nbsp;&nbsp;&nbsp;US"), 100)
        'strHtml = strHtml.Substring(InStr(strHtml, "</div>") - 8, 7)

        strHtml = strHtml.Substring(InStr(strHtml, "Thai Baht = 1 USD") - 9, 8) 'Add By Neung 2015/10/28

		pageSourceReader.Dispose()
		pageSourceStream.Dispose()
		pageResponse.Close()
		Return Val(strHtml)
    End Function
    Public Function GetArticle(Optional ByVal design_no As String = "") As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim articleNo As String
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dm_get_article"
        comm.Parameters.AddWithValue("@design_no", design_no)
        comm.Connection = conn
        conn.Open()
        articleNo = comm.ExecuteScalar
        conn.Close()  'Sitthana 20190325
        Return articleNo
    End Function

    Public Function GetGmPerSqm(Optional ByVal design_no As String = "") As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim GmPerSqM As String
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_designs_get_GmPerSqM"
        comm.Parameters.AddWithValue("@design_no", design_no)
        comm.Connection = conn
        conn.Open()
        GmPerSqM = comm.ExecuteScalar
        conn.Close()  'Sitthana 20190325
        Return GmPerSqM
    End Function

    Public Function GetFWth(Optional ByVal design_no As String = "") As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim Fwth As String
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_designs_get_Fwth"
        comm.Parameters.AddWithValue("@design_no", design_no)
        comm.Connection = conn
        conn.Open()
        Fwth = comm.ExecuteScalar
        conn.Close()  'Sitthana 20190325
        Return Fwth
    End Function

    Public Function Combomtlwarehouse(strUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse"
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetdefaultWarehouse(ByVal strUSerID As String) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse_set_default"
        comm.Parameters.AddWithValue("@logempcd", strUSerID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)("mtl_warehouse_id")
    End Function

    Public Function GetdefaultSubinventory(ByVal Int64mtl_warehouse_id As Nullable(Of Int64),
                                           ByVal Strsubinventory_code As String,
                                           ByVal strUSerID As String) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_subinventory_set_default"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@subinventory_code", Strsubinventory_code)
        comm.Parameters.AddWithValue("@logempcd", strUSerID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)("mtl_subinventory_id")
    End Function


    Public Function GetCombomtl_subinventory(Optional ByVal INt64mtl_warehouse_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New ClassConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_subinventory"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function Combomtllocations(Optional ByVal strUSerID As String = "", _
                                      Optional ByVal INt64mtl_warehouse_id As Nullable(Of Int64) = Nothing, _
                                      Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_locations"
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        'comm.Parameters.AddWithValue("@logempcd", strUserId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function CombomtllocationsByWareHouse(ByVal Int64mtl_warehouse_id As Nullable(Of Int64), strUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_locations_by_warehouse_id"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function CombomtllocationsByYarnInBalance(strUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_locations_by_yarn_in_det"
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function Getmtl_locations(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing, _
                                     Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mtl_locations_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboBanks() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_COMBO_MASTER_banks"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function GetExchangeRateAPI(ByVal currency As String) As Decimal
        On Error Resume Next
        Dim ExchangeRate As Decimal = 0
        ' ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType) 'Protocol tls12 = 3072
        Dim SPeriod As DateTime = DateTime.Now
        Dim EPeriod As DateTime = DateTime.Now
        'If Not DateTime.Now.Hour >= 18 Then
        '    SPeriod = SPeriod.AddDays(-1)
        '    EPeriod = EPeriod.AddDays(-1)
        'End If
        '=========================================== Get Data From Current Date ===============================================================
        Dim startPeriod As String = SPeriod.ToString("yyyy-MM-dd")
        Dim endPeriod As String = EPeriod.ToString("yyyy-MM-dd")
        Dim client As New RestClient("https://apigw1.bot.Or.th/bot/public/Stat-ExchangeRate/v2/DAILY_AVG_EXG_RATE/?start_period=" + startPeriod + "&end_period=" + endPeriod + "&currency=" + currency)
        Dim request = New RestRequest(Method.GET)
        request.AddHeader("x-ibm-client-id", "212d6cd1-a227-434c-b300-48d1417ad6d5") 'Client ID
        request.AddHeader("accept", "undefined")

        Dim response As IRestResponse = client.Execute(request)
        If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
            Console.WriteLine(response.Content)
            ExchangeRate = response.Content.ToString.Substring(InStr(response.Content.ToString, "buying_sight") + 14, 8) 'Add By Neung 20151028 buying_sight คืำ ตำแหน่ง + 14 นับจาก b และ 10 คือข้อมูล
        End If

        '=========================================== Get Data From BOT Last Update If Exchange Rete still equals zero =======================================
        If ExchangeRate.Equals(0) Then
            startPeriod = response.Content.ToString.Substring(InStr(response.Content.ToString, "last_updated") + 14, 10)
            endPeriod = response.Content.ToString.Substring(InStr(response.Content.ToString, "last_updated") + 14, 10)
            Dim clientLastUpdate As New RestClient("https://apigw1.bot.Or.th/bot/public/Stat-ExchangeRate/v2/DAILY_AVG_EXG_RATE/?start_period=" + startPeriod + "&end_period=" + endPeriod + "&currency=" + currency)
            Dim requestLastUpdate = New RestRequest(Method.GET)
            requestLastUpdate.AddHeader("x-ibm-client-id", "212d6cd1-a227-434c-b300-48d1417ad6d5") 'Client ID
            requestLastUpdate.AddHeader("accept", "undefined")
            Dim responseLastUpdate As IRestResponse = clientLastUpdate.Execute(requestLastUpdate)
            If (responseLastUpdate.StatusCode.Equals(HttpStatusCode.OK)) Then
                ExchangeRate = responseLastUpdate.Content.ToString.Substring(InStr(responseLastUpdate.Content.ToString, "buying_sight") + 14, 8)
            End If
        End If

        Return ExchangeRate
    End Function
    Public Function GetdefaultWarehouseID(ByVal strUSerID As String) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse_set_default"
        comm.Parameters.AddWithValue("@logempcd", (New clsConfig).IsNull(strUSerID, "").Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Dim pMtlWarehouseID As Nullable(Of Int64) = 1
        If dt.Rows.Count > 0 Then
            pMtlWarehouseID = dt.Rows(0)("mtl_warehouse_id")
        End If
        Return pMtlWarehouseID
    End Function
    Public Function selectExchageRateRecord(ByVal pCurrFr As String, ByVal pCurrTo As String, ByVal pCurrDate As DateTime) As Decimal
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_EXCHANGE_RATE_PKG_select_exchange_rate_record"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@p_curr_fr", pCurrFr) 'USD and ETC
        comm.Parameters.AddWithValue("@p_curr_to", pCurrTo) 'THB
        comm.Parameters.AddWithValue("@p_curr_date", pCurrDate) 'Date
        Dim pExchangeRate As New SqlParameter("@p_exchange_rate", SqlDbType.Decimal)
        With pExchangeRate
            ' Set precision and scale and Direction
            .Precision = 18
            .Scale = 4
            .Direction = ParameterDirection.Output
        End With
        comm.Parameters.Add(pExchangeRate)
        comm.Parameters("@p_exchange_rate").Precision = 18
        comm.Parameters("@p_exchange_rate").Scale = 4
        comm.Parameters("@p_exchange_rate").Direction = ParameterDirection.Output
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        comm.Connection.Close()
        selectExchageRateRecord = oConfig.IsNull(pExchangeRate.Value, 0) 'clsConfig.IsNull(comm.Parameters("@p_exchange_rate").Value, 0)
        Return selectExchageRateRecord
    End Function
    Public Function GetExchangeRateAPIByDate(ByVal currency As String, ByVal SPeriod As DateTime, ByVal EPeriod As DateTime) As Decimal
        On Error Resume Next
        'ดึงข้อมูลจาก ธนาคารแห่งประเทศไทย แบบ Realtime ถ้ายังเป็นวันใหม่ๆ ธนาคารยังไม่อัพเดทให้
        Dim ExchangeRate As Decimal = 0
        'If SPeriod.Date = Now.Date And (SPeriod.Hour > 0 And SPeriod.Hour < 18) Then GoTo EX
        If currency.Trim = "THB" Then
            ExchangeRate = 1
            GoTo EX 'กรณ๊ที่เป็นไทยบาท 
        Else
            ExchangeRate = selectExchageRateRecord(currency, "THB", SPeriod)
            If ExchangeRate > 0 Then
                GoTo EX
            End If
        End If
        ServicePointManager.SecurityProtocol = DirectCast(3072, SecurityProtocolType) 'Protocol tls12 = 3072

        '=========================================== Get Data From Current Date ===============================================================

        Dim startPeriod As String
        Dim endPeriod As String
BEGIN:
        startPeriod = SPeriod.ToString("yyyy-MM-dd")
        endPeriod = EPeriod.ToString("yyyy-MM-dd")
        Dim client As New RestClient("https://gateway.api.bot.or.th/Stat-ExchangeRate/v2/DAILY_AVG_EXG_RATE/?start_period=" + startPeriod + "&end_period=" + endPeriod + "&currency=" + currency)
        Dim request = New RestRequest(Method.GET)
        request.AddHeader("Authorization", "eyJvcmciOiI2NzM1NzgwZWM4YzFlYjAwMDEyYTM3NzEiLCJpZCI6ImY5NzllNGRhYjllNjQyZjFiMGFmNWJiYzI5YTRlYzcyIiwiaCI6Im11cm11cjEyOCJ9") ' John 09/01/2026 'Client ID
        request.AddHeader("accept", "undefined")

        Dim response As IRestResponse = client.Execute(request)
        If (response.StatusCode.Equals(HttpStatusCode.OK)) Then
            Console.WriteLine(response.Content)
            ExchangeRate = response.Content.ToString.Substring(InStr(response.Content.ToString, "buying_sight") + 14, 8) 'Add By Neung 20151028 buying_sight คืำ ตำแหน่ง + 14 นับจาก b และ 10 คือข้อมูล
            If ExchangeRate = 0 Then
                SPeriod = SPeriod.AddDays(-1)
                EPeriod = EPeriod.AddDays(-1)
                GoTo BEGIN
            End If
        End If
EX:
        Return ExchangeRate
    End Function
End Class
