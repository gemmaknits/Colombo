Public Class frmGreigeOnhandAging
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

    Private Sub GenCombo()
        Dim dt As DataTable = New classMaster().comboEmployee("")
        ddlSalesPerson.DataSource = dt
        ddlSalesPerson.DisplayMember = "empname"
        ddlSalesPerson.ValueMember = "empcd"
        ddlSalesPerson.SelectedIndex = -1
    End Sub

    Private Sub frmGreigeOnhandAging_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptGreigeOnhandAgingBySales.rpt"
        If optDesign.Checked Then rptFileName = "rptGreigeOnhandAgingByDesign.rpt"

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@empcd", clsConfig.IsNull(ddlSalesPerson.SelectedValue, ""))
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        rpt.SetParameterValue("@grade", txtGrade.Text.Trim)

        If optSalesPerson.Checked Then
            rpt.SetParameterValue("@order", "SALES")
        Else
            rpt.SetParameterValue("@order", "DESIGN")
        End If

        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@logempcd", clsUser.UserID)
        
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Onhand Aging By " & IIf(optSalesPerson.Checked, "Sales", "Design")
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