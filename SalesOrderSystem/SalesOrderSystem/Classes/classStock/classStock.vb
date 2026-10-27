Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classStock
    Public Structure StockSHeader
        Dim h01_dinno As String
        Dim h02_dindt As String
        Dim h03_doctyp As String
        Dim h04_design_no As String
        Dim h05_Gwth As String
        Dim h06_remark As String
        Dim h07_log_empcd As String
        Dim h08_outtyp As String
    End Structure


    Public Structure Strolls_DHeader

        'strolls_d
        Dim h01_dinno As String
        Dim h02_dindt As Nullable(Of Date)
        Dim h03_doctyp As String
        Dim h04_dhcod As String
        Dim h05_dhdono As String
        Dim h06_dhdodt As String
        Dim h07_dfno As String
        Dim h08_dono As String
        Dim h09_dodt As Nullable(Of Date)
        Dim h10_design_no As String
        Dim h11_Gwth As String
        Dim h12_fwth As String
        Dim h13_lot As String
        Dim h14_yr As String
        Dim h15_sh As String
        Dim h16_col As String
        Dim h17_Gr As String
        Dim h18_mtkg As Double
        Dim h19_roll_no_d As String
        Dim h20_roll_no_g As String
        Dim h21_kg As Double
        Dim h22_mts As Double
        Dim h23_yds As Double
        Dim h24_sono As String
        Dim h25_nob As Double
        Dim h26_typ As String
        Dim h27_status As String
        Dim h28_outreqno As String
        Dim h29_outreqdt As Nullable(Of Date)
        Dim h30_mts_g As Double
        Dim h31_yds_g As Double
        Dim h32_allowmt As Double
        Dim h33_sonoid As String
        Dim h34_lotbatno As String
        Dim h35_sel As Boolean
        Dim h36_loc As String 'Same h01_cartno
        Dim h37_cost As Double 'Same h02_packno
        Dim h38_batch As String
        Dim h39_custcolor As String
        Dim h40_fload As Boolean
        Dim h41_cancel As Boolean
        Dim h42_dinno1 As String
        Dim h43_dinnot As String
        Dim h44_cost_d As Double
        Dim h45_unit As String
        Dim h46_roll_no_o As String
        Dim h47_roll_no_p As String
        Dim h48_roll_no_f As String
        Dim h49_rem_qc As String
        Dim h50_job_line_id As String
        Dim h51_fabric_cost As Double
        Dim h52_process_cost As Double
        Dim h53_process_loss_perc As Double
        Dim h54_other_cost As Double
        Dim h55_cost_per_unit As Double
        Dim h56_mtl_warehouse_id As Nullable(Of Int64)
        Dim h57_mtl_locations_id As Nullable(Of Int64)
        Dim h58_mtl_subinventory_id As Nullable(Of Int64)


        'strolls_d
    End Structure

    Public Structure TrnHeader
        Dim h01_trn_id As Long
        Dim h02_trn_no As String
        Dim h03_trn_date As String
        Dim h04_trn_time As String
        Dim h05_new_location As String
        Dim h06_new_sub_location As String
        Dim h07_login_empcd As String
    End Structure

	Public Function GetSINNo() As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_stock_s_select"
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function GetSINDet(ByVal strDINNo As String) As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_stock_s_select2"
		comm.Parameters.AddWithValue("@dinno", strDINNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function StockSSave(ByVal SINH As StockSHeader, ByVal SIND_ADD As DataView, ByVal SIND_UPD As DataView, ByVal SIND_DEL As DataView, ByRef msgerr As String, ByRef sinno As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		Dim i As Integer = 0
		Dim outno As String = ""

		sinno = SINH.h01_dinno

		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_stock_s_update"

		'Add Detail----------

		For i = 0 To SIND_ADD.Count - 1
			With SIND_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@dinno", sinno)
				comm.Parameters.AddWithValue("@dindt", SINH.h02_dindt)
				comm.Parameters.AddWithValue("@doctyp", SINH.h03_doctyp)
				comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(i)("dhcod"), "").Trim)
				comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(i)("dhdono"), "").Trim)
				comm.Parameters.AddWithValue("@dhdodt", CDate(config.IsNull(.Item(i)("dhdodt2"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(i)("dfno"), "").Trim)
				comm.Parameters.AddWithValue("@dono", outno)
				comm.Parameters.AddWithValue("@dodt", CDate(config.IsNull(.Item(i)("dodt2"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@design_no", SINH.h04_design_no)
				comm.Parameters.AddWithValue("@Gwth", SINH.h05_Gwth)
				comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
				comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), "").Trim)
				comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
				comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
				comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("Gr"), "").Trim)
				comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(i)("mtkg"), 0))
				comm.Parameters.AddWithValue("@roll_no_d", "")
				comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), "").Trim)
				comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("kg"), 0))
				comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("mts"), 0))
				comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("yds"), 0))
				comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
				comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(i)("nob"), 0).ToString)
				comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(i)("typ"), "").Trim)
				comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), "").Trim)
				comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "").Trim)
				comm.Parameters.AddWithValue("@outreqdt", CDate(config.IsNull(.Item(i)("outreqdt2"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(i)("mts_g"), 0))
				comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(i)("yds_g"), 0))
				comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(i)("allowmt"), 0))
				comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
				comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(i)("lotbatno"), "").Trim)
				comm.Parameters.AddWithValue("@sel", IIf(CBool(config.IsNull(.Item(i)("sel"), False)), 1, 0))
				comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(i)("loc"), "").Trim)
				comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(i)("cost"), 0))
				comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").Trim)
				comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
				comm.Parameters.AddWithValue("@fload", IIf(CBool(config.IsNull(.Item(i)("fload"), False)), 1, 0))
				comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(i)("dinno1"), "").Trim)
				comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(i)("dinnot"), "").Trim)
				comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(i)("cost_d"), 0))
				comm.Parameters.AddWithValue("@remark", SINH.h06_remark)
				comm.Parameters.AddWithValue("@outtyp", SINH.h08_outtyp)
				comm.Parameters.AddWithValue("@log_empcd", SINH.h07_log_empcd)
			End With

			Dim xxx As String = config.BuildSQL(comm)
			Debug.Print(xxx)

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
			sinno = dt.Rows(0)("dinno").ToString
			outno = dt.Rows(0)("dono").ToString
		Next

		'Update Detail----------

		i = 0
		comm.CommandText = "p_stock_s_update"

		For i = 0 To SIND_UPD.Count - 1
			With SIND_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@dinno", SINH.h01_dinno)
				comm.Parameters.AddWithValue("@dindt", SINH.h02_dindt)
				comm.Parameters.AddWithValue("@doctyp", SINH.h03_doctyp)
				comm.Parameters.AddWithValue("@dhcod", config.IsNull(.Item(i)("dhcod"), "").Trim)
				comm.Parameters.AddWithValue("@dhdono", config.IsNull(.Item(i)("dhdono"), "").Trim)
				comm.Parameters.AddWithValue("@dhdodt", CDate(config.IsNull(.Item(i)("dhdodt2"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@dfno", config.IsNull(.Item(i)("dfno"), "").Trim)
				comm.Parameters.AddWithValue("@dono", config.IsNull(.Item(i)("dono"), "").Trim)
				comm.Parameters.AddWithValue("@dodt", CDate(config.IsNull(.Item(i)("dodt2"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@design_no", SINH.h04_design_no)
				comm.Parameters.AddWithValue("@Gwth", SINH.h05_Gwth)
				comm.Parameters.AddWithValue("@fwth", config.IsNull(.Item(i)("fwth"), "").Trim)
				comm.Parameters.AddWithValue("@lot", config.IsNull(.Item(i)("lot"), "").Trim)
				comm.Parameters.AddWithValue("@yr", config.IsNull(.Item(i)("yr"), "").Trim)
				comm.Parameters.AddWithValue("@sh", config.IsNull(.Item(i)("sh"), "").Trim)
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
				comm.Parameters.AddWithValue("@Gr", config.IsNull(.Item(i)("Gr"), "").Trim)
				comm.Parameters.AddWithValue("@mtkg", config.IsNull(.Item(i)("mtkg"), 0))
				comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item(i)("roll_no_d"), "").Trim)
				comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), "").Trim)
				comm.Parameters.AddWithValue("@kg", config.IsNull(.Item(i)("kg"), 0))
				comm.Parameters.AddWithValue("@mts", config.IsNull(.Item(i)("mts"), 0))
				comm.Parameters.AddWithValue("@yds", config.IsNull(.Item(i)("yds"), 0))
				comm.Parameters.AddWithValue("@sono", config.IsNull(.Item(i)("sono"), "").Trim)
				comm.Parameters.AddWithValue("@nob", config.IsNull(.Item(i)("nob"), 0).ToString)
				comm.Parameters.AddWithValue("@typ", config.IsNull(.Item(i)("typ"), "").Trim)
				comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), "").Trim)
				comm.Parameters.AddWithValue("@outreqno", config.IsNull(.Item(i)("outreqno"), "").Trim)
				comm.Parameters.AddWithValue("@outreqdt", CDate(config.IsNull(.Item(i)("outreqdt2"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@mts_g", config.IsNull(.Item(i)("mts_g"), 0))
				comm.Parameters.AddWithValue("@yds_g", config.IsNull(.Item(i)("yds_g"), 0))
				comm.Parameters.AddWithValue("@allowmt", config.IsNull(.Item(i)("allowmt"), 0))
				comm.Parameters.AddWithValue("@sonoid", config.IsNull(.Item(i)("sonoid"), "").Trim)
				comm.Parameters.AddWithValue("@lotbatno", config.IsNull(.Item(i)("lotbatno"), "").Trim)
				comm.Parameters.AddWithValue("@sel", IIf(CBool(config.IsNull(.Item(i)("sel"), False)), 1, 0))
				comm.Parameters.AddWithValue("@loc", config.IsNull(.Item(i)("loc"), "").Trim)
				comm.Parameters.AddWithValue("@cost", config.IsNull(.Item(i)("cost"), 0))
				comm.Parameters.AddWithValue("@batch", config.IsNull(.Item(i)("batch"), "").Trim)
				comm.Parameters.AddWithValue("@custcolor", config.IsNull(.Item(i)("custcolor"), "").Trim)
				comm.Parameters.AddWithValue("@fload", IIf(CBool(config.IsNull(.Item(i)("fload"), False)), 1, 0))
				comm.Parameters.AddWithValue("@dinno1", config.IsNull(.Item(i)("dinno1"), "").Trim)
				comm.Parameters.AddWithValue("@dinnot", config.IsNull(.Item(i)("dinnot"), "").Trim)
				comm.Parameters.AddWithValue("@cost_d", config.IsNull(.Item(i)("cost_d"), 0))
				comm.Parameters.AddWithValue("@remark", SINH.h06_remark)
				comm.Parameters.AddWithValue("@outtyp", SINH.h08_outtyp)
				comm.Parameters.AddWithValue("@log_empcd", SINH.h07_log_empcd)
			End With

			Dim sql As String = config.BuildSQL(comm)
			Debug.Print(sql)

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
		comm.CommandText = "p_stock_s_del"

		For i = 0 To SIND_DEL.Count - 1
			With SIND_DEL(i)
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@roll_no_d", config.IsNull(.Item("roll_no_d"), "").ToString.Trim)
				comm.Parameters.AddWithValue("@log_empcd", SINH.h07_log_empcd)
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

    Public Function GetRollLocation(ByVal trn_id As Long, ByVal trn_no As String, ByVal roll_no_g As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_location_by_roll"
        comm.Parameters.AddWithValue("@trn_id", trn_id)
        comm.Parameters.AddWithValue("@trn_no", trn_no)
        comm.Parameters.AddWithValue("@roll_no_g", roll_no_g)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetGreigeStatus() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_status_select"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function GetTrnNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_transfer_select"
        comm.Parameters.AddWithValue("@trn_no", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetTrnDet(ByVal trn_no As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_transfer_det_select"
        comm.Parameters.AddWithValue("@trn_no", trn_no)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function TrnSave(ByVal TrnH As TrnHeader, ByVal TrnD_ADD As DataView, ByVal TrnD_UPD As DataView, ByVal TrnD_DEL As DataView, ByRef msgerr As String, ByRef trn_id As Long) As Boolean
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim i As Integer = 0

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_transfer_update"

        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@trn_id", TrnH.h01_trn_id)
        comm.Parameters.AddWithValue("@new_location", TrnH.h05_new_location)
        comm.Parameters.AddWithValue("@new_sub_location", TrnH.h06_new_sub_location)
        comm.Parameters.AddWithValue("@loginempcd", TrnH.h07_login_empcd)

        Dim xxx As String = config.BuildSQL(comm)
        Debug.Print(xxx)

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
        trn_id = dt.Rows(0)("trn_id")


        'Add Detail----------

        comm.CommandText = "p_greige_transfer_det_update"

        For i = 0 To TrnD_ADD.Count - 1
            With TrnD_ADD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", 0)
                comm.Parameters.AddWithValue("@trn_id", trn_id)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), ""))
                comm.Parameters.AddWithValue("@location", config.IsNull(.Item(i)("location"), ""))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
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

        'Update Detail----------

        i = 0
        comm.CommandText = "p_greige_transfer_det_update"

        For i = 0 To TrnD_UPD.Count - 1
            With TrnD_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", config.IsNull(.Item(i)("det_id"), 0))
                comm.Parameters.AddWithValue("@trn_id", trn_id)
                comm.Parameters.AddWithValue("@roll_no_g", config.IsNull(.Item(i)("roll_no_g"), ""))
                comm.Parameters.AddWithValue("@location", config.IsNull(.Item(i)("location"), ""))
                comm.Parameters.AddWithValue("@sub_location", config.IsNull(.Item(i)("sub_location"), ""))
                comm.Parameters.AddWithValue("@status", config.IsNull(.Item(i)("status"), 0))
                comm.Parameters.AddWithValue("@new_status", config.IsNull(.Item(i)("new_status"), 0))
            End With

            Dim sql As String = config.BuildSQL(comm)
            Debug.Print(sql)

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
        comm.CommandText = "p_greige_transfer_det_delete"

        For i = 0 To TrnD_DEL.Count - 1
            With TrnD_DEL(i)
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@det_id", config.IsNull(.Item("det_id"), 0))
                comm.Parameters.AddWithValue("@log_empcd", TrnH.h07_login_empcd)
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

    Public Function TrnDelete(ByVal trn_id As Long, ByVal loginempcd As String)
        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Dim i As Integer = 0

        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_transfer_delete"

        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@trn_id", trn_id)
        comm.Parameters.AddWithValue("@loginempcd", loginempcd)

        Dim xxx As String = config.BuildSQL(comm)
        Debug.Print(xxx)

        da = New SqlDataAdapter(comm)
        dt = New DataTable
        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        Return True
    End Function

    Public Function GetRollDetails(strRollNo As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_roll_no"
        comm.Parameters.AddWithValue("@trn_no", "")
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function GetDINNo() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_din_no"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function
    Public Function GetDIN(ByVal strBillNo As String, ByVal strEmpCode As String, ByRef Strerror As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.Transaction = tran

        comm.CommandTimeout = 600

        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_select_by_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Strerror = ex.Message
            tran.Rollback()
            comm.Connection.Close()
            Return dt
        End Try
        tran.Commit()
        comm.Connection.Close()
        Return dt
        'Dim conn As New SqlConnection((New classConnection).connection)
        'Dim comm As New SqlCommand("", conn)
        'comm.CommandType = CommandType.StoredProcedure
        'comm.CommandText = "p_strolls_d_select_by_gamma"
        'comm.Parameters.AddWithValue("@bill_no", strBillNo)
        'comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        'Dim da As New SqlDataAdapter(comm)
        'Dim dt As New DataTable
        'da.Fill(dt)
        'Return dt
    End Function

    Public Function SaveDIN(ByVal dtc As DataTable, ByVal strBillNo As String, ByVal strEmpCode As String, Optional ByVal StrLoc As String = "",
                             Optional ByVal Strolls_DHeader As Strolls_DHeader = Nothing, Optional ByRef StrMessage As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran

        comm.CommandText = "p_strolls_d_update_by_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        comm.Parameters.AddWithValue("@loc", StrLoc)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Strolls_DHeader.h56_mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Strolls_DHeader.h58_mtl_subinventory_id)
        comm.Parameters.AddWithValue("@mtl_locations_id", Strolls_DHeader.h57_mtl_locations_id)
        comm.CommandTimeout = 360
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            StrMessage = ex.Message
            tran.Rollback()
            conn.Close()
            Return dt
        End Try

        tran.Commit()
        conn.Close()
        Return dt
    End Function
    'Public Function SaveDIN(ByVal strBillNo As String, ByVal strEmpCode As String) As DataTable
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    conn.Open()
    '    Dim tran As SqlTransaction = conn.BeginTransaction
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.Transaction = tran

    '    comm.CommandText = "p_strolls_d_update_by_gamma"
    '    comm.Parameters.AddWithValue("@bill_no", strBillNo)
    '    comm.Parameters.AddWithValue("@logempcd", strEmpCode)
    '    comm.CommandTimeout = 360
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    Try
    '        da.Fill(dt)
    '    Catch ex As Exception
    '        'msgerr = ex.Message
    '        tran.Rollback()
    '        conn.Close()
    '        Return dt
    '    End Try

    '    tran.Commit()
    '    conn.Close()
    '    Return dt
    'End Function
    Public Function CancelDIN(ByVal strDINNo As String, ByVal strEmpCode As String, ByRef message As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.Connection.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_strolls_d_cancel"
        comm.Parameters.AddWithValue("@dinno", strDINNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        'comm.Connection.Open()
        'comm.ExecuteNonQuery()
        'comm.Connection.Close()
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            message = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Public Function GetGINNoPFD() As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_combo_gin_no_pfd"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
    End Function

    Public Function CancelGIN(ByVal strGINNo As String, ByVal Dtptran_dt As Nullable(Of DateTime), ByVal strEmpCode As String, ByRef Strmessage As String) As Boolean
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.Connection.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_greige_in_cancel"
        comm.Parameters.AddWithValue("@tran_no", strGINNo)
        comm.Parameters.AddWithValue("@tran_dt", Dtptran_dt)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Strmessage = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try

        tran.Commit()
        conn.Close()
        Return True
    End Function

    Public Function GetGINPDF(ByVal strBillNo As String, ByVal strEmpCode As String, ByRef Strmsgerr As String) As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran

        comm.CommandText = "P_GREIGE_IN_PFD_GAMMA_PKG_select_greige_from_gamma"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            Strmsgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return dt
        End Try
        tran.Commit()
        conn.Close()
        Return dt
    End Function
    'Public Function GetGINPDF(ByVal strBillNo As String, ByVal strEmpCode As String, ByRef Strmsgerr As String) As DataTable
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    conn.Open()
    '    Dim tran As SqlTransaction = conn.BeginTransaction
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.Transaction = tran

    '    comm.CommandText = "p_greige_select_by_gamma"
    '    comm.Parameters.AddWithValue("@bill_no", strBillNo)
    '    comm.Parameters.AddWithValue("@logempcd", strEmpCode)
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    Try
    '        da.Fill(dt)
    '    Catch ex As Exception
    '        Strmsgerr = ex.Message
    '        tran.Rollback()
    '        conn.Close()
    '        Return dt
    '    End Try
    '    tran.Commit()
    '    conn.Close()
    '    Return dt
    'End Function

    Public Function SaveGINPFD(ByVal strBillNo As String, ByVal strEmpCode As String, Optional ByVal StrLoc As String = "", Optional ByVal Int64mtl_warehouse_id As Int64 = Nothing, Optional ByVal Int64mtl_locations_id As Int64 = Nothing, Optional ByVal Int64mtl_subinventory_id As Int64 = Nothing, Optional ByRef StrMessage As String = "") As DataTable
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)

        comm.CommandType = CommandType.StoredProcedure
        comm.Transaction = tran
        comm.CommandText = "P_GREIGE_IN_PFD_GAMMA_PKG_update_greige"
        comm.Parameters.AddWithValue("@bill_no", strBillNo)
        comm.Parameters.AddWithValue("@logempcd", strEmpCode)
        comm.Parameters.AddWithValue("@loc", StrLoc)
        comm.Parameters.AddWithValue("@mtl_warehouse_id", Int64mtl_warehouse_id)
        comm.Parameters.AddWithValue("@mtl_locations_id", Int64mtl_locations_id)
        comm.Parameters.AddWithValue("@mtl_subinventory_id", Int64mtl_subinventory_id)
        comm.CommandTimeout = 360
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        Try
            da.Fill(dt)
        Catch ex As Exception
            StrMessage = ex.Message
            tran.Rollback()
            conn.Close()
            Return dt
        End Try

        tran.Commit()
        conn.Close()
        Return dt
    End Function
    'Public Function SaveGINPFD(ByVal strBillNo As String, ByVal strEmpCode As String, ByRef Strmsgerr As String) As DataTable
    '    Dim conn As New SqlConnection((New classConnection).connection)
    '    conn.Open()
    '    Dim tran As SqlTransaction = conn.BeginTransaction
    '    Dim comm As New SqlCommand("", conn)
    '    comm.CommandType = CommandType.StoredProcedure
    '    comm.Transaction = tran

    '    comm.CommandText = "p_greige_update_by_gamma"
    '    comm.Parameters.AddWithValue("@bill_no", strBillNo)
    '    comm.Parameters.AddWithValue("@logempcd", strEmpCode)
    '    comm.CommandTimeout = 360
    '    Dim da As New SqlDataAdapter(comm)
    '    Dim dt As New DataTable
    '    Try
    '        da.Fill(dt)
    '    Catch ex As Exception
    '        Strmsgerr = ex.Message
    '        tran.Rollback()
    '        conn.Close()
    '        Return dt
    '    End Try
    '    tran.Commit()
    '    conn.Close()
    '    Return dt
    'End Function

    Public Function getGInTranType() As DataTable
        'Writhe By   : Sitthana Boonlom
        'Writen Date : 21/02/2024

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_IN_PKG_get_tran_type"

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()
        Return dt
    End Function

    Public Function getDistinctTransNo(pTranType As String, pDateFrom As String, pDateTo As String) As DataTable
        'Writhe By   : Sitthana Boonlom
        'Writen Date : 21/02/2024

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_IN_PKG_select_distinct_trans_no"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@pTranType", pTranType)
        comm.Parameters.AddWithValue("@pDateFrom", pDateFrom)
        comm.Parameters.AddWithValue("@pDateTo", pDateTo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()
        Return dt
    End Function

    Public Function getRollsOfGin(pTranType As String, pDateFrom As String, pDateTo As String) As DataTable
        'Writhe By   : Sitthana Boonlom
        'Writen Date : 21/02/2024

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_IN_PKG_select_rolls"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@pTranType", pTranType)
        comm.Parameters.AddWithValue("@pDateFrom", pDateFrom)
        comm.Parameters.AddWithValue("@pDateTo", pDateTo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()
        Return dt
    End Function

    Public Function getGInByTranNo(pTranNo As String) As DataTable
        'Writhe By   : Sitthana Boonlom
        'Writen Date : 21/02/2024

        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "P_GREIGE_IN_PKG_select_gin_by_tran_no"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@pTranNo", pTranNo)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)

        conn.Close()
        Return dt
    End Function

    Public Function GInSaveQcRemark(ByRef msgerr As String, ByVal dfr As DataTable, ByVal DV_DTC_UPD As DataView, ByRef UserID As String, ByRef pTranNo As String) As Boolean
        'Write By : Sitthana 20240221 
        'modify from old another code

        Dim config As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        conn.Open()
        Dim tran As SqlTransaction = conn.BeginTransaction
        Dim comm As New SqlCommand("", conn)
        'Dim i As Integer = 0
        Dim j As Integer = 0
        'Dim strLotNo As String = ""
        'Dim strRoll_no_o As String = ""
        Dim Action As String = ""


        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure


        'Start update Cartons----------

        comm.CommandText = "P_GREIGE_IN_PKG_update_qc_remark"
        j = 0
        For j = 0 To DV_DTC_UPD.Count - 1
            With DV_DTC_UPD
                comm.Parameters.Clear()
                comm.Parameters.AddWithValue("@pIdGreige", .Item(j)("id_greige"))
                comm.Parameters.AddWithValue("@pRemQc", config.IsNull(.Item(j)("rem_qc"), "").trim)
            End With

            Dim dac_upd = New SqlDataAdapter(comm)
            Dim dtc_upd = New DataTable
            Try
                dac_upd.Fill(dtc_upd)
            Catch ex As Exception
                msgerr = ex.Message
                tran.Rollback()
                conn.Close()
                Return False
            End Try
            Action = "CHANGE"
        Next
        'End update Cartons----------

        'Start Insert Action----------
        If Action = "" Then Action = "CHANGE"
        comm.CommandText = "sp_insert_ACTION"
        j = 0
        Dim doctyp As String = "QCRem"
        comm.Parameters.Clear()
        comm.Parameters.AddWithValue("@empcd", UserID.Trim)
        comm.Parameters.AddWithValue("@docno", pTranNo)
        comm.Parameters.AddWithValue("@workdt", Now)
        comm.Parameters.AddWithValue("@doctyp", doctyp)
        comm.Parameters.AddWithValue("@worktyp", Action)

        'Dim sql As String = config.BuildSQL(comm)
        Dim da_sp = New SqlDataAdapter(comm)
        Dim dt_sp = New DataTable
        Try
            da_sp.Fill(dt_sp)
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()
            Return False
        End Try
        'End Insert Action----------

        tran.Commit()
        conn.Close()
        Return True
    End Function
End Class
