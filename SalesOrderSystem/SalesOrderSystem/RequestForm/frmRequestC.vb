Imports System.Drawing
Imports System.Data.SqlClient

Public Class frmRequestC
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo

	Dim strReqNo As String = ""
	Dim blnCancel As Boolean = False
	Dim idx As Long = 0
	Dim idx2 As Long = 0

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Private Sub SetControlValue(ByVal Obj As Control)
		If TypeOf Obj Is TextBox Then
			If Obj.Tag = "str" Then Obj.Text = ""
			If Obj.Tag = "int" Then Obj.Text = "0.00"
		End If
		If TypeOf Obj Is DateTimePicker Then
			Dim dtp As DateTimePicker = Obj
			dtp.Value = Now
		End If
		If TypeOf Obj Is ComboBox Then
			Dim cbo As ComboBox = Obj
			cbo.SelectedValue = ""
		End If
		If TypeOf Obj Is CheckBox Then
			Dim chk As CheckBox = Obj
			chk.Checked = False
		End If
		If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
			Dim obj2 As Control
			For Each obj2 In Obj.Controls
				Call SetControlValue(obj2)
			Next
		End If
	End Sub

	Private Sub InitControl()
		Dim obj As Control
		For Each obj In Me.Controls
			Call SetControlValue(obj)
		Next
		Call EnabledControl(True)
		strReqNo = ""
		dtpReleaseDate.Value = CDate("01/01/1900")
		lblCancelled.Visible = False
		ClearGrdDesign()
		ClearGrdStock()
		ClearGrdReq()
		Call LoadData("")
		txtReqNo.Focus()
	End Sub

	Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
		If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
		If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
		If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
		If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
		If TypeOf Obj Is DataGridView Then
			Dim grd As DataGridView = Obj
			grd.ReadOnly = Not blnEnabled
		End If
		If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
			Dim obj2 As Control
			For Each obj2 In Obj.Controls
				Call SetControlEnabled(obj2, blnEnabled)
			Next
		End If
	End Sub

	Private Sub EnabledControl(ByVal blnEnabled As Boolean)
		Dim obj As Control
		For Each obj In Me.Controls
			Call SetControlEnabled(obj, blnEnabled)
		Next
	End Sub

	Private Sub GenCombo()
		Dim objDB As New classMaster
		Me.cboDocType.DataSource = objDB.GetDocType
		Me.cboDocType.DisplayMember = "name"
		Me.cboDocType.ValueMember = "doctyp"

		Me.cboCustomer.DataSource = objDB.GetCustomer
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "new_custcd"

		Me.cboDesignNo.DataSource = objDB.GetDesign
		Me.cboDesignNo.DisplayMember = "design_no"
		Me.cboDesignNo.ValueMember = "design_no"

		Me.cboUOM.DataSource = objDB.GetUOM
		Me.cboUOM.DisplayMember = "uom2"
		Me.cboUOM.ValueMember = "uom2"

		Me.cboSoNo.DataSource = objDB.GetSoNo
		Me.cboSoNo.DisplayMember = "sono2"
		Me.cboSoNo.ValueMember = "sono2"
	End Sub

	Private Sub GenComboReqNo()
		Dim objDB As New classRequest
		cboReqNo.ComboBox.DataSource = objDB.GetReqNo("C")
		cboReqNo.ComboBox.DisplayMember = "outreqno"
		cboReqNo.ComboBox.ValueMember = "outreqno"
		If strReqNo.Trim.Length > 0 Then cboReqNo.ComboBox.SelectedValue = strReqNo.Trim
	End Sub

	Private Sub GenComboDesignNo()
		On Error Resume Next
		Dim objDB As New classDFOrder
        cboDesignNo.DataSource = objDB.GetSODesign(clsConfig.IsNull(cboSoNo.SelectedValue, ""))
		cboDesignNo.DisplayMember = "design_no"
		cboDesignNo.ValueMember = "design_no"
	End Sub

	Private Sub BindData(ByVal dt As DataTable)
		strReqNo = dt.Rows(0)("outreqno").ToString.Trim
		txtReqNo.Text = dt.Rows(0)("outreqno").ToString.Trim
		dtpReqDate.Value = CDate(dt.Rows(0)("outreqdt2").ToString)

		cboDocType.SelectedValue = dt.Rows(0)("outreqtyp").ToString.Trim
		cboUOM.SelectedValue = dt.Rows(0)("uom").ToString.Trim
		txtVerNo.Text = dt.Rows(0)("verno").ToString.Trim
		cboSoNo.SelectedValue = dt.Rows(0)("sono").ToString.Trim
		cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString.Trim
		cboDesignNo.SelectedValue = dt.Rows(0)("design_no").ToString.Trim
		dtpReleaseDate.Value = CDate(dt.Rows(0)("release_date2").ToString)
		txtRemark.Text = dt.Rows(0)("remark").ToString.Trim
		optSize1.Checked = CBool(dt.Rows(0)("size1"))
		optSize2.Checked = CBool(dt.Rows(0)("size2"))
		optTube1.Checked = CBool(dt.Rows(0)("mtype1"))
		optTube2.Checked = CBool(dt.Rows(0)("mtype2"))
		optLogo1.Checked = CBool(dt.Rows(0)("logo1"))
		optLogo2.Checked = CBool(dt.Rows(0)("logo2"))

		If CBool(dt.Rows(0)("cancel_status")) Then
			lblCancelled.Visible = True
			Call EnabledControl(False)
		End If
	End Sub

	Private Sub BindGrid(ByVal dt As DataTable)
		grdReqDetD.AutoGenerateColumns = False
		grdReqDetD.DataSource = dt
	End Sub

	Private Function IsDataChange() As Boolean
		Dim result As Boolean = False
		Dim dt As New DataTable
		dt = grdReqDetD.DataSource
		Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
		If dt Is Nothing Or dv.Count = 0 Or grdReqDetD.Rows.Count = 0 Then
			If grdReqDetD.Rows.Count > 1 Then result = True

			If dtpReqDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
			If clsConfig.IsNull(cboDocType.SelectedValue, "") <> "" Then result = True
			If clsConfig.IsNull(cboUOM.SelectedValue, "") <> "" Then result = True
			If txtVerNo.Text <> "" Then result = True
			If cboSoNo.SelectedValue <> "" Then result = True
			If cboCustomer.SelectedValue <> "" Then result = True
			If cboDesignNo.SelectedValue <> "" Then result = True
			If dtpReleaseDate.Value.ToString("yyyyMMdd") <> "19000101" Then result = True
			If txtRemark.Text <> "" Then result = True
			If optSize1.Checked = False Then result = True
			If optTube1.Checked = False Then result = True
			If optLogo1.Checked = False Then result = True
		Else
			Dim i As Integer = CheckDelRow(dt)
			If Not lblCancelled.Visible Then
				If dtpReqDate.Value <> CDate(dt.Rows(i)("outreqdt2").ToString) Then result = True
				If cboDocType.SelectedValue <> dt.Rows(i)("outreqtyp").ToString.Trim Then result = True
				If cboUOM.SelectedValue <> dt.Rows(i)("uom").ToString.Trim Then result = True
				If txtVerNo.Text <> dt.Rows(i)("verno").ToString.Trim Then result = True
				If cboSoNo.SelectedValue <> dt.Rows(i)("sono").ToString.Trim Then result = True
				If cboCustomer.SelectedValue <> dt.Rows(i)("custcd").ToString.Trim Then result = True
				If cboDesignNo.SelectedValue <> dt.Rows(i)("design_no").ToString.Trim Then result = True
				If dtpReleaseDate.Value <> CDate(dt.Rows(i)("release_date2").ToString) Then result = True
				If txtRemark.Text <> dt.Rows(i)("remark").ToString.Trim Then result = True
				If optSize1.Checked <> CBool(dt.Rows(i)("size1")) Then result = True
				If optTube1.Checked <> CBool(dt.Rows(i)("mtype1")) Then result = True
				If optLogo1.Checked <> CBool(dt.Rows(i)("logo1")) Then result = True

				Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
				If delRecs.Count > 0 Then result = True

				Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
				If updRecs.Count > 0 Then result = True

				Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
				If addRecs.Count > 0 Then result = True
			End If
		End If

		IsDataChange = result
	End Function

	Private Function CheckData() As Boolean
		If lblCancelled.Visible Then
			MessageBox.Show("This document is cancelled." & vbCrLf & "Can't edit anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If clsConfig.IsNull(cboDocType.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose Document Type !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If clsConfig.IsNull(cboUOM.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose Unit of Mesurement !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose S/O No. !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose customer!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If grdReqDetD.Rows.Count <= 0 Then
			MessageBox.Show("Please insert data in table at least 1 record!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If

		'Dim dt As DataTable = grdReqDetD.DataSource
		'Dim dt2 As DataTable = dt.Clone()
		'Dim i As Integer = 0
		'Dim j As Integer = 0
		'Dim strRollNo As String = ""
		'Dim AllKgs As Double = 0
		'Dim AllYds As Double = 0
		'Dim AllMts As Double = 0
		'Dim Kgs As Double = 0
		'Dim Yds As Double = 0
		'Dim Mts As Double = 0
		'If dt2.Rows.Count > 1 Then
		'	For i = 0 To dt2.Rows.Count - 1
		'		strRollNo = clsConfig.IsNull(dt2.Rows(i)("roll_no"), "").ToString.Trim
		'		AllKgs = clsConfig.IsNull(dt2.Rows(i)("kg"), 0)
		'		AllYds = clsConfig.IsNull(dt2.Rows(i)("yds"), 0)
		'		AllMts = clsConfig.IsNull(dt2.Rows(i)("mts"), 0)
		'		Kgs = 0
		'		Yds = 0
		'		Mts = 0
		'		For j = 0 To dt2.Rows.Count - 1
		'			If strRollNo = clsConfig.IsNull(dt2.Rows(j)("roll_no"), "").ToString.Trim Then
		'				Kgs = Kgs + clsConfig.IsNull(dt2.Rows(j)("k"), 0)
		'				Yds = Yds + clsConfig.IsNull(dt2.Rows(j)("y"), 0)
		'				Mts = Mts + clsConfig.IsNull(dt2.Rows(j)("m"), 0)
		'			End If
		'		Next
		'		If Kgs > AllKgs Then
		'			MessageBox.Show("Roll No. " & strRollNo & " can't choose over " & AllKgs & " Kgs." & vbCrLf & "ม้วนผ้าเลขที่ " & strRollNo & " ที่เลือกต้องหนักรวมกันไม่เกิน " & AllKgs & " Kgs.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
		'			CheckData = False
		'			Exit Function
		'		End If
		'		If Yds > AllYds Then
		'			MessageBox.Show("Roll No. " & strRollNo & " can't choose over " & AllYds & " Yds." & vbCrLf & "ม้วนผ้าเลขที่ " & strRollNo & " ที่เลือกต้องยาวรวมกันไม่เกิน " & AllYds & " Yds.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
		'			CheckData = False
		'			Exit Function
		'		End If
		'		If Mts > AllMts Then
		'			MessageBox.Show("Roll No. " & strRollNo & " can't choose over " & AllMts & " Mts." & vbCrLf & "ม้วนผ้าเลขที่ " & strRollNo & " ที่เลือกต้องยาวรวมกันไม่เกิน " & AllMts & " mts.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
		'			CheckData = False
		'			Exit Function
		'		End If
		'	Next
		'End If
		CheckData = True
	End Function

	Private Sub LoadData(ByVal ReqNo As String)
		Dim objDB As New classRequest
		Dim dt As New DataTable
		dt = objDB.ReqDetDCLoad(ReqNo)
		Call BindGrid(dt)
		If dt.Rows.Count > 0 Then Call BindData(dt)
		Call SumGrid()
	End Sub

	Private Sub SumGrid()
		Dim i As Integer = 0
		Dim rolls As Integer = 0
		Dim kgs As Double = 0
		Dim yds As Double = 0
		Dim mts As Double = 0
		Dim dt As DataTable = grdReqDetD.DataSource
		For i = 0 To dt.Rows.Count - 1
			If dt.Rows(i).RowState <> DataRowState.Deleted Then
				rolls = rolls + 1
				kgs = kgs + clsConfig.IsNull(dt.Rows(i)("kg"), 0)
				yds = yds + clsConfig.IsNull(dt.Rows(i)("yds"), 0)
				mts = mts + clsConfig.IsNull(dt.Rows(i)("mts"), 0)
			End If
		Next
		txtSelectedRolls.Text = Format(rolls, "#,###")
		txtSelectedKgs.Text = Format(kgs, "#,###.#0")
		txtSelectedYds.Text = Format(yds, "#,###.#0")
		txtSelectedMts.Text = Format(mts, "#,###.#0")
	End Sub

	Private Sub SumGridStock()
		Dim i As Integer = 0
		Dim rolls As Integer = 0
		Dim kgs As Double = 0
		Dim yds As Double = 0
		Dim mts As Double = 0
        Dim dt As DataTable = grdFreeStockD.DataSource
        ' Dim cls As clsConfig
        For i = 0 To dt.Rows.Count - 1
            If CBool(clsConfig.IsNull(dt.Rows(i)("sel"), False)) Then
                rolls = rolls + 1
                kgs = kgs + clsConfig.IsNull(dt.Rows(i)("kg"), 0)
                yds = yds + clsConfig.IsNull(dt.Rows(i)("yds"), 0)
                mts = mts + clsConfig.IsNull(dt.Rows(i)("mts"), 0)
            End If
        Next
		txtSelectRolls.Text = Format(rolls, "#,###")
		txtSelectKgs.Text = Format(kgs, "#,###.#0")
		txtSelectYds.Text = Format(yds, "#,###.#0")
		txtSelectMts.Text = Format(mts, "#,###.#0")
	End Sub

	Private Function SaveData() As Boolean
		Dim clsReq As New classRequest
		Dim header As New classRequest.ReqHeader
		Dim msgerr As String = ""
		Dim reqno As String = ""
		Dim dt As DataTable = grdReqDetD.DataSource
		Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
		Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
		Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)

		header.h01_outreqno = strReqNo
		header.h02_outreqdt = dtpReqDate.Value.ToString("yyyyMMdd")
		header.h03_outreqtyp = clsConfig.IsNull(cboDocType.SelectedValue, "")
		header.h04_post = "n"
		header.h05_type = ""
		header.h06_qtypack = 0
		header.h07_uom = clsConfig.IsNull(cboUOM.SelectedValue, "")
		header.h08_size1 = optSize1.Checked
		header.h09_size2 = optSize2.Checked
		header.h10_Mtype1 = optTube1.Checked
		header.h11_Mtype2 = optTube2.Checked
		header.h12_logo1 = optLogo1.Checked
		header.h13_logo2 = optLogo2.Checked
		header.h14_remark = txtRemark.Text.Trim
		header.h15_cuscd = clsConfig.IsNull(cboCustomer.SelectedValue, "")
		header.h16_sono = clsConfig.IsNull(cboSoNo.SelectedValue, "")
		header.h17_verno = txtVerNo.Text.Trim
		header.h18_release_date = dtpReleaseDate.Value.ToString("yyyyMMdd")
		header.h19_empcd = clsUser.UserID
		header.h20_stock_type = "C"
		header.h21_cancel_status = False

		If clsReq.ReqDCSave(header, dv_add, dv_upd, dv_del, msgerr, reqno) Then
			strReqNo = reqno
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Function CheckGrdStock() As Boolean
		If grdFreeStockD.DataSource Is Nothing Then Return False
		If grdFreeStockD.Rows.Count = 0 Then Return False
		Dim i As Integer = 0
		For i = 0 To grdFreeStockD.Rows.Count - 1
			If CBool(grdFreeStockD.Rows(i).Cells("stk_sel").Value) Then Return True
		Next
		Return False
	End Function

	Private Function CheckGrdReq() As Boolean
		If grdReqDetD.DataSource Is Nothing Then Return False
		If grdReqDetD.Rows.Count = 0 Then Return False
		Dim i As Integer = 0
		For i = 0 To grdReqDetD.Rows.Count - 1
			If CBool(grdReqDetD.Rows(i).Cells("sel").Value) Then Return True
		Next
		Return False
	End Function

	Private Function AskBeforeChangeDesignNo(ByVal strChangeType As String) As Boolean
		If grdReqDetD.Rows.Count = 0 Then Return True
        If MessageBox.Show("Program must clear all Roll No. in right pane before change " & strChangeType & vbCrLf _
         & "Would you still like to change " & strChangeType & " ?" & vbCrLf _
         & "โปรแกรมจะเคลียร์ม้วนที่เลือกไว้ทั้งหมดอัติโนมัติก่อนเปลี่ยน " & strChangeType & vbCrLf _
         & "คุณยังต้องการจะเปลี่ยน " & strChangeType & " อีกหรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Return False
        Else
            Return True
		End If
	End Function

	Private Sub ClearGrdDesign()
		Dim objDB As New classDFOrder
		grdDesign.AutoGenerateColumns = False
		grdDesign.DataSource = objDB.GetSODesignGrid("Nothing", "Nothing")
	End Sub

	Private Sub ClearGrdStock()
		Dim objDB As New classRequest
		grdFreeStockD.AutoGenerateColumns = False
		grdFreeStockD.DataSource = objDB.ReqDetDCLoad("")
	End Sub

	Private Sub ClearGrdReq()
		Dim objDB As New classRequest
		grdReqDetD.AutoGenerateColumns = False
		grdReqDetD.DataSource = objDB.ReqDetDCLoad("")
	End Sub

	Private Function CheckDuplicate(ByVal strRollNo As String, ByVal strCol As String, ByVal dt As DataTable) As Boolean
		If dt.Rows.Count > 0 Then
			Dim i As Integer = 0
			For i = 0 To dt.Rows.Count - 1
				If dt.Rows(i).RowState <> DataRowState.Deleted Then
					If dt.Rows(i)("roll_no").ToString.Trim = strRollNo _
					And dt.Rows(i)("col").ToString.Trim = strCol Then Return True
				End If
			Next
		End If
		Return False
	End Function

	Private Sub AddRollNo()
		If grdFreeStockD.Rows.Count > 0 Then
			Dim config As New clsConfig
			Dim dt As DataTable = grdFreeStockD.DataSource
			Dim dt2 As DataTable = grdReqDetD.DataSource
			Dim dr As DataRow
			Dim msg As String = ""
			Dim i As Integer = 0
			Dim j As Integer = 0
			For i = 0 To dt.Rows.Count - 1
				If CBool(dt.Rows(i)("sel")) Then
					If Not CheckDuplicate(dt.Rows(i)("roll_no").ToString.Trim, dt.Rows(i)("col").ToString.Trim, dt2.Copy()) Then
						dr = dt2.NewRow
						For j = 0 To dt2.Columns.Count - 1
							dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
						Next
						dt2.Rows.Add(dr)
					Else
						MessageBox.Show("Roll No. " & dt.Rows(i)("roll_no").ToString.Trim & " Color " & dt.Rows(i)("col").ToString.Trim & " is duplicated in right grid." & vbCrLf _
						& "If you want to add same Roll No., Please change color by change S/O No. ID in Grid Above." & vbCrLf _
						& "เลขม้วน " & dt.Rows(i)("roll_no").ToString.Trim & " สี " & dt.Rows(i)("col").ToString.Trim & " ซ้ำกับที่เลือกไว้แล้วด้านขวา" & vbCrLf _
						& "ถ้าจะใช้เลขม้วนเดิมต้องเปลี่ยนสี ถ้าจะเปลี่ยนสีให้เลือก S/O No. ID จากตารางด้านบนใหม่ แล้วกลับมาเลือกม้วนเดิม." & vbCrLf _
						, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
					End If
				End If
			Next
		End If
		Call SumGrid()
	End Sub

	Private Sub DeleteRollNo(ByVal strType As String)
		If grdReqDetD.Rows.Count > 0 Then
			Dim i As Integer = 0
			Dim dt As DataTable = grdReqDetD.DataSource
			If strType = "ALL" Then
				Call ClearGrdReq()
			Else
				Do While i < dt.Rows.Count
					If dt.Rows.Count = 0 Then Exit Do
					For i = 0 To dt.Rows.Count - 1
						If Not dt.Rows(i).RowState = DataRowState.Deleted Then
							If CBool(dt.Rows(i)("sel")) Then
								dt.Rows(i).Delete()
								Exit For
							End If
						End If
					Next
				Loop
			End If
		End If
		Call SumGrid()
	End Sub

	Private Sub frmRequestD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call GenComboReqNo()
		Call InitControl()
	End Sub

	Private Sub frmRequestD_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If IsDataChange() Then Call btnSave_Click(sender, e)
		e.Cancel = blnCancel
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		If IsDataChange() Then Call btnSave_Click(sender, e)
		If Not blnCancel Then Call InitControl()
	End Sub

	Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
		Dim frm As New frmRequestSearch
		frm.pStockType = "C"
		frm.ShowDialog(Me)
		Call btnNew_Click(sender, e)
		Me.Cursor = Cursors.WaitCursor
		If Not blnCancel Then LoadData(frm.pReqNo)
		Me.Cursor = Cursors.Default
		frm.Dispose()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub
        If Not CheckData() Then Exit Sub
		Me.Cursor = Cursors.WaitCursor
		If SaveData() Then
			LoadData(strReqNo)
			Call GenComboReqNo()
			Call cboDesignNo_SelectedIndexChanged(sender, e)
		End If
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		If strReqNo = "" Then strReqNo = txtReqNo.Text.Trim.ToUpper
		If strReqNo.Length = 0 Then Exit Sub
		Const rptFileName = "rptReqC.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

		rpt.VerifyDatabase()
		rpt.SetParameterValue("@outreqno", strReqNo)
		rpt.SetParameterValue("@datefr", "")
		rpt.SetParameterValue("@dateto", "")
		rpt.SetParameterValue("@custcd", "")

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Request Stock Cutted"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		If strReqNo.Trim.Length = 0 Then Exit Sub Else Call btnSave_Click(sender, e)
		If blnCancel Then Exit Sub
		If lblCancelled.Visible Then
			MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Exit Sub
		End If
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Dim objDB As New classRequest
		Call objDB.ReqCancel(strReqNo, clsUser.UserID)
		Call btnNew_Click(sender, e)
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub cboReqNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboReqNo.DropDownClosed
        If cboReqNo.ComboBox.SelectedValue = "" Then
            Exit Sub
        End If
        Dim ReqNo As String
        ReqNo = clsConfig.IsNull(cboReqNo.ComboBox.SelectedValue, "")
		If ReqNo.Substring(0, 2) = "RC" Then
			If ReqNo.Trim.Length > 0 Then
				Call btnNew_Click(sender, e)
				If Not blnCancel Then LoadData(ReqNo)
			End If
		Else
			MessageBox.Show("This Form Can Request Only Cutted Stock." & vbCrLf & "หน้าจอนี้ใช้เฉพาะ Request Stock C เท่านั้น", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
		End If
	End Sub

	Private Sub txtReqNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReqNo.KeyPress
        If cboReqNo.ComboBox.SelectedValue = "" Then
            Exit Sub
        End If
        Dim ReqNo As String = ""
		If Asc(e.KeyChar) = 13 Then
			ReqNo = txtReqNo.Text.Trim.ToUpper
			If ReqNo.Substring(0, 2) = "RC" Then
				Call btnNew_Click(sender, e)
				If Not blnCancel Then LoadData(ReqNo)
			Else
				MessageBox.Show("This Form Can Request Only Cutted Stock." & vbCrLf & "หน้าจอนี้ใช้เฉพาะ Request Stock C เท่านั้น", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			End If
		End If
	End Sub

	Private Sub btnMoveLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveLeft.Click
		If grdFreeStockD.Width > 300 Then
			grdFreeStockD.Width = grdFreeStockD.Width - 300
			btnMoveLeft.Left = grdFreeStockD.Right
			btnMoveRight.Left = grdFreeStockD.Right
			btnAdd.Left = grdFreeStockD.Right
			btnDel.Left = grdFreeStockD.Right
			btnDelAll.Left = grdFreeStockD.Right
			grdReqDetD.Left = btnMoveLeft.Right
			grdReqDetD.Width = grdReqDetD.Width + 300
		End If
	End Sub

	Private Sub btnMoveRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveRight.Click
		If grdReqDetD.Width > 300 Then
			grdFreeStockD.Width = grdFreeStockD.Width + 300
			btnMoveLeft.Left = grdFreeStockD.Right
			btnMoveRight.Left = grdFreeStockD.Right
			btnAdd.Left = grdFreeStockD.Right
			btnDel.Left = grdFreeStockD.Right
			btnDelAll.Left = grdFreeStockD.Right
			grdReqDetD.Left = btnMoveLeft.Right
			grdReqDetD.Width = grdReqDetD.Width - 300
		End If
	End Sub

	Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
		If Not CheckGrdStock() Then Exit Sub
        If MessageBox.Show("Would you like to add selected Roll No. from left grid to right grid ?" & vbCrLf & "คุณต้องการเพิ่มม้วนที่เลือกไว้ด้านซ้ายเพื่อนำไปย้อมด้านขวาใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Call AddRollNo()
	End Sub

	Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
		If Not CheckGrdReq() Then Exit Sub
        If MessageBox.Show("Would you like to delete selected Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบม้วนที่เลือกไว้เพื่อย้อมในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If grdReqDetD.CurrentRow.Index >= 0 Then Call DeleteRollNo("SOME")
	End Sub

	Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
		If lblCancelled.Visible Then Exit Sub
		If grdReqDetD.Rows.Count = 0 Then Exit Sub
        If MessageBox.Show("Would you like to delete all Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบม้วน ทั้งหมด ที่เตรียมจะย้อมในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Call DeleteRollNo("ALL")
	End Sub

	Private Sub cboSoNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoNo.Click
		idx = cboSoNo.SelectedIndex
	End Sub

	Private Sub cboSoNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoNo.DropDownClosed
		If idx >= 0 Then
			If cboSoNo.SelectedIndex = idx Then Exit Sub
			If AskBeforeChangeDesignNo("S/O No.") = False Then
				cboSoNo.SelectedIndex = idx
			Else
				Call DeleteRollNo("ALL")
				cboDesignNo.SelectedIndex = -1
			End If
		End If
	End Sub

	Private Sub cboSoNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoNo.SelectedIndexChanged
		If cboSoNo.SelectedIndex < 0 Then Exit Sub
		Dim config As New clsConfig
		Dim i As Integer = 0
		Dim dt As DataTable = cboSoNo.DataSource
		Dim dt2 As New DataTable
		dt2 = dt.Copy()
		For i = 0 To dt2.Rows.Count - 1
			If dt2.Rows(i)("sono").ToString.Trim = config.IsNull(cboSoNo.SelectedValue, "").ToString.Trim Then
				cboCustomer.SelectedValue = dt2.Rows(i)("custcd").ToString.Trim
				Exit For
			End If
		Next
		Call GenComboDesignNo()
	End Sub

	Private Sub cboDesignNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignNo.Click
		idx2 = cboDesignNo.SelectedIndex
	End Sub

	Private Sub cboDesignNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignNo.DropDownClosed
		If idx2 >= 0 Then
			If cboDesignNo.SelectedIndex = idx2 Then Exit Sub
			If AskBeforeChangeDesignNo("Design No.") = False Then
				cboDesignNo.SelectedIndex = idx2
			Else
				Call DeleteRollNo("ALL")
			End If
		End If
	End Sub

	Private Sub cboDesignNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDesignNo.SelectedIndexChanged
		If cboDesignNo.SelectedIndex < 0 Then Exit Sub
		Dim objDB As New classRequest
		grdDesign.AutoGenerateColumns = False
		grdDesign.DataSource = objDB.GetSODesignGrid2(clsConfig.IsNull(cboSoNo.SelectedValue, "Nothing").ToString.Trim, clsConfig.IsNull(cboDesignNo.SelectedValue, "Nothing").ToString.Trim)
		Call ClearGrdStock()
		Call SumGridStock()
	End Sub

	Private Sub grdFreeStockD_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFreeStockD.CellContentClick
		If grdFreeStockD.CurrentCell.IsInEditMode Then grdFreeStockD.EndEdit()
	End Sub

	Private Sub grdFreeStockD_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdFreeStockD.CellEndEdit
		If grdFreeStockD.Columns(e.ColumnIndex).Name = "stk_sel" Then Call SumGridStock()
	End Sub

	Private Function CheckDelRow(ByVal dt As DataTable) As Integer
		Dim i As Integer = 0
		Dim j As Integer = 0
		For i = 0 To dt.Rows.Count - 1
			If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
		Next
		Return j
	End Function

	Private Sub grdReqDetD_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdReqDetD.CellValueChanged
		If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
		If grdReqDetD.Columns(e.ColumnIndex).Name = "k" Or _
		 grdReqDetD.Columns(e.ColumnIndex).Name = "y" Or _
		 grdReqDetD.Columns(e.ColumnIndex).Name = "m" Then
			If CBool(chkAutoCalculate.Checked) Then
				'If grdReqDetD.Columns(e.ColumnIndex).Name = "y" Then grdReqDetD.Rows(e.RowIndex).Cells("m").Value = FormatNumber(Val(clsConfig.IsNull(grdReqDetD.Rows(e.RowIndex).Cells("y").Value, 0)) * 0.9144, 2, TriState.False, TriState.False, TriState.False)
				'If grdReqDetD.Columns(e.ColumnIndex).Name = "m" Then grdReqDetD.Rows(e.RowIndex).Cells("y").Value = FormatNumber(Val(clsConfig.IsNull(grdReqDetD.Rows(e.RowIndex).Cells("m").Value, 0)) / 0.9144, 2, TriState.False, TriState.False, TriState.False)
				Dim dt As DataTable = grdReqDetD.DataSource
				Dim i As Integer = CheckDelRow(dt)
				If grdReqDetD.Columns(e.ColumnIndex).Name = "k" Then
					dt.Rows(e.RowIndex + i)("y") = FormatNumber(dt.Rows(e.RowIndex + i)("k") * dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
					dt.Rows(e.RowIndex + i)("m") = FormatNumber(dt.Rows(e.RowIndex + i)("y") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
				End If
				If grdReqDetD.Columns(e.ColumnIndex).Name = "y" Then
					If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("k") = FormatNumber(dt.Rows(e.RowIndex + i)("y") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
					dt.Rows(e.RowIndex + i)("m") = FormatNumber(dt.Rows(e.RowIndex + i)("y") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
				End If
				If grdReqDetD.Columns(e.ColumnIndex).Name = "m" Then
					dt.Rows(e.RowIndex + i)("y") = FormatNumber(dt.Rows(e.RowIndex + i)("m") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
					If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("k") = FormatNumber(dt.Rows(e.RowIndex + i)("y") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
				End If
			End If
			Call SumGrid()
		End If
	End Sub

	Private Sub grdReqDetD_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdReqDetD.DataError
		MessageBox.Show("Data error, please check your value !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
		e.Cancel = True
	End Sub

	Private Sub grdReqDetD_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdReqDetD.UserDeletedRow
		Call SumGrid()
	End Sub

	Public Function CheckDocType() As Boolean
		If clsConfig.IsNull(cboDocType.SelectedValue, "") = "W" Or _
		clsConfig.IsNull(cboDocType.SelectedValue, "") = "E" Or _
		clsConfig.IsNull(cboDocType.SelectedValue, "") = "T" Or _
		clsConfig.IsNull(cboDocType.SelectedValue, "") = "N" Or _
		clsConfig.IsNull(cboDocType.SelectedValue, "") = "H" Then
			Return True
		Else
			Return False
		End If
	End Function

	Private Sub grdDesign_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDesign.CellClick
		If grdDesign.DataSource Is Nothing Then Exit Sub
		If grdDesign.Rows.Count = 0 Then Exit Sub
		If e.RowIndex < 0 Then Exit Sub
		Dim config As New clsConfig
		Dim objDB As New classRequest
		grdFreeStockD.AutoGenerateColumns = False
		grdFreeStockD.DataSource = objDB.GetSORollNoGrid2(strReqNo, _
		  config.IsNull(grdDesign.Rows(e.RowIndex).Cells("ds_sonoid").Value, "").ToString.Trim, _
		  config.IsNull(grdDesign.Rows(e.RowIndex).Cells("ds_design_no").Value, "").ToString.Trim, _
		  config.IsNull(grdDesign.Rows(e.RowIndex).Cells("ds_gwth").Value, "").ToString.Trim, _
		  IIf(CheckDocType(), "", config.IsNull(grdDesign.Rows(e.RowIndex).Cells("ds_col").Value, "").ToString.Trim), _
		  config.IsNull(grdDesign.Rows(e.RowIndex).Cells("ds_gr").Value, "").ToString.Trim)
		Call SumGridStock()
	End Sub

	Private Sub btnShowLockedStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowLockedStock.Click
		Dim frm As New frmRequestCOnhand
		frm.UserInfo = clsUser
		frm.MdiParent = Me.MdiParent
		frm.Show()
	End Sub

	Private Sub grdFreeStockD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdFreeStockD.KeyDown
		Dim i As Integer = 0
		If e.KeyCode = Keys.Enter Then
			If grdFreeStockD.Columns(grdFreeStockD.SelectedCells(i).ColumnIndex).Name = "stk_sel" Then
				For i = 0 To grdFreeStockD.SelectedCells.Count - 1
					grdFreeStockD.SelectedCells(i).Value = Not CBool(grdFreeStockD.SelectedCells(i).Value)
				Next
			End If
		End If
	End Sub

	Private Sub grdReqDetD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdReqDetD.KeyDown
		Dim i As Integer = 0
		If e.KeyCode = Keys.Enter Then
			If grdReqDetD.Columns(grdReqDetD.SelectedCells(i).ColumnIndex).Name = "sel" Then
				For i = 0 To grdReqDetD.SelectedCells.Count - 1
					grdReqDetD.SelectedCells(i).Value = Not CBool(grdReqDetD.SelectedCells(i).Value)
				Next
			End If
		End If
	End Sub

    Private Sub cboReqNo_Click(sender As System.Object, e As System.EventArgs) Handles cboReqNo.Click

    End Sub
End Class