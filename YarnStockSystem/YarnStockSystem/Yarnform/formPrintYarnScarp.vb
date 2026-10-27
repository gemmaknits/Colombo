Imports System.Data
Imports System.Data.SqlClient
Public Class formPrintYarnScarp
    Dim clsUser As New classUserInfo
    Dim scAutoComplete As New AutoCompleteStringCollection

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property


    Private Sub formPrintYarnScarp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call InitControl()
    End Sub

    Private Sub InitControl()
        Me.dtpDateFr.Value = Date.Now.AddDays(-180)
        Me.dtpDateTo.Value = Date.Now

        Call GetKoNoAutoComplete()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Call printReport()
    End Sub

    Private Sub printReport()
        Dim config As New clsConfig
        Dim classCn As New classConnection

        btnPrint.Enabled = False
        Me.Cursor = Cursors.WaitCursor

        Dim clsConfig As New clsConfig
        Const rptFileName = "rptKOYarn.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(classCn.ServerName, classCn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.UserName, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@datefr", dtpDateFr.Value.Date.ToString("yyyyMMdd")) ' ,(dtpDateFr.Value, "MM/dd/yyyy") 'dtpDateFr.Value.Date.ToString)
        rpt.SetParameterValue("@dateto", dtpDateTo.Value.Date.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@kono", txtKoNo.Text.Trim)
        rpt.SetParameterValue("@ko_group", IIf(chkKI.Checked, "KI", IIf(ChkWO.Checked, "WO", "ALL")))

        Dim frmreport As New frmReport
        frmreport.CRViewer.ReportSource = rpt
        frmreport.MdiParent = Me.MdiParent
        frmreport.CRViewer.Zoom(100)
        frmreport.CRViewer.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub


    Private Sub GetKoNoAutoComplete()
        Dim connStr As New classConnection
        Dim conn As New SqlConnection(connStr.Connection())
        Dim comm As New SqlCommand("", conn)
        Dim da As New SqlDataAdapter(comm)
        'Dim ds As New DataSet
        Dim cmd As New SqlCommand("select kono from ko order by kono desc", conn)
        Dim dr As SqlDataReader
        conn.Open()
        dr = cmd.ExecuteReader
        Do While dr.Read
            scAutoComplete.Add(dr.GetString(0))
        Loop
        conn.Close()

        txtKoNo.AutoCompleteMode = AutoCompleteMode.Suggest
        txtKoNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtKoNo.AutoCompleteCustomSource = scAutoComplete

    End Sub

    Private Sub txtKoNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKoNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call printReport()
        End If
    End Sub

    Private Sub txtKoNo_TextChanged(sender As Object, e As EventArgs) Handles txtKoNo.TextChanged

    End Sub
End Class