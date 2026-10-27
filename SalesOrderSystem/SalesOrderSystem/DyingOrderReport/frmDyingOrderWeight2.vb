Public Class frmDyingOrderWeight2
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

        Me.cboCustomer.DataSource = objDB.GetCustomer()
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.cboDyedHouse.DataSource = objDB.GetDyedHouse()
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd"
        Me.cboDyedHouse.SelectedIndex = -1

        Me.cboOwner.DataSource = objDB.GetEmp()
        Me.cboOwner.DisplayMember = "empname"
        Me.cboOwner.ValueMember = "empcd"
        Me.cboOwner.SelectedIndex = -1
    End Sub

    Private Sub frmDyingOrderWeight2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptDFOrderWeightControl.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dfno", txtDFNo.Text)
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@sono", txtSONo.Text)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@dhcod", clsConfig.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@design_no", txtDesignNo.Text)
        rpt.SetParameterValue("@empcd", clsConfig.IsNull(cboOwner.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@logempcd", clsUser.UserID)
        
        frm.Title = "D/F Weight Control"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class