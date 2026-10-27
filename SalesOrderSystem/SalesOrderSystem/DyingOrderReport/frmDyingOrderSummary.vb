Imports System.Data.SqlClient
Imports Syncfusion.XlsIO

Public Class frmDyingOrderSummary
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
        Dim objDF As New classDFOrder
        Dim objSO As New classSalesOrder

        Me.cboDFNo.DataSource = objDF.DFLoad()
        Me.cboDFNo.DisplayMember = "dfno"
        Me.cboDFNo.ValueMember = "dfno"
        Me.cboDFNo.SelectedIndex = -1

        Me.cboCustomer.DataSource = objDB.GetCustomer()
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = -1

        Me.cboSoNo.DataSource = objSO.SOLoad(strUserID:=clsUser.UserID)
        Me.cboSoNo.DisplayMember = "sono"
        Me.cboSoNo.ValueMember = "sono"
        Me.cboSoNo.SelectedIndex = -1

        Me.cboDyedHouse.DataSource = objDB.GetDyedHouse()
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd"
        Me.cboDyedHouse.SelectedIndex = -1

        Me.cboDesignNo.DataSource = objDB.GetDesign()
        Me.cboDesignNo.DisplayMember = "design_no"
        Me.cboDesignNo.ValueMember = "design_no"
        Me.cboDesignNo.SelectedIndex = -1

        Me.cboOwner.DataSource = objDB.GetEmp()
        Me.cboOwner.DisplayMember = "empname"
        Me.cboOwner.ValueMember = "empcd"
        Me.cboOwner.SelectedIndex = -1

    End Sub

    Private Sub frmDyingOrderPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        Me.optOrderFilterAll.Checked = True

        Call GenCombo()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Const rptFileName = "rptDFOrderSummary.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dfno", clsConfig.IsNull(cboDFNo.SelectedValue, "").ToString.Trim)

        If optDFDate.Checked Then
            rpt.SetParameterValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
            rpt.SetParameterValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        Else
            rpt.SetParameterValue("@datefr", "")
            rpt.SetParameterValue("@dateto", "")
        End If

        rpt.SetParameterValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@dhcod", clsConfig.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@design_no", clsConfig.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim)
        rpt.SetParameterValue("@empcd", clsConfig.IsNull(cboOwner.SelectedValue, "").ToString.Trim)

        If Me.optOrderFilterAll.Checked Then rpt.SetParameterValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then rpt.SetParameterValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then rpt.SetParameterValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then rpt.SetParameterValue("@orderfilter", "MTO")

        If optDFDate.Checked Then
            rpt.SetParameterValue("@receive_datefr", "")
            rpt.SetParameterValue("@receive_dateto", "")
        Else
            rpt.SetParameterValue("@receive_datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
            rpt.SetParameterValue("@receive_dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        End If

        rpt.SetParameterValue("@deptcd", IIf(optExport.Checked, "X", IIf(optDomestic.Checked, "D", "")))

        '      rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "D/F Order Summary"
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
            worksheet.ImportDataTable(LoadData_DyingOrderSummary(), True, 1, 1)
            worksheet.UsedRange.AutofitColumns()

            'Save the workbook to disk in xlsx format
            'workbook.SaveAs("Output.xlsx")

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "File(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveFileDialog1.Title = "Save File"
            saveFileDialog1.FileName = "Dying Order Summary"
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

    Public Function LoadData_DyingOrderSummary() As DataTable
        'saharat 20230703
        Dim conn As New SqlConnection((New classConnection).connection)
        Dim comm As New SqlCommand("", conn)
        comm.CommandType = CommandType.StoredProcedure
        comm.CommandText = "p_dforder_rep_summary"
        'comm.CommandTimeout = 150
        comm.Parameters.Clear()

        comm.Parameters.AddWithValue("@dfno", clsConfig.IsNull(cboDFNo.SelectedValue, "").ToString.Trim)

        If optDFDate.Checked Then
            comm.Parameters.AddWithValue("@datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        Else
            comm.Parameters.AddWithValue("@datefr", "")
            comm.Parameters.AddWithValue("@dateto", "")
        End If

        comm.Parameters.AddWithValue("@sono", clsConfig.IsNull(cboSoNo.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@custcd", clsConfig.IsNull(cboCustomer.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@dhcod", clsConfig.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@design_no", clsConfig.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim)
        comm.Parameters.AddWithValue("@empcd", clsConfig.IsNull(cboOwner.SelectedValue, "").ToString.Trim)

        If Me.optOrderFilterAll.Checked Then comm.Parameters.AddWithValue("@orderfilter", "ALL")
        If Me.optOrderFilterDevl.Checked Then comm.Parameters.AddWithValue("@orderfilter", "DEVL")
        If Me.optOrderFilterMTS.Checked Then comm.Parameters.AddWithValue("@orderfilter", "MTS")
        If Me.optOrderFilterMTO.Checked Then comm.Parameters.AddWithValue("@orderfilter", "MTO")

        If optDFDate.Checked Then
            comm.Parameters.AddWithValue("@receive_datefr", "")
            comm.Parameters.AddWithValue("@receive_dateto", "")
        Else
            comm.Parameters.AddWithValue("@receive_datefr", dtpDateFr.Value.ToString("yyyyMMdd"))
            comm.Parameters.AddWithValue("@receive_dateto", dtpDateTo.Value.ToString("yyyyMMdd"))
        End If

        comm.Parameters.AddWithValue("@deptcd", IIf(optExport.Checked, "X", IIf(optDomestic.Checked, "D", "")))

        Dim da As New SqlDataAdapter(comm)
        Dim dt As New DataTable
        da.Fill(dt)
        conn.Close()
        Return dt
    End Function

End Class