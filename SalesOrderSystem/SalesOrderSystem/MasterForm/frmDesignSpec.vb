Public Class frmDesignSpec
	Dim clsConfig As New clsConfig
	Dim clsConn As New classConnection
	Dim clsUser As New classUserInfo

	Dim lngSpecID As Long = 0
	Dim lngIDYarnChange As Long = 0
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
		cboDesignNo.Focus()
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
		Me.cboDesignNo.DataSource = objDB.GetDesign
		Me.cboDesignNo.DisplayMember = "design_no"
		Me.cboDesignNo.ValueMember = "design_no"

		Me.cboCustomer.DataSource = objDB.GetCustomer
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"

		Me.cboMCType.DataSource = objDB.GetMCType
		Me.cboMCType.DisplayMember = "mname"
		Me.cboMCType.ValueMember = "mctyp"
	End Sub

	Private Sub BindData(ByVal dt As DataTable)
		lngSpecID = dt.Rows(0)("cust_spec_id")
		Me.dtpSpecDate.Value = CDate(dt.Rows(0)("cust_spec_date2"))
		Me.cboCustomer.SelectedValue = dt.Rows(0)("custcd")
		Me.cboDesignNo.SelectedValue = dt.Rows(0)("design_no")
		Me.txtRevise.Text = dt.Rows(0)("revise")
		Me.txtDescription.Text = dt.Rows(0)("mat_desc")
		Me.txtComposition.Text = dt.Rows(0)("compo")
		Me.txtLotNo.Text = dt.Rows(0)("lot")
		Me.txtColor.Text = dt.Rows(0)("col")
		lngIDYarnChange = dt.Rows(0)("id_yarnchange")
		Me.cboMCType.SelectedValue = dt.Rows(0)("mctyp")
		Me.txtGauge.Text = dt.Rows(0)("gauge")
		Me.txtBars.Text = dt.Rows(0)("bars")
		Me.txtRLAvg.Text = dt.Rows(0)("rl_avg")
		Me.txtRLMin.Text = dt.Rows(0)("rl_min")
		Me.txtRLMax.Text = dt.Rows(0)("rl_max")
		'dt.Rows(0)("rl_tolerance")
		Me.txtRWAvg.Text = dt.Rows(0)("rw_avg")
		Me.txtRWMin.Text = dt.Rows(0)("rw_min")
		Me.txtRWMax.Text = dt.Rows(0)("rw_max")
		'dt.Rows(0)("rw_tolerance")
		Me.txtShrinkageLength.Text = dt.Rows(0)("shrink_length")
		Me.txtShrinkageWidth.Text = dt.Rows(0)("shrink_width")
		'dt.Rows(0)("shrink_length_tolerance")
		'dt.Rows(0)("shrink_width_tolerance")
		Me.txtShrinkageLengthTemp.Text = dt.Rows(0)("shrink_length_temp")
		'dt.Rows(0)("shrink_length_temp_tolerance")
		Me.txtShrinkageWidthTemp.Text = dt.Rows(0)("shrink_width_temp")
		'dt.Rows(0)("shrink_width_temp_tolerance")
		Me.txtGMSPerRunMt.Text = dt.Rows(0)("gms_per_run_mt")
		'dt.Rows(0)("gms_per_run_mt_tolerance")
		Me.txtGMSPerSqM.Text = dt.Rows(0)("gms_per_sq_mt")
		'dt.Rows(0)("gms_per_sq_mt_tolerance")
		Me.txtBurstStrengthAvg.Text = dt.Rows(0)("burst_strength_avg")
		Me.txtBurstStrengthMin.Text = dt.Rows(0)("burst_strength_min")
		Me.txtBurstStrengthMax.Text = dt.Rows(0)("burst_strength_max")
		'dt.Rows(0)("burst_strength_tolerance")
		Me.txtElongationHandLen.Text = dt.Rows(0)("elong_hand_length_perc")
		'dt.Rows(0)("elong_hand_length_perc_tolerance")
		Me.txtElongationHandWth.Text = dt.Rows(0)("elong_hand_width_perc")
		'dt.Rows(0)("elong_hand_width_perc_tolerance")
		Me.txtElongationMachineLen.Text = dt.Rows(0)("elong_mc_length_perc")
		'dt.Rows(0)("elong_mc_length_perc_tolerance")
		Me.txtElongationMachineWth.Text = dt.Rows(0)("elong_mc_width_perc")
		'dt.Rows(0)("elong_mc_width_perc_tolerance")
		Me.txtModLenPerc1.Text = dt.Rows(0)("mod_length_perc1")
		Me.txtModLenVal1.Text = dt.Rows(0)("mod_length_val1")
		Me.txtModWthPerc1.Text = dt.Rows(0)("mod_width_perc1")
		Me.txtModWthVal1 = dt.Rows(0)("mod_width_val1")
		Me.txtModLenPerc2.Text = dt.Rows(0)("mod_length_perc2")
		Me.txtModLenVal2.Text = dt.Rows(0)("mod_length_val2")
		Me.txtModLenPerc2.Text = dt.Rows(0)("mod_width_perc2")
		Me.txtModWthVal2.Text = dt.Rows(0)("mod_width_val2")
		Me.txtModLenPerc3.Text = dt.Rows(0)("mod_length_perc3")
		Me.txtModLenVal3.Text = dt.Rows(0)("mod_length_val3")
		Me.txtModWthPerc3.Text = dt.Rows(0)("mod_width_perc3")
		txtModWthVal3.Text = dt.Rows(0)("mod_width_val3")
		txtProcessRoute.Text = dt.Rows(0)("process_route")
		txtSeperationMethod.Text = dt.Rows(0)("separation_method")
		'dt.Rows(0)("application")
		'dt.Rows(0)("care_instruction")
		'dt.Rows(0)("cpi")
		'dt.Rows(0)("wpi")
		'dt.Rows(0)("cpi_telorance")
		'dt.Rows(0)("wpi_telorance")
		'dt.Rows(0)("usable_width_cm")
		'dt.Rows(0)("usable_width_cm_telorance")
		'dt.Rows(0)("mtkg")
		'dt.Rows(0)("tensile_strength")
		'dt.Rows(0)("pilling")
		'dt.Rows(0)("snagging")
		'dt.Rows(0)("weight_method")
		'dt.Rows(0)("shrink_method")
		'dt.Rows(0)("elongation_method")
		'dt.Rows(0)("empcd")
		'dt.Rows(0)("tstamp")
		'dt.Rows(0)("remarks")
	End Sub

	Private Sub frmDesignSpec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Call GenCombo()
	End Sub

	Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
		Call InitControl()
	End Sub

	Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
		'a
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		'a
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
		'a
	End Sub
End Class