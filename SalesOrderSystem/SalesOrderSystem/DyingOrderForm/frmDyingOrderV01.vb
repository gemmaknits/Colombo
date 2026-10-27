Public Class frmDyingOrderV01
    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim strDFNo As String = ""
    Dim strDyedType As String = "NORMAL"
    Dim blnCancel As Boolean = False
    Dim blnEditMode As Boolean = False
    Dim blnGenCombo As Boolean = False
    Dim idx As Long = 0
    Dim idx2 As Long = 0
    Dim dtGetSODesignGrid As DataTable

#Region "Constant"
    'For Eschler lookup_type = DF_TYPE(lookup_id= 37)

    Private Const DF As String = "355"
    Private Const FINISH As String = "356"
    Private Const PRESET As String = "357"
    Private Const REDYE As String = "358"
    Private Const EMBROID As String = "359"
    Private Const HOLOGRAM As String = "360"
    Private Const LAMINATE As String = "361"
    Private Const PLEAT As String = "362"
    Private Const REFINISH As String = "363"
    Private Const SPLIT As String = "364"
    Private Const PRINTING As String = "365"
#End Region

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsUser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsUser = NewValue
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
            'cbo.SelectedValue = ""
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
        End If
        If TypeOf Obj Is RadioButton Then
            Dim opt As RadioButton = Obj
            opt.Checked = False
        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        initComboBox()  'Sitthana 07/036/2018
        GrpProcessOption.Enabled = False  'Sitthana 07/036/2018

        strDFNo = ""
        lblCustomer.Text = ""
        lblCancelled.Visible = False
        txtGarment.Text = "Eschler" 'Sitthana 20230112
        '        Call ClearGrdDesignNo()
        '        Call ClearGrdRollNo()
        '        Call ClearGrdDF()
        If grdDesign.Rows.Count > 0 Then Call ClearGrdDesignNo()
        If grdDF.Rows.Count > 0 Then Call ClearGrdDF()
        If grdRollNo.Rows.Count > 0 Then Call ClearGrdRollNo()

        Call LoadData("")
        'cboDyedHouse.SelectedValue = "GT"

        cboPDFID.Enabled = False
        txtOth_Std_Comment.ReadOnly = False 'Sitthana 20200724
        txtDFNo.Focus()
    End Sub
    Private Sub initComboBox()
        'First Load Program Only  Sitthana 05/03/2018

        Dim objDB As New classMaster
        Me.cboDFType.DataSource = objDB.GetDF_Type
        Me.cboDFType.DisplayMember = "DF_Type_value"
        Me.cboDFType.ValueMember = "DF_Type_id"
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

    Private Sub EnabledControl(ByVal blnEnabled As Boolean)
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlEnabled(obj, blnEnabled)
        Next
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster
        Dim objREQ As New classRequest

        'Dim dt As DataTable = objDB.GetSoNo
        'Dim dt2 As DataTable = dt.Clone
        'Dim expression As String
        'expression = "flow_status_code = 'CFM' "
        'Dim foundRows() As DataRow
        'foundRows = dt.Select(expression)
        'For Each row As DataRow In foundRows
        '    dt2.ImportRow(row)
        'Next
        'Me.txtSoNo.DataSource = dt2
        'Me.txtSoNo.DisplayMember = "sono2"
        'Me.txtsono.ValueMember = "sono2"

        'Me.cboSoNo.DataSource = objDB.GetSoNo
        ' Me.cboSoNo.DisplayMember = "sono2"
        'Me.cboSoNo.ValueMember = "sono2"

        Me.cboDyedHouse.DataSource = objDB.GetDyedHouse
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd2"
        'Me.cboDyedCase.SelectedValue = "GT"

        Me.cboDyedCase.DataSource = objDB.GetDyedCase
        Me.cboDyedCase.DisplayMember = "dyecasedescp"
        Me.cboDyedCase.ValueMember = "dyecase"


        'Me.cboDesignNo.DataSource = objDB.GetDesign
        'Me.cboDesignNo.DisplayMember = "design_no"
        'Me.cboDesignNo.ValueMember = "design_no"

        Me.txtFinishedDesign.DataSource = objDB.GetDesign
        Me.txtFinishedDesign.DisplayMember = "design_no"
        Me.txtFinishedDesign.ValueMember = "design_no"

        'Me.txtReqNo.DataSource = objREQ.GetReqNo
        'Me.txtReqNo.DisplayMember = "outreqno"
        'Me.txtReqNo.ValueMember = "outreqno"

        'Me.txtOutNo.DataSource = objDB.GetOutNo
        'Me.txtOutNo.DisplayMember = "outno"
        'Me.txtOutNo.ValueMember = "outno"

        Me.df_col.DataSource = objDB.GetColor
        Me.df_col.DisplayMember = "col2"
        Me.df_col.ValueMember = "col2"
    End Sub

    ' Private Sub GenComboDFNo()
    'Dim objDB As New classDFOrder
    'cboDFNo.ComboBox.DataSource = objDB.DFComboLoad()
    'cboDFNo.ComboBox.DisplayMember = "dfno"
    'cboDFNo.ComboBox.ValueMember = "dfno"
    'If strDFNo.Trim.Length > 0 Then cboDFNo.ComboBox.SelectedValue = strDFNo.Trim
    ' End Sub

    'Private Sub GenComboDesignNo()
    '    Dim config As New clsConfig
    '    Dim objDB As New classDFOrder
    '    If strDyedType = "NORMAL" Then txtDesignNo.DataSource = objDB.GetSODesign(config.IsNull(txtsono.Text.Trim, "").ToString.Trim)
    '    '        If strDyedType = "REDYED" Then cboDesignNo.DataSource = objDB.GetStkOutDesign(config.IsNull(cboOutNo.SelectedValue, "").ToString.Trim)
    '    If strDyedType = "REDYED" Then txtDesignNo.DataSource = objDB.GetSODesign(config.IsNull(txtsono.Text.Trim, "").ToString.Trim)
    '    txtDesignNo.DisplayMember = "design_no"
    '    txtDesignNo.ValueMember = "design_no"
    '    Call GenComboColor()
    'End Sub

    Private Sub GenComboColor()
        Dim config As New clsConfig
        Dim objDB As New classDFOrder
        'Me.cboColor.DataSource = objDB.GetSOColor(config.IsNull(cboSoNo.Text, "").ToString.Trim)
        'Me.cboColor.DisplayMember = "col"
        'Me.cboColor.ValueMember = "col"

        'Sitthana 07/06/2018  Change cboColor combo to multicolumn combo
        mltcboColor.DataSource = objDB.GetSOColor(config.IsNull(txtsono.Text, "").ToString.Trim)
        mltcboColor.MultiColumn = True
        mltcboColor.ValueMember = "col" 'id_yarnchange
        mltcboColor.DisplayMember = "col"
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        strDFNo = dt.Rows(0)("dfno").ToString.Trim
        txtDFNo.Text = dt.Rows(0)("dfno").ToString.Trim
        dtpDFDate.Value = CDate(dt.Rows(0)("dfdt2").ToString)
        txtLotNo.Text = dt.Rows(0)("lot").ToString.Trim
        txtRevise.Text = dt.Rows(0)("rev").ToString.Trim

        txtsono.Text = dt.Rows(0)("sono").ToString.Trim
        Call getSoData()
        txtOutno.Text = dt.Rows(0)("outno").ToString.Trim

        If txtOutno.Text.Trim.Length = 0 Then strDyedType = "NORMAL"
        If txtOutno.Text.Trim.Length > 0 Then
            If txtOutno.Text.ToString.Substring(0, 2) = "GO" Then
                strDyedType = "NORMAL"
            ElseIf txtOutno.Text.ToString.Substring(0, 2) = "DO" Then
                strDyedType = "REDYED" 'Add By Neung 
            End If
        End If

        Call GenComboFGDesignNo()
        'Call GenComboDesignNo()

        txtDesignNo.Text = dt.Rows(0)("design_no").ToString.Trim
        txtFinishedDesign.Text = dt.Rows(0)("design_no_fg").ToString.Trim
        txtReqNo.Text = dt.Rows(0)("outreqno").ToString.Trim
        cboDyedHouse.SelectedValue = dt.Rows(0)("dhcod").ToString.Trim
        cboDyedCase.SelectedValue = dt.Rows(0)("style").ToString.Trim
        dtpDeliveryDate.Value = CDate(dt.Rows(0)("delidt2").ToString)
        txtDeliveryBy.Text = dt.Rows(0)("deliver_by").ToString.Trim
        txtDeliveryTo.Text = dt.Rows(0)("deliver_to").ToString.Trim

        chkLightD65.Checked = CBool(dt.Rows(0)("d65"))
        chkLightTL84.Checked = CBool(dt.Rows(0)("tl84"))
        chkLightTL83.Checked = CBool(dt.Rows(0)("tl83"))
        chkLightIncadescentA.Checked = CBool(dt.Rows(0)("inc"))
        chkLightTL84Macbeth.Checked = CBool(dt.Rows(0)("tl84m"))
        chkLightCWF.Checked = CBool(dt.Rows(0)("cwf"))
        chkLightD65Macbeth.Checked = CBool(dt.Rows(0)("d65m"))
        txtLightD65.Text = dt.Rows(0)("d65_order").ToString.Trim
        txtLightTL84.Text = dt.Rows(0)("tl84_order").ToString.Trim
        txtLightTL83.Text = dt.Rows(0)("tl83_order").ToString.Trim
        txtLightIncadescentA.Text = dt.Rows(0)("inc_order").ToString.Trim
        txtLightTL84Macbeth.Text = dt.Rows(0)("tl84m_order").ToString.Trim
        txtLightCWF.Text = dt.Rows(0)("cwf_order").ToString.Trim
        txtLightD65Macbeth.Text = dt.Rows(0)("d65m_order").ToString.Trim

        If dt.Rows(0)("lottype").ToString.Trim = "N" Then optLotNormal.Checked = True
        If dt.Rows(0)("lottype").ToString.Trim = "T" Then optLotTesting.Checked = True
        If dt.Rows(0)("lottype").ToString.Trim = "S" Then optLotSample.Checked = True
        chkNewDesign.Checked = CBool(dt.Rows(0)("newdesign"))
        txtRepeatLen.Text = dt.Rows(0)("len").ToString.Trim
        txtRepeatWidth.Text = dt.Rows(0)("wth").ToString.Trim
        chkStandardKarisma.Checked = CBool(dt.Rows(0)("ka_std"))
        chkStandardGamma.Checked = CBool(dt.Rows(0)("ga_std"))
        chkStandardCustomer.Checked = CBool(dt.Rows(0)("cus_std"))
        chkStandardOther.Checked = CBool(dt.Rows(0)("oth_std")) 'Sitthana 20200724
        txtOth_Std_Comment.Text = dt.Rows(0)("oth_std_comment").ToString().Trim 'Sitthana 20200724
        chkOrderSample.Checked = CBool(dt.Rows(0)("csample"))
        chkOrderBulk.Checked = CBool(dt.Rows(0)("cbulk"))
        txtDyeLossPercent.Text = dt.Rows(0)("dye_loss_percent").ToString().Trim
        txtPackCond.Text = dt.Rows(0)("cond").ToString.Trim
        txtSpecialCond.Text = dt.Rows(0)("remark").ToString.Trim
        txtSampleBook.Text = dt.Rows(0)("sample").ToString.Trim
        txtRemark.Text = dt.Rows(0)("dfrem").ToString.Trim


        'ToDo: 1. Bind data Modify By Sitthana 07/03/2018 -> Change Check box To Combo Box
        '---Begin 
        cboDFType.SelectedValue = dt.Rows(0)("df_type_id")
        txtDFTypeRemark.Text = dt.Rows(0)("df_type_remark").ToString.Trim
        If dt.Rows(0)("df_type_id") = 1 Then
            chkProcessSplit.Checked = True
        End If

        '----- End  Modify By Sitthana

        ''--- Check box wait cancel -> Old data from base
        chkProcessDying.Checked = CBool(dt.Rows(0)("dye"))
        chkProcessFinish.Checked = CBool(dt.Rows(0)("finish"))
        chkProcessPreset.Checked = CBool(dt.Rows(0)("preset"))

        chkProcessReDyed.Checked = CBool(dt.Rows(0)("red"))
        chkProcessReFinish.Checked = CBool(dt.Rows(0)("ref"))
        chkProcessPleat.Checked = CBool(dt.Rows(0)("pleat"))
        txtPleatRem.Text = dt.Rows(0)("pleat_rem").ToString.Trim
        chkProcessHologram.Checked = CBool(dt.Rows(0)("holog"))
        txtHologRem.Text = dt.Rows(0)("holog_rem").ToString.Trim
        chkProcessPrinting.Checked = CBool(dt.Rows(0)("printing"))
        txtPrintRem.Text = dt.Rows(0)("print_rem").ToString.Trim
        chkProcessEmbroidary.Checked = CBool(dt.Rows(0)("embroidary"))
        txtEmbroidaryRem.Text = dt.Rows(0)("embroidary_rem").ToString.Trim
        '----- End  Check box wait cancel

        txtOwner.Text = dt.Rows(0)("empname").ToString.Trim
        dtpCreateDate.Value = CDate(dt.Rows(0)("issuedt2").ToString)

        txtDesignNo.Text = dt.Rows(0)("design_no").ToString.Trim
        txtFinishedDesign.SelectedValue = dt.Rows(0)("design_no_fg").ToString.Trim

        txtMtsPerRoll.Text = dt.Rows(0)("mts_per_roll").ToString.Trim
        'txtPDFID.Text = dt.Rows(0)("poc_pdf_header_id").ToString.Trim 'Add By Neung 24/02/2016

        'Dim dtPDF As New DataTable
        'Dim dr As DataRow
        'dtPDF.Columns.Add("poc_pdf_header_id")
        'dr = dtPDF.NewRow()
        'dr("poc_pdf_header_id") = dt.Rows(0)("poc_pdf_header_id")
        'dtPDF.Rows.Add(dr)
        'cboPDF.DataSource = dtPDF
        'cboPDF.DisplayMember = ""
        'cboPDF.ValueMember = "poc_pdf_header_id"
        If Not IsDBNull(dt.Rows(0)("poc_pdf_header_id")) Or (dt.Rows(0)("poc_pdf_header_id")) Is Nothing Then
            cboPDFID.SelectedValue = dt.Rows(0)("poc_pdf_header_id") '.ToString.Trim '.ToString.Trim 'Add By Neung 24/02/2016
            cboPDFID.Enabled = False
        Else
            cboPDFID.Enabled = False
        End If

        chkaddl.Checked = CBool(dt.Rows(0)("addl"))
        txtaddl_remark.Text = dt.Rows(0)("addl_remark")

        Select Case dt.Rows(0)("width_type")
            Case 1 : optNorminal.Checked = True
            Case 2 : optEdgeGlue.Checked = True
            Case 3 : optEdgeCut.Checked = True
            Case 4 : optUsable.Checked = True
        End Select

        If dt.Rows(0)("status").ToString.Trim = "C" Then
            lblCancelled.Visible = True
            lblCancelled.Text = "CANCELLED BY:" + dt.Rows(0)("CancelRecUserName").ToString.Trim + " / Dt: " + dt.Rows(0)("CancelRecDate").ToString.Trim
            Call EnabledControl(False)
        End If

        txtInventoryTypeName.Text = (New classDFOrder).getStatusFabric(strDFNo)  '' dt.Rows(0)("inventory_type_name").ToString.Trim 'Sitthana 20211027
        'txtGarment.Text = dt.Rows(0)("garment").ToString.Trim 'Sitthana 20240112
    End Sub

    Private Sub BindGridDesign(ByVal dt As DataTable)
        grdDesign.AutoGenerateColumns = False
        grdDesign.DataSource = dt
    End Sub

    Private Sub BindGridRollNo(ByVal dt As DataTable)
        grdRollNo.AutoGenerateColumns = False
        grdRollNo.DataSource = dt
    End Sub

    Private Sub BindGridDF(ByVal dt As DataTable)
        grdDF.AutoGenerateColumns = False
        grdDF.DataSource = dt
    End Sub

    Private Function IsDataChange() As Boolean
        Dim config As New clsConfig
        Dim result As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dt As New DataTable
        dt = grdDF.DataSource
        If dt Is Nothing Then Return False
        Dim dv As New DataView(dt, "", "", DataViewRowState.OriginalRows)
        If dt Is Nothing Or dv.Count = 0 Then
            If grdDF.Rows.Count > 1 Then result = True

            'If txtDFNo.Text <> "" Then result = True
            If dtpDFDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If txtLotNo.Text <> "" Then result = True

            If config.IsNull(txtsono.Text, "") <> "" Then result = True
            If config.IsNull(txtReqNo.Text, "") <> "" Then result = True
            If config.IsNull(cboDyedHouse.SelectedValue, "") <> "" Then result = True
            If dtpDeliveryDate.Value.ToString("yyyyMMdd") <> Now.ToString("yyyyMMdd") Then result = True
            If txtDeliveryBy.Text <> "" Then result = True
            If txtDeliveryTo.Text <> "" Then result = True

            If CBool(chkLightD65.Checked) Then result = True
            If CBool(chkLightTL84.Checked) Then result = True
            If CBool(chkLightTL83.Checked) Then result = True
            If CBool(chkLightIncadescentA.Checked) Then result = True
            If CBool(chkLightTL84Macbeth.Checked) Then result = True
            If CBool(chkLightCWF.Checked) Then result = True
            If CBool(chkLightD65Macbeth.Checked) Then result = True
            If txtLightD65.Text <> "" Then result = True
            If txtLightTL84.Text <> "" Then result = True
            If txtLightTL83.Text <> "" Then result = True
            If txtLightIncadescentA.Text <> "" Then result = True
            If txtLightTL84Macbeth.Text <> "" Then result = True
            If txtLightCWF.Text <> "" Then result = True
            If txtLightD65Macbeth.Text <> "" Then result = True

            'ToDo: 2. Modify By Sitthana 07/03/2018 -> Change Check box To Combo Box
            '----- Begin 
            ' Check combo box cboDFType , text txtDFTypeRemark -> wait
            '----- End

            '----- Check box wait cancel -> Old data from base
            If CBool(chkProcessDying.Checked) Then result = True
            If CBool(chkProcessFinish.Checked) Then result = True
            If CBool(chkProcessPreset.Checked) Then result = True
            '----- End  Check box wait cancel

            If optLotNormal.Checked = False Then result = True
            If CBool(chkNewDesign.Checked) Then result = True
            If Val(txtRepeatLen.Text) <> 0 Then result = True
            If Val(txtRepeatWidth.Text) <> 0 Then result = True
            If CBool(chkStandardKarisma.Checked) Then result = True
            If CBool(chkStandardGamma.Checked) Then result = True
            If CBool(chkStandardCustomer.Checked) Then result = True
            If CBool(chkOrderSample.Checked) Then result = True
            If CBool(chkOrderBulk.Checked) Then result = True
            If txtPackCond.Text <> "" Then result = True
            If txtSpecialCond.Text <> "" Then result = True
            If txtSampleBook.Text <> "" Then result = True
            If txtRemark.Text <> "" Then result = True
            If config.IsNull(txtDesignNo.Text, "") <> "" Then result = True
            If config.IsNull(txtFinishedDesign.SelectedValue, "") <> "" Then result = True
        Else
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(0).RowState <> DataRowState.Deleted Then
                    j = i
                    Exit For
                End If
            Next

            If j > 0 Then
                If dtpDFDate.Value <> CDate(dt.Rows(j)("dfdt2").ToString) Then result = True
                If txtLotNo.Text <> dt.Rows(j)("lot").ToString.Trim Then result = True

                If config.IsNull(txtsono.Text, "").ToString.Trim <> dt.Rows(j)("sono").ToString.Trim Then result = True
                If config.IsNull(txtReqNo.Text, "").ToString.Trim <> dt.Rows(j)("outreqno").ToString.Trim Then result = True
                If config.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim <> dt.Rows(j)("dhcod").ToString.Trim Then result = True
                If dtpDeliveryDate.Value <> CDate(dt.Rows(j)("delidt2").ToString) Then result = True
                If txtDeliveryBy.Text <> dt.Rows(j)("deliver_by").ToString.Trim Then result = True
                If txtDeliveryTo.Text <> dt.Rows(j)("deliver_to").ToString.Trim Then result = True

                If chkLightD65.Checked <> CBool(dt.Rows(j)("d65")) Then result = True
                If chkLightTL84.Checked <> CBool(dt.Rows(j)("tl84")) Then result = True
                If chkLightTL83.Checked <> CBool(dt.Rows(j)("tl83")) Then result = True
                If chkLightIncadescentA.Checked <> CBool(dt.Rows(j)("inc")) Then result = True
                If chkLightTL84Macbeth.Checked <> CBool(dt.Rows(j)("tl84m")) Then result = True
                If chkLightCWF.Checked <> CBool(dt.Rows(j)("cwf")) Then result = True
                If chkLightD65Macbeth.Checked <> CBool(dt.Rows(j)("d65m")) Then result = True
                If txtLightD65.Text <> dt.Rows(j)("d65_order").ToString.Trim Then result = True
                If txtLightTL84.Text <> dt.Rows(j)("tl84_order").ToString.Trim Then result = True
                If txtLightTL83.Text <> dt.Rows(j)("tl83_order").ToString.Trim Then result = True
                If txtLightIncadescentA.Text <> dt.Rows(j)("inc_order").ToString.Trim Then result = True
                If txtLightTL84Macbeth.Text <> dt.Rows(j)("tl84m_order").ToString.Trim Then result = True
                If txtLightCWF.Text <> dt.Rows(j)("cwf_order").ToString.Trim Then result = True
                If txtLightD65Macbeth.Text <> dt.Rows(j)("d65m_order").ToString.Trim Then result = True

                'ToDo: 3. Modify By Sitthana 07/03/2018 -> Change Check box To Combo Box
                '----- Begin 
                ' Check combo box cboDFType , text txtDFTypeRemark -> wait
                ''----- End

                '----- Check box wait cancel -> Old data from base
                If chkProcessDying.Checked <> CBool(dt.Rows(j)("dye")) Then result = True
                If chkProcessFinish.Checked <> CBool(dt.Rows(j)("finish")) Then result = True
                If chkProcessPreset.Checked <> CBool(dt.Rows(j)("preset")) Then result = True
                '----- End  Check box wait cancel

                If dt.Rows(j)("lottype").ToString.Trim = "N" Then If Not CBool(optLotNormal.Checked) Then result = True
                If dt.Rows(j)("lottype").ToString.Trim = "T" Then If Not CBool(optLotTesting.Checked) Then result = True
                If dt.Rows(j)("lottype").ToString.Trim = "S" Then If Not CBool(optLotSample.Checked) Then result = True
                If chkNewDesign.Checked <> CBool(dt.Rows(j)("newdesign")) Then result = True
                If txtRepeatLen.Text <> dt.Rows(j)("len").ToString.Trim Then result = True
                If txtRepeatWidth.Text <> dt.Rows(j)("wth").ToString.Trim Then result = True
                If chkStandardKarisma.Checked <> CBool(dt.Rows(j)("ka_std")) Then result = True
                If chkStandardGamma.Checked <> CBool(dt.Rows(j)("ga_std")) Then result = True
                If chkStandardCustomer.Checked <> CBool(dt.Rows(j)("cus_std")) Then result = True
                If chkOrderSample.Checked <> CBool(dt.Rows(j)("csample")) Then result = True
                If chkOrderBulk.Checked <> CBool(dt.Rows(j)("cbulk")) Then result = True
                If txtPackCond.Text <> dt.Rows(j)("cond").ToString.Trim Then result = True
                If txtSpecialCond.Text <> dt.Rows(j)("remark").ToString.Trim Then result = True
                If txtSampleBook.Text <> dt.Rows(j)("sample").ToString.Trim Then result = True
                If txtRemark.Text <> dt.Rows(j)("dfrem").ToString.Trim Then result = True
                If config.IsNull(txtDesignNo.Text, "").ToString.Trim <> dt.Rows(j)("design_no_d").ToString.Trim Then result = True
                If config.IsNull(txtFinishedDesign.SelectedValue, "").ToString.Trim <> dt.Rows(j)("design_no_fg").ToString.Trim Then result = True
            End If

            Dim delRecs As New DataView(dt, "", "", DataViewRowState.Deleted)
            If delRecs.Count > 0 Then result = True

            Dim updRecs As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
            If updRecs.Count > 0 Then result = True

            Dim addRecs As New DataView(dt, "", "", DataViewRowState.Added)
            If addRecs.Count > 0 Then result = True
        End If

        IsDataChange = result
    End Function

    Private Function CheckData() As Boolean
        Dim config As New clsConfig
        If lblCancelled.Visible Then
            MessageBox.Show("This document is cancelled." & vbCrLf & "Can't edit anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(txtsono.Text, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Sales Order No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Dyed House!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(Me.txtDesignNo.Text, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Finished Design No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        If config.IsNull(txtFinishedDesign.Text, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Finished Design No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        'If config.IsNull(cboDyedCase.SelectedValue, "").ToString.Trim = "" Then
        If cboDyedCase.SelectedIndex = -1 Then
            MessageBox.Show("Please choose Dyed Case!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        If grdDF.Rows.Count <= 0 Then
            MessageBox.Show("Please insert data in table at least 1 record!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If Not grdDF.EndEdit Then
            MessageBox.Show("Right Pane Grid is error !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        If Not (New classSalesOrder).ValidateSOFlowStatus(StrSoNo:=config.IsNull(txtsono.Text, "").ToString.Trim) Then
            MessageBox.Show("This SO is Not CFM Status Please Check It Before!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function

    Private Sub LoadData(ByVal DFNo As String)
        Dim objDB As New classDFOrder
        Dim dt As New DataTable
        dt = objDB.DFDetLoadPKG(DFNo)
        Call BindGridDF(dt)
        Call SumGridDF()
        If dt.Rows.Count > 0 Then Call BindData(dt)
    End Sub

    Private Sub SumGridRollNo()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblYds As Double = 0
        Dim dblMts As Double = 0
        For i = 0 To grdRollNo.Rows.Count - 1
            If CBool(grdRollNo.Rows(i).Cells("sel").Value) Then
                dblKgs = dblKgs + config.IsNull(grdRollNo.Rows(i).Cells("kg").Value, 0)
                dblYds = dblYds + config.IsNull(grdRollNo.Rows(i).Cells("yds").Value, 0)
                dblMts = dblMts + config.IsNull(grdRollNo.Rows(i).Cells("mts").Value, 0)
                j += 1
            End If
        Next
        txtSelectionRolls.Text = FormatNumber(j, 0, TriState.False, TriState.False, TriState.True)
        txtSelectionKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtSelectionYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)
        txtSelectionMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
    End Sub

    Private Sub SumGridDF()
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim dblKgs As Double = 0
        Dim dblYds As Double = 0
        Dim dblMts As Double = 0
        For i = 0 To grdDF.Rows.Count - 1
            dblKgs = dblKgs + config.IsNull(grdDF.Rows(i).Cells("df_kg").Value, 0)
            dblYds = dblYds + config.IsNull(grdDF.Rows(i).Cells("df_yds").Value, 0)
            dblMts = dblMts + config.IsNull(grdDF.Rows(i).Cells("df_mts").Value, 0)
        Next
        txtTotalRolls.Text = FormatNumber(grdDF.Rows.Count, 0, TriState.False, TriState.False, TriState.True)
        txtTotalKgs.Text = FormatNumber(dblKgs, 2, TriState.False, TriState.False, TriState.True)
        txtTotalYds.Text = FormatNumber(dblYds, 2, TriState.False, TriState.False, TriState.True)
        txtTotalMts.Text = FormatNumber(dblMts, 2, TriState.False, TriState.False, TriState.True)
    End Sub

    Private Function SaveData() As Boolean
        Dim config As New clsConfig
        Dim clsDF As New classDFOrder
        Dim header As New classDFOrder.DFHeader
        Dim msgerr As String = ""
        Dim dfno As String = ""
        Dim dt As DataTable = grdDF.DataSource

        'If dt.Rows.Count > 0 Then
        '	Dim i As Integer = 0
        '	For i = 0 To dt.Rows.Count - 1
        '		If config.IsNull(dt.Rows(i)("slno"), 0) = 0 Then dt.Rows(i)("slno") = i + 1
        '	Next
        'End If
        Dim dv_add As New DataView(dt, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dt, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dt, "", "", DataViewRowState.Deleted)

        header.h01_dhcod = config.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim
        header.h02_dfno = strDFNo
        header.h03_dfdt = dtpDFDate.Value.ToString("yyyyMMdd")
        header.h04_design_no = config.IsNull(txtDesignNo.Text, "").ToString.Trim
        'header.h05_gwth = dt.Rows(i)("gwth").ToString.Trim 'cannot use when first row is deleted.
        'header.h05_gwth = grdDesign.CurrentRow.Cells("gwth").Value 'cannot use when grdDesign has no data
        Dim i As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted Then
                header.h05_gwth = dt.Rows(i)("gwth").ToString.Trim
                Exit For
            End If
        Next
        header.h06_fwth = ""
        header.h07_lot = IIf(txtLotNo.Text.Trim.Length = 0, IIf(optLotNormal.Checked, "N", IIf(optLotTesting.Checked, "T", "S")), txtLotNo.Text.Trim)
        header.h08_yr = ""
        header.h09_compo = ""
        header.h10_mtkg = 0
        header.h11_dyetyp = ""
        header.h12_sono = config.IsNull(txtsono.Text, "").ToString.Trim
        header.h13_rptlen_d = 0
        header.h14_rptwth_d = 0
        header.h15_rptlen_s = 0
        header.h16_rptwth_s = 0
        header.h17_rolltyp = ""
        header.h18_packtyp = ""
        header.h19_nob = 0
        header.h20_supcod = ""
        header.h21_dhcolref = ""
        header.h22_dhcoldt = "19000101"
        header.h23_typ = ""
        header.h24_AB = ""
        header.h25_status = ""
        header.h26_usewth = ""
        header.h27_labsubmit = False
        header.h28_urgent = False
        header.h29_urgentdt = "19000101"
        header.h30_nophenyell = False
        header.h31_noazo = False
        header.h32_dyestd = 0
        header.h33_finlikesmp = False
        header.h34_grading = False
        header.h35_bulksub = False
        header.h36_bulkappdh = False
        header.h37_labeldes = ""
        header.h38_labelwth = ""
        header.h39_ph = False
        header.h40_refspec = False
        header.h41_rollcode = ""
        header.h42_lblcode = ""
        header.h43_pclen = ""
        header.h44_remark = txtSpecialCond.Text.Trim
        header.h45_inoutwear = ""
        header.h46_rwbands = 1
        header.h47_cond = txtPackCond.Text.Trim
        header.h48_sample = txtSampleBook.Text.Trim
        header.h49_lights = ""
        header.h50_D65 = chkLightD65.Checked
        header.h51_D65_order = txtLightD65.Text.Trim
        header.h52_TL83 = chkLightTL83.Checked
        header.h53_TL83_order = txtLightTL83.Text.Trim
        header.h54_TL84 = chkLightTL84.Checked
        header.h55_TL84_order = txtLightTL84.Text.Trim
        header.h56_inc = chkLightIncadescentA.Checked
        header.h57_inc_order = txtLightIncadescentA.Text.Trim
        header.h58_cwf = chkLightCWF.Checked
        header.h59_cwf_order = txtLightCWF.Text.Trim
        header.h60_d65m = chkLightD65Macbeth.Checked
        header.h61_d65m_order = txtLightD65Macbeth.Text.Trim
        header.h62_outreqno = config.IsNull(txtReqNo.Text, "").ToString.Trim
        header.h63_outno = config.IsNull(txtOutno.Text, "").ToString.Trim

        header.h66_delidt = dtpDeliveryDate.Value.ToString("yyyyMMdd")
        header.h67_cfno = ""
        header.h68_dftyp = ""
        header.h69_dfrem = txtRemark.Text.Trim
        header.h72_rev = Val(txtRevise.Text)
        header.h73_diff = 0
        header.h74_style = config.IsNull(cboDyedCase.SelectedValue, "").ToString.Trim
        header.h75_newdesign = chkNewDesign.Checked
        header.h76_len = txtRepeatLen.Text
        header.h77_wth = txtRepeatWidth.Text
        header.h78_ka_std = chkStandardKarisma.Checked
        header.h79_ga_std = chkStandardGamma.Checked
        header.h80_cus_std = chkStandardCustomer.Checked
        header.h111_oth_std = chkStandardOther.Checked 'Sitthana 20200724
        header.h112_oth_std_comment = txtOth_Std_Comment.Text.Trim 'Sitthana 20200724
        header.h81_csample = chkOrderSample.Checked
        header.h82_cbulk = chkOrderBulk.Checked
        header.h83_empcd = clsUser.UserID
        header.h84_issuedt = Now.ToString("yyyyMMdd")
        header.h85_TL84M = chkLightTL84Macbeth.Checked
        header.h86_TL84M_order = txtLightTL84Macbeth.Text.Trim
        header.h88_sample_fabric = 0
        header.h89_sample_hank = 0
        header.h90_sample_card = 0

        header.h94_deliver_to = txtDeliveryTo.Text.Trim
        header.h95_deliver_by = txtDeliveryBy.Text.Trim
        header.h96_design_no_fg = config.IsNull(txtFinishedDesign.SelectedValue, "").ToString.Trim

        If optNorminal.Checked Then
            header.h102_width_type = 1
        ElseIf optEdgeGlue.Checked Then
            header.h102_width_type = 2
        ElseIf optEdgeCut.Checked Then
            header.h102_width_type = 3
        ElseIf optUsable.Checked Then
            header.h102_width_type = 4
        Else
            header.h102_width_type = 1
        End If
        header.h103_dye_loss_percent = Val(txtDyeLossPercent.Text.Trim)
        header.h104_poc_pdf_header_id = cboPDFID.SelectedValue
        header.h105_addl_remark = txtaddl_remark.Text.Trim
        header.h106_addl = chkaddl.Checked
        header.mts_per_roll = Val(txtMtsPerRoll.Text)

        'ToDo: 4. Save Data Modify By Sitthana 07/03/2018 -> Change Check box To Combo Box
        '----- Begin 
        header.h107_DFType = config.IsNull(cboDFType.SelectedValue, 0)
        header.h108_DFTypeRemark = txtDFTypeRemark.Text.Trim

        '-- Old
        header.h91_dye = 0          'chkProcessDying
        header.h92_finish = 0       'chkProcessFinish

        header.h93_preset = 0       'chkProcessPreset
        header.h64_red = 0          'chkProcessReDyed
        header.h100_embroidary = 0  'chkEmbroidary
        header.h101_embroidary_rem = ""   ' txtEmbroidaryRem.Text.Trim
        header.h71_holog = 0        'chkProcessHologram.Checked
        header.h98_holog_rem = ""   'txtHologRem.Text.Trim
        header.h70_pleat = 0        'chkProcessPleat.Checked
        header.h97_pleat_rem = ""   'txtPleatRem.Text.Trim
        header.h65_ref = 0          'chkProcessReFinish.Checked
        header.h87_printing = 0     'chkProcessPrinting.Checked
        header.h99_print_rem = ""   'txtPrintRem.Text.Trim
        header.h109_Sprit = 0     'chkProcessSplit 

        Select Case cboDFType.SelectedValue
            Case DF          'DYE & FINISH
                header.h91_dye = 1          'chkProcessDying.Checked
                header.h92_finish = 1       'chkProcessFinish.Checked
            Case FINISH     'FINISH
                header.h92_finish = 1       'chkProcessFinish.Checked
            Case PRESET    'PRESET
                header.h93_preset = 1       'chkProcessPreset.Checked
            Case REDYE      'RE-DYE
                header.h64_red = 1          'chkProcessReDyed.Checked
            Case EMBROID    'EMBROIDERY
                header.h100_embroidary = 1  'chkEmbroidary.Checked
                header.h101_embroidary_rem = txtDFTypeRemark.Text.Trim
            Case HOLOGRAM   'HOLOGRAM
                header.h71_holog = 1        'chkProcessHologram.Checked
                header.h98_holog_rem = txtDFTypeRemark.Text.Trim
            Case LAMINATE   'LAMINATION
               'none
            Case PLEAT      'PLEAT
                header.h70_pleat = 1        'chkProcessPleat.Checked
                header.h97_pleat_rem = txtDFTypeRemark.Text.Trim
            Case REFINISH   'RE-FINISH
                header.h65_ref = 1          'chkProcessReFinish.Checked
            Case SPLIT      'SPLIT
                header.h109_Sprit = 1
            Case PRINTING      'PRINTING
                header.h87_printing = 1     'chkProcessPrinting.Checked
                header.h99_print_rem = txtDFTypeRemark.Text.Trim
            Case Else

        End Select
        ''----- End

        header.h113_garment = txtGarment.Text.Trim 'Sitthana 20240112

        '----- Check box wait cancel -> Old data from base
        'header.h64_red = chkProcessReDyed.Checked
        'header.h65_ref = chkProcessReFinish.Checked
        'header.h91_dye = chkProcessDying.Checked
        'header.h92_finish = chkProcessFinish.Checked
        'header.h93_preset = chkProcessPreset.Checked
        'header.h70_pleat = chkProcessPleat.Checked
        'header.h97_pleat_rem = txtPleatRem.Text.Trim
        'header.h71_holog = chkProcessHologram.Checked
        'header.h98_holog_rem = txtHologRem.Text.Trim
        'header.h87_printing = chkProcessPrinting.Checked
        'header.h99_print_rem = txtPrintRem.Text.Trim
        'header.h100_embroidary = chkEmbroidary.Checked
        'header.h101_embroidary_rem = txtEmbroidaryRem.Text.Trim

        '----- End  Check box wait cancel

        If clsDF.DFSave_DFORDER_FORM_PKG(header, dv_add, dv_upd, dv_del, msgerr, dfno) Then
            strDFNo = dfno
            SaveData = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveData = False
        End If
    End Function

    Private Function CheckGrdRollNo() As Boolean
        If grdRollNo.DataSource Is Nothing Then Return False
        If grdRollNo.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdRollNo.Rows.Count - 1
            If CBool(grdRollNo.Rows(i).Cells("sel").Value) Then Return True
        Next
        Return False
    End Function

    Private Function CheckGrdDF() As Boolean
        If grdDF.DataSource Is Nothing Then Return False
        If grdDF.Rows.Count = 0 Then Return False
        Dim i As Integer = 0
        For i = 0 To grdDF.Rows.Count - 1
            If CBool(grdDF.Rows(i).Cells("df_sel").Value) Then Return True
        Next
        Return False
    End Function

    Private Function AskBeforeChangeDesignNo(ByVal strChangeType As String) As Boolean
        If grdDF.Rows.Count = 0 Then Return True
        If MessageBox.Show("Program must clear all Roll No. in right pane before change " & strChangeType & vbCrLf _
         & "Would you still like to change " & strChangeType & " ?" & vbCrLf _
         & "โปรแกรมจะเคลียร์ม้วนที่เลือกไว้ทั้งหมดอัติโนมัติก่อนเปลี่ยน " & strChangeType & vbCrLf _
         & "คุณยังต้องการจะเปลี่ยน " & strChangeType & " อีกหรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ClearGrdDesignNo()
        Dim objDB As New classDFOrder
        grdDesign.AutoGenerateColumns = False
        grdDesign.DataSource = objDB.GetSODesignGrid()
    End Sub

    Private Sub ClearGrdRollNo()
        Dim objDB As New classDFOrder
        grdRollNo.AutoGenerateColumns = False
        grdRollNo.DataSource = objDB.GetSORollNoGridPKG()
    End Sub

    Private Sub ClearGrdDF()
        Dim objDB As New classDFOrder
        grdDF.AutoGenerateColumns = False
        grdDF.DataSource = objDB.GetSORollNoGridPKG()
    End Sub

    Private Function CheckDuplicate(ByVal strRollNo As String, ByVal strCol As String, ByVal strSonoid As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("roll_no").ToString.Trim = strRollNo _
                    And dt.Rows(i)("col").ToString.Trim = strCol And dt.Rows(i)("sonoid").ToString.Trim = strSonoid Then Return True
                End If
            Next
        End If
        Return False
    End Function

    Private Sub AddRollNo()
        If grdRollNo.Rows.Count > 0 Then
            Dim config As New clsConfig
            Dim dt As DataTable = grdRollNo.DataSource
            Dim dt2 As DataTable = grdDF.DataSource
            Dim dr As DataRow
            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If CBool(dt.Rows(i)("sel")) Then
                    If Not CheckDuplicate(dt.Rows(i)("roll_no").ToString.Trim, dt.Rows(i)("col").ToString.Trim, dt.Rows(i)("sonoid").ToString.Trim, dt2.Copy()) Then
                        dr = dt2.NewRow
                        For j = 0 To dt2.Columns.Count - 1
                            'If dt2.Columns(j).ColumnName.Trim = "sh" Then
                            '	If dt2.Rows.Count <= 25 Then
                            '		dr(dt2.Columns(j).ColumnName.Trim) = Chr(65 + dt2.Rows.Count)
                            '	Else
                            '		dr(dt2.Columns(j).ColumnName.Trim) = Chr(48 + dt2.Rows.Count - 25)
                            '	End If
                            'Else
                            '	dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                            'End If
                            'MsgBox(dt2.Columns(j).ColumnName.Trim)
                            dr(dt2.Columns(j).ColumnName.Trim) = dt.Rows(i)(dt2.Columns(j).ColumnName.Trim)
                        Next
                        dt2.Rows.Add(dr)
                    Else
                        MessageBox.Show("Roll No. " & dt.Rows(i)("roll_no").ToString.Trim & " Color " & dt.Rows(i)("col").ToString.Trim & " is duplicated in right grid." & vbCrLf _
                        & "If you want to add same Roll No., Please change color by change S/O No. ID in Grid Above." & vbCrLf _
                        & "เลขม้วน " & dt.Rows(i)("roll_no").ToString.Trim & " สี " & dt.Rows(i)("col").ToString.Trim & " ซ้ำกับที่เลือกไว้แล้วด้านขวา" & vbCrLf _
                        & "ถ้าจะใช้เลขม้วนเดิมต้องเปลี่ยนสี ถ้าจะเปลี่ยนสีให้เลือก S/O No. ID จากตารางด้านบนใหม่ แล้วกลับมาเลือกม้วนเดิม." & vbCrLf _
                        , "System Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
                    End If
                End If
            Next
        End If
        Call SumGridDF()
    End Sub

    Private Sub DeleteRollNo(ByVal strType As String)
        If grdDF.Rows.Count > 0 Then
            Dim i As Integer = 0
            Dim dt As DataTable = grdDF.DataSource
            If strType = "ALL" Then
                Call ClearGrdDF()
            Else
                Do While i < dt.Rows.Count
                    If dt.Rows.Count = 0 Then Exit Do
                    For i = 0 To dt.Rows.Count - 1
                        If Not dt.Rows(i).RowState = DataRowState.Deleted Then
                            If CBool(dt.Rows(i)("sel")) Then
                                dt.Rows(i).Delete()
                                Exit For
                            End If
                        End If
                    Next
                Loop
            End If
        End If
        Call SumGridDF()
    End Sub

    Private Sub CreateNewDf()
        If IsDataChange() Then SaveDF()
        If Not blnCancel Then Call InitControl()
    End Sub

    Private Sub SaveDF()
        If Not grdDF.DataSource Is Nothing Then
            If grdDF.Rows.Count > 0 And grdDF.Focused Then
                If grdDF.CurrentCell.IsInEditMode Then
                    Dim cell As DataGridViewCell = grdDF.CurrentCell
                    grdDF.EndEdit(DataGridViewDataErrorContexts.Commit)
                    grdDF.CurrentCell = grdDF.Rows(0).Cells(0)
                    grdDF.CurrentCell = cell
                End If
            End If
        End If
        blnCancel = False
        'Sitthana 20220624 Changed Windows.Forms.DialogResult To DialogResult
        Dim result As DialogResult ' Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = DialogResult.Cancel Then blnCancel = True
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Me.Cursor = Cursors.WaitCursor

        'Call AutoUpdatePDF() 'Add By Nueng 2016/02/24

        If SaveData() Then
            LoadData(strDFNo)
            'Call GenComboDFNo()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmDyingOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Me.Text = "Initializing d/f order form 1"
        Call GenCombo()
        Call GenAutocomplate()
        'Call GenCboPDF("NONE") 'add By Neung 20160204
        Me.Text = "Fetching d/f orders"
        ' Call GenComboDFNo()
        Me.Text = "Setting up form"
        Call InitControl()
        'Call GenCboPDF("NONE") 'add By Neung 20160204
    End Sub

    Private Sub GenAutocomplate()

        Dim dt2 As DataTable = (New classDFOrder).GetAutoCompleteSoNo
        Dim row As DataRow
        txtsono.AutoCompleteSource = AutoCompleteSource.None
        txtsono.AutoCompleteMode = AutoCompleteMode.None
        txtsono.AutoCompleteCustomSource.Clear()
        For Each row In dt2.Rows
            txtsono.AutoCompleteCustomSource.Add(row.Item("sono").ToString())
        Next
        txtsono.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtsono.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim dtReqNo As DataTable = (New classDFOrder).GetAutoCompleteOutReqNo
        Dim rowReqNo As DataRow
        txtReqNo.AutoCompleteSource = AutoCompleteSource.None
        txtReqNo.AutoCompleteMode = AutoCompleteMode.None
        txtReqNo.AutoCompleteCustomSource.Clear()
        For Each rowReqNo In dtReqNo.Rows
            txtReqNo.AutoCompleteCustomSource.Add(rowReqNo.Item("outreqno").ToString())
        Next
        txtReqNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtReqNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub frmDyingOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsDataChange() Then Call SaveDF()
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        CreateNewDf()
        txtGarment.Text = "Eschler" 'Sitthana 20230112
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmDyingOrderSearch
        frm.ShowDialog(Me)
        SaveDF()
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pDFNo)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        strDFNo = ""
        txtDFNo.Text = ""
        dtpDFDate.Value = Now
        txtLotNo.Text = ""
        Dim objDB As New classDFOrder
        Dim dt As New DataTable
        Call BindGridDF(objDB.DFDetLoadPKG(""))
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call SaveDF()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim rptFileName = "rptDFOrder2.rpt" '' "rptDFOrder2.rpt" rptDFOrder2_SBTest 'rptDFOrder2CLO - for COLOMBO Testing because colmbo main df system is not ready yet - John 30/1/2026'

        If strDFNo = "" Then strDFNo = txtDFNo.Text.Trim.ToUpper
        If strDFNo.Length = 0 Then Exit Sub
        If Mid(strDFNo, 1, 2) = "DL" Then
            rptFileName = "rptDFOrder_Lamination.rpt"
            'ElseIf Mid(strDFNo, 1, 3) = "3DF" Then
            '    rptFileName = "rptHeatSettingMaster.rpt"
        End If

        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim logonInfo As New CrystalDecisions.Shared.TableLogOnInfo
        Me.Cursor = Cursors.WaitCursor
        logonInfo.ConnectionInfo.ServerName = clsConn.servername
        logonInfo.ConnectionInfo.DatabaseName = clsConn.database
        logonInfo.ConnectionInfo.IntegratedSecurity = False
        logonInfo.ConnectionInfo.UserID = clsConn.Userid
        logonInfo.ConnectionInfo.Password = clsConn.Password

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.Subreports(0).Database.Tables(0).ApplyLogOnInfo(logonInfo)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dfno", strDFNo)
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@sono", "")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@dhcod", "")
        rpt.SetParameterValue("@design_no", "")
        rpt.SetParameterValue("@empcd", "")
        rpt.SetParameterValue("@lot", "")
        rpt.DataDefinition.ParameterFields("@dfno", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dfno").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@datefr", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@datefr").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@dateto", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dateto").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@sono", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@sono").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@custcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@custcd").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@dhcod", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@dhcod").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@design_no", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@design_no").CurrentValues)
        'rpt.DataDefinition.ParameterFields("@empcd", rpt.Subreports(0).Name).ApplyCurrentValues(rpt.ParameterFields("@empcd").CurrentValues)

        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "D/F Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Validate()

        If strDFNo.Trim.Length = 0 Then Exit Sub Else SaveDF()
        If blnCancel Then Exit Sub
        If lblCancelled.Visible Then
            MessageBox.Show("This document is already cancelled." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        Dim obj As New classDFOrder
        If obj.IsAlreadyGOUT(strDFNo) = True Then
            MessageBox.Show("This document is already GOUT." & vbCrLf & "Can't cancel anymore.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If MessageBox.Show("Would you like to cancel this document ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Dim objDB As New classDFOrder
        Dim Errmessage As String = ""
        If objDB.DFCancel(strDFNo, clsUser.UserID, Errmessage) Then
            CreateNewDf()
        Else
            MessageBox.Show(Errmessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        'Call btnNew_Click(sender, e)
    End Sub

    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Would you like to exit ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then Me.Close()
    End Sub

    Private Sub btnSearchSO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchSO.Click
        Dim frm As New frmSalesOrderSearch
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If frm.pblnOk = True Then
            If Not blnCancel Then txtsono.Text = frm.pSoNo
            Call getSoData()
        End If
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub btnSearchReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchReq.Click
        'a
    End Sub

    Private Sub btnPrintPacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPacking.Click
        If strDFNo = "" Then strDFNo = txtDFNo.Text.Trim.ToUpper
        If strDFNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptDFOrderPacking.rpt" 'rptDFOrderPacking.rpt 'rptDFOrderPackingCLO.rpt
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@dfno", strDFNo)
        rpt.SetParameterValue("@datefr", "")
        rpt.SetParameterValue("@dateto", "")
        rpt.SetParameterValue("@sono", "")
        rpt.SetParameterValue("@custcd", "")
        rpt.SetParameterValue("@dhcod", "")
        rpt.SetParameterValue("@design_no", "")
        rpt.SetParameterValue("@empcd", "")
        frm.Title = "D/F Order Packing"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPrintBlankSheet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBlankSheet.Click
        Dim frm As New frmBlankApvSheet
        frm.UserInfo = clsUser
        frm.MdiParent = Me.MdiParent
        frm.Show()
    End Sub

    Private Sub btnChangeColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeColor.Click
        Dim config As New clsConfig
        If config.IsNull(mltcboColor.SelectedValue, "").ToString.Trim.Length = 0 Then Exit Sub
        If MessageBox.Show("Would you like to apply color '" & config.IsNull(mltcboColor.SelectedValue, "").ToString.Trim & "' to chosen item in grid below ?" & vbCrLf _
         & "คุณต้องการเปลี่ยนสีของรายการที่เลือกด้วยเครื่องหมายถูกในตารางด้านล่างให้เป็นสี '" & config.IsNull(mltcboColor.SelectedValue, "").ToString.Trim & "' ใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub

        Dim dt As DataTable = grdDF.DataSource
        Dim dt2 As DataTable = dt.Copy()
        Dim dtcbocoler As DataTable = TryCast(mltcboColor.DataSource, DataTable) 'Sithana 08/06/2018
        Dim i As Integer = 0

        If dt2.Rows.Count > 0 Then
            For i = 0 To dt2.Rows.Count - 1
                'If CBool(dt2.Rows(i)("sel")) Then 'Comment because will lock 1 DF = 1 Sonoid
                dt2.Rows(i)("sonoid") = dtcbocoler.Rows(mltcboColor.SelectedIndex)("sonoid").ToString 'Sithana 08/06/2018
                dt2.Rows(i)("col") = config.IsNull(mltcboColor.SelectedValue, "").ToString.Trim
                dt2.Rows(i)("custcolor") = dtcbocoler.Rows(mltcboColor.SelectedIndex)("custcol").ToString 'Sithana 08/06/2018
                dt2.Rows(i)("labdipno") = dtcbocoler.Rows(mltcboColor.SelectedIndex)("labdipno").ToString 'Sithana 08/06/2018
                'End If 'Comment By Sithana 08/06/2018
            Next
        End If

        Dim col As String = ""
        Dim roll_no As String = ""
        Dim j As Integer = 0
        For i = 0 To dt2.Rows.Count - 1
            col = dt2.Rows(i)("col").ToString.Trim
            roll_no = dt2.Rows(i)("roll_no").ToString.Trim
            For j = i + 1 To dt2.Rows.Count - 1
                If dt2.Rows(j)("col").ToString.Trim = col _
                 And dt2.Rows(j)("roll_no").ToString.Trim = roll_no Then
                    MessageBox.Show("After apply, Some Roll No. and Color are duplicated." & vbCrLf & "หลังจากเปลี่ยนสีแล้วมีบางม้วนซึ่งเป็นม้วนเดียวกันมีสีเดียวกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If
            Next
        Next

        grdDF.DataSource = dt2
    End Sub


    Private Sub btnMoveLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveLeft.Click
        If grdDesign.Width > 200 Then
            grdDesign.Width = grdDesign.Width - 200
            grdRollNo.Width = grdRollNo.Width - 200
            btnMoveLeft.Left = grdDesign.Right
            btnMoveRight.Left = grdDesign.Right
            btnAdd.Left = grdRollNo.Right
            btnDel.Left = grdRollNo.Right
            btnDelAll.Left = grdRollNo.Right
            grdDF.Left = btnMoveLeft.Right
            grdDF.Width = grdDF.Width + 200
        End If
    End Sub

    Private Sub btnMoveRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveRight.Click
        If grdDF.Width > 200 Then
            grdDesign.Width = grdDesign.Width + 200
            grdRollNo.Width = grdRollNo.Width + 200
            btnMoveLeft.Left = grdDesign.Right
            btnMoveRight.Left = grdDesign.Right
            btnAdd.Left = grdRollNo.Right
            btnDel.Left = grdRollNo.Right
            btnDelAll.Left = grdRollNo.Right
            grdDF.Left = btnMoveLeft.Right
            grdDF.Width = grdDF.Width - 200
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not CheckGrdRollNo() Then Exit Sub
        If MessageBox.Show("Would you like to add selected Roll No. from left grid to right grid ?" & vbCrLf & "คุณต้องการเพิ่มม้วนที่เลือกไว้ด้านซ้ายเพื่อนำไปย้อมด้านขวาใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Call AddRollNo()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If Not CheckGrdDF() Then Exit Sub
        If MessageBox.Show("Would you like to delete selected Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบม้วนที่เลือกไว้เพื่อย้อมในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        If grdDF.CurrentRow.Index >= 0 Then Call DeleteRollNo("SOME")
    End Sub

    Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
        If lblCancelled.Visible Then Exit Sub
        If grdDF.Rows.Count = 0 Then Exit Sub
        If MessageBox.Show("Would you like to delete all Roll No. in right grid ?" & vbCrLf & "คุณต้องการลบม้วน ทั้งหมด ที่เตรียมจะย้อมในด้านขวาออกใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Call DeleteRollNo("ALL")
    End Sub

    'Private Sub cboDFNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
    '    loadDfData()
    'End Sub
    'Private Sub loadDfData()
    '    Dim DFNo As String
    '    DFNo = cboDFNo.ComboBox.Text
    '    If DFNo.Trim.Length > 0 Then
    '        CreateNewDf()
    '        If Not blnCancel Then LoadData(DFNo)
    '    End If
    'End Sub

    Private Sub txtDFNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDFNo.KeyPress
        Dim DFNo As String = ""
        If Asc(e.KeyChar) = 13 Then
            DFNo = txtDFNo.Text.Trim.ToUpper
            CreateNewDf()
            'Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(DFNo)
        End If
    End Sub

    'Private Sub cboSoNo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    idx = txtsono.SelectedIndex
    'End Sub

    'Private Sub cboSoNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If idx >= 0 Then
    '        If txtsono.SelectedIndex = idx Then Exit Sub
    '        If AskBeforeChangeDesignNo("S/O No.") = False Then
    '            txtsono.SelectedIndex = idx
    '        Else

    '            ' Suresh - disabled the following lines on 17-may-2015 to allow multiple designs for lamination
    '            Call DeleteRollNo("ALL")
    '            txtOutno.SelectedIndex = -1
    '        End If
    '    End If
    'End Sub

    Private Sub cboSoNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyValue = Keys.Enter Then
            getSoData()
        End If
    End Sub

    'Private Sub cboSoNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Not (New classSalesOrder).ValidateSOFlowStatus(clsConfig.IsNull(txtsono.SelectedValue, "")) Then
    '        MessageBox.Show("S/O ติดสถานะ ENT มีการแก้ไข S/O ต้อง CFM ก่อน", "System Message")
    '        Call EnabledControl(False)
    '        Exit Sub
    '    End If

    '    If txtsono.SelectedIndex >= 0 And clsConfig.IsNull(txtsono.SelectedValue, "") <> "" Then getSoData()
    'End Sub

    Private Sub getSoData()
        'If txtsono.Text.Trim = "" Then Exit Sub 'Disible By Neung 202021127

        Dim dt As DataTable = (New classDFOrder).GetSoDetail(strSoNo:=txtsono.Text)
        If dt.Rows.Count > 0 Then
            lblCustomer.Text = dt.Rows(0)("custname").ToString.Trim
            txtDeliveryTo.Text = dt.Rows(0)("deliver_to").ToString.Trim
            If txtSpecialCond.Text.Trim = "" Then
                txtSpecialCond.Text = dt.Rows(0)("rem").ToString.Trim
            End If
            txtMtsPerRoll.Text = dt.Rows(0)("mts_per_roll").ToString.Trim
        End If

        'strDyedType = "NORMAL"
        'If txtOutno.Text <> "" Then
        '    strDyedType = "REDYED"
        'End If
        If txtOutno.Text.Trim.Length = 0 Then strDyedType = "NORMAL"
        If txtOutno.Text.Trim.Length > 0 Then
            If txtOutno.Text.ToString.Substring(0, 2) = "GO" Then
                strDyedType = "NORMAL"
            ElseIf txtOutno.Text.ToString.Substring(0, 2) = "DO" Then
                strDyedType = "REDYED" 'Add By Neung 
            End If
        End If

        Call GenComboFGDesignNo()
        txtDesignNo.Text = (New classDFOrder).GetStkDesignNo((New clsConfig).IsNull(txtFinishedDesign.SelectedValue, "").ToString.Trim)

    End Sub

    'Private Sub cboReqNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If txtReqNo.SelectedIndex < 0 Or clsConfig.IsNull(txtReqNo.SelectedValue, "") = "" Then Exit Sub
    '    Dim i As Integer = 0
    '    Dim dt As DataTable = txtReqNo.DataSource
    '    Dim dt2 As New DataTable
    '    dt2 = dt.Copy()
    '    For i = 0 To dt2.Rows.Count - 1
    '        If dt2.Rows(i)("outreqno").ToString.Trim = clsConfig.IsNull(txtReqNo.SelectedValue, "").ToString.Trim Then
    '            txtsono.SelectedValue = dt2.Rows(i)("sono").ToString.Trim
    '            Call cboSoNo_SelectedIndexChanged(sender, e)
    '            If dt2.Rows(i)("sono").ToString.Trim = "SAMPLE" Or
    '             dt2.Rows(i)("sono").ToString.Trim = "DEVL" Then
    '                If dt2.Rows(i)("design_no").ToString.Trim.Length > 0 Then
    '                    txtDesignNo.SelectedValue = dt2.Rows(i)("design_no").ToString.Trim
    '                    Call cboDesignNo_SelectedIndexChanged(sender, e)
    '                End If
    '            End If
    '            Exit For
    '        End If
    '    Next

    '    'ToDo: objDB.DFDetLoadFromReq  Sitthana 08/03/2018
    '    Dim objDB As New classDFOrder
    '    dt = objDB.DFDetLoadFromReqPKG(strDFNo, clsConfig.IsNull(txtReqNo.SelectedValue, "").ToString.Trim)
    '    Call BindGridDF(dt)
    '    Call SumGridDF()
    'End Sub

    'Private Sub cboOutNo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    idx = txtOutno.SelectedIndex
    'End Sub

    'Private Sub cboOutNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If idx >= 0 Then
    '        If txtOutno.SelectedIndex = idx Then Exit Sub
    '        ' Suresh - disabled the following lines on 17-may-2015 to allow multiple designs for lamination

    '        '            If AskBeforeChangeDesignNo("Out No.") = False Then
    '        '            cboOutNo.SelectedIndex = idx
    '        '       Else

    '        'Call DeleteRollNo("ALL")
    '        'cboSoNo.SelectedIndex = -1
    '        'End If
    '    End If
    'End Sub

    'Private Sub cboOutNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If txtOutno.SelectedIndex < 0 Or clsConfig.IsNull(txtOutno.SelectedValue, "") = "" Then Exit Sub
    '    Dim config As New clsConfig
    '    Dim i As Integer = 0
    '    Dim dt As DataTable = txtOutno.DataSource
    '    Dim dt2 As New DataTable
    '    dt2 = dt.Copy()
    '    For i = 0 To dt2.Rows.Count - 1
    '        If dt2.Rows(i)("outno").ToString.Trim = config.IsNull(txtOutno.SelectedValue, "").ToString.Trim Then
    '            'ToDo : 5. Modify By Sitthana 07/03/2018 -> Change Check box To Combo Box
    '            '----- Begin 
    '            Select Case cboDFType.SelectedValue
    '                Case DF, FINISH, PRESET, REDYE, HOLOGRAM, PLEAT, REFINISH, PRINTING
    '                    txtsono.SelectedValue = dt2.Rows(i)("sono").ToString.Trim
    '            End Select
    '            'Case Cut Split
    '            '----- End

    '            '----- Check box wait cancel -> Old data from base
    '            If chkProcessDying.Checked Or chkProcessFinish.Checked Or
    '                chkProcessHologram.Checked Or chkProcessPleat.Checked Or
    '                chkProcessPreset.Checked Or chkProcessPrinting.Checked Or
    '                chkProcessReDyed.Checked Or chkProcessReFinish.Checked Then
    '                txtsono.SelectedValue = dt2.Rows(i)("sono").ToString.Trim
    '            End If
    '            '----- End  Check box wait cancel

    '            Exit For
    '        End If
    '    Next
    '    strDyedType = "REDYED"
    '    Call GenComboDesignNo()
    '    txtFinishedDesign.SelectedValue = config.IsNull(txtDesignNo.SelectedValue, "").ToString.Trim
    'End Sub

    'Private Sub cboDesignNo_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    idx2 = txtDesignNo.SelectedIndex
    'End Sub

    'Private Sub cboDesignNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFinishedDesign.DropDownClosed
    '    If idx2 >= 0 Then
    '        If txtDesignNo.SelectedIndex = idx2 Then Exit Sub
    '        If AskBeforeChangeDesignNo("Design No.") = False Then
    '            txtDesignNo.SelectedIndex = idx2
    '        Else
    '            Call DeleteRollNo("ALL")
    '        End If
    '    End If
    'End Sub

    Private Sub txtFinishedDesign_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFinishedDesign.KeyDown
        If e.KeyValue = Keys.Enter Then getStockData()
    End Sub

    'Private Sub cboDesignNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDesignNo.SelectedIndexChanged
    '    If txtsono.SelectedIndex < 0 Or clsConfig.IsNull(txtsono.SelectedValue, "") = "" Then Exit Sub
    '    If txtDesignNo.SelectedIndex >= 0 And clsConfig.IsNull(txtDesignNo.SelectedValue, "") <> "" Then
    '        txtFinishedDesign.SelectedValue = txtDesignNo.Text
    '        getStockData()
    '    End If
    'End Sub

    Private Sub cboFinishedDesign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFinishedDesign.SelectedIndexChanged
        'If txtsono.SelectedIndex < 0 Or clsConfig.IsNull(txtsono.SelectedValue, "") = "" Then Exit Sub
        If txtsono.Text.Length = 0 Then Exit Sub
        If txtFinishedDesign.SelectedIndex >= 0 And clsConfig.IsNull(txtFinishedDesign.SelectedValue, "") <> "" Then getStockData()
    End Sub

    Private Sub getStockData()
        If txtDesignNo.Text = "" Then Exit Sub
        Dim config As New clsConfig
        Dim objDB As New classDFOrder

        grdDesign.AutoGenerateColumns = False
        If strDyedType = "NORMAL" Then
            grdDesign.DataSource = objDB.GetSODesignGrid(config.IsNull(txtsono.Text, "").ToString.Trim, config.IsNull(Me.txtDesignNo.Text, "Nothing").ToString.Trim, config.IsNull(Me.txtFinishedDesign.Text, "Nothing").ToString.Trim)
        End If
        '        If strDyedType = "REDYED" Then grdDesign.DataSource = objDB.GetStkOutDesignGrid(config.IsNull(cboOutNo.SelectedValue, "").ToString.Trim, config.IsNull(cboDesignNo.SelectedValue, "Nothing").ToString.Trim, config.IsNull(Me.cboFinishedDesign.SelectedValue, "Nothing").ToString.Trim)
        If strDyedType = "REDYED" Then
            grdDesign.DataSource = objDB.GetSODesignGrid(config.IsNull(txtsono.Text, "").ToString.Trim, config.IsNull(Me.txtDesignNo.Text, "Nothing").ToString.Trim, config.IsNull(Me.txtFinishedDesign.Text, "Nothing").ToString.Trim)
        End If
        Call ClearGrdRollNo()
        Call SumGridRollNo()
    End Sub

    Private Sub grdDesign_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDesign.CellClick
        If grdDesign.DataSource Is Nothing Then Exit Sub
        If grdDesign.Rows.Count = 0 Then Exit Sub
        If e.RowIndex < 0 Then Exit Sub

        Dim config As New clsConfig
        Dim objDB As New classDFOrder
        Dim dt As New DataTable


        grdRollNo.AutoGenerateColumns = False
        'ToDo : SBTest -> Get Data to grdRollNo by grdDesign  : Sitthana 09/03/2018

        If strDyedType = "NORMAL" Then dt = objDB.GetSORollNoGridPKG(strDFNo,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("sonoid").Value, "").ToString.Trim,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("design_no").Value, "").ToString.Trim,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("gwth").Value, "").ToString.Trim,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("col").Value, "").ToString.Trim,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("custcol").Value, "").ToString.Trim)
        If strDyedType = "REDYED" Then dt = objDB.GetStkOutRollNoGridPKG(strDFNo,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("sonoid").Value, "").ToString.Trim,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("design_no").Value, "").ToString.Trim,
          config.IsNull(Val(grdDesign.Rows(e.RowIndex).Cells("gwth").Value), "").ToString.Trim,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("col").Value, "").ToString.Trim,
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("custcol").Value, "").ToString.Trim,
          config.IsNull(txtOutno.Text, "").ToString.Trim)
        grdRollNo.DataSource = dt

        If (dt.Rows.Count > 0) Then
            If CInt(dt.Rows(0)("sys_width_id")).Equals(0) Then
                optNorminal.Checked = True
            ElseIf CInt(dt.Rows(0)("sys_width_id")).Equals(1) Then
                optNorminal.Checked = True
            ElseIf CInt(dt.Rows(0)("sys_width_id")).Equals(2) Then
                optUsable.Checked = True
            ElseIf CInt(dt.Rows(0)("sys_width_id")).Equals(3) Then
                optEdgeCut.Checked = True
            ElseIf CInt(dt.Rows(0)("sys_width_id")).Equals(4) Then
                optEdgeGlue.Checked = True
            End If
        End If

        'GenCboPDF(grdDesign.CurrentRow.Cells("sonoid").Value) 'Add By Neung

    End Sub

    Private Sub GenCboPDF(ByVal Strsonoid As String)
        Dim objDB As New classSearchPDF
        'Dim dt As New DataTable
        'dt = objDB.SearchPDF(Strsonoid)

        'Me.cboSoNo.DataSource = objDB.GetSoNo
        'Me.cboSoNo.DisplayMember = "sono2"
        'Me.cboSoNo.ValueMember = "sono2"
        'grdDesign.CurrentRow.Cells("sonoid").Value

        cboPDFID.DataSource = objDB.SearchPDF(Strsonoid)
        cboPDFID.ValueMember = "poc_pdf_header_id"
        cboPDFID.DisplayMember = "pdf_number"
        'cboPDFID.SelectedIndex = -1

        cboPDFID.Enabled = False

    End Sub
    Private Sub grdRollNo_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRollNo.CellContentClick
        If grdRollNo.CurrentCell.IsInEditMode Then grdRollNo.EndEdit()
    End Sub

    Private Sub grdRollNo_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdRollNo.CellEndEdit
        If grdRollNo.Columns(e.ColumnIndex).Name = "sel" Then Call SumGridRollNo()
    End Sub

    Private Function CheckDelRow(ByVal dt As DataTable, ByVal RowIndex As Integer) As Integer
        Dim i As Integer = 0
        Dim j As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If i <= RowIndex Then
                If dt.Rows(i).RowState = DataRowState.Deleted Then j = j + 1
            End If
        Next
        Return j
    End Function

    Private Sub grdDF_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDF.CellEndEdit
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
        If grdDF.Columns(e.ColumnIndex).Name = "df_kg" Or
         grdDF.Columns(e.ColumnIndex).Name = "df_yds" Or
         grdDF.Columns(e.ColumnIndex).Name = "df_mts" Then
            If CBool(chkAutoCalculate.Checked) Then
                '            Dim dt As DataTable = grdDF.DataSource
                '			 Dim i As Integer = CheckDelRow(dt, e.RowIndex)
                '            If grdDF.Columns(e.ColumnIndex).Name = "df_kg" Then
                '                dt.Rows(e.RowIndex + i)("qc_yds") = FormatNumber(dt.Rows(e.RowIndex + i)("qc_kg") * dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                '                dt.Rows(e.RowIndex + i)("qc_mts") = FormatNumber(dt.Rows(e.RowIndex + i)("qc_yds") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                '            End If
                '            If grdDF.Columns(e.ColumnIndex).Name = "df_yds" Then
                '                If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("qc_kg") = FormatNumber(dt.Rows(e.RowIndex + i)("qc_yds") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                '                dt.Rows(e.RowIndex + i)("qc_mts") = FormatNumber(dt.Rows(e.RowIndex + i)("qc_yds") * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                '            End If
                '            If grdDF.Columns(e.ColumnIndex).Name = "df_mts" Then
                '                dt.Rows(e.RowIndex + i)("qc_yds") = FormatNumber(dt.Rows(e.RowIndex + i)("qc_mts") / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                '                If Val(dt.Rows(e.RowIndex + i)("ydkg")) > 0 Then dt.Rows(e.RowIndex + i)("qc_kg") = FormatNumber(dt.Rows(e.RowIndex + i)("qc_yds") / dt.Rows(e.RowIndex + i)("ydkg"), 2, TriState.False, TriState.False, TriState.False)
                '            End If
                If grdDF.Columns(e.ColumnIndex).Name = "df_kg" Then
                    grdDF.Rows(e.RowIndex).Cells("df_yds").Value = FormatNumber(Val(grdDF.Rows(e.RowIndex).Cells("df_kg").Value) * Val(grdDF.Rows(e.RowIndex).Cells("ydkg").Value), 2, TriState.False, TriState.False, TriState.False)
                    grdDF.Rows(e.RowIndex).Cells("df_mts").Value = FormatNumber(Val(grdDF.Rows(e.RowIndex).Cells("df_yds").Value) * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdDF.Columns(e.ColumnIndex).Name = "df_yds" Then
                    If Val(grdDF.Rows(e.RowIndex).Cells("ydkg").Value) > 0 Then grdDF.Rows(e.RowIndex).Cells("df_kg").Value = FormatNumber(Val(grdDF.Rows(e.RowIndex).Cells("df_yds").Value) / Val(grdDF.Rows(e.RowIndex).Cells("ydkg").Value), 2, TriState.False, TriState.False, TriState.False)
                    grdDF.Rows(e.RowIndex).Cells("df_mts").Value = FormatNumber(Val(grdDF.Rows(e.RowIndex).Cells("df_yds").Value) * 0.9144, 2, TriState.False, TriState.False, TriState.False)
                End If
                If grdDF.Columns(e.ColumnIndex).Name = "df_mts" Then
                    grdDF.Rows(e.RowIndex).Cells("df_yds").Value = FormatNumber(Val(grdDF.Rows(e.RowIndex).Cells("df_mts").Value) / 0.9144, 2, TriState.False, TriState.False, TriState.False)
                    If Val(grdDF.Rows(e.RowIndex).Cells("ydkg").Value) > 0 Then grdDF.Rows(e.RowIndex).Cells("df_kg").Value = FormatNumber(Val(grdDF.Rows(e.RowIndex).Cells("df_yds").Value) / Val(grdDF.Rows(e.RowIndex).Cells("ydkg").Value), 2, TriState.False, TriState.False, TriState.False)
                End If
            End If
            Call SumGridDF()
        End If
    End Sub

    Private Sub grdDF_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdDF.DataError
        'MessageBox.Show("Data error, please check your value !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        e.Cancel = True
    End Sub

    Private Sub grdDF_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles grdDF.UserDeletedRow
        Call SumGridDF()
    End Sub

    Private Sub grdDF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdDF.KeyDown
        Dim i As Integer = 0
        If e.KeyCode = Keys.Enter Then
            If grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "df_dhcol" Or
              grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "dhcoldt" Or
              grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "labdipno" Then
                Dim strReplace As String = InputBox("ใส่ข้อมูลที่ต้องการให้ใส่ลงตาราง" & vbCrLf & "Input data into grid.", "System Message", "")
                For i = 0 To grdDF.SelectedCells.Count - 1
                    If grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "df_dhcol" Or
                     grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "labdipno" Then
                        grdDF.SelectedCells(i).Value = strReplace
                    End If
                    If grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "dhcoldt" Then
                        If IsDate(strReplace) Then grdDF.SelectedCells(i).Value = CDate(strReplace).ToString("dd/MM/yyyy")
                    End If

                Next
            ElseIf grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "df_sel" Then
                For i = 0 To grdDF.SelectedCells.Count - 1
                    grdDF.SelectedCells(i).Value = Not CBool(grdDF.SelectedCells(i).Value)
                Next
            End If
        End If
    End Sub

    Private Sub grdRollNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdRollNo.KeyDown
        Dim i As Integer = 0
        If e.KeyCode = Keys.Enter Then
            If grdRollNo.Columns(grdRollNo.SelectedCells(i).ColumnIndex).Name = "sel" Then
                For i = 0 To grdRollNo.SelectedCells.Count - 1
                    grdRollNo.SelectedCells(i).Value = Not CBool(grdRollNo.SelectedCells(i).Value)
                Next
            End If
        End If
    End Sub

    '   Private Sub cboDesignNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignNo.Validated
    '       getStockData()
    '   End Sub

    '   Private Sub cboDesignNo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboDesignNo.Validating
    '       getStockData()
    'End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        Call getStockData()
    End Sub

    'Private Sub cboDFNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '    If e.KeyValue = Keys.Enter Then Call loadDfData()
    'End Sub


    'Private Sub AllCombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
    'Handles cboDFNo.GotFocus, _
    'cboSoNo.GotFocus, _
    'cboReqNo.GotFocus, _
    'cboDyedHouse.GotFocus, _
    'cboDyedCase.GotFocus, _
    'cboOutNo.GotFocus, _
    'txtDFNo.GotFocus, _
    'TabControl1.Click, _
    'btnNew.MouseHover, _
    'btnSearch.MouseHover
    '   If Not blnGenCombo Then
    '        blnGenCombo = True
    '         Dim strTitle As String = Me.Text
    '          Dim i As Integer
    '           Me.Cursor = Cursors.WaitCursor
    '            Me.Text = "Please wait while program is initializing data ."

    'Me.Text = "Begin Initializing ..."
    'Call GenCombo()
    'For i = 0 To 50
    '    Me.Text = "Initialize " & i & " % Completed"
    'Next
    'Call GenComboDFNo()
    ' For i = 51 To 75
    '      Me.Text = "Initialize " & i & " % Completed"
    '   Next
    '    Call InitControl()
    '     For i = 76 To 100
    '          Me.Text = "Initialize " & i & " % Completed"
    '        Next
    '         Me.Text = strTitle
    '           Me.Cursor = Cursors.Default
    '      End If
    '  End Sub




    Private Sub txtBarcode_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode.Equals(Keys.Enter) Then
            Dim isFound As Boolean = False

            If grdRollNo.Rows.Count > 0 Then
                Dim config As New clsConfig
                Dim dt As DataTable = grdRollNo.DataSource
                Dim i As Integer = 0
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i)("roll_no").ToString().Trim().Equals(txtBarcode.Text.Trim()) Then
                        dt.Rows(i)("sel") = True
                        isFound = True
                        Exit For
                    End If
                Next
            End If

            If Not isFound Then MessageBox.Show("Roll No. " + txtBarcode.Text.Trim() + " is not found.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtBarcode.Text = ""
            txtBarcode.Focus()
        End If
    End Sub

    Private Sub cboDyedHouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDyedHouse.SelectedIndexChanged
        Me.txtDeliveryBy.Text = UCase(cboDyedHouse.Text)
    End Sub

    Private Sub BtnSearchPDF_Click(sender As System.Object, e As System.EventArgs) Handles BtnSearchPDF.Click
        Dim frm As New frmSearchPDF
        Dim config As New clsConfig

        If Not grdDesign.Rows.Count > 0 Then
            MessageBox.Show("Please Select S/O No. ID First ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If config.IsNull(grdDesign.CurrentRow.Cells("sonoid").Value, "") = "" Then
            MessageBox.Show("Please Select S/O No. ID First ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        frm.pSoNoID = grdDesign.CurrentRow.Cells("sonoid").Value
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If Not config.IsNull(frm.pPoc_pdf_header_id, 0) = 0 Then cboPDFID.SelectedValue = frm.pPoc_pdf_header_id


        cboPDFID.Enabled = False
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Function AutoUpdatePDF() As Boolean
        Dim dt As DataTable = grdDF.DataSource
        Dim config As New clsConfig

        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    dt.Rows(i)("poc_pdf_header_id") = config.IsNull(cboPDFID.SelectedValue, "").ToString.Trim
                End If
            Next
            Return True
        Else
            Return False
        End If

        cboPDFID.Enabled = False

    End Function

    Private Sub cboDFType_DropDownClosed(sender As Object, e As EventArgs) Handles cboDFType.DropDownClosed
        'Sitthana 07/03/2018
        clearChkBoxAll()
        txtDFTypeRemark.Text = ""
        txtDFTypeRemark.ReadOnly = True

        Select Case cboDFType.SelectedValue
            Case DF          'DYE & FINISH
                chkProcessDying.Checked = True
                chkProcessFinish.Checked = True
            Case FINISH     'FINISH
                chkProcessFinish.Checked = True
            Case PRESET    'PRESET
                chkProcessPreset.Checked = True
            Case REDYE      'RE-DYE
                chkProcessReDyed.Checked = True
            Case EMBROID    'EMBROIDERY
                txtDFTypeRemark.Text = ""
                txtDFTypeRemark.Text = txtEmbroidaryRem.Text.Trim  'Wait Cancel Sitthana 08/03/2018
                txtDFTypeRemark.ReadOnly = False
                chkProcessEmbroidary.Checked = True
            Case HOLOGRAM   'HOLOGRAM
                txtDFTypeRemark.Text = ""
                txtDFTypeRemark.Text = txtHologRem.Text.Trim  'Wait Cancel Sitthana 08/03/2018
                txtDFTypeRemark.ReadOnly = False
                chkProcessHologram.Checked = True
            Case LAMINATE   'LAMINATION
                chkProcessLaminame.Checked = True
            Case PLEAT      'PLEAT
                txtDFTypeRemark.Text = ""
                txtDFTypeRemark.Text = txtPleatRem.Text.Trim  'Wait Cancel Sitthana 08/03/2018
                txtDFTypeRemark.ReadOnly = False
                chkProcessPleat.Checked = True
            Case REFINISH   'RE-FINISH
                chkProcessReFinish.Checked = True
            Case SPLIT      'SPLIT
                chkProcessSplit.Checked = True
            Case PRINTING      'PRINTING
                txtDFTypeRemark.Text = ""
                txtDFTypeRemark.Text = txtPrintRem.Text.Trim  'Wait Cancel Sitthana 08/03/2018
                txtDFTypeRemark.ReadOnly = False
                chkProcessPrinting.Checked = True
            Case Else

        End Select
    End Sub
    Private Sub clearChkBoxAll()
        'ToDo: 6. Create new By Sitthana 07/03/2018 -> Change Check box To Combo Box
        '----- wait delete

        chkProcessDying.Checked = False
        chkProcessFinish.Checked = False
        chkProcessPreset.Checked = False
        chkProcessReDyed.Checked = False
        chkProcessEmbroidary.Checked = False
        chkProcessHologram.Checked = False
        chkProcessLaminame.Checked = False  'New
        chkProcessPleat.Checked = False
        chkProcessReFinish.Checked = False
        chkProcessSplit.Checked = False
        chkProcessPrinting.Checked = False
    End Sub

    Private Sub cboDFNo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grdDF_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDF.CellContentClick

    End Sub

    Private Sub btnSearchDFNo_Click(sender As Object, e As EventArgs) Handles btnSearchDFNo.Click
        Dim frm As New frmDyingOrderSearch
        frm.Userinfo = clsUser
        frm.ShowDialog(Me)
        SaveDF()
        Me.Cursor = Cursors.WaitCursor
        If Not blnCancel Then LoadData(frm.pDFNo)
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtsono_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsono.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call getSoData()
        End If
    End Sub

    Private Sub txtOutno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOutno.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Not CheckDataOutno() Then Exit Sub

            Select Case cboDFType.SelectedValue
                Case REDYE, REFINISH, PRINTING '=======Disible By neung only redye, refinish and printing will load so again , other is not.'DF, FINISH, PRESET, HOLOGRAM, PLEAT
                    txtsono.Text = (New classDFOrder).GetSoNoByOutNo(txtOutno.Text.Trim)
                    Call getSoData()
            End Select

            strDyedType = "REDYED"
            Call GenComboFGDesignNo()


        End If
    End Sub
    Private Function CheckDataOutno() As Boolean

        If clsConfig.IsNull(txtOutno.Text, "") = "" Then
            MessageBox.Show("คุณยังไม่ได้เลือก Out No.", "System Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Select Case cboDFType.SelectedValue
            Case "0"
                MessageBox.Show("คุณยังไม่ได้เลือก DF Process Type", "System Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
        End Select
        If txtsono.Text.Trim = "" Then
            Select Case cboDFType.SelectedValue
                Case DF, FINISH, PRESET, HOLOGRAM, PLEAT
                    MessageBox.Show("คุณยังไม่ได้เลือก S/O No.", "System Meassage", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
            End Select
        End If

        Return True
    End Function
    Private Sub GenComboFGDesignNo()
        Dim config As New clsConfig
        Dim objDB As New classDFOrder

        'Begin Sitthana 20181214
        'Change if to select case 
        Select Case strDyedType
            Case "NORMAL"
                txtFinishedDesign.DataSource = objDB.GetSODesign(txtsono.Text.Trim)
                txtDesignNo.Text = objDB.GetStkDesignNo(config.IsNull(txtFinishedDesign.SelectedValue, "").ToString.Trim)
            Case "REDYED"
                txtDesignNo.Text = objDB.GetStkOutDesignNo(config.IsNull(txtOutno.Text, "").ToString.Trim)
                txtFinishedDesign.DataSource = objDB.GetSODesign(txtsono.Text.Trim)
        End Select

        txtFinishedDesign.DisplayMember = "design_no"
        txtFinishedDesign.ValueMember = "design_no"

        If txtFinishedDesign.Items.Count > 0 Then
            txtFinishedDesign.SelectedIndex = 0
        End If
        Call GenComboColor()
        'End Sitthana 201812114

    End Sub

    Private Sub txtReqNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReqNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtReqNo.Text = "" Then Exit Sub
            txtsono.Text = (New classDFOrder).GetSONOByReqNo(txtReqNo.Text)
            Call getSoData()
            If txtsono.Text.Trim = "SAMPLE" Or
             txtsono.Text.Trim = "DEVL" Then

                If (New classDFOrder).GetDesignNoByReqNo(txtReqNo.Text) <> "" Then
                    txtDesignNo.Text = (New classDFOrder).GetDesignNoByReqNo(txtReqNo.Text)
                    Call txtDesignNo_SelectedIndexChanged(sender, e)
                End If
            End If

            'Dim objDB As New classDFOrder
            'Dim dt = objDB.DFDetLoadFromReq(strDFNo, clsConfig.IsNull(txtReqNo.Text, "").ToString.Trim)
            'Call BindGridDF(dt)
            'Call SumGridDF()
        End If
    End Sub

    Private Sub txtDesignNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If txtsono.Text.Length = 0 Then Exit Sub
        If clsConfig.IsNull(txtDesignNo.Text, "") <> "" Then
            Call getStockData()
        End If
    End Sub

    Private Sub txtDesignNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyValue = Keys.Enter Then
            If txtDesignNo.Text <> "" And txtFinishedDesign.Text <> "" Then
                Call getStockData()
            End If
        End If
    End Sub
End Class