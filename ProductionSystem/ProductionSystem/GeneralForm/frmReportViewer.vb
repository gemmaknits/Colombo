Imports Microsoft.Reporting.WinForms

Public Class frmReportViewer
    Public Property Title() As String
        Get
            Title = Me.Text
        End Get
        Set(ByVal NewValue As String)
            Me.Text = NewValue
        End Set
    End Property

    Private Sub frmReportViewer_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmReportViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        '
        'ReportDataSource1.Name = "itcatreport"
        'ReportDataSource1.Value = Me.p_dbx_by_invoice_linesDataTableBindingSource
        'Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        ' Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "china.reportDBXDocument.rdlc"

        Me.rv.RefreshReport()

    End Sub
End Class