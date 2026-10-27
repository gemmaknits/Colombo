Public Class frmDyingOrderSearchDesign
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

	Private Sub ResizeCRV()
		CRViewer.Top = 40
		CRViewer.Left = 8
		CRViewer.Height = Me.Height - 83
		CRViewer.Width = Me.Width - 25
	End Sub

	Private Sub GenCombo()
		Dim objDB As New classMaster

		Me.cboDesignNo.DataSource = objDB.GetDesign()
		Me.cboDesignNo.DisplayMember = "design_no"
		Me.cboDesignNo.ValueMember = "design_no"
		Me.cboDesignNo.SelectedIndex = -1
	End Sub

	Private Sub frmDyingOrderSearchDesign_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
		Me.WindowState = FormWindowState.Maximized
		Call ResizeCRV()
		Call GenCombo()
	End Sub

	Private Sub frmDyingOrderSearchDesign_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
		Call ResizeCRV()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Const rptFileName = "rptDFOrderSearchDesign.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
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
		rpt.SetParameterValue("@design_no", clsConfig.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim)

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		CRViewer.ReportSource = rpt
		CRViewer.Show()
		Me.Cursor = Cursors.Default
	End Sub
End Class