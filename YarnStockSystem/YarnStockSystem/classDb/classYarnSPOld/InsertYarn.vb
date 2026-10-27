Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class InsertYarn
	'Private ds As New DataSet
	Private connStr As New classConnection
	'Private Clsconfig As New clsConfig

	Public Function InsertYarnIn(ByRef ParamYarnin As tbl_Yarn_in, ByRef msgerr As String, ByRef Purno As String, ByVal loginEmpcd As String) As Boolean
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_insert ")
		strSQL.Append("'" & ParamYarnin.docdt.ToString("yyyyMMdd") & "',")
		strSQL.Append("'" & ParamYarnin.docno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.jobno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.purno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.sinvno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.sinvdt.Trim & "',")
		strSQL.Append("'" & ParamYarnin.suppcd.Trim & "',")
		strSQL.Append("'" & ParamYarnin.lotno_sup.Trim & "',")
		strSQL.Append("'" & ParamYarnin.lotno_our.Trim & "',")
		strSQL.Append("'" & ParamYarnin.srefno.Trim & "',")
		strSQL.Append(ParamYarnin.totkg.ToString & ",")
		strSQL.Append("'" & ParamYarnin.curr.Trim & "',")
		strSQL.Append(ParamYarnin.exrt.ToString & ",")
		strSQL.Append(ParamYarnin.vat.ToString & ",")
		strSQL.Append(ParamYarnin.vatamt.ToString & ",")
		strSQL.Append(ParamYarnin.taxper.ToString & ",")
		strSQL.Append(ParamYarnin.taxamt.ToString & ",")
		strSQL.Append(ParamYarnin.freight.ToString & ",")
		strSQL.Append(ParamYarnin.insurance.ToString & ",")
		strSQL.Append(ParamYarnin.otheramt.ToString & ",")
		strSQL.Append("'" & ParamYarnin.other_text.Trim & "',")
		strSQL.Append(ParamYarnin.discamt.ToString & ",")
		strSQL.Append(ParamYarnin.totamt.ToString & ",")
		strSQL.Append("'" & ParamYarnin.tstamp.ToString("yyyyMMdd") & "',")
		strSQL.Append("'" & ParamYarnin.tran_type.Trim & "',")
		strSQL.Append(ParamYarnin.docapp.ToString & ",")
		strSQL.Append(ParamYarnin.cancel.ToString & ",")
		strSQL.Append("'" & ParamYarnin.outno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.remark.Trim & "',")
		strSQL.Append("'" & loginEmpcd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim dt As New DataTable

		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try

		Dim docno As String = dt.Rows(0)("docno").ToString.Trim
		Dim i As Integer = 0
		Dim tbl_Yarn_in_det As New tbl_Yarn_in_det
		Purno = docno

		Try
			For Each tbl_Yarn_in_det In ParamYarnin.tbl_Yarn_in_det
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_in_det_insert ")
				strSQL.Append("'" & docno & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.itcd.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.boxno_s.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.boxno.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.boxno_o.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.lotno_sup.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.lotno_our.Trim & "',")
				strSQL.Append(tbl_Yarn_in_det.spools.ToString & ",")
				strSQL.Append("'" & tbl_Yarn_in_det.grade.Trim & "',")
				strSQL.Append(tbl_Yarn_in_det.kg_gr.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.cart_tearwt.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.spool_tearwt.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.kg_nt.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.price.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.Used.ToString & ",")
				strSQL.Append("'" & tbl_Yarn_in_det.tstamp.ToString("yyyyMMdd") & "'")
				da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable
				da.Fill(dt)
				ParamYarnin.tbl_Yarn_in_det(i).boxno = dt.Rows(0)("boxno").ToString.Trim
				i += 1
			Next
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try
		Return True
	End Function

	Public Function InsertYarnInReturn(ByVal ParamYarnin As tbl_Yarn_in, ByRef msgerr As String, ByRef Purno As String, ByVal loginempcd As String) As Boolean
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_return_insert ")
		strSQL.Append("'" & ParamYarnin.docdt.ToString("yyyyMMdd") & "',")
		strSQL.Append("'" & ParamYarnin.docno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.jobno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.purno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.sinvno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.sinvdt.Trim & "',")
		strSQL.Append("'" & ParamYarnin.suppcd.Trim & "',")
		strSQL.Append("'" & ParamYarnin.lotno_sup.Trim & "',")
		strSQL.Append("'" & ParamYarnin.lotno_our.Trim & "',")
		strSQL.Append("'" & ParamYarnin.srefno.Trim & "',")
		strSQL.Append(ParamYarnin.totkg.ToString & ",")
		strSQL.Append("'" & ParamYarnin.curr.Trim & "',")
		strSQL.Append(ParamYarnin.exrt.ToString & ",")
		strSQL.Append(ParamYarnin.vat.ToString & ",")
		strSQL.Append(ParamYarnin.vatamt.ToString & ",")
		strSQL.Append(ParamYarnin.taxper.ToString & ",")
		strSQL.Append(ParamYarnin.taxamt.ToString & ",")
		strSQL.Append(ParamYarnin.freight.ToString & ",")
		strSQL.Append(ParamYarnin.insurance.ToString & ",")
		strSQL.Append(ParamYarnin.otheramt.ToString & ",")
		strSQL.Append("'" & ParamYarnin.other_text.Trim & "',")
		strSQL.Append(ParamYarnin.discamt.ToString & ",")
		strSQL.Append(ParamYarnin.totamt.ToString & ",")
		strSQL.Append("'" & ParamYarnin.tstamp.ToString("yyyyMMdd") & "',")
		strSQL.Append("'" & ParamYarnin.tran_type.Trim & "',")
		strSQL.Append(ParamYarnin.docapp.ToString & ",")
		strSQL.Append(ParamYarnin.cancel.ToString & ",")
		strSQL.Append("'" & ParamYarnin.outno.Trim & "',")
		strSQL.Append("'" & ParamYarnin.remark.Trim & "',")
		strSQL.Append("'" & loginempcd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim dt As New DataTable

		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try

		Dim docno As String = dt.Rows(0)("docno").ToString.Trim
		Dim i As Integer = 0
		Dim tbl_Yarn_in_det As New tbl_Yarn_in_det
		Purno = docno

		Try
			For Each tbl_Yarn_in_det In ParamYarnin.tbl_Yarn_in_det
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_in_return_det_insert ")
				strSQL.Append("'" & docno & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.itcd.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.boxno_s.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.boxno.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.boxno_o.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.lotno_sup.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_in_det.lotno_our.Trim & "',")
				strSQL.Append(tbl_Yarn_in_det.spools.ToString & ",")
				strSQL.Append("'" & tbl_Yarn_in_det.grade.Trim & "',")
				strSQL.Append(tbl_Yarn_in_det.kg_gr.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.cart_tearwt.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.spool_tearwt.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.kg_nt.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.price.ToString & ",")
				strSQL.Append(tbl_Yarn_in_det.Used.ToString & ",")
				strSQL.Append("'" & tbl_Yarn_in_det.tstamp.ToString("yyyyMMdd") & "'")
				da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable
				da.Fill(dt)
				ParamYarnin.tbl_Yarn_in_det(i).boxno = dt.Rows(0)("boxno").ToString.Trim
				i += 1
			Next
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try
		Return True
	End Function

	Public Function CheckKeySGN_of_Month(ByVal Num As Integer, ByVal idname As String) As String
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_num_select '" & idname & "'," & Year(Today()))
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim dt As New DataTable
		Dim KeyMM As String = ""

		Try
			da.Fill(dt)
		Catch ex As Exception
			Return KeyMM
		End Try

		If dt.Rows.Count > 0 Then
			If dt.Rows(0)("format").ToString.Trim.ToUpper = "YY" Then
				KeyMM = Val(dt.Rows(0)("num")).ToString
			Else
				KeyMM = Val(dt.Rows(0)("num" & Num)).ToString
			End If
		End If
		Return KeyMM
	End Function

	Public Function InsertYarnOut(ByRef paramtbl_yarn_out As tbl_Yarn_out, ByRef Youtno As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_out_insert ")
		strSQL.Append("'" & paramtbl_yarn_out.outno.Trim & "',")
		strSQL.Append("'" & paramtbl_yarn_out.outdt.ToString("yyyyMMdd") & "',")
		strSQL.Append("'" & paramtbl_yarn_out.tran_type.Trim & "',")
		strSQL.Append("'" & paramtbl_yarn_out.refdocno.Trim & "',")
		strSQL.Append("'" & paramtbl_yarn_out.suppcd.Trim & "',")
		strSQL.Append("'" & paramtbl_yarn_out.kono.Trim & "',")
		strSQL.Append("'" & paramtbl_yarn_out.remm.Trim & "',")
		strSQL.Append("0,")
		strSQL.Append("'" & loginEmpcd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim dt As New DataTable

		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try

		Dim docno As String = dt.Rows(0)("outno").ToString.Trim
		Dim i As Integer = 0
		Dim tbl_Yarn_out_det As New tbl_Yarn_out_det
		Youtno = docno

		Try
			For Each tbl_Yarn_out_det In paramtbl_yarn_out.tbl_Yarn_out_det
				strSQL = New StringBuilder
				strSQL.Append("exec p_yarn_out_det_insert ")
				strSQL.Append(tbl_Yarn_out_det.id_yarn_out_det.ToString & ",")
				strSQL.Append("'" & docno & "',")
				strSQL.Append("'" & tbl_Yarn_out_det.itcd.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_out_det.grade.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_out_det.boxno_s.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_out_det.boxno.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_out_det.lotno_sup.Trim & "',")
				strSQL.Append("'" & tbl_Yarn_out_det.lotno_our.Trim & "',")
				strSQL.Append(tbl_Yarn_out_det.spools.ToString & ",")
				strSQL.Append(tbl_Yarn_out_det.kg_gr.ToString & ",")
				strSQL.Append(tbl_Yarn_out_det.cart_tearwt.ToString & ",")
				strSQL.Append(tbl_Yarn_out_det.spool_tearwt.ToString & ",")
				strSQL.Append(tbl_Yarn_out_det.kg_nt.ToString & ",")
				strSQL.Append(tbl_Yarn_out_det.id_job_det_yarn.ToString)
				da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable
				da.Fill(dt)
				paramtbl_yarn_out.tbl_Yarn_out_det(i).id_yarn_out_det = dt.Rows(0)("id_yarn_out_det")
				i += 1
			Next
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try
		Return True
	End Function

	Public Function InsertJobOrderforYarn(ByVal tbl_job As tbl_job, ByRef SGN As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
		Dim strSQL As New StringBuilder
		With tbl_job
			strSQL.Append("exec p_job_insert ")
			strSQL.Append("'" & .jobno.Trim & "',")
			strSQL.Append("'" & .jobdt.ToString("yyyyMMdd") & "',")
			strSQL.Append("'" & .suppcd.Trim & "',")
			strSQL.Append("'" & .supquoteno.Trim & "',")
			strSQL.Append("'" & .sourcedocno.Trim & "',")
			strSQL.Append("'" & .supplang.Trim & "',")
			strSQL.Append("'" & .empcd.Trim & "',")
			strSQL.Append("'" & .deptcd.Trim & "',")
			strSQL.Append("'" & .reqno.Trim & "',")
			strSQL.Append("'" & .kono.Trim & "',")
			strSQL.Append(.delidays.ToString & ",")
			strSQL.Append("'" & .delidt.ToString("yyyyMMdd") & "',")
			strSQL.Append("'" & .crterm.Trim & "',")
			strSQL.Append(.crdays.ToString & ",")
			strSQL.Append("'" & .crdesc.Trim & "',")
			strSQL.Append("'" & .paymodecd.Trim & "',")
			strSQL.Append("'" & .shipvia.Trim & "',")
			strSQL.Append("'" & .jobtype.Trim & "',")
			strSQL.Append("'" & .jobitcd.Trim & "',")
			strSQL.Append(.tubeqty.ToString & ",")
			strSQL.Append(.tubekg.ToString & ",")
			strSQL.Append("'" & .twists.Trim & "',")
			strSQL.Append("'" & .col.Trim & "',")
			strSQL.Append("'" & .packcd.Trim & "',")
			strSQL.Append("'" & .splins.Trim & "',")
			strSQL.Append("'" & .remark.Trim & "',")
			strSQL.Append("'" & .jobfor.Trim & "',")
			strSQL.Append(.import.ToString & ",")
			strSQL.Append("'" & .curr.Trim & "',")
			strSQL.Append(.exrt.ToString & ",")
			strSQL.Append(.discper.ToString & ",")
			strSQL.Append(.discamt.ToString & ",")
			strSQL.Append(.vat.ToString & ",")
			strSQL.Append(.vatamt.ToString & ",")
			strSQL.Append(.taxper.ToString & ",")
			strSQL.Append(.taxamt.ToString & ",")
			strSQL.Append(.shipping.ToString & ",")
			strSQL.Append(.freight.ToString & ",")
			strSQL.Append(.insurance.ToString & ",")
			strSQL.Append(.handling.ToString & ",")
			strSQL.Append(.otheramt.ToString & ",")
			strSQL.Append("'" & .other_text.Trim & "',")
			strSQL.Append(.totamt.ToString & ",")
			strSQL.Append(.cancel_status.ToString & ",")
			strSQL.Append(.shipterms.ToString & ",")
			strSQL.Append("'" & .deliaddr.Trim & "',")
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

		Dim docno As String = dt.Rows(0)("jobno").ToString.Trim
		Dim i As Integer = 0
		Dim j As Integer = 0
		Dim tbl_job_det As New tbl_job_det
		Dim tbl_job_det_yarn As New tbl_job_det_yarn
		SGN = docno

		Try
			For Each tbl_job_det In tbl_job.tbl_job_det
				strSQL = New StringBuilder
				With tbl_job_det
					strSQL.Append("exec p_job_det_insert ")
					strSQL.Append("'" & docno & "',")
					strSQL.Append(.id_jobdet.ToString & ",")
					strSQL.Append("'" & .supquoteno.trim & "',")
					strSQL.Append("'" & .outno.Trim & "',")
					strSQL.Append("'" & .itcd.Trim & "',")
					strSQL.Append("'" & .itdesc.Trim & "',")
					strSQL.Append(.qty.ToString & ",")
					strSQL.Append("'" & .uom.Trim & "',")
					strSQL.Append(.price.ToString & ",")
					strSQL.Append("'" & .curr.Trim & "',")
					strSQL.Append(.exrt.ToString & ",")
					strSQL.Append(.discper.ToString & ",")
					strSQL.Append(.discamt.ToString & ",")
					strSQL.Append(.lineamt.ToString & ",")
					strSQL.Append("'" & .delidt.ToString("yyyyMMdd") & "',")
					strSQL.Append("'" & .remark.Trim & "',")
					strSQL.Append(.closed.ToString)
				End With
				da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
				dt = New DataTable
				da.Fill(dt)
				tbl_job.tbl_job_det(i).id_jobdet = dt.Rows(0)("id_jobdet")
				i += 1
				j = 0

				For Each tbl_job_det_yarn In tbl_job.tbl_job_det_yarn
					If tbl_job_det.itcd.Trim = tbl_job_det_yarn.itcd.Trim Then
						With tbl_job_det_yarn
							strSQL.Append("exec p_job_det_yarn_insert ")
							strSQL.Append(.id_job_det_yarn.ToString & ",")
							strSQL.Append(tbl_job.tbl_job_det(i).id_jobdet.ToString & ",")
							strSQL.Append("'" & .lotno_sup.Trim & "',")
							strSQL.Append("'" & .lotno_our.Trim & "',")
							strSQL.Append("'" & .itcd.Trim & "',")
							strSQL.Append("'" & .boxno.Trim & "',")
							strSQL.Append(.spools.ToString & ",")
							strSQL.Append(.kg_gr.ToString & ",")
							strSQL.Append(.kg_nt.ToString & ",")
							strSQL.Append("'" & .tstamp.ToString("yyyyMMdd") & "'")
						End With
						da = New SqlDataAdapter(strSQL.ToString, connStr.connection())
						dt = New DataTable
						da.Fill(dt)
						tbl_job.tbl_job_det_yarn(j).id_job_det_yarn = dt.Rows(0)("id_job_det_yarn")
					End If
					j += 1
				Next
			Next
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try
		Return True
	End Function

	Public Function InsertYarnMaster(ByVal Param_tbl_items As tbl_Items, ByRef msgerr As String) As Boolean
		Dim strSQL As New StringBuilder
		With Param_tbl_items
			strSQL.Append("exec p_items_insert ")
			strSQL.Append("'" & .itcd.Trim & "',")
			strSQL.Append("'" & .itdesc.Trim & "',")
			strSQL.Append("'" & .itdesc2.Trim & "',")
			strSQL.Append("'" & .itdesc3.Trim & "',")
			strSQL.Append("'" & .itdesct.Trim & "',")
			strSQL.Append("'" & .itdesct2.Trim & "',")
			strSQL.Append("'" & .itdesct3.Trim & "',")
			strSQL.Append("'" & .itnaturecd.Trim & "',")
			strSQL.Append("'" & .ittypecd.Trim & "',")
			strSQL.Append("'" & .itcatcd.Trim & "',")
			strSQL.Append("'" & .itsubcatcd.Trim & "',")
			strSQL.Append("'" & .itgroupcd.Trim & "',")
			strSQL.Append("'" & .itsubcd.Trim & "',")
			strSQL.Append("'" & .itsubcd2.Trim & "',")
			strSQL.Append("'" & .itsubcd3.Trim & "',")
			strSQL.Append("'" & .mrpcode.Trim & "',")
			strSQL.Append("'" & .dinear.Trim & "',")
			strSQL.Append("'" & .filament.Trim & "',")
			strSQL.Append("'" & .twists.Trim & "',")
			strSQL.Append("'" & .col.Trim & "',")
			strSQL.Append("'" & .dimension.Trim & "',")
			strSQL.Append("'" & .suppcd.Trim & "',")
			strSQL.Append("'" & .tstamp.ToString("yyyyMMdd") & "'")
		End With
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim dt As New DataTable

		Try
			da.Fill(dt)
		Catch ex As Exception
			msgerr = ex.Message
			Return False
		End Try
		Return True
	End Function

End Class
