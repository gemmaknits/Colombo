Public Class frmDINDocument
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


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptDIN.rpt"
        
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
        rpt.SetParameterValue("@dinno", txtDINNO.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "DIN Document"
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

    Private Sub btnSearchDIN_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchDIN.Click
        Dim frm As New frmSearchDIN
        frm.pStockType = "D"
        frm.ShowDialog(Me)
        'Call btnNew_Click(sender, e)
        txtDINNO.Text = (frm.pDINno.Trim)
        Me.Cursor = Cursors.WaitCursor
        'If Not blnCancel Then GetREQD(txtDINNO.Text)
        Me.Cursor = Cursors.Default
        frm.Dispose()
        txtDINNO.Focus()
    End Sub

    Private Sub txtDINNO_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtDINNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnPrint_Click(sender, e)
        End If
    End Sub

    Private Sub txtDINNO_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDINNO.TextChanged

    End Sub

    Private Sub frmDINDocument_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class