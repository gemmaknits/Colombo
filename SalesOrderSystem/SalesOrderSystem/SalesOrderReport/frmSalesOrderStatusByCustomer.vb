Imports System.Data.SqlClient
Imports Syncfusion.XlsIO

Public Class frmSalesOrderStatusByCustomer
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
        Dim objSO As New classSalesOrder

        Me.cboCustomer.DataSource = objDB.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.cboSoNo.DataSource = objSO.SOLoad()
        Me.cboSoNo.DisplayMember = "sono2"
        Me.cboSoNo.ValueMember = "sono2"
        Me.cboSoNo.SelectedIndex = -1

        Me.comboSalesPerson.DataSource = objDB.GetEmp
        Me.comboSalesPerson.DisplayMember = "empname"
        Me.comboSalesPerson.ValueMember = "empcd"
        Me.comboSalesPerson.SelectedValue = clsUser.UserID

    End Sub

    Private Sub FormRptInvoiceLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Call checkAllSalesPersons_CheckedChanged(sender, e)
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
        Me.optOrderFilterAll.Checked = True
        Call checkAllSalesPersons_CheckedChanged(sender, e)
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        setupReport()
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub
    Private Sub setupReport()
        Dim rptFileName As String = IIf(chkUseDeliveryDate.Checked, "rptSO5.rpt", "rptSO4.rpt")
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then
            'Try
            '    Dim rpt As New rptSO4
            '    printReport(rpt)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            Exit Sub
        Else
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUser.ReportPath & rptFileName)
            printReport(rpt)
        End If

    End Sub
    Private Sub printReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@sodatefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@sodateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        If optOption1.Checked Then rpt.SetParameterValue("@showclosedinv", 0)
        If optOption2.Checked Then rpt.SetParameterValue("@showclosedinv", 1)
        If optOption3.Checked Then rpt.SetParameterValue("@showclosedinv", 2)

        If Me.optOrderFilterAll.Checked Then rpt.SetParameterValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then rpt.SetParameterValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then rpt.SetParameterValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then rpt.SetParameterValue("@orderfilter", "MTO")

        rpt.SetParameterValue("@empcd", clsConfig.IsNull(comboSalesPerson.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@loginEmpcd", clsConfig.IsNull(clsUser.UserID, "").ToString.Trim)

        If Me.chkShowSoWithNoDF.Checked Then
            rpt.SetParameterValue("@ShowSoWithNoDF", 1)
        Else
            rpt.SetParameterValue("@ShowSoWithNoDF", 0)
        End If

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA3
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        frm.Title = "Sales Order Status By Customer"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub checkAllSalesPersons_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkAllSalesPersons.CheckedChanged
        Me.comboSalesPerson.SelectedIndex = -1
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        ExportToExcel()
    End Sub

    Private Sub ExportToExcel()
        'saharat 20230703
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
            worksheet.ImportDataTable(LoadData_SalesOrderStatusByCustomer(), True, 1, 1)
            worksheet.UsedRange.AutofitColumns()

            'Save the workbook to disk in xlsx format
            'workbook.SaveAs("Output.xlsx")

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "File(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveFileDialog1.Title = "Save File"
            saveFileDialog1.FileName = "Sales Order Status By Customer"
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

    Public Function LoadData_SalesOrderStatusByCustomer() As DataTable
        'saharat 20230703
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = IIf(chkUseDeliveryDate.Checked, "p_so_track_by_delivery", "p_so_track_sum")
        'comm.CommandTimeout = 150
        comm.Parameters.Clear()

        comm.Parameters.AddWithValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@sodatefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        comm.Parameters.AddWithValue("@sodateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        comm.Parameters.AddWithValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        If optOption1.Checked Then comm.Parameters.AddWithValue("@showclosedinv", 0)
        If optOption2.Checked Then comm.Parameters.AddWithValue("@showclosedinv", 1)
        If optOption3.Checked Then comm.Parameters.AddWithValue("@showclosedinv", 2)

        If Me.optOrderFilterAll.Checked Then comm.Parameters.AddWithValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then comm.Parameters.AddWithValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then comm.Parameters.AddWithValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then comm.Parameters.AddWithValue("@orderfilter", "MTO")

        comm.Parameters.AddWithValue("@empcd", clsConfig.IsNull(comboSalesPerson.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@loginEmpcd", clsConfig.IsNull(clsUser.UserID, "").ToString.Trim)

        If Me.chkShowSoWithNoDF.Checked Then
            comm.Parameters.AddWithValue("@ShowSoWithNoDF", 1)
        Else
            comm.Parameters.AddWithValue("@ShowSoWithNoDF", 0)
        End If

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

End Class