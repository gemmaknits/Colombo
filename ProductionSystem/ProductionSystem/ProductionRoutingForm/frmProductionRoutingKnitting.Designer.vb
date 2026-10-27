<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionRoutingKnitting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionRoutingKnitting))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnPrintList = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.btnPrintSticker = New System.Windows.Forms.Button()
        Me.lblSumSecondary_Quantity = New System.Windows.Forms.Label()
        Me.grdDataLots = New System.Windows.Forms.DataGridView()
        Me.operation_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.system_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfg_production_lots_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custom_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operator_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inventory_item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_bdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grade_adt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot_delivered_to_inventory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.production_order_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primary_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secondary_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.counter_per_roll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rpm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creation_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.qc_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tran_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tran_dt = New ProductionSystem.DataGridViewCalendarColumn()
        Me.txtSumSecondary_Quantity = New System.Windows.Forms.TextBox()
        Me.lblSumPrimary_quantity = New System.Windows.Forms.Label()
        Me.txtSumprimary_Quantity = New System.Windows.Forms.TextBox()
        Me.btnnewroll = New System.Windows.Forms.Button()
        Me.BtnDownStep = New System.Windows.Forms.Button()
        Me.btnScanRolls = New System.Windows.Forms.Button()
        Me.GbTotal = New System.Windows.Forms.GroupBox()
        Me.txtSumRolls = New System.Windows.Forms.TextBox()
        Me.lblSumRolls = New System.Windows.Forms.Label()
        Me.BtnUPStep = New System.Windows.Forms.Button()
        Me.btnViewRolls = New System.Windows.Forms.Button()
        Me.BtnDeleteStep = New System.Windows.Forms.Button()
        Me.DataGridViewCalendarColumn1 = New ProductionSystem.DataGridViewCalendarColumn()
        Me.BtnGenLots = New System.Windows.Forms.Button()
        Me.btnSearchRouting_Code = New System.Windows.Forms.Button()
        Me.btnDirectPrint = New System.Windows.Forms.Button()
        Me.btnCopyRoll = New System.Windows.Forms.Button()
        Me.btnDelRoll = New System.Windows.Forms.Button()
        Me.lblProdNo = New System.Windows.Forms.Label()
        Me.TPlots = New System.Windows.Forms.TabPage()
        Me.BtnPrintListMultipleColumns = New System.Windows.Forms.Button()
        Me.btnPrintStickerMultipleColumns = New System.Windows.Forms.Button()
        Me.lblProItem = New System.Windows.Forms.Label()
        Me.grdDataRouting = New System.Windows.Forms.DataGridView()
        Me.lblRoutingNo = New System.Windows.Forms.Label()
        Me.lblProdQty = New System.Windows.Forms.Label()
        Me.txtBOM = New System.Windows.Forms.TextBox()
        Me.txtrouting_code = New System.Windows.Forms.TextBox()
        Me.lblBom = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TProunting = New System.Windows.Forms.TabPage()
        Me.btnCopyStep = New System.Windows.Forms.Button()
        Me.btnNewStep = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblKOClosedFinal = New System.Windows.Forms.Label()
        Me.lblKOClosed = New System.Windows.Forms.Label()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtProdNo = New System.Windows.Forms.TextBox()
        Me.txtDesign_no = New System.Windows.Forms.TextBox()
        Me.mfg_production_steps_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.routing_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.step_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operation_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.step_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan_start_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.plan_end_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.plan_step_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_start_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.actual_end_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.actual_step_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbomcno = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cbooperator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.work_shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbostep_status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.step_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdDataLots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbTotal.SuspendLayout()
        Me.TPlots.SuspendLayout()
        CType(Me.grdDataRouting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TProunting.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnPrintList
        '
        Me.BtnPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintList.Location = New System.Drawing.Point(104, 399)
        Me.BtnPrintList.Name = "BtnPrintList"
        Me.BtnPrintList.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrintList.TabIndex = 47
        Me.BtnPrintList.Text = "Print List"
        Me.BtnPrintList.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnSearch, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1074, 25)
        Me.ToolStrip1.TabIndex = 455
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 22)
        Me.btnSearch.Text = "Search"
        Me.btnSearch.Visible = False
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
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'btnPrintSticker
        '
        Me.btnPrintSticker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrintSticker.Location = New System.Drawing.Point(22, 399)
        Me.btnPrintSticker.Name = "btnPrintSticker"
        Me.btnPrintSticker.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintSticker.TabIndex = 46
        Me.btnPrintSticker.Text = "Print Sticker"
        Me.btnPrintSticker.UseVisualStyleBackColor = True
        '
        'lblSumSecondary_Quantity
        '
        Me.lblSumSecondary_Quantity.AutoSize = True
        Me.lblSumSecondary_Quantity.Location = New System.Drawing.Point(409, 16)
        Me.lblSumSecondary_Quantity.Name = "lblSumSecondary_Quantity"
        Me.lblSumSecondary_Quantity.Size = New System.Drawing.Size(27, 13)
        Me.lblSumSecondary_Quantity.TabIndex = 5
        Me.lblSumSecondary_Quantity.Text = "Mts"
        '
        'grdDataLots
        '
        Me.grdDataLots.AllowUserToAddRows = False
        Me.grdDataLots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataLots.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.operation_name, Me.system_lot_number, Me.mfg_production_lots_id, Me.custom_lot_number, Me.operator_lot_number, Me.inventory_item_code, Me.grade_bdt, Me.grade_adt, Me.lot_grade, Me.lot_delivered_to_inventory, Me.production_order_no, Me.primary_quantity, Me.secondary_quantity, Me.counter_per_roll, Me.rpm, Me.created_by, Me.creation_date, Me.qc_remarks, Me.tran_no, Me.tran_dt})
        Me.grdDataLots.Location = New System.Drawing.Point(16, 30)
        Me.grdDataLots.Name = "grdDataLots"
        Me.grdDataLots.Size = New System.Drawing.Size(1014, 360)
        Me.grdDataLots.TabIndex = 45
        '
        'operation_name
        '
        Me.operation_name.DataPropertyName = "operation_name"
        Me.operation_name.HeaderText = "Operation Step"
        Me.operation_name.Name = "operation_name"
        '
        'system_lot_number
        '
        Me.system_lot_number.DataPropertyName = "system_lot_number"
        Me.system_lot_number.HeaderText = "COMP. ROLL NO."
        Me.system_lot_number.Name = "system_lot_number"
        Me.system_lot_number.ReadOnly = True
        Me.system_lot_number.Width = 80
        '
        'mfg_production_lots_id
        '
        Me.mfg_production_lots_id.DataPropertyName = "mfg_production_lots_id"
        Me.mfg_production_lots_id.HeaderText = "mfg_production_lots_id"
        Me.mfg_production_lots_id.Name = "mfg_production_lots_id"
        Me.mfg_production_lots_id.Visible = False
        '
        'custom_lot_number
        '
        Me.custom_lot_number.DataPropertyName = "custom_lot_number"
        Me.custom_lot_number.HeaderText = "FACT. ROLL NO"
        Me.custom_lot_number.Name = "custom_lot_number"
        '
        'operator_lot_number
        '
        Me.operator_lot_number.DataPropertyName = "operator_lot_number"
        Me.operator_lot_number.HeaderText = "OPER ROLL NO."
        Me.operator_lot_number.Name = "operator_lot_number"
        Me.operator_lot_number.Width = 50
        '
        'inventory_item_code
        '
        Me.inventory_item_code.DataPropertyName = "inventory_item_code"
        Me.inventory_item_code.HeaderText = "inventory_item_code"
        Me.inventory_item_code.Name = "inventory_item_code"
        Me.inventory_item_code.ReadOnly = True
        Me.inventory_item_code.Visible = False
        '
        'grade_bdt
        '
        Me.grade_bdt.DataPropertyName = "grade_bdt"
        Me.grade_bdt.HeaderText = "Grade Of Inspection"
        Me.grade_bdt.Name = "grade_bdt"
        Me.grade_bdt.Width = 80
        '
        'grade_adt
        '
        Me.grade_adt.DataPropertyName = "grade_adt"
        Me.grade_adt.HeaderText = "Grade After Dyedtest"
        Me.grade_adt.Name = "grade_adt"
        Me.grade_adt.Width = 80
        '
        'lot_grade
        '
        Me.lot_grade.DataPropertyName = "lot_grade"
        Me.lot_grade.HeaderText = "Grade"
        Me.lot_grade.Name = "lot_grade"
        Me.lot_grade.Width = 60
        '
        'lot_delivered_to_inventory
        '
        Me.lot_delivered_to_inventory.DataPropertyName = "lot_delivered_to_inventory"
        Me.lot_delivered_to_inventory.HeaderText = "lot_delivered_to_inventory"
        Me.lot_delivered_to_inventory.Name = "lot_delivered_to_inventory"
        Me.lot_delivered_to_inventory.Visible = False
        '
        'production_order_no
        '
        Me.production_order_no.DataPropertyName = "production_order_no"
        Me.production_order_no.HeaderText = "production_order_no"
        Me.production_order_no.Name = "production_order_no"
        Me.production_order_no.Visible = False
        '
        'primary_quantity
        '
        Me.primary_quantity.DataPropertyName = "primary_quantity"
        Me.primary_quantity.HeaderText = "QTY (KGS)"
        Me.primary_quantity.Name = "primary_quantity"
        '
        'secondary_quantity
        '
        Me.secondary_quantity.DataPropertyName = "secondary_quantity"
        Me.secondary_quantity.HeaderText = "QTY (MTS)"
        Me.secondary_quantity.Name = "secondary_quantity"
        Me.secondary_quantity.ReadOnly = True
        '
        'counter_per_roll
        '
        Me.counter_per_roll.DataPropertyName = "counter_per_roll"
        Me.counter_per_roll.HeaderText = "Counter / Roll"
        Me.counter_per_roll.Name = "counter_per_roll"
        Me.counter_per_roll.Width = 80
        '
        'rpm
        '
        Me.rpm.DataPropertyName = "rpm"
        Me.rpm.HeaderText = "RPM"
        Me.rpm.Name = "rpm"
        Me.rpm.Width = 80
        '
        'created_by
        '
        Me.created_by.DataPropertyName = "created_by"
        Me.created_by.HeaderText = "created_by"
        Me.created_by.Name = "created_by"
        Me.created_by.Visible = False
        '
        'creation_date
        '
        Me.creation_date.DataPropertyName = "creation_date"
        Me.creation_date.HeaderText = "creation_date"
        Me.creation_date.Name = "creation_date"
        Me.creation_date.Visible = False
        '
        'qc_remarks
        '
        Me.qc_remarks.DataPropertyName = "qc_remarks"
        Me.qc_remarks.HeaderText = "Q/C REMARKS"
        Me.qc_remarks.Name = "qc_remarks"
        Me.qc_remarks.Width = 300
        '
        'tran_no
        '
        Me.tran_no.DataPropertyName = "tran_no"
        Me.tran_no.HeaderText = "G IN No."
        Me.tran_no.Name = "tran_no"
        '
        'tran_dt
        '
        Me.tran_dt.DataPropertyName = "tran_dt"
        Me.tran_dt.HeaderText = "G IN Dt."
        Me.tran_dt.Name = "tran_dt"
        '
        'txtSumSecondary_Quantity
        '
        Me.txtSumSecondary_Quantity.Location = New System.Drawing.Point(303, 12)
        Me.txtSumSecondary_Quantity.Name = "txtSumSecondary_Quantity"
        Me.txtSumSecondary_Quantity.Size = New System.Drawing.Size(100, 20)
        Me.txtSumSecondary_Quantity.TabIndex = 4
        '
        'lblSumPrimary_quantity
        '
        Me.lblSumPrimary_quantity.AutoSize = True
        Me.lblSumPrimary_quantity.Location = New System.Drawing.Point(269, 16)
        Me.lblSumPrimary_quantity.Name = "lblSumPrimary_quantity"
        Me.lblSumPrimary_quantity.Size = New System.Drawing.Size(28, 13)
        Me.lblSumPrimary_quantity.TabIndex = 3
        Me.lblSumPrimary_quantity.Text = "Kgs"
        '
        'txtSumprimary_Quantity
        '
        Me.txtSumprimary_Quantity.Location = New System.Drawing.Point(163, 12)
        Me.txtSumprimary_Quantity.Name = "txtSumprimary_Quantity"
        Me.txtSumprimary_Quantity.Size = New System.Drawing.Size(100, 20)
        Me.txtSumprimary_Quantity.TabIndex = 2
        '
        'btnnewroll
        '
        Me.btnnewroll.Location = New System.Drawing.Point(14, 6)
        Me.btnnewroll.Name = "btnnewroll"
        Me.btnnewroll.Size = New System.Drawing.Size(75, 23)
        Me.btnnewroll.TabIndex = 455
        Me.btnnewroll.Text = "New Roll"
        Me.btnnewroll.UseVisualStyleBackColor = True
        '
        'BtnDownStep
        '
        Me.BtnDownStep.Location = New System.Drawing.Point(339, 6)
        Me.BtnDownStep.Name = "BtnDownStep"
        Me.BtnDownStep.Size = New System.Drawing.Size(75, 23)
        Me.BtnDownStep.TabIndex = 455
        Me.BtnDownStep.Text = "DownStep"
        Me.BtnDownStep.UseVisualStyleBackColor = True
        Me.BtnDownStep.Visible = False
        '
        'btnScanRolls
        '
        Me.btnScanRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnScanRolls.Location = New System.Drawing.Point(95, 407)
        Me.btnScanRolls.Name = "btnScanRolls"
        Me.btnScanRolls.Size = New System.Drawing.Size(75, 23)
        Me.btnScanRolls.TabIndex = 458
        Me.btnScanRolls.Text = "Scan Rolls"
        Me.btnScanRolls.UseVisualStyleBackColor = True
        '
        'GbTotal
        '
        Me.GbTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbTotal.Controls.Add(Me.lblSumSecondary_Quantity)
        Me.GbTotal.Controls.Add(Me.txtSumSecondary_Quantity)
        Me.GbTotal.Controls.Add(Me.lblSumPrimary_quantity)
        Me.GbTotal.Controls.Add(Me.txtSumprimary_Quantity)
        Me.GbTotal.Controls.Add(Me.txtSumRolls)
        Me.GbTotal.Controls.Add(Me.lblSumRolls)
        Me.GbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GbTotal.Location = New System.Drawing.Point(569, 390)
        Me.GbTotal.Name = "GbTotal"
        Me.GbTotal.Size = New System.Drawing.Size(452, 40)
        Me.GbTotal.TabIndex = 48
        Me.GbTotal.TabStop = False
        Me.GbTotal.Text = "Total"
        '
        'txtSumRolls
        '
        Me.txtSumRolls.Location = New System.Drawing.Point(16, 13)
        Me.txtSumRolls.Name = "txtSumRolls"
        Me.txtSumRolls.Size = New System.Drawing.Size(100, 20)
        Me.txtSumRolls.TabIndex = 1
        '
        'lblSumRolls
        '
        Me.lblSumRolls.AutoSize = True
        Me.lblSumRolls.Location = New System.Drawing.Point(122, 16)
        Me.lblSumRolls.Name = "lblSumRolls"
        Me.lblSumRolls.Size = New System.Drawing.Size(35, 13)
        Me.lblSumRolls.TabIndex = 0
        Me.lblSumRolls.Text = "Rolls"
        '
        'BtnUPStep
        '
        Me.BtnUPStep.Location = New System.Drawing.Point(258, 6)
        Me.BtnUPStep.Name = "BtnUPStep"
        Me.BtnUPStep.Size = New System.Drawing.Size(75, 23)
        Me.BtnUPStep.TabIndex = 454
        Me.BtnUPStep.Text = "Up Step"
        Me.BtnUPStep.UseVisualStyleBackColor = True
        Me.BtnUPStep.Visible = False
        '
        'btnViewRolls
        '
        Me.btnViewRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewRolls.Location = New System.Drawing.Point(13, 407)
        Me.btnViewRolls.Name = "btnViewRolls"
        Me.btnViewRolls.Size = New System.Drawing.Size(75, 23)
        Me.btnViewRolls.TabIndex = 457
        Me.btnViewRolls.Text = "View Rolls"
        Me.btnViewRolls.UseVisualStyleBackColor = True
        '
        'BtnDeleteStep
        '
        Me.BtnDeleteStep.Location = New System.Drawing.Point(177, 6)
        Me.BtnDeleteStep.Name = "BtnDeleteStep"
        Me.BtnDeleteStep.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteStep.TabIndex = 456
        Me.BtnDeleteStep.Text = "Delete Step"
        Me.BtnDeleteStep.UseVisualStyleBackColor = True
        '
        'DataGridViewCalendarColumn1
        '
        Me.DataGridViewCalendarColumn1.DataPropertyName = "creation_date"
        Me.DataGridViewCalendarColumn1.HeaderText = "creation_date"
        Me.DataGridViewCalendarColumn1.Name = "DataGridViewCalendarColumn1"
        Me.DataGridViewCalendarColumn1.Visible = False
        '
        'BtnGenLots
        '
        Me.BtnGenLots.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGenLots.Location = New System.Drawing.Point(196, 60)
        Me.BtnGenLots.Name = "BtnGenLots"
        Me.BtnGenLots.Size = New System.Drawing.Size(69, 23)
        Me.BtnGenLots.TabIndex = 460
        Me.BtnGenLots.Text = "Gen Lots"
        Me.BtnGenLots.UseVisualStyleBackColor = True
        Me.BtnGenLots.Visible = False
        '
        'btnSearchRouting_Code
        '
        Me.btnSearchRouting_Code.Image = CType(resources.GetObject("btnSearchRouting_Code.Image"), System.Drawing.Image)
        Me.btnSearchRouting_Code.Location = New System.Drawing.Point(160, 60)
        Me.btnSearchRouting_Code.Name = "btnSearchRouting_Code"
        Me.btnSearchRouting_Code.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchRouting_Code.TabIndex = 458
        Me.btnSearchRouting_Code.UseVisualStyleBackColor = True
        '
        'btnDirectPrint
        '
        Me.btnDirectPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDirectPrint.Location = New System.Drawing.Point(271, 60)
        Me.btnDirectPrint.Name = "btnDirectPrint"
        Me.btnDirectPrint.Size = New System.Drawing.Size(88, 23)
        Me.btnDirectPrint.TabIndex = 462
        Me.btnDirectPrint.Text = "Print Barcode"
        Me.btnDirectPrint.UseVisualStyleBackColor = True
        Me.btnDirectPrint.Visible = False
        '
        'btnCopyRoll
        '
        Me.btnCopyRoll.Location = New System.Drawing.Point(95, 6)
        Me.btnCopyRoll.Name = "btnCopyRoll"
        Me.btnCopyRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnCopyRoll.TabIndex = 457
        Me.btnCopyRoll.Text = "Copy Roll"
        Me.btnCopyRoll.UseVisualStyleBackColor = True
        '
        'btnDelRoll
        '
        Me.btnDelRoll.Location = New System.Drawing.Point(177, 6)
        Me.btnDelRoll.Name = "btnDelRoll"
        Me.btnDelRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnDelRoll.TabIndex = 458
        Me.btnDelRoll.Text = "Delete Roll"
        Me.btnDelRoll.UseVisualStyleBackColor = True
        '
        'lblProdNo
        '
        Me.lblProdNo.AutoSize = True
        Me.lblProdNo.Location = New System.Drawing.Point(16, 12)
        Me.lblProdNo.Name = "lblProdNo"
        Me.lblProdNo.Size = New System.Drawing.Size(52, 13)
        Me.lblProdNo.TabIndex = 40
        Me.lblProdNo.Text = "Prod No:"
        '
        'TPlots
        '
        Me.TPlots.Controls.Add(Me.BtnPrintListMultipleColumns)
        Me.TPlots.Controls.Add(Me.btnPrintStickerMultipleColumns)
        Me.TPlots.Controls.Add(Me.btnDelRoll)
        Me.TPlots.Controls.Add(Me.btnCopyRoll)
        Me.TPlots.Controls.Add(Me.btnnewroll)
        Me.TPlots.Controls.Add(Me.GbTotal)
        Me.TPlots.Controls.Add(Me.BtnPrintList)
        Me.TPlots.Controls.Add(Me.btnPrintSticker)
        Me.TPlots.Controls.Add(Me.grdDataLots)
        Me.TPlots.Location = New System.Drawing.Point(4, 22)
        Me.TPlots.Name = "TPlots"
        Me.TPlots.Padding = New System.Windows.Forms.Padding(3)
        Me.TPlots.Size = New System.Drawing.Size(1042, 436)
        Me.TPlots.TabIndex = 1
        Me.TPlots.Text = "Production Lot"
        Me.TPlots.UseVisualStyleBackColor = True
        '
        'BtnPrintListMultipleColumns
        '
        Me.BtnPrintListMultipleColumns.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintListMultipleColumns.Location = New System.Drawing.Point(353, 399)
        Me.BtnPrintListMultipleColumns.Name = "BtnPrintListMultipleColumns"
        Me.BtnPrintListMultipleColumns.Size = New System.Drawing.Size(157, 23)
        Me.BtnPrintListMultipleColumns.TabIndex = 460
        Me.BtnPrintListMultipleColumns.Text = "Print List Multiple Columns"
        Me.BtnPrintListMultipleColumns.UseVisualStyleBackColor = True
        '
        'btnPrintStickerMultipleColumns
        '
        Me.btnPrintStickerMultipleColumns.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrintStickerMultipleColumns.Location = New System.Drawing.Point(185, 399)
        Me.btnPrintStickerMultipleColumns.Name = "btnPrintStickerMultipleColumns"
        Me.btnPrintStickerMultipleColumns.Size = New System.Drawing.Size(162, 23)
        Me.btnPrintStickerMultipleColumns.TabIndex = 459
        Me.btnPrintStickerMultipleColumns.Text = "Print Sticker Multiple Columns"
        Me.btnPrintStickerMultipleColumns.UseVisualStyleBackColor = True
        '
        'lblProItem
        '
        Me.lblProItem.AutoSize = True
        Me.lblProItem.Location = New System.Drawing.Point(149, 12)
        Me.lblProItem.Name = "lblProItem"
        Me.lblProItem.Size = New System.Drawing.Size(59, 13)
        Me.lblProItem.TabIndex = 41
        Me.lblProItem.Text = "Prod Item:"
        '
        'grdDataRouting
        '
        Me.grdDataRouting.AllowUserToAddRows = False
        Me.grdDataRouting.AllowUserToDeleteRows = False
        Me.grdDataRouting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataRouting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataRouting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mfg_production_steps_id, Me.routing_id, Me.step_number, Me.operation_id, Me.step_name, Me.plan_start_date, Me.plan_end_date, Me.plan_step_qty, Me.actual_start_date, Me.actual_end_date, Me.actual_step_qty, Me.cbomcno, Me.cbooperator, Me.work_shift, Me.cbostep_status, Me.step_remarks})
        Me.grdDataRouting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdDataRouting.Location = New System.Drawing.Point(16, 31)
        Me.grdDataRouting.Name = "grdDataRouting"
        Me.grdDataRouting.Size = New System.Drawing.Size(1020, 370)
        Me.grdDataRouting.TabIndex = 44
        '
        'lblRoutingNo
        '
        Me.lblRoutingNo.AutoSize = True
        Me.lblRoutingNo.Location = New System.Drawing.Point(26, 41)
        Me.lblRoutingNo.Name = "lblRoutingNo"
        Me.lblRoutingNo.Size = New System.Drawing.Size(88, 13)
        Me.lblRoutingNo.TabIndex = 456
        Me.lblRoutingNo.Text = "Routing Code. :"
        '
        'lblProdQty
        '
        Me.lblProdQty.AutoSize = True
        Me.lblProdQty.Location = New System.Drawing.Point(280, 12)
        Me.lblProdQty.Name = "lblProdQty"
        Me.lblProdQty.Size = New System.Drawing.Size(82, 13)
        Me.lblProdQty.TabIndex = 42
        Me.lblProdQty.Text = "Prod Qty(Kgs)::"
        '
        'txtBOM
        '
        Me.txtBOM.Location = New System.Drawing.Point(418, 32)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.ReadOnly = True
        Me.txtBOM.Size = New System.Drawing.Size(125, 22)
        Me.txtBOM.TabIndex = 50
        Me.txtBOM.Tag = "str"
        '
        'txtrouting_code
        '
        Me.txtrouting_code.Location = New System.Drawing.Point(29, 60)
        Me.txtrouting_code.Name = "txtrouting_code"
        Me.txtrouting_code.Size = New System.Drawing.Size(125, 22)
        Me.txtrouting_code.TabIndex = 457
        '
        'lblBom
        '
        Me.lblBom.AutoSize = True
        Me.lblBom.Location = New System.Drawing.Point(415, 12)
        Me.lblBom.Name = "lblBom"
        Me.lblBom.Size = New System.Drawing.Size(36, 13)
        Me.lblBom.TabIndex = 45
        Me.lblBom.Text = "Bom :"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TProunting)
        Me.TabControl1.Controls.Add(Me.TPlots)
        Me.TabControl1.Location = New System.Drawing.Point(25, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1050, 462)
        Me.TabControl1.TabIndex = 461
        '
        'TProunting
        '
        Me.TProunting.Controls.Add(Me.BtnDownStep)
        Me.TProunting.Controls.Add(Me.btnScanRolls)
        Me.TProunting.Controls.Add(Me.BtnUPStep)
        Me.TProunting.Controls.Add(Me.btnViewRolls)
        Me.TProunting.Controls.Add(Me.BtnDeleteStep)
        Me.TProunting.Controls.Add(Me.btnCopyStep)
        Me.TProunting.Controls.Add(Me.grdDataRouting)
        Me.TProunting.Controls.Add(Me.btnNewStep)
        Me.TProunting.Location = New System.Drawing.Point(4, 22)
        Me.TProunting.Name = "TProunting"
        Me.TProunting.Padding = New System.Windows.Forms.Padding(3)
        Me.TProunting.Size = New System.Drawing.Size(1042, 436)
        Me.TProunting.TabIndex = 0
        Me.TProunting.Text = "Production Routing"
        Me.TProunting.UseVisualStyleBackColor = True
        '
        'btnCopyStep
        '
        Me.btnCopyStep.Location = New System.Drawing.Point(95, 6)
        Me.btnCopyStep.Name = "btnCopyStep"
        Me.btnCopyStep.Size = New System.Drawing.Size(75, 23)
        Me.btnCopyStep.TabIndex = 455
        Me.btnCopyStep.Text = "Copy Step"
        Me.btnCopyStep.UseVisualStyleBackColor = True
        '
        'btnNewStep
        '
        Me.btnNewStep.Location = New System.Drawing.Point(14, 6)
        Me.btnNewStep.Name = "btnNewStep"
        Me.btnNewStep.Size = New System.Drawing.Size(75, 23)
        Me.btnNewStep.TabIndex = 454
        Me.btnNewStep.Text = "New Step"
        Me.btnNewStep.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblKOClosedFinal)
        Me.GroupBox1.Controls.Add(Me.lblKOClosed)
        Me.GroupBox1.Controls.Add(Me.lblCancelled)
        Me.GroupBox1.Controls.Add(Me.lblProdNo)
        Me.GroupBox1.Controls.Add(Me.lblProItem)
        Me.GroupBox1.Controls.Add(Me.txtBOM)
        Me.GroupBox1.Controls.Add(Me.lblProdQty)
        Me.GroupBox1.Controls.Add(Me.lblBom)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.txtProdNo)
        Me.GroupBox1.Controls.Add(Me.txtDesign_no)
        Me.GroupBox1.Location = New System.Drawing.Point(514, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 62)
        Me.GroupBox1.TabIndex = 459
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prod. Information"
        '
        'lblKOClosedFinal
        '
        Me.lblKOClosedFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKOClosedFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKOClosedFinal.ForeColor = System.Drawing.Color.Red
        Me.lblKOClosedFinal.Location = New System.Drawing.Point(436, -3)
        Me.lblKOClosedFinal.Name = "lblKOClosedFinal"
        Me.lblKOClosedFinal.Size = New System.Drawing.Size(115, 24)
        Me.lblKOClosedFinal.TabIndex = 269
        Me.lblKOClosedFinal.Text = "Delivered"
        Me.lblKOClosedFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblKOClosedFinal.Visible = False
        '
        'lblKOClosed
        '
        Me.lblKOClosed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKOClosed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKOClosed.ForeColor = System.Drawing.Color.Red
        Me.lblKOClosed.Location = New System.Drawing.Point(351, -3)
        Me.lblKOClosed.Name = "lblKOClosed"
        Me.lblKOClosed.Size = New System.Drawing.Size(87, 24)
        Me.lblKOClosed.TabIndex = 268
        Me.lblKOClosed.Text = "Closed"
        Me.lblKOClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblKOClosed.Visible = False
        '
        'lblCancelled
        '
        Me.lblCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(233, -3)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(121, 24)
        Me.lblCancelled.TabIndex = 267
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCancelled.Visible = False
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(283, 32)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.ReadOnly = True
        Me.txtqty.Size = New System.Drawing.Size(125, 22)
        Me.txtqty.TabIndex = 48
        Me.txtqty.Tag = "str"
        '
        'txtProdNo
        '
        Me.txtProdNo.Location = New System.Drawing.Point(16, 32)
        Me.txtProdNo.Name = "txtProdNo"
        Me.txtProdNo.ReadOnly = True
        Me.txtProdNo.Size = New System.Drawing.Size(125, 22)
        Me.txtProdNo.TabIndex = 46
        Me.txtProdNo.Tag = "str"
        '
        'txtDesign_no
        '
        Me.txtDesign_no.Location = New System.Drawing.Point(152, 32)
        Me.txtDesign_no.Name = "txtDesign_no"
        Me.txtDesign_no.ReadOnly = True
        Me.txtDesign_no.Size = New System.Drawing.Size(125, 22)
        Me.txtDesign_no.TabIndex = 47
        Me.txtDesign_no.Tag = "str"
        '
        'mfg_production_steps_id
        '
        Me.mfg_production_steps_id.DataPropertyName = "mfg_production_steps_id"
        Me.mfg_production_steps_id.HeaderText = "mfg_production_steps_id"
        Me.mfg_production_steps_id.Name = "mfg_production_steps_id"
        Me.mfg_production_steps_id.Visible = False
        '
        'routing_id
        '
        Me.routing_id.DataPropertyName = "routing_id"
        Me.routing_id.HeaderText = "routing_id"
        Me.routing_id.Name = "routing_id"
        Me.routing_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.routing_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.routing_id.Visible = False
        '
        'step_number
        '
        Me.step_number.DataPropertyName = "step_number"
        Me.step_number.HeaderText = "STEP NO"
        Me.step_number.Name = "step_number"
        Me.step_number.Width = 75
        '
        'operation_id
        '
        Me.operation_id.DataPropertyName = "operation_id"
        Me.operation_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.operation_id.HeaderText = "STEP NAME"
        Me.operation_id.Name = "operation_id"
        Me.operation_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.operation_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'step_name
        '
        Me.step_name.DataPropertyName = "step_name"
        Me.step_name.HeaderText = "STEP NAME"
        Me.step_name.Name = "step_name"
        Me.step_name.ReadOnly = True
        Me.step_name.Visible = False
        Me.step_name.Width = 75
        '
        'plan_start_date
        '
        Me.plan_start_date.DataPropertyName = "plan_start_date"
        Me.plan_start_date.HeaderText = "PLAN START"
        Me.plan_start_date.Name = "plan_start_date"
        Me.plan_start_date.Width = 75
        '
        'plan_end_date
        '
        Me.plan_end_date.DataPropertyName = "plan_end_date"
        Me.plan_end_date.HeaderText = "PLAN END"
        Me.plan_end_date.Name = "plan_end_date"
        Me.plan_end_date.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.plan_end_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.plan_end_date.Width = 76
        '
        'plan_step_qty
        '
        Me.plan_step_qty.DataPropertyName = "plan_step_qty"
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.plan_step_qty.DefaultCellStyle = DataGridViewCellStyle1
        Me.plan_step_qty.HeaderText = "PLAN STEP QTY"
        Me.plan_step_qty.Name = "plan_step_qty"
        Me.plan_step_qty.Width = 75
        '
        'actual_start_date
        '
        Me.actual_start_date.DataPropertyName = "actual_start_date"
        Me.actual_start_date.HeaderText = "ACTUAL START"
        Me.actual_start_date.Name = "actual_start_date"
        Me.actual_start_date.Width = 75
        '
        'actual_end_date
        '
        Me.actual_end_date.DataPropertyName = "actual_end_date"
        Me.actual_end_date.HeaderText = "ACTUAL END"
        Me.actual_end_date.Name = "actual_end_date"
        Me.actual_end_date.Width = 75
        '
        'actual_step_qty
        '
        Me.actual_step_qty.DataPropertyName = "actual_step_qty"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.actual_step_qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.actual_step_qty.HeaderText = "ACTUAL STEP QTY"
        Me.actual_step_qty.Name = "actual_step_qty"
        Me.actual_step_qty.Width = 75
        '
        'cbomcno
        '
        Me.cbomcno.DataPropertyName = "mcno"
        Me.cbomcno.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbomcno.HeaderText = "M/C No."
        Me.cbomcno.Name = "cbomcno"
        Me.cbomcno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbomcno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cbomcno.Width = 75
        '
        'cbooperator
        '
        Me.cbooperator.DataPropertyName = "operator"
        Me.cbooperator.HeaderText = "OPERATOR"
        Me.cbooperator.Name = "cbooperator"
        Me.cbooperator.Width = 76
        '
        'work_shift
        '
        Me.work_shift.DataPropertyName = "work_shift"
        Me.work_shift.HeaderText = "SHIFT"
        Me.work_shift.Name = "work_shift"
        Me.work_shift.Width = 50
        '
        'cbostep_status
        '
        Me.cbostep_status.DataPropertyName = "step_status"
        Me.cbostep_status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.cbostep_status.HeaderText = "STATUS"
        Me.cbostep_status.Name = "cbostep_status"
        Me.cbostep_status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cbostep_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'step_remarks
        '
        Me.step_remarks.DataPropertyName = "step_remarks"
        Me.step_remarks.HeaderText = "COMMENT"
        Me.step_remarks.Name = "step_remarks"
        Me.step_remarks.Width = 75
        '
        'frmProductionRoutingKnitting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 570)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnGenLots)
        Me.Controls.Add(Me.btnSearchRouting_Code)
        Me.Controls.Add(Me.btnDirectPrint)
        Me.Controls.Add(Me.lblRoutingNo)
        Me.Controls.Add(Me.txtrouting_code)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProductionRoutingKnitting"
        Me.Text = "Production Routing Knitting"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdDataLots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbTotal.ResumeLayout(False)
        Me.GbTotal.PerformLayout()
        Me.TPlots.ResumeLayout(False)
        CType(Me.grdDataRouting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TProunting.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnPrintList As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrintSticker As System.Windows.Forms.Button
    Friend WithEvents lblSumSecondary_Quantity As System.Windows.Forms.Label
    Friend WithEvents grdDataLots As System.Windows.Forms.DataGridView
    Friend WithEvents txtSumSecondary_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents lblSumPrimary_quantity As System.Windows.Forms.Label
    Friend WithEvents txtSumprimary_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents btnnewroll As System.Windows.Forms.Button
    Friend WithEvents BtnDownStep As System.Windows.Forms.Button
    Friend WithEvents btnScanRolls As System.Windows.Forms.Button
    Friend WithEvents GbTotal As System.Windows.Forms.GroupBox
    Friend WithEvents txtSumRolls As System.Windows.Forms.TextBox
    Friend WithEvents lblSumRolls As System.Windows.Forms.Label
    Friend WithEvents BtnUPStep As System.Windows.Forms.Button
    Friend WithEvents btnViewRolls As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteStep As System.Windows.Forms.Button
    Friend WithEvents DataGridViewCalendarColumn1 As ProductionSystem.DataGridViewCalendarColumn
    Friend WithEvents BtnGenLots As System.Windows.Forms.Button
    Friend WithEvents btnSearchRouting_Code As System.Windows.Forms.Button
    Friend WithEvents btnDirectPrint As System.Windows.Forms.Button
    Friend WithEvents btnCopyRoll As System.Windows.Forms.Button
    Friend WithEvents btnDelRoll As System.Windows.Forms.Button
    Friend WithEvents lblProdNo As System.Windows.Forms.Label
    Friend WithEvents TPlots As System.Windows.Forms.TabPage
    Friend WithEvents lblProItem As System.Windows.Forms.Label
    Friend WithEvents grdDataRouting As System.Windows.Forms.DataGridView
    Friend WithEvents lblRoutingNo As System.Windows.Forms.Label
    Friend WithEvents lblProdQty As System.Windows.Forms.Label
    Friend WithEvents txtBOM As System.Windows.Forms.TextBox
    Friend WithEvents txtrouting_code As System.Windows.Forms.TextBox
    Friend WithEvents lblBom As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TProunting As System.Windows.Forms.TabPage
    Friend WithEvents btnCopyStep As System.Windows.Forms.Button
    Friend WithEvents btnNewStep As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtProdNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDesign_no As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrintListMultipleColumns As System.Windows.Forms.Button
    Friend WithEvents btnPrintStickerMultipleColumns As System.Windows.Forms.Button
    Friend WithEvents operation_name As DataGridViewTextBoxColumn
    Friend WithEvents system_lot_number As DataGridViewTextBoxColumn
    Friend WithEvents mfg_production_lots_id As DataGridViewTextBoxColumn
    Friend WithEvents custom_lot_number As DataGridViewTextBoxColumn
    Friend WithEvents operator_lot_number As DataGridViewTextBoxColumn
    Friend WithEvents inventory_item_code As DataGridViewTextBoxColumn
    Friend WithEvents grade_bdt As DataGridViewTextBoxColumn
    Friend WithEvents grade_adt As DataGridViewTextBoxColumn
    Friend WithEvents lot_grade As DataGridViewTextBoxColumn
    Friend WithEvents lot_delivered_to_inventory As DataGridViewTextBoxColumn
    Friend WithEvents production_order_no As DataGridViewTextBoxColumn
    Friend WithEvents primary_quantity As DataGridViewTextBoxColumn
    Friend WithEvents secondary_quantity As DataGridViewTextBoxColumn
    Friend WithEvents counter_per_roll As DataGridViewTextBoxColumn
    Friend WithEvents rpm As DataGridViewTextBoxColumn
    Friend WithEvents created_by As DataGridViewTextBoxColumn
    Friend WithEvents creation_date As DataGridViewCalendarColumn
    Friend WithEvents qc_remarks As DataGridViewTextBoxColumn
    Friend WithEvents tran_no As DataGridViewTextBoxColumn
    Friend WithEvents tran_dt As DataGridViewCalendarColumn
    Friend WithEvents lblKOClosedFinal As Label
    Friend WithEvents lblKOClosed As Label
    Friend WithEvents lblCancelled As Label
    Friend WithEvents mfg_production_steps_id As DataGridViewTextBoxColumn
    Friend WithEvents routing_id As DataGridViewComboBoxColumn
    Friend WithEvents step_number As DataGridViewTextBoxColumn
    Friend WithEvents operation_id As DataGridViewComboBoxColumn
    Friend WithEvents step_name As DataGridViewTextBoxColumn
    Friend WithEvents plan_start_date As DataGridViewCalendarColumn
    Friend WithEvents plan_end_date As DataGridViewCalendarColumn
    Friend WithEvents plan_step_qty As DataGridViewTextBoxColumn
    Friend WithEvents actual_start_date As DataGridViewCalendarColumn
    Friend WithEvents actual_end_date As DataGridViewCalendarColumn
    Friend WithEvents actual_step_qty As DataGridViewTextBoxColumn
    Friend WithEvents cbomcno As DataGridViewComboBoxColumn
    Friend WithEvents cbooperator As DataGridViewTextBoxColumn
    Friend WithEvents work_shift As DataGridViewTextBoxColumn
    Friend WithEvents cbostep_status As DataGridViewComboBoxColumn
    Friend WithEvents step_remarks As DataGridViewTextBoxColumn
End Class
