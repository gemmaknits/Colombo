Public Class frmRptYarnMaster
    Dim clsUser As New classUserInfo

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Private Sub frmYarnMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitComboBox()
    End Sub
    Private Sub InitComboBox()
        Dim objDB As New classMaster
        With cboItemGroup
            .DataSource = objDB.getDistItemsitgroupcd("YARNS")
            .DisplayMember = "itgroupdesc"
            .ValueMember = "itgroupcd"
        End With
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printReport()
    End Sub

    Private Sub printReport()
        Dim config As New clsConfig
        Dim classCn As New classConnection

        Me.Cursor = Cursors.WaitCursor

        Dim clsConfig As New clsConfig
        Const rptFileName = "rptMasterRYarn.rpt"
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(classCn.servername, classCn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(classCn.Userid, classCn.Password)

        rpt.VerifyDatabase()
        rpt.SetParameterValue("@p_itnaturecd", "YARNS")
        rpt.SetParameterValue("@p_itgroupcd", cboItemGroup.SelectedValue)

        Dim frmreport As New frmReport
        frmreport.CRViewer.ReportSource = rpt
        'frmreport.MdiParent = Me.MdiParent
        frmreport.CRViewer.Zoom(100)
        frmreport.CRViewer.Show()
        Me.Cursor = Cursors.Default
        btnPrint.Enabled = True
        frmreport.Show()
    End Sub
End Class