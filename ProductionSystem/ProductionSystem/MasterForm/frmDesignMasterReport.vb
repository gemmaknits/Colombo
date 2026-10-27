Public Class frmDesignMasterReport
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
        Dim objDB As New classMaster

        Me.cboDesignNo.DataSource = objDB.GetDesign
        Me.cboDesignNo.DisplayMember = "design_no"
        Me.cboDesignNo.ValueMember = "design_no"
        Me.cboDesignNo.SelectedIndex = -1
    End Sub

    Private Sub frmDesignMasterReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptDesignMaster2.rpt"
        ' 'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
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
        rpt.SetParameterValue("@design_no", clsConfig.IsNull(cboDesignNo.SelectedValue, ""))

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Design Master"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class