Imports System.ComponentModel

Public Class frmrptCMRList
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmrptCMRList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ConfirmExitPrg() = False Then
            e.Cancel = True
        End If
    End Sub
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
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintReport("rptCMRList.rpt")
    End Sub
    Private Sub PrintReport(p_RptName As String)
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, p_RptName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & p_RptName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@p_datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@p_dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        If rdShowOnlyCMRNo.Checked Then
            rpt.SetParameterValue("p_ShowDetail", False)
        Else
            rpt.SetParameterValue("p_ShowDetail", True)
        End If

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "CMR List"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmrptCMRList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
    End Sub
    Private Sub InitForm()
        'Set Center form
        Dim boundWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim boundHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim x As Integer = boundWidth - Me.Width
        Dim y As Integer = boundHeight - Me.Height
        Me.Location = New Point(x / 2, y / 2)
    End Sub


End Class