Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class InsertYarn
	'Private ds As New DataSet
	'Private Clsconfig As New clsConfig
	Private connStr As New classConnection

	'Public Function InsertYarnOut(ByVal paramtbl_yarn_out As tbl_Yarn_out, ByRef Youtno As String, ByRef msgerr As String) As Boolean
	'	Dim strcountyarnout As New StringBuilder
	'	Dim str As New StringBuilder
	'	Dim nnnn As String
	'	Dim prefix As String
	'	Dim YY As String
	'	Dim MM As String
	'	Dim KeyGen As String
	'	Dim No As String
	'	Dim GenSGN As String
	'	Dim nnnn1 As Integer
	'	Dim Nodigits As String
	'	Dim lpadchar As String
	'	Dim strnnnn As String

	'	Dim conn As SqlConnection = New SqlConnection
	'	conn.ConnectionString = connStr.connection
	'	conn.Open()
	'	Dim tran As SqlTransaction
	'	tran = conn.BeginTransaction
	'	Try
	'		Dim comm As SqlCommand = New SqlCommand
	'		comm.Connection = conn
	'		comm.Transaction = tran

	'		'----------------------------------Generate SGN 

	'		'//////////////////////CountNum tblYarnIn

	'		strcountyarnout.Append("select * from yarn_out ")
	'		comm.CommandText = strcountyarnout.ToString
	'		comm.ExecuteNonQuery()

	'		Dim daCount As New SqlDataAdapter(strcountyarnout.ToString, connStr.connection)
	'		daCount.Fill(ds, "TblCountNumYarnout")
	'		If ds.Tables("TblCountNumYarnout").Rows.Count > 0 Then
	'			nnnn = ds.Tables("TblCountNumYarnout").Rows.Count
	'		Else
	'			nnnn = 0
	'		End If

	'		str.Append("select * from Num where ltrim(rtrim(idname)) = 'YOUT' and yr = '" & Year(Today.Date) & "'")
	'		comm.CommandText = str.ToString
	'		comm.ExecuteNonQuery()
	'		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
	'		da.Fill(ds, "TblKeyGen")
	'		If ds.Tables("TblKeyGen").Rows.Count > 0 Then
	'			prefix = ds.Tables("Tblkeygen").Rows(0).Item("prefix").ToString.Trim
	'			YY = Mid(Year(Today.Date), 3, 2)
	'			MM = Month(Today.Date)
	'			Nodigits = ds.Tables("Tblkeygen").Rows(0).Item("Nodigits").ToString
	'			lpadchar = ds.Tables("Tblkeygen").Rows(0).Item("lpadchar").ToString
	'			nnnn1 = CheckKeySGN_of_Month(Month(Today.Date), "YOUT") + 1

	'			strnnnn = Trim(nnnn1.ToString)
	'			strnnnn = strnnnn.PadLeft(Nodigits - strnnnn.Length, lpadchar)
	'			No = strnnnn
	'			KeyGen = prefix & YY & MM & No
	'		End If

	'		GenSGN = KeyGen

	'		'------------------------------Insert tbl_yarn_out and tbl_yarn_out_det
	'		Dim strYarnout As New StringBuilder
	'		Dim strYarnoutdet As String
	'		strYarnout.Append("insert into yarn_out(outno,outdt,tran_type,refdocno,remm) ")
	'		strYarnout.Append("values('" & GenSGN & "','" & paramtbl_yarn_out.outdt & "','" & paramtbl_yarn_out.tran_type & "','" & paramtbl_yarn_out.refdocno & "','" & paramtbl_yarn_out.remm & "')")
	'		comm.CommandText = strYarnout.ToString
	'		comm.ExecuteNonQuery()
	'		If Not IsNothing(paramtbl_yarn_out.tbl_Yarn_out_det) Then
	'			Dim tbl_yarn_out_det As New tbl_Yarn_out_det
	'			For Each tbl_yarn_out_det In paramtbl_yarn_out.tbl_Yarn_out_det
	'				strYarnoutdet = "insert into Yarn_out_det(outno,outdt,itcd,grade,boxno_s,boxno,spools,kg_gr,cart_tearwt,kg_nt) " & _
	'				   "values('" & GenSGN & "','" & tbl_yarn_out_det.outdt & "'" & _
	'				  ",'" & tbl_yarn_out_det.itcd & "','" & tbl_yarn_out_det.grade & "','" & tbl_yarn_out_det.boxno_s & "'" & _
	'				   ",'" & tbl_yarn_out_det.boxno & "','" & tbl_yarn_out_det.spools & "','" & tbl_yarn_out_det.kg_gr & "'" & _
	'				   ",'" & tbl_yarn_out_det.cart_tearwt & "','" & tbl_yarn_out_det.kg_nt & "')"

	'				comm.CommandText = strYarnoutdet
	'				comm.ExecuteNonQuery()
	'			Next
	'		End If

	'		Dim strnum As New StringBuilder
	'		strnum.Append("update num set ")
	'		Select Case Month(Today.Date)
	'			Case 1
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num1").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num1 = '" & num & "'")
	'			Case 2
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num2").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num2 = '" & num & "'")
	'			Case 3
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num3").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num3 = '" & num & "'")
	'			Case 4
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num4").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num4 = '" & num & "'")
	'			Case 5
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num5").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num5 = '" & num & "'")
	'			Case 6
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num6").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num6 = '" & num & "'")
	'			Case 7
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num7").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num7 = '" & num & "'")
	'			Case 8
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num8").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num8 = '" & num & "'")
	'			Case 9
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num9").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num9 = '" & num & "'")
	'			Case 10
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num10").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num10 = '" & num & "'")
	'			Case 11
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num11").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num11  = '" & num & "'")
	'			Case 12
	'				Dim num As String
	'				num = ds.Tables("Tblkeygen").Rows(0).Item("num12").ToString.Trim
	'				num = num + 1
	'				strnum.Append(" num12 = '" & num & "'")
	'		End Select
	'		strnum.Append(" where ltrim(rtrim(idname)) = 'YOUT'")

	'		comm.CommandText = strnum.ToString
	'		comm.ExecuteNonQuery()

	'		Youtno = GenSGN
	'		'-------------------------------------------------
	'		tran.Commit()
	'		Return True
	'	Catch ex As Exception
	'		tran.Rollback()
	'		msgerr = ex.Message
	'		Return False
	'	Finally
	'		conn.Close()
	'	End Try
	'End Function

	Public Function InsertJobOrderforYarn(ByRef tbl_job As tbl_job, ByRef SGN As String, ByRef msgerr As String, Optional ByVal loginempcd As String = "") As Boolean
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		Dim tran As SqlTransaction = conn.BeginTransaction
		comm.Transaction = tran
		comm.CommandType = Data.CommandType.StoredProcedure
		comm.CommandText = "p_job_insert"
		With tbl_job
			comm.Parameters.AddWithValue("@jobno", .jobno.Trim)
			comm.Parameters.AddWithValue("@jobdt", CDate(.jobdt).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
			comm.Parameters.AddWithValue("@supquoteno", .supquoteno.Trim)
			comm.Parameters.AddWithValue("@sourcedocno", .sourcedocno.Trim)
			comm.Parameters.AddWithValue("@supplang", .supplang.Trim)
			comm.Parameters.AddWithValue("@empcd", .Empcd.Trim)
			comm.Parameters.AddWithValue("@deptcd", .Deptcd.Trim)
			comm.Parameters.AddWithValue("@reqno", .reqno.Trim)
			comm.Parameters.AddWithValue("@kono", .kono.Trim)
			comm.Parameters.AddWithValue("@delidays", .delidays.ToString)
			comm.Parameters.AddWithValue("@delidt", CDate(.delidt).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@crterm", .crterm.Trim)
			comm.Parameters.AddWithValue("@crdays", .crdays.ToString)
			comm.Parameters.AddWithValue("@crdesc", .crdesc.Trim)
			comm.Parameters.AddWithValue("@paymodecd", .paymodecd.Trim)
			comm.Parameters.AddWithValue("@shipvia", .shipvia.Trim)
			comm.Parameters.AddWithValue("@jobtype", .jobtype.Trim)
			comm.Parameters.AddWithValue("@jobitcd", .jobitcd.Trim)
			comm.Parameters.AddWithValue("@tubeqty", .tubeqty.ToString)
			comm.Parameters.AddWithValue("@tubekg", .tubekg.ToString)
			comm.Parameters.AddWithValue("@twists", .twists.Trim)
			comm.Parameters.AddWithValue("@col", .col.Trim)
			comm.Parameters.AddWithValue("@packcd", .packcd.Trim)
			comm.Parameters.AddWithValue("@splins", .splins.Trim)
			comm.Parameters.AddWithValue("@rem", .remark.Trim)
			comm.Parameters.AddWithValue("@jobfor", .jobfor.Trim)
			comm.Parameters.AddWithValue("@import", .import.ToString)
			comm.Parameters.AddWithValue("@curr", .curr.Trim)
			comm.Parameters.AddWithValue("@exrt", .exrt.ToString)
			comm.Parameters.AddWithValue("@discper", .discper.ToString)
			comm.Parameters.AddWithValue("@discamt", .discamt.ToString)
			comm.Parameters.AddWithValue("@vat", .vat.ToString)
			comm.Parameters.AddWithValue("@vatamt", .vatamt.ToString)
			comm.Parameters.AddWithValue("@taxper", .taxper.ToString)
			comm.Parameters.AddWithValue("@taxamt", .taxamt.ToString)
			comm.Parameters.AddWithValue("@shipping", .shipping.ToString)
			comm.Parameters.AddWithValue("@freight", .freight.ToString)
			comm.Parameters.AddWithValue("@insurance", .insurance.ToString)
			comm.Parameters.AddWithValue("@handling", .handling.ToString)
			comm.Parameters.AddWithValue("@otheramt", .otheramt.ToString)
			comm.Parameters.AddWithValue("@other_text", .other_text.Trim)
			comm.Parameters.AddWithValue("@totamt", .totamt.ToString)
			comm.Parameters.AddWithValue("@cancel_status", .cancel_status.ToString)
			comm.Parameters.AddWithValue("@cancel_date", CDate(.cancel_date).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@shipterms", .shipterms.Trim)
			comm.Parameters.AddWithValue("@deliaddr", .deliaddr.Trim)
			comm.Parameters.AddWithValue("@tstamp", CDate(.tstamp).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@approve_status", .approve_status.ToString)
			comm.Parameters.AddWithValue("@approve_date", CDate(.approve_date).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@rem_app", .rem_app.Trim)
			comm.Parameters.AddWithValue("@rem_cancel", .rem_cancel.Trim)
			comm.Parameters.AddWithValue("@present_status", .present_status.Trim)
			comm.Parameters.AddWithValue("@log_empcd", loginempcd.Trim)
		End With
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

		Dim docno As String = dt.Rows(0)("jobno").ToString.Trim
		Dim i As Integer = 0
		Dim j As Integer = 0
		Dim tbl_job_det As New tbl_job_det
		Dim tbl_job_det_yarn As New tbl_job_det_yarn
		SGN = docno

		Try
			For Each tbl_job_det In tbl_job.tbl_job_det
				comm = New SqlCommand("", conn)
				comm.CommandType = CommandType.StoredProcedure
				comm.Transaction = tran
				comm.CommandText = "p_job_det_insert "
				With tbl_job_det
					comm.Parameters.AddWithValue("@jobno", docno)
					comm.Parameters.AddWithValue("@id_jobdet", .id_jobdet.ToString)
					comm.Parameters.AddWithValue("@supquoteno", .supquoteno.Trim)
					comm.Parameters.AddWithValue("@outno", .outno.Trim)
					comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
					comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
					comm.Parameters.AddWithValue("@qty", .qty.ToString)
					comm.Parameters.AddWithValue("@uom", .uom.Trim)
					comm.Parameters.AddWithValue("@price", .price.ToString)
					comm.Parameters.AddWithValue("@curr", .curr.Trim)
					comm.Parameters.AddWithValue("@exrt", .exrt.ToString)
					comm.Parameters.AddWithValue("@discper", .discper.ToString)
					comm.Parameters.AddWithValue("@discamt", .discamt.ToString)
					comm.Parameters.AddWithValue("@lineamt", .lineamt.ToString)
					comm.Parameters.AddWithValue("@delidt", CDate(.delidt).ToString("yyyyMMdd"))
					comm.Parameters.AddWithValue("@rem", .remark.Trim)
					comm.Parameters.AddWithValue("@closed", .closed.ToString)
				End With
				da = New SqlDataAdapter(comm)
				dt = New DataTable
				da.Fill(dt)
				tbl_job.tbl_job_det(i).id_jobdet = dt.Rows(0)("id_jobdet")
				i += 1
				j = 0

				For Each tbl_job_det_yarn In tbl_job.tbl_job_det_yarn
					If tbl_job_det.itcd.Trim = tbl_job_det_yarn.itcd.Trim Then
						comm = New SqlCommand("", conn)
						comm.CommandType = CommandType.StoredProcedure
						comm.Transaction = tran
						comm.CommandText = "p_job_det_yarn_insert"
						With tbl_job_det_yarn
							comm.Parameters.AddWithValue("@id_job_det_yarn", .id_job_det_yarn.ToString)
							comm.Parameters.AddWithValue("@id_job_det", tbl_job.tbl_job_det(i).id_jobdet.ToString)
							comm.Parameters.AddWithValue("@lotno_sup", .lotno_sup.Trim)
							comm.Parameters.AddWithValue("@lotno_our", .lotno_our.Trim)
							comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
							comm.Parameters.AddWithValue("@boxno", .boxno.Trim)
							comm.Parameters.AddWithValue("@spools", .spools.ToString)
							comm.Parameters.AddWithValue("@kg_gr", .kg_gr.ToString)
							comm.Parameters.AddWithValue("@kg_nt", .kg_nt.ToString)
							comm.Parameters.AddWithValue("@tstamp", CDate(.tstamp).ToString("yyyyMMdd"))
						End With
						da = New SqlDataAdapter(comm)
						dt = New DataTable
						da.Fill(dt)
						tbl_job.tbl_job_det_yarn(j).id_job_det_yarn = dt.Rows(0)("id_job_det_yarn")
					End If
					j += 1
				Next
			Next
		Catch ex As Exception
			msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
		End Try

		tran.Commit()
		comm.Connection.Close()
		comm.Dispose()
		If conn.State = ConnectionState.Open Then conn.Dispose()
		conn.Dispose()
		Return True
	End Function

	Public Function InsertPurchaseOrder(ByVal Param_tbl_job As tbl_job, ByRef Purno As String, ByRef msgerr As String, Optional ByVal loginempcd As String = "") As Boolean
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		Dim tran As SqlTransaction = conn.BeginTransaction
		comm.Transaction = tran
		comm.CommandType = Data.CommandType.StoredProcedure
		comm.CommandText = "p_job_insert"
		With Param_tbl_job
			comm.Parameters.AddWithValue("@jobno", .jobno.Trim)
			comm.Parameters.AddWithValue("@jobdt", CDate(.jobdt).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
			comm.Parameters.AddWithValue("@supquoteno", .supquoteno.Trim)
			comm.Parameters.AddWithValue("@sourcedocno", .sourcedocno.Trim)
			comm.Parameters.AddWithValue("@supplang", .supplang.Trim)
			comm.Parameters.AddWithValue("@empcd", .Empcd.Trim)
			comm.Parameters.AddWithValue("@deptcd", .Deptcd.Trim)
			comm.Parameters.AddWithValue("@reqno", .reqno.Trim)
			comm.Parameters.AddWithValue("@kono", .kono.Trim)
			comm.Parameters.AddWithValue("@delidays", .delidays.ToString)
			comm.Parameters.AddWithValue("@delidt", CDate(.delidt).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@crterm", .crterm.Trim)
			comm.Parameters.AddWithValue("@crdays", .crdays.ToString)
			comm.Parameters.AddWithValue("@crdesc", .crdesc.Trim)
			comm.Parameters.AddWithValue("@paymodecd", .paymodecd.Trim)
			comm.Parameters.AddWithValue("@shipvia", .shipvia.Trim)
			comm.Parameters.AddWithValue("@jobtype", .jobtype.Trim)
			comm.Parameters.AddWithValue("@jobitcd", .jobitcd.Trim)
			comm.Parameters.AddWithValue("@tubeqty", .tubeqty.ToString)
			comm.Parameters.AddWithValue("@tubekg", .tubekg.ToString)
			comm.Parameters.AddWithValue("@twists", .twists.Trim)
			comm.Parameters.AddWithValue("@col", .col.Trim)
			comm.Parameters.AddWithValue("@packcd", .packcd.Trim)
			comm.Parameters.AddWithValue("@splins", .splins.Trim)
			comm.Parameters.AddWithValue("@rem", .remark.Trim)
			comm.Parameters.AddWithValue("@jobfor", .jobfor.Trim)
			comm.Parameters.AddWithValue("@import", .import.ToString)
			comm.Parameters.AddWithValue("@curr", .curr.Trim)
			comm.Parameters.AddWithValue("@exrt", .exrt.ToString)
			comm.Parameters.AddWithValue("@discper", .discper.ToString)
			comm.Parameters.AddWithValue("@discamt", .discamt.ToString)
			comm.Parameters.AddWithValue("@vat", .vat.ToString)
			comm.Parameters.AddWithValue("@vatamt", .vatamt.ToString)
			comm.Parameters.AddWithValue("@taxper", .taxper.ToString)
			comm.Parameters.AddWithValue("@taxamt", .taxamt.ToString)
			comm.Parameters.AddWithValue("@shipping", .shipping.ToString)
			comm.Parameters.AddWithValue("@freight", .freight.ToString)
			comm.Parameters.AddWithValue("@insurance", .insurance.ToString)
			comm.Parameters.AddWithValue("@handling", .handling.ToString)
			comm.Parameters.AddWithValue("@otheramt", .otheramt.ToString)
			comm.Parameters.AddWithValue("@other_text", .other_text.Trim)
			comm.Parameters.AddWithValue("@totamt", .totamt.ToString)
			comm.Parameters.AddWithValue("@cancel_status", .cancel_status.ToString)
			comm.Parameters.AddWithValue("@cancel_date", CDate(.cancel_date).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@shipterms", .shipterms.Trim)
			comm.Parameters.AddWithValue("@deliaddr", .deliaddr.Trim)
			comm.Parameters.AddWithValue("@tstamp", CDate(.tstamp).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@approve_status", .approve_status.ToString)
			comm.Parameters.AddWithValue("@approve_date", CDate(.approve_date).ToString("yyyyMMdd"))
			comm.Parameters.AddWithValue("@rem_app", .rem_app.Trim)
			comm.Parameters.AddWithValue("@rem_cancel", .rem_cancel.Trim)
			comm.Parameters.AddWithValue("@present_status", .present_status.Trim)
			comm.Parameters.AddWithValue("@log_empcd", loginempcd.Trim)
		End With

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

		Dim docno As String = dt.Rows(0)("jobno").ToString.Trim
		Dim i As Integer = 0
		Dim j As Integer = 0
		Dim tbl_job_det As New tbl_job_det
		Dim tbl_job_det_yarn As New tbl_job_det_yarn
		Purno = docno

		Try
			For Each tbl_job_det In Param_tbl_job.tbl_job_det
				comm = New SqlCommand("", conn)
				comm.CommandType = CommandType.StoredProcedure
				comm.Transaction = tran
				comm.CommandText = "p_job_det_insert "
				With tbl_job_det
					comm.Parameters.AddWithValue("@jobno", docno)
					comm.Parameters.AddWithValue("@id_jobdet", .id_jobdet.ToString)
					comm.Parameters.AddWithValue("@supquoteno", .supquoteno.Trim)
					comm.Parameters.AddWithValue("@outno", .outno.Trim)
					comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
					comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
					comm.Parameters.AddWithValue("@qty", .qty.ToString)
					comm.Parameters.AddWithValue("@uom", .uom.Trim)
					comm.Parameters.AddWithValue("@price", .price.ToString)
					comm.Parameters.AddWithValue("@curr", .curr.Trim)
					comm.Parameters.AddWithValue("@exrt", .exrt.ToString)
					comm.Parameters.AddWithValue("@discper", .discper.ToString)
					comm.Parameters.AddWithValue("@discamt", .discamt.ToString)
					comm.Parameters.AddWithValue("@lineamt", .lineamt.ToString)
					comm.Parameters.AddWithValue("@delidt", CDate(.delidt).ToString("yyyyMMdd"))
					comm.Parameters.AddWithValue("@rem", .remark.Trim)
					comm.Parameters.AddWithValue("@closed", .closed.ToString)
				End With
				da = New SqlDataAdapter(comm)
				dt = New DataTable
				da.Fill(dt)
				Param_tbl_job.tbl_job_det(i).id_jobdet = dt.Rows(0)("id_jobdet")
				i += 1
				j = 0

				For Each tbl_job_det_yarn In Param_tbl_job.tbl_job_det_yarn
					If tbl_job_det.itcd.Trim = tbl_job_det_yarn.itcd.Trim Then
						comm = New SqlCommand("", conn)
						comm.CommandType = CommandType.StoredProcedure
						comm.Transaction = tran
						comm.CommandText = "p_job_det_yarn_insert"
						With tbl_job_det_yarn
							comm.Parameters.AddWithValue("@id_job_det_yarn", .id_job_det_yarn.ToString)
							comm.Parameters.AddWithValue("@id_job_det", Param_tbl_job.tbl_job_det(i).id_jobdet.ToString)
							comm.Parameters.AddWithValue("@lotno_sup", .lotno_sup.Trim)
							comm.Parameters.AddWithValue("@lotno_our", .lotno_our.Trim)
							comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
							comm.Parameters.AddWithValue("@boxno", .boxno.Trim)
							comm.Parameters.AddWithValue("@spools", .spools.ToString)
							comm.Parameters.AddWithValue("@kg_gr", .kg_gr.ToString)
							comm.Parameters.AddWithValue("@kg_nt", .kg_nt.ToString)
							comm.Parameters.AddWithValue("@tstamp", CDate(.tstamp).ToString("yyyyMMdd"))
						End With
						da = New SqlDataAdapter(comm)
						dt = New DataTable
                        da.Fill(dt)
                        Param_tbl_job.tbl_job_det_yarn(j).id_job_det_yarn = dt.Rows(0)("id_job_det_yarn")
					End If
					j += 1
				Next
			Next
		Catch ex As Exception
			msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
		End Try

		tran.Commit()
		comm.Connection.Close()
		comm.Dispose()
		If conn.State = ConnectionState.Open Then conn.Dispose()
		conn.Dispose()
		Return True
	End Function

	Public Function updateYarnMaster(ByVal Param_tbl_items As tbl_Items, ByVal commandType As String, ByRef msgerr As String, Optional ByVal loginempcd As String = "") As Boolean
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		Dim tran As SqlTransaction = conn.BeginTransaction
		comm.Transaction = tran
		comm.CommandType = Data.CommandType.StoredProcedure
		Select Case commandType
			Case "NEW"
				With Param_tbl_items
					comm.CommandText = "p_items_insert"
					comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
					comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
					comm.Parameters.AddWithValue("@itdesc2", .itdesc2.Trim)
					comm.Parameters.AddWithValue("@itdesc3", .itdesc3.Trim)
					comm.Parameters.AddWithValue("@itdesct", .itdesct.Trim)
					comm.Parameters.AddWithValue("@itdesct2", .itdesct2.Trim)
					comm.Parameters.AddWithValue("@itdesct3", .itdesct3)
					comm.Parameters.AddWithValue("@itnaturecd", .itnaturecd.Trim)
					comm.Parameters.AddWithValue("@ittypecd", .ittypecd.Trim)
					comm.Parameters.AddWithValue("@itcatcd", .itcatcd.Trim)
					comm.Parameters.AddWithValue("@itsubcatcd", .itsubcatcd.Trim)
					comm.Parameters.AddWithValue("@itgroupcd", .itgroupcd.Trim)
					comm.Parameters.AddWithValue("@itsubcd", .itsubcd.Trim)
					comm.Parameters.AddWithValue("@itsubcd2", .itsubcd2.Trim)
					comm.Parameters.AddWithValue("@itsubcd3", .itsubcd3.Trim)
					comm.Parameters.AddWithValue("@mrpcode", .mrpcode.Trim)
					comm.Parameters.AddWithValue("@dinear", .dinear.Trim)
					comm.Parameters.AddWithValue("@filament", .filament.Trim)
					comm.Parameters.AddWithValue("@twists", .twists.Trim)
					comm.Parameters.AddWithValue("@col", .col.Trim)
					comm.Parameters.AddWithValue("@dimension", .dimension.Trim)
					comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
					comm.Parameters.AddWithValue("@tstamp", CDate(.tstamp).ToString("yyyyMMdd"))
				End With
			Case "EDIT"
				With Param_tbl_items
					comm.CommandText = "p_items_update"
					comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
					comm.Parameters.AddWithValue("@itdesc", .itdesc.Trim)
					comm.Parameters.AddWithValue("@itdesc2", .itdesc2.Trim)
					comm.Parameters.AddWithValue("@itdesc3", .itdesc3.Trim)
					comm.Parameters.AddWithValue("@itdesct", .itdesct.Trim)
					comm.Parameters.AddWithValue("@itdesct2", .itdesct2.Trim)
					comm.Parameters.AddWithValue("@itdesct3", .itdesct3)
					comm.Parameters.AddWithValue("@itnaturecd", .itnaturecd.Trim)
					comm.Parameters.AddWithValue("@ittypecd", .ittypecd.Trim)
					comm.Parameters.AddWithValue("@itcatcd", .itcatcd.Trim)
					comm.Parameters.AddWithValue("@itsubcatcd", .itsubcatcd.Trim)
					comm.Parameters.AddWithValue("@itgroupcd", .itgroupcd.Trim)
					comm.Parameters.AddWithValue("@itsubcd", .itsubcd.Trim)
					comm.Parameters.AddWithValue("@itsubcd2", .itsubcd2.Trim)
					comm.Parameters.AddWithValue("@itsubcd3", .itsubcd3.Trim)
					comm.Parameters.AddWithValue("@mrpcode", .mrpcode.Trim)
					comm.Parameters.AddWithValue("@dinear", .dinear.Trim)
					comm.Parameters.AddWithValue("@filament", .filament.Trim)
					comm.Parameters.AddWithValue("@twists", .twists.Trim)
					comm.Parameters.AddWithValue("@col", .col.Trim)
					comm.Parameters.AddWithValue("@dimension", .dimension.Trim)
					comm.Parameters.AddWithValue("@suppcd", .suppcd.Trim)
					comm.Parameters.AddWithValue("@tstamp", CDate(.tstamp).ToString("yyyyMMdd"))
				End With
			Case "DEL"
				With Param_tbl_items
					comm.CommandText = "p_items_update"
					comm.Parameters.AddWithValue("@itcd", .itcd.Trim)
					comm.Parameters.AddWithValue("@log_empcd", loginempcd.Trim)
				End With
		End Select

		Try
			comm.ExecuteNonQuery()
		Catch ex As Exception
			msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
		End Try

		tran.Commit()
		comm.Connection.Close()
		comm.Dispose()
		If conn.State = ConnectionState.Open Then conn.Dispose()
		conn.Dispose()
		Return True
	End Function

    Public Function deleteYarnMaster(ByVal param_itemCode As String, ByVal commandType As String, ByRef msgerr As String, Optional ByVal loginempcd As String = "") As Boolean

        'MessageBox.Show("ปิดการใช้งาน โปรดติดต่อ PROGRAMMER" _
        '   , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Dim conn As New SqlConnection(connStr.connection())
        Dim comm As New SqlCommand("", conn)
        Dim tran As SqlTransaction = conn.BeginTransaction
        comm.Transaction = tran
        comm.CommandType = Data.CommandType.StoredProcedure
        comm.CommandText = "p_items_delete"
        comm.Parameters.AddWithValue("@itcd", param_itemCode.Trim)
        comm.Parameters.AddWithValue("@log_empcd", loginempcd.Trim)
               
        Try
            comm.ExecuteNonQuery()
        Catch ex As Exception
            msgerr = ex.Message
            tran.Rollback()
            conn.Close()  'Sitthana 20190325
            Return False
        End Try
        tran.Commit()
        conn.Close()  'Sitthana 20190325
        Return True
    End Function

	Public Function CheckKeySGN_of_Month(ByVal Num As Integer, ByVal idname As String) As String
		Dim conn As New SqlConnection(connStr.connection())
		Dim comm As New SqlCommand("", conn)
		comm.CommandType = CommandType.StoredProcedure
		comm.CommandText = "p_num_select"
		comm.Parameters.AddWithValue("@idname", idname)
		comm.Parameters.AddWithValue("@yr", Year(Today()).ToString)
		Dim da As New SqlDataAdapter(comm)
		Dim dt As New DataTable
		Dim KeyMM As String = ""


        Try
            da.Fill(dt)
            conn.Close()  'Sitthana 20190325
        Catch ex As Exception
            conn.Close()  'Sitthana 20190325
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

End Class
