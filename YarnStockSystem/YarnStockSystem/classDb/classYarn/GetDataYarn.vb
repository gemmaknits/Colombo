Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class GetDataYarn
	Private ds As New DataSet
	Private clsConfig As New clsConfig
	Private connStr As New classConnection

	'----------------------- Yarn In ------------------

	Public Function checkPurno(ByVal tblPur As Tbl_Pur, ByRef MsgErr As String) As Tbl_Pur()
		Dim i As Integer = 0
		Dim str As New StringBuilder
		Dim dr As DataRow
		str.Append("select * from Job where jobno = '" & tblPur.purno & "'")
		Dim myda As New SqlDataAdapter(str.ToString, connstr.connection)
		myda.Fill(ds, "tblDisPur")
		If ds.Tables("tblDisPur").Rows.Count > 0 Then
			Dim arr_tblPur() As tbl_Pur
			For Each dr In ds.Tables("tblDisPur").Rows
				ReDim Preserve arr_tblPur(i)
				arr_tblPur(i) = New Tbl_Pur
				arr_tblPur(i).purno = ds.Tables("tblDisPur").Rows(i).Item("purno").ToString
				arr_tblPur(i).purdt = clsConfig.IsValidDate(ds.Tables("tblDisPur").Rows(i).Item("purdt"))
				arr_tblPur(i).suppcd = ds.Tables("tblDisPur").Rows(i).Item("suppcd").ToString
				arr_tblPur(i).reqno = ds.Tables("tblDisPur").Rows(i).Item("reqno").ToString
				arr_tblPur(i).purtype = ds.Tables("tblDisPur").Rows(i).Item("purtype").ToString
				arr_tblPur(i).remm = ds.Tables("tblDisPur").Rows(i).Item("rem").ToString
				arr_tblPur(i).import = Clsconfig.IsValidBoolean(ds.Tables("tblDisPur").Rows(i).Item("import"))
				arr_tblPur(i).curr = ds.Tables("tblDisPur").Rows(i).Item("curr").ToString
				arr_tblPur(i).exrt = ds.Tables("tblDisPur").Rows(i).Item("exrt").ToString
				arr_tblPur(i).vat = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("vat"))
				arr_tblPur(i).vatamt = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("vatamt"))
				arr_tblPur(i).taxper = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("taxper"))
				arr_tblPur(i).taxamt = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("taxamt"))
				arr_tblPur(i).freight = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("freight"))
				arr_tblPur(i).insurance = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("insurance"))
				arr_tblPur(i).shipping = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("shipping"))
				arr_tblPur(i).handling = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("handling"))
				arr_tblPur(i).miscamt = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("miscamt"))
				arr_tblPur(i).misc_desc = ds.Tables("tblDisPur").Rows(i).Item("misc_desc").ToString
				arr_tblPur(i).discamt = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("discamt"))
				arr_tblPur(i).totamt = clsConfig.IsValidinteger(ds.Tables("tblDisPur").Rows(i).Item("totamt"))
				i = i + 1
			Next
			Return arr_tblPur
		Else
			MsgErr = "Can not found"
		End If
	End Function

	Public Function GetDataSupplier(ByVal arr_tblPurPurno As String, ByRef msgerr As String) As DataSet
		Dim Str As New StringBuilder
		If arr_tblPurPurno = "NONE" Then
            Str.Append("select * from Suppliers order by name ")
			Dim da As New SqlDataAdapter(Str.ToString, connStr.connection)
			da.Fill(ds, "tblSuppResult")
			If ds.Tables("tblSuppResult").Rows.Count > 0 Then
				Return ds
			End If
		Else
			'Str.Append("select * from Suppliers where suppcd = '" & arr_tblPurPurno & "'")
			Str.Append("select * from Suppliers Order by name")
			Dim myda As New SqlDataAdapter(Str.ToString, connStr.connection)
			myda.Fill(ds, "tblSuppResult")
			If ds.Tables("tblSuppResult").Rows.Count > 0 Then
				Return ds
			Else
				Return ds
			End If
		End If
	End Function

	Public Function GetDataItem(ByVal paramItems As tbl_Items) As DataSet
		Dim str As New StringBuilder
		Dim strresult As New StringBuilder
		Dim connstr As New classConnection

		str.Append("select * from items where itcd = '" & paramItems.itcd & "'")
		Dim da As New SqlDataAdapter(str.ToString, connstr.connection)
		da.Fill(ds, "tblItemsEventResult")
		If ds.Tables("tblItemsEventResult").Rows.Count > 0 Then
			Return ds
		Else
			strresult.Append("select * from items where itnaturecd='YARNS'")
			Dim dap As New SqlDataAdapter(strresult.ToString, connstr.connection)
			dap.Fill(ds, "tblItemsResult")
			If ds.Tables("tblItemsResult").Rows.Count > 0 Then
				Return ds
			Else
				Return ds
			End If
		End If
	End Function

	Public Function GetDataCurrency() As DataSet
		Dim str As New StringBuilder
		Dim strresult As New StringBuilder
		Dim connstr As New classConnection

		str.Append("select * from Currency")
		Dim da As New SqlDataAdapter(str.ToString, connstr.connection)
		da.Fill(ds, "tblCurrencyResult")
		If ds.Tables("tblCurrencyResult").Rows.Count > 0 Then
			Return ds
		Else
			Return ds
		End If
	End Function

	Public Function GetDataYarnInDetail() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from yarn_in_det")
		Dim daCount As New SqlDataAdapter(str.ToString, connStr.connection)
		daCount.Fill(ds, "TblYarnin_Detail")
		If ds.Tables("TblYarnin_Detail").Rows.Count > 0 Then
			Return ds.Tables("TblYarnin_Detail")
		Else
			Return ds.Tables("TblYarnin_Detail")
		End If

	End Function



	'----------------------- Yarn Out ---------------

	Public Function GetDataYarnOut(ByVal paramdocno As String, ByVal SourceDoc As String) As DataTable
		Dim str As New StringBuilder
		Dim connstr As New classConnection
		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connstr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction
		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran
			If SourceDoc = "YIN" Then
				str.Append("select * from v_YarnBalByBox_minus_job where docno = '" & paramdocno & "'")
			Else
				str.Append("select *,jobtype as tran_type from v_Job_Yarn where Jobno = '" & paramdocno & "'")
			End If
			comm.CommandText = str.ToString
			comm.ExecuteNonQuery()
			Dim daCount As New SqlDataAdapter(str.ToString, connstr.connection)
			daCount.Fill(ds, "view_YarnBalByBox")

			tran.Commit()
			Return ds.Tables("view_YarnBalByBox")
		Catch ex As Exception
			tran.Rollback()
		Finally
			conn.Close()
		End Try
	End Function

	Public Function GetDataTrantype() As DataTable
		Dim str As New StringBuilder
		Dim connstr As New classConnection
		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connstr.connection
		conn.Open()
		Dim tran As SqlTransaction
		tran = conn.BeginTransaction
		Try
			Dim comm As SqlCommand = New SqlCommand
			comm.Connection = conn
			comm.Transaction = tran

			str.Append("select * from tran_type")
			comm.CommandText = str.ToString
			comm.ExecuteNonQuery()
			Dim daCount As New SqlDataAdapter(str.ToString, connstr.connection)
			daCount.Fill(ds, "tbl_tran_type")

			tran.Commit()
			Return ds.Tables("tbl_tran_type")
		Catch ex As Exception
			tran.Rollback()
		Finally
			conn.Close()
		End Try
	End Function

	'------------------------------------------------


	'-------------------- JobOrderforYarn -----------------

	Public Function GetDataPacktype() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from pack_type ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "TblPacktype")
		If ds.Tables("TblPacktype").Rows.Count > 0 Then
			Return ds.Tables("TblPacktype")
		End If
	End Function

	Public Function GetSupplier() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from Suppliers ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "TblSupplier")
		If ds.Tables("TblSupplier").Rows.Count > 0 Then
			Return ds.Tables("TblSupplier")
		End If
	End Function

	Public Function Getjobtype() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from tran_type ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "TblTrantype")
		If ds.Tables("TblTrantype").Rows.Count > 0 Then
			Return ds.Tables("TblTrantype")
		End If
	End Function


    Public Function GetYarnInno(ByVal YarnIn As String, ByVal Itemcode As String, ByRef Msgerr As String) As DataTable
        Try
            If YarnIn <> "" And Itemcode = "" Then
                Dim str As New StringBuilder
                str.Append("select * from v_YarnBalByBox_minus_job where docno = '" & YarnIn & "'")
                Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
                da.Fill(ds, "v_YarnBalByBox")
                If ds.Tables("v_YarnBalByBox").Rows.Count > 0 Then
                    Return ds.Tables("v_YarnBalByBox")
                Else
                    Return ds.Tables("v_YarnBalByBox")
                End If
            ElseIf YarnIn = "" And Itemcode <> "" Then
                Dim str As New StringBuilder
                str.Append("select * from v_YarnBalByBox_minus_job where itcd = '" & Itemcode & "'")
                Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
                da.Fill(ds, "v_YarnBalByBox")
                If ds.Tables("v_YarnBalByBox").Rows.Count > 0 Then
                    Return ds.Tables("v_YarnBalByBox")
                Else
                    Return ds.Tables("v_YarnBalByBox")
                End If
            Else
                MsgBox("กรุณาระบุข้อมูลในการค้นหารายละเอียดครับ", MsgBoxStyle.Information, "โปรดตรวจสอบการใช้งาน")
                Dim str As New StringBuilder
                str.Append("select * from v_YarnBalByBox_minus_job where docno = '*^*'")
                Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
                da.Fill(ds, "v_YarnBalByBox")
                If ds.Tables("v_YarnBalByBox").Rows.Count > 0 Then
                    Return ds.Tables("v_YarnBalByBox")
                Else
                    Return ds.Tables("v_YarnBalByBox")
                End If
            End If
        Catch ex As Exception
            Msgerr = ex.Message
        End Try

    End Function
    Public Function GetYarnInnoPrintBarcode(ByVal YarnIn As String, ByVal Itemcode As String, ByRef Msgerr As String) As DataTable
        Try
            If YarnIn <> "" And Itemcode = "" Then
                Dim str As New StringBuilder
                str.Append("select docno,itcd,boxno,kg_nt from v_YarnBalByBox where docno = '" & YarnIn & "'")
                Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
                da.Fill(ds, "v_YarnBalByBox")
                If ds.Tables("v_YarnBalByBox").Rows.Count > 0 Then
                    Return ds.Tables("v_YarnBalByBox")
                Else
                    Return ds.Tables("v_YarnBalByBox")
                End If
            ElseIf YarnIn = "" And Itemcode <> "" Then
                Dim str As New StringBuilder
                str.Append("select docno,itcd,boxno,kg_nt from v_YarnBalByBox where itcd = '" & Itemcode & "'")
                Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
                da.Fill(ds, "v_YarnBalByBox")
                If ds.Tables("v_YarnBalByBox").Rows.Count > 0 Then
                    Return ds.Tables("v_YarnBalByBox")
                Else
                    Return ds.Tables("v_YarnBalByBox")
                End If
            Else
                MsgBox("กรุณาระบุข้อมูลในการค้นหารายละเอียดครับ", MsgBoxStyle.Information, "โปรดตรวจสอบการใช้งาน")
                Dim str As New StringBuilder
                str.Append("select docno,itcd,boxno,kg_nt from v_YarnBalByBox where docno = '*^*'")
                Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
                da.Fill(ds, "v_YarnBalByBox")
                If ds.Tables("v_YarnBalByBox").Rows.Count > 0 Then
                    Return ds.Tables("v_YarnBalByBox")
                Else
                    Return ds.Tables("v_YarnBalByBox")
                End If
            End If
        Catch ex As Exception
            Msgerr = ex.Message
        End Try

    End Function



	Public Function GetColor() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from Colors ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "TblColors")
		If ds.Tables("TblColors").Rows.Count > 0 Then
			Return ds.Tables("TblColors")
		End If
	End Function
	'------------------------------------------------------


	'---------------- Create Yarn Master in form Purcahse -----------

	Public Function GetCheckDataYarn_Code(ByVal Yarn_code As String) As Boolean
		Dim str As New StringBuilder
		str.Append("select * from Items ")
		str.Append("where itcd = '" & Yarn_code & "'")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblItems")
		If ds.Tables("tblItems").Rows.Count > 0 Then
			Return True
		Else
			Return False
		End If
	End Function

	Public Function GetData_Item_group() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from items_group ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblItemsgroup")
		If ds.Tables("tblItemsgroup").Rows.Count > 0 Then
			Return ds.Tables("tblItemsgroup")
		Else
			Return ds.Tables("tblItemsgroup")
		End If
	End Function

	Public Function GetData_Item_type() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from items_type ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblitems_type")
		If ds.Tables("tblitems_type").Rows.Count > 0 Then
			Return ds.Tables("tblitems_type")
		Else
			Return ds.Tables("tblitems_type")
		End If
	End Function

	Public Function GetData_Item_sub() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from items_sub ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblitems_sub")
		If ds.Tables("tblitems_sub").Rows.Count > 0 Then
			Return ds.Tables("tblitems_sub")
		Else
			Return ds.Tables("tblitems_sub")
		End If
	End Function

	Public Function GetData_Item_sub2() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from items_sub2 ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblitems_sub2")
		If ds.Tables("tblitems_sub2").Rows.Count > 0 Then
			Return ds.Tables("tblitems_sub2")
		Else
			Return ds.Tables("tblitems_sub2")
		End If
	End Function

	Public Function GetData_Item_cat() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from items_cat ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblitems_cat")
		If ds.Tables("tblitems_cat").Rows.Count > 0 Then
			Return ds.Tables("tblitems_cat")
		Else
			Return ds.Tables("tblitems_cat")
		End If
	End Function

	Public Function GetData_Item_subcat() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from items_subcat ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblitems_subcat")
		If ds.Tables("tblitems_subcat").Rows.Count > 0 Then
			Return ds.Tables("tblitems_subcat")
		Else
			Return ds.Tables("tblitems_subcat")
		End If
	End Function

	Public Function GetData_Suppliers() As DataTable
		Dim str As New StringBuilder
		str.Append("select * from Suppliers ")
		Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
		da.Fill(ds, "tblitems_Suppliers")
		If ds.Tables("tblitems_Suppliers").Rows.Count > 0 Then
			Return ds.Tables("tblitems_Suppliers")
		Else
			Return ds.Tables("tblitems_Suppliers")
		End If
	End Function

	'----------------------------------------------------------------

	'------------------------  Get DataYarnIn -----------------------
	Public Function GetData_YarnIn(ByVal Param_YarninCode As String, ByRef Msgerr As String) As DataTable
		Try
			Dim str As New StringBuilder
			str.Append("select * from v_yarn_in ")
			str.Append("where docno = '" & Param_YarninCode & "'")
			Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblDataYarnIn")
			If ds.Tables("TblDataYarnIn").Rows.Count > 0 Then
				Return ds.Tables("TblDataYarnIn")
			Else
				Return ds.Tables("TblDataYarnIn")
			End If

		Catch ex As Exception
			Msgerr = ex.Message
		End Try
	End Function

	Public Function GetData_YarnInDet(ByVal Param_YarninCode As String, ByRef Msgerr As String, ByRef da As SqlDataAdapter) As DataTable
		Try
			Dim str As New StringBuilder
			str.Append("select * from yarn_in_det ")
			str.Append("where docno = '" & Param_YarninCode & "'")
			da = New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblDataYarnIndet")
			If ds.Tables("TblDataYarnIndet").Rows.Count > 0 Then
				Return ds.Tables("TblDataYarnIndet")
			Else
				Return ds.Tables("TblDataYarnIndet")
			End If

		Catch ex As Exception
			Msgerr = ex.Message
		End Try
	End Function
	'----------------------------------------------------------------

	'-----------------------------   Get DataYarnOut ----------------
	Public Function GetData_YarnOut(ByVal Param_YarnOutCode As String, ByRef da As SqlDataAdapter, ByRef Msgerr As String) As DataTable
		Try
			Dim str As New StringBuilder
			str.Append("select * from v_yarn_out inner join suppliers on suppliers.suppcd=v_yarn_out.suppcd ")
			str.Append("where outno = '" & Param_YarnOutCode & "'")
			da = New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblDataYarnOut")
			If ds.Tables("TblDataYarnOut").Rows.Count > 0 Then
				Return ds.Tables("TblDataYarnOut")
			Else
				Return ds.Tables("TblDataYarnOut")
			End If

		Catch ex As Exception
			Msgerr = ex.Message
		End Try
	End Function

	Public Function GetData_YarnOutdet(ByVal Param_YarnOutCode As String, ByRef da As SqlDataAdapter, ByRef Msgerr As String) As DataTable
		Try
            Dim str As New StringBuilder
            Dim da1 As New SqlDataAdapter
            Dim DS1 As New DataSet
			str.Append("select * from yarn_out_det ")
			str.Append("where outno = '" & Param_YarnOutCode & "'")
            da1 = New SqlDataAdapter(str.ToString, connStr.connection)
            da1.Fill(DS1, "TblDataYarnOut")
            If DS1.Tables("TblDataYarnOut").Rows.Count > 0 Then
                Return DS1.Tables("TblDataYarnOut")
            Else
                Return DS1.Tables("TblDataYarnOut")
            End If

		Catch ex As Exception
			Msgerr = ex.Message
		End Try
	End Function

	Public Function GetData_v_Yarn_bal_box(ByVal Param_YarnInCode As String, ByRef Msgerr As String) As DataTable
		Try
			Dim str As New StringBuilder
			str.Append("select * from v_YarnBalByBox ")
			str.Append("where docno = '" & Param_YarnInCode & "'")
			Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblDataYarnbalbox")
			If ds.Tables("TblDataYarnbalbox").Rows.Count > 0 Then
				Return ds.Tables("TblDataYarnbalbox")
			Else
				Return ds.Tables("TblDataYarnbalbox")
			End If

		Catch ex As Exception
			Msgerr = ex.Message
		End Try
	End Function

	Public Function GetData_NameSuppliers(ByVal Param_SuppCd As String, ByRef Msgerr As String) As String
		Try
			Dim str As New StringBuilder
			Dim namesupp As String
			str.Append("select * from suppliers ")
			str.Append("where suppcd = '" & Param_SuppCd & "'")
			Dim da As New SqlDataAdapter(str.ToString, connStr.connection)
			da.Fill(ds, "TblDataYarnbalbox")
			If ds.Tables("TblDataYarnbalbox").Rows.Count > 0 Then
				namesupp = ds.Tables("TblDataYarnbalbox").Rows(0).Item("name").ToString
				Return namesupp
			Else

			End If

		Catch ex As Exception
			Msgerr = ex.Message
		End Try
	End Function

	'----------------------------------------------------------------
End Class
