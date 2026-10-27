Public Class frmExpInvoiceCommision
    'Writen By      : Sitthana
    'Writen Date    : 20210901

#Region "Properties"
    Private clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
#End Region

    'Local Variable
    Private clsConn As New classConnection
    Private clsConfig As New clsConfig

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmExpInvoiceCommision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDateFr.Value = Today
        dtpDateTo.Value = Today
    End Sub
    Private Sub bthSelectEmp_Click(sender As Object, e As EventArgs) Handles bthSelectEmp.Click

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If rbLocalInv.Checked Then
            PrintReport("rptSOLocalInvCommision.rpt")
        Else
            PrintReport("rptSOExpInvCommision.rpt")
        End If
    End Sub

    Private Sub PrintReport(pRptFileName As String)
        If clsUser.ReportPath = "" Then
            clsUser.ReportPath = clsUser.ReportPath
        End If

        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & pRptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@p_invdt_from", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@p_invdt_to", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@p_emp_code", txtEmpCode.Text.Trim)
        rpt.SetParameterValue("@p_month_name", MonthName(Month(dtpDateFr.Value)))
        rpt.SetParameterValue("@p_year", Year(dtpDateFr.Value))

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        Dim frm As New frmReport
        frm.Title = "Invoice Master"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub
End Class