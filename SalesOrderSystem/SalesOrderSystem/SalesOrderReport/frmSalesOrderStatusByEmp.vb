Imports System.Data.SqlClient
Imports Syncfusion.XlsIO

Public Class frmSalesOrderStatusByEmp
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

        Me.cboCustomer.DataSource = objDB.GetCustomer
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.comboSalesPerson.DataSource = objDB.GetEmp
        Me.comboSalesPerson.DisplayMember = "empname"
        Me.comboSalesPerson.ValueMember = "empcd"
        Me.comboSalesPerson.SelectedValue = clsUser.UserID
    End Sub

    Private Sub frmSalesOrderStatusByEmp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptSOEmp.rpt"
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
        rpt.SetParameterValue("@empcd", clsConfig.IsNull(comboSalesPerson.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)

        frm.Title = "Sales Order Status By Employee"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
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
            saveFileDialog1.FileName = "Sales Order Status By Employee"
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
        Dim clsConfig As New clsConfig
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_so_emp_rep"
        'comm.CommandTimeout = 150
        comm.Parameters.Clear()

        comm.Parameters.AddWithValue("@empcd", clsConfig.IsNull(comboSalesPerson.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd").Trim)
        comm.Parameters.AddWithValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd").Trim)

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt

    End Function

End Class