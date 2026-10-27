Public Class frmInvoiceExportControl
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
		Dim rowAll As DataRow = dt.NewRow()
		rowAll("custcd") = ""
		rowAll("name") = "ทั้งหมด"
		dt.Rows.InsertAt(rowAll, 0)
		Me.cboCustomer.DataSource = dt
		Me.cboCustomer.DisplayMember = "name"
		Me.cboCustomer.ValueMember = "custcd"
		Me.cboCustomer.SelectedIndex = 0

		dt = objDB.GetAgent
		Me.cboAgent.DataSource = dt
		Me.cboAgent.DisplayMember = "name"
        Me.cboAgent.ValueMember = "agcd"

        dt = objDB.GetDesign
        Me.cboDesignNo.DataSource = dt
        Me.cboDesignNo.DisplayMember = "Design_no"
        Me.cboDesignNo.ValueMember = "Design_no"
        Me.cboDesignNo.SelectedIndex = -1

        ' Populate month combo
        Dim monthNames() As String = {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน",
                                      "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"}
        cboPeriodMonth.Items.Clear()
        cboPeriodMonth.Items.Add("- เลือกงวด -")
        For i As Integer = 0 To 11
            cboPeriodMonth.Items.Add(monthNames(i))
        Next
        cboPeriodMonth.SelectedIndex = 0

        ' Populate year combo (5 years back to current year)
        cboPeriodYear.Items.Clear()
        Dim currentYear As Integer = Now.Year
        For y As Integer = currentYear To currentYear - 5 Step -1
            cboPeriodYear.Items.Add(y)
        Next
        cboPeriodYear.SelectedItem = currentYear

	End Sub

	Private Sub frmInvoiceExportControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
	End Sub

    Private Sub ApplyPeriod()
        If cboPeriodMonth.SelectedIndex <= 0 Then Exit Sub
        Dim month As Integer = cboPeriodMonth.SelectedIndex ' index 1 = มกราคม = month 1
        Dim year As Integer = CInt(cboPeriodYear.SelectedItem)
        Dim firstDay As New DateTime(year, month, 1)
        Dim lastDay As New DateTime(year, month, DateTime.DaysInMonth(year, month))
        dtpDateFr.Value = firstDay
        dtpDateTo.Value = lastDay
    End Sub

    Private Sub cboPeriodMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodMonth.SelectedIndexChanged
        ApplyPeriod()
    End Sub

    Private Sub cboPeriodYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodYear.SelectedIndexChanged
        ApplyPeriod()
    End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptInvExportControl.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
		Dim frm As New frmReport
		Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
		Me.Cursor = Cursors.WaitCursor
		rpt.Load(clsUser.ReportPath & rptFileName)
		rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
		rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
		rpt.VerifyDatabase()
		rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
		rpt.SetParameterValue("@custcd", cboCustomer.SelectedValue)
		rpt.SetParameterValue("@agcd", cboAgent.SelectedValue)
        rpt.SetParameterValue("@Design_no", cboDesignNo.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

		frm.Title = "Export Invoice Control"
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
