Public Class frmDyingOrderPending2
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

        Me.cboCustomer.DataSource = objDB.comboCustomer(clsUser.UserID)
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.cboEmployee.DataSource = objDB.comboSalesPerson(clsUser.UserID)
        Me.cboEmployee.DisplayMember = "empname"
        Me.cboEmployee.ValueMember = "empcd"
        Me.cboEmployee.SelectedIndex = -1
    End Sub

    Private Sub frmDyingOrderPending2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        Dim rptFileName = "rptDFOrderPending2.rpt"
        If optKgs.Checked Then
            rptFileName = "rptDFOrderPending2.rpt"
        ElseIf optmts.Checked Then
            rptFileName = "rptDFOrderPending2Mts.rpt"
        ElseIf optYds.Checked Then
            rptFileName = "rptDFOrderPending2Yds.rpt"
        End If

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
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
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        rpt.SetParameterValue("@empcd", clsConfig.IsNull(cboEmployee.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@show_cost", 0)

        If Me.optDFNo.Checked Then rpt.SetParameterValue("@order_by", "DFNO")
        If Me.optDFDate.Checked Then rpt.SetParameterValue("@order_by", "DFDT")
        If Me.optDesignNo.Checked Then rpt.SetParameterValue("@order_by", "DESIGN")
        If Me.optSONo.Checked Then rpt.SetParameterValue("@order_by", "SONO")
        If Me.optCustomer.Checked Then rpt.SetParameterValue("@order_by", "CUST")

        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "D/F Order Pending 2"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class