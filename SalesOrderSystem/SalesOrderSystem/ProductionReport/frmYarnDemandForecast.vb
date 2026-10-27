Public Class frmYarnDemandForecast
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
        Dim objDB As New classProduction

        ddlKO.DataSource = objDB.comboKO
        ddlKO.DisplayMember = "kono"
        ddlKO.ValueMember = "kono"
        ddlKO.SelectedIndex = -1

        ddlSO.DataSource = objDB.comboSO
        ddlSO.DisplayMember = "sono"
        ddlSO.ValueMember = "sono"
        ddlSO.SelectedIndex = -1

        ddlDesignNo.DataSource = objDB.comboDesignNo
        ddlDesignNo.DisplayMember = "design_no"
        ddlDesignNo.ValueMember = "design_no"
        ddlDesignNo.SelectedIndex = -1

        ddlMachineNo.DataSource = objDB.comboMachine
        ddlMachineNo.DisplayMember = "mcno"
        ddlMachineNo.ValueMember = "mcno"
        ddlMachineNo.SelectedIndex = -1

        ddlYarnCode.DataSource = objDB.comboYarnCode
        ddlYarnCode.DisplayMember = "itcd"
        ddlYarnCode.ValueMember = "itcd"
        ddlYarnCode.SelectedIndex = -1

        ddlSupplier.DataSource = objDB.comboSupplier
        ddlSupplier.DisplayMember = "name"
        ddlSupplier.ValueMember = "suppcd"
        ddlSupplier.SelectedIndex = -1
    End Sub

    Private Sub frmYarnDemandForecast_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call GenCombo()
        ddlKO.Focus()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptYarnDemandForecast.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", clsConfig.IsNull(ddlKO.SelectedValue, ""))
        rpt.SetParameterValue("@sono", clsConfig.IsNull(ddlSO.SelectedValue, ""))
        rpt.SetParameterValue("@design_no", clsConfig.IsNull(ddlDesignNo.SelectedValue, ""))
        rpt.SetParameterValue("@mcno", clsConfig.IsNull(ddlMachineNo.SelectedValue, ""))
        rpt.SetParameterValue("@itcd", clsConfig.IsNull(ddlYarnCode.SelectedValue, ""))
        rpt.SetParameterValue("@suppcd", clsConfig.IsNull(ddlSupplier.SelectedValue, ""))
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "Yarn Demand Forecast"
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