Public Class frmInvoiceLocalPrint
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
		Dim objDB As New classMaster
		Dim objDB2 As New classInvoice
		Dim dt As DataTable
		dt = objDB.GetCustomer
		Me.cboCustomer.DataSource = dt
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"

		dt = objDB2.InvLocLoad
		Me.cboInvNo.DataSource = dt
		Me.cboInvNo.DisplayMember = "invno"
		Me.cboInvNo.ValueMember = "invid"
		Me.cboInvNo.SelectedIndex = -1
	End Sub

	Private Sub FormRptInvoiceLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Const rptFileName = "rptInvLocal.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor
		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@invid", clsConfig.IsNull(cboInvNo.SelectedValue, 0))
		rpt.SetParameterValue("@invno", "")
		rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@language", IIf(optThai.Checked, "TH", "EN"))
		rpt.SetParameterValue("@custcd", cboCustomer.SelectedValue)

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Local Invoice"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Dispose()
	End Sub
End Class