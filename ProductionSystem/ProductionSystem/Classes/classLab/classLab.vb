Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class classLab
	Public Structure LabHeader
		Dim h01_labno As String
		Dim h02_design_no As String
		Dim h03_plights As String
		Dim h04_slights As String
		Dim h05_remark As String
		Dim h06_specu As Boolean
		Dim h07_speck As Boolean
		Dim h08_method As String
		Dim h09_labdt As Date
		Dim h10_delidt As Date
		Dim h11_attn As String
		Dim h12_dhcod As String
		Dim h13_sample As Boolean
		Dim h14_appr As Boolean
		Dim h15_azo As Boolean
		Dim h16_ph As Boolean
		Dim h17_gwth As String
		Dim h18_dmethodcd As String
		Dim h19_diff As String
		Dim h20_empcd As String
		Dim h21_issuedt As Date
		Dim h22_std_lay As String
		Dim h23_sam_lay As String
		Dim h24_arrivedt As Date
		Dim h25_cancel_status As Boolean
	End Structure

	Public Function GetLabNo(Optional ByVal strLabNo As String = "", Optional ByVal strDateFr As String = "", Optional ByVal strDateTo As String = "", Optional ByVal strDHCod As String = "") As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_select"
		comm.Parameters.AddWithValue("@labno", strLabNo)
		comm.Parameters.AddWithValue("@datefr", strDateFr)
		comm.Parameters.AddWithValue("@dateto", strDateTo)
		comm.Parameters.AddWithValue("@dhcod", strDHCod)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function LabDetLoad(ByVal strLabNo As String) As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_detail_select"
		comm.Parameters.AddWithValue("@labno", strLabNo)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function LabResultLoad(ByVal lngLabDetID As Long) As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_result_select"
		comm.Parameters.AddWithValue("@id_labdet", lngLabDetID)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function LabApvSheetLoad(ByVal lngLabDetID As Long, ByVal lngSheetID As Long) As DataTable
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_approval_sheet_select"
		comm.Parameters.AddWithValue("@id_labdet", lngLabDetID)
		comm.Parameters.AddWithValue("@sheet_id", lngSheetID)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()  'Sitthana 20190325
        Return dt
	End Function

	Public Function LabSave(ByVal LABH As LabHeader, ByVal LABD_ADD As DataView, ByVal LABD_UPD As DataView, ByVal LABD_DEL As DataView, ByRef msgerr As String, ByRef labno As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_update"
		With LABH
			comm.Parameters.AddWithValue("@labno", .h01_labno.Trim)
			comm.Parameters.AddWithValue("@design_no", .h02_design_no.Trim)
			comm.Parameters.AddWithValue("@plights", .h03_plights.Trim)
			comm.Parameters.AddWithValue("@slights", .h04_slights.Trim)
			comm.Parameters.AddWithValue("@remark", .h05_remark.Trim)
			comm.Parameters.AddWithValue("@specu", IIf(.h06_specu, 1, 0))
			comm.Parameters.AddWithValue("@speck", IIf(.h07_speck, 1, 0))
			comm.Parameters.AddWithValue("@method", .h08_method.Trim)
			comm.Parameters.AddWithValue("@labdt", .h09_labdt.ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@delidt", .h10_delidt.ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@attn", .h11_attn.Trim)
			comm.Parameters.AddWithValue("@dhcod", .h12_dhcod.Trim)
			comm.Parameters.AddWithValue("@sample", IIf(.h13_sample, 1, 0))
			comm.Parameters.AddWithValue("@appr", IIf(.h14_appr, 1, 0))
			comm.Parameters.AddWithValue("@azo", IIf(.h15_azo, 1, 0))
			comm.Parameters.AddWithValue("@ph", IIf(.h16_ph, 1, 0))
			comm.Parameters.AddWithValue("@gwth", .h17_gwth.Trim)
			comm.Parameters.AddWithValue("@dmethodcd", .h18_dmethodcd.Trim)
			comm.Parameters.AddWithValue("@diff", .h19_diff.Trim)
			comm.Parameters.AddWithValue("@empcd", .h20_empcd.Trim)
			comm.Parameters.AddWithValue("@issuedt", .h21_issuedt.ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@std_lay", .h22_std_lay.Trim)
			comm.Parameters.AddWithValue("@sam_lay", .h23_sam_lay.Trim)
			comm.Parameters.AddWithValue("@arrivedt", .h24_arrivedt.ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@cancel_status", IIf(.h25_cancel_status, 1, 0))
		End With

		'Dim xxx As String = config.BuildSQL(comm)
		'xxx = xxx

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
		labno = dt.Rows(0)("labno").ToString

		'Add Detail----------

		i = 0
		comm.CommandText = "p_lab_detail_update"

		For i = 0 To LABD_ADD.Count - 1
			With LABD_ADD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@labno", labno)
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
				comm.Parameters.AddWithValue("@onet", config.IsNull(.Item(i)("onet"), False))
				comm.Parameters.AddWithValue("@twot", config.IsNull(.Item(i)("twot"), False))
				comm.Parameters.AddWithValue("@nyon", config.IsNull(.Item(i)("nyon"), "").Trim)
				comm.Parameters.AddWithValue("@rayon", config.IsNull(.Item(i)("rayon"), "").Trim)
				comm.Parameters.AddWithValue("@poly", config.IsNull(.Item(i)("poly"), "").Trim)
				comm.Parameters.AddWithValue("@net", config.IsNull(.Item(i)("net"), False))
				comm.Parameters.AddWithValue("@yarn", config.IsNull(.Item(i)("yarn"), False))
				comm.Parameters.AddWithValue("@plies", config.IsNull(.Item(i)("plies"), "").Trim)
				comm.Parameters.AddWithValue("@ltime", config.IsNull(.Item(i)("ltime"), "").Trim)
				comm.Parameters.AddWithValue("@remark", config.IsNull(.Item(i)("remark_det"), "").Trim)
				comm.Parameters.AddWithValue("@treet", config.IsNull(.Item(i)("treet"), False))
				comm.Parameters.AddWithValue("@arrivedt", CDate(config.IsNull(.Item(i)("arrivedt"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@sen2custdt", CDate(config.IsNull(.Item(i)("sen2custdt"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@custconfdt", CDate(config.IsNull(.Item(i)("custconfdt"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@custrem", config.IsNull(.Item(i)("custrem"), "").Trim)
				comm.Parameters.AddWithValue("@id_labdet", 0)
				comm.Parameters.AddWithValue("@log_empcd", LABH.h20_empcd.Trim)
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
		comm.CommandText = "p_lab_detail_update"

		For i = 0 To LABD_UPD.Count - 1
			With LABD_UPD
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@labno", labno)
				comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
				comm.Parameters.AddWithValue("@onet", config.IsNull(.Item(i)("onet"), False))
				comm.Parameters.AddWithValue("@twot", config.IsNull(.Item(i)("twot"), False))
				comm.Parameters.AddWithValue("@nyon", config.IsNull(.Item(i)("nyon"), "").Trim)
				comm.Parameters.AddWithValue("@rayon", config.IsNull(.Item(i)("rayon"), "").Trim)
				comm.Parameters.AddWithValue("@poly", config.IsNull(.Item(i)("poly"), "").Trim)
				comm.Parameters.AddWithValue("@net", config.IsNull(.Item(i)("net"), False))
				comm.Parameters.AddWithValue("@yarn", config.IsNull(.Item(i)("yarn"), False))
				comm.Parameters.AddWithValue("@plies", config.IsNull(.Item(i)("plies"), "").Trim)
				comm.Parameters.AddWithValue("@ltime", config.IsNull(.Item(i)("ltime"), "").Trim)
				comm.Parameters.AddWithValue("@remark", config.IsNull(.Item(i)("remark_det"), "").Trim)
				comm.Parameters.AddWithValue("@treet", config.IsNull(.Item(i)("treet"), False))
				comm.Parameters.AddWithValue("@arrivedt", CDate(config.IsNull(.Item(i)("arrivedt"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@sen2custdt", CDate(config.IsNull(.Item(i)("sen2custdt"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@custconfdt", CDate(config.IsNull(.Item(i)("custconfdt"), "01/01/1900")).ToString("yyyyMMdd"))
				comm.Parameters.AddWithValue("@custrem", config.IsNull(.Item(i)("custrem"), "").Trim)
				comm.Parameters.AddWithValue("@id_labdet", config.IsNull(.Item(i)("id_labdet"), 0))
				comm.Parameters.AddWithValue("@log_empcd", LABH.h20_empcd.Trim)
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
		comm.CommandText = "p_lab_detail_delete"

		For i = 0 To LABD_DEL.Count - 1
			With LABD_DEL(i)
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@id_labdet", config.IsNull(.Item("id_labdet"), 0))
				comm.Parameters.AddWithValue("@log_empcd", LABH.h20_empcd)
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

	Public Function LabCancel(ByVal strLabNo As String, ByVal strEmpCD As String) As Boolean
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_cancel"
		comm.Parameters.AddWithValue("@labno", strLabNo)
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

	Public Function LabClose(ByVal dt As DataTable, ByRef msgerr As String, ByVal strEmpCD As String) As Boolean
		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_close"
		For i = 0 To dt.Rows.Count - 1
			If config.IsNull(dt.Rows(i)("id_labdet"), 0) > 0 Then
				comm.Parameters.Clear()
				With dt.Rows(i)
					'comm.Parameters.AddWithValue("@labno", config.IsNull(.Item(i)("labno"), "").Trim)
					'comm.Parameters.AddWithValue("@col", config.IsNull(.Item(i)("col"), "").Trim)
					comm.Parameters.AddWithValue("@labrcdt", CDate(config.IsNull(.Item("labrcdt2"), "01/01/1900")).ToString("yyyyMMdd"))
					comm.Parameters.AddWithValue("@custreplydt", CDate(config.IsNull(.Item("custreplydt2"), "01/01/1900")).ToString("yyyyMMdd"))
					comm.Parameters.AddWithValue("@custcomment", config.IsNull(.Item("custcomment"), "").Trim)
					comm.Parameters.AddWithValue("@shadeapproved", config.IsNull(.Item("shadeapproved"), "").Trim)
					comm.Parameters.AddWithValue("@labok", IIf(config.IsNull(.Item("labok"), False), 1, 0))
					comm.Parameters.AddWithValue("@labnotok", IIf(config.IsNull(.Item("labnotok"), False), 1, 0))
					comm.Parameters.AddWithValue("@labclosed", IIf(config.IsNull(.Item("labclosed"), False), 1, 0))
					'comm.Parameters.AddWithValue("@labstamp", config.IsNull(.Item("labstamp"), 0))
					comm.Parameters.AddWithValue("@id_labdet", config.IsNull(.Item("id_labdet"), 0))
				End With
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

	Public Function LabApvSheetSave( _
		ByRef sheet_id As Long, _
		ByVal sheet_date As String, _
		ByVal labno As String, _
		ByVal id_labdet As Long, _
		ByVal design_no As String, _
		ByVal col As String, _
		ByVal sonoid As String, _
		ByVal custcd As String, _
		ByVal attn As String, _
		ByVal lotno As String, _
		ByVal lot_qty As Double, _
		ByVal lot_uom As String, _
		ByVal batch As String, _
		ByVal batch_qty As Double, _
		ByVal batch_uom As String, _
		ByVal result_labdip As Boolean, _
		ByVal result_shiping As Boolean, _
		ByVal result_finishing As Boolean, _
		ByVal remark As String, _
		ByVal shade1 As String, _
		ByVal shade2 As String, _
		ByVal cancel_status As Boolean, _
		ByVal owner_id As String, _
		ByRef msgerr As String) As Boolean

		Dim config As New clsConfig
		Dim conn As New SqlConnection((New classConnection).connection)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim comm As New SqlCommand("", conn)
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_lab_approval_sheet_update"
		comm.Parameters.Clear()
		comm.Parameters.AddWithValue("@sheet_id", sheet_id)
		comm.Parameters.AddWithValue("@sheet_date", sheet_date.Trim)
		comm.Parameters.AddWithValue("@labno", labno.Trim)
		comm.Parameters.AddWithValue("@id_labdet", id_labdet)
		comm.Parameters.AddWithValue("@design_no", design_no.Trim)
		comm.Parameters.AddWithValue("@col", col.Trim)
		comm.Parameters.AddWithValue("@sonoid", sonoid.Trim)
		comm.Parameters.AddWithValue("@custcd", custcd.Trim)
		comm.Parameters.AddWithValue("@attn", attn.Trim)
		comm.Parameters.AddWithValue("@lotno", lotno.Trim)
		comm.Parameters.AddWithValue("@lot_qty", lot_qty.ToString)
		comm.Parameters.AddWithValue("@lot_uom", lot_uom.Trim)
		comm.Parameters.AddWithValue("@batch", batch.Trim)
		comm.Parameters.AddWithValue("@batch_qty", batch_qty.ToString)
		comm.Parameters.AddWithValue("@batch_uom", batch_uom.Trim)
		comm.Parameters.AddWithValue("@result_labdip", IIf(result_labdip, 1, 0))
		comm.Parameters.AddWithValue("@result_shiping", IIf(result_shiping, 1, 0))
		comm.Parameters.AddWithValue("@result_finishing", IIf(result_finishing, 1, 0))
		comm.Parameters.AddWithValue("@remark", remark.Trim)
		comm.Parameters.AddWithValue("@shade1", shade1.Trim)
		comm.Parameters.AddWithValue("@shade2", shade2.Trim)
		comm.Parameters.AddWithValue("@cancel_status", IIf(cancel_status, 1, 0))
		comm.Parameters.AddWithValue("@owner_id", owner_id.Trim)

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
		If dt.Rows.Count > 0 Then sheet_id = dt.Rows(0)("sheet_id")
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
	End Function
End Class
