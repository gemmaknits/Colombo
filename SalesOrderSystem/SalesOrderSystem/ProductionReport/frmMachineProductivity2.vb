Public Class frmMachineProductivity2
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

    Private Sub frmMachineProductivity2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpStartDate.Value = DateTime.Today
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptFileName = IIf(optDate.Checked, "rptMachineProductivity2.rpt", IIf(optShift.Checked, "rptMachineProductivityByShift.rpt", "rptMachineProductivitySum.rpt"))

        'If rptmcno.Checked Then
        'rptFileName = "rptMachineProductivity3.rpt"
        'End If

        'Dim rptFileName = IIf(optDate.Checked, "rptMachineProductivity2.rpt", IIf(optShift.Checked, "rptMachineProductivityByShift.rpt", "rptMachineProductivitySum.rpt"))
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
        rpt.SetParameterValue("@mcsize", IIf(optWARPKNIT.Checked, "WARPKNIT", IIf(optBEAMING.Checked, "BEAMING", "ALL")))
        'If rptWARPKNIT.Checked Then rpt.SetParameterValue("@mcsize", "WARPKNIT")
        'If rptBEAMING.Checked Then rpt.SetParameterValue("@mcsize", "BEAMING")

        frm.Title = "Machine Productivity 2"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class