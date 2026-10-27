Imports System.Data.SqlClient
Imports Syncfusion.XlsIO

Public Class frmSalesOrderStatusByAgency
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

        Me.cboAgency.DataSource = objDB.GetAgent
        Me.cboAgency.DisplayMember = "name"
        Me.cboAgency.ValueMember = "agcd"
        Me.cboAgency.SelectedIndex = -1

        Me.cboSoNo.DataSource = objSO.SOLoad()
        Me.cboSoNo.DisplayMember = "sono2"
        Me.cboSoNo.ValueMember = "sono2"
        Me.cboSoNo.SelectedIndex = -1
    End Sub

    Private Sub FormRptInvoiceLocal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptSO4_Agency.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@sodatefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@sodateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        If optOption1.Checked Then rpt.SetParameterValue("@showclosedinv", 0)
        If optOption2.Checked Then rpt.SetParameterValue("@showclosedinv", 1)
        If optOption3.Checked Then rpt.SetParameterValue("@showclosedinv", 2)
        rpt.SetParameterValue("@agcd", clsConfig.IsNull(cboAgency.SelectedValue, "").ToString.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Sales Order Status By Agency"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Dispose()
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
            saveFileDialog1.FileName = "Sales Order Status By Agency"
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
        comm.CommandText = "p_so_track_sum_agency"
        'comm.CommandTimeout = 150
        comm.Parameters.Clear()

        comm.Parameters.AddWithValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@sodatefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        comm.Parameters.AddWithValue("@sodateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)
        If optOption1.Checked Then comm.Parameters.AddWithValue("@showclosedinv", 0)
        If optOption2.Checked Then comm.Parameters.AddWithValue("@showclosedinv", 1)
        If optOption3.Checked Then comm.Parameters.AddWithValue("@showclosedinv", 2)
        comm.Parameters.AddWithValue("@agcd", clsConfig.IsNull(cboAgency.SelectedValue, "").ToString.Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt

    End Function

End Class