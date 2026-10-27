Public Class frmYarnLostByKO

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Dim kono As String
    Dim fromDate As String
    Dim toDate As String
    Dim inclKIClosedAtProduction As Integer
    Dim inclKIClosedAtDelivery As Integer
    Dim rptFilename As String
    Dim reportPath As String
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Private Sub setupReport()
        rptFilename = "rptYarnLostByKO.rpt"
        If reportPath = "" Then reportPath = clsuser.reportpath
        If Not clsConfig.CheckReport(clsuser.reportpath, rptFilename, False) Then
            Try
                Dim rptFileName As String = "rptYarnLostByKO.rpt"
                Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rpt.Load(clsuser.reportpath & rptFileName)
                'Dim rpt As New rptKIConsumption
                printReport(rpt)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        Else

            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsuser.reportpath & rptFilename)
            printReport(rpt)
        End If
    End Sub

    Private Sub printReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", textKono.Text.Trim)
        rpt.SetParameterValue("@datefr", dtpFromDate.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpToDate.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@isClosedDate", IIf(optKIClosedDate.Checked, 1, 0))
        rpt.SetParameterValue("@ShowOnlyClosedKO", IIf(chkClosedKO.Checked, 1, 0))
        rpt.SetParameterValue("@ShowOnlyPendingKO", IIf(chkPendingKO.Checked, 1, 0))

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Yarn Lost By K/O"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        setupReport()
    End Sub
End Class