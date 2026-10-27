Imports System.Text
Imports System.Data.SqlClient
Imports System.Data

Public Class UpdateYarn
	Private connstr As New classConnection

	Public Function UpdateYarnIn(ByVal Param_YarnIn As tbl_Yarn_in, ByVal ds_Yarn_in_det As DataTable, ByRef Msgerr As String, ByVal da As SqlDataAdapter, ByVal loginEmpcd As String) As Boolean
		Dim strupt As New StringBuilder
		Dim conn As SqlConnection = New SqlConnection
		Dim recordCount As Integer
		Dim strBatch As New StringBuilder
		Dim newBatchno As String = Param_YarnIn.lotno_our
		Dim ds As New DataSet
		Dim m_genBatchno As Boolean = True
		Dim tran As SqlTransaction
		Dim m_lotChanged As Boolean = False
		Dim strCheckLot As New StringBuilder

		conn.ConnectionString = connstr.connection
		conn.Open()
		tran = conn.BeginTransaction
		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran

			'----------
			comm.CommandType = CommandType.StoredProcedure
			comm.CommandText = "log_yarn_in"
			comm.Parameters.AddWithValue("@empcd", loginEmpcd)
			comm.Parameters.AddWithValue("@docno", Param_YarnIn.docno.Trim)
			comm.Parameters.AddWithValue("@action", "EDIT")
			comm.ExecuteNonQuery()

			comm.CommandType = CommandType.Text

			' --------------- Get Batch no. for this lot 
			' --------------- but check if the existing supplier lot was changed

			strCheckLot.Append("Select count(*) from yarn_in where docno='")
			strCheckLot.Append(Param_YarnIn.docno.Trim & "'")
			strCheckLot.Append(" and lotno_sup='")
			strCheckLot.Append(Param_YarnIn.lotno_sup.Trim & "'")

			comm.CommandText = strCheckLot.ToString
			recordCount = comm.ExecuteScalar()
			If recordCount = 0 Then
				m_lotChanged = True
			Else
				m_lotChanged = False
			End If

			If m_lotChanged = True Then
				recordCount = 0
				newBatchno = ""
                comm.CommandText = "Select config_setting from config where config_name='GEN_YIN_INTERNAL_BATCH_NO'"
                m_genBatchno = comm.ExecuteScalar()
                'm_genBatchno = True
				If m_genBatchno = True Then
					strBatch.Append("SELECT count(*) as count from (select lotno_sup from Yarn_in where suppcd='" & Param_YarnIn.suppcd & "'" & " and lotno_sup='" & Param_YarnIn.lotno_sup & "'" & " Group by Lotno_sup,docno) as LotCount")
					comm.CommandText = strBatch.ToString
					' Generate batch no. only if the length of supplier lot no is more than 2 char
					If Param_YarnIn.lotno_sup.Length > 0 Then
						recordCount = comm.ExecuteScalar()
						recordCount = recordCount + 1
						Dim daBatch As New SqlDataAdapter(strBatch.ToString, connstr.connection)
						da.Fill(ds, "tableBatch")
						Dim stryearlot As String = ""
						stryearlot = Right(Year(Today.Date), 2)
						'newBatchno = (ds.Tables("tableBatch").Rows.Count + 1).ToString.PadLeft(2, "0")
						newBatchno = "-" & stryearlot & recordCount.ToString.PadLeft(3, "0")
					Else
						newBatchno = Param_YarnIn.lotno_sup
					End If
				Else
					newBatchno = ""
				End If
			Else	' update the lotno same as old one
				newBatchno = Param_YarnIn.lotno_our
			End If

			'*********
			strupt.Append("Update yarn_in set ")
			'strupt.Append("docdt = '" & Param_YarnIn.docdt & "',")
			strupt.Append("purno = '" & Param_YarnIn.purno & "',")
			strupt.Append("sinvno = '" & Param_YarnIn.sinvno & "',")
			strupt.Append("sinvdt = '" & Param_YarnIn.sinvdt & "',")
			strupt.Append("suppcd = '" & Param_YarnIn.suppcd & "',")
			strupt.Append("lotno_sup = '" & Param_YarnIn.lotno_sup & "',")
			strupt.Append("lotno_our = '" & newBatchno & "',")
			strupt.Append("srefno = '" & Param_YarnIn.srefno & "',")
			strupt.Append("curr = '" & Param_YarnIn.curr & "',")
			strupt.Append("exrt = '" & Param_YarnIn.exrt & "',")
			strupt.Append("vat = '" & Param_YarnIn.vat & "',")
			strupt.Append("vatamt = '" & Param_YarnIn.vatamt & "',")
			strupt.Append("taxamt = '" & Param_YarnIn.taxamt & "',")
			strupt.Append("freight = '" & Param_YarnIn.freight & "',")
			strupt.Append("insurance = '" & Param_YarnIn.insurance & "',")
			strupt.Append("otheramt = '" & Param_YarnIn.otheramt & "',")
			strupt.Append("other_text = '" & Param_YarnIn.other_text & "',")
			strupt.Append("discamt = '" & Param_YarnIn.discamt & "',")
			strupt.Append("totamt = '" & Param_YarnIn.totamt & "',")
			strupt.Append("tstamp = '" & Param_YarnIn.tstamp & "',")
			strupt.Append("remark = '" & Param_YarnIn.remark & "' ")
			strupt.Append("where ltrim(rtrim(docno)) = '" & Param_YarnIn.docno.Trim & "' ")

			comm.CommandText = strupt.ToString
			comm.ExecuteNonQuery()
			'Next


			'Dim CmdUptYarndet As New SqlCommandBuilder
			'CmdUptYarndet.DataAdapter = da
			'da.InsertCommand = CmdUptYarndet.GetInsertCommand
			'da.UpdateCommand = CmdUptYarndet.GetUpdateCommand
			'da.deleteCommand = CmdUptYarndet.GetdeleteCommand
			'da.Update(ds_Yarn_in_det)

			tran.Commit()
			Return True
		Catch ex As Exception
			Msgerr = ex.Message
			tran.Rollback()
			Return False
		Finally
			conn.Close()
		End Try

	End Function

	Public Function UpdateYarnOut(ByVal param_tbl_yarn_out As tbl_Yarn_out, ByVal dt_yarn_out_det As DataTable, ByRef msgerr As String, ByVal loginEmpcd As String) As Boolean
		Dim strupt As New StringBuilder
		Dim strdel As New StringBuilder

		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connstr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction
		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran
			'----------
			comm.CommandType = CommandType.StoredProcedure
			comm.CommandText = "log_yarn_out"
			comm.Parameters.AddWithValue("@empcd", loginEmpcd)
			comm.Parameters.AddWithValue("@docno", param_tbl_yarn_out.outno.Trim)
			comm.Parameters.AddWithValue("@action", "EDIT")
			comm.ExecuteNonQuery()

			comm.CommandType = CommandType.Text

			'----------
			strupt.Append("update yarn_out set ")
			'strupt.Append("outno = '" & param_tbl_yarn_out.outno & "',")
			'strupt.Append("outdt = '" & param_tbl_yarn_out.outdt & "',")
			strupt.Append("tran_type = '" & param_tbl_yarn_out.tran_type & "',")
			'strupt.Append("refdocno = '" & param_tbl_yarn_out.refdocno & "',")
			'strupt.Append("suppcd = '" & param_tbl_yarn_out.suppcd & "',")
			strupt.Append("rem = '" & param_tbl_yarn_out.remm & "' ")
			strupt.Append("where outno = '" & param_tbl_yarn_out.outno & "'")

			comm.CommandText = strupt.ToString
			comm.ExecuteNonQuery()

			Dim daYarnOutDet As New SqlDataAdapter("Select top 0 * from Yarn_out_det ", connstr.connection)
			Dim cmdYarnOutDet As New SqlCommandBuilder
			cmdYarnOutDet.DataAdapter = daYarnOutDet
			daYarnOutDet.InsertCommand = cmdYarnOutDet.GetInsertCommand
			daYarnOutDet.DeleteCommand = cmdYarnOutDet.GetDeleteCommand
			daYarnOutDet.UpdateCommand = cmdYarnOutDet.GetUpdateCommand
			daYarnOutDet.Update(dt_yarn_out_det)

			'Dim tbl_yarn_out_det As New tbl_Yarn_out_det
			'If Not IsNothing(param_tbl_yarn_out.tbl_Yarn_out_det) Then
			'	For Each tbl_yarn_out_det In param_tbl_yarn_out.tbl_Yarn_out_det
			'		strdel.Append("delete from yarn_out_det ")
			'		strdel.Append("where id_yarn_out_det = '" & tbl_yarn_out_det.id_yarn_out_det & "'")
			'		comm.CommandText = strdel.ToString
			'		comm.ExecuteNonQuery()
			'	Next
			'End If

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
	Public Function cancelYarnin(ByVal Docno As String, ByVal loginEmpcd As String, ByRef Msgerr As String)
		Dim conn As SqlConnection = New SqlConnection
		Dim ds As New DataSet
		Dim tran As SqlTransaction

		conn.ConnectionString = connstr.connection
		conn.Open()
		tran = conn.BeginTransaction

		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran

			'----------
			comm.CommandType = CommandType.StoredProcedure
			comm.CommandText = "log_yarn_in"
			comm.Parameters.AddWithValue("@empcd", loginEmpcd)
			comm.Parameters.AddWithValue("@docno", Docno)
			comm.Parameters.AddWithValue("@action", "EDIT")
			comm.ExecuteNonQuery()

			comm.CommandText = "p_yarnin_cancel"
			comm.Parameters.AddWithValue("@empcd", loginEmpcd)
			comm.Parameters.AddWithValue("@docno", Docno)
			comm.ExecuteNonQuery()


			tran.Commit()
			Return True
		Catch ex As Exception
			Msgerr = ex.Message
			tran.Rollback()
			Return False
		Finally
			conn.Close()
		End Try

	End Function


End Class
