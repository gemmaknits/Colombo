Public Class frmYarnOnTime
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName
        If OptOnTime.Checked = True Then
            rptFileName = "rptYarnExpectedReturnByMc.rpt"

        ElseIf OptWaitTime.Checked = True Then
            rptFileName = "rptYarnExpectedReturnByMc.rpt"

        ElseIf OptAllTime.Checked = True Then
            rptFileName = "rptYarnExpectedReturnByMc.rpt"
        Else
            rptFileName = "rptYarnExpectedReturnByMc.rpt"
        End If



        ' Dim rptFileName = "rptYarnExpectedReturnByMc.rpt"

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsuser.reportpath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@mcno", cbomcno.SelectedValue)
        'rpt.SetParameterValue("@logempcd", clsUser.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Yarn ON Time"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmYarnOnTime_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        gencbo()
    End Sub
    Private Sub gencbo()
        Dim objdb As New classMaster

        Me.cbomcno.DataSource = objdb.GetMCNO
        Me.cbomcno.DisplayMember = "mcno"
        Me.cbomcno.ValueMember = "mcno"
        Me.cbomcno.SelectedIndex = -1
        'Me.cbomcno.Items.Add("1")
        'With cbomcno
        'Me.cbomcno.Items.Add("")

        ' End With
    End Sub
End Class