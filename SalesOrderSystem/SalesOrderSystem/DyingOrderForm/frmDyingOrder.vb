Public Class frmDyingOrder
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
            cbo.SelectedValue = ""
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
        strDFNo = ""
        lblCustomer.Text = ""
        lblCancelled.Visible = False
        Call ClearGrdDesignNo()
        Call ClearGrdRollNo()
        Call ClearGrdDF()
        Call LoadData("")
        txtDFNo.Focus()
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

        Me.cboSoNo.DataSource = objDB.GetSoNo
        Me.cboSoNo.DisplayMember = "sono2"
        Me.cboSoNo.ValueMember = "sono2"

        Me.cboDyedHouse.DataSource = objDB.GetDyedHouse
        Me.cboDyedHouse.DisplayMember = "name"
        Me.cboDyedHouse.ValueMember = "suppcd2"

        Me.cboDyedCase.DataSource = objDB.GetDyedCase
        Me.cboDyedCase.DisplayMember = "dyedcase"
        Me.cboDyedCase.ValueMember = "dyedcase"

        'ยังไม่ได้แก้ไข Greige Design
        'Me.cboDesignNo.DataSource = objDB.GetDesign
        'Me.cboDesignNo.DisplayMember = "design_no"
        'Me.cboDesignNo.ValueMember = "design_no"

        Me.cboFinishedDesign.DataSource = objDB.GetDesign
        Me.cboFinishedDesign.DisplayMember = "design_no"
        Me.cboFinishedDesign.ValueMember = "design_no"

        Me.cboReqNo.DataSource = objREQ.GetReqNo
        Me.cboReqNo.DisplayMember = "outreqno"
        Me.cboReqNo.ValueMember = "outreqno"

        Me.cboOutNo.DataSource = objDB.GetOutNo
        Me.cboOutNo.DisplayMember = "outno"
        Me.cboOutNo.ValueMember = "outno"

        Me.df_col.DataSource = objDB.GetColor
        Me.df_col.DisplayMember = "col2"
        Me.df_col.ValueMember = "col2"
    End Sub

    Private Sub GenComboDFNo()
        Dim objDB As New classDFOrder
        cboDFNo.ComboBox.DataSource = objDB.DFComboLoad()
        cboDFNo.ComboBox.DisplayMember = "dfno"
        cboDFNo.ComboBox.ValueMember = "dfno"
        If strDFNo.Trim.Length > 0 Then cboDFNo.ComboBox.SelectedValue = strDFNo.Trim
    End Sub

    Private Sub GenComboDesignNo()
        Dim config As New clsConfig
        Dim objDB As New classDFOrder
        If strDyedType = "NORMAL" Then cboDesignNo.DataSource = objDB.GetSODesign(config.IsNull(cboSoNo.Text.Trim, "").ToString.Trim)
        If strDyedType = "REDYED" Then cboDesignNo.DataSource = objDB.GetStkOutDesign(config.IsNull(cboOutNo.SelectedValue, "").ToString.Trim)
        cboDesignNo.DisplayMember = "design_no"
        cboDesignNo.ValueMember = "design_no"
        Call GenComboColor()
    End Sub

    Private Sub GenComboColor()
        Dim config As New clsConfig
        Dim objDB As New classDFOrder
        Me.cboColor.DataSource = objDB.GetSOColor(config.IsNull(cboSoNo.Text, "").ToString.Trim)
        Me.cboColor.DisplayMember = "col"
        Me.cboColor.ValueMember = "col"
    End Sub

    Private Sub BindData(ByVal dt As DataTable)
        strDFNo = dt.Rows(0)("dfno").ToString.Trim
        txtDFNo.Text = dt.Rows(0)("dfno").ToString.Trim
        dtpDFDate.Value = CDate(dt.Rows(0)("dfdt2").ToString)
        txtLotNo.Text = dt.Rows(0)("lot").ToString.Trim
        txtRevise.Text = dt.Rows(0)("rev").ToString.Trim

        cboSoNo.SelectedValue = dt.Rows(0)("sono").ToString.Trim
        cboOutNo.SelectedValue = dt.Rows(0)("outno").ToString.Trim
        If dt.Rows(0)("outno").ToString.Trim.Length = 0 Then strDyedType = "NORMAL"
        If dt.Rows(0)("outno").ToString.Trim.Length > 0 Then strDyedType = "REDYED"

        Call GenComboDesignNo()

        cboDesignNo.Text = dt.Rows(0)("design_no").ToString.Trim
        cboFinishedDesign.Text = dt.Rows(0)("design_no_fg").ToString.Trim
        cboReqNo.SelectedValue = dt.Rows(0)("outreqno").ToString.Trim
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

        chkProcessDying.Checked = CBool(dt.Rows(0)("dye"))
        chkProcessFinish.Checked = CBool(dt.Rows(0)("finish"))
        chkProcessPreset.Checked = CBool(dt.Rows(0)("preset"))
        If dt.Rows(0)("lottype").ToString.Trim = "N" Then optLotNormal.Checked = True
        If dt.Rows(0)("lottype").ToString.Trim = "T" Then optLotTesting.Checked = True
        If dt.Rows(0)("lottype").ToString.Trim = "S" Then optLotSample.Checked = True
        chkNewDesign.Checked = CBool(dt.Rows(0)("newdesign"))
        txtRepeatLen.Text = dt.Rows(0)("len").ToString.Trim
        txtRepeatWidth.Text = dt.Rows(0)("wth").ToString.Trim
        chkStandardKarisma.Checked = CBool(dt.Rows(0)("ka_std"))
        chkStandardGamma.Checked = CBool(dt.Rows(0)("ga_std"))
        chkStandardCustomer.Checked = CBool(dt.Rows(0)("cus_std"))
        chkOrderSample.Checked = CBool(dt.Rows(0)("csample"))
        chkOrderBulk.Checked = CBool(dt.Rows(0)("cbulk"))
        txtDyeLossPercent.Text = dt.Rows(0)("dye_loss_percent").ToString().Trim
        txtPackCond.Text = dt.Rows(0)("cond").ToString.Trim
        txtSpecialCond.Text = dt.Rows(0)("remark").ToString.Trim
        txtSampleBook.Text = dt.Rows(0)("sample").ToString.Trim
        txtRemark.Text = dt.Rows(0)("dfrem").ToString.Trim

        chkProcessReDyed.Checked = CBool(dt.Rows(0)("red"))
        chkProcessReFinish.Checked = CBool(dt.Rows(0)("ref"))
        chkProcessPleat.Checked = CBool(dt.Rows(0)("pleat"))
        txtPleatRem.Text = dt.Rows(0)("pleat_rem").ToString.Trim
        chkProcessHologram.Checked = CBool(dt.Rows(0)("holog"))
        txtHologRem.Text = dt.Rows(0)("holog_rem").ToString.Trim
        chkProcessPrinting.Checked = CBool(dt.Rows(0)("printing"))
        txtPrintRem.Text = dt.Rows(0)("print_rem").ToString.Trim
        chkEmbroidary.Checked = CBool(dt.Rows(0)("embroidary"))
        txtEmbroidaryRem.Text = dt.Rows(0)("embroidary_rem").ToString.Trim

        txtOwner.Text = dt.Rows(0)("empname").ToString.Trim
        dtpCreateDate.Value = CDate(dt.Rows(0)("issuedt2").ToString)
        txtMtsPerRoll.Text = dt.Rows(0)("mts_per_roll").ToString.Trim

        cboDesignNo.SelectedValue = dt.Rows(0)("design_no").ToString.Trim
        cboFinishedDesign.SelectedValue = dt.Rows(0)("design_no_fg").ToString.Trim

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

            If config.IsNull(cboSoNo.SelectedValue, "") <> "" Then result = True
            If config.IsNull(cboReqNo.SelectedValue, "") <> "" Then result = True
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

            If CBool(chkProcessDying.Checked) Then result = True
            If CBool(chkProcessFinish.Checked) Then result = True
            If CBool(chkProcessPreset.Checked) Then result = True
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
            If config.IsNull(cboDesignNo.SelectedValue, "") <> "" Then result = True
            If config.IsNull(cboFinishedDesign.SelectedValue, "") <> "" Then result = True
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

                If config.IsNull(cboSoNo.SelectedValue, "").ToString.Trim <> dt.Rows(j)("sono").ToString.Trim Then result = True
                If config.IsNull(cboReqNo.SelectedValue, "").ToString.Trim <> dt.Rows(j)("outreqno").ToString.Trim Then result = True
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

                If chkProcessDying.Checked <> CBool(dt.Rows(j)("dye")) Then result = True
                If chkProcessFinish.Checked <> CBool(dt.Rows(j)("finish")) Then result = True
                If chkProcessPreset.Checked <> CBool(dt.Rows(j)("preset")) Then result = True
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
                If config.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim <> dt.Rows(j)("design_no_d").ToString.Trim Then result = True
                If config.IsNull(cboFinishedDesign.SelectedValue, "").ToString.Trim <> dt.Rows(j)("design_no_fg").ToString.Trim Then result = True
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
        If config.IsNull(cboSoNo.SelectedValue, "").ToString.Trim = "" Or config.IsNull(Me.cboSoNo.Text, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Sales Order No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(cboDyedHouse.SelectedValue, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Dyed House!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(Me.cboDesignNo.Text, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Finished Design No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If

        If config.IsNull(cboFinishedDesign.Text, "").ToString.Trim = "" Then
            MessageBox.Show("Please choose Finished Design No.!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        End If
        If config.IsNull(cboDyedCase.SelectedValue, "").ToString.Trim = "" Then
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
        CheckData = True
    End Function

    Private Sub LoadData(ByVal DFNo As String)
        Dim objDB As New classDFOrder
        Dim dt As New DataTable
        dt = objDB.DFDetLoad(DFNo)
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
        header.h04_design_no = config.IsNull(cboDesignNo.Text, "").ToString.Trim
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
        header.h12_sono = config.IsNull(cboSoNo.SelectedValue, "").ToString.Trim
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
        header.h62_outreqno = config.IsNull(cboReqNo.SelectedValue, "").ToString.Trim
        header.h63_outno = config.IsNull(cboOutNo.SelectedValue, "").ToString.Trim
        header.h64_red = chkProcessReDyed.Checked
        header.h65_ref = chkProcessReFinish.Checked
        header.h66_delidt = dtpDeliveryDate.Value.ToString("yyyyMMdd")
        header.h67_cfno = ""
        header.h68_dftyp = ""
        header.h69_dfrem = txtRemark.Text.Trim
        header.h70_pleat = chkProcessPleat.Checked
        header.h71_holog = chkProcessHologram.Checked
        header.h72_rev = Val(txtRevise.Text)
        header.h73_diff = 0
        header.h74_style = config.IsNull(cboDyedCase.SelectedValue, "").ToString.Trim
        header.h75_newdesign = chkNewDesign.Checked
        header.h76_len = txtRepeatLen.Text
        header.h77_wth = txtRepeatWidth.Text
        header.h78_ka_std = chkStandardKarisma.Checked
        header.h79_ga_std = chkStandardGamma.Checked
        header.h80_cus_std = chkStandardCustomer.Checked
        header.h81_csample = chkOrderSample.Checked
        header.h82_cbulk = chkOrderBulk.Checked
        header.h83_empcd = clsUser.UserID
        header.h84_issuedt = Now.ToString("yyyyMMdd")
        header.h85_TL84M = chkLightTL84Macbeth.Checked
        header.h86_TL84M_order = txtLightTL84Macbeth.Text.Trim
        header.h87_printing = chkProcessPrinting.Checked
        header.h88_sample_fabric = 0
        header.h89_sample_hank = 0
        header.h90_sample_card = 0
        header.h91_dye = chkProcessDying.Checked
        header.h92_finish = chkProcessFinish.Checked
        header.h93_preset = chkProcessPreset.Checked
        header.h94_deliver_to = txtDeliveryTo.Text.Trim
        header.h95_deliver_by = txtDeliveryBy.Text.Trim
        header.h96_design_no_fg = config.IsNull(cboFinishedDesign.SelectedValue, "").ToString.Trim
        header.h97_pleat_rem = txtPleatRem.Text.Trim
        header.h98_holog_rem = txtHologRem.Text.Trim
        header.h99_print_rem = txtPrintRem.Text.Trim
        header.h100_embroidary = chkEmbroidary.Checked
        header.h101_embroidary_rem = txtEmbroidaryRem.Text.Trim

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
        header.mts_per_roll = Val(txtMtsPerRoll.Text)

        If clsDF.DFSave(header, dv_add, dv_upd, dv_del, msgerr, dfno) Then
            strDFNo = dfno
            MessageBox.Show("บันทึกสำเร็จ!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
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
        grdRollNo.DataSource = objDB.GetSORollNoGrid()
    End Sub

    Private Sub ClearGrdDF()
        Dim objDB As New classDFOrder
        grdDF.AutoGenerateColumns = False
        grdDF.DataSource = objDB.GetSORollNoGrid()
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
        If SaveData() Then
            LoadData(strDFNo)
            Call GenComboDFNo()
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub frmDyingOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call GenCombo()
        Call GenComboDFNo()
        Call InitControl()
    End Sub

    Private Sub frmDyingOrder_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsDataChange() Then Call SaveDF()
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        CreateNewDf()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
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
        Call BindGridDF(objDB.DFDetLoad(""))
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SaveDF()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If strDFNo = "" Then strDFNo = txtDFNo.Text.Trim.ToUpper
        If strDFNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptDFOrder2.rpt"
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

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "D/F Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
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
        Dim ErrorMessage As String = ""
        If objDB.DFCancel(strDFNo, clsUser.UserID, ErrorMessage) Then
            MessageBox.Show("ยกเลิก สำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Call CreateNewDf()
        Else
            MessageBox.Show(ErrorMessage, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
        ' CreateNewDf()
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
        If Not blnCancel Then cboSoNo.SelectedValue = frm.pSoNo
        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub btnSearchReq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchReq.Click
        'a
    End Sub

    Private Sub btnPrintPacking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPacking.Click
        If strDFNo = "" Then strDFNo = txtDFNo.Text.Trim.ToUpper
        If strDFNo.Length = 0 Then Exit Sub
        Const rptFileName = "rptDFOrderPacking.rpt"
        If clsUser.ReportPath = "" Then clsUser.ReportPath = clsUser.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Me.Cursor = Cursors.WaitCursor
        rpt.Load(clsUser.ReportPath & rptFileName)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait

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
        If config.IsNull(cboColor.SelectedValue, "").ToString.Trim.Length = 0 Then Exit Sub
        If MessageBox.Show("Would you like to apply color '" & config.IsNull(cboColor.SelectedValue, "").ToString.Trim & "' to chosen item in grid below ?" & vbCrLf _
         & "คุณต้องการเปลี่ยนสีของรายการที่เลือกด้วยเครื่องหมายถูกในตารางด้านล่างให้เป็นสี '" & config.IsNull(cboColor.SelectedValue, "").ToString.Trim & "' ใช่หรือไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then Exit Sub
        Dim dt As DataTable = grdDF.DataSource
        Dim dt2 As DataTable = dt.Copy()
        Dim i As Integer = 0
        If dt2.Rows.Count > 0 Then
            For i = 0 To dt2.Rows.Count - 1
                If CBool(dt2.Rows(i)("sel")) Then dt2.Rows(i)("col") = config.IsNull(cboColor.SelectedValue, "").ToString.Trim
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

    Private Sub cboDFNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDFNo.DropDownClosed
        loadDfData()
    End Sub
    Private Sub loadDfData()
        Dim DFNo As String
        DFNo = cboDFNo.ComboBox.Text
        If DFNo.Trim.Length > 0 Then
            CreateNewDf()
            If Not blnCancel Then LoadData(DFNo)
        End If
    End Sub

    Private Sub txtDFNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDFNo.KeyPress
        Dim DFNo As String = ""
        If Asc(e.KeyChar) = 13 Then
            DFNo = txtDFNo.Text.Trim.ToUpper
            CreateNewDf()
            'Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData(DFNo)
        End If
    End Sub

    Private Sub cboSoNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoNo.Click
        idx = cboSoNo.SelectedIndex
    End Sub

    Private Sub cboSoNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSoNo.DropDownClosed
        If idx >= 0 Then
            If cboSoNo.SelectedIndex = idx Then Exit Sub
            If AskBeforeChangeDesignNo("S/O No.") = False Then
                cboSoNo.SelectedIndex = idx
            Else
                Call DeleteRollNo("ALL")
                cboOutNo.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cboSoNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSoNo.KeyDown
        If e.KeyValue = Keys.Enter Then
            getSoData()
        End If
    End Sub

    Private Sub cboSoNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSoNo.SelectedIndexChanged
        If cboSoNo.SelectedIndex >= 0 And clsConfig.IsNull(cboSoNo.SelectedValue, "") <> "" Then getSoData()
    End Sub

    Private Sub getSoData()
        If cboSoNo.Text = "" Then Exit Sub
        Dim i As Integer = 0
        Dim dt As DataTable = cboSoNo.DataSource
        Dim dt2 As New DataTable
        dt2 = dt.Copy()
        For i = 0 To dt2.Rows.Count - 1
            If dt2.Rows(i)("sono").ToString.Trim = clsConfig.IsNull(cboSoNo.Text.Trim, "").ToString.Trim Then
                lblCustomer.Text = dt2.Rows(i)("custname").ToString.Trim
                txtDeliveryTo.Text = dt2.Rows(i)("deliver_to").ToString.Trim
                If txtSpecialCond.Text = "" Then
                    txtSpecialCond.Text = dt2.Rows(i)("rem").ToString.Trim
                End If
                txtMtsPerRoll.Text = dt.Rows(0)("mts_per_roll").ToString.Trim
                Exit For
            End If
        Next
        strDyedType = "NORMAL"
        Call GenComboDesignNo()
        'If cboDesignNo.SelectedIndex >= 0 And clsConfig.IsNull(cboDesignNo.SelectedValue, "") <> "" Then
        'cboFinishedDesign.SelectedValue = cboDesignNo.Text
        'getStockData()
        'End If
        '===================================================================
        'Add By Neung Fix Error When Sale Not Enter Design No On S/O
        If clsConfig.IsNull(cboDesignNo.SelectedValue, "") = "" Then
            MessageBox.Show("Sale ไม่ได้ใส่ Design No. ให้กลับไปเช็คอีกครั้ง (ไม่สามารถดำเนินการต่อได้) ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            cboFinishedDesign.SelectedValue = cboDesignNo.SelectedValue
        Else
            cboFinishedDesign.SelectedValue = cboDesignNo.SelectedValue
        End If
        '===================================================================
        'cboFinishedDesign.SelectedValue = cboDesignNo.SelectedValue
    End Sub

    Private Sub cboReqNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboReqNo.DropDownClosed
        If cboReqNo.SelectedIndex < 0 Or clsConfig.IsNull(cboReqNo.SelectedValue, "") = "" Then Exit Sub
        Dim i As Integer = 0
        Dim dt As DataTable = cboReqNo.DataSource
        Dim dt2 As New DataTable
        dt2 = dt.Copy()
        For i = 0 To dt2.Rows.Count - 1
            If dt2.Rows(i)("outreqno").ToString.Trim = clsConfig.IsNull(cboReqNo.SelectedValue, "").ToString.Trim Then
                cboSoNo.SelectedValue = dt2.Rows(i)("sono").ToString.Trim
                Call cboSoNo_SelectedIndexChanged(sender, e)
                If dt2.Rows(i)("sono").ToString.Trim = "SAMPLE" Or _
                 dt2.Rows(i)("sono").ToString.Trim = "DEVL" Then
                    If dt2.Rows(i)("design_no").ToString.Trim.Length > 0 Then
                        cboDesignNo.SelectedValue = dt2.Rows(i)("design_no").ToString.Trim
                        Call cboDesignNo_SelectedIndexChanged(sender, e)
                    End If
                End If
                Exit For
            End If
        Next

        Dim objDB As New classDFOrder
        dt = objDB.DFDetLoadFromReq(strDFNo, clsConfig.IsNull(cboReqNo.SelectedValue, "").ToString.Trim)
        Call BindGridDF(dt)
        Call SumGridDF()
    End Sub

    Private Sub cboOutNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOutNo.Click
        idx = cboOutNo.SelectedIndex
    End Sub

    Private Sub cboOutNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboOutNo.DropDownClosed
        If idx >= 0 Then
            If cboOutNo.SelectedIndex = idx Then Exit Sub
            If AskBeforeChangeDesignNo("Out No.") = False Then
                cboOutNo.SelectedIndex = idx
            Else
                Call DeleteRollNo("ALL")
                cboSoNo.SelectedIndex = -1
            End If
        End If
    End Sub

    Private Sub cboOutNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutNo.SelectedIndexChanged
        If cboOutNo.SelectedIndex < 0 Or clsConfig.IsNull(cboOutNo.SelectedValue, "") = "" Then Exit Sub
        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim dt As DataTable = cboOutNo.DataSource
        Dim dt2 As New DataTable
        dt2 = dt.Copy()
        For i = 0 To dt2.Rows.Count - 1
            If dt2.Rows(i)("outno").ToString.Trim = config.IsNull(cboOutNo.SelectedValue, "").ToString.Trim Then
                cboSoNo.SelectedValue = dt2.Rows(i)("sono").ToString.Trim
                Exit For
            End If
        Next
        strDyedType = "REDYED"
        Call GenComboDesignNo()
        cboFinishedDesign.SelectedValue = config.IsNull(cboDesignNo.SelectedValue, "").ToString.Trim
    End Sub

    Private Sub cboDesignNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignNo.Click
        idx2 = cboDesignNo.SelectedIndex
    End Sub

    Private Sub cboDesignNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDesignNo.DropDownClosed, cboFinishedDesign.DropDownClosed
        If idx2 >= 0 Then
            If cboDesignNo.SelectedIndex = idx2 Then Exit Sub
            If AskBeforeChangeDesignNo("Design No.") = False Then
                cboDesignNo.SelectedIndex = idx2
            Else
                Call DeleteRollNo("ALL")
            End If
        End If
    End Sub

    Private Sub cboDesignNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDesignNo.KeyDown, cboFinishedDesign.KeyDown
        If e.KeyValue = Keys.Enter Then getStockData()
    End Sub

    Private Sub cboDesignNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDesignNo.SelectedIndexChanged
        If cboSoNo.SelectedIndex < 0 Or clsConfig.IsNull(cboSoNo.SelectedValue, "") = "" Then Exit Sub
        If cboDesignNo.SelectedIndex >= 0 And clsConfig.IsNull(cboDesignNo.SelectedValue, "") <> "" Then
            cboFinishedDesign.SelectedValue = cboDesignNo.Text
            getStockData()
        End If
    End Sub

    Private Sub cboFinishedDesign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFinishedDesign.SelectedIndexChanged
        If cboSoNo.SelectedIndex < 0 Or clsConfig.IsNull(cboSoNo.SelectedValue, "") = "" Then Exit Sub
        If cboFinishedDesign.SelectedIndex >= 0 And clsConfig.IsNull(cboFinishedDesign.SelectedValue, "") <> "" Then getStockData()
    End Sub

    Private Sub getStockData()
        If cboDesignNo.Text = "" Then Exit Sub
        Dim config As New clsConfig
        Dim objDB As New classDFOrder
        grdDesign.AutoGenerateColumns = False
        If strDyedType = "NORMAL" Then grdDesign.DataSource = objDB.GetSODesignGrid(config.IsNull(cboSoNo.Text, "").ToString.Trim, config.IsNull(Me.cboDesignNo.Text, "Nothing").ToString.Trim, config.IsNull(Me.cboFinishedDesign.Text, "Nothing").ToString.Trim)
        If strDyedType = "REDYED" Then grdDesign.DataSource = objDB.GetStkOutDesignGrid(config.IsNull(cboOutNo.SelectedValue, "").ToString.Trim, config.IsNull(cboDesignNo.SelectedValue, "Nothing").ToString.Trim, config.IsNull(Me.cboFinishedDesign.SelectedValue, "Nothing").ToString.Trim)
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
        If strDyedType = "NORMAL" Then dt = objDB.GetSORollNoGrid(strDFNo, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("sonoid").Value, "").ToString.Trim, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("design_no").Value, "").ToString.Trim, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("gwth").Value, "").ToString.Trim, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("col").Value, "").ToString.Trim, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("custcol").Value, "").ToString.Trim)
        If strDyedType = "REDYED" Then dt = objDB.GetStkOutRollNoGrid(strDFNo, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("sonoid").Value, "").ToString.Trim, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("design_no").Value, "").ToString.Trim, _
          config.IsNull(Val(grdDesign.Rows(e.RowIndex).Cells("gwth").Value), "").ToString.Trim, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("col").Value, "").ToString.Trim, _
          config.IsNull(grdDesign.Rows(e.RowIndex).Cells("custcol").Value, "").ToString.Trim, _
          config.IsNull(cboOutNo.SelectedValue, "").ToString.Trim)

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
        If grdDF.Columns(e.ColumnIndex).Name = "df_kg" Or _
         grdDF.Columns(e.ColumnIndex).Name = "df_yds" Or _
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
            If grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "df_dhcol" Or _
              grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "dhcoldt" Or _
              grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "labdipno" Then
                Dim strReplace As String = InputBox("ใส่ข้อมูลที่ต้องการให้ใส่ลงตาราง" & vbCrLf & "Input data into grid.", "System Message", "")
                For i = 0 To grdDF.SelectedCells.Count - 1
                    If grdDF.Columns(grdDF.SelectedCells(i).ColumnIndex).Name = "df_dhcol" Or _
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
        Dim config As New clsConfig
        Dim i As Integer = 0
        If e.KeyCode = Keys.Enter Then
            If grdRollNo.Columns(grdRollNo.SelectedCells(i).ColumnIndex).Name = "sel" Then
                For i = 0 To grdRollNo.SelectedCells.Count - 1
                    grdRollNo.SelectedCells(i).Value = Not CBool(config.IsNull(grdRollNo.SelectedCells(i).Value, False))
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

    Private Sub cboDFNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboDFNo.KeyDown
        If e.KeyValue = Keys.Enter Then Call loadDfData()
    End Sub

    Private Sub AllCombo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) _
      Handles cboDFNo.GotFocus, _
      cboSoNo.GotFocus, _
      cboReqNo.GotFocus, _
      cboDyedHouse.GotFocus, _
      cboDyedCase.GotFocus, _
      cboOutNo.GotFocus, _
      txtDFNo.GotFocus, _
      TabControl1.Click, _
      btnNew.MouseHover, _
      btnSearch.MouseHover
        If Not blnGenCombo Then
            blnGenCombo = True
            Dim strTitle As String = Me.Text
            Dim i As Integer
            Me.Cursor = Cursors.WaitCursor
            Me.Text = "Please wait while program is initializing data ."
            'For i = 0 To 600
            '	My.Application.DoEvents()
            'Next
            Me.Text = "Begin Initializing ..."
            Call GenCombo()
            For i = 0 To 50
                Me.Text = "Initialize " & i & " % Completed"
            Next
            Call InitControl()
            'Call GenComboDFNo()
            For i = 51 To 98
                Me.Text = "Initialize " & i & " % Completed"
            Next

            For i = 99 To 100
                Me.Text = "Initialize " & i & " % Completed"
            Next
            Me.Text = strTitle
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub cboDFNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDFNo.Click

    End Sub

    Private Sub grdDesign_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdDesign.CellContentClick

    End Sub

    Private Sub cboDyedHouse_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDyedHouse.SelectedValueChanged
        'If txtDeliveryBy.Text.Trim = "" Then
        '    txtDeliveryBy.Text = UCase(cboDyedHouse.Text)
        'End If
    End Sub

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

    Private Sub txtDFNo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDFNo.TextChanged

    End Sub

    Private Sub grdDF_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDF.CellContentClick

    End Sub
End Class