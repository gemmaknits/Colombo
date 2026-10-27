Public Class frmRDSsProductionReport
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

    Private Sub frmRDSsProductionReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        genCombo()
    End Sub
    Private Sub genCombo()
        Dim objDB As New classMaster

        cmbMcNo.DataSource = objDB.GetMachine("")
        cmbMcNo.DisplayMember = "mcdesc"
        cmbMcNo.ValueMember = "mcno"
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = ""

        If rbGrpByMachineNo.Checked Then
            rptFileName = "rptCustRevenueTarget.rpt"
        ElseIf rbGrpByDate.Checked Then
            rptFileName = "rptCustRevenueTarget_ByDate.rpt"
        End If

        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
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
        If cmbMcNo.Text.Trim = "" Or cmbMcNo.Text.Trim.ToUpper = "NONE" Then
            rpt.SetParameterValue("@p_mcno", "")
            rpt.SetParameterValue("@p_mcno", "", "rptCustRevenueTargetSub.rpt")
        Else
            rpt.SetParameterValue("@p_mcno", cmbMcNo.SelectedValue)
            rpt.SetParameterValue("@p_mcno", cmbMcNo.SelectedValue, "rptCustRevenueTargetSub.rpt")
        End If

        If cmbMonth.SelectedIndex = -1 Then
            rpt.SetParameterValue("@p_month", "")
            rpt.SetParameterValue("@p_month", "", "rptCustRevenueTargetSub.rpt")
        Else
            rpt.SetParameterValue("@p_month", cmbMonth.AutoCompleteCustomSource.Item(cmbMonth.SelectedIndex))
            rpt.SetParameterValue("@p_month", cmbMonth.AutoCompleteCustomSource.Item(cmbMonth.SelectedIndex), "rptCustRevenueTargetSub.rpt")
        End If

        rpt.SetParameterValue("@p_year", txtYear.Text.Trim)
        rpt.SetParameterValue("@p_year", txtYear.Text.Trim, "rptCustRevenueTargetSub.rpt")
        'rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "Find Design From Yarn Report"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.CRViewer.ShowRefreshButton = True
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class