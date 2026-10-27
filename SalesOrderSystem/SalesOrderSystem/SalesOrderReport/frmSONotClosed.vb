Imports Syncfusion.XlsIO
Imports OfficeOpenXml
Imports System.IO
Imports System.Windows.Forms
Public Class frmSONotClosed
#Region "Property"
    Private clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
#End Region


    Private clsSalesOrder As New classSalesOrder
    Private clsConfig As New clsConfig
    Private clsMaster As New classMaster

    'Constant Values
    Private Const CC_SortBySoDate As String = "SoDate"
    Private Const CC_SortByDesignNo As String = "DesignNo"
    Private Const CC_SortByCustomerName As String = "CustomerName"

    'Parameter for report
    Private PM_EmpType As Integer
    Private PM_EmpCd As String
    Private PM_Closed As Integer
    Private PM_LogEmpCd As String
    Private PM_DateFr As String
    Private PM_DateTo As String
    Private PM_DateOf As String
    Private PM_CustomerName As String
    Private PM_DesignNo As String
    Private PM_SortBy As String

    Private Sub frmSONotClosed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        Call GenCombo()
        cmbSortBy.SelectedIndex = 0
        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
    End Sub

    Private Sub GenCombo()
        With comboSalesPerson
            .DataSource = clsMaster.GetEmp
            .DisplayMember = "empname"
            .ValueMember = "empcd"
            .SelectedIndex = -1
        End With

        With cmbSortBy
            .Items.Add(CC_SortBySoDate)
            .Items.Add(CC_SortByDesignNo)
            .Items.Add(CC_SortByCustomerName)

            .AutoCompleteCustomSource.Add(CC_SortBySoDate)
            .AutoCompleteCustomSource.Add(CC_SortByDesignNo)
            .AutoCompleteCustomSource.Add(CC_SortByCustomerName)
        End With
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptFileName = ""

        If rbReportForSales.Checked Then
            rptFileName = "rptSONotClosed.rpt"
        ElseIf rbReportForSaleRelateGammaJob.Checked Then
            rptFileName = "rptSONotClosedRelateGammaJob.rpt"
        ElseIf rbReportForProduction.Checked Then
            rptFileName = "rptSONotClosedForProductionPlan.rpt"
        ElseIf rbForPresent.Checked Then
            rptFileName = "rptSONotClosedForPresent.rpt"
        End If

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then Exit Sub

        Dim clsConn As New classConnection
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim frm As New frmReport

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase() 'Neugn 20251103
        initConditonParameter()

        rpt.SetParameterValue("@emp_type", PM_EmpType)
        rpt.SetParameterValue("@empcd", PM_EmpCd)
        rpt.SetParameterValue("@datefr", PM_DateFr)
        rpt.SetParameterValue("@dateto", PM_DateTo)
        rpt.SetParameterValue("@closed", PM_Closed)
        rpt.SetParameterValue("@logempcd", PM_LogEmpCd)

        rpt.SetParameterValue("@dateof", PM_DateOf)
        rpt.SetParameterValue("@customer_name", PM_CustomerName)
        rpt.SetParameterValue("@design_no", PM_DesignNo)
        rpt.SetParameterValue("@Sort_By", PM_SortBy)
        '--- Sitthana 20190112 - End

        Dim TitleDesc As String = ""
        If optShowClosedSO.Checked Then
            TitleDesc = "Sales Order Closed Report"
        ElseIf optShowNonClosedSO.Checked Then
            TitleDesc = "Sales Order Not Closed Report"
        Else
            TitleDesc = "Sales Order Report"
        End If 'Sitthana 20210419

        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub initConditonParameter()
        If optPrintAll.Checked Then
            PM_EmpType = 0
        ElseIf optPrintOnly.Checked Then
            PM_EmpType = 1
        ElseIf optPrintExcept.Checked Then
            PM_EmpType = 2
        End If

        PM_EmpCd = clsConfig.IsNull(comboSalesPerson.SelectedValue, "").ToString.Trim

        If optShowClosedSO.Checked Then
            PM_Closed = 1
        ElseIf optShowNonClosedSO.Checked Then
            PM_Closed = 0
        Else
            PM_Closed = 2
        End If 'Sitthana 20210419

        PM_LogEmpCd = clsUser.UserID

        '--- Sitthana 20190112 - Begin
        If dtpDateFr.Checked Then
            PM_DateFr = dtpDateFr.Value.ToString("yyyyMMdd").Trim
            If dtpDateTo.Checked = False Then
                dtpDateTo.Checked = True
                dtpDateTo.Value = dtpDateFr.Value
            End If
            PM_DateTo = dtpDateTo.Value.ToString("yyyyMMdd").Trim
        Else
            dtpDateTo.Checked = False
            PM_DateFr = "19000101"
            PM_DateTo = "210001231"
        End If

        If rbCustShipdt.Checked Then
            PM_DateOf = "CUSTDUE"
        Else
            PM_DateOf = "SO"
        End If

        PM_CustomerName = txtCustomerName.Text.Trim
        PM_DesignNo = txtDesignNo.Text.Trim
        PM_SortBy = cmbSortBy.AutoCompleteCustomSource.Item(cmbSortBy.SelectedIndex)
    End Sub

    Private Sub tsbtnExportToExcel_Click(sender As Object, e As EventArgs) Handles tsbtnExportToExcel.Click
        Dim dtExcel As New DataTable
        Dim bsExcel As New BindingSource
        Dim drvExcel As DataRowView

        initConditonParameter()

        If rbReportForSaleRelateGammaJob.Checked Then
            dtExcel = clsSalesOrder.getSoNotClosedRelateGamma(PM_DateFr, PM_DateTo, PM_Closed _
                                                            , PM_LogEmpCd, PM_EmpCd, PM_EmpType _
                                                            , PM_DesignNo, PM_CustomerName _
                                                            , PM_SortBy, PM_DateOf
                                                              )
            bsExcel.DataSource = dtExcel

            dgvSaleRelateGammaJob.AutoGenerateColumns = False
            dgvSaleRelateGammaJob.DataSource = bsExcel
            'ChangeColumnNameDtExcelRelateGamma(dtExcel)
            'DeleteColumnDtExcelRelateGamma(dtExcel)
        Else
            dtExcel = clsSalesOrder.getSoNotClosed(PM_DateFr, PM_DateTo, PM_Closed _
                                                 , PM_LogEmpCd, PM_EmpCd, PM_EmpType _
                                                 , PM_DesignNo, PM_CustomerName _
                                                 , PM_SortBy, PM_DateOf
                                                 )
            ChangeColumnNameDtExcel(dtExcel)
            DeleteColumnDtExcel(dtExcel)
        End If


        ExportToExcel()
    End Sub

    Private Sub ChangeColumnNameDtExcel(ByRef dt As DataTable)
        dt.Columns("sonoid").ColumnName = "S/O No."
        dt.Columns("sodt").ColumnName = "Date"
        dt.Columns("customer_name").ColumnName = "Customer"
        dt.Columns("custpo").ColumnName = "Customer PO"
        dt.Columns("empcd").ColumnName = "Sales"
        dt.Columns("design_no").ColumnName = "Design No."
        dt.Columns("custdes").ColumnName = "Customer Design"
        dt.Columns("labdipno").ColumnName = "CMR No."
        dt.Columns("col").ColumnName = "Color"
        dt.Columns("custcol").ColumnName = "Color Name"
        dt.Columns("qty").ColumnName = "Qty."
        dt.Columns("uom").ColumnName = "UOM"
        dt.Columns("qty_balance").ColumnName = "Qty Balance"
        dt.Columns("price").ColumnName = "Unit Price"
        dt.Columns("curr").ColumnName = "Currency"
        dt.Columns("lineamt").ColumnName = "Amount"
        dt.Columns("cust_shipdt").ColumnName = "Due Date"
        dt.Columns("dfno").ColumnName = "DF No"
        dt.Columns("jobno").ColumnName = "Job No"
        dt.Columns("exrt").ColumnName = "Rate"
        dt.Columns("lineamtthb").ColumnName = "Amount (THB)"
        dt.Columns("amount_balance_baht").ColumnName = "Amount Balance (THB)"
        dt.Columns("closed").ColumnName = "Closed"
        dt.Columns("closedt").ColumnName = "Closed Date"
    End Sub

    Private Sub DeleteColumnDtExcel(ByRef dt As DataTable)
        'dt.Columns.Remove("sono")
        'dt.Columns.Remove("sodtforsort")
    End Sub

    Private Sub ChangeColumnNameDtExcelRelateGamma(ByRef dt As DataTable)
        dt.Columns("sonoid").ColumnName = "S/O No."
        dt.Columns("sodt").ColumnName = "Date"
        dt.Columns("customer_name").ColumnName = "Customer"
        dt.Columns("custpo").ColumnName = "Customer PO"
        dt.Columns("empcd").ColumnName = "Sales"
        dt.Columns("design_no").ColumnName = "Design No."
        dt.Columns("custdes").ColumnName = "Customer Design"
        dt.Columns("labdipno").ColumnName = "CMR No."
        dt.Columns("col").ColumnName = "Color"
        dt.Columns("custcol").ColumnName = "Color Name"
        dt.Columns("qty").ColumnName = "Qty."
        dt.Columns("uom").ColumnName = "UOM"
        dt.Columns("qty_balance").ColumnName = "Qty Balance"
        dt.Columns("price").ColumnName = "Unit Price"
        dt.Columns("curr").ColumnName = "Currency"
        dt.Columns("lineamt").ColumnName = "Amount"
        dt.Columns("cust_shipdt").ColumnName = "Due Date"
        dt.Columns("dfno").ColumnName = "DF No"
        dt.Columns("jobno").ColumnName = "Job No"
        dt.Columns("exrt").ColumnName = "Rate"
        dt.Columns("lineamtthb").ColumnName = "Amount (THB)"
        dt.Columns("amount_balance_baht").ColumnName = "Amount Balance (THB)"
        dt.Columns("closed").ColumnName = "Closed"
        dt.Columns("closedt").ColumnName = "Closed Date"
    End Sub

    Private Sub DeleteColumnDtExcelRelateGamma(ByRef dt As DataTable)
        'dt.Columns.Remove("sono")
        'dt.Columns.Remove("sodtforsort")
    End Sub
    Private Sub ExportToExcel()
        Me.Cursor = Cursors.WaitCursor

        Dim dt As New DataTable

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial

        ' Create a new Excel package
        Using package As New ExcelPackage()
            ' Add a new worksheet
            Dim worksheet = package.Workbook.Worksheets.Add("Sheet1")

            ' Load data from the DataTable starting from cell A1
            worksheet.Cells("A1").LoadFromDataTable(PrepareDataTable(dt), True)

            For Each cell In worksheet.Cells
                Dim ie = worksheet.IgnoredErrors.Add(cell)
                ie.NumberStoredAsText = True

                If IsNumeric(cell.Value) Then
                    ' Trim the cell value to remove any leading or trailing spaces
                    Dim trimmedValue As String = cell.Value.ToString().Trim()

                    ' Check if the trimmed value contains any operators
                    If Not (trimmedValue.Contains("+") Or trimmedValue.Contains("*") Or trimmedValue.Contains("/")) Then
                        ' Try to convert to decimal
                        Try
                            cell.Value = Convert.ToDecimal(trimmedValue, Globalization.CultureInfo.InvariantCulture)
                        Catch ex As FormatException
                            ' Handle cases where the conversion fails
                            'MessageBox.Show("Invalid format: " & trimmedValue)
                        End Try
                    Else
                        ' If it contains an operator, skip conversion
                        ' MessageBox.Show("Value contains operator, skipping conversion: " & trimmedValue)
                    End If
                End If

                If TypeOf cell.Value Is String Then
                    Dim dateValue As DateTime
                    If DateTime.TryParseExact(cell.Value.ToString(), "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dateValue) Then
                        cell.Value = dateValue ' Convert to DateTime
                        cell.Style.Numberformat.Format = "dd/MM/yyyy" ' Set the date format
                    End If
                End If
            Next

            For col As Integer = 1 To dt.Columns.Count
                worksheet.Column(col).Width = 17
            Next
            ' Save the Excel package to a file
            Using saveFileDialog1 As New SaveFileDialog
                saveFileDialog1.Filter = "File(*.xlsx)|*.xlsx|All files (*.*)|*.*"
                saveFileDialog1.Title = "Save File"
                saveFileDialog1.FileName = ""

                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    If saveFileDialog1.FileName <> "" Then
                        package.SaveAs(saveFileDialog1.FileName)
                        MessageBox.Show("Excel file created successfully.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Else
                        MessageBox.Show("File name cannot be empty!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    End If
                End If
            End Using
        End Using

        Me.Cursor = Cursors.Default
    End Sub

    Private Function PrepareDataTable(dt As DataTable)

        ' For Add columns to the DataTable based on the DataGridView columns
        For Each column As DataGridViewColumn In dgvSaleRelateGammaJob.Columns
            dt.Columns.Add(column.Name)
        Next

        ' For Populate the DataRow with data from the DataGridView
        For Each row As DataGridViewRow In dgvSaleRelateGammaJob.Rows

            Dim newRow As DataRow = dt.NewRow()

            For Each column As DataColumn In dt.Columns
                newRow(column.ColumnName) = If(row.Cells(column.ColumnName).Value IsNot Nothing, row.Cells(column.ColumnName).Value, DBNull.Value)
            Next

            dt.Rows.Add(newRow)
        Next

        ' For Modify the header text. Follow Headet Text DataGridView
        For Each column As DataColumn In dt.Columns
            column.ColumnName = dgvSaleRelateGammaJob.Columns(dt.Columns.IndexOf(column)).HeaderText
        Next

        Return dt

    End Function


    'Private Sub ExportToExcel(pDataTable As DataTable) 'Commented by John 19/11/2025 this one is using syncfusion OUTDATED
    '    Using excelEngine As ExcelEngine = New ExcelEngine()
    '        Initialize Application
    '        Dim application As IApplication = excelEngine.Excel
    '        Set the default application version as Excel 2016
    '        application.DefaultVersion = ExcelVersion.Excel2016
    '        Dim workbook As IWorkbook = application.Workbooks.Create(1)
    '        Dim worksheet As IWorksheet = workbook.Worksheets(0)

    '        worksheet.ImportDataTable(pDataTable, True, 1, 1)
    '        worksheet.UsedRange.AutofitColumns()

    '        Dim saveFileDialog1 As New SaveFileDialog()
    '        saveFileDialog1.Filter = "File(*.xlsx)|*.xlsx|All files (*.*)|*.*"
    '        saveFileDialog1.Title = "Save File"
    '        saveFileDialog1.FileName = ""

    '        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
    '            If saveFileDialog1.FileName <> "" Then
    '                workbook.SaveAs(saveFileDialog1.FileName)
    '                MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    '            End If
    '        End If

    '    End Using
    'End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub optPrintAll_CheckedChanged(sender As Object, e As EventArgs) Handles optPrintAll.CheckedChanged
        If optPrintAll.Checked Then
            comboSalesPerson.Enabled = False
        End If
    End Sub

    Private Sub optPrintOnly_CheckedChanged(sender As Object, e As EventArgs) Handles optPrintOnly.CheckedChanged
        If optPrintOnly.Checked Then
            comboSalesPerson.Enabled = True
        End If
    End Sub

    Private Sub optPrintExcept_CheckedChanged(sender As Object, e As EventArgs) Handles optPrintExcept.CheckedChanged
        If optPrintExcept.Checked Then
            comboSalesPerson.Enabled = True
        End If
    End Sub

    Private Sub btnGetCustomer_Click(sender As Object, e As EventArgs) Handles btnGetCustomer.Click
        Dim objfrmSeachCustomers As New frmSearchCustomers
        objfrmSeachCustomers.ShowDialog()
        txtCustCode.Text = objfrmSeachCustomers.pCustomerID
        txtCustomerName.Text = objfrmSeachCustomers.pCustomerName
    End Sub


End Class