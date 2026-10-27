Public Class frmPODocument



    Private Sub frmPODocument_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
       
    End Sub

    'Private Sub print()
    '    Dim rptFileName = "rptYarnINPurchased.rpt"

    '    If clsUser.ReportPath = "" Then clsUser.ReportPath = clsConfig.ReportPath
    '    'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
    '    If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
    '    Dim frm As New frmReport
    '    Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    Dim stype As String = ""
    '    Dim ord As String = ""
    '    Me.Cursor = Cursors.WaitCursor

    '    rpt.Load(clsUser.ReportPath & rptFileName)
    '    rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.DatabaseName, False)
    '    rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
    '    rpt.VerifyDatabase()
    '    rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
    '    rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
    '    rpt.SetParameterValue("@logempcd", clsUser.UserID)

    '    'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
    '    'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
    '    'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

    '    frm.Title = "Yarn IN Purchased"
    '    frm.CRViewer.ReportSource = rpt
    '    frm.MdiParent = Me.ParentForm
    '    frm.Show()
    '    Me.Cursor = Cursors.Default
    'End Sub
End Class