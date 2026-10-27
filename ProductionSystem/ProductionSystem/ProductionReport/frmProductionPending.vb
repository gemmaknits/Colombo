Public Class frmProductionPending
    Dim clsUser As New classUserInfo
    Dim clsConn As New classConnection
    Dim clsConfig As New clsConfig
    Dim dt As DataTable

    Private koDtFrom As String = ""
    Private KoDtTo As String = ""
    Private WOStartDtFrom As String = ""
    Private WOStartDtTo As String = ""
    Private WOEndDtFrom As String = ""
    Private WOEndDtTo As String = ""

    'For Browse Dialog
    Private Const DataForFindDesignBeam As String = "DesignBeam"
    Private Const DataForFindDesignBobins As String = "DesignBobins"
    Private Const DataForFindArticleKnitting As String = "ArticleKnitting"

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property

    Private Sub frmProductionPending_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitMachineCombo()
        InitSortByCombo()
        cboSortBy.SelectedIndex = 0
    End Sub

    'Init Form
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
            .Items.Add("WO Create Date")
            .Items.Add("WO Start Date")
            .Items.Add("WO End Date")
            .Items.Add("Design Beam")
            .Items.Add("Design Beam & WO NO.")
            .Items.Add("Article Knitting")
            .Items.Add("Machine")
            .Items.Add("Design Bobins")

            .AutoCompleteCustomSource.Add("WONO")
            .AutoCompleteCustomSource.Add("WOCreateDate")
            .AutoCompleteCustomSource.Add("WOStartDate")
            .AutoCompleteCustomSource.Add("WOEndDate")
            .AutoCompleteCustomSource.Add("DesignBeam")
            .AutoCompleteCustomSource.Add("DesignBeam&WONO")
            .AutoCompleteCustomSource.Add("ArticleKnitting")
            .AutoCompleteCustomSource.Add("Machine")
            .AutoCompleteCustomSource.Add("DesignBobins")
        End With
    End Sub

    'Dialog Find
    Private Sub callFindDialog(pDataForFind As String)
        Dim objDlgGetMasterCode As New DlgGetMasterCode(pDataForFind)

        'Assign parameter
        Select Case pDataForFind
            Case DataForFindDesignBeam
                objDlgGetMasterCode.pDesignBeam = txtDesignBeam.Text.Trim
            Case DataForFindDesignBobins
                objDlgGetMasterCode.pDesignBeam = txtDesignBobins.Text.Trim
            Case DataForFindArticleKnitting
                objDlgGetMasterCode.pArticleKnitting = txtArticleKnitting.Text.Trim
        End Select

        'Call Dialog and return value
        If objDlgGetMasterCode.ShowDialog() = vbOK Then
            Select Case pDataForFind
                Case DataForFindDesignBeam
                    txtDesignBeam.Text = objDlgGetMasterCode.pDesignBeam
                    txtDesignBeamDesc.Text = objDlgGetMasterCode.pDesignBeamDesc
                Case DataForFindDesignBobins
                    txtDesignBobins.Text = objDlgGetMasterCode.pDesignBobins
                    TextBox1.Text = objDlgGetMasterCode.pDesignBobinsDesc
                Case DataForFindArticleKnitting
                    txtArticleKnitting.Text = objDlgGetMasterCode.pArticleKnitting
            End Select
        End If
    End Sub
    Private Sub btnFindDesignBeam_Click(sender As Object, e As EventArgs) Handles btnFindDesignBeam.Click
        callFindDialog(DataForFindDesignBeam)
    End Sub
    Private Sub btnFindDesignBobins_Click(sender As Object, e As EventArgs) Handles btnFindDesignBobins.Click
        callFindDialog(DataForFindDesignBobins)
    End Sub
    Private Sub btnFindArticleKnitting_Click(sender As Object, e As EventArgs) Handles btnFindArticleKnitting.Click
        callFindDialog(DataForFindArticleKnitting)
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
            Case "rptProductionWarpPending.rpt"
                InitCondition(rpt)
                frm.Title = "K/O Production Pending"
            Case "rptStockYOnhandBalanceByItcd.rpt"
                InitDesignStockCondition(rpt, pItCdStock)
                frm.Title = pItCdStock & " Stock On Hand Balance"
            Case "rptStockYOnhandBalanceByBox.rpt"
                InitDesignStockCondition(rpt, pItCdStock)
                frm.Title = pItCdStock & " Yarn Stock Balance Report"
        End Select

        'Call Report
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    'Print Report
    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName As String = ""

        rptFileName = "rptProductionWarpPending.rpt"

        PrintReport(rptFileName, "")
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
    Private Sub InitCondition(rpt As Object)
        SetCondtionKODtDate()
        SetConditonKONo()
        SetCondtionKOStartDate()
        SetCondtionKOEndDate()

        rpt.SetParameterValue("@p_kono_from", txtKONoFrom.Text.Trim)
        rpt.SetParameterValue("@p_kono_to", txtKONoTo.Text.Trim)
        rpt.SetParameterValue("@p_kodt_from", koDtFrom)
        rpt.SetParameterValue("@p_kodt_to", KoDtTo)
        rpt.SetParameterValue("@p_kostartdt_from", WOStartDtFrom)
        rpt.SetParameterValue("@p_kostartdt_to", WOStartDtTo)
        rpt.SetParameterValue("@p_koenddt_from", WOEndDtFrom)
        rpt.SetParameterValue("@p_koenddt_to", WOEndDtTo)
        rpt.SetParameterValue("@p_mcno", cboMC.SelectedValue)
        rpt.SetParameterValue("@p_design_beam", txtDesignBeam.Text.Trim)
        rpt.SetParameterValue("@p_design_bobins", txtDesignBobins.Text.Trim)
        rpt.SetParameterValue("@p_sono", txtSONo.Text.Trim)
        rpt.SetParameterValue("@p_production_order_no_cross", txtKINo.Text.Trim)
        rpt.SetParameterValue("@p_design_cross", txtArticleKnitting.Text.Trim)
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
        rpt.SetParameterValue("@p_design_beam_descp", txtDesignBeamDescp.Text.Trim)
        rpt.SetParameterValue("@p_sortby", cboSortBy.AutoCompleteCustomSource.Item(cboSortBy.SelectedIndex))
    End Sub


    'Print Stock Report
    Private Sub PrintYarnStock(pStockItCd As String)
        Dim rptFileName As String = "rptStockYOnhandBalanceByBox.rpt" '"rptStockYOnhandBalanceByItcd.rpt"
        PrintReport(rptFileName, pStockItCd)
    End Sub
    Private Sub btnPrnStockDesignBeam_Click(sender As Object, e As EventArgs) Handles btnPrnStockDesignBeam.Click
        If txtDesignBeam.Text.Trim = "" Then
            MessageBox.Show("คุณต้องระบุ DesignBeam ที่จะพิมพ์ Stock Balance ก่อนครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            PrintYarnStock(txtDesignBeam.Text.Trim)
        End If
    End Sub
    Private Sub btnPrnStockDesignBobins_Click(sender As Object, e As EventArgs) Handles btnPrnStockDesignBobins.Click
        If txtDesignBobins.Text.Trim = "" Then
            MessageBox.Show("คุณต้องระบุ DesignBobins ที่จะพิมพ์ Stock Balance ก่อนครับ", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            PrintYarnStock(txtDesignBobins.Text.Trim)
        End If
    End Sub
    Private Sub InitDesignStockCondition(rpt As Object, pStockItCd As String)
        rpt.SetParameterValue("@itcd_list", pStockItCd)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@showbeforedate", Nothing)
        rpt.SetParameterValue("@mtl_warehouse_id", Nothing)
        rpt.SetParameterValue("@mtl_subinventory_id", Nothing)
        rpt.SetParameterValue("@mtl_locations_id", Nothing) 'Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class