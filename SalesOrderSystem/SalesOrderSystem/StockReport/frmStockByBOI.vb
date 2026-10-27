Public Class frmStockByBOI
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

    Private Sub frmStockByBOI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        ' dtpDateFr.Value = DateAdd(DateInterval.Year, -99, Now)
        dtpDateFr.Value = "01-01-1900"
        dtpDateTo.Value = Now
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = IIf(optGIN.Checked, "rptGreigeINByBOI.rpt", IIf(optGOUT.Checked, "rptGreigeOUTByBOI.rpt", IIf(optDIN.Checked, "rptDINByBOI.rpt", IIf(optDOUT.Checked, "rptDINByBOI.rpt", IIf(optDBAL.Checked, "rptDbal.rpt", IIf(optGBAL.Checked, "rptGbal.rpt", "rptGbal.rpt"))))))
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@logempcd", clsUser.UserName)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = IIf(optGIN.Checked, "Greige IN By BOI", IIf(optGOUT.Checked, "Greige OUT By BOI", IIf(optDIN.Checked, "D-IN By BOI", IIf(optDOUT.Checked, "D-OUT By BOI", IIf(optDBAL.Checked, "DYED BALANCE", IIf(optGBAL.Checked, "GREIGE BALANCE", "GREIGE BALANCE"))))))
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