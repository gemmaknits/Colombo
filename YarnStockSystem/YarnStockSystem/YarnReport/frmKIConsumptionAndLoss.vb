Public Class frmKIConsumptionAndLoss

    Dim clsUser As New classUserInfo


    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim frm As New frmReport
        Dim rptFileName As String = "rptKIConsumptionAndLoss.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim clsConn As New classConnection
        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.SetParameterValue("@fromdate", DtpFrom.Value.Date)
        rpt.SetParameterValue("@todate", DtpTo.Value.Date)

        frm.Title = "KI Consumption And Loss"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class