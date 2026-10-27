Public Class frmPrintPO
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

    Private Sub buttonSearchPO_Click(sender As Object, e As EventArgs) Handles buttonSearchPO.Click
        Dim frm As New formSearchPO
        frm.ShowDialog()
        If frm.puserAction = "OK" Then
            Me.txtPurNo.Text = frm.pSelectedPO

        End If
    End Sub

    Private Sub A4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles A4ToolStripMenuItem.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurNo.Text.Trim


        rptFileName = "RptPurchaseOrderCreateTH.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)


        frm.Title = "PurchaseOrder"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ENToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENToolStripMenuItem.Click
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String
        Dim jobno As String = ""
        Dim docno As String = txtPurNo.Text.Trim

        rptFileName = "RptPurchaseOrderCreate.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            rpt.Load(clsUser.ReportPath & rptFileName)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            rpt.VerifyDatabase()
            rpt.SetParameterValue("@jobno", docno)


            frm.Title = "PurchaseOrder"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
End Class