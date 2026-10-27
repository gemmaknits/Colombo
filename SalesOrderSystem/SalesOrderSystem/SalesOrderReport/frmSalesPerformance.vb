Public Class frmSalesPerformance
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmSalesPerformance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpMonth.Value = Now
        dtpYear.Value = Now
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptSalesPerformanceBy"

        If optMonth.Checked Then
            rptFileName &= "Month"
        Else
            rptFileName &= "Year"
        End If

        If optDesignNo.Checked Then
            rptFileName &= "Design"
        Else
            rptFileName &= "Customer"
        End If

        If optDetails.Checked Then
            rptFileName &= ".rpt"
        Else
            rptFileName &= "Sum.rpt"
        End If

        Dim clsConfig As New clsConfig

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then Exit Sub

        Dim clsConn As New classConnection
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim frm As New frmReport

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@empcd", "")
        rpt.SetParameterValue("@region", IIf(optDomestic.Checked, "DOMESTIC", "EXPORT"))
        rpt.SetParameterValue("@product_group", "FABRIC")
        rpt.SetParameterValue("@month", IIf(optMonth.Checked, dtpMonth.Value.ToString("yyyyMM"), dtpYear.Value.ToString("yyyyMM")))
        rpt.SetParameterValue("@loginempcd", clsUser.UserID)

        frm.Title = "Sales Performance Report " & IIf(optMonth.Checked, "Month", "Year")
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

    Private Sub optMonth_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optMonth.CheckedChanged
        dtpMonth.Enabled = True
        dtpYear.Enabled = False
    End Sub

    Private Sub optYear_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optYear.CheckedChanged
        dtpMonth.Enabled = False
        dtpYear.Enabled = True
    End Sub
End Class