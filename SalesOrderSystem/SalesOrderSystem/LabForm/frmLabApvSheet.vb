Public Class frmLabApvSheet
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo
	Dim blnCancel As Boolean = False
	Dim dtSource As New DataTable

	Dim lngLabDetID As Long = 0
	Dim strLabNo As String = ""
	Dim strDesignNo As String = ""
	Dim strGwth As String = ""
	Dim strCol As String = ""
	Dim lngSheetID As Long = 0

	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Public Property LabDetID() As Long
		Get
			LabDetID = lngLabDetID
		End Get
		Set(ByVal NewValue As Long)
			lngLabDetID = NewValue
		End Set
	End Property

	Public Property pLabNo() As String
		Get
			pLabNo = strLabNo
		End Get
		Set(ByVal NewValue As String)
			strLabNo = NewValue
		End Set
	End Property

	Public Property pDesignNo() As String
		Get
			pDesignNo = strDesignNo
		End Get
		Set(ByVal NewValue As String)
			strDesignNo = NewValue
		End Set
	End Property

	Public Property pGwth() As String
		Get
			pGwth = strGwth
		End Get
		Set(ByVal NewValue As String)
			strGwth = NewValue
		End Set
	End Property

	Public Property pCol() As String
		Get
			pCol = strCol
		End Get
		Set(ByVal NewValue As String)
			strCol = NewValue
		End Set
	End Property

	Public Property SheetID() As Long
		Get
			SheetID = lngSheetID
		End Get
		Set(ByVal NewValue As Long)
			lngSheetID = NewValue
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
		lngSheetID = 0
		txtLabNo.Text = strLabNo
		txtDesignNo.Text = strDesignNo
		txtGwth.Text = strGwth
		txtColor.Text = strCol
		cboSoNoID.Focus()
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
		txtLabNo.Enabled = False
		txtDesignNo.Enabled = False
		txtGwth.Enabled = False
		txtColor.Enabled = False
	End Sub

	Private Sub GenCombo()
		Dim objDB As New classMaster
		Me.cboCustomer.DataSource = objDB.GetCustomer
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"

		Me.cboSoNoID.DataSource = objDB.GetSoNoID
		Me.cboSoNoID.DisplayMember = "sono_design_col"
		Me.cboSoNoID.ValueMember = "sonoid"

		Me.cboLotUOM.DataSource = objDB.GetUOM
		Me.cboLotUOM.DisplayMember = "uom"
		Me.cboLotUOM.ValueMember = "uom"

		Me.cboBatchUOM.DataSource = objDB.GetUOM
		Me.cboBatchUOM.DisplayMember = "uom"
		Me.cboBatchUOM.ValueMember = "uom"
	End Sub

	Private Sub GenComboSheetID()
		Dim objDB As New classLab
		cboSheetID.ComboBox.DataSource = objDB.LabApvSheetLoad(lngLabDetID, 0)
		cboSheetID.ComboBox.DisplayMember = "sheet_id"
		cboSheetID.ComboBox.ValueMember = "sheet_id"
	End Sub

	Private Sub BindData(ByVal dt As DataTable)
		lngSheetID = dt.Rows(0)("sheet_id")
		dtpSheetDate.Value = CDate(dt.Rows(0)("sheet_date2"))
		txtLabNo.Text = dt.Rows(0)("labno").ToString.Trim
		'txtDesignNo.Text = dt.Rows(0)("design_no").ToString.Trim
		'txtGwth.Text = dt.Rows(0)("gwth").ToString.Trim
		'txtColor.Text = dt.Rows(0)("col").ToString.Trim
		txtDesignNo.Text = strDesignNo
		txtGwth.Text = strGwth
		txtColor.Text = strCol
		cboSoNoID.SelectedValue = dt.Rows(0)("sonoid").ToString.Trim
		cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString.Trim
		txtAttention.Text = dt.Rows(0)("attn").ToString.Trim
		chkLabDip.Checked = CBool(dt.Rows(0)("result_labdip"))
		chkShipping.Checked = CBool(dt.Rows(0)("result_shiping"))
		chkFinishing.Checked = CBool(dt.Rows(0)("result_finishing"))
		txtLotNo.Text = dt.Rows(0)("lotno").ToString.Trim
		txtLotQty.Text = dt.Rows(0)("lot_qty").ToString.Trim
		cboLotUOM.SelectedValue = dt.Rows(0)("lot_uom").ToString.Trim
		txtBatch.Text = dt.Rows(0)("batch").ToString.Trim
		txtBatchQty.Text = dt.Rows(0)("batch_qty").ToString.Trim
		cboBatchUOM.SelectedValue = dt.Rows(0)("batch_uom").ToString.Trim
		txtRemark.Text = dt.Rows(0)("remark").ToString.Trim
		txtShade1.Text = dt.Rows(0)("shade1").ToString.Trim
		txtShade2.Text = dt.Rows(0)("shade2").ToString.Trim
	End Sub

	Private Sub LoadData()
		Dim objDB As New classLab
		Dim dt As New DataTable
		dt = objDB.LabApvSheetLoad(lngLabDetID, lngSheetID)
		If dt.Rows.Count > 0 Then Call BindData(dt)
	End Sub

	Private Function SaveData() As Boolean
		Dim clsLab As New classLab
		Dim msgerr As String = ""

		If clsLab.LabApvSheetSave(lngSheetID, _
		  dtpSheetDate.Value.ToString("yyyyMMdd"), _
		  txtLabNo.Text, _
		  lngLabDetID, _
		  strDesignNo, _
		  strCol, _
		  clsConfig.IsNull(cboSoNoID.SelectedValue, ""), _
		  clsConfig.IsNull(cboCustomer.SelectedValue, ""), _
		  txtAttention.Text.Trim, _
		  txtLotNo.Text.Trim, _
		  Val(txtLotQty.Text), _
		  clsConfig.IsNull(cboLotUOM.SelectedValue, ""), _
		  txtBatch.Text.Trim, _
		  Val(txtBatchQty.Text), _
		  clsConfig.IsNull(cboBatchUOM.SelectedValue, ""), _
		  chkLabDip.Checked, _
		  chkShipping.Checked, _
		  chkFinishing.Checked, _
		  txtRemark.Text.Trim, _
		  txtShade1.Text.Trim, _
		  txtShade2.Text.Trim, _
		  False, _
		  clsUser.UserID, _
		  msgerr) Then
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub frmLabApvSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call GenComboSheetID()
		Call InitControl()
		Call LoadData()
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		Call InitControl()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If SaveData() Then
			Call GenComboSheetID()
		End If
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		If lngSheetID = 0 Then Exit Sub
		Const rptFileName = "rptLabApvSheet.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

		rpt.VerifyDatabase()
		rpt.SetParameterValue("@sheet_id", lngSheetID)

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Lab Approval Sheet"
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

	Private Sub cboSheetID_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSheetID.DropDownClosed
		lngSheetID = clsConfig.IsNull(cboSheetID.ComboBox.SelectedValue, 0)
		Call LoadData()
	End Sub
End Class