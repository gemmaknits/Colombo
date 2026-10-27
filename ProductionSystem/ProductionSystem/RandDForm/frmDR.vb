Public Class frmDR
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
            'If Obj.Tag = "str" Then Obj.Text = ""
            'If Obj.Tag = "int" Then Obj.Text = "0.00"
            Obj.Text = Obj.Tag
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
        optKI.Checked = True
        txtDRNo.Focus()
        id = 0
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classRandD

        Me.cboPDR.DataSource = objDB.comboPDR(clsUser.UserID)
        Me.cboPDR.DisplayMember = "pdr_no"
        Me.cboPDR.ValueMember = "id"
        Me.cboPDR.SelectedIndex = 0

        Me.cboMachine.DataSource = objDB.comboMachineGauge(clsUser.UserID)
        Me.cboMachine.DisplayMember = "gauge"
        Me.cboMachine.ValueMember = "gauge"
        Me.cboMachine.SelectedIndex = 0

        Dim dt As DataTable = objDB.comboYarnCode(clsUser.UserID)
        Dim ds As New DataSet
        ds.Tables.Add(dt)

        Me.cboYarn1Code.DataSource = dt
        Me.cboYarn1Code.DisplayMember = "itcd2"
        Me.cboYarn1Code.ValueMember = "itcd"
        Me.cboYarn1Code.SelectedIndex = 0

        Me.cboYarn2Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn2Code.DisplayMember = "itcd2"
        Me.cboYarn2Code.ValueMember = "itcd"
        Me.cboYarn2Code.SelectedIndex = 0

        Me.cboYarn3Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn3Code.DisplayMember = "itcd2"
        Me.cboYarn3Code.ValueMember = "itcd"
        Me.cboYarn3Code.SelectedIndex = 0

        Me.cboYarn4Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn4Code.DisplayMember = "itcd2"
        Me.cboYarn4Code.ValueMember = "itcd"
        Me.cboYarn4Code.SelectedIndex = 0

        Me.cboYarn5Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn5Code.DisplayMember = "itcd2"
        Me.cboYarn5Code.ValueMember = "itcd"
        Me.cboYarn5Code.SelectedIndex = 0

        Me.cboYarn6Code.DataSource = ds.Tables(0).Copy()
        Me.cboYarn6Code.DisplayMember = "itcd2"
        Me.cboYarn6Code.ValueMember = "itcd"
        Me.cboYarn6Code.SelectedIndex = 0
    End Sub

    Private Sub GenComboDocNo()
        Dim objDB As New classRandD

        Me.cboDocNo.ComboBox.DataSource = objDB.comboDR(clsUser.UserID)
        Me.cboDocNo.ComboBox.DisplayMember = "dr_no"
        Me.cboDocNo.ComboBox.ValueMember = "id"
        Me.cboDocNo.ComboBox.SelectedIndex = -1
    End Sub


    Private Sub BindData(ByVal dt As DataTable)
        id = Val(dt.Rows(0)("id"))

        txtDRNo.Text = dt.Rows(0)("dr_no").ToString()
        dtpDRDate.Value = CDate(dt.Rows(0)("dr_date"))
        cboPDR.SelectedValue = dt.Rows(0)("pdr_id").ToString()
        txtDFNo.Text = dt.Rows(0)("dfno").ToString()
        txtNewDesignNo.Text = dt.Rows(0)("new_design_no").ToString()

        If dt.Rows(0)("knitting_type").ToString().Equals("KI") Then optKI.Checked = True
        If dt.Rows(0)("knitting_type").ToString().Equals("KO") Then optKO.Checked = True
        If dt.Rows(0)("knitting_type").ToString().Equals("KP") Then optKP.Checked = True

        cboYarn1Code.SelectedValue = dt.Rows(0)("itcd1").ToString()
        txtYarn1Percent.Text = dt.Rows(0)("ynperc1").ToString()
        txtYarn1Spools.Text = dt.Rows(0)("spools1").ToString()
        txtYarn1Remark.Text = dt.Rows(0)("itcd1_remark").ToString()

        cboYarn2Code.SelectedValue = dt.Rows(0)("itcd2").ToString()
        txtYarn2Percent.Text = dt.Rows(0)("ynperc2").ToString()
        txtYarn2Spools.Text = dt.Rows(0)("spools2").ToString()
        txtYarn2Remark.Text = dt.Rows(0)("itcd2_remark").ToString()

        cboYarn3Code.SelectedValue = dt.Rows(0)("itcd3").ToString()
        txtYarn3Percent.Text = dt.Rows(0)("ynperc3").ToString()
        txtYarn3Spools.Text = dt.Rows(0)("spools3").ToString()
        txtYarn3Remark.Text = dt.Rows(0)("itcd3_remark").ToString()

        cboYarn4Code.SelectedValue = dt.Rows(0)("itcd4").ToString()
        txtYarn4Percent.Text = dt.Rows(0)("ynperc4").ToString()
        txtYarn4Spools.Text = dt.Rows(0)("spools4").ToString()
        txtYarn4Remark.Text = dt.Rows(0)("itcd4_remark").ToString()

        cboYarn5Code.SelectedValue = dt.Rows(0)("itcd5").ToString()
        txtYarn5Percent.Text = dt.Rows(0)("ynperc5").ToString()
        txtYarn5Spools.Text = dt.Rows(0)("spools5").ToString()
        txtYarn5Remark.Text = dt.Rows(0)("itcd5_remark").ToString()

        cboYarn6Code.SelectedValue = dt.Rows(0)("itcd6").ToString()
        txtYarn6Percent.Text = dt.Rows(0)("ynperc6").ToString()
        txtYarn6Spools.Text = dt.Rows(0)("spools6").ToString()
        txtYarn6Remark.Text = dt.Rows(0)("itcd6_remark").ToString()

        txtRolls.Text = dt.Rows(0)("rolls").ToString()
        txtKgsPerRoll.Text = dt.Rows(0)("kgs_per_roll").ToString()
        cboMachine.SelectedValue = dt.Rows(0)("mcno").ToString()
        txtKnittingRemark.Text = dt.Rows(0)("knitting_remark").ToString()

        txtWeight.Text = dt.Rows(0)("weight_sqm").ToString()
        txtWidth.Text = dt.Rows(0)("width").ToString()
        txtCourse.Text = dt.Rows(0)("course").ToString()
        txtWale.Text = dt.Rows(0)("wale").ToString()
        txtDyeingRemark.Text = dt.Rows(0)("dyeing_remark").ToString()
    End Sub

    Private Sub LoadData(ByVal new_id As Long)
        Dim objDB As New classRandD
        Dim dt As DataTable = objDB.DRSelect(new_id, clsUser.UserID)
        If dt.Rows.Count > 0 Then
            Call BindData(dt)
        End If
    End Sub

    Private Function SaveData() As Boolean
        Dim obj As New DR
        Dim objDB As New classRandD
        Dim errmsg As String = ""

        obj.id = id
        obj.dr_no = txtDRNo.Text
        obj.dr_date = dtpDRDate.Value.ToString("yyyyMMdd")
        obj.pdr_id = cboPDR.SelectedValue
        obj.dfno = txtDFNo.Text
        obj.new_design_no = txtNewDesignNo.Text

        obj.knitting_type = IIf(optKO.Checked, "KO", IIf(optKP.Checked, "KP", "KI"))

        obj.itcd1 = cboYarn1Code.SelectedValue
        obj.ynperc1 = Val(txtYarn1Percent.Text)
        obj.spools1 = Val(txtYarn1Spools.Text)
        obj.itcd1_remark = txtYarn1Remark.Text

        obj.itcd2 = cboYarn2Code.SelectedValue
        obj.ynperc2 = Val(txtYarn2Percent.Text)
        obj.spools2 = Val(txtYarn2Spools.Text)
        obj.itcd2_remark = txtYarn2Remark.Text

        obj.itcd3 = cboYarn3Code.SelectedValue
        obj.ynperc3 = Val(txtYarn3Percent.Text)
        obj.spools3 = Val(txtYarn3Spools.Text)
        obj.itcd3_remark = txtYarn3Remark.Text

        obj.itcd4 = cboYarn4Code.SelectedValue
        obj.ynperc4 = Val(txtYarn4Percent.Text)
        obj.spools4 = Val(txtYarn4Spools.Text)
        obj.itcd4_remark = txtYarn4Remark.Text

        obj.itcd5 = cboYarn5Code.SelectedValue
        obj.ynperc5 = Val(txtYarn5Percent.Text)
        obj.spools5 = Val(txtYarn5Spools.Text)
        obj.itcd5_remark = txtYarn5Remark.Text

        obj.itcd6 = cboYarn6Code.SelectedValue
        obj.ynperc6 = Val(txtYarn6Percent.Text)
        obj.spools6 = Val(txtYarn6Spools.Text)
        obj.itcd6_remark = txtYarn6Remark.Text

        obj.rolls = Val(txtRolls.Text)
        obj.kgs_per_roll = Val(txtKgsPerRoll.Text)
        obj.mcno = cboMachine.SelectedValue
        obj.knitting_remark = txtKnittingRemark.Text

        obj.weight_sqm = Val(txtWeight.Text)
        obj.width = Val(txtWidth.Text)
        obj.course = Val(txtCourse.Text)
        obj.wale = Val(txtWale.Text)
        obj.dyeing_remark = txtDyeingRemark.Text

        obj.active = True
        obj.remark = ""
        obj.create_by = clsUser.UserID
        obj.create_date = Today.ToString("yyyyMMdd")
        obj.create_time = Now.ToString("HH:mm:ss")
        obj.modify_by = clsUser.UserID
        obj.modify_date = Today.ToString("yyyyMMdd")
        obj.modify_time = Now.ToString("HH:mm:ss")

        If objDB.DRUpdate(obj, clsUser.UserID, errmsg) Then
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

    Private Sub frmDR_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenCombo()
        Call GenComboDocNo()
    End Sub

    Private Sub frmDR_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call btnSave_Click(sender, e)
        Call InitControl()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call SaveData()
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptDR.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
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

        frm.Title = "Development Requirement"
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