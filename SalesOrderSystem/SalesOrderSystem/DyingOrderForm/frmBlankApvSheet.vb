Public Class frmBlankApvSheet
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

	Private Sub frmLabApvSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call InitControl()
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		Call InitControl()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Const rptFileName = "rptBlankApvSheet.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

		rpt.VerifyDatabase()
		rpt.SetParameterValue("@sheet_date", dtpSheetDate.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
		rpt.SetParameterValue("@col", txtColor.Text.Trim)
		rpt.SetParameterValue("@custcd", cboCustomer.SelectedValue)
		rpt.SetParameterValue("@sonoid", cboSoNoID.SelectedValue)
		rpt.SetParameterValue("@attn", txtAttention.Text.Trim)
		rpt.SetParameterValue("@lotno", txtLotNo.Text.Trim)
		rpt.SetParameterValue("@lot_qty", Val(txtLotQty.Text))
		rpt.SetParameterValue("@lot_uom", cboLotUOM.SelectedValue)
		rpt.SetParameterValue("@batch", txtBatch.Text.Trim)
		rpt.SetParameterValue("@batch_qty", Val(txtBatchQty.Text))
		rpt.SetParameterValue("@batch_uom", cboBatchUOM.SelectedValue)
		rpt.SetParameterValue("@result_labdip", chkLabDip.Checked)
		rpt.SetParameterValue("@result_shiping", chkShipping.Checked)
		rpt.SetParameterValue("@result_finishing", chkFinishing.Checked)
		rpt.SetParameterValue("@remark", txtRemark.Text.Trim)
		rpt.SetParameterValue("@shade1", txtShade1.Text.Trim)
		rpt.SetParameterValue("@shade2", txtShade2.Text.Trim)
		rpt.SetParameterValue("@owner_id", clsUser.UserID)

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Blank Approval Sheet"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class