Imports ProductionSystem.Controls

Public Class frmDesignNew
    Private _AllowEdit As Boolean = True
    Private _AllowPrint As Boolean = True
    Private _AllowNew As Boolean = True
    Private _pDesignNo As String = "" 'Sitthana 20201014
    Private oConfig As New clsConfig
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
    Public Property pDesignNo() As String
        Get
            pDesignNo = _pDesignNo
        End Get
        Set(ByVal NewValue As String)
            _pDesignNo = NewValue
        End Set
    End Property

    Dim clsConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo

    Dim strDesignNo As String = ""
    Dim blnCancel As Boolean = False
    Dim strImagePath As String = ""
    Dim strImageFilename As String = ""

    Dim dtDesignMaster As New DataTable
    Dim bsDesignMaster As New BindingSource

    Dim dtBOMHeader As New DataTable
    Dim bsBOMHeader As New BindingSource

    Dim dtBOMLines As New DataTable
    Dim bsBOMLines As New BindingSource

    Dim ItemID As Integer = -1
    Dim DesignNo As String

    Dim objMaster As New classMaster
    Dim oDesignNew As New classDesignNew   'data work of this form (read/save Design Master)
    Dim drv As DataRowView
    Dim CalculateMeasurements As Boolean
    Event bsBOMHeaderPosChanged As EventHandler

    'Begin Appen by Sitthana 01/02/2018
    Const cnstFabricTypePLAIN As Integer = 340   '340 : "PLAIN"
    Const cnstFabricTypeJPLAIN As Integer = 341  '341 : "JAEQUAED PLAIN"
    'Finish Appen by Sitthana 01/02/2018

    Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument 'Move By Sitthana 18/08/2018

    'Send to GMK button: defined in frmDesignNew.Designer.vb (btnSendGMK), it is enabled with the Save button (same permission).
    'The flow (check the differences, confirm, send) is in SendToGmkFlow below
    Private Sub btnSendGMK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSendGMK.Click
        Try
            Me.Validate()
            bsDesignMaster.EndEdit()
            Dim unsaved As Boolean = (dtDesignMaster.GetChanges() IsNot Nothing)
            Dim row As DataRow = Nothing
            Dim cur As DataRowView = TryCast(bsDesignMaster.Current, DataRowView)
            If cur IsNot Nothing Then
                row = cur.Row
            ElseIf dtDesignMaster.Rows.Count > 0 Then
                row = dtDesignMaster.Rows(0)
            End If
            SendToGmkFlow(row, unsaved)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Send to GMK", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Send to GMK: check the design, show the differences, ask to confirm, send, tell the result.
    'The data work (compare / send) is in classDesignNew; this form only talks to the user.
    Private Sub SendToGmkFlow(ByVal row As DataRow, ByVal hasUnsavedChanges As Boolean)
        Const MsgTitle As String = "Send to GMK"

        If hasUnsavedChanges Then
            MessageBox.Show(Me, "กรุณากดบันทึก (Save) ก่อน แล้วจึงส่งข้อมูลไป GMK", MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If row Is Nothing OrElse row("dm_design_no").ToString().Trim() = "" Then
            MessageBox.Show(Me, "ยังไม่มี Design No.", MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim sendDesignNo As String = row("dm_design_no").ToString().Trim()
        Dim svc As classDesignNew = oDesignNew
        Dim diff As classDesignNew.DiffResult
        Dim oldCursor As Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        Try
            diff = svc.GetDifferences(row, UserInfo.UserID)
        Finally
            Cursor.Current = oldCursor
        End Try

        If diff.Disabled Then
            MessageBox.Show(Me, "ระบบส่งข้อมูลไป GMK ถูกปิดอยู่ กรุณาติดต่อผู้ดูแลระบบ", MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If diff.ErrorMessage <> "" Then
            MessageBox.Show(Me, "ตรวจข้อมูลที่ GMK ไม่สำเร็จ" & vbCrLf & vbCrLf & diff.ErrorMessage, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Not diff.ExistsInGmk Then
            Dim ask As DialogResult = MessageBox.Show(Me, "ไม่พบ Design " & sendDesignNo & " ใน GMK" & vbCrLf & "ต้องการสร้างใหม่ใน GMK หรือไม่?", _
                                                      MsgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If ask <> DialogResult.Yes Then Return
        ElseIf diff.Items.Count = 0 Then
            Dim same As String = "ข้อมูลตรงกับ GMK แล้ว ไม่มีอะไรต้องส่ง"
            If diff.Warnings.Count > 0 Then same &= vbCrLf & vbCrLf & "ค่าที่ไม่ได้ส่ง (ตามกติกา):" & vbCrLf & String.Join(vbCrLf, diff.Warnings.ToArray())
            MessageBox.Show(Me, same, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        Else
            Using dlg As New frmSendToGMKConfirm(sendDesignNo, diff)
                If dlg.ShowDialog(Me) <> DialogResult.OK Then Return
            End Using
        End If

        Dim res As classDesignNew.SyncResult
        Cursor.Current = Cursors.WaitCursor
        Try
            res = svc.SendToGMK(row, UserInfo.UserID)
        Finally
            Cursor.Current = oldCursor
        End Try

        If Not res.Success Then
            MessageBox.Show(Me, "ส่งข้อมูลไป GMK ไม่สำเร็จ" & vbCrLf & vbCrLf & res.Message, MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf res.Warnings.Count > 0 Then
            MessageBox.Show(Me, "ส่งข้อมูลไป GMK สำเร็จ แต่มีค่าที่ไม่ได้ส่ง (ตามกติกา):" & vbCrLf & String.Join(vbCrLf, res.Warnings.ToArray()), MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(Me, "ส่งข้อมูลไป GMK สำเร็จ", MsgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmDesign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler bsBOMHeader.PositionChanged, New EventHandler(AddressOf bsBomHeader_PositionChanged)
        InitControl()
        dgvBomHeader.AutoGenerateColumns = False
        dgvBOMLines.AutoGenerateColumns = False
        Call GenCombo()
        Call GenAutoComplete()
        Call InitDataBinding()

        btnNew.Enabled = AllowNew
        tsbCopy.Enabled = AllowNew
        btnSave.Enabled = AllowEdit
        btnPrint.Enabled = AllowPrint
        btnSendGMK.Enabled = btnSave.Enabled
        AddHandler bsDesignMaster.CurrentChanged, AddressOf UpdateDeleteDesignButton
        AddHandler bsDesignMaster.ListChanged, AddressOf UpdateDeleteDesignButton
        UpdateDeleteDesignButton(Nothing, EventArgs.Empty)

        If _pDesignNo.Trim <> "" Then
            txtDesignNo.Text = _pDesignNo.Trim
            LoadData("", _pDesignNo)
        End If 'Sitthana 20201014
    End Sub

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
        ErrorProvider1.Clear()

    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        ItemID = -1
        strDesignNo = ""
        strImagePath = ""
        strImageFilename = ""
        txtDesignNo.Focus()
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
        Dim dt As DataTable

        Me.cboFinishing.DataSource = objMaster.GetFinishingGroup()
        Me.cboFinishing.DisplayMember = "fin_desc2"
        Me.cboFinishing.ValueMember = "fin_id"
        Me.cboFinishing.SelectedIndex = 0

        Me.cbomtl_inventory_types.DataSource = objMaster.GetCombomtl_inventory_types()
        Me.cbomtl_inventory_types.DisplayMember = "inventory_type_name"
        Me.cbomtl_inventory_types.ValueMember = "mtl_inventory_types_id"
        Me.cbomtl_inventory_types.SelectedIndex = 0

        Me.cboSizeCtry.DataSource = objMaster.comboShoeSizeCtry()
        Me.cboSizeCtry.DisplayMember = "lookup_value"
        Me.cboSizeCtry.ValueMember = "lookup_value_id"
        Me.cboSizeCtry.SelectedIndex = 0

        Me.cboShoeGender.DataSource = objMaster.comboShoeGender()
        Me.cboShoeGender.DisplayMember = "lookup_value"
        Me.cboShoeGender.ValueMember = "lookup_value_id"
        Me.cboShoeGender.SelectedIndex = 0

        Me.cboFabricType.DataSource = objMaster.comboFabricType()
        Me.cboFabricType.DisplayMember = "lookup_value"
        Me.cboFabricType.ValueMember = "lookup_value_id"
        Me.cboFabricType.SelectedIndex = 0

        dt = objMaster.GetMachineGroup()
        Dim dv As New DataView
        dv = dt.AsDataView
        'Me.cboMultiMachineGroup.DataSource = dv
        'Me.cboMultiMachineGroup.MultiColumn = True
        'Me.cboMultiMachineGroup.ValueMember = "machine_group_id"
        'Me.cboMultiMachineGroup.DisplayMember = "machine_group_name"

        With cboMultiMachineGroup
            .DataSource = dv
            .MultiColumn = True
            .DisplayMember = "machine_group_name"
            .ValueMember = "machine_group_id"
            Me.Text = ""
            For i = 1 To .ListBox.Grid.Model.Cols.HeaderCount

            Next
            .ListBox.Grid.Model.Cols.Hidden(1) = False
            .ListBox.Grid.Model.Cols.Hidden(2) = False
            .ListBox.Grid.Model.Cols.Hidden(3) = False
            .ListBox.Grid.Model.Cols.Hidden(4) = True
            .ListBox.Grid.Model.Cols.Hidden(5) = False
            .ListBox.Grid.Model.Cols.Hidden(6) = True
            .ListBox.Grid.Model.Cols.Hidden(7) = True
            .ListBox.Grid.Model.Cols.Hidden(8) = True
            .ListBox.Grid.Model.Cols.Hidden(9) = True
            .ListBox.Grid.Model.Cols.Hidden(10) = True
            .ListBox.Grid.Model.Cols.Hidden(11) = True
            .ListBox.Grid.Model.Cols.Hidden(12) = True
            .ListBox.Grid.Model.Cols.Hidden(13) = True
            .ListBox.Grid.Model.Cols.Hidden(14) = True
            .ListBox.Grid.Model.Cols.Hidden(15) = True
            .ListBox.Grid.Model.Cols.Hidden(16) = True
            .ListBox.Grid.Model.Cols.Hidden(17) = True
            .ListBox.Grid.Model.Cols.Hidden(18) = True
            .ListBox.Grid.Model.Cols.Hidden(19) = True
            AddHandler TryCast(.ListControl, GridListBox).Grid.Model.QueryCellInfo, AddressOf Model_QueryCellInMultiMachineGroup
        End With 'Sitthana 20231212

        cboSpecStatus.DataSource = (New classMaster).comboSpecStatus
        cboSpecStatus.ValueMember = "spec_status"
        cboSpecStatus.DisplayMember = "spec_status"

    End Sub

    Private Sub Model_QueryCellInMultiMachineGroup(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)
        If e.RowIndex = 0 AndAlso e.ColIndex = 1 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 9, FontStyle.Bold))
            e.Style.Text = "Machine Group Name"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 2 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 9, FontStyle.Bold))
            e.Style.Text = "Machine Guage"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 9, FontStyle.Bold))
            e.Style.Text = "Machine Diameter"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 5 Then
            e.Style.Font = New GridFontInfo(New Font("Segoe UI", 9, FontStyle.Bold))
            e.Style.Text = "Machine Group Id"
        End If
    End Sub

    Private Sub genComboShoeSize(ByVal CountryLookupValueID As Int64)
        Me.cboShoeSize.DataSource = objMaster.comboShoeSize(CountryLookupValueID)
        Me.cboShoeSize.DisplayMember = "lookup_value"
        Me.cboShoeSize.ValueMember = "lookup_value_id"
        Me.cboShoeSize.SelectedIndex = 0
    End Sub
    Private Sub BindData()
        ClearDataBindings()
        txtDesignNo.DataBindings.Add("text", bsDesignMaster, "dm_design_no")
        txtComposition.DataBindings.Add("text", bsDesignMaster, "dm_compo")
        txtCompositionForTag.DataBindings.Add("text", bsDesignMaster, "dm_compo_for_tag") 'Add By Neung 20200302
        txtRemark.DataBindings.Add("text", bsDesignMaster, "dm_rem")
        txtSuppDesignNo.DataBindings.Add("text", bsDesignMaster, "dm_supdes_no")
        txtCustDesignNo.DataBindings.Add("text", bsDesignMaster, "dm_cust_design_no")
        txtRefDesNo.DataBindings.Add("text", bsDesignMaster, "dm_refdesno")
        cboFinishing.DataBindings.Add("SelectedValue", bsDesignMaster, "dm_fin_id")
        txtdesign_gauge.DataBindings.Add("text", bsDesignMaster, "dm_design_gauge") 'Sitthana 03/12/2018
        txtParentDesign.DataBindings.Add("Text", bsDesignMaster, "dm_parent_design")
        txtDesignFamily.DataBindings.Add("Text", bsDesignMaster, "dm_design_family")
        cbomtl_inventory_types.DataBindings.Add("SelectedValue", bsDesignMaster, "dm_mtl_inventory_types_id")

        '----- Tab : Specifications
        '----- WIDTH (cm)
        txtFullWidth.DataBindings.Add("text", bsDesignMaster, "ds_fwth")
        txtFullWidth_Min.DataBindings.Add("text", bsDesignMaster, "ds_fwth_min") 'Sitthana 15/03/2018
        txtFullWidth_Max.DataBindings.Add("text", bsDesignMaster, "ds_fwth_max") 'Sitthana 15/03/2018
        txtNOB.DataBindings.Add("text", bsDesignMaster, "ds_nob")

        txtEdgeWidth.DataBindings.Add("text", bsDesignMaster, "ds_edge_cut_wth")
        txtEdgeWidth_Min.DataBindings.Add("text", bsDesignMaster, "ds_Edge_min") 'Sitthana 15/03/2018
        txtEdgeWidth_Max.DataBindings.Add("text", bsDesignMaster, "ds_Edge_max") 'Sitthana 15/03/2018

        txtUseableWidth.DataBindings.Add("text", bsDesignMaster, "ds_usewth")
        txtUseableWidth_Min.DataBindings.Add("text", bsDesignMaster, "ds_usewth_min")  'Sitthana 15/03/2018
        txtUseableWidth_Max.DataBindings.Add("text", bsDesignMaster, "ds_usewth_max")  'Sitthana 15/03/2018

        '----- Grp 2
        txtGramPerSqm.DataBindings.Add("text", bsDesignMaster, "ds_gmpersqm")
        txtGramPerSqm_Min.DataBindings.Add("text", bsDesignMaster, "ds_gmpersqm_min") 'Sitthana 15/03/2018
        txtGramPerSqm_Max.DataBindings.Add("text", bsDesignMaster, "ds_gmpersqm_max") 'Sitthana 15/03/2018

        txtKgPerRoll.DataBindings.Add("text", bsDesignMaster, "ds_kg_per_roll")
        'txtKgPerRoll_Min.DataBindings.Add("text", bsDesignMaster, "ds_kg_per_roll_min") 'Sitthana 15/03/2018
        'txtKgPerRoll_Max.DataBindings.Add("text", bsDesignMaster, "ds_kg_per_roll_max") 'Sitthana 15/03/2018

        txtMtsPerRoll.DataBindings.Add("text", bsDesignMaster, "ds_mts_per_roll")
        'txtMtsPerRoll_Min.DataBindings.Add("text", bsDesignMaster, "ds_mts_per_roll_min") 'Sitthana 15/03/2018
        'txtMtsPerRoll_Max.DataBindings.Add("text", bsDesignMaster, "ds_mts_per_roll_max") 'Sitthana 15/03/2018

        '----- YIELD
        txtMtsPerKgFullWidth.DataBindings.Add("text", bsDesignMaster, "ds_mtkg")
        txtMtsPerKgFullWidth_ReadOnly.DataBindings.Add("text", bsDesignMaster, "ds_mtkg")
        txtMtsPerKgEdgeCut.DataBindings.Add("text", bsDesignMaster, "ds_mtkg_edge")
        txtMtsPerKgUseable.DataBindings.Add("text", bsDesignMaster, "ds_mtkg_useable")
        txtKgPerMeter.DataBindings.Add("text", bsDesignMaster, "ds_kg_per_meter")

        '----- PHYSICAL PROPERTIES
        txtCPI.DataBindings.Add("text", bsDesignMaster, "ds_cpi")
        txtCPI_Remark.DataBindings.Add("text", bsDesignMaster, "ds_cpi_remark") 'Sitthana 15/03/2018
        txtWPI.DataBindings.Add("text", bsDesignMaster, "ds_wpi")
        txtWPI_Remark.DataBindings.Add("text", bsDesignMaster, "ds_wpi_remark") 'Sitthana 15/03/2018

        txtShrinkageDegC.DataBindings.Add("text", bsDesignMaster, "ds_shrinkage_centigrade")
        txtShrinkageLength.DataBindings.Add("text", bsDesignMaster, "ds_shrinkage_length")
        txtShrinkageLength_Min.DataBindings.Add("text", bsDesignMaster, "ds_shrinkage_length_min") 'Sitthana 15/03/2018
        txtShrinkageLength_Max.DataBindings.Add("text", bsDesignMaster, "ds_shrinkage_length_max") 'Sitthana 15/03/2018
        txtShrinkageWidth.DataBindings.Add("text", bsDesignMaster, "ds_shrinkage_width")
        txtShrinkageWidth_Min.DataBindings.Add("text", bsDesignMaster, "ds_shrinkage_width_min") 'Sitthana 15/03/2018
        txtShrinkageWidth_Max.DataBindings.Add("text", bsDesignMaster, "ds_shrinkage_width_max") 'Sitthana 15/03/2018

        txtElongationKg.DataBindings.Add("text", bsDesignMaster, "ds_elongation")
        txtElongationLength.DataBindings.Add("text", bsDesignMaster, "ds_elasticity_length")
        txtElongationLength_Min.DataBindings.Add("text", bsDesignMaster, "ds_elongation_length_min") 'Sitthana 15/03/2018
        txtElongationLength_Max.DataBindings.Add("text", bsDesignMaster, "ds_elongation_length_max") 'Sitthana 15/03/2018
        txtElongationWidth.DataBindings.Add("text", bsDesignMaster, "ds_elasticity_width")
        txtElongationWidth_Min.DataBindings.Add("text", bsDesignMaster, "ds_elongation_width_min") 'Sitthana 15/03/2018
        txtElongationWidth_Max.DataBindings.Add("text", bsDesignMaster, "ds_elongation_width_max") 'Sitthana 15/03/2018

        txtModulusPerc.DataBindings.Add("text", bsDesignMaster, "ds_modulus")
        txtModulusLength.DataBindings.Add("text", bsDesignMaster, "ds_modulus_length")
        txtModulusLength_Min.DataBindings.Add("text", bsDesignMaster, "ds_modulus_length_min") 'Sitthana 15/03/2018
        txtModulusLength_Max.DataBindings.Add("text", bsDesignMaster, "ds_modulus_length_max") 'Sitthana 15/03/2018
        txtModulusWidth.DataBindings.Add("text", bsDesignMaster, "ds_modulus_width")
        txtModulusWidth_Min.DataBindings.Add("text", bsDesignMaster, "ds_modulus_width_min") 'Sitthana 15/03/2018
        txtModulusWidth_Max.DataBindings.Add("text", bsDesignMaster, "ds_modulus_width_max") 'Sitthana 15/03/2018

        txtForEmb.DataBindings.Add("text", bsDesignMaster, "ds_foremb")  'Sitthana 23/03/2018
        txtThickness.DataBindings.Add("text", bsDesignMaster, "ds_thickness")  'Sitthana 25/04/2018
        txtThickness_Tolerance_Sign.DataBindings.Add("text", bsDesignMaster, "ds_thickness_tolerance_sign")  'Sitthana 25/04/2018
        txtThickness_tolerance.DataBindings.Add("text", bsDesignMaster, "ds_thickness_tolerance")  'Sitthana 25/04/2018
        txtTensileStrength.DataBindings.Add("text", bsDesignMaster, "ds_tensile_strength")
        txtPiling.DataBindings.Add("text", bsDesignMaster, "ds_piling")
        txtSnagging.DataBindings.Add("text", bsDesignMaster, "ds_snagging")
        txtBurst.DataBindings.Add("text", bsDesignMaster, "ds_brust")

        '----- MACHINE DATA
        cboMultiMachineGroup.DataBindings.Add("SelectedValue", bsDesignMaster, "ds_machine_group_id")
        txtCounterPerRoll.DataBindings.Add("text", bsDesignMaster, "ds_counter_per_roll")
        txtRpm.DataBindings.Add("text", bsDesignMaster, "ds_rpm")
        txtNeedle.DataBindings.Add("text", bsDesignMaster, "ds_needle")

        '-----
        txtNeedle2.DataBindings.Add("text", bsDesignMaster, "ds_needle")
        txtKgPerDay.DataBindings.Add("text", bsDesignMaster, "ds_kg_per_day")
        txtMetersPerDay.DataBindings.Add("text", bsDesignMaster, "ds_meters_per_day")
        txtHoursPerDay.DataBindings.Add("text", bsDesignMaster, "ds_hours_per_day")

        ' binding for foremb field can add here (if required)
        txtPairsPerMeter.DataBindings.Add("text", bsDesignMaster, "ds_pairs_per_meter")

        cboShoeSize.DataBindings.Add("selectedvalue", bsDesignMaster, "ds_shoe_size")
        txtShoeStyle.DataBindings.Add("text", bsDesignMaster, "ds_shoe_style")

        txtShoeLength.DataBindings.Add("text", bsDesignMaster, "ds_shoe_length_cm")
        txtShoeWidth.DataBindings.Add("text", bsDesignMaster, "ds_shoe_width_cm")
        txtPalletPatternNo.DataBindings.Add("text", bsDesignMaster, "ds_pallet_pattern_no")
        txtProductPatternNo.DataBindings.Add("text", bsDesignMaster, "ds_product_pattern_no")
        txtGramPerRow.DataBindings.Add("text", bsDesignMaster, "ds_sh_grams_per_row")
        txtLengthPerRepeatMark.DataBindings.Add("text", bsDesignMaster, "ds_sh_length_cm_per_repeat")
        txtLengthPerPcMark.DataBindings.Add("text", bsDesignMaster, "ds_sh_length_cm_mark_to_mark")
        txtWidthPerPcMark.DataBindings.Add("text", bsDesignMaster, "ds_sh_width_cm_mark_to_mark")
        txtPixelWidth.DataBindings.Add("text", bsDesignMaster, "ds_sh_needle_width_cm")
        txtPatternArea.DataBindings.Add("text", bsDesignMaster, "ds_sh_pattern_area")

        ' binding for pattern_area_grams field missing, can add here
        txtPieceWeight.DataBindings.Add("text", bsDesignMaster, "ds_sh_grams_of_lasercut_pc")
        txtWeightPerPair.DataBindings.Add("text", bsDesignMaster, "ds_sh_grams_of_lasercut_pair")
        txtPcsPerRowPx.DataBindings.Add("text", bsDesignMaster, "ds_sh_pcs_fabric_needle_width")
        txtPcsPerRowEdge.DataBindings.Add("text", bsDesignMaster, "ds_sh_pcs_fabric_edge_to_edge")
        txtRowsPerMeter.DataBindings.Add("text", bsDesignMaster, "ds_sh_rows_per_meter")
        txtPairsPerRepeat.DataBindings.Add("text", bsDesignMaster, "ds_sh_pairs_per_repeat_of_fabric_width")
        txtWeightWithPattern.DataBindings.Add("text", bsDesignMaster, "ds_sh_fabric_grams_with_pattern")
        txtWeightNoPattern.DataBindings.Add("text", bsDesignMaster, "ds_sh_fabric_grams_without_pattern")

        txtRepeatPerDay.DataBindings.Add("text", bsDesignMaster, "ds_sh_repeat_per_day")
        cboShoeGender.DataBindings.Add("selectedvalue", bsDesignMaster, "ds_shoe_gender_id")
        txtMinutesPerRepeat.DataBindings.Add("text", bsDesignMaster, "ds_sh_minutes_per_repeat")
        txtPairsPerDay.DataBindings.Add("text", bsDesignMaster, "ds_sh_pairs_per_day")

        txtGramPerSqM2.DataBindings.Add("text", bsDesignMaster, "ds_gmpersqm")
        txtKgPerRoll2.DataBindings.Add("text", bsDesignMaster, "ds_kg_per_roll")
        txtMtsPerRoll2.DataBindings.Add("text", bsDesignMaster, "ds_mts_per_roll")
        cboSizeCtry.DataBindings.Add("selectedvalue", bsDesignMaster, "ds_shoe_country_id")
        cboFabricType.DataBindings.Add("selectedvalue", bsDesignMaster, "dm_fabric_type_id")
        txtCreationDate.DataBindings.Add("text", bsDesignMaster, "dm_creation_date")
        txtCreateBy.DataBindings.Add("text", bsDesignMaster, "dm_created_by")
        txtModifiedDate.DataBindings.Add("text", bsDesignMaster, "dm_modified_date")
        txtModifyBy.DataBindings.Add("text", bsDesignMaster, "dm_modified_by")

        'Copy From GMK by neung 20200302
        txtTongueWeight.DataBindings.Add("text", bsDesignMaster, "ds_tongue_weight")
        txtTongueWidth.DataBindings.Add("text", bsDesignMaster, "ds_tongue_width")
        txtTongueLenght.DataBindings.Add("text", bsDesignMaster, "ds_tongue_length")
        txtTongueCenterMarkLenght.DataBindings.Add("text", bsDesignMaster, "ds_tongue_center_mark_length")
        cboSpecStatus.DataBindings.Add("selectedvalue", bsDesignMaster, "dm_spec_status")
        txtSpecVersion.DataBindings.Add("text", bsDesignMaster, "dm_spec_version")
        ' don't calculate yield unless gmpersqm or related width fields are modified
        ' If CalculateMeasurements Then If CalculateMeasurements Then CalculateShoeFields()

        'Sitthana 2023121 - Begin
        txtStitchNoteSuk90.DataBindings.Add("text", bsDesignMaster, "stitch_note_suk90")
        txtStitchNoteTr005.DataBindings.Add("text", bsDesignMaster, "stitch_note_tr005")
        txtStitchNote1str.DataBindings.Add("text", bsDesignMaster, "stitch_note_1str")
        txtStitchNote2str.DataBindings.Add("text", bsDesignMaster, "stitch_note_2str")
        'Sitthana 2023121 - End

        If chkCalcMeasurements.Checked Then
            CalculateShoeFields()
        End If

        Call getBOMHeader()
        Call showDesignByParentDesign()
    End Sub
    Private Sub showDesignByParentDesign()
        'Writer By : Sitthana 20201014
        Dim dt As New DataTable
        grdParentDesign.DataSource = Nothing
        If txtParentDesign.Text.Trim <> "" Then
            dt = objMaster.getDesignByParentDesign(txtParentDesign.Text.Trim)
            With grdParentDesign
                .AutoGenerateColumns = False
                .DataSource = dt
            End With

        End If
    End Sub
    Private Function IsDataChange() As Boolean
        Dim clsMaster As New classMaster
        Dim dt As DataTable = clsMaster.GetDesign2(strDesignNo)
        Dim result As Boolean = False
        Dim i As Integer = 0
        Dim j As Integer = 0

        If strDesignNo.Trim.Length = 0 Or dt.Rows.Count = 0 Then
            If txtCustDesignNo.Text <> "" Then result = True
            If txtRemark.Text <> "" Then result = True
            If txtComposition.Text <> "" Then result = True
            If txtdesign_gauge.Text <> "" Then result = True 'Sitthana 03/12/2018
            'If clsConfig.IsNull(cbomtl_inventory_types.SelectedValue, 0) <> 0 Then result = True
        Else
            If txtCustDesignNo.Text <> dt.Rows(0)("cust_design_no").ToString.Trim Then result = True
            If txtRemark.Text <> dt.Rows(0)("rem").ToString.Trim Then result = True
            If txtComposition.Text <> dt.Rows(0)("compo").ToString.Trim Then result = True
            If txtdesign_gauge.Text <> dt.Rows(0)("dm_design_gauge").ToString.Trim Then result = True 'Sitthana 03/12/2018
            'If cbomtl_inventory_types.SelectedValue <> CBool(dt.Rows(0)("mtl_inventory_types_id")) Then result = True

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
        If IIf(strDesignNo.Trim.Length = 0, txtDesignNo.Text.Trim.ToUpper, strDesignNo).ToString.Trim.Length = 0 Then
            MessageBox.Show("Please fill Design No. !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            CheckData = False
            Exit Function
        ElseIf txtDesignNo.Text.Trim = "" Then
            MessageBox.Show("Please fill Design No. !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(Me.cbomtl_inventory_types, "Please Select Inventory Types !!")
            CheckData = False
            Exit Function
        End If
        If Trim(txtParentDesign.Text) = "" Then
            MessageBox.Show("Knitting Design ไม่สามารถเป็นค่าว่างได้" & vbCr _
                            & Space(3) & "กรุณากรอกข้อมูลให้เรียบร้อยก่อน จึงจะบันทึกได้" _
                            , "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ErrorProvider1.SetError(Me.txtParentDesign, "Please fill Knitting Design !!")
            txtParentDesign.Focus()
            CheckData = False
            Exit Function
        Else
            ErrorProvider1.Clear()
        End If

        'Auto Gen Design Family
        '--- Begin Cancel by Sitthana 28/06/2018
        'If txtDesignFamily.Text.Trim.Length = 0 Then
        '    MessageBox.Show("ถ้าคุณไม่กรอก Design Family ระบบจะ Gen ให้อัตโนมัติ!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    'CheckData = False
        '    'Exit Function
        'End If

        If cbomtl_inventory_types.SelectedValue Is Nothing Then
            MessageBox.Show("Please Select Inventory Types !!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(Me.cbomtl_inventory_types, "Please Select Inventory Types !!")
            CheckData = False
            Exit Function
        End If

        CheckData = True
    End Function

    Public Sub ClearDataBindings()
        Dim obj As Control
        For Each obj In Me.Controls
            Call ClearControlBindings(obj)
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

    Private Sub InitDataBinding()
        ItemID = -1
        dtDesignMaster = oDesignNew.getDesignMasterRecord(ItemID, txtDesignNo.Text)
        bsDesignMaster.DataSource = dtDesignMaster
        bsDesignMaster.MoveFirst()
        ' CreateNewRecord() 'Sitthana comment 25/04/2018
        drv = CType(bsDesignMaster.Current, DataRowView)

        If Not dtDesignMaster.Rows.Count > 0 Then
            CreateNewRecord() 'Sitthana 04/07/2018
        Else
            ItemID = dtDesignMaster.Rows(0)("dm_item_id")
            DesignNo = dtDesignMaster.Rows(0)("dm_design_no")
        End If
        Call BindData() 'DM
        'ItemID = -1
        'dtDesignMaster = objMaster.getDesignMasterRecord(ItemID)
        'bsDesignMaster.DataSource = dtDesignMaster
        'CreateNewRecord()
        'drv = CType(bsDesignMaster.Current, DataRowView)
        'BindData() 'DM
    End Sub

    Private Sub LoadData(Optional ByVal ItemID As String = "", Optional DesignNo As String = "")

        dtDesignMaster = oDesignNew.getDesignMasterRecord(ItemID, DesignNo)

        bsDesignMaster.DataSource = dtDesignMaster
        bsDesignMaster.MoveFirst()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If dtDesignMaster.Rows.Count > 0 Then
            ItemID = dtDesignMaster.Rows(0)("dm_item_id")
            DesignNo = dtDesignMaster.Rows(0)("dm_design_no")
            Call BindData() 'DM
        Else
            CreateNewRecord() 'Sitthana 24/08/2018
        End If

        getBOMHeader()

    End Sub

    Private Function SaveData() As Boolean
        If AllowEdit Or AllowNew Then
            Dim objMasterUpdate As New classMasterUpdate
            Dim header As New classMasterUpdate.DM

            drv = CType(bsDesignMaster.Current, DataRowView)

            If CalculateMeasurements Then CalculateShoeFields()

            ItemID = drv.Item("dm_item_id")
            Try
                dtDesignMaster = oDesignNew.DesignMasterNewSave(drv, UserInfo.UserID)
                bsDesignMaster.DataSource = dtDesignMaster
                bsDesignMaster.MoveFirst()
                ItemID = dtDesignMaster.Rows(0)("dm_item_id")
                DesignNo = dtDesignMaster.Rows(0)("dm_design_no")

                SaveData = True

                'Sync to GMK (one-way Eschler -> GMK). Eschler save is already done: a sync problem must not stop the user.
                Try
                    Dim syncMsg As String = oDesignNew.SyncAfterSave(dtDesignMaster.Rows(0), UserInfo.UserID)
                    If syncMsg <> "" Then MessageBox.Show(syncMsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Catch
                End Try
            Catch ex As Exception
                MessageBox.Show(ex.Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                SaveData = False
            End Try
        Else
            MessageBox.Show("Permission denied", "Security message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If

    End Function


    Private Sub GenAutoComplete()


        Dim dtDesignNo As DataTable = (New classMaster).GetDesignNo
        Dim rowDesignNo As DataRow
        txtDesignNo.AutoCompleteSource = AutoCompleteSource.None
        txtDesignNo.AutoCompleteMode = AutoCompleteMode.None
        txtDesignNo.AutoCompleteCustomSource.Clear()
        For Each rowDesignNo In dtDesignNo.Rows
            txtDesignNo.AutoCompleteCustomSource.Add(rowDesignNo.Item("design_no").ToString())
        Next
        txtDesignNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtDesignNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Private Sub frmDesign_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If IsDataChange() Then Call btnSave_Click(sender, e)
        e.Cancel = blnCancel
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        CreateNewRecord()
    End Sub
    Private Sub CreateNewRecord()
        Dim nr As DataRow
        dtDesignMaster.Clear()
        dtBOMHeader.Clear()
        dtBOMLines.Clear()

        nr = dtDesignMaster.NewRow
        AssignDefaultValueToDataRow(nr) 'Sitthana 24/04/2018
        dtDesignMaster.Rows.Add(nr)
        bsDesignMaster.MoveFirst()
        chkCalcMeasurements.Checked = True

        'nr = dtDesignMaster.NewRow
        'nr("dm_item_id") = -1
        'dtDesignMaster.Rows.Add(nr)
        'bsDesignMaster.MoveFirst()
        'chkCalcMeasurements.Checked = True
        '        BindData(dtDesignMaster)
    End Sub

    Private Sub AssignDefaultValueToDataRow(nr As DataRow)
        'Sitthana 24/04/2018, 07/07/2018, '12/07/2018
        nr("dm_item_id") = -1
        nr("dm_fin_id") = 0 '07/07/2018
        nr("dm_supdes_no") = "" '12/07/2018
        nr("ds_nob") = 1
        nr("ds_shrinkage_centigrade") = 0
        nr("ds_elongation") = 0
        nr("ds_modulus") = 0
        nr("ds_thickness") = 0
        nr("ds_thickness_tolerance") = 0
        nr("ds_ydkg") = 0
        nr("ds_edge_cut_wth") = 0 '07/07/2018
        nr("ds_width_type") = "OPEN WIDTH"
        nr("ds_thickness_tolerance_sign") = ""  '07/07/2018
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        AskBeforeSave()
    End Sub

    Private Sub UpdateDeleteDesignButton(ByVal sender As Object, ByVal e As EventArgs)
        Dim current = TryCast(bsDesignMaster.Current, DataRowView)
        btnDeleteDesign.Enabled = False
        If Not CBool(AllowEdit) OrElse current Is Nothing Then Return
        If current.Row.RowState = DataRowState.Deleted OrElse Not current.Row.HasVersion(DataRowVersion.Original) Then Return
        If IsDBNull(current("dm_item_id")) Then Return
        btnDeleteDesign.Enabled = Convert.ToInt64(current("dm_item_id")) > 0
    End Sub

    Private Sub btnDeleteDesign_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteDesign.Click
        If Not CBool(AllowEdit) Then Return
        Dim current = TryCast(bsDesignMaster.Current, DataRowView)
        If current Is Nothing OrElse Not current.Row.HasVersion(DataRowVersion.Original) Then Return
        If IsDBNull(current("dm_item_id")) OrElse Convert.ToInt64(current("dm_item_id")) <= 0 Then Return

        'Use the persisted identity, never the editable Design No. textbox.
        Dim savedId = Convert.ToInt64(current.Row("dm_item_id", DataRowVersion.Original))
        Dim savedNo = Convert.ToString(current.Row("dm_design_no", DataRowVersion.Original)).Trim()
        Dim confirmation = Microsoft.VisualBasic.Interaction.InputBox(
            "Permanently delete Design " & savedNo & "?" & Environment.NewLine &
            "Unsaved changes will be discarded only if deletion succeeds." & Environment.NewLine &
            "Type the Design No. to confirm:", "Delete Design")
        If confirmation.Length = 0 Then Return
        If Not String.Equals(confirmation.Trim(), savedNo, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Design No. does not match. Nothing was deleted.", "Delete Design", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        btnDeleteDesign.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim updater As New classMasterUpdate
            updater.DeleteDesignMaster(savedId, savedNo, clsUser.UserID)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Design failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Finally
            Me.Cursor = Cursors.Default
            UpdateDeleteDesignButton(Nothing, EventArgs.Empty)
        End Try

        ClearDataBindings()
        InitControl()
        DesignNo = ""
        blnCancel = False
        CreateNewRecord()
        BindData()
        txtDesignNo.AutoCompleteCustomSource.Remove(savedNo)
        MessageBox.Show("Design " & savedNo & " deleted.", "Delete Design", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub AskBeforeSave()
        If AllowEdit = False Then
            Exit Sub
        End If
        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        Dim dtChanges As DataTable
        dtChanges = dtDesignMaster.GetChanges
        If dtChanges IsNot Nothing Then
            If dtChanges.Rows.Count > 0 Then
                result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
                If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

                If Not CheckData() Then Exit Sub

                Me.Cursor = Cursors.WaitCursor
                If SaveData() Then
                    MessageBox.Show("Save Completed", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Sitthana 01/02/2018
                    LoadData(ItemID, "")
                End If
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub


    Private Sub btnMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub txtDesignNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F5 Then
            Dim frm As New frmItemsCategory
            frm.UserInfo = clsUser
            frm.PItcd = txtDesignNo.Text.Trim
            frm.Pitnaturecd = "FABRIC"
            frm.ShowDialog()
        End If
    End Sub

    Private Sub txtdesign_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim design_no As String = ""
        If Asc(e.KeyChar) = 13 Then
            design_no = txtDesignNo.Text.Trim.ToUpper
            Call btnNew_Click(sender, e)
            If Not blnCancel Then LoadData("", design_no)
        End If


    End Sub


    Private Sub btnViewImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Len(strImagePath & strImageFilename) > 0 Then
            Dim frm As New frmDesignImage
            frm.pImageFile = strImageFilename
            frm.pImagePath = strImagePath
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btnImagePath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtDesignNo.Text.Trim.Length = 0 Then Exit Sub

        Dim dlg As New OpenFileDialog

        Dim split As String() = (txtDesignNo.Text + "/").Split("/")
        Dim strFileName As String = split(0) & ".jpg"
        Dim strFilePath As String = "\\172.16.3.4\Setup\Image\Designs\"
        Dim strOldFilePath As String = "C:\"

        If strImagePath.Length = 0 Then
            If Not FileIO.FileSystem.DirectoryExists(strFilePath) Then
                strImagePath = ""
            Else
                strImagePath = strFilePath
                If FileIO.FileSystem.FileExists(strFilePath & strFileName) Then
                    strImageFilename = strFileName
                End If
            End If

        End If

        dlg.InitialDirectory = strOldFilePath 'strImagePath
        dlg.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*"
        dlg.Multiselect = False
        If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtImagePath.Text = dlg.FileName
        End If

        If dlg.FileName <> "" Then 'Add By Neung
            My.Computer.FileSystem.CopyFile(
            dlg.FileName,
           strFilePath & strFileName,
           Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
            Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException)
        End If

        txtImagePath.Text = strImagePath & strFileName
    End Sub

    Private Sub BtnfrmItemsCategory_Click(sender As System.Object, e As System.EventArgs) Handles BtnfrmItemsCategory.Click
        'If Not Validate_Design_no(txtDesignNo.Text.Trim) Or txtDesignNo.Text.Trim = "" Then
        '    MessageBox.Show("Design No. : " & txtDesignNo.Text & "............    Not Valid!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        '    Exit Sub
        'End If
        Dim frm As New frmItemsCategory
        frm.UserInfo = clsUser
        frm.PItcd = txtDesignNo.Text.Trim
        frm.Pitnaturecd = "FABRIC"
        frm.MdiParent = Me.ParentForm
        frm.AllowEdit = AllowEdit
        frm.Show()
        'frm.ShowDialog()
    End Sub

    Private Function Validate_Design_no(ByVal Design_no As String) As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ValidateDesignNo(Design_no, clsUser.UserID)

        If dt.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub BtmfrmDoc_attachments_Click(sender As System.Object, e As System.EventArgs) Handles BtmfrmDoc_attachments.Click
        If Not Validate_Design_no(txtDesignNo.Text.Trim) Or txtDesignNo.Text.Trim = "" Then
            MessageBox.Show("Design No. : " & txtDesignNo.Text & "............    Not Valid!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim frm As New frmDocAttachments
        frm.UserInfo = clsUser
        frm.Psource_doc_number = txtDesignNo.Text.Trim
        frm.Psource_doc_type = "DESIGN_NO"
        frm.MdiParent = Me.ParentForm
        frm.Show()

    End Sub

    Private Sub btnFindDesign_Click(sender As Object, e As EventArgs) Handles btnFindDesign.Click
        Dim f As New Classes.formSearchItemcode
        Dim res As Classes.SearchFormResult
        Dim c As New classConnection

        f.SqlConn = c.getSQLConnection

        f.ItemNatureCD = "FABRIC"
        res = f.ShowItems()
        If res.ButtonClicked = "OK" Then
            If Not res.ResultRowView Is Nothing Then
                DesignNo = res.ResultRowView("itcd").ToString
                ItemID = res.ResultRowView("item_id").ToString
                If Not blnCancel Then
                    LoadData(ItemID, DesignNo)
                End If
            End If
        End If
    End Sub

    Private Sub txtFullWidth_Leave(sender As Object, e As EventArgs) Handles txtFullWidth.Leave
        CalculateMeterPerKGFullWidth()
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub

    Private Sub txtEdgeWidth_Leave(sender As Object, e As EventArgs) Handles txtEdgeWidth.Leave
        CalculateMeterPerKGEdgeWidth()
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub

    Private Sub txtUseableWidth_Leave(sender As Object, e As EventArgs) Handles txtUseableWidth.Leave
        CalculateMeterPerKGUseableWidth()
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub

    Private Sub txtGramPerSqm_Leave(sender As Object, e As EventArgs) Handles txtGramPerSqm.Leave
        CalculateMeterPerKGFullWidth()
        CalculateMeterPerKGEdgeWidth()
        CalculateMeterPerKGUseableWidth()
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub

    Private Sub txtLengthPerPcMark_Leave(sender As Object, e As EventArgs) Handles txtLengthPerPcMark.Leave
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)

        '  CalculateGramPerRow()
        ' CalculateLengthPerRepeat()
        'CalculatePatternAreaSqCM()

        If CalculateMeasurements Then CalculateShoeFields()
    End Sub

    Private Sub txtRepeatPerDay_Leave(sender As Object, e As EventArgs)
        'CalculateMetersPerDay()
        'Sitthana 01/02/2018
        If Not (cboFabricType.SelectedValue = cnstFabricTypePLAIN Or cboFabricType.SelectedValue = cnstFabricTypeJPLAIN) Then
            CalculatePlanningFields()
        End If
    End Sub

    Private Sub txtMinutesPerRepeat_Leave(sender As Object, e As EventArgs) Handles txtMinutesPerRepeat.Leave
        'CalculateMetersPerDay()
        'Sitthana 01/02/2018
        'If Not (cboFabricType.Text.ToUpper = cnstFabricTypePLAIN Or cboFabricType.Text.ToUpper = cnstFabricTypeJPLAIN) Then
        If clsConfig.IsNull(cboFabricType.SelectedValue, -1) > 0 Then
            If Not (cboFabricType.SelectedValue = cnstFabricTypePLAIN Or cboFabricType.SelectedValue = cnstFabricTypeJPLAIN) Then
                CalculatePlanningFields()
            End If
        End If
    End Sub

    Private Sub txtHoursPerDay_Leave(sender As Object, e As EventArgs) Handles txtHoursPerDay.Leave
        'Sitthana 01/02/2018
        'If Not (cboFabricType.Text.ToUpper = cnstFabricTypePLAIN Or cboFabricType.Text.ToUpper = cnstFabricTypeJPLAIN) Then
        If clsConfig.IsNull(cboFabricType.SelectedValue, -1) > 0 Then
            If Not (cboFabricType.SelectedValue = cnstFabricTypePLAIN Or cboFabricType.SelectedValue = cnstFabricTypeJPLAIN) Then
                CalculatePlanningFields()
            End If
        End If
    End Sub

    Private Sub txtWidthPerPcMark_Leave(sender As Object, e As EventArgs) Handles txtWidthPerPcMark.Leave
        'CalculatePatternAreaSqCM()
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub
    Private Sub txtPieceWeight_Leave(sender As Object, e As EventArgs) Handles txtPieceWeight.Leave
        'CalculateWeightPerPair()
        If CalculateMeasurements Then CalculateShoeFields()

    End Sub

    Private Sub txtPixelWidth_Leave(sender As Object, e As EventArgs) Handles txtPixelWidth.Leave
        'CalculatePcsPerRowWidth()
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub

    Private Sub cboMultiMachineGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMultiMachineGroup.SelectedIndexChanged
        Me.txtdesign_gauge.Text = Me.cboMultiMachineGroup.ListBox.Grid.Model(Me.cboMultiMachineGroup.SelectedIndex + 1, 2).CellValue.ToString.Trim
        Me.txtNeedle.Text = Me.cboMultiMachineGroup.ListBox.Grid.Model(Me.cboMultiMachineGroup.SelectedIndex + 1, 6).CellValue.ToString()
    End Sub

    Private Sub txtNeedle_Leave(sender As Object, e As EventArgs) Handles txtNeedle.Leave
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub
    Private Sub txtNeedle2_Leave(sender As Object, e As EventArgs) Handles txtNeedle2.Leave
        If CalculateMeasurements Then CalculateShoeFields()
    End Sub

    Private Sub txtKgPerRoll_Leave(sender As Object, e As EventArgs) Handles txtKgPerRoll.Leave
        CalculateMeterPerRoll()
    End Sub
    Private Sub dgvBomHeader_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBomHeader.RowEnter
        getBOMLines()
    End Sub

    Private Sub bsBomHeader_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        getBOMLines()
    End Sub

    Private Sub getBOMHeader()
        dtBOMHeader = objMaster.getBOMHeader(DesignNo)
        bsBOMHeader.DataSource = dtBOMHeader

        dgvBomHeader.DataSource = bsBOMHeader
    End Sub

    Private Sub getBOMLines()
        Dim drvBOMHeader As DataRowView
        Dim IDYarnchange As Integer
        drvBOMHeader = CType(bsBOMHeader.Current, DataRowView)
        If drvBOMHeader Is Nothing Then 'Sitthana 19/03/2018
            bsBOMLines.DataSource = Nothing 'Sitthana 19/03/2018
            dgvBOMLines.DataSource = Nothing 'Sitthana 19/03/2018
        Else
            IDYarnchange = drvBOMHeader.Item("id_yarnchange")
            dtBOMLines = objMaster.getBOMLines(IDYarnchange)
            bsBOMLines.DataSource = dtBOMLines
            dgvBOMLines.DataSource = bsBOMLines
        End If
    End Sub

    Private Sub cboSizeCtry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSizeCtry.SelectedIndexChanged
        Dim CountryLookupValueId As Int64
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)

        If drv IsNot Nothing Then
            CountryLookupValueId = oConfig.IsNull(drv.Item("ds_shoe_country_id"), Nothing)
            genComboShoeSize(CountryLookupValueId)
        End If

    End Sub

    Private Sub btnOpenBOMForm_Click(sender As Object, e As EventArgs) Handles btnOpenBOMForm.Click
        ShowBOMForm()
    End Sub

    Private Sub ShowBOMForm()
        Dim f As New frmDesignBOMNew
        Dim drvBOMHeader As DataRowView
        Dim IDYarnchange As Nullable(Of Int32)
        drvBOMHeader = CType(bsBOMHeader.Current, DataRowView)
        If Not drvBOMHeader Is Nothing Then
            IDYarnchange = oConfig.IsNull(drvBOMHeader.Item("id_yarnchange"), Nothing)
            f.BOMHeaderID = IDYarnchange
            f.UserInfo = Me.UserInfo
            f.Show()
        Else
            MessageBox.Show("BOM has not been created for this item. Please create BOM before proceeding.", "System Message", MessageBoxButtons.OK)
        End If


    End Sub

    Private Sub tsbCopy_Click(sender As Object, e As EventArgs) Handles tsbCopy.Click
        CopyDesign()
    End Sub

    Private Sub CopyDesign()
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        AskBeforeSave()
        dtBOMHeader.Clear()
        dtBOMLines.Clear()
        drv.Item("dm_item_id") = -1
        drv.Item("dm_design_no") = ""
        ItemID = -1
    End Sub

#Region "CALCULATIONS"
    Private Sub CalculateMeterPerKGFullWidth()
        Dim objMaster As New classMaster
    Dim oDesignNew As New classDesignNew   'data work of this form (read/save Design Master)
        Dim FullWidth As Decimal 'Sitthana 20200525 Changed from Integer to decimal
        Dim Gmpersqm As Decimal 'Sitthana 20200525 Changed from Integer to decimal
        Dim KgPerMeter As Decimal
        Dim MetersPerKg As Decimal
        bsDesignMaster.EndEdit()
        KgPerMeter = 0
        MetersPerKg = 0
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_gmpersqm")) Then
            Gmpersqm = 0
            drv.Item("ds_gmpersqm") = 0
        Else
            Gmpersqm = drv.Item("ds_gmpersqm")
        End If

        If IsDBNull(drv.Item("ds_fwth")) Then
            FullWidth = 0
            drv.Item("ds_fwth") = 0
        Else
            FullWidth = drv.Item("ds_fwth")
        End If

        If Gmpersqm = 0 Or FullWidth = 0 Then
            drv.Item("ds_mtkg") = 0
            drv.Item("ds_kg_per_meter") = 0
        Else
            KgPerMeter = objMaster.KgPerMeter(Gmpersqm, FullWidth)

            MetersPerKg = objMaster.MetersPerKg(KgPerMeter)
            MetersPerKg = Math.Round(100000 / FullWidth / Gmpersqm, 2)  'Sitthana 17/10/2018 Because Eschler use this formula
            txtMtsPerKgFullWidth.Text = MetersPerKg
            txtMtsPerKgFullWidth_ReadOnly.Text = MetersPerKg
            'txtMtsPerKgFullWidth.DataBindings(0).WriteValue()
            bsDesignMaster.MoveFirst()
            drv.Item("ds_mtkg") = MetersPerKg
            drv.Item("ds_kg_per_meter") = KgPerMeter
        End If
    End Sub

    Private Sub CalculateMeterPerKGEdgeWidth()
        Dim objMaster As New classMaster
    Dim oDesignNew As New classDesignNew   'data work of this form (read/save Design Master)
        Dim EdgeWidth As Integer
        Dim Gmpersqm As Integer
        Dim KgPerMeter As Decimal
        Dim MetersPerKg As Decimal
        bsDesignMaster.EndEdit()
        KgPerMeter = 0
        MetersPerKg = 0

        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_gmpersqm")) Or IsDBNull(drv.Item("ds_gmpersqm")) Then
            Gmpersqm = 0
            drv.Item("ds_gmpersqm") = 0
        Else
            Gmpersqm = drv.Item("ds_gmpersqm")
        End If

        If IsDBNull(drv.Item("ds_edge_cut_wth")) Then
            EdgeWidth = 0
            drv.Item("ds_edge_cut_wth") = 0
        Else
            EdgeWidth = txtEdgeWidth.Text
        End If

        If Gmpersqm = 0 Or EdgeWidth = 0 Then
            drv.Item("ds_mtkg_edge") = 0
        Else
            KgPerMeter = objMaster.KgPerMeter(Gmpersqm, EdgeWidth)
            MetersPerKg = objMaster.MetersPerKg(KgPerMeter)
            'MetersPerKg = Math.Round(100000 / FullWidth / Gmpersqm, 2)  'Sitthana 17/10/2018 Because Eschler use this formula
            txtMtsPerKgFullWidth.Text = MetersPerKg
            txtMtsPerKgFullWidth_ReadOnly.Text = MetersPerKg
            'txtMtsPerKgFullWidth.DataBindings(0).WriteValue()
            bsDesignMaster.MoveFirst()
            drv = CType(bsDesignMaster.Current, DataRowView)
            drv.Item("ds_mtkg_edge") = MetersPerKg
        End If
    End Sub

    Private Sub CalculateMeterPerKGUseableWidth()
        Dim UseableWidth As Integer
        Dim Gmpersqm As Integer
        Dim KgPerMeter As Decimal
        Dim MetersPerKg As Decimal
        KgPerMeter = 0
        MetersPerKg = 0

        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_gmpersqm")) Then
            Gmpersqm = 0
            drv.Item("ds_gmpersqm") = 0
        Else
            Gmpersqm = drv.Item("ds_gmpersqm")
        End If

        If IsDBNull(drv.Item("ds_usewth")) Then
            UseableWidth = 0
            drv.Item("ds_usewth") = 0
        Else
            UseableWidth = txtUseableWidth.Text
        End If

        If Gmpersqm = 0 Or UseableWidth = 0 Then
            drv.Item("ds_mtkg_Useable") = 0
        Else
            KgPerMeter = objMaster.KgPerMeter(Gmpersqm, UseableWidth)
            MetersPerKg = objMaster.MetersPerKg(KgPerMeter)
            'MetersPerKg = Math.Round(100000 / FullWidth / Gmpersqm, 2)  'Sitthana 17/10/2018 Because Eschler use this formula
            txtMtsPerKgFullWidth.Text = MetersPerKg
            txtMtsPerKgFullWidth_ReadOnly.Text = MetersPerKg

            'txtMtsPerKgFullWidth.DataBindings(0).WriteValue()
            bsDesignMaster.MoveFirst()
            drv = CType(bsDesignMaster.Current, DataRowView)
            drv.Item("ds_mtkg_Useable") = MetersPerKg
        End If
    End Sub

    Private Sub CalculateGramPerRow()
        Dim GramsPerRow As Decimal
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        ' 1000/100 means 1000 to convert kg to gram and divide by 100 to convert cm to meters
        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Then
            drv.Item("ds_sh_length_cm_mark_to_mark") = 0
        End If
        If IsDBNull(drv.Item("ds_kg_per_meter")) Then
            drv.Item("ds_kg_per_meter") = 0
        End If

        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Or IsDBNull(drv.Item("ds_kg_per_meter")) Then
            GramsPerRow = 0
        Else
            GramsPerRow = Math.Round(objMaster.WeightGramsPerRow(drv.Item("ds_sh_length_cm_mark_to_mark"), drv.Item("ds_kg_per_meter")), 2)
            drv.Item("ds_sh_grams_per_row") = GramsPerRow
        End If
        '        drv.Item("ds_sh_grams_per_row") = Math.Round((drv.Item("ds_sh_length_cm_mark_to_mark") / drv.Item("ds_mtkg") * 1000) / 100, 2)
    End Sub

    Private Sub CalculateLengthPerRepeat()
        Dim LengthPerRepeat As Decimal
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If

        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Then
            drv.Item("ds_sh_length_cm_mark_to_mark") = 0
        End If

        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Then
            LengthPerRepeat = 0
        Else
            LengthPerRepeat = objMaster.LengthCmPerRepeat(drv.Item("ds_sh_length_cm_mark_to_mark"))
            drv.Item("ds_sh_length_cm_per_repeat") = LengthPerRepeat
        End If
        '        drv.Item("ds_sh_length_cm_per_repeat") = Math.Round(drv.Item("ds_sh_length_cm_mark_to_mark") * 2, 2)
    End Sub

    Private Sub CalculateMetersPerDay()
        Dim MetersPerDay As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_repeat_per_day")) Then
            drv.Item("ds_sh_repeat_per_day") = 0
        End If
        If IsDBNull(drv.Item("ds_sh_length_cm_per_repeat")) Then
            drv.Item("ds_sh_length_cm_per_repeat") = 0
        End If

        If IsDBNull(drv.Item("ds_sh_repeat_per_day")) Or IsDBNull(drv.Item("ds_sh_length_cm_per_repeat")) Then
            drv.Item("ds_meters_per_day") = 0
        Else
            MetersPerDay = objMaster.MetersPerDay(drv.Item("ds_sh_length_cm_per_repeat"), drv.Item("ds_sh_repeat_per_day"))
            drv.Item("ds_meters_per_day") = MetersPerDay
            '            drv.Item("ds_sh_meters_per_day") = drv.Item("ds_sh_length_cm_per_repeat") * drv.Item("ds_sh_repeat_per_day")
        End If
    End Sub

    Public Sub CalculatePatternAreaSqCM()
        Dim PatternAreaSqCM As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Then
            drv.Item("ds_sh_length_cm_mark_to_mark") = 0
        End If
        If IsDBNull(drv.Item("ds_sh_width_cm_mark_to_mark")) Then
            drv.Item("ds_sh_width_cm_mark_to_mark") = 0
        End If

        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Or IsDBNull(drv.Item("ds_sh_width_cm_mark_to_mark")) Then
            PatternAreaSqCM = 0
        Else
            PatternAreaSqCM = objMaster.AreaSqCMPerPiece(drv.Item("ds_sh_length_cm_mark_to_mark"), drv.Item("ds_sh_width_cm_mark_to_mark"))
            drv.Item("ds_sh_pattern_area") = PatternAreaSqCM
        End If
    End Sub


    Public Sub CalculateWeightPerPair()
        Dim WeightPerPair As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_grams_of_lasercut_pc")) Then
            drv.Item("ds_sh_grams_of_lasercut_pc") = 0
        End If

        If IsDBNull(drv.Item("ds_sh_grams_of_lasercut_pc")) Then
            WeightPerPair = 0
        Else
            WeightPerPair = objMaster.WeighGramstPerPair(drv.Item("ds_sh_grams_of_lasercut_pc"))
            drv.Item("ds_sh_grams_of_lasercut_pair") = WeightPerPair
        End If

    End Sub

    Private Sub CalculatePcsPerRowWidth()
        Dim PcsPerPxWidth As Decimal = 0
        Dim PcsPerEdgeWidth As Decimal = 0
        Dim WidthPerPcMarkToMark As Decimal
        Dim NumOfNeedles As Integer
        Dim FullWidth As Decimal
        Dim NeedleWidth As Decimal
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_fwth")) Then
            drv.Item("ds_fwth") = 0
            FullWidth = 0
        Else
            If drv.Item("ds_fwth").ToString.Trim = "" Then  'Sitthana 23/03/2018
                drv.Item("ds_fwth") = 0
                FullWidth = 0
            Else
                FullWidth = Convert.ToDecimal(drv.Item("ds_fwth"))
            End If
            'FullWidth = drv.Item("ds_fwth") 'Sitthana comment on 23/03/2018
        End If

        If IsDBNull(drv.Item("ds_needle")) Then
            drv.Item("ds_needle") = 0
            NumOfNeedles = 0
        Else
            If drv.Item("ds_needle").ToString.Trim = "" Then  'Sitthana 21/03/2018
                drv.Item("ds_needle") = 0
                NumOfNeedles = 0
            Else
                NumOfNeedles = Convert.ToDecimal(drv.Item("ds_needle"))
            End If
        End If

        If IsDBNull(drv.Item("ds_sh_needle_width_cm")) Then
            drv.Item("ds_sh_needle_width_cm") = 0
            NeedleWidth = 0
        Else
            NeedleWidth = drv.Item("ds_sh_needle_width_cm")
        End If

        If IsDBNull(drv.Item("ds_sh_width_cm_mark_to_mark")) Then
            drv.Item("ds_sh_width_cm_mark_to_mark") = 0
            WidthPerPcMarkToMark = 0
        Else
            WidthPerPcMarkToMark = drv.Item("ds_sh_width_cm_mark_to_mark")
        End If

        If FullWidth = 0 Or NumOfNeedles = 0 Then
            PcsPerPxWidth = 0
        Else
            PcsPerPxWidth = objMaster.PiecesPerFabricNeedleWidthPerRow(NumOfNeedles, NeedleWidth)
            drv.Item("ds_sh_pcs_fabric_needle_width") = PcsPerPxWidth
        End If

        If NeedleWidth = 0 Or WidthPerPcMarkToMark = 0 Then
            PcsPerEdgeWidth = 0
        Else
            PcsPerEdgeWidth = objMaster.PiecesPerFabricFullWidthPerRow(FullWidth, WidthPerPcMarkToMark)
            drv.Item("ds_sh_pcs_fabric_edge_to_edge") = PcsPerEdgeWidth
        End If

    End Sub
    Private Sub CalculateRowsPerMeter()
        Dim RowsPerMeter As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Or (drv.Item("ds_sh_length_cm_mark_to_mark")) = 0 Then
            drv.Item("ds_sh_length_cm_mark_to_mark") = 0
            RowsPerMeter = 0
        Else
            drv.Item("ds_sh_rows_per_meter") = objMaster.RowsPerMeter(drv.Item("ds_sh_length_cm_mark_to_mark"))
        End If

    End Sub

    Private Sub CalculatePairsPerRepeat()
        Dim PairPerRepeat As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_needle")) Then
            drv.Item("ds_needle") = 0
        ElseIf drv.Item("ds_needle").ToString.Trim = "" Then   'Sitthana 21/03/2018
            drv.Item("ds_needle") = 0
        End If

        If IsDBNull(drv.Item("ds_sh_needle_width_cm")) Then
            drv.Item("ds_needle_width_cm") = 0
        ElseIf drv.Item("ds_sh_needle_width_cm").ToString.Trim = "" Then  'Sitthana 21/03/2018
            drv.Item("ds_needle_width_cm") = 0
        End If

        drv.Item("ds_sh_pairs_per_repeat_of_fabric_width") = objMaster.PairsPerRepeat(drv.Item("ds_needle"), drv.Item("ds_sh_needle_width_cm"))
    End Sub

    Private Sub CalculatePairsPerMeter()
        Dim PairPerRepeat As Decimal = 0
        Dim PiecesEdgeToEdge As Decimal = 0
        Dim LengthPerPieceWithMark As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_pcs_fabric_edge_to_edge")) Then
            drv.Item("ds_sh_pcs_fabric_edge_to_edge") = 0
            PiecesEdgeToEdge = 0
        Else
            PiecesEdgeToEdge = drv.Item("ds_sh_pcs_fabric_edge_to_edge")
        End If

        If IsDBNull(drv.Item("ds_sh_length_cm_mark_to_mark")) Then
            drv.Item("ds_sh_length_cm_mark_to_mark") = 0
            LengthPerPieceWithMark = 0
        Else
            LengthPerPieceWithMark = drv.Item("ds_sh_length_cm_mark_to_mark")
        End If

        drv.Item("ds_pairs_per_meter") = objMaster.PairsPerMeter(LengthPerPieceWithMark, PiecesEdgeToEdge)
    End Sub


    Private Sub CalculateFabricWeightWithPattern()
        Dim WeightWithPattern As Decimal = 0
        Dim WeightPerPiece As Decimal = 0
        Dim PiecesEdgeToEdge As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_pcs_fabric_edge_to_edge")) Then
            drv.Item("ds_sh_pcs_fabric_edge_to_edge") = 0
            PiecesEdgeToEdge = 0
        Else
            PiecesEdgeToEdge = drv.Item("ds_sh_pcs_fabric_edge_to_edge")
        End If

        If IsDBNull(drv.Item("ds_sh_grams_of_lasercut_pc")) Then
            drv.Item("ds_sh_grams_of_lasercut_pc") = 0
            WeightPerPiece = 0
        Else
            WeightPerPiece = drv.Item("ds_sh_grams_of_lasercut_pc")
        End If

        drv.Item("ds_sh_fabric_grams_with_pattern") = objMaster.WeightGramsFullWidth(WeightPerPiece, PiecesEdgeToEdge)
    End Sub
    Private Sub CalculateFabricWeightWithNoPattern()
        Dim WeightWithPattern As Decimal = 0
        Dim WeightPerRow As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_fabric_grams_with_pattern")) Then
            drv.Item("ds_sh_fabric_grams_with_pattern") = 0
            WeightWithPattern = 0
        Else
            WeightWithPattern = drv.Item("ds_sh_fabric_grams_with_pattern")
        End If

        If IsDBNull(drv.Item("ds_sh_grams_per_row")) Then
            drv.Item("ds_sh_grams_per_row") = 0
            WeightPerRow = 0
        Else
            WeightPerRow = drv.Item("ds_sh_grams_per_row")
        End If

        drv.Item("ds_sh_fabric_grams_without_pattern") = objMaster.WeightGramsOfAreaNotUsed(WeightPerRow, WeightWithPattern)
    End Sub
    Private Sub CalculateKgPerDay()
        Dim MetersPerKg As Decimal = 0
        Dim MetersPerDay As Decimal = 0
        Dim KgPerday As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_mtkg")) Then
            drv.Item("ds_mtkg") = 0
            MetersPerKg = 0
        Else
            MetersPerKg = drv.Item("ds_mtkg")
        End If

        If IsDBNull(drv.Item("ds_meters_per_day")) Then
            drv.Item("ds_meters_per_day") = 0
            MetersPerDay = 0
        Else
            MetersPerDay = drv.Item("ds_meters_per_day")
        End If

        drv.Item("ds_kg_per_day") = objMaster.KgPerDay(MetersPerDay, MetersPerKg)
    End Sub
    Private Sub CalculatePairsPerDay()
        Dim PairsPerMeter As Decimal = 0
        Dim MetersPerDay As Decimal = 0
        Dim PairsPerday As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_pairs_per_meter")) Then
            drv.Item("ds_pairs_per_meter") = 0
            PairsPerMeter = 0
        Else
            PairsPerMeter = drv.Item("ds_pairs_per_meter")
        End If

        If IsDBNull(drv.Item("ds_meters_per_day")) Then
            drv.Item("ds_meters_per_day") = 0
            MetersPerDay = 0
        Else
            MetersPerDay = drv.Item("ds_meters_per_day")
        End If

        drv.Item("ds_sh_pairs_per_day") = objMaster.PairsPerDay(PairsPerMeter, MetersPerDay)
    End Sub

    Private Sub CalculateRepeatsPerDay()
        Dim MinutesPerRepeat As Decimal = 0
        Dim HoursPerDay As Decimal = 0
        Dim RepeatsPerDay As Decimal = 0
        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_sh_minutes_per_repeat")) Then
            drv.Item("ds_sh_minutes_per_repeat") = 0
            MinutesPerRepeat = 0
        Else
            MinutesPerRepeat = drv.Item("ds_sh_minutes_per_repeat")
        End If

        If IsDBNull(drv.Item("ds_hours_per_day")) Then
            drv.Item("ds_hours_per_day") = 0
            HoursPerDay = 0
        Else
            HoursPerDay = drv.Item("ds_hours_per_day")
        End If

        drv.Item("ds_sh_repeat_per_day") = objMaster.RepeatsPerDay(MinutesPerRepeat, HoursPerDay)
    End Sub

    Private Sub CalculateYield()
        CalculateMeterPerKGFullWidth()
        CalculateMeterPerKGEdgeWidth()
        CalculateMeterPerKGUseableWidth()
    End Sub

    Private Sub CalculateMeterPerRoll()
        Dim MeterPerRoll As Decimal = 0
        Dim KgPerRoll As Decimal = 0
        Dim MetersPerKg As Decimal = 0

        bsDesignMaster.EndEdit()
        drv = CType(bsDesignMaster.Current, DataRowView)
        If drv Is Nothing Then 'Sitthana 24/08/2018
            Exit Sub
        End If
        If IsDBNull(drv.Item("ds_kg_per_roll")) Then
            drv.Item("ds_kg_per_roll") = 0
        Else
            KgPerRoll = drv.Item("ds_kg_per_roll")
        End If

        If IsDBNull(drv.Item("ds_mtkg")) Then
            drv.Item("ds_mtkg") = 0
        Else
            MetersPerKg = drv.Item("ds_mtkg")
        End If

        drv.Item("ds_mts_per_roll") = objMaster.MetersPerRoll(KgPerRoll, MetersPerKg)
    End Sub

    Private Sub CalculateShoeFields()
        CalculateGramPerRow()
        '        CalculateLengthPerRepeat() -- K. Best don't want calculation
        CalculateRepeatsPerDay()
        '        CalculateMetersPerDay() '11
        CalculatePatternAreaSqCM()
        CalculateWeightPerPair()
        CalculatePcsPerRowWidth()
        CalculateRowsPerMeter()
        CalculatePairsPerMeter()
        CalculatePairsPerRepeat()
        CalculateFabricWeightWithPattern()
        CalculateFabricWeightWithNoPattern()
        CalculateMeterPerRoll()
        'CalculatePlanningFields() 'Old Sitthana 01/02/2018
        'If Not (cboFabricType.Text.ToUpper.Trim = cnstFabricTypePLAIN Or cboFabricType.Text.ToUpper.Trim = cnstFabricTypeJPLAIN) Then
        If clsConfig.IsNull(cboFabricType.SelectedValue, -1) > 0 Then
            If Not (cboFabricType.SelectedValue = cnstFabricTypePLAIN Or cboFabricType.SelectedValue = cnstFabricTypeJPLAIN) Then
                CalculateMetersPerDay() '11
                CalculatePlanningFields()
            End If
        End If
    End Sub

    Private Sub CalculatePlanningFields()
        'Sitthana 01/02/2018
        'CalculateKgPerDay()
        'If cboFabricType.Text.ToUpper <> "PLAIN" Then   'Old Sitthana 01/02/2018
        'If Not (cboFabricType.Text.ToUpper.Trim = cnstFabricTypePLAIN Or cboFabricType.Text.ToUpper.Trim = cnstFabricTypeJPLAIN) Then
        If clsConfig.IsNull(cboFabricType.SelectedValue, -1) > 0 Then
            If Not (cboFabricType.SelectedValue = cnstFabricTypePLAIN Or cboFabricType.SelectedValue = cnstFabricTypeJPLAIN) Then
                CalculateKgPerDay()
                CalculatePairsPerDay()
                CalculateRepeatsPerDay()
            End If
        End If
    End Sub

    Private Sub chkCalcMeasurements_CheckedChanged(sender As Object, e As EventArgs) Handles chkCalcMeasurements.CheckedChanged
        CalculateMeasurements = chkCalcMeasurements.Checked
    End Sub

    Private Sub cboFabricType_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboFabricType.SelectedValueChanged
        'Sitthana 01/02/2018
        'If (cboFabricType.Text.ToUpper.Trim = cnstFabricTypePLAIN Or cboFabricType.Text.ToUpper.Trim = cnstFabricTypeJPLAIN) Then
        If clsConfig.IsNull(cboFabricType.SelectedValue, -1) > 0 Then
            If (cboFabricType.SelectedValue = cnstFabricTypePLAIN Or cboFabricType.SelectedValue = cnstFabricTypeJPLAIN) Then
                txtKgPerDay.BackColor = Color.White
            Else
                txtKgPerDay.BackColor = Color.NavajoWhite
            End If
        End If
    End Sub

    Private Sub txtKgPerDay_Leave(sender As Object, e As EventArgs) Handles txtKgPerDay.Leave
        'Sitthana 01/02/2018
        'If (cboFabricType.Text.ToUpper.Trim = cnstFabricTypePLAIN Or cboFabricType.Text.ToUpper.Trim = cnstFabricTypeJPLAIN) Then
        If clsConfig.IsNull(cboFabricType.SelectedValue, -1) > 0 Then
            If (cboFabricType.SelectedValue = cnstFabricTypePLAIN Or cboFabricType.SelectedValue = cnstFabricTypeJPLAIN) Then
                txtMetersPerDay.Text = clsConfig.IsNull(txtKgPerDay.Text.Trim, 0) * clsConfig.IsNull(txtMtsPerKgFullWidth.Text.Trim, 0)
            End If
        End If
    End Sub

    Private Sub tsbtnRptDesignMaster_Click(sender As Object, e As EventArgs) Handles tsbtnRptDesignMaster.Click
        'Dim frm As New frmReport
        ''Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'Dim rptFileName As String

        If strDesignNo = "" Then
            PrintReport("rptMasterDesign.rpt", "Design Master")
            'rptFileName = "rptMasterDesign.rpt"
            ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            'If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            'Me.Cursor = Cursors.WaitCursor

            'rpt.Load(clsUser.ReportPath & rptFileName)
            'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            'rpt.VerifyDatabase()
            'rpt.SetParameterValue("@design_no", strDesignNo)
        Else
            PrintReport("rptMasterDesign2.rpt", "Design Master")
            'rptFileName = "rptMasterDesign2.rpt"
            ''If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
            'If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
            'Me.Cursor = Cursors.WaitCursor

            'rpt.Load(clsUser.ReportPath & rptFileName)
            'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
            'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
            'rpt.VerifyDatabase()
            'rpt.SetParameterValue("@design_no", strDesignNo)
            'GetImage(rpt.Database.Tables(0))
        End If

        'frm.Title = "Design Master"
        'frm.CRViewer.ReportSource = rpt
        'frm.MdiParent = Me.ParentForm
        'frm.Show()
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub tsbtnTechnicalDatasheet_Click(sender As Object, e As EventArgs) Handles tsbtnTechnicalDatasheet.Click
        PrintReport("rptEschlerTechDatasheet.rpt", "Eschler  Techical  Datasheet")
    End Sub
    Private Sub PrintReport(p_ReportName As String, p_RptTitle As String)
        Dim frm As New frmReport
        'Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim rptFileName As String

        rptFileName = p_ReportName
        ' 'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@design_no", txtDesignNo.Text.Trim) 'strDesignNo

        frm.Title = p_RptTitle
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtDesignNo_KeyDown_1(sender As Object, e As KeyEventArgs) Handles txtDesignNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            DesignNo = txtDesignNo.Text
            Call InitDataBinding()
        End If

        If e.KeyCode = Keys.F5 Then
            Dim frm As New frmItemsCategory
            frm.UserInfo = clsUser
            frm.PItcd = txtDesignNo.Text.Trim
            frm.Pitnaturecd = "FABRIC"
            frm.ShowDialog()
        End If
    End Sub

    Private Sub grdParentDesign_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdParentDesign.CellDoubleClick
        'Sitthana 20201014
        With grdParentDesign
            If .RowCount > 0 Then
                If .Rows(.CurrentRow.Index).Cells("Design_no").ToString.Trim <> "" Then
                    If txtDesignNo.Text.Trim = .Rows(.CurrentRow.Index).Cells("Design_no").Value.ToString.Trim Then
                        MessageBox.Show("Current is Design no that you double click", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        Dim frm As New frmDesignNew
                        frm.pDesignNo = .Rows(.CurrentRow.Index).Cells("Design_no").Value.ToString.Trim
                        frm.ShowDialog()
                    End If
                End If
            End If
        End With
    End Sub
#End Region

End Class
