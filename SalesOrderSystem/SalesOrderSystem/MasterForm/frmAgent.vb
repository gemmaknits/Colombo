Public Class frmAgent
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo

	Dim strAgCD As String = ""
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
		If TypeOf Obj Is TextBox Then
			Obj.Text = Obj.Tag
		End If
		If TypeOf Obj Is DateTimePicker Then
			Dim dtp As DateTimePicker = Obj
			dtp.Value = Now
		End If
		If TypeOf Obj Is ComboBox Then
			Dim cbo As ComboBox = Obj
			cbo.SelectedIndex = -1
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
		strAgCD = ""
		'Call LoadData("")
		txtAgCD.Focus()
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

		Me.cboCurrency.DataSource = objDB.GetCurrency()
		Me.cboCurrency.DisplayMember = "curr"
		Me.cboCurrency.ValueMember = "curr"

		Me.cboCountry.DataSource = objDB.GetCountry()
		Me.cboCountry.DisplayMember = "name2"
		Me.cboCountry.ValueMember = "ctry2"
	End Sub

	Private Sub GenComboAgCD()
		Dim objDB As New classMaster
		Me.cboAgCD.ComboBox.DataSource = objDB.GetAgent()
		Me.cboAgCD.ComboBox.DisplayMember = "name"
		Me.cboAgCD.ComboBox.ValueMember = "agcd"
		Me.cboAgCD.ComboBox.SelectedIndex = 0
	End Sub

	Private Sub BindData(ByVal dt As DataTable)
		strAgCD = dt.Rows(0)("agcd").ToString.Trim
		txtAgCD.Text = dt.Rows(0)("agcd").ToString.Trim
		txtNickName.Text = dt.Rows(0)("nickname").ToString.Trim
		txtENName.Text = dt.Rows(0)("name").ToString.Trim
		txtENAddr1.Text = dt.Rows(0)("addr1").ToString.Trim
		txtENAddr2.Text = dt.Rows(0)("addr2").ToString.Trim
		txtENAddr3.Text = dt.Rows(0)("addr3").ToString.Trim
		txtTHName.Text = dt.Rows(0)("namet").ToString.Trim
		txtTHAddr1.Text = dt.Rows(0)("addr1t").ToString.Trim
		txtTHAddr2.Text = dt.Rows(0)("addr2t").ToString.Trim
		txtTHAddr3.Text = dt.Rows(0)("addr3t").ToString.Trim
		cboCountry.SelectedValue = dt.Rows(0)("ctry").ToString.Trim
		txtEMail.Text = dt.Rows(0)("email").ToString.Trim
		txtTel.Text = dt.Rows(0)("tel").ToString.Trim
		txtFax.Text = dt.Rows(0)("fax").ToString.Trim
		txtCommission.Text = dt.Rows(0)("comm").ToString.Trim
		txtCommissionPercent.Text = dt.Rows(0)("commper").ToString.Trim
		txtTax.Text = dt.Rows(0)("tax").ToString.Trim
		txtBankDetail.Text = dt.Rows(0)("bank").ToString.Trim
		cboCurrency.SelectedValue = dt.Rows(0)("currency").ToString.Trim
		txtContact.Text = dt.Rows(0)("contact").ToString.Trim
	End Sub

	Private Function IsDataChange() As Boolean
		Dim clsMaster As New classMaster
		Dim dt As DataTable = clsMaster.GetAgent(strAgCD)
		Dim result As Boolean = False

		If txtNickName.Text <> dt.Rows(0)("nickname").ToString.Trim Then result = True
		If txtENAddr1.Text <> dt.Rows(0)("addr1").ToString.Trim Then result = True
		If txtENAddr2.Text <> dt.Rows(0)("addr2").ToString.Trim Then result = True
		If txtENAddr3.Text <> dt.Rows(0)("addr3").ToString.Trim Then result = True
		If txtTHName.Text <> dt.Rows(0)("namet").ToString.Trim Then result = True
		If txtTHAddr1.Text <> dt.Rows(0)("addr1t").ToString.Trim Then result = True
		If txtTHAddr2.Text <> dt.Rows(0)("addr2t").ToString.Trim Then result = True
		If txtTHAddr3.Text <> dt.Rows(0)("addr3t").ToString.Trim Then result = True
		If clsConfig.IsNull(cboCountry.SelectedValue, "").ToString.Trim <> dt.Rows(0)("ctry").ToString.Trim Then result = True
		If txtEMail.Text <> dt.Rows(0)("email").ToString.Trim Then result = True
		If txtTel.Text <> dt.Rows(0)("tel").ToString.Trim Then result = True
		If txtFax.Text <> dt.Rows(0)("fax").ToString.Trim Then result = True
		If txtCommission.Text <> dt.Rows(0)("comm").ToString.Trim Then result = True
		If txtCommissionPercent.Text <> dt.Rows(0)("commper").ToString.Trim Then result = True
		If txtTax.Text <> dt.Rows(0)("tax").ToString.Trim Then result = True
		If txtBankDetail.Text <> dt.Rows(0)("bank").ToString.Trim Then result = True
		If clsConfig.IsNull(cboCurrency.SelectedValue, "").ToString.Trim <> dt.Rows(0)("currency").ToString.Trim Then result = True
		If txtContact.Text <> dt.Rows(0)("contact").ToString.Trim Then result = True

		IsDataChange = result
	End Function

	Private Function CheckData() As Boolean
		Dim config As New clsConfig
		If txtENName.Text.Trim.Length = 0 Then
			MessageBox.Show("Please fill the agency name (Eng) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If txtTHName.Text.Trim.Length = 0 Then
			MessageBox.Show("Please fill the agency name (Thai) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If config.IsNull(cboCountry.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose country !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		If config.IsNull(cboCurrency.SelectedValue, "").ToString.Trim = "" Then
			MessageBox.Show("Please choose currency !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
			CheckData = False
			Exit Function
		End If
		CheckData = True
	End Function

	Private Sub LoadData(ByVal agcd As String)
		Dim objDB As New classMaster
		Dim dt As New DataTable
		dt = objDB.GetAgent(agcd)
		If dt.Rows.Count > 0 Then Call BindData(dt)
	End Sub

	Private Function SaveData() As Boolean
		Dim clsMaster As New classMasterUpdate
		Dim header As New classMasterUpdate.Agency
		Dim msgerr As String = ""
		Dim agcd As String = ""
        header.h01_Agcd = txtAgCD.Text.Trim 'strAgCD 'Neung 20260122
        header.h02_Nickname = txtNickName.Text.Trim
		header.h03_Name = txtENName.Text.Trim
		header.h04_Addr1 = txtENAddr1.Text.Trim
		header.h05_Addr2 = txtENAddr2.Text.Trim
		header.h06_Addr3 = txtENAddr3.Text.Trim
		header.h07_Namet = txtTHName.Text.Trim
		header.h08_Addr1T = txtTHAddr1.Text.Trim
		header.h09_Addr2T = txtTHAddr2.Text.Trim
		header.h10_Addr3T = txtTHAddr3.Text.Trim
		header.h11_ctry = clsConfig.IsNull(cboCountry.SelectedValue, "").ToString.Trim
		header.h12_tel = txtTel.Text.Trim
		header.h13_fax = txtFax.Text.Trim
		header.h14_email = txtEMail.Text.Trim
		header.h15_bank = txtBankDetail.Text.Trim
		header.h16_currency = clsConfig.IsNull(cboCurrency.SelectedValue, "").ToString.Trim
		header.h17_comm = Val(txtCommission.Text.Trim)
		header.h18_tax = Val(txtTax.Text.Trim)
		header.h19_commper = Val(txtCommissionPercent.Text.Trim)
		header.h20_contact = txtContact.Text.Trim

		If clsMaster.AgencySave(header, msgerr, agcd) Then
			strAgCD = agcd
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub frmAgent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call GenComboagcd()
		Call InitControl()
	End Sub

	Private Sub frmAgent_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
		If IsDataChange() Then Call btnSave_Click(sender, e)
		e.Cancel = blnCancel
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		If IsDataChange() Then Call btnSave_Click(sender, e)
		If Not blnCancel Then Call InitControl()
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
			LoadData(strAgCD)
			Call GenComboagcd()
		End If
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Const rptFileName = "rptMasterAgent.rpt"
		If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
		If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()

		frm.Title = "Agency Master"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub cboAgCD_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAgCD.DropDownClosed
		Dim agcd As String
		agcd = clsConfig.IsNull(cboAgCD.ComboBox.SelectedValue, "")
		If agcd.Trim.Length > 0 Then
			Call btnNew_Click(sender, e)
			If Not blnCancel Then LoadData(agcd)
		End If
	End Sub

	Private Sub txtagcd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAgCD.KeyPress
		Dim agcd As String = ""
		If Asc(e.KeyChar) = 13 Then
			agcd = txtAgCD.Text.Trim.ToUpper
			Call btnNew_Click(sender, e)
			If Not blnCancel Then LoadData(agcd)
		End If
	End Sub
End Class