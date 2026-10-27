Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class FormRptYarnIn
	Private ds As New DataSet
	Private connStr As New classConnection

	Private Sub FormRptYarnIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		'Dim str As New StringBuilder
		'Dim custid As String = "0002"
		'str.Append("select * from Customers where custcd = '" & custid & "'")
		'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
		'myda.Fill(ds, "TblDataCust")
		'Dim frmreport As New FormRptYarnIn
		'Dim obj As New RptYarnIn
		'obj.SetDataSource(ds.Tables("TblDataCust"))
		'frmreport.CrystalReportViewer1.ReportSource = obj
		'frmreport.ShowDialog()
	End Sub
End Class