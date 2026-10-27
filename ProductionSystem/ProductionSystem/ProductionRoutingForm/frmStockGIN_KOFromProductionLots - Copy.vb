Public Class frmStockGIN_KOFromProductionLots
    Dim clsuser As classUserInfo
    Dim dtProductionLots As New DataTable
    Dim bsProductionLots As New BindingSource
    Dim MfgProductionLots As New MfgProdcutionsLots
    Dim dtdefectroll As DataTable
    Dim bsDefectRoll As New BindingSource
    Dim dtMtlSubInventory As New DataTable
    Dim bsMtlSubInventory As New BindingSource
    Dim dtmtlLocations As New DataTable
    Dim bsMtlLocations As New BindingSource

    Dim mfg_production_lots As mfg_production_lots

    Dim clsConn As New classConnection
    Dim clsconfig As New clsConfig

    Dim blnCancel As Boolean = False 'For GIN Step
    Dim StrNew As String = "" 'For GIN Step

    Public Property Title() As String
        Get
            Title = Me.Text
        End Get
        Set(ByVal NewValue As String)
            Me.Text = NewValue
        End Set
    End Property

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Public Property p_mfg_production_lots() As mfg_production_lots
        Get
            p_mfg_production_lots = Me.mfg_production_lots
        End Get
        Set(ByVal NewValue As mfg_production_lots)
            mfg_production_lots = NewValue
        End Set
    End Property

    Private Sub frmProductionLots_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed



        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub frmQI_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Call InitControl()
        'Call InitDataBinding()
    End Sub


    Private Sub InitDataBinding()

        'dtProductionLots = (New classmfgOperationsStepLaserCut).GetMfgOperationStepLaserCut(IntMfgProductionLotsID:=Nothing, StrSystemLotNumber:=txtsystem_lot_number.Text, IntmfgProductionStepsID:=Nothing, StrProductionOrderNo:=Nothing, Strlogempcd:=clsuser.UserID)

        'bsProductionLots.DataSource = dtProductionLots


        dtdefectroll = (New classStockGIN_KOManual).GetDefectRoll(txtsystem_lot_number.Text, clsuser.UserID)

        bsDefectRoll.DataSource = dtdefectroll

        'Call BindData() '
    End Sub

    Private Sub GenCboInGrid()
        Dim objdb As New classStockGIN_KOManual
        ColDefectCode.DataSource = objdb.GetComboDefectCode
        ColDefectCode.DisplayMember = "defect_code"
        ColDefectCode.ValueMember = "defect_code"
    End Sub

    'Private Sub GetgrdDefect(ByVal StrSystemroll_no As String)
    '    Dim objdb As New classStockGIN_KOManual
    '    grdDefect.AutoGenerateColumns = False
    '    grdDefect.DataSource = objdb.GetDefectRoll(StrSystemroll_no, "")

    'End Sub

    Private Sub BindDataDefect()
        Dim dbStockG As New classStockGIN_KOManual
        Dim objdb As DataTable = dbStockG.GetDefectRoll(txtsystem_lot_number.Text, clsuser.UserID)
    End Sub
    Private Sub BindDataLotsSteps()
        Dim dbStockG As New classProductionLots
        Dim objdb As DataTable = dbStockG.GetLotsSteps(txtsystem_lot_number.Text, clsuser.UserID)
    End Sub



    Private Sub InitControl()

        Call Gencbo()
        Call GenCboInGrid()

        IIf(clsconfig.IsNull(mfg_production_lots.mfg_production_steps_id, Nothing) = Nothing, Nothing, cbomfg_production_steps_id.SelectedValue = mfg_production_lots.mfg_production_steps_id)

        Call Loaddata(mfg_production_lots.system_lot_number)
    End Sub

    Private Function GetDefectRoll(ByVal StrRollNo As String) As Boolean
        ' Dim dbStockG As New classStockGIN_KOManual
        'Dim objdb As DataTable = dbStockG.GetDefectRoll(StrRollNo, clsuser.UserID)
        grdDefect.AutoGenerateColumns = False
        grdDefect.DataSource = (New classmfgOperationsStepKnitting).GetDefectRoll(strrollNo:=StrRollNo)
        'grdDefect.DataSource = (New classStockGIN_KOManual).GetDefectRoll(StrRollNo, clsuser.UserID)

    End Function
    Private Sub Gencbo()
        Dim objdb As New classMaster
        Dim clsProductionRouting As New classProductionRouting
        Dim dt As New DataTable



        cbomfg_production_steps_id.DataSource = clsProductionRouting.Combomfgproductionstep(mfg_production_lots.production_order_no, "")
        cbomfg_production_steps_id.DisplayMember = "mfg_production_steps_id" + "operation_name"
        cbomfg_production_steps_id.ValueMember = "mfg_production_steps_id"

        cbomtl_warehouse.DataSource = (New classmfgOperationsStepKnitting).Combomtlwarehouse()
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"

        dtMtlSubInventory = (New classmfgOperationsStepKnitting).ComboMtlsubinventory(0)
        bsMtlSubInventory.DataSource = dtMtlSubInventory
        cbomtl_subinventory.DataSource = bsMtlSubInventory.DataSource
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"

        dtmtlLocations = (New classmfgOperationsStepKnitting).Combomtllocations(INt64mtl_warehouse_id:=0, Int64mtl_subinventory_id:=0)
        bsMtlLocations.DataSource = dtmtlLocations
        cbomtl_location.DataSource = bsMtlLocations.DataSource
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"

        cbooperator.DataSource = objdb.comboEmployee(clsuser.UserID)
        cbooperator.DisplayMember = "empname"
        cbooperator.ValueMember = "empcd"

        cbomcno.DataSource = objdb.comboMachine(clsuser.UserID)
        cbomcno.DisplayMember = "mcno"
        cbomcno.ValueMember = "mcno"

        Dim objdb2 As New classStockGIN_KOManual
        Me.cbodefect_code.DataSource = objdb2.GetComboDefectCode
        Me.cbodefect_code.DisplayMember = "defect_code_name"
        Me.cbodefect_code.ValueMember = "defect_code"
        Me.cbodefect_code.SelectedIndex = -1

    End Sub
    Private Sub SetDefaultWarehouse(ByVal dt As DataTable)
        Dim expression As String
        expression = "warehouse_name like '%ESH%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        If foundRows.Length > 0 Then cbomtl_warehouse.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub SetDefaultSubInventory(ByVal dt As DataTable)
        Dim expression As String
        expression = "subinventory_name like '%GREIGE%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        If foundRows.Length > 0 Then cbomtl_subinventory.SelectedValue = foundRows(0)(0)

    End Sub
    Private Sub SetDefaultLocation(ByVal dt As DataTable)
        Dim expression As String
        expression = "location_name like '%N/A%'"
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        If foundRows.Length > 0 Then cbomtl_subinventory.SelectedValue = foundRows(0)(0)

    End Sub

    Private Sub GetComboLocation(ByVal Int64mtl_warehouse_id As Int64, ByVal Int64mtl_subinventory_id As Int64)
        Dim objdb As New classMaster
        cbomtl_location.DataSource = objdb.Combomtllocations(strUSerID:=clsuser.UserID, INt64mtl_warehouse_id:=Int64mtl_warehouse_id, Int64mtl_subinventory_id:=Int64mtl_subinventory_id)
        cbomtl_location.DisplayMember = "location_name"
        cbomtl_location.ValueMember = "mtl_locations_id"

        'SetDefaultSubLocation(cbomtl_location.DataSource)
    End Sub

    Private Sub GetComboNewSubInventory(ByVal Int64mtl_warehouse_id As Int64)
        Dim objdb As New classMaster

        cbomtl_subinventory.DataSource = objdb.GetCombomtl_subinventory(cbomtl_warehouse.SelectedValue)
        cbomtl_subinventory.DisplayMember = "subinventory_code"
        cbomtl_subinventory.ValueMember = "mtl_subinventory_id"

        SetDefaultSubInventory(cbomtl_subinventory.DataSource)

    End Sub

    Private Sub lblPROD_Click(sender As System.Object, e As System.EventArgs) Handles lblPROD.Click

    End Sub
    Private Sub lblStep_Click(sender As System.Object, e As System.EventArgs) Handles lblStep.Click

    End Sub

    Private Sub txtsystem_lot_number_Click(sender As Object, e As System.EventArgs) Handles txtsystem_lot_number.Click

    End Sub

    Private Sub txtsystem_lot_number_GotFocus(sender As Object, e As System.EventArgs) Handles txtsystem_lot_number.GotFocus
        txtsystem_lot_number.Focus()
    End Sub

    Private Sub txtsystem_lot_number_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtsystem_lot_number.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Validate_Greige_IN(txtsystem_lot_number.Text.Trim) Then

            End If
            If Validate_RollNo(txtsystem_lot_number.Text.Trim) Then
                Call Loaddata(txtsystem_lot_number.Text)
            Else
                Call Loaddata("")
            End If
        End If
    End Sub

    Private Sub EnaBle()

    End Sub

    Private Sub Loaddata(Optional ByVal strsystem_lot_number As String = Nothing)

        dtProductionLots = (New classmfgOperationsStepKnitting).GetMfgOperationStepKnitting(IntMfgProductionLotsID:=Nothing, _
                             StrSystemLotNumber:=strsystem_lot_number, IntmfgProductionStepsID:=Nothing, _
                             StrProductionOrderNo:=Nothing, Strlogempcd:=clsuser.UserID)

        Call Binddatatext(dtProductionLots)
        Call GetDefectRoll(strsystem_lot_number)

    End Sub

    Private Sub Binddatatext(ByVal dt As DataTable)
        Dim config As New clsConfig
        Dim clsProductionRouting As New classProductionRouting

        If dt.Rows.Count > 0 Then

            cbomfg_production_steps_id.DataSource = clsProductionRouting.Combomfgproductionstep(dt.Rows(0)("production_order_no"), "")
            cbomfg_production_steps_id.DisplayMember = "operation_desc"
            cbomfg_production_steps_id.ValueMember = "mfg_production_steps_id"
            cbomfg_production_steps_id.SelectedValue = dt.Rows(0).Item("mfg_production_steps_id")
            txtsystem_lot_number.Text = dt.Rows(0).Item("system_lot_number").ToString.Trim
            txtproduction_order_no.Text = dt.Rows(0)("production_order_no")
            txtinventory_item_code.Text = dt.Rows(0)("inventory_item_code")
            txtlot_grade.Text = config.IsNull(dt.Rows(0)("lot_grade"), String.Empty)
            txtprimary_quantity.Text = config.IsNull(dt.Rows(0)("primary_quantity"), "0")
            txtsecondary_quantity.Text = config.IsNull(dt.Rows(0)("secondary_quantity"), "0")
            If config.IsNull(dt.Rows(0)("mcno").ToString, Nothing) = Nothing Then
                cbomcno.SelectedIndex = -1
            ElseIf config.IsNull(dt.Rows(0)("mcno").ToString, Nothing) <> Nothing Then
                cbomcno.SelectedValue = config.IsNull(dt.Rows(0)("mcno"), Nothing)
            End If
            txtcustom_lot_number.Text = config.IsNull(dt.Rows(0)("custom_lot_number"), String.Empty)
            txtqc_remarks.Text = config.IsNull(dt.Rows(0)("qc_remarks"), Nothing)
            If config.IsNull(dt.Rows(0)("mtl_warehouse_id"), Nothing) = Nothing Then
                cbomtl_warehouse.SelectedIndex = -1
            ElseIf config.IsNull(dt.Rows(0)("mtl_warehouse_id"), Nothing) <> Nothing Then
                cbomtl_warehouse.SelectedValue = config.IsNull(dt.Rows(0)("mtl_warehouse_id"), Nothing)
            End If

            GetComboNewSubInventory(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue)
            GetComboLocation(Int64mtl_warehouse_id:=cbomtl_warehouse.SelectedValue, Int64mtl_subinventory_id:=cbomtl_subinventory.SelectedValue)


            If config.IsNull(dt.Rows(0)("mtl_locations_id"), Nothing) = Nothing Then
                cbomtl_location.SelectedItem = -1
            ElseIf config.IsNull(dt.Rows(0)("mtl_locations_id"), Nothing) <> Nothing Then
                cbomtl_location.SelectedValue = config.IsNull(dt.Rows(0)("mtl_locations_id"), Nothing)
            End If
            If config.IsNull(dt.Rows(0)("operator"), Nothing) = Nothing Then
                cbooperator.SelectedItem = -1
            ElseIf config.IsNull(dt.Rows(0)("operator"), Nothing) <> Nothing Then
                cbooperator.SelectedValue = config.IsNull(dt.Rows(0)("operator"), Nothing)
            End If

            txtwork_shift.Text = config.IsNull(dt.Rows(0)("work_shift"), String.Empty)
            txtBOM.Text = config.IsNull(dt.Rows(0)("ynchgcd"), String.Empty)
            txtsteam_instruction.Text = config.IsNull(dt.Rows(0)("steam_instruction"), String.Empty)

            txtsteam_condition.Text = config.IsNull(dt.Rows(0)("steam_condition"), String.Empty)

            If config.IsNull(dt.Rows(0)("steam_date"), CDate("01/01/1900")) = CDate("01/01/1900") Then
                dtpsteam_date.Value = CDate("01/01/1900")
                dtpsteam_date.Checked = False
            Else
                dtpsteam_date.Value = dt.Rows(0)("steam_date")
                dtpsteam_date.Checked = True
            End If

            If config.IsNull(dt.Rows(0)("steam_time"), Nothing) = Nothing Then
                dtpsteam_time.Value = CDate("01/01/1900")
                dtpsteam_time.Checked = False
            Else
                dtpsteam_time.Value = CDate("01/01/1900") + dt.Rows(0)("steam_time")
                dtpsteam_time.Checked = True
            End If

            txtbar_weight.Text = config.IsNull(dt.Rows(0)("bar_weight"), 0)
            txtgwth.Text = CInt(config.IsNull(dt.Rows(0)("gwth"), 0))
            txtlot.Text = config.IsNull(dt.Rows(0)("lot"), String.Empty)
            txtgrade_bdt.Text = config.IsNull(dt.Rows(0)("grade_bdt"), String.Empty)
            txtgrade_adt.Text = config.IsNull(dt.Rows(0)("grade_adt"), String.Empty)
            chkcliped.Checked = clsconfig.IsNull((dt.Rows(0)("cliped")), False)
            txtwork_shift.Text = dt.Rows(0)("shift").ToString.Trim

            If config.IsNull(dt.Rows(0)("ProdFinishDate"), CDate("01/01/1900")) = CDate("01/01/1900") Then
                dtpProdFinishDate.Value = CDate("01/01/1900")
                dtpProdFinishDate.Checked = False
            Else
                dtpProdFinishDate.Value = dt.Rows(0)("ProdFinishDate")
                dtpProdFinishDate.Checked = True
            End If

            If config.IsNull(dt.Rows(0)("ProdFinishTime"), Nothing) = Nothing Then
                dtpProdFinishTime.Value = CDate("01/01/1900")
                dtpProdFinishTime.Checked = False
            Else
                dtpProdFinishTime.Value = CDate("01/01/1900") + dt.Rows(0)("ProdFinishTime")
                dtpProdFinishTime.Checked = True
            End If

            chkdyeing_pass.Checked = clsconfig.IsNull(dt.Rows(0)("dyeing_pass"), False)
            txtadjust_loss_kg.Text = clsconfig.IsNull(dt.Rows(0)("adjust_loss_kg"), 0)
            txtqc_loss_kg.Text = clsconfig.IsNull(dt.Rows(0)("qc_loss_kg"), 0)
            txtdyed_loss_kg.Text = clsconfig.IsNull(dt.Rows(0)("dyed_loss_kg"), 0)
            txtlab_loss_kg.Text = clsconfig.IsNull(dt.Rows(0)("lab_loss_kg"), 0)
            txtdefect_loss_kg.Text = clsconfig.IsNull(dt.Rows(0)("defect_loss_kg"), 0)

            txttran_no.Text = clsconfig.IsNull(dt.Rows(0)("tran_no"), "")
            If config.IsNull(dt.Rows(0)("tran_dt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
                dtptran_dt.Value = CDate("01/01/1900")
                dtptran_dt.Checked = False
            Else
                dtptran_dt.Value = dt.Rows(0)("tran_dt")
                dtptran_dt.Checked = True
            End If

            cbomtl_warehouse.SelectedValue = clsconfig.IsNull(dt.Rows(0)("mtl_warehouse_id"), 1)
            bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) & "'"
            cbomtl_subinventory.SelectedValue = clsconfig.IsNull(dt.Rows(0)("mtl_subinventory_id"), 1)
            bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0) & "'"
            cbomtl_location.SelectedValue = clsconfig.IsNull(dt.Rows(0)("mtl_locations_id"), 794)

            txtcounter_per_roll.Text = clsconfig.IsNull(dt.Rows(0)("counter_per_roll"), String.Empty)
            txtrpm.Text = clsconfig.IsNull(dt.Rows(0)("rpm"), String.Empty)

        Else
            cbomfg_production_steps_id.SelectedIndex = -1

            txtsystem_lot_number.Text = String.Empty

            txtproduction_order_no.Text = String.Empty
            'txtoperation_name.Text = String.Empty

            txtinventory_item_code.Text = String.Empty
            txtlot_grade.Text = String.Empty
            txtprimary_quantity.Text = String.Empty
            txtsecondary_quantity.Text = String.Empty
            cbomcno.SelectedIndex = -1


            txtcustom_lot_number.Text = String.Empty
            txtqc_remarks.Text = String.Empty
            cbomtl_warehouse.SelectedIndex = -1
            'cbomtl_location.SelectedIndex = -1
            cbomtl_location.SelectedValue = CInt("794")

            txtBOM.Text = String.Empty
            txtsteam_instruction.Text = String.Empty

            txtsteam_condition.Text = String.Empty
            'dtpsteam_date.Value = DateTime.Now.Date
            dtpsteam_date.Value = CDate("01/01/1900")
            dtpsteam_date.Checked = False

            dtpsteam_time.Value = CDate("01/01/1900")
            dtpsteam_time.Checked = False

            txtbar_weight.Text = String.Empty
            txtgwth.Text = String.Empty
            txtlot.Text = String.Empty
            txtgrade_bdt.Text = String.Empty
            txtgrade_adt.Text = String.Empty
            chkcliped.Checked = False
            txtwork_shift.Text = String.Empty

            dtpProdFinishDate.Value = CDate("01/01/1900")
            dtpProdFinishDate.Checked = False

            dtpProdFinishTime.Value = CDate("01/01/1900")
            dtpProdFinishTime.Checked = False

            dtptran_dt.Value = CDate("01/01/1900")
            dtptran_dt.Checked = False

            chkdyeing_pass.Checked = False
            txtadjust_loss_kg.Text = String.Empty
            txtqc_loss_kg.Text = String.Empty
            txtdyed_loss_kg.Text = String.Empty
            txtlab_loss_kg.Text = String.Empty
            txtdefect_loss_kg.Text = String.Empty

            cbomtl_warehouse.SelectedIndex = -1
            cbomtl_location.SelectedIndex = -1

            txtcounter_per_roll.Text = String.Empty
            txtrpm.Text = String.Empty
        End If

        txtsystem_lot_number.SelectAll()

    End Sub


    Private Sub txtsystem_lot_number_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsystem_lot_number.TextChanged

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Call BFSave()
    End Sub

    Private Sub BFSave()

        If Validate_RollNo(txtsystem_lot_number.Text.Trim) Then
            call Save()
        Else
            Call Loaddata("")
        End If

    End Sub
    Private Function Validate_RollNo(Optional ByVal StrRollNo As String = "") As Boolean
        Dim objdb As New classProductionLots
        Dim dt As DataTable = objdb.Validate_RollNo(StrRollNo, clsuser.UserID)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Roll No .: " & StrRollNo & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function
    Private Function Validate_Greige_IN(Optional ByVal StrRollNo As String = "") As Boolean
        Dim objdb As New classProductionLots
        Dim dt As DataTable = objdb.Validate_Greige_IN(StrRollNo, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            btnGreigeIn.Visible = False
            'MessageBox.Show("Roll No .: " & StrRollNo & "............   is Greige In Already!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Else
            btnGreigeIn.Visible = True
            Return False
        End If


    End Function
    Public Function Save() As Boolean
        Dim clsconfig As New clsConfig
        'Dim mfg_production_lots As New mfg_production_lots
        Dim mfg_production_steps As New mfg_production_steps
        Dim classStockGIN_KOManualFromProductionLots As New classStockGIN_KOManualFromProductionLots
        Dim Defect_Roll_Header As New Defect_roll_Header

        mfg_production_lots.mfg_production_lots_id = dtProductionLots.Rows(0)("mfg_production_lots_id")
        mfg_production_lots.system_lot_number = txtsystem_lot_number.Text.Trim
        mfg_production_lots.custom_lot_number = txtcustom_lot_number.Text.Trim
        mfg_production_lots.inventory_item_code = txtinventory_item_code.Text.Trim
        mfg_production_lots.lot_delivered_to_inventory = clsconfig.IsNull(dtProductionLots.Rows(0)("lot_delivered_to_inventory"), String.Empty)
        mfg_production_lots.production_order_no = txtproduction_order_no.Text.Trim
        mfg_production_lots.primary_quantity = txtprimary_quantity.Text.Trim
        mfg_production_lots.secondary_quantity = txtsecondary_quantity.Text.Trim
        mfg_production_lots.created_by = clsconfig.IsNull(dtProductionLots.Rows(0)("created_by"), String.Empty)
        mfg_production_lots.creation_date = clsconfig.IsNull(dtProductionLots.Rows(0)("creation_date"), Nothing)
        mfg_production_lots.last_modified_by = clsuser.UserID
        mfg_production_lots.last_modified_date = Now
        mfg_production_lots.mfg_production_steps_id = clsconfig.IsNull(cbomfg_production_steps_id.SelectedValue, Nothing)
        mfg_production_lots.lot_grade = txtlot_grade.Text.Trim
        mfg_production_lots.qc_remarks = txtqc_remarks.Text.Trim
        mfg_production_lots.mtl_warehouse_id = cbomtl_warehouse.SelectedValue
        mfg_production_lots.mtl_subinventory_id = cbomtl_subinventory.SelectedValue
        mfg_production_lots.mtl_locations_id = cbomtl_location.SelectedValue
        mfg_production_lots.steam_condition = txtsteam_condition.Text.Trim
        mfg_production_lots.steam_date = dtpsteam_date.Value.Date
        mfg_production_lots.steam_time = dtpsteam_time.Value.TimeOfDay
        mfg_production_lots.operator_lot_number = Nothing

        mfg_production_lots.bar_weight = txtbar_weight.Text.Trim
        mfg_production_lots.gwth = txtgwth.Text.Trim
        mfg_production_lots.lot = txtlot.Text.Trim
        mfg_production_lots.grade_bdt = txtgrade_bdt.Text.Trim
        mfg_production_lots.grade_adt = txtgrade_adt.Text.Trim
        mfg_production_lots.lot_grade = txtlot_grade.Text.Trim
        mfg_production_lots.cliped = chkcliped.Checked
        mfg_production_lots.shift = txtwork_shift.Text
        mfg_production_lots.ProdFinishDate = dtpProdFinishDate.Value.Date
        mfg_production_lots.ProdFinishTime = dtpProdFinishTime.Value.TimeOfDay
        mfg_production_lots.dyeing_pass = chkdyeing_pass.Checked
        mfg_production_lots.adjust_loss_kg = txtadjust_loss_kg.Text.Trim
        mfg_production_lots.qc_loss_kg = txtqc_loss_kg.Text.Trim
        mfg_production_lots.dyed_loss_kg = txtdyed_loss_kg.Text.Trim
        mfg_production_lots.lab_loss_kg = txtlab_loss_kg.Text.Trim
        mfg_production_lots.defect_loss_kg = txtdefect_loss_kg.Text.Trim

        mfg_production_lots.message = Nothing


        Defect_Roll_Header.h01_id_defect_roll = 0
        Defect_Roll_Header.h02_roll_no = txtsystem_lot_number.Text
        Defect_Roll_Header.h03_defect_code = Nothing
        Defect_Roll_Header.h04_defect_details = Nothing
        Defect_Roll_Header.h05_stock_code = "G"

        If dtProductionLots.Rows.Count > 0 Then
            'For i = 0 To dtproduction_lots.Rows.Count - 1
            dtProductionLots.Rows(0)("mfg_production_lots_id") = dtProductionLots.Rows(0)("mfg_production_lots_id")
            dtProductionLots.Rows(0)("system_lot_number") = txtsystem_lot_number.Text.Trim
            dtProductionLots.Rows(0)("custom_lot_number") = txtcustom_lot_number.Text.Trim
            dtProductionLots.Rows(0)("inventory_item_code") = txtinventory_item_code.Text.Trim
            dtProductionLots.Rows(0)("lot_delivered_to_inventory") = dtProductionLots.Rows(0)("lot_delivered_to_inventory")
            dtProductionLots.Rows(0)("production_order_no") = txtproduction_order_no.Text.Trim
            dtProductionLots.Rows(0)("primary_quantity") = txtprimary_quantity.Text.Trim
            dtProductionLots.Rows(0)("secondary_quantity") = txtsecondary_quantity.Text.Trim
            dtProductionLots.Rows(0)("created_by") = dtProductionLots.Rows(0)("created_by")
            dtProductionLots.Rows(0)("creation_date") = dtProductionLots.Rows(0)("creation_date")
            dtProductionLots.Rows(0)("last_modified_by") = clsuser.UserID
            dtProductionLots.Rows(0)("last_modified_date") = Now
            dtProductionLots.Rows(0)("mfg_production_steps_id") = clsconfig.IsNull(cbomfg_production_steps_id.SelectedValue, DBNull.Value)
            dtProductionLots.Rows(0)("lot_grade") = txtlot_grade.Text.Trim
            dtProductionLots.Rows(0)("qc_remarks") = txtqc_remarks.Text.Trim
           dtProductionLots.Rows(0)("mtl_warehouse_id") = clsconfig.IsNull(cbomtl_warehouse.SelectedValue, DBNull.Value)
            dtProductionLots.Rows(0)("mtl_subinventory_id") = clsconfig.IsNull(cbomtl_subinventory.SelectedValue, DBNull.Value)
           dtProductionLots.Rows(0)("mtl_locations_id") = clsconfig.IsNull(cbomtl_location.SelectedValue, DBNull.Value)
            dtProductionLots.Rows(0)("steam_condition") = txtsteam_condition.Text.Trim
           dtProductionLots.Rows(0)("steam_date") = IIf(dtpsteam_date.Checked, dtpsteam_date.Value.Date, DBNull.Value)
            dtProductionLots.Rows(0)("steam_time") = IIf(dtpsteam_time.Checked, dtpsteam_time.Value.TimeOfDay, DBNull.Value)
            dtProductionLots.Rows(0)("operator_lot_number") = dtProductionLots.Rows(0)("operator_lot_number")
            dtProductionLots.Rows(0)("operator") = clsconfig.IsNull(cbooperator.SelectedValue, Nothing)
            dtProductionLots.Rows(0)("work_shift") = txtwork_shift.Text.Trim
            dtProductionLots.Rows(0)("bar_weight") = txtbar_weight.Text.Trim
            dtProductionLots.Rows(0)("gwth") = txtgwth.Text.Trim
            dtProductionLots.Rows(0)("lot") = txtlot.Text.Trim
            dtProductionLots.Rows(0)("grade_bdt") = txtgrade_bdt.Text.Trim
            dtProductionLots.Rows(0)("grade_adt") = txtgrade_adt.Text.Trim
            dtProductionLots.Rows(0)("lot_grade") = txtlot_grade.Text.Trim
            dtProductionLots.Rows(0)("cliped") = IIf(chkcliped.Checked, True, False)
            dtProductionLots.Rows(0)("shift") = txtwork_shift.Text.Trim
            dtProductionLots.Rows(0)("ProdFinishDate") = IIf(dtpProdFinishDate.Checked, dtpProdFinishDate.Value.Date, DBNull.Value)
            dtProductionLots.Rows(0)("ProdFinishTime") = IIf(dtpProdFinishTime.Checked, dtpProdFinishTime.Value.TimeOfDay, DBNull.Value)
            dtProductionLots.Rows(0)("mcno") = cbomcno.Text.Trim
            dtProductionLots.Rows(0)("dyeing_pass") = IIf(chkdyeing_pass.Checked, True, False)
            dtProductionLots.Rows(0)("adjust_loss_kg") = txtadjust_loss_kg.Text.Trim
            dtProductionLots.Rows(0)("qc_loss_kg") = txtqc_loss_kg.Text.Trim
            dtProductionLots.Rows(0)("dyed_loss_kg") = txtdyed_loss_kg.Text.Trim
            dtProductionLots.Rows(0)("lab_loss_kg") = txtlab_loss_kg.Text.Trim
            dtProductionLots.Rows(0)("defect_loss_kg") = txtdefect_loss_kg.Text.Trim
            dtProductionLots.Rows(0)("counter_per_roll") = IIf(txtcounter_per_roll.Text.Trim = "", DBNull.Value, txtcounter_per_roll.Text.Trim)
            dtProductionLots.Rows(0)("rpm") = IIf(txtrpm.Text.Trim = "", DBNull.Value, txtrpm.Text.Trim)

        End If

        Dim dv_add As New DataView(dtProductionLots, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dtProductionLots, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView(dtProductionLots, "", "", DataViewRowState.Deleted)

        Dim dtDefect As DataTable = grdDefect.DataSource

        Dim dv_dtDefect_add As New DataView(dtDefect, "", "", DataViewRowState.Added)
        Dim dv_dtDefect_upd As New DataView(dtDefect, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtDefect_del As New DataView(dtDefect, "", "", DataViewRowState.Deleted)

        Dim dv_yarn_in_add As New DataView
        Dim dv_yarn_in_upd As New DataView
        Dim dv_yarn_in_del As New DataView

        If classStockGIN_KOManualFromProductionLots.SavaData(mfg_production_lots:=mfg_production_lots, Defect_Roll_Header:=Defect_Roll_Header _
                                        , dv_yarn_in_add:=dv_yarn_in_add, dv_yarn_in_upd:=dv_yarn_in_upd, dv_yarn_in_del:=dv_yarn_in_del _
                                        , dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del _
                                        , dv_dtDefect_add:=dv_dtDefect_add, dv_dtDefect_upd:=dv_dtDefect_upd, dv_dtDefect_del:=dv_dtDefect_del _
                                        , clsuser:=clsuser) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Call Loaddata(txtsystem_lot_number.Text)
            Return True
        Else
            MessageBox.Show(mfg_production_lots.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If
    End Function

    Private Sub DirectPrint()
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtsystem_lot_number.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)
        Dim margins As New CrystalDecisions.Shared.PageMargins(2, 2, 2, 2) ' Set Margin

        rpt.PrintOptions.ApplyPageMargins(margins)

        Dim objDefaultPrinter As New System.Drawing.Printing.PrinterSettings
        Dim strOldDefaultPrinter As String = "" '= "Microsoft XPS Document Writer"

        If (objDefaultPrinter IsNot Nothing) AndAlso (objDefaultPrinter.IsDefaultPrinter) Then
            strOldDefaultPrinter = objDefaultPrinter.PrinterName

        End If

        '--------- Direct Print ----------------------'
        'If objDefaultPrinter.PrinterName = "SATO CL408e" _
        '    Or objDefaultPrinter.PrinterName = "SATO CL4NX 203dpi" _
        '   Or objDefaultPrinter.PrinterName = "SATOCL4N" _
        '   Or objDefaultPrinter.PrinterName Like "*SATO*" Then
        rpt.PrintToPrinter(1, False, 1, 1)
        Me.Cursor = Cursors.Default
        'Else
        'Call PreviewPrint()
        'Me.Cursor = Cursors.Default
        'End If
        '-----------------------------------------------

        Me.Cursor = Cursors.Default
        objDefaultPrinter.PrinterName = strOldDefaultPrinter

    End Sub

    Private Function PreviewPrint() As Boolean
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Function
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtsystem_lot_number.Text)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default

        PreviewPrint = True
    End Function

    Private _ToolTip As New ToolTip()

    Private Sub txtcustom_lot_number_MouseHover(sender As Object, e As System.EventArgs) Handles txtcustom_lot_number.MouseHover
        _ToolTip.Show("fill down 'n' For Auto Gen Factory Roll No.", txtcustom_lot_number)
    End Sub
    Private Sub txtcustom_lot_number_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcustom_lot_number.TextChanged
        'Private _ToolTip As New ToolTip()


    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnSave_2_Click(sender As System.Object, e As System.EventArgs) Handles btnSave_2.Click
        Call BFSave()
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        Call PrintBarcode()
        'Dim clsConfig As New clsConfig
        'Dim rptFileName = "rptGreigeBarcode.rpt"
        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        ''clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        'If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        'Dim frm As New frmReport
        'Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        'Dim stype As String = ""
        'Dim ord As String = ""
        'Me.Cursor = Cursors.WaitCursor

        'rpt.Load(clsuser.ReportPath & rptFileName)
        'rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        'rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        'rpt.VerifyDatabase()
        'rpt.SetParameterValue("@roll_no", txtsystem_lot_number.Text.ToString)
        'rpt.SetParameterValue("@loc", "")
        'rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        ''rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        ''rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        ''rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.Title = "Greige Barcode"
        'frm.CRViewer.ReportSource = rpt
        'frm.MdiParent = Me.ParentForm
        'frm.Show()
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub PrintBarcode()
        Dim clsConfig As New clsConfig
        Dim rptFileName = "rptGreigeBarcode.rpt"
        If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        'clsUser.ReportPath = "C:\Users\DELL\Desktop\GemmaKnits\"
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@roll_no", txtsystem_lot_number.Text.ToString)
        rpt.SetParameterValue("@loc", "")
        rpt.SetParameterValue("@logempcd", UserInfo.UserID)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        frm.Title = "Greige Barcode"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnApply_Click(sender As System.Object, e As System.EventArgs) Handles btnApply.Click
        ApplyData()
    End Sub

    Private Sub ApplyData()
        Dim config As New clsConfig
        If cbodefect_code.SelectedIndex = -1 Then
            MessageBox.Show("System Message!", "ต้องเลือก Defect Code ก่อน", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If
        If txtdefect_details.Text.Trim.Length = 0 Then
            MessageBox.Show("System Message!", "ต้องใส่จำนวน Defect ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Exit Sub
        End If


        'If cboproperty.SelectedIndex = -1 Then Exit Sub

        grdDefect.AutoGenerateColumns = False

        Dim dt2 As DataTable = grdDefect.DataSource

        Dim dr As DataRow

        Dim msg As String = ""
        Dim i As Integer = 0
        Dim j As Integer = 0

        If CheckDuplicate(Me.cbodefect_code.SelectedValue.ToString, Me.txtdefect_details.Text, dt2) Then
            MessageBox.Show("ข้อมูลซ้ำกัน", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        dr = dt2.NewRow



        For j = 0 To dt2.Columns.Count - 1
            dr("defect_code") = Me.cbodefect_code.SelectedValue
            dr("defect_details") = Me.txtdefect_details.Text

        Next
        dt2.Rows.Add(dr)

    End Sub

    Private Function CheckDuplicate(ByVal defect_code As String, ByVal defect_details As String, ByVal dt As DataTable) As Boolean
        If dt.Rows.Count > 0 Then
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).RowState <> DataRowState.Deleted Then
                    If dt.Rows(i)("defect_code").ToString.Trim = defect_code.Trim Then
                        Return True
                    End If
                End If
            Next
        End If
        Return False
    End Function

    Private Sub btnGreigeIn_Click(sender As System.Object, e As System.EventArgs) Handles btnGreigeIn.Click
        Call SaveGreigeIN()
    End Sub

    Private Sub SaveGreigeIN()
        If Not (Validate_RollNo(txtsystem_lot_number.Text.Trim)) Then Exit Sub

        If SaveGINKOManual() Then
            If txtsystem_lot_number.Text.Trim.Length > 0 Then
                blnCancel = False
                Dim result As Windows.Forms.DialogResult
                result = MessageBox.Show("Would you like to Direct print ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                If result = Windows.Forms.DialogResult.Yes Then DirectPrint()
            End If
            blnCancel = False
            Call Loaddata(txtsystem_lot_number.Text)
        Else
            Call Loaddata("")
        End If

    End Sub

    Private Function SaveGINKOManual(Optional ByVal strGINNO As String = "") As Boolean
        Dim config As New clsConfig
        config.ChangeCulture()
        Dim objDB As New classStockGIN_KOManual
        Dim Greige_Header As New classStockGIN_KOManual.Greige_Header
        Dim Defect_Roll_Header As New classStockGIN_KOManual.Defect_roll_Header

        Dim msgerr As String = ""
        Dim Tran_no As String = strGINNO
        Dim Roll_no As String = txtsystem_lot_number.Text.Trim
        Dim someDateAndTime As Date = #1/1/1900 1:12:00 PM#

        Greige_Header.h01_suppcd = config.IsNull(dtProductionLots.Rows(0)("suppcd"), "GK")
        Greige_Header.h02_source = config.IsNull(dtProductionLots.Rows(0)("source"), Nothing)
        Greige_Header.h03_source_refno = config.IsNull(dtProductionLots.Rows(0)("source_refno"), Nothing)
        Greige_Header.h04_tran_no = txttran_no.Text
        Greige_Header.h05_tran_dt = dtptran_dt.Value
        Greige_Header.h06_design_no = txtinventory_item_code.Text
        Greige_Header.h07_supdes_no = config.IsNull(dtProductionLots.Rows(0)("supdes_no"), Nothing)
        Greige_Header.h08_kono = txtproduction_order_no.Text
        Greige_Header.h09_pieces = config.IsNull(dtProductionLots.Rows(0)("pieces"), Nothing)
        Greige_Header.h10_nob = config.IsNull(dtProductionLots.Rows(0)("nob"), Nothing)
        Greige_Header.h11_Gwth = txtgwth.Text
        Greige_Header.h12_Gwth_actual = config.IsNull(dtProductionLots.Rows(0)("Gwth_actual"), Nothing)
        Greige_Header.h13_roll_no = txtsystem_lot_number.Text
        Greige_Header.h14_roll_no_g = config.IsNull(dtProductionLots.Rows(0)("roll_no_g"), Nothing)
        Greige_Header.h15_roll_no_n = config.IsNull(dtProductionLots.Rows(0)("roll_no_n"), Nothing)
        Greige_Header.h16_racks = config.IsNull(dtProductionLots.Rows(0)("racks"), Nothing)
        Greige_Header.h17_kg = config.IsValidDouble(txtprimary_quantity.Text.Trim)
        Greige_Header.h18_mts = config.IsValidDouble(txtsecondary_quantity.Text.Trim)
        Greige_Header.h19_yds = config.IsValidDouble(txtsecondary_quantity.Text.Trim) / 0.9144
        Greige_Header.h20_kg_qc = config.IsValidDouble(txtprimary_quantity.Text.Trim) - config.IsValidDouble(txtbar_weight.Text.Trim)
        Greige_Header.h21_mts_qc = config.IsValidDouble(txtsecondary_quantity.Text.Trim)
        Greige_Header.h22_yds_qc = config.IsValidDouble(txtsecondary_quantity.Text.Trim) / 0.9144
        Greige_Header.h23_grade = config.IsValidDouble(txtgrade_bdt.Text)
        Greige_Header.h24_rem_qc = txtqc_remarks.Text.Trim
        Greige_Header.h25_loc = cbomtl_location.Text.Trim
        Greige_Header.h26_outreqno = config.IsNull(dtProductionLots.Rows(0)("outreqno"), Nothing)
        Greige_Header.h27_outreqdt = config.IsNull(dtProductionLots.Rows(0)("outreqdt"), Nothing)
        Greige_Header.h28_outreqtyp = config.IsNull(dtProductionLots.Rows(0)("outreqtyp"), Nothing)
        Greige_Header.h29_outno = config.IsNull(dtProductionLots.Rows(0)("outno"), Nothing)
        Greige_Header.h30_outdt = config.IsNull(dtProductionLots.Rows(0)("outdt"), Nothing)
        Greige_Header.h31_lot = txtlot.Text.Trim
        Greige_Header.h32_yr = config.IsNull(dtProductionLots.Rows(0)("yr"), Nothing)
        Greige_Header.h33_sh = config.IsNull(dtProductionLots.Rows(0)("sh"), Nothing)
        Greige_Header.h34_dfno = config.IsNull(dtProductionLots.Rows(0)("dfno"), Nothing)
        Greige_Header.h35_col = config.IsNull(dtProductionLots.Rows(0)("col"), Nothing)
        Greige_Header.h36_dhcod = config.IsNull(dtProductionLots.Rows(0)("dhcod"), Nothing)
        Greige_Header.h37_sono = config.IsNull(dtProductionLots.Rows(0)("sono"), Nothing)
        Greige_Header.h38_sonoid = config.IsNull(dtProductionLots.Rows(0)("sonoid"), Nothing)
        Greige_Header.h39_roll_no_o = config.IsNull(txtcustom_lot_number.Text.Trim, "")
        Greige_Header.h40_pn = config.IsNull(dtProductionLots.Rows(0)("pn"), Nothing)
        Greige_Header.h41_ydkg_g = config.IsNull(dtProductionLots.Rows(0)("ydkg_g"), Nothing)
        Greige_Header.h42_cost = config.IsNull(dtProductionLots.Rows(0)("cost"), Nothing)
        Greige_Header.h43_fload = config.IsNull(dtProductionLots.Rows(0)("fload"), Nothing)
        Greige_Header.h44_rate = config.IsNull(dtProductionLots.Rows(0)("rate"), Nothing)
        Greige_Header.h45_sel = config.IsNull(dtProductionLots.Rows(0)("sel"), Nothing)
        Greige_Header.h46_cost_g = config.IsNull(dtProductionLots.Rows(0)("cost_g"), Nothing)
        Greige_Header.h47_cliped = chkcliped.Checked
        Greige_Header.h48_unit = config.IsNull(dtProductionLots.Rows(0)("unit"), Nothing)
        Greige_Header.h49_g_cost = config.IsNull(dtProductionLots.Rows(0)("g_cost"), Nothing)
        Greige_Header.h50_tran_no1 = config.IsNull(txttran_no.Text.Trim, "")
        Greige_Header.h51_tran_not = config.IsNull(txttran_no.Text, "")
        Greige_Header.h52_cancel = config.IsNull(dtProductionLots.Rows(0)("cancel"), Nothing)
        Greige_Header.h53_doctyp = config.IsNull(dtProductionLots.Rows(0)("doctyp"), Nothing)
        Greige_Header.h54_preseted = config.IsNull(dtProductionLots.Rows(0)("preseted"), Nothing)
        Greige_Header.h55_qcalertcd = config.IsNull(dtProductionLots.Rows(0)("qcalertcd"), Nothing)
        Greige_Header.h56_ProdFinishDate = config.IsValidDate(dtpProdFinishDate.Value)
        Greige_Header.h57_ProdFinishTime = (dtpProdFinishTime.Text)   ' Try to check again
        Greige_Header.h58_mcno = config.IsNull(cbomcno.Text, "")
        Greige_Header.h59_adjust_loss_kg = txtadjust_loss_kg.Text.Trim
        Greige_Header.h60_qc_loss_kg = txtqc_loss_kg.Text.Trim
        Greige_Header.h61_dyed_loss_kg = txtdyed_loss_kg.Text.Trim
        Greige_Header.h62_grade_bdt = txtgrade_bdt.Text.Trim
        Greige_Header.h63_grade_adt = txtgrade_adt.Text.Trim
        Greige_Header.h64_dyeing_pass = chkdyeing_pass.Checked
        Greige_Header.h65_dyeing_fail = config.IsNull(dtProductionLots.Rows(0)("dyeing_fail"), Nothing)
        Greige_Header.h66_shift = txtwork_shift.Text.Trim
        Greige_Header.h67_id_greige_do = config.IsNull(dtProductionLots.Rows(0)("id_greige_do"), Nothing)
        Greige_Header.h68_id_greige = config.IsNull(dtProductionLots.Rows(0)("id_greige"), Nothing)
        Greige_Header.h69_lab_loss_kg = txtlab_loss_kg.Text.Trim
        Greige_Header.h70_defect_loss_kg = txtdefect_loss_kg.Text.Trim
        Greige_Header.h71_purno = config.IsNull(dtProductionLots.Rows(0)("purno"), Nothing)
        Greige_Header.h72_tran_type = config.IsNull(dtProductionLots.Rows(0)("tran_type"), "KNITTING")
        Greige_Header.h73_roll_no_f = txtsystem_lot_number.Text.Trim
        Greige_Header.h74_job_line_id = config.IsNull(dtProductionLots.Rows(0)("job_line_id"), "")
        Greige_Header.h75_fabric_cost = config.IsNull(dtProductionLots.Rows(0)("fabric_cost"), 0)
        Greige_Header.h76_process_cost = config.IsNull(dtProductionLots.Rows(0)("process_cost"), 0)
        Greige_Header.h77_process_loss_perc = config.IsNull(dtProductionLots.Rows(0)("process_loss_perc"), 0)
        Greige_Header.h78_other_cost = config.IsNull(dtProductionLots.Rows(0)("other_cost"), 0)
        Greige_Header.h79_cost_per_unit = config.IsNull(dtProductionLots.Rows(0)("cost_per_unit"), 0)
        Greige_Header.h80_sub_location = String.Empty 'txtsub_location.Text.Trim
        Greige_Header.h81_greige_status = config.IsNull(dtProductionLots.Rows(0)("greige_status"), 0)
        Greige_Header.h82_bar_weight = txtbar_weight.Text.Trim
        Greige_Header.h83_mtl_warehouse_id = config.IsNull(cbomtl_warehouse.SelectedValue, Nothing)
        Greige_Header.h84_mtl_subinventory_id = config.IsNull(cbomtl_subinventory.SelectedValue, Nothing)
        Greige_Header.h85_mtl_locations_id = config.IsNull(cbomtl_location.SelectedValue, Nothing)
        Greige_Header.h86_counter_per_roll = Convert.ToDecimal(txtcounter_per_roll.Text.Trim)
        Greige_Header.h87_rpm = Convert.ToDecimal(txtrpm.Text.Trim)

        Defect_Roll_Header.h01_id_defect_roll = 0
        Defect_Roll_Header.h02_roll_no = txtsystem_lot_number.Text
        Defect_Roll_Header.h03_defect_code = Nothing
        Defect_Roll_Header.h04_defect_details = Nothing
        Defect_Roll_Header.h05_stock_code = "G"

        Dim dtc As DataTable = grdDefect.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added)
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted)

        blnCancel = False
        Dim result As Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> Windows.Forms.DialogResult.Yes Then Exit Function

        If objDB.GIN_KOManualsave(Greige_Header, Defect_Roll_Header, msgerr, dtc, dv_dtc_add, dv_dtc_upd, dv_dtc_del, clsuser.UserID, Tran_no, Roll_no) Then
            strGINNO = Tran_no
            txttran_no.Text = strGINNO.Trim
            txtsystem_lot_number.Text = Roll_no
            MessageBox.Show("Save is Complete! : บันทึกสำเร็จ! ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            SaveGINKOManual = True
        Else
            MessageBox.Show(msgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            SaveGINKOManual = False
        End If

    End Function

    Private Sub txtgrade_bdt_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtgrade_bdt.TextChanged
        GenLot_Grade()
    End Sub

    Private Sub txtgrade_adt_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtgrade_adt.TextChanged
        GenLot_Grade()
    End Sub

    Private Sub GenLot_Grade()
        txtlot_grade.Text = Trim(txtgrade_bdt.Text) + Trim(txtgrade_adt.Text)
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        bsMtlSubInventory.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) & "'"
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0) & "'"
    End Sub

    Private Sub Bindgrdmtl_Locations(ByVal mtl_Locations As DataTable)

        cbomtl_location.DataSource = Nothing
        cbomtl_location.DataSource = mtl_Locations
        cbomtl_location.ValueMember = "mtl_locations_id"
        cbomtl_location.DisplayMember = "location_name"
    End Sub

    Private Sub cbomtl_warehouse_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_warehouse.SelectedIndexChanged

    End Sub

    Private Sub cbomtl_subinventory_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_subinventory.DropDownClosed
        bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0) & "'"

    End Sub

    Private Sub cbomtl_subinventory_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbomtl_subinventory.SelectedIndexChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        If txtsystem_lot_number.Text.Trim.Length > 0 Then
            blnCancel = False
            Dim result As Windows.Forms.DialogResult
            result = MessageBox.Show("Would you like to Direct print ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result = Windows.Forms.DialogResult.Yes Then DirectPrint()
        End If
    End Sub

    Private Sub cbomtl_subinventory_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbomtl_subinventory.SelectedValueChanged
        ' bsMtlLocations.Filter = "mtl_warehouse_id = '" & (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) & "' and mtl_subinventory_id = '" & (New clsConfig).IsNull(cbomtl_subinventory.SelectedValue, 0) & "'"
    End Sub
End Class