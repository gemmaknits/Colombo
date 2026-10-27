Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net
Imports RestSharp
Public Class classMaster
    'Bank Of Thailand Website (BOT)
    ' Public Const WWW_BOT = "http://www.bot.or.th/bothomepage/index/index_e.asp"
    ' Public Const WWW_BOT = "http://www2.bot.or.th/RSS/fxrates/fxrate-USD.xml" 'Add By Neung 20151028
    Public Const WWW_BOT = "https://www.bot.Or.th/App/RSS/fxrate-usd.xml" 'Add By Neung 20190708
    Public Function GetSupplier(Optional ByVal suppcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_suppliers_select"
        comm.Parameters.AddWithValue("@suppcd", suppcd.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetAgent(Optional ByVal agcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_agents_select"
        comm.Parameters.AddWithValue("@agcd", agcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetCustomer(Optional ByVal custcd As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_customers_select"
        comm.Parameters.AddWithValue("@custcd", custcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetUOM() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_uom_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetColor() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_colors_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDesign(Optional ByVal design_no As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dm_select"
        comm.Parameters.AddWithValue("@design_no", design_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDesign2(Optional ByVal design_no As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_designs_select5"
        comm.Parameters.AddWithValue("@design_no", design_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDesignGwth() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_designs_gwth_nob_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetGwth(Optional ByVal design_no As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_designs_gwth_select"
        comm.Parameters.AddWithValue("@design_no", design_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetCurrency() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_currency_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetEmp() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_emp_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDyedHouse() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyedhouse_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDyedCase() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyedcase_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetYesNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim strSql As String = ""
        strSql = "select cast(0 as bit) as value,'No' as YesNo,'False' as TrueFalse "
        strSql = strSql & " union all "
        strSql = strSql & " select cast(1 as bit) as value,'Yes' as YesNo,'True' as TrueFalse"
        Dim da As New SqlDataAdapter(strSql, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function comboSO(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_so"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetSoNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_select2"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function combosono(ByVal StrSono As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_soitm"
        comm.Parameters.AddWithValue("@sono", StrSono)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetSoNoID() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_soitm_select2"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetOutNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_df_redye_outno"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetCountry() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_country_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetPaymode() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_paymode_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDesignGroup() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_group_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDesignType() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_type_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetFreightCharge() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_freight_charge_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDocType() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_doc_type_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetDyingMethod() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dyed_method_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetLightSource() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_light_source_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetMCType() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mctyp_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function
    Public Function GetMCNO() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_machines_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetEndBuyers() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_endbuyers_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetYarnCode(ByVal itcd As String, ByRef returnException As Exception) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_select5"
        comm.Parameters.AddWithValue("@itcd", itcd)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
        Catch ex As Exception
            conn.Close()  'Sitthana 20190326
            returnException = ex
        End Try

        conn.Close()  'Sitthana 20190326
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
        'strHtml = strHtml.Substring(InStr(strHtml, "&nbsp;&nbsp;&nbsp;US"), 100)
        '      strHtml = strHtml.Substring(InStr(strHtml, "</div>") - 8, 7)

        strHtml = strHtml.Substring(InStr(strHtml, "Thai Baht = 1 USD") - 9, 8) 'Add By Neung 2015/10/28

		pageSourceReader.Dispose()
		pageSourceStream.Dispose()
		pageResponse.Close()
		Return Val(strHtml)
    End Function

    Public Function Combomtlwarehouse(strUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse"
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt

    End Function
    Public Function getItemGroupData() As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_item_group"
        Dim da As New SqlDataAdapter(comm)
        Dim ds As New DataSet
        da.Fill(ds, "tblItemsgroup")
        conn.Close()  'Sitthana 20190325
        Return ds.Tables("tblItemsgroup")
    End Function
    Public Function Combomtllocations(Optional ByVal strUSerID As String = "", _
                                      Optional ByVal INt64mtl_warehouse_id As Nullable(Of Int64) = Nothing, _
                                      Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection((New classConnection).Connection)
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
        conn.Close()  'Sitthana 20190326
        Return dt

    End Function

    Public Function GetCombomtl_warehouse(ByVal UserInfo As classUserInfo) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse"
        comm.Parameters.AddWithValue("@logempcd", UserInfo.UserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt

    End Function

    Public Function GetCombomtl_subinventory(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_subinventory"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt

    End Function

    Public Function GetCombomtl_location(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing _
                                       , Optional ByVal Int64mtl_subinventory_id As Nullable(Of Int64) = Nothing) As DataTable
        'Sitthana24/02/2018
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_locations"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetCombomtl_Locations(INt64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64, ByVal UserInfo As classUserInfo) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_locations"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", INt64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        'comm.Parameters.AddWithValue("@location_name", Strlocation_name)
        comm.Parameters.AddWithValue("@logempcd", UserInfo.UserID)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt

    End Function

    Public Function GetdefaultWarehouse(ByVal strUSerID As String) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse_set_default"
        comm.Parameters.AddWithValue("@logempcd", strUSerID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        'Return dt
        Return dt.Rows(0)("mtl_warehouse_id")
    End Function

    Public Function Getdefaultmtlsubinventory(ByVal strUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_subinventory_set_default"
        comm.Parameters.AddWithValue("@logempcd", strUSerID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        Return dt
    End Function

    Public Function GetdefaultSubinventory(ByVal Int64mtl_warehouse_id As Nullable(Of Int64),
                                           ByVal Strsubinventory_code As String,
                                           ByVal strUSerID As String) As Nullable(Of Int64)
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_subinventory_set_default"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@subinventory_code", Strsubinventory_code)
        comm.Parameters.AddWithValue("@logempcd", strUSerID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
        If dt.Rows.Count > 0 Then
            Return (New clsConfig).IsNull(dt.Rows(0)("mtl_subinventory_id"), Nothing)
        Else
            Return Nothing
        End If
    End Function

    Public Function Getdefaultlocations(ByVal Int64mtl_warehouse_id As Nullable(Of Int64),
                                           ByVal Int64mtl_subinventory_id As Nullable(Of Int64),
                                           ByVal Strlocation_name As String,
                                           ByVal strUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_locations_set_default"
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        comm.Parameters.AddWithValue("@location_name", Strlocation_name)
        comm.Parameters.AddWithValue("@logempcd", strUSerID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190326
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
        Dim conn As New SqlConnection((New classConnection).Connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse_set_default"
        comm.Parameters.Clear()
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
End Class
