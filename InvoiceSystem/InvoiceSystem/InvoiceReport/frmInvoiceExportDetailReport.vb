Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmInvoiceExportDetailReport
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo

    Private rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Private fileName As String = "InvExportDetail"
    Private pathname As String = "D:\Temp\"

    Private Const rptFileName = "rptinv_export_det.rpt"
    Private Const OutputToScreen As String = "OutputToScreen"
    Private Const OutputToFileExcel As String = "OutputToFileExcel"
    Private Const OutputToFilePdf As String = "OutputToFilePdf"

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmInvoiceExportDetailReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen

        dtpDateFr.Value = DateAdd(DateInterval.Month, -1, Now)
        dtpDateTo.Value = Now
        tsslUser.Text = clsUser.UserName

        rdbtnFile.Checked = True
        txtPathName.Text = pathname
        txtFileName.Text = fileName
    End Sub

    Private Function getOutputTo()
        Dim result As String = ""

        If rdbtnScreen.Checked Then
            result = OutputToScreen
        ElseIf rdbtnFile.Checked Then
            If RadioButton1.Checked Then
                result = OutputToFileExcel
            ElseIf RadioButton2.Checked Then
                result = OutputToFilePdf
            End If
        End If

        Return result
    End Function

    Private Sub configReport()
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub

        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@invno_start", txtInvFrom.Text.Trim)
        rpt.SetParameterValue("@invno_end", txtInvTo.Text.Trim)

        Dim invdate_start As String = ""
        Dim invdate_end As String = ""
        If dtpDateFr.Checked Then
            If dtpDateTo.Checked Then
                invdate_start = dtpDateFr.Value.ToString("yyyyMMdd")
                invdate_end = dtpDateTo.Value.ToString("yyyyMMdd")
                If invdate_start > invdate_end Then
                    'dtpDateFr.Value = "#" & Mid(invdate_end, 5, 2) & "," & Mid(invdate_end, 7, 2) & "," & Mid(invdate_end, 1, 4) & "#"
                    'dtpDateTo.Value = invdate_start
                    invdate_start = dtpDateTo.Value.ToString("yyyyMMdd")
                    invdate_end = dtpDateFr.Value.ToString("yyyyMMdd")
                End If
            Else
                invdate_start = dtpDateFr.Value.ToString("yyyyMMdd")
                invdate_end = dtpDateFr.Value.ToString("yyyyMMdd")
            End If
        Else
            If dtpDateTo.Checked Then
                invdate_start = dtpDateTo.Value.ToString("yyyyMMdd")
                invdate_end = dtpDateTo.Value.ToString("yyyyMMdd")
            End If
        End If
        rpt.SetParameterValue("@invdate_start", invdate_start)
        rpt.SetParameterValue("@invdate_end", invdate_end)
    End Sub
    Private Sub btnGetDirectoryName_Click(sender As Object, e As EventArgs) Handles btnGetDirectoryName.Click
        Dim SaveFileDialog1 = New SaveFileDialog

        SaveFileDialog1.FileName = txtFileName.Text.Trim
        Select Case getOutputTo()
            Case OutputToFileExcel
                SaveFileDialog1.Filter = "Excel97 File|*.xls"  ''|Excel File|*.xlsx
                SaveFileDialog1.Title = "Save Excel File"
            Case OutputToFilePdf
                SaveFileDialog1.Filter = "Pdf File|*.pdf"
                SaveFileDialog1.Title = "Save Pdf File"
        End Select

        SaveFileDialog1.ShowDialog()

        If DialogResult.OK Then
            ' Get the file name.
            Dim path As String = SaveFileDialog1.FileName
            Try
                Dim fInfo = New System.IO.FileInfo(SaveFileDialog1.FileName)

                txtPathName.Text = fInfo.DirectoryName
                txtFileName.Text = fInfo.Name
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim FileName As String = txtPathName.Text.Trim & "\" & txtFileName.Text.Trim

        configReport()

        Select Case getOutputTo()
            Case OutputToScreen
                Dim frm As New frmReport
                frm.Title = "Invoice Export Detail Report"
                frm.CRViewer.ReportSource = rpt
                frm.MdiParent = Me.ParentForm
                frm.Show()
            Case OutputToFileExcel
                Dim CrFormatTypeOptions As New ExcelFormatOptions 'Dif
                FileName &= ".xls"  'Dif
                ExportToFile(CrFormatTypeOptions, ExportFormatType.Excel, FileName)
            Case OutputToFilePdf
                Dim CrFormatTypeOptions As New PdfFormatOptions   'Dif
                FileName &= ".pdf" 'Dif
                ExportToFile(CrFormatTypeOptions, ExportFormatType.PortableDocFormat, FileName)
            Case Else
                MessageBox.Show("No Output Destination -> Please Contact Programmer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub ExportToFile(CrFormatTypeOptions As Object, ExportFormatType As ObjectFormatProperty, FileName As String)
        Dim CrExportOptions As ExportOptions
        Dim CrDiskFileDestinationOptions As New DiskFileDestinationOptions()

        CrExportOptions = rpt.ExportOptions
        With CrExportOptions
            .FormatOptions = CrFormatTypeOptions 'Dif

            .ExportFormatType = ExportFormatType 'Dif
            .ExportDestinationType = ExportDestinationType.DiskFile
            .DestinationOptions = CrDiskFileDestinationOptions
        End With
        CrDiskFileDestinationOptions.DiskFileName = FileName
        Try
            rpt.Export()
            MsgBox("Export Finished")
            System.Diagnostics.Process.Start(FileName)
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub
    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rdbtnScreen_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnScreen.CheckedChanged
        grpOutputFile.Enabled = False
    End Sub

    Private Sub rdbtnFile_CheckedChanged(sender As Object, e As EventArgs) Handles rdbtnFile.CheckedChanged
        grpOutputFile.Enabled = True
    End Sub
End Class