Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmPrintJobOrderforYarn
    Private connStr As New classConnection
    Dim ds As New DataSet
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        'Dim str As String
        'str = ""
        'ds.Clear()
        'str = "select * from v_job_yarn  " & _
        '  "where jobno = '" & Me.txtJobno.Text & "' "

        'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        'myda.Fill(ds, "TblDatajobyarn")
        'If ds.Tables("TblDatajobyarn").Rows.Count > 0 Then
        '          Dim frmreport As New FormRptJobOrderforYarn
        '          Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        '          Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '          obj.Load(clsuser.reportpath & rptFileName)
        '          'Dim obj As New RptJobOrderforYarn
        '	obj.SetDataSource(ds.Tables("TblDatajobyarn"))

        '	frmreport.CrystalReportViewer1.ReportSource = obj

        '	frmreport.ShowDialog()
        'End If

        Dim clsConn As New classConnection
        Dim rptFileName As String = "RptJobOrderforYarn.rpt"
        Dim frm As New frmReport
        Dim clsConfig As New clsConfig

        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@jobno", txtJobno.Text)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        ''frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class