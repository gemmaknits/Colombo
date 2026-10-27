Public Class formRptYarnBalance
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub formRptYarnBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDateTo.Value = Now
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim config As New clsConfig
        config.ChangeCulture()

        Dim frm As New frmReport
        Dim rptFileName As String = "rptYarnBalance2.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsuser.reportpath & rptFileName)
        'Dim rpt As New rptYarnBalance2
        rpt.DataSourceConnections.Item(0).SetLogon("sa", "sa")
        rpt.VerifyDatabase()
        rpt.SetParameterValue(0, "19000101")
        rpt.SetParameterValue(1, dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        frm.MdiParent = Me.MdiParent
        frm.CRViewer.ReportSource = rpt
        frm.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class