Imports Microsoft.Reporting.WinForms

Public Class frmPrintIssueTemplate
    Public paramKono As String
    Public reportPath As String
    Private Sub frmPrintIssueTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim objdb As New classProduction
        Dim rds As New ReportDataSource
        dt = objdb.PrintProductIssueTemplate(paramKono)
        rds = New ReportDataSource("dsProductIssuesPrint", dt)
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rds)
        ReportViewer1.LocalReport.EnableExternalImages = True
        ReportViewer1.LocalReport.Refresh()
        ReportViewer1.LocalReport.ReportPath = reportPath + "rptProductIssues.rdlc"
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class