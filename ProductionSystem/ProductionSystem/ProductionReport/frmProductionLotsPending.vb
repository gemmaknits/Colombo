Public Class frmProductionLotsPending
    Dim clsUser As New classUserInfo
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim dt As DataTable

    Private DtWarpFinishFrom As String = ""
    Private DtWarpFinishTo As String = ""
    Private koDtFrom As String = ""
    Private KoDtTo As String = ""
    Private WOStartDtFrom As String = ""
    Private WOStartDtTo As String = ""
    Private WOEndDtFrom As String = ""
    Private WOEndDtTo As String = ""
    Private WarpFinishDtFrom As String = ""
    Private WarpFinishDtTo As String = ""

    'For Browse Dialog
    Private Const DataForFindSystemLotNumber As String = "SystemLotNumber"
    Private Const DataForFindArticleKnitting As String = "ArticleKnitting"

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmProductionLotsPending_Load(sender As Object, e As EventArgs) Handles Me.Load
        InitMachineCombo()
        InitSortByCombo()
        cboSortBy.SelectedIndex = 0
    End Sub
    Private Sub InitMachineCombo()
        Dim objdb As New classProduction

        dt = objdb.comboKoMachines("WO", "")
        cboMC.DataSource = dt
        cboMC.DisplayMember = "mcdesc"
        cboMC.ValueMember = "mcno"
        cboMC.SelectedIndex = -1
    End Sub
    Private Sub InitSortByCombo()
        With cboSortBy
            .Items.Add("WO NO.")
            '.Items.Add("WO Create Date")
            '.Items.Add("WO Start Date")
            .Items.Add("WO End Date")
            .Items.Add("Design Beam")
            .Items.Add("Design Beam & WO NO.")
            .Items.Add("Article Knitting")
            .Items.Add("Machine")
            .Items.Add("Design Bobins")

            .AutoCompleteCustomSource.Add("WONO")
            '.AutoCompleteCustomSource.Add("WOCreateDate")
            '.AutoCompleteCustomSource.Add("WOStartDate")
            .AutoCompleteCustomSource.Add("WOEndDate")
            .AutoCompleteCustomSource.Add("DesignBeam")
            .AutoCompleteCustomSource.Add("DesignBeam&WONO")
            .AutoCompleteCustomSource.Add("ArticleKnitting")
            .AutoCompleteCustomSource.Add("Machine")
            .AutoCompleteCustomSource.Add("DesignBobins")

        End With
    End Sub

    Private Sub callFindDialog(pDataForFind As String)
        Dim objDlgGetMasterCode As New DlgGetMasterCode(pDataForFind)

        'Assign parameter
        Select Case pDataForFind
            Case DataForFindSystemLotNumber
                objDlgGetMasterCode.pDesignBeam = txtSystemLotNumber.Text.Trim
            Case DataForFindArticleKnitting
                objDlgGetMasterCode.pArticleKnitting = txtArticleKnitting.Text.Trim
        End Select

        'Call Dialog and return value
        If objDlgGetMasterCode.ShowDialog() = vbOK Then
            Select Case pDataForFind
                Case DataForFindSystemLotNumber
                    txtSystemLotNumber.Text = objDlgGetMasterCode.pSystemLotNumber
                Case DataForFindArticleKnitting
                    txtArticleKnitting.Text = objDlgGetMasterCode.pArticleKnitting
            End Select
        End If
    End Sub

    'Common Print
    Private Sub PrintReport(pReportFileName As String, pItCdStock As String)
        'Check
        ' If clsUser.ReportPath = "" Then
        ' clsUser.ReportPath = clsConfig.ReportPath
        ' End If
        If Not clsConfig.CheckReport(clsUser.ReportPath, pReportFileName) Then
            Exit Sub
        End If

        'Init Report
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & pReportFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        'Set Report Condition
        Select Case pReportFileName
            Case "rptWarpingProductionReport.rpt" 'rptProductionWarpLotsPending
                InitCondition(rpt)
                frm.Title = "Warping Production Report" '"K/O Production Lots Pending"
        End Select

        'Call Report
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SetConditonKODtWarpFinishDate()
        If dtpKODtFrom.Checked Then
            DtWarpFinishFrom = Format(dtpWarpFinishDateFrom.Value, "yyyyMMdd")
            If dtpKODtTo.Checked Then
                DtWarpFinishTo = Format(dtpWarpFinishDateTo.Value, "yyyyMMdd")
            Else
                DtWarpFinishTo = DtWarpFinishFrom
            End If
            If DtWarpFinishFrom > DtWarpFinishTo Then
                Dim DtTmp As String
                DtTmp = DtWarpFinishFrom
                DtWarpFinishFrom = DtWarpFinishTo
                DtWarpFinishTo = DtTmp
            End If
        Else
            DtWarpFinishFrom = ""
            DtWarpFinishTo = ""
            dtpWOStartDateTo.Checked = False
        End If
    End Sub
    Private Sub SetCondtionKODtDate()
        If dtpKODtFrom.Checked Then
            koDtFrom = Format(dtpKODtFrom.Value, "yyyyMMdd")
            If dtpKODtTo.Checked Then
                KoDtTo = Format(dtpKODtTo.Value, "yyyyMMdd")
            Else
                KoDtTo = koDtFrom
            End If
            If koDtFrom > KoDtTo Then
                Dim DtTmp As String
                DtTmp = koDtFrom
                koDtFrom = KoDtTo
                KoDtTo = DtTmp
            End If
        Else
            koDtFrom = ""
            KoDtTo = ""
            dtpKODtTo.Checked = False
        End If
    End Sub
    Private Sub SetConditonKONo()
        Dim KONoFrom As String = txtKONoFrom.Text.Trim
        Dim KONoTo As String = txtKONoTo.Text.Trim
        If KONoFrom = "" Then
            If KONoTo <> "" Then
                KONoFrom = KONoTo
            End If
        ElseIf KONoTo = "" Then
            KONoTo = KONoFrom
        ElseIf KONoFrom > KONoTo Then
            Dim KONoTmp As String = ""
            KONoTmp = KONoFrom
            KONoFrom = KONoTo
            KONoTo = KONoTmp
        End If
        txtKONoFrom.Text = KONoFrom
        txtKONoTo.Text = KONoTo
    End Sub
    Private Sub SetCondtionKOStartDate()
        If dtpWOStartDateFrom.Checked Then
            WOStartDtFrom = Format(dtpWOStartDateFrom.Value, "yyyyMMdd")
            If dtpWOStartDateTo.Checked Then
                WOStartDtTo = Format(dtpWOStartDateTo.Value, "yyyyMMdd")
            Else
                WOStartDtTo = WOStartDtFrom
            End If
            If WOStartDtFrom > WOStartDtTo Then
                Dim DtTmp As String
                DtTmp = WOStartDtFrom
                WOStartDtFrom = WOStartDtTo
                WOStartDtTo = DtTmp
            End If
        Else
            WOStartDtFrom = ""
            WOStartDtTo = ""
            dtpWOStartDateTo.Checked = False
        End If
    End Sub
    Private Sub SetCondtionKOEndDate()
        If dtpWOEndDateFrom.Checked Then
            WOEndDtFrom = Format(dtpWOEndDateFrom.Value, "yyyyMMdd")
            If dtpWOEndDateTo.Checked Then
                WOEndDtTo = Format(dtpWOEndDateTo.Value, "yyyyMMdd")
            Else
                WOEndDtTo = WOEndDtFrom
            End If
            If WOEndDtFrom > WOEndDtTo Then
                Dim DtTmp As String
                DtTmp = WOEndDtFrom
                WOEndDtFrom = WOEndDtTo
                WOEndDtTo = DtTmp
            End If
        Else
            WOEndDtFrom = ""
            WOEndDtTo = ""
            dtpWOEndDateTo.Checked = False
        End If
    End Sub
    Private Sub SetCondtionWarpFinishDate()
        If dtpWarpFinishDateFrom.Checked Then
            WarpFinishDtFrom = Format(dtpWarpFinishDateFrom.Value, "yyyyMMdd")
            If dtpWarpFinishDateTo.Checked Then
                WarpFinishDtTo = Format(dtpWarpFinishDateTo.Value, "yyyyMMdd")
            Else
                WarpFinishDtTo = WarpFinishDtFrom
            End If
            If WarpFinishDtFrom > WarpFinishDtTo Then
                Dim DtTmp As String
                DtTmp = WarpFinishDtFrom
                WarpFinishDtFrom = WarpFinishDtTo
                WarpFinishDtTo = DtTmp
            End If
        Else
            WarpFinishDtFrom = ""
            WarpFinishDtTo = ""
            dtpWarpFinishDateTo.Checked = False
        End If
    End Sub
    Private Sub InitCondition(rpt As Object)
        SetConditonKODtWarpFinishDate
        SetCondtionKODtDate()
        SetConditonKONo()
        SetCondtionKOStartDate()
        SetCondtionKOEndDate()
        SetCondtionWarpFinishDate()

        rpt.SetParameterValue("@p_kono_from", txtKONoFrom.Text.Trim)
        rpt.SetParameterValue("@p_kono_to", txtKONoTo.Text.Trim)
        rpt.SetParameterValue("@p_kodt_from", koDtFrom)
        rpt.SetParameterValue("@p_kodt_to", KoDtTo)
        rpt.SetParameterValue("@p_kostartdt_from", WOStartDtFrom)
        rpt.SetParameterValue("@p_kostartdt_to", WOStartDtTo)
        rpt.SetParameterValue("@p_koenddt_from", WOEndDtFrom)
        rpt.SetParameterValue("@p_koenddt_to", WOEndDtTo)
        rpt.SetParameterValue("@p_warp_finish_date_from", WarpFinishDtFrom)
        rpt.SetParameterValue("@p_warp_finish_date_to", WarpFinishDtTo)
        rpt.SetParameterValue("@p_mcno", cboMC.SelectedValue)
        rpt.SetParameterValue("@p_Design_Beam", txtDesignBeam.Text.Trim)
        rpt.SetParameterValue("@p_design_bobins", txtDesignBobbins.Text.Trim)
        rpt.SetParameterValue("@p_sono", txtSONo.Text.Trim)
        rpt.SetParameterValue("@p_production_order_no_cross", txtKINo.Text.Trim)
        rpt.SetParameterValue("@p_design_cross", txtArticleKnitting.Text.Trim)
        rpt.SetParameterValue("@p_system_lot_number", txtSystemLotNumber.Text.Trim)
        If rbAllKoStatus.Checked Then
            rpt.SetParameterValue("@p_closed_staus", "")
        ElseIf rbClosedKoStatus.Checked Then
            rpt.SetParameterValue("@p_closed_staus", "1") 'Closed
        ElseIf rbOpenKoStatus.Checked Then
            rpt.SetParameterValue("@p_closed_staus", "0") 'Open
        ElseIf rbPendingKoStatus.Checked Then
            rpt.SetParameterValue("@p_closed_staus", "2") 'Pending
        Else
            rpt.SetParameterValue("@p_closed_staus", "")
        End If
        If rbAllKoCancel.Checked Then
            rpt.SetParameterValue("@p_cancel_staus", "")
        ElseIf rbCancelKo.Checked Then
            rpt.SetParameterValue("@p_cancel_staus", "1")
        ElseIf rbNonCancelKo.Checked Then
            rpt.SetParameterValue("@p_cancel_staus", "0")
        Else
            rpt.SetParameterValue("@p_cancel_staus", "")
        End If
        rpt.SetParameterValue("@p_sortby", cboSortBy.AutoCompleteCustomSource.Item(cboSortBy.SelectedIndex))
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = ""

        rptFileName = "rptWarpingProductionReport.rpt"

        PrintReport(rptFileName, "")
    End Sub

    Private Sub btnFindSystemLotNumber_Click(sender As Object, e As EventArgs) Handles btnFindSystemLotNumber.Click
        callFindDialog(DataForFindSystemLotNumber)
    End Sub

    Private Sub btnFindArticleKnitting_Click(sender As Object, e As EventArgs) Handles btnFindArticleKnitting.Click
        callFindDialog(DataForFindArticleKnitting)
    End Sub



    'Print Report

End Class