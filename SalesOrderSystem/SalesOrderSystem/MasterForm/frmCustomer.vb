Public Class frmCustomer
	Dim clsConfig As New clsConfig
	Dim clsConn As New ClassConnection


    Dim strCustCD As String = ""
	Dim blnCancel As Boolean = False
    Dim clsUser As New classUserInfo
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
		strCustCD = ""
		'Call LoadData("")
		txtCustCD.Focus()
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

		Me.cboAgent.DataSource = objDB.GetAgent()
		Me.cboAgent.DisplayMember = "name"
		Me.cboAgent.ValueMember = "agcd"

		Me.cboCountry.DataSource = objDB.GetCountry()
		Me.cboCountry.DisplayMember = "name2"
        Me.cboCountry.ValueMember = "ctry2"

        Me.cboBank.populateData((New classConnection).getSQLConnection)
        'Me.cboBank1.DataSource = objDB.Get


    End Sub

    Private Sub GenComboCustCD()
        Dim objDB As New classMaster
        Me.cboCustCD.ComboBox.DataSource = objDB.GetCustomer()
        Me.cboCustCD.ComboBox.DisplayMember = "name2"
        Me.cboCustCD.ComboBox.ValueMember = "custcd"
        Me.cboCustCD.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        strCustCD = dt.Rows(0)("custcd").ToString.Trim
        txtCustCD.Text = dt.Rows(0)("custcd").ToString.Trim
        txtENName.Text = dt.Rows(0)("name").ToString.Trim
        txtName2.Text = dt.Rows(0)("name2").ToString.Trim
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
        txtCredit.Text = dt.Rows(0)("credit").ToString.Trim
        txtContact.Text = dt.Rows(0)("contact").ToString.Trim
        txtPaymentTerms.Text = dt.Rows(0)("payterms").ToString.Trim
        cboAgent.SelectedValue = dt.Rows(0)("agcd").ToString.Trim
        chkActive.Checked = IIf(dt.Rows(0)("active").ToString.Trim = "1", True, False)
        txtvatno.Text = dt.Rows(0)("vatregno").ToString.Trim
        cboBank.SelectedValue = dt.Rows(0)("id_banks")
    End Sub

    Private Function IsDataChange() As Boolean
        Dim clsMaster As New classMaster
        Dim dt As DataTable = clsMaster.GetCustomer(strCustCD)
        Dim result As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0

        'If strCustCD = "" Then
        '	'If txtCustCD.Text <> "" Then result = True
        '	If txtENName.Text <> "" Then result = True
        '	If txtENAddr1.Text <> "" Then result = True
        '	If txtENAddr2.Text <> "" Then result = True
        '	If txtENAddr3.Text <> "" Then result = True
        '	If txtTHName.Text <> "" Then result = True
        '	If txtTHAddr1.Text <> "" Then result = True
        '	If txtTHAddr2.Text <> "" Then result = True
        '	If txtTHAddr3.Text <> "" Then result = True
        '	If clsConfig.IsNull(cboCountry.SelectedValue, "").ToString.Trim <> "" Then result = True
        '	If txtEMail.Text <> "" Then result = True
        '	If txtTel.Text <> "" Then result = True
        '	If txtFax.Text <> "" Then result = True
        '	If txtCredit.Text <> "" Then result = True
        '	If txtContact.Text <> "" Then result = True
        '	If txtPaymentTerms.Text <> "" Then result = True
        '	If clsConfig.IsNull(cboAgent.SelectedValue, "").ToString.Trim <> "" Then result = True
        '	If chkActive.Checked Then result = True
        'Else
        '	If txtENName.Text <> dt.Rows(0)("name").ToString.Trim Then result = True
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
        If txtCredit.Text <> dt.Rows(0)("credit").ToString.Trim Then result = True
        If txtContact.Text <> dt.Rows(0)("contact").ToString.Trim Then result = True
        If txtPaymentTerms.Text <> dt.Rows(0)("payterms").ToString.Trim Then result = True
        If clsConfig.IsNull(cboAgent.SelectedValue, "").ToString.Trim <> dt.Rows(0)("agcd").ToString.Trim Then result = True
        If chkActive.Checked <> IIf(dt.Rows(0)("active").ToString.Trim = "1", True, False) Then result = True
        'End If
        IsDataChange = result
    End Function

    Private Function CheckData() As Boolean
        Dim config As New clsConfig
        If txtENName.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the customer name (Eng) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If txtTHName.Text.Trim.Length = 0 Then
            MessageBox.Show("Please fill the customer name (Thai) !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(cboCountry.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose country !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        CheckData = True
    End Function

    Private Sub LoadData(ByVal CustCD As String)
        Dim objDB As New classMaster
        Dim dt As New DataTable
        dt = objDB.GetCustomer(CustCD)
        If dt.Rows.Count > 0 Then Call BindData(dt)
    End Sub

    Private Function SaveData() As Boolean
        Dim clsMaster As New classMasterUpdate
        Dim header As New classMasterUpdate.Customer
        Dim msgerr As String = ""
        Dim CustCD As String = ""
        header.h01_custcd = strCustCD
        header.h02_name = txtENName.Text.Trim
        header.h03_namet = txtTHName.Text.Trim
        header.h04_addr1 = txtENAddr1.Text.Trim
        header.h05_addr2 = txtENAddr2.Text.Trim
        header.h06_addr3 = txtENAddr3.Text.Trim
        header.h07_addr1t = txtTHAddr1.Text.Trim
        header.h08_addr2t = txtTHAddr2.Text.Trim
        header.h09_addr3t = txtTHAddr3.Text.Trim
        header.h10_city = ""
        header.h11_ctry = clsConfig.IsNull(cboCountry.SelectedValue, "").ToString.Trim
        header.h12_tel = txtTel.Text.Trim
        header.h13_fax = txtFax.Text.Trim
        header.h14_email = txtEMail.Text.Trim
        header.h15_contact = txtContact.Text.Trim
        header.h16_credit = Val(txtCredit.Text)
        header.h17_payterms = txtPaymentTerms.Text.Trim
        header.h18_agcd = clsConfig.IsNull(cboAgent.SelectedValue, "").ToString.Trim
        header.h19_Custgroup = "01"
        header.h20_active = IIf(chkActive.Checked, "1", "0")
        header.h21_crdays = 0
        header.h22_log_empcd = clsUser.UserID
        header.h23_name2 = txtName2.Text.Trim
        header.h24_vat = txtvatno.Text.Trim
        header.h25_id_banks = cboBank.SelectedValue
        If clsMaster.CustomerSave(header, msgerr, CustCD) Then
			strCustCD = CustCD
			SaveData = True
		Else
			MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
			SaveData = False
		End If
	End Function

	Private Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
		Call GenComboCustCD()
		Call InitControl()
	End Sub

	Private Sub frmCustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
			LoadData(strCustCD)
			Call GenComboCustCD()
		End If
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Const rptFileName = "rptMasterCustomer.rpt"
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

		frm.Title = "Customer Master"
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

	Private Sub cboCustCD_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCustCD.DropDownClosed
		Dim CustCD As String
		CustCD = clsConfig.IsNull(cboCustCD.ComboBox.SelectedValue, "")
		If CustCD.Trim.Length > 0 Then
			Call btnNew_Click(sender, e)
			If Not blnCancel Then LoadData(CustCD)
		End If
	End Sub

	Private Sub txtCustCD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCustCD.KeyPress
		Dim CustCD As String = ""
		If Asc(e.KeyChar) = 13 Then
			CustCD = txtCustCD.Text.Trim.ToUpper
			Call btnNew_Click(sender, e)
			If Not blnCancel Then LoadData(CustCD)
		End If
	End Sub

    Private Sub cboCustCD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCustCD.Click

    End Sub

    Private Sub txtENName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtENName.TextChanged
        If Me.txtName2.Text = "" Then
            Me.txtName2.Text = Me.txtENName.Text.Trim
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtvatno.TextChanged

    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub txtCustCD_TextChanged(sender As Object, e As EventArgs) Handles txtCustCD.TextChanged

    End Sub
End Class