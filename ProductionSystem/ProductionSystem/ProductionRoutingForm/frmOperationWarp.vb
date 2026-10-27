Imports ProductionSystem.Controls

Public Class frmOperationWarp
       Dim clsuser As new classUserInfo
    Dim mfg_production_lots As mfg_production_lots
    Dim KO As KO
    Dim dtMfgProductionLots As New DataTable
    Dim bsMfgProductionLots As New BindingSource
    Dim drvMfgProductionLots As DataRowView

    Dim oConfig As New clsConfig
    Dim strSystemLotNumber As String
    Dim oOperationWarp As New classOperationWarp

    Public Property UserInfo() As classUserInfo
        Get
            UserInfo = clsuser
        End Get
        Set(ByVal NewValue As classUserInfo)
            clsuser = NewValue
        End Set
    End Property

    Public Property pSystemLotNumber As String

        Get
            pSystemLotNumber = mfg_production_lots.system_lot_number
        End Get
        Set(ByVal newvalue As String)
            mfg_production_lots.system_lot_number = newvalue
        End Set

    End Property


    Private Sub frmOperationWarp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call InitControl()

        Me.WindowState = FormWindowState.Maximized
        Call genCombo()
        IIf(oConfig.IsNull(mfg_production_lots.mfg_production_steps_id, Nothing) = Nothing, Nothing, cbomfg_production_steps_id.SelectedValue = mfg_production_lots.mfg_production_steps_id)

        'Call LoadData(mfg_production_lots.system_lot_number)
        Call InitDataBindingYarnInDet()
    End Sub

    Private Sub InitDataBindingYarnInDet()
        dtMfgProductionLots = (New classOperationWarp).GetProductionLots(pSystemLotNumber:=txtsystem_lot_number.Text.Trim)
        bsMfgProductionLots.DataSource = dtMfgProductionLots
        bsMfgProductionLots.MoveFirst()
        drvMfgProductionLots = CType(bsMfgProductionLots.Current, DataRowView)

        Call BinddataProductionLots()
    End Sub

    Private Sub BinddataProductionLots()
        Call ClearDataBindings()
        txtsystem_lot_number.DataBindings.Add("text", bsMfgProductionLots, "system_lot_number")
        Dim clsProductionRouting As New classProductionLots
        txtproduction_order_no.DataBindings.Add("text", bsMfgProductionLots, "production_order_no")
        cbomfg_production_steps_id.DataSource = (New classProductionRouting).Combomfgproductionstep(txtproduction_order_no.Text.Trim, "")
        cbomfg_production_steps_id.DisplayMember = "operation_desc"
        cbomfg_production_steps_id.ValueMember = "mfg_production_steps_id"
        cbomfg_production_steps_id.DataBindings.Add("SelectedValue", bsMfgProductionLots, "mfg_production_steps_id")

        txtinventory_item_code.DataBindings.Add("text", bsMfgProductionLots, "inventory_item_code") '.Text = dtMfgProductionLots.Rows(0)("inventory_item_code")
        cbomcno.DataBindings.Add("SelectedValue", bsMfgProductionLots, "mcno")

        txtBoxRemark.DataBindings.Add("text", bsMfgProductionLots, "box_remark") 'txtBoxRemark.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("box_remark"), Nothing)
        cbooperator.DataBindings.Add("SelectedValue", bsMfgProductionLots, "operator") 'cbooperator.SelectedValue = clsuser.UserID
        txtBOM.DataBindings.Add("text", bsMfgProductionLots, "ynchgcd")   'txtBOM.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("ynchgcd"), String.Empty)
        txtdocno.DataBindings.Add("text", bsMfgProductionLots, "docno") 'txtdocno.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("docno"), "")
        dtpdocdt.DataBindings.Add("text", bsMfgProductionLots, "docdt")
        'If Config.IsNull(dtMfgProductionLots.Rows(0)("docdt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
        '    dtpdocdt.Value = Today ' CDate("01/01/1900") 'Sitthana 20200317
        '    dtpdocdt.Checked = False
        'Else
        '    dtpdocdt.Value = dtMfgProductionLots.Rows(0)("docdt")
        '    dtpdocdt.Checked = True
        'End If
        txtbobbin_weight_before.DataBindings.Add("text", bsMfgProductionLots, "bobbin_weight_before")   'txtbobbin_weight_before.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("bobbin_weight_before"), "0")
        txtbobbin_weight_after.DataBindings.Add("text", bsMfgProductionLots, "bobbin_weight_after") 'txtbobbin_weight_after.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("bobbin_weight_after"), "0")
        txtbobbin_tear_weight.DataBindings.Add("text", bsMfgProductionLots, "bobbin_tear_weight") 'txtbobbin_tear_weight.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("bobbin_tear_weight"), "0")
        txtbeam_tear_weight.DataBindings.Add("text", bsMfgProductionLots, "beam_tear_weight") ' txtbeam_tear_weight.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("beam_tear_weight"), "0")
        txtbeam_total_weight.DataBindings.Add("text", bsMfgProductionLots, "beam_total_weight") 'txtbeam_total_weight.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("beam_total_weight"), "0") 'beam_total_weight
        txtwarped_ends.DataBindings.Add("text", bsMfgProductionLots, "warped_ends") 'txtwarped_ends.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("warped_ends"), "0")
        txtbeams_per_set.DataBindings.Add("text", bsMfgProductionLots, "beams_per_set") 'txtbeams_per_set.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("beams_per_set"), "0")
        txtkg_gr.DataBindings.Add("text", bsMfgProductionLots, "kg_gr") 'txtkg_gr.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("kg_gr"), "0")
        txtactual_cone_weight.DataBindings.Add("text", bsMfgProductionLots, "actual_cone_weight") ' txtactual_cone_weight.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("actual_cone_weight"), "0")
        cbomtl_warehouse.DataBindings.Add("SelectedValue", bsMfgProductionLots, "mtl_warehouse_id")   'cbomtl_warehouse.SelectedValue = Config.IsNull(dtMfgProductionLots.Rows(0)("mtl_warehouse_id"), 4)
        Call GenCboSubInventory()
        CboMtlSubinventory.DataBindings.Add("SelectedValue", bsMfgProductionLots, "mtl_subinventory_id") 'CboMtlSubinventory.SelectedValue = dtMfgProductionLots.Rows(0)("mtl_subinventory_id")
        Call GenCboLocation()
        cbomtl_locations.DataBindings.Add("SelectedValue", bsMfgProductionLots, "mtl_locations_id")  ' cbomtl_locations.SelectedValue = dtMfgProductionLots.Rows(0)("mtl_locations_id")
        txtlotno_sup.DataBindings.Add("text", bsMfgProductionLots, "lotno_sup") 'txtlotno_sup.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("lotno_sup"), "")
        txtlotno_our.DataBindings.Add("text", bsMfgProductionLots, "lotno_our") '  txtlotno_our.Text = Config.IsNull(dtMfgProductionLots.Rows(0)("lotno_our"), "")
        txtBoxno.DataBindings.Add("text", bsMfgProductionLots, "boxno") 'txtBoxno.Text = dtMfgProductionLots.Rows(0)("boxno")
        Call SumTextData()
    End Sub
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

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call SetErrorProvider()

        'Me.WindowState = FormWindowState.Maximized
        'Call Gencbo()
        'IIf(Config.IsNull(mfg_production_lots.mfg_production_steps_id, Nothing) = Nothing, Nothing, cbomfg_production_steps_id.SelectedValue = mfg_production_lots.mfg_production_steps_id)
        'Call LoadData(mfg_production_lots.system_lot_number)

    End Sub

    Private Sub SetControlValue(ByVal Obj As Control)
        If TypeOf Obj Is TextBox Then
            Obj.Text = Obj.Tag

        End If
        If TypeOf Obj Is DateTimePicker Then
            Dim dtp As DateTimePicker = Obj
            dtp.Value = Now
            dtp.Checked = False
        End If
        If TypeOf Obj Is ComboBox Then
            Dim cbo As ComboBox = Obj
            cbo.SelectedIndex = -1
        End If
        If TypeOf Obj Is CheckBox Then
            Dim chk As CheckBox = Obj
            chk.Checked = False
            ' If chk.Name = "chkAutoCalculate" Then chk.Checked = True

        End If
        If TypeOf Obj Is TabControl Or TypeOf Obj Is TabPage Or TypeOf Obj Is GroupBox Then
            Dim obj2 As Control
            For Each obj2 In Obj.Controls
                Call SetControlValue(obj2)
            Next
        End If


        If TypeOf Obj Is MultiColumnComboBox Then
            Dim obj2 As MultiColumnComboBox = Obj
        End If

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
        If TypeOf Obj Is MultiColumnComboBox Then Obj.Enabled = blnEnabled


    End Sub


    Private Sub SetErrorProvider()
        ErrorProvider1.Clear()
    End Sub

    Private Sub SetToolTips()

    End Sub

    Private Function Validate_Yarn_IN(Optional ByVal StrRollNo As String = "") As Boolean
        Dim objconfig As New clsConfig
        Dim objdb As New classProductionLots
        Dim dt As DataTable = objdb.Validate_Yarn_IN(StrRollNo, clsuser.UserID)

        Me.btnYarnIn.Visible = objconfig.UserAccess(clsuser.UserID, "SY0010", "MENU")

        'If dt.Rows.Count > 0 Then
        '    btnYarnIn.Visible = False
        '    'MessageBox.Show("Roll No .: " & StrRollNo & "............   is Greige In Already!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return True
        'Else
        '    btnYarnIn.Visible = True
        '    Return False
        'End If


    End Function

    Private Sub genCombo()
        Dim objdb As New classMaster
        Dim clsProductionRouting As New classProductionRouting
        Dim dt As New DataTable

        cbomfg_production_steps_id.DataSource = clsProductionRouting.Combomfgproductionstep(mfg_production_lots.production_order_no, "")
        cbomfg_production_steps_id.DisplayMember = "mfg_production_steps_id" + "operation_name"
        cbomfg_production_steps_id.ValueMember = "mfg_production_steps_id"

        cbomtl_warehouse.DataSource = objdb.Combomtlwarehouse(clsuser.UserID)
        cbomtl_warehouse.DisplayMember = "warehouse_code"
        cbomtl_warehouse.ValueMember = "mtl_warehouse_id"

        CboMtlSubinventory.DataSource = objdb.GetCombomtl_subinventory(INt64mtl_warehouse_id:=0)
        CboMtlSubinventory.DisplayMember = "subinventory_code"
        CboMtlSubinventory.ValueMember = "mtl_subinventory_id"

        cbomtl_locations.DataSource = objdb.Combomtllocations(strUSerID:=clsuser.UserID,
                                                              pMtlWarehouseId:=0,
                                                              Int64mtl_subinventory_id:=0)
        cbomtl_locations.DisplayMember = "location_name"
        cbomtl_locations.ValueMember = "mtl_locations_id"

        cbooperator.DataSource = (New classOperationWarp).GetComboOperator 'objdb.comboEmployee(clsuser.UserID)
        cbooperator.DisplayMember = "empname"
        cbooperator.ValueMember = "empcd"

        cbomcno.DataSource = objdb.comboMachine(clsuser.UserID)
        cbomcno.DisplayMember = "mcno"
        cbomcno.ValueMember = "mcno"

    End Sub
    Private Sub btnWarping_Click(sender As System.Object, e As System.EventArgs)
        Dim frm2 As New frmOperationKnitting
        frm2.UserInfo = clsuser
        frm2.MdiParent = Me.ParentForm
        frm2.Show()
        Me.Close()
    End Sub

    Private Sub txtProdNo_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            LoadDataLots(Intmfg_production_steps_id:=mfg_production_lots.mfg_production_steps_id, Strproduction_order_no:=txtproduction_order_no.Text.Trim)
        End If
    End Sub



    Private Sub GetData()
        Dim objdb As New classProductionLots
        Dim dt As New DataTable
        dt = objdb.GetProductionLots(Nothing, Nothing, txtproduction_order_no.Text.Trim, UserInfo.UserID)
        'Call LoadData(dt)

    End Sub
    Private Sub LoadData(Optional ByVal strsystem_lot_number As String = Nothing)
        Dim objdb As New classProductionLots

        ' dtYarnInDet = objdb.GetProductionLots(Strsystem_lot_number:=strsystem_lot_number, Intmfg_production_steps_id:=Nothing, Strproduction_order_no:=Nothing, Strlogempcd:=clsuser.UserID)
        dtMfgProductionLots = (New classOperationWarp).GetProductionLots(pSystemLotNumber:=strsystem_lot_number)
        'dtproduction_lots = objdb.GetProductionLotsBySystemRolls(Intmfg_production_lots_id:=Nothing, Strsystem_lot_number:=strsystem_lot_number, Intmfg_production_steps_id:=Nothing, Strproduction_order_no:=Nothing, Strlogempcd:=clsuser.UserID)

        Call BindDataGrid(dtMfgProductionLots)
        Call BindDataText(dtMfgProductionLots)

        'Call Validate_Yarn_IN(txtsystem_lot_number.Text.Trim)

        txtsystem_lot_number.Focus()
    End Sub

    Private Sub BindDataGrid(ByVal dtproduction_lots As DataTable)
        'grdDataLots.AutoGenerateColumns = False
        ' grdDataLots.DataSource = dtproduction_lots

        'Call SumGrdData()
    End Sub

    Private Sub SumTextData()

        If chkAutoCalculate.Checked = False Then Exit Sub

        Dim config As New clsConfig
        Dim i As Integer = 0
        Dim j As Integer = 0


        'Dim dblbobbin_weight_before As Double = Val(txtbobbin_weight_before.Text) '0 'A
        'Dim dblbobbin_weight_after As Double = Val(txtbobbin_weight_after.Text) '0 'B
        'Dim dblwarped_ends As Double = Val(txtwarped_ends.Text) 'D
        Dim dblbeams_per_set As Double = Val(txtbeams_per_set.Text) 'C
        Dim dblbeam_total_weight As Double = Val(txtbeam_total_weight.Text)
        Dim dblactual_cone_weight As Double = Val(txtactual_cone_weight.Text)
        dblactual_cone_weight = dblbeam_total_weight / dblbeams_per_set
        'Dim dblbobbin_tear_weight As Double = config.IsNull(txtbobbin_tear_weight.Text, 0) '0 'C
        'Dim dblbeam_tear_weight As Double = config.IsNull(txtbeam_tear_weight.Text, 0) '0 'D


        ' dblbobbin_tear_weight = dblbobbin_weight_before - dblbobbin_weight_after
        'dblbeam_tear_weight = ((dblbobbin_weight_before - dblbobbin_weight_after) * dblwarped_ends) / dblbeams_per_set
        'dblbeam_total_weight = (dblbobbin_weight_before - dblbobbin_weight_after) * dblwarped_ends

        'txtbobbin_tear_weight.Text = FormatNumber(dblbobbin_tear_weight, 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        'txtbeam_tear_weight.Text = FormatNumber(dblbeam_tear_weight, 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        'txtbeam_total_weight.Text = FormatNumber(dblbeam_total_weight, 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        'txtkg_gr.Text = FormatNumber(dblbeam_total_weight, 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
        txtactual_cone_weight.Text = FormatNumber(dblactual_cone_weight, 3, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
    End Sub

    Private Sub BindDataText(ByVal dtproduction_lots As DataTable)
        Dim clsProductionRouting As New classProductionRouting

        If dtproduction_lots.Rows.Count > 0 Then
            cbomfg_production_steps_id.DataSource = clsProductionRouting.Combomfgproductionstep(dtproduction_lots.Rows(0)("production_order_no"), "")
            cbomfg_production_steps_id.DisplayMember = "operation_desc"
            cbomfg_production_steps_id.ValueMember = "mfg_production_steps_id"
            cbomfg_production_steps_id.SelectedValue = dtproduction_lots.Rows(0).Item("mfg_production_steps_id")
            txtsystem_lot_number.Text = dtproduction_lots.Rows(0).Item("system_lot_number").ToString.Trim
            txtproduction_order_no.Text = dtproduction_lots.Rows(0)("production_order_no")
            txtinventory_item_code.Text = dtproduction_lots.Rows(0)("inventory_item_code")

            If oConfig.IsNull(dtproduction_lots.Rows(0)("mcno").ToString, Nothing) = Nothing Then
                cbomcno.SelectedIndex = -1
            ElseIf oConfig.IsNull(dtproduction_lots.Rows(0)("mcno").ToString, Nothing) <> Nothing Then
                cbomcno.SelectedValue = oConfig.IsNull(dtproduction_lots.Rows(0)("mcno"), Nothing)
            End If

            txtBoxRemark.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("box_remark"), Nothing)
            cbooperator.SelectedValue = clsuser.UserID
            txtBOM.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("ynchgcd"), String.Empty)
            txtdocno.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("docno"), "")
            If oConfig.IsNull(dtproduction_lots.Rows(0)("docdt"), CDate("01/01/1900")) = CDate("01/01/1900") Then
                dtpdocdt.Value = Today ' CDate("01/01/1900") 'Sitthana 20200317
                dtpdocdt.Checked = False
            Else
                dtpdocdt.Value = dtproduction_lots.Rows(0)("docdt")
                dtpdocdt.Checked = True
            End If
            txtbobbin_weight_before.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("bobbin_weight_before"), "0")
            txtbobbin_weight_after.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("bobbin_weight_after"), "0")
            txtbobbin_tear_weight.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("bobbin_tear_weight"), "0")
            txtbeam_tear_weight.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("beam_tear_weight"), "0")
            txtbeam_total_weight.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("beam_total_weight"), "0") 'beam_total_weight
            txtwarped_ends.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("warped_ends"), "0")
            txtbeams_per_set.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("beams_per_set"), "0")
            txtkg_gr.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("kg_gr"), "0")
            txtactual_cone_weight.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("actual_cone_weight"), "0")
            cbomtl_warehouse.SelectedValue = oConfig.IsNull(dtproduction_lots.Rows(0)("mtl_warehouse_id"), 4)
            CboMtlSubinventory.SelectedValue = dtproduction_lots.Rows(0)("mtl_subinventory_id")
            Call GenCboLocation()
            cbomtl_locations.SelectedValue = dtproduction_lots.Rows(0)("mtl_locations_id")
            txtlotno_sup.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("lotno_sup"), "")
            txtlotno_our.Text = oConfig.IsNull(dtproduction_lots.Rows(0)("lotno_our"), "")
            txtBoxno.Text = dtproduction_lots.Rows(0)("boxno")
            Call SumTextData()
        Else
            'cbomfg_production_steps_id.DataSource = clsProductionRouting.Combomfgproductionstep(dtproduction_lots.Rows(0)("production_order_no"), "")
            'cbomfg_production_steps_id.DisplayMember = "operation_desc"
            'cbomfg_production_steps_id.ValueMember = "mfg_production_steps_id"
            cbomfg_production_steps_id.SelectedIndex = -1

            txtsystem_lot_number.Text = ""

            txtproduction_order_no.Text = ""
            txtinventory_item_code.Text = ""
            cbomcno.SelectedIndex = -1
            cbooperator.SelectedItem = -1
            txtBOM.Text = ""
            dtpdocdt.Value = CDate("01/01/1900")
            dtpdocdt.Checked = False


            txtbobbin_weight_before.Text = String.Empty
            txtbobbin_weight_after.Text = String.Empty
            txtBoxRemark.Text = String.Empty
            txtbeam_tear_weight.Text = String.Empty
            txtbeam_total_weight.Text = String.Empty

            txtwarped_ends.Text = String.Empty
            txtbeams_per_set.Text = String.Empty

            cbomtl_warehouse.SelectedIndex = -1
            GenCboLocation()
            cbomtl_locations.SelectedIndex = -1

            txtkg_gr.Text = 0
            txtactual_cone_weight.Text = 0
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs)
        If txtsystem_lot_number.Text.Trim = "" Then Exit Sub

        Call SumTextData()

        If MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


            If ValidateSetNo(txtsystem_lot_number.Text.Trim) Then
                Call SaveData()
            Else
                Call LoadData("")
            End If

        End If

    End Sub


    Public Function SaveData() As Boolean
        Dim clsconfig As New clsConfig
        Dim mfg_production_steps As New mfg_production_steps
        Dim classProductionLots As New classProductionLots
        Dim Defect_Roll_Header As New Defect_roll_Header
        Dim yarnin As New classOperationWarp.YarnIn

        yarnin.docno = txtdocno.Text.Trim
        yarnin.docdt = dtpdocdt.Value.ToString("yyyy-MM-dd")

        mfg_production_lots.beam_total_weight = Convert.ToDecimal(txtbeam_total_weight.Text.Trim)

        Defect_Roll_Header.h01_id_defect_roll = 0
        Defect_Roll_Header.h02_roll_no = txtsystem_lot_number.Text
        Defect_Roll_Header.h03_defect_code = Nothing
        Defect_Roll_Header.h04_defect_details = Nothing
        Defect_Roll_Header.h05_stock_code = "Y"

        Dim i = 0
        For i = 0 To dtMfgProductionLots.Rows.Count - 1
            With dtMfgProductionLots.Rows

                dtMfgProductionLots.Rows(0)("system_lot_number") = txtsystem_lot_number.Text.Trim
                dtMfgProductionLots.Rows(0)("inventory_item_code") = txtinventory_item_code.Text.Trim
                dtMfgProductionLots.Rows(0)("lot_delivered_to_inventory") = dtMfgProductionLots.Rows(0)("lot_delivered_to_inventory")
                dtMfgProductionLots.Rows(0)("primary_quantity") = dtMfgProductionLots.Rows(0)("primary_quantity")
                dtMfgProductionLots.Rows(0)("secondary_quantity") = dtMfgProductionLots.Rows(0)("secondary_quantity")
                dtMfgProductionLots.Rows(0)("production_order_no") = txtproduction_order_no.Text.Trim
                dtMfgProductionLots.Rows(0)("created_by") = dtMfgProductionLots.Rows(0)("created_by")
                dtMfgProductionLots.Rows(0)("creation_date") = dtMfgProductionLots.Rows(0)("creation_date")
                dtMfgProductionLots.Rows(0)("last_modified_by") = clsuser.UserID
                dtMfgProductionLots.Rows(0)("last_modified_date") = Now
                dtMfgProductionLots.Rows(0)("mfg_production_steps_id") = clsconfig.IsNull(cbomfg_production_steps_id.SelectedValue, DBNull.Value)

                dtMfgProductionLots.Rows(0)("docno") = txtdocno.Text.Trim
                dtMfgProductionLots.Rows(0)("docdt") = dtpdocdt.Text.Trim

                dtMfgProductionLots.Rows(0)("beam_length") = dtMfgProductionLots.Rows(0)("beam_length")
                dtMfgProductionLots.Rows(0)("weight_before_warp") = dtMfgProductionLots.Rows(0)("weight_before_warp")
                dtMfgProductionLots.Rows(0)("warp_speed") = dtMfgProductionLots.Rows(0)("warp_speed")
                dtMfgProductionLots.Rows(0)("tension_h") = dtMfgProductionLots.Rows(0)("tension_h")
                dtMfgProductionLots.Rows(0)("tension_per_g") = dtMfgProductionLots.Rows(0)("tension_per_g")
                dtMfgProductionLots.Rows(0)("tape_layer") = dtMfgProductionLots.Rows(0)("tape_layer")
                dtMfgProductionLots.Rows(0)("bobbin_weight_before") = txtbobbin_weight_before.Text.Trim
                dtMfgProductionLots.Rows(0)("bobbin_weight_after") = txtbobbin_weight_after.Text.Trim
                dtMfgProductionLots.Rows(0)("bobbin_tear_weight") = Val(txtbobbin_tear_weight.Text.Trim)
                dtMfgProductionLots.Rows(0)("beam_tear_weight") = Val(txtbeam_tear_weight.Text.Trim)
                dtMfgProductionLots.Rows(0)("beam_total_weight") = Convert.ToDecimal(txtbeam_total_weight.Text.Trim)
                dtMfgProductionLots.Rows(0)("waste_yarn") = dtMfgProductionLots.Rows(0)("waste_yarn")
                dtMfgProductionLots.Rows(0)("warping_time") = dtMfgProductionLots.Rows(0)("warping_time")

                dtMfgProductionLots.Rows(0)("beam_total_weight") = Convert.ToDecimal(txtbeam_total_weight.Text.Trim) 'FormatNumber(txtbeam_total_weight.Text.Trim, 2, TriState.False, TriState.False, TriState.True)
                dtMfgProductionLots.Rows(0)("beams_per_set") = txtbeams_per_set.Text.Trim

                dtMfgProductionLots.Rows(0)("kg_gr") = Convert.ToDecimal(txtkg_gr.Text.Trim) '
                dtMfgProductionLots.Rows(0)("actual_cone_weight") = Convert.ToDecimal(txtactual_cone_weight.Text.Trim) '

                dtMfgProductionLots.Rows(0)("mtl_warehouse_id") = cbomtl_warehouse.SelectedValue
                dtMfgProductionLots.Rows(0)("mtl_subinventory_id") = CboMtlSubinventory.SelectedValue
                dtMfgProductionLots.Rows(0)("mtl_locations_id") = cbomtl_locations.SelectedValue

                dtMfgProductionLots.Rows(0)("lotno_sup") = dtMfgProductionLots.Rows(0)("lotno_sup")
                dtMfgProductionLots.Rows(0)("lotno_our") = dtMfgProductionLots.Rows(0)("lotno_our")


                dtMfgProductionLots.Rows(0)("inventory_item_code") = txtinventory_item_code.Text.Trim
                dtMfgProductionLots.Rows(0)("qc_remarks") = txtBoxRemark.Text.Trim

            End With

        Next

        Dim dv_add As New DataView(dtMfgProductionLots, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dtMfgProductionLots, "", "", DataViewRowState.ModifiedCurrent)



        Dim dv_del As New DataView(dtMfgProductionLots, "", "", DataViewRowState.Deleted)


        Dim dtYarnIn As New DataTable '= GenYarnInTable(dtproduction_lots)

        Dim dv_yarn_in_add As New DataView(dtYarnIn, "", "", DataViewRowState.Added)
        Dim dv_yarn_in_upd As New DataView(dtYarnIn, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_yarn_in_del As New DataView(dtYarnIn, "", "", DataViewRowState.Deleted)

        Dim dtDefect As New DataTable '= grdDefect.DataSource

        Dim dv_dtDefect_add As New DataView(dtDefect, "", "", DataViewRowState.Added)
        Dim dv_dtDefect_upd As New DataView(dtDefect, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtDefect_del As New DataView(dtDefect, "", "", DataViewRowState.Deleted)

        If classProductionLots.SavaData(mfg_production_lots:=mfg_production_lots, Defect_Roll_Header:=Defect_Roll_Header, dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, dv_yarn_in_add:=dv_yarn_in_add, dv_yarn_in_upd:=dv_yarn_in_upd, dv_yarn_in_del:=dv_yarn_in_del, dv_dtDefect_add:=dv_dtDefect_add, dv_dtDefect_upd:=dv_dtDefect_upd, dv_dtDefect_del:=dv_dtDefect_del, clsuser:=clsuser) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Call LoadData(txtsystem_lot_number.Text)
            Return True
        Else
            MessageBox.Show(mfg_production_lots.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

    End Function


    Public Function SaveYarnIn() As Boolean

        Call SumTextData()

        Dim clsconfig As New clsConfig
        Dim mfg_production_steps As New mfg_production_steps
        Dim classProductionLots As New classProductionLots
        Dim Defect_Roll_Header As New Defect_roll_Header
        Dim message As String = ""
        Dim pYarnIn As New classOperationWarp.YarnIn
        pYarnIn.docno = txtdocno.Text.Trim
        pYarnIn.docdt = dtpdocdt.Value.Date

        Defect_Roll_Header.h01_id_defect_roll = 0
        Defect_Roll_Header.h02_roll_no = txtsystem_lot_number.Text
        Defect_Roll_Header.h03_defect_code = Nothing
        Defect_Roll_Header.h04_defect_details = Nothing
        Defect_Roll_Header.h05_stock_code = "Y"


        'ModifiedCurrent
        'For Each dr As DataRow In dtproduction_lots.Rows
        '    If dr.RowState <> DataRowState.Deleted Then
        '        dr("system_lot_number") = txtsystem_lot_number.Text.Trim
        '    End If
        'Next

        Dim i = 0
        For i = 0 To dtMfgProductionLots.Rows.Count - 1
            With dtMfgProductionLots.Rows

                '-------------------------------------------------------------------------------------------------
                dtMfgProductionLots.Rows(0)("system_lot_number") = txtsystem_lot_number.Text.Trim
                dtMfgProductionLots.Rows(0)("inventory_item_code") = txtinventory_item_code.Text.Trim
                dtMfgProductionLots.Rows(0)("lot_delivered_to_inventory") = dtMfgProductionLots.Rows(0)("lot_delivered_to_inventory")
                dtMfgProductionLots.Rows(0)("primary_quantity") = dtMfgProductionLots.Rows(0)("primary_quantity")
                dtMfgProductionLots.Rows(0)("secondary_quantity") = dtMfgProductionLots.Rows(0)("secondary_quantity")
                dtMfgProductionLots.Rows(0)("production_order_no") = txtproduction_order_no.Text.Trim
                dtMfgProductionLots.Rows(0)("created_by") = dtMfgProductionLots.Rows(0)("created_by")
                dtMfgProductionLots.Rows(0)("creation_date") = dtMfgProductionLots.Rows(0)("creation_date")
                dtMfgProductionLots.Rows(0)("last_modified_by") = clsuser.UserID
                dtMfgProductionLots.Rows(0)("last_modified_date") = Now
                dtMfgProductionLots.Rows(0)("mfg_production_steps_id") = clsconfig.IsNull(cbomfg_production_steps_id.SelectedValue, DBNull.Value)

                dtMfgProductionLots.Rows(0)("docno") = txtdocno.Text.Trim
                ' dtproduction_lots.Rows(0)("docdt") = dtpdocdt.Text.Trim
                dtMfgProductionLots.Rows(0)("docdt") = dtpdocdt.Value.Date
                dtMfgProductionLots.Rows(0)("boxno") = txtBoxno.Text.Trim
                dtMfgProductionLots.Rows(0)("beam_length") = dtMfgProductionLots.Rows(0)("beam_length")
                dtMfgProductionLots.Rows(0)("weight_before_warp") = dtMfgProductionLots.Rows(0)("weight_before_warp")
                dtMfgProductionLots.Rows(0)("warp_speed") = dtMfgProductionLots.Rows(0)("warp_speed")
                dtMfgProductionLots.Rows(0)("tension_h") = dtMfgProductionLots.Rows(0)("tension_h")
                dtMfgProductionLots.Rows(0)("tension_per_g") = dtMfgProductionLots.Rows(0)("tension_per_g")
                dtMfgProductionLots.Rows(0)("tape_layer") = dtMfgProductionLots.Rows(0)("tape_layer")
                dtMfgProductionLots.Rows(0)("bobbin_weight_before") = Val(txtbobbin_weight_before.Text)
                dtMfgProductionLots.Rows(0)("bobbin_weight_after") = Val(txtbobbin_weight_after.Text)
                dtMfgProductionLots.Rows(0)("bobbin_tear_weight") = Convert.ToDecimal(0)
                dtMfgProductionLots.Rows(0)("beam_tear_weight") = Convert.ToDecimal(Val(txtbeam_tear_weight.Text.Trim))
                dtMfgProductionLots.Rows(0)("beam_total_weight") = Convert.ToDecimal(Val(txtbeam_total_weight.Text.Trim))
                dtMfgProductionLots.Rows(0)("waste_yarn") = dtMfgProductionLots.Rows(0)("waste_yarn")
                dtMfgProductionLots.Rows(0)("warping_time") = dtMfgProductionLots.Rows(0)("warping_time")

                dtMfgProductionLots.Rows(0)("beam_total_weight") = Convert.ToDecimal(Val(txtbeam_total_weight.Text.Trim)) 'FormatNumber(txtbeam_total_weight.Text.Trim, 2, TriState.False, TriState.False, TriState.True)
                dtMfgProductionLots.Rows(0)("beams_per_set") = txtbeams_per_set.Text.Trim

                dtMfgProductionLots.Rows(0)("kg_gr") = Convert.ToDecimal(txtkg_gr.Text.Trim)
                dtMfgProductionLots.Rows(0)("actual_cone_weight") = Convert.ToDecimal(Val(txtactual_cone_weight.Text.Trim))

                dtMfgProductionLots.Rows(0)("mtl_warehouse_id") = (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, DBNull.Value)
                dtMfgProductionLots.Rows(0)("mtl_subinventory_id") = (New clsConfig).IsNull(CboMtlSubinventory.SelectedValue, DBNull.Value)
                dtMfgProductionLots.Rows(0)("mtl_locations_id") = (New clsConfig).IsNull(cbomtl_locations.SelectedValue, DBNull.Value)

                dtMfgProductionLots.Rows(0)("lotno_sup") = txtlotno_sup.Text
                dtMfgProductionLots.Rows(0)("lotno_our") = txtlotno_our.Text

                dtMfgProductionLots.Rows(0)("box_remark") = txtBoxRemark.Text.Trim

            End With

        Next


        Dim dv_add As New DataView '(dtproduction_lots, "", "", DataViewRowState.Added)
        Dim dv_upd As New DataView(dtMfgProductionLots, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_del As New DataView '(dtproduction_lots, "", "", DataViewRowState.Deleted)

        'Dim dtYarnIn As DataTable = GenYarnInTable(dtproduction_lots)

        Dim dv_yarn_in_add As New DataView(dtMfgProductionLots, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_yarn_in_upd As New DataView '(dtYarnIn, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_yarn_in_del As New DataView '(dtYarnIn, "", "", DataViewRowState.Deleted)

        Dim dtDefect As New DataTable '= grdDefect.DataSource

        Dim dv_dtDefect_add As New DataView(dtDefect, "", "", DataViewRowState.Added)
        Dim dv_dtDefect_upd As New DataView(dtDefect, "", "", DataViewRowState.ModifiedCurrent)
        Dim dv_dtDefect_del As New DataView(dtDefect, "", "", DataViewRowState.Deleted)

        'If classProductionLots.SavaData(mfg_production_lots:=mfg_production_lots, Defect_Roll_Header:=Defect_Roll_Header, dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, dv_yarn_in_add:=dv_yarn_in_add, dv_yarn_in_upd:=dv_yarn_in_upd, dv_yarn_in_del:=dv_yarn_in_del, dv_dtDefect_add:=dv_dtDefect_add, dv_dtDefect_upd:=dv_dtDefect_upd, dv_dtDefect_del:=dv_dtDefect_del, clsuser:=clsuser) Then
        If (New classOperationWarp).SavaData(YarnIn:=pYarnIn, dtYarnInDet:=dtMfgProductionLots, message:=message, logempcd:=clsuser.UserID) Then
            MessageBox.Show("บันทึกสำเร็จ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            'Call LoadData(txtsystem_lot_number.Text)
            Call InitDataBindingYarnInDet()
            Return True
        Else
            'MessageBox.Show(mfg_production_lots.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            MessageBox.Show(message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

    End Function

    Private Function GenYarnInTable(ByVal dt As DataTable) As DataTable
        Dim config As New clsConfig
        'If txtDFNo.Text = "" Then Exit Function
        'Dim k As Integer = 0
        Dim DtProductionLot As DataTable = dt
        Dim DtYarnIn As New DataTable

        'grdData.AutoGenerateColumns = False
        If DtProductionLot.Rows.Count > 0 Then
            'Dim dt1 As DataTable = dt
            'Dim dt2 As New DataTable '= grdData.DataSource
            DtYarnIn.Columns.Add("docdt")
            DtYarnIn.Columns.Add("docno")
            DtYarnIn.Columns.Add("jobno")
            DtYarnIn.Columns.Add("purno")
            DtYarnIn.Columns.Add("sinvno")
            DtYarnIn.Columns.Add("sinvdt")
            DtYarnIn.Columns.Add("suppcd")
            DtYarnIn.Columns.Add("lotno_sup")
            DtYarnIn.Columns.Add("lotno_our")
            DtYarnIn.Columns.Add("srefno")
            DtYarnIn.Columns.Add("totkg")
            DtYarnIn.Columns.Add("curr")
            DtYarnIn.Columns.Add("exrt")
            DtYarnIn.Columns.Add("vat")
            DtYarnIn.Columns.Add("vatamt")
            DtYarnIn.Columns.Add("taxper")
            DtYarnIn.Columns.Add("taxamt")

            DtYarnIn.Columns.Add("boxno")

            'dt1.Columns.Add("mtl_warehouse_id")

            Dim dr As DataRow

            Dim msg As String = ""
            Dim i As Integer = 0
            Dim j As Integer = 0



            For i = 0 To dt.Rows.Count - 1

                'If dt1.Rows(i)("dfno") = dt2.Rows(i)("dfno") Then Exit Sub
                'If CheckDuplicate(config.IsNull(dt.Rows(i)("outno"), ""), config.IsNull(dt.Rows(i)("roll_no_o"), ""), dt2) Then
                '    MessageBox.Show("ใส่ข้อมูลซ้ำกันไม่ได้", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                '    Exit Function
                'End If

                dr = DtYarnIn.NewRow

                For j = 0 To DtYarnIn.Columns.Count - 1



                    dr("boxno") = DtProductionLot.Rows(i)("system_lot_number")
                    'dr.Item("mtl_locations_id") = dt1.Rows(i)("mtl_locations_id") '.ToString '.Rows(i)("mtl_locations_id")
                    'dr.Item("mtl_warehouse_id") = dt1.Rows(i)("mtl_warehouse_id") '.ToString 'dt1.Rows(i)("mtl_warehouse_id")
                    'dr("mtl_locations_id") = dt1.Rows(i)("mtl_locations_id")
                    'dr("mtl_warehouse_id") = dt1.Rows(i)("mtl_warehouse_id")

                    'dr("outno") = dt1.Rows(i)("outno")
                    'dr("suppcd") = dt1.Rows(i)("suppcd")
                    'dr("source_refno") = dt1.Rows(i)("source_refno")
                    'dr("dfno") = dt1.Rows(i)("dfno")
                    'dr("design_no") = dt1.Rows(i)("design_no")
                    'dr("gwth") = dt1.Rows(i)("gwth")
                    ''dr("fwth") = dt1.Rows(i)("fwth")
                    'dr("col") = dt1.Rows(i)("col")
                    ''dr("gr") = dt1.Rows(i)("gr")
                    ''dr("custcolor") = dt1.Rows(i)("custcolor")
                    ''dr("roll_no_d") = dt1.Rows(i)("roll_no_d")
                    'dr("roll_no_g") = dt1.Rows(i)("roll_no_g")
                    'dr("roll_no_o") = dt1.Rows(i)("roll_no_o")
                    'dr("sonoid") = dt1.Rows(i)("sonoid")
                    'dr("kg") = dt1.Rows(i)("kg")
                    'dr("mts") = dt1.Rows(i)("mts")
                    'dr("yds") = dt1.Rows(i)("yds")
                    'dr("lot") = dt1.Rows(i)("lot")
                    ''dr("rem_qc") = dt1.Rows(i)("rem_qc") source_refno
                    'dr("roll_no_f") = dt1.Rows(i)("roll_no_f")
                    'dr("mcno") = dt1.Rows(i)("mcno")
                    'dr("kono") = dt1.Rows(i)("kono")
                    'dr("grade") = dt1.Rows(i)("grade")
                    'dr("ProdFinishDate") = dt1.Rows(i)("ProdFinishDate")
                    'dr("ProdFinishTime") = dt1.Rows(i)("ProdFinishTime")
                    'dr("rem_qc") = dt1.Rows(i)("rem_qc")
                Next
                DtYarnIn.Rows.Add(dr)

            Next

        End If


        ' SumGrdData()


        Return DtYarnIn
    End Function


    'Public Function SaveDataLots() As Boolean
    '    Dim classProductionLots As New classProductionLots
    '    Dim Defect_Roll_Header As New Defect_roll_Header
    '    Dim clsconfig As New clsConfig

    '    KO.design_no = txtproduction_order_no.Text.Trim
    '    KO.kono = txtproduction_order_no.Text.Trim

    '    mfg_production_lots.mfg_production_lots_id = Nothing
    '    mfg_production_lots.system_lot_number = String.Empty
    '    mfg_production_lots.custom_lot_number = Nothing
    '    mfg_production_lots.inventory_item_code = KO.design_no
    '    mfg_production_lots.lot_delivered_to_inventory = Nothing
    '    mfg_production_lots.production_order_no = KO.kono
    '    mfg_production_lots.primary_quantity = Nothing
    '    mfg_production_lots.secondary_quantity = Nothing
    '    mfg_production_lots.created_by = clsuser.UserID
    '    mfg_production_lots.creation_date = Now
    '    mfg_production_lots.last_modified_by = clsuser.UserID
    '    mfg_production_lots.last_modified_date = Now
    '    mfg_production_lots.mfg_production_steps_id = Nothing
    '    mfg_production_lots.lot_grade = Nothing
    '    mfg_production_lots.qc_remarks = Nothing
    '    mfg_production_lots.message = Nothing

    '    Dim dv_add As New DataView '(grdDataLots.DataSource, "", "", DataViewRowState.Added)
    '    Dim dv_upd As New DataView '(grdDataLots.DataSource, "", "", DataViewRowState.ModifiedCurrent)
    '    Dim dv_del As New DataView '(grdDataLots.DataSource, "", "", DataViewRowState.Deleted)

    '    Dim dv_yarn_in_add As New DataView
    '    Dim dv_yarn_in_upd As New DataView
    '    Dim dv_yarn_in_del As New DataView

    '    Dim dv_dtDefect_add As New DataView '(grdDefect.DataSource, "", "", DataViewRowState.Added)
    '    Dim dv_dtDefect_upd As New DataView '(grdDefect.DataSource, "", "", DataViewRowState.ModifiedCurrent)
    '    Dim dv_dtDefect_del As New DataView '(grdDefect.DataSource, "", "", DataViewRowState.Deleted)

    '    If classProductionLots.SavaData(mfg_production_lots:=mfg_production_lots, Defect_Roll_Header:=Defect_Roll_Header, dv_add:=dv_add, dv_upd:=dv_upd, dv_del:=dv_del, dv_yarn_in_add:=dv_yarn_in_add, dv_yarn_in_upd:=dv_yarn_in_upd, dv_yarn_in_del:=dv_yarn_in_del, dv_dtDefect_add:=dv_dtDefect_add, dv_dtDefect_upd:=dv_dtDefect_upd, dv_dtDefect_del:=dv_dtDefect_del, clsuser:=clsuser) Then
    '        LoadDataLots(Intmfg_production_steps_id:=mfg_production_lots.mfg_production_steps_id, Strproduction_order_no:=mfg_production_lots.production_order_no)
    '        Return True
    '    Else
    '        MessageBox.Show(mfg_production_lots.message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
    '        Return False
    '    End If
    'End Function

    Private Sub LoadDataLots(ByVal Intmfg_production_steps_id As Nullable(Of Integer), ByVal Strproduction_order_no As String)
        Dim objdb As New classProductionLots
        Dim dt As New DataTable

        dt = objdb.GetProductionLots(Nothing, Intmfg_production_steps_id, Strproduction_order_no)

        'grdDataLots.AutoGenerateColumns = False
        'grdDataLots.DataSource = dt

        If dt.Rows.Count > 0 Then
            txtproduction_order_no.Text = dt.Rows(0)("inventory_item_code").ToString
        End If

        'Call SumgrdDataLots()


    End Sub

    Private Sub txtproduction_order_no_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtproduction_order_no.TextChanged

    End Sub

    Private Sub txtsystem_lot_number_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtsystem_lot_number.KeyDown
        If e.KeyCode = Keys.Enter Then

            If ValidateSetNo(txtsystem_lot_number.Text.Trim) Then
                Call InitDataBindingYarnInDet()
                'Call LoadData(txtsystem_lot_number.Text)
            Else
                Call InitDataBindingYarnInDet()
                'Call LoadData("")
            End If
        End If
    End Sub
    Private Function ValidateSetNo(Optional ByVal StrSetNo As String = "") As Boolean
        Dim objdb As New classProductionLots
        Dim Strmessage As String = ""
        Dim dt As DataTable = objdb.Validate_SetNo(StrSetNo, clsuser.UserID, Strmessage:=Strmessage)
        'If Strmessage.Trim.Length > 0 Then MessageBox.Show(Strmessage, "System Meass")
        If dt.Rows.Count = 0 Then
            If Strmessage.Trim.Length > 0 Then MessageBox.Show(Strmessage, "System Meassage")
            MessageBox.Show("Roll No .: " & StrSetNo & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Function ValidateYout(Optional ByVal StrSetNo As String = "") As Boolean
        Dim objdb As New classProductionLots
        Dim dt As DataTable = objdb.Validate_SetNo(StrSetNo, clsuser.UserID)

        If dt.Rows.Count > 0 Then
            MessageBox.Show("Roll No .: " & StrSetNo & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If


    End Function

    Private Sub txtsystem_lot_number_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtsystem_lot_number.TextChanged

    End Sub

    Private Sub btnYarnIn_Click(sender As System.Object, e As System.EventArgs) Handles btnYarnIn.Click
        bsMfgProductionLots.EndEdit()
        Me.Validate()

        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Save Yarn in?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveYarnIn()

    End Sub

    Private Function CheckData() As Boolean

        If Not ValidateSetNo(txtsystem_lot_number.Text.Trim) Then

            Return False
        End If

        If txtsystem_lot_number.Text.Trim = "" Then

            Return False
        End If

        If (New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณต้องเลือก W/H", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtl_warehouse, "คุณต้องเลือก W/H")
            Return False
        Else
            ErrorProvider1.SetError(cbomtl_warehouse, "")
        End If

        If (New clsConfig).IsNull(CboMtlSubinventory.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณต้องเลือก Sub Inventory", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(CboMtlSubinventory, "คุณต้องเลือก Sub Inventory")
            Return False
        Else
            ErrorProvider1.SetError(CboMtlSubinventory, "")
        End If

        If (New clsConfig).IsNull(cbomtl_locations.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณต้องเลือก Locations", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cbomtl_locations, "คุณต้องเลือก Locations")
            Return False
        Else
            ErrorProvider1.SetError(cbomtl_locations, "")
        End If

        Return True
    End Function

    Private Sub grdDataLots_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub grdDataLots_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Call SumGrdData()
    End Sub

    Private Sub cbomtl_warehouse_DropDownClosed(sender As Object, e As System.EventArgs) Handles cbomtl_warehouse.DropDownClosed
        Call GenCboSubInventory()
        Call GenCboLocation()
    End Sub
    Private Sub GenCboSubInventory()
        CboMtlSubinventory.DataSource = (New classMaster).GetCombomtl_subinventory(INt64mtl_warehouse_id:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0))
        CboMtlSubinventory.ValueMember = "mtl_subinventory_id"
        CboMtlSubinventory.DisplayMember = "subinventory_code"
    End Sub
    Private Sub GenCboLocation()

        cbomtl_locations.DataSource = (New classMaster).Combomtllocations(strUSerID:=clsuser.UserID,
                                                                          pMtlWarehouseId:=(New clsConfig).IsNull(cbomtl_warehouse.SelectedValue, 0),
                                                                          Int64mtl_subinventory_id:=(New clsConfig).IsNull(CboMtlSubinventory.SelectedValue, 0))
        cbomtl_locations.ValueMember = "mtl_locations_id"
        cbomtl_locations.DisplayMember = "location_name"
    End Sub

    Private Sub BtnYarnPrintDoc_Click(sender As System.Object, e As System.EventArgs) Handles BtnYarnPrintDoc.Click
        If txtdocno.Text.Length <= 0 Then Exit Sub

        Dim clsConn As New classConnection
        Dim rptFileName As String = "RptYarnIn.rpt"
        Dim frm As New frmReport
        Dim clsconfig As New clsConfig

        If Not clsconfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@docno", txtdocno.Text.Trim)

        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        'rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BtnYarnPrintBar_Click(sender As System.Object, e As System.EventArgs) Handles BtnYarnPrintBar.Click
        If txtdocno.Text.Length <= 0 Then Exit Sub

        Dim clsConn As New classConnection
        Dim clsConfig As New clsConfig
        Dim rptFileName As String = "RptYarnBarcode.rpt"
        'If UCase(connStr.DatabaseName) = "GEMMASOFT" Then rptFileName = "RptYarnBarcode.rpt"
        Dim frm As New frmReport


        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub

        If Not clsConfig.CheckReport(clsuser.ReportPath, rptFileName) Then Exit Sub
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsuser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()

        'If flagsearch_Yarn_in = True Then
        rpt.SetParameterValue("@docno", txtdocno.Text.Trim)
        rpt.SetParameterValue("@itcd", "")
        'Else
        'rpt.SetParameterValue("@docno", "")
        'rpt.SetParameterValue("@itcd", txtItcd_no.Text.Trim)
        'End If

        rpt.SetParameterValue("@boxno", txtsystem_lot_number.Text)

        'If UCase(connStr.database) = "GEMMASOFT" Then
        '    rpt.PrintOptions.PrinterName = "SATO CL408e"
        'Else
        '    rpt.PrintOptions.PrinterName = "Datamax E-4203"
        'End If
        'rpt.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        rpt.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.Portrait
        rpt.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto

        'frm.CRViewer.DisplayGroupTree = False
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Title = "Yarn In"
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub txtbobbin_tear_weight_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbobbin_tear_weight.TextChanged

    End Sub

    Private Sub txtbobbin_weight_before_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtbobbin_weight_before.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Call SumTextData()
        'End If
    End Sub

    Private Sub txtbobbin_weight_before_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbobbin_weight_before.TextChanged

    End Sub

    Private Sub btnLocations_Click(sender As System.Object, e As System.EventArgs) Handles btnLocations.Click
        Dim objdb As New classMaster
        Dim clsProductionRouting As New classProductionRouting
        Dim dt As New DataTable

        Dim frm2 As New frmmtl_locations
        frm2.UserInfo = clsuser
        frm2.MdiParent = Me.ParentForm
        frm2.Show()

        If frm2.dtLocations.Rows.Count > 0 Then
            GenCboLocation()
        End If

    End Sub

    Private Sub txtbobbin_weight_after_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtbobbin_weight_after.KeyDown
        'If e.KeyCode = Keys.Enter Then
        'Call SumTextData()
        'End If
    End Sub

    Private Sub txtbobbin_weight_after_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtbobbin_weight_after.TextChanged

    End Sub

    Private Sub txtbeam_total_weight_TextChanged(sender As Object, e As EventArgs) Handles txtbeam_total_weight.TextChanged
        Call SumTextData()
    End Sub

    Private Sub chkAutoCalculate_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoCalculate.CheckedChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

    End Sub

    Private Sub lblWeightAfter_Click(sender As Object, e As EventArgs) Handles lblWeightAfter.Click

    End Sub

    Private Sub CboMtlSubinventory_DropDownClosed(sender As Object, e As EventArgs) Handles CboMtlSubinventory.DropDownClosed
        Call GenCboLocation()
    End Sub

    Private Sub cbomtl_warehouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbomtl_warehouse.SelectedValueChanged
        Call GenCboSubInventory()
        Call GenCboLocation()
    End Sub
End Class