Imports System.ComponentModel
Imports Syncfusion.Windows.Forms.Tools
Imports System.Data.SqlClient

Public Class frmRequestGMColorMatch
    'Set Value First When Changed Project Site (Gemmaknits, Eschler)
    Private ProgUsedBy As String = "Eschler"   'Gemmaknits, Eschler
    ' End

    'Declare Var
    Private clsConfig As New clsConfig
    Private clsConn As New classConnection
    Private clsUser As New classUserInfo
    Private clsCMR As New ClassCMR

    '--- For Class
    Private _AllowEdit As Boolean = True
    Private _AllowPrint As Boolean = True
    Private _AllowNew As Boolean = True

    '---
    Private objMaster As New classMaster
    Private objCMR As New ClassCMR
    '--- Table
    Private dtCMRHeader As New DataTable
    Private bsCMRHeader As New BindingSource
    Private dtCMRLines As New DataTable
    Private bsCMRLines As New BindingSource
    Private dtCMRDelivery As New DataTable

    '--- Record
    Dim drv As DataRowView

    Private cmrHeaderID As Integer = 0
    Private CmrNumber As String = ""
    Private SoHeaderId As Integer = 0
    Private LastLineNum As Integer = 0
    Private CurCmrRevisionNumber As Integer = 0
    Private PlanDayAdd As Integer = 0
    Private CmrClosed As String = "N"
    Private CmrCancel As String = "N"

    '--- For Default Value
    Private defaultCmrDocPrefix As String = ""
    Private defaultVendorName As String = ""
    Private defaultGreigeFabricStatusId As Integer = 0
    Private defaultMatchingPriority1Id As Integer = 0
    Private defaultMatchingPriority2Id As Integer = 0
    Private defaultMatchingPriority3Id As Integer = 0
    Private defaultFabricSellingPriceType As Integer = 0
    Private defaultQualityLevel As String = ""
    Private defaultmtlSubInvIDStock As Integer = 0

    Private CustomerID As Integer = 0

    'For Each Project Site
    'Gemmaknits
    Private Const CmrDocPrefixGMK As String = "GK"
    Private Const VendorNameGMK As String = "Gemmaknits"
    Private Const mtlSubinvIdSampleGMK As Integer = 13

    'Eschler
    Private Const CmrDocPrefixEL As String = "EL"
    Private Const VendorNameEL As String = "Eschler"
    Private Const mtlSubinvIdLABGAM As Integer = 46
    'End 

    Private Const ModeNew As String = "New"
    Private Const ModeUpdate As String = "Update"
    Private Const ModeReadOnly As String = "ReadOnly"

    'For Browse Dialog
    Private Const DataForFindCmrNumber As String = "Cmr_Number"
    Private Const DataForFindCmrRevisionHistory As String = "Cmr_RevisionHistory"
    Private Const DataForFindSONo As String = "SONo"
    Private Const DataForFindMasDyeFinFormula As String = "MasDyeFinFormula"
    Private Const DataForFindDesign As String = "Design"
    Private Const DataForFindEndBuyer As String = "EndBuyer"
    Private Const DataForFindSourceDesign As String = "RollNo"
    Private Const DataForFindPreviousCMRNO As String = "PreviousCMRNO"

    Private Const GreigeFabricStatusName As String = "CMR_GRE_FAB_STA"
    Private Const GreigeFabricStatusCode As String = "PFD"
    Private Const MatchingPriority1Name As String = "CMR_MATCH_PRIOR"
    Private Const MatchingPriority1Code As String = "Shade"
    Private Const MatchingPriority2Name As String = "CMR_MATCH_PRIOR"
    Private Const MatchingPriority2Code As String = "Colour fastness"
    Private Const MatchingPriority3Name As String = "CMR_MATCH_PRIOR"
    Private Const MatchingPriority3Code As String = "Cost"
    Private Const FabricSellingPriceTypeName As String = "CMR_FAB_S_P_TYP"
    Private Const FabricSellingPriceTypeCode As String = "Good"
    Private Const QualityLevel As String = "Serious Quality"

    Private Const PlanDateAddOneColor As Integer = 6
    Private Const PlanDateAddMoreThanOneColor As Integer = 10


    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
        End Set
    End Property
    Public Property AllowEdit()
        Get
            Return _AllowEdit
        End Get
        Set(ByVal value)
            _AllowEdit = value
        End Set
    End Property
    Public Property AllowPrint()
        Get
            Return _AllowPrint
        End Get
        Set(ByVal value)
            _AllowPrint = value
        End Set
    End Property
    Public Property AllowNew()
        Get
            Return _AllowNew
        End Get
        Set(ByVal value)
            _AllowNew = value
        End Set
    End Property
    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag
        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub
    Private Sub SetErrorProvider()
        ErrProvider.Clear()
    End Sub
    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()
    End Sub
    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub
    Private Sub SetControlEnabled(ByVal Obj As Control, ByVal blnEnabled As Boolean)
        If TypeOf Obj Is TextBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DateTimePicker Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is ComboBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is CheckBox Then Obj.Enabled = blnEnabled
        If TypeOf Obj Is DataGridView Then
            Dim grd As DataGridView = Obj
            grd.ReadOnly = Not blnEnabled
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlEnabled(obj2, blnEnabled)
            Next
        End If
    End Sub
    Private Function getPlanDayAdd() As Integer
        If dtCMRLines.Rows.Count = 1 Then
            getPlanDayAdd = PlanDateAddOneColor
        Else
            getPlanDayAdd = PlanDateAddMoreThanOneColor
        End If
    End Function
    Private Sub tsbtnCopy_Click(sender As Object, e As EventArgs) Handles tsbtnCopy.Click
        If MessageBox.Show("คุณ ยืนยันที่จะ Copy ข้อมูล ใช่หรือไม่ ?" & vbCr _
                         & "ถ้าคุณตอบ Yes" & vbCr _
                         & Space(5) & "1. โปรแกรมจะลบเฉพาะเลขที่ CMR  จากนั้น" & vbCr _
                         & Space(5) & "2. ให้่คุณตรวจสอบข้อมูลอีกครั้ง " & vbCr _
                         & Space(5) & "3. ให้คุณกดปุ่มบันทึกข้อมูลเพื่อสร้างเอกสารใหม่" _
                         , "ยืนยันการ Copy ข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                           ) = vbYes Then

            Dim PlanDayAdd As Integer = getPlanDayAdd()

            With dtCMRHeader
                .Rows(0)("cmr_header_id") = "-1"
                .Rows(0)("cmr_number") = ""
                .Rows(0)("cmr_date") = Today
                .Rows(0)("need_by_date") = DateAdd(DateInterval.Day, PlanDayAdd, Today)
                .Rows(0)("cmr_closed") = "N"
                .Rows(0)("cmr_revision_number") = 0
            End With
            With dtCMRLines
                If .Rows.Count > 0 Then
                    Dim dttmp As New DataTable
                    dttmp = objCMR.getCmrLinesRecord(-1)
                    Dim dr As DataRow
                    For i As Integer = 0 To .Rows.Count - 1
                        dr = dttmp.NewRow
                        dr("line_num") = i + 1  'Sitthana 20230612
                        dr("color_name") = .Rows(i)("color_name")
                        dr("shades_per_color") = .Rows(i)("shades_per_color")
                        dr("num_of_sets") = .Rows(i)("num_of_sets")
                        dr("need_by_date") = DateAdd(DateInterval.Day, PlanDayAdd, Today)
                        dr("planned_submit_date") = DateAdd(DateInterval.Day, PlanDayAdd, Today)
                        dr("cmr_line_remarks") = ""
                        dttmp.Rows.Add(dr)
                    Next
                    dtCMRLines = Nothing
                    dtCMRLines = dttmp
                    grdCmrLines.DataSource = dtCMRLines
                End If
            End With
            tsbtnCopy.Enabled = False
            tsbtnRelab.Enabled = False
            tsbtnSave.Enabled = True
            tsbtnSaveAsRevision.Enabled = False
            tsbtnSaveAsRevision.Enabled = False

            If cboCmrDocPrefix.SelectedValue = "STG" Then
                cboCmrDocSuffix.Enabled = True
                txtCmrNumber.ReadOnly = False
            End If

            lblGammaTransferAlready.Text = "" 'Sitthana 20230801
            grdCmrLines.ReadOnly = False 'Sitthana 20230801
        End If
    End Sub
    Private Sub tsbtnRelab_Click(sender As Object, e As EventArgs) Handles tsbtnRelab.Click
        If MessageBox.Show("คุณยืนยันที่จะสร้าง ใบสั่งทำแล๊ปอีกครั้ง  และปิดใบสั่งทำแล๊ปเดิม ใช่หรือไม่" _
                         , "ยืนยันสร้าง Relab", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                         ) = vbOK Then
            'If cbRelabCause.Checked = False Then
            '    If MessageBox.Show("อย่างลืมคลิก Check Box 'Relab Cause'" & vbCr & "และป้อนเหตุผล การทำ Relab ด้วยครับ" _
            '             , "แจ้งเตือนข้อมูล", MessageBoxButtons.OKCancel _
            '             , MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2
            '             ) = vbOK Then
            '        tcRemark.SelectedTab = tpRelabCause
            '        cbRelabCause.Checked = True
            '        txtCmrRelabCause.Focus()
            '    End If
            '    Exit Sub
            'End If
            Me.Cursor = Cursors.WaitCursor
            If CreateRelab() Then
                MessageBox.Show("Save Completed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Sitthana 01/02/2018

                LoadData(cmrHeaderID, CmrNumber)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'callFindDialog("Cmr_Number")
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub frmRequestGMColorMatch_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' AddHandler bsBOMHeader.PositionChanged, New EventHandler(AddressOf bsBomHeader_PositionChanged) -understand
        InitControl()
        InitObject()
        InitDefaultValue()
        InitDataBinding()
        InitEnvironment(ModeNew)
    End Sub
    Private Sub InitObject()
        Me.CenterToScreen()

        'grdCmrLines.AutoGenerateColumns = False
        GenCombo()

        'clsConn.servername
        tsbtnSave.Enabled = AllowEdit
        btnNew.Enabled = AllowNew
        tsmnitmCMRForm.Enabled = AllowPrint
        LblCmrClosed.Visible = False

        ' SetcboCmrDocPrefixEnabled()
        'cboCmrDocPrefix.Enabled = True
        tcRemark.TabPages.Remove(tcRemark.TabPages("tpColorChangeCause")) 'Sitthana not yet create field cmr_colorNew_cause 20200827
    End Sub
    Private Sub SetcboCmrDocPrefixEnabled()
        'Only Case Click New Button
        Select Case ProgUsedBy
            Case VendorNameGMK
                cboCmrDocPrefix.Enabled = True
            Case VendorNameEL
                cboCmrDocPrefix.Enabled = False
        End Select
    End Sub
    Private Sub InitDefaultValue()
        defaultGreigeFabricStatusId = objCMR.getLookupValueIdByValCd(GreigeFabricStatusName, GreigeFabricStatusCode) 'PFD -> 401
        defaultMatchingPriority1Id = objCMR.getLookupValueIdByValCd(MatchingPriority1Name, MatchingPriority1Code) 'Shade -> 397
        defaultMatchingPriority2Id = objCMR.getLookupValueIdByValCd(MatchingPriority2Name, MatchingPriority2Code) 'Colour fastness -> 398
        defaultMatchingPriority3Id = objCMR.getLookupValueIdByValCd(MatchingPriority3Name, MatchingPriority3Code) 'Cost -> 396
        defaultFabricSellingPriceType = objCMR.getLookupValueIdByValCd(FabricSellingPriceTypeName, FabricSellingPriceTypeCode) 'Good -> 395
        defaultQualityLevel = QualityLevel
        'Sitthana 20181224
        Select Case ProgUsedBy
            Case VendorNameGMK
                defaultCmrDocPrefix = CmrDocPrefixGMK
                defaultVendorName = VendorNameGMK
                defaultmtlSubInvIDStock = mtlSubinvIdSampleGMK
            Case VendorNameEL
                defaultCmrDocPrefix = CmrDocPrefixEL
                defaultVendorName = VendorNameEL
                defaultmtlSubInvIDStock = mtlSubinvIdLABGAM
        End Select
    End Sub
    Private Sub InitDataBinding()
        ClearDataBindings()
        txtCurStockBalance.Text = ""
        LblCmrClosed.Visible = False
        SetControlValue(Me)
        cmrHeaderID = -1
        dtCMRHeader = objCMR.getCmrHeaderRecord(cmrHeaderID, "")
        bsCMRHeader.DataSource = dtCMRHeader

        Dim nr As DataRow
        nr = dtCMRHeader.NewRow
        dtCMRHeader.Rows.Add(nr)
        bsCMRHeader.MoveFirst()

        dtCMRHeader.Rows(0)("cmr_doc_prefix") = defaultCmrDocPrefix  'Sitthana 20181224
        dtCMRHeader.Rows(0)("customer_name") = defaultVendorName  'Sitthana 20181224
        dtCMRHeader.Rows(0)("greige_fabric_status_id") = defaultGreigeFabricStatusId '401  'PFD
        dtCMRHeader.Rows(0)("matching_priority_1_id") = defaultMatchingPriority1Id   '397  'Shade
        dtCMRHeader.Rows(0)("matching_priority_2_id") = defaultMatchingPriority2Id   '398  'Colour fastness
        dtCMRHeader.Rows(0)("matching_priority_3_id") = defaultMatchingPriority3Id   '396  'Cost
        dtCMRHeader.Rows(0)("fabric_selling_price_type") = defaultFabricSellingPriceType '395 'Good
        dtCMRHeader.Rows(0)("quality_level") = defaultQualityLevel '"Serious Quality" 'Serious Qulity

        BindDataHead()
        getCmrLines(cmrHeaderID)
        txtCurStockBalance.Text = ""
    End Sub
    Private Sub GenCombo()
        cboCmrDocPrefix.DataSource = objCMR.getCmrDocPrefix
        cboCmrDocPrefix.DisplayMember = "cmr_doc_prefix_value"
        cboCmrDocPrefix.ValueMember = "cmr_doc_prefix_id"
        cboCmrDocPrefix.SelectedIndex = 0
        ' cboCmrDocPrefix.Enabled = False 'Enable Only GMK

        cboCmrDocSuffix.DataSource = objCMR.getCmrDocSuffix
        cboCmrDocSuffix.DisplayMember = "cmr_doc_suffix_value"
        cboCmrDocSuffix.ValueMember = "cmr_doc_suffix_id"
        cboCmrDocSuffix.SelectedIndex = 0
        cboCmrDocSuffix.Enabled = True

        cboLabTypeId.DataSource = objCMR.comboLookupCodesSelect("CMR_LAB_TYPE")
        cboLabTypeId.DisplayMember = "lookup_value_short_code"
        cboLabTypeId.ValueMember = "lookup_value_id"
        cboLabTypeId.SelectedIndex = -1

        cboLabDyeingTypeId.DataSource = objCMR.comboLookupCodesSelect("CMR_DYEING_TYPE")
        cboLabDyeingTypeId.DisplayMember = "lookup_value_short_code"
        cboLabDyeingTypeId.ValueMember = "lookup_value_id"
        cboLabDyeingTypeId.SelectedIndex = -1

        cboGreigeFabricStatusId.DataSource = objCMR.comboLookupCodesSelect("CMR_GRE_FAB_STA")
        cboGreigeFabricStatusId.DisplayMember = "lookup_value_short_code"
        cboGreigeFabricStatusId.ValueMember = "lookup_value_id"
        cboGreigeFabricStatusId.SelectedIndex = -1

        cboFabricSellingPriceType.DataSource = objCMR.comboLookupCodesSelect("CMR_FAB_S_P_TYP")
        cboFabricSellingPriceType.DisplayMember = "lookup_value_short_code"
        cboFabricSellingPriceType.ValueMember = "lookup_value_id"
        cboFabricSellingPriceType.SelectedIndex = -1

        cboMatchingPriority1Id.DataSource = objCMR.comboLookupCodesSelect("CMR_MATCH_PRIOR")
        cboMatchingPriority1Id.DisplayMember = "lookup_value_short_code"
        cboMatchingPriority1Id.ValueMember = "lookup_value_id"
        cboMatchingPriority1Id.SelectedIndex = -1

        cboMatchingPriority2Id.DataSource = objCMR.comboLookupCodesSelect("CMR_MATCH_PRIOR")
        cboMatchingPriority2Id.DisplayMember = "lookup_value_short_code"
        cboMatchingPriority2Id.ValueMember = "lookup_value_id"
        cboMatchingPriority2Id.SelectedIndex = -1

        cboMatchingPriority3Id.DataSource = objCMR.comboLookupCodesSelect("CMR_MATCH_PRIOR")
        cboMatchingPriority3Id.DisplayMember = "lookup_value_short_code"
        cboMatchingPriority3Id.ValueMember = "lookup_value_id"
        cboMatchingPriority3Id.SelectedIndex = -1

        cboCmr_Approed_By_Id.DataSource = objCMR.comboLookupCodesSelect("CMR_APPROVED_BY")
        cboCmr_Approed_By_Id.DisplayMember = "lookup_value_short_code"
        cboCmr_Approed_By_Id.ValueMember = "lookup_value_id"
        cboCmr_Approed_By_Id.SelectedIndex = -1

        cboEndUsedId.DataSource = objCMR.comboLookupCodesSelect("CMR_END_USED")
        cboEndUsedId.DisplayMember = "lookup_value_short_code"
        cboEndUsedId.ValueMember = "lookup_value_id"
        cboEndUsedId.SelectedIndex = -1

        cboContrastGarmentTypeId.DataSource = objCMR.comboLookupCodesSelect("CMR_CON_GAM_TYP")
        cboContrastGarmentTypeId.DisplayMember = "lookup_value_short_code"
        cboContrastGarmentTypeId.ValueMember = "lookup_value_id"
        cboContrastGarmentTypeId.SelectedIndex = -1

        cboMixMatchPart1Id.DataSource = objCMR.comboLookupCodesSelect("CMR_MIX_MATCH")
        cboMixMatchPart1Id.DisplayMember = "lookup_value_short_code"
        cboMixMatchPart1Id.ValueMember = "lookup_value_id"
        cboMixMatchPart1Id.SelectedIndex = -1

        cboMixMatchPart2Id.DataSource = objCMR.comboLookupCodesSelect("CMR_MIX_MATCH_2")
        cboMixMatchPart2Id.DisplayMember = "lookup_value_short_code"
        cboMixMatchPart2Id.ValueMember = "lookup_value_id"
        cboMixMatchPart2Id.SelectedIndex = -1

        cboMixMatchPart3Id.DataSource = objCMR.comboLookupCodesSelect("CMR_MIX_MATCH_3")
        cboMixMatchPart3Id.DisplayMember = "lookup_value_short_code"
        cboMixMatchPart3Id.ValueMember = "lookup_value_id"
        cboMixMatchPart3Id.SelectedIndex = -1

        cboSwatchMatching.DataSource = objCMR.getCmrFrontBackSide()
        cboSwatchMatching.DisplayMember = "front_back_side_value"
        cboSwatchMatching.ValueMember = "front_back_side_value"
        cboSwatchMatching.SelectedIndex = 0

        cboMaterialMatching.DataSource = objCMR.getCmrFrontBackSide()
        cboMaterialMatching.DisplayMember = "front_back_side_value"
        cboMaterialMatching.ValueMember = "front_back_side_value"
        cboMaterialMatching.SelectedIndex = 0

        cboQualityLevel.DataSource = objCMR.getCmrQuality()
        cboQualityLevel.DisplayMember = "quality_value"
        cboQualityLevel.ValueMember = "quality_value"
        cboQualityLevel.SelectedIndex = -1

        cboStdTestMethodId.DataSource = objCMR.comboLookupCodesSelect("CMR_STANDARD")
        cboStdTestMethodId.DisplayMember = "lookup_value_short_code"
        cboStdTestMethodId.ValueMember = "lookup_value_id"
        cboStdTestMethodId.SelectedIndex = -1

        cboObserverTypeId.DataSource = objCMR.comboLookupCodesSelect("CMR_OBS_TYPE_ID")
        cboObserverTypeId.DisplayMember = "lookup_value_short_code"
        cboObserverTypeId.ValueMember = "lookup_value_id"
        cboObserverTypeId.SelectedIndex = -1

        cboLightBoxId.DataSource = objCMR.comboLookupCodesSelect("CMR_LIGHT_BOX")
        cboLightBoxId.DisplayMember = "lookup_value_short_code"
        cboLightBoxId.ValueMember = "lookup_value_id"
        cboLightBoxId.SelectedIndex = -1

        cboLightSource1Id.DataSource = objCMR.comboLookupCodesSelect("CMR_LIGHT_SOURC")
        cboLightSource1Id.DisplayMember = "lookup_value_short_code"
        cboLightSource1Id.ValueMember = "lookup_value_id"
        cboLightSource1Id.SelectedIndex = -1

        cboLightSource2Id.DataSource = objCMR.comboLookupCodesSelect("CMR_LIGHT_SOURC")
        cboLightSource2Id.DisplayMember = "lookup_value_short_code"
        cboLightSource2Id.ValueMember = "lookup_value_id"
        cboLightSource2Id.SelectedIndex = -1

        cboLightSource3Id.DataSource = objCMR.comboLookupCodesSelect("CMR_LIGHT_SOURC")
        cboLightSource3Id.DisplayMember = "lookup_value_short_code"
        cboLightSource3Id.ValueMember = "lookup_value_id"
        cboLightSource3Id.SelectedIndex = -1
    End Sub
    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            ClearControlBindings(obj)
        Next
    End Sub
    Private Sub ClearControlBindings(ByVal obj As Control)
        obj.DataBindings.Clear()
        If TypeOf obj Is TabControl Or TypeOf obj Is TabPage Or TypeOf obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In obj.Controls
                Call ClearControlBindings(obj2)
            Next
        End If
    End Sub
    Private Sub BindDataHead()
        'ClearDataBindings()
        Dim i As Integer = bsCMRLines.Current
        bsCMRHeader.MoveFirst()

        cboCmrDocPrefix.DataBindings.Add("selectedvalue", bsCMRHeader, "cmr_doc_prefix")
        cboCmrDocSuffix.DataBindings.Add("selectedvalue", bsCMRHeader, "cmr_doc_suffix") 'Sitthana 28/11/2018
        txtCmrNumber.DataBindings.Add("text", bsCMRHeader, "cmr_number")
        txtCmrRevisionNumber.DataBindings.Add("text", bsCMRHeader, "cmr_revision_number")
        CurCmrRevisionNumber = clsConfig.IsNull(dtCMRHeader.Rows(i)("cmr_revision_number"), 0)
        txtCmrRevisionCause.DataBindings.Add("text", bsCMRHeader, "cmr_revision_cause")

        'txtCmr_Number.Text = dtCMR_Header.Rows(i)("cmr_number")
        'dtpCmr_Date.DataBindings.Add("", bsCMR_Header, "cmr_date")
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("cmr_date"), Today) = Today Then
            dtpCmrDate.Value = Today
        Else
            dtpCmrDate.DataBindings.Add("value", bsCMRHeader, "cmr_date")
        End If
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("need_by_date"), Today) = Today Then
            dtpNeedByDate.Value = Today
        Else
            dtpNeedByDate.DataBindings.Add("Value", bsCMRHeader, "need_by_date")
        End If
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("for_order"), "") = "Y" Then
            cbForOrder.Checked = True
        Else
            cbForOrder.Checked = False
        End If
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("for_sample"), "") = "Y" Then
            cbForSample.Checked = True
        Else
            cbForSample.Checked = False
        End If
        cboLabTypeId.DataBindings.Add("selectedvalue", bsCMRHeader, "lab_type_id")
        txtSONo.DataBindings.Add("text", bsCMRHeader, "sono")

        'Customer Details
        txtRefCustCode.DataBindings.Add("text", bsCMRHeader, "Ref_Cust_Code")
        txtRefCustName.DataBindings.Add("text", bsCMRHeader, "Ref_Cust_Name")
        txtCustomerName.DataBindings.Add("text", bsCMRHeader, "customer_name")
        txtGarmentType.DataBindings.Add("text", bsCMRHeader, "Garment_type")
        txtEndBuyerId.DataBindings.Add("text", bsCMRHeader, "endbuyerid")
        txtEndBuyerName.DataBindings.Add("text", bsCMRHeader, "end_buyer_name")
        txtContactPerson.DataBindings.Add("text", bsCMRHeader, "contact_person")
        cboLabDyeingTypeId.DataBindings.Add("SelectedValue", bsCMRHeader, "lab_dyeing_type_id")

        'Material Details
        'MsgBox(dtCMR_Header.Rows(i)("item_code").ToString)
        txtItemCode.DataBindings.Add("text", bsCMRHeader, "item_code")
        txtItemCustCode.DataBindings.Add("text", bsCMRHeader, "item_cust_code") 'Sitthana 20210115
        txtItemName.DataBindings.Add("text", bsCMRHeader, "item_name")
        txtItemDesc.DataBindings.Add("text", bsCMRHeader, "item_desc")
        txtSourceDesignNo.DataBindings.Add("text", bsCMRHeader, "source_design_no")
        lblStockBalance.Text = "Stock Balance (" & Format(Today, "dd/MM/yyyy").ToString & ")"
        txtCurStockBalance.DataBindings.Add("text", bsCMRHeader, "bal_mts")
        txtYarnStitch.DataBindings.Add("text", bsCMRHeader, "yarn_stitch")
        cboGreigeFabricStatusId.DataBindings.Add("selectedvalue", bsCMRHeader, "greige_fabric_status_id")
        'txtMaterialWidth.DataBindings.Add("text", bsCMR_Header, "finished_width_cm") 'Value same txtFinished_Width_Cm
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("finished_width_cm"), 0) = clsConfig.IsNull(dtCMRHeader.Rows(i)("finished_width_cm_max"), 0) Then
            txtMaterialWidth.Text = Format(clsConfig.IsNull(dtCMRHeader.Rows(i)("finished_width_cm"), 0), "0000")
        Else
            txtMaterialWidth.Text = Format((clsConfig.IsNull(dtCMRHeader.Rows(i)("finished_width_cm"), 0) _
                                  + clsConfig.IsNull(dtCMRHeader.Rows(i)("finished_width_cm_max"), 0)
                                     ) / 2, "0")
        End If

        txtFinishedWidthCmMin.DataBindings.Add("text", bsCMRHeader, "finished_width_cm")
        txtFinishedWidthCmMax.DataBindings.Add("text", bsCMRHeader, "finished_width_cm_max")
        txtFinished_GmPerSqmMin.DataBindings.Add("text", bsCMRHeader, "finished_gmpersqm")
        txtFinishedGmPerSqmMax.DataBindings.Add("text", bsCMRHeader, "finished_gmpersqm_max")
        txtFinishedMtKg.DataBindings.Add("text", bsCMRHeader, "finished_mtkg")
        txtFinId.DataBindings.Add("text", bsCMRHeader, "fin_id")
        txtFinDescp.DataBindings.Add("text", bsCMRHeader, "fin_desc")

        'Stock
        txtSourceDesignNo.Text = txtItemCode.Text.Trim
        If txtItemCode.Text.Trim = "" Then
            txtCurStockBalance.Text = ""
        Else
            getBalanceStock()
        End If


        'Dip submit
        txtShadesPerColor.DataBindings.Add("text", bsCMRHeader, "shades_per_color")
        txtNumOfSets.DataBindings.Add("text", bsCMRHeader, "num_of_sets")
        cboCmr_Approed_By_Id.DataBindings.Add("selectedvalue", bsCMRHeader, "cmr_approval_by_id")
        cboEndUsedId.DataBindings.Add("selectedvalue", bsCMRHeader, "end_use_id")
        txtCmrRemarks.DataBindings.Add("text", bsCMRHeader, "cmr_remarks")

        'Technical Details
        cboFabricSellingPriceType.DataBindings.Add("selectedvalue", bsCMRHeader, "fabric_selling_price_type")
        cboMatchingPriority1Id.DataBindings.Add("selectedvalue", bsCMRHeader, "matching_priority_1_id")
        cboMatchingPriority2Id.DataBindings.Add("selectedvalue", bsCMRHeader, "matching_priority_2_id")
        cboMatchingPriority3Id.DataBindings.Add("selectedvalue", bsCMRHeader, "matching_priority_3_id")

        If clsConfig.IsNull(dtCMRHeader.Rows(i)("contrast_garment"), 0) = "1" Then
            rdContrastGarmentY.Checked = True
            cboContrastGarmentTypeId.Enabled = True
        Else
            rdContrastGarmentN.Checked = True
            cboContrastGarmentTypeId.Enabled = False
        End If
        cboContrastGarmentTypeId.DataBindings.Add("selectedvalue", bsCMRHeader, "contrast_garment_type_id")
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("mix_match_part1_id"), -1) >= 0 Then
            cbMixMatchPart1Id.Checked = True
            cboMixMatchPart1Id.Enabled = True
        Else
            cbMixMatchPart1Id.Checked = False
            cboMixMatchPart1Id.SelectedIndex = -1
            cboMixMatchPart1Id.Enabled = False
        End If
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("mix_match_part2_id"), -1) >= 0 Then
            cbMixMatchPart2Id.Checked = True
            cboMixMatchPart2Id.Enabled = True
        Else
            cbMixMatchPart2Id.Checked = False
            cboMixMatchPart2Id.SelectedIndex = -1
            cboMixMatchPart2Id.Enabled = False
        End If
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("mix_match_part3_id"), -1) >= 0 Then
            cbMixMatchPart3Id.Checked = True
            cboMixMatchPart3Id.Enabled = True
        Else
            cbMixMatchPart3Id.Checked = False
            cboMixMatchPart3Id.SelectedIndex = -1
            cboMixMatchPart3Id.Enabled = False
        End If
        cboMixMatchPart1Id.DataBindings.Add("selectedvalue", bsCMRHeader, "mix_match_part1_id")
        cboMixMatchPart2Id.DataBindings.Add("selectedvalue", bsCMRHeader, "mix_match_part2_id")
        cboMixMatchPart3Id.DataBindings.Add("selectedvalue", bsCMRHeader, "mix_match_part3_id")

        If clsConfig.IsNull(dtCMRHeader.Rows(0)("bisphenol_control"), "N") = "N" Then
            rbBisphenolControl_No.Checked = True
        Else
            rbBisphenolControl_Yes.Checked = True
        End If 'Sitthana 20250205

        If clsConfig.IsNull(dtCMRHeader.Rows(0)("delta_e"), "N") = "N" Then
            rbDeltaENo.Checked = True
        Else
            rbDeltaEYes.Checked = True
        End If 'John 06/03/2026

        If clsConfig.IsNull(dtCMRHeader.Rows(0)("test_report"), "N") = "N" Then
            rbTestReportNo.Checked = True
        Else
            rbTestReportYes.Checked = True
        End If 'John 06/03/2026

        txtMasterColorRef.DataBindings.Add("text", bsCMRHeader, "master_color_ref") 'John 06/03/2026

        Select Case clsConfig.IsNull(dtCMRHeader.Rows(0)("condition_type"), "")
            Case "LMN"
                cbLaminate.Checked = True
                cbMold.Checked = False
            Case "MOLD"
                cbLaminate.Checked = False
                cbMold.Checked = True
            Case Else
                cbLaminate.Checked = False
                cbMold.Checked = False
        End Select 'Sitthana 20250205, 20250314

        txtLaminateConditionFoamNo.DataBindings.Add("text", bsCMRHeader, "laminate_condition_foam_no")
        txtLaminateConditionTemp.DataBindings.Add("text", bsCMRHeader, "laminate_condition_temp")
        txtLaminateConditionDuration.DataBindings.Add("text", bsCMRHeader, "laminate_condition_duration")
        txtLaminateConditionDurationMax.DataBindings.Add("text", bsCMRHeader, "laminate_condition_duration_max") 'Sitthana 20230605
        'If 

        'bsCMR_Lines.Item(bsCMR_Lines.Current)("mold_condition_bubble_type")
        If clsConfig.IsNull(dtCMRHeader.Rows(0)("mold_condition_rigid_type"), 0) = "1" Then
            cbMoldConditionRigidType.Checked = True
        Else
            cbMoldConditionRigidType.Checked = False
        End If
        If clsConfig.IsNull(dtCMRHeader.Rows(0)("mold_condition_bubble_type"), 0) = "1" Then
            cbMoldConditionBubbleType.Checked = True
        Else
            cbMoldConditionBubbleType.Checked = False
        End If
        txtMoldConditionTemp.DataBindings.Add("text", bsCMRHeader, "mold_condition_temp")
        txtMoldConditionDuration.DataBindings.Add("text", bsCMRHeader, "mold_condition_duration")
        txtMoldConditionDurationMax.DataBindings.Add("text", bsCMRHeader, "mold_condition_duration_max")

        cboSwatchMatching.DataBindings.Add("selectedvalue", bsCMRHeader, "swatch_front_back_matching")
        cboMaterialMatching.DataBindings.Add("selectedvalue", bsCMRHeader, "material_front_back_matching")
        If clsConfig.IsNull(dtCMRHeader.Rows(i)("match_with_another_flag"), 0) = "1" Then
            rdMatchWithAnotherFlagY.Checked = True
            txtMatchWithReference.ReadOnly = False
        Else
            rdMatchWithAnotherFlagN.Checked = True
            txtMatchWithReference.ReadOnly = True
        End If
        txtMatchWithReference.DataBindings.Add("text", bsCMRHeader, "match_with_reference")
        txtInternalDocRef.DataBindings.Add("text", bsCMRHeader, "internal_doc_ref")
        cboQualityLevel.DataBindings.Add("selectedvalue", bsCMRHeader, "quality_level")
        cboStdTestMethodId.DataBindings.Add("selectedvalue", bsCMRHeader, "std_test_method_id")
        txtTestMethodOthers.DataBindings.Add("text", bsCMRHeader, "test_method_others")

        'Colour Comarison Method
        txtStdLayers.DataBindings.Add("text", bsCMRHeader, "std_layers")
        txtSampleLayers.DataBindings.Add("text", bsCMRHeader, "sample_layers")

        If clsConfig.IsNull(dtCMRHeader.Rows(0)("lay_on_std"), 0) = "1" Then
            rbLayOnStd.Checked = True
        End If
        If clsConfig.IsNull(dtCMRHeader.Rows(0)("butt_to_std"), 0) = "1" Then
            rbButtToStd.Checked = True
        End If
        cboObserverTypeId.DataBindings.Add("selectedvalue", bsCMRHeader, "observer_type_id")
        cboLightBoxId.DataBindings.Add("selectedvalue", bsCMRHeader, "light_box_id")
        txtStdThichnessLayers.DataBindings.Add("text", bsCMRHeader, "std_thichness_layers")
        cboLightSource1Id.DataBindings.Add("selectedvalue", bsCMRHeader, "light_source_1_id")
        cboLightSource2Id.DataBindings.Add("selectedvalue", bsCMRHeader, "light_source_2_id")
        cboLightSource3Id.DataBindings.Add("selectedvalue", bsCMRHeader, "light_source_3_id")

    End Sub

    Private Sub tsbtnCancel_Click(sender As Object, e As EventArgs) Handles tsbtnCancel.Click
        Dim ConfirmMsg As String = ""
        Dim pCmrCancel As String = ""
        If CmrCancel = "Y" Then
            ConfirmMsg = "ไม่ยกเลิก"
            pCmrCancel = "N"
        Else
            ConfirmMsg = "ยกเลิก"
            pCmrCancel = "Y"
        End If
        If MessageBox.Show("คุณยืนยันที่จะ " & ConfirmMsg & " ใบสั่งทำแล๊ปเลขที่ " & txtCmrNumber.Text.Trim & " ใช่หรือไม่" _
                         , "Cancel Confirm", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                         ) = vbOK Then
            Me.Cursor = Cursors.WaitCursor

            If CancelCMRDoc(pCmrCancel) Then
                MessageBox.Show("ได้ทำการ " & ConfirmMsg & " ใบสั่งทำแล๊ป เรียบร้อยแล้วครับ", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Sitthana 01/02/2018

                LoadData(cmrHeaderID, CmrNumber)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cbForOrderEnable(False)
        InitDataBinding()
        InitEnvironment(ModeNew)
    End Sub


    Private Sub InitEnvironment(pMode As String)
        cbRevisionCause.Checked = False
        txtCmrRevisionCause.ReadOnly = True
        lblGammaTransferAlready.Text = "" 'Sitthana 20230801
        grdCmrLines.ReadOnly = False 'Sitthana 20230801

        Select Case pMode
            Case ModeNew
                'tsmnRevisionHistoryOfLabRequestNo.Enabled = false
                tslblCancelStatus.Text = ""
                tsbtnCopy.Enabled = False
                tsbtnRelab.Enabled = False
                tsbtnSaveAsRevision.Enabled = False
                tsbtnSaveAsRevision.Enabled = False
                tsmnitmCMRForm.Enabled = False
                tsbtnCancel.Enabled = False
                cboCmrDocSuffix.Enabled = True
                txtCmrNumber.ReadOnly = False
                cbForOrderEnable(False)
                lblStockBalance.Text = "Stock Balance"
            Case ModeUpdate
                'tsmnRevisionHistoryOfLabRequestNo.Enabled = True
                tsbtnCopy.Enabled = True
                tsbtnCancel.Enabled = True
                If clsConfig.IsNull(dtCMRHeader.Rows(0)("cmr_closed"), "N") = "Y" Then
                    tsbtnRelab.Enabled = False
                    tsbtnSaveAsRevision.Enabled = False
                    tsbtnSaveAsRevision.Enabled = False
                Else
                    tsbtnRelab.Enabled = True
                    tsbtnSaveAsRevision.Enabled = True
                    tsbtnSaveAsRevision.Enabled = True
                End If
                If CmrCancel = "Y" Then
                    tslblCancelStatus.Text = "Cancel"
                Else
                    tslblCancelStatus.Text = ""
                End If
                If CmrClosed = "Y" Then
                    LblCmrClosed.Visible = True
                Else
                    LblCmrClosed.Visible = False
                End If

                If CmrCancel = "Y" Or CmrClosed = "Y" Then
                    tsbtnSave.Enabled = False
                    tsbtnCopy.Enabled = False
                    tsbtnRelab.Enabled = False
                    tsbtnSaveAsRevision.Enabled = False
                    tsbtnSaveAsRevision.Enabled = False
                    tsmnitmCMRForm.Enabled = True 'Sitthana 20230530
                    tsbtnCancel.Text = "Uncancel"
                Else
                    tsbtnSave.Enabled = True
                    tsbtnCopy.Enabled = True
                    tsbtnRelab.Enabled = True
                    tsbtnSaveAsRevision.Enabled = True
                    tsbtnSaveAsRevision.Enabled = True
                    tsmnitmCMRForm.Enabled = True
                    tsbtnCancel.Text = "Cancel"
                    cboCmrDocSuffix.Enabled = False
                    txtCmrNumber.ReadOnly = True
                End If

                'Check Gamma transfer Data Already
                If clsCMR.GammaTransferDataAlready(txtCmrNumber.Text.Trim) = "N" Then
                    grdCmrLines.ReadOnly = False
                    lblGammaTransferAlready.Text = ""
                Else
                    grdCmrLines.ReadOnly = True 'lock
                    'grdCmrLines.ReadOnly = False 'unlock
                    lblGammaTransferAlready.Text = "Gamma Transfer Data Already"
                End If 'Sitthana 20230801
            Case ModeReadOnly
                tsmnRevisionHistoryOfLabRequestNo.Enabled = False
                tsbtnCopy.Enabled = False
                tsbtnRelab.Enabled = False
                tsbtnSave.Enabled = False
                tsbtnSaveAsRevision.Enabled = False
                tsbtnSaveAsRevision.Enabled = False
                tsmnitmCMRForm.Enabled = True
                tsbtnCancel.Enabled = False
                cboCmrDocSuffix.Enabled = False
                txtCmrNumber.ReadOnly = True
                cbForOrderEnable(False)
        End Select
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles tsbtnSave.Click
        txtCmrNumber.Focus()  'Use for when edit grd and then click save by nothing click anathor object before save
        AskBeforeSave()
    End Sub

    Private Sub tsbtnSaveAsRevision_Click(sender As Object, e As EventArgs) Handles tsbtnSaveAsRevision.Click
        txtCmrNumber.Focus()
        SaveCaseReviseOrNewColor("Revise")
    End Sub
    Private Sub tsbtnSaveAsNewColor_Click(sender As Object, e As EventArgs) Handles tsbtnSaveAsNewColor.Click
        txtCmrNumber.Focus()
        If InStr(1, txtCmrNumber.Text.Trim, "#") > 0 Then
            MessageBox.Show("You can change color 1 time only", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            SaveCaseReviseOrNewColor("NewColor")
        End If
    End Sub
    Private Sub SaveCaseReviseOrNewColor(pSaveType As String)
        Dim ConfirmMessage As String = ""
        Dim WarningMessage As String = ""
        Dim ResultMessage As String = ""

        Select Case pSaveType
            Case "Revise"
                ConfirmMessage = "คุณยืนยันที่จะ Revise ใบสั่งทำแล๊ปเลขที่ "
                WarningMessage = "อย่างลืมคลิก Check Box 'Revision Cause'"
                ResultMessage = "Revision ใบสั่งทำแล๊ป เรียบร้อยแล้วครับ"
            Case "NewColor"
                ConfirmMessage = "คุณยืนยันที่จะ Change Color ของใบสั่งทำแล๊ปเลขที่"
                WarningMessage = "อย่างลืมคลิก Check Box 'Color Change Cause'"
                ResultMessage = "Changed Color ใบสั่งทำแล๊ป เรียบร้อยแล้วครับ"
        End Select

        If MessageBox.Show(ConfirmMessage & txtCmrNumber.Text.Trim & " นี้ ใช่หรือไม่" _
                         , "Confirm Message", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Question, MessageBoxDefaultButton.Button2
                         ) = vbOK Then
            If pSaveType = "Revise" Then
                If cbRevisionCause.Checked = False Then
                    If MessageBox.Show(WarningMessage & vbCr & "และป้อนเหตุผล การเปลี่ยนแปลงแปลง " & pSaveType & " ด้วยครับ" _
                         , "Warning Message", MessageBoxButtons.OKCancel _
                         , MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2
                         ) = vbOK Then
                        tcRemark.SelectedTab = tpRevisionCause
                        cbRevisionCause.Checked = True
                        txtCmrRevisionCause.Focus()
                        Exit Sub
                    End If
                End If
            Else
                'Case Coler New yet create field cmr_color_new_cause
                'If cbColorChangeCause.Checked = False Then
                '    If MessageBox.Show(WarningMessage & vbCr & "และป้อนเหตุผล การเปลี่ยนแปลงแปลง " & pSaveType & " ด้วยครับ" _
                '         , "Warning Message", MessageBoxButtons.OKCancel _
                '         , MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2
                '         ) = vbOK Then
                '        tcRemark.SelectedTab = tpColorChangeCause
                '        cbColorChangeCause.Checked = True
                '        txtColorChangeCause.Focus()
                '        Exit Sub
                '    End If
                'End If
            End If

            Me.Cursor = Cursors.WaitCursor
            If CreateNewRevisionOrNewColor(pSaveType) Then
                MessageBox.Show(ResultMessage, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Sitthana 01/02/2018

                LoadData(cmrHeaderID, CmrNumber)
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub
    Private Sub AskBeforeSave()
        If MessageBox.Show("Would you like to save ?" _
                         , "System Message" _
                         , MessageBoxButtons.YesNo _
                         , MessageBoxIcon.Question _
                         , MessageBoxDefaultButton.Button1
                           ) = vbYes Then
            If Not CheckData() Then Exit Sub

            Me.Cursor = Cursors.WaitCursor
            If SaveData() Then
                MessageBox.Show("Save Completed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Sitthana 01/02/2018

                LoadData(cmrHeaderID, CmrNumber)
            End If
            Me.Cursor = Cursors.Default
        End If
        'End If
        'End If
    End Sub

    Private Function CheckData() As Boolean
        CheckData = True

        Dim ErrMsg As String = ""
        If cbLaminate.Checked = True And cbMold.Checked = True Then
            CheckData = False
            ErrMsg = "You must select Laminate or Mold or not select both" & vbCr _
                   & "(คุณต้องเลิอก Laminate หรือ Mold อย่างใดอย่างหนี่ง หรือไม่เลือกทั้งสอง เท่านั้น)"
        End If

        With grdCmrLines
            If ErrMsg = "" Then
                ErrMsg &= vbCr & "รายการต่อไปนี้ สีห้ามปล่อยว่าง" & vbCr
            End If

            If .Rows.Count > 1 Then
                For i As Integer = 0 To .Rows.Count - 2
                    If .Rows(i).Cells("color_name").Value.ToString.Trim = "" Then
                        ErrMsg &= vbCr & "รายการที่ " & Convert.ToString(i + 1)
                        CheckData = False
                    End If
                Next
                If CheckData = False Then
                    MessageBox.Show(ErrMsg, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End With
    End Function

    Private Function SaveData() As Boolean
        If AllowEdit Or AllowNew Then
            Dim objClassCMR As New ClassCMR
            Dim dtCmrLines As DataTable
            'grdCmr_Lines.EndEdit()
            dtCmrLines = grdCmrLines.DataSource
            bsCMRHeader.EndEdit()
            Dim dv_add As New DataView(grdCmrLines.DataSource, "", "", DataViewRowState.Added)
            Dim dv_upd As New DataView(grdCmrLines.DataSource, "", "", DataViewRowState.ModifiedCurrent)
            Dim dv_del As New DataView(grdCmrLines.DataSource, "", "", DataViewRowState.Deleted)

            Dim errmsg As String = ""

            Dim TotalNewLine As Integer

            TotalNewLine = dv_add.Count
            CheckAndVerifyData(TotalNewLine)

            Try
                dtCMRHeader = objCMR.CMRNewSave(drv, dtLines:=grdCmrLines.DataSource, dv_del:=dv_del, p_CurCmrRevisionNumber:=CurCmrRevisionNumber, p_log_empcd:=UserInfo.UserID, pLastLineNum:=LastLineNum)
                cmrHeaderID = dtCMRHeader.Rows(0)("cmr_header_id") 'drv.Item("cmr_header_id")
                CmrNumber = dtCMRHeader.Rows(0)("cmr_number") 'drv.Item("cmr_number") 'dtCMR_Header.Rows(i)("cmr_number")
                txtCmrNumber.Text = CmrNumber

                SaveData = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                SaveData = False
            End Try
        Else
            MessageBox.Show("Permission denied", "Security message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Function
    Private Sub setdtNewRequiredPlanDate()
        PlanDayAdd = getPlanDayAdd()
        With dtCMRHeader
            .Rows(0)("cmr_date") = Today
            dtCMRHeader.Rows(0)("need_by_date") = DateAdd(DateInterval.Day, PlanDayAdd, Today)
            dtpNeedByDate.Value = DateAdd(DateInterval.Day, PlanDayAdd, Today)
        End With
        With dtCMRLines
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    .Rows(0)("need_by_date") = DateAdd(DateInterval.Day, PlanDayAdd, Today)
                    .Rows(0)("planned_submit_date") = DateAdd(DateInterval.Day, PlanDayAdd, Today)
                Next
            End If
        End With
    End Sub
    Private Function CreateRelab() As Boolean
        If AllowEdit Or AllowNew Then
            Dim objClassCMR As New ClassCMR

            Dim errmsg As String = ""

            If IsDBNull(dtCMRHeader.Rows(0)("cmr_header_id")) Then
                MessageBox.Show("ไม่สามารถ Relab ได้ เนื่องจาก cmr_header_id ผิดพลาด" & vbCr _
                              & "  ให้คุณติดต่อโปรแกรมเมอร์" _
                                , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If

            Try
                setdtNewRequiredPlanDate()

                dtCMRHeader = objCMR.CMRRelabSave(dtCMRHeader.Rows(0)("cmr_header_id") _
                                                 , UserInfo.UserID _
                                                 , PlanDayAdd _
                                                 , txtCmrRelabCause.Text.Trim
                                                 )
                cmrHeaderID = dtCMRHeader.Rows(0)("cmr_header_id") 'drv.Item("cmr_header_id")
                CmrNumber = dtCMRHeader.Rows(0)("cmr_number") 'drv.Item("cmr_number") 'dtCMR_Header.Rows(i)("cmr_number")

                txtCmrNumber.Text = CmrNumber

                CreateRelab = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                CreateRelab = False
            End Try
        Else
            MessageBox.Show("Permission denied", "Security message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Function
    Private Function CreateNewRevisionOrNewColor(pSaveType As String) As Boolean
        'pSaveType = "Revise", "NewColor"
        If AllowEdit Or AllowNew Then
            Dim objClassCMR As New ClassCMR

            ' Dim errmsg As String = ""

            If IsDBNull(dtCMRHeader.Rows(0)("cmr_header_id")) Then
                MessageBox.Show("ไม่สามารถ Create " & pSaveType & " ได้ เนื่องจาก cmr_header_id ผิดพลาด" & vbCr _
                              & "  ให้คุณติดต่อโปรแกรมเมอร์" _
                                , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Function
            End If

            Try
                If pSaveType = "Revise" Then
                    dtCMRHeader = objCMR.CMRRevisionSave(dtCMRHeader.Rows(0)("cmr_header_id") _
                                                       , CurCmrRevisionNumber + 1 _
                                                       , Trim(txtCmrRevisionCause.Text) _
                                                       , UserInfo.UserID
                                                        )
                Else
                    dtCMRHeader = objCMR.CMRNewColorSave(dtCMRHeader.Rows(0)("cmr_header_id") _
                                                       , txtCmrNumber.Text.Trim _
                                                       , UserInfo.UserID
                                                        )
                End If

                cmrHeaderID = dtCMRHeader.Rows(0)("cmr_header_id") 'drv.Item("cmr_header_id")
                CmrNumber = dtCMRHeader.Rows(0)("cmr_number") 'drv.Item("cmr_number") 'dtCMR_Header.Rows(i)("cmr_number")
                txtCmrNumber.Text = CmrNumber

                CreateNewRevisionOrNewColor = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                CreateNewRevisionOrNewColor = False
            End Try
        Else
            MessageBox.Show("Permission denied", "Security message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Function
    Private Function CancelCMRDoc(pCmrCancel As String) As Boolean
        If AllowEdit Or AllowNew Then
            Dim objClassCMR As New ClassCMR
            Try
                cmrHeaderID = dtCMRHeader.Rows(0)("cmr_header_id")
                objCMR.CMRCancelDoc(cmrHeaderID _
                                  , pCmrCancel _
                                  , UserInfo.UserID
                                   )

                CancelCMRDoc = True
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                CancelCMRDoc = False
            End Try
        End If
    End Function
    Private Sub CheckAndVerifyData(pTotalNewLine As Integer)
        drv = CType(bsCMRHeader.Current, DataRowView)

        cmrHeaderID = clsConfig.IsNull(drv.Item("cmr_header_id"), -1)
        If cboCmrDocPrefix.SelectedIndex = -1 Then
            cboCmrDocPrefix.SelectedIndex = 0
        End If
        drv.Item("cmr_doc_prefix") = cboCmrDocPrefix.SelectedValue
        If cboCmrDocSuffix.SelectedIndex = -1 Then
            cboCmrDocSuffix.SelectedIndex = 0
        End If
        drv.Item("cmr_doc_suffix") = cboCmrDocSuffix.SelectedValue 'Sitthana 28/11/2018
        If txtCmrNumber.Text.Trim = "" Then
            drv.Item("Cmr_Number") = ""
        Else
            drv.Item("Cmr_Number") = txtCmrNumber.Text.Trim
        End If
        drv.Item("cmr_date") = dtpCmrDate.Value
        drv.Item("Need_By_Date") = dtpNeedByDate.Value

        drv.Item("last_line_num") = LastLineNum + pTotalNewLine
        '--- Order Details
        If cbForOrder.Checked Then
            drv.Item("for_order") = "Y"
        Else
            drv.Item("for_order") = "N"
        End If
        If cbForSample.Checked Then
            drv.Item("for_sample") = "Y"
        Else
            drv.Item("for_sample") = "N"
        End If
        If cboLabTypeId.Text.Trim = "" Then
            drv.Item("lab_type_id") = -1
        Else
            drv.Item("lab_type_id") = cboLabTypeId.SelectedValue
        End If
        '--- Material Details
        If cboGreigeFabricStatusId.Text.Trim = "" Then
            drv.Item("greige_fabric_status_id") = -1
        Else
            drv.Item("greige_fabric_status_id") = cboGreigeFabricStatusId.SelectedValue
        End If
        '--- Customer Details
        If cboLabDyeingTypeId.Text.Trim = "" Then
            drv.Item("lab_dyeing_type_id") = -1
        Else
            drv.Item("lab_dyeing_type_id") = cboLabDyeingTypeId.SelectedValue
        End If
        '--- Dip submit
        If cboCmr_Approed_By_Id.Text.Trim = "" Then
            drv.Item("cmr_approval_by_id") = -1
        Else
            drv.Item("cmr_approval_by_id") = cboCmr_Approed_By_Id.SelectedValue
        End If
        If cboEndUsedId.Text.Trim = "" Then
            drv.Item("end_use_id") = -1
        Else
            drv.Item("end_use_id") = cboEndUsedId.SelectedValue
        End If
        '--- Technical Details
        If cboFabricSellingPriceType.Text.Trim = "" Then
            drv.Item("fabric_selling_price_type") = -1
        Else
            drv.Item("fabric_selling_price_type") = cboFabricSellingPriceType.SelectedValue
        End If
        If cboMatchingPriority1Id.Text.Trim = "" Then
            drv.Item("matching_priority_1_id") = -1
        Else
            drv.Item("matching_priority_1_id") = cboMatchingPriority1Id.SelectedValue
        End If
        If cboMatchingPriority2Id.Text.Trim = "" Then
            drv.Item("matching_priority_2_id") = -1
        Else
            drv.Item("matching_priority_2_id") = cboMatchingPriority2Id.SelectedValue
        End If
        If cboMatchingPriority3Id.Text.Trim = "" Then
            drv.Item("matching_priority_3_id") = -1
        Else
            drv.Item("matching_priority_3_id") = cboMatchingPriority3Id.SelectedValue
        End If
        If rdContrastGarmentY.Checked Then
            drv.Item("contrast_garment") = "1"
        Else
            drv.Item("contrast_garment") = "0"
            drv.Item("contrast_garment_type_id") = -1
        End If
        If cboMixMatchPart1Id.Text.Trim = "" Then
            drv.Item("mix_match_part1_id") = -1
        Else
            drv.Item("mix_match_part1_id") = cboMixMatchPart1Id.SelectedValue
        End If
        If cboMixMatchPart2Id.Text.Trim = "" Then
            drv.Item("mix_match_part2_id") = -1
        Else
            drv.Item("mix_match_part2_id") = cboMixMatchPart2Id.SelectedValue
        End If
        If cboMixMatchPart3Id.Text.Trim = "" Then
            drv.Item("mix_match_part3_id") = -1
        Else
            drv.Item("mix_match_part3_id") = cboMixMatchPart3Id.SelectedValue
        End If
        If rbBisphenolControl_Yes.Checked = True Then
            drv.Item("bisphenol_control") = "Y"
        Else
            drv.Item("bisphenol_control") = "N"
        End If 'Sitthana 20250204

        If rbDeltaEYes.Checked = True Then
            drv.Item("delta_e") = "Y"
        Else
            drv.Item("delta_e") = "N"
        End If ' John 06/03/2026

        If rbTestReportYes.Checked = True Then
            drv.Item("test_report") = "Y"
        Else
            drv.Item("test_report") = "N"
        End If ' John 06/03/2026

        If cbLaminate.Checked Then
            drv.Item("condition_type") = "LMN"
        ElseIf cbMold.Checked Then
            drv.Item("condition_type") = "MOLD"
        Else
            drv.Item("condition_type") = "" 'Sitthana 20250314
        End If 'Sitthana 20250204
        If cbMoldConditionBubbleType.Checked Then
            drv.Item("mold_condition_bubble_type") = "1"
        Else
            drv.Item("mold_condition_bubble_type") = "0"
        End If
        If cbMoldConditionRigidType.Checked Then
            drv.Item("mold_condition_rigid_type") = "1"
        Else
            drv.Item("mold_condition_rigid_type") = "0"
        End If
        If rdMatchWithAnotherFlagY.Checked Then
            drv.Item("match_with_another_flag") = "1"
        Else
            drv.Item("match_with_another_flag") = "0"
            drv.Item("match_with_reference") = ""
        End If
        If cboQualityLevel.Text.Trim = "" Then
            drv.Item("quality_level") = -1
        Else
            drv.Item("quality_level") = cboQualityLevel.SelectedValue
        End If
        If cboStdTestMethodId.Text.Trim = "" Then
            drv.Item("std_test_method_id") = -1
        Else
            drv.Item("std_test_method_id") = cboStdTestMethodId.SelectedValue
        End If
        If rbButtToStd.Checked Then
            drv.Item("butt_to_std") = "1"
        Else
            drv.Item("butt_to_std") = "0"
        End If
        If rbLayOnStd.Checked Then
            drv.Item("lay_on_std") = "1"
        Else
            drv.Item("lay_on_std") = "0"
        End If
        If cboObserverTypeId.Text.Trim = "" Then
            drv.Item("observer_type_id") = -1
        Else
            drv.Item("observer_type_id") = cboObserverTypeId.SelectedValue
        End If
        If cboLightBoxId.Text.Trim = "" Then
            drv.Item("light_box_id") = -1
        Else
            drv.Item("light_box_id") = cboLightBoxId.SelectedValue
        End If
        If cboSwatchMatching.Text.Trim = "" Then
            drv.Item("swatch_front_back_matching") = -1
        Else
            drv.Item("swatch_front_back_matching") = cboSwatchMatching.SelectedValue
        End If
        If cboMaterialMatching.Text.Trim = "" Then
            drv.Item("material_front_back_matching") = -1
        Else
            drv.Item("material_front_back_matching") = cboMaterialMatching.SelectedValue
        End If

    End Sub
    Private Sub frmRequestGMColorMatch_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If clsConfig.ConfirmExitPrg("Gammma Colour Matchinge Request") = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub LoadData(Optional ByVal pCmrHeaderId As Integer = 0, Optional pCmrNumber As String = "")
        ClearDataBindings()
        dtCMRHeader = objCMR.getCmrHeaderRecord(pCmrHeaderId, pCmrNumber)
        If dtCMRHeader.Rows.Count = 0 Then
            If MessageBox.Show("ไม่พบข้อมูล Lab Request No. " & pCmrNumber _
                             & "   คุณต้องการที่จะสร้างรายการใหม่ย้อนหลัง ด้วยเลขที่นี้ใช่หรือไม่ ?" _
                             , "ผลการค้นหาข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question _
                             , MessageBoxDefaultButton.Button2) = vbYes Then
                CmrNumber = txtCmrNumber.Text.Trim
                ' cboCmrDocPrefix.Enabled = False
                cboCmrDocSuffix.Enabled = False
                txtCmrNumber.ReadOnly = True
                tsbtnCopy.Enabled = False
                tsbtnRelab.Enabled = False
                tsbtnSaveAsRevision.Enabled = False
                tsbtnSaveAsRevision.Enabled = False
                LastLineNum = 0
                InitEnvironment("New")
            Else
                txtCmrNumber.Text = ""
            End If
        Else
            ClearDataBindings()
            bsCMRHeader.DataSource = dtCMRHeader
            bsCMRHeader.MoveFirst()
            drv = CType(bsCMRHeader.Current, DataRowView)
            cmrHeaderID = dtCMRHeader.Rows(0)("cmr_header_id")
            LastLineNum = dtCMRHeader.Rows(0)("last_line_num")
            CmrClosed = clsConfig.IsNull(dtCMRHeader.Rows(0)("cmr_closed"), "N")
            CmrCancel = clsConfig.IsNull(dtCMRHeader.Rows(0)("cmr_cancel"), "N")
            BindDataHead()
            getCmrLines(cmrHeaderID)
            getCmrDelivery(dtCMRHeader.Rows(0)("cmr_number"))

            InitEnvironment("Update")
        End If
    End Sub
    Private Sub LoadCmrHeaderLogData(Optional ByVal pCmrHeaderId As Integer = 0, Optional pCmrNumber As String = "")

        ClearDataBindings()
        dtCMRHeader = objCMR.getCmrHeaderLogRecord(pCmrHeaderId, pCmrNumber)
        If dtCMRHeader.Rows.Count = 0 Then
            MessageBox.Show("ไม่พบข้อมูล History Of Lab Request No. " & pCmrNumber _
                             , "ผลการค้นหาข้อมูล", MessageBoxButtons.YesNo, MessageBoxIcon.Question _
                             , MessageBoxDefaultButton.Button2)
        Else
            ClearDataBindings()
            bsCMRHeader.DataSource = dtCMRHeader
            bsCMRHeader.MoveFirst()
            drv = CType(bsCMRHeader.Current, DataRowView)
            cmr_header_id = dtCMRHeader.Rows(0)("cmr_header_id")
            LastLineNum = dtCMRHeader.Rows(0)("last_line_num")
            BindDataHead()
            getHistoryCmrLines(pCmrHeaderId)
            getCmrDelivery(dtCMRHeader.Rows(0)("cmr_number"))

            InitEnvironment("ReadOnly")
        End If
    End Sub
    Private Sub getCmrLines(pCmrHeaderId As Integer)
        dtCMRLines = Nothing
        dtCMRLines = objCMR.getCmrLinesRecord(pCmrHeaderId)
        grdCmrLines.AutoGenerateColumns = False
        grdCmrLines.DataSource = dtCMRLines
    End Sub
    Private Sub getHistoryCmrLines(pCmrHeaderId As Integer)
        dtCMRLines = Nothing
        dtCMRLines = objCMR.getCmrLinesLogRecord(pCmrHeaderId)
        grdCmrLines.AutoGenerateColumns = False
        grdCmrLines.DataSource = dtCMRLines
    End Sub
    Private Sub getCmrDelivery(pCmrNumber As String)
        dtCMRDelivery = Nothing
        dtCMRDelivery = objCMR.getCmrDeliveryRecord(pCmrNumber)
        grdCmrDelivery.AutoGenerateColumns = False
        grdCmrDelivery.DataSource = dtCMRDelivery
    End Sub
    Private Sub btnSave_Disposed(sender As Object, e As EventArgs) Handles tsbtnSave.Disposed

    End Sub

    Private Sub rdContrastGarmentY_Click(sender As Object, e As EventArgs) Handles rdContrastGarmentY.Click
        cboContrastGarmentTypeId.Enabled = True
    End Sub

    Private Sub rdContrastGarmentN_Click(sender As Object, e As EventArgs) Handles rdContrastGarmentN.Click
        cboContrastGarmentTypeId.Enabled = False
    End Sub

    Private Sub cbMixMatchPart1Id_CheckedChanged(sender As Object, e As EventArgs) Handles cbMixMatchPart1Id.CheckedChanged
        If cbMixMatchPart1Id.Checked Then
            cboMixMatchPart1Id.Enabled = True
        Else
            cboMixMatchPart1Id.SelectedIndex = -1
            cboMixMatchPart1Id.Enabled = False
        End If
    End Sub

    Private Sub cbMixMatchPart2Id_CheckedChanged(sender As Object, e As EventArgs) Handles cbMixMatchPart2Id.CheckedChanged
        If cbMixMatchPart2Id.Checked Then
            cboMixMatchPart2Id.Enabled = True
        Else
            cboMixMatchPart2Id.SelectedIndex = -1
            cboMixMatchPart2Id.Enabled = False
        End If
    End Sub

    Private Sub cbMixMatchPart3Id_CheckedChanged(sender As Object, e As EventArgs) Handles cbMixMatchPart3Id.CheckedChanged
        If cbMixMatchPart3Id.Checked Then
            cboMixMatchPart3Id.Enabled = True
        Else
            cboMixMatchPart3Id.SelectedIndex = -1
            cboMixMatchPart3Id.Enabled = False
        End If
    End Sub

    Private Sub rdMatchWithAnotherFlagY_Click(sender As Object, e As EventArgs) Handles rdMatchWithAnotherFlagY.Click
        txtMatchWithReference.ReadOnly = False
        btnFindPreviousCMRNo.Enabled = True
    End Sub

    Private Sub rdMatch_With_Another_Flag_N_Click(sender As Object, e As EventArgs) Handles rdMatchWithAnotherFlagN.Click
        txtMatchWithReference.ReadOnly = True
        txtMatchWithReference.Text = ""
        btnFindPreviousCMRNo.Enabled = False
    End Sub

    '--- KeyPress for Get data
    Private Sub txtCmrNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCmrNumber.KeyPress
        If e.KeyChar = vbCr Then
            If txtCmrNumber.Text.Trim <> "" Then
                LoadData(0, txtCmrNumber.Text.Trim)
            End If
        End If
    End Sub
    Private Sub txtSONo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSONo.KeyPress
        If e.KeyChar = vbCr Then
            If txtSONo.Text.Trim = "" Then
                MessageBox.Show("คุณยังไม่ได้ระบุเลขที่ So", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim objDB As New classSalesOrder
                Dim dt As New DataTable
                dt = objDB.getSoData(txtSONo.Text.Trim)

                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)("sample_order") = 1 Then
                        cbForSample.Checked = True
                        cbForOrder.Checked = False
                    Else
                        cbForSample.Checked = False
                        cbForOrder.Checked = True
                    End If
                Else
                    MessageBox.Show("ไม่พบข้อมูลเลขที่ So ที่คุณป้อน ให้คุณลองอีกครั้ง", "แจ้งข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cbForSample.Checked = False
                    cbForOrder.Checked = False
                End If
            End If
        End If
    End Sub
    Private Sub txtFinId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinId.KeyPress
        If e.KeyChar = vbCr Then
            If txtFinId.Text.Trim <> "" Then
                Dim objDB As New ClassCMR
                Dim dt As New DataTable
                dt = objDB.getMasDyeFinFormulaData(txtFinId.Text.Trim)
                If dt.Rows.Count > 0 Then
                    txtFinDescp.Text = dt.Rows(0)("FinDescp")
                Else
                    txtFinDescp.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub txtItemCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemCode.KeyPress
        If e.KeyChar = vbCr Then
            If txtItemCode.Text.Trim <> "" Then
                Dim objDB As New ClassCMR
                Dim dt As New DataTable
                dt = objDB.getDesignData(txtItemCode.Text.Trim)
                If dt.Rows.Count > 0 Then
                    txtItemName.Text = dt.Rows(0)("refdesno")
                    txtItemDesc.Text = dt.Rows(0)("compo")
                    txtMaterialWidth.Text = dt.Rows(0)("MaterialWidth")
                    If clsConfig.IsNull(dt.Rows(0)("FinishedWidthMin"), 0) = 0 Then
                        txtFinishedWidthCmMin.Text = dt.Rows(0)("FinishedWidth") 'Sitthana 20230605
                    Else
                        txtFinishedWidthCmMin.Text = dt.Rows(0)("FinishedWidthMin")
                    End If
                    txtFinishedWidthCmMax.Text = dt.Rows(0)("FinishedWidthMax")

                    If clsConfig.IsNull(dt.Rows(0)("FinishedWeightMin"), 0) = 0 Then
                        txtFinished_GmPerSqmMin.Text = clsConfig.IsNull(dt.Rows(0)("FinishedWeight"), 0)
                    Else
                        txtFinished_GmPerSqmMin.Text = clsConfig.IsNull(dt.Rows(0)("FinishedWeightMin"), 0)
                    End If
                    txtFinishedGmPerSqmMax.Text = dt.Rows(0)("FinishedWeightMax")

                    txtFinishedMtKg.Text = dt.Rows(0)("FinishedYield")
                    txtFinId.Text = dt.Rows(0)("FinId")
                    txtFinDescp.Text = dt.Rows(0)("FinDescp")
                    txtInternalDocRef.Text = objCMR.getDrSqDf(txtItemCode.Text.Trim)
                    txtSourceDesignNo.Text = txtItemCode.Text.Trim
                    getBalanceStock()
                    ShowStockWarningMessage()
                Else
                    txtItemCode.Text = ""
                    txtItemName.Text = ""
                    txtItemDesc.Text = ""
                    txtMaterialWidth.Text = ""
                    txtFinishedWidthCmMin.Text = ""
                    txtFinishedWidthCmMax.Text = ""
                    txtFinished_GmPerSqmMin.Text = ""
                    txtFinishedGmPerSqmMax.Text = ""
                    txtFinishedMtKg.Text = ""
                    txtFinId.Text = ""
                    txtFinDescp.Text = ""
                    txtSourceDesignNo.Text = ""
                    txtInternalDocRef.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub txtEndBuyerId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEndBuyerId.KeyPress
        If e.KeyChar = vbCr Then
            If txtEndBuyerId.Text.Trim <> "" Then
                Dim objDB As New ClassCMR
                Dim dt As New DataTable
                dt = objDB.getEndBuyerData(txtEndBuyerId.Text.Trim)
                If dt.Rows.Count > 0 Then
                    txtEndBuyerName.Text = dt.Rows(0)("endbuyername")
                Else
                    txtEndBuyerName.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub tsmnLabRequestNo_Click(sender As Object, e As EventArgs) Handles tsmnLabRequestNo.Click
        callFindDialog(DataForFindCmrNumber)
    End Sub
    Private Sub tsmnRevisionHistoryOfLabRequestNo_Click(sender As Object, e As EventArgs) Handles tsmnRevisionHistoryOfLabRequestNo.Click
        callFindDialog(DataForFindCmrRevisionHistory)
    End Sub
    Private Sub btnFindCmrNumber_Click(sender As Object, e As EventArgs) Handles btnFindCmrNumber.Click
        callFindDialog(DataForFindCmrNumber)
    End Sub
    Private Sub btnFindSoNo_Click(sender As Object, e As EventArgs) Handles btnFindSoNo.Click
        callFindDialog(DataForFindSONo)
    End Sub
    Private Sub btnFindFinId_Click(sender As Object, e As EventArgs) Handles btnFindFinId.Click
        callFindDialog(DataForFindMasDyeFinFormula)
    End Sub

    Private Sub btnFindItemCode_Click(sender As Object, e As EventArgs) Handles btnFindItemCode.Click
        callFindDialog(DataForFindDesign)
        ShowStockWarningMessage()
    End Sub
    Private Sub ShowStockWarningMessage()
        If txtCurStockBalance.Text.Trim = "" Then
            MessageBox.Show("Qty Stock is Zero, Please prepare cloth for lab", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtCurStockBalance.Text < 10 Then
            MessageBox.Show("Qty Stock is Less than 10, Please prepare cloth for lab", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub btnGetEndBuyerId_Click(sender As Object, e As EventArgs) Handles btnGetEndBuyerId.Click
        callFindDialog(DataForFindEndBuyer)
    End Sub
    Private Sub btnFindRollNo_Click(sender As Object, e As EventArgs) Handles btnFindRollNo.Click
        callFindDialog(DataForFindSourceDesign)
    End Sub
    Private Sub btnFindPreviousCMRNo_Click(sender As Object, e As EventArgs) Handles btnFindPreviousCMRNo.Click
        callFindDialog(DataForFindPreviousCMRNO)
    End Sub
    Private Sub callFindDialog(pDataForFind As String)
        Dim objDlgGetMasterCode As New DlgGetMasterCode(pDataForFind)
        'Assign parameter
        Select Case pDataForFind
            Case DataForFindCmrNumber
                'objDlgGetMasterCode.pCmrNumber = txtCmrNumber.Text.Trim
                objDlgGetMasterCode.pCmrNumber = "" 'Sitthana 20230605
            Case DataForFindPreviousCMRNO
                objDlgGetMasterCode.pCmrNumber = ""
            Case DataForFindSourceDesign
                objDlgGetMasterCode.pRollNo = ""
                objDlgGetMasterCode.pDesignNO = txtSourceDesignNo.Text.Trim
                objDlgGetMasterCode.pMtlSubinvId = defaultmtlSubInvIDStock 'Sitthana 20181224
        End Select

        'Call Dialog
        If objDlgGetMasterCode.ShowDialog() = vbOK Then
            Select Case pDataForFind
                Case DataForFindCmrNumber
                    txtCmrNumber.Text = objDlgGetMasterCode.pCmrNumber
                    LoadData(0, txtCmrNumber.Text.Trim)
                Case DataForFindPreviousCMRNO
                    txtMatchWithReference.Text = objDlgGetMasterCode.pCmrNumber
                Case DataForFindCmrRevisionHistory
                    txtCmrNumber.Text = objDlgGetMasterCode.pCmrNumber
                    LoadCmrHeaderLogData(objDlgGetMasterCode.pCmrHeaderId, txtCmrNumber.Text.Trim)
                Case DataForFindSONo
                    txtSONo.Text = objDlgGetMasterCode.pSoNo
                    If objDlgGetMasterCode.pSampleOrder = "1" Then
                        cbForSample.Checked = True
                        cbForOrder.Checked = False
                    Else
                        cbForSample.Checked = False
                        cbForOrder.Checked = True
                    End If
                Case DataForFindMasDyeFinFormula
                    txtFinId.Text = objDlgGetMasterCode.pFinId
                    txtFinDescp.Text = objDlgGetMasterCode.pFinDescp
                Case DataForFindDesign
                    txtItemCode.Text = objDlgGetMasterCode.pDesignNO
                    txtItemName.Text = objDlgGetMasterCode.pRefDesNo
                    txtItemDesc.Text = objDlgGetMasterCode.pCompo
                    txtMaterialWidth.Text = objDlgGetMasterCode.pMaterialWidth

                    If objDlgGetMasterCode.pFinishedWidthMin = 0 Then
                        txtFinishedWidthCmMin.Text = objDlgGetMasterCode.pFinishedWidth
                    Else
                        txtFinishedWidthCmMin.Text = objDlgGetMasterCode.pFinishedWidthMin
                    End If 'Sitthana 20230605
                    txtFinishedWidthCmMax.Text = objDlgGetMasterCode.pFinishedWidthMax

                    If objDlgGetMasterCode.pFinishedWeightMin = 0 Then
                        txtFinished_GmPerSqmMin.Text = objDlgGetMasterCode.pFinishedWeight
                    Else
                        txtFinished_GmPerSqmMin.Text = objDlgGetMasterCode.pFinishedWeightMin
                    End If 'Sitthana 20230605
                    txtFinishedGmPerSqmMax.Text = objDlgGetMasterCode.pFinishedWeightMax

                    txtFinishedMtKg.Text = objDlgGetMasterCode.pFinishedYield
                    txtFinId.Text = objDlgGetMasterCode.pFinId
                    txtFinDescp.Text = objDlgGetMasterCode.pFinDescp
                    txtSourceDesignNo.Text = Mid(objDlgGetMasterCode.pDesignNO, 1, 6)
                    txtInternalDocRef.Text = ""
                    txtInternalDocRef.Text = objCMR.getDrSqDf(objDlgGetMasterCode.pDesignNO)
                    txtSourceDesignNo.Text = txtItemCode.Text.Trim
                    getBalanceStock()
                Case DataForFindEndBuyer
                    txtEndBuyerId.Text = objDlgGetMasterCode.pEndBuyerId
                    txtEndBuyerName.Text = objDlgGetMasterCode.pEndBuyerName
                Case DataForFindSourceDesign
                    txtSourceDesignNo.Text = objDlgGetMasterCode.pSourceDesignNo
                    txtCurStockBalance.Text = objDlgGetMasterCode.pCurStockBalance
                    ShowStockWarningMessage()
            End Select
        End If
    End Sub
    Private Sub getBalanceStock()
        If txtSourceDesignNo.Text.Trim = "" Then
            txtCurStockBalance.Text = ""
        Else
            Dim dt As New DataTable
            Dim objDB As New ClassCMR
            dt = objDB.getRollData("", txtSourceDesignNo.Text.Trim, mtlSubinvIdLABGAM)
            If dt.Rows.Count > 0 Then
                txtCurStockBalance.Text = dt.Rows(0)("bal_mts")
            Else
                txtCurStockBalance.Text = 0
            End If
        End If
    End Sub
    Private Sub tsmnitmCMRForm_Click(sender As Object, e As EventArgs) Handles tsmnitmCMRForm.Click
        InitReport("rptGammaCMR.rpt")
    End Sub
    Private Sub tsmnitmCMRFormRev2_Click(sender As Object, e As EventArgs)
        InitReport("rptGammaCMR_Rev1.rpt")
    End Sub
    Private Sub tsmnGammaCMRBlankForm_Click(sender As Object, e As EventArgs) Handles tsmnGammaCMRBlankForm.Click
        InitReport("rptGammaCMRBlankForm.rpt")
    End Sub
    Private Sub InitReport(rptFileName As String)
        If txtCmrNumber.Text.Trim = "" Then
            MessageBox.Show("คุณต้องกำหนดเลขที่ Lab Request No ที่จะพิมพ์ก่อน", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName, False) Then
            MessageBox.Show("ไม่พบรายงาน ให้คุณติดต่อโปรแกรมเมอร์", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Me.Cursor = Cursors.WaitCursor
            rpt.Load(clsUser.ReportPath & rptFileName)
            printReport(rpt)
        End If
    End Sub
    Private Sub printReport(ByRef rpt As CrystalDecisions.CrystalReports.Engine.ReportDocument)
        Dim frm As New frmReport

        frm.Title = "Gamma Colour Matching Request"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm

        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor

        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        If UCase((New classConnection).database) = "KARISMA" Then
            rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        Else
            'rpt.Database.Tables(0).ApplyLogOnInfo(logonInfo)
            rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)

        End If
        rpt.VerifyDatabase()

        rpt.SetParameterValue("@p_cmr_number", txtCmrNumber.Text.Trim)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Show()

        Me.Cursor = Cursors.Default
    End Sub
    Private Sub tsmnitmCMRList_Click(sender As Object, e As EventArgs) Handles tsmnitmCMRList.Click
        Dim ObjfrmrptCMRList As New frmrptCMRList
        ObjfrmrptCMRList.ShowDialog(Me)
    End Sub
    Private Sub assignSrcValToCell(pSrcObj As Object, pGrdObj As Object, pcellName As String)
        With pGrdObj
            If TypeOf pSrcObj Is TextBox Then
                If .Rows(.CurrentRow.Index).Cells(pcellName).Value.ToString.Trim = "" Then
                    If pSrcObj.Text.Trim <> "" Then
                        .Rows(.CurrentRow.Index).Cells(pcellName).Value = pSrcObj.Text.Trim
                    End If
                End If
            ElseIf TypeOf pSrcObj Is DateTimePicker Then
                If .Rows(.CurrentRow.Index).Cells(pcellName).Value.ToString.Trim = "" Then
                    If IsDate(pSrcObj.Value) Then
                        .Rows(.CurrentRow.Index).Cells(pcellName).Value = pSrcObj.Value
                    End If
                End If
            End If
        End With
    End Sub
    Private Sub grdCmrLines_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdCmrLines.CellBeginEdit
        With grdCmrLines
            If .Rows(.CurrentRow.Index).Cells("Line_Num").Value.ToString.Trim = "" Then
                .Rows(.CurrentRow.Index).Cells("Line_Num").Value = getLastbs()
                assignSrcValToCell(txtShadesPerColor, grdCmrLines, "shades_per_color")
                assignSrcValToCell(txtNumOfSets, grdCmrLines, "num_of_sets")
                assignSrcValToCell(dtpNeedByDate, grdCmrLines, "need_by_date")
                CalLabConfirmedData()
                '.EndEdit()
            End If

            Select Case .Columns(.CurrentCell.ColumnIndex).Name
                Case "shades_per_color"
                    assignSrcValToCell(txtShadesPerColor, grdCmrLines, "shades_per_color")
                Case "num_of_sets"
                    assignSrcValToCell(txtNumOfSets, grdCmrLines, "num_of_sets")
                Case "need_by_date"
                    assignSrcValToCell(dtpNeedByDate, grdCmrLines, "need_by_date")
                    CalLabConfirmedData()
            End Select
        End With
    End Sub
    Private Sub CalLabConfirmedData()
        With grdCmrLines
            Select Case .CurrentRow.Index
                Case 0
                    If .Rows.Count = 1 Then
                        .Rows(.CurrentRow.Index).Cells("planned_submit_date").Value = DateAdd(DateInterval.Day, 6, dtpCmrDate.Value)
                    End If
                Case 1
                    .Rows(.CurrentRow.Index).Cells("planned_submit_date").Value = DateAdd(DateInterval.Day, 10, dtpCmrDate.Value)
                    .Rows(0).Cells("planned_submit_date").Value = DateAdd(DateInterval.Day, 10, dtpCmrDate.Value)
                Case Else
                    .Rows(.CurrentRow.Index).Cells("planned_submit_date").Value = DateAdd(DateInterval.Day, 10, dtpCmrDate.Value)
            End Select
        End With
    End Sub
    Private Function getLastbs()
        Dim CurLineNo As Integer = 0
        Dim bsTmpCMRLines As BindingSource = bsCMRLines
        bsTmpCMRLines.MoveLast()

        If bsTmpCMRLines.DataSource = Nothing Then
            CurLineNo = grdCmrLines.CurrentRow.Index + 1
        Else
            CurLineNo = Convert.ToInt64(bsTmpCMRLines.Item("Line_Num"))
        End If
        Return CurLineNo
    End Function
    Private Sub cbForOrderEnable(penabled As Boolean)
        txtSONo.ReadOnly = Not penabled
        btnFindSoNo.Enabled = penabled
    End Sub
    Private Sub cbForOrder_CheckStateChanged(sender As Object, e As EventArgs) Handles cbForOrder.CheckStateChanged
        If cbForOrder.Checked = True Then
            cbForOrderEnable(True)
        Else
            cbForOrderEnable(False)
        End If
    End Sub

    Private Sub cbRevisionCauseCheckStateChanged(sender As Object, e As EventArgs) Handles cbRevisionCause.CheckStateChanged
        If cbRevisionCause.Checked Then
            txtCmrRevisionCause.ReadOnly = False
        Else
            txtCmrRevisionCause.ReadOnly = True
        End If
    End Sub

    Private Sub btnGetRefCustomer_Click(sender As Object, e As EventArgs) Handles btnGetRefCustomer.Click
        Dim cls As New classSearchCustomers
        Dim frm As New frmSearchCustomers

        frm.ShowDialog()

        If frm.pCustomerID <> 0 Then
            If dtCMRHeader.Rows.Count > 0 Then
                dtCMRHeader.Rows(0)("customer_id") = frm.pCustomerID
            End If
            txtRefCustCode.Text = frm.pCustomerCode
            txtRefCustName.Text = frm.pCustomerName
        End If
    End Sub


End Class