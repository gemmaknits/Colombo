Public Class formPrintKIConsumption
    Dim kono As String
    Dim fromDate As String
    Dim toDate As String
    Dim inclKIClosedAtProduction As Integer
    Dim inclKIClosedAtDelivery As Integer
    Dim rptFilename As String
    Dim reportPath As String
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
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


    Private Sub checkClosedDelivery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.chkClosedKO.Checked = True
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
        rptFilename = "rptKIConsumption.rpt"

        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFilename, False) Then
            Try
                Dim rptFileName As String = "rptKIConsumption.rpt"
                Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                rpt.Load(clsUser.ReportPath & rptFileName)
                'Dim rpt As New rptKIConsumption
                printReport(rpt)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        Else

            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUser.ReportPath & rptFilename)
            printReport(rpt)
        End If
    End Sub
    Private Sub printReport(ByVal rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport
       
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", textKono.Text.Trim)
        rpt.SetParameterValue("@datefr", dtpFromDate.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@dateto", dtpToDate.Value.ToString("yyyyMMdd"))
        rpt.SetParameterValue("@isClosedDate", IIf(optKIClosedDate.Checked, 1, 0))
        rpt.SetParameterValue("@ShowOnlyClosedKO", IIf(chkClosedKO.Checked, 1, 0))
        rpt.SetParameterValue("@ShowOnlyPendingKO", IIf(chkPendingKO.Checked, 1, 0))

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "K/I & Greige Delivery Control"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

 
    Private Sub formPrintKIConsumption_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class