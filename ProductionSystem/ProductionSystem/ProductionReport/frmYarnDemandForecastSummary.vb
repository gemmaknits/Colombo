Public Class frmYarnDemandForecastSummary
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub GenCombo()
        Dim objDB As New classProduction

        ddlKO.DataSource = objDB.comboKO
        ddlKO.DisplayMember = "kono"
        ddlKO.ValueMember = "kono"
        ddlKO.SelectedIndex = -1

        ddlSO.DataSource = objDB.comboSO
        ddlSO.DisplayMember = "sono"
        ddlSO.ValueMember = "sono"
        ddlSO.SelectedIndex = -1

        ddlDesignNo.DataSource = objDB.comboDesignNo
        ddlDesignNo.DisplayMember = "design_no"
        ddlDesignNo.ValueMember = "design_no"
        ddlDesignNo.SelectedIndex = -1

        ddlMachineNo.DataSource = objDB.comboMachine
        ddlMachineNo.DisplayMember = "mcno"
        ddlMachineNo.ValueMember = "mcno"
        ddlMachineNo.SelectedIndex = -1

        ddlYarnCode.DataSource = objDB.comboYarnCode
        ddlYarnCode.DisplayMember = "itcd"
        ddlYarnCode.ValueMember = "itcd"
        ddlYarnCode.SelectedIndex = -1

        ddlSupplier.DataSource = objDB.comboSupplier
        ddlSupplier.DisplayMember = "name"
        ddlSupplier.ValueMember = "suppcd"
        ddlSupplier.SelectedIndex = -1
    End Sub

    Private Sub frmYarnDemandForecastSummary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call GenCombo()
        ddlKO.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = ""
        ' Dim rptYarnDemandForecastSummaryFor3Month As Boolean = False
        ' If optItems.Checked Then
        'If optstd.Checked = True Then
        rptFileName = "rptYarnDemandForecastSummary.rpt"
        '    rptYarnDemandForecastSummaryFor3Month = False
        'ElseIf optbeta.Checked = True Then
        '    'rptFileName = "rptYarnDemandForecastSummaryFor3Month_gr.rpt"
        '    rptFileName = "rptYarnDemandForecastSummaryFor3Month.rpt"
        '    rptYarnDemandForecastSummaryFor3Month = True
        'ElseIf opt3monthv2.Checked Then
        '    rptFileName = "rptYarnDemandForecastSummaryFor3Month_v2.rpt"
        '    rptYarnDemandForecastSummaryFor3Month = True
        'End If
        'ElseIf optSubInventory.Checked Then
        'rptFileName = "rptYarnDemandForecastSummaryBySubInventory.rpt"
        'rptYarnDemandForecastSummaryFor3Month = True
        'End If

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
        'rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", clsConfig.IsNull(ddlKO.SelectedValue, ""))
        rpt.SetParameterValue("@sono", clsConfig.IsNull(ddlSO.SelectedValue, ""))
        rpt.SetParameterValue("@design_no", clsConfig.IsNull(ddlDesignNo.SelectedValue, ""))
        rpt.SetParameterValue("@mcno", clsConfig.IsNull(ddlMachineNo.SelectedValue, ""))
        rpt.SetParameterValue("@itcd", clsConfig.IsNull(ddlYarnCode.SelectedValue, ""))
        rpt.SetParameterValue("@suppcd", clsConfig.IsNull(ddlSupplier.SelectedValue, ""))
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))
        rpt.SetParameterValue("@only_minus", IIf(chkMinus.Checked, "1", "0"))
        rpt.SetParameterValue("@show_no_demand", IIf(chkShowNoDemand.Checked, "1", "0"))
        rpt.SetParameterValue("@sort_by", IIf(optItcd.Checked, "ITCD", IIf(OptSupp.Checked, "SUPP", IIf(OptREORDER.Checked, "REORDER", "DESC"))))
        rpt.SetParameterValue("@datefr", dtpdatefr.Value)
        rpt.SetParameterValue("@dateto", dtpdateto.Value)
        rpt.SetParameterValue("@show_only_demand_movement", IIf(chkshow_only_demand_movement.Checked, "1", "0"))

        'Dim ReportNewVerion() As String = {"rptYarnDemandForecastSummaryFor3Month.rpt", "rptYarnDemandForecastSummaryFor3Month_v2.rpt"}
        'Dim rptYarnDemandForecastSummaryFor3Month As Boolean = False

        'For Each rptFileName In ReportNewVerion
        'If rptFileName.ToString.Equals(ReportNewVerion) Then
        'rptYarnDemandForecastSummaryFor3Month = True
        'End If
        'rptYarnDemandForecastSummaryFor3Month = True
        'Next

        'If rptYarnDemandForecastSummaryFor3Month Then
        'rpt.SetParameterValue("@datefr", dtpdatefr.Value)
        'rpt.SetParameterValue("@dateto", dtpdateto.Value)
        'rpt.SetParameterValue("@show_only_demand_movement", IIf(chkshow_only_demand_movement.Checked, True, False))
        'End If

        frm.Title = "Yarn Demand Forecast Summary"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

End Class