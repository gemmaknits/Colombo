Public Class frmBOIFromGIN
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
    Private Sub frmBOIFromGIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        'dtpMonth.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpMonth.Value = Now
        'dtpDateTo.Value = Now
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptBOIBYGIN.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@datefr", dtpMonth.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpMonth.Value.ToString("yyyyMMdd"))
        'rpt.SetParameterValue("@custcd", cboCustomer.SelectedValue)
        ' rpt.SetParameterValue("@agcd", cboAgent.SelectedValue)
        If optKnitting.Checked Then
            rpt.SetParameterValue("@tran_type", "KNITTING")
        ElseIf optPreset.Checked Then
            rpt.SetParameterValue("@tran_type", "PRESET")
        ElseIf optPurchase.Checked Then
            rpt.SetParameterValue("@tran_type", "PURCHASE")
        ElseIf optReturn.Checked Then
            rpt.SetParameterValue("@tran_type", "RETURN")
        End If

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "BOI From Greige IN"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class