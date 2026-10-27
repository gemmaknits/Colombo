Imports System.Windows.Forms

Public Class frmDeadStockBalanceYarn
    'Writen By  : Sitthana Boonlom
    'Writen Date    : 20241216

#Region "Properties"
    Dim ReportBy As String = ""


    Public Property pReportBy() As String
        Get
            pReportBy = ReportBy
        End Get
        Set(ByVal NewValue As String)
            ReportBy = NewValue
        End Set
    End Property
#End Region

    Private clsConn As New classConnection
    Private clsUser As New classUserInfo

    Private clsConfig As New clsConfig

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

    Private Sub frmDeadStockBalanceYarn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nmudFromYear.Value = Year(Today)
        nmudToYear.Value = Year(Today)
        tsstlblReportBy.Text = "Report By : " & ReportBy
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintReport("rptDeadStockBalanceYarn.rpt")
    End Sub

    Private Sub PrintReport(pRptName As String)
        If clsUser.ReportPath = "" Then
            clsUser.ReportPath = clsuser.reportpath
        End If

        If Not clsConfig.CheckReport(clsUser.ReportPath, pRptName) Then
            Exit Sub
        End If

        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptName)

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)

        'Parameter For Stored Procedure
        rpt.SetParameterValue("@p_year_from", nmudFromYear.Value)
        rpt.SetParameterValue("@p_year_to", nmudToYear.Value)
        If rbYRA.Checked Then
            rpt.SetParameterValue("@p_ittype", "YRA")
        Else
            rpt.SetParameterValue("@p_ittype", "YBM")
        End If

        'rpt.SetParameterValue("@logempcd", logempcd)

        frm.Title = "Dead Stock Balance - Yarn"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class