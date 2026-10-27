Public Class frmDyingOrderClosing
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

    Private Sub frmDyingOrderClosing_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptDFOrderClosing_DFNO.rpt"
        If optDFDate.Checked Then rptFileName = "rptDFOrderClosing_DFDT.rpt"
        If optDesignNo.Checked Then rptFileName = "rptDFOrderClosing_DESIGN.rpt"
        If optSONo.Checked Then rptFileName = "rptDFOrderClosing_SONO.rpt"
        If optCustomer.Checked Then rptFileName = "rptDFOrderClosing_CUST.rpt"

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
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        rpt.SetParameterValue("@lossfr", Val(txtLossFr.Text.Trim))
        rpt.SetParameterValue("@lossto", Val(txtLossTo.Text.Trim))

        If Me.optDFNo.Checked Then rpt.SetParameterValue("@order_by", "DFNO")
        If Me.optDFDate.Checked Then rpt.SetParameterValue("@order_by", "DFDT")
        If Me.optDesignNo.Checked Then rpt.SetParameterValue("@order_by", "DESIGN")
        If Me.optSONo.Checked Then rpt.SetParameterValue("@order_by", "SONO")
        If Me.optCustomer.Checked Then rpt.SetParameterValue("@order_by", "CUST")

        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "D/F Order Closing"
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

    Private Sub optDFNo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optDFNo.CheckedChanged

    End Sub
End Class