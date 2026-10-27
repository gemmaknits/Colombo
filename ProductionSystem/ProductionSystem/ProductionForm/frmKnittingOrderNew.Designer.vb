<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKnittingOrderNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnittingOrderNew))
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteBomLine = New System.Windows.Forms.Button()
        Me.btnAddBomHeader = New System.Windows.Forms.Button()
        Me.btnAddBomLine = New System.Windows.Forms.Button()
        Me.McboIDYarnChange = New ProductionSystem.Controls.MultiColumnComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cboko_mtl_warehouse_id = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboline_type = New System.Windows.Forms.ComboBox()
        Me.grdmfg_production_order_lines = New System.Windows.Forms.DataGridView()
        Me.colMfgProductionOrderId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMfgProductionOrderLinesId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLineType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMfgProductionStepsId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOperationCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMtlWarehouseId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSourceSubinventoryId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSourceSubInventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_perc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.collineuomid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.collineuom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creation_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_modified_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.last_modified_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_header_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_line_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPrintIssueTemplate = New System.Windows.Forms.Button()
        Me.lblsteam_instruction = New System.Windows.Forms.Label()
        Me.txtsteam_instruction = New System.Windows.Forms.TextBox()
        Me.txtClosedRemark = New System.Windows.Forms.TextBox()
        Me.txtCancelledRemark = New System.Windows.Forms.TextBox()
        Me.dtpClosed = New System.Windows.Forms.DateTimePicker()
        Me.dtpCancelled = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btnGenQty = New System.Windows.Forms.Button()
        Me.btnGenKenddt = New System.Windows.Forms.Button()
        Me.txtDailyCapacity = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtStandardRollKgs = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnRouting = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.BtmfrmDoc_attachments = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtDFBatchSize = New System.Windows.Forms.TextBox()
        Me.txtdyeding_loss_perc = New System.Windows.Forms.TextBox()
        Me.DataGridViewCalendarColumn1 = New ProductionSystem.DataGridViewCalendarColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboProdType = New System.Windows.Forms.ComboBox()
        Me.DataGridViewCalendarColumn2 = New ProductionSystem.DataGridViewCalendarColumn()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtMachineNo = New System.Windows.Forms.TextBox()
        Me.btnMcNoSearch = New System.Windows.Forms.Button()
        Me.txtproduction_order_no_cross = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDesign_cross = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTotal_Production_lot = New System.Windows.Forms.TextBox()
        Me.txtSetupDays = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtknit_loss_perc = New System.Windows.Forms.TextBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpKODate = New System.Windows.Forms.DateTimePicker()
        Me.txtPRODNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboUOM = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboSONo = New System.Windows.Forms.ComboBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnKoClosed = New System.Windows.Forms.Button()
        Me.lblKOClosed = New System.Windows.Forms.Label()
        Me.lblKOClosedFinal = New System.Windows.Forms.Label()
        Me.txtDeliveredRemark = New System.Windows.Forms.TextBox()
        Me.dtpDelivered = New System.Windows.Forms.DateTimePicker()
        Me.BtnDelivered = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDesignMasterRemark = New System.Windows.Forms.TextBox()
        Me.btnSeacthKoNo = New System.Windows.Forms.Button()
        Me.btnOutSourcePO = New System.Windows.Forms.Button()
        Me.GroupBox9.SuspendLayout()
        CType(Me.McboIDYarnChange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdmfg_production_order_lines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.btnDeleteBomLine)
        Me.GroupBox9.Controls.Add(Me.btnAddBomHeader)
        Me.GroupBox9.Controls.Add(Me.btnAddBomLine)
        Me.GroupBox9.Controls.Add(Me.McboIDYarnChange)
        Me.GroupBox9.Controls.Add(Me.Label15)
        Me.GroupBox9.Controls.Add(Me.cboko_mtl_warehouse_id)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.cboline_type)
        Me.GroupBox9.Controls.Add(Me.grdmfg_production_order_lines)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Location = New System.Drawing.Point(15, 287)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(756, 405)
        Me.GroupBox9.TabIndex = 257
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Production Line Items"
        '
        'btnDeleteBomLine
        '
        Me.btnDeleteBomLine.Image = Global.ProductionSystem.My.Resources.Resources.DeleteListItem_16x
        Me.btnDeleteBomLine.Location = New System.Drawing.Point(282, 52)
        Me.btnDeleteBomLine.Name = "btnDeleteBomLine"
        Me.btnDeleteBomLine.Size = New System.Drawing.Size(135, 25)
        Me.btnDeleteBomLine.TabIndex = 278
        Me.btnDeleteBomLine.Text = "Delete Material Line"
        Me.btnDeleteBomLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDeleteBomLine.UseVisualStyleBackColor = True
        '
        'btnAddBomHeader
        '
        Me.btnAddBomHeader.Enabled = False
        Me.btnAddBomHeader.Image = Global.ProductionSystem.My.Resources.Resources.AddItem_16x
        Me.btnAddBomHeader.Location = New System.Drawing.Point(14, 52)
        Me.btnAddBomHeader.Name = "btnAddBomHeader"
        Me.btnAddBomHeader.Size = New System.Drawing.Size(131, 25)
        Me.btnAddBomHeader.TabIndex = 277
        Me.btnAddBomHeader.Text = "Add Product Line"
        Me.btnAddBomHeader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddBomHeader.UseVisualStyleBackColor = True
        '
        'btnAddBomLine
        '
        Me.btnAddBomLine.Image = Global.ProductionSystem.My.Resources.Resources.AddItem_16x
        Me.btnAddBomLine.Location = New System.Drawing.Point(151, 52)
        Me.btnAddBomLine.Name = "btnAddBomLine"
        Me.btnAddBomLine.Size = New System.Drawing.Size(125, 25)
        Me.btnAddBomLine.TabIndex = 276
        Me.btnAddBomLine.Text = "Add Material Line"
        Me.btnAddBomLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddBomLine.UseVisualStyleBackColor = True
        '
        'McboIDYarnChange
        '
        Me.McboIDYarnChange.BackColor = System.Drawing.Color.Khaki
        Me.McboIDYarnChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.McboIDYarnChange.DataSource = Nothing
        Me.McboIDYarnChange.DisplayMember = Nothing
        Me.McboIDYarnChange.Location = New System.Drawing.Point(534, 21)
        Me.McboIDYarnChange.Name = "McboIDYarnChange"
        Me.McboIDYarnChange.SelectedIndex = -1
        Me.McboIDYarnChange.SelectedValue = Nothing
        Me.McboIDYarnChange.Size = New System.Drawing.Size(150, 21)
        Me.McboIDYarnChange.TabIndex = 275
        Me.McboIDYarnChange.ValueMember = Nothing
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(262, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 213
        Me.Label15.Text = "W/H"
        '
        'cboko_mtl_warehouse_id
        '
        Me.cboko_mtl_warehouse_id.FormattingEnabled = True
        Me.cboko_mtl_warehouse_id.Location = New System.Drawing.Point(303, 21)
        Me.cboko_mtl_warehouse_id.Name = "cboko_mtl_warehouse_id"
        Me.cboko_mtl_warehouse_id.Size = New System.Drawing.Size(139, 21)
        Me.cboko_mtl_warehouse_id.TabIndex = 212
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 211
        Me.Label14.Text = "Line Type"
        '
        'cboline_type
        '
        Me.cboline_type.BackColor = System.Drawing.SystemColors.Window
        Me.cboline_type.FormattingEnabled = True
        Me.cboline_type.Location = New System.Drawing.Point(77, 21)
        Me.cboline_type.Name = "cboline_type"
        Me.cboline_type.Size = New System.Drawing.Size(139, 21)
        Me.cboline_type.TabIndex = 209
        '
        'grdmfg_production_order_lines
        '
        Me.grdmfg_production_order_lines.AllowUserToAddRows = False
        Me.grdmfg_production_order_lines.AllowUserToDeleteRows = False
        Me.grdmfg_production_order_lines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdmfg_production_order_lines.ColumnHeadersHeight = 40
        Me.grdmfg_production_order_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdmfg_production_order_lines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMfgProductionOrderId, Me.colMfgProductionOrderLinesId, Me.colLineType, Me.colMfgProductionStepsId, Me.colOperationCode, Me.colItemID, Me.colItcd, Me.colItdesc, Me.colMtlWarehouseId, Me.colWarehouseCode, Me.colSourceSubinventoryId, Me.colSourceSubInventoryCode, Me.bom_perc, Me.plan_qty, Me.actual_qty, Me.collineuomid, Me.collineuom, Me.creation_date, Me.created_by, Me.last_modified_date, Me.last_modified_by, Me.bom_header_id, Me.bom_line_id})
        Me.grdmfg_production_order_lines.Location = New System.Drawing.Point(14, 83)
        Me.grdmfg_production_order_lines.Name = "grdmfg_production_order_lines"
        Me.grdmfg_production_order_lines.RowHeadersVisible = False
        Me.grdmfg_production_order_lines.Size = New System.Drawing.Size(729, 313)
        Me.grdmfg_production_order_lines.TabIndex = 210
        '
        'colMfgProductionOrderId
        '
        Me.colMfgProductionOrderId.DataPropertyName = "mfg_production_order_id"
        Me.colMfgProductionOrderId.HeaderText = "PROD ORDER ID"
        Me.colMfgProductionOrderId.Name = "colMfgProductionOrderId"
        Me.colMfgProductionOrderId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colMfgProductionOrderId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMfgProductionOrderId.Visible = False
        '
        'colMfgProductionOrderLinesId
        '
        Me.colMfgProductionOrderLinesId.DataPropertyName = "mfg_production_order_lines_id"
        Me.colMfgProductionOrderLinesId.HeaderText = "PROD LINES ID"
        Me.colMfgProductionOrderLinesId.Name = "colMfgProductionOrderLinesId"
        Me.colMfgProductionOrderLinesId.ReadOnly = True
        Me.colMfgProductionOrderLinesId.Visible = False
        Me.colMfgProductionOrderLinesId.Width = 50
        '
        'colLineType
        '
        Me.colLineType.DataPropertyName = "line_type"
        Me.colLineType.HeaderText = "Line Type"
        Me.colLineType.Name = "colLineType"
        Me.colLineType.Width = 40
        '
        'colMfgProductionStepsId
        '
        Me.colMfgProductionStepsId.DataPropertyName = "mfg_production_steps_id"
        Me.colMfgProductionStepsId.HeaderText = "Step ID"
        Me.colMfgProductionStepsId.Name = "colMfgProductionStepsId"
        Me.colMfgProductionStepsId.Visible = False
        '
        'colOperationCode
        '
        Me.colOperationCode.DataPropertyName = "operation_code"
        Me.colOperationCode.HeaderText = "Step Operation"
        Me.colOperationCode.Name = "colOperationCode"
        Me.colOperationCode.ReadOnly = True
        '
        'colItemID
        '
        Me.colItemID.DataPropertyName = "item_id"
        Me.colItemID.HeaderText = "Item ID"
        Me.colItemID.Name = "colItemID"
        Me.colItemID.ReadOnly = True
        Me.colItemID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colItemID.Visible = False
        '
        'colItcd
        '
        Me.colItcd.DataPropertyName = "itcd"
        Me.colItcd.HeaderText = "Item Code"
        Me.colItcd.Name = "colItcd"
        Me.colItcd.ReadOnly = True
        '
        'colItdesc
        '
        Me.colItdesc.DataPropertyName = "itdesc"
        Me.colItdesc.HeaderText = "Item Description"
        Me.colItdesc.Name = "colItdesc"
        Me.colItdesc.ReadOnly = True
        '
        'colMtlWarehouseId
        '
        Me.colMtlWarehouseId.DataPropertyName = "mtl_warehouse_id"
        Me.colMtlWarehouseId.HeaderText = "Warehouse"
        Me.colMtlWarehouseId.Name = "colMtlWarehouseId"
        Me.colMtlWarehouseId.ReadOnly = True
        Me.colMtlWarehouseId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colMtlWarehouseId.Visible = False
        Me.colMtlWarehouseId.Width = 80
        '
        'colWarehouseCode
        '
        Me.colWarehouseCode.DataPropertyName = "warehouse_code"
        Me.colWarehouseCode.HeaderText = "W/H"
        Me.colWarehouseCode.Name = "colWarehouseCode"
        Me.colWarehouseCode.ReadOnly = True
        '
        'colSourceSubinventoryId
        '
        Me.colSourceSubinventoryId.DataPropertyName = "source_subinventory_id"
        Me.colSourceSubinventoryId.HeaderText = "Source Subinventory ID"
        Me.colSourceSubinventoryId.Name = "colSourceSubinventoryId"
        Me.colSourceSubinventoryId.ReadOnly = True
        Me.colSourceSubinventoryId.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colSourceSubinventoryId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colSourceSubinventoryId.Visible = False
        Me.colSourceSubinventoryId.Width = 120
        '
        'colSourceSubInventoryCode
        '
        Me.colSourceSubInventoryCode.DataPropertyName = "subinventory_code"
        Me.colSourceSubInventoryCode.HeaderText = "Sub Inventory"
        Me.colSourceSubInventoryCode.Name = "colSourceSubInventoryCode"
        Me.colSourceSubInventoryCode.ReadOnly = True
        '
        'bom_perc
        '
        Me.bom_perc.DataPropertyName = "bom_perc"
        Me.bom_perc.HeaderText = "%"
        Me.bom_perc.Name = "bom_perc"
        Me.bom_perc.Width = 50
        '
        'plan_qty
        '
        Me.plan_qty.DataPropertyName = "plan_qty"
        Me.plan_qty.HeaderText = "Plan QTY"
        Me.plan_qty.Name = "plan_qty"
        Me.plan_qty.Width = 90
        '
        'actual_qty
        '
        Me.actual_qty.DataPropertyName = "actual_qty"
        Me.actual_qty.HeaderText = "Actual Qty"
        Me.actual_qty.Name = "actual_qty"
        Me.actual_qty.ReadOnly = True
        Me.actual_qty.Width = 80
        '
        'collineuomid
        '
        Me.collineuomid.DataPropertyName = "uom_id"
        Me.collineuomid.HeaderText = "UOM ID"
        Me.collineuomid.Name = "collineuomid"
        Me.collineuomid.ReadOnly = True
        Me.collineuomid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.collineuomid.Visible = False
        Me.collineuomid.Width = 60
        '
        'collineuom
        '
        Me.collineuom.DataPropertyName = "uom"
        Me.collineuom.HeaderText = "UOM"
        Me.collineuom.Name = "collineuom"
        Me.collineuom.ReadOnly = True
        '
        'creation_date
        '
        Me.creation_date.DataPropertyName = "creation_date"
        Me.creation_date.HeaderText = "Creation Date"
        Me.creation_date.Name = "creation_date"
        Me.creation_date.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.creation_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.creation_date.Visible = False
        '
        'created_by
        '
        Me.created_by.DataPropertyName = "created_by"
        Me.created_by.HeaderText = "Created BY"
        Me.created_by.Name = "created_by"
        Me.created_by.Visible = False
        '
        'last_modified_date
        '
        Me.last_modified_date.DataPropertyName = "last_modified_date"
        Me.last_modified_date.HeaderText = "Last Modified Date"
        Me.last_modified_date.Name = "last_modified_date"
        Me.last_modified_date.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.last_modified_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.last_modified_date.Visible = False
        '
        'last_modified_by
        '
        Me.last_modified_by.DataPropertyName = "last_modified_by"
        Me.last_modified_by.HeaderText = "Last Modified By"
        Me.last_modified_by.Name = "last_modified_by"
        Me.last_modified_by.Visible = False
        '
        'bom_header_id
        '
        Me.bom_header_id.DataPropertyName = "bom_header_id"
        Me.bom_header_id.HeaderText = "bom_header_id"
        Me.bom_header_id.Name = "bom_header_id"
        Me.bom_header_id.Visible = False
        '
        'bom_line_id
        '
        Me.bom_line_id.DataPropertyName = "bom_line_id"
        Me.bom_line_id.HeaderText = "bom_line_id"
        Me.bom_line_id.Name = "bom_line_id"
        Me.bom_line_id.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(477, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "BOM No."
        '
        'btnPrintIssueTemplate
        '
        Me.btnPrintIssueTemplate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintIssueTemplate.Location = New System.Drawing.Point(923, 77)
        Me.btnPrintIssueTemplate.Name = "btnPrintIssueTemplate"
        Me.btnPrintIssueTemplate.Size = New System.Drawing.Size(75, 37)
        Me.btnPrintIssueTemplate.TabIndex = 256
        Me.btnPrintIssueTemplate.Text = "Print Issue Template"
        Me.btnPrintIssueTemplate.UseVisualStyleBackColor = True
        '
        'lblsteam_instruction
        '
        Me.lblsteam_instruction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblsteam_instruction.AutoSize = True
        Me.lblsteam_instruction.Location = New System.Drawing.Point(783, 492)
        Me.lblsteam_instruction.Name = "lblsteam_instruction"
        Me.lblsteam_instruction.Size = New System.Drawing.Size(97, 13)
        Me.lblsteam_instruction.TabIndex = 255
        Me.lblsteam_instruction.Text = "Steam Instruction"
        '
        'txtsteam_instruction
        '
        Me.txtsteam_instruction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsteam_instruction.Location = New System.Drawing.Point(807, 509)
        Me.txtsteam_instruction.Multiline = True
        Me.txtsteam_instruction.Name = "txtsteam_instruction"
        Me.txtsteam_instruction.Size = New System.Drawing.Size(407, 77)
        Me.txtsteam_instruction.TabIndex = 247
        Me.txtsteam_instruction.Tag = ""
        '
        'txtClosedRemark
        '
        Me.txtClosedRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClosedRemark.Location = New System.Drawing.Point(943, 630)
        Me.txtClosedRemark.Name = "txtClosedRemark"
        Me.txtClosedRemark.Size = New System.Drawing.Size(276, 22)
        Me.txtClosedRemark.TabIndex = 242
        '
        'txtCancelledRemark
        '
        Me.txtCancelledRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCancelledRemark.Location = New System.Drawing.Point(943, 601)
        Me.txtCancelledRemark.Name = "txtCancelledRemark"
        Me.txtCancelledRemark.Size = New System.Drawing.Size(276, 22)
        Me.txtCancelledRemark.TabIndex = 239
        '
        'dtpClosed
        '
        Me.dtpClosed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpClosed.CustomFormat = "dd/MM/yyyy"
        Me.dtpClosed.Enabled = False
        Me.dtpClosed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosed.Location = New System.Drawing.Point(853, 630)
        Me.dtpClosed.Name = "dtpClosed"
        Me.dtpClosed.Size = New System.Drawing.Size(85, 22)
        Me.dtpClosed.TabIndex = 241
        Me.dtpClosed.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtpCancelled
        '
        Me.dtpCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpCancelled.CustomFormat = "dd/MM/yyyy"
        Me.dtpCancelled.Enabled = False
        Me.dtpCancelled.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCancelled.Location = New System.Drawing.Point(853, 601)
        Me.dtpCancelled.Name = "dtpCancelled"
        Me.dtpCancelled.Size = New System.Drawing.Size(85, 22)
        Me.dtpCancelled.TabIndex = 238
        Me.dtpCancelled.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(456, 99)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(16, 13)
        Me.Label30.TabIndex = 25
        Me.Label30.Text = "%"
        '
        'btnGenQty
        '
        Me.btnGenQty.Location = New System.Drawing.Point(474, 69)
        Me.btnGenQty.Name = "btnGenQty"
        Me.btnGenQty.Size = New System.Drawing.Size(75, 44)
        Me.btnGenQty.TabIndex = 226
        Me.btnGenQty.Text = "Generate Quantity"
        Me.btnGenQty.UseVisualStyleBackColor = True
        '
        'btnGenKenddt
        '
        Me.btnGenKenddt.Location = New System.Drawing.Point(474, 19)
        Me.btnGenKenddt.Name = "btnGenKenddt"
        Me.btnGenKenddt.Size = New System.Drawing.Size(75, 44)
        Me.btnGenKenddt.TabIndex = 225
        Me.btnGenKenddt.Text = "Generate End Date"
        Me.btnGenKenddt.UseVisualStyleBackColor = True
        '
        'txtDailyCapacity
        '
        Me.txtDailyCapacity.BackColor = System.Drawing.Color.Khaki
        Me.txtDailyCapacity.Location = New System.Drawing.Point(387, 48)
        Me.txtDailyCapacity.Name = "txtDailyCapacity"
        Me.txtDailyCapacity.Size = New System.Drawing.Size(64, 22)
        Me.txtDailyCapacity.TabIndex = 19
        Me.txtDailyCapacity.Tag = "0"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(220, 124)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 13)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "%"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(268, 50)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(108, 13)
        Me.Label25.TabIndex = 210
        Me.Label25.Text = "Daily Capacity (Kgs.)"
        '
        'txtStandardRollKgs
        '
        Me.txtStandardRollKgs.BackColor = System.Drawing.Color.Khaki
        Me.txtStandardRollKgs.Location = New System.Drawing.Point(387, 22)
        Me.txtStandardRollKgs.Name = "txtStandardRollKgs"
        Me.txtStandardRollKgs.Size = New System.Drawing.Size(64, 22)
        Me.txtStandardRollKgs.TabIndex = 17
        Me.txtStandardRollKgs.Tag = "0"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnNew, Me.btnCopy, Me.btnSave, Me.btnRouting, Me.btnPrint, Me.btnMinimized, Me.BtmfrmDoc_attachments, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1235, 25)
        Me.ToolStrip1.TabIndex = 248
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnCopy
        '
        Me.btnCopy.Image = CType(resources.GetObject("btnCopy.Image"), System.Drawing.Image)
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(55, 22)
        Me.btnCopy.Text = "Copy"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnRouting
        '
        Me.btnRouting.Image = CType(resources.GetObject("btnRouting.Image"), System.Drawing.Image)
        Me.btnRouting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRouting.Name = "btnRouting"
        Me.btnRouting.Size = New System.Drawing.Size(69, 22)
        Me.btnRouting.Text = "Routing"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'BtmfrmDoc_attachments
        '
        Me.BtmfrmDoc_attachments.Image = CType(resources.GetObject("BtmfrmDoc_attachments.Image"), System.Drawing.Image)
        Me.BtmfrmDoc_attachments.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtmfrmDoc_attachments.Name = "BtmfrmDoc_attachments"
        Me.BtmfrmDoc_attachments.Size = New System.Drawing.Size(59, 22)
        Me.BtmfrmDoc_attachments.Text = "Photo"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 22)
        Me.btnExit.Text = "Exit"
        '
        'txtDFBatchSize
        '
        Me.txtDFBatchSize.Location = New System.Drawing.Point(387, 72)
        Me.txtDFBatchSize.Name = "txtDFBatchSize"
        Me.txtDFBatchSize.Size = New System.Drawing.Size(64, 22)
        Me.txtDFBatchSize.TabIndex = 18
        Me.txtDFBatchSize.Tag = "0"
        '
        'txtdyeding_loss_perc
        '
        Me.txtdyeding_loss_perc.Location = New System.Drawing.Point(386, 96)
        Me.txtdyeding_loss_perc.Name = "txtdyeding_loss_perc"
        Me.txtdyeding_loss_perc.Size = New System.Drawing.Size(64, 22)
        Me.txtdyeding_loss_perc.TabIndex = 23
        Me.txtdyeding_loss_perc.Tag = "0"
        '
        'DataGridViewCalendarColumn1
        '
        Me.DataGridViewCalendarColumn1.DataPropertyName = "creation_date"
        Me.DataGridViewCalendarColumn1.HeaderText = "Creation Date"
        Me.DataGridViewCalendarColumn1.Name = "DataGridViewCalendarColumn1"
        Me.DataGridViewCalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCalendarColumn1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Khaki
        Me.TextBox1.Location = New System.Drawing.Point(468, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(99, 22)
        Me.TextBox1.TabIndex = 253
        Me.TextBox1.Tag = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(383, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 259
        Me.Label4.Text = "Outsource PO:"
        '
        'cboProdType
        '
        Me.cboProdType.FormattingEnabled = True
        Me.cboProdType.Location = New System.Drawing.Point(132, 68)
        Me.cboProdType.Name = "cboProdType"
        Me.cboProdType.Size = New System.Drawing.Size(243, 21)
        Me.cboProdType.TabIndex = 258
        '
        'DataGridViewCalendarColumn2
        '
        Me.DataGridViewCalendarColumn2.DataPropertyName = "last_modified_date"
        Me.DataGridViewCalendarColumn2.HeaderText = "Last Modified Date"
        Me.DataGridViewCalendarColumn2.Name = "DataGridViewCalendarColumn2"
        Me.DataGridViewCalendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCalendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCalendarColumn2.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(234, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(148, 13)
        Me.Label20.TabIndex = 200
        Me.Label20.Text = "Standard Roll Weight (Kgs.)"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtMachineNo)
        Me.GroupBox5.Controls.Add(Me.btnMcNoSearch)
        Me.GroupBox5.Controls.Add(Me.txtproduction_order_no_cross)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtDesign_cross)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.txtTotal_Production_lot)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.btnGenQty)
        Me.GroupBox5.Controls.Add(Me.btnGenKenddt)
        Me.GroupBox5.Controls.Add(Me.txtDailyCapacity)
        Me.GroupBox5.Controls.Add(Me.Label29)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txtStandardRollKgs)
        Me.GroupBox5.Controls.Add(Me.txtDFBatchSize)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtdyeding_loss_perc)
        Me.GroupBox5.Controls.Add(Me.txtSetupDays)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtknit_loss_perc)
        Me.GroupBox5.Controls.Add(Me.dtpEndDate)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.dtpStartDate)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(453, 135)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(770, 146)
        Me.GroupBox5.TabIndex = 236
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PLANNING INFORMATION"
        '
        'txtMachineNo
        '
        Me.txtMachineNo.BackColor = System.Drawing.Color.Khaki
        Me.txtMachineNo.Location = New System.Drawing.Point(115, 24)
        Me.txtMachineNo.Name = "txtMachineNo"
        Me.txtMachineNo.Size = New System.Drawing.Size(76, 22)
        Me.txtMachineNo.TabIndex = 262
        Me.txtMachineNo.Tag = ""
        '
        'btnMcNoSearch
        '
        Me.btnMcNoSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnMcNoSearch.Image = CType(resources.GetObject("btnMcNoSearch.Image"), System.Drawing.Image)
        Me.btnMcNoSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMcNoSearch.Location = New System.Drawing.Point(194, 23)
        Me.btnMcNoSearch.Name = "btnMcNoSearch"
        Me.btnMcNoSearch.Size = New System.Drawing.Size(24, 23)
        Me.btnMcNoSearch.TabIndex = 261
        Me.btnMcNoSearch.Text = "..."
        Me.btnMcNoSearch.UseVisualStyleBackColor = True
        '
        'txtproduction_order_no_cross
        '
        Me.txtproduction_order_no_cross.Location = New System.Drawing.Point(654, 48)
        Me.txtproduction_order_no_cross.Name = "txtproduction_order_no_cross"
        Me.txtproduction_order_no_cross.Size = New System.Drawing.Size(89, 22)
        Me.txtproduction_order_no_cross.TabIndex = 235
        Me.txtproduction_order_no_cross.Tag = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(555, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 13)
        Me.Label16.TabIndex = 234
        Me.Label16.Text = "Warp For KO No."
        '
        'txtDesign_cross
        '
        Me.txtDesign_cross.Location = New System.Drawing.Point(654, 22)
        Me.txtDesign_cross.Name = "txtDesign_cross"
        Me.txtDesign_cross.Size = New System.Drawing.Size(89, 22)
        Me.txtDesign_cross.TabIndex = 233
        Me.txtDesign_cross.Tag = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(554, 27)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 13)
        Me.Label17.TabIndex = 232
        Me.Label17.Text = "Warp For Dm No."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(263, 123)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(116, 13)
        Me.Label31.TabIndex = 231
        Me.Label31.Text = "Total Production Lots"
        '
        'txtTotal_Production_lot
        '
        Me.txtTotal_Production_lot.BackColor = System.Drawing.Color.Gold
        Me.txtTotal_Production_lot.Location = New System.Drawing.Point(387, 120)
        Me.txtTotal_Production_lot.Name = "txtTotal_Production_lot"
        Me.txtTotal_Production_lot.Size = New System.Drawing.Size(64, 22)
        Me.txtTotal_Production_lot.TabIndex = 230
        Me.txtTotal_Production_lot.Tag = "0.00"
        '
        'txtSetupDays
        '
        Me.txtSetupDays.BackColor = System.Drawing.Color.Khaki
        Me.txtSetupDays.Location = New System.Drawing.Point(115, 96)
        Me.txtSetupDays.Name = "txtSetupDays"
        Me.txtSetupDays.Size = New System.Drawing.Size(104, 22)
        Me.txtSetupDays.TabIndex = 16
        Me.txtSetupDays.Tag = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(40, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 13)
        Me.Label19.TabIndex = 198
        Me.Label19.Text = "Setup Days"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(30, 75)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(78, 13)
        Me.Label18.TabIndex = 197
        Me.Label18.Text = "Finished Date"
        '
        'txtknit_loss_perc
        '
        Me.txtknit_loss_perc.Location = New System.Drawing.Point(115, 120)
        Me.txtknit_loss_perc.Name = "txtknit_loss_perc"
        Me.txtknit_loss_perc.Size = New System.Drawing.Size(104, 22)
        Me.txtknit_loss_perc.TabIndex = 22
        Me.txtknit_loss_perc.Tag = "0"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(115, 72)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.ShowCheckBox = True
        Me.dtpEndDate.Size = New System.Drawing.Size(104, 22)
        Me.dtpEndDate.TabIndex = 15
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(290, 99)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(68, 13)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Dyeing Loss"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Start Date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(115, 48)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.ShowCheckBox = True
        Me.dtpStartDate.Size = New System.Drawing.Size(104, 22)
        Me.dtpStartDate.TabIndex = 14
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(19, 123)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(89, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Produciton Loss"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(34, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 13)
        Me.Label27.TabIndex = 193
        Me.Label27.Text = "Machine No."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(291, 75)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 13)
        Me.Label21.TabIndex = 202
        Me.Label21.Text = "D/F Batch Size"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 251
        Me.Label3.Text = "PRODUCTION TYPE:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1004, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 250
        Me.Label2.Text = "PROD. Date"
        '
        'dtpKODate
        '
        Me.dtpKODate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpKODate.CustomFormat = "dd/MM/yyyy"
        Me.dtpKODate.Enabled = False
        Me.dtpKODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKODate.Location = New System.Drawing.Point(1080, 96)
        Me.dtpKODate.Name = "dtpKODate"
        Me.dtpKODate.Size = New System.Drawing.Size(104, 22)
        Me.dtpKODate.TabIndex = 234
        '
        'txtPRODNo
        '
        Me.txtPRODNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPRODNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtPRODNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPRODNo.Location = New System.Drawing.Point(1080, 72)
        Me.txtPRODNo.Name = "txtPRODNo"
        Me.txtPRODNo.Size = New System.Drawing.Size(104, 22)
        Me.txtPRODNo.TabIndex = 232
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1004, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "PROD. No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(201, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Unit:"
        '
        'cboUOM
        '
        Me.cboUOM.BackColor = System.Drawing.Color.Khaki
        Me.cboUOM.FormattingEnabled = True
        Me.cboUOM.Location = New System.Drawing.Point(236, 110)
        Me.cboUOM.Name = "cboUOM"
        Me.cboUOM.Size = New System.Drawing.Size(91, 21)
        Me.cboUOM.TabIndex = 206
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(31, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 205
        Me.Label13.Text = "Customer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(383, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 252
        Me.Label7.Text = "Supplier"
        '
        'cboDesignNo
        '
        Me.cboDesignNo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDesignNo.BackColor = System.Drawing.Color.Khaki
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(89, 81)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(329, 21)
        Me.cboDesignNo.TabIndex = 4
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Khaki
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(468, 95)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(425, 21)
        Me.cboSupplier.TabIndex = 233
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Item No."
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Khaki
        Me.txtQty.Location = New System.Drawing.Point(89, 110)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(56, 22)
        Me.txtQty.TabIndex = 2
        Me.txtQty.Tag = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "Production Qty"
        '
        'cboSONo
        '
        Me.cboSONo.BackColor = System.Drawing.Color.Khaki
        Me.cboSONo.FormattingEnabled = True
        Me.cboSONo.Location = New System.Drawing.Point(89, 21)
        Me.cboSONo.Name = "cboSONo"
        Me.cboSONo.Size = New System.Drawing.Size(136, 21)
        Me.cboSONo.TabIndex = 1
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(810, 399)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(407, 77)
        Me.txtRemark.TabIndex = 243
        Me.txtRemark.Tag = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 197
        Me.Label9.Text = "S/O No."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.cboUOM)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtQty)
        Me.GroupBox4.Controls.Add(Me.cboDesignNo)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cboSONo)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cboCustomer)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 135)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 146)
        Me.GroupBox4.TabIndex = 235
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ORDER INFORMATION"
        '
        'cboCustomer
        '
        Me.cboCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(89, 51)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(329, 21)
        Me.cboCustomer.TabIndex = 3
        '
        'lblCancelled
        '
        Me.lblCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(900, 45)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(121, 24)
        Me.lblCancelled.TabIndex = 261
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCancelled.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Location = New System.Drawing.Point(780, 601)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(67, 23)
        Me.BtnCancel.TabIndex = 262
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnKoClosed
        '
        Me.BtnKoClosed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnKoClosed.Location = New System.Drawing.Point(780, 630)
        Me.BtnKoClosed.Name = "BtnKoClosed"
        Me.BtnKoClosed.Size = New System.Drawing.Size(66, 23)
        Me.BtnKoClosed.TabIndex = 263
        Me.BtnKoClosed.Text = "Closed"
        Me.BtnKoClosed.UseVisualStyleBackColor = True
        '
        'lblKOClosed
        '
        Me.lblKOClosed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKOClosed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKOClosed.ForeColor = System.Drawing.Color.Red
        Me.lblKOClosed.Location = New System.Drawing.Point(1018, 45)
        Me.lblKOClosed.Name = "lblKOClosed"
        Me.lblKOClosed.Size = New System.Drawing.Size(87, 24)
        Me.lblKOClosed.TabIndex = 265
        Me.lblKOClosed.Text = "Closed"
        Me.lblKOClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblKOClosed.Visible = False
        '
        'lblKOClosedFinal
        '
        Me.lblKOClosedFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKOClosedFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKOClosedFinal.ForeColor = System.Drawing.Color.Red
        Me.lblKOClosedFinal.Location = New System.Drawing.Point(1103, 45)
        Me.lblKOClosedFinal.Name = "lblKOClosedFinal"
        Me.lblKOClosedFinal.Size = New System.Drawing.Size(115, 24)
        Me.lblKOClosedFinal.TabIndex = 266
        Me.lblKOClosedFinal.Text = "Delivered"
        Me.lblKOClosedFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblKOClosedFinal.Visible = False
        '
        'txtDeliveredRemark
        '
        Me.txtDeliveredRemark.Location = New System.Drawing.Point(943, 660)
        Me.txtDeliveredRemark.Name = "txtDeliveredRemark"
        Me.txtDeliveredRemark.Size = New System.Drawing.Size(276, 22)
        Me.txtDeliveredRemark.TabIndex = 268
        Me.txtDeliveredRemark.Visible = False
        '
        'dtpDelivered
        '
        Me.dtpDelivered.CustomFormat = "dd/MM/yyyy"
        Me.dtpDelivered.Enabled = False
        Me.dtpDelivered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDelivered.Location = New System.Drawing.Point(853, 658)
        Me.dtpDelivered.Name = "dtpDelivered"
        Me.dtpDelivered.Size = New System.Drawing.Size(85, 22)
        Me.dtpDelivered.TabIndex = 267
        Me.dtpDelivered.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDelivered.Visible = False
        '
        'BtnDelivered
        '
        Me.BtnDelivered.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelivered.Location = New System.Drawing.Point(780, 659)
        Me.BtnDelivered.Name = "BtnDelivered"
        Me.BtnDelivered.Size = New System.Drawing.Size(66, 23)
        Me.BtnDelivered.TabIndex = 269
        Me.BtnDelivered.Text = "Delivered"
        Me.BtnDelivered.UseVisualStyleBackColor = True
        Me.BtnDelivered.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(785, 380)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 13)
        Me.Label22.TabIndex = 271
        Me.Label22.Text = "Production Remark :"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(786, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 13)
        Me.Label10.TabIndex = 273
        Me.Label10.Text = "Design Master Remark :"
        '
        'txtDesignMasterRemark
        '
        Me.txtDesignMasterRemark.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDesignMasterRemark.Location = New System.Drawing.Point(811, 308)
        Me.txtDesignMasterRemark.Multiline = True
        Me.txtDesignMasterRemark.Name = "txtDesignMasterRemark"
        Me.txtDesignMasterRemark.ReadOnly = True
        Me.txtDesignMasterRemark.Size = New System.Drawing.Size(407, 55)
        Me.txtDesignMasterRemark.TabIndex = 272
        Me.txtDesignMasterRemark.Tag = ""
        '
        'btnSeacthKoNo
        '
        Me.btnSeacthKoNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeacthKoNo.Image = CType(resources.GetObject("btnSeacthKoNo.Image"), System.Drawing.Image)
        Me.btnSeacthKoNo.Location = New System.Drawing.Point(1186, 71)
        Me.btnSeacthKoNo.Name = "btnSeacthKoNo"
        Me.btnSeacthKoNo.Size = New System.Drawing.Size(28, 23)
        Me.btnSeacthKoNo.TabIndex = 270
        Me.btnSeacthKoNo.UseVisualStyleBackColor = True
        '
        'btnOutSourcePO
        '
        Me.btnOutSourcePO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnOutSourcePO.Image = CType(resources.GetObject("btnOutSourcePO.Image"), System.Drawing.Image)
        Me.btnOutSourcePO.Location = New System.Drawing.Point(569, 67)
        Me.btnOutSourcePO.Name = "btnOutSourcePO"
        Me.btnOutSourcePO.Size = New System.Drawing.Size(29, 22)
        Me.btnOutSourcePO.TabIndex = 260
        Me.btnOutSourcePO.Text = "..."
        Me.btnOutSourcePO.UseVisualStyleBackColor = True
        '
        'frmKnittingOrderNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 701)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDesignMasterRemark)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnSeacthKoNo)
        Me.Controls.Add(Me.BtnDelivered)
        Me.Controls.Add(Me.txtDeliveredRemark)
        Me.Controls.Add(Me.dtpDelivered)
        Me.Controls.Add(Me.lblKOClosedFinal)
        Me.Controls.Add(Me.lblKOClosed)
        Me.Controls.Add(Me.BtnKoClosed)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.lblCancelled)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.btnPrintIssueTemplate)
        Me.Controls.Add(Me.lblsteam_instruction)
        Me.Controls.Add(Me.txtsteam_instruction)
        Me.Controls.Add(Me.txtClosedRemark)
        Me.Controls.Add(Me.txtCancelledRemark)
        Me.Controls.Add(Me.dtpClosed)
        Me.Controls.Add(Me.dtpCancelled)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboProdType)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpKODate)
        Me.Controls.Add(Me.txtPRODNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOutSourcePO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboSupplier)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmKnittingOrderNew"
        Me.Text = "Production Order New"
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.McboIDYarnChange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdmfg_production_order_lines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboline_type As System.Windows.Forms.ComboBox
    Friend WithEvents grdmfg_production_order_lines As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnPrintIssueTemplate As System.Windows.Forms.Button
    Friend WithEvents lblsteam_instruction As System.Windows.Forms.Label
    Friend WithEvents txtsteam_instruction As System.Windows.Forms.TextBox
    Friend WithEvents txtClosedRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtCancelledRemark As System.Windows.Forms.TextBox
    Friend WithEvents dtpClosed As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCancelled As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents btnGenQty As System.Windows.Forms.Button
    Friend WithEvents btnGenKenddt As System.Windows.Forms.Button
    Friend WithEvents txtDailyCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtStandardRollKgs As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRouting As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtDFBatchSize As System.Windows.Forms.TextBox
    Friend WithEvents txtdyeding_loss_perc As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewCalendarColumn1 As ProductionSystem.DataGridViewCalendarColumn
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboProdType As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridViewCalendarColumn2 As ProductionSystem.DataGridViewCalendarColumn
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSetupDays As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtknit_loss_perc As System.Windows.Forms.TextBox
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpKODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPRODNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboUOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnOutSourcePO As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboSONo As System.Windows.Forms.ComboBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cboko_mtl_warehouse_id As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_Production_lot As System.Windows.Forms.TextBox
    Friend WithEvents txtproduction_order_no_cross As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDesign_cross As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblCancelled As System.Windows.Forms.Label
    Friend WithEvents BtmfrmDoc_attachments As ToolStripButton
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnKoClosed As Button
    Friend WithEvents lblKOClosed As Label
    Friend WithEvents lblKOClosedFinal As Label
    Friend WithEvents txtDeliveredRemark As TextBox
    Friend WithEvents dtpDelivered As DateTimePicker
    Friend WithEvents BtnDelivered As Button
    Friend WithEvents btnSeacthKoNo As Button
    Friend WithEvents btnAddBomLine As Button
    Friend WithEvents McboIDYarnChange As ProductionSystem.Controls.MultiColumnComboBox
    Friend WithEvents btnDeleteBomLine As Button
    Friend WithEvents btnAddBomHeader As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label22 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtDesignMasterRemark As TextBox
    Friend WithEvents btnMcNoSearch As Button
    Friend WithEvents txtMachineNo As TextBox
    Friend WithEvents colMfgProductionOrderId As DataGridViewTextBoxColumn
    Friend WithEvents colMfgProductionOrderLinesId As DataGridViewTextBoxColumn
    Friend WithEvents colLineType As DataGridViewTextBoxColumn
    Friend WithEvents colMfgProductionStepsId As DataGridViewTextBoxColumn
    Friend WithEvents colOperationCode As DataGridViewTextBoxColumn
    Friend WithEvents colItemID As DataGridViewTextBoxColumn
    Friend WithEvents colItcd As DataGridViewTextBoxColumn
    Friend WithEvents colItdesc As DataGridViewTextBoxColumn
    Friend WithEvents colMtlWarehouseId As DataGridViewTextBoxColumn
    Friend WithEvents colWarehouseCode As DataGridViewTextBoxColumn
    Friend WithEvents colSourceSubinventoryId As DataGridViewTextBoxColumn
    Friend WithEvents colSourceSubInventoryCode As DataGridViewTextBoxColumn
    Friend WithEvents bom_perc As DataGridViewTextBoxColumn
    Friend WithEvents plan_qty As DataGridViewTextBoxColumn
    Friend WithEvents actual_qty As DataGridViewTextBoxColumn
    Friend WithEvents collineuomid As DataGridViewTextBoxColumn
    Friend WithEvents collineuom As DataGridViewTextBoxColumn
    Friend WithEvents creation_date As DataGridViewCalendarColumn
    Friend WithEvents created_by As DataGridViewTextBoxColumn
    Friend WithEvents last_modified_date As DataGridViewCalendarColumn
    Friend WithEvents last_modified_by As DataGridViewTextBoxColumn
    Friend WithEvents bom_header_id As DataGridViewTextBoxColumn
    Friend WithEvents bom_line_id As DataGridViewTextBoxColumn
End Class
