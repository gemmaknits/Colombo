Public Class frmPrintSampleTag
    'Writen By      : Sitthana Boonlom
    'Writen Date    : 20240205

#Region "Properties"
    Private clsUser As classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
#End Region

    Private clsConfig As New clsConfig
    Private clsMaster As New classMaster

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub frmPrintSampleTag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initComboBox()
    End Sub

    Private Sub initComboBox()
        With cbbDesignFamily
            .DataSource = clsMaster.GetSampleFamilyDesign()
            .DisplayMember = "DesignFamily"
            .ValueMember = "DesignFamily"
        End With
    End Sub

    Private Sub tsmnPrintTag_Click(sender As Object, e As EventArgs) Handles tsmnPrintTag.Click
        PrintTag("rptSampleTag.rpt")
    End Sub

    Private Sub PrintTag(pReportName As String)
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath

        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & pReportName)
        rpt.DataSourceConnections.Item(0).SetConnection((New classConnection).servername, (New classConnection).database, False)
        rpt.DataSourceConnections.Item(0).SetLogon((New classConnection).Userid, (New classConnection).Password)

        'Sent parameter to sql database
        rpt.SetParameterValue("@pRoll_No_d", txtRollNo.Text.Trim)

        'Sent Parameter to crystal report
        rpt.SetParameterValue("pFamilyName", cbbDesignFamily.Text.Trim)
        rpt.SetParameterValue("pSrp", txtSrpNo.Text.Trim)

        frm.Title = "Sample Tag"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSearchDyedRoll_Click(sender As Object, e As EventArgs) Handles btnSearchDyedRoll.Click
        Dim frm As New frmSearchDyedRoll
        frm.ShowDialog()

        txtRollNo.Text = frm.Roll_No
    End Sub
End Class