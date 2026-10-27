Imports System.Data
Imports System.Data.SqlClient
Imports System.Text

Public Class frnDesignMasterSpecificationList
    'Writen By  : Sitthana 20200310

#Region "Property"
    Private _clsUser As classUserInfo

    Public Property clsUser As classUserInfo
        Get
            clsUser = _clsUser
        End Get
        Set(ByVal Newvalue As classUserInfo)
            _clsUser = Newvalue
        End Set
    End Property
#End Region

    '#Class Region
    Dim clsConn As New classConnection
    Private Clsconfig As New clsConfig


    Private Sub frnDesignMasterSpecificatoinList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printReport("rptDesignSpecList.rpt")
    End Sub

    '#Report Region
    Private Sub printReport(pReportName As String)
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        If clsUser.ReportPath = "" Then
            clsUser.ReportPath = "\\172.16.3.11\Reports\" 'clsConf.ReportPath
        End If

        If Not Clsconfig.CheckReport(clsUser.ReportPath, pReportName) Then
            Exit Sub
        End If

        Dim SpecCase As String = ""
        If rbSpecStatusApproved.Checked Then
            SpecCase = "A"
        ElseIf rbSpecStatusDraft.Checked Then
            SpecCase = "D"
        ElseIf rbObsulete.Checked Then
            SpecCase = "O"
        ElseIf rbCancel.Checked Then
            SpecCase = "C"
        ElseIf rbSpecStatusCreated.Checked Then
            SpecCase = "Y"
        Else
            SpecCase = "N"
        End If

        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()


        'Sent Report Parameter Value
        rpt.SetParameterValue("@p_spec_case", SpecCase)
        rpt.SetParameterValue("@p_logempcd", clsUser.UserID)


        'Set Form 
        frm.Title = "Design Master Specification List"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub
End Class