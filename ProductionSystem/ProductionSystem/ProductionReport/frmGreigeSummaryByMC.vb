Public Class frmGreigeSummaryByMC
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

    Private Sub frmGreigeSummaryByMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        genCombo()
    End Sub
    Private Sub genCombo()
        Dim objDB As New classMaster

        cmbMcNo.DataSource = objDB.GetMachine("")
        cmbMcNo.DisplayMember = "mcdesc"
        cmbMcNo.ValueMember = "mcno"
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptGreigeInOutByMC.rpt"
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
        'rpt.VerifyDatabase() 'Comment By Sitthana 20191107
        If cmbMcNo.Text.Trim = "" Or cmbMcNo.Text.Trim.ToUpper = "NONE" Then
            rpt.SetParameterValue("@p_mcno", "")
        Else
            rpt.SetParameterValue("@p_mcno", cmbMcNo.SelectedValue)
        End If
        rpt.SetParameterValue("@p_datefr", Format(dtpFromDate.Value, "yyyyMMdd"))
        rpt.SetParameterValue("@p_dateto", Format(dtpToDate.Value, "yyyyMMdd"))

        'If cmbMonth.SelectedIndex = -1 Then
        '    rpt.SetParameterValue("@p_month", "")
        'Else
        '    rpt.SetParameterValue("@p_month", cmbMonth.AutoCompleteCustomSource.Item(cmbMonth.SelectedIndex))
        'End If

        'rpt.SetParameterValue("@p_year", txtYear.Text.Trim)
        'rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "RDS's  Production  Report"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class