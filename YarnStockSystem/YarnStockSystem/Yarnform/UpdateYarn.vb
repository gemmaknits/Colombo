Imports System.Text
Imports System.Data.SqlClient
Imports System.Data

Public Class UpdateYarn
	Private connStr As New classConnection

	Public Function UpdateYarnIn(ByVal Param_YarnIn As tbl_Yarn_in, ByVal dt_Yarn_in_det As DataTable, ByRef Msgerr As String, ByVal da As SqlDataAdapter, ByVal loginEmpcd As String) As Boolean
		Dim deletedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.Deleted)
		Dim modifiedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.ModifiedCurrent)
        Dim addedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.Added)

		Dim conn As New SqlConnection(connStr.connection())
		conn.Open()

		Dim comm As New SqlCommand("", conn)
		Dim tran As SqlTransaction = conn.BeginTransaction
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_yarn_in_update"
		With Param_YarnIn
			comm.Parameters.AddWithValue("@docdt", CDate(.docdt))
			comm.Parameters.AddWithValue("@docno", .docno.Trim)
			comm.Parameters.AddWithValue("@purno", .purno.Trim)
			comm.Parameters.AddWithValue("@sinvno", .sinvno.Trim)
			comm.Parameters.AddWithValue("@sinvdt", .sinvdt.Trim)
			comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
			comm.Parameters.AddWithValue("@lotno_sup", .lotno_sup.Trim)
			comm.Parameters.AddWithValue("@srefno", .srefno.Trim)
			comm.Parameters.AddWithValue("@outno", .outno.Trim)
			comm.Parameters.AddWithValue("@remark", .remark.Trim)
			comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
        End With
        Dim da2 As New SqlDataAdapter(comm)
        Dim dt As New DataTable

		Try
            da2.Fill(dt)
            'MsgBox(dt.Rows(0)("suppcd"))
		Catch ex As Exception
			Msgerr = ex.Message
			tran.Rollback()
			Return False
		End Try

		REM delete old record ------------------------------

		Dim i As Integer = 0

		If deletedDetRecs.Count > 0 Then
			For i = 0 To deletedDetRecs.Count - 1
				comm.Parameters.Clear()
				comm.CommandText = "p_yarn_in_det_delete"
                'comm.Transaction = tran
				comm.Parameters.AddWithValue("@docno", Param_YarnIn.docno.Trim)
				comm.Parameters.AddWithValue("@boxno", deletedDetRecs.Item(i)("boxno").ToString.Trim)
				comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)
				da2 = New SqlDataAdapter(comm)
				dt = New DataTable

				Try
					da2.Fill(dt)
				Catch ex As Exception
					Msgerr = ex.Message
					tran.Rollback()
					Return False
				End Try
			Next
		End If

		REM update old record ------------------------------

		i = 0

		If modifiedDetRecs.Count > 0 Then
			For i = 0 To modifiedDetRecs.Count - 1
				comm.Parameters.Clear()
				comm.CommandText = "p_yarn_in_det_update"
                '			comm.Transaction = tran
				With modifiedDetRecs
					comm.Parameters.AddWithValue("@docno", .Item(i)("docno").Trim)
					comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
					comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s").Trim)
					comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
					comm.Parameters.AddWithValue("@spools", .Item(i)("spools").ToString)
					comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
					comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr").ToString)
					comm.Parameters.AddWithValue("@cart_tearwt", .Item(i)("cart_tearwt").ToString)
					comm.Parameters.AddWithValue("@spool_tearwt", .Item(i)("spool_tearwt").ToString)
					comm.Parameters.AddWithValue("@kg_nt", .Item(i)("kg_nt").ToString)
					comm.Parameters.AddWithValue("@id_jobdet", .Item(i)("id_jobdet").ToString)
					'comm.Parameters.AddWithValue("@lotno_our", .Item(i)("lotno_our").ToString)
					'comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
				End With
				da2 = New SqlDataAdapter(comm)
				dt = New DataTable

				Try
					da2.Fill(dt)
				Catch ex As Exception
					Msgerr = ex.Message
					tran.Rollback()
					Return False
				End Try
			Next
		End If

		REM insert new record ------------------------------

		i = 0

		If addedDetRecs.Count > 0 Then
			For i = 0 To addedDetRecs.Count - 1
				comm.Parameters.Clear()
				comm.CommandText = "p_yarn_in_det_insert"
				'comm.Transaction = tran
				With addedDetRecs
					comm.Parameters.AddWithValue("@docno", .Item(i)("docno").Trim)
					comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
					comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s").Trim)
					comm.Parameters.AddWithValue("@spools", Val(.Item(i)("spools").ToString))
					comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
					comm.Parameters.AddWithValue("@kg_gr", Val(.Item(i)("kg_gr").ToString))
					comm.Parameters.AddWithValue("@cart_tearwt", Val(.Item(i)("cart_tearwt").ToString))
					comm.Parameters.AddWithValue("@spool_tearwt", Val(.Item(i)("spool_tearwt").ToString))
					comm.Parameters.AddWithValue("@kg_nt", Val(.Item(i)("kg_nt").ToString))
					comm.Parameters.AddWithValue("@id_jobdet", Val(.Item(i)("id_jobdet").ToString))
					comm.Parameters.AddWithValue("@log_empcd", loginEmpcd)
				End With
				da2 = New SqlDataAdapter(comm)
				dt = New DataTable

				Try
					da2.Fill(dt)
				Catch ex As Exception
					Msgerr = ex.Message
					tran.Rollback()
					Return False
				End Try
			Next
		End If
		tran.Commit()
		Return True
	End Function

	Public Function UpdateYarnOut(ByVal param_tbl_yarn_out As tbl_Yarn_out, ByVal dt_yarn_out_det As DataTable, ByRef msgerr As String, ByVal loginEmpcd As String, ByVal refDocnoChanged As Boolean) As Boolean
		Dim deletedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.Deleted)
		Dim modifiedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.ModifiedCurrent)
		Dim addedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.Added)
		If deletedDetRecs.Count = 0 And modifiedDetRecs.Count = 0 And addedDetRecs.Count = 0 Then
			msgerr = "No changes were found to update"
			Return False
		End If

		Dim conn As New SqlConnection(connStr.connection())
		conn.Open()

		Dim comm As New SqlCommand("", conn)
		Dim tran As SqlTransaction = conn.BeginTransaction
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_yarn_out_update"
		With param_tbl_yarn_out
			comm.Parameters.AddWithValue("@outno", .outno.Trim)
			'comm.Parameters.AddWithValue("@outdt", .outdt.ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@tran_type", .tran_type.Trim)
			comm.Parameters.AddWithValue("@refdocno", .refdocno.Trim)
			comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
			comm.Parameters.AddWithValue("@kono", .kono.Trim)
			comm.Parameters.AddWithValue("@rem", .remm.Trim)
			comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
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

		REM delete old record ------------------------------

		Dim i As Integer = 0

		If deletedDetRecs.Count > 0 Then
			For i = 0 To deletedDetRecs.Count - 1
				comm.Transaction = tran
				comm.CommandText = "p_yarn_out_det_delete"
				comm.Parameters.Clear()

				comm.Parameters.AddWithValue("@id_yarn_out_det", deletedDetRecs.Item(i)("id_yarn_out_det").ToString)
				comm.Parameters.AddWithValue("@outno", param_tbl_yarn_out.outno.Trim)
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
		End If

		REM update old record ------------------------------

		i = 0

		If modifiedDetRecs.Count > 0 Then
			For i = 0 To modifiedDetRecs.Count - 1
				comm.CommandType = CommandType.StoredProcedure
				comm.Transaction = tran
				comm.CommandText = "p_yarn_out_det_update"
				comm.Parameters.Clear()
				With modifiedDetRecs
					comm.Parameters.AddWithValue("@outno", param_tbl_yarn_out.outno.Trim)
					comm.Parameters.AddWithValue("@id_yarn_out_det", .Item(i)("id_yarn_out_det").ToString)
					comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
					comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
					comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
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
		End If

		REM insert new record ------------------------------

		i = 0

		If addedDetRecs.Count > 0 Then
			For i = 0 To addedDetRecs.Count - 1
				comm.CommandType = CommandType.StoredProcedure
				comm.Transaction = tran
				comm.CommandText = "p_yarn_out_det_insert"
				comm.Parameters.Clear()
				With addedDetRecs
					comm.Parameters.AddWithValue("@outno", param_tbl_yarn_out.outno.Trim)
					comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
					comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
					comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
					'comm.Parameters.AddWithValue("@id_job_det_yarn", ("id_job_det_yarn").ToString)
					comm.Parameters.AddWithValue("@id_job_det_yarn", 0)
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
		End If
		tran.Commit()
		Return True
	End Function

	Public Function cancelYarnin(ByVal Docno As String, ByVal loginEmpcd As String, ByRef Msgerr As String)
		Dim conn As New SqlConnection(connStr.connection())
		conn.Open()

		Dim comm As New SqlCommand("", conn)
		Dim tran As SqlTransaction = conn.BeginTransaction
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_yarn_in_cancel"
		comm.Parameters.AddWithValue("@docno", Docno.Trim)
		comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		Try
			da.Fill(dt)
		Catch ex As Exception
			Msgerr = ex.Message
			tran.Rollback()
			Return False
		End Try
		tran.Commit()
		Return True
	End Function

    Public Function updateKoYarn(ByVal dtKoYarn As DataTable, ByRef msgErr As String) As Boolean
        Dim conn As New SqlConnection(connStr.connection())
        conn.Open()

        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_ko_yarn_update"
        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable

        Dim i As Integer
        For i = 0 To dtKoYarn.Rows.Count - 1
            comm.Parameters.Clear()
            comm.Parameters.AddWithValue("@kono", dtKoYarn.Rows(i).Item("kono"))
            comm.Parameters.AddWithValue("@itcd", dtKoYarn.Rows(i).Item("itcd"))
            comm.Parameters.AddWithValue("@total_scrap_qty", dtKoYarn.Rows(i).Item("total_scrap_qty"))
            Try
                da.Fill(dt)
            Catch ex As Exception
                msgErr = ex.Message
                tran.Rollback()
                Exit Function
                updateKoYarn = False
            End Try
        Next
        tran.Commit()
        msgErr = "Scrap data saved successfully.."
        updateKoYarn = True
	End Function

	Public Function CloseJob(ByVal dt As DataTable, ByRef msgerr As String) As Boolean
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = Data.CommandType.StoredProcedure
		comm.CommandText = "p_po_closing_update"
		For i = 0 To dt.Rows.Count - 1
			Try
				comm.Parameters.Clear()
				comm.Parameters.AddWithValue("@id_jobdet", dt.Rows(i)("id_jobdet"))
				comm.Parameters.AddWithValue("@closed", CBool(dt.Rows(i)("closed")))
				comm.ExecuteNonQuery()
			Catch ex As Exception
				msgerr = ex.Message
				tran.Rollback()
				Return False
			End Try
		Next

		tran.Commit()
		comm.Dispose()
		If conn.State = ConnectionState.Open Then conn.Close()
		conn.Dispose()
		Return True
	End Function

	Public Function UpdateYarnIN2(ByVal dt As DataTable, ByVal loginEmpcd As String, ByRef docno As String) As Boolean
		Dim deletedDetRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
		Dim modifiedDetRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
		Dim addedDetRecs As New DataView(dt, "", "", DataViewRowState.Added)
		Dim clsConfig As New clsConfig
		Dim conn As New SqlConnection(connStr.connection())
		conn.Open()

		Dim comm As New SqlCommand("", conn)
		Dim tran As SqlTransaction = conn.BeginTransaction
		comm.Transaction = tran
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_yarn_in_update3"

		comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dt.Rows(0)("docno"), ""))
		comm.Parameters.AddWithValue("@purno", clsConfig.IsNull(dt.Rows(0)("purno"), ""))
		comm.Parameters.AddWithValue("@sinvno", clsConfig.IsNull(dt.Rows(0)("sinvno"), ""))
		comm.Parameters.AddWithValue("@sinvdt", clsConfig.IsNull(dt.Rows(0)("sinvdt"), ""))
		comm.Parameters.AddWithValue("@suppcd", clsConfig.IsNull(dt.Rows(0)("suppcd"), ""))
		comm.Parameters.AddWithValue("@lotno_sup", clsConfig.IsNull(dt.Rows(0)("lotno_sup"), ""))
		comm.Parameters.AddWithValue("@srefno", clsConfig.IsNull(dt.Rows(0)("srefno"), ""))
		comm.Parameters.AddWithValue("@tran_type", clsConfig.IsNull(dt.Rows(0)("tran_type"), ""))
		comm.Parameters.AddWithValue("@remark", clsConfig.IsNull(dt.Rows(0)("remark"), ""))
		comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)

		Dim da2 As New SqlDataAdapter(comm)
		Dim dt2 As New DataTable

		Try
			da2.Fill(dt2)
			docno = dt2.Rows(0)("docno").ToString
			'MessageBox.Show(docno)
		Catch ex As Exception
			MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
			tran.Rollback()
			Return False
		End Try

		REM delete old record ------------------------------

		Dim i As Integer = 0

		If deletedDetRecs.Count > 0 Then
			For i = 0 To deletedDetRecs.Count - 1
				comm.Parameters.Clear()
				comm.CommandText = "p_yarn_in_det_delete"

				comm.Parameters.AddWithValue("@docno", clsConfig.IsNull(dt.Rows(0)("docno"), ""))
				comm.Parameters.AddWithValue("@boxno", deletedDetRecs.Item(i)("boxno").ToString.Trim)
				comm.Parameters.AddWithValue("@log_empcd", loginEmpcd.Trim)
				da2 = New SqlDataAdapter(comm)
				dt = New DataTable

				Try
					da2.Fill(dt)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
					tran.Rollback()
					Return False
				End Try
			Next
		End If

		REM update old record ------------------------------

		i = 0

		If modifiedDetRecs.Count > 0 Then
			For i = 0 To modifiedDetRecs.Count - 1
				comm.Parameters.Clear()
				comm.CommandText = "p_yarn_in_det_update3"

				With modifiedDetRecs
					comm.Parameters.AddWithValue("@docno", docno)
					comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
					comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s").Trim)
					comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
					comm.Parameters.AddWithValue("@spools", .Item(i)("spools").ToString)
					comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
					comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr").ToString)
					comm.Parameters.AddWithValue("@cart_tearwt", .Item(i)("cart_tearwt").ToString)
					comm.Parameters.AddWithValue("@spool_tearwt", .Item(i)("spool_tearwt").ToString)
					comm.Parameters.AddWithValue("@kg_nt", .Item(i)("kg_nt").ToString)
					comm.Parameters.AddWithValue("@id_jobdet", .Item(i)("id_jobdet").ToString)
					comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
				End With
				da2 = New SqlDataAdapter(comm)
				dt = New DataTable

				Try
					da2.Fill(dt)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
					tran.Rollback()
					Return False
				End Try
			Next
		End If

		REM insert new record ------------------------------

		i = 0

		If addedDetRecs.Count > 0 Then
			For i = 0 To addedDetRecs.Count - 1
				comm.Parameters.Clear()
				comm.CommandText = "p_yarn_in_det_update3"

				With addedDetRecs
					comm.Parameters.AddWithValue("@docno", docno)
					comm.Parameters.AddWithValue("@itcd", .Item(i)("itcd").Trim)
					comm.Parameters.AddWithValue("@boxno_s", .Item(i)("boxno_s").Trim)
					comm.Parameters.AddWithValue("@boxno", .Item(i)("boxno").Trim)
					comm.Parameters.AddWithValue("@spools", .Item(i)("spools").ToString)
					comm.Parameters.AddWithValue("@grade", .Item(i)("grade").Trim)
					comm.Parameters.AddWithValue("@kg_gr", .Item(i)("kg_gr").ToString)
					comm.Parameters.AddWithValue("@cart_tearwt", .Item(i)("cart_tearwt").ToString)
					comm.Parameters.AddWithValue("@spool_tearwt", .Item(i)("spool_tearwt").ToString)
					comm.Parameters.AddWithValue("@kg_nt", .Item(i)("kg_nt").ToString)
					comm.Parameters.AddWithValue("@id_jobdet", .Item(i)("id_jobdet").ToString)
					comm.Parameters.AddWithValue("@login_empcd", loginEmpcd.Trim)
				End With
				da2 = New SqlDataAdapter(comm)
				dt = New DataTable

				Try
					da2.Fill(dt)
				Catch ex As Exception
					MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
					tran.Rollback()
					Return False
				End Try
			Next
		End If
		tran.Commit()
		Return True
	End Function

	Public Function YarnLocationSave(ByVal dt As DataTable, ByRef msgerr As String, ByVal log_empcd As String, ByRef strLogNo As String) As Boolean
		Dim conn As New SqlConnection((New classConnection).connection)
		Dim comm As New SqlCommand("", conn)
		conn.Open()
		Dim tran As SqlTransaction = conn.BeginTransaction
		Dim i As Integer = 0
		comm.Transaction = tran
		comm.CommandType = Data.CommandType.StoredProcedure
		comm.CommandText = "p_yarn_in_location_save"
		'Dim strLogNo As String = ""
		Dim da As New SqlDataAdapter()
		Dim dt2 As New DataTable
		For i = 0 To dt.Rows.Count - 1
			comm.Parameters.Clear()
			comm.Parameters.AddWithValue("@logno", strLogNo)
			comm.Parameters.AddWithValue("@boxno", dt.Rows(i)("boxno"))
			comm.Parameters.AddWithValue("@location", dt.Rows(i)("loc"))
			comm.Parameters.AddWithValue("@log_empcd", log_empcd)
			da = New SqlDataAdapter(comm)
			Try
				da.Fill(dt2)
			Catch ex As Exception
				msgerr = ex.Message
				tran.Rollback()
				Return False
			End Try
			strLogNo = dt2.Rows(0)("logno").ToString()
		Next

		tran.Commit()
		comm.Dispose()
		If conn.State = ConnectionState.Open Then conn.Close()
		conn.Dispose()
		Return True
	End Function
End Class
