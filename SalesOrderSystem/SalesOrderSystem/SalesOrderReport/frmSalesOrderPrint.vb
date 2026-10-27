Public Class frmSalesOrderPrint
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
		Dim objSO As New classSalesOrder

		Me.cboCustomer.DataSource = objDB.GetCustomer
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"
		Me.cboCustomer.SelectedIndex = -1

        Me.cboSoNo.DataSource = objSO.SOLoad(strUserID:=clsUser.UserID)
		Me.cboSoNo.DisplayMember = "sono2"
		Me.cboSoNo.ValueMember = "sono2"
		Me.cboSoNo.SelectedIndex = -1
	End Sub

	Private Sub FormRptInvoiceLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Const rptFileName = "rptSO.rpt"
        Const rptFileName = "rptSOConfirm.rpt"

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor

        'logonInfo.ConnectionInfo.ServerName = clsConn.servername
        'logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        'logonInfo.ConnectionInfo.IntegratedSecurity = False
        'logonInfo.ConnectionInfo.UserID = clsConn.Userid
        'logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        'rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
		rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
		rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
		rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
		rpt.SetParameterValue("@print_performa", chkPrintPerforma.Checked)
        rpt.SetParameterValue("@use_show_price", chkUseShowPrice.Checked)
        rpt.SetParameterValue("@print_yield", chkPrintYield.Checked)

        'rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@print_performa", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@print_performa").CurrentValues)
        '      rpt.DataDefinition.ParameterFields("@use_show_price", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@use_show_price").CurrentValues)
        '      rpt.DataDefinition.ParameterFields("@print_yield", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@print_yield").CurrentValues)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Sales Order"
		frm.CRViewer.ReportSource = rpt
		frm.MdiParent = Me.ParentForm
		frm.Show()
		Me.Cursor = Cursors.Default
	End Sub

    Private Sub btnPrintSoRemark_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
		Me.WindowState = FormWindowState.Minimized
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Dispose()
	End Sub


End Class