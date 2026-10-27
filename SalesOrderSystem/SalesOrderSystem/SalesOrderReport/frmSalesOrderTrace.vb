Public Class frmSalesOrderTrace
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

        Me.cboSONo.DataSource = objDB.comboSO2(clsUser.UserID)
        Me.cboSONo.DisplayMember = "so_cust"
        Me.cboSONo.ValueMember = "sono"
        Me.cboSONo.SelectedIndex = -1

        Me.cboCustomer.DataSource = objDB.comboCustomer(clsUser.UserID)
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.cboSalesPerson.DataSource = objDB.comboEmployee(clsUser.UserID)
        Me.cboSalesPerson.DisplayMember = "empcd"
        Me.cboSalesPerson.ValueMember = "empcd"
        Me.cboSalesPerson.SelectedIndex = -1
        'Me.cboSalesPerson.SelectedValue = clsUser.UserID
    End Sub

    Private Sub frmSalesOrderTrace_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptSOTrace.rpt"
        If (optCustomerName.Checked) Then rptFileName = "rptSOTraceByCustomer.rpt"
        Dim clsConfig As New clsConfig

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then Exit Sub

        Dim clsConn As New classConnection
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim frm As New frmReport

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@sono", IIf(cboSONo.SelectedIndex >= 0, clsConfig.IsNull(cboSONo.SelectedValue, "").ToString.Trim, ""))
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@custcd", IIf(cboCustomer.SelectedIndex >= 0, clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim, ""))
        rpt.SetParameterValue("@empcd", IIf(cboSalesPerson.SelectedIndex >= 0, clsConfig.IsNull(cboSalesPerson.SelectedValue, "").ToString.Trim, ""))
        rpt.SetParameterValue("@showonlypending", IIf(chkShowOnlyPending.Checked, 1, 0))
        rpt.SetParameterValue("@loginempcd", "")
        'Disible By Neung 04/02/2015
        'rpt.SetParameterValue("@loginempcd", clsUser.UserID)

        frm.Title = "Sales Order Trace Report"
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

    Private Sub cboSONo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboSONo.SelectedIndexChanged

    End Sub
End Class