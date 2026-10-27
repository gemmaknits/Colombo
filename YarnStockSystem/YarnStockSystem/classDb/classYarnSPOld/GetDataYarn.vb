Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class GetDataYarn
	'Private ds As New DataSet
	'Private clsConfig As New clsConfig
	Private connStr As New classConnection

	'----------------------- Yarn In ------------------

	Public Function checkPurno(ByVal tblPur As Tbl_Pur, ByRef MsgErr As String) As Tbl_Pur()
		Dim i As Integer = 0
		Dim str As New StringBuilder
		Dim clsConfig As New clsConfig
		Dim dr As DataRow
		Dim dt As New DataTable
		str.Append("exec p_job_select '" & tblPur.purno.Trim & "'")
		Dim myda As New SqlDataAdapter(str.ToString, connstr.connection)
		myda.Fill(dt)
		If dt.Rows.Count > 0 Then
			Dim arr_tblPur() As tbl_Pur
			For Each dr In dt.Rows
				ReDim Preserve arr_tblPur(i)
				arr_tblPur(i) = New tbl_Pur
				arr_tblPur(i).purno = dr("purno").ToString
				arr_tblPur(i).purdt = clsConfig.IsValidDate(dr("purdt"))
				arr_tblPur(i).suppcd = dr("suppcd").ToString
				arr_tblPur(i).reqno = dr("reqno").ToString
				arr_tblPur(i).purtype = dr("purtype").ToString
				arr_tblPur(i).remm = dr("rem").ToString
				arr_tblPur(i).import = clsConfig.IsValidBoolean(dr("import"))
				arr_tblPur(i).curr = dr("curr").ToString
				arr_tblPur(i).exrt = dr("exrt").ToString
				arr_tblPur(i).vat = clsConfig.IsValidinteger(dr("vat"))
				arr_tblPur(i).vatamt = clsConfig.IsValidinteger(dr("vatamt"))
				arr_tblPur(i).taxper = clsConfig.IsValidinteger(dr("taxper"))
				arr_tblPur(i).taxamt = clsConfig.IsValidinteger(dr("taxamt"))
				arr_tblPur(i).freight = clsConfig.IsValidinteger(dr("freight"))
				arr_tblPur(i).insurance = clsConfig.IsValidinteger(dr("insurance"))
				arr_tblPur(i).shipping = clsConfig.IsValidinteger(dr("shipping"))
				arr_tblPur(i).handling = clsConfig.IsValidinteger(dr("handling"))
				arr_tblPur(i).miscamt = clsConfig.IsValidinteger(dr("miscamt"))
				arr_tblPur(i).misc_desc = dr("misc_desc").ToString
				arr_tblPur(i).discamt = clsConfig.IsValidinteger(dr("discamt"))
				arr_tblPur(i).totamt = clsConfig.IsValidinteger(dr("totamt"))
				i = i + 1
			Next
			Return arr_tblPur
		Else
			MsgErr = "Can not found"
			Return Nothing
		End If
	End Function

	Public Function GetDataSupplier(ByVal arr_tblPurPurno As String, ByRef msgerr As String) As DataSet
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_suppliers_select '" & arr_tblPurPurno.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim ds As New DataSet
		da.Fill(ds, "tblSuppResult")
		Return ds
	End Function

	Public Function GetDataItem(ByVal paramItems As tbl_Items) As DataSet
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_select '" & paramItems.itcd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connstr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "items")
		Return ds
	End Function

	Public Function GetDataCurrency(Optional ByVal strCurr As String = "") As DataSet
		Dim strSQL As New StringBuilder
		strSQL.Append("p_currency_select '" & strCurr.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblCurrencyResult")
		Return ds
	End Function

	Public Function GetDataYarnInDetail(Optional ByVal strDocNo As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_det_select '" & strDocNo.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "TblYarnin_Detail")
		Return ds.Tables("TblYarnin_Detail")
	End Function

	'----------------------- Yarn Out ---------------

	Public Function GetDataYarnOut(ByVal paramdocno As String, ByVal SourceDoc As String) As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_out_select '" & paramdocno.Trim & "','" & SourceDoc.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connstr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "view_YarnBalByBox")
		Return ds.Tables("view_YarnBalByBox")
	End Function

	Public Function GetDataTrantype(Optional ByVal strTranType As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_tran_type_select '" & strTranType.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connstr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tbl_tran_type")
		Return ds.Tables("tbl_tran_type")
	End Function

	'-------------------- JobOrderforYarn -----------------

	Public Function GetDataPacktype(Optional ByVal strPackCD As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_pack_type_select '" & strPackCD.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "TblPacktype")
		Return ds.Tables("TblPacktype")
	End Function

	Public Function GetSupplier(Optional ByVal strSuppcd As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_suppliers_select '" & strSuppcd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection())
		Dim ds As New DataSet
		da.Fill(ds, "TblSupplier")
		Return ds.Tables("TblSupplier")
	End Function

	Public Function Getjobtype(Optional ByVal strTranType As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_tran_type_select '" & strTranType.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "TblTrantype")
		Return ds.Tables("TblTrantype")
	End Function

	Public Function GetYarnInno(ByVal YarnIn As String, ByVal Itemcode As String, ByRef Msgerr As String) As DataTable
		If YarnIn = "" And Itemcode = "" Then MessageBox.Show("Yarn IN No. or Item Code is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_select2 '" & YarnIn.Trim & "','" & Itemcode.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet

		Try
			da.Fill(ds, "v_YarnBalByBox")
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		Return ds.Tables("v_YarnBalByBox")
	End Function

	Public Function GetYarnInnoPrintBarcode(ByVal YarnIn As String, ByVal Itemcode As String, ByRef Msgerr As String) As DataTable
		If YarnIn = "" And Itemcode = "" Then MessageBox.Show("Yarn IN No. or Item Code is incorrect.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_select3 '" & YarnIn.Trim & "','" & Itemcode.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet

		Try
			da.Fill(ds, "v_YarnBalByBox")
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		Return ds.Tables("v_YarnBalByBox")
	End Function

	Public Function GetColor(Optional ByVal strCol As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_colors_select '" & strCol.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "TblColors")
		Return ds.Tables("TblColors")
	End Function

	'---------------- Create Yarn Master in form Purcahse -----------

	Public Function GetCheckDataYarn_Code(ByVal Yarn_code As String) As Boolean
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_select '" & Yarn_code.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblItems")
		Return IIf(ds.Tables("tblItems").Rows.Count > 0, True, False)
	End Function

	Public Function GetData_Item_group(Optional ByVal strGrpCD As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_group_select '" & strGrpCD.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblItemsgroup")
		Return ds.Tables("tblItemsgroup")
	End Function

	Public Function GetData_Item_type(Optional ByVal strTypeCD As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_type_select '" & strTypeCD.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblitems_type")
		Return ds.Tables("tblitems_type")
	End Function

	Public Function GetData_Item_sub(Optional ByVal strSubCD As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_sub_select '" & strSubCD.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblitems_sub")
		Return ds.Tables("tblitems_sub")
	End Function

	Public Function GetData_Item_sub2(Optional ByVal strSubCD2 As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_sub2_select '" & strSubCD2.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblitems_sub2")
		Return ds.Tables("tblitems_sub2")
	End Function

	Public Function GetData_Item_cat(Optional ByVal strCatCD As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_cat_select '" & strCatCD.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblitems_cat")
		Return ds.Tables("tblitems_cat")
	End Function

	Public Function GetData_Item_subcat(Optional ByVal strSubCatCD As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_items_subcat_select '" & strSubCatCD.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblitems_subcat")
		Return ds.Tables("tblitems_subcat")
	End Function

	Public Function GetData_Suppliers(Optional ByVal strSuppcd As String = "") As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_suppliers_select '" & strSuppcd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet
		da.Fill(ds, "tblitems_Suppliers")
		Return ds.Tables("tblitems_Suppliers")
	End Function

	'------------------------  Get DataYarnIn -----------------------

	Public Function GetData_YarnIn(ByVal Param_YarninCode As String, ByRef Msgerr As String) As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_select4 '" & Param_YarninCode.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet

		Try
			da.Fill(ds, "TblDataYarnIn")
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		Return ds.Tables("TblDataYarnIn")
	End Function

	Public Function GetData_YarnInDet(ByVal Param_YarninCode As String, ByRef Msgerr As String, ByRef da As SqlDataAdapter) As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_det_select '" & Param_YarninCode.Trim & "'")
		da = New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet

		Try
			da.Fill(ds, "TblDataYarnIndet")
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		Return ds.Tables("TblDataYarnIndet")
	End Function

	'-----------------------------   Get DataYarnOut ----------------

	Public Function GetData_YarnOut(ByVal Param_YarnOutCode As String, ByRef da As SqlDataAdapter, ByRef Msgerr As String) As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_out_select2 '" & Param_YarnOutCode.Trim & "'")
		da = New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet

		Try
			da.Fill(ds, "TblDataYarnOut")
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		Return ds.Tables("TblDataYarnOut")
	End Function

	Public Function GetData_YarnOutdet(ByVal Param_YarnOutCode As String, ByRef da As SqlDataAdapter, ByRef Msgerr As String) As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_out_det_select '" & Param_YarnOutCode.Trim & "'")
		da = New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet

		Try
			da.Fill(ds, "TblDataYarnOut")
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		Return ds.Tables("TblDataYarnOut")
	End Function

	Public Function GetData_v_Yarn_bal_box(ByVal Param_YarnInCode As String, ByRef Msgerr As String) As DataTable
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_yarn_in_select5 '" & Param_YarnInCode.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim ds As New DataSet

		Try
			da.Fill(ds, "TblDataYarnbalbox")
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		Return ds.Tables("TblDataYarnbalbox")
	End Function

	Public Function GetData_NameSuppliers(ByVal Param_SuppCd As String, ByRef Msgerr As String) As String
		Dim strSQL As New StringBuilder
		strSQL.Append("exec p_suppliers_select '" & Param_SuppCd.Trim & "'")
		Dim da As New SqlDataAdapter(strSQL.ToString, connStr.connection)
		Dim dt As New DataTable

		Try
			da.Fill(dt)
		Catch ex As Exception
			Msgerr = ex.Message
		End Try

		If dt.Rows.Count > 0 Then
			Return dt.Rows(0)("name").ToString
		Else
			Return ""
		End If
	End Function
End Class