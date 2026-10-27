Public Class frmGreigeOnhandByDesigns
    Dim clsuser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub btnSearchDFNo_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchDFNo.Click
        Dim frm As New frmSearchDesign
        frm.ShowDialog(Me)
        txtDesignNo.Text = frm.pDesignNo
        frm.Dispose()

    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        'print
        Dim clsconfig As New clsConfig
        Dim clsConn As New classConnection


        If txtDesignNo.Text = "" Then Exit Sub
        Const rptFileName = "rptGreigeOnHandByDesigns.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsuser.ReportPath
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@Design_no", txtDesignNo.Text)
        'rpt.SetParameterValue("@grade", txtGrade.Text)
        rpt.SetParameterValue("@grade", CboGrade.Text)
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige In"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmGreigeOnhandByDesigns_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Gencbo()
    End Sub
    Private Sub Gencbo()
        Dim objdb As New classStockG

        Me.CboGrade.DataSource = objdb.getGradeByGreige
        Me.CboGrade.DisplayMember = "Grade"
        Me.CboGrade.ValueMember = "Grade"
        Me.CboGrade.SelectedIndex = -1
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class