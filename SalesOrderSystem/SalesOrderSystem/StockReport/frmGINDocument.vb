Public Class frmGINDocument
    Dim clsConn As New ClassConnection
    Dim oConfig As New clsConfig
    Dim clsUser As New classUserInfo
    Dim dbStockG As New classStockG

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGIN.rpt"
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
        rpt.SetParameterValue("@trannofr", oConfig.IsNull(cboGINNOfr.SelectedValue, ""))
        rpt.SetParameterValue("@trannoto", oConfig.IsNull(cboGINNOto.SelectedValue, "")) 'oConfig.IsNull(cboGINNOto.SelectedValue, ""))
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "GIN Document"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.Tag = ""
        Me.Show()
        Me.WindowState = FormWindowState.Minimized

    End Sub


    Private Sub txtDINNO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call btnPrint_Click(sender, e)
        End If
    End Sub

    Private Sub txtDINNO_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub frmDINDocument_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GenCombo()
    End Sub
    Private Sub GenCombo()
        Dim Objdb As New DataTable
        Dim Objdb2 As New DataTable
        Dim Count As New Integer
        Objdb = dbStockG.GetComboGin("GR", "")
        Objdb2 = dbStockG.GetComboGin("GR", "")
        Count = Objdb.Rows.Count

        cboGINNOfr.DataSource = Objdb
        cboGINNOfr.DisplayMember = "docno"
        cboGINNOfr.ValueMember = "docno"

        cboGINNOto.DataSource = Objdb2
        cboGINNOto.DisplayMember = "docno"
        cboGINNOto.ValueMember = "docno"

    End Sub


End Class