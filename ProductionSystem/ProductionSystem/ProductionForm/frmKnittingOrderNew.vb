Imports ProductionSystem.Controls
Imports System.Data.SqlClient
Imports System.Windows.Forms.DialogResult
Imports System.Drawing

Public Class frmKnittingOrderNew
    Dim oConfig As New clsConfig
    Dim clsConn As New classConnection
    Dim clsUser As New classUserInfo
    'Dim kono As String = ""
    Dim StrOldbom As String  'For Ch5hkeck New BOM
    Dim StrOldDesignNo As String = "" 'For Check New Design
    Dim SingleOldQty As Single ' For Check New Qty
    Dim ko As New KO
    Dim MfgProductionOrderLines As New MfgProductionOrderLines

    Dim dtKO As New DataTable
    Dim bsKO As New BindingSource
    Dim dtMfgProductionOrderLines As DataTable
    Dim bsMfgProductionOrderLines As New BindingSource

    Dim blnCancel As Boolean = False
    Private _ProductionOrderTypeCode As String 'WONO KONO etc.
    Public Property pProductionOrderTypeCode As String
        Get
            pProductionOrderTypeCode = _ProductionOrderTypeCode
        End Get
        Set(ByVal NewValue As String)
            _ProductionOrderTypeCode = NewValue
        End Set
    End Property
    Sub setYear()
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")
        System.Threading.Thread.CurrentThread.CurrentUICulture = System.Threading.Thread.CurrentThread.CurrentCulture
    End Sub

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
            dtp.Value = "01/01/1900"
            dtp.Value = Now
            'dtp.Value = Now Edit by Neung 23/12/2014
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

        btnSave.Enabled = blnEnabled
        btnCopy.Enabled = blnEnabled
        'btnRouting.Enabled = blnEnabled
        btnGenKenddt.Enabled = blnEnabled
        btnGenQty.Enabled = blnEnabled
        McboIDYarnChange.Enabled = blnEnabled
    End Sub

    Private Sub InitControl()
        Dim obj As Control
        For Each obj In Me.Controls
            Call SetControlValue(obj)
        Next
        Call EnabledControl(True)
        Call CheckDataAccessControls()
        txtPRODNo.Text = ""
        ko.kono = ""
        ko.production_order_id = 0
        'kono = ""
        dtpKODate.Value = Now
        dtpCancelled.Value = "01/01/1900"
        dtpClosed.Value = "01/01/1900"
        'dtpDelivered.Value = "01/01/1900"
        txtPRODNo.Focus()
        cboProdType.Enabled = True
        lblCancelled.Visible = False
        lblKOClosed.Visible = False
        lblKOClosedFinal.Visible = False
        McboIDYarnChange.Enabled = True
        'McboIDYarnChange.ReadOnly = False

        Call LoadGridProd(ko)

        Call GenComboKONo()
        Call GenCombo()
        Call GenComboDesignBOMNew("")
        Call GenAutoComplete()
    End Sub

    Private Sub LoadGridProd(ByVal Ko As KO)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.ProductionSelect(Ko, clsUser)

        cboline_type.SelectedIndex = -1

        Call BindGridProd(dt)

        StrOldDesignNo = oConfig.IsNull(cboDesignNo.SelectedValue, "")
        StrOldbom = McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue
        SingleOldQty = Val(txtQty.Text)
    End Sub

    Private Sub GenCombo()
        Dim objDB As New classMaster

        Me.cboSupplier.DataSource = objDB.comboSupplier(clsUser.UserID)
        Me.cboSupplier.DisplayMember = "name"
        Me.cboSupplier.ValueMember = "suppcd"
        Me.cboSupplier.SelectedIndex = -1

        Dim dt As DataTable = objDB.comboSODR(clsUser.UserID)
        Dim dt2 As DataTable = dt.Clone
        Dim expression As String
        expression = "flow_status_code = 'CFM' "
        Dim foundRows() As DataRow
        foundRows = dt.Select(expression)
        For Each row As DataRow In foundRows
            dt2.ImportRow(row)
        Next
        Me.cboSONo.DataSource = dt2
        Me.cboSONo.DisplayMember = "sono_cust"
        Me.cboSONo.ValueMember = "sono"

        'Me.cboSONo.DataSource = objDB.comboSODR(clsUser.UserID)
        'Me.cboSONo.DisplayMember = "so_cust"
        'Me.cboSONo.ValueMember = "sono"
        'Me.cboSONo.SelectedIndex = 0

        Me.cboCustomer.DataSource = objDB.comboCustomer(clsUser.UserID)
        Me.cboCustomer.DisplayMember = "name"
        Me.cboCustomer.ValueMember = "custcd"
        Me.cboCustomer.SelectedIndex = 0

        Me.cboDesignNo.DataSource = objDB.comboGreigeDesign(clsUser.UserID)
        Me.cboDesignNo.DisplayMember = "itcd2"
        Me.cboDesignNo.ValueMember = "itcd"
        Me.cboDesignNo.SelectedIndex = 0

        Dim dtmc As DataTable = objDB.comboMachine(clsUser.UserID)
        'Changed combo to text box with autocomplete
        'Me.cboMachineNo.DataSource = dtmc
        'Me.cboMachineNo.DisplayMember = "mcno"
        'Me.cboMachineNo.ValueMember = "mcno"
        'Me.cboMachineNo.SelectedIndex = 0

        'Sitthana 20200901 Begin
        txtMachineNo.AutoCompleteSource = AutoCompleteSource.None
        txtMachineNo.AutoCompleteMode = AutoCompleteMode.None
        txtMachineNo.AutoCompleteCustomSource.Clear()
        Dim mcrow As DataRow
        For Each mcrow In dtmc.Rows
            txtMachineNo.AutoCompleteCustomSource.Add(mcrow.Item("mcno").ToString)
        Next
        txtMachineNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtMachineNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'Sitthana 20200901 End

        ' Call GetComboWarehouseinGrid()
        ' Call GetcomboSubInventoryinGrid(Int64mtl_warehouse_id:=0)


        'Me.item_id.DataSource = objDB.ComboItems(StrUserId:=clsUser.UserID)
        'Me.item_id.DisplayMember = "itcd2"
        'Me.item_id.ValueMember = "item_id"

        'Me.uom_id.DataSource = objDB.GetUOM()
        'Me.uom_id.DisplayMember = "uom"
        'Me.uom_id.ValueMember = "uom_id"

        Me.cboProdType.DataSource = objDB.comboKOType(StrUserID:=clsUser.UserID)
        Me.cboProdType.DisplayMember = "lookup_value"
        Me.cboProdType.ValueMember = "lookup_value_id"
        Me.cboProdType.SelectedIndex = -1

        Me.cboUOM.DataSource = objDB.GetUOM()
        Me.cboUOM.DisplayMember = "uom"
        Me.cboUOM.ValueMember = "uom_id"
        Me.cboUOM.SelectedIndex = -1

        cboline_type.DisplayMember = "line_type_name"
        cboline_type.ValueMember = "line_type_id"
        Dim dtLineType As New DataTable
        dtLineType.Columns.Add("line_type_name", GetType(String))
        dtLineType.Columns.Add("line_type_id", GetType(Integer))
        dtLineType.Rows.Add(" ", 0)
        dtLineType.Rows.Add("Bom Header", 1)
        dtLineType.Rows.Add("Bom Line", -1)
        cboline_type.DataSource = dtLineType

        'Me.TSCboko_mtl_warehouse_id.ComboBox.DataSource = objDB.Combomtlwarehouse(clsUser.UserID)
        'Me.TSCboko_mtl_warehouse_id.ComboBox.DisplayMember = "warehouse_code"
        'Me.TSCboko_mtl_warehouse_id.ComboBox.ValueMember = "mtl_warehouse_id"
        'Me.TSCboko_mtl_warehouse_id.ComboBox.SelectedIndex = 0
        'SetDefaultWarehouse(TSCboko_mtl_warehouse_id.ComboBox.DataSource)

        cboko_mtl_warehouse_id.DataSource = objDB.Combomtlwarehouse(clsUser.UserID)
        cboko_mtl_warehouse_id.DisplayMember = "warehouse_code"
        cboko_mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
        SetDefaultWarehouse(cboko_mtl_warehouse_id.DataSource, cboko_mtl_warehouse_id)


    End Sub


    Private Sub SetDefaultWarehouse(ByVal dt As DataTable, ByVal combobox As ComboBox)
        Dim Int64warehouse_id As Int64 = (New classMaster).GetdefaultWarehouse(strUSerID:=clsUser.UserID)

        'Dim expression As String
        'expression = "warehouse_name like '%ESH%'"
        'Dim foundRows() As DataRow
        'foundRows = dt.Select(expression)

        combobox.SelectedValue = Int64warehouse_id

    End Sub

    'Private Sub GetComboWarehouseinGrid()
    '    Dim objdb As New classMaster
    '    mtl_warehouse_id.DataSource = objdb.Combomtlwarehouse(clsUser.UserID)
    '    mtl_warehouse_id.DisplayMember = "warehouse_code"
    '    mtl_warehouse_id.ValueMember = "mtl_warehouse_id"
    '    'SetdefaultWarehouse()
    'End Sub
    'Private Sub GetcomboSubInventoryinGrid(ByVal Int64mtl_warehouse_id As Int64)
    '    Dim objdb As New classMaster
    '    source_subinventory_id.DataSource = objdb.GetCombomtl_subinventory(Int64mtl_warehouse_id)
    '    source_subinventory_id.DisplayMember = "subinventory_code"
    '    source_subinventory_id.ValueMember = "mtl_subinventory_id"
    '    'Setdefaultsubinventory(0)
    'End Sub
    Private Sub GenComboKONo()
        Dim objDB As New classMaster

        'Me.cboKoNo.ComboBox.DataSource = objDB.comboK(clsUser.UserID)
        ' Me.cboKoNo.ComboBox.DataSource = objDB.comboKOStatus  'Sitthana 06/02/2018
        ' Me.cboKoNo.ComboBox.DisplayMember = "konowithstat"    'Sitthana 06/02/2018
        ' Me.cboKoNo.ComboBox.ValueMember = "production_order_id"
        'Me.cboKoNo.ComboBox.SelectedIndex = 0
    End Sub

    'Private Sub GenComboDesignBOM(strDesignNo As String)
    '    Dim objDB As New classMaster

    '    If Not cboBOM.DataSource Is Nothing Then StrOldbom = config.IsNull(cboBOM.SelectedValue, "")

    '    Me.cboBOM.DataSource = objDB.comboDesignBOM(strDesignNo, clsUser.UserID)
    '    Me.cboBOM.DisplayMember = "ynchgcd"
    '    Me.cboBOM.ValueMember = "ynchgcd"

    '    cboBOM.SelectedValue = StrOldbom
    'End Sub

    Private Sub BindData(ByVal dt As DataTable)

        ko.kono = dt.Rows(0)("kono").ToString
        ko.production_order_id = dt.Rows(0)("production_order_id")
        cboProdType.SelectedValue = dt.Rows(0)("production_order_type_id")
        cboProdType.Enabled = False

        cboSupplier.SelectedValue = dt.Rows(0)("suppcd").ToString
        'txtPRODNo.Text = dt.Rows(0)("kono").ToString
        dtpKODate.Value = dt.Rows(0)("kodt").ToString
        'cboMachineNo.SelectedValue = dt.Rows(0)("mcno").ToString 'Comment By Sittthana 20200901
        txtMachineNo.Text = dt.Rows(0)("mcno").ToString 'Sittthana 20200901
        cboDesignNo.SelectedValue = dt.Rows(0)("design_no").ToString
        Call GenComboDesignBOMNew((dt.Rows(0)("design_no").ToString)) 'Add By Neung 20191111
        McboIDYarnChange.SelectedValue = dt.Rows(0)("id_yarnchange")
        'If (New clsConfig).IsNull(dt.Rows(0)("is_yarn_out").ToString, False) = True Then
        '    McboIDYarnChange.Enabled = False
        'Else
        '    McboIDYarnChange.Enabled = True
        'End If
        txtRemark.Text = dt.Rows(0)("remark").ToString 'Comment by Sitthana 20200723

        cboSONo.SelectedValue = dt.Rows(0)("sono").ToString
        cboCustomer.SelectedValue = dt.Rows(0)("custcd").ToString
        If oConfig.IsNull(dt.Rows(0)("kstartdt").ToString, CDate("01/01/1900")) = CDate("01/01/1900") Then
            dtpStartDate.Value = CDate("01/01/1900")
            dtpStartDate.Checked = False
        Else
            dtpStartDate.Value = dt.Rows(0)("kstartdt").ToString
            dtpStartDate.Checked = True
        End If

        If oConfig.IsNull(dt.Rows(0)("kenddt").ToString, CDate("01/01/1900")) = CDate("01/01/1900") Then
            dtpEndDate.Value = CDate("01/01/1900")
            dtpEndDate.Checked = False
        Else
            dtpEndDate.Value = dt.Rows(0)("kenddt").ToString
            dtpEndDate.Checked = True
        End If
        lblKOClosed.Visible = dt.Rows(0)("koclosed").ToString
        dtpClosed.Value = dt.Rows(0)("koclosedt").ToString
        lblCancelled.Visible = dt.Rows(0)("cancel").ToString
        IIf(oConfig.IsNull(dt.Rows(0)("canceldt").ToString, CDate("01/01/1900")) = CDate("01/01/1900"), dtpCancelled.Value = CDate("01/01/1900") And dtpCancelled.Checked = False, dtpCancelled.Value = dt.Rows(0)("canceldt").ToString And dtpCancelled.Checked)
        dtpCancelled.Value = dt.Rows(0)("canceldt").ToString
        txtClosedRemark.Text = dt.Rows(0)("rem_closed").ToString
        txtCancelledRemark.Text = dt.Rows(0)("rem_cancel").ToString
        lblKOClosedFinal.Visible = dt.Rows(0)("koclosed_final").ToString
        dtpDelivered.Value = dt.Rows(0)("koclosed_final_date").ToString
        txtDeliveredRemark.Text = dt.Rows(0)("rem_closed_final").ToString
        txtSetupDays.Text = dt.Rows(0)("adjustment").ToString
        txtStandardRollKgs.Text = dt.Rows(0)("roll_kgs_std").ToString
        txtDFBatchSize.Text = dt.Rows(0)("df_batch_kgs").ToString
        txtDailyCapacity.Text = dt.Rows(0)("daily_capacity_kg").ToString
        txtQty.Text = dt.Rows(0)("qty").ToString
        txtsteam_instruction.Text = dt.Rows(0)("steam_instruction").ToString
        txtknit_loss_perc.Text = dt.Rows(0)("knit_loss_perc").ToString
        txtdyeding_loss_perc.Text = dt.Rows(0)("dyeding_loss_perc").ToString
        cboUOM.SelectedValue = dt.Rows(0)("uom_id") 'uom from production order line type = 1
        txtTotal_Production_lot.Text = dt.Rows(0)("total_production_lots").ToString
        cboko_mtl_warehouse_id.SelectedValue = dt.Rows(0)("ko_mtl_warehouse_id")
        txtDesign_cross.Text = dt.Rows(0)("Design_cross").ToString
        txtproduction_order_no_cross.Text = dt.Rows(0)("production_order_no_cross").ToString
        If (New clsConfig).IsNull(dt.Rows(0)("cancel").ToString, False) = True Then
            lblCancelled.Visible = True
            Call EnabledControl(False)

            BtnCancel.Text = "UnCancel"
            BtnCancel.Enabled = (New clsConfig).UserAccess(UserInfo.UserID, "R0705", "ROLE")
        Else
            lblCancelled.Visible = False
            BtnCancel.Text = "Cancel"
            BtnCancel.Enabled = (New clsConfig).UserAccess(UserInfo.UserID, "R0702", "ROLE")
        End If

        If (New clsConfig).IsNull(dt.Rows(0)("koclosed").ToString, False) = True Then
            lblKOClosed.Visible = True
            Call EnabledControl(False)
            BtnKoClosed.Text = "UnClosed"
            BtnKoClosed.Enabled = (New clsConfig).UserAccess(UserInfo.UserID, "R0706", "ROLE")
        Else
            lblKOClosed.Visible = False
            BtnKoClosed.Text = "Closed"
            BtnKoClosed.Enabled = (New clsConfig).UserAccess(UserInfo.UserID, "R0703", "ROLE")
        End If

        If (New clsConfig).IsNull(dt.Rows(0)("koclosed_final").ToString, False) = True Then
            lblKOClosedFinal.Visible = True
            Call EnabledControl(False)
            BtnDelivered.Text = "UnDelivered"
            BtnDelivered.Enabled = (New clsConfig).UserAccess(UserInfo.UserID, "R0707", "ROLE")
        Else
            lblKOClosedFinal.Visible = False
            BtnDelivered.Text = "Delivered"
            BtnDelivered.Enabled = (New clsConfig).UserAccess(UserInfo.UserID, "R0704", "ROLE")
        End If

    End Sub

    Private Sub BindGrid(ByVal dt As DataTable)
        'grdData.AutoGenerateColumns = False
        'grdData.DataSource = dt
    End Sub

    Private Sub LoadData(ByVal ko As KO)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.KOSelect2(ko, clsUser)
        If dt.Rows.Count > 0 Then
            Call EnabledControl(True)
            Call BindData(dt)
            Call LoadGridProd(ko)

            Dim objClassMaster As New classMaster
            txtDesignMasterRemark.Text = objClassMaster.getDmRemark(cboDesignNo.SelectedValue) 'Sittha
        Else
            Call InitControl()
        End If
    End Sub

    Private Sub LoadGridData(ByVal strKONo As String, ByVal strDesignNo As String, ByVal strBOM As String, ByVal SingleQty As Single)
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.KOBOMSelect(strKONo, strDesignNo, strBOM, SingleQty, clsUser.UserID)
        Call BindGrid(dt)
    End Sub

    Private Function SaveData() As Boolean
        Dim objKO As New KO
        Dim objDB As New classProduction
        Dim errmsg As String = ""
        Dim dtc As New DataTable
        dtc = bsMfgProductionOrderLines.DataSource

        Dim dv_dtc_add As New DataView(dtc, "", "", DataViewRowState.Added) '
        Dim dv_dtc_upd As New DataView(dtc, "", "", DataViewRowState.ModifiedCurrent) '
        Dim dv_dtc_del As New DataView(dtc, "", "", DataViewRowState.Deleted) '

        ko.kono = txtPRODNo.Text
        objKO.kono = ko.kono
        objKO.production_order_id = ko.production_order_id
        objKO.production_order_type_id = cboProdType.SelectedValue
        objKO.suppcd = cboSupplier.SelectedValue
        objKO.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        'objKO.mcno = cboMachineNo.SelectedValue 'Comment By Sittthana 20200901
        objKO.mcno = txtMachineNo.Text.Trim 'Sittthana 20200901
        objKO.design_no = cboDesignNo.SelectedValue
        objKO.remark = txtRemark.Text
        objKO.sono = oConfig.IsNull(cboSONo.SelectedValue, cboSONo.SelectedText)
        objKO.custcd = cboCustomer.SelectedValue
        objKO.kstartdt = dtpStartDate.Value.ToString("yyyyMMdd")
        objKO.kenddt = dtpEndDate.Value.ToString("yyyyMMdd")
        objKO.ynchgcd = If(McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue IsNot Nothing, McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue.ToString(), "")
        objKO.id_yarnchange = (New clsConfig).IsNull(McboIDYarnChange.SelectedValue, Nothing)
        objKO.koclosed = lblKOClosed.Visible
        objKO.koclosedt = dtpClosed.Value.ToString("yyyyMMdd")
        objKO.cancel = lblCancelled.Visible
        objKO.canceldt = dtpCancelled.Value.ToString("yyyyMMdd")
        objKO.rem_closed = txtClosedRemark.Text
        objKO.rem_cancel = txtCancelledRemark.Text
        objKO.koclosed_final = lblKOClosedFinal.Visible
        objKO.koclosed_final_date = dtpDelivered.Value.ToString("yyyyMMdd")
        objKO.rem_closed_final = txtDeliveredRemark.Text
        objKO.adjustment = txtSetupDays.Text
        objKO.roll_kgs_std = Val(txtStandardRollKgs.Text)
        objKO.df_batch_kgs = Val(txtDFBatchSize.Text)
        objKO.daily_capacity_kg = Val(txtDailyCapacity.Text)
        objKO.qty = Val(txtQty.Text)
        objKO.steam_instruction = txtsteam_instruction.Text
        objKO.knit_loss_perc = Val(txtknit_loss_perc.Text.Trim)
        objKO.dyeding_loss_perc = Val(txtdyeding_loss_perc.Text.Trim)
        objKO.ko_mtl_warehouse_id = (New clsConfig).IsNull(cboko_mtl_warehouse_id.SelectedValue, Nothing)
        objKO.total_production_lots = CInt(txtTotal_Production_lot.Text.Trim)
        objKO.design_cross = txtDesign_cross.Text.Trim
        objKO.production_order_no_cross = txtproduction_order_no_cross.Text.Trim.ToUpper

        If objDB.KOUpdate(objKO:=objKO, DTC:=dtc, DV_DTC_ADD:=dv_dtc_add, DV_DTC_UPD:=dv_dtc_upd, DV_DTC_DEL:=dv_dtc_del, logempcd:=clsUser.UserID, errmsg:=errmsg) Then
            txtPRODNo.Text = objKO.kono

            If txtPRODNo.Text.Length > 0 Or objKO.kono.Length > 0 Then
                Call LoadData(ko:=objKO)
            Else
                Call InitControl()
            End If

            MessageBox.Show("Save Completed" & vbCrLf & errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function
    Private Sub checkProdType()
        Select Case _ProductionOrderTypeCode
            Case "KINO"
                Me.Text = "Knitting Order / Internal"
                ' cboProdType.SelectedValue = 906
                'btnSearchRouting.Visible = False
                cboProdType.Enabled = True
                'lblProductionOrder.Text = "Set Order No."
                '   lblProductionOrderDate.Text = "Set Order Date"
                colMfgProductionOrderLinesId.HeaderText = "Knitting Order Line Id"
               ' lblProductionStatusId.Text = "Status"
           ' tsbtnCopy.Text = "Copy Set"
            Case "WONO"
                Me.Text = "Warping Order"
                ' cboProdType.SelectedValue = 907
                ' btnSearchRouting.Visible = True
                cboProdType.Enabled = True
                ' lblProductionOrder.Text = "Cut && Pack Order No."
                ' lblProductionOrderDate.Text = "Cut && Pack Order Date."
                colMfgProductionOrderLinesId.HeaderText = "Warping Order Line Id"
                ' lblProductionStatusId.Text = "Status"
                ' tsbtnCopy.Text = "Copy Cut && Pack Order"
            Case Else
                Me.Text = "Production Order"
                ' btnSearchRouting.Visible = True
                cboProdType.Enabled = True
                ' lblProductionOrder.Text = "Prod Order No."
                ' lblProductionOrderDate.Text = "Prod Order Date."
                colMfgProductionOrderLinesId.HeaderText = "Production Order Line Id"
                ' lblProductionStatusId.Text = "Status"
        End Select

        'If _ProgramName <> "" Then
        '    Me.Text = pProgramname
        'End If

        'If _ProductionOrderTypeCode.Trim.Length > 0 Then
        '    cboProdType.SelectedValue = _ProductionOrderTypeCode
        'End If

        Dim dt As DataTable = CType(cboProdType.DataSource, DataTable)
        If Not String.IsNullOrEmpty(_ProductionOrderTypeCode) Then
            Dim rows = dt.Select("lookup_value_code = '" & _ProductionOrderTypeCode & "'")
            If rows.Length > 0 Then
                cboProdType.SelectedValue = rows(0)("lookup_value_id")
            End If
        End If


    End Sub
    Private Sub frmKnittingOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Application.EnableVisualStyles()

        ' txtPRODNo.Attributes.Add("onchange", "myTextBox_onchange()")

        Me.WindowState = FormWindowState.Maximized
        'Application.Run(New Form())
        Call InitControl()

        checkProdType()
    End Sub
    Private Sub GenAutoComplete()

        Dim dtKO As DataTable = (New classProduction).GetKoNo
        Dim rowKO As DataRow
        txtPRODNo.AutoCompleteSource = AutoCompleteSource.None
        txtPRODNo.AutoCompleteMode = AutoCompleteMode.None
        txtPRODNo.AutoCompleteCustomSource.Clear()
        For Each rowKO In dtKO.Rows
            txtPRODNo.AutoCompleteCustomSource.Add(rowKO.Item("kono").ToString().Trim)
        Next
        txtPRODNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtPRODNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend

    End Sub
    Private Function HasChanges() As Boolean

        If bsMfgProductionOrderLines IsNot Nothing AndAlso bsMfgProductionOrderLines.DataSource IsNot Nothing Then
            Dim dt As DataTable = CType(bsMfgProductionOrderLines.DataSource, DataTable)
            If dt.GetChanges() IsNot Nothing Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Sub frmKnittingOrder_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If HasChanges() Then
            Dim result As System.Windows.Forms.DialogResult
            result = MessageBox.Show("Data has changed ,Would you like to save ?" & vbCrLf,
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result = System.Windows.Forms.DialogResult.Yes Then
                If Not CheckData() Then Exit Sub
                Call SaveData()
            ElseIf result = System.Windows.Forms.DialogResult.No Then

            ElseIf result = System.Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        Call InitControl()
        btnSave.Enabled = True 'Sitthana 20200822 Everyone can create new
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Me.Validate()
        'Dim clsconfig As New clsConfig
        'If Not grdmfg_production_order_lines.DataSource Is Nothing Then
        '    If grdmfg_production_order_lines.Rows.Count > 0 Then
        '        If grdmfg_production_order_lines.CurrentCell.IsInEditMode Then
        '            Dim cell As DataGridViewCell = grdmfg_production_order_lines.CurrentCell
        '            grdmfg_production_order_lines.EndEdit(DataGridViewDataErrorContexts.Commit)
        '            grdmfg_production_order_lines.CurrentCell = grdmfg_production_order_lines.Rows(0).Cells("colLineType")
        '            grdmfg_production_order_lines.CurrentCell = cell
        '        End If
        '    End If
        'End If

        blnCancel = False
        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to save ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckData() Then Exit Sub

        Call SaveData()

    End Sub


    Private Function CheckData() As Boolean
        'Pro TYpe 
        If (New clsConfig).IsNull(cboProdType.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก Prod Type", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cboProdType, "คุณยังไม่ได้เลือก Production Type")
            Return False
        Else
            ErrorProvider1.SetError(cboProdType, "")
        End If
        'Uom 
        If (New clsConfig).IsNull(cboUOM.SelectedValue, 0) = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก UOM", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ErrorProvider1.SetError(cboUOM, "คุณยังไม่ได้เลือก UOM")
            Return False
        Else
            ErrorProvider1.SetError(cboUOM, "")
        End If

        'check ถ้าไม่มี Production Order line ไม่ให้บันทึก
        If grdmfg_production_order_lines.Rows.Count = 0 Then
            MessageBox.Show("ต้องมี Production Order Lines", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        'Check Line_type = -1 and ไม่ได้ใส่ Subinventory supply ไม่ให้บันทึก 
        'Changed line_type to colLineType 'Sitthana 20200221
        If grdmfg_production_order_lines.Rows.Count > 0 Then
            For i = 0 To grdmfg_production_order_lines.Rows.Count - 1
                If (New clsConfig).IsNull(grdmfg_production_order_lines.Rows(i).Cells("colLineType").Value, 0) = -1 Then
                    If (New clsConfig).IsNull(grdmfg_production_order_lines.Rows(i).Cells("colSourceSubinventoryId").Value, 0) = 0 Then
                        MessageBox.Show("ต้องมี Subinventorys", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                    End If
                End If
            Next
        End If

        'Check ไม่ได้ใส่ UOM ไม่ให้บันทึก 
        If grdmfg_production_order_lines.Rows.Count > 0 Then
            For i = 0 To grdmfg_production_order_lines.Rows.Count - 1
                If (New clsConfig).IsNull(grdmfg_production_order_lines.Rows(i).Cells("collineuomid").Value, 0) = 0 Then
                    MessageBox.Show("ต้องมี Uom" + vbCr + vbCr + "Must Be UOM", "System Message!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    ErrorProvider1.SetError(grdmfg_production_order_lines, "ต้องมี Uom" + vbCr + vbCr + "Must Be UOM")
                    Return False
                End If
            Next
        End If

        If Not (New classSalesOrder).ValidateSOFlowStatus(StrSoNo:=oConfig.IsNull(cboSONo.SelectedValue, "").ToString.Trim) Then
            MessageBox.Show("This SO is Not CFM Status Please Check It Before!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If

        ErrorProvider1.Clear()
        Return True
    End Function

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        'Const rptFileName = "rptKO.rpt"
        Dim rptFileName As String = "rptKO.rpt"
        Dim Strlookup_value_short_code As String
        Strlookup_value_short_code = (New classMaster).Getlookup_value_short_code(Int64lookup_value_id:=cboProdType.SelectedValue)
        If Strlookup_value_short_code.Trim = "WO" Then
            rptFileName = "rptWO.rpt"
        End If

        'If clsuser.ReportPath = "" Then clsuser.ReportPath = clsConfig.ReportPath
        '#NEWFORM Dim ko_type = If(optKI.Checked, 1, IIf(optKO.Checked, 2, IIf(optKP.Checked, 3, IIf(optKC.Checked, 4, -1))))
        Dim ko_type = cboProdType.SelectedValue
        ' If optKS.Checked Then
        'ko_type = 5
        'End If
        If Not oConfig.CheckReport(clsUser.ReportPath, rptFileName) Then Exit Sub
        Dim frm As New frmReport
        Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim stype As String = ""
        Dim ord As String = ""
        Me.Cursor = Cursors.WaitCursor

        rpt.Load(clsUser.ReportPath & rptFileName)
        rpt.DataSourceConnections.Item(0).SetConnection(clsConn.servername, clsConn.database, False)
        rpt.DataSourceConnections.Item(0).SetLogon(clsConn.Userid, clsConn.Password)
        rpt.VerifyDatabase()
        rpt.SetParameterValue("@kono", ko.kono)
        'Add by Neung 03/02/2015
        rpt.SetParameterValue("@ko_type", ko_type)
        rpt.SetParameterValue("@logempcd", clsUser.UserID)

        frm.Title = "Knitting Order"
        frm.CRViewer.ReportSource = rpt
        frm.MdiParent = Me.ParentForm
        frm.Show()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnMinimized_Click(sender As System.Object, e As System.EventArgs) Handles btnMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Private Sub cboKoNo_DropDownClosed(sender As System.Object, e As System.EventArgs)
    '    'Dim ko As New KO
    '    'Begin Sitthana 06/02/2018
    '    Dim KoNO As String = "" 'config.IsNull(cboKoNo.ComboBox.SelectedText, "")
    '    Dim numstr As Integer = 0

    '    KoNO = config.IsNull(cboKoNo.ComboBox.Text, "")
    '    numstr = InStr(KoNO, "(")
    '    If numstr > 0 Then
    '        ko.kono = Mid(KoNO, 1, numstr - 1).Trim
    '    Else
    '        ko.kono = KoNO.Trim
    '    End If
    '    'End  Sitthana 06/02/2018
    '    'ko.kono = config.IsNull(cboKoNo.ComboBox.SelectedText, "") 'Sitthana 06/02/2018
    '    ko.production_order_id = config.IsNull(cboKoNo.ComboBox.SelectedValue, Nothing)
    '    Call LoadData(ko)

    'End Sub

    Private Sub cboDesignNo_DropDownClosed(sender As System.Object, e As System.EventArgs) Handles cboDesignNo.DropDownClosed

        Dim design_no As String
        design_no = oConfig.IsNull(cboDesignNo.SelectedValue, "")
        If design_no = "" Then Exit Sub
        If Not Validate_Design_no(design_no) Then
            MessageBox.Show("BOM No. :   " & design_no & "..Didn't Create...,Please Create It ")
            Exit Sub

        End If


        Dim strDesignNo As String = oConfig.IsNull(cboDesignNo.SelectedValue, "")

        'If Not strDesignNo.Equals(StrOldDesignNo) Then
        Call GenComboDesignBOMNew(strDesignNo) 'Add By Neung 20191111
        'Call GenComboDesignBOM(strDesignNo)
        Call GenStandardRollKgs(strDesignNo)
        'End If

        'Dim strBOM As String = config.IsNull(cboBOM.SelectedValue, "")
        'Dim SingleQty As Single = Val(txtQty.Text)

        'Call GenProductionOrderLine(StrKono:=txtPRODNo.Text.Trim,
        '                StrDesignNo:=config.IsNull(cboDesignNo.SelectedValue, ""),
        '                  StrBOM:=config.IsNull(cboBOM.SelectedValue, ""),
        '                  SingleQty:=Val(txtQty.Text.Trim))
        'Sitthana 20190301
        Dim objClassMaster As New classMaster
        'If txtRemark.Text.Trim = "" Then
        '    txtRemark.Text = objClassMaster.getDmRemark(strDesignNo)
        'Else
        '    If MessageBox.Show("ในหมายเหตุ มีข้อความอยู่แล้ว ต้องการแทนที่ใช่หรือไม่", "ยืนยันการเปลี่ยนแปลงข้อมูล" _
        '                       , MessageBoxButtons.YesNo, MessageBoxIcon.Question _
        '                       , MessageBoxDefaultButton.Button1
        '                       ) = vbYes Then
        '        txtRemark.Text = objClassMaster.getDmRemark(strDesignNo)
        '    End If
        'End If
        txtDesignMasterRemark.Text = objClassMaster.getDmRemark(strDesignNo) 'Sitthana 20200723
    End Sub

    Private Sub GenComboDesignBOMNew(strDesignNo As String)

        ' Me.McboIDYarnChange.DataSource = (New classJobCard).GetDesignBOM(strDesignNo, clsUser.UserID)
        Me.McboIDYarnChange.DataSource = (New classProduction).GetDesignBOM(strDesignNo, clsUser.UserID)
        Me.McboIDYarnChange.DisplayMember = "ynchgcd_col"
        Me.McboIDYarnChange.ValueMember = "id_yarnchange"
        Me.McboIDYarnChange.SelectedIndex = -1
        Dim glb As GridListBox = TryCast(McboIDYarnChange.ListControl, GridListBox)
        If glb IsNot Nothing Then
            RemoveHandler glb.Grid.Model.QueryCellInfo, AddressOf McboIDYarnChange_Model_QueryCellinfo
            AddHandler glb.Grid.Model.QueryCellInfo, AddressOf McboIDYarnChange_Model_QueryCellinfo
        End If

    End Sub
    Private Sub McboIDYarnChange_Model_QueryCellinfo(ByVal sender As Object, ByVal e As GridQueryCellInfoEventArgs)

        If e.RowIndex = 0 AndAlso e.ColIndex = 1 Then
            e.Style.Text = "ID"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 2 Then
            e.Style.Text = "BOM"
        ElseIf e.RowIndex = 0 AndAlso e.ColIndex = 3 Then
            e.Style.Text = "BOM_COL"
        End If

    End Sub

    Private Sub GenStandardRollKgs(strDesignNo As String)
        Dim objdb As New classMaster
        Dim dt As New DataTable
        dt = objdb.GetDesign(design_no:=strDesignNo)
        If dt.Rows.Count > 0 Then
            Me.txtStandardRollKgs.Text = (New clsConfig).IsNull(dt.Rows(0)("kg_per_roll"), 0)
        End If

    End Sub

    Private Function Validate_Design_no(design_no) As Boolean
        Dim objDB As New classProduction
        Dim dt As DataTable = objDB.Validateyarnchange(design_no, clsUser.UserID)

        If dt.Rows.Count = 0 Then
            Return False
        End If
        Return True
    End Function

    'Private Sub cboBOM_DropDownClosed(sender As System.Object, e As System.EventArgs)
    '    Dim strDesignNo As String = config.IsNull(cboDesignNo.SelectedValue, "")
    '    Dim strBOM As String = config.IsNull(cboBOM.SelectedValue, "")

    '    If strDesignNo.Length > 0 And strBOM.Length > 0 Then
    '        Call LoadGridData(ko.kono, cboDesignNo.SelectedValue, strBOM, SingleOldQty)
    '    End If

    '    Call GenProductionOrderLine(StrKono:=(New clsConfig).IsNull(txtPRODNo.Text.Trim, ""),
    '                      StrDesignNo:=config.IsNull(cboDesignNo.SelectedValue, ""),
    '                      StrBOM:=config.IsNull(cboBOM.SelectedValue, ""),
    '                      SingleQty:=Val(txtQty.Text.Trim))

    'End Sub
    Private Sub GenProductionOrderLine(ByVal StrKono As String, ByVal StrDesignNo As String, ByVal StrBOM As String, ByVal SingleQty As Single)

        If SingleQty = 0 Then Exit Sub

        'If Not StrBOM.Equals(StrOldbom) Or Not StrDesignNo.Equals(StrOldDesignNo) Or Not SingleQty.Equals(SingleOldQty) Then
        Call LoadGridData(strKONo:=ko.kono, strDesignNo:=StrDesignNo, strBOM:=StrBOM, SingleQty:=SingleQty)

        Dim dt As DataTable = grdmfg_production_order_lines.DataSource

        If Not dt Is Nothing Then dt.Rows.Clear()

        Call GetDataProLine(StrKono:=StrKono,
                            strDesignNo:=StrDesignNo,
                            strBOM:=StrBOM,
                            SingleQty:=SingleQty)


        'End If
    End Sub

    Private Sub GetDataProLine(ByVal StrKono As String, ByVal strDesignNo As String, ByVal strBOM As String, ByVal SingleQty As Single)
        Dim objdb As New classProduction
        Dim dt As New DataTable

        dt = objdb.GetKOProLineSelect(strKONo:=StrKono, strDesignNo:=strDesignNo, strBOM:=strBOM, SingleQty:=SingleQty, logempcd:=clsUser.UserID)


        Call BindGridProd(dt)

        StrOldDesignNo = oConfig.IsNull(cboDesignNo.SelectedValue, "")
        StrOldbom = If(McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue IsNot Nothing, McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue.ToString(), "")
        SingleOldQty = Val(txtQty.Text)

    End Sub

    Private Sub BindGridProd(ByVal dt As DataTable)

        dtMfgProductionOrderLines = dt
        bsMfgProductionOrderLines.DataSource = dtMfgProductionOrderLines
        bsMfgProductionOrderLines.MoveFirst()
        bsMfgProductionOrderLines.EndEdit()

        grdmfg_production_order_lines.AutoGenerateColumns = False
        grdmfg_production_order_lines.DataSource = bsMfgProductionOrderLines
        grdmfg_production_order_lines.Refresh()

    End Sub

    Private Sub cboDesignNo_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        Dim strStartDate As String = dtpStartDate.Value.ToString("yyyyMMdd")
        Dim strEndDate As String = dtpEndDate.Value.ToString("yyyyMMdd")
        Dim strSetupDays As String = oConfig.IsNull(txtSetupDays.Text, "")
        Dim strDailyCapacity As String = oConfig.IsNull(txtDailyCapacity.Text, "")
        'objKO.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        If strSetupDays.Length Then
            'Call LoadGridData(kono, cboDesignNo.SelectedValue, strBOM)
            Call Loadkenddt(strStartDate, strEndDate, strSetupDays, strDailyCapacity)
        End If
    End Sub
    Private Sub Loadkenddt(ByRef StrStartDates As String, ByRef StrEnddate As String, ByRef StrSetupdays As Integer, ByRef StrDailyCapacity As Integer)
        Dim objdb As New classProduction
        Dim dt As DataTable = objdb.AutoGenKendDt(StrStartDates, StrEnddate, StrSetupdays, StrDailyCapacity)

        dtpEndDate.Value = dt.Rows(0)("kenddt")
        'dtpKODate.Value = dt.Rows(0)("kodt").ToString
    End Sub


    Private Sub btnRouting_Click(sender As System.Object, e As System.EventArgs) Handles btnRouting.Click
        '============= Add By Neung Fix Error User Change KONO but Not Data Change =========
        '  ko.kono = txtPRODNo.Text.Trim
        '   Call LoadData(ko:=ko)
        '===================================================================================

        'Dim result As System.Windows.Forms.DialogResult
        'result = MessageBox.Show("คุณต้องการไปหน้าที่ Rounting ใช่หรอืไม่ ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckDataRouting() Then Exit Sub

        ko.kono = txtPRODNo.Text
        ko.design_no = cboDesignNo.SelectedValue.ToString
        ko.qty = txtQty.Text
        'KO.ynchgcd = cboBOM.Text
        ko.ynchgcd = If(McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue IsNot Nothing, McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue.ToString(), "")
        ko.daily_capacity_kg = txtDailyCapacity.Text
        ko.roll_kgs_std = txtStandardRollKgs.Text
        ko.kstartdt = dtpStartDate.Value.ToString
        ko.kenddt = dtpEndDate.Value.ToString
        ko.cancel = lblCancelled.Visible
        ko.koclosed = lblKOClosed.Visible
        ko.koclosed_final = lblKOClosedFinal.Visible

        MfgProductionOrderLines.MfgProductionOrderLinesId = grdmfg_production_order_lines.CurrentRow.Cells("colMfgProductionOrderLinesId").Value

        Dim Strlookup_value_short_code As String
        Strlookup_value_short_code = (New classMaster).Getlookup_value_short_code(Int64lookup_value_id:=cboProdType.SelectedValue)
        If Validate_KoNo(txtPRODNo.Text.Trim) Then 'Go to frmProductionRouting
            If Strlookup_value_short_code.Trim = "WO" Or Strlookup_value_short_code.Trim = "WE" Then
                Dim frmProRouting As New frmProductionRoutingWarping
                frmProRouting.KOdata = ko
                frmProRouting.UserInfo = clsUser
                frmProRouting.MfgProductionOrderLinesData = MfgProductionOrderLines
                frmProRouting.MdiParent = Me.ParentForm
                frmProRouting.Show()
            Else
                Dim frmProRouting As New frmProductionRoutingKnitting
                frmProRouting.KOdata = ko
                frmProRouting.UserInfo = clsUser
                frmProRouting.MfgProductionOrderLinesData = MfgProductionOrderLines
                frmProRouting.MdiParent = Me.ParentForm
                frmProRouting.Show()
            End If
        End If
    End Sub

    Private Function CheckDataRouting() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("Not Found Product order No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If
        If grdmfg_production_order_lines.Rows.Count = 0 Then
            MessageBox.Show("Not Found Product line", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        If Not (New clsConfig).IsNull(grdmfg_production_order_lines.CurrentRow.Cells("colLineType").Value, 0) = 1 Then
            MessageBox.Show("ยังไม่ได้ติ๊กเลือก Line Item = 1", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (New clsConfig).IsNull(grdmfg_production_order_lines.CurrentRow.Cells("colMfgProductionOrderLinesId").Value, 0) = 0 Then
            MessageBox.Show("ยังไม่ได้บันทึก Production", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not (New classProduction).ValidateProductionLineID(txtPRODNo.Text, grdmfg_production_order_lines.CurrentRow.Cells("colMfgProductionOrderLinesId").Value) Then
            MessageBox.Show("ไม่พบ Line Item นี้ ใน K/O นี้" & vbCrLf & " คุณได้ Load K/O", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function


    Private Function Validate_KoNo(Optional ByVal StrKono As String = "") As Boolean
        Dim objdb As New classProductionRouting
        Dim dt As DataTable = objdb.Validate_KoNo(StrKono, clsUser.UserID)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("KO No .: " & StrKono & "............   is Not Correct!!", "SyStem Messsage", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnGenKenddt_Click(sender As System.Object, e As System.EventArgs) Handles btnGenKenddt.Click
        Dim clsconfig As New clsConfig
        Dim objdb As New classProduction

        '----------------------------------------
        If dtpStartDate.Checked = False Then
            MessageBox.Show("Please Select Start Date Before Process", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        '-------------------------------------------

        If dtpStartDate.Value.ToString("yyyyMMdd") = "19000101" Then
            MessageBox.Show("Start Date = " + dtpStartDate.Value.ToString("dd-MM-yyyy") + " , Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpEndDate.Value = DateTime.Parse("1900-01-01")
            Exit Sub

        End If
        If CSng(IIf(txtDailyCapacity.Text.Trim.Length = 0, "0", txtDailyCapacity.Text.Trim)) = 0 Then
            MessageBox.Show("Daily Capacity = " + txtDailyCapacity.Text.ToString + ", Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If CSng(IIf(txtQty.Text.Trim.Length = 0, "0", txtQty.Text.Trim)) = 0 Then
            MessageBox.Show("QTY KGS. = " + txtQty.Text.ToString + ", Please Check", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        dtpEndDate.Value = objdb.Getkenddt(txtPRODNo.Text, dtpStartDate.Value.ToString("yyyyMMdd"), dtpEndDate.Value.ToString("yyyyMMdd"), txtDailyCapacity.Text, txtSetupDays.Text, txtQty.Text)

    End Sub


    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        'MessageBox.Show("อยู่ระหว่างปรับปรุง", "Sytem Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Dim result As System.Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to copy Production Order ?",
        "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)

        If result = System.Windows.Forms.DialogResult.Cancel Then blnCancel = True
        If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub

        If Not CheckDataCopyKoNo() Then Exit Sub

        Dim KoNo As String = txtPRODNo.Text.Trim
        If CopyKo(KoNo, sender, e) Then
            MessageBox.Show("Copy Prod No." & KoNo & " Success" & vbCrLf & "", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        End If
        'If MessageBox.Show("Would you like to copy ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '    ko.kono = ""
        '    ko.production_order_id = 0
        '    txtPRODNo.Text = ko.kono
        '    dtpKODate.Value = Now

        '    Call GenProductionOrderLine(StrKono:=txtPRODNo.Text.Trim,
        '                StrDesignNo:=config.IsNull(cboDesignNo.SelectedValue, ""),
        '                                StrBOM:=McboIDYarnChange.ListBox.Grid.Model(McboIDYarnChange.SelectedIndex + 1, 2).CellValue.ToString(),
        '                  SingleQty:=Val(txtQty.Text.Trim))
        'End If
    End Sub

    Private Function CopyKo(ByRef KoNo As String, sender As System.Object, e As System.EventArgs) As Boolean
        Try

            'Dim KoNo As String = txtPRODNo.Text.Trim
            '========= Copy Data =========='
            Dim dtCopyKO As DataTable = (New classProduction).GetCopyKo(KoNo:=KoNo, logempcd:=clsUser.UserID)
            Dim dtCopyKOLine As DataTable = (New classProduction).GetCopyProductionLines(KoNo:=KoNo, Logempcd:=clsUser.UserID)
            '========= Clear Data ========='
            Call btnNew_Click(sender:=sender, e:=e)
            '========= Loop Copy Data ====='
            Dim dtOld As New DataTable
            dtOld = bsMfgProductionOrderLines.DataSource
            Dim drOldNewRow As DataRow
            For Each drCopy As DataRow In dtCopyKOLine.Rows
                drOldNewRow = dtOld.NewRow
                For Each dcOld As DataColumn In dtOld.Columns
                    For Each dcCopy As DataColumn In dtCopyKOLine.Columns
                        drOldNewRow(dcOld.ColumnName) = drCopy(dcOld.ColumnName)
                    Next
                Next
                dtOld.Rows.Add(drOldNewRow)
            Next

            If dtCopyKO.Rows.Count > 0 Then Call BindData(dtCopyKO)
            If dtOld.Rows.Count > 0 Then Call BindGridProd(dtOld)

        Catch ex As Exception
            Dim Message As String = ex.Message
            MessageBox.Show("Copy Prod No. Not Success " & vbCrLf & Message, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            ko.kono = KoNo 'บันทึกไม่สำเร็จ ดึงข้อมูลมาใหม่
            Call LoadData(ko:=ko)
            Return False
        End Try

        Return True
    End Function

    Private Function CheckDataCopyKoNo() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("This S/O No. is Empty", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs)
        Dim frm As New frmSearchKOForGreigeINManual
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If (New clsConfig).IsNull(frm.pKono, "").trim <> "" Then
            txtPRODNo.Text = frm.pKono
            ko.kono = txtPRODNo.Text.Trim
            ko.production_order_id = 0
            Call LoadData(ko:=ko)
        End If

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub

    Private Sub txtMachineNo_Leave(sender As Object, e As EventArgs) Handles txtMachineNo.Leave
        'Sittthana 20200901
        If txtMachineNo.Text.Trim <> "" Then
            'Sitthana 20/10/2018
            Dim objdb As New classProduction
            Dim dt As New DataTable
            Dim MtlWarehouseId As Integer = 0
            dt = objdb.getMtlWarehouseIdByMcNo(txtMachineNo.Text.Trim)

            If dt.Rows(0)("mtl_warehouse_id") Is Nothing OrElse IsDBNull(dt.Rows(0)("mtl_warehouse_id")) Then
                cboko_mtl_warehouse_id.SelectedValue = -1
                MessageBox.Show("เครื่องจักร " & txtMachineNo.Text.Trim _
                               & " ยังไม่ได้ระบุ ตำแหน่งที่ตั้งของเครื่องจักรตัวนี้" & vbCr _
                               & Space(5) & "ดังนั้นให้คุณเลือก W/H เองครับ" _
                               , "รายงานข้อมูลเกี่ยวกับเครื่องจักร", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                cboko_mtl_warehouse_id.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
            End If
        End If
    End Sub
    Private Sub cboMachineNo_DropDownClosed(sender As Object, e As EventArgs)
        'If cboMachineNo.Items.Count > 0 Then
        '    'Sitthana 20/10/2018
        '    Dim objdb As New classProduction
        '    Dim dt As New DataTable
        '    Dim MtlWarehouseId As Integer = 0
        '    dt = objdb.getMtlWarehouseIdByMcNo(cboMachineNo.SelectedValue)

        '    If dt.Rows(0)("mtl_warehouse_id") Is Nothing OrElse IsDBNull(dt.Rows(0)("mtl_warehouse_id")) Then
        '        cboko_mtl_warehouse_id.SelectedValue = -1
        '        MessageBox.Show("เครื่องจักร " & cboMachineNo.SelectedValue _
        '                       & " ยังไม่ได้ระบุ ตำแหน่งที่ตั้งของเครื่องจักรตัวนี้" & vbCr _
        '                       & Space(5) & "ดังนั้นให้คุณเลือก W/H เองครับ" _
        '                       , "รายงานข้อมูลเกี่ยวกับเครื่องจักร", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Else
        '        cboko_mtl_warehouse_id.SelectedValue = dt.Rows(0)("mtl_warehouse_id")
        '    End If
        'End If
    End Sub

    Private Sub btnPrintIssueTemplate_Click(sender As Object, e As EventArgs) Handles btnPrintIssueTemplate.Click

        Dim kono As String
        Dim frmPrintIssueTemplate As New frmPrintIssueTemplate
        kono = txtPRODNo.Text
        frmPrintIssueTemplate.paramKono = kono
        frmPrintIssueTemplate.reportPath = clsUser.ReportPath
        frmPrintIssueTemplate.Show()
    End Sub

    'Private Sub grdmfg_production_order_lines_CellBeginEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles grdmfg_production_order_lines.CellBeginEdit
    '    Dim objdb As New classMaster
    '    Dim dgvccSubInven As New DataGridViewComboBoxCell
    '    Dim dtSubInven As New DataTable
    '    If grdmfg_production_order_lines.Columns(e.ColumnIndex).Name = "source_subinventory_id" Then
    '        If Not IsDBNull(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
    '            dtSubInven = objdb.GetCombomtl_subinventory(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
    '            dgvccSubInven = grdmfg_production_order_lines.Rows(e.RowIndex).Cells("source_subinventory_id")
    '            Try
    '                dgvccSubInven.DataSource = dtSubInven
    '                dgvccSubInven.DisplayMember = "subinventory_code"
    '                dgvccSubInven.ValueMember = "mtl_subinventory_id"
    '            Catch ex As Exception
    '                dgvccSubInven.Value = DBNull.Value
    '            End Try
    '        End If
    '    End If
    'End Sub

    'Private Sub grdmfg_production_order_lines_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdmfg_production_order_lines.CellContentClick

    'End Sub

    Private Sub txtQty_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtQty.TextChanged
        ' Call GenProductionOrderLine(StrKono:=(New clsConfig).IsNull(txtPRODNo.Text.Trim, ""),
        ' StrDesignNo:=(New clsConfig).IsNull(cboDesignNo.SelectedValue, ""),
        'StrBOM:=(New clsConfig).IsNull(cboBOM.SelectedValue, ""),
        'SingleQty:=Val(txtQty.Text.Trim))
    End Sub

    Private Sub cboline_type_DropDownClosed(sender As Object, e As System.EventArgs) Handles cboline_type.DropDownClosed
        bsMfgProductionOrderLines.Filter = "line_type = '" & (New clsConfig).IsNull(cboline_type.SelectedValue, 0) & "'  or " & (New clsConfig).IsNull(cboline_type.SelectedValue, 0) & " = 0"
    End Sub

    Private Sub cboline_type_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboline_type.SelectedIndexChanged

    End Sub

    Private Sub cboBOM_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    'Private Sub grdmfg_production_order_lines_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdmfg_production_order_lines.CellEndEdit
    '    Dim objdb As New classMaster
    '    Dim dgvccSubInven As New DataGridViewComboBoxCell
    '    Dim dtSubInven As New DataTable
    '    If grdmfg_production_order_lines.Columns(e.ColumnIndex).Name = "mtl_warehouse_id" Then
    '        If Not IsDBNull(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value) Then
    '            dtSubInven = objdb.GetCombomtl_subinventory(grdmfg_production_order_lines.Rows(e.RowIndex).Cells("mtl_warehouse_id").Value)
    '            dgvccSubInven = grdmfg_production_order_lines.Rows(e.RowIndex).Cells("source_subinventory_id")
    '            Try
    '                dgvccSubInven.DataSource = dtSubInven
    '                dgvccSubInven.DisplayMember = "subinventory_code"
    '                dgvccSubInven.ValueMember = "mtl_subinventory_id"
    '                dgvccSubInven.Value = DBNull.Value
    '            Catch ex As Exception
    '                dgvccSubInven.Value = DBNull.Value
    '            End Try
    '        End If
    '    End If
    'End Sub

    Private Sub cboSONo_DropDownClosed(sender As Object, e As EventArgs) Handles cboSONo.DropDownClosed
        Call LoadDataCustcdFromSO()
    End Sub
    Private Sub LoadDataCustcdFromSO()
        Dim objdb As New classSalesOrder
        Dim dt As DataTable = objdb.SODetLoad((New clsConfig).IsNull(cboSONo.SelectedValue, Nothing))
        'Call BindGrid(dt)
        If dt.Rows.Count > 0 Then cboCustomer.SelectedValue = dt.Rows(0)("custcd")
        If dt.Rows.Count = 0 Then cboCustomer.SelectedIndex = -1


    End Sub
    Private Sub cboSONo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSONo.SelectedIndexChanged
        If cboSONo.SelectedIndex < 0 Then Exit Sub

        If Not (New classSalesOrder).ValidateSOFlowStatus((New clsConfig).IsNull(cboSONo.SelectedValue, "")) Then
            MessageBox.Show("S/O ติดสถานะ ENT มีการแก้ไข S/O ต้อง CFM ก่อน", "System Message")
            Call EnabledControl(False)
            Exit Sub
        End If

    End Sub


    Private Sub btnGenQty_Click(sender As Object, e As EventArgs) Handles btnGenQty.Click
        Dim objdb As New classProduction
        Dim int_set_qty As Nullable(Of Integer)

        Dim Strlookup_value_short_code As String
        Strlookup_value_short_code = (New classMaster).Getlookup_value_short_code(Int64lookup_value_id:=cboProdType.SelectedValue)


        If Strlookup_value_short_code.Trim = "WO" Then

            Dim result As DialogResult  'Windows.Forms.DialogResult
            result = MessageBox.Show("Would You Like To Gens Qty ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result = DialogResult.No Then Exit Sub

            int_set_qty = CInt(txtTotal_Production_lot.Text.Trim)

            Dim dt As DataTable = objdb.GetKgOnBeam(cboSONo.SelectedValue, txtPRODNo.Text, cboDesignNo.SelectedValue, int_set_qty)
            If dt.Rows.Count > 0 Then
                txtQty.Text = dt.Rows(0)("sum_woqty") + ((dt.Rows(0)("sum_woqty") / 100) * CInt(txtknit_loss_perc.Text))
                txtStandardRollKgs.Text = CInt(dt.Rows(0)("kg_on_beam"))

            End If
        End If

    End Sub

    Private Sub grdmfg_production_order_lines_KeyDown(sender As Object, e As KeyEventArgs) Handles grdmfg_production_order_lines.KeyDown

        If e.KeyCode = Keys.Delete Then
            'Dim errmsg As String = ""
            'Dim dt As DataTable = grdmfg_production_order_lines.DataSource
            'If dt.Rows.Count > 0 Then
            '    If Val(grdmfg_production_order_lines.CurrentRow.Cells("mfg_production_order_lines_id").Value) > 0 Then
            '        'grdData.DataSource = GetData("DELETE " & grdData.CurrentRow.Cells("id").Value.ToString())
            '        If MessageBox.Show("Would you like to remove item  " &
            '                           grdmfg_production_order_lines.CurrentRow.Cells("item_id").FormattedValue.ToString() & " ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '            If (New classProduction).ProductionOrderLinesDelete(Int64mfg_production_order_lines_id:=grdmfg_production_order_lines.CurrentRow.Cells("mfg_production_order_lines_id").Value.ToString(),
            '                                                                  errmsg:=errmsg) Then
            '                Call GenComboKONo()
            '                'Me.DgYarn.Rows(i).Cells("mtl_locations_id").FormattedValue.ToString() 
            '                If txtPRODNo.Text.Length > 0 Then
            '                    ko.kono = txtPRODNo.Text
            '                    Call LoadData(ko:=ko)
            '                Else
            '                    Call InitControl()
            '                End If
            '                MessageBox.Show("Remove Completed" & vbCrLf & errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '            Else
            '                MessageBox.Show(errmsg, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '            End If
            '        End If
            '    End If
            'End If

            'txtPRODNo.Focus()
        End If
    End Sub

    Private Sub cboKoNo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtmfrmDoc_attachments_Click(sender As Object, e As EventArgs) Handles BtmfrmDoc_attachments.Click
        'Sitthana Copy from frmDesignNew 22/05/2018

        If Not Validate_Design_no(cboDesignNo.SelectedValue) Or cboDesignNo.SelectedValue = "" Then
            MessageBox.Show("Design No. : " & cboDesignNo.SelectedValue & "............    Not Valid!!", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        Dim frm As New frmDocAttachments
        frm.UserInfo = clsUser
        frm.Psource_doc_number = cboDesignNo.SelectedValue
        frm.Psource_doc_type = "DESIGN_NO"
        frm.MdiParent = Me.ParentForm
        frm.Show()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Call CheckCanceled()
        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would you like to Cancel PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result <> Windows.Forms.DialogResult.Yes Then Exit Sub

        'If Not CheckDataCancel() Then Exit Sub

        'If CancelPRODNo() Then

        'End If

    End Sub

    Private Sub CheckCanceled()
        If Not lblCancelled.Visible Then
            Dim result As DialogResult 'Windows.Forms.DialogResult
            result = MessageBox.Show("Would you like to Cancel PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result <> DialogResult.Yes Then Exit Sub

            If Not CheckDataCancel() Then Exit Sub

            If CancelPRODNo() Then

            End If
        Else
            Dim result As DialogResult 'Windows.Forms.DialogResult
            result = MessageBox.Show("Would you like to UnCancel PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result <> DialogResult.Yes Then Exit Sub

            If Not CheckDataUnCanceled() Then Exit Sub

            If UnCanceledPRODNo() Then

            End If
        End If

    End Sub

    Private Function CheckDataCancel() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก PROD No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    'UnCanceled'
    Private Function CheckDataUnCanceled() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก PROD No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    'KoClosed
    Private Function CheckDataClosed() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก PROD No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    'KoUnClosed
    Private Function CheckDataUnClosed() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก PROD No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    'Delivered
    Private Function CheckDataDelivered() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก PROD No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    'UNDelivered
    Private Function CheckDataUNDelivered() As Boolean
        If txtPRODNo.Text.Trim.Length = 0 Then
            MessageBox.Show("คุณยังไม่ได้เลือก PROD No.", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
            Exit Function
        End If

        Return True
    End Function
    Private Function CancelPRODNo() As Boolean
        Dim config As New clsConfig

        Dim KOHeader As New KO

        KOHeader.kono = txtPRODNo.Text.Trim
        KOHeader.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        KOHeader.canceldt = dtpCancelled.Value.ToString("yyyyMMdd")
        KOHeader.rem_cancel = txtCancelledRemark.Text.Trim
        KOHeader.Strmsgerr = ""

        If (New classProduction).CANCELPRODNo(KOHeader, clsUser) Then
            MessageBox.Show("ยกเลิกสำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call GenComboKONo()
            Call LoadData(ko:=KOHeader)
            CancelPRODNo = True
        Else
            CancelPRODNo = False
            MessageBox.Show(KOHeader.Strmsgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Function UnCanceledPRODNo() As Boolean
        Dim config As New clsConfig

        Dim KOHeader As New KO

        KOHeader.kono = txtPRODNo.Text.Trim
        KOHeader.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        KOHeader.canceldt = dtpCancelled.Value.ToString("yyyyMMdd")
        KOHeader.rem_cancel = txtCancelledRemark.Text.Trim
        KOHeader.Strmsgerr = ""

        If (New classProduction).UnCanceledPRODNo(KOHeader, clsUser) Then
            MessageBox.Show("Uncanceled สำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call GenComboKONo()
            Call LoadData(ko:=KOHeader)
            UnCanceledPRODNo = True
        Else
            UnCanceledPRODNo = False
            MessageBox.Show(KOHeader.Strmsgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Sub BtnUncanceled_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to UnCanceled PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataUnCanceled() Then Exit Sub

        If UnCanceledPRODNo() Then

        End If
    End Sub

    Private Sub BtnKoClosed_Click(sender As Object, e As EventArgs) Handles BtnKoClosed.Click
        Call CheckClosed()
        'Dim result As Windows.Forms.DialogResult
        'result = MessageBox.Show("Would you like to Closed PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        'If result <> Windows.Forms.DialogResult.Yes Then Exit Sub

        'If Not CheckDataClosed() Then Exit Sub

        'If ClosedPRODNo() Then

        'End If

    End Sub

    Private Sub CheckClosed()
        If Not lblKOClosed.Visible Then
            Dim result As DialogResult 'Windows.Forms.DialogResult
            result = MessageBox.Show("Would you like to Closed PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result <> DialogResult.Yes Then Exit Sub

            If Not CheckDataClosed() Then Exit Sub

            If ClosedPRODNo() Then

            End If
        Else
            Dim result As DialogResult
            result = MessageBox.Show("Would you like to UnClosed PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            If result <> DialogResult.Yes Then Exit Sub

            If Not CheckDataUnClosed() Then Exit Sub

            If UNClosedPRODNo() Then

            End If
        End If
    End Sub

    Private Function ClosedPRODNo() As Boolean
        Dim config As New clsConfig

        Dim KOHeader As New KO

        KOHeader.kono = txtPRODNo.Text.Trim
        KOHeader.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        KOHeader.koclosedt = dtpClosed.Value.ToString("yyyyMMdd") 'Neung 20260911
        KOHeader.rem_closed = txtClosedRemark.Text.Trim
        KOHeader.Strmsgerr = ""

        If (New classProduction).ClosedPRODNo(KOHeader, clsUser) Then
            MessageBox.Show("Closed Production สำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call GenComboKONo()
            Call LoadData(ko:=KOHeader)
            ClosedPRODNo = True
        Else
            ClosedPRODNo = False
            MessageBox.Show(KOHeader.Strmsgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function



    Private Function UNClosedPRODNo() As Boolean
        Dim config As New clsConfig

        Dim KOHeader As New KO

        KOHeader.kono = txtPRODNo.Text.Trim
        KOHeader.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        KOHeader.koclosedt = dtpClosed.Value.ToString("yyyyMMdd")
        KOHeader.rem_closed = txtClosedRemark.Text.Trim
        KOHeader.Strmsgerr = ""

        If (New classProduction).UNClosedPRODNo(KOHeader, clsUser) Then
            MessageBox.Show("Closed Production สำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call GenComboKONo()
            Call LoadData(ko:=KOHeader)
            UNClosedPRODNo = True
        Else
            UNClosedPRODNo = False
            MessageBox.Show(KOHeader.Strmsgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Sub BtnKoclosedFinal_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to Delivered PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataDelivered() Then Exit Sub

        If DeliveredPRODNo() Then

        End If
    End Sub

    Private Function DeliveredPRODNo() As Boolean
        Dim config As New clsConfig

        Dim KOHeader As New KO

        KOHeader.kono = txtPRODNo.Text.Trim
        KOHeader.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        KOHeader.koclosed_final_date = dtpDelivered.Value.ToString("yyyyMMdd")
        KOHeader.rem_closed_final = txtDeliveredRemark.Text.Trim
        KOHeader.Strmsgerr = ""

        If (New classProduction).DeliveredPRODNo(KOHeader, clsUser) Then
            MessageBox.Show("Delivered Production สำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call GenComboKONo()
            Call LoadData(ko:=KOHeader)
            DeliveredPRODNo = True
        Else
            DeliveredPRODNo = False
            MessageBox.Show(KOHeader.Strmsgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Function UNDeliveredPRODNo() As Boolean
        Dim config As New clsConfig

        Dim KOHeader As New KO

        KOHeader.kono = txtPRODNo.Text.Trim
        KOHeader.kodt = dtpKODate.Value.ToString("dd/MM/yyyy")
        KOHeader.koclosed_final_date = dtpDelivered.Value.ToString("yyyyMMdd")
        KOHeader.rem_closed_final = txtDeliveredRemark.Text.Trim
        KOHeader.Strmsgerr = ""

        If (New classProduction).UNDeliveredPRODNo(KOHeader, clsUser) Then
            MessageBox.Show("UnDelivered Production สำเร็จ ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call GenComboKONo()
            Call LoadData(ko:=KOHeader)
            UNDeliveredPRODNo = True
        Else
            UNDeliveredPRODNo = False
            MessageBox.Show(KOHeader.Strmsgerr, "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End If
    End Function

    Private Sub BtnUnDelivered_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult 'Windows.Forms.DialogResult
        result = MessageBox.Show("Would you like to UNDelivered PROD No. ?", "System Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
        If result <> DialogResult.Yes Then Exit Sub

        If Not CheckDataUNDelivered() Then Exit Sub

        If UNDeliveredPRODNo() Then

        End If

    End Sub

    Private Sub CheckDataAccessControls()
        Dim objSecurity As New clsConfig

        BtnCancel.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0702", "ROLE")
        BtnKoClosed.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0703", "ROLE")
        'BtnKoclosedFinal.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0704", "ROLE")

        'BtnUncanceled.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0705", "ROLE")
        'BtnUnclosed.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0706", "ROLE")
        'BtnUnDelivered.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0707", "ROLE")

    End Sub



    Private Sub btnSeacthKoNo_Click(sender As Object, e As EventArgs) Handles btnSeacthKoNo.Click
        Dim frm As New frmSearchKO
        Dim _ProductionOrderTypeId As Nullable(Of Int64)
        Dim drv As DataRowView = TryCast(cboProdType.SelectedItem, DataRowView)
        If drv IsNot Nothing Then
            _ProductionOrderTypeId = oConfig.IsNull(drv("lookup_value_id"), 0) '.ToString()
        End If

        frm.pProductionOrderTypeId = _ProductionOrderTypeId
        frm.ShowDialog(Me)
        Me.Cursor = Cursors.WaitCursor
        If frm.pblnOk = True Then
            txtPRODNo.Text = frm.pKono
            ko.kono = frm.pKono
            ko.production_order_id = frm.pProductionOrderId
            Call LoadData(ko:=ko)
            If lblKOClosed.Visible = False Then
                Dim objSecurity As New clsConfig 'Sitthana 20200828
                btnSave.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0708", "ROLE")
            End If 'Sitthana 20200828
        End If

        Me.Cursor = Cursors.Default
        frm.Dispose()
    End Sub
    Private Sub txtKONo_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPRODNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            ko.kono = txtPRODNo.Text.Trim
            Call LoadData(ko:=ko)
            If lblKOClosed.Visible = False Then
                Dim objSecurity As New clsConfig 'Sitthana 20200828
                btnSave.Enabled = objSecurity.UserAccess(UserInfo.UserID, "R0708", "ROLE")
            End If 'Sitthana 20200828
        End If
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim result As DialogResult 'Windows.Forms.DialogResult
            result = MessageBox.Show("Would you like to change qty ?", "System Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
            ' If result = Windows.Forms.DialogResult.Cancel Then blnCancel = True
            If result <> DialogResult.OK Then Exit Sub

            If grdmfg_production_order_lines.Rows.Count > 0 Then
                For Each dgvr As DataGridViewRow In grdmfg_production_order_lines.Rows
                    If dgvr.Cells("colLineType").Value = "1" Then
                        dgvr.Cells("plan_qty").Value = dgvr.Cells("bom_perc").Value * Val(txtQty.Text) / 100
                    End If
                    If dgvr.Cells("colLineType").Value = "-1" Then
                        dgvr.Cells("plan_qty").Value = dgvr.Cells("bom_perc").Value * Val(txtQty.Text) / 100
                    End If
                Next
            End If

        End If
    End Sub

    Private Sub McboIDYarnChange_DropDownCloseOnClick(sender As Object, args As MouseClickCancelEventArgs) Handles McboIDYarnChange.DropDownCloseOnClick
        Call BindBomLine()
    End Sub

    Private Sub BindBomLine()
        '================================= Delete if Actual Qty > 0 ===========================================
        'For i = 0 To dtmfg_production_order_lines.Rows.Count - 1
        '    If Not dtmfg_production_order_lines.Rows(i).RowState = DataRowState.Deleted Then
        '        If Not (New clsConfig).IsNull(dtmfg_production_order_lines.Rows(i)("actual_qty"), 0) > 0 Then
        '            dtmfg_production_order_lines.Rows(i).Delete()
        '        End If
        '    End If
        'Next

        For Each drOld As DataRow In dtMfgProductionOrderLines.Rows
            If Not drOld.RowState = DataRowState.Deleted Then
                If Not (New clsConfig).IsNull(drOld("actual_qty"), 0) > 0 Then
                    drOld.Delete()
                End If
            End If
        Next

        '================================= Add if Item Not Exist    ===========================================
        'Dim dt = (New classProduction).GetBom((New clsConfig).IsNull(Me.McboIDYarnChange.ListBox.Grid.Model(Me.McboIDYarnChange.SelectedIndex + 1, 1).CellValue, String.Empty), Val(txtQty.Text), cboUOM.SelectedValue, cboMachineNo.SelectedValue)
        'Sittthana 20200901
        Dim dt As New DataTable
        Dim isDuplicate As Boolean = False

        dt = (New classProduction).GetBom((New clsConfig).IsNull(Me.McboIDYarnChange.ListBox.Grid.Model(Me.McboIDYarnChange.SelectedIndex + 1, 1).CellValue, String.Empty) _
                                         , Val(txtQty.Text) _
                                         , cboUOM.SelectedValue _
                                         , txtMachineNo.Text.Trim)
        For Each dr As DataRow In dt.Rows
            isDuplicate = False
            For Each drOld As DataRow In dtMfgProductionOrderLines.Rows
                If Not drOld.RowState = DataRowState.Deleted Then
                    'If dr("item_id") = drOld("item_id") Then
                    If (New clsConfig).IsNull(dr("bom_header_id"), 0) = (New clsConfig).IsNull(drOld("bom_header_id"), 0) And
                        (New clsConfig).IsNull(dr("bom_line_id"), 0) = (New clsConfig).IsNull(drOld("bom_line_id"), 0) And
                        (New clsConfig).IsNull(dr("itcd"), "") = (New clsConfig).IsNull(drOld("itcd"), "") Then
                        isDuplicate = True
                    End If

                End If
            Next
            If Not isDuplicate Then dtMfgProductionOrderLines.ImportRow(dr)
        Next

        bsMfgProductionOrderLines.DataSource = dtMfgProductionOrderLines
        bsMfgProductionOrderLines.MoveFirst()
        bsMfgProductionOrderLines.EndEdit()
        bsMfgProductionOrderLines.Sort = ("line_type desc,bom_line_id asc,itcd asc")

        grdmfg_production_order_lines.Refresh()

    End Sub

    Private Sub btnAddBomLine_Click(sender As Object, e As EventArgs) Handles btnAddBomLine.Click
        Call AddMaterailLine()
    End Sub

    Private Sub AddMaterailLine()
        Dim frm As New frmSelectItems
        frm.ShowDialog(Me)
        If frm.pblnOk <> True Then Exit Sub
        Dim drNew As DataRow = dtMfgProductionOrderLines.NewRow()
        drNew("item_id") = frm.pItemID
        drNew("itcd") = frm.pItcd
        drNew("itdesc") = frm.pItdesc
        drNew("line_type") = "-1"
        drNew("mtl_warehouse_id") = "4"
        drNew("warehouse_code") = "ESH"
        drNew("uom_id") = frm.pUomID
        drNew("uom") = frm.pUom
        '==================================   Check Dupicate Items ============================
        Dim isDuplicate As Boolean = False
        ' For Each dr As DataRow In dt.Rows
        isDuplicate = False
        For Each drOld As DataRow In dtMfgProductionOrderLines.Rows
            If Not drOld.RowState = DataRowState.Deleted Then
                If drNew("item_id") = drOld("item_id") Then
                    isDuplicate = True
                End If
            End If
        Next
        If Not isDuplicate Then dtMfgProductionOrderLines.Rows.Add(drNew) 'dtmfg_production_order_lines.ImportRow(dr)
        bsMfgProductionOrderLines.EndEdit()
    End Sub

    Private Sub btnAddBomHeader_Click(sender As Object, e As EventArgs) Handles btnAddBomHeader.Click
        Dim drjoblineNew As DataRow = dtMfgProductionOrderLines.NewRow()
        'Dim dt As DataTable = (New classJobCard)
        drjoblineNew("line_type") = "1"
        drjoblineNew("mtl_warehouse_id") = "4"
        drjoblineNew("warehouse_code") = "ESH"
        dtMfgProductionOrderLines.Rows.Add(drjoblineNew)
        bsMfgProductionOrderLines.EndEdit()
    End Sub

    Private Sub btnDeleteBomLine_Click(sender As Object, e As EventArgs) Handles btnDeleteBomLine.Click

        If (New clsConfig).IsNull(bsMfgProductionOrderLines.Current("actual_qty"), 0) > 0 Then
            MessageBox.Show("ไม่สามารถลบ Line นีได้เนื่องจาก Actual Qty > 0")
            Exit Sub
        End If

        bsMfgProductionOrderLines.RemoveCurrent()
        bsMfgProductionOrderLines.EndEdit()
        grdmfg_production_order_lines.Refresh()
    End Sub

    Private Sub grdmfg_production_order_lines_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdmfg_production_order_lines.CellDoubleClick
        Dim currentColIndex As Integer = grdmfg_production_order_lines.CurrentCell.ColumnIndex
        Dim currentColName As String = grdmfg_production_order_lines.Columns(currentColIndex).Name
        Dim dgr As DataGridViewRow = grdmfg_production_order_lines.CurrentRow
        If currentColName = "colItemId" Or currentColName = "colItcd" Or currentColName = "colItdesc" Then
            'If Not CheckChangeBomItems(MfgProductionOrderLinesId:=(New clsConfig).IsNull(dgr.Cells("colMfgProductionOrderLinesId").Value, Nothing)) Then Exit Sub 'Add by Neung 20200217
            Dim frmSelectItems As New frmSelectItems
            frmSelectItems.ShowDialog(Me)
            If frmSelectItems.pblnOk = True Then
                dgr.Cells("colItemID").Value = frmSelectItems.pItemID
                dgr.Cells("colItcd").Value = frmSelectItems.pItcd
                dgr.Cells("colItdesc").Value = frmSelectItems.pItdesc
                dgr.Cells("collineuomid").Value = frmSelectItems.pUomID
                dgr.Cells("collineuom").Value = frmSelectItems.pUom
            End If
        End If

        If currentColName = "colMtlWarehouseId" Or currentColName = "colWarehouseCode" Then
            Dim frmSelectMtlWareHouse As New frmSelectMtlWareHouse
            frmSelectMtlWareHouse.ShowDialog(Me)
            If frmSelectMtlWareHouse.pblnOk = True Then
                dgr.Cells("colMtlWarehouseId").Value = frmSelectMtlWareHouse.pMtlwarehouseid
                dgr.Cells("colWareHouseCode").Value = frmSelectMtlWareHouse.pWarehouseCode
                dgr.Cells("colSourceSubinventoryId").Value = DBNull.Value
                dgr.Cells("colSourceSubInventoryCode").Value = DBNull.Value
            End If
        End If

        If currentColName = "colSourceSubinventoryId" Or currentColName = "colSourceSubInventoryCode" Then
            If Not dgr.Cells("colMtlWarehouseId").Value Is DBNull.Value Then
                'If (New clsConfig).IsNull(dgr.Cells("colMtlWarehouseId").Value, 0) > 0 Then
                Dim frmSelectMtlSubinventory As New frmSelectMtlSubinventory
                frmSelectMtlSubinventory.pMtlwarehouseid = dgr.Cells("colMtlWarehouseId").Value
                frmSelectMtlSubinventory.ShowDialog(Me)
                If frmSelectMtlSubinventory.pblnOk = True Then
                    dgr.Cells("colSourceSubinventoryId").Value = frmSelectMtlSubinventory.pmtlsubinventoryid
                    dgr.Cells("colSourceSubInventoryCode").Value = frmSelectMtlSubinventory.pSubinventorycode
                End If
            End If
        End If

        If currentColName = "collineUOMId" Or currentColName = "collineuom" Then
            Dim frmSelectUOM As New frmSelectUOM
            frmSelectUOM.ShowDialog(Me)
            If frmSelectUOM.pblnOk = True Then
                dgr.Cells("collineUOMId").Value = frmSelectUOM.pUOMID
                dgr.Cells("collineUOM").Value = frmSelectUOM.pUOM
            End If
        End If

        If currentColName = "colOperationCode" Then
            Dim frm As New frmSelectMfgProductionSteps
            frm.pProductionOrderNo = txtPRODNo.Text.Trim 'dgr.Cells("colMtlWarehouseId").Value
            frm.ShowDialog(Me)
            If frm.pblnOk = True Then
                dgr.Cells("colMfgProductionStepsId").Value = frm.pMfgProductionStepsId
                dgr.Cells("colOperationCode").Value = frm.pOperationCode
            End If
        End If

    End Sub

    Private Function CheckChangeBomItems(ByVal MfgProductionOrderLinesId As Nullable(Of Int64))
        If Not (New classProduction).CheckChangeBomItems(txtPRODNo.Text, MfgProductionOrderLinesId, clsUser.UserID) Then
            MessageBox.Show("ไม่สามารถแก้ไข Bom Item นี้ได้ ,เนื่องจากเปิด Production order ไปแล้ว" & vbCrLf & vbCrLf & "It Cannot Change Bom Items ,Because Production Order Open Already ", "System Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End If

        Return True
    End Function

    Private Sub txtPRODNo_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtPRODNo.PreviewKeyDown
        ' Dim result As System.Windows.Forms.DialogResult
        Select Case e.KeyCode
            Case Keys.Up
                'result = MessageBox.Show("Would you like to Load K/O No:" & vbCrLf & txtPRODNo.Text & " ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                'If result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub
                ko.kono = txtPRODNo.Text.Trim
                Call LoadData(ko:=ko)
            Case Keys.Down
                'Result = MessageBox.Show("Would you like to Load K/O No:" & vbCrLf & txtPRODNo.Text & " ?", "System Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3)
                'If Result <> System.Windows.Forms.DialogResult.Yes Then Exit Sub
                ko.kono = txtPRODNo.Text.Trim
                Call LoadData(ko:=ko)
        End Select
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomer.SelectedIndexChanged

    End Sub

    Private Sub btnMcNoSearch_Click(sender As Object, e As EventArgs) Handles btnMcNoSearch.Click
        'Sitthana 20200901
        Dim f = New Classes.frmSearchMachine
        Dim drv As DataRowView
        Dim SearchResult As New Classes.SearchFormResult

        ' pass nothing to use default connection string inside the class or pass your connection object if need to use different from default.
        f.setConnectionString(clsConn.getSQLConnection)
        f.logempcd = clsUser.UserID

        SearchResult = f.ShowFrm
        f.Close()
        f.Dispose()
        If SearchResult.ButtonClicked = "OK" Then
            drv = SearchResult.ResultRowView
            'cboMachineNo.SelectedIndex = cboMachineNo.FindString(drv.Item("mcno"))
            txtMachineNo.Text = drv.Item("mcno")
        End If
    End Sub

    Private Sub BtnDelivered_Click(sender As Object, e As EventArgs) Handles BtnDelivered.Click

    End Sub
End Class