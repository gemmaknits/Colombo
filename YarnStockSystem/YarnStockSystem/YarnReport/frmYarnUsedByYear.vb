Public Class frmYarnUsedByYear
    Dim empcd As String = ""
    Dim clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property loginEmpcd() As String
        Get
            loginEmpcd = empcd
        End Get
        Set(ByVal NewValue As String)
            empcd = NewValue
        End Set
    End Property

    Private Sub ResizeCRV()
        crvYarnUsed.Top = 40
        crvYarnUsed.Left = 8
        crvYarnUsed.Height = Me.Height - 83
        crvYarnUsed.Width = Me.Width - 25
    End Sub

    Private Sub frmYarnUsedByYear_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call ResizeCRV()
    End Sub

    Private Sub frmYarnUsedByYear_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Call ResizeCRV()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptYarnUsedByYear.rpt"
        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        clsConfig.ChangeCulture()

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@year", dtpPrint.Value.ToString("yyyy"))
        rpt.SetParameterValue("@itcd", txtYarnCode.Text.Trim)
        rpt.SetParameterValue("@logempcd", loginEmpcd)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Yarn Usage Summary"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub
End Class