Public Class frmGreigeIN
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

        ddlKO.DataSource = objDB.comboKO(clsUser.UserID)
        ddlKO.DisplayMember = "kono"
        ddlKO.ValueMember = "kono"
        ddlKO.SelectedIndex = -1

        CboMcNo.DataSource = objDB.comboMachine(clsUser.UserID)
        CboMcNo.DisplayMember = "mcno"
        CboMcNo.ValueMember = "mcno"
        CboMcNo.SelectedIndex = -1

    End Sub

    Private Sub frmGreigeIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = Now
        dtpDateTo.Value = Now
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptGINByDate.rpt"
        If optMachine.Checked Then rptFileName = "rptGINByMachine.rpt"
        If optKO.Checked Then rptFileName = "rptGINByKO.rpt"

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
        If optKO.Checked Then
            rpt.SetParameterValue("@kono", clsConfig.IsNull(ddlKO.SelectedValue, ""))
        ElseIf optMachine.Checked Then
            rpt.SetParameterValue("@mcno", clsConfig.IsNull(CboMcNo.SelectedValue, ""))
            rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
            rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
            rpt.SetParameterValue("@p_custcd", txtCustCd.Text.Trim) 'Sitthana 20210521
        ElseIf optDate.Checked Then
            rpt.SetParameterValue("@mcno", clsConfig.IsNull(CboMcNo.SelectedValue, ""))
            rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
            rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
            rpt.SetParameterValue("@p_custcd", txtCustCd.Text.Trim) 'Sitthana 20210521
        End If
        
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige IN " & IIf(optDate.Checked, "By Date", IIf(optMachine.Checked, "By Machine", "By K/O"))
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

    Private Sub optDate_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optDate.CheckedChanged
        ddlKO.Enabled = False
        CboMcNo.Enabled = True
        dtpDateFr.Enabled = True
        dtpDateTo.Enabled = True
    End Sub

    Private Sub optMachine_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optMachine.CheckedChanged
        ddlKO.Enabled = False
        CboMcNo.Enabled = True
        dtpDateFr.Enabled = True
        dtpDateTo.Enabled = True
    End Sub

    Private Sub optKO_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optKO.CheckedChanged
        ddlKO.Enabled = True
        CboMcNo.Enabled = False
        dtpDateFr.Enabled = False
        dtpDateTo.Enabled = False
    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        Dim f As New Classes.formSearchCustomer
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult
        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConn.getSQLConnection)
        f.deptcd = ""
        f.logempcd = clsUser.UserID
        f.customerName = ""
        SearchResult = f.ShowCustomers
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            txtCustCd.Text = drv.Item("custcd")
            txtCustName.Text = drv.Item("name")
        End If
    End Sub
End Class