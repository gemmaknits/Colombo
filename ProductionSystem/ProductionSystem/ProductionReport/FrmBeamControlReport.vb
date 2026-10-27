Public Class FrmBeamControlReport
    Dim clsUser As New classUserInfo
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig

    Private WOStartDtFrom As String = ""
    Private WOStartDtTo As String = ""

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub FrmBeamControlReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenCbo()
    End Sub
    Private Sub GenCbo()
        Dim objdb As New classMaster
        'Dim dt As DataTable = objdb.comboMachine(clsUser.UserID)
        cbomc.DataSource = objdb.comboMachine(clsUser.UserID)
        cbomc.DisplayMember = "mcno"
        cbomc.ValueMember = "mcno"
        cbomc.SelectedIndex = 0
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim ReportFileName As String = "rptBeamControl.rpt"

        'Check
        ' If clsUser.ReportPath = "" Then
        '    clsUser.ReportPath = clsConfig.ReportPath
        ' End If
        If Not clsConfig.CheckReport(clsUser.ReportPath, ReportFileName) Then
            Exit Sub
        End If

        'Init Report
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor

        If rbGrpByWoNo.Checked Then
            ReportFileName = "rptBeamControl.rpt"
        ElseIf rbGrpByMCNo.Checked Then
            ReportFileName = "rptBeamControlGrpByMcNo.rpt"
        Else
            ReportFileName = "rptBeamControl.rpt"
        End If
        rpt.Load(clsUser.ReportPath & ReportFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@p_production_order_no_from", txtKONoFrom.Text.Trim)
        If txtKONoTo.Text.Trim = "" Then
            rpt.SetParameterValue("@p_production_order_no_to", txtKONoFrom.Text.Trim)
        Else
            rpt.SetParameterValue("@p_production_order_no_to", txtKONoTo.Text.Trim)
        End If

        If dtpKODtFrom.Checked And dtpKODtTo.Checked Then
            If dtpKODtFrom.Value > dtpKODtTo.Value Then
                Dim KoDttmp As Date = dtpKODtFrom.Value
                dtpKODtFrom.Value = dtpKODtTo.Value
                dtpKODtTo.Value = KoDttmp
            End If
        End If
        If dtpKODtFrom.Checked Then
            rpt.SetParameterValue("@p_warp_end_date_from", Format(dtpKODtFrom.Value, "yyyyMMdd"))
            If dtpKODtTo.Checked Then
                rpt.SetParameterValue("@p_warp_end_date_to", Format(dtpKODtTo.Value, "yyyyMMdd"))
            Else
                rpt.SetParameterValue("@p_warp_end_date_to", Format(dtpKODtFrom.Value, "yyyyMMdd"))
            End If
        Else
            rpt.SetParameterValue("@p_warp_end_date_from", "")
            rpt.SetParameterValue("@p_warp_end_date_to", "")
        End If
        rpt.SetParameterValue("@p_mcno", cbomc.SelectedValue)

        'Call Report
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub txtKONoFrom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKONoFrom.KeyPress

    End Sub
End Class