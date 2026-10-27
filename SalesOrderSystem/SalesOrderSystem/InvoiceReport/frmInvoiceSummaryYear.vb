Public Class frmInvoiceSummaryYear
    Private clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private clsConn As New classConnection
    Private clsConfig As New clsConfig
    Private clsMstSrchDlg As New ClassMasterSearchDialog

    Private Sub frmInvoiceSummaryYear_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        txtYearFr.Text = Year(DateAdd(DateInterval.Year, -1, Now)).ToString()
        txtYearTo.Text = Year(Now).ToString()
        Call Gencombo()
    End Sub
    Private Sub Gencombo()
        'Me.cboPrintOnly.DataSource = (New classMaster).GetEmp
        'Me.cboPrintOnly.DisplayMember = "empname"
        'Me.cboPrintOnly.ValueMember = "empcd"
        'Me.cboPrintOnly.SelectedValue = clsUser.UserID
    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptInvoiceSummaryYear.rpt"

        '        If optDomestic.Checked Then rptFileName = "rptInvoiceSummaryYearLocal.rpt"
        '        If optExport.Checked Then rptFileName = "rptInvoiceSummaryYearExport.rpt"

        If rbInvoiceYearSummary.Checked Then
            If optDomestic.Checked Then rptFileName = "rptInvoiceSummaryYear.rpt"
            If optExport.Checked Then rptFileName = "rptInvoiceSummaryYear.rpt"
        ElseIf rbInvoiceYearSummaryGrpBySales.Checked Then
            rptFileName = "rptInvoiceSummaryYearGrpBySales.rpt"
        ElseIf rbInvoiceYearSummaryGrpBySalesDesign.Checked Then
            rptFileName = "rptInvoiceSummaryYearGrpBySalesDesign.rpt"
        ElseIf rbInvoiceYearSummaryGrpBySalesYMDesign.Checked Then
            rptFileName = "rptInvoiceSummaryYearGrpBySalesYMDesign.rpt"
        End If


        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub

        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        'rpt.SetParameterValue("@inv_type", "LOC")

        If rbInvoiceYearSummary.Checked Or
           rbInvoiceYearSummaryGrpBySales.Checked Then
            If optDomestic.Checked Then rpt.SetParameterValue("@inv_type", "LOC".ToString.Trim)
            If optExport.Checked Then rpt.SetParameterValue("@inv_type", "EXP".ToString.Trim)
            If optAll.Checked Then rpt.SetParameterValue("@inv_type", "ALL".ToString.Trim)
            If chkExclGMK.Checked Then
                rpt.SetParameterValue("@exclGMK", "Y".ToString.Trim)
            Else
                rpt.SetParameterValue("@exclGMK", "N".ToString.Trim)
            End If
            rpt.SetParameterValue("@year", txtYearFr.Text.Trim)
            rpt.SetParameterValue("@year_to", txtYearTo.Text.Trim)
        ElseIf rbInvoiceYearSummaryGrpBySalesDesign.Checked Or
               rbInvoiceYearSummaryGrpBySalesYMDesign.Checked Then
            If optDomestic.Checked Then rpt.SetParameterValue("@p_inv_type", "LOC".ToString.Trim)
            If optExport.Checked Then rpt.SetParameterValue("@p_inv_type", "EXP".ToString.Trim)
            If optAll.Checked Then rpt.SetParameterValue("@p_inv_type", "ALL".ToString.Trim)
            If chkExclGMK.Checked Then
                rpt.SetParameterValue("@p_exclGMK", "Y".ToString.Trim)
            Else
                rpt.SetParameterValue("@p_exclGMK", "N".ToString.Trim)
            End If
            rpt.SetParameterValue("@p_year_from", txtYearFr.Text.Trim)
            rpt.SetParameterValue("@p_year_to", txtYearTo.Text.Trim)
        End If

        rpt.SetParameterValue("@p_custcd", txtCustomerCode.Text.Trim) 'Sitthana 20211111
        rpt.SetParameterValue("@p_design_no", txtDesignNo.Text.Trim) 'Sitthana 20211126

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Invoice Year Summary"
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

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnGetCustomer_Click(sender As Object, e As EventArgs) Handles btnGetCustomer.Click
        Dim drv As DataRowView

        drv = clsMstSrchDlg.searchCustomer(clsUser.UserName, (New classConnection).getSQLConnection)
        If drv IsNot Nothing Then
            txtCustomerCode.Text = drv.Item("custcd").ToString.Trim
            txtCustomerName.Text = drv.Item("name").ToString.Trim
        End If
    End Sub

    Private Sub btnGetArticle_Click(sender As Object, e As EventArgs) Handles btnGetArticle.Click
        'Dim drv As DataRowView

        'drv = clsMstSrchDlg.searchDesign(clsUser.UserName, (New classConnection).getSQLConnection)
        'If drv IsNot Nothing Then
        '    txtDesignNo.Text = drv.Item("design_no").ToString.Trim
        'End If
        Dim frm As New dlgSearchItemsList
        frm.logempcd = clsUser.UserName

        Dim DesignNo As String = ""
        DesignNo = frm.ShowFrm()

        If DesignNo.Trim <> "" Then
            txtDesignNo.Text = frm.DesignNoList.Trim
        End If
    End Sub

    Private Sub btnClearArticle_Click(sender As Object, e As EventArgs) Handles btnClearArticle.Click
        txtDesignNo.Text = ""
    End Sub
End Class