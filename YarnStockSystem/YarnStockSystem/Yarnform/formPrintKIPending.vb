Public Class formPrintKIPending
    Dim kono As String
    Dim fromDate As String
    Dim toDate As String
    Dim inclKIClosedAtProduction As Integer
    Dim inclKIClosedAtDelivery As Integer
    Dim rptFilename As String
    Dim reportPath As String
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Private clsUser As New classUserInfo
    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        setupReport()

    End Sub



    Private Sub btnSearchKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchKI.Click
        Dim formSearchKi As New formSearchKO
        Dim selectedKono As String
        selectedKono = formSearchKO.getKono
        If selectedKono <> "" Then
            Me.textKono.Text = selectedKono
        End If

    End Sub
    Private Sub setupReport()
        rptFilename = "rptKIPending.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFilename, False) Then
            'Try
            '    Dim rpt As New rptKIPending
            '    printReport(rpt)
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
        Else

            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUser.ReportPath & rptFilename)
            printReport(rpt)
        End If
    End Sub
    Private Sub printReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport
        Dim fromDate As String
        Dim toDate As String
        Dim kono As String

        fromDate = Me.dtpFromDate.Value.ToString("yyyyMMdd")
        toDate = Me.dtpToDate.Value.ToString("yyyyMMdd")
        kono = Me.textKono.Text.Trim

        If checkAllDate.Checked = True Or kono <> "" Then
            fromDate = "19000101"
            toDate = "99990101"
        End If

        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@fromDate", fromDate)
        rpt.SetParameterValue("@toDate", toDate)
        rpt.SetParameterValue("@kono", kono)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "K/I Pending status report"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub
End Class