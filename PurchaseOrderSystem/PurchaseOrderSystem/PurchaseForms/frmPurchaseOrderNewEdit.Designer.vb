<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPurchaseOrderNewEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseOrderNewEdit))
        Me.dgvJobDet = New System.Windows.Forms.DataGridView()
        Me.colIdJobdet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSoNoId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supdes_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itdesc_supp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSuppitcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supquoteno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMfgProductionOrderLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rcv_warehouse_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWareHouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rcv_subinventory_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSourceSubInventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colQty2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colUom2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colItemUnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFreightPerUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDiscamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGrossLineamt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRemark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.buttonViewHistory = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelidt = New PurchaseOrderSystem.DataGridViewCalendarColumn()
        Me.ColEffectiveDate = New PurchaseOrderSystem.DataGridViewCalendarColumn()
        Me.recycle_trans_report_rcvd_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.supplier_spec_rcvd_flag = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnTransFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnYarnFile = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.contextMenuGrid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeeHistoryForThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnApplyDelidt = New System.Windows.Forms.Button()
        Me.txtremark = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpackcd = New System.Windows.Forms.TextBox()
        Me.dtpDelidt = New System.Windows.Forms.DateTimePicker()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.btnGetBOMLine = New System.Windows.Forms.Button()
        Me.btnGetSoItmData = New System.Windows.Forms.Button()
        Me.comboItemNature = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.mcboPoLineType = New PurchaseOrderSystem.Controls.MultiColumnComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbPriceIncudingVat = New System.Windows.Forms.CheckBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtNetOrderAmount = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtNetLineAmount = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtGrossLineDiscount = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtDisper = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtGrossLineamount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtDiscountamount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.txtVatAmount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpaDeliveryDate = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaPayDate = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaLCDate = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txtLCNo = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.checkImport = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDeliAddr = New System.Windows.Forms.TextBox()
        Me.txtdeliveryday = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCrdays = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpaArrival = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaAWB_date = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaBL_date = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaInvoice_date = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaPacking_date = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaDeparture = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.dtpaAWB_Received_date = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.txtPortName = New System.Windows.Forms.ComboBox()
        Me.txtVehicleName = New System.Windows.Forms.ComboBox()
        Me.txtBenefit = New System.Windows.Forms.ComboBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.dtpaQuotationDate = New PurchaseOrderSystem.Controls.NullableDateTimePicker()
        Me.txtBenefitKgs = New System.Windows.Forms.TextBox()
        Me.epcboCurrency = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txtPackingRemark = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtBLNo = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtPackingNo = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txtBenefitAmount = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtAgencyName = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtPeriod = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtFreight = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.cboForwarder = New System.Windows.Forms.ComboBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.lblAWP_Date = New System.Windows.Forms.Label()
        Me.lblAWBreceived_date = New System.Windows.Forms.Label()
        Me.txtAWB_no = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lblPackdt = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmailCC = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.txtEmailTo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.chkValidateQtyCone = New System.Windows.Forms.CheckBox()
        Me.txtCrterm = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.txtPayModeCd = New System.Windows.Forms.TextBox()
        Me.btnSuppSearch = New System.Windows.Forms.Button()
        Me.cboPaymentTerm = New System.Windows.Forms.ComboBox()
        Me.cboIncoTerms = New System.Windows.Forms.ComboBox()
        Me.cboShipvia = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtQuotationNo = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DataGridViewCalendarColumn1 = New PurchaseOrderSystem.DataGridViewCalendarColumn()
        Me.txtrate = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbNew = New System.Windows.Forms.ToolStripButton()
        Me.tsbSave = New System.Windows.Forms.ToolStripButton()
        Me.btnApprove = New System.Windows.Forms.ToolStripButton()
        Me.btnClosed = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrint = New System.Windows.Forms.ToolStripSplitButton()
        Me.tsbPrintPO = New System.Windows.Forms.ToolStripMenuItem()
        Me.A4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.tsbMinimized = New System.Windows.Forms.ToolStripButton()
        Me.tsbExit = New System.Windows.Forms.ToolStripButton()
        Me.epcboPaymentTerm = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPresentStatus = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPoReqNo = New System.Windows.Forms.Button()
        Me.textReqno = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.comboEmp = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.epItemGrid = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epcomboEmp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.eptxtrate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cboCurrency = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.epcboSupplier = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gboxNewDoc = New System.Windows.Forms.GroupBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.buttonSearchPO = New System.Windows.Forms.Button()
        Me.txtPurNo = New System.Windows.Forms.TextBox()
        Me.DateYIN = New System.Windows.Forms.DateTimePicker()
        Me.lblYINno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.epSaved = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epmcboPoLineType = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridViewCalendarColumn2 = New PurchaseOrderSystem.DataGridViewCalendarColumn()
        Me.coltest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.epcboDept = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epItemNature = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.epPresentStatus = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.textSupQuoteno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.dgvJobDet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextMenuGrid.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.mcboPoLineType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtpaDeliveryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaPayDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaLCDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaArrival, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaAWB_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaBL_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaInvoice_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaPacking_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaDeparture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaAWB_Received_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpaQuotationDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epcboCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.epcboPaymentTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.epItemGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epcomboEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eptxtrate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epcboSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxNewDoc.SuspendLayout()
        CType(Me.epSaved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epmcboPoLineType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.epcboDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epItemNature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.epPresentStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvJobDet
        '
        Me.dgvJobDet.AllowUserToOrderColumns = True
        Me.dgvJobDet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvJobDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvJobDet.ColumnHeadersHeight = 35
        Me.dgvJobDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdJobdet, Me.colSoNo, Me.colSoNoId, Me.colItemId, Me.colItcd, Me.colItdesc, Me.supdes_no, Me.itdesc_supp, Me.colSuppitcd, Me.supquoteno, Me.colMfgProductionOrderLineId, Me.rcv_warehouse_id, Me.colWareHouseCode, Me.rcv_subinventory_id, Me.colSourceSubInventoryCode, Me.colQty, Me.colUom, Me.colQty2, Me.colUom2, Me.colItemUnitPrice, Me.colFreightPerUnit, Me.colPrice, Me.colDiscper, Me.colDiscamt, Me.colLineamt, Me.colGrossLineamt, Me.colRemark, Me.buttonViewHistory, Me.colDelidt, Me.ColEffectiveDate, Me.recycle_trans_report_rcvd_flag, Me.supplier_spec_rcvd_flag, Me.btnTransFile, Me.btnYarnFile})
        Me.dgvJobDet.ContextMenuStrip = Me.contextMenuGrid
        Me.dgvJobDet.Location = New System.Drawing.Point(5, 32)
        Me.dgvJobDet.Name = "dgvJobDet"
        Me.dgvJobDet.Size = New System.Drawing.Size(1061, 248)
        Me.dgvJobDet.TabIndex = 18
        '
        'colIdJobdet
        '
        Me.colIdJobdet.DataPropertyName = "id_jobdet"
        Me.colIdJobdet.Frozen = True
        Me.colIdJobdet.HeaderText = "P/O Line ID"
        Me.colIdJobdet.Name = "colIdJobdet"
        Me.colIdJobdet.Width = 50
        '
        'colSoNo
        '
        Me.colSoNo.DataPropertyName = "sono"
        Me.colSoNo.Frozen = True
        Me.colSoNo.HeaderText = "S/O No."
        Me.colSoNo.Name = "colSoNo"
        Me.colSoNo.Width = 90
        '
        'colSoNoId
        '
        Me.colSoNoId.DataPropertyName = "sonoid"
        Me.colSoNoId.Frozen = True
        Me.colSoNoId.HeaderText = "S/O No. Line"
        Me.colSoNoId.Name = "colSoNoId"
        '
        'colItemId
        '
        Me.colItemId.DataPropertyName = "item_id"
        Me.colItemId.Frozen = True
        Me.colItemId.HeaderText = "Item ID"
        Me.colItemId.Name = "colItemId"
        Me.colItemId.Visible = False
        '
        'colItcd
        '
        Me.colItcd.DataPropertyName = "itcd"
        Me.colItcd.Frozen = True
        Me.colItcd.HeaderText = "Item code"
        Me.colItcd.Name = "colItcd"
        Me.colItcd.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colItcd.Width = 150
        '
        'colItdesc
        '
        Me.colItdesc.DataPropertyName = "itdesc"
        Me.colItdesc.HeaderText = "Item Description Supp. & Additional"
        Me.colItdesc.Name = "colItdesc"
        Me.colItdesc.Width = 250
        '
        'supdes_no
        '
        Me.supdes_no.DataPropertyName = "supdes_no"
        Me.supdes_no.HeaderText = "Supplier Design"
        Me.supdes_no.Name = "supdes_no"
        '
        'itdesc_supp
        '
        Me.itdesc_supp.DataPropertyName = "itdesc_supp"
        Me.itdesc_supp.HeaderText = "Description (Supp)"
        Me.itdesc_supp.Name = "itdesc_supp"
        Me.itdesc_supp.ReadOnly = True
        Me.itdesc_supp.Visible = False
        Me.itdesc_supp.Width = 250
        '
        'colSuppitcd
        '
        Me.colSuppitcd.DataPropertyName = "suppitcd"
        Me.colSuppitcd.HeaderText = "Supp. Item Code Ref."
        Me.colSuppitcd.Name = "colSuppitcd"
        Me.colSuppitcd.Width = 85
        '
        'supquoteno
        '
        Me.supquoteno.DataPropertyName = "supquoteno"
        Me.supquoteno.HeaderText = "Production No."
        Me.supquoteno.Name = "supquoteno"
        Me.supquoteno.ReadOnly = True
        '
        'colMfgProductionOrderLineId
        '
        Me.colMfgProductionOrderLineId.DataPropertyName = "mfg_production_order_line_id"
        Me.colMfgProductionOrderLineId.HeaderText = "Production Line"
        Me.colMfgProductionOrderLineId.Name = "colMfgProductionOrderLineId"
        Me.colMfgProductionOrderLineId.ReadOnly = True
        '
        'rcv_warehouse_id
        '
        Me.rcv_warehouse_id.DataPropertyName = "rcv_warehouse_id"
        Me.rcv_warehouse_id.HeaderText = "W/H"
        Me.rcv_warehouse_id.Name = "rcv_warehouse_id"
        Me.rcv_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rcv_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rcv_warehouse_id.Visible = False
        Me.rcv_warehouse_id.Width = 80
        '
        'colWareHouseCode
        '
        Me.colWareHouseCode.DataPropertyName = "warehouse_code"
        Me.colWareHouseCode.HeaderText = "W/H Code"
        Me.colWareHouseCode.Name = "colWareHouseCode"
        Me.colWareHouseCode.ReadOnly = True
        '
        'rcv_subinventory_id
        '
        Me.rcv_subinventory_id.DataPropertyName = "rcv_subinventory_id"
        Me.rcv_subinventory_id.HeaderText = "Sub Inventory"
        Me.rcv_subinventory_id.Name = "rcv_subinventory_id"
        Me.rcv_subinventory_id.ReadOnly = True
        Me.rcv_subinventory_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rcv_subinventory_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.rcv_subinventory_id.Visible = False
        Me.rcv_subinventory_id.Width = 80
        '
        'colSourceSubInventoryCode
        '
        Me.colSourceSubInventoryCode.DataPropertyName = "subinventory_code"
        Me.colSourceSubInventoryCode.HeaderText = "Sub Inventory Code"
        Me.colSourceSubInventoryCode.Name = "colSourceSubInventoryCode"
        Me.colSourceSubInventoryCode.ReadOnly = True
        '
        'colQty
        '
        Me.colQty.DataPropertyName = "qty"
        Me.colQty.HeaderText = "Quantity"
        Me.colQty.MaxInputLength = 15
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 80
        '
        'colUom
        '
        Me.colUom.DataPropertyName = "uom_id"
        Me.colUom.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colUom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colUom.HeaderText = "Unit"
        Me.colUom.Name = "colUom"
        Me.colUom.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colUom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colUom.Width = 70
        '
        'colQty2
        '
        Me.colQty2.DataPropertyName = "qty2"
        Me.colQty2.HeaderText = "Quantity2"
        Me.colQty2.Name = "colQty2"
        Me.colQty2.Width = 80
        '
        'colUom2
        '
        Me.colUom2.DataPropertyName = "uom2_id"
        Me.colUom2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.colUom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colUom2.HeaderText = "Uom2"
        Me.colUom2.Name = "colUom2"
        Me.colUom2.Width = 70
        '
        'colItemUnitPrice
        '
        Me.colItemUnitPrice.DataPropertyName = "item_unit_price"
        Me.colItemUnitPrice.HeaderText = "Raw Materials Price"
        Me.colItemUnitPrice.Name = "colItemUnitPrice"
        '
        'colFreightPerUnit
        '
        Me.colFreightPerUnit.DataPropertyName = "freight_per_unit"
        Me.colFreightPerUnit.HeaderText = "Freight Per Unit"
        Me.colFreightPerUnit.Name = "colFreightPerUnit"
        '
        'colPrice
        '
        Me.colPrice.DataPropertyName = "price"
        Me.colPrice.HeaderText = "Unit price"
        Me.colPrice.MaxInputLength = 15
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Width = 60
        '
        'colDiscper
        '
        Me.colDiscper.DataPropertyName = "discper"
        DataGridViewCellStyle1.Format = "N2"
        Me.colDiscper.DefaultCellStyle = DataGridViewCellStyle1
        Me.colDiscper.HeaderText = "Disc.%"
        Me.colDiscper.Name = "colDiscper"
        Me.colDiscper.Width = 50
        '
        'colDiscamt
        '
        Me.colDiscamt.DataPropertyName = "discamt"
        DataGridViewCellStyle2.Format = "N2"
        Me.colDiscamt.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDiscamt.HeaderText = "Discount Amount"
        Me.colDiscamt.MaxInputLength = 15
        Me.colDiscamt.Name = "colDiscamt"
        Me.colDiscamt.Width = 75
        '
        'colLineamt
        '
        Me.colLineamt.DataPropertyName = "lineamt"
        Me.colLineamt.HeaderText = "Line Amount"
        Me.colLineamt.Name = "colLineamt"
        '
        'colGrossLineamt
        '
        Me.colGrossLineamt.DataPropertyName = "gross_lineamt"
        Me.colGrossLineamt.HeaderText = "Gross Line Amount"
        Me.colGrossLineamt.Name = "colGrossLineamt"
        Me.colGrossLineamt.Visible = False
        '
        'colRemark
        '
        Me.colRemark.DataPropertyName = "rem"
        Me.colRemark.HeaderText = "Remark"
        Me.colRemark.Name = "colRemark"
        '
        'buttonViewHistory
        '
        Me.buttonViewHistory.HeaderText = ""
        Me.buttonViewHistory.Name = "buttonViewHistory"
        Me.buttonViewHistory.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.buttonViewHistory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.buttonViewHistory.Text = "History"
        Me.buttonViewHistory.UseColumnTextForButtonValue = True
        Me.buttonViewHistory.Width = 50
        '
        'colDelidt
        '
        Me.colDelidt.DataPropertyName = "delidt"
        Me.colDelidt.HeaderText = "Deli Date"
        Me.colDelidt.Name = "colDelidt"
        '
        'ColEffectiveDate
        '
        Me.ColEffectiveDate.DataPropertyName = "effective_date"
        Me.ColEffectiveDate.HeaderText = "Effective Date"
        Me.ColEffectiveDate.Name = "ColEffectiveDate"
        '
        'recycle_trans_report_rcvd_flag
        '
        Me.recycle_trans_report_rcvd_flag.DataPropertyName = "recycle_trans_report_rcvd_flag"
        Me.recycle_trans_report_rcvd_flag.HeaderText = "Recycle Trans Rec."
        Me.recycle_trans_report_rcvd_flag.Name = "recycle_trans_report_rcvd_flag"
        Me.recycle_trans_report_rcvd_flag.ReadOnly = True
        Me.recycle_trans_report_rcvd_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.recycle_trans_report_rcvd_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.recycle_trans_report_rcvd_flag.Width = 50
        '
        'supplier_spec_rcvd_flag
        '
        Me.supplier_spec_rcvd_flag.DataPropertyName = "supplier_spec_rcvd_flag"
        Me.supplier_spec_rcvd_flag.HeaderText = "Supp. Spec Received"
        Me.supplier_spec_rcvd_flag.Name = "supplier_spec_rcvd_flag"
        Me.supplier_spec_rcvd_flag.ReadOnly = True
        Me.supplier_spec_rcvd_flag.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supplier_spec_rcvd_flag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.supplier_spec_rcvd_flag.Width = 50
        '
        'btnTransFile
        '
        Me.btnTransFile.DataPropertyName = "btnTransFile"
        Me.btnTransFile.HeaderText = "Trans File"
        Me.btnTransFile.Name = "btnTransFile"
        Me.btnTransFile.Text = "Load"
        Me.btnTransFile.Width = 50
        '
        'btnYarnFile
        '
        Me.btnYarnFile.DataPropertyName = "btnYarnFile"
        Me.btnYarnFile.HeaderText = "Yarn File"
        Me.btnYarnFile.Name = "btnYarnFile"
        Me.btnYarnFile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.btnYarnFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.btnYarnFile.Text = "Load"
        Me.btnYarnFile.Width = 50
        '
        'contextMenuGrid
        '
        Me.contextMenuGrid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeeHistoryForThisItemToolStripMenuItem})
        Me.contextMenuGrid.Name = "contextMenuGrid"
        Me.contextMenuGrid.Size = New System.Drawing.Size(199, 26)
        '
        'SeeHistoryForThisItemToolStripMenuItem
        '
        Me.SeeHistoryForThisItemToolStripMenuItem.Name = "SeeHistoryForThisItemToolStripMenuItem"
        Me.SeeHistoryForThisItemToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SeeHistoryForThisItemToolStripMenuItem.Text = "See history for this item"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnApplyDelidt)
        Me.TabPage2.Controls.Add(Me.txtremark)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtpackcd)
        Me.TabPage2.Controls.Add(Me.dtpDelidt)
        Me.TabPage2.Controls.Add(Me.Label67)
        Me.TabPage2.Controls.Add(Me.btnGetBOMLine)
        Me.TabPage2.Controls.Add(Me.dgvJobDet)
        Me.TabPage2.Controls.Add(Me.btnGetSoItmData)
        Me.TabPage2.Controls.Add(Me.comboItemNature)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.Label58)
        Me.TabPage2.Controls.Add(Me.mcboPoLineType)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1073, 515)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Item details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnApplyDelidt
        '
        Me.btnApplyDelidt.Image = Global.PurchaseOrderSystem.My.Resources.Resources.ConfirmButton_16x
        Me.btnApplyDelidt.Location = New System.Drawing.Point(888, 5)
        Me.btnApplyDelidt.Name = "btnApplyDelidt"
        Me.btnApplyDelidt.Size = New System.Drawing.Size(106, 23)
        Me.btnApplyDelidt.TabIndex = 420
        Me.btnApplyDelidt.Text = "Apply to grid"
        Me.btnApplyDelidt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApplyDelidt.UseVisualStyleBackColor = True
        '
        'txtremark
        '
        Me.txtremark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtremark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtremark.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremark.Location = New System.Drawing.Point(9, 410)
        Me.txtremark.Multiline = True
        Me.txtremark.Name = "txtremark"
        Me.txtremark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtremark.Size = New System.Drawing.Size(296, 72)
        Me.txtremark.TabIndex = 389
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 390
        Me.Label9.Text = "Packing instruction:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 390)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 391
        Me.Label4.Text = "Remarks:"
        '
        'txtpackcd
        '
        Me.txtpackcd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpackcd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpackcd.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpackcd.Location = New System.Drawing.Point(9, 312)
        Me.txtpackcd.Multiline = True
        Me.txtpackcd.Name = "txtpackcd"
        Me.txtpackcd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtpackcd.Size = New System.Drawing.Size(296, 75)
        Me.txtpackcd.TabIndex = 388
        '
        'dtpDelidt
        '
        Me.dtpDelidt.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDelidt.CustomFormat = "dd/MM/yyyy"
        Me.dtpDelidt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDelidt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDelidt.Location = New System.Drawing.Point(786, 6)
        Me.dtpDelidt.Name = "dtpDelidt"
        Me.dtpDelidt.Size = New System.Drawing.Size(96, 22)
        Me.dtpDelidt.TabIndex = 418
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(711, 10)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(74, 13)
        Me.Label67.TabIndex = 421
        Me.Label67.Text = "Delivery Date"
        '
        'btnGetBOMLine
        '
        Me.btnGetBOMLine.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Import_16x
        Me.btnGetBOMLine.Location = New System.Drawing.Point(132, 3)
        Me.btnGetBOMLine.Name = "btnGetBOMLine"
        Me.btnGetBOMLine.Size = New System.Drawing.Size(123, 26)
        Me.btnGetBOMLine.TabIndex = 169
        Me.btnGetBOMLine.Text = "Get BOM Line"
        Me.btnGetBOMLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGetBOMLine.UseVisualStyleBackColor = True
        Me.btnGetBOMLine.Visible = False
        '
        'btnGetSoItmData
        '
        Me.btnGetSoItmData.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Import_16x
        Me.btnGetSoItmData.Location = New System.Drawing.Point(3, 3)
        Me.btnGetSoItmData.Name = "btnGetSoItmData"
        Me.btnGetSoItmData.Size = New System.Drawing.Size(123, 26)
        Me.btnGetSoItmData.TabIndex = 168
        Me.btnGetSoItmData.Text = "Get S/O Item Data"
        Me.btnGetSoItmData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGetSoItmData.UseVisualStyleBackColor = True
        '
        'comboItemNature
        '
        Me.comboItemNature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboItemNature.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboItemNature.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboItemNature.FormattingEnabled = True
        Me.comboItemNature.Location = New System.Drawing.Point(361, 8)
        Me.comboItemNature.Name = "comboItemNature"
        Me.comboItemNature.Size = New System.Drawing.Size(131, 21)
        Me.comboItemNature.TabIndex = 394
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(267, 11)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(70, 13)
        Me.Label35.TabIndex = 395
        Me.Label35.Text = "Item Nature:"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(498, 11)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(54, 13)
        Me.Label58.TabIndex = 397
        Me.Label58.Text = "Line Type"
        '
        'mcboPoLineType
        '
        Me.mcboPoLineType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mcboPoLineType.DataSource = Nothing
        Me.mcboPoLineType.DisplayMember = Nothing
        Me.mcboPoLineType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcboPoLineType.Location = New System.Drawing.Point(558, 8)
        Me.mcboPoLineType.Name = "mcboPoLineType"
        Me.mcboPoLineType.SelectedIndex = -1
        Me.mcboPoLineType.SelectedValue = Nothing
        Me.mcboPoLineType.Size = New System.Drawing.Size(147, 21)
        Me.mcboPoLineType.TabIndex = 398
        Me.mcboPoLineType.ValueMember = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbPriceIncudingVat)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtNetOrderAmount)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txtNetLineAmount)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txtGrossLineDiscount)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.txtDisper)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtGrossLineamount)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtVat)
        Me.GroupBox2.Controls.Add(Me.txtDiscountamount)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTotalAmount)
        Me.GroupBox2.Controls.Add(Me.txtVatAmount)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(618, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(448, 186)
        Me.GroupBox2.TabIndex = 387
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Amount:"
        '
        'cbPriceIncudingVat
        '
        Me.cbPriceIncudingVat.AutoSize = True
        Me.cbPriceIncudingVat.Location = New System.Drawing.Point(74, 160)
        Me.cbPriceIncudingVat.Name = "cbPriceIncudingVat"
        Me.cbPriceIncudingVat.Size = New System.Drawing.Size(111, 17)
        Me.cbPriceIncudingVat.TabIndex = 154
        Me.cbPriceIncudingVat.Text = "Price Include Vat"
        Me.cbPriceIncudingVat.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(242, 106)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(108, 13)
        Me.Label34.TabIndex = 151
        Me.Label34.Text = "Net Order Amount :"
        '
        'txtNetOrderAmount
        '
        Me.txtNetOrderAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetOrderAmount.Enabled = False
        Me.txtNetOrderAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetOrderAmount.Location = New System.Drawing.Point(352, 103)
        Me.txtNetOrderAmount.Name = "txtNetOrderAmount"
        Me.txtNetOrderAmount.Size = New System.Drawing.Size(80, 22)
        Me.txtNetOrderAmount.TabIndex = 29
        Me.txtNetOrderAmount.Text = "0"
        Me.txtNetOrderAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(251, 54)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(99, 13)
        Me.Label33.TabIndex = 149
        Me.Label33.Text = "Net Line Amount :"
        '
        'txtNetLineAmount
        '
        Me.txtNetLineAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetLineAmount.Enabled = False
        Me.txtNetLineAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetLineAmount.Location = New System.Drawing.Point(352, 51)
        Me.txtNetLineAmount.Name = "txtNetLineAmount"
        Me.txtNetLineAmount.Size = New System.Drawing.Size(80, 22)
        Me.txtNetLineAmount.TabIndex = 26
        Me.txtNetLineAmount.Text = "0"
        Me.txtNetLineAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(184, 132)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 13)
        Me.Label32.TabIndex = 147
        Me.Label32.Text = "%"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(184, 80)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(16, 13)
        Me.Label31.TabIndex = 146
        Me.Label31.Text = "%"
        '
        'txtGrossLineDiscount
        '
        Me.txtGrossLineDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossLineDiscount.Enabled = False
        Me.txtGrossLineDiscount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossLineDiscount.Location = New System.Drawing.Point(352, 25)
        Me.txtGrossLineDiscount.Name = "txtGrossLineDiscount"
        Me.txtGrossLineDiscount.Size = New System.Drawing.Size(80, 22)
        Me.txtGrossLineDiscount.TabIndex = 25
        Me.txtGrossLineDiscount.Text = "0"
        Me.txtGrossLineDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(235, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(115, 13)
        Me.Label30.TabIndex = 144
        Me.Label30.Text = "Gross Line Discount :"
        '
        'txtDisper
        '
        Me.txtDisper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDisper.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisper.Location = New System.Drawing.Point(136, 77)
        Me.txtDisper.Name = "txtDisper"
        Me.txtDisper.Size = New System.Drawing.Size(48, 22)
        Me.txtDisper.TabIndex = 1
        Me.txtDisper.Text = "0"
        Me.txtDisper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(92, 13)
        Me.Label21.TabIndex = 143
        Me.Label21.Text = "Order Discount :"
        '
        'txtGrossLineamount
        '
        Me.txtGrossLineamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossLineamount.Enabled = False
        Me.txtGrossLineamount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossLineamount.Location = New System.Drawing.Point(104, 25)
        Me.txtGrossLineamount.Name = "txtGrossLineamount"
        Me.txtGrossLineamount.Size = New System.Drawing.Size(80, 22)
        Me.txtGrossLineamount.TabIndex = 0
        Me.txtGrossLineamount.Text = "0"
        Me.txtGrossLineamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 27)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 13)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "Gross Line Amt :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(217, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Order Discount Amount:"
        '
        'txtVat
        '
        Me.txtVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVat.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVat.Location = New System.Drawing.Point(136, 129)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.Size = New System.Drawing.Size(48, 22)
        Me.txtVat.TabIndex = 2
        Me.txtVat.Text = "0"
        Me.txtVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountamount
        '
        Me.txtDiscountamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscountamount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountamount.Location = New System.Drawing.Point(352, 77)
        Me.txtDiscountamount.Name = "txtDiscountamount"
        Me.txtDiscountamount.Size = New System.Drawing.Size(80, 22)
        Me.txtDiscountamount.TabIndex = 28
        Me.txtDiscountamount.Text = "0"
        Me.txtDiscountamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(69, 132)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 63
        Me.Label17.Text = "VAT :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(274, 132)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 59
        Me.Label15.Text = "VAT Amount :"
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalAmount.Location = New System.Drawing.Point(352, 155)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.Size = New System.Drawing.Size(80, 22)
        Me.txtTotalAmount.TabIndex = 32
        Me.txtTotalAmount.Text = "0"
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVatAmount
        '
        Me.txtVatAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVatAmount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVatAmount.Location = New System.Drawing.Point(352, 129)
        Me.txtVatAmount.Name = "txtVatAmount"
        Me.txtVatAmount.Size = New System.Drawing.Size(80, 22)
        Me.txtVatAmount.TabIndex = 31
        Me.txtVatAmount.Text = "0"
        Me.txtVatAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(192, 157)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(157, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Net Order Amount After VAT :"
        '
        'dtpaDeliveryDate
        '
        Me.dtpaDeliveryDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpaDeliveryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaDeliveryDate.Location = New System.Drawing.Point(828, 193)
        Me.dtpaDeliveryDate.Name = "dtpaDeliveryDate"
        Me.dtpaDeliveryDate.ShowCheckBox = True
        Me.dtpaDeliveryDate.Size = New System.Drawing.Size(127, 20)
        Me.dtpaDeliveryDate.TabIndex = 374
        Me.dtpaDeliveryDate.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaPayDate
        '
        Me.dtpaPayDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpaPayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaPayDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaPayDate.Location = New System.Drawing.Point(96, 191)
        Me.dtpaPayDate.Name = "dtpaPayDate"
        Me.dtpaPayDate.ShowCheckBox = True
        Me.dtpaPayDate.Size = New System.Drawing.Size(127, 20)
        Me.dtpaPayDate.TabIndex = 372
        Me.dtpaPayDate.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaLCDate
        '
        Me.dtpaLCDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpaLCDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaLCDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaLCDate.Location = New System.Drawing.Point(496, 190)
        Me.dtpaLCDate.Name = "dtpaLCDate"
        Me.dtpaLCDate.ShowCheckBox = True
        Me.dtpaLCDate.Size = New System.Drawing.Size(127, 20)
        Me.dtpaLCDate.TabIndex = 371
        Me.dtpaLCDate.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(398, 193)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(50, 13)
        Me.Label45.TabIndex = 157
        Me.Label45.Text = "L/C Date"
        '
        'txtLCNo
        '
        Me.txtLCNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLCNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtLCNo.Location = New System.Drawing.Point(496, 166)
        Me.txtLCNo.MaxLength = 20
        Me.txtLCNo.Name = "txtLCNo"
        Me.txtLCNo.Size = New System.Drawing.Size(232, 20)
        Me.txtLCNo.TabIndex = 154
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(13, 146)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(77, 13)
        Me.Label43.TabIndex = 153
        Me.Label43.Text = "Payment Term"
        '
        'checkImport
        '
        Me.checkImport.AutoSize = True
        Me.checkImport.Enabled = False
        Me.checkImport.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkImport.Location = New System.Drawing.Point(639, 23)
        Me.checkImport.Name = "checkImport"
        Me.checkImport.Size = New System.Drawing.Size(60, 17)
        Me.checkImport.TabIndex = 8
        Me.checkImport.Text = "Import"
        Me.checkImport.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(878, 170)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 13)
        Me.Label29.TabIndex = 151
        Me.Label29.Text = "days"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(13, 243)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 30)
        Me.Label28.TabIndex = 150
        Me.Label28.Text = "INCO terms (CIF,FOB etc.)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(533, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 13)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "Delivery goods to:"
        '
        'txtDeliAddr
        '
        Me.txtDeliAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeliAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDeliAddr.Location = New System.Drawing.Point(639, 46)
        Me.txtDeliAddr.Multiline = True
        Me.txtDeliAddr.Name = "txtDeliAddr"
        Me.txtDeliAddr.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDeliAddr.Size = New System.Drawing.Size(386, 84)
        Me.txtDeliAddr.TabIndex = 10
        '
        'txtdeliveryday
        '
        Me.txtdeliveryday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdeliveryday.Location = New System.Drawing.Point(828, 166)
        Me.txtdeliveryday.Name = "txtdeliveryday"
        Me.txtdeliveryday.Size = New System.Drawing.Size(47, 22)
        Me.txtdeliveryday.TabIndex = 8
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(740, 170)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 145
        Me.Label23.Text = "Delivery:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 144
        Me.Label12.Text = "Pay date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 169)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "Credit:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(740, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 120
        Me.Label10.Text = "Exp. Delivery dt:"
        '
        'cboSupplier
        '
        Me.cboSupplier.DisplayMember = "suppcd"
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(96, 19)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(227, 21)
        Me.cboSupplier.TabIndex = 1
        Me.cboSupplier.ValueMember = "suppcd"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 217)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "Ship via:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(145, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "days"
        '
        'txtCrdays
        '
        Me.txtCrdays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCrdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtCrdays.Location = New System.Drawing.Point(97, 165)
        Me.txtCrdays.Name = "txtCrdays"
        Me.txtCrdays.Size = New System.Drawing.Size(46, 20)
        Me.txtCrdays.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(398, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Credit term:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(96, 46)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(386, 84)
        Me.txtAddress.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Supplier:"
        '
        'dtpaArrival
        '
        Me.dtpaArrival.CustomFormat = "dd/MM/yyyy"
        Me.dtpaArrival.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaArrival.Location = New System.Drawing.Point(896, 159)
        Me.dtpaArrival.Name = "dtpaArrival"
        Me.dtpaArrival.ShowCheckBox = True
        Me.dtpaArrival.Size = New System.Drawing.Size(127, 20)
        Me.dtpaArrival.TabIndex = 376
        Me.dtpaArrival.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaAWB_date
        '
        Me.dtpaAWB_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpaAWB_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaAWB_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaAWB_date.Location = New System.Drawing.Point(896, 100)
        Me.dtpaAWB_date.Name = "dtpaAWB_date"
        Me.dtpaAWB_date.ShowCheckBox = True
        Me.dtpaAWB_date.Size = New System.Drawing.Size(127, 20)
        Me.dtpaAWB_date.TabIndex = 375
        Me.dtpaAWB_date.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaBL_date
        '
        Me.dtpaBL_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpaBL_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaBL_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaBL_date.Location = New System.Drawing.Point(896, 74)
        Me.dtpaBL_date.Name = "dtpaBL_date"
        Me.dtpaBL_date.ShowCheckBox = True
        Me.dtpaBL_date.Size = New System.Drawing.Size(127, 20)
        Me.dtpaBL_date.TabIndex = 374
        Me.dtpaBL_date.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaInvoice_date
        '
        Me.dtpaInvoice_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpaInvoice_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaInvoice_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaInvoice_date.Location = New System.Drawing.Point(896, 47)
        Me.dtpaInvoice_date.Name = "dtpaInvoice_date"
        Me.dtpaInvoice_date.ShowCheckBox = True
        Me.dtpaInvoice_date.Size = New System.Drawing.Size(127, 20)
        Me.dtpaInvoice_date.TabIndex = 373
        Me.dtpaInvoice_date.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaPacking_date
        '
        Me.dtpaPacking_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpaPacking_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaPacking_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaPacking_date.Location = New System.Drawing.Point(896, 21)
        Me.dtpaPacking_date.Name = "dtpaPacking_date"
        Me.dtpaPacking_date.ShowCheckBox = True
        Me.dtpaPacking_date.Size = New System.Drawing.Size(127, 20)
        Me.dtpaPacking_date.TabIndex = 372
        Me.dtpaPacking_date.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaDeparture
        '
        Me.dtpaDeparture.CustomFormat = "dd/MM/yyyy"
        Me.dtpaDeparture.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaDeparture.Location = New System.Drawing.Point(580, 156)
        Me.dtpaDeparture.Name = "dtpaDeparture"
        Me.dtpaDeparture.ShowCheckBox = True
        Me.dtpaDeparture.Size = New System.Drawing.Size(127, 20)
        Me.dtpaDeparture.TabIndex = 371
        Me.dtpaDeparture.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'dtpaAWB_Received_date
        '
        Me.dtpaAWB_Received_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpaAWB_Received_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaAWB_Received_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaAWB_Received_date.Location = New System.Drawing.Point(580, 130)
        Me.dtpaAWB_Received_date.Name = "dtpaAWB_Received_date"
        Me.dtpaAWB_Received_date.ShowCheckBox = True
        Me.dtpaAWB_Received_date.Size = New System.Drawing.Size(127, 20)
        Me.dtpaAWB_Received_date.TabIndex = 370
        Me.dtpaAWB_Received_date.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'txtPortName
        '
        Me.txtPortName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPortName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtPortName.FormattingEnabled = True
        Me.txtPortName.Items.AddRange(New Object() {"", "BKK"})
        Me.txtPortName.Location = New System.Drawing.Point(176, 155)
        Me.txtPortName.Name = "txtPortName"
        Me.txtPortName.Size = New System.Drawing.Size(208, 21)
        Me.txtPortName.TabIndex = 181
        '
        'txtVehicleName
        '
        Me.txtVehicleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtVehicleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtVehicleName.FormattingEnabled = True
        Me.txtVehicleName.Items.AddRange(New Object() {"", "SEA", "AIR", "COURIER"})
        Me.txtVehicleName.Location = New System.Drawing.Point(176, 127)
        Me.txtVehicleName.Name = "txtVehicleName"
        Me.txtVehicleName.Size = New System.Drawing.Size(208, 21)
        Me.txtVehicleName.TabIndex = 180
        '
        'txtBenefit
        '
        Me.txtBenefit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtBenefit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtBenefit.FormattingEnabled = True
        Me.txtBenefit.Items.AddRange(New Object() {"", "BOI", "FORM", "VAT"})
        Me.txtBenefit.Location = New System.Drawing.Point(176, 73)
        Me.txtBenefit.Name = "txtBenefit"
        Me.txtBenefit.Size = New System.Drawing.Size(104, 21)
        Me.txtBenefit.TabIndex = 179
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(32, 242)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(96, 13)
        Me.Label54.TabIndex = 177
        Me.Label54.Text = "Benefit Qty. (Kgs.)"
        '
        'dtpaQuotationDate
        '
        Me.dtpaQuotationDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpaQuotationDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpaQuotationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpaQuotationDate.Location = New System.Drawing.Point(496, 243)
        Me.dtpaQuotationDate.Name = "dtpaQuotationDate"
        Me.dtpaQuotationDate.ShowCheckBox = True
        Me.dtpaQuotationDate.Size = New System.Drawing.Size(127, 20)
        Me.dtpaQuotationDate.TabIndex = 373
        Me.dtpaQuotationDate.Value = New Date(2021, 1, 12, 11, 4, 9, 464)
        '
        'txtBenefitKgs
        '
        Me.txtBenefitKgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBenefitKgs.Location = New System.Drawing.Point(176, 240)
        Me.txtBenefitKgs.Name = "txtBenefitKgs"
        Me.txtBenefitKgs.Size = New System.Drawing.Size(104, 22)
        Me.txtBenefitKgs.TabIndex = 178
        Me.txtBenefitKgs.Text = "0"
        Me.txtBenefitKgs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'epcboCurrency
        '
        Me.epcboCurrency.ContainerControl = Me
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Enabled = False
        Me.Label53.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(788, 159)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(85, 13)
        Me.Label53.TabIndex = 161
        Me.Label53.Text = "Estimate Arrival"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Enabled = False
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(434, 159)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(105, 13)
        Me.Label52.TabIndex = 159
        Me.Label52.Text = "Estimate Departure"
        '
        'txtPackingRemark
        '
        Me.txtPackingRemark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPackingRemark.Location = New System.Drawing.Point(580, 185)
        Me.txtPackingRemark.MaxLength = 100
        Me.txtPackingRemark.Multiline = True
        Me.txtPackingRemark.Name = "txtPackingRemark"
        Me.txtPackingRemark.Size = New System.Drawing.Size(443, 86)
        Me.txtPackingRemark.TabIndex = 19
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(434, 187)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(88, 13)
        Me.Label51.TabIndex = 18
        Me.Label51.Text = "Packing Remark"
        '
        'txtBLNo
        '
        Me.txtBLNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBLNo.Enabled = False
        Me.txtBLNo.Location = New System.Drawing.Point(580, 73)
        Me.txtBLNo.MaxLength = 20
        Me.txtBLNo.Name = "txtBLNo"
        Me.txtBLNo.Size = New System.Drawing.Size(160, 22)
        Me.txtBLNo.TabIndex = 17
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Enabled = False
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(434, 76)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(43, 13)
        Me.Label50.TabIndex = 16
        Me.Label50.Text = "B/L No."
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInvoiceNo.Enabled = False
        Me.txtInvoiceNo.Location = New System.Drawing.Point(580, 46)
        Me.txtInvoiceNo.MaxLength = 20
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(160, 22)
        Me.txtInvoiceNo.TabIndex = 15
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Enabled = False
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(434, 49)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(64, 13)
        Me.Label49.TabIndex = 14
        Me.Label49.Text = "Invoice No."
        '
        'txtPackingNo
        '
        Me.txtPackingNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPackingNo.Enabled = False
        Me.txtPackingNo.Location = New System.Drawing.Point(580, 19)
        Me.txtPackingNo.MaxLength = 20
        Me.txtPackingNo.Name = "txtPackingNo"
        Me.txtPackingNo.Size = New System.Drawing.Size(160, 22)
        Me.txtPackingNo.TabIndex = 13
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Enabled = False
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(434, 22)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(68, 13)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Packing No."
        '
        'txtBenefitAmount
        '
        Me.txtBenefitAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBenefitAmount.Location = New System.Drawing.Point(176, 212)
        Me.txtBenefitAmount.Name = "txtBenefitAmount"
        Me.txtBenefitAmount.Size = New System.Drawing.Size(104, 22)
        Me.txtBenefitAmount.TabIndex = 11
        Me.txtBenefitAmount.Text = "0"
        Me.txtBenefitAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(32, 213)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(118, 13)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "Benefit Amount (USD)"
        '
        'txtAgencyName
        '
        Me.txtAgencyName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAgencyName.Location = New System.Drawing.Point(176, 184)
        Me.txtAgencyName.MaxLength = 100
        Me.txtAgencyName.Name = "txtAgencyName"
        Me.txtAgencyName.Size = New System.Drawing.Size(208, 22)
        Me.txtAgencyName.TabIndex = 9
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(32, 187)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(76, 13)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "Agency Name"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(32, 159)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(60, 13)
        Me.Label40.TabIndex = 6
        Me.Label40.Text = "Port Name"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(32, 130)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(75, 13)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "Vehicle Name"
        '
        'txtPeriod
        '
        Me.txtPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeriod.Location = New System.Drawing.Point(176, 100)
        Me.txtPeriod.MaxLength = 10
        Me.txtPeriod.Name = "txtPeriod"
        Me.txtPeriod.Size = New System.Drawing.Size(104, 22)
        Me.txtPeriod.TabIndex = 3
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(32, 103)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(93, 13)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "Approved Period"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(32, 76)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(43, 13)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "Benefit"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dtpaArrival)
        Me.TabPage3.Controls.Add(Me.dtpaAWB_date)
        Me.TabPage3.Controls.Add(Me.dtpaBL_date)
        Me.TabPage3.Controls.Add(Me.dtpaInvoice_date)
        Me.TabPage3.Controls.Add(Me.dtpaPacking_date)
        Me.TabPage3.Controls.Add(Me.dtpaDeparture)
        Me.TabPage3.Controls.Add(Me.dtpaAWB_Received_date)
        Me.TabPage3.Controls.Add(Me.txtFreight)
        Me.TabPage3.Controls.Add(Me.Label63)
        Me.TabPage3.Controls.Add(Me.cboForwarder)
        Me.TabPage3.Controls.Add(Me.Label64)
        Me.TabPage3.Controls.Add(Me.lblAWP_Date)
        Me.TabPage3.Controls.Add(Me.lblAWBreceived_date)
        Me.TabPage3.Controls.Add(Me.txtAWB_no)
        Me.TabPage3.Controls.Add(Me.Label57)
        Me.TabPage3.Controls.Add(Me.Label56)
        Me.TabPage3.Controls.Add(Me.Label55)
        Me.TabPage3.Controls.Add(Me.lblPackdt)
        Me.TabPage3.Controls.Add(Me.txtPortName)
        Me.TabPage3.Controls.Add(Me.txtVehicleName)
        Me.TabPage3.Controls.Add(Me.txtBenefit)
        Me.TabPage3.Controls.Add(Me.txtBenefitKgs)
        Me.TabPage3.Controls.Add(Me.Label54)
        Me.TabPage3.Controls.Add(Me.Label53)
        Me.TabPage3.Controls.Add(Me.Label52)
        Me.TabPage3.Controls.Add(Me.txtPackingRemark)
        Me.TabPage3.Controls.Add(Me.Label51)
        Me.TabPage3.Controls.Add(Me.txtBLNo)
        Me.TabPage3.Controls.Add(Me.Label50)
        Me.TabPage3.Controls.Add(Me.txtInvoiceNo)
        Me.TabPage3.Controls.Add(Me.Label49)
        Me.TabPage3.Controls.Add(Me.txtPackingNo)
        Me.TabPage3.Controls.Add(Me.Label48)
        Me.TabPage3.Controls.Add(Me.txtBenefitAmount)
        Me.TabPage3.Controls.Add(Me.Label42)
        Me.TabPage3.Controls.Add(Me.txtAgencyName)
        Me.TabPage3.Controls.Add(Me.Label41)
        Me.TabPage3.Controls.Add(Me.Label40)
        Me.TabPage3.Controls.Add(Me.Label39)
        Me.TabPage3.Controls.Add(Me.txtPeriod)
        Me.TabPage3.Controls.Add(Me.Label38)
        Me.TabPage3.Controls.Add(Me.Label37)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1073, 515)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "BOI"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtFreight
        '
        Me.txtFreight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFreight.Location = New System.Drawing.Point(176, 46)
        Me.txtFreight.MaxLength = 10
        Me.txtFreight.Name = "txtFreight"
        Me.txtFreight.Size = New System.Drawing.Size(104, 22)
        Me.txtFreight.TabIndex = 369
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(32, 49)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(71, 13)
        Me.Label63.TabIndex = 368
        Me.Label63.Text = "Freight Price"
        '
        'cboForwarder
        '
        Me.cboForwarder.FormattingEnabled = True
        Me.cboForwarder.Location = New System.Drawing.Point(176, 19)
        Me.cboForwarder.Name = "cboForwarder"
        Me.cboForwarder.Size = New System.Drawing.Size(208, 21)
        Me.cboForwarder.TabIndex = 367
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(32, 22)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(60, 13)
        Me.Label64.TabIndex = 366
        Me.Label64.Text = "Forwarder"
        '
        'lblAWP_Date
        '
        Me.lblAWP_Date.AutoSize = True
        Me.lblAWP_Date.Enabled = False
        Me.lblAWP_Date.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAWP_Date.Location = New System.Drawing.Point(788, 103)
        Me.lblAWP_Date.Name = "lblAWP_Date"
        Me.lblAWP_Date.Size = New System.Drawing.Size(57, 13)
        Me.lblAWP_Date.TabIndex = 193
        Me.lblAWP_Date.Text = "AWB Date"
        '
        'lblAWBreceived_date
        '
        Me.lblAWBreceived_date.AutoSize = True
        Me.lblAWBreceived_date.Enabled = False
        Me.lblAWBreceived_date.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAWBreceived_date.Location = New System.Drawing.Point(434, 130)
        Me.lblAWBreceived_date.Name = "lblAWBreceived_date"
        Me.lblAWBreceived_date.Size = New System.Drawing.Size(105, 13)
        Me.lblAWBreceived_date.TabIndex = 190
        Me.lblAWBreceived_date.Text = "AWB Received Date"
        '
        'txtAWB_no
        '
        Me.txtAWB_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAWB_no.Enabled = False
        Me.txtAWB_no.Location = New System.Drawing.Point(580, 100)
        Me.txtAWB_no.Name = "txtAWB_no"
        Me.txtAWB_no.Size = New System.Drawing.Size(160, 22)
        Me.txtAWB_no.TabIndex = 189
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Enabled = False
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(434, 103)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(51, 13)
        Me.Label57.TabIndex = 188
        Me.Label57.Text = "AWB No."
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Enabled = False
        Me.Label56.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(788, 76)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(49, 13)
        Me.Label56.TabIndex = 187
        Me.Label56.Text = "B/L Date"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Enabled = False
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(788, 49)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(49, 13)
        Me.Label55.TabIndex = 186
        Me.Label55.Text = "Inv Date"
        '
        'lblPackdt
        '
        Me.lblPackdt.AutoSize = True
        Me.lblPackdt.Enabled = False
        Me.lblPackdt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPackdt.Location = New System.Drawing.Point(788, 22)
        Me.lblPackdt.Name = "lblPackdt"
        Me.lblPackdt.Size = New System.Drawing.Size(60, 13)
        Me.lblPackdt.TabIndex = 185
        Me.lblPackdt.Text = "Pack Date."
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtEmailCC)
        Me.GroupBox1.Controls.Add(Me.Label61)
        Me.GroupBox1.Controls.Add(Me.txtEmailTo)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.chkValidateQtyCone)
        Me.GroupBox1.Controls.Add(Me.txtCrterm)
        Me.GroupBox1.Controls.Add(Me.Label68)
        Me.GroupBox1.Controls.Add(Me.dtpaDeliveryDate)
        Me.GroupBox1.Controls.Add(Me.dtpaQuotationDate)
        Me.GroupBox1.Controls.Add(Me.dtpaPayDate)
        Me.GroupBox1.Controls.Add(Me.dtpaLCDate)
        Me.GroupBox1.Controls.Add(Me.txtPayModeCd)
        Me.GroupBox1.Controls.Add(Me.btnSuppSearch)
        Me.GroupBox1.Controls.Add(Me.cboPaymentTerm)
        Me.GroupBox1.Controls.Add(Me.cboIncoTerms)
        Me.GroupBox1.Controls.Add(Me.cboShipvia)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.txtQuotationNo)
        Me.GroupBox1.Controls.Add(Me.Label45)
        Me.GroupBox1.Controls.Add(Me.Label44)
        Me.GroupBox1.Controls.Add(Me.txtLCNo)
        Me.GroupBox1.Controls.Add(Me.Label43)
        Me.GroupBox1.Controls.Add(Me.checkImport)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtDeliAddr)
        Me.GroupBox1.Controls.Add(Me.txtdeliveryday)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCrdays)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1058, 506)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier details:"
        '
        'txtEmailCC
        '
        Me.txtEmailCC.Location = New System.Drawing.Point(96, 312)
        Me.txtEmailCC.Name = "txtEmailCC"
        Me.txtEmailCC.Size = New System.Drawing.Size(227, 22)
        Me.txtEmailCC.TabIndex = 385
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(14, 312)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(56, 13)
        Me.Label61.TabIndex = 384
        Me.Label61.Text = "E-Mail CC"
        '
        'txtEmailTo
        '
        Me.txtEmailTo.Location = New System.Drawing.Point(97, 278)
        Me.txtEmailTo.Name = "txtEmailTo"
        Me.txtEmailTo.Size = New System.Drawing.Size(226, 22)
        Me.txtEmailTo.TabIndex = 383
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(14, 281)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(54, 13)
        Me.Label36.TabIndex = 382
        Me.Label36.Text = "E-Mail To"
        '
        'chkValidateQtyCone
        '
        Me.chkValidateQtyCone.AutoSize = True
        Me.chkValidateQtyCone.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkValidateQtyCone.Location = New System.Drawing.Point(401, 280)
        Me.chkValidateQtyCone.Name = "chkValidateQtyCone"
        Me.chkValidateQtyCone.Size = New System.Drawing.Size(117, 17)
        Me.chkValidateQtyCone.TabIndex = 378
        Me.chkValidateQtyCone.Text = "Validate Qty Cone"
        Me.chkValidateQtyCone.UseVisualStyleBackColor = True
        '
        'txtCrterm
        '
        Me.txtCrterm.Location = New System.Drawing.Point(496, 140)
        Me.txtCrterm.Name = "txtCrterm"
        Me.txtCrterm.Size = New System.Drawing.Size(127, 22)
        Me.txtCrterm.TabIndex = 376
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(740, 143)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(56, 13)
        Me.Label68.TabIndex = 375
        Me.Label68.Text = "Paymode:"
        '
        'txtPayModeCd
        '
        Me.txtPayModeCd.Location = New System.Drawing.Point(828, 141)
        Me.txtPayModeCd.Name = "txtPayModeCd"
        Me.txtPayModeCd.ReadOnly = True
        Me.txtPayModeCd.Size = New System.Drawing.Size(80, 22)
        Me.txtPayModeCd.TabIndex = 364
        '
        'btnSuppSearch
        '
        Me.btnSuppSearch.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Search_16x
        Me.btnSuppSearch.Location = New System.Drawing.Point(329, 17)
        Me.btnSuppSearch.Name = "btnSuppSearch"
        Me.btnSuppSearch.Size = New System.Drawing.Size(31, 23)
        Me.btnSuppSearch.TabIndex = 166
        Me.btnSuppSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSuppSearch.UseVisualStyleBackColor = True
        '
        'cboPaymentTerm
        '
        Me.cboPaymentTerm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPaymentTerm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPaymentTerm.FormattingEnabled = True
        Me.cboPaymentTerm.Items.AddRange(New Object() {"", "LC", "TT"})
        Me.cboPaymentTerm.Location = New System.Drawing.Point(96, 141)
        Me.cboPaymentTerm.Name = "cboPaymentTerm"
        Me.cboPaymentTerm.Size = New System.Drawing.Size(227, 21)
        Me.cboPaymentTerm.TabIndex = 165
        '
        'cboIncoTerms
        '
        Me.cboIncoTerms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboIncoTerms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIncoTerms.FormattingEnabled = True
        Me.cboIncoTerms.Items.AddRange(New Object() {"", "CIF", "FOB", "EX WORK", "CFS"})
        Me.cboIncoTerms.Location = New System.Drawing.Point(96, 240)
        Me.cboIncoTerms.Name = "cboIncoTerms"
        Me.cboIncoTerms.Size = New System.Drawing.Size(227, 21)
        Me.cboIncoTerms.TabIndex = 164
        '
        'cboShipvia
        '
        Me.cboShipvia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboShipvia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboShipvia.FormattingEnabled = True
        Me.cboShipvia.Items.AddRange(New Object() {"", "SEA", "AIR", "COURIER"})
        Me.cboShipvia.Location = New System.Drawing.Point(96, 214)
        Me.cboShipvia.Name = "cboShipvia"
        Me.cboShipvia.Size = New System.Drawing.Size(227, 21)
        Me.cboShipvia.TabIndex = 163
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(398, 243)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(87, 13)
        Me.Label47.TabIndex = 161
        Me.Label47.Text = "Quotation Date"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(398, 217)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(81, 13)
        Me.Label46.TabIndex = 160
        Me.Label46.Text = "Quotation No."
        '
        'txtQuotationNo
        '
        Me.txtQuotationNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuotationNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtQuotationNo.Location = New System.Drawing.Point(496, 214)
        Me.txtQuotationNo.MaxLength = 20
        Me.txtQuotationNo.Name = "txtQuotationNo"
        Me.txtQuotationNo.Size = New System.Drawing.Size(232, 20)
        Me.txtQuotationNo.TabIndex = 159
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(398, 170)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(44, 13)
        Me.Label44.TabIndex = 155
        Me.Label44.Text = "L/C No."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(-158, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 13)
        Me.Label26.TabIndex = 78
        Me.Label26.Text = "Boxes:"
        '
        'DataGridViewCalendarColumn1
        '
        Me.DataGridViewCalendarColumn1.DataPropertyName = "delidt"
        Me.DataGridViewCalendarColumn1.HeaderText = "Deli Date"
        Me.DataGridViewCalendarColumn1.Name = "DataGridViewCalendarColumn1"
        '
        'txtrate
        '
        Me.txtrate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtrate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrate.Location = New System.Drawing.Point(442, 39)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.Size = New System.Drawing.Size(54, 22)
        Me.txtrate.TabIndex = 386
        Me.txtrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNew, Me.tsbSave, Me.btnApprove, Me.btnClosed, Me.tsbPrint, Me.btnCancel, Me.tsbMinimized, Me.tsbExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1105, 25)
        Me.ToolStrip1.TabIndex = 399
        '
        'tsbNew
        '
        Me.tsbNew.Image = Global.PurchaseOrderSystem.My.Resources.Resources.NewItem_16x
        Me.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNew.Name = "tsbNew"
        Me.tsbNew.Size = New System.Drawing.Size(50, 22)
        Me.tsbNew.Text = "New"
        '
        'tsbSave
        '
        Me.tsbSave.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Save_16x
        Me.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSave.Name = "tsbSave"
        Me.tsbSave.Size = New System.Drawing.Size(50, 22)
        Me.tsbSave.Text = "Save"
        '
        'btnApprove
        '
        Me.btnApprove.Image = Global.PurchaseOrderSystem.My.Resources.Resources.ConfirmButton_16x
        Me.btnApprove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(70, 22)
        Me.btnApprove.Text = "Approve"
        '
        'btnClosed
        '
        Me.btnClosed.Image = Global.PurchaseOrderSystem.My.Resources.Resources.CloseDocument_16x
        Me.btnClosed.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnClosed.Name = "btnClosed"
        Me.btnClosed.Size = New System.Drawing.Size(55, 22)
        Me.btnClosed.Text = "Close"
        Me.btnClosed.Visible = False
        '
        'tsbPrint
        '
        Me.tsbPrint.DoubleClickEnabled = True
        Me.tsbPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbPrintPO})
        Me.tsbPrint.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Print_16x
        Me.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrint.Name = "tsbPrint"
        Me.tsbPrint.Size = New System.Drawing.Size(63, 22)
        Me.tsbPrint.Text = "Print"
        '
        'tsbPrintPO
        '
        Me.tsbPrintPO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.A4ToolStripMenuItem, Me.ENToolStripMenuItem})
        Me.tsbPrintPO.Name = "tsbPrintPO"
        Me.tsbPrintPO.Size = New System.Drawing.Size(120, 22)
        Me.tsbPrintPO.Text = "Print P/O"
        '
        'A4ToolStripMenuItem
        '
        Me.A4ToolStripMenuItem.Name = "A4ToolStripMenuItem"
        Me.A4ToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.A4ToolStripMenuItem.Text = "TH"
        '
        'ENToolStripMenuItem
        '
        Me.ENToolStripMenuItem.Name = "ENToolStripMenuItem"
        Me.ENToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.ENToolStripMenuItem.Text = "EN"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Cancel_16x
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(61, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'tsbMinimized
        '
        Me.tsbMinimized.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Minimize_16x
        Me.tsbMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMinimized.Name = "tsbMinimized"
        Me.tsbMinimized.Size = New System.Drawing.Size(80, 22)
        Me.tsbMinimized.Text = "Minimized"
        '
        'tsbExit
        '
        Me.tsbExit.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Exit_16x
        Me.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExit.Name = "tsbExit"
        Me.tsbExit.Size = New System.Drawing.Size(45, 22)
        Me.tsbExit.Text = "Exit"
        '
        'epcboPaymentTerm
        '
        Me.epcboPaymentTerm.ContainerControl = Me
        '
        'txtPresentStatus
        '
        Me.txtPresentStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtPresentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresentStatus.Enabled = False
        Me.txtPresentStatus.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresentStatus.Location = New System.Drawing.Point(502, 39)
        Me.txtPresentStatus.Name = "txtPresentStatus"
        Me.txtPresentStatus.Size = New System.Drawing.Size(49, 22)
        Me.txtPresentStatus.TabIndex = 379
        Me.txtPresentStatus.Text = "UN-APP"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPoReqNo)
        Me.GroupBox3.Controls.Add(Me.textReqno)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.cboDept)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.comboEmp)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(453, 73)
        Me.GroupBox3.TabIndex = 382
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Source document"
        '
        'btnPoReqNo
        '
        Me.btnPoReqNo.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Search_16x
        Me.btnPoReqNo.Location = New System.Drawing.Point(144, 39)
        Me.btnPoReqNo.Name = "btnPoReqNo"
        Me.btnPoReqNo.Size = New System.Drawing.Size(31, 23)
        Me.btnPoReqNo.TabIndex = 1
        Me.btnPoReqNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPoReqNo.UseVisualStyleBackColor = True
        '
        'textReqno
        '
        Me.textReqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.textReqno.Location = New System.Drawing.Point(15, 40)
        Me.textReqno.Name = "textReqno"
        Me.textReqno.Size = New System.Drawing.Size(123, 22)
        Me.textReqno.TabIndex = 0
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(96, 13)
        Me.Label27.TabIndex = 153
        Me.Label27.Text = "Purchase req.no.:"
        '
        'cboDept
        '
        Me.cboDept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboDept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(314, 41)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(123, 21)
        Me.cboDept.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(311, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 13)
        Me.Label25.TabIndex = 150
        Me.Label25.Text = "Department:"
        '
        'comboEmp
        '
        Me.comboEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comboEmp.FormattingEnabled = True
        Me.comboEmp.Items.AddRange(New Object() {"Cash", "Credit"})
        Me.comboEmp.Location = New System.Drawing.Point(181, 40)
        Me.comboEmp.Name = "comboEmp"
        Me.comboEmp.Size = New System.Drawing.Size(123, 21)
        Me.comboEmp.TabIndex = 1
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(181, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(67, 13)
        Me.Label24.TabIndex = 149
        Me.Label24.Text = "Request by:"
        '
        'epItemGrid
        '
        Me.epItemGrid.ContainerControl = Me
        '
        'epcomboEmp
        '
        Me.epcomboEmp.ContainerControl = Me
        '
        'eptxtrate
        '
        Me.eptxtrate.ContainerControl = Me
        '
        'cboCurrency
        '
        Me.cboCurrency.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cboCurrency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCurrency.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCurrency.FormattingEnabled = True
        Me.eptxtrate.SetIconAlignment(Me.cboCurrency, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.cboCurrency.Location = New System.Drawing.Point(368, 39)
        Me.cboCurrency.Name = "cboCurrency"
        Me.cboCurrency.Size = New System.Drawing.Size(68, 21)
        Me.cboCurrency.TabIndex = 385
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(439, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 13)
        Me.Label20.TabIndex = 393
        Me.Label20.Text = "Ex.rate:"
        '
        'epcboSupplier
        '
        Me.epcboSupplier.ContainerControl = Me
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(369, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 392
        Me.Label19.Text = "Currency :"
        '
        'gboxNewDoc
        '
        Me.gboxNewDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gboxNewDoc.Controls.Add(Me.Label18)
        Me.gboxNewDoc.Controls.Add(Me.textSupQuoteno)
        Me.gboxNewDoc.Controls.Add(Me.txtPresentStatus)
        Me.gboxNewDoc.Controls.Add(Me.Label65)
        Me.gboxNewDoc.Controls.Add(Me.buttonSearchPO)
        Me.gboxNewDoc.Controls.Add(Me.txtPurNo)
        Me.gboxNewDoc.Controls.Add(Me.DateYIN)
        Me.gboxNewDoc.Controls.Add(Me.txtrate)
        Me.gboxNewDoc.Controls.Add(Me.lblYINno)
        Me.gboxNewDoc.Controls.Add(Me.Label2)
        Me.gboxNewDoc.Controls.Add(Me.Label1)
        Me.gboxNewDoc.Controls.Add(Me.Label20)
        Me.gboxNewDoc.Controls.Add(Me.cboCurrency)
        Me.gboxNewDoc.Controls.Add(Me.Label26)
        Me.gboxNewDoc.Controls.Add(Me.Label19)
        Me.gboxNewDoc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxNewDoc.Location = New System.Drawing.Point(533, 30)
        Me.gboxNewDoc.Name = "gboxNewDoc"
        Me.gboxNewDoc.Size = New System.Drawing.Size(560, 73)
        Me.gboxNewDoc.TabIndex = 383
        Me.gboxNewDoc.TabStop = False
        Me.gboxNewDoc.Text = "Document"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(499, 23)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(39, 13)
        Me.Label65.TabIndex = 152
        Me.Label65.Text = "Status"
        '
        'buttonSearchPO
        '
        Me.buttonSearchPO.Image = Global.PurchaseOrderSystem.My.Resources.Resources.Search_16x
        Me.buttonSearchPO.Location = New System.Drawing.Point(125, 39)
        Me.buttonSearchPO.Name = "buttonSearchPO"
        Me.buttonSearchPO.Size = New System.Drawing.Size(22, 22)
        Me.buttonSearchPO.TabIndex = 151
        Me.buttonSearchPO.UseVisualStyleBackColor = True
        '
        'txtPurNo
        '
        Me.txtPurNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPurNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurNo.Location = New System.Drawing.Point(16, 39)
        Me.txtPurNo.Name = "txtPurNo"
        Me.txtPurNo.Size = New System.Drawing.Size(103, 22)
        Me.txtPurNo.TabIndex = 4
        '
        'DateYIN
        '
        Me.DateYIN.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateYIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateYIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateYIN.Location = New System.Drawing.Point(153, 39)
        Me.DateYIN.Name = "DateYIN"
        Me.DateYIN.Size = New System.Drawing.Size(100, 20)
        Me.DateYIN.TabIndex = 5
        '
        'lblYINno
        '
        Me.lblYINno.AutoSize = True
        Me.lblYINno.Location = New System.Drawing.Point(106, 31)
        Me.lblYINno.Name = "lblYINno"
        Me.lblYINno.Size = New System.Drawing.Size(0, 13)
        Me.lblYINno.TabIndex = 83
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(154, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Purch. Ord.Dt:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "Purch. Ord#"
        '
        'epSaved
        '
        Me.epSaved.ContainerControl = Me
        Me.epSaved.Icon = CType(resources.GetObject("epSaved.Icon"), System.Drawing.Icon)
        '
        'epmcboPoLineType
        '
        Me.epmcboPoLineType.ContainerControl = Me
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 109)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1081, 541)
        Me.TabControl1.TabIndex = 384
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1073, 515)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Supplier details"
        '
        'DataGridViewCalendarColumn2
        '
        Me.DataGridViewCalendarColumn2.DataPropertyName = "effective_date"
        Me.DataGridViewCalendarColumn2.HeaderText = "Effective Date"
        Me.DataGridViewCalendarColumn2.Name = "DataGridViewCalendarColumn2"
        '
        'coltest
        '
        Me.coltest.HeaderText = "coltest"
        Me.coltest.Name = "coltest"
        '
        'epcboDept
        '
        Me.epcboDept.ContainerControl = Me
        '
        'epItemNature
        '
        Me.epItemNature.ContainerControl = Me
        '
        'epPresentStatus
        '
        Me.epPresentStatus.ContainerControl = Me
        '
        'textSupQuoteno
        '
        Me.textSupQuoteno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textSupQuoteno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textSupQuoteno.Location = New System.Drawing.Point(259, 39)
        Me.textSupQuoteno.Name = "textSupQuoteno"
        Me.textSupQuoteno.Size = New System.Drawing.Size(103, 22)
        Me.textSupQuoteno.TabIndex = 394
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(256, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 13)
        Me.Label18.TabIndex = 395
        Me.Label18.Text = "Supplier Quote No."
        '
        'frmPurchaseOrderNewEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 662)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gboxNewDoc)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmPurchaseOrderNewEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order (New/Edit)"
        CType(Me.dgvJobDet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextMenuGrid.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.mcboPoLineType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtpaDeliveryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaPayDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaLCDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaArrival, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaAWB_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaBL_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaInvoice_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaPacking_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaDeparture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaAWB_Received_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpaQuotationDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epcboCurrency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.epcboPaymentTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.epItemGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epcomboEmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eptxtrate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epcboSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxNewDoc.ResumeLayout(False)
        Me.gboxNewDoc.PerformLayout()
        CType(Me.epSaved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epmcboPoLineType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.epcboDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epItemNature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.epPresentStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPurNo As System.Windows.Forms.TextBox
    Friend WithEvents DateYIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblYINno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnYarnExit As System.Windows.Forms.Button
    Friend WithEvents BtnYarnPrintDoc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtremark As System.Windows.Forms.TextBox
    Friend WithEvents txtpackcd As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DtDileveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCrdays As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents gboxNewDoc As System.Windows.Forms.GroupBox
    Friend WithEvents DtPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdeliveryday As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents textReqno As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents comboEmp As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents dgvJobDet As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDeliAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents checkImport As System.Windows.Forms.CheckBox
    Friend WithEvents errorSupplier As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorEmp As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorCurrency As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorItemGrid As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorSaved As System.Windows.Forms.ErrorProvider
    Friend WithEvents contextMenuGrid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SeeHistoryForThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtrate As System.Windows.Forms.TextBox
    Friend WithEvents cboCurrency As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtNetOrderAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtNetLineAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtGrossLineDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtDisper As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtGrossLineamount As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtVat As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountamount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtVatAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtBenefitAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtAgencyName As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtPeriod As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents dtpQuotationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtQuotationNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpLCDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtLCNo As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtPackingNo As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents dtpArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtPackingRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtBLNo As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtBenefitKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtPortName As System.Windows.Forms.ComboBox
    Friend WithEvents txtVehicleName As System.Windows.Forms.ComboBox
    Friend WithEvents txtBenefit As System.Windows.Forms.ComboBox
    Friend WithEvents txtAWB_no As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents lblPackdt As System.Windows.Forms.Label
    Friend WithEvents DtpBL_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpInvoice_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpPacking_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAWP_Date As System.Windows.Forms.Label
    Friend WithEvents DtpAWB_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpAWB_Received_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblAWBreceived_date As System.Windows.Forms.Label
    Friend WithEvents ErrorDept As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorItemNature As System.Windows.Forms.ErrorProvider
    Friend WithEvents ClassDataGridViewCalendarColumn1 As PurchaseOrderSystem.DataGridViewCalendarColumn
    'Friend WithEvents delidt As PurchaseOrderSystem.DataGridViewCalendarColumn
    'Friend WithEvents effective_date As PurchaseOrderSystem.DataGridViewCalendarColumn
    Friend WithEvents Label58 As Label
    Friend WithEvents mcboPoLineType As PurchaseOrderSystem.Controls.MultiColumnComboBox
    Friend WithEvents coltest As DataGridViewTextBoxColumn
    Friend WithEvents ErrormcboPoLineType As ErrorProvider
    Friend WithEvents DataGridViewCalendarColumn1 As DataGridViewCalendarColumn
    Friend WithEvents DataGridViewCalendarColumn2 As DataGridViewCalendarColumn
    Friend WithEvents btnSuppSearch As Button
    Friend WithEvents btnGetSoItmData As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Label59 As Label
    Friend WithEvents textPresentStatus As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbNew As ToolStripButton
    Friend WithEvents tsbSave As ToolStripButton
    Friend WithEvents tsbPrint As ToolStripSplitButton
    Friend WithEvents tsbPrintPO As ToolStripMenuItem
    Friend WithEvents tsbMinimized As ToolStripButton
    Friend WithEvents tsbExit As ToolStripButton
    Friend WithEvents txtPayModeCd As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents btnGetPo As Button
    Friend WithEvents cboPaymentTerm As ComboBox
    Friend WithEvents cboShipvia As ComboBox
    Friend WithEvents cboIncoTerms As ComboBox
    Friend WithEvents cboForwarder As ComboBox
    Friend WithEvents txtFreight As TextBox
    Friend WithEvents btnGetBOMLine As Button
    Friend WithEvents dtpaDeliveryDate As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaPayDate As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaLCDate As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents dtpaArrival As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaAWB_date As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaBL_date As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaInvoice_date As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaPacking_date As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaDeparture As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaAWB_Received_date As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents dtpaQuotationDate As PurchaseOrderSystem.Controls.NullableDateTimePicker
    Friend WithEvents epcboCurrency As ErrorProvider
    Friend WithEvents btnApprove As ToolStripButton
    Friend WithEvents btnCancel As ToolStripButton
    Friend WithEvents epcboPaymentTerm As ErrorProvider
    Friend WithEvents txtPresentStatus As TextBox
    Friend WithEvents btnPoReqNo As Button
    Friend WithEvents epItemGrid As ErrorProvider
    Friend WithEvents epcomboEmp As ErrorProvider
    Friend WithEvents eptxtrate As ErrorProvider
    Friend WithEvents epcboSupplier As ErrorProvider
    Friend WithEvents Label65 As Label
    Friend WithEvents buttonSearchPO As Button
    Friend WithEvents epSaved As ErrorProvider
    Friend WithEvents epmcboPoLineType As ErrorProvider
    Friend WithEvents epcboDept As ErrorProvider
    Friend WithEvents epItemNature As ErrorProvider
    Friend WithEvents epPresentStatus As ErrorProvider
    Friend WithEvents btnClosed As ToolStripButton
    Friend WithEvents Label67 As Label
    Friend WithEvents dtpDelidt As DateTimePicker
    Friend WithEvents btnApplyDelidt As Button
    Friend WithEvents Label35 As Label
    Friend WithEvents comboItemNature As ComboBox
    Friend WithEvents txtCrterm As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents cbPriceIncudingVat As CheckBox
    Friend WithEvents A4ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtEmailCC As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents txtEmailTo As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents chkValidateQtyCone As CheckBox
    Friend WithEvents colIdJobdet As DataGridViewTextBoxColumn
    Friend WithEvents colSoNo As DataGridViewTextBoxColumn
    Friend WithEvents colSoNoId As DataGridViewTextBoxColumn
    Friend WithEvents colItemId As DataGridViewTextBoxColumn
    Friend WithEvents colItcd As DataGridViewTextBoxColumn
    Friend WithEvents colItdesc As DataGridViewTextBoxColumn
    Friend WithEvents supdes_no As DataGridViewTextBoxColumn
    Friend WithEvents itdesc_supp As DataGridViewTextBoxColumn
    Friend WithEvents colSuppitcd As DataGridViewTextBoxColumn
    Friend WithEvents supquoteno As DataGridViewTextBoxColumn
    Friend WithEvents colMfgProductionOrderLineId As DataGridViewTextBoxColumn
    Friend WithEvents rcv_warehouse_id As DataGridViewTextBoxColumn
    Friend WithEvents colWareHouseCode As DataGridViewTextBoxColumn
    Friend WithEvents rcv_subinventory_id As DataGridViewTextBoxColumn
    Friend WithEvents colSourceSubInventoryCode As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colUom As DataGridViewComboBoxColumn
    Friend WithEvents colQty2 As DataGridViewTextBoxColumn
    Friend WithEvents colUom2 As DataGridViewComboBoxColumn
    Friend WithEvents colItemUnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents colFreightPerUnit As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colDiscper As DataGridViewTextBoxColumn
    Friend WithEvents colDiscamt As DataGridViewTextBoxColumn
    Friend WithEvents colLineamt As DataGridViewTextBoxColumn
    Friend WithEvents colGrossLineamt As DataGridViewTextBoxColumn
    Friend WithEvents colRemark As DataGridViewTextBoxColumn
    Friend WithEvents buttonViewHistory As DataGridViewButtonColumn
    Friend WithEvents colDelidt As DataGridViewCalendarColumn
    Friend WithEvents ColEffectiveDate As DataGridViewCalendarColumn
    Friend WithEvents recycle_trans_report_rcvd_flag As DataGridViewCheckBoxColumn
    Friend WithEvents supplier_spec_rcvd_flag As DataGridViewCheckBoxColumn
    Friend WithEvents btnTransFile As DataGridViewButtonColumn
    Friend WithEvents btnYarnFile As DataGridViewButtonColumn
    Friend WithEvents textSupQuoteno As TextBox
    Friend WithEvents Label18 As Label
End Class
