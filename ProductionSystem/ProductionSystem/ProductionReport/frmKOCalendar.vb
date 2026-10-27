Public Class frmKOCalendar
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
    Private Sub frmKOCalendar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = Now
    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptKOCalendar3.rpt"
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
        rpt.SetParameterValue("First Month", dtpDateFr.Value.ToString("MMMM"))
        rpt.SetParameterValue("First Year", dtpDateFr.Value.ToString("yyyy"))
        rpt.SetParameterValue("Last Month", dtpDateFr.Value.ToString("MMMM"))
        rpt.SetParameterValue("Last Year", dtpDateFr.Value.ToString("yyyy"))
        rpt.SetParameterValue("@Date_type", IIf(optStartDate.Checked, 1, IIf(optEndDate.Checked, 2, 3)))
        rpt.SetParameterValue("@month", dtpDateFr.Value.ToString("yyyyMM"))
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))
        rpt.DataDefinition.ParameterFields("@Date_type", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@Date_type").CurrentValues)
        rpt.DataDefinition.ParameterFields("@month", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@month").CurrentValues)
        rpt.DataDefinition.ParameterFields("@logempcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@logempcd").CurrentValues)
        'rpt.SetParameterValue("@Date_type(subreport)", IIf(optStartDate.Checked, 1, IIf(optEndDate.Checked, 2, 3)))
        'rpt.SetParameterValue("@month(subreport)", dtpDateFr.Value.ToString("yyyyMM"))
        'rpt.SetParameterValue("@logempcd(subreport)", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "K/O Calendar"
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