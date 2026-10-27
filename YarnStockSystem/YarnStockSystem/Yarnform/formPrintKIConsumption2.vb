Public Class formPrintKIConsumption2
    Dim rptFilename As String
    Dim reportPath As String
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub setupReport()
        rptFilename = "rptKIConsumption3.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFilename, False) Then
            Try
                Dim rptFileName As String = "rptKIConsumption3.rpt"
                Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rpt.Load(clsUser.ReportPath & rptFileName)
                'Dim rpt As New rptKIConsumption
                printReport(rpt)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        Else

            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUser.ReportPath & rptFilename)
            printReport(rpt)
        End If
    End Sub

    Private Sub printReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", textKONo.Text.Trim)
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@mcno", txtMCNo.Text.Trim)
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        rpt.SetParameterValue("@boi", txtBOI.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "K/I & Greige Delivery Control"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        setupReport()
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class