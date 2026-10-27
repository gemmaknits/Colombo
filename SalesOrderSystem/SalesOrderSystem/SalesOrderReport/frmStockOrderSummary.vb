Imports System.Data.SqlClient
Imports Syncfusion.XlsIO

Public Class frmStockOrderSummary
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo 'Add by Neung 20151208
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub GenCombo()
        Dim objDB As New classMaster
        Dim objSO As New classSalesOrder

        Me.cboCustomer.DataSource = objDB.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.cboSoNo.DataSource = objSO.SOLoad(strOrder_Type:="STOCK")
        Me.cboSoNo.DisplayMember = "sono2"
        Me.cboSoNo.ValueMember = "sono2"
        Me.cboSoNo.SelectedIndex = -1

        Me.comboSalesPerson.DataSource = objDB.GetEmp
        Me.comboSalesPerson.DisplayMember = "empname"
        Me.comboSalesPerson.ValueMember = "empcd"
        Me.comboSalesPerson.SelectedValue = clsUser.UserID
        Me.comboSalesPerson.SelectedIndex = -1

    End Sub

    Private Sub frmSalesOrderStockCutting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Call setupReport()
    End Sub
    Private Sub setupReport()
        'Const rptFileName = "rptSOStockCutting.rpt"
        Const rptFileName = "rptSTSummary.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        'If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        printReport(rpt)
        'End If

    End Sub

    Private Sub printReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        'rpt.SetParameterValue("@salesRegion", Nothing)
        rpt.SetParameterValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@sodatefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@sodateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@salesRegion", clsConfig.IsNull(cbosalesRegion.SelectedText, Nothing))

        If Me.optOrderFilterAll.Checked Then rpt.SetParameterValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then rpt.SetParameterValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then rpt.SetParameterValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then rpt.SetParameterValue("@orderfilter", "MTO")

        rpt.SetParameterValue("@empcd", clsConfig.IsNull(comboSalesPerson.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim)
        rpt.SetParameterValue("@only_without_df", IIf(chkOnlyWithoutDF.Checked, 1, 0))
        rpt.SetParameterValue("@loginEmpcd", clsConfig.IsNull(clsUser.UserID, "").ToString.Trim)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Sales Order Status Summary"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub


    Private Sub checkAllST_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkAllST.CheckedChanged
        Me.cboSoNo.SelectedIndex = -1
    End Sub

    Private Sub checkAllSalesPersons_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkAllSalesPersons.CheckedChanged
        'If checkAllSalesPersons.Checked = True Then
        Me.cbosalesRegion.SelectedIndex = -1
        Me.comboSalesPerson.SelectedIndex = -1
        ' End If
    End Sub

    Private Sub optOrderFilterMTS_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optOrderFilterMTS.CheckedChanged
        If optOrderFilterMTS.Checked Then
            GenCBOSO("STOCK")
        End If
    End Sub
    Private Sub GenCBOSO(Optional ByVal strOrder_Type As String = "")
        Dim objDB As New classMaster
        Dim objSO As New classSalesOrder

        Me.cboSoNo.DataSource = objSO.SOLoad(strOrder_Type:=strOrder_Type)
        Me.cboSoNo.DisplayMember = "sono2"
        Me.cboSoNo.ValueMember = "sono2"
        Me.cboSoNo.SelectedIndex = -1
    End Sub

    Private Sub optCUSTORDER_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optOrderFilterMTO.CheckedChanged
        If optOrderFilterMTO.Checked Then
            GenCBOSO("CUSTORDER")
        End If
    End Sub

    Private Sub comboSalesPerson_DropDownClosed(sender As Object, e As System.EventArgs) Handles comboSalesPerson.DropDownClosed
        checkAllSalesPersons.Checked = False
    End Sub

    Private Sub cboSoNo_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboSoNo.DropDownClosed
        checkAllST.Checked = False
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        ExportToExcel()
    End Sub

    Public Function LoadData_SOSummary() As DataTable
        'saharat 20230626
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_st_summery_rep"
        'comm.CommandTimeout = 150
        comm.Parameters.Clear()


        comm.Parameters.AddWithValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@sodatefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        comm.Parameters.AddWithValue("@sodateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        comm.Parameters.AddWithValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@salesRegion", clsConfig.IsNull(cbosalesRegion.SelectedText, Nothing))

        If Me.optOrderFilterAll.Checked Then comm.Parameters.AddWithValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then comm.Parameters.AddWithValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then comm.Parameters.AddWithValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then comm.Parameters.AddWithValue("@orderfilter", "MTO")

        comm.Parameters.AddWithValue("@empcd", clsConfig.IsNull(comboSalesPerson.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@design_no", txtDesignNo.Text.Trim)
        comm.Parameters.AddWithValue("@only_without_df", IIf(chkOnlyWithoutDF.Checked, 1, 0))
        comm.Parameters.AddWithValue("@loginEmpcd", clsConfig.IsNull(clsUser.UserID, "").ToString.Trim)


        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Private Sub ExportToExcel()
        Me.Cursor = Cursors.WaitCursor

        Using excelEngine As ExcelEngine = New ExcelEngine()

            'Initialize Application
            Dim application As IApplication = excelEngine.Excel

            'Set the default application version as Excel 2016
            application.DefaultVersion = ExcelVersion.Excel2016

            'Create a new workbook
            Dim workbook As IWorkbook = application.Workbooks.Create(1)

            'Access first worksheet from the workbook instance
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Exporting DataTable to worksheet
            'Dim dataTable As DataTable = GetDataTable()
            'Dim dt As New DataTable()
            'dt = TryCast(dgvSOSummary.DataSource, DataTable)
            worksheet.ImportDataTable(LoadData_SOSummary(), True, 1, 1)
            worksheet.UsedRange.AutofitColumns()

            'Save the workbook to disk in xlsx format
            'workbook.SaveAs("Output.xlsx")

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "File(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveFileDialog1.Title = "Save File"
            saveFileDialog1.FileName = "Stock Order Summary"
            'saveFileDialog1.ShowDialog()

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                If saveFileDialog1.FileName <> "" Then
                    workbook.SaveAs(saveFileDialog1.FileName)
                    MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                End If
            End If

        End Using

        Me.Cursor = Cursors.Default

    End Sub

End Class
