Public Class frmSalesOrderDeliveryPlan
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

        Me.cboCustomer.DataSource = objDB.comboCustomer(clsUser.UserID)
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.cboSalesPerson.DataSource = objDB.comboEmployee(clsUser.UserID)
        Me.cboSalesPerson.DisplayMember = "empcd"
        Me.cboSalesPerson.ValueMember = "empcd"
        Me.cboSalesPerson.SelectedIndex = -1
        'Me.cboSalesPerson.SelectedValue = clsUser.UserID
    End Sub

    Private Sub frmSalesOrderDeliveryPlan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        If My.Application.Culture.TwoLetterISOLanguageName.ToLower().Equals("th") Then
            txtYear.Text = (Year(Today()) - 543).ToString()
        Else
            txtYear.Text = Year(Today()).ToString()
        End If

        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptSODeliveryPlan.rpt"
        If optDetails.Checked Then rptFileName = "rptSODeliveryPlanDetails.rpt"
        If optCapacity.Checked Then rptFileName = "rptSODeliveryPlanCapacity.rpt"
        Dim clsConfig As New clsConfig

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then Exit Sub

        Dim clsConn As New classConnection
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim frm As New frmReport

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@year", txtYear.Text)
        rpt.SetParameterValue("@sono", txtSONo.Text.Trim)
        rpt.SetParameterValue("@custcd", IIf(cboCustomer.SelectedIndex >= 0, clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim, ""))
        rpt.SetParameterValue("@empcd", IIf(cboSalesPerson.SelectedIndex >= 0, clsConfig.IsNull(cboSalesPerson.SelectedValue, "").ToString.Trim, ""))
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Sales Order Delivery Plan Report"
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
End Class