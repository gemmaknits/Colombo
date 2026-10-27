Public Class frmKOOntime
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
        Dim rptFileName
        If OptOnTime.Checked = True Then
            rptFileName = "rptKOOntimeByMC.rpt"

        ElseIf OptWaitTime.Checked = True Then
            rptFileName = "rptKOWaittimeByMC.rpt"

        ElseIf OptAllTime.Checked = True Then
            rptFileName = "rptKOAlltimeBYMC.rpt"
        Else
            rptFileName = "rptKOAlltimeBYMC.rpt"
        End If


        ' Const rptFileName = "rptKOOntimeByMC.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
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
        rpt.SetParameterValue("@mcno", (New clsConfig).IsNull(cbomc.SelectedValue, ""))
        rpt.SetParameterValue("@custcd", (New clsConfig).IsNull(cboCustomer.SelectedValue, ""))
        'rpt.SetParameterValue("@time_type", IIf(OptOnTime.Checked, 2, IIf(OptWaitTime.Checked, 1, 3)))
        'rpt.SetParameterValue("@logempcd", clsConfig.IsNull(clsUser.UserID, ""))

        frm.Title = "K/O Ontime By Mc"
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

    Private Sub frmKOPending_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call GenCbo()
    End Sub
    Private Sub GenCbo()
        Dim objdb As New classMaster
        'Dim dt As DataTable = objdb.comboMachine(clsUser.UserID)
        Me.cbomc.DataSource = objdb.comboMachine(clsUser.UserID)
        Me.cbomc.DisplayMember = "mcno"
        Me.cbomc.ValueMember = "mcno"
        Me.cbomc.SelectedIndex = -1

        Me.cboCustomer.DataSource = objdb.comboCustomer(clsUser.UserID)
        Me.cboCustomer.DisplayMember = "name2"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

    End Sub
End Class