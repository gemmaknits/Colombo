Public Class frmStockSampleAging
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

    Private Sub frmStockSampleAging_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDesignNo.Focus()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptFileName = IIf(optDesignNo.Checked, "rptStockSAging.rpt", "rptStockSAging2.rpt")
        Dim classCn As New ClassConnection
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(classCn.servername, classCn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.Userid, classCn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@design_no", txtDesignNo.Text)
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Stock Sample Aging"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class