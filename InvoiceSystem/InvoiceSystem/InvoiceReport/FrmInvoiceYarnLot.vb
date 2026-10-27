
Public Class FrmInvoiceYarnLot
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintReport("rptInvYarnLot.rpt")
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

    End Sub

    Private Sub FrmInvoiceYarnLot_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
    End Sub
    Private Sub PrintReport(pRptName As String)
        If Not clsConfig.CheckReport(clsUser.ReportPath, pRptName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@p_datefrom", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@p_dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@p_design_no", "")
        rpt.SetParameterValue("@p_custcd", txtCustomer.Text.Trim)
        rpt.SetParameterValue("@p_invno", TextBox4.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Invoice detail"
        'frm.CRViewer.DisplayGroupTree = (cboInvNo.SelectedIndex < 0)
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCustomerFind_Click(sender As Object, e As EventArgs) Handles btnCustomerFind.Click
        Dim DlgGetMasterCode As New DlgGetMasterCode("CUSTOMER")
        DlgGetMasterCode.pCustCd = txtCustomer.Text.Trim
        DlgGetMasterCode.ShowDialog(Me)
        txtCustomer.Text = DlgGetMasterCode.pCustCd
        txtCustName.Text = DlgGetMasterCode.pcustName
    End Sub
End Class