Public Class frmSalesOrderInvoice
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

		Me.cboSoNo.DataSource = objSO.SOLoad()
		Me.cboSoNo.DisplayMember = "sono2"
		Me.cboSoNo.ValueMember = "sono2"
        Me.cboSoNo.SelectedIndex = -1

        Me.ComboSalesPerson1.DataSource = objDB.GetEmp
        Me.ComboSalesPerson1.DisplayMember = "empname"
        Me.ComboSalesPerson1.ValueMember = "empcd"
        Me.ComboSalesPerson1.SelectedValue = clsUser.UserID
    End Sub

	Private Sub frmSaleOrderInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.StartPosition = FormStartPosition.CenterScreen
		dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
		dtpDateTo.Value = Now
		Call GenCombo()
	End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        setupReport()
    End Sub
    Private Sub setupReport()
        Const rptFileName = "rptSO_INV.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then
            'Try
            '    Dim rpt As New rptSO_INV
            '    printReport(rpt)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            'End Try
            Exit Sub
        Else
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            rpt.Load(clsUser.ReportPath & rptFileName)
            printReport(rpt)
        End If
    End Sub
    Private Sub printReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport
        Me.Cursor = Cursors.WaitCursor

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@showclosedinv", IIf(optOption1.Checked, 0, 1))
        rpt.SetParameterValue("@loginEmpcd", clsConfig.IsNull(clsUser.UserID, "").ToString.Trim)
        rpt.SetParameterValue("@salecd", clsConfig.IsNull(ComboSalesPerson1.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)


        'Begin Sitthana 20190312
        'If rbPfPfdColorShowAll.Checked Then
        '    rpt.SetParameterValue("@p_pfe_pfd_color", "All")
        'ElseIf rbPfPfdColorShowPFE.Checked Then
        '    rpt.SetParameterValue("@p_pfe_pfd_color", "PFE")
        'ElseIf rbPfPfdColorShowPFD.Checked Then
        '    rpt.SetParameterValue("@p_pfe_pfd_color", "PFD")
        'ElseIf rbPfPfdColorShowColor.Checked Then
        '    rpt.SetParameterValue("@p_pfe_pfd_color", "COLOR")
        'ElseIf rbPfPfdColorShowEmpty.Checked Then
        '    rpt.SetParameterValue("@p_pfe_pfd_color", "")
        'End If
        'End Sitthana 20190312


        If Me.optOrderFilterAll.Checked Then rpt.SetParameterValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then rpt.SetParameterValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then rpt.SetParameterValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then rpt.SetParameterValue("@orderfilter", "MTO")

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Sales Order"
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

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class