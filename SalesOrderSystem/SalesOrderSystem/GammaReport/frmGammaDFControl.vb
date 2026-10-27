Public Class frmGammaDFControl
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

    Private Sub frmGammaDFControl_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim StartDate As New Date(Year(Today), 1, 1) 'Sitthana 20230824
        dtpStartDate.Value = StartDate 'Sitthana 20230824
        dtpEndDate.Value = DateTime.Today
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Me.Validate()

        Dim rptFileName = "rptGemmaKnitsJobControl.rpt"
        If optShowByRollNo.Checked Then rptFileName = "rptGemmaKnitsDFControl.rpt"
        ' If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        ' rpt.VerifyDatabase() 'Comment by neung 20231130
        rpt.SetParameterValue("@datefr", dtpStartDate.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpEndDate.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dfno", txtDFNo.Text.Trim)
        rpt.SetParameterValue("@jobno", txtJobNo.Text.Trim)
        rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = IIf(optShowByRollNo.Checked, "D/F", "Job") & " Submit At Gamma Dyed House"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class