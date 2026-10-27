Imports System.Windows.Forms

Public Class DlgStockNonMovement
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Dim ReportBy As String = ""

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property pReportBy() As String
        Get
            pReportBy = ReportBy
        End Get
        Set(ByVal NewValue As String)
            ReportBy = NewValue
        End Set
    End Property

    Private Function ConfirmExitPrg() As Boolean
        If MessageBox.Show("คุณยืนยันที่จะออกจาก หน้าต่างพิมพ์รายงาน ใช่หรือไม่ ?" _
                         , "ข้อความยืนยัน", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Question, MessageBoxDefaultButton.Button1
                           ) = vbOK Then
            ConfirmExitPrg = True
        Else
            ConfirmExitPrg = False
        End If
    End Function
    Private Sub DlgStockNonMoving_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If ConfirmExitPrg() = False Then
        '    e.Cancel = True
        'End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If cbShowAverageWeight.Checked Then
            PrintReport("rptYarnNonMovementAvgCost.rpt")
        Else
            PrintReport("rptYarnNonMovement.rpt")
        End If
    End Sub

    Private Sub DlgStockNonMoving_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitForm()
        InitFrmValue()
    End Sub
    Private Sub InitForm()
        'Set Center form
        'Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        'Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        'Dim x As Integer = boundWidth - Me.Width
        'Dim y As Integer = boundHeight - Me.Height
        'Me.Location = New Point(x / 2, y / 2)

    End Sub
    Private Sub InitFrmValue()
        nmupdrYearFrom.Value = Year(Today)
        nmupdrYearTo.Value = Year(Today)
        tsstlblReportBy.Text = "Report By : " & ReportBy
    End Sub
    Private Sub PrintReport(pRptName As String)
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsuser.reportpath
        If Not clsConfig.CheckReport(clsUser.ReportPath, pRptName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        '
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()

        'Parameter For Stored Procedure
        rpt.SetParameterValue("@p_year_from", nmupdrYearFrom.Value)
        rpt.SetParameterValue("@p_year_to", nmupdrYearTo.Value)
        rpt.SetParameterValue("@itcd", "")
        rpt.SetParameterValue("@logempcd", clsUser.UserID)
        rpt.SetParameterValue("@itcd_prefix", IIf(rbtShowOnlyPrefixYRA.Checked, "YRA", IIf(rbtShowOnlyPrefixYBM.Checked, "YBM", "")))

        'Parameter For Report
        rpt.SetParameterValue("pReportBy", ReportBy)
        If rdShowSummary.Checked Then
            rpt.SetParameterValue("pShowDetail", 0)
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        Else
            rpt.SetParameterValue("pShowDetail", 1)
            rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        End If

        'rpt.SetParameterValue("@SortBy", SortBy)

        frm.Title = "รายการ วัตถุดิบที่ไม่มีการเคลื่อนไหว"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub


End Class
