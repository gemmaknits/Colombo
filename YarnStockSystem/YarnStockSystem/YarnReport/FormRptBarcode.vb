Imports CrystalDecisions.CrystalReports.Engine

Public Class FormRptBarcode
    Public Property ReportSource() As ReportDocument  'RptYarnBarcode3
        Get
            ReportSource = CrystalReportViewer1.ReportSource
        End Get
        Set(ByVal NewValue As ReportDocument)  'RptYarnBarcode3)
            CrystalReportViewer1.ReportSource = NewValue
        End Set
    End Property


    Private Sub FormRptBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.Show()
    End Sub
End Class