Public Class frmCompanySticker
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub frmCompanySticker_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'test
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = "rptCompanySticker.rpt"
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        rpt.Load(clsuser.reportpath & rptFileName)
        'Dim rpt As New rptCompanySticker
        rpt.DataSourceConnections(0).SetLogon("sa", "sa")
        rpt.ParameterFields(0).AllowCustomValues = True
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@copies", Val(txtCopies.Text))
        crvReport.ReportSource = rpt
        crvReport.Show()
    End Sub

    Private Sub frmCompanySticker_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        crvReport.Top = 40
        crvReport.Left = 0
        crvReport.Height = Me.Height - 83
        crvReport.Width = Me.Width - 25
    End Sub
End Class