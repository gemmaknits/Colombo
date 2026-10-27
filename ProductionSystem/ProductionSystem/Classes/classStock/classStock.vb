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
        conn.Close()  'Sitthana 20190325
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
End Class
