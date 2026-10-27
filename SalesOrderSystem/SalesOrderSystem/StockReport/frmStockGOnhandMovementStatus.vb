Public Class frmStockGOnhandMovementStatus
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

        Me.cboSalesPerson.DataSource = objDB.comboEmployee(clsUser.UserID)
        Me.cboSalesPerson.DisplayMember = "empname2"
        Me.cboSalesPerson.ValueMember = "empcd"
        Me.cboSalesPerson.SelectedIndex = -1
        'Me.cboSalesPerson.SelectedValue = clsUser.UserID
    End Sub

    Private Sub frmStockGOnhandMovementStatus_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptGreigeOnhandBySO.rpt"
        If optDesignNo.Checked Then rptFileName = "rptGreigeOnhandBySO2.rpt"
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
        'rpt.SetParameterValue("@empcd", "")
        rpt.SetParameterValue("@empcd", IIf(cboSalesPerson.SelectedIndex >= 0, clsConfig.IsNull(cboSalesPerson.SelectedValue, "").ToString.Trim, ""))
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim())
        rpt.SetParameterValue("@grade", txtGrade.Text.Trim())
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Greige Onhand By S/O"
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