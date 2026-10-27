Public Class frmInvoiceLocalControl
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
	End Sub

	Private Sub frmInvoiceLocalControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptInvLocalControl.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor
		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
        rpt.SetParameterValue("@datefr", Format(dtpDateFr.Value, "yyyyMMdd"))
        rpt.SetParameterValue("@dateto", Format(dtpDateTo.Value, "yyyyMMdd"))
        rpt.SetParameterValue("@custcd", cboCustomer.SelectedValue)
        rpt.SetParameterValue("@empcd", "") 'clsUser.UserID 'Sitthana 20190620
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Local Invoice Control"
        frm.CRViewer.ReportSource = rpt
        frm.CRViewer.Refresh()
        frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

	Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class