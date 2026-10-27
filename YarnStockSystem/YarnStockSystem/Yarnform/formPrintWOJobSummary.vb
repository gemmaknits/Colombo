Public Class formPrintWOJobSummary

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

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If textWono.Text.Trim.Length > 0 Then
            optSortByJob.Checked = True
        Else
            optSortByKI.Checked = True
        End If

        setupReport()

    End Sub


    Private Sub checkClosedDelivery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.checkClosedProduction.Checked = True
    End Sub

    Private Sub btnSearchKI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchKI.Click
        Dim formSearchKi As New formSearchKO
        Dim selectedKono As String
        selectedKono = formSearchKO.getKono
        If selectedKono <> "" Then
            Me.textWono.Text = selectedKono
        End If

    End Sub
    Private Sub setupReport()
        rptFilename = "rptWOJobSummary.rpt"
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFilename, False) Then
            'Try
            '    Dim rpt As New rptKIJobsummary
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
        Dim inclClosedAfterProd As Integer
        Dim sortBy As String
        Dim kono As String

        fromDate = Me.dtpFromDate.Value.ToString("yyyyMMdd")
        toDate = Me.dtpToDate.Value.ToString("yyyyMMdd")
        inclClosedAfterProd = 0
        sortBy = "WO"
        kono = Me.textWono.Text.Trim

        If checkAllDate.Checked = True Or kono <> "" Then
            fromDate = "19000101"
            toDate = "99990101"
        End If
        If Me.checkClosedProduction.Checked = True Then
            inclClosedAfterProd = 1
        End If
        If Me.optSortByKI.Checked = True Then
            sortBy = "WO"
        Else
            sortBy = "JOB"
        End If
        If kono <> "" Then
            sortBy = "JOB" ' makes sense to sort by job if only one k/o is selected
        End If
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.Database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.UserName, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@fromDate", fromDate)
        rpt.SetParameterValue("@toDate", toDate)
        rpt.SetParameterValue("@inclClosedAfterProd", inclClosedAfterProd)
        rpt.SetParameterValue("@sortBy", sortBy)
        rpt.SetParameterValue("@kono", kono)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Landscape
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "W/O & Greige Delivery Control"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub formPrintKIConsumption_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub textWono_GotFocus(sender As Object, e As EventArgs) Handles textWono.GotFocus
        'If  textWono.Focus Then
        optSortByJob.Checked = True
        'End If
        '.Checked = True
    End Sub

    Private Sub textWono_TextChanged(sender As System.Object, e As System.EventArgs) Handles textWono.TextChanged
        If textWono.Text.Trim.Length > 0 Then
            optSortByJob.Checked = True
        Else
            optSortByKI.Checked = True
        End If
    End Sub

    Private Sub optSortByKI_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles optSortByKI.CheckedChanged
        If textWono.Text.Trim.Length > 0 Then
            textWono.Text = ""
        End If

    End Sub
End Class