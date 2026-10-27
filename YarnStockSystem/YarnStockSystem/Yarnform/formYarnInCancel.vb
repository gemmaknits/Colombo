Imports System.Data.SqlClient
Imports System.Text
Public Class formYarnInCancel
	Public loginEmpcd As String
	Private dt_yarnindet As DataTable
	Private da As New SqlDataAdapter
	Private Clsconfig As New clsConfig
	Private saveItcd As String
	Private saveTube As String
	Private saveGross As String
	Private saveKG_net As String
	Private saveBoxTearWeight As String

	Private Sub formYarnInEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		LoadCbSupplier()
		insertcomboitemcode()
		insertcomboCurrency()
	End Sub

	Private Sub insertcomboCurrency()
		Dim tblItems As New tbl_Items
		Dim getDatayarn As New GetDataYarn
		Dim ds As New DataSet
		ds = getDatayarn.GetDataCurrency()
		If Not IsNothing(ds) Then
			'Me.cboCurrency.DataSource = ds.Tables(0)
			'Me.cboCurrency.DisplayMember = "currname"
			'Me.cboCurrency.ValueMember = "curr"
		End If
	End Sub

	Private Sub insertcomboitemcode()
		Dim tblItems As New tbl_Items
		Dim getDatayarn As New GetDataYarn
		Dim ds As New DataSet
		tblItems.itcd = 123456789
		ds = getDatayarn.GetDataItem(tblItems)
		If Not IsNothing(ds) Then
			Me.cboitcd.DataSource = ds.Tables(1)
			Me.cboitcd.DisplayMember = "itdesc"
			Me.cboitcd.ValueMember = "Itcd"

		End If
	End Sub

	Private Sub loaddgyarninedit()

	End Sub

	Private Sub LoadCbSupplier()
		Dim GetdataSupplier As New GetDataYarn
		Dim dt As DataTable
		dt = GetdataSupplier.GetSupplier
		If dt.Rows.Count > 0 Then
			Me.CbSupplier.DataSource = dt
			Me.CbSupplier.DisplayMember = "name"
			Me.CbSupplier.ValueMember = "suppcd"
		End If
	End Sub

	Private Sub Btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch.Click
		Dim selectedYarn As String
		Dim formSearchyarn As New formSearchYarn
		selectedyarn = formSearchyarn.getYarnno()
		If selectedYarn <> "" Then
			Me.txtyarnincode.Text = selectedYarn
		End If
		LoadDataYarnIn()
	End Sub


	Private Sub LoadDataYarnIn()
		Dim msgerr As String = ""
		Dim dt As DataTable
		Dim GetdataYarnIn As New GetDataYarn
		dt = GetdataYarnIn.GetData_YarnIn(Me.txtyarnincode.Text, msgerr)
		If dt.Rows.Count > 0 Then
			'			Me.txtPO.Text = dt.Rows(0).Item("purno").ToString
			Me.CbSupplier.SelectedValue = dt.Rows(0).Item("suppcd").ToString.Trim

			Me.txtSupp.Text = dt.Rows(0).Item("sinvno").ToString
			Me.txtSupDt.Text = dt.Rows(0).Item("sinvdt").ToString
			Me.txtSupLot.Text = dt.Rows(0).Item("lotno_sup").ToString
			'Me.txtSupref.Text = dt.Rows(0).Item("srefno").ToString
			'Me.txtFreight.Text = dt.Rows(0).Item("Freight").ToString
			'Me.txtInsurance.Text = dt.Rows(0).Item("Insurance").ToString
			'Me.txtAmt.Text = dt.Rows(0).Item("otheramt").ToString
			'Me.txtDetail.Text = dt.Rows(0).Item("other_text").ToString
			'Me.lblYINno.Text = dt.Rows(0).Item("docno").ToString
			'Me.DateYIN.Value = dt.Rows(0).Item("docdt").ToString
			lbldate.Text = dt.Rows(0).Item("docdt").ToString
			'Me.txtremark.Text = dt.Rows(0).Item("remark").ToString
			Me.txttotalboxes.Text = dt.Rows(0).Item("other_text").ToString
			Me.txttotalgross.Text = dt.Rows(0).Item("kg_gr").ToString
			Me.txttotalnet.Text = dt.Rows(0).Item("kg_nt").ToString

			'----------------- dgyarn ----------------------
			Me.DgYarn.AutoGenerateColumns = False
			Dim Getdatayarnindet As New GetDataYarn

			dt_yarnindet = Getdatayarnindet.GetData_YarnInDet(Me.txtyarnincode.Text, msgerr, da)
			Dim n As Integer
			'For n = 0 To dt_yarnindet.Rows.Count - 1
			'    If IsDBNull(dt_yarnindet.Rows(n).Item("")) = True Then

			'    End If

			'Next
			If Not IsNothing(dt_yarnindet) Then
				Me.DgYarn.DataSource = dt_yarnindet
				With Me.DgYarn
					.Columns(0).DataPropertyName = "itcd"
					.Columns(1).DataPropertyName = "docno"
					.Columns(2).DataPropertyName = "grade"
					.Columns(3).DataPropertyName = "boxno_s"
					.Columns(4).DataPropertyName = "boxno"
					.Columns(5).DataPropertyName = "spools"
					.Columns(6).DataPropertyName = "kg_gr"
					.Columns(7).DataPropertyName = "cart_tearwt"
					.Columns(8).DataPropertyName = "kg_nt"
					.Columns(9).DataPropertyName = "docno"

				End With
			End If

			'-----------------------------------------------

			'Me.cboCurrency.SelectedValue = dt.Rows(0).Item("curr").ToString
			'Me.txtrate.Text = dt.Rows(0).Item("exrt").ToString
			'Me.txtVat.Text = dt.Rows(0).Item("vat").ToString
			'Me.txtTaxAmount.Text = dt.Rows(0).Item("taxamt").ToString
			'Me.txtDiscountamount.Text = dt.Rows(0).Item("discamt").ToString
			'Me.txtVatAmount.Text = dt.Rows(0).Item("vatamt").ToString
			'Me.txtTotalAmount.Text = dt.Rows(0).Item("totamt").ToString
		End If
		sumtotal()
	End Sub

	Private Sub txtyarnincode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtyarnincode.KeyPress
		If AscW(e.KeyChar) = 13 Then
			LoadDataYarnIn()
		End If
	End Sub

	Private Sub BtnYarnEdit_and_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim connstr As New classConnection
		Dim ds1 As New DataSet
		Dim Obj_YarnIn As New tbl_Yarn_in
		Dim UpdateYarnin As New UpdateYarn
		Dim IsValid As Boolean
		Dim i As Integer
		Dim Msgerr As String = ""
		Dim strsql1 As String = ""

		strsql1 = "select * from yarn_in_det where docno = '" & Me.txtyarnincode.Text.Trim & "'"
		'and yr =year(getdate())"
		Dim dadet As New SqlDataAdapter(strsql1, connStr.connection)
		dadet.Fill(ds1, "tbl_yarn_in_det")
		'If ds1.Tables("tbl_yarn_in_det").Rows.Count > 0 Then

		'Else
		'    MsgBox("", MsgBoxStyle.Critical, "Error data ")
		'End If

		Obj_YarnIn.docno = Me.txtyarnincode.Text
		'Obj_YarnIn. jobno =
		'Obj_YarnIn.purno = Me.txtPO.Text.Trim
		Obj_YarnIn.sinvno = UCase(Me.txtSupp.Text.Trim)
		Obj_YarnIn.sinvdt = Me.txtSupDt.Text.Trim
		Obj_YarnIn.suppcd = Me.CbSupplier.SelectedValue
		Obj_YarnIn.lotno_sup = UCase(Me.txtSupLot.Text.Trim)
		'Obj_YarnIn. lotno_our =
		Obj_YarnIn.srefno = Me.txtSupRefno.Text.Trim
		'Obj_YarnIn. totkg=
		'        Obj_YarnIn.curr = Me.cboCurrency.SelectedValue
		'       Obj_YarnIn.exrt = Me.txtrate.Text.Trim
		'      Obj_YarnIn.vat = Me.txtVat.Text.Trim
		'Obj_YarnIn.vatamt = Me.txtVatAmount.Text.Trim
		'Obj_YarnIn. taxper =
		'Obj_YarnIn.taxamt = Me.txtTaxAmount.Text.Trim
		'Obj_YarnIn.freight = Me.txtFreight.Text.Trim
		'        Obj_YarnIn.insurance = Me.txtInsurance.Text.Trim
		'       Obj_YarnIn.otheramt = Me.txtAmt.Text.Trim
		'      Obj_YarnIn.other_text = Me.txtDetail.Text.Trim
		'     Obj_YarnIn.discamt = Me.txtDiscountamount.Text.Trim
		'    Obj_YarnIn.totamt = Me.txtTotalAmount.Text.Trim
		'Obj_YarnIn.tstamp = Me.DateYIN.Value.ToString("yyy/MM/dd")
		'Obj_YarnIn. tran_type =
		'Obj_YarnIn. docapp =
		'Obj_YarnIn. cancel =
		'Obj_YarnIn. outno =
		'Obj_YarnIn.remark = Me.txtremark.Text.Trim

		IsValid = UpdateYarnin.UpdateYarnIn(Obj_YarnIn, dt_yarnindet.GetChanges(), Msgerr, da, loginEmpcd)
		''========================================================================
		Dim strupdate_det As String = ""
		Dim strupt As New StringBuilder
		'Dim connstr As New classConnection
		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connstr.connection
		conn.Open()
		Dim tran As SqlTransaction
		Dim comm As SqlCommand = New SqlCommand
		tran = conn.BeginTransaction
		comm.Connection = conn
		comm.Transaction = tran
		Try
			Dim sum_tran_no As Integer
			Dim boxno_tran As Long
			Dim total_num_row_yarn_in_det As Integer
			Dim old_num_intbl_num As Integer
			Dim new_num As Integer
			Dim mm As String
			Dim yy As String
			Dim m_format As String
			old_num_intbl_num = 0
			new_num = 0
			boxno_tran = 0
			sum_tran_no = 0
			total_num_row_yarn_in_det = 0
			Dim strPrefix_tran_boxno As String = ""
			Dim strsql2 As String = ""
			strsql2 = "select * from num  where idname = 'YBOXNO'  and yr = " & Year(Today())
			Dim dadet1 As New SqlDataAdapter(strsql2, connstr.connection)
			dadet1.Fill(ds1, "tbl_Gen_num_boxno")
			If ds1.Tables("tbl_Gen_num_boxno").Rows.Count > 0 Then
				boxno_tran = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				boxno_tran = boxno_tran + 1
				old_num_intbl_num = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				strPrefix_tran_boxno = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("prefix").ToString
				m_format = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("format").ToString.Trim
			Else
				MsgBox("check  Return False", MsgBoxStyle.Critical, "")
				Exit Sub
			End If
			ds1.Tables("tbl_Gen_num_boxno").Clear()

			'------------------ Delete records ---------------------

			Dim deletedRecs As New DataView(dt_yarnindet, "", "", DataViewRowState.Deleted)
			Dim deletedRec As DataRowView
			Dim m_Boxno As String
			Dim strDelete As String
			For Each deletedRec In deletedRecs
				m_Boxno = deletedRec("Boxno")
				strDelete = "Delete Yarn_in_det where boxno = '" & m_Boxno & "'"
				comm.CommandText = strDelete.ToString
				comm.ExecuteNonQuery()
			Next

			'------------------ Update or insert records ---------------------

			For i = 0 To Me.DgYarn.Rows.Count - 2
				If Me.DgYarn.Rows(i).Cells("boxno").Value.ToString.Trim <> "" Then
					strupdate_det = strupdate_det & "Update Yarn_in_det "
					strupdate_det = strupdate_det & " SET itcd='" & Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString.Trim & "',"
					strupdate_det = strupdate_det & "boxno_s='" & Me.DgYarn.Rows(i).Cells("boxno_s").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "grade='" & Me.DgYarn.Rows(i).Cells("Grade").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "kg_gr='" & Me.DgYarn.Rows(i).Cells("kg_gr").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "cart_tearwt='" & Me.DgYarn.Rows(i).Cells("kg_gr2").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "spools='" & Me.DgYarn.Rows(i).Cells("spools").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "kg_nt='" & Me.DgYarn.Rows(i).Cells("kg_nt").Value.ToString.Trim & "',"
					strupdate_det = strupdate_det & "tstamp='" & Clsconfig.ConvertFormatDateTostring(Today.Date) & "'"
					strupdate_det = strupdate_det & " WHERE docno = '" & txtyarnincode.Text.Trim & "' and boxno = '" & Me.DgYarn.Rows(i).Cells("boxno").Value.ToString.Trim & " '"
					comm.CommandText = strupdate_det.ToString
					comm.ExecuteNonQuery()
				Else
					total_num_row_yarn_in_det = total_num_row_yarn_in_det + 1
					If Me.DgYarn.Rows(i).Cells("Kg_gr").Value.ToString = "" Then
						Me.DgYarn.Rows(i).Cells("Kg_gr").Value = "0"
					End If

					If Me.DgYarn.Rows(i).Cells("Kg_gr2").Value.ToString = "" Then
						Me.DgYarn.Rows(i).Cells("Kg_gr2").Value = "0"
					End If

					If Me.DgYarn.Rows(i).Cells("Kg_NT").Value.ToString = "" Then
						Me.DgYarn.Rows(i).Cells("Kg_nt").Value = "0"
					End If
					YY = Mid(Year(Today.Date), 3, 2).Trim
					YY = YY.PadLeft(2, "0")

					MM = Month(Today.Date).ToString.Trim
					MM = MM.PadLeft(2, "0")
					m_Boxno = ""

					If m_format = "" Then
						m_Boxno = strPrefix_tran_boxno.Trim & boxno_tran.ToString.Trim
					End If
					If UCase(m_format) = "YY" Then
						m_Boxno = strPrefix_tran_boxno.Trim & yy & boxno_tran.ToString.Trim
					End If

					If UCase(m_format) = "YYMM" Then
						m_Boxno = strPrefix_tran_boxno.Trim & yy & mm & boxno_tran.ToString.Trim
					End If
					If UCase(m_format) <> "YY" And UCase(m_format) <> "YYMM" Then
						m_Boxno = strPrefix_tran_boxno.Trim & boxno_tran.ToString.Trim
					End If

					'm_Boxno = strPrefix_tran_boxno.Trim & boxno_tran.ToString.Trim

					strupdate_det = "insert into Yarn_in_det(docno,itcd,boxno_s,boxno,boxno_o,spools,grade," & _
					"kg_gr,cart_tearwt,spool_tearwt,kg_nt,price,tstamp,lotno_sup,lotno_our) " & _
					"values('" & Me.txtyarnincode.Text.Trim & "','" & Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString.Trim & "','" & Me.DgYarn.Rows(i).Cells("boxno_s").Value.ToString.Trim & "'," & _
					"'" & m_Boxno & "','','" & Me.DgYarn.Rows(i).Cells("spools").Value.ToString.Trim & "'," & _
					"'" & Me.DgYarn.Rows(i).Cells("Grade").Value.ToString.Trim & "','" & Me.DgYarn.Rows(i).Cells("kg_gr").Value.ToString.Trim & "','" & Me.DgYarn.Rows(i).Cells("kg_gr2").Value.ToString.Trim & "'," & _
					"0,'" & Me.DgYarn.Rows(i).Cells("kg_nt").Value.ToString.Trim & "',0," & _
					"'" & Clsconfig.ConvertFormatDateTostring(Today.Date) & "','" & ds1.Tables("tbl_yarn_in_det").Rows(0).Item("lotno_sup").ToString.Trim & "','" & ds1.Tables("tbl_yarn_in_det").Rows(0).Item("lotno_our").ToString.Trim & "') "

					comm.CommandText = strupdate_det.ToString
					comm.ExecuteNonQuery()
					boxno_tran = boxno_tran + 1
				End If
			Next

			If total_num_row_yarn_in_det > 0 Then
				new_num = old_num_intbl_num + total_num_row_yarn_in_det
				strsql2 = "Update Num set num = '" & boxno_tran - 1 & "' where idname = 'YBOXNO'  and yr = " & Year(Today())
				comm.CommandText = strsql2.ToString
				comm.ExecuteNonQuery()
			End If

			tran.Commit()
			MsgBox("Update Success")
		Catch ex As Exception
			Msgerr = ex.Message
			MsgBox(Msgerr)
			tran.Rollback()
		Finally
			conn.Close()
		End Try

		''========================================================================
		'If IsValid = True Then
		'    MsgBox("Update Success")
		'ElseIf IsValid = False Then
		'    MsgBox(Msgerr)
		'End If
	End Sub

	Private Sub txtPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Dim tblPur As New tbl_Pur
		Dim arr_tblPurPur As New tbl_Pur
		Dim msgerr As String = ""
		Dim getDatayarn As New GetDataYarn
		Dim objarr_tblPur() As tbl_Pur
		Dim ds As New DataSet
		Dim objsupp As New GetDataYarn
		'Dim arr_tblPur() As Tbl_Pur
		Try
			'arr_tblPurPur.purno = UCase(Me.txtPO.Text.Trim)
			objarr_tblPur = getDatayarn.checkPurno(arr_tblPurPur, msgerr)
			If Not IsNothing(objarr_tblPur) Then
				'ds = objsupp.GetDataSupplier(UCase(Me.txtPO.Text.Trim), msgerr)
				CbSupplier.DataSource = ds.Tables(0)
			ElseIf IsNothing(objarr_tblPur) Then
				Me.CbSupplier.Text = ""
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub BtnYarnPrintDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnPrintDoc.Click
		Dim ds As New DataSet
		Dim connstr As New classConnection
		Dim str As String
		str = ""
		ds.Clear()
		str = "select * from v_yarn_in  " & _
		 "where docno = '" & txtyarnincode.Text & "'"

		Dim myda As New SqlDataAdapter(str.ToString, connstr.connection)
		myda.Fill(ds, "TblDatayarnin")

		Dim frmreport As New FormRptYarnIn
		Dim obj As New RptYarnIn
		obj.SetDataSource(ds.Tables("TblDatayarnin"))

		frmreport.CrystalReportViewer1.ReportSource = obj


		frmreport.ShowDialog()
	End Sub


	Private Sub sumtotal()
		Dim sumgross As Double
		Dim sumnet As Double
		Dim i As Integer
		Try
			Dim countGrid As Integer
			countGrid = Me.DgYarn.Rows.Count
			For i = 0 To Me.DgYarn.Rows.Count - 2
				Dim kg_gr As Double
				Dim kg_nt As Double

				If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_gr").Value) Then
					kg_gr = 0
				Else
					kg_gr = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_gr").Value)
				End If

				If IsDBNull(Me.DgYarn.Rows(i).Cells("Kg_nt").Value) Then
					kg_nt = 0
				Else
					kg_nt = Clsconfig.IsValidDouble(Me.DgYarn.Rows(i).Cells("Kg_gr").Value)
				End If

				sumgross = sumgross + kg_gr
				sumnet = sumnet + kg_nt
			Next
			Me.txttotalgross.Text = sumgross
			Me.txttotalnet.Text = sumnet
			txttotalboxes.Text = Me.DgYarn.RowCount - 1
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

	End Sub

	Private Sub BtnYarnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnYarnExit.Click
		Me.Close()
	End Sub


	Private Sub DgYarn_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.CellValidated
		sumtotal()
	End Sub

	Private Sub DgYarn_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DgYarn.DefaultValuesNeeded
		With e.Row
			.Cells("docno").Value = txtyarnincode.Text
		End With
		'		e.Row.Cells(1).Value = Me.DgYarn.Rows(0).Cells(0).Value
		e.Row.Cells(2).Value = 0
		e.Row.Cells("Boxno").Value = ""
		e.Row.Cells("spools").Value = saveTube
		e.Row.Cells("kg_nt").Value = saveKG_net
		e.Row.Cells("kg_gr").Value = saveGross
		e.Row.Cells("kg_gr2").Value = saveBoxTearWeight
		e.Row.Cells("cboItcd").Value = saveItcd
	End Sub

	Private Sub DgYarn_RowValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgYarn.RowValidated
		Dim currentRow As Integer
		currentRow = e.RowIndex
		saveItcd = Me.DgYarn.Rows(currentRow).Cells("cboItcd").Value
		saveTube = Me.DgYarn.Rows(currentRow).Cells("spools").Value
		saveKG_net = Me.DgYarn.Rows(currentRow).Cells("kg_nt").Value
		saveBoxTearWeight = Me.DgYarn.Rows(currentRow).Cells("kg_gr2").Value
		saveGross = Me.DgYarn.Rows(currentRow).Cells("kg_gr").Value
	End Sub

	Private Sub BtnYarnPrintBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		If Me.txtyarnincode.Text.Length > 5 Then
			Dim K As New formPrintBarcode
			Dim stryarnin As String
			stryarnin = Me.txtyarnincode.Text.Trim
			K.Show()
			K.txtYarn_in_no.Text = stryarnin.ToString.Trim
			K.btnFindByYarnInClick()
			K.SelectAll(sender, e)
		End If
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		cancelYarnin()
	End Sub
	Private Sub cancelYarnin()
		Dim connstr As New classConnection
		Dim ds1 As New DataSet
		Dim Obj_YarnIn As New tbl_Yarn_in
		Dim UpdateYarnin As New UpdateYarn
		Dim IsValid As Boolean
		Dim i As Integer
		Dim Msgerr As String = ""
		Dim strsql1 As String = ""

		strsql1 = "select * from yarn_in_det where docno = '" & Me.txtyarnincode.Text.Trim & "'"
		'and yr =year(getdate())"
		Dim dadet As New SqlDataAdapter(strsql1, connstr.connection)
		dadet.Fill(ds1, "tbl_yarn_in_det")
		'If ds1.Tables("tbl_yarn_in_det").Rows.Count > 0 Then

		'Else
		'    MsgBox("", MsgBoxStyle.Critical, "Error data ")
		'End If

		Obj_YarnIn.docno = Me.txtyarnincode.Text
		'Obj_YarnIn. jobno =
		'Obj_YarnIn.purno = Me.txtPO.Text.Trim
		Obj_YarnIn.sinvno = UCase(Me.txtSupp.Text.Trim)
		Obj_YarnIn.sinvdt = Me.txtSupDt.Text.Trim
		Obj_YarnIn.suppcd = Me.CbSupplier.SelectedValue
		Obj_YarnIn.lotno_sup = UCase(Me.txtSupLot.Text.Trim)
		'Obj_YarnIn. lotno_our =
		Obj_YarnIn.srefno = Me.txtSupRefno.Text.Trim
		'Obj_YarnIn. totkg=
		'        Obj_YarnIn.curr = Me.cboCurrency.SelectedValue
		'       Obj_YarnIn.exrt = Me.txtrate.Text.Trim
		'      Obj_YarnIn.vat = Me.txtVat.Text.Trim
		'Obj_YarnIn.vatamt = Me.txtVatAmount.Text.Trim
		'Obj_YarnIn. taxper =
		'Obj_YarnIn.taxamt = Me.txtTaxAmount.Text.Trim
		'Obj_YarnIn.freight = Me.txtFreight.Text.Trim
		'        Obj_YarnIn.insurance = Me.txtInsurance.Text.Trim
		'       Obj_YarnIn.otheramt = Me.txtAmt.Text.Trim
		'      Obj_YarnIn.other_text = Me.txtDetail.Text.Trim
		'     Obj_YarnIn.discamt = Me.txtDiscountamount.Text.Trim
		'    Obj_YarnIn.totamt = Me.txtTotalAmount.Text.Trim
		'Obj_YarnIn.tstamp = Me.DateYIN.Value.ToString("yyy/MM/dd")
		'Obj_YarnIn. tran_type =
		'Obj_YarnIn. docapp =
		'Obj_YarnIn. cancel =
		'Obj_YarnIn. outno =
		'Obj_YarnIn.remark = Me.txtremark.Text.Trim

		IsValid = UpdateYarnin.UpdateYarnIn(Obj_YarnIn, dt_yarnindet.GetChanges(), Msgerr, da, loginEmpcd)
		''========================================================================
		Dim strupdate_det As String = ""
		Dim strupt As New StringBuilder
		'Dim connstr As New classConnection
		Dim conn As SqlConnection = New SqlConnection
		conn.ConnectionString = connstr.connection
		conn.Open()
		Dim tran As SqlTransaction
		Dim comm As SqlCommand = New SqlCommand
		tran = conn.BeginTransaction
		comm.Connection = conn
		comm.Transaction = tran
		Try
			Dim sum_tran_no As Integer
			Dim boxno_tran As Long
			Dim total_num_row_yarn_in_det As Integer
			Dim old_num_intbl_num As Integer
			Dim new_num As Integer
			Dim mm As String
			Dim yy As String
			Dim m_format As String
			old_num_intbl_num = 0
			new_num = 0
			boxno_tran = 0
			sum_tran_no = 0
			total_num_row_yarn_in_det = 0
			Dim strPrefix_tran_boxno As String = ""
			Dim strsql2 As String = ""
			strsql2 = "select * from num  where idname = 'YBOXNO'  and yr = " & Year(Today())
			Dim dadet1 As New SqlDataAdapter(strsql2, connstr.connection)
			dadet1.Fill(ds1, "tbl_Gen_num_boxno")
			If ds1.Tables("tbl_Gen_num_boxno").Rows.Count > 0 Then
				boxno_tran = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				boxno_tran = boxno_tran + 1
				old_num_intbl_num = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("num").ToString
				strPrefix_tran_boxno = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("prefix").ToString
				m_format = ds1.Tables("tbl_Gen_num_boxno").Rows(0).Item("format").ToString.Trim
			Else
				MsgBox("check  Return False", MsgBoxStyle.Critical, "")
				Exit Sub
			End If
			ds1.Tables("tbl_Gen_num_boxno").Clear()

			'------------------ Delete records ---------------------

			Dim deletedRecs As New DataView(dt_yarnindet, "", "", DataViewRowState.Deleted)
			Dim deletedRec As DataRowView
			Dim m_Boxno As String
			Dim strDelete As String
			For Each deletedRec In deletedRecs
				m_Boxno = deletedRec("Boxno")
				strDelete = "Delete Yarn_in_det where boxno = '" & m_Boxno & "'"
				comm.CommandText = strDelete.ToString
				comm.ExecuteNonQuery()
			Next

			'------------------ Update or insert records ---------------------

			For i = 0 To Me.DgYarn.Rows.Count - 2
				If Me.DgYarn.Rows(i).Cells("boxno").Value.ToString.Trim <> "" Then
					strupdate_det = strupdate_det & "Update Yarn_in_det "
					strupdate_det = strupdate_det & " SET itcd='" & Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString.Trim & "',"
					strupdate_det = strupdate_det & "boxno_s='" & Me.DgYarn.Rows(i).Cells("boxno_s").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "grade='" & Me.DgYarn.Rows(i).Cells("Grade").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "kg_gr='" & Me.DgYarn.Rows(i).Cells("kg_gr").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "cart_tearwt='" & Me.DgYarn.Rows(i).Cells("kg_gr2").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "spools='" & Me.DgYarn.Rows(i).Cells("spools").Value.ToString.Trim & "', "
					strupdate_det = strupdate_det & "kg_nt='" & Me.DgYarn.Rows(i).Cells("kg_nt").Value.ToString.Trim & "',"
					strupdate_det = strupdate_det & "tstamp='" & Clsconfig.ConvertFormatDateTostring(Today.Date) & "'"
					strupdate_det = strupdate_det & " WHERE docno = '" & txtyarnincode.Text.Trim & "' and boxno = '" & Me.DgYarn.Rows(i).Cells("boxno").Value.ToString.Trim & " '"
					comm.CommandText = strupdate_det.ToString
					comm.ExecuteNonQuery()
				Else
					total_num_row_yarn_in_det = total_num_row_yarn_in_det + 1
					If Me.DgYarn.Rows(i).Cells("Kg_gr").Value.ToString = "" Then
						Me.DgYarn.Rows(i).Cells("Kg_gr").Value = "0"
					End If

					If Me.DgYarn.Rows(i).Cells("Kg_gr2").Value.ToString = "" Then
						Me.DgYarn.Rows(i).Cells("Kg_gr2").Value = "0"
					End If

					If Me.DgYarn.Rows(i).Cells("Kg_NT").Value.ToString = "" Then
						Me.DgYarn.Rows(i).Cells("Kg_nt").Value = "0"
					End If
					yy = Mid(Year(Today.Date), 3, 2).Trim
					yy = yy.PadLeft(2, "0")

					mm = Month(Today.Date).ToString.Trim
					mm = mm.PadLeft(2, "0")
					m_Boxno = ""

					If m_format = "" Then
						m_Boxno = strPrefix_tran_boxno.Trim & boxno_tran.ToString.Trim
					End If
					If UCase(m_format) = "YY" Then
						m_Boxno = strPrefix_tran_boxno.Trim & yy & boxno_tran.ToString.Trim
					End If

					If UCase(m_format) = "YYMM" Then
						m_Boxno = strPrefix_tran_boxno.Trim & yy & mm & boxno_tran.ToString.Trim
					End If
					If UCase(m_format) <> "YY" And UCase(m_format) <> "YYMM" Then
						m_Boxno = strPrefix_tran_boxno.Trim & boxno_tran.ToString.Trim
					End If

					'm_Boxno = strPrefix_tran_boxno.Trim & boxno_tran.ToString.Trim

					strupdate_det = "insert into Yarn_in_det(docno,itcd,boxno_s,boxno,boxno_o,spools,grade," & _
					"kg_gr,cart_tearwt,spool_tearwt,kg_nt,price,tstamp,lotno_sup,lotno_our) " & _
					"values('" & Me.txtyarnincode.Text.Trim & "','" & Me.DgYarn.Rows(i).Cells("cboitcd").Value.ToString.Trim & "','" & Me.DgYarn.Rows(i).Cells("boxno_s").Value.ToString.Trim & "'," & _
					"'" & m_Boxno & "','','" & Me.DgYarn.Rows(i).Cells("spools").Value.ToString.Trim & "'," & _
					"'" & Me.DgYarn.Rows(i).Cells("Grade").Value.ToString.Trim & "','" & Me.DgYarn.Rows(i).Cells("kg_gr").Value.ToString.Trim & "','" & Me.DgYarn.Rows(i).Cells("kg_gr2").Value.ToString.Trim & "'," & _
					"0,'" & Me.DgYarn.Rows(i).Cells("kg_nt").Value.ToString.Trim & "',0," & _
					"'" & Clsconfig.ConvertFormatDateTostring(Today.Date) & "','" & ds1.Tables("tbl_yarn_in_det").Rows(0).Item("lotno_sup").ToString.Trim & "','" & ds1.Tables("tbl_yarn_in_det").Rows(0).Item("lotno_our").ToString.Trim & "') "

					comm.CommandText = strupdate_det.ToString
					comm.ExecuteNonQuery()
					boxno_tran = boxno_tran + 1
				End If
			Next

			If total_num_row_yarn_in_det > 0 Then
				new_num = old_num_intbl_num + total_num_row_yarn_in_det
				strsql2 = "Update Num set num = '" & boxno_tran - 1 & "' where idname = 'YBOXNO'  and yr = " & Year(Today())
				comm.CommandText = strsql2.ToString
				comm.ExecuteNonQuery()
			End If

			tran.Commit()
			MsgBox("Update Success")
		Catch ex As Exception
			Msgerr = ex.Message
			MsgBox(Msgerr)
			tran.Rollback()
		Finally
			conn.Close()
		End Try

		''========================================================================
		'If IsValid = True Then
		'    MsgBox("Update Success")
		'ElseIf IsValid = False Then
		'    MsgBox(Msgerr)
		'End If

	End Sub
End Class
