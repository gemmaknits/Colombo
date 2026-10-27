Public Class frmStockSIN
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo
	Dim strSINNo As String = ""
	Dim blnLocked As Boolean = False

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Public Property pSINNo() As String
		Get
			pSINNo = strSINNo
		End Get
		Set(ByVal NewValue As String)
			strSINNo = NewValue
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
		Call BindGrid((New classStock).GetSINDet(""))
		strSINNo = ""
		blnLocked = False
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
		'txtSINNo.Enabled = False
	End Sub

	Private Sub GenCombo()
		Dim objDB As New classMaster

		Me.cboDesignNo.DataSource = objDB.GetDesign
		Me.cboDesignNo.DisplayMember = "design_no"
		Me.cboDesignNo.ValueMember = "design_no"

		Me.col.DataSource = objDB.GetColor()
		Me.col.DisplayMember = "col"
		Me.col.ValueMember = "col"

		Me.sonoid.DataSource = objDB.GetSoNoID
		Me.sonoid.DisplayMember = "sono_design_col"
		Me.sonoid.ValueMember = "sonoid"

		Me.cboDocType.DataSource = objDB.GetDocType()
		Me.cboDocType.DisplayMember = "name"
		Me.cboDocType.ValueMember = "doctyp"
	End Sub

	Private Sub GenComboSINNo()
		Dim objDB As New classStock
		cboSINNO.ComboBox.DataSource = objDB.GetSINNo()
		cboSINNO.ComboBox.DisplayMember = "dinno"
		cboSINNO.ComboBox.ValueMember = "dinno"
	End Sub

	Private Sub GenComboGwth()
		Dim objDB As New classMaster
		cboGwth.DataSource = objDB.GetGwth(clsConfig.IsNull(cboDesignNo.SelectedValue, ""))
		cboGwth.DisplayMember = "gwth"
		cboGwth.ValueMember = "gwth"
	End Sub

	Private Sub BindData(ByVal dt As DataTable)
		strSINNo = dt.Rows(0)("dinno")
		txtSINNo.Text = dt.Rows(0)("dinno")
		dtpSINDate.Value = CDate(dt.Rows(0)("dindt2"))
		Select Case dt.Rows(0)("doctyp")
			Case "X" : optGre.Checked = True
			Case "Y" : optDye.Checked = True
			Case "Z" : optCut.Checked = True
		End Select
		cboDesignNo.SelectedValue = dt.Rows(0)("design_no")
		Call GenComboGwth()
		cboGwth.SelectedValue = dt.Rows(0)("gwth")
		txtRemark.Text = dt.Rows(0)("remark")

		If dt.Rows(0)("status") = "L" Then
			blnLocked = True
			Call EnabledControl(False)
		End If
	End Sub

	Private Sub BindGrid(ByVal dt As DataTable)
		grdStockS.AutoGenerateColumns = False
		grdStockS.DataSource = dt
	End Sub

	Private Sub LoadData(ByVal sinno As String)
		Dim objDB As New classStock
		Dim dt As New DataTable
		dt = objDB.GetSINDet(sinno)
		If dt.Rows.Count > 0 Then Call BindData(dt)
		Call BindGrid(dt)
	End Sub

	Private Function SaveData() As Boolean
		Dim clsStock As New classStock
		Dim header As New classStock.StockSHeader

		header.h01_dinno = strSINNo
		header.h02_dindt = dtpSINDate.Value.ToString("yyyyMMdd")
		If optGre.Checked Then header.h03_doctyp = "X"
		If optDye.Checked Then header.h03_doctyp = "Y"
		If optCut.Checked Then header.h03_doctyp = "Z"
		header.h04_design_no = cboDesignNo.SelectedValue
		header.h05_Gwth = cboGwth.SelectedValue
		header.h06_remark = txtRemark.Text.Trim
		header.h07_log_empcd = clsUser.UserID
		header.h08_outtyp = clsConfig.IsNull(cboDocType.SelectedValue, "W")

		Dim dt As DataTable = grdStockS.DataSource

		If strSINNo <> "" Then
			If dt.Rows(0)("dinno") <> header.h01_dinno Or _
			   CDate(dt.Rows(0)("dindt2")).ToString("yyyyMMdd") <> header.h02_dindt Or _
			   dt.Rows(0)("doctyp") <> header.h03_doctyp Or _
			   dt.Rows(0)("design_no") <> header.h04_design_no Or _
			   dt.Rows(0)("gwth") <> header.h05_Gwth Or _
			   dt.Rows(0)("remark") <> header.h06_remark Then
				Dim i As Integer = 0
				For i = 0 To dt.Rows.Count - 1
					dt.Rows(0)("dinno") = header.h01_dinno
					dt.Rows(0)("dindt") = dtpSINDate.Value
					dt.Rows(0)("doctyp") = header.h03_doctyp
					dt.Rows(0)("design_no") = header.h04_design_no
					dt.Rows(0)("gwth") = header.h05_Gwth
					dt.Rows(0)("remark") = header.h06_remark
				Next
			End If
		End If

		Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
		Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
		Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)
		Dim msgerr As String = ""
		Dim sinno As String = ""

		If clsStock.StockSSave(header, dv_add, dv_upd, dv_del, msgerr, sinno) Then
			SaveData = True
			Call LoadData(sinno)
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub CopyRow(ByVal intRow As Integer)
		Dim i As Integer = 0
		For i = 0 To grdStockS.Columns.Count - 1
			If grdStockS.Columns(i).Name <> "kg" And _
			grdStockS.Columns(i).Name <> "yds" And _
			grdStockS.Columns(i).Name <> "mts" Then
				grdStockS.Rows(intRow).Cells(i).Value = grdStockS.Rows(0).Cells(i).Value
			End If
		Next
	End Sub

	Private Sub frmStockSIN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call GenComboSINNo()
		Call InitControl()
		Call LoadData("")
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		Call InitControl()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		If blnLocked Then
			MessageBox.Show("This document is locked by system." & vbCrLf & "Please contact administrator to unlock and change document.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
			Exit Sub
		End If

        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If SaveData() Then
			Call GenComboSINNo()
		End If
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		If strSINNo = "" Then Exit Sub
		Const rptFileName = "rptStockSIN_OUT.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

		rpt.VerifyDatabase()
		rpt.SetParameterValue("@dinno", strSINNo)

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Stock Sample In & Out"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		'a
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub cboSheetID_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSINNO.DropDownClosed
		strSINNo = clsConfig.IsNull(cboSINNO.ComboBox.SelectedValue, 0)
		Call LoadData(strSINNo)
	End Sub

	Private Sub cboDesignNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDesignNo.SelectedIndexChanged
		Call GenComboGwth()
	End Sub

	Private Sub txtSINNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSINNo.KeyDown
		If e.KeyCode = Keys.Enter Then
			Call LoadData(txtSINNo.Text.Trim)
		End If
	End Sub

	Private Sub grdStockS_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdStockS.CellEndEdit
		If grdStockS.Columns(e.ColumnIndex).Name = "kg" Then
			'grdStockS.Rows(intRow).Cells(i).Value = grdStockS.Rows(intRow).Cells(i).Value
		ElseIf grdStockS.Columns(e.ColumnIndex).Name = "yds" Then
			grdStockS.Rows(e.RowIndex).Cells("mts").Value = Math.Round(Val(grdStockS.Rows(e.RowIndex).Cells("yds").Value) * 0.9144, 2)
		ElseIf grdStockS.Columns(e.ColumnIndex).Name = "mts" Then
			grdStockS.Rows(e.RowIndex).Cells("yds").Value = Math.Round(Val(grdStockS.Rows(e.RowIndex).Cells("mts").Value) / 0.9144, 2)
		End If
	End Sub

	Private Sub grdStockS_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdStockS.UserAddedRow
		If e.Row.Index > 1 Then
			If grdStockS.Columns(grdStockS.CurrentCell.ColumnIndex).Name = "kg" Then
				Call CopyRow(e.Row.Index - 1)
			ElseIf grdStockS.Columns(grdStockS.CurrentCell.ColumnIndex).Name = "yds" Then
				Call CopyRow(e.Row.Index - 1)
			ElseIf grdStockS.Columns(grdStockS.CurrentCell.ColumnIndex).Name = "mts" Then
				Call CopyRow(e.Row.Index - 1)
			End If
		End If
	End Sub
End Class