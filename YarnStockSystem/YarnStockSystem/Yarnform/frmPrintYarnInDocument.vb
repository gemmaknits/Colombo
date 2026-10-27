Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frmPrintYarnInDocument
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
        ''str.Append("SELECT dbo.yarn_in.*, dbo.Yarn_in_det.*  ")
        ''str.Append("FROM   dbo.yarn_in INNER JOIN ")
        ''str.Append("dbo.Yarn_in_det ON dbo.yarn_in.docno = dbo.Yarn_in_det.docno ")
        ''str.Append("where  (dbo.yarn_in.docno =  '" & Me.txtDocno.Text & "')")
        'str = ""
        'ds.Clear()
        '      str = "select * from v_yarn_in  " & _
        '       "where docno = '" & Me.txtDocno.Text & "' order by itcd,boxno_s"

        '      Dim myda As New SqlDataAdapter(str.ToString, connStr.ConnectionString)
        'myda.Fill(ds, "TblDatayarnin")
        'If ds.Tables("TblDatayarnin").Rows.Count > 0 Then
        '          Dim frmreport As New FormRptYarnIn
        '          Dim rptFileName As String = "RptYarnin.rpt"
        '          Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '          obj.Load(clsuser.reportpath & rptFileName)
        '          'Dim obj As New RptYarnin
        '	obj.SetDataSource(ds.Tables("TblDatayarnin"))

        '	frmreport.CrystalReportViewer1.ReportSource = obj


        '	frmreport.ShowDialog()
        'End If
        Dim clsconfig As New clsConfig
        Dim clsConn As New classConnection
        Dim rptFileName As String = "rptYarnIn.rpt"
        Dim frm As New frmReport

        If Not clsConfig.CheckReport(clsuser.reportpath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.reportpath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtDocno.Text)

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
	End Sub

	Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
		Me.Close()
	End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        loadSearchYarnIn()
    End Sub

     Private Sub loadSearchYarnIn()
        Dim selectedYarn As String
        Dim formSearchyarn As New formSearchYarn
        selectedYarn = formSearchyarn.getYarnno()
        If selectedYarn <> "" Then
            Me.txtDocno.Text = selectedYarn
        End If

    End Sub

 
    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        loadSearchYarnIn()
    End Sub
End Class
