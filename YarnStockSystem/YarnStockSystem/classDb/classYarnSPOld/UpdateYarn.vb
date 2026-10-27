Imports System.Text
Imports System.Data.SqlClient
Imports System.Data

Public Class UpdateYarn
	Private connStr As New classConnection

	Public Function UpdateYarnIn(ByVal Param_YarnIn As tbl_Yarn_in, ByVal dt_Yarn_in_det As DataTable, ByRef Msgerr As String, ByVal da As SqlDataAdapter, ByVal loginEmpcd As String) As Boolean
		Dim strSQL As New StringBuilder
		Dim deletedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.Deleted)
		Dim modifiedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.ModifiedCurrent)
		Dim addedDetRecs As New DataView(dt_Yarn_in_det, "", "", DataViewRowState.Added)

		With Param_YarnIn
			strSQL.Append("exec p_yarn_in_update ")
			strSQL.Append("'" & .docdt.ToString.Trim.Format("yyyyMMdd") & "',")
			strSQL.Append("'" & .docno.Trim & "',")
			strSQL.Append("'" & "''" & "',") ' .jobno.Trim
			strSQL.Append("'" & .purno.Trim & "',")
			strSQL.Append("'" & .sinvno.Trim & "',")
			strSQL.Append("'" & .sinvdt.Trim & "',")
			strSQL.Append("'" & .suppcd.Trim & "',")
			strSQL.Append("'" & .lotno_sup.Trim & "',")
			strSQL.Append("'" & .lotno_our.Trim & "',")
			strSQL.Append("'" & .srefno.Trim & "',")
			strSQL.Append(.totkg.ToString & ",")
			strSQL.Append("'" & .curr.Trim & "',")
			strSQL.Append(.exrt.ToString & ",")
			strSQL.Append(.vat.ToString & ",")
			strSQL.Append(.vatamt.ToString & ",")
			strSQL.Append(.taxper.ToString & ",")
			strSQL.Append(.taxamt.ToString & ",")
			strSQL.Append(.freight.ToString & ",")
			strSQL.Append(.insurance.ToString & ",")
			strSQL.Append(.otheramt.ToString & ",")
			strSQL.Append("'" & .other_text.Trim & "',")
			strSQL.Append(.discamt.ToString & ",")
			strSQL.Append(.totamt.ToString & ",")
			strSQL.Append("'" & .tstamp.ToString.Format("yyyyMMdd") & "',")
			strSQL.Append("'" & .tran_type.Trim & "',")
			strSQL.Append(.docapp.ToString & ",")
			strSQL.Append(.cancel.ToString & ",")
			strSQL.Append("'" & .outno.Trim & "',")
			strSQL.Append("'" & .remark.Trim & "',")
			strSQL.Append("'" & loginEmpcd.Trim & "'")
		End With

		Dim da2 As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim dt As New DataTable

		Try
			da2.Fill(dt)
		Catch ex As Exception
			Msgerr = ex.Message
			Return False
		End Try

		REM delete old record ------------------------------

		Dim i As Integer = 0

		If deletedDetRecs.Count > 0 Then
			For i = 0 To deletedDetRecs.Count - 1
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_in_det_delete ")
				strSQL.Append("'" & Param_YarnIn.docno.Trim & "',")
				strSQL.Append("'" & deletedDetRecs.Item(i)("boxno").ToString.Trim & "'")
				da2 = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable

				Try
					da2.Fill(dt)
				Catch ex As Exception
					Msgerr = ex.Message
					Return False
				End Try
			Next
		End If

		REM update old record ------------------------------

		i = 0

		If modifiedDetRecs.Count > 0 Then
			For i = 0 To modifiedDetRecs.Count - 1
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_in_det_update ")
				strSQL.Append("'" & Param_YarnIn.docno.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("itcd").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("boxno_s").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("boxno").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("boxno_o").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("lotno_sup").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("lotno_our").ToString.Trim & "',")
				strSQL.Append(modifiedDetRecs.Item(i)("spools").ToString & ",")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("grade").ToString.Trim & "',")
				strSQL.Append(modifiedDetRecs.Item(i)("kg_gr").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item(i)("cart_tearwt").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item(i)("spool_tearwt").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item(i)("kg_nt").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item(i)("price").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item(i)("Used").ToString & ",")
				strSQL.Append("'" & modifiedDetRecs.Item(i)("tstamp").ToString("yyyyMMdd") & "'")
				da2 = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable

				Try
					da.Fill(dt)
				Catch ex As Exception
					Msgerr = ex.Message
					Return False
				End Try
			Next
		End If

		REM insert new record ------------------------------

		i = 0

		If addedDetRecs.Count > 0 Then
			For i = 0 To addedDetRecs.Count - 1
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_in_det_insert ")
				strSQL.Append("'" & Param_YarnIn.docno.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item(i)("itcd").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item(i)("boxno_s").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item(i)("boxno").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item(i)("boxno_o").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item(i)("lotno_sup").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item(i)("lotno_our").ToString.Trim & "',")
				strSQL.Append(addedDetRecs.Item(i)("spools").ToString & ",")
				strSQL.Append("'" & addedDetRecs.Item(i)("grade").ToString.Trim & "',")
				strSQL.Append(addedDetRecs.Item(i)("kg_gr").ToString & ",")
				strSQL.Append(addedDetRecs.Item(i)("cart_tearwt").ToString & ",")
				strSQL.Append(addedDetRecs.Item(i)("spool_tearwt").ToString & ",")
				strSQL.Append(addedDetRecs.Item(i)("kg_nt").ToString & ",")
				strSQL.Append(addedDetRecs.Item(i)("price").ToString & ",")
				strSQL.Append(addedDetRecs.Item(i)("Used").ToString & ",")
				strSQL.Append("'" & addedDetRecs.Item(i)("tstamp").ToString("yyyyMMdd") & "'")
				da2 = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable

				Try
					da.Fill(dt)
				Catch ex As Exception
					Msgerr = ex.Message
					Return False
				End Try
			Next
		End If

		Return True
	End Function

	Public Function UpdateYarnOut(ByVal param_tbl_yarn_out As tbl_Yarn_out, ByVal dt_yarn_out_det As DataTable, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
		Dim strSQL As New StringBuilder
		Dim deletedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.Deleted)
		Dim modifiedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.ModifiedCurrent)
		Dim addedDetRecs As New DataView(dt_yarn_out_det, "", "", DataViewRowState.Added)

		strSQL.Append("exec p_yarn_out_update ")
		With param_tbl_yarn_out
			strSQL.Append("exec p_yarn_out_update ")
			strSQL.Append("'" & .outno.Trim & "',")
			strSQL.Append("'" & .outdt.ToString("yyyyMMdd") & "',")
			strSQL.Append("'" & .tran_type.Trim & "',")
			strSQL.Append("'" & .refdocno.Trim & "',")
			strSQL.Append("'" & .suppcd.Trim & "',")
			strSQL.Append("'" & .kono.Trim & "',")
			strSQL.Append("'" & .remm.Trim & "',")
			strSQL.Append("0,")
			strSQL.Append("'" & loginEmpcd.Trim & "'")
		End With

		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim dt As New DataTable

		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try

		REM delete old record ------------------------------

		Dim i As Integer = 0

		If deletedDetRecs.Count > 0 Then
			For i = 0 To deletedDetRecs.Count - 1
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_out_det_delete ")
				strSQL.Append(deletedDetRecs.Item(i)("id_yarn_out_det").ToString & ",")
				strSQL.Append("'" & param_tbl_yarn_out.outno.Trim & "'")
				da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable

				Try
					da.Fill(dt)
				Catch ex As Exception
					msgerr = ex.Message
					Return False
				End Try
			Next
		End If

		REM update old record ------------------------------

		i = 0

		If modifiedDetRecs.Count > 0 Then
			For i = 0 To modifiedDetRecs.Count - 1
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_out_det_update ")
				strSQL.Append(modifiedDetRecs.Item("id_yarn_out_det").ToString & ",")
				strSQL.Append("'" & param_tbl_yarn_out.outno.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item("itcd").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item("grade").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item("boxno_s").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item("boxno").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item("lotno_sup").ToString.Trim & "',")
				strSQL.Append("'" & modifiedDetRecs.Item("lotno_our").ToString.Trim & "',")
				strSQL.Append(modifiedDetRecs.Item("spools").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item("kg_gr").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item("cart_tearwt").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item("spool_tearwt").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item("kg_nt").ToString & ",")
				strSQL.Append(modifiedDetRecs.Item("id_job_det_yarn").ToString)
				da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable

				Try
					da.Fill(dt)
				Catch ex As Exception
					msgerr = ex.Message
					Return False
				End Try
			Next
		End If

		REM insert new record ------------------------------

		i = 0

		If addedDetRecs.Count > 0 Then
			For i = 0 To addedDetRecs.Count - 1
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_out_det_insert ")
				strSQL.Append(addedDetRecs.Item("id_yarn_out_det").ToString & ",")
				strSQL.Append("'" & param_tbl_yarn_out.outno.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item("itcd").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item("grade").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item("boxno_s").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item("boxno").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item("lotno_sup").ToString.Trim & "',")
				strSQL.Append("'" & addedDetRecs.Item("lotno_our").ToString.Trim & "',")
				strSQL.Append(addedDetRecs.Item("spools").ToString & ",")
				strSQL.Append(addedDetRecs.Item("kg_gr").ToString & ",")
				strSQL.Append(addedDetRecs.Item("cart_tearwt").ToString & ",")
				strSQL.Append(addedDetRecs.Item("spool_tearwt").ToString & ",")
				strSQL.Append(addedDetRecs.Item("kg_nt").ToString & ",")
				strSQL.Append(addedDetRecs.Item("id_job_det_yarn").ToString)
				da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable

				Try
					da.Fill(dt)
				Catch ex As Exception
					msgerr = ex.Message
					Return False
				End Try
			Next
		End If

		Return True
	End Function

	Public Function cancelYarnin(ByVal Docno As String, ByVal loginEmpcd As String, ByRef Msgerr As String)
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_cancel '" & Docno.Trim & "','" & loginEmpcd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim dt As New DataTable
		Try
			da.Fill(dt)
		Catch ex As Exception
			Msgerr = ex.Message
			Return False
		End Try
		Return True
	End Function

End Class
