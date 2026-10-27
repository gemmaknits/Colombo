<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWOReservations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWOReservations))
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtWoNo = New System.Windows.Forms.TextBox()
        Me.lblWoNo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.grdProductionOrderLines = New System.Windows.Forms.DataGridView()
        Me.grdProductionOrderLinesDemandSourceLineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesSupplySourceItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesMtlWarehouseID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesSourceSubinventoryID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesLineType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesBomPerc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesPlanQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesActualQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesUomID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesCreationDate = New ProductionSystem.DataGridViewCalendarColumn()
        Me.grdProductionOrderLinesCreatedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesLastModifiedDate = New ProductionSystem.DataGridViewCalendarColumn()
        Me.grdProductionOrderLinesLastModifiedBy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesBomHeaderID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesBomLineId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesmc_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionOrderLinesMachine_Bar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtKoNo = New System.Windows.Forms.TextBox()
        Me.lblKoNo = New System.Windows.Forms.Label()
        Me.cboWOItems = New System.Windows.Forms.ComboBox()
        Me.lblWOItems = New System.Windows.Forms.Label()
        Me.grdProductionLots = New System.Windows.Forms.DataGridView()
        Me.grdProductionLotsSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdProductionLotsMfgProductionOrderLines_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsSupplySourceItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsSupplySourceLotNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsCustomLotNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsSubinventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsReserveQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsReserveQtyBal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsReserveUomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsReserveMC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdProductionLotsReserveMachineBar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservations = New System.Windows.Forms.DataGridView()
        Me.grdReservationsSel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.grdReservationsDemandSourceHeaderCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsDemandSourceLineID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsSupplySourceItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsSupplySourceLotNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsCustomLotNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsWarehouseCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsSubinventoryCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsReserveQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.machine_bar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grdReservationsReserveUomName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSupplySourceHeaderMcno = New System.Windows.Forms.TextBox()
        Me.lblSupplySourceHeaderMcno = New System.Windows.Forms.Label()
        Me.lblitdesc2 = New System.Windows.Forms.Label()
        Me.txtitdesc2 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGetRSNo = New System.Windows.Forms.Button()
        Me.lblMcNo = New System.Windows.Forms.Label()
        Me.txtMcNo = New System.Windows.Forms.TextBox()
        Me.lblDesignNo = New System.Windows.Forms.Label()
        Me.txtDesignNo = New System.Windows.Forms.TextBox()
        Me.lblReservationsDate = New System.Windows.Forms.Label()
        Me.lblReservationsNumber = New System.Windows.Forms.Label()
        Me.btnSearchCustomers = New System.Windows.Forms.Button()
        Me.dtpReservationsDate = New System.Windows.Forms.DateTimePicker()
        Me.txtReservationsNumber = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewCalendarColumn1 = New ProductionSystem.DataGridViewCalendarColumn()
        Me.DataGridViewCalendarColumn2 = New ProductionSystem.DataGridViewCalendarColumn()
        Me.btnMoveRight = New System.Windows.Forms.Button()
        Me.btnMoveLeft = New System.Windows.Forms.Button()
        Me.btnDelAll = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblStockKgs = New System.Windows.Forms.Label()
        Me.txtTotalQtyBalStk = New System.Windows.Forms.TextBox()
        Me.lblStockRoll = New System.Windows.Forms.Label()
        Me.txtTotalLotsStk = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalQtyRS = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTotalLotsRs = New System.Windows.Forms.TextBox()
        Me.lblStockTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdProductionOrderLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdProductionLots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdReservations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtWoNo
        '
        Me.txtWoNo.Location = New System.Drawing.Point(90, 20)
        Me.txtWoNo.Name = "txtWoNo"
        Me.txtWoNo.Size = New System.Drawing.Size(104, 20)
        Me.txtWoNo.TabIndex = 250
        '
        'lblWoNo
        '
        Me.lblWoNo.AutoSize = True
        Me.lblWoNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWoNo.Location = New System.Drawing.Point(32, 23)
        Me.lblWoNo.Name = "lblWoNo"
        Me.lblWoNo.Size = New System.Drawing.Size(52, 13)
        Me.lblWoNo.TabIndex = 251
        Me.lblWoNo.Text = "W/O No."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1023, 25)
        Me.ToolStrip1.TabIndex = 252
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(51, 22)
        Me.btnNew.Text = "New"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Visible = False
        '
        'btnMinimized
        '
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(83, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'grdProductionOrderLines
        '
        Me.grdProductionOrderLines.AllowUserToAddRows = False
        Me.grdProductionOrderLines.AllowUserToDeleteRows = False
        Me.grdProductionOrderLines.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionOrderLines.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grdProductionOrderLines.ColumnHeadersHeight = 50
        Me.grdProductionOrderLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdProductionOrderLines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdProductionOrderLinesDemandSourceLineID, Me.grdProductionOrderLinesSupplySourceItemCode, Me.grdProductionOrderLinesMtlWarehouseID, Me.grdProductionOrderLinesSourceSubinventoryID, Me.grdProductionOrderLinesLineType, Me.grdProductionOrderLinesBomPerc, Me.grdProductionOrderLinesPlanQty, Me.grdProductionOrderLinesActualQty, Me.grdProductionOrderLinesUomID, Me.grdProductionOrderLinesCreationDate, Me.grdProductionOrderLinesCreatedBy, Me.grdProductionOrderLinesLastModifiedDate, Me.grdProductionOrderLinesLastModifiedBy, Me.grdProductionOrderLinesBomHeaderID, Me.grdProductionOrderLinesBomLineId, Me.grdProductionOrderLinesmc_no, Me.grdProductionOrderLinesMachine_Bar})
        Me.grdProductionOrderLines.Location = New System.Drawing.Point(19, 67)
        Me.grdProductionOrderLines.Name = "grdProductionOrderLines"
        Me.grdProductionOrderLines.Size = New System.Drawing.Size(735, 164)
        Me.grdProductionOrderLines.TabIndex = 253
        '
        'grdProductionOrderLinesDemandSourceLineID
        '
        Me.grdProductionOrderLinesDemandSourceLineID.DataPropertyName = "demand_source_line_id"
        Me.grdProductionOrderLinesDemandSourceLineID.HeaderText = "K/O Line ID"
        Me.grdProductionOrderLinesDemandSourceLineID.Name = "grdProductionOrderLinesDemandSourceLineID"
        Me.grdProductionOrderLinesDemandSourceLineID.ReadOnly = True
        Me.grdProductionOrderLinesDemandSourceLineID.Width = 70
        '
        'grdProductionOrderLinesSupplySourceItemCode
        '
        Me.grdProductionOrderLinesSupplySourceItemCode.DataPropertyName = "supply_source_item_code"
        Me.grdProductionOrderLinesSupplySourceItemCode.HeaderText = "Inventory Item Code"
        Me.grdProductionOrderLinesSupplySourceItemCode.Name = "grdProductionOrderLinesSupplySourceItemCode"
        Me.grdProductionOrderLinesSupplySourceItemCode.ReadOnly = True
        Me.grdProductionOrderLinesSupplySourceItemCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'grdProductionOrderLinesMtlWarehouseID
        '
        Me.grdProductionOrderLinesMtlWarehouseID.DataPropertyName = "warehouse_code"
        Me.grdProductionOrderLinesMtlWarehouseID.HeaderText = "Warehouse"
        Me.grdProductionOrderLinesMtlWarehouseID.Name = "grdProductionOrderLinesMtlWarehouseID"
        Me.grdProductionOrderLinesMtlWarehouseID.ReadOnly = True
        Me.grdProductionOrderLinesMtlWarehouseID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionOrderLinesMtlWarehouseID.Width = 80
        '
        'grdProductionOrderLinesSourceSubinventoryID
        '
        Me.grdProductionOrderLinesSourceSubinventoryID.DataPropertyName = "subinventory_code"
        Me.grdProductionOrderLinesSourceSubinventoryID.HeaderText = "Source Subinventory"
        Me.grdProductionOrderLinesSourceSubinventoryID.Name = "grdProductionOrderLinesSourceSubinventoryID"
        Me.grdProductionOrderLinesSourceSubinventoryID.ReadOnly = True
        Me.grdProductionOrderLinesSourceSubinventoryID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionOrderLinesSourceSubinventoryID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.grdProductionOrderLinesSourceSubinventoryID.Width = 120
        '
        'grdProductionOrderLinesLineType
        '
        Me.grdProductionOrderLinesLineType.DataPropertyName = "line_type"
        Me.grdProductionOrderLinesLineType.HeaderText = "Type"
        Me.grdProductionOrderLinesLineType.Name = "grdProductionOrderLinesLineType"
        Me.grdProductionOrderLinesLineType.ReadOnly = True
        Me.grdProductionOrderLinesLineType.Visible = False
        '
        'grdProductionOrderLinesBomPerc
        '
        Me.grdProductionOrderLinesBomPerc.DataPropertyName = "bom_perc"
        Me.grdProductionOrderLinesBomPerc.HeaderText = "%"
        Me.grdProductionOrderLinesBomPerc.Name = "grdProductionOrderLinesBomPerc"
        Me.grdProductionOrderLinesBomPerc.ReadOnly = True
        Me.grdProductionOrderLinesBomPerc.Width = 50
        '
        'grdProductionOrderLinesPlanQty
        '
        Me.grdProductionOrderLinesPlanQty.DataPropertyName = "plan_qty"
        Me.grdProductionOrderLinesPlanQty.HeaderText = "Plan QTY"
        Me.grdProductionOrderLinesPlanQty.Name = "grdProductionOrderLinesPlanQty"
        Me.grdProductionOrderLinesPlanQty.ReadOnly = True
        Me.grdProductionOrderLinesPlanQty.Width = 90
        '
        'grdProductionOrderLinesActualQty
        '
        Me.grdProductionOrderLinesActualQty.DataPropertyName = "actual_qty"
        Me.grdProductionOrderLinesActualQty.HeaderText = "Actual Qty"
        Me.grdProductionOrderLinesActualQty.Name = "grdProductionOrderLinesActualQty"
        Me.grdProductionOrderLinesActualQty.ReadOnly = True
        Me.grdProductionOrderLinesActualQty.Width = 80
        '
        'grdProductionOrderLinesUomID
        '
        Me.grdProductionOrderLinesUomID.DataPropertyName = "ko_uom_name"
        Me.grdProductionOrderLinesUomID.HeaderText = "UOM"
        Me.grdProductionOrderLinesUomID.Name = "grdProductionOrderLinesUomID"
        Me.grdProductionOrderLinesUomID.ReadOnly = True
        Me.grdProductionOrderLinesUomID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionOrderLinesUomID.Width = 60
        '
        'grdProductionOrderLinesCreationDate
        '
        Me.grdProductionOrderLinesCreationDate.DataPropertyName = "creation_date"
        Me.grdProductionOrderLinesCreationDate.HeaderText = "Creation Date"
        Me.grdProductionOrderLinesCreationDate.Name = "grdProductionOrderLinesCreationDate"
        Me.grdProductionOrderLinesCreationDate.ReadOnly = True
        Me.grdProductionOrderLinesCreationDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionOrderLinesCreationDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdProductionOrderLinesCreationDate.Visible = False
        '
        'grdProductionOrderLinesCreatedBy
        '
        Me.grdProductionOrderLinesCreatedBy.DataPropertyName = "created_by"
        Me.grdProductionOrderLinesCreatedBy.HeaderText = "Created BY"
        Me.grdProductionOrderLinesCreatedBy.Name = "grdProductionOrderLinesCreatedBy"
        Me.grdProductionOrderLinesCreatedBy.ReadOnly = True
        Me.grdProductionOrderLinesCreatedBy.Visible = False
        '
        'grdProductionOrderLinesLastModifiedDate
        '
        Me.grdProductionOrderLinesLastModifiedDate.DataPropertyName = "last_modified_date"
        Me.grdProductionOrderLinesLastModifiedDate.HeaderText = "Last Modified Date"
        Me.grdProductionOrderLinesLastModifiedDate.Name = "grdProductionOrderLinesLastModifiedDate"
        Me.grdProductionOrderLinesLastModifiedDate.ReadOnly = True
        Me.grdProductionOrderLinesLastModifiedDate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionOrderLinesLastModifiedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdProductionOrderLinesLastModifiedDate.Visible = False
        '
        'grdProductionOrderLinesLastModifiedBy
        '
        Me.grdProductionOrderLinesLastModifiedBy.DataPropertyName = "last_modified_by"
        Me.grdProductionOrderLinesLastModifiedBy.HeaderText = "Last Modified By"
        Me.grdProductionOrderLinesLastModifiedBy.Name = "grdProductionOrderLinesLastModifiedBy"
        Me.grdProductionOrderLinesLastModifiedBy.ReadOnly = True
        Me.grdProductionOrderLinesLastModifiedBy.Visible = False
        '
        'grdProductionOrderLinesBomHeaderID
        '
        Me.grdProductionOrderLinesBomHeaderID.DataPropertyName = "bom_header_id"
        Me.grdProductionOrderLinesBomHeaderID.HeaderText = "Bom Header"
        Me.grdProductionOrderLinesBomHeaderID.Name = "grdProductionOrderLinesBomHeaderID"
        Me.grdProductionOrderLinesBomHeaderID.ReadOnly = True
        Me.grdProductionOrderLinesBomHeaderID.Visible = False
        '
        'grdProductionOrderLinesBomLineId
        '
        Me.grdProductionOrderLinesBomLineId.DataPropertyName = "bom_line_id"
        Me.grdProductionOrderLinesBomLineId.HeaderText = "Bom Line"
        Me.grdProductionOrderLinesBomLineId.Name = "grdProductionOrderLinesBomLineId"
        Me.grdProductionOrderLinesBomLineId.ReadOnly = True
        Me.grdProductionOrderLinesBomLineId.Visible = False
        '
        'grdProductionOrderLinesmc_no
        '
        Me.grdProductionOrderLinesmc_no.DataPropertyName = "mc_no"
        Me.grdProductionOrderLinesmc_no.HeaderText = "mc_no"
        Me.grdProductionOrderLinesmc_no.Name = "grdProductionOrderLinesmc_no"
        Me.grdProductionOrderLinesmc_no.Visible = False
        '
        'grdProductionOrderLinesMachine_Bar
        '
        Me.grdProductionOrderLinesMachine_Bar.DataPropertyName = "Machine_Bar"
        Me.grdProductionOrderLinesMachine_Bar.HeaderText = "Machine Bar"
        Me.grdProductionOrderLinesMachine_Bar.Name = "grdProductionOrderLinesMachine_Bar"
        Me.grdProductionOrderLinesMachine_Bar.Visible = False
        '
        'txtKoNo
        '
        Me.txtKoNo.Location = New System.Drawing.Point(69, 28)
        Me.txtKoNo.Name = "txtKoNo"
        Me.txtKoNo.Size = New System.Drawing.Size(104, 20)
        Me.txtKoNo.TabIndex = 252
        '
        'lblKoNo
        '
        Me.lblKoNo.AutoSize = True
        Me.lblKoNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKoNo.Location = New System.Drawing.Point(26, 31)
        Me.lblKoNo.Name = "lblKoNo"
        Me.lblKoNo.Size = New System.Drawing.Size(37, 13)
        Me.lblKoNo.TabIndex = 253
        Me.lblKoNo.Text = "KI No."
        '
        'cboWOItems
        '
        Me.cboWOItems.Enabled = False
        Me.cboWOItems.FormattingEnabled = True
        Me.cboWOItems.Location = New System.Drawing.Point(90, 46)
        Me.cboWOItems.Name = "cboWOItems"
        Me.cboWOItems.Size = New System.Drawing.Size(104, 21)
        Me.cboWOItems.TabIndex = 252
        '
        'lblWOItems
        '
        Me.lblWOItems.AutoSize = True
        Me.lblWOItems.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWOItems.Location = New System.Drawing.Point(17, 47)
        Me.lblWOItems.Name = "lblWOItems"
        Me.lblWOItems.Size = New System.Drawing.Size(65, 13)
        Me.lblWOItems.TabIndex = 253
        Me.lblWOItems.Text = "Beam Code"
        '
        'grdProductionLots
        '
        Me.grdProductionLots.AllowUserToAddRows = False
        Me.grdProductionLots.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionLots.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grdProductionLots.ColumnHeadersHeight = 50
        Me.grdProductionLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdProductionLots.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdProductionLotsSel, Me.grdProductionLotsMfgProductionOrderLines_id, Me.grdProductionLotsSupplySourceItemCode, Me.grdProductionLotsSupplySourceLotNumber, Me.grdProductionLotsCustomLotNumber, Me.grdProductionLotsWarehouseCode, Me.grdProductionLotsSubinventoryCode, Me.grdProductionLotsReserveQty, Me.grdProductionLotsReserveQtyBal, Me.grdProductionLotsReserveUomName, Me.grdProductionLotsReserveMC, Me.grdProductionLotsReserveMachineBar})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdProductionLots.DefaultCellStyle = DataGridViewCellStyle12
        Me.grdProductionLots.Location = New System.Drawing.Point(12, 271)
        Me.grdProductionLots.Name = "grdProductionLots"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionLots.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdProductionLots.RowsDefaultCellStyle = DataGridViewCellStyle14
        Me.grdProductionLots.Size = New System.Drawing.Size(646, 234)
        Me.grdProductionLots.TabIndex = 301
        '
        'grdProductionLotsSel
        '
        Me.grdProductionLotsSel.DataPropertyName = "sel"
        Me.grdProductionLotsSel.HeaderText = "Sel"
        Me.grdProductionLotsSel.Name = "grdProductionLotsSel"
        Me.grdProductionLotsSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdProductionLotsSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdProductionLotsSel.Width = 50
        '
        'grdProductionLotsMfgProductionOrderLines_id
        '
        Me.grdProductionLotsMfgProductionOrderLines_id.DataPropertyName = "mfg_production_order_lines_id"
        Me.grdProductionLotsMfgProductionOrderLines_id.HeaderText = "Production Order Line ID"
        Me.grdProductionLotsMfgProductionOrderLines_id.Name = "grdProductionLotsMfgProductionOrderLines_id"
        Me.grdProductionLotsMfgProductionOrderLines_id.ReadOnly = True
        Me.grdProductionLotsMfgProductionOrderLines_id.Visible = False
        Me.grdProductionLotsMfgProductionOrderLines_id.Width = 60
        '
        'grdProductionLotsSupplySourceItemCode
        '
        Me.grdProductionLotsSupplySourceItemCode.DataPropertyName = "supply_source_item_code"
        Me.grdProductionLotsSupplySourceItemCode.HeaderText = "Inventory Item Code"
        Me.grdProductionLotsSupplySourceItemCode.Name = "grdProductionLotsSupplySourceItemCode"
        Me.grdProductionLotsSupplySourceItemCode.ReadOnly = True
        '
        'grdProductionLotsSupplySourceLotNumber
        '
        Me.grdProductionLotsSupplySourceLotNumber.DataPropertyName = "supply_source_lot_number"
        Me.grdProductionLotsSupplySourceLotNumber.HeaderText = "System Lot Number"
        Me.grdProductionLotsSupplySourceLotNumber.Name = "grdProductionLotsSupplySourceLotNumber"
        Me.grdProductionLotsSupplySourceLotNumber.ReadOnly = True
        '
        'grdProductionLotsCustomLotNumber
        '
        Me.grdProductionLotsCustomLotNumber.DataPropertyName = "custom_lot_number"
        Me.grdProductionLotsCustomLotNumber.HeaderText = "Custom Lot Number"
        Me.grdProductionLotsCustomLotNumber.Name = "grdProductionLotsCustomLotNumber"
        Me.grdProductionLotsCustomLotNumber.ReadOnly = True
        Me.grdProductionLotsCustomLotNumber.Visible = False
        '
        'grdProductionLotsWarehouseCode
        '
        Me.grdProductionLotsWarehouseCode.DataPropertyName = "warehouse_code"
        Me.grdProductionLotsWarehouseCode.HeaderText = "W/H"
        Me.grdProductionLotsWarehouseCode.Name = "grdProductionLotsWarehouseCode"
        Me.grdProductionLotsWarehouseCode.ReadOnly = True
        Me.grdProductionLotsWarehouseCode.Width = 50
        '
        'grdProductionLotsSubinventoryCode
        '
        Me.grdProductionLotsSubinventoryCode.DataPropertyName = "subinventory_code"
        Me.grdProductionLotsSubinventoryCode.HeaderText = "Sub Inventory"
        Me.grdProductionLotsSubinventoryCode.Name = "grdProductionLotsSubinventoryCode"
        Me.grdProductionLotsSubinventoryCode.ReadOnly = True
        '
        'grdProductionLotsReserveQty
        '
        Me.grdProductionLotsReserveQty.DataPropertyName = "reserve_qty"
        Me.grdProductionLotsReserveQty.HeaderText = "Qty"
        Me.grdProductionLotsReserveQty.Name = "grdProductionLotsReserveQty"
        Me.grdProductionLotsReserveQty.ReadOnly = True
        Me.grdProductionLotsReserveQty.Visible = False
        Me.grdProductionLotsReserveQty.Width = 50
        '
        'grdProductionLotsReserveQtyBal
        '
        Me.grdProductionLotsReserveQtyBal.DataPropertyName = "reserve_qty_bal"
        Me.grdProductionLotsReserveQtyBal.HeaderText = "Qty Bal"
        Me.grdProductionLotsReserveQtyBal.Name = "grdProductionLotsReserveQtyBal"
        Me.grdProductionLotsReserveQtyBal.ReadOnly = True
        Me.grdProductionLotsReserveQtyBal.Width = 50
        '
        'grdProductionLotsReserveUomName
        '
        Me.grdProductionLotsReserveUomName.DataPropertyName = "reserve_uom_name"
        Me.grdProductionLotsReserveUomName.HeaderText = "UOM"
        Me.grdProductionLotsReserveUomName.Name = "grdProductionLotsReserveUomName"
        Me.grdProductionLotsReserveUomName.ReadOnly = True
        Me.grdProductionLotsReserveUomName.Width = 70
        '
        'grdProductionLotsReserveMC
        '
        Me.grdProductionLotsReserveMC.DataPropertyName = "mcno"
        Me.grdProductionLotsReserveMC.HeaderText = "MC"
        Me.grdProductionLotsReserveMC.Name = "grdProductionLotsReserveMC"
        Me.grdProductionLotsReserveMC.Visible = False
        '
        'grdProductionLotsReserveMachineBar
        '
        Me.grdProductionLotsReserveMachineBar.DataPropertyName = "machine_bar"
        Me.grdProductionLotsReserveMachineBar.HeaderText = "Machine Bar"
        Me.grdProductionLotsReserveMachineBar.Name = "grdProductionLotsReserveMachineBar"
        Me.grdProductionLotsReserveMachineBar.Visible = False
        '
        'grdReservations
        '
        Me.grdReservations.AllowUserToAddRows = False
        Me.grdReservations.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdReservations.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.grdReservations.ColumnHeadersHeight = 50
        Me.grdReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdReservations.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.grdReservationsSel, Me.grdReservationsDemandSourceHeaderCode, Me.grdReservationsDemandSourceLineID, Me.grdReservationsSupplySourceItemCode, Me.grdReservationsSupplySourceLotNumber, Me.grdReservationsCustomLotNumber, Me.grdReservationsWarehouseCode, Me.grdReservationsSubinventoryCode, Me.grdReservationsReserveQty, Me.MC, Me.machine_bar, Me.grdReservationsReserveUomName})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdReservations.DefaultCellStyle = DataGridViewCellStyle16
        Me.grdReservations.Location = New System.Drawing.Point(702, 271)
        Me.grdReservations.Name = "grdReservations"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdReservations.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdReservations.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.grdReservations.Size = New System.Drawing.Size(309, 234)
        Me.grdReservations.TabIndex = 302
        '
        'grdReservationsSel
        '
        Me.grdReservationsSel.DataPropertyName = "sel"
        Me.grdReservationsSel.HeaderText = "Sel"
        Me.grdReservationsSel.Name = "grdReservationsSel"
        Me.grdReservationsSel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdReservationsSel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.grdReservationsSel.Width = 50
        '
        'grdReservationsDemandSourceHeaderCode
        '
        Me.grdReservationsDemandSourceHeaderCode.DataPropertyName = "demand_source_header_code"
        Me.grdReservationsDemandSourceHeaderCode.HeaderText = "K/O No."
        Me.grdReservationsDemandSourceHeaderCode.Name = "grdReservationsDemandSourceHeaderCode"
        Me.grdReservationsDemandSourceHeaderCode.ReadOnly = True
        Me.grdReservationsDemandSourceHeaderCode.Width = 70
        '
        'grdReservationsDemandSourceLineID
        '
        Me.grdReservationsDemandSourceLineID.DataPropertyName = "demand_source_line_id"
        Me.grdReservationsDemandSourceLineID.HeaderText = "K/O Lines ID"
        Me.grdReservationsDemandSourceLineID.Name = "grdReservationsDemandSourceLineID"
        Me.grdReservationsDemandSourceLineID.ReadOnly = True
        Me.grdReservationsDemandSourceLineID.Width = 60
        '
        'grdReservationsSupplySourceItemCode
        '
        Me.grdReservationsSupplySourceItemCode.DataPropertyName = "supply_source_item_code"
        Me.grdReservationsSupplySourceItemCode.HeaderText = "Inventory Item Code"
        Me.grdReservationsSupplySourceItemCode.Name = "grdReservationsSupplySourceItemCode"
        Me.grdReservationsSupplySourceItemCode.ReadOnly = True
        '
        'grdReservationsSupplySourceLotNumber
        '
        Me.grdReservationsSupplySourceLotNumber.DataPropertyName = "supply_source_lot_number"
        Me.grdReservationsSupplySourceLotNumber.HeaderText = "System Lot Number"
        Me.grdReservationsSupplySourceLotNumber.Name = "grdReservationsSupplySourceLotNumber"
        Me.grdReservationsSupplySourceLotNumber.ReadOnly = True
        '
        'grdReservationsCustomLotNumber
        '
        Me.grdReservationsCustomLotNumber.DataPropertyName = "custom_lot_number"
        Me.grdReservationsCustomLotNumber.HeaderText = "Custom Lot Number"
        Me.grdReservationsCustomLotNumber.Name = "grdReservationsCustomLotNumber"
        Me.grdReservationsCustomLotNumber.ReadOnly = True
        Me.grdReservationsCustomLotNumber.Visible = False
        '
        'grdReservationsWarehouseCode
        '
        Me.grdReservationsWarehouseCode.DataPropertyName = "warehouse_code"
        Me.grdReservationsWarehouseCode.HeaderText = "W/H"
        Me.grdReservationsWarehouseCode.Name = "grdReservationsWarehouseCode"
        Me.grdReservationsWarehouseCode.ReadOnly = True
        Me.grdReservationsWarehouseCode.Width = 50
        '
        'grdReservationsSubinventoryCode
        '
        Me.grdReservationsSubinventoryCode.DataPropertyName = "subinventory_code"
        Me.grdReservationsSubinventoryCode.HeaderText = "Sub Inventory"
        Me.grdReservationsSubinventoryCode.Name = "grdReservationsSubinventoryCode"
        Me.grdReservationsSubinventoryCode.ReadOnly = True
        '
        'grdReservationsReserveQty
        '
        Me.grdReservationsReserveQty.DataPropertyName = "reserve_qty"
        Me.grdReservationsReserveQty.HeaderText = "QTY"
        Me.grdReservationsReserveQty.Name = "grdReservationsReserveQty"
        Me.grdReservationsReserveQty.Width = 50
        '
        'MC
        '
        Me.MC.DataPropertyName = "mcno"
        Me.MC.HeaderText = "MC"
        Me.MC.Name = "MC"
        Me.MC.Width = 80
        '
        'machine_bar
        '
        Me.machine_bar.DataPropertyName = "machine_bar"
        Me.machine_bar.HeaderText = "Machine Bar"
        Me.machine_bar.Name = "machine_bar"
        Me.machine_bar.Width = 50
        '
        'grdReservationsReserveUomName
        '
        Me.grdReservationsReserveUomName.DataPropertyName = "reserve_uom_name"
        Me.grdReservationsReserveUomName.HeaderText = "UOM"
        Me.grdReservationsReserveUomName.Name = "grdReservationsReserveUomName"
        Me.grdReservationsReserveUomName.ReadOnly = True
        Me.grdReservationsReserveUomName.Width = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSupplySourceHeaderMcno)
        Me.GroupBox1.Controls.Add(Me.lblSupplySourceHeaderMcno)
        Me.GroupBox1.Controls.Add(Me.lblitdesc2)
        Me.GroupBox1.Controls.Add(Me.txtitdesc2)
        Me.GroupBox1.Controls.Add(Me.txtWoNo)
        Me.GroupBox1.Controls.Add(Me.lblWoNo)
        Me.GroupBox1.Controls.Add(Me.cboWOItems)
        Me.GroupBox1.Controls.Add(Me.lblWOItems)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(211, 142)
        Me.GroupBox1.TabIndex = 303
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply Detail"
        '
        'txtSupplySourceHeaderMcno
        '
        Me.txtSupplySourceHeaderMcno.Location = New System.Drawing.Point(90, 106)
        Me.txtSupplySourceHeaderMcno.Name = "txtSupplySourceHeaderMcno"
        Me.txtSupplySourceHeaderMcno.Size = New System.Drawing.Size(104, 20)
        Me.txtSupplySourceHeaderMcno.TabIndex = 257
        '
        'lblSupplySourceHeaderMcno
        '
        Me.lblSupplySourceHeaderMcno.AutoSize = True
        Me.lblSupplySourceHeaderMcno.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplySourceHeaderMcno.Location = New System.Drawing.Point(17, 109)
        Me.lblSupplySourceHeaderMcno.Name = "lblSupplySourceHeaderMcno"
        Me.lblSupplySourceHeaderMcno.Size = New System.Drawing.Size(49, 13)
        Me.lblSupplySourceHeaderMcno.TabIndex = 256
        Me.lblSupplySourceHeaderMcno.Text = "M/C No."
        '
        'lblitdesc2
        '
        Me.lblitdesc2.AutoSize = True
        Me.lblitdesc2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitdesc2.Location = New System.Drawing.Point(17, 77)
        Me.lblitdesc2.Name = "lblitdesc2"
        Me.lblitdesc2.Size = New System.Drawing.Size(68, 13)
        Me.lblitdesc2.TabIndex = 255
        Me.lblitdesc2.Text = "Beam Detail"
        '
        'txtitdesc2
        '
        Me.txtitdesc2.Location = New System.Drawing.Point(90, 74)
        Me.txtitdesc2.Name = "txtitdesc2"
        Me.txtitdesc2.Size = New System.Drawing.Size(104, 20)
        Me.txtitdesc2.TabIndex = 254
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnGetRSNo)
        Me.GroupBox2.Controls.Add(Me.lblMcNo)
        Me.GroupBox2.Controls.Add(Me.txtMcNo)
        Me.GroupBox2.Controls.Add(Me.lblDesignNo)
        Me.GroupBox2.Controls.Add(Me.txtDesignNo)
        Me.GroupBox2.Controls.Add(Me.lblReservationsDate)
        Me.GroupBox2.Controls.Add(Me.lblReservationsNumber)
        Me.GroupBox2.Controls.Add(Me.btnSearchCustomers)
        Me.GroupBox2.Controls.Add(Me.dtpReservationsDate)
        Me.GroupBox2.Controls.Add(Me.txtReservationsNumber)
        Me.GroupBox2.Controls.Add(Me.grdProductionOrderLines)
        Me.GroupBox2.Controls.Add(Me.txtKoNo)
        Me.GroupBox2.Controls.Add(Me.lblKoNo)
        Me.GroupBox2.Location = New System.Drawing.Point(245, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(766, 237)
        Me.GroupBox2.TabIndex = 304
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Demand Detail"
        '
        'btnGetRSNo
        '
        Me.btnGetRSNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetRSNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetRSNo.Image = CType(resources.GetObject("btnGetRSNo.Image"), System.Drawing.Image)
        Me.btnGetRSNo.Location = New System.Drawing.Point(732, 16)
        Me.btnGetRSNo.Name = "btnGetRSNo"
        Me.btnGetRSNo.Size = New System.Drawing.Size(24, 20)
        Me.btnGetRSNo.TabIndex = 305
        Me.btnGetRSNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGetRSNo.UseVisualStyleBackColor = True
        '
        'lblMcNo
        '
        Me.lblMcNo.AutoSize = True
        Me.lblMcNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMcNo.Location = New System.Drawing.Point(388, 31)
        Me.lblMcNo.Name = "lblMcNo"
        Me.lblMcNo.Size = New System.Drawing.Size(45, 13)
        Me.lblMcNo.TabIndex = 304
        Me.lblMcNo.Text = "MC No."
        '
        'txtMcNo
        '
        Me.txtMcNo.Location = New System.Drawing.Point(457, 28)
        Me.txtMcNo.Name = "txtMcNo"
        Me.txtMcNo.Size = New System.Drawing.Size(100, 20)
        Me.txtMcNo.TabIndex = 303
        '
        'lblDesignNo
        '
        Me.lblDesignNo.AutoSize = True
        Me.lblDesignNo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesignNo.Location = New System.Drawing.Point(217, 31)
        Me.lblDesignNo.Name = "lblDesignNo"
        Me.lblDesignNo.Size = New System.Drawing.Size(64, 13)
        Me.lblDesignNo.TabIndex = 302
        Me.lblDesignNo.Text = "Design No."
        '
        'txtDesignNo
        '
        Me.txtDesignNo.Location = New System.Drawing.Point(286, 28)
        Me.txtDesignNo.Name = "txtDesignNo"
        Me.txtDesignNo.Size = New System.Drawing.Size(100, 20)
        Me.txtDesignNo.TabIndex = 301
        '
        'lblReservationsDate
        '
        Me.lblReservationsDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReservationsDate.AutoSize = True
        Me.lblReservationsDate.Location = New System.Drawing.Point(574, 43)
        Me.lblReservationsDate.Name = "lblReservationsDate"
        Me.lblReservationsDate.Size = New System.Drawing.Size(51, 13)
        Me.lblReservationsDate.TabIndex = 3
        Me.lblReservationsDate.Text = "RS Date."
        '
        'lblReservationsNumber
        '
        Me.lblReservationsNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReservationsNumber.AutoSize = True
        Me.lblReservationsNumber.Location = New System.Drawing.Point(574, 19)
        Me.lblReservationsNumber.Name = "lblReservationsNumber"
        Me.lblReservationsNumber.Size = New System.Drawing.Size(42, 13)
        Me.lblReservationsNumber.TabIndex = 2
        Me.lblReservationsNumber.Text = "RS No."
        '
        'btnSearchCustomers
        '
        Me.btnSearchCustomers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCustomers.Image = CType(resources.GetObject("btnSearchCustomers.Image"), System.Drawing.Image)
        Me.btnSearchCustomers.Location = New System.Drawing.Point(179, 28)
        Me.btnSearchCustomers.Name = "btnSearchCustomers"
        Me.btnSearchCustomers.Size = New System.Drawing.Size(24, 20)
        Me.btnSearchCustomers.TabIndex = 300
        Me.btnSearchCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchCustomers.UseVisualStyleBackColor = True
        Me.btnSearchCustomers.Visible = False
        '
        'dtpReservationsDate
        '
        Me.dtpReservationsDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpReservationsDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpReservationsDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpReservationsDate.Location = New System.Drawing.Point(626, 43)
        Me.dtpReservationsDate.Name = "dtpReservationsDate"
        Me.dtpReservationsDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpReservationsDate.TabIndex = 1
        '
        'txtReservationsNumber
        '
        Me.txtReservationsNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReservationsNumber.Location = New System.Drawing.Point(626, 16)
        Me.txtReservationsNumber.Name = "txtReservationsNumber"
        Me.txtReservationsNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtReservationsNumber.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
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
        'DataGridViewCalendarColumn2
        '
        Me.DataGridViewCalendarColumn2.DataPropertyName = "last_modified_date"
        Me.DataGridViewCalendarColumn2.HeaderText = "Last Modified Date"
        Me.DataGridViewCalendarColumn2.Name = "DataGridViewCalendarColumn2"
        Me.DataGridViewCalendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCalendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCalendarColumn2.Visible = False
        '
        'btnMoveRight
        '
        Me.btnMoveRight.Location = New System.Drawing.Point(664, 295)
        Me.btnMoveRight.Name = "btnMoveRight"
        Me.btnMoveRight.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveRight.TabIndex = 309
        Me.btnMoveRight.Text = "...>"
        Me.btnMoveRight.UseVisualStyleBackColor = True
        '
        'btnMoveLeft
        '
        Me.btnMoveLeft.Location = New System.Drawing.Point(664, 271)
        Me.btnMoveLeft.Name = "btnMoveLeft"
        Me.btnMoveLeft.Size = New System.Drawing.Size(32, 24)
        Me.btnMoveLeft.TabIndex = 308
        Me.btnMoveLeft.Text = "<..."
        Me.btnMoveLeft.UseVisualStyleBackColor = True
        '
        'btnDelAll
        '
        Me.btnDelAll.Location = New System.Drawing.Point(664, 423)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.Size = New System.Drawing.Size(32, 32)
        Me.btnDelAll.TabIndex = 307
        Me.btnDelAll.Text = "<<"
        Me.btnDelAll.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(664, 391)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(32, 32)
        Me.btnDel.TabIndex = 306
        Me.btnDel.Text = "<"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(664, 359)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(32, 32)
        Me.btnAdd.TabIndex = 305
        Me.btnAdd.Text = ">"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblStockKgs
        '
        Me.lblStockKgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStockKgs.AutoSize = True
        Me.lblStockKgs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockKgs.Location = New System.Drawing.Point(298, 515)
        Me.lblStockKgs.Name = "lblStockKgs"
        Me.lblStockKgs.Size = New System.Drawing.Size(28, 17)
        Me.lblStockKgs.TabIndex = 314
        Me.lblStockKgs.Text = "Qty"
        '
        'txtTotalQtyBalStk
        '
        Me.txtTotalQtyBalStk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalQtyBalStk.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQtyBalStk.Location = New System.Drawing.Point(219, 511)
        Me.txtTotalQtyBalStk.Name = "txtTotalQtyBalStk"
        Me.txtTotalQtyBalStk.ReadOnly = True
        Me.txtTotalQtyBalStk.Size = New System.Drawing.Size(73, 25)
        Me.txtTotalQtyBalStk.TabIndex = 313
        Me.txtTotalQtyBalStk.Tag = "0.00"
        Me.txtTotalQtyBalStk.Text = "0.00"
        Me.txtTotalQtyBalStk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStockRoll
        '
        Me.lblStockRoll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStockRoll.AutoSize = True
        Me.lblStockRoll.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockRoll.Location = New System.Drawing.Point(187, 515)
        Me.lblStockRoll.Name = "lblStockRoll"
        Me.lblStockRoll.Size = New System.Drawing.Size(32, 17)
        Me.lblStockRoll.TabIndex = 312
        Me.lblStockRoll.Text = "Lots"
        '
        'txtTotalLotsStk
        '
        Me.txtTotalLotsStk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalLotsStk.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLotsStk.Location = New System.Drawing.Point(108, 511)
        Me.txtTotalLotsStk.Name = "txtTotalLotsStk"
        Me.txtTotalLotsStk.ReadOnly = True
        Me.txtTotalLotsStk.Size = New System.Drawing.Size(73, 25)
        Me.txtTotalLotsStk.TabIndex = 311
        Me.txtTotalLotsStk.Tag = "0.00"
        Me.txtTotalLotsStk.Text = "0.00"
        Me.txtTotalLotsStk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(979, 515)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 17)
        Me.Label15.TabIndex = 324
        Me.Label15.Text = "Qty"
        '
        'txtTotalQtyRS
        '
        Me.txtTotalQtyRS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalQtyRS.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalQtyRS.Location = New System.Drawing.Point(895, 511)
        Me.txtTotalQtyRS.Name = "txtTotalQtyRS"
        Me.txtTotalQtyRS.ReadOnly = True
        Me.txtTotalQtyRS.Size = New System.Drawing.Size(78, 25)
        Me.txtTotalQtyRS.TabIndex = 323
        Me.txtTotalQtyRS.Tag = "0.00"
        Me.txtTotalQtyRS.Text = "0.00"
        Me.txtTotalQtyRS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(868, 515)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 17)
        Me.Label17.TabIndex = 322
        Me.Label17.Text = "Lots"
        '
        'txtTotalLotsRs
        '
        Me.txtTotalLotsRs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalLotsRs.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLotsRs.Location = New System.Drawing.Point(784, 511)
        Me.txtTotalLotsRs.Name = "txtTotalLotsRs"
        Me.txtTotalLotsRs.ReadOnly = True
        Me.txtTotalLotsRs.Size = New System.Drawing.Size(78, 25)
        Me.txtTotalLotsRs.TabIndex = 321
        Me.txtTotalLotsRs.Tag = "0.00"
        Me.txtTotalLotsRs.Text = "0.00"
        Me.txtTotalLotsRs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStockTotal
        '
        Me.lblStockTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStockTotal.AutoSize = True
        Me.lblStockTotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockTotal.Location = New System.Drawing.Point(12, 514)
        Me.lblStockTotal.Name = "lblStockTotal"
        Me.lblStockTotal.Size = New System.Drawing.Size(90, 17)
        Me.lblStockTotal.TabIndex = 325
        Me.lblStockTotal.Text = "Total Selected"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(741, 514)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 326
        Me.Label4.Text = "Total"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(92, 241)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 24)
        Me.btnClear.TabIndex = 328
        Me.btnClear.Text = "Clear all"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelectAll.Location = New System.Drawing.Point(12, 241)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(73, 24)
        Me.btnSelectAll.TabIndex = 327
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'frmWOReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 541)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblStockTotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotalQtyRS)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTotalLotsRs)
        Me.Controls.Add(Me.lblStockKgs)
        Me.Controls.Add(Me.txtTotalQtyBalStk)
        Me.Controls.Add(Me.lblStockRoll)
        Me.Controls.Add(Me.txtTotalLotsStk)
        Me.Controls.Add(Me.btnMoveRight)
        Me.Controls.Add(Me.btnMoveLeft)
        Me.Controls.Add(Me.btnDelAll)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grdProductionLots)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdReservations)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmWOReservations"
        Me.Text = "WO Reservations"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdProductionOrderLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdProductionLots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdReservations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtWoNo As TextBox
    Friend WithEvents lblWoNo As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents btnPrint As ToolStripButton
    Friend WithEvents btnMinimized As ToolStripButton
    Friend WithEvents btnExit As ToolStripButton
    Friend WithEvents grdProductionOrderLines As DataGridView
    Friend WithEvents txtKoNo As TextBox
    Friend WithEvents lblKoNo As Label
    Friend WithEvents cboWOItems As ComboBox
    Friend WithEvents lblWOItems As Label
    Friend WithEvents grdProductionLots As DataGridView
    Friend WithEvents grdReservations As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearchCustomers As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DataGridViewCalendarColumn1 As DataGridViewCalendarColumn
    Friend WithEvents DataGridViewCalendarColumn2 As DataGridViewCalendarColumn
    Friend WithEvents btnMoveRight As Button
    Friend WithEvents btnMoveLeft As Button
    Friend WithEvents btnDelAll As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTotalQtyRS As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTotalLotsRs As TextBox
    Friend WithEvents lblStockKgs As Label
    Friend WithEvents txtTotalQtyBalStk As TextBox
    Friend WithEvents lblStockRoll As Label
    Friend WithEvents txtTotalLotsStk As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStockTotal As Label
    Friend WithEvents lblReservationsDate As Label
    Friend WithEvents lblReservationsNumber As Label
    Friend WithEvents dtpReservationsDate As DateTimePicker
    Friend WithEvents txtReservationsNumber As TextBox
    Friend WithEvents btnNew As ToolStripButton
    Friend WithEvents lblDesignNo As Label
    Friend WithEvents txtDesignNo As TextBox
    Friend WithEvents lblitdesc2 As Label
    Friend WithEvents txtitdesc2 As TextBox
    Friend WithEvents lblMcNo As Label
    Friend WithEvents txtMcNo As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSelectAll As Button
    Friend WithEvents txtSupplySourceHeaderMcno As TextBox
    Friend WithEvents lblSupplySourceHeaderMcno As Label
    Friend WithEvents grdReservationsSel As DataGridViewCheckBoxColumn
    Friend WithEvents grdReservationsDemandSourceHeaderCode As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsDemandSourceLineID As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsSupplySourceItemCode As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsSupplySourceLotNumber As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsCustomLotNumber As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsWarehouseCode As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsSubinventoryCode As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsReserveQty As DataGridViewTextBoxColumn
    Friend WithEvents MC As DataGridViewTextBoxColumn
    Friend WithEvents machine_bar As DataGridViewTextBoxColumn
    Friend WithEvents grdReservationsReserveUomName As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsSel As DataGridViewCheckBoxColumn
    Friend WithEvents grdProductionLotsMfgProductionOrderLines_id As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsSupplySourceItemCode As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsSupplySourceLotNumber As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsCustomLotNumber As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsWarehouseCode As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsSubinventoryCode As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsReserveQty As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsReserveQtyBal As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsReserveUomName As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsReserveMC As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionLotsReserveMachineBar As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesDemandSourceLineID As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesSupplySourceItemCode As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesMtlWarehouseID As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesSourceSubinventoryID As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesLineType As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesBomPerc As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesPlanQty As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesActualQty As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesUomID As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesCreationDate As DataGridViewCalendarColumn
    Friend WithEvents grdProductionOrderLinesCreatedBy As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesLastModifiedDate As DataGridViewCalendarColumn
    Friend WithEvents grdProductionOrderLinesLastModifiedBy As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesBomHeaderID As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesBomLineId As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesmc_no As DataGridViewTextBoxColumn
    Friend WithEvents grdProductionOrderLinesMachine_Bar As DataGridViewTextBoxColumn
    Friend WithEvents btnGetRSNo As Button
End Class
