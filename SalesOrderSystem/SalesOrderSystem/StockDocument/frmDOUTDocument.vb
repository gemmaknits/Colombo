Public Class frmDOUTDocument

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
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "rptDOUT.rpt"

        If OptDesignNo.Checked Then
            rptFileName = "rptDOUTByDesign.rpt"
        ElseIf OptLotNo.Checked Then
            rptFileName = "rptDOUT.rpt"
        End If

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
        rpt.SetParameterValue("@outno", txtOUTNO.Text)

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

    Private Sub btnSearchOutno_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchOutno.Click
        Dim frm As New frmSearchDOUT
        frm.pStockType = "D"
        frm.pDoctype = "M"
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        txtOutNo.Text = (frm.pOutno)
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then btnPrint_Click(sender, e)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtOUTNO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtOUTNO.KeyDown
        If Keys.KeyCode = Keys.Enter Then
            btnPrint_Click(sender, e)
        End If
    End Sub

    Private Sub txtOUTNO_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtOUTNO.TextChanged

    End Sub

    Private Sub frmDOUTDocument_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class