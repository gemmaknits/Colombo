Public Class frmKOSchedulePlan
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Dim koSchedulePlan As New KOSchedulePlan

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub InitControl()
        koSchedulePlan = New KOSchedulePlan

        dtpKODate.Value = CDate("01/01/1900")
        dtpDeliveryDate.Value = CDate("01/01/1900")
        dtpModifyDate.Value = CDate("01/01/1900")
        txtKgs.Text = "0"
        dtpStartDate.Value = CDate("01/01/1900")
        dtpEndDate.Value = CDate("01/01/1900")
        txtAdjustment.Text = "0"
        txtRollKgsStd.Text = "0"
        txtDFBatchKgs.Text = "0"
        txtDailyCapacity.Text = "0"
        txtLossPercent.Text = "0"

        txtSONo.Text = ""
        txtDesignNo.Text = ""
        txtGwth.Text = ""
        chkApproved.Checked = False
        
        ClearGrid()
        Call LoadData("")
        txtKONo.Focus()
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classProduction

        ddlKO.ComboBox.DataSource = objDB.comboKO
        ddlKO.ComboBox.DisplayMember = "kono"
        ddlKO.ComboBox.ValueMember = "kono"
        ddlKO.ComboBox.SelectedIndex = -1

        'ddlSO.DataSource = objDB.comboSO
        'ddlSO.DisplayMember = "sono"
        'ddlSO.ValueMember = "sono"
        'ddlSO.SelectedIndex = -1

        'ddlDesignNo.DataSource = objDB.comboDesignNo
        'ddlDesignNo.DisplayMember = "design_no"
        'ddlDesignNo.ValueMember = "design_no"
        'ddlDesignNo.SelectedIndex = -1

        ddlMachineNo.DataSource = objDB.comboMachine
        ddlMachineNo.DisplayMember = "mcno"
        ddlMachineNo.ValueMember = "mcno"
        ddlMachineNo.SelectedIndex = -1

        'ddlYarnCode.DataSource = objDB.comboYarnCode
        'ddlYarnCode.DisplayMember = "itcd"
        'ddlYarnCode.ValueMember = "itcd"
        'ddlYarnCode.SelectedIndex = -1

        'ddlSupplier.DataSource = objDB.comboSupplier
        'ddlSupplier.DisplayMember = "name"
        'ddlSupplier.ValueMember = "suppcd"
        'ddlSupplier.SelectedIndex = -1
    End Sub

    Private Sub GenComboYarnChange(strDesignNo As String)
        Dim objDB As New classProduction

        ddlYarnChangeCode.DataSource = objDB.comboYarnChangeCode(strDesignNo)
        ddlYarnChangeCode.DisplayMember = "ynchgcd"
        ddlYarnChangeCode.ValueMember = "id_yarnchange"
        ddlYarnChangeCode.SelectedIndex = -1
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        koSchedulePlan.id = CLng(dt.Rows(0)("id"))
        koSchedulePlan.code = dt.Rows(0)("code").ToString
        koSchedulePlan.name_en = dt.Rows(0)("name_en").ToString
        koSchedulePlan.name_th = dt.Rows(0)("name_th").ToString
        koSchedulePlan.active = CBool(dt.Rows(0)("active"))
        koSchedulePlan.remark = dt.Rows(0)("remark").ToString
        koSchedulePlan.create_by = dt.Rows(0)("create_by").ToString
        koSchedulePlan.create_date = dt.Rows(0)("create_date").ToString
        koSchedulePlan.create_time = dt.Rows(0)("create_time").ToString
        koSchedulePlan.mcno = dt.Rows(0)("mcno").ToString
        koSchedulePlan.gwth = dt.Rows(0)("gwth").ToString
        koSchedulePlan.id_yarnchange = CInt(dt.Rows(0)("id_yarnchange"))
        koSchedulePlan.kgs = CSng(dt.Rows(0)("kgs"))
        koSchedulePlan.kstartdt = dt.Rows(0)("kstartdt").ToString
        koSchedulePlan.kstarttime = dt.Rows(0)("kstarttime").ToString
        koSchedulePlan.kenddt = dt.Rows(0)("kenddt").ToString
        koSchedulePlan.kendtime = dt.Rows(0)("kendtime").ToString
        koSchedulePlan.adjustment = dt.Rows(0)("adjustment").ToString
        koSchedulePlan.roll_kgs_std = CSng(dt.Rows(0)("roll_kgs_std").ToString())
        koSchedulePlan.df_batch_kgs = CSng(dt.Rows(0)("df_batch_kgs").ToString())
        koSchedulePlan.daily_capacity = CSng(dt.Rows(0)("daily_capacity").ToString())
        koSchedulePlan.loss_percent = CSng(dt.Rows(0)("loss_percent").ToString())
        koSchedulePlan.approved = CBool(dt.Rows(0)("approved").ToString())
        koSchedulePlan.schedule_remark = dt.Rows(0)("schedule_remark").ToString

        txtKONo.Text = dt.Rows(0)("code").ToString
        dtpKODate.Value = CDate(clsConfig.IsNull(dt.Rows(0)("kodt").ToString, "01/01/1900"))
        dtpDeliveryDate.Value = CDate(clsConfig.IsNull(dt.Rows(0)("delidt").ToString(), "01/01/1900"))
        ddlMachineNo.SelectedValue = dt.Rows(0)("mcno").ToString
        GenComboYarnChange(dt.Rows(0)("name_th").ToString)
        ddlYarnChangeCode.SelectedValue = dt.Rows(0)("id_yarnchange").ToString
        DateTime.TryParse(dt.Rows(0)("kstartdt").ToString + " " + dt.Rows(0)("kstarttime").ToString, dtpStartDate.Value)
        DateTime.TryParse(dt.Rows(0)("kenddt").ToString + " " + dt.Rows(0)("kendtime").ToString, dtpEndDate.Value)
        txtKgs.Text = dt.Rows(0)("kgs").ToString
        txtAdjustment.Text = dt.Rows(0)("adjustment").ToString()
        txtRollKgsStd.Text = dt.Rows(0)("roll_kgs_std").ToString()
        txtDFBatchKgs.Text = dt.Rows(0)("df_batch_kgs").ToString()
        txtDailyCapacity.Text = dt.Rows(0)("daily_capacity").ToString()
        txtLossPercent.Text = dt.Rows(0)("loss_percent").ToString()

        txtSONo.Text = dt.Rows(0)("name_en").ToString
        txtDesignNo.Text = dt.Rows(0)("name_th").ToString
        txtGwth.Text = dt.Rows(0)("gwth").ToString
        chkApproved.Checked = CBool(dt.Rows(0)("approved"))

        txtRemark.Text = dt.Rows(0)("remark").ToString
        txtschedule_remark.Text = dt.Rows(0)("schedule_remark").ToString
    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        grdLab.AutoGenerateColumns = False
        grdLab.DataSource = dt
    End Sub

    Private Sub LoadData(ByVal strKONo As String)
        If strKONo.Trim.Length = 0 Then Exit Sub
        Dim objDB As New classProduction
        Dim dt As New DataTable
        dt = objDB.KOSchedulePlanSelect(strKONo)
        If dt.Rows.Count > 0 Then Call BindData(dt)

        dt = objDB.KOSchedulePlanHistory(strKONo)
        Call BindGrid(dt)
    End Sub

    Private Function SaveData() As Boolean
        koSchedulePlan.name_en = txtSONo.Text.Trim
        koSchedulePlan.remark = txtRemark.Text.Trim
        koSchedulePlan.create_by = clsUser.UserID
        koSchedulePlan.mcno = ddlMachineNo.SelectedValue
        koSchedulePlan.id_yarnchange = ddlYarnChangeCode.SelectedValue
        koSchedulePlan.kgs = CSng(txtKgs.Text)
        koSchedulePlan.kstartdt = dtpStartDate.Value.ToString("yyyyMMdd")
        koSchedulePlan.kstarttime = dtpStartDate.Value.ToString("HH:mm:ss")
        koSchedulePlan.kenddt = dtpEndDate.Value.ToString("yyyyMMdd")
        koSchedulePlan.kendtime = dtpEndDate.Value.ToString("HH:mm:ss")
        koSchedulePlan.adjustment = txtAdjustment.Text.Trim
        koSchedulePlan.roll_kgs_std = CSng(IIf(txtRollKgsStd.Text.Trim.Length = 0, "0", txtRollKgsStd.Text.Trim))
        koSchedulePlan.df_batch_kgs = CSng(IIf(txtDFBatchKgs.Text.Trim.Length = 0, "0", txtDFBatchKgs.Text.Trim))
        koSchedulePlan.daily_capacity = CSng(IIf(txtDailyCapacity.Text.Trim.Length = 0, "0", txtDailyCapacity.Text.Trim))
        koSchedulePlan.loss_percent = CSng(IIf(txtLossPercent.Text.Trim.Length = 0, "0", txtLossPercent.Text.Trim))
        koSchedulePlan.approved = chkApproved.Checked
        koSchedulePlan.schedule_remark = txtschedule_remark.Text.Trim

        Dim msgerr As String = ""
        Dim clsProduction As New classProduction


        If clsProduction.KOSchedulePlanUpdate(koSchedulePlan, msgerr, clsuser:=UserInfo) Then
            MessageBox.Show("Save Completed.", "System Message", MessageBoxButtons.OK)
            LoadData(txtKONo.Text.Trim)
            Return True

        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        'SaveData = clsProduction.KOSchedulePlanUpdate(koSchedulePlan)

    End Function

    Private Sub ClearGrid()
        grdLab.AutoGenerateColumns = False
        grdLab.DataSource = New DataTable()
    End Sub

    Private Sub frmKOSchedulePlan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.WindowState = FormWindowState.Maximized
        Call GenCombo()
        txtKONo.Focus()
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        If SaveData() Then
            '    MessageBox.Show("Save Completed.", "System Message", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptKOScheduleHist.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@code", koSchedulePlan.code)

        frm.Title = "K/O Schedule Plan History"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintKO_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintKO.Click
        Const rptFileName = "rptKO.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Dim ko_type As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", koSchedulePlan.code)
        rpt.SetParameterValue("@logempcd", clsUser.UserID)
        rpt.SetParameterValue("@ko_type", ko_type)

        frm.Title = "Knitting Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit now ?", "System Message", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub ddlKO_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles ddlKO.DropDownClosed
        LoadData(clsConfig.IsNull(ddlKO.ComboBox.SelectedValue, ""))
    End Sub

    Private Sub txtKONo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtKONo.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            LoadData(txtKONo.Text.Trim)
        End If
    End Sub

    Private Sub ddlKO_Click(sender As System.Object, e As System.EventArgs) Handles ddlKO.Click

    End Sub
End Class