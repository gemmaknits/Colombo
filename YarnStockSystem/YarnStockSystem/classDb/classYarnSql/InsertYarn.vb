Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class InsertYarn
	Private ds As New DataSet
	Private connStr As New classConnection
	Private Clsconfig As New clsConfig

	Public Function InsertYarnIn(ByVal ParamYarnin As tbl_Yarn_in, ByRef msgerr As String, ByRef Purno As String, ByVal loginEmpcd As String) As Boolean
		Dim KeyGen As String
		Dim No As String
		Dim nnnn1 As Integer
		Dim Nodigits As Integer
		Dim lpadchar As String
		Dim nnnn As String
		Dim prefix As String
		Dim YY As String
		Dim MM As String
		Dim m_boxno As String
		Dim str As New StringBuilder
		Dim strAction As New StringBuilder
		Dim strCountYarnIn As New StringBuilder
		Dim GenSGN As String
		Dim getdatayarn As New GetDataYarn
		Dim instr As New StringBuilder
		Dim instrdet As String
        Dim strnnnn As String
        Dim m_format As String

		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connStr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction

		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran
			'----------------------------------Generate SGN 
			'//////////////////////CountNum tblYarnIn
			Dim m_year As String = Year(Today())

			str.Append("select * from Num where ltrim(rtrim(idname)) = 'YIN' and yr = " & m_year)
			comm.CommandText = str.ToString
			comm.ExecuteNonQuery()
			Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblKeyGen")
			If ds.Tables("TblKeyGen").Rows.Count > 0 Then
				prefix = ds.Tables("Tblkeygen").Rows(0).Item("prefix").ToString.Trim
				YY = Mid(Year(Today.Date), 3, 2).Trim
				YY = YY.PadLeft(2, "0")

				MM = Month(Today.Date).ToString.Trim
				MM = MM.PadLeft(2, "0")

				Nodigits = ds.Tables("Tblkeygen").Rows(0).Item("Nodigits").ToString
				lpadchar = ds.Tables("Tblkeygen").Rows(0).Item("lpadchar").ToString
				nnnn1 = CheckKeySGN_of_Month(Month(Today.Date), "YIN") + 1

				strnnnn = Trim(nnnn1.ToString)
				strnnnn = strnnnn.PadLeft(Nodigits, lpadchar)
				No = strnnnn
				KeyGen = prefix & YY & MM & No
			End If

			GenSGN = KeyGen

			If GenSGN = "" Then
				MsgBox("Error while generating Y-IN no., please contact IT", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
				tran.Rollback()
				Exit Function
			End If
			'strAction.Append("sp_isnert_action ")
			'strAction.Append("'")
			'strAction.Append(loginEmpcd)
			'strAction.Append("','")
			'strAction.Append(GenSGN)
			'strAction.Append("','")
			'strAction.Append(Now().ToString("yyy/MM/dd"))
			'strAction.Append("','")
			'strAction.Append("YIN")
			'strAction.Append("','")
			'strAction.Append("NEW")
			'strAction.Append("'")
			'comm.ExecuteNonQuery()

			comm.CommandType = CommandType.StoredProcedure
			comm.CommandText = "sp_insert_action"
			comm.Parameters.AddWithValue("@empcd", loginEmpcd)
			comm.Parameters.AddWithValue("@docno", GenSGN)
			comm.Parameters.AddWithValue("@workdt", Now().ToString("yyy/MM/dd"))
			comm.Parameters.AddWithValue("@doctyp", "YIN")
			comm.Parameters.AddWithValue("@worktyp", "NEW")
			comm.CommandType = CommandType.StoredProcedure
			comm.ExecuteNonQuery()

			comm.CommandType = CommandType.Text

			'----------------------------------------------
			' --------------- Get Batch no. for this lot

			Dim strBatch As New StringBuilder
			Dim recordCount As Integer
			Dim newBatchno As String
			recordCount = 0
			newBatchno = ""
			Dim m_genBatchno As Boolean
            comm.CommandText = "Select config_setting from config where config_name='GEN_YIN_INTERNAL_BATCH_NO'"
            m_genBatchno = comm.ExecuteScalar()

            'm_genBatchno = True
			If m_genBatchno = True Then
				strBatch.Append("SELECT count(*) as count from (select lotno_sup from Yarn_in where suppcd='" & ParamYarnin.suppcd & "'" & " and lotno_sup='" & ParamYarnin.lotno_sup & "'" & " Group by Lotno_sup,docno) as LotCount")
				comm.CommandText = strBatch.ToString
				' Generate batch no. only if the length of supplier lot no is more than 2 char
				If ParamYarnin.lotno_sup.Length > 0 Then
					recordCount = comm.ExecuteScalar()
					recordCount = recordCount + 1
					Dim daBatch As New SqlDataAdapter(strBatch.ToString, connStr.connection)
					da.Fill(ds, "tableBatch")
					Dim stryearlot As String = ""
					stryearlot = Right(Year(Today.Date), 2)
					'newBatchno = (ds.Tables("tableBatch").Rows.Count + 1).ToString.PadLeft(2, "0")
					newBatchno = "-" & stryearlot & recordCount.ToString.PadLeft(3, "0")
				Else
					newBatchno = ParamYarnin.lotno_sup
				End If
			Else
				newBatchno = ""
			End If

			'///////////////////insert Data in Tbl_Yarn_in
			instr.Append("insert into yarn_in(docdt,docno,jobno,purno,sinvno,sinvdt,suppcd,lotno_sup,lotno_our,")
			instr.Append("srefno,totkg,curr,exrt,vat,vatamt,taxper,taxamt,freight,insurance,otheramt,other_text, ")
			instr.Append("discamt,totamt,tstamp,tran_type,docapp,cancel,outno,remark) ")
			instr.Append("values ('" & ParamYarnin.docdt & "','" & GenSGN.Trim & "','" & ParamYarnin.jobno & "',")
			instr.Append("'" & ParamYarnin.purno & "','" & ParamYarnin.sinvno & "','" & ParamYarnin.sinvdt & "',")
			instr.Append("'" & ParamYarnin.suppcd & "','" & ParamYarnin.lotno_sup & "','" & ParamYarnin.lotno_our & newBatchno & "',")
			instr.Append("'" & ParamYarnin.srefno & "','" & ParamYarnin.totkg & "','" & ParamYarnin.curr & "',")
			instr.Append("'" & ParamYarnin.exrt & "','" & ParamYarnin.vat & "','" & ParamYarnin.vatamt & "',")
			instr.Append("'" & ParamYarnin.taxper & "','" & ParamYarnin.taxamt & "','" & ParamYarnin.freight & "',")
			instr.Append("'" & ParamYarnin.insurance & "','" & ParamYarnin.otheramt & "','" & ParamYarnin.other_text & "',")
			instr.Append("'" & ParamYarnin.discamt & "','" & ParamYarnin.taxamt & "','" & ParamYarnin.tstamp & "',")
			instr.Append("'" & ParamYarnin.tran_type & "','" & ParamYarnin.docapp & "','" & ParamYarnin.cancel & "',")
			instr.Append("'" & ParamYarnin.outno & "','" & ParamYarnin.remark & "') ")

			comm.CommandText = instr.ToString
			comm.ExecuteNonQuery()

			'///////////////////insert Data in Tbl_Yarn_in_det
			Dim tbl_Yarn_in_det As New tbl_Yarn_in_det
			'Dim Count_Yarn_in_det As Integer
			'Dim j As Integer
			'Count_Yarn_in_det = ParamYarnin.tbl_Yarn_in_det.Length - 1
			Dim sum_tran_no As Integer
			Dim boxno_tran As Long
			Dim strBoxno As String

			Dim total_num_row_yarn_in_det As Integer
			Dim old_num_intbl_num As Integer
			Dim new_num As Integer
			old_num_intbl_num = 0
			new_num = 0
			boxno_tran = 0
			sum_tran_no = 0
			total_num_row_yarn_in_det = 0
			Dim strPrefix_tran_boxno As String = ""
			Dim strsql2 As String = ""

			strsql2 = "select * from num  where idname = 'YBOXNO'  and yr = " & m_year
			'and yr =year(getdate())"
			Dim dadet As New SqlDataAdapter(strsql2, connStr.connection)
			dadet.Fill(ds, "tbl_Gen_num_boxno")
			'
			If ds.Tables("tbl_Gen_num_boxno").Rows.Count > 0 Then
				Nodigits = ds.Tables("Tbl_gen_num_boxno").Rows(0).Item("Nodigits").ToString
                lpadchar = ds.Tables("Tbl_gen_num_boxno").Rows(0).Item("lpadchar").ToString
                m_format = ds.Tables("Tbl_gen_num_boxno").Rows(0).Item("format").ToString.Trim

                boxno_tran = ds.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				boxno_tran = boxno_tran + 1
				old_num_intbl_num = ds.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				strPrefix_tran_boxno = ds.Tables("tbl_Gen_num_boxno").Rows(0).Item("prefix").ToString

			Else
				MsgBox("check data in tblnum,it Zero rows return", MsgBoxStyle.Critical, "Error in data")
				Return False
				Exit Function
			End If
			'ds.Tables("tbl_Gen_num_boxno").Clear()
			If Not IsNothing(ParamYarnin.tbl_Yarn_in_det) Then
				For Each tbl_Yarn_in_det In ParamYarnin.tbl_Yarn_in_det
					strBoxno = Trim(boxno_tran.ToString)
                    strBoxno = strBoxno.PadLeft(Nodigits, lpadchar)
                    YY = Mid(Year(Today.Date), 3, 2).Trim
                    YY = YY.PadLeft(2, "0")

                    MM = Month(Today.Date).ToString.Trim
                    MM = MM.PadLeft(2, "0")

                    If m_format = "" Then
                        m_boxno = strPrefix_tran_boxno.Trim & strBoxno.ToString.Trim
                    End If
                    If UCase(m_format) = "YY" Then
                        m_boxno = strPrefix_tran_boxno.Trim & YY & strBoxno.ToString.Trim
                    End If

                    If UCase(m_format) = "YYMM" Then
                        m_boxno = strPrefix_tran_boxno.Trim & YY & MM & strBoxno.ToString.Trim
					End If
					' if no format is specified do as follows
					If UCase(m_format) <> "YY" And UCase(m_format) <> "YYMM" Then
						m_boxno = strPrefix_tran_boxno.Trim & strBoxno.ToString.Trim
					End If

                    total_num_row_yarn_in_det = total_num_row_yarn_in_det + 1
                    'For j = 0 To Count_Yarn_in_det
                    'instrdet = ""
                    instrdet = "insert into Yarn_in_det(docno,itcd,boxno_s,boxno,boxno_o,spools,grade," & _
                      "kg_gr,cart_tearwt,spool_tearwt,kg_nt,price,tstamp,lotno_sup,lotno_our) " & _
                      "values('" & GenSGN & "','" & tbl_Yarn_in_det.itcd.Trim & "','" & tbl_Yarn_in_det.boxno_s.Trim & "'," & _
                      "'" & m_boxno & "','','" & tbl_Yarn_in_det.spools & "'," & _
                      "'" & tbl_Yarn_in_det.grade.Trim & "','" & tbl_Yarn_in_det.kg_gr & "','" & tbl_Yarn_in_det.cart_tearwt & "'," & _
                      "'" & tbl_Yarn_in_det.spool_tearwt & "','" & tbl_Yarn_in_det.kg_nt & "','" & tbl_Yarn_in_det.price & "'," & _
                      "'" & tbl_Yarn_in_det.tstamp & "','" & tbl_Yarn_in_det.lotno_sup & "','" & tbl_Yarn_in_det.lotno_our & newBatchno & "') "

                    comm.CommandText = instrdet
                    comm.ExecuteNonQuery()
                    boxno_tran = boxno_tran + 1
                Next
			End If

			new_num = old_num_intbl_num + total_num_row_yarn_in_det
			strsql2 = "Update Num set num = '" & new_num & "' where idname = 'YBOXNO' and yr = " & m_year
			comm.CommandText = strsql2.ToString
			comm.ExecuteNonQuery()

			Dim strnum As New StringBuilder
			strnum.Append("update num set ")

			Select Case Month(Today.Date)
				Case 1
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num1").ToString.Trim
					num = num + 1
					strnum.Append(" num1 = '" & num & "'")
				Case 2
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num2").ToString.Trim
					num = num + 1
					strnum.Append(" num2 = '" & num & "'")
				Case 3
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num3").ToString.Trim
					num = num + 1
					strnum.Append(" num3 = '" & num & "'")
				Case 4
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num4").ToString.Trim
					num = num + 1
					strnum.Append(" num4 = '" & num & "'")
				Case 5
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num5").ToString.Trim
					num = num + 1
					strnum.Append(" num5 = '" & num & "'")
				Case 6
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num6").ToString.Trim
					num = num + 1
					strnum.Append(" num6 = '" & num & "'")
				Case 7
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num7").ToString.Trim
					num = num + 1
					strnum.Append(" num7 = '" & num & "'")
				Case 8
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num8").ToString.Trim
					num = num + 1
					strnum.Append(" num8 = '" & num & "'")
				Case 9
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num9").ToString.Trim
					num = num + 1
					strnum.Append(" num9 = '" & num & "'")
				Case 10
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num10").ToString.Trim
					num = num + 1
					strnum.Append(" num10 = '" & num & "'")
				Case 11
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num11").ToString.Trim
					num = num + 1
					strnum.Append(" num11  = '" & num & "'")
				Case 12
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num12").ToString.Trim
					num = num + 1
					strnum.Append(" num12 = '" & num & "'")
			End Select

			ds.Tables("Tblkeygen").Clear()
			strnum.Append(" where ltrim(rtrim(idname)) = 'YIN' and yr = " & m_year)

			comm.CommandText = strnum.ToString
			comm.ExecuteNonQuery()
			'Next
			Purno = GenSGN
			tran.Commit()
			Return True

		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		Finally
			conn.Close()
		End Try
	End Function
	Public Function InsertYarnInReturn(ByVal ParamYarnin As tbl_Yarn_in, ByRef msgerr As String, ByRef Purno As String, ByVal loginempcd As String) As Boolean
		Dim KeyGen As String
		Dim No As String
		Dim nnnn1 As Integer
		Dim Nodigits As String
		Dim lpadchar As String
		Dim nnnn As String
		Dim prefix As String
		Dim YY As String
		Dim MM As String
		Dim str As New StringBuilder
		Dim strCountYarnIn As New StringBuilder
		Dim strsqlGenboxno As String = ""
		Dim GenSGN As String
		Dim getdatayarn As New GetDataYarn
		Dim instr As New StringBuilder
		Dim instrdet As String
		Dim strnnnn As String
		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connStr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction
		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran

			'----------------------------------Generate SGN 
			'//////////////////////CountNum tblYarnIn
			Dim m_year As String = Year(Today())
			str.Append("select * from Num where ltrim(rtrim(idname)) = 'YIN' and yr = " & m_year)
			comm.CommandText = str.ToString
			'comm.ExecuteNonQuery()

			Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblKeyGen")
			If ds.Tables("TblKeyGen").Rows.Count > 0 Then
				prefix = ds.Tables("Tblkeygen").Rows(0).Item("prefix").ToString.Trim
				YY = Mid(Year(Today.Date), 3, 2)
				MM = Month(Today.Date)
				Nodigits = ds.Tables("Tblkeygen").Rows(0).Item("Nodigits").ToString
				lpadchar = ds.Tables("Tblkeygen").Rows(0).Item("lpadchar").ToString
				nnnn1 = CheckKeySGN_of_Month(Month(Today.Date), "YOUT") + 1

				strnnnn = Trim(nnnn1.ToString)
				strnnnn = strnnnn.PadLeft(Nodigits - strnnnn.Length, lpadchar)
				No = strnnnn
                KeyGen = "R" & prefix & YY & MM & No
			End If

			GenSGN = KeyGen

			'--------------------
			comm.CommandType = CommandType.StoredProcedure
			comm.CommandText = "sp_insert_action"
			comm.Parameters.AddWithValue("@empcd", loginempcd)
			comm.Parameters.AddWithValue("@docno", GenSGN)
			comm.Parameters.AddWithValue("@workdt", Now().ToString("yyy/MM/dd"))
			comm.Parameters.AddWithValue("@doctyp", "YIRET")
			comm.Parameters.AddWithValue("@worktyp", "NEW")
			comm.CommandType = CommandType.StoredProcedure
            comm.ExecuteNonQuery()
            comm.CommandType = CommandType.Text

			'--------------------

			'ds.Tables("TblKeyGen").Clear()
			'----------------------------------------------
			' --------------- Get Batch no. for this lot
			Dim strBatch As New StringBuilder
			Dim recordCount As Integer
			strBatch.Append("SELECT count(*) as count from (select lotno_sup from Yarn_in where suppcd='" & ParamYarnin.suppcd & "'" & " and lotno_sup='" & ParamYarnin.lotno_sup & "'" & " Group by Lotno_sup,docno) as LotCount")
			comm.CommandText = strBatch.ToString
			recordCount = comm.ExecuteScalar()
			recordCount = recordCount + 1
			Dim daBatch As New SqlDataAdapter(strBatch.ToString, connStr.connection)
			da.Fill(ds, "tableBatch")
			Dim newBatchno As String
			Dim stryearlot As String = ""
			stryearlot = Year(Today.Date)
			newBatchno = (ds.Tables("tableBatch").Rows.Count + 1).ToString.PadLeft(2, "0")
			newBatchno = "-" & stryearlot & recordCount.ToString.PadLeft(2, "0")

			'///////////////////insert Data in Tbl_Yarn_in
			instr.Append("insert into yarn_in(docdt,docno,jobno,purno,sinvno,sinvdt,suppcd,lotno_sup,lotno_our,")
			instr.Append("srefno,totkg,curr,exrt,vat,vatamt,taxper,taxamt,freight,insurance,otheramt,other_text, ")
			instr.Append("discamt,totamt,tstamp,tran_type,docapp,cancel,outno,remark) ")
			instr.Append("values('" & ParamYarnin.docdt & "','" & GenSGN.ToString.Trim & "','" & ParamYarnin.jobno & "',")
			instr.Append("'" & ParamYarnin.purno & "','" & ParamYarnin.sinvno & "','" & ParamYarnin.sinvdt & "',")
			instr.Append("'" & ParamYarnin.suppcd & "','" & ParamYarnin.lotno_sup & "','" & ParamYarnin.lotno_our & newBatchno & "',")
			instr.Append("'" & ParamYarnin.srefno & "','" & ParamYarnin.totkg & "','" & ParamYarnin.curr & "',")
			instr.Append("'" & ParamYarnin.exrt & "','" & ParamYarnin.vat & "','" & ParamYarnin.vatamt & "',")
			instr.Append("'" & ParamYarnin.taxper & "','" & ParamYarnin.taxamt & "','" & ParamYarnin.freight & "',")
			instr.Append("'" & ParamYarnin.insurance & "','" & ParamYarnin.otheramt & "','" & ParamYarnin.other_text & "',")
			instr.Append("'" & ParamYarnin.discamt & "','" & ParamYarnin.taxamt & "','" & ParamYarnin.tstamp & "',")
			instr.Append("'" & ParamYarnin.tran_type & "','" & ParamYarnin.docapp & "','" & ParamYarnin.cancel & "',")
			instr.Append("'" & ParamYarnin.outno & "','" & ParamYarnin.remark & "') ")

			comm.CommandText = instr.ToString
			comm.ExecuteNonQuery()
			'///////////////////insert Data in Tbl_Yarn_in_det
			Dim tbl_Yarn_in_det As New tbl_Yarn_in_det
			'Dim Count_Yarn_in_det As Integer
			'Dim j As Integer
			'Count_Yarn_in_det = ParamYarnin.tbl_Yarn_in_det.Length - 1
			Dim sum_tran_no As Integer
			Dim boxno_tran As Long
			Dim total_num_row_yarn_in_det As Integer
			Dim old_num_intbl_num As Integer
			Dim new_num As Integer
			old_num_intbl_num = 0
			new_num = 0
			boxno_tran = 0
			sum_tran_no = 0
			total_num_row_yarn_in_det = 0
			Dim strPrefix_tran_boxno As String = ""
			Dim strsql2 As String = ""
			strsql2 = "select * from num  where idname = 'YBOXNO'  and yr = " & m_year
			'and yr =year(getdate())"
			Dim dadet As New SqlDataAdapter(strsql2, connStr.connection)
			dadet.Fill(ds, "tbl_Gen_num_boxno")
			If ds.Tables("tbl_Gen_num_boxno").Rows.Count > 0 Then
				boxno_tran = ds.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				boxno_tran = boxno_tran + 1
				old_num_intbl_num = ds.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				strPrefix_tran_boxno = "RT"
			Else
				MsgBox("check data in tblnum,it Zero rows return", MsgBoxStyle.Critical, "Error in data")
				Return False
				Exit Function
			End If
			'ds.Tables("tbl_Gen_num_boxno").Clear()
			If Not IsNothing(ParamYarnin.tbl_Yarn_in_det) Then
				For Each tbl_Yarn_in_det In ParamYarnin.tbl_Yarn_in_det
					total_num_row_yarn_in_det = total_num_row_yarn_in_det + 1
					'For j = 0 To Count_Yarn_in_det
                    'instrdet = ""
                    If tbl_Yarn_in_det.Used = 1 Then
                        strPrefix_tran_boxno = "BR"
                    Else
                        strPrefix_tran_boxno = "RF"
                    End If
                    instrdet = "insert into Yarn_in_det(docno,itcd,boxno_s,boxno,boxno_o,spools,grade," & _
                      "kg_gr,cart_tearwt,spool_tearwt,kg_nt,price,tstamp,lotno_sup,lotno_our,used) " & _
                      "values('" & GenSGN & "','" & tbl_Yarn_in_det.itcd.Trim & "','" & tbl_Yarn_in_det.boxno_s.Trim & "'," & _
                      "'" & strPrefix_tran_boxno.Trim & boxno_tran.ToString.Trim & "','" & tbl_Yarn_in_det.boxno_o.Trim & "','" & tbl_Yarn_in_det.spools & "'," & _
                      "'" & tbl_Yarn_in_det.grade.Trim & "','" & tbl_Yarn_in_det.kg_gr & "','" & tbl_Yarn_in_det.cart_tearwt & "'," & _
                      "'" & tbl_Yarn_in_det.spool_tearwt & "','" & tbl_Yarn_in_det.kg_nt & "','" & tbl_Yarn_in_det.price & "'," & _
                      "'" & tbl_Yarn_in_det.tstamp & "','" & ParamYarnin.lotno_sup & "','" & ParamYarnin.lotno_our & newBatchno & "'," & tbl_Yarn_in_det.Used & ") "

                    comm.CommandText = instrdet
                    comm.ExecuteNonQuery()
                    boxno_tran = boxno_tran + 1

                Next
			End If
			new_num = old_num_intbl_num + total_num_row_yarn_in_det
			strsql2 = "Update Num set num = '" & new_num & "' where idname = 'YBOXNO'  and yr = " & m_year
			comm.CommandText = strsql2.ToString
			comm.ExecuteNonQuery()
			Dim strnum As New StringBuilder
			strnum.Append("update num set ")
			Select Case Month(Today.Date)
				Case 1
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num1").ToString.Trim
					num = num + 1
					strnum.Append(" num1 = '" & num & "'")
				Case 2
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num2").ToString.Trim
					num = num + 1
					strnum.Append(" num2 = '" & num & "'")
				Case 3
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num3").ToString.Trim
					num = num + 1
					strnum.Append(" num3 = '" & num & "'")
				Case 4
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num4").ToString.Trim
					num = num + 1
					strnum.Append(" num4 = '" & num & "'")
				Case 5
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num5").ToString.Trim
					num = num + 1
					strnum.Append(" num5 = '" & num & "'")
				Case 6
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num6").ToString.Trim
					num = num + 1
					strnum.Append(" num6 = '" & num & "'")
				Case 7
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num7").ToString.Trim
					num = num + 1
					strnum.Append(" num7 = '" & num & "'")
				Case 8
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num8").ToString.Trim
					num = num + 1
					strnum.Append(" num8 = '" & num & "'")
				Case 9
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num9").ToString.Trim
					num = num + 1
					strnum.Append(" num9 = '" & num & "'")
				Case 10
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num10").ToString.Trim
					num = num + 1
					strnum.Append(" num10 = '" & num & "'")
				Case 11
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num11").ToString.Trim
					num = num + 1
					strnum.Append(" num11  = '" & num & "'")
				Case 12
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num12").ToString.Trim
					num = num + 1
					strnum.Append(" num12 = '" & num & "'")
			End Select
			strnum.Append(" where ltrim(rtrim(idname)) = 'YIN' and yr = " & m_year)

			comm.CommandText = strnum.ToString
			comm.ExecuteNonQuery()
			'Next
			Purno = GenSGN
			tran.Commit()
			Return True

		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		Finally
			conn.Close()
		End Try
	End Function

	Public Function CheckKeySGN_of_Month(ByVal Num As Integer, ByVal idname As String) As String
		Dim str As New StringBuilder
		Dim KeyMM As Integer
		Dim m_year As String = Year(Today())
		str.Append("select * from Num where ltrim(rtrim(idname)) = '" & idname & "'" & " AND Yr = " & m_year)
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "TblMMGen")
		If ds.Tables("TblMMGen").Rows.Count > 0 Then
            If ds.Tables("tblMMGen").Rows(0).Item("format").ToString.Trim.ToUpper = "YY" Then
                KeyMM = ds.Tables("tblMMGen").Rows(0).Item("num")
                Return KeyMM
            End If
			Select Case Num
				Case 1
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num1")
					Return KeyMM
				Case 2
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num2")
					Return KeyMM
				Case 3
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num3")
					Return KeyMM
				Case 4
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num4")
					Return KeyMM
				Case 5
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num5")
					Return KeyMM
				Case 6
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num6")
					Return KeyMM
				Case 7
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num7")
					Return KeyMM
				Case 8
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num8")
					Return KeyMM
				Case 9
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num9")
					Return KeyMM
				Case 10
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num10")
					Return KeyMM
				Case 11
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num11")
					Return KeyMM
				Case 12
					KeyMM = ds.Tables("TblMMGen").Rows(0).Item("num12")
					Return KeyMM
			End Select
		End If
	End Function

	Public Function InsertYarnOut(ByVal paramtbl_yarn_out As tbl_Yarn_out, ByRef Youtno As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
		Dim strcountyarnout As New StringBuilder
		Dim str As New StringBuilder
		Dim nnnn As String
		Dim prefix As String
		Dim YY As String
		Dim MM As String
		Dim KeyGen As String
		Dim No As String
		Dim GenSGN As String
		Dim nnnn1 As Integer
		Dim Nodigits As Integer
		Dim lpadchar As String
		Dim strnnnn As String

		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connStr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction
		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran

			'----------------------------------Generate SGN 

			'//////////////////////CountNum tblYarnIn

			strcountyarnout.Append("select * from yarn_out ")
			comm.CommandText = strcountyarnout.ToString
			comm.ExecuteNonQuery()

			Dim daCount As New SqlDataAdapter(strcountyarnout.ToString, connStr.connection)
			daCount.Fill(ds, "TblCountNumYarnout")
			If ds.Tables("TblCountNumYarnout").Rows.Count > 0 Then
				nnnn = ds.Tables("TblCountNumYarnout").Rows.Count
			Else
				nnnn = 0
			End If

			Dim m_year As String = Year(Today())
			str.Append("select * from Num where ltrim(rtrim(idname)) = 'YOUT' and yr = " & m_year)
			comm.CommandText = str.ToString
			comm.ExecuteNonQuery()
			Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblKeyGen")
			If ds.Tables("TblKeyGen").Rows.Count > 0 Then
				prefix = ds.Tables("Tblkeygen").Rows(0).Item("prefix").ToString.Trim
				YY = Mid(Year(Today.Date), 3, 2).PadLeft(2, "0")
				MM = Month(Today.Date).ToString.PadLeft(2, "0")
				Nodigits = ds.Tables("Tblkeygen").Rows(0).Item("Nodigits").ToString
				lpadchar = ds.Tables("Tblkeygen").Rows(0).Item("lpadchar").ToString
				nnnn1 = CheckKeySGN_of_Month(Month(Today.Date), "YOUT") + 1

				strnnnn = Trim(nnnn1.ToString)
				strnnnn = strnnnn.PadLeft(Nodigits, lpadchar)
				No = strnnnn
				KeyGen = prefix & YY & MM & No
			End If

			GenSGN = KeyGen

			'-----------
			comm.CommandType = CommandType.StoredProcedure
			comm.CommandText = "sp_insert_action"
			comm.Parameters.AddWithValue("@empcd", loginEmpcd)
			comm.Parameters.AddWithValue("@docno", GenSGN)
			comm.Parameters.AddWithValue("@workdt", Now().ToString("yyy/MM/dd"))
			comm.Parameters.AddWithValue("@doctyp", "YOUT")
			comm.Parameters.AddWithValue("@worktyp", "NEW")
			comm.CommandType = CommandType.StoredProcedure
			comm.ExecuteNonQuery()

			comm.CommandType = CommandType.Text
			'-------------------
			'------------------------------Insert tbl_yarn_out and tbl_yarn_out_det
			Dim strYarnout As New StringBuilder
			Dim strYarnoutdet As String
			strYarnout.Append("insert into yarn_out(outno,outdt,tran_type,refdocno,rem,suppcd) ")
			strYarnout.Append("values('" & GenSGN & "','" & paramtbl_yarn_out.outdt & "','" & paramtbl_yarn_out.tran_type & "','" & paramtbl_yarn_out.refdocno & "','" & paramtbl_yarn_out.remm & "','" & paramtbl_yarn_out.suppcd & "')")
			comm.CommandText = strYarnout.ToString
			comm.ExecuteNonQuery()
			If Not IsNothing(paramtbl_yarn_out.tbl_Yarn_out_det) Then
				Dim tbl_yarn_out_det As New tbl_Yarn_out_det
				For Each tbl_yarn_out_det In paramtbl_yarn_out.tbl_Yarn_out_det
					strYarnoutdet = "insert into Yarn_out_det(outno,itcd,grade,boxno_s,boxno,spools,kg_gr,cart_tearwt,kg_nt) " & _
					   "values('" & GenSGN & "','" & tbl_yarn_out_det.itcd & "','" & tbl_yarn_out_det.grade & "','" & tbl_yarn_out_det.boxno_s & "'" & _
					   ",'" & tbl_yarn_out_det.boxno & "','" & tbl_yarn_out_det.spools & "','" & tbl_yarn_out_det.kg_gr & "'" & _
					   ",'" & tbl_yarn_out_det.cart_tearwt & "','" & tbl_yarn_out_det.kg_nt & "')"

					comm.CommandText = strYarnoutdet
					comm.ExecuteNonQuery()
				Next
			End If

			Dim strnum As New StringBuilder
			strnum.Append("update num set ")
			Select Case Month(Today.Date)
				Case 1
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num1").ToString.Trim
					num = num + 1
					strnum.Append(" num1 = '" & num & "'")
				Case 2
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num2").ToString.Trim
					num = num + 1
					strnum.Append(" num2 = '" & num & "'")
				Case 3
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num3").ToString.Trim
					num = num + 1
					strnum.Append(" num3 = '" & num & "'")
				Case 4
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num4").ToString.Trim
					num = num + 1
					strnum.Append(" num4 = '" & num & "'")
				Case 5
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num5").ToString.Trim
					num = num + 1
					strnum.Append(" num5 = '" & num & "'")
				Case 6
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num6").ToString.Trim
					num = num + 1
					strnum.Append(" num6 = '" & num & "'")
				Case 7
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num7").ToString.Trim
					num = num + 1
					strnum.Append(" num7 = '" & num & "'")
				Case 8
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num8").ToString.Trim
					num = num + 1
					strnum.Append(" num8 = '" & num & "'")
				Case 9
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num9").ToString.Trim
					num = num + 1
					strnum.Append(" num9 = '" & num & "'")
				Case 10
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num10").ToString.Trim
					num = num + 1
					strnum.Append(" num10 = '" & num & "'")
				Case 11
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num11").ToString.Trim
					num = num + 1
					strnum.Append(" num11  = '" & num & "'")
				Case 12
					Dim num As String
					num = ds.Tables("Tblkeygen").Rows(0).Item("num12").ToString.Trim
					num = num + 1
					strnum.Append(" num12 = '" & num & "'")
			End Select

			strnum.Append(" where ltrim(rtrim(idname)) = 'YOUT' and YR = " & m_year)

			comm.CommandText = strnum.ToString
			comm.ExecuteNonQuery()

			Youtno = GenSGN
			'-------------------------------------------------
			tran.Commit()
			Return True
		Catch ex As Exception
			tran.Rollback()
			msgerr = ex.Message
			Return False
		Finally
			conn.Close()
		End Try
	End Function

	Public Function InsertJobOrderforYarn(ByVal tbl_job As tbl_job, ByRef SGN As String, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
		Dim strcountyarnout As New StringBuilder
		Dim str As New StringBuilder
		Dim nnnn As String
		Dim prefix As String
		Dim YY As String
		Dim MM As String
		Dim KeyGen As String
		Dim No As String
		Dim GenSGN As String
		Dim nnnn1 As Integer
		Dim Nodigits As String
		Dim lpadchar As String
		Dim strnnnn As String
		Dim strJob As New StringBuilder
		Dim m_id_job_det As Integer
		Dim k As Integer

		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connStr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction

		'--------------------------------------------
		Try

			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran

			'------------------ Generate SGN ---------------------
			Dim m_year As String = Year(Today())

			str.Append("select * from Num where ltrim(rtrim(idname)) = 'JOB' and yr = " & m_year)
			comm.CommandText = str.ToString
			comm.ExecuteNonQuery()
			Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblKeyGen")
			If ds.Tables("TblKeyGen").Rows.Count > 0 Then
				prefix = ds.Tables("Tblkeygen").Rows(0).Item("prefix").ToString.Trim
				YY = Mid(Year(Today.Date), 3, 2)
				MM = Month(Today.Date)
				Nodigits = ds.Tables("Tblkeygen").Rows(0).Item("Nodigits").ToString
				lpadchar = ds.Tables("Tblkeygen").Rows(0).Item("lpadchar").ToString
				nnnn1 = CheckKeySGN_of_Month(Month(Today.Date), "JOB") + 1

				strnnnn = Trim(nnnn1.ToString)
				strnnnn = strnnnn.PadLeft(Nodigits, lpadchar)
				No = strnnnn
				KeyGen = prefix & YY & No
			End If

			GenSGN = KeyGen

			'--------------------
			comm.CommandType = CommandType.StoredProcedure
			comm.CommandText = "sp_insert_action"
			comm.Parameters.AddWithValue("@empcd", loginEmpcd)
			comm.Parameters.AddWithValue("@docno", GenSGN)
			comm.Parameters.AddWithValue("@workdt", Now().ToString("yyy/MM/dd"))
			comm.Parameters.AddWithValue("@doctyp", "JOB")
			comm.Parameters.AddWithValue("@worktyp", "NEW")
			comm.CommandType = CommandType.StoredProcedure
			comm.ExecuteNonQuery()
			comm.CommandType = CommandType.Text
			'--------------------

			'------------------------- Insert job
			strJob.Append("insert into job(jobno, jobdt, suppcd, reqno,kono, jobtype, jobitcd, tubeqty, tubekg, twists, ")
			strJob.Append("col,packcd,splins,rem,jobfor,import,curr,exrt,vat,vatamt,taxper,")
			strJob.Append("taxamt,freight,insurance,otheramt,other_text,totamt,cancel_status) ")
			strJob.Append("values('" & GenSGN & "','" & tbl_job.jobdt & "','" & tbl_job.suppcd & "'")
			strJob.Append(",'" & tbl_job.reqno & "','" & tbl_job.kono & "','" & tbl_job.jobtype & "','" & tbl_job.jobitcd & "'")
			strJob.Append(",'" & tbl_job.tubeqty & "','" & tbl_job.tubekg & "','" & tbl_job.twists & "'")
			strJob.Append(",'" & tbl_job.col & "','" & tbl_job.packcd & "','" & tbl_job.splins & "','" & tbl_job.remark & "'")
			strJob.Append(",'" & tbl_job.jobfor & "','" & tbl_job.import & "','" & tbl_job.curr & "'")
			strJob.Append(",'" & tbl_job.exrt & "','" & tbl_job.vat & "','" & tbl_job.vatamt & "'")
			strJob.Append(",'" & tbl_job.taxper & "','" & tbl_job.taxamt & "','" & tbl_job.freight & "'")
			strJob.Append(",'" & tbl_job.insurance & "','" & tbl_job.otheramt & "','" & tbl_job.other_text & "'")
			strJob.Append(",'" & tbl_job.totamt & "','" & tbl_job.cancel_status & "')")

			comm.CommandText = strJob.ToString
			comm.ExecuteNonQuery()

			'----------------------------------------------------------------

			'----------------------- Insert job_det ------------------------
			Dim tbl_job_det As New tbl_job_det
			Dim tbl_job_det_yarn As New tbl_job_det_yarn
			Dim sql_job_det As String
			Dim sql_job_det_yarn As String
			Dim id_job_det As String

			For Each tbl_job_det In tbl_job.tbl_job_det
				'sql_job_det = ""
				sql_job_det = "insert into job_det(jobno,outno" & _
				",itcd,itdesc,qty,uom,price,curr,exrt,discper,discamt,lineamt,rem,closed) " & _
				"values('" & GenSGN & "','" & tbl_job_det.outno & "'" & _
				",'" & tbl_job_det.itcd & "','" & tbl_job_det.itdesc & "','" & tbl_job_det.qty & "'" & _
				",'" & tbl_job_det.uom & "','" & tbl_job_det.price & "','" & tbl_job_det.curr & "'" & _
				",'" & tbl_job_det.exrt & "','" & tbl_job_det.discper & "','" & tbl_job_det.discamt & "'" & _
				   ",'" & tbl_job_det.lineamt & "','" & tbl_job_det.remark & "','" & tbl_job_det.closed & "' )"

				comm.CommandText = sql_job_det
				k = comm.ExecuteNonQuery()
				'sql_job_det_yarn = " declare @Key_id_job_det as integer " & _
				'  " Select @Key_id_job_det = SCOPE_IDENTITY() "

				comm.CommandText = "select ident_current('job_det')"
				m_id_job_det = comm.ExecuteScalar()

				'--------------------  Insert job_det_yarn -------------------

				For Each tbl_job_det_yarn In tbl_job.tbl_job_det_yarn
					If tbl_job_det.itcd.Trim = tbl_job_det_yarn.itcd.Trim Then
						sql_job_det_yarn = sql_job_det_yarn & " insert into job_det_yarn(id_job_det,lotno_sup," & _
						"lotno_our,itcd,boxno,spools,kg_gr,kg_nt) " & _
						"values(" & m_id_job_det & ",'" & tbl_job_det_yarn.lotno_sup & "'" & _
						",'" & tbl_job_det_yarn.lotno_our & "','" & tbl_job_det_yarn.itcd & "','" & tbl_job_det_yarn.boxno & "'" & _
						",'" & tbl_job_det_yarn.spools & "','" & tbl_job_det_yarn.kg_gr & "','" & tbl_job_det_yarn.kg_nt & "')"
					End If
				Next
				comm.CommandText = sql_job_det_yarn
				comm.ExecuteNonQuery()
				'----------------------------------------------------------------
			Next
			'------------------------- Update SGN of table_num ---------------

			Dim strnum As New StringBuilder
			strnum.Append("update num set ")
            If ds.Tables("TblKeyGen").Rows(0).Item("format").ToString.ToUpper.Trim = "YY" Then
                Dim num As String
                num = ds.Tables("Tblkeygen").Rows(0).Item("num").ToString.Trim
                num = num + 1
                strnum.Append(" num = '" & num & "'")
            Else

                Select Case Month(Today.Date)
                    Case 1
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num1").ToString.Trim
                        num = num + 1
                        strnum.Append(" num1 = '" & num & "'")
                    Case 2
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num2").ToString.Trim
                        num = num + 1
                        strnum.Append(" num2 = '" & num & "'")
                    Case 3
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num3").ToString.Trim
                        num = num + 1
                        strnum.Append(" num3 = '" & num & "'")
                    Case 4
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num4").ToString.Trim
                        num = num + 1
                        strnum.Append(" num4 = '" & num & "'")
                    Case 5
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num5").ToString.Trim
                        num = num + 1
                        strnum.Append(" num5 = '" & num & "'")
                    Case 6
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num6").ToString.Trim
                        num = num + 1
                        strnum.Append(" num6 = '" & num & "'")
                    Case 7
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num7").ToString.Trim
                        num = num + 1
                        strnum.Append(" num7 = '" & num & "'")
                    Case 8
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num8").ToString.Trim
                        num = num + 1
                        strnum.Append(" num8 = '" & num & "'")
                    Case 9
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num9").ToString.Trim
                        num = num + 1
                        strnum.Append(" num9 = '" & num & "'")
                    Case 10
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num10").ToString.Trim
                        num = num + 1
                        strnum.Append(" num10 = '" & num & "'")
                    Case 11
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num11").ToString.Trim
                        num = num + 1
                        strnum.Append(" num11  = '" & num & "'")
                    Case 12
                        Dim num As String
                        num = ds.Tables("Tblkeygen").Rows(0).Item("num12").ToString.Trim
                        num = num + 1
                        strnum.Append(" num12 = '" & num & "'")
                End Select
            End If
			strnum.Append(" where ltrim(rtrim(idname)) = 'JOB' and yr = " & m_year)

			comm.CommandText = strnum.ToString
			comm.ExecuteNonQuery()
			'-----------------------------------------------------------------

			tran.Commit()
			SGN = GenSGN
			Return True
		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		Finally
			conn.Close()
		End Try
	End Function

	Public Function InsertYarnMaster(ByVal Param_tbl_items As tbl_Items, ByRef msgerr As String) As Boolean
		Dim str As New StringBuilder
		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connStr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction
		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran

			str.Append("insert into items")
			str.Append("(itcd,itdesc,itdesc2,itdesct,itdesct2,itnaturecd,ittypecd,")
			str.Append("itcatcd,itsubcatcd,itgroupcd,itsubcd,itsubcd2,itsubcd3,mrpcode,")
			str.Append("dinear,filament,twists,col,dimension,suppcd,tstamp) ")
			str.Append("values('" & Param_tbl_items.itcd & "','" & Param_tbl_items.itdesc & "','" & Param_tbl_items.itdesc2 & "',")
			str.Append("'" & Param_tbl_items.itdesct & "','" & Param_tbl_items.itdesct2 & "','" & Param_tbl_items.itnaturecd & "',")
			str.Append("'" & Param_tbl_items.ittypecd & "','" & Param_tbl_items.itcatcd & "','" & Param_tbl_items.itsubcatcd & "',")
			str.Append("'" & Param_tbl_items.itgroupcd & "','" & Param_tbl_items.itsubcd & "','" & Param_tbl_items.itsubcd2 & "',")
			str.Append("'" & Param_tbl_items.itsubcd3 & "','" & Param_tbl_items.mrpcode & "','" & Param_tbl_items.dinear & "',")
			str.Append("'" & Param_tbl_items.filament & "','" & Param_tbl_items.twists & "','" & Param_tbl_items.col & "',")
			str.Append("'" & Param_tbl_items.dimension & "','" & Param_tbl_items.suppcd & "',")
			str.Append("getdate())")

			comm.CommandText = str.ToString
			comm.ExecuteNonQuery()

			tran.Commit()
			Return True
		Catch ex As Exception
			msgerr = ex.Message
			tran.Rollback()
			Return False
		Finally
			conn.Close()
		End Try
	End Function

End Class
