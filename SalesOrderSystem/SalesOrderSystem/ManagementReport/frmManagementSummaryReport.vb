Imports System.ComponentModel

Public Class frmManagementSummaryReport
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim clsUser As New classUserInfo
    Delegate Sub UpdateStatusCallback(ByVal status As String)
    Delegate Sub PrintReport(ByVal printerSettings As System.Drawing.Printing.PrinterSettings)
    Delegate Sub PrintReportFinishedDelegate(ByVal functionName As String)
    Event PrintReportFinishedEvent As PrintReportFinishedDelegate
    Shared status As Boolean = False

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmManagementSummaryReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dtpMonth.Value = Today
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Dim dialog As New PrintDialog()
        dialog.ShowDialog(Me)
        'Dim thread = New Threading.Thread(AddressOf PrintPOOntime)
        'thread.Start(dialog.PrinterSettings)
        'Threading.ThreadPool.QueueUserWorkItem(AddressOf PrintPOOntime, dialog.PrinterSettings)

        Dim p1 As PrintReport = New PrintReport(AddressOf PrintAllReport)
        p1.BeginInvoke(dialog.PrinterSettings, AddressOf PrintReportCallBack, Nothing)
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PrintAllReport(ByVal printerSettings As System.Drawing.Printing.PrinterSettings)
        PrintPOOntime(printerSettings)
        PrintKOOntime(printerSettings)
        PrintPOOntime(printerSettings)
        PrintKOOntime(printerSettings)
        PrintPOOntime(printerSettings)
        PrintKOOntime(printerSettings)
        PrintPOOntime(printerSettings)
        PrintKOOntime(printerSettings)
    End Sub

    Private Sub PrintPOOntime(ByVal printerSettings As System.Drawing.Printing.PrinterSettings)
        UpdateStatus("Printing P/O Ontime...")
        Dim rptFileName = "rptPOOntime2.rpt"
        Dim params As New Hashtable
        params.Add("@year", dtpMonth.Value.Year.ToString())
        params.Add("@logempcd", clsUser.UserID)
        'clsConfig.PrintReportWithoutPreview(rptFileName, params, clsUser, printerSettings)
        Threading.Thread.Sleep(5000)
        RaiseEvent PrintReportFinishedEvent("PrintPOOntime")
    End Sub

    Private Sub PrintKOOntime(ByVal printerSettings As System.Drawing.Printing.PrinterSettings)
        UpdateStatus("Printing K/O Ontime...")
        Dim rptFileName = "rptKOOntime.rpt"
        Dim params As New Hashtable
        params.Add("@year", dtpMonth.Value.Year.ToString())
        params.Add("@logempcd", clsUser.UserID)
        'clsConfig.PrintReportWithoutPreview(rptFileName, params, clsUser, printerSettings)
        Threading.Thread.Sleep(10000)
        RaiseEvent PrintReportFinishedEvent("PrintKOOntime")
    End Sub

    Private Sub UpdateStatus(ByVal status As String)
        If lblStatus.InvokeRequired Then
            Dim d As New UpdateStatusCallback(AddressOf UpdateStatus)
            Me.Invoke(d, status)
        Else
            lblStatus.Text = status
        End If
    End Sub

    Private Sub PrintReportFinishedMethod(ByVal functionName As String) Handles Me.PrintReportFinishedEvent
        UpdateStatus(functionName)
        If (functionName.Equals("PrintKOOntime")) Then
            If Me.InvokeRequired Then

            Else
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub PrintReportCallBack(ByVal obj As Object)
        'Dim result As IAsyncResult = DirectCast(obj, IAsyncResult)
        'Dim process As PrintReport = DirectCast(result.AsyncState, PrintReport)
        'process.EndInvoke(result)
        UpdateStatus("Finished print report.")
    End Sub
End Class