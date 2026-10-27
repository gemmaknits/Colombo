Public Class frmPreviewQuotation
    Public Quoteno As String
    Public ReportFile As String

    Public Sub setupReport()
        Dim clsUser As New classUserInfo
        Dim clsconfig As New clsConfig
        clsUser.ReportPath = clsUser.ReportPath
        If Quoteno.Length = 0 Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & ReportFile)
        printReport(rpt, Quoteno)
    End Sub
    Private Sub printReport(ByRef rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByVal Quoteno As String)
        Me.CrystalReportViewer1.ReportSource = rpt
        Me.MdiParent = Me.ParentForm

        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor

        logonInfo.ConnectionInfo.ServerName = (New classConnection).servername
        logonInfo.ConnectionInfo.DatabaseName = (New classConnection).database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = (New classConnection).Userid
        logonInfo.ConnectionInfo.Password = (New classConnection).Password

        'rpt.Database.Tables(0).ApplyLogOnInfo(logonInfo)
        rpt.DataSourceConnections.Item(0).SetConnection((New classConnection).servername, (New classConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New classConnection).Userid, (New classConnection).Password)

        rpt.VerifyDatabase()

        rpt.SetParameterValue("@quoteno", quoteno)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'obj.SetDataSource(dt)
        'obj.Subreports(0).SetDataSource(dt)

        Me.Cursor = Cursors.Default

    End Sub

End Class