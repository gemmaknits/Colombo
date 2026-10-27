Public Class frmGOUTDocument

    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo
    Dim blnCancel As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        If txtOUTNOFR.Text = "" Then txtOUTNOFR.Text = txtOUTNOTO.Text 'Add By Neung 20151031
        If txtOUTNOTO.Text = "" Then txtOUTNOTO.Text = txtOUTNOFR.Text 'Add By Neung 20151031

        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGOUT.rpt"
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
        rpt.SetParameterValue("@outnofr", txtOUTNOFR.Text)
        rpt.SetParameterValue("@outnoto", txtOUTNOTO.Text)
        rpt.SetParameterValue("@outdtfr", Format(dtpoutdtfr.Value, "yyyymmdd"))
        rpt.SetParameterValue("@outdtto", Format(dtpoutdtto.Value, "YYYYmmDD"))
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DOUT Document"
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

    Private Sub btnSearchOutnofr_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutnofr.Click
        Dim frm As New frmSearchGOUT
        frm.pStockType = "G"
        frm.pDoctype = ""
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        txtOUTNOFR.Text = (frm.pOutno)

        'If txtOUTNOTO.Text = "" Then txtOUTNOTO.Text = txtOUTNOFR.Text

        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then btnPrint_Click(sender, e)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtOUTNO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOUTNOFR.KeyDown
        If Keys.KeyCode = Keys.Enter Then
            btnPrint_Click(sender, e)
        End If
    End Sub

    Private Sub btnSearchOutnoto_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutnoto.Click
        Dim frm As New frmSearchGOUT
        frm.pStockType = "G"
        frm.pDoctype = ""
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        txtOUTNOTO.Text = (frm.pOutno)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then btnPrint_Click(sender, e)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub dtpoutdtto_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpoutdtto.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub chkOutdt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOutdt.CheckedChanged
        'If chkOutdt.Checked = True Then
        '    dtpoutdtfr.Visible = True
        '    dtpoutdtto.Visible = True
        'ElseIf chkOutdt.Checked = False Then
        '    dtpoutdtfr.Visible = False
        '    dtpoutdtto.Visible = False
        'End If
    End Sub

    Private Sub frmGOUTDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class