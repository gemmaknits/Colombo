Public Class frmMachineProductivity
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

    Private Sub frmMachineProductivity_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call GenCbo()
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpStartDate.Value = DateTime.Today
    End Sub

    Private Sub GenCbo()
        Dim objdb As New classMaster

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(UserInfo.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_name"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"
        cbomtl_warehouse.SelectedIndex = -1

        cboko_group.DataSource = objdb.comboKOGroup(UserInfo.UserID)
        cboko_group.DisplayMember = "ko_group"
        cboko_group.ValueMember = "ko_group"
        cboko_group.SelectedIndex = -1

    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = ""
        'If optstd.Checked Then
        'rptFileName = IIf(optDate.Checked, "rptMachineProductivity.rpt", IIf(optShift.Checked, "rptMachineProductivityByShift.rpt", "rptMachineProductivitySum.rpt"))
        'ElseIf optv2.Checked Then
        'rptFileName = IIf(optDate.Checked, "rptMachineProductivity2.rpt", IIf(optShift.Checked, "rptMachineProductivityByShift.rpt", IIf(optSummary.Checked, "rptMachineProductivitySum.rpt", "rptMachineProductivityByMonth.rpt")))
        rptFileName = IIf(optDate.Checked, "rptMachineProductivity.rpt", IIf(optShift.Checked, "rptMachineProductivityByShift.rpt", IIf(optSummary.Checked, "rptMachineProductivitySum.rpt", "rptMachineProductivityByMonth.rpt")))

        'End If

        ' IIf(optDate.Checked, "rptMachineProductivity2.rpt", IIf(optShift.Checked, "rptMachineProductivityByShift.rpt", "rptMachineProductivitySum.rpt"))

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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
        rpt.SetParameterValue("@month", dtpStartDate.Value.ToString("yyyyMM"))
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))
        rpt.SetParameterValue("@mtl_warehouse_id", clsConfig.IsNull(cbomtl_warehouse.SelectedValue, DBNull.Value))
        rpt.SetParameterValue("@ko_group", clsConfig.IsNull(cboko_group.SelectedValue, DBNull.Value))
        'If rptWARPKNIT.Checked Then rpt.SetParameterValue("@mcsize", "WARPKNIT")
        'If rptBEAMING.Checked Then rpt.SetParameterValue("@mcsize", "BEAMING")

        frm.Title = "Machine Productivity"
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
End Class