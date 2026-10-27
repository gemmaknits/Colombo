Public Class frmDyingOrderPrint
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
		Dim objDF As New classDFOrder
		Dim objSO As New classSalesOrder

		Me.cboDFNo.DataSource = objDF.DFLoad()
		Me.cboDFNo.DisplayMember = "dfno"
		Me.cboDFNo.ValueMember = "dfno"
		Me.cboDFNo.SelectedIndex = -1

		Me.cboCustomer.DataSource = objDB.GetCustomer()
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"
		Me.cboCustomer.SelectedIndex = -1

        Me.cboSoNo.DataSource = objSO.SOLoad(strUserID:=clsUser.UserID)
        Me.cboSoNo.DisplayMember = "sono"
        Me.cboSoNo.ValueMember = "sono"
		Me.cboSoNo.SelectedIndex = -1

		Me.cboDyedHouse.DataSource = objDB.GetDyedHouse()
		Me.cboDyedHouse.DisplayMember = "name"
		Me.cboDyedHouse.ValueMember = "suppcd"
		Me.cboDyedHouse.SelectedIndex = -1

		Me.cboDesignNo.DataSource = objDB.GetDesign()
		Me.cboDesignNo.DisplayMember = "design_no"
		Me.cboDesignNo.ValueMember = "design_no"
		Me.cboDesignNo.SelectedIndex = -1

		Me.cboOwner.DataSource = objDB.GetEmp()
		Me.cboOwner.DisplayMember = "empname"
		Me.cboOwner.ValueMember = "empcd"
		Me.cboOwner.SelectedIndex = -1

	End Sub

	Private Sub frmDyingOrderPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptDFOrder2.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
		Me.Cursor = Cursors.WaitCursor
		logonInfo.ConnectionInfo.ServerName = clsConn.servername
		logonInfo.ConnectionInfo.DatabaseName = clsConn.database
		logonInfo.ConnectionInfo.IntegratedSecurity = False
		logonInfo.ConnectionInfo.UserID = clsConn.Userid
		logonInfo.ConnectionInfo.Password = clsConn.Password

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@dfno", clsConfig.IsNull(cboDFNo.SelectedValue, "").ToString.Trim)
		rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
		rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
		rpt.SetParameterValue("@dhcod", clsConfig.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim)
		rpt.SetParameterValue("@design_no", clsConfig.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@empcd", clsConfig.IsNull(cboOwner.SelectedValue, "").ToString.Trim)

        'Add By Neung 09/02/2015 //@lot is missing
        rpt.SetParameterValue("@lot", "")
        rpt.DataDefinition.ParameterFields("@dfno", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dfno").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@dhcod", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dhcod").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@design_no", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@design_no").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@empcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@empcd").CurrentValues)

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "D/F Order"
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