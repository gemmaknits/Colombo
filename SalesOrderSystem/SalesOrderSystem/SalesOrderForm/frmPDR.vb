Public Class frmPDR
    Dim clsConn As New classConnection
    Dim config As New clsConfig
    Dim clsUser As New classUserInfo

    Dim id As Long

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
            cbo.SelectedIndex = 0
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

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        'Call LoadData("")
        txtBookNo.Focus()
        id = 0
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classRandD

        Me.cboCustomer.DataSource = objDB.comboCustomer(clsUser.UserID)
        Me.cboCustomer.DisplayMember = "name2"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = 0

        Me.cboUOM.DataSource = objDB.comboUOM(clsUser.UserID)
        Me.cboUOM.DisplayMember = "uom"
        Me.cboUOM.ValueMember = "uom"
        Me.cboUOM.SelectedIndex = 0

        Me.cboFinalProduct.DataSource = objDB.comboFinalProduct(clsUser.UserID)
        Me.cboFinalProduct.DisplayMember = "name_en"
        Me.cboFinalProduct.ValueMember = "id"
        Me.cboFinalProduct.SelectedIndex = 0

        Me.cboDevelopType.DataSource = objDB.comboDevelopmentType(clsUser.UserID)
        Me.cboDevelopType.DisplayMember = "name_en"
        Me.cboDevelopType.ValueMember = "id"
        Me.cboDevelopType.SelectedIndex = 0

        Me.cboFabricType.DataSource = objDB.comboFabricType(clsUser.UserID)
        Me.cboFabricType.DisplayMember = "name_en"
        Me.cboFabricType.ValueMember = "id"
        Me.cboFabricType.SelectedIndex = 0

        Me.cboFabricStructure.DataSource = objDB.comboFabricStructure2(clsUser.UserID)
        Me.cboFabricStructure.DisplayMember = "name_en"
        Me.cboFabricStructure.ValueMember = "id"
        Me.cboFabricStructure.SelectedIndex = 0

        Me.cboAppearance.DataSource = objDB.comboFabricAppearance(clsUser.UserID)
        Me.cboAppearance.DisplayMember = "name_en"
        Me.cboAppearance.ValueMember = "id"
        Me.cboAppearance.SelectedIndex = 0

        Me.cboFinishing.DataSource = objDB.comboFinishing(clsUser.UserID)
        Me.cboFinishing.DisplayMember = "code"
        Me.cboFinishing.ValueMember = "id"
        Me.cboFinishing.SelectedIndex = 0

        Me.cboEmployee.DataSource = objDB.comboEmployee(clsUser.UserID)
        Me.cboEmployee.DisplayMember = "empname2"
        Me.cboEmployee.ValueMember = "empcd"
        Me.cboEmployee.SelectedIndex = 0
    End Sub

    Private Sub GenComboDocNo()
        Dim objDB As New classRandD

        Me.cboDocNo.ComboBox.DataSource = objDB.comboPDR(clsUser.UserID)
        Me.cboDocNo.ComboBox.DisplayMember = "pdr_no"
        Me.cboDocNo.ComboBox.ValueMember = "id"
        Me.cboDocNo.ComboBox.SelectedIndex = -1
    End Sub


    Private Sub BindData(ByVal dt As DataTable)
        id = Val(dt.Rows(0)("id"))

        txtBookNo.Text = dt.Rows(0)("book_no").ToString()
        txtPDRNo.Text = dt.Rows(0)("pdr_no").ToString()
        dtpPDRDate.Value = CDate(dt.Rows(0)("pdr_date"))
        txtDRNo.Text = dt.Rows(0)("dr_no").ToString()
        txtDesignNo.Text = dt.Rows(0)("design_no").ToString()
        cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString()
        cboEmployee.SelectedValue = dt.Rows(0)("empcd").ToString()
        txtPriceRequest.Text = Val(dt.Rows(0)("expected_price"))
        cboUOM.SelectedValue = dt.Rows(0)("uom").ToString()
        dtpDueDate.Value = CDate(dt.Rows(0)("expected_date"))
        cboFinalProduct.SelectedValue = Val(dt.Rows(0)("final_product_id"))

        cboDevelopType.SelectedValue = Val(dt.Rows(0)("development_type_id"))
        txtDevelopTypeRemark.Text = dt.Rows(0)("development_type_remark")
        cboFabricType.SelectedValue = Val(dt.Rows(0)("fabric_type_id"))
        cboFabricStructure.SelectedValue = Val(dt.Rows(0)("fabric_structure2_id"))
        cboAppearance.SelectedValue = Val(dt.Rows(0)("fabric_appearance_id"))
        txtAppearanceRemark.Text = dt.Rows(0)("fabric_appearance_remark").ToString()
        chkTestAATCC.Checked = CBool(dt.Rows(0)("standard_aatcc"))
        chkTestASTM.Checked = CBool(dt.Rows(0)("standard_astm"))
        chkTestISO.Checked = CBool(dt.Rows(0)("standard_iso"))
        chkTestJIS.Checked = CBool(dt.Rows(0)("standard_jis"))
        txtCustomerTestStandard.Text = dt.Rows(0)("standard_customer").ToString()

        txtComposition1Percent.Text = Val(dt.Rows(0)("composition1_percent"))
        txtComposition2Percent.Text = Val(dt.Rows(0)("composition2_percent"))
        txtComposition3Percent.Text = Val(dt.Rows(0)("composition3_percent"))
        txtComposition4Percent.Text = Val(dt.Rows(0)("composition4_percent"))
        txtComposition5Percent.Text = Val(dt.Rows(0)("composition5_percent"))
        txtComposition6Percent.Text = Val(dt.Rows(0)("composition6_percent"))

        txtComposition1Name.Text = dt.Rows(0)("composition1_name").ToString()
        txtComposition2Name.Text = dt.Rows(0)("composition2_name").ToString()
        txtComposition3Name.Text = dt.Rows(0)("composition3_name").ToString()
        txtComposition4Name.Text = dt.Rows(0)("composition4_name").ToString()
        txtComposition5Name.Text = dt.Rows(0)("composition5_name").ToString()
        txtComposition6Name.Text = dt.Rows(0)("composition6_name").ToString()

        txtWeight.Text = Val(dt.Rows(0)("weight_sqm"))
        txtWeightTolerance.Text = Val(dt.Rows(0)("weight_sqm_tolerance"))
        txtWeightRemark.Text = dt.Rows(0)("weight_sqm_remark").ToString()

        txtWidth.Text = Val(dt.Rows(0)("width"))
        txtWidthTolerance.Text = Val(dt.Rows(0)("width_tolerance"))
        txtWidthRemark.Text = dt.Rows(0)("width_remark").ToString()

        txtElongation.Text = Val(dt.Rows(0)("elongation"))
        txtElongationL.Text = Val(dt.Rows(0)("elongation_l"))
        txtElongationW.Text = Val(dt.Rows(0)("elongation_w"))
        txtElongationTolerance.Text = Val(dt.Rows(0)("elongation_tolerance"))
        txtElongationRemark.Text = dt.Rows(0)("elongation_remark").ToString()

        txtModulus.Text = Val(dt.Rows(0)("modulus"))
        txtModulusL.Text = Val(dt.Rows(0)("modulus_l"))
        txtModulusW.Text = Val(dt.Rows(0)("modulus_w"))
        txtModulusTolerance.Text = Val(dt.Rows(0)("modulus_tolerance"))
        txtModulusRemark.Text = dt.Rows(0)("modulus_remark").ToString()
        
        txtStretchL.Text = Val(dt.Rows(0)("stretch_l"))
        txtStretchW.Text = Val(dt.Rows(0)("stretch_w"))
        txtStretchTolerance.Text = Val(dt.Rows(0)("stretch_tolerance"))
        txtStretchRemark.Text = dt.Rows(0)("stretch_remark").ToString()

        txtShrinkageL.Text = Val(dt.Rows(0)("shrinkage_l"))
        txtShrinkageW.Text = Val(dt.Rows(0)("shrinkage_w"))
        txtShrinkageTolerance.Text = Val(dt.Rows(0)("shrinkage_tolerance"))
        txtShrinkageRemark.Text = dt.Rows(0)("shrinkage_remark").ToString()

        txtPillingWash.Text = Val(dt.Rows(0)("pilling_wash"))
        txtPillingL.Text = Val(dt.Rows(0)("pilling_l"))
        txtPillingW.Text = Val(dt.Rows(0)("pilling_w"))
        txtPillingTolerance.Text = Val(dt.Rows(0)("pilling_tolerance"))
        txtPillingRemark.Text = dt.Rows(0)("pilling_remark").ToString()

        txtSnaggingWash.Text = Val(dt.Rows(0)("snagging_wash"))
        txtSnaggingL.Text = Val(dt.Rows(0)("snagging_l"))
        txtSnaggingW.Text = Val(dt.Rows(0)("snagging_w"))
        txtSnaggingTolerance.Text = Val(dt.Rows(0)("snagging_tolerance"))
        txtSnaggingRemark.Text = dt.Rows(0)("snagging_remark").ToString()

        txtColorCode.Text = dt.Rows(0)("color_code").ToString()
        txtColorName.Text = dt.Rows(0)("color_name").ToString()
        cboFinishing.SelectedValue = Val(dt.Rows(0)("dye_finishing_formula_id"))
        txtDyingRemark.Text = dt.Rows(0)("dye_remark").ToString()
        txtHanger.Text = Val(dt.Rows(0)("hanger"))
        txtYardage.Text = Val(dt.Rows(0)("yardage"))
        chkTagRequired.Checked = CBool(dt.Rows(0)("require_tag"))

        txtMachineDense.Text = dt.Rows(0)("machine_dense").ToString()
        chkYarnAvailable.Checked = CBool(dt.Rows(0)("yarn_available"))
        dtpYarnReadyDate.Value = CDate(dt.Rows(0)("yarn_available_date"))
        dtpKnittingDate.Value = CDate(dt.Rows(0)("knitting_appointment"))

        txtOfferPrice.Text = Val(dt.Rows(0)("offer_price"))
        chkPriceNegotiation.Checked = CBool(dt.Rows(0)("negotiation_success"))
        chkConsideration.Checked = CBool(dt.Rows(0)("is_consideration"))

        chkApprove.Checked = CBool(dt.Rows(0)("approve"))
        chkReject.Checked = CBool(dt.Rows(0)("reject"))

        dtpExpectFinishDate.Value = CDate(dt.Rows(0)("expected_finished_date"))
        dtpSpecMasterDate.Value = CDate(dt.Rows(0)("spec_master_date"))
        dtpQAReportDate.Value = CDate(dt.Rows(0)("qa_report_date"))
    End Sub

    Private Sub LoadData(ByVal new_id As Long)
        Dim objDB As New classRandD
        Dim dt As DataTable = objDB.PDRSelect(new_id, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
        End If
    End Sub

    Private Function SaveData() As Boolean
        Dim obj As New PDR
        Dim objDB As New classRandD
        Dim errmsg As String = ""

        obj.id = id
        obj.book_no = txtBookNo.Text
        obj.pdr_no = txtPDRNo.Text
        obj.pdr_date = dtpPDRDate.Value.ToString("yyyyMMdd")
        obj.dr_no = txtDRNo.Text
        obj.design_no = txtDesignNo.Text
        obj.custcd = config.IsNull(cboCustomer.SelectedValue, "")
        obj.empcd = config.IsNull(cboEmployee.SelectedValue, "")
        obj.expected_price = Val(txtPriceRequest.Text)
        obj.uom = config.IsNull(cboUOM.SelectedValue, "")
        obj.expected_date = dtpDueDate.Value.ToString("yyyyMMdd")
        obj.final_product_id = Val(config.IsNull(cboFinalProduct.SelectedValue, 0))

        obj.development_type_id = Val(config.IsNull(cboDevelopType.SelectedValue, 0))
        obj.development_type_remark = txtDevelopTypeRemark.Text
        obj.fabric_type_id = Val(config.IsNull(cboFabricType.SelectedValue, 0))
        obj.fabric_structure2_id = Val(config.IsNull(cboFabricStructure.SelectedValue, 0))
        obj.fabric_appearance_id = Val(config.IsNull(cboAppearance.SelectedValue, 0))
        obj.fabric_appearance_remark = txtAppearanceRemark.Text
        obj.standard_aatcc = chkTestAATCC.Checked
        obj.standard_astm = chkTestASTM.Checked
        obj.standard_iso = chkTestISO.Checked
        obj.standard_jis = chkTestJIS.Checked
        obj.standard_customer = txtCustomerTestStandard.Text

        obj.composition1_percent = Val(txtComposition1Percent.Text)
        obj.composition2_percent = Val(txtComposition2Percent.Text)
        obj.composition3_percent = Val(txtComposition3Percent.Text)
        obj.composition4_percent = Val(txtComposition4Percent.Text)
        obj.composition5_percent = Val(txtComposition5Percent.Text)
        obj.composition6_percent = Val(txtComposition6Percent.Text)
        obj.composition1_name = txtComposition1Name.Text
        obj.composition2_name = txtComposition2Name.Text
        obj.composition3_name = txtComposition3Name.Text
        obj.composition4_name = txtComposition4Name.Text
        obj.composition5_name = txtComposition5Name.Text
        obj.composition6_name = txtComposition6Name.Text

        obj.weight_sqm = Val(txtWeight.Text)
        obj.weight_sqm_tolerance = Val(txtWeightTolerance.Text)
        obj.weight_sqm_remark = txtWeightRemark.Text

        obj.width = Val(txtWidth.Text)
        obj.width_tolerance = Val(txtWidthTolerance.Text)
        obj.width_remark = txtWidthRemark.Text

        obj.elongation = Val(txtElongation.Text)
        obj.elongation_l = Val(txtElongationL.Text)
        obj.elongation_w = Val(txtElongationW.Text)
        obj.elongation_tolerance = Val(txtElongationTolerance.Text)
        obj.elongation_remark = txtElongationRemark.Text

        obj.modulus = Val(txtModulus.Text)
        obj.modulus_l = Val(txtModulusL.Text)
        obj.modulus_w = Val(txtModulusW.Text)
        obj.modulus_tolerance = Val(txtModulusTolerance.Text)
        obj.modulus_remark = txtModulusRemark.Text

        obj.stretch_l = Val(txtStretchL.Text)
        obj.stretch_w = Val(txtStretchW.Text)
        obj.stretch_tolerance = Val(txtStretchTolerance.Text)
        obj.stretch_remark = txtStretchRemark.Text

        obj.shrinkage_l = Val(txtShrinkageL.Text)
        obj.shrinkage_w = Val(txtShrinkageW.Text)
        obj.shrinkage_tolerance = Val(txtShrinkageTolerance.Text)
        obj.shrinkage_remark = txtShrinkageRemark.Text

        obj.pilling_wash = Val(txtPillingWash.Text)
        obj.pilling_l = Val(txtPillingL.Text)
        obj.pilling_w = Val(txtPillingW.Text)
        obj.pilling_tolerance = Val(txtPillingTolerance.Text)
        obj.pilling_remark = txtPillingRemark.Text

        obj.snagging_wash = Val(txtSnaggingWash.Text)
        obj.snagging_l = Val(txtSnaggingL.Text)
        obj.snagging_w = Val(txtSnaggingW.Text)
        obj.snagging_tolerance = Val(txtSnaggingTolerance.Text)
        obj.snagging_remark = txtSnaggingRemark.Text

        obj.color_code = txtColorCode.Text
        obj.color_name = txtColorName.Text
        obj.dye_finishing_formula_id = Val(config.IsNull(cboFinishing.SelectedValue, 0))
        obj.dye_remark = txtDyingRemark.Text
        obj.hanger = Val(txtHanger.Text)
        obj.yardage = Val(txtYardage.Text)
        obj.require_tag = chkTagRequired.Checked
        obj.machine_dense = txtMachineDense.Text
        obj.yarn_available = chkYarnAvailable.Checked
        obj.yarn_available_date = dtpYarnReadyDate.Value.ToString("yyyyMMdd")
        obj.knitting_appointment = dtpKnittingDate.Value.ToString("yyyyMMdd")
        obj.offer_price = Val(txtOfferPrice.Text)
        obj.negotiation_success = chkPriceNegotiation.Checked
        obj.is_consideration = chkConsideration.Checked
        obj.approve = chkApprove.Checked
        obj.reject = chkReject.Checked
        obj.expected_finished_date = dtpExpectFinishDate.Value.ToString("yyyyMMdd")
        obj.spec_master_date = dtpSpecMasterDate.Value.ToString("yyyyMMdd")
        obj.qa_report_date = dtpQAReportDate.Value.ToString("yyyyMMdd")
        obj.active = True
        obj.remark = ""
        obj.create_by = clsUser.UserID
        obj.create_date = Today.ToString("yyyyMMdd")
        obj.create_time = Now.ToString("HH:mm:ss")
        obj.modify_by = clsUser.UserID
        obj.modify_date = Today.ToString("yyyyMMdd")
        obj.modify_time = Now.ToString("HH:mm:ss")

        If objDB.PDRUpdate(obj, clsUser.UserID, errmsg) Then
            Call GenComboDocNo()

            If id = 0 Then
                Call InitControl()
                Call LoadData(errmsg)
            End If

            MessageBox.Show("Save Completed", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function

    Private Sub frmPDR_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenCombo()
        Call GenComboDocNo()
    End Sub

    Private Sub frmPDR_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptPDR.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not config.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@id", id)
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Pre Development Requirement"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboDocNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDocNo.DropDownClosed
        Dim new_id As Long = config.IsNull(cboDocNo.ComboBox.SelectedValue, 0)
        If new_id > 0 Then
            Call LoadData(new_id)
        End If
    End Sub
End Class