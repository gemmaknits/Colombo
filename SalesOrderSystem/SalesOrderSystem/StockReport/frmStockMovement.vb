Public Class frmStockMovement
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

		Me.cboDesignNo.DataSource = objDB.GetDesign
		Me.cboDesignNo.DisplayMember = "design_no"
		Me.cboDesignNo.ValueMember = "design_no"
		Me.cboDesignNo.SelectedIndex = -1

		Me.cboDocType.DataSource = objDB.GetDocType
		Me.cboDocType.DisplayMember = "name"
		Me.cboDocType.ValueMember = "doctyp"
		Me.cboDocType.SelectedIndex = -1
	End Sub

	Private Sub frmStockMovement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim rptFileName As String = ""
		If optStockG.Checked Then
			If optMovement.Checked Then
				rptFileName = "rptStockGMovement_karisma.rpt"
			Else
				rptFileName = "rptStockGBalance_karisma.rpt"
			End If
		End If
		If optStockD.Checked Then
			If optMovement.Checked Then
				rptFileName = "rptStockDMovement_karisma.rpt"
			Else
				rptFileName = "rptStockDBalance_karisma.rpt"
			End If
		End If
		If optStockC.Checked Then
			If optMovement.Checked Then
				rptFileName = "rptStockCMovement_karisma.rpt"
			Else
				rptFileName = "rptStockCBalance_karisma.rpt"
			End If
		End If
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Dim stype As String = ""
		Dim ord As String = ""
		Me.Cursor = Cursors.WaitCursor
		If optStockG.Checked Then stype = "G"
		If optStockD.Checked Then stype = "D"
		If optStockC.Checked Then stype = "C"

		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@design_no", clsConfig.IsNull(cboDesignNo.SelectedValue, ""))
		rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@language", IIf(optEng.Checked, "EN", "TH"))
		rpt.SetParameterValue("@doc_type", clsConfig.IsNull(cboDocType.SelectedValue, ""))

		rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
		rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
		rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Stock " & stype & IIf(optMovement.Checked, " Movement", " Balance")
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