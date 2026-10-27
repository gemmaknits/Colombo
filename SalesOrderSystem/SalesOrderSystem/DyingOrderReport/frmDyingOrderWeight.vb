Public Class frmDyingOrderWeight
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

		Me.cboSoNo.DataSource = objSO.SOLoad()
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
        Me.optOrderFilterAll.Checked = True
		Call GenCombo()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Const rptFileName = "rptDFOrderWeight.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
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
        If Me.optOrderFilterAll.Checked Then rpt.SetParameterValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then rpt.SetParameterValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then rpt.SetParameterValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then rpt.SetParameterValue("@orderfilter", "MTO")

        If Me.chkShowOnlyClosedOrders.Checked Then
            rpt.SetParameterValue("@ShowOnlyClosed", 1)
        Else
            rpt.SetParameterValue("@ShowOnlyClosed", 0)
        End If

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "D/F Order Summary"
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