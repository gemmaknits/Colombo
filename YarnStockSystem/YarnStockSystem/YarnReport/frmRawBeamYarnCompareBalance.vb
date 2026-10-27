Public Class frmRawBeamYarnCompareBalance
    'Writen By  : Sitthana 20191130

#Region "Property"
    Private _clsUser As classUserInfo

    Public Property clsUser As classUserInfo
        Get
            clsUser = _clsUser
        End Get
        Set(ByVal Newvalue As classUserInfo)
            _clsUser = Newvalue
        End Set
    End Property
#End Region

    '#Class Variable
    Private clsConnection As New classConnection
    Private clsConfig As New clsConfig

    Private Sub frmRawBeamYarnCompareBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printReport("rptYarnbalanceByYearInOneGraph.rpt")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    '#Report
    Private Sub printReport(pReportName As String)
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If clsUser.ReportPath = "" Then
            clsUser.ReportPath = "\\172.16.3.11\Reports\" 'clsConf.ReportPath
        End If

        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportName) Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim FirstYarnType As String = ""
        Dim SecondYarnType As String = ""
        If rbYRA.Checked Then
            FirstYarnType = "YRA"
            SecondYarnType = "YRA"
        ElseIf rbYBM.Checked Then
            FirstYarnType = "YBM"
            SecondYarnType = "YBM"
        Else
            FirstYarnType = "YRA"
            SecondYarnType = "YBM"
        End If

        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConnection.ServerName, clsConnection.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConnection.UserName, clsConnection.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@p_from_year", Format(dtpFromYear.Value, "yyyy"))
        rpt.SetParameterValue("@p_to_year", Format(dtpToYear.Value, "yyyy"))
        rpt.SetParameterValue("@p_first_yarn_type", FirstYarnType)
        rpt.SetParameterValue("@p_second_yarn_type", SecondYarnType)
        rpt.SetParameterValue("@p_logempcd", clsUser.UserID)

        frm.Title = "Raw / Beam  Yarn Compare Balance"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub
End Class