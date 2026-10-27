Public Class frmDataEntry
#Region "Variables"
	'l = Local Variable, p = Public Variable
	'str = String, int = Integer, lng = Long, dbl = Double,
	'bln = Boolean, dat = Date, cls = Class
	Private clsConfig As New clsConfig
	Private clsUser As New classUserInfo

	Private lBlnCanExit As Boolean = True
	Private lStrDocNo As String = ""
#End Region

#Region "Properties"
	Public Property UserInfo() As classUserInfo
		Get
			UserInfo = clsUser
		End Get
		Set(ByVal NewValue As classUserInfo)
			clsUser = NewValue
		End Set
	End Property

	Public Property Remark() As String
		Get
			Remark = lblRemark.Text
		End Get
		Set(ByVal NewValue As String)
			lblRemark.Text = NewValue
			Me.lblRemark.Visible = IIf(lblRemark.Text = "", False, True)
		End Set
	End Property

	Public Property CanExit() As Boolean
		Get
			CanExit = lblnCanExit
		End Get
		Set(ByVal NewValue As Boolean)
			lblnCanExit = NewValue
		End Set
	End Property

	Public Property DocNo() As String
		Get
			DocNo = lStrDocNo
		End Get
		Set(ByVal NewValue As String)
			lStrDocNo = NewValue
		End Set
	End Property
#End Region

#Region "Functions"
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

	Public Sub InitControl()
		Dim obj As Control
		For Each obj In Me.Controls
			Call SetControlValue(obj)
			If obj.Name = "txtDocNo" Then obj.Focus()
		Next
		Call EnabledControl(True)
		Call LoadData()
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

	Public Sub EnabledControl(ByVal blnEnabled As Boolean)
		Dim obj As Control
		For Each obj In Me.Controls
			If obj.Name = "txtDocNo" Then
				Call SetControlEnabled(obj, True)
			Else
				Call SetControlEnabled(obj, blnEnabled)
			End If
		Next
	End Sub

	Private Sub SetCombo(ByRef cbo As ComboBox)
		Dim objDB As New classMaster
		Select Case cbo.Name
			Case "cboAgent"
				cbo.DataSource = objDB.GetAgent
				cbo.DisplayMember = "agname2"
				cbo.ValueMember = "agcd2"
			Case "cboColor"
				cbo.DataSource = objDB.GetColor
				cbo.DisplayMember = "colname2"
				cbo.ValueMember = "col2"
			Case "cboCountry"
				cbo.DataSource = objDB.GetCountry
				cbo.DisplayMember = "name2"
				cbo.ValueMember = "ctry2"
			Case "cboCurrency"
				cbo.DataSource = objDB.GetCurrency
				cbo.DisplayMember = "currname"
				cbo.ValueMember = "curr"
			Case "cboCustomer"
				cbo.DataSource = objDB.GetCustomer
				cbo.DisplayMember = "new_custname"
				cbo.ValueMember = "new_custcd"
			Case "cboDesignNo"
				cbo.DataSource = objDB.GetDesign
				cbo.DisplayMember = "design_no"
				cbo.ValueMember = "design_no"
			Case "cboDesignGroup"
				cbo.DataSource = objDB.GetDesignGroup
				cbo.DisplayMember = "itgroupdesc"
				cbo.ValueMember = "itgroupcd"
			Case "cboDesignGwthNob"
				cbo.DataSource = objDB.GetDesignGwth
				cbo.DisplayMember = "design_gwth_nob"
				cbo.ValueMember = "design_gwth_nob"
			Case "cboDesignType"
				cbo.DataSource = objDB.GetDesignType
				cbo.DisplayMember = "ittypedesc"
				cbo.ValueMember = "ittypecd"
			Case "cboDocType"
				cbo.DataSource = objDB.GetDocType
				cbo.DisplayMember = "name"
				cbo.ValueMember = "doctyp"
			Case "cboDyedCase"
				cbo.DataSource = objDB.GetDyedCase
				cbo.DisplayMember = "dyedcase"
				cbo.ValueMember = "dyedcase"
			Case "cboDyedHouse"
				cbo.DataSource = objDB.GetDyedHouse
				cbo.DisplayMember = "suppname"
				cbo.ValueMember = "suppcd2"
			Case "cboDyedMethod"
				cbo.DataSource = objDB.GetDyingMethod
				cbo.DisplayMember = "dmethod"
				cbo.ValueMember = "dmethodcd"
			Case "cboEmp"
				cbo.DataSource = objDB.GetEmp
				cbo.DisplayMember = "empname2"
				cbo.ValueMember = "empcd2"
			Case "cboFreightCharge"
				cbo.DataSource = objDB.GetFreightCharge
				cbo.DisplayMember = "charge_desc"
				cbo.ValueMember = "charge_code"
			Case "cboGwth"
				cbo.DataSource = objDB.GetGwth
				cbo.DisplayMember = "gwth"
				cbo.ValueMember = "gwth"
			Case "cboLightSource"
				cbo.DataSource = objDB.GetLightSource
				cbo.DisplayMember = "description"
				cbo.ValueMember = "lights"
			Case "cboMCType"
				cbo.DataSource = objDB.GetMCType
				cbo.DisplayMember = "mname"
				cbo.ValueMember = "mctyp"
			Case "cboOutNo"
				cbo.DataSource = objDB.GetOutNo
				cbo.DisplayMember = "outno"
				cbo.ValueMember = "outno"
			Case "cboPayMode"
				cbo.DataSource = objDB.GetPaymode
				cbo.DisplayMember = "paymodecd"
				cbo.ValueMember = "paymodecd"
			Case "cboSoNo"
				cbo.DataSource = objDB.GetSoNo
				cbo.DisplayMember = "sono"
				cbo.ValueMember = "sono"
			Case "cboSoNoID"
				cbo.DataSource = objDB.GetSoNoID
				cbo.DisplayMember = "sono_design_col"
				cbo.ValueMember = "sonoid"
			Case "cboSupplier"
				cbo.DataSource = objDB.GetSupplier
				cbo.DisplayMember = "suppname"
				cbo.ValueMember = "suppcd2"
			Case "cboUOM"
				cbo.DataSource = objDB.GetUOM
				cbo.DisplayMember = "uom"
				cbo.ValueMember = "uom"
			Case "cboYesNo"
				cbo.DataSource = objDB.GetYesNo
				cbo.DisplayMember = "yesno"
				cbo.ValueMember = "value"
			Case "cboTrueFalse"
				cbo.DataSource = objDB.GetYesNo
				cbo.DisplayMember = "truefalse"
				cbo.ValueMember = "value"
			Case "cboEndBuyer"
				cbo.DataSource = objDB.GetEndBuyers
				cbo.DisplayMember = "endbuyername"
				cbo.ValueMember = "endbuyercd"
		End Select
		cbo.SelectedIndex = -1
		cbo.Font = New Font("Courier New", 8, FontStyle.Regular)
	End Sub

	Private Sub GenCombo(ByVal parent As Control)
		Dim obj As Control
		For Each obj In parent.Controls
			If TypeOf obj Is ComboBox Then Call SetCombo(obj)
			If TypeOf obj Is ContainerControl Then Call GenCombo(obj)
		Next
	End Sub

	Public Overridable Sub LoadData()
		'a
	End Sub

	Public Overridable Function IsDataChange(ByVal strStatus As String, ByVal dt As DataTable) As Boolean
		On Error Resume Next
		Dim result As Boolean = False
		Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
		Dim obj As Control
		If dt Is Nothing Or dv.Count = 0 Or dt.Rows.Count = 0 Or strStatus = "NEW" Then
			If dt.Rows.Count > 1 Then result = True
			For Each obj In Me.Controls
				If obj.Tag <> "" And obj.Name <> "txtDocNo" Then
					If TypeOf obj Is TextBox Then
						If obj.Text <> "" Then result = True
					ElseIf TypeOf obj Is DateTimePicker Then
						If DirectCast(obj, DateTimePicker).Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
					ElseIf TypeOf obj Is ComboBox Then
						If clsConfig.IsNull(DirectCast(obj, ComboBox).SelectedValue, "") <> "" Then result = True
					End If
				End If
			Next
		Else
			If Not lblCancelled.Visible Then
				For Each obj In Me.Controls
					If obj.Tag <> "" And obj.Name <> "txtDocNo" Then
						If TypeOf obj Is TextBox Then
							If obj.Text <> dv(0)(obj.Tag) Then result = True
						ElseIf TypeOf obj Is DateTimePicker Then
							If DirectCast(obj, DateTimePicker).Value.ToString("yyyyMMdd") <> CDate(dv(0)(obj.Tag)).ToString("yyyyMMdd") Then result = True
						ElseIf TypeOf obj Is ComboBox Then
							If clsConfig.IsNull(DirectCast(obj, ComboBox).SelectedValue, "") <> dv(0)(obj.Tag) Then result = True
						End If
					End If
				Next

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

	Public Sub BindGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
		grd.AutoGenerateColumns = False
		grd.DataSource = dt
	End Sub

	Public Sub ClearGrid(ByRef grd As DataGridView, ByVal dt As DataTable)
		Dim objDB As New classLab
		grd.AutoGenerateColumns = False
		grd.DataSource = dt
	End Sub
#End Region

#Region "Events"
	Private Sub frmDataEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.btnCancel.Visible = False
		Call GenCombo(Me)
		Application.DoEvents()
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		MessageBox.Show("new1")
		Application.DoEvents()
	End Sub

	Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
		Application.DoEvents()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		Application.DoEvents()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Application.DoEvents()
	End Sub

	Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
		Application.DoEvents()
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
		Application.DoEvents()
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		If Me.CanExit Then Me.Close()
		Application.DoEvents()
	End Sub

	Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
		Application.DoEvents()
	End Sub

	Private Sub cboDocNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDocNo.Click
		Application.DoEvents()
	End Sub

	Private Sub cboDocNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDocNo.DropDownClosed
		Application.DoEvents()
	End Sub

	Private Sub cboDocNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDocNo.KeyDown
		If e.KeyCode = Keys.Enter Then cboDocNo.SelectedItem = cboDocNo.Text
		Application.DoEvents()
	End Sub
#End Region
End Class