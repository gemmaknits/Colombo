Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Net

Imports RestSharp
Public Class classMaster
    'Bank Of Thailand Website (BOT)
    'Public Const WWW_BOT = "http://www.bot.or.th/bothomepage/index/index_e.asp"
    'Public Const WWW_BOT = "http://www.bot.or.th/Thai/Pages/BOTDefault.aspx"
    'Public Const WWW_BOT = "http://www2.bot.or.th/RSS/fxrates/fxrate-USD.xml" 'Add By Neung 20151028
    Public Const WWW_BOT = "https://www.bot.Or.th/App/RSS/fxrate-usd.xml" 'Add By Neung 20190708

    'New Procedure in Gemmaknits   -- Sitthana 13/03/2018
    Public Function AreaSqCMPerPiece(ByVal LengthCmPerPieceWithMark As Decimal, ByVal WidthCmPerPieceWithMark As Decimal) As Decimal
        Return Math.Round(LengthCmPerPieceWithMark * WidthCmPerPieceWithMark, 2)
    End Function

    Public Function GetDesignNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_master_new_pkg_get_design_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboShoeSizeCtry() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_shoe_ctry"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboShoeSize(ByVal CountryLookupValueID As Int64) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_shoe_size_by_ctry"
        comm.Parameters.AddWithValue("@p_parent_lookup_value_id", CountryLookupValueID)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboShoeStyle() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_shoe_style"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboShoeGender() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_shoe_gender"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboFabricType() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_master_new_pkg_combo_fabric_type"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetMachineGroup() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_machine_group"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function getBOMHeader(ByVal DesignNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_master_new_pkg_select_bom_headers"
        comm.Parameters.AddWithValue("@p_design_no", DesignNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function getBOMLines(ByVal IDYarnchange As Integer) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_design_master_new_pkg_select_bom_lines"
        comm.Parameters.AddWithValue("@p_id_yarnchange", IDYarnchange)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function ComboLookUp(Strlookup_type As String) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_lookup_codes"
        comm.Parameters.AddWithValue("@p_lookup_type", Strlookup_type)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function
    Public Function getDesignByParentDesign(pParentDesignNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DESIGN_MASTER_NEW_PKG_select_design_master_by_parent_design"
        comm.Parameters.AddWithValue("@p_parent_design", pParentDesignNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function KgPerDay(ByVal MetersPerDay As Decimal, ByVal MetersPerKg As Decimal) As Decimal
        If MetersPerKg = 0 Then
            Return 0
        End If
        Return Math.Round(MetersPerDay / MetersPerKg, 2)
    End Function

    Public Function KgPerMeter(ByVal GramsPerSqM As Decimal, ByVal FabricFullWidthCm As Decimal) As Decimal
        If IsDBNull(GramsPerSqM) Or IsDBNull(FabricFullWidthCm) Then
            Return 0
        Else
            Return Math.Round(((GramsPerSqM * FabricFullWidthCm * 100) / 10000) / 1000, 2)
        End If
    End Function

    Public Function MetersPerDay(ByVal LengthCmPerPieceWithMark As Decimal, RepeatsPerDay As Decimal) As Decimal
        Return Math.Round(LengthCmPerPieceWithMark / 100 * RepeatsPerDay, 2)
    End Function
    Public Function MetersPerKg(ByVal KgPerMeter As Decimal) As Decimal
        If IsDBNull(KgPerMeter) Or KgPerMeter = 0 Then
            Return 0
        End If
        Return Math.Round(1 / KgPerMeter, 2)
    End Function

    Public Function MetersPerRoll(ByVal KgPerRoll As Decimal, ByVal MetersPerKg As Decimal) As Decimal
        Return KgPerRoll * MetersPerKg
    End Function

    Public Function LengthCmPerRepeat(ByVal LengthMetersPerPieceWithMark As Decimal) As Decimal
        Return Math.Round(LengthMetersPerPieceWithMark * 2, 2)
    End Function

    Public Function PairsPerDay(ByVal PairsPerMeter As Decimal, ByVal MetersPerDay As Decimal) As Decimal
        Return Math.Round(PairsPerMeter * MetersPerDay, 2)
    End Function

    Public Function PairsPerMeter(ByVal LengthPerPieceWithMark As Decimal, ByVal PiecesPerFabricFullWidthPerRow As Decimal) As Decimal
        If LengthPerPieceWithMark = 0 Then
            Return 0
        End If
        Return Math.Round((PiecesPerFabricFullWidthPerRow / LengthPerPieceWithMark) / 2 * 100, 2)
    End Function

    Public Function PairsPerKg(ByVal PairsPerMeter As Decimal, ByVal MetersPerKg As Decimal) As Decimal
        Return Math.Round(PairsPerMeter * MetersPerKg, 2)
    End Function

    Public Function PairsPerRepeat(ByVal NumberOfNeedles As Decimal, ByVal NeedleWidth As Decimal) As Decimal
        If NeedleWidth = 0 Then
            Return 0
        End If
        Return Math.Round(NumberOfNeedles / NeedleWidth, 2)
    End Function

    Public Function PiecesPerFabricNeedleWidthPerRow(ByVal NumberOfNeedls As Decimal, ByVal FabricNeedleWidth As Decimal) As Decimal
        If FabricNeedleWidth = 0 Then
            Return 0
        End If
        Return Math.Round(NumberOfNeedls / FabricNeedleWidth, 2)
    End Function

    Public Function PiecesPerFabricFullWidthPerRow(ByVal FabricFullWidthCm As Decimal, ByVal WidthCmPerPieceWithMark As Decimal) As Decimal
        If WidthCmPerPieceWithMark = 0 Then
            Return 0
        End If
        Return Math.Round(FabricFullWidthCm / WidthCmPerPieceWithMark, 2)
    End Function

    Public Function RepeatsPerDay(ByVal MinutesPerRepeat As Decimal, ByVal HoursPerDay As Decimal) As Decimal
        Dim varRepeatsPerDay As Decimal
        If MinutesPerRepeat = 0 Then
            Return 0
        End If
        varRepeatsPerDay = Math.Round(HoursPerDay * 60 / MinutesPerRepeat, 2)
        Return varRepeatsPerDay
    End Function

    Public Function RowsPerMeter(ByVal PieceLengthCMMarkToMark As Decimal) As Decimal
        Dim PieceLengthMeterMarkToMark As Decimal
        PieceLengthMeterMarkToMark = (PieceLengthCMMarkToMark / 100)
        Return Math.Round(1 / PieceLengthMeterMarkToMark, 2)
    End Function


    Public Function WeightGramsPerRow(ByVal LengthPerPieceWithMark As Decimal, ByVal KgPerMeter As Decimal) As Decimal
        ' 1000/100 means 1000 to convert kg to gram and divide by 100 to convert cm to meters
        Return Math.Round(LengthPerPieceWithMark * KgPerMeter * 1000 / 100, 2)
    End Function

    Public Function WeighGramstPerPair(ByVal WeightGramsPerPiece As Decimal) As Decimal
        Return Math.Round(WeightGramsPerPiece * 2, 2)
    End Function

    Public Function WeightGramsFullWidth(ByVal WeightGramsPerPiece As Decimal, ByVal PiecesPerFabricFullWidthPerRow As Decimal) As Decimal
        Return Math.Round(WeightGramsPerPiece * PiecesPerFabricFullWidthPerRow, 2)
    End Function

    Public Function WeightGramsOfAreaNotUsed(ByVal WeightGramsPerRow As Decimal, ByVal PatternWeightGramsFullWidth As Decimal) As Decimal
        Return Math.Round(WeightGramsPerRow - PatternWeightGramsFullWidth, 2)
    End Function

    'End New Procedure in Gemmaknits

    Public Function GetSupplier(Optional ByVal suppcd As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_suppliers_select"
        comm.Parameters.Clear()
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

    Public Function GetBOMUOM() As DataTable
        'Create By :Sitthana 16/01/2018
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_bom_form_pkg_combo_uom"
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

    Public Function GetBOMColorWay() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_bom_form_pkg_combo_color_way"
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

    Public Function getItdesc(Optional ByVal itcd As String = "") As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_BOM_PKG_get_itdesc"
        comm.Parameters.AddWithValue("@itcd", itcd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)("itdesc").ToString
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

    Public Function GetDesign3(Optional ByVal design_no As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_designs_select6"
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

    Public Function GetEmp(Optional ByVal EmpCD As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_emp_select"
        comm.Parameters.AddWithValue("@empcd", EmpCD)
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

	Public Function GetDesignSubGroup() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_design_subgroup_select"
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

	Public Function GetEndBuyers(Optional ByVal strEndBuyerCD As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_endbuyers_select"
		comm.Parameters.AddWithValue("@endbuyercd", strEndBuyerCD)
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
        'strHtml = strHtml.Substring(InStr(strHtml, "&nbsp;&nbsp;&nbsp;US"), 100)
        'strHtml = strHtml.Substring(InStr(strHtml, "</div>") - 8, 7)

        'strHtml = strHtml.Substring(InStr(strHtml, "USD") - 1, 50)
        'strHtml = strHtml.Substring(8, Len(strHtml) - 8)
        'strHtml = strHtml.Substring(InStr(strHtml, "</td>") - 8, 11)
        'strHtml = strHtml.Substring(0, 7)

        strHtml = strHtml.Substring(InStr(strHtml, "Thai Baht = 1 USD") - 9, 8) 'Add By Neung 2015/10/28

        pageSourceReader.Dispose()
        pageSourceStream.Dispose()
        pageResponse.Close()
        Return Val(strHtml)
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
        Dim client As New RestClient("https://gateway.api.bot.or.th/Stat-ExchangeRate/v2/DAILY_AVG_EXG_RATE/?start_period=" + startPeriod + "&end_period=" + endPeriod + "&currency=" + currency)
        Dim request = New RestRequest(Method.GET)
        request.AddHeader("Authorization", "eyJvcmciOiI2NzM1NzgwZWM4YzFlYjAwMDEyYTM3NzEiLCJpZCI6ImY5NzllNGRhYjllNjQyZjFiMGFmNWJiYzI5YTRlYzcyIiwiaCI6Im11cm11cjEyOCJ9") ' John 09/01/2026 'Client ID
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
            Dim clientLastUpdate As New RestClient("https://gateway.api.bot.or.th/Stat-ExchangeRate/v2/DAILY_AVG_EXG_RATE/?start_period=" + startPeriod + "&end_period=" + endPeriod + "&currency=" + currency)
            Dim requestLastUpdate = New RestRequest(Method.GET)
            requestLastUpdate.AddHeader("Authorization", "eyJvcmciOiI2NzM1NzgwZWM4YzFlYjAwMDEyYTM3NzEiLCJpZCI6ImY5NzllNGRhYjllNjQyZjFiMGFmNWJiYzI5YTRlYzcyIiwiaCI6Im11cm11cjEyOCJ9") 'Client ID
            requestLastUpdate.AddHeader("accept", "undefined")
            Dim responseLastUpdate As IRestResponse = clientLastUpdate.Execute(requestLastUpdate)
            If (responseLastUpdate.StatusCode.Equals(HttpStatusCode.OK)) Then
                ExchangeRate = responseLastUpdate.Content.ToString.Substring(InStr(responseLastUpdate.Content.ToString, "buying_sight") + 14, 8)
            End If
        End If

        Return ExchangeRate
    End Function

    Public Function getExchangeRateByDateCurr(pDate As String, pCurrency As String) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        Dim articleNo As String
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_EXCHANGE_RATE_PKG_select_exchange_rate_by_date_curr"
        comm.Parameters.AddWithValue("@p_date", pDate)
        comm.Parameters.AddWithValue("@p_currency", pCurrency)

        comm.Connection = conn
        conn.Open()
        articleNo = comm.ExecuteScalar
        conn.Close()  'Sitthana 20190325
        Return articleNo
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

    Public Function GetItemDesc(ByVal itcd As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(comm)

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_items_get_desc"
        comm.Parameters.AddWithValue("@itcd", itcd)
        comm.Connection = conn
        conn.Open()
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
            Return Nothing
        End Try
        Return dt
    End Function

	Public Function GetSOType() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_sotype_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetFinishingGroup() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_finishing_group_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCompositionGroup() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mas_composition_group_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetWidth() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_sys_width_select"
        comm.Parameters.Clear()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetMachine(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_machines_select2"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetMachineMaster(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_machines_master_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSO(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_so"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSODR(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_so_dr"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboKO(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_ko"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboKOStatus() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_combo_master_ko"
        comm.CommandText = "p_combo_master_ko_ShowStatus" 'Sitthana 06/02/2018 
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboKOGroup(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_ko_group"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function combomtl_txn_source_type(StrUSerID As String) As DataTable
        Dim classConnection As New classConnection
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_txn_source_type"
        comm.Parameters.AddWithValue("@logempcd", StrUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function combodemand_source_line_id(Optional ByVal Int64demand_source_line_id As Int64 = Nothing, Optional ByVal StrUserId As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_demand_source_line_id"
        comm.Parameters.AddWithValue("@demand_source_line_id", Int64demand_source_line_id)
        comm.Parameters.AddWithValue("@logempcd", StrUserId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function combosupply_source_line_id(Optional ByVal Int64supply_source_line_id As Int64 = Nothing, Optional ByVal StrUserId As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_demand_source_line_id"
        comm.Parameters.AddWithValue("@demand_source_line_id", Int64supply_source_line_id)
        comm.Parameters.AddWithValue("@logempcd", StrUserId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboCustomer(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_customer"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboEmployee(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_employee"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSalesPerson(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_sales_person"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboMachine(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_machine"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboDesignGroup(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_design_group"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboMachineDesign(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_machine_design"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboSupplier(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_supplier"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboDesign(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_design"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function combov_items_des_mc(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_v_items_des_mc"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboGreigeDesign(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_production_item"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboDesignBOM(strDesignNo As String, strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_design_bom"
        comm.Parameters.AddWithValue("@design_no", strDesignNo)
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboYarnChange(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_yarnchange"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboBOMUsage(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_bom_usage"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function comboYarn(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_yarn"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function gridMachine(ByVal strMcNo As String, strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_grid_master_machine"
        comm.Parameters.AddWithValue("@mcno", strMcNo)
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function


    Public Function comboStatus(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_status_code"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function comboBeamItem(strUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_beam_items"
        comm.Parameters.AddWithValue("@logempcd", strUserID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function Combomtlwarehouse(strUSerID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function GetdefaultWarehouse(strUSerID As String) As Int64
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_warehouse_set_default"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt.Rows(0)("mtl_warehouse_id")
    End Function

    Public Function GetCombomtl_subinventory(INt64mtl_warehouse_id As Int64) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
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

    Public Function CombomtlSub(strUSerID As String) As DataTable
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

    'p_combo_master_mtl_locations
    Public Function Combomtllocations(Optional ByVal strUSerID As String = "", Optional ByVal pMtlWarehouseId As Int64 = Nothing, Optional ByVal Int64mtl_subinventory_id As Int64 = Nothing) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_locations"
        comm.Parameters.AddWithValue("@logempcd", strUSerID)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", pMtlWarehouseId)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        'comm.Parameters.AddWithValue("@logempcd", strUserId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function Getmtl_locations(Optional ByVal Int64mtl_warehouse_id As Nullable(Of Int64) = Nothing) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_mtl_locations_select"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ComboItems(StrUserId As String) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_items"
        comm.Parameters.AddWithValue("@logempcd", StrUserId)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetCombomtl_inventory_types() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_mtl_inventory_types"

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function ComboItem(Stritnaturecd As String) As DataTable
        Dim classconection As New classConnection
        Dim conn As New SqlConnection(classconection.connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_item"
        comm.Parameters.AddWithValue("@itnaturecd", Stritnaturecd)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt

    End Function

    Public Function comboKOType(ByVal StrUserID As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_master_ko_type"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@logempcd", StrUserID.Trim)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function Getlookup_value_short_code(Optional ByVal Int64lookup_value_id As Nullable(Of Int64) = Nothing) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_lookup_select"
        comm.Parameters.AddWithValue("@lookup_value_id", Int64lookup_value_id)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("lookup_value_short_code")
        Else
            Return ""
        End If 'Sitthana 20200212
    End Function

    Public Function getDmRemark(pDesignNo As String) As String
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dm_get_remark"
        comm.Parameters.AddWithValue("@p_design_no", pDesignNo)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0)("rem")
        Else
            Return ""
        End If 'Sitthana 20200212
    End Function
    Public Function comboSpecStatus() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_DESIGN_MASTER_NEW_PKG_combo_spec_status"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
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
End Class
