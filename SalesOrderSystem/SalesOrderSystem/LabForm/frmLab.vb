Imports System.Drawing
Imports System.Data.SqlClient

Public Class frmLab
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo

	Dim strLabNo As String = ""
	Dim blnCancel As Boolean = False

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Private Sub SetControlValue(ByVal Obj As Control)
		If TypeOf Obj Is TextBox Then Obj.Text = Obj.Tag
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
		strLabNo = ""
		dtpDeliveryDate.Value = CDate("01/01/1900")
		cboIssueBy.SelectedValue = clsUser.UserID
		lblCancelled.Visible = False
		ClearGrid()
		Call LoadData("")
		txtLabNo.Focus()
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
		cboIssueBy.Enabled = False
		dtpIssueDate.Enabled = False
	End Sub

	Private Sub GenCombo()
		Dim objDB As New classMaster
		Me.cboDesignNo.DataSource = objDB.GetDesign
		Me.cboDesignNo.DisplayMember = "design_no"
		Me.cboDesignNo.ValueMember = "design_no"
		Me.cboDesignNo.SelectedIndex = 0

		Me.cboDyedHouse.DataSource = objDB.GetDyedHouse
		Me.cboDyedHouse.DisplayMember = "name"
		Me.cboDyedHouse.ValueMember = "suppcd2"
		Me.cboDyedHouse.SelectedIndex = 0

		Me.cboDyingMethod.DataSource = objDB.GetDyingMethod
		Me.cboDyingMethod.DisplayMember = "dmethod"
		Me.cboDyingMethod.ValueMember = "dmethodcd"
		Me.cboDyingMethod.SelectedIndex = 0

		Me.cboPrimaryLightSource.DataSource = objDB.GetLightSource
		Me.cboPrimaryLightSource.DisplayMember = "description"
		Me.cboPrimaryLightSource.ValueMember = "lights"
		Me.cboPrimaryLightSource.SelectedIndex = 0

		Me.cboSecondaryLightSource.DataSource = objDB.GetLightSource
		Me.cboSecondaryLightSource.DisplayMember = "description"
		Me.cboSecondaryLightSource.ValueMember = "lights"
		Me.cboSecondaryLightSource.SelectedIndex = 0

		Me.cboIssueBy.DataSource = objDB.GetEmp
		Me.cboIssueBy.DisplayMember = "empname"
		Me.cboIssueBy.ValueMember = "empcd2"
		Me.cboIssueBy.SelectedValue = clsUser.UserName
	End Sub

	Private Sub GenComboLabNo()
		Dim objDB As New classLab
		cboLabNo.ComboBox.DataSource = objDB.GetLabNo
		cboLabNo.ComboBox.DisplayMember = "labno"
		cboLabNo.ComboBox.ValueMember = "labno"
		If strLabNo.Trim.Length > 0 Then cboLabNo.ComboBox.SelectedValue = strLabNo.Trim
	End Sub

	Private Sub GenComboGwth(Optional ByVal design_no As String = "")
		On Error Resume Next
		Dim objDB As New classMaster
		cboGwth.DataSource = objDB.GetGwth(design_no)
		cboGwth.DisplayMember = "gwth"
		cboGwth.ValueMember = "gwth"
	End Sub

	Private Sub BindData(ByVal dt As DataTable)
		strLabNo = dt.Rows(0)("labno").ToString.Trim
		txtLabNo.Text = dt.Rows(0)("labno").ToString.Trim
		dtpLabDate.Value = CDate(dt.Rows(0)("labdt2").ToString)
		dtpDeliveryDate.Value = CDate(dt.Rows(0)("delidt2").ToString)
		cboIssueBy.SelectedValue = dt.Rows(0)("empcd").ToString.Trim
		dtpIssueDate.Value = CDate(dt.Rows(0)("issuedt2").ToString)

		cboDesignNo.SelectedValue = dt.Rows(0)("design_no").ToString.Trim
		Call GenComboGwth(dt.Rows(0)("design_no").ToString.Trim)
		cboGwth.SelectedValue = dt.Rows(0)("gwth").ToString.Trim
		txtTolerance.Text = dt.Rows(0)("diff").ToString.Trim
		txtStandardLayer.Text = dt.Rows(0)("std_lay").ToString.Trim
		txtSampleLayer.Text = dt.Rows(0)("sam_lay").ToString.Trim

		cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod").ToString.Trim
		txtAttention.Text = dt.Rows(0)("attn").ToString.Trim
		cboDyingMethod.SelectedValue = dt.Rows(0)("dmethodcd").ToString.Trim
		txtDyingMethod.Text = dt.Rows(0)("method").ToString.Trim

		cboPrimaryLightSource.SelectedValue = dt.Rows(0)("plights").ToString.Trim
		cboSecondaryLightSource.SelectedValue = dt.Rows(0)("slights").ToString.Trim

		optSample.Checked = CBool(dt.Rows(0)("sample"))
		optApprove.Checked = CBool(dt.Rows(0)("appr"))

		chkNoAZO.Checked = CBool(dt.Rows(0)("azo"))
		chkPhenolicYellowing.Checked = CBool(dt.Rows(0)("ph"))

		txtRemark.Text = dt.Rows(0)("remark").ToString.Trim

		If CBool(dt.Rows(0)("cancel_status")) Then
			lblCancelled.Visible = True
			Call EnabledControl(False)
		End If
	End Sub

	Private Sub BindGrid(ByVal dt As DataTable)
		grdLab.AutoGenerateColumns = False
		grdLab.DataSource = dt
	End Sub

	Private Function IsDataChange() As Boolean
		Dim result As Boolean = False
		Dim dt As New DataTable
		dt = grdLab.DataSource
		Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
		If dt Is Nothing Or dv.Count = 0 Or grdLab.Rows.Count = 0 Then
			If grdLab.Rows.Count > 1 Then result = True

			If dtpLabDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
			If dtpDeliveryDate.Value.ToString("yyyyMMdd") <> "19000101" Then result = True
			If clsConfig.IsNull(cboIssueBy.SelectedValue, "").ToString.Trim <> clsUser.UserID Then result = True
			If dtpIssueDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
			If clsConfig.IsNull(cboDesignNo.SelectedValue, "") <> "" Then result = True
			If clsConfig.IsNull(cboGwth.SelectedValue, "") <> "" Then result = True
			If Val(txtTolerance.Text) <> 0 Then result = True
			If txtStandardLayer.Text <> "" Then result = True
			If txtSampleLayer.Text <> "" Then result = True
			If clsConfig.IsNull(cboDyedHouse.SelectedValue, "") <> "" Then result = True
			If txtAttention.Text <> "" Then result = True
			If clsConfig.IsNull(cboDyingMethod.SelectedValue, "") <> "" Then result = True
			If txtDyingMethod.Text <> "" Then result = True
			If clsConfig.IsNull(cboPrimaryLightSource.SelectedValue, "") <> "" Then result = True
			If clsConfig.IsNull(cboSecondaryLightSource.SelectedValue, "") <> "" Then result = True
			If optSample.Checked = True Then result = True
			If optApprove.Checked = False Then result = True
			If chkNoAZO.Checked = True Then result = True
			If chkPhenolicYellowing.Checked = True Then result = True
			If txtRemark.Text <> "" Then result = True
		Else
			Dim i As Integer = CheckDelRow(dt)
			If Not lblCancelled.Visible Then
				If dtpLabDate.Value <> CDate(dt.Rows(i)("labdt2").ToString) Then result = True
				If dtpDeliveryDate.Value <> CDate(dt.Rows(i)("delidt2").ToString) Then result = True
				If cboIssueBy.SelectedValue <> dt.Rows(i)("empcd").ToString.Trim Then result = True
				If dtpIssueDate.Value <> CDate(dt.Rows(i)("issuedt2").ToString) Then result = True
				If cboDesignNo.SelectedValue <> dt.Rows(i)("design_no").ToString.Trim Then result = True
				If cboGwth.SelectedValue.trim <> dt.Rows(i)("gwth").ToString.Trim Then result = True
				If txtTolerance.Text <> dt.Rows(i)("diff").ToString.Trim Then result = True
				If txtStandardLayer.Text <> dt.Rows(i)("std_lay").ToString.Trim Then result = True
				If txtSampleLayer.Text <> dt.Rows(i)("sam_lay").ToString.Trim Then result = True
				If cboDyedHouse.SelectedValue <> dt.Rows(i)("dhcod").ToString.Trim Then result = True
				If txtAttention.Text <> dt.Rows(i)("attn").ToString.Trim Then result = True
				If cboDyingMethod.SelectedValue <> dt.Rows(i)("dmethodcd").ToString.Trim Then result = True
				If txtDyingMethod.Text <> dt.Rows(i)("method").ToString.Trim Then result = True
				If cboPrimaryLightSource.SelectedValue <> dt.Rows(i)("plights").ToString.Trim Then result = True
				If cboSecondaryLightSource.SelectedValue <> dt.Rows(i)("slights").ToString.Trim Then result = True
				If optSample.Checked <> CBool(dt.Rows(i)("sample")) Then result = True
				If optApprove.Checked <> CBool(dt.Rows(i)("appr")) Then result = True
				If chkNoAZO.Checked <> CBool(dt.Rows(i)("azo")) Then result = True
				If chkPhenolicYellowing.Checked <> CBool(dt.Rows(i)("ph")) Then result = True
				If txtRemark.Text <> dt.Rows(i)("remark").ToString.Trim Then result = True

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
		If clsConfig.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose Document Type !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If clsConfig.IsNull(cboGwth.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose Unit of Mesurement !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If clsConfig.IsNull(cboDyingMethod.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose S/O No. !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If clsConfig.IsNull(cboPrimaryLightSource.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose customer!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If grdLab.Rows.Count <= 0 Then
			MessageBox.Show("Please insert data in table at least 1 record!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		CheckData = True
	End Function

	Private Sub LoadData(ByVal LabNo As String)
		Dim objDB As New classLab
		Dim dt As New DataTable
		dt = objDB.LabDetLoad(LabNo)
		Call BindGrid(dt)
		If dt.Rows.Count > 0 Then Call BindData(dt)
	End Sub

	Private Function SaveData() As Boolean
		Dim clsLab As New classLab
		Dim header As New classLab.LabHeader
		Dim msgerr As String = ""
		Dim labno As String = ""
		Dim dt As DataTable = grdLab.DataSource
		Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
		Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
		Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)

		header.h01_labno = strLabNo
		header.h02_design_no = clsConfig.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim
		header.h03_plights = clsConfig.IsNull(cboPrimaryLightSource.SelectedValue, "").ToString.Trim
		header.h04_slights = clsConfig.IsNull(cboSecondaryLightSource.SelectedValue, "").ToString.Trim
		header.h05_remark = txtRemark.Text.Trim
		header.h06_specu = False
		header.h07_speck = False
		header.h08_method = txtDyingMethod.Text.Trim
		header.h09_labdt = dtpLabDate.Value
		header.h10_delidt = dtpDeliveryDate.Value
		header.h11_attn = txtAttention.Text.Trim
		header.h12_dhcod = clsConfig.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim
		header.h13_sample = optSample.Checked
		header.h14_appr = optApprove.Checked
		header.h15_azo = chkNoAZO.Checked
		header.h16_ph = chkPhenolicYellowing.Checked
		header.h17_gwth = clsConfig.IsNull(cboGwth.SelectedValue, "").ToString.Trim
		header.h18_dmethodcd = clsConfig.IsNull(cboDyingMethod.SelectedValue, "").ToString.Trim
		header.h19_diff = Val(txtTolerance.Text.Trim)
		header.h20_empcd = clsConfig.IsNull(cboIssueBy.SelectedValue, "").ToString.Trim
		header.h21_issuedt = dtpIssueDate.Value
		header.h22_std_lay = txtStandardLayer.Text.Trim
		header.h23_sam_lay = txtSampleLayer.Text.Trim
		header.h24_arrivedt = CDate("01/01/1900")
		header.h25_cancel_status = False

		If clsLab.LabSave(header, dv_add, dv_upd, dv_del, msgerr, labno) Then
			strLabNo = labno
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub ClearGrid()
		Dim objDB As New classLab
		grdLab.AutoGenerateColumns = False
		grdLab.DataSource = objDB.LabDetLoad("")
	End Sub

	Private Sub frmRequestD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call GenComboLabNo()
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
		Dim frm As New frmLabSearch
		frm.ShowDialog(Me)
		Call btnNew_Click(sender, e)
		Me.Cursor = Cursors.WaitCursor
		If Not blnCancel Then LoadData(frm.pLabNo)
		Me.Cursor = Cursors.Default
		frm.Dispose()
	End Sub

	Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
		strLabNo = ""
		txtLabNo.Text = ""
		dtpLabDate.Value = Now
		cboIssueBy.SelectedValue = clsUser.UserID
		dtpIssueDate.Value = Now
		Call ClearGrid()
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
			LoadData(strLabNo)
			Call GenComboLabNo()
		End If
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		If strLabNo = "" Then strLabNo = txtLabNo.Text.Trim.ToUpper
		If strLabNo.Length = 0 Then Exit Sub
		Const rptFileName = "rptLab.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

		rpt.VerifyDatabase()
		rpt.SetParameterValue("@labno", strLabNo)
		rpt.SetParameterValue("@datefr", "")
		rpt.SetParameterValue("@dateto", "")
		rpt.SetParameterValue("@dhcod", "")

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Lab Test"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		If strLabNo.Trim.Length = 0 Then Exit Sub Else Call btnSave_Click(sender, e)
		If blnCancel Then Exit Sub
		If lblCancelled.Visible Then
			MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			Exit Sub
		End If
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Dim objDB As New classLab
		Call objDB.LabCancel(strLabNo, clsUser.UserID)
		Call btnNew_Click(sender, e)
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub cboLabNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLabNo.DropDownClosed
		Dim LabNo As String
		LabNo = clsConfig.IsNull(cboLabNo.ComboBox.SelectedValue, "")
		If LabNo.Trim.Length > 0 Then
			Call btnNew_Click(sender, e)
			If Not blnCancel Then LoadData(LabNo)
		End If
	End Sub

	Private Sub txtLabNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLabNo.KeyPress
		Dim LabNo As String = ""
		If Asc(e.KeyChar) = 13 Then
			LabNo = txtLabNo.Text.Trim.ToUpper
			Call btnNew_Click(sender, e)
			If Not blnCancel Then LoadData(LabNo)
		End If
	End Sub

	Private Function CheckDelRow(ByVal dt As DataTable) As Integer
		Dim i As Integer = 0
		Dim j As Integer = 0
		For i = 0 To dt.Rows.Count - 1
			If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
		Next
		Return j
	End Function

	Private Sub grdReqDetD_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdLab.DataError
		MessageBox.Show("Data error, please check your value !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
		e.Cancel = True
	End Sub

	Private Sub grdLab_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdLab.CellContentClick
		If grdLab.Columns(e.ColumnIndex).Name = "btnClose" And _
		grdLab.CurrentRow.Cells("col").Value.ToString.Trim.Length > 0 And _
		clsConfig.IsNull(grdLab.CurrentRow.Cells("id_labdet").Value, 0) > 0 Then
			Dim frm As New frmLabClose
			frm.LabDetID = clsConfig.IsNull(grdLab.CurrentRow.Cells("id_labdet").Value, 0)
			frm.ShowDialog(Me)
		End If
		If grdLab.Columns(e.ColumnIndex).Name = "btnApvSheet" And _
		grdLab.CurrentRow.Cells("col").Value.ToString.Trim.Length > 0 And _
		clsConfig.IsNull(grdLab.CurrentRow.Cells("id_labdet").Value, 0) > 0 Then
			Dim frm As New frmLabApvSheet
			frm.UserInfo = Me.UserInfo
			frm.LabDetID = clsConfig.IsNull(grdLab.CurrentRow.Cells("id_labdet").Value, 0)
			frm.pLabNo = strLabNo
			frm.pDesignNo = clsConfig.IsNull(cboDesignNo.SelectedValue, "")
			frm.pGwth = clsConfig.IsNull(cboGwth.SelectedValue, "")
			frm.pCol = clsConfig.IsNull(grdLab.CurrentRow.Cells("col").Value, "")
			frm.ShowDialog(Me)
		End If
	End Sub

	Private Sub cboDesignNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDesignNo.SelectedIndexChanged
		Call GenComboGwth(clsConfig.IsNull(cboDesignNo.SelectedValue, ""))
	End Sub
End Class