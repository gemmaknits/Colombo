Imports OfficeOpenXml
Imports OfficeOpenXml.Style
Imports System.IO
Imports System.Text

Public Class frmSoBookShipMentReport
    Private Shared ReadOnly BOOKED_COLOR As Color = Color.FromArgb(198, 89, 17)
    Private Shared ReadOnly INVOICED_COLOR As Color = Color.FromArgb(0, 112, 192)
    Private Shared ReadOnly PENDING_COLOR As Color = Color.FromArgb(0, 176, 80)
    Private Shared ReadOnly HEADER_FILL_COLOR As Color = Color.FromArgb(255, 230, 153)

    Private clsConn As New classConnection
    Private clsUser As New classUserInfo
    Private isFormLoaded As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmSoBookShipMentReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.StartPosition = FormStartPosition.CenterScreen
        'Me.WindowState = FormWindowState.Maximized

        dtpGenerateDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpGenerateDateTo.Value = Now
        dtpGeneratePendFrom.Value = DateSerial(Year(Now) - 1, 1, 1)

        isFormLoaded = True
        ConfigureFlatLayout()
    End Sub

    Private Sub ConfigureFlatLayout()
        If Not isFormLoaded OrElse tabReports Is Nothing OrElse tabReports.TabPages.Count = 0 Then
            Return
        End If

        ConfigureGenerateTab()
    End Sub

    Private Sub ConfigureGenerateTab()
        'If dgvGenerateReport Is Nothing Then
        '     Return
        '  End If

        ' wbGenerateReport.Size = New Size(tabGenerateReport.ClientSize.Width - 16, tabGenerateReport.ClientSize.Height - 48)
    End Sub

    Private Sub tabReports_Resize(sender As Object, e As EventArgs) Handles tabReports.Resize
        ConfigureFlatLayout()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            LoadGenerateReport()
        Catch ex As Exception
            ShowActionError("print report", ex)
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            LoadGenerateReport()
        Catch ex As Exception
            ShowActionError("search report", ex)
        End Try
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        Try
            If ValidateSelectedTabDateRange() Then ExportToExcel()
        Catch ex As Exception
            ShowActionError("export Excel", ex)
        End Try
    End Sub

    Private Function ValidateSelectedTabDateRange() As Boolean
        Return ValidateDateRange(dtpGenerateDateFr, dtpGenerateDateTo)
    End Function

    Private Function ValidateDateRange(ByVal dateFr As DateTimePicker, ByVal dateTo As DateTimePicker) As Boolean
        If dateFr.Value <= dateTo.Value Then
            Return True
        End If

        MessageBox.Show("From date is after To date.", "S/O Book Shipment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Return False
    End Function

    Private Sub ShowActionError(ByVal actionName As String, ByVal ex As Exception)
        MessageBox.Show("Failed to " & actionName & ":" & vbCrLf & ex.Message, "S/O Book Shipment", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LoadGenerateReport()
        If dtpGenerateDateFr.Value > dtpGenerateDateTo.Value Then
            MessageBox.Show("From date is after To date.", "S/O Book Shipment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim html As String = GetGenerateHtmlReport()

        If String.IsNullOrEmpty(html) Then
            MessageBox.Show("Report returned no content.", "S/O Book Shipment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim data As New DataTable
        data.Columns.Add("html", GetType(String))
        data.Rows.Add(html)
        'dgvGenerateReport.DataSource = data

        Dim htmlPath As String = SaveGenerateHtmlFile(html)
        OpenFileInDefaultApp(htmlPath)
    End Sub

    Private Function GetGenerateHtmlReport() As String
        Dim html As String = ""

        Try
            Me.Cursor = Cursors.WaitCursor

            Using conn As System.Data.SqlClient.SqlConnection = clsConn.getSQLConnection()
                Using comm As New System.Data.SqlClient.SqlCommand("P_SO_BOOK_SHIPMENT_REPORT_PKG_generate_report", conn)
                    comm.CommandType = CommandType.StoredProcedure
                    comm.CommandTimeout = 300
                    comm.Parameters.AddWithValue("@datefr", dtpGenerateDateFr.Value.ToString("yyyyMMdd").Trim)
                    comm.Parameters.AddWithValue("@dateto", dtpGenerateDateTo.Value.ToString("yyyyMMdd").Trim)
                    comm.Parameters.AddWithValue("@pend_from", dtpGeneratePendFrom.Value.ToString("yyyyMMdd").Trim)
                    Dim htmlParameter As System.Data.SqlClient.SqlParameter = comm.Parameters.Add("@html", System.Data.SqlDbType.NVarChar, -1)
                    htmlParameter.Direction = System.Data.ParameterDirection.Output

                    conn.Open()
                    html = Convert.ToString(comm.ExecuteScalar())

                    If String.IsNullOrEmpty(html) AndAlso htmlParameter.Value IsNot Nothing AndAlso htmlParameter.Value IsNot DBNull.Value Then
                        html = htmlParameter.Value.ToString()
                    End If
                End Using
            End Using
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return html
    End Function

    Private Function SaveGenerateHtmlFile(ByVal html As String) As String
        Dim dateFr As String = dtpGenerateDateFr.Value.ToString("yyyyMMdd").Trim
        Dim dateTo As String = dtpGenerateDateTo.Value.ToString("yyyyMMdd").Trim
        Dim fileName As String = "SO_Book_Shipment_" & dateFr & "_" & dateTo & ".html"
        Dim path As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), fileName)

        File.WriteAllText(path, html, New UTF8Encoding(False))
        Return path
    End Function

    Private Sub OpenFileInDefaultApp(ByVal path As String)
        Dim browserPath As String = GetModernBrowserPath()

        If browserPath <> "" Then
            Process.Start(New ProcessStartInfo(browserPath, """" & path & """"))
        Else
            Dim processInfo As New ProcessStartInfo(path)
            processInfo.UseShellExecute = True
            Process.Start(processInfo)
        End If
    End Sub

    Private Function GetModernBrowserPath() As String
        Dim candidates() As String = {
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Microsoft\Edge\Application\msedge.exe"),
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Microsoft\Edge\Application\msedge.exe"),
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Microsoft\Edge\Application\msedge.exe"),
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Google\Chrome\Application\chrome.exe"),
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Google\Chrome\Application\chrome.exe"),
            System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Google\Chrome\Application\chrome.exe")
        }

        For Each candidate As String In candidates
            If File.Exists(candidate) Then
                Return candidate
            End If
        Next

        Return ""
    End Function

    Private Sub OpenTablePrintPreview(ByVal title As String, ByVal data As DataTable)
        If data Is Nothing OrElse data.Rows.Count = 0 Then
            MessageBox.Show("No data for print.", "S/O Book Shipment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim path As String = SaveTableHtmlFile(title, data)
        OpenFileInDefaultApp(path)
    End Sub

    Private Function SaveTableHtmlFile(ByVal title As String, ByVal data As DataTable) As String
        Dim html As New StringBuilder

        html.AppendLine("<!doctype html>")
        html.AppendLine("<html><head><meta charset=""utf-8"">")
        html.AppendLine("<title>" & HtmlEncode(title) & "</title>")
        html.AppendLine("<style>")
        html.AppendLine("body{font-family:Segoe UI,Arial,sans-serif;margin:24px;color:#222}")
        html.AppendLine("h1{font-size:18px;margin:0 0 4px}.meta{font-size:12px;color:#666;margin-bottom:16px}")
        html.AppendLine("table{border-collapse:collapse;width:100%;font-size:12px}th,td{border:1px solid #ccc;padding:5px 7px;vertical-align:top}")
        html.AppendLine("th{background:#f2f2f2;text-align:left}.num{text-align:right;white-space:nowrap}.toolbar{margin-bottom:14px}@media print{.toolbar{display:none}}")
        html.AppendLine("</style></head><body>")
        html.AppendLine("<div class=""toolbar""><button onclick=""window.print()"">Print</button></div>")
        html.AppendLine("<h1>" & HtmlEncode(title) & "</h1>")
        html.AppendLine("<div class=""meta"">Generated: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm") & " | Rows: " & data.Rows.Count.ToString() & "</div>")
        html.AppendLine("<table><thead><tr>")

        For Each column As DataColumn In data.Columns
            html.AppendLine("<th>" & HtmlEncode(column.ColumnName) & "</th>")
        Next

        html.AppendLine("</tr></thead><tbody>")

        For Each row As DataRow In data.Rows
            html.AppendLine("<tr>")
            For Each column As DataColumn In data.Columns
                Dim value As Object = row(column)
                Dim cellClass As String = If(IsNumericValue(value), " class=""num""", "")
                html.AppendLine("<td" & cellClass & ">" & HtmlEncode(FormatPrintValue(value)) & "</td>")
            Next
            html.AppendLine("</tr>")
        Next

        html.AppendLine("</tbody></table></body></html>")

        Dim path As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), BuildSafeFileName(title) & "_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".html")
        File.WriteAllText(path, html.ToString(), New UTF8Encoding(False))
        Return path
    End Function

    Private Function FormatPrintValue(ByVal value As Object) As String
        If value Is Nothing OrElse value Is DBNull.Value Then Return ""

        If IsNumericValue(value) Then
            Return Convert.ToDecimal(value).ToString("#,##0.##")
        End If

        Return value.ToString()
    End Function

    Private Function IsNumericValue(ByVal value As Object) As Boolean
        Return TypeOf value Is Decimal OrElse TypeOf value Is Double OrElse TypeOf value Is Single OrElse TypeOf value Is Integer OrElse TypeOf value Is Long
    End Function

    Private Function HtmlEncode(ByVal value As String) As String
        If value Is Nothing Then Return ""
        Return System.Net.WebUtility.HtmlEncode(value)
    End Function

    Private Function BuildSafeFileName(ByVal value As String) As String
        Dim safeName As String = value
        For Each invalidChar As Char In System.IO.Path.GetInvalidFileNameChars()
            safeName = safeName.Replace(invalidChar, "_"c)
        Next

        Return safeName.Replace(" ", "_")
    End Function

    Private Sub ExportToExcel()
        Dim workbookData As New List(Of ReportExcelSection)

        workbookData.Add(New ReportExcelSection(CreateBookedSummary(GetGenerateOrderBookedData()), BOOKED_COLOR))
        workbookData.Add(New ReportExcelSection(CreateInvoicedSummary(GetGenerateOrderInvoicedData()), INVOICED_COLOR))
        workbookData.Add(New ReportExcelSection(CreatePendingSummary(GetGenerateOrderPendingData()), PENDING_COLOR))

        If workbookData.Count = 0 OrElse Not HasExportData(workbookData) Then
            MessageBox.Show("No data for export.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Return
        End If

        SaveExcelWorkbook(workbookData)
    End Sub

    Private Function GetGenerateOrderBookedData() As DataTable
        Return GetReportData("P_SO_BOOK_SHIPMENT_REPORT_PKG_order_booked", GetDateRangeParameters(dtpGenerateDateFr, dtpGenerateDateTo))
    End Function

    Private Function GetGenerateOrderInvoicedData() As DataTable
        Return GetReportData("P_SO_BOOK_SHIPMENT_REPORT_PKG_order_invoiced", GetDateRangeParameters(dtpGenerateDateFr, dtpGenerateDateTo))
    End Function

    Private Function GetGenerateOrderPendingData() As DataTable
        Return GetReportData("P_SO_BOOK_SHIPMENT_REPORT_PKG_order_pending", GetGenerateParameters())
    End Function

    Private Function GetGenerateParameters() As Dictionary(Of String, Object)
        Dim parameters As Dictionary(Of String, Object) = GetDateRangeParameters(dtpGenerateDateFr, dtpGenerateDateTo)
        parameters.Add("@pend_from", dtpGeneratePendFrom.Value.ToString("yyyyMMdd").Trim)
        Return parameters
    End Function

    Private Function GetDateRangeParameters(ByVal dateFr As DateTimePicker, ByVal dateTo As DateTimePicker) As Dictionary(Of String, Object)
        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("@datefr", dateFr.Value.ToString("yyyyMMdd").Trim)
        parameters.Add("@dateto", dateTo.Value.ToString("yyyyMMdd").Trim)
        Return parameters
    End Function

    Private Function CreateBookedSummary(ByVal source As DataTable) As DataTable
        Return CreateSalespersonMonthlySummary("Sales Order monthly (OC)", source, "amount")
    End Function

    Private Function CreateInvoicedSummary(ByVal source As DataTable) As DataTable
        Return CreateSalespersonMonthlySummary("Summary Invoice", source, "amount")
    End Function

    Private Function CreatePendingSummary(ByVal source As DataTable) As DataTable
        Dim summary As New DataTable
        Dim values As New Dictionary(Of String, Decimal)
        Dim periodNames As New Dictionary(Of String, String)
        Dim periodKeys As New List(Of String)

        summary.Columns.Add("OC Pending_Shipment Update:", GetType(String))
        summary.Columns.Add("Amount (THB)", GetType(Decimal))
        If source Is Nothing Then Return summary

        For Each row As DataRow In source.Rows
            Dim periodKey As String = GetMonthKey(row)

            If Not values.ContainsKey(periodKey) Then
                values.Add(periodKey, 0D)
                periodNames.Add(periodKey, GetMonthName(periodKey))
                periodKeys.Add(periodKey)
            End If

            values(periodKey) += GetDecimalValue(row, "amtbal")
        Next

        periodKeys.Sort()
        For Each periodKey As String In periodKeys
            Dim row As DataRow = summary.NewRow()
            row(0) = periodNames(periodKey)
            row(1) = values(periodKey)
            summary.Rows.Add(row)
        Next

        Return summary
    End Function

    Private Function CreateSalespersonMonthlySummary(ByVal title As String, ByVal source As DataTable, ByVal amountColumn As String) As DataTable
        Dim summary As New DataTable
        Dim values As New Dictionary(Of String, Dictionary(Of String, Decimal))
        Dim periodNames As New Dictionary(Of String, String)
        Dim periodKeys As New List(Of String)

        summary.Columns.Add(title, GetType(String))
        If source Is Nothing Then Return summary

        For Each row As DataRow In source.Rows
            Dim salesPerson As String = GetStringValue(row, "sp")
            Dim periodKey As String = GetMonthKey(row)

            If salesPerson = "" Then salesPerson = "No sales person"
            If Not periodNames.ContainsKey(periodKey) Then
                periodNames.Add(periodKey, GetMonthName(periodKey))
                periodKeys.Add(periodKey)
            End If
            If Not values.ContainsKey(salesPerson) Then values.Add(salesPerson, New Dictionary(Of String, Decimal))
            If Not values(salesPerson).ContainsKey(periodKey) Then values(salesPerson).Add(periodKey, 0D)
            values(salesPerson)(periodKey) += GetDecimalValue(row, amountColumn)
        Next

        periodKeys.Sort()
        For Each periodKey As String In periodKeys
            summary.Columns.Add(periodNames(periodKey), GetType(Decimal))
        Next

        AddDynamicSummaryRows(summary, values, periodKeys)
        Return summary
    End Function

    Private Function GetMonthKey(ByVal row As DataRow) As String
        Dim delivMonth As String = GetStringValue(row, "delivm")
        If delivMonth <> "" Then Return delivMonth

        Dim dateValue As Date = GetDateValue(GetStringValue(row, "dt"))
        If dateValue <> Date.MinValue Then Return dateValue.ToString("yyyy-MM")

        Return "0000-00"
    End Function

    Private Function GetMonthName(ByVal periodKey As String) As String
        Dim dateValue As Date
        If Date.TryParseExact(periodKey & "-01", "yyyy-MM-dd", Nothing, Globalization.DateTimeStyles.None, dateValue) Then
            Return dateValue.ToString("MMMM/yyyy")
        End If

        Return "No Date"
    End Function

    Private Sub AddDynamicSummaryRows(ByVal summary As DataTable, ByVal values As Dictionary(Of String, Dictionary(Of String, Decimal)), ByVal periodKeys As List(Of String))
        Dim rowKeys As New List(Of String)(values.Keys)
        rowKeys.Sort()

        For Each rowKey As String In rowKeys
            Dim row As DataRow = summary.NewRow()
            row(0) = rowKey
            For index As Integer = 0 To periodKeys.Count - 1
                Dim periodKey As String = periodKeys(index)
                row(index + 1) = If(values(rowKey).ContainsKey(periodKey), values(rowKey)(periodKey), 0D)
            Next
            summary.Rows.Add(row)
        Next
    End Sub

    Private Function HasExportData(ByVal sections As List(Of ReportExcelSection)) As Boolean
        For Each section As ReportExcelSection In sections
            If section.Data IsNot Nothing AndAlso section.Data.Columns.Count > 0 AndAlso section.Data.Rows.Count > 0 Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub SaveExcelWorkbook(ByVal sections As List(Of ReportExcelSection))
        Me.Cursor = Cursors.WaitCursor

        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial

            Using package As New ExcelPackage()
                Dim worksheet = package.Workbook.Worksheets.Add("S O Book Shipment")
                Dim startRow As Integer = 1

                For Each section As ReportExcelSection In sections
                    If section.Data IsNot Nothing AndAlso section.Data.Columns.Count > 0 AndAlso section.Data.Rows.Count > 0 Then
                        WriteExcelSection(worksheet, section, startRow)
                        startRow += section.Data.Rows.Count + 4
                    End If
                Next

                worksheet.View.FreezePanes(2, 2)
                SetExcelColumnWidths(worksheet)

                Using saveFileDialog1 As New SaveFileDialog()
                    saveFileDialog1.Filter = "File(*.xlsx)|*.xlsx|All files (*.*)|*.*"
                    saveFileDialog1.Title = "Save File"
                    saveFileDialog1.FileName = GetExportFileName()

                    If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                        If saveFileDialog1.FileName <> "" Then
                            package.SaveAs(New FileInfo(saveFileDialog1.FileName))
                            MessageBox.Show("Excel file created successfully.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        End If
                    End If
                End Using
            End Using
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub WriteExcelSection(ByVal worksheet As ExcelWorksheet, ByVal section As ReportExcelSection, ByVal startRow As Integer)
        Dim data As DataTable = section.Data
        Dim endRow As Integer = startRow + data.Rows.Count
        Dim totalRow As Integer = endRow + 1
        If section.IncludeTotal Then endRow = totalRow
        Dim lastColumn As Integer = Math.Max(data.Columns.Count, 1)

        For columnIndex As Integer = 0 To data.Columns.Count - 1
            worksheet.Cells(startRow, columnIndex + 1).Value = data.Columns(columnIndex).ColumnName
        Next

        For rowIndex As Integer = 0 To data.Rows.Count - 1
            For columnIndex As Integer = 0 To data.Columns.Count - 1
                SetExcelCellValue(worksheet.Cells(startRow + rowIndex + 1, columnIndex + 1), data.Rows(rowIndex)(columnIndex))
            Next
        Next

        If section.IncludeTotal Then
            worksheet.Cells(totalRow, 1).Value = "Total"
            For columnIndex As Integer = 1 To data.Columns.Count - 1
                Dim total As Decimal = 0D
                For Each row As DataRow In data.Rows
                    total += GetDecimalValue(row(columnIndex))
                Next
                SetExcelCellValue(worksheet.Cells(totalRow, columnIndex + 1), total)
            Next
        End If

        StyleExcelRange(worksheet, startRow, endRow, lastColumn, section.TitleColor, section.IncludeTotal)
    End Sub

    Private Sub SetExcelCellValue(ByVal cell As ExcelRange, ByVal value As Object)
        If value Is Nothing OrElse value Is DBNull.Value Then
            cell.Value = "-"
            Return
        End If

        If TypeOf value Is Decimal OrElse TypeOf value Is Double OrElse TypeOf value Is Single OrElse TypeOf value Is Integer OrElse TypeOf value Is Long Then
            Dim number As Decimal = Convert.ToDecimal(value)
            If number = 0D Then
                cell.Value = "-"
            Else
                cell.Value = number
                cell.Style.Numberformat.Format = "#,##0.00"
            End If
        Else
            cell.Value = value.ToString
        End If
    End Sub

    Private Sub StyleExcelRange(ByVal worksheet As ExcelWorksheet, ByVal startRow As Integer, ByVal endRow As Integer, ByVal lastColumn As Integer, ByVal titleColor As Color, ByVal includeTotal As Boolean)
        Dim tableRange = worksheet.Cells(startRow, 1, endRow, lastColumn)

        tableRange.Style.Border.Top.Style = ExcelBorderStyle.Thin
        tableRange.Style.Border.Left.Style = ExcelBorderStyle.Thin
        tableRange.Style.Border.Right.Style = ExcelBorderStyle.Thin
        tableRange.Style.Border.Bottom.Style = ExcelBorderStyle.Thin

        With worksheet.Cells(startRow, 1, startRow, lastColumn).Style
            .Fill.PatternType = ExcelFillStyle.Solid
            .Fill.BackgroundColor.SetColor(HEADER_FILL_COLOR)
            .Font.Bold = True
            .Font.Size = 14
            .Font.Color.SetColor(titleColor)
            .HorizontalAlignment = ExcelHorizontalAlignment.Center
        End With

        If includeTotal Then
            With worksheet.Cells(endRow, 1, endRow, lastColumn).Style
                .Font.Bold = True
                .Font.Size = 12
                .Font.Color.SetColor(titleColor)
                .Border.Top.Style = ExcelBorderStyle.Double
            End With
        End If

        worksheet.Cells(startRow + 1, 2, endRow, lastColumn).Style.HorizontalAlignment = ExcelHorizontalAlignment.Right
        worksheet.Column(1).Width = 32
    End Sub

    Private Sub SetExcelColumnWidths(ByVal worksheet As ExcelWorksheet)
        If worksheet.Dimension Is Nothing Then
            Return
        End If

        For columnIndex As Integer = worksheet.Dimension.Start.Column To worksheet.Dimension.End.Column
            If columnIndex = 1 Then
                worksheet.Column(columnIndex).Width = 32
            Else
                worksheet.Column(columnIndex).Width = 18
            End If
        Next
    End Sub

    Private Function GetExportFileName() As String
        Return "SO Book Shipment Generate Report"
    End Function

    Private Function GetStringValue(ByVal row As DataRow, ByVal columnName As String) As String
        If row.Table.Columns.Contains(columnName) AndAlso row(columnName) IsNot DBNull.Value Then
            Return row(columnName).ToString.Trim
        End If

        Return ""
    End Function

    Private Function GetDecimalValue(ByVal row As DataRow, ByVal columnName As String) As Decimal
        If row.Table.Columns.Contains(columnName) Then
            Return GetDecimalValue(row(columnName))
        End If

        Return 0D
    End Function

    Private Function GetDecimalValue(ByVal value As Object) As Decimal
        If value Is Nothing OrElse value Is DBNull.Value Then Return 0D

        Dim number As Decimal
        If Decimal.TryParse(value.ToString, number) Then
            Return number
        End If

        Return 0D
    End Function

    Private Function GetDateValue(ByVal value As String) As Date
        Dim dateValue As Date
        Dim formats() As String = {"dd/MM/yy", "dd/MM/yyyy", "yyyyMMdd", "yyyy-MM-dd"}

        If Date.TryParseExact(value, formats, Nothing, Globalization.DateTimeStyles.None, dateValue) Then
            Return dateValue
        End If
        If Date.TryParse(value, dateValue) Then
            Return dateValue
        End If

        Return Date.MinValue
    End Function

    Private Class ReportExcelSection
        Public Sub New(ByVal data As DataTable, ByVal titleColor As Color, Optional ByVal includeTotal As Boolean = True)
            Me.Data = data
            Me.TitleColor = titleColor
            Me.IncludeTotal = includeTotal
        End Sub

        Public Property Data As DataTable
        Public Property TitleColor As Color
        Public Property IncludeTotal As Boolean
    End Class

    Private Function GetReportData(ByVal procedureName As String, ByVal parameters As Dictionary(Of String, Object)) As DataTable
        Dim dt As New DataTable

        Try
            Me.Cursor = Cursors.WaitCursor

            Using conn As System.Data.SqlClient.SqlConnection = clsConn.getSQLConnection()
                Using comm As New System.Data.SqlClient.SqlCommand(procedureName, conn)
                    comm.CommandType = CommandType.StoredProcedure
                    comm.CommandTimeout = 0

                    For Each parameter As KeyValuePair(Of String, Object) In parameters
                        comm.Parameters.AddWithValue(parameter.Key, parameter.Value)
                    Next

                    If procedureName = "P_SO_BOOK_SHIPMENT_REPORT_PKG_generate_report" AndAlso Not comm.Parameters.Contains("@html") Then
                        Dim htmlParameter As System.Data.SqlClient.SqlParameter = comm.Parameters.Add("@html", System.Data.SqlDbType.NVarChar, -1)
                        htmlParameter.Direction = System.Data.ParameterDirection.Output
                    End If

                    Dim da As New System.Data.SqlClient.SqlDataAdapter(comm)
                    da.Fill(dt)

                    If procedureName = "P_SO_BOOK_SHIPMENT_REPORT_PKG_generate_report" AndAlso dt.Rows.Count = 0 AndAlso comm.Parameters.Contains("@html") Then
                        Dim htmlValue As Object = comm.Parameters("@html").Value
                        If htmlValue IsNot Nothing AndAlso htmlValue IsNot DBNull.Value Then
                            dt.Columns.Add("html", GetType(String))
                            Dim row As DataRow = dt.NewRow()
                            row("html") = htmlValue.ToString()
                            dt.Rows.Add(row)
                        End If
                    End If
                End Using
            End Using
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return dt
    End Function

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
