Public Class formPrintKIJobSummary
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

    Private Sub SetControlFixbug()

        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlFixbug(obj)
        Next

    End Sub

    Private Sub SetControlFixbug(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            'Bug Datetime Picker 1 digit When ToolStripButton1 click print or save
            dtpFromDate.CustomFormat = "dd/MM/yyyy"
            dtpFromDate.Format = DateTimePickerFormat.Custom
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj

        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlFixbug(obj2)
            Next
        End If
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Call SetControlFixbug()

        Call setupReport()

    End Sub


    Private Sub checkClosedDelivery_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.checkClosedProduction.Checked = True
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
        Dim rptFilename As String = "rptKIJobSummary.rpt"
        If chkKnitting.Checked = True Then rptFilename = "rptKIJobSummary.rpt"
        If ChkWarping.Checked = True Then rptFilename = "rptWOJobSummary.rpt"



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
        sortBy = "KI"
        kono = Me.textKono.Text.Trim

        If checkAllDate.Checked = True Or kono <> "" Then
            fromDate = "19000101"
            toDate = "99990101"
        End If
        If Me.checkClosedProduction.Checked Then
            inclClosedAfterProd = 1
        End If
        If Me.optSortByKI.Checked Then
            sortBy = "KI"
        Else
            sortBy = "JOB"
        End If
        'Disible By Neung K.Nui need to order by outdt
        'If kono <> "" Then
        '    sortBy = "JOB" ' makes sense to sort by job if only one k/o is selected
        'End If

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

        frm.Title = "Prod Job Summary"
        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

    End Sub

End Class