Imports System.Text
Imports Syncfusion.XlsIO

Public Class frmCMRLabStatus

    Private objCMR As New ClassCMR

    Private dtCMRLabStatus As New DataTable
    Private bsCMRLabStatus As New BindingSource

    Private clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmCMRLabStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.WindowState = FormWindowState.Maximized

        LoadDataComboBox()
        'LoadData()
        dtpCMRDateFrom.Value = New DateTime(Today.Year - 1, Today.Month, Today.Day)
        dtpCMRDateTo.Value = Today
    End Sub

    Private Sub LoadDataComboBox()

        cboCMRStatus.DataSource = New BindingSource(objCMR.getComboBoxCMRStatus(), Nothing)
        cboCMRStatus.DisplayMember = "Value"
        cboCMRStatus.ValueMember = "Key"
        cboCMRStatus.SelectedIndex = 0

        'Dim key As String = DirectCast(cboCMRStatus.SelectedItem, KeyValuePair(Of String, String)).Key
        'Dim value As String = DirectCast(cboCMRStatus.SelectedItem, KeyValuePair(Of String, String)).Value
        'MessageBox.Show(key & "   " & value)

    End Sub

    Private Sub LoadData(Optional pCMRDateFrom As String = "",
                         Optional pCMRDateTo As String = "",
                         Optional pCMRStatus As String = "ALL")
        Me.Cursor = Cursors.WaitCursor
        dtCMRLabStatus = objCMR.getCMRLabStatus(pCMRDateFrom, pCMRDateTo, pCMRStatus)
        DataBinding()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub DataBinding()
        dgvCMRLabStatus.AutoGenerateColumns = False

        bsCMRLabStatus.DataSource = dtCMRLabStatus
        dgvCMRLabStatus.DataSource = bsCMRLabStatus
        CountRowDataGrid()
    End Sub

    Private Sub CountRowDataGrid()
        tslblTotalRowDataGrid.Text = dgvCMRLabStatus.RowCount
    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        txtFilter.Text = ""
        LoadData(dtpCMRDateFrom.Value, dtpCMRDateTo.Value, cboCMRStatus.Text)
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportToExcel()
    End Sub

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
            'Dim dt As DataTable = TryCast(bsCMRLabStatus.DataSource, DataTable)

            dtCMRLabStatus.DefaultView.RowFilter = bsCMRLabStatus.Filter
            Dim dt As DataTable = dtCMRLabStatus.DefaultView.ToTable()

            worksheet.ImportDataTable(dt, True, 1, 1)
            worksheet.UsedRange.AutofitColumns()

            'Save the workbook to disk in xlsx format
            'workbook.SaveAs("Output.xlsx")

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "File(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveFileDialog1.Title = "Save File"
            saveFileDialog1.FileName = "CMR Lab Status"
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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        Filter()
    End Sub

    'Private Sub Filter_()
    '    Dim strFilter As String
    '    Dim dvResult As DataView = New DataView(dtCMRLabStatus)
    '    strFilter = "cmr_number like '%" & txtFilter.Text & "%'"
    '    strFilter &= " or end_buyer_name like '%" & txtFilter.Text & "%'"
    '    strFilter &= " or color_name like '%" & txtFilter.Text & "%'"
    '    strFilter &= " or colref like '%" & txtFilter.Text & "%'"
    '    dvResult.RowFilter = strFilter
    '    dgvCMRLabStatus.DataSource = dvResult
    '    CountRowDataGrid()
    'End Sub

    Private Sub Filter()
        Dim FilterExp As New StringBuilder
        Dim SearchString As String
        SearchString = txtFilter.Text.Trim
        FilterExp.Append(" cmr_number LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or end_buyer_name LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or color_name LIKE '*" & SearchString & "*'")
        FilterExp.Append(" or colref LIKE '*" & SearchString & "*'")

        If SearchString <> "" Then
            bsCMRLabStatus.Filter = FilterExp.ToString
        Else
            bsCMRLabStatus.Filter = ""
        End If

        'dtCMRLabStatus.DefaultView.RowFilter = bsCMRLabStatus.Filter
        'Dim dt As DataTable = dtCMRLabStatus.DefaultView.ToTable()

        CountRowDataGrid()
    End Sub


End Class