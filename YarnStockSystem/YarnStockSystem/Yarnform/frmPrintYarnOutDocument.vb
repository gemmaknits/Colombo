Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Public Class frmPrintYarnOutDocument
    Dim clsUser As New classUserInfo
    Private connStr As New classConnection
    Dim ds As New DataSet

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub printYoutDocument()
        'Dim str As String
        'str = ""
        'ds.Clear()
        'str = "select * from v_yarn_out  " & _
        ' "where outno = '" & Me.txtDocno.Text & "'"

        'Dim myda As New SqlDataAdapter(str.ToString, connStr.connection)
        'myda.Fill(ds, "TblDatayarnout")
        'If ds.Tables("TblDatayarnout").Rows.Count > 0 Then
        '    Dim frmreport As New FormRptYarnOut
        '    Dim rptFileName As String = "RptYarnOut.rpt"
        '    Dim obj As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        '    obj.Load(clsuser.reportpath & rptFileName)
        '    'Dim obj As New RptYarnOut
        '    obj.SetDataSource(ds.Tables("TblDatayarnout"))
        '    frmreport.CrystalReportViewer1.ReportSource = obj
        '    frmreport.ShowDialog()
        'End If
        Dim clsYarnOutBarCode As New classYarnOutBarcode
        Dim rptFileName As String
        rptFileName = "RptYarnOut.rpt"

        Dim dt As DataTable = clsYarnOutBarCode.GetYOutByJob(strJobNo:="", strOutno:=txtDocno.Text.Trim, strlogempcd:=clsUser.UserID)
        If dt.Rows.Count > 0 Then
            If dt.Rows(0)("tran_type").ToString.Trim = "WARPING" Then
                rptFileName = "RptYarnOut.rpt"
            ElseIf dt.Rows(0)("tran_type").ToString.Trim = "KNITTING" Then
                rptFileName = "RptYarnOutKnitting.rpt"
            Else
                rptFileName = "RptYarnOut.rpt"
            End If
        End If

        Dim clsConn As New classConnection
        'Dim rptFileName As String = "RptYarnOut.rpt"
        Dim frm As New frmReport
        Dim clsConfig As New clsConfig

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.ServerName, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@outno", txtDocno.Text)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn OUT"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        printYoutDocument()
    End Sub

    Private Sub btnSearchYout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchYout.Click
        searchYout()
    End Sub
    Private Sub searchYout()
        Dim selectedYarnOut As String
        Dim formSearchyarnOut As New formSearchYarnOut
        selectedYarnOut = formSearchyarnOut.getYarnOutno
        If selectedYarnOut <> "" Then
            Me.txtDocno.Text = selectedYarnOut
        End If
    End Sub

    Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class