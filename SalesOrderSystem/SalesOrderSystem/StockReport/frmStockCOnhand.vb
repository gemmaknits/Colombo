Public Class frmStockCOnhand
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

		Me.cboUOM.DataSource = objDB.GetUOM
		Me.cboUOM.DisplayMember = "uom2"
		Me.cboUOM.ValueMember = "uom2"
		Me.cboUOM.SelectedValue = "KGS"

		Me.cboColor.DataSource = objDB.GetColor
		Me.cboColor.DisplayMember = "col2"
		Me.cboColor.ValueMember = "col2"
		Me.cboColor.SelectedIndex = -1
	End Sub

	Private Sub frmStockGOnhand_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		Call GenCombo()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim strDesignNo As String = ""
		Dim rptFileName As String = "rptStockCOnhand2.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
		rpt.SetParameterValue("@rptwth", Val(txtRptWth.Text.Trim))
		rpt.SetParameterValue("@ab", txtAB.Text.Trim)
		rpt.SetParameterValue("@gr", txtGr.Text.Trim)
		rpt.SetParameterValue("@qtyfr", Val(txtQtyFr.Text))
		rpt.SetParameterValue("@qtyto", Val(txtQtyTo.Text))
		rpt.SetParameterValue("@uom", clsConfig.IsNull(cboUOM.SelectedValue, ""))
		rpt.SetParameterValue("@col", clsConfig.IsNull(cboColor.SelectedValue, ""))

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Stock G Onhand"
		frm.CRViewer.ReportSource = rpt
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
