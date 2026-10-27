<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductionRoutingWarping
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionRoutingWarping))
        Me.lblProItem = New System.Windows.Forms.Label()
        Me.BtnPrintList = New System.Windows.Forms.Button()
        Me.routing_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnNewStep = New System.Windows.Forms.Button()
        Me.operation_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mfg_production_steps_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblProdNo = New System.Windows.Forms.Label()
        Me.step_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TPlots = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSumBeamTotalWeight = New System.Windows.Forms.TextBox()
        Me.txtYINSumRolls = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnYarnIn = New System.Windows.Forms.Button()
        Me.btnPrintQCTension = New System.Windows.Forms.Button()
        Me.BtnPrintQCUI = New System.Windows.Forms.Button()
        Me.btnWO = New System.Windows.Forms.Button()
        Me.btnProtocolWarp = New System.Windows.Forms.Button()
        Me.btnDelRoll = New System.Windows.Forms.Button()
        Me.btnCopyRoll = New System.Windows.Forms.Button()
        Me.btnnewroll = New System.Windows.Forms.Button()
        Me.GbTotal = New System.Windows.Forms.GroupBox()
        Me.lblSumSecondary_Quantity = New System.Windows.Forms.Label()
        Me.txtSumSecondary_Quantity = New System.Windows.Forms.TextBox()
        Me.lblSumPrimary_quantity = New System.Windows.Forms.Label()
        Me.txtSumprimary_Quantity = New System.Windows.Forms.TextBox()
        Me.txtSumRolls = New System.Windows.Forms.TextBox()
        Me.lblSumRolls = New System.Windows.Forms.Label()
        Me.btnPrintSticker = New System.Windows.Forms.Button()
        Me.grdDataLots = New System.Windows.Forms.DataGridView()
        Me.reservation = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.yin = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operation_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.system_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfg_production_lots_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custom_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.operator_lot_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.inventory_item_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot_grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lot_delivered_to_inventory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.production_order_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.primary_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.secondary_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qc_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beam_length = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.warped_ends = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beams_per_set = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboBeamItem = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.weight_before_warp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.warp_speed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tension_h = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tension_per_g = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tape_layer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bobbin_weight_before = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bobbin_weight_after = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bobbin_tear_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beam_tear_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.beam_total_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waste_yarn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.warping_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docdt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.docno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotno_sup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lotno_our = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kg_gr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_cone_weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnViewRolls = New System.Windows.Forms.Button()
        Me.grdDataRouting = New System.Windows.Forms.DataGridView()
        Me.step_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan_step_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_step_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbomcno = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cbooperator = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.work_shift = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbostep_status = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.step_remarks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TProunting = New System.Windows.Forms.TabPage()
        Me.BtnDownStep = New System.Windows.Forms.Button()
        Me.btnScanRolls = New System.Windows.Forms.Button()
        Me.BtnUPStep = New System.Windows.Forms.Button()
        Me.BtnDeleteStep = New System.Windows.Forms.Button()
        Me.btnCopyStep = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.txtBOM = New System.Windows.Forms.TextBox()
        Me.lblProdQty = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.txtProdNo = New System.Windows.Forms.TextBox()
        Me.lblBom = New System.Windows.Forms.Label()
        Me.lblRoutingNo = New System.Windows.Forms.Label()
        Me.txtrouting_code = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDesign_no = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BtnGenLots = New System.Windows.Forms.Button()
        Me.btnSearchRouting_Code = New System.Windows.Forms.Button()
        Me.btnDirectPrint = New System.Windows.Forms.Button()
        Me.lblKOClosedFinal = New System.Windows.Forms.Label()
        Me.lblKOClosed = New System.Windows.Forms.Label()
        Me.lblCancelled = New System.Windows.Forms.Label()
        Me.TPlots.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbTotal.SuspendLayout()
        CType(Me.grdDataLots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDataRouting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TProunting.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProItem
        '
        Me.lblProItem.AutoSize = True
        Me.lblProItem.Location = New System.Drawing.Point(155, 13)
        Me.lblProItem.Name = "lblProItem"
        Me.lblProItem.Size = New System.Drawing.Size(59, 13)
        Me.lblProItem.TabIndex = 41
        Me.lblProItem.Text = "Prod Item:"
        '
        'BtnPrintList
        '
        Me.BtnPrintList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintList.Location = New System.Drawing.Point(104, 328)
        Me.BtnPrintList.Name = "BtnPrintList"
        Me.BtnPrintList.Size = New System.Drawing.Size(75, 23)
        Me.BtnPrintList.TabIndex = 47
        Me.BtnPrintList.Text = "Print List"
        Me.BtnPrintList.UseVisualStyleBackColor = True
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
        'btnNewStep
        '
        Me.btnNewStep.Location = New System.Drawing.Point(14, 6)
        Me.btnNewStep.Name = "btnNewStep"
        Me.btnNewStep.Size = New System.Drawing.Size(75, 23)
        Me.btnNewStep.TabIndex = 454
        Me.btnNewStep.Text = "New Step"
        Me.btnNewStep.UseVisualStyleBackColor = True
        '
        'operation_id
        '
        Me.operation_id.DataPropertyName = "operation_id"
        Me.operation_id.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.operation_id.HeaderText = "STEP NAME"
        Me.operation_id.Name = "operation_id"
        Me.operation_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.operation_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mfg_production_steps_id
        '
        Me.mfg_production_steps_id.DataPropertyName = "mfg_production_steps_id"
        Me.mfg_production_steps_id.HeaderText = "mfg_production_steps_id"
        Me.mfg_production_steps_id.Name = "mfg_production_steps_id"
        Me.mfg_production_steps_id.Visible = False
        '
        'lblProdNo
        '
        Me.lblProdNo.AutoSize = True
        Me.lblProdNo.Location = New System.Drawing.Point(16, 13)
        Me.lblProdNo.Name = "lblProdNo"
        Me.lblProdNo.Size = New System.Drawing.Size(52, 13)
        Me.lblProdNo.TabIndex = 40
        Me.lblProdNo.Text = "Prod No:"
        '
        'step_number
        '
        Me.step_number.DataPropertyName = "step_number"
        Me.step_number.HeaderText = "STEP NO"
        Me.step_number.Name = "step_number"
        Me.step_number.Width = 75
        '
        'TPlots
        '
        Me.TPlots.Controls.Add(Me.GroupBox2)
        Me.TPlots.Controls.Add(Me.btnYarnIn)
        Me.TPlots.Controls.Add(Me.btnPrintQCTension)
        Me.TPlots.Controls.Add(Me.BtnPrintQCUI)
        Me.TPlots.Controls.Add(Me.btnWO)
        Me.TPlots.Controls.Add(Me.btnProtocolWarp)
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
        Me.TPlots.Size = New System.Drawing.Size(1042, 402)
        Me.TPlots.TabIndex = 1
        Me.TPlots.Text = "Production Lot Warp"
        Me.TPlots.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSumBeamTotalWeight)
        Me.GroupBox2.Controls.Add(Me.txtYINSumRolls)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(275, 356)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 40)
        Me.GroupBox2.TabIndex = 464
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "YIN Done"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Total Weight"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Kgs"
        '
        'txtSumBeamTotalWeight
        '
        Me.txtSumBeamTotalWeight.Location = New System.Drawing.Point(186, 14)
        Me.txtSumBeamTotalWeight.Name = "txtSumBeamTotalWeight"
        Me.txtSumBeamTotalWeight.Size = New System.Drawing.Size(59, 22)
        Me.txtSumBeamTotalWeight.TabIndex = 8
        Me.txtSumBeamTotalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtYINSumRolls
        '
        Me.txtYINSumRolls.Location = New System.Drawing.Point(33, 14)
        Me.txtYINSumRolls.Name = "txtYINSumRolls"
        Me.txtYINSumRolls.Size = New System.Drawing.Size(35, 22)
        Me.txtYINSumRolls.TabIndex = 7
        Me.txtYINSumRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Set"
        '
        'btnYarnIn
        '
        Me.btnYarnIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnYarnIn.Location = New System.Drawing.Point(723, 328)
        Me.btnYarnIn.Name = "btnYarnIn"
        Me.btnYarnIn.Size = New System.Drawing.Size(75, 23)
        Me.btnYarnIn.TabIndex = 463
        Me.btnYarnIn.Text = "Yarn In"
        Me.btnYarnIn.UseVisualStyleBackColor = True
        '
        'btnPrintQCTension
        '
        Me.btnPrintQCTension.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrintQCTension.Location = New System.Drawing.Point(597, 328)
        Me.btnPrintQCTension.Name = "btnPrintQCTension"
        Me.btnPrintQCTension.Size = New System.Drawing.Size(120, 23)
        Me.btnPrintQCTension.TabIndex = 462
        Me.btnPrintQCTension.Text = "Print QC Tension"
        Me.btnPrintQCTension.UseVisualStyleBackColor = True
        '
        'BtnPrintQCUI
        '
        Me.BtnPrintQCUI.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintQCUI.Location = New System.Drawing.Point(471, 328)
        Me.BtnPrintQCUI.Name = "BtnPrintQCUI"
        Me.BtnPrintQCUI.Size = New System.Drawing.Size(120, 23)
        Me.BtnPrintQCUI.TabIndex = 461
        Me.BtnPrintQCUI.Text = "Print QC UI/LDR"
        Me.BtnPrintQCUI.UseVisualStyleBackColor = True
        '
        'btnWO
        '
        Me.btnWO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWO.Location = New System.Drawing.Point(185, 328)
        Me.btnWO.Name = "btnWO"
        Me.btnWO.Size = New System.Drawing.Size(151, 23)
        Me.btnWO.TabIndex = 460
        Me.btnWO.Text = "Print Production Lot Warp"
        Me.btnWO.UseVisualStyleBackColor = True
        '
        'btnProtocolWarp
        '
        Me.btnProtocolWarp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProtocolWarp.Location = New System.Drawing.Point(345, 328)
        Me.btnProtocolWarp.Name = "btnProtocolWarp"
        Me.btnProtocolWarp.Size = New System.Drawing.Size(120, 23)
        Me.btnProtocolWarp.TabIndex = 459
        Me.btnProtocolWarp.Text = "Print Protocal Warp"
        Me.btnProtocolWarp.UseVisualStyleBackColor = True
        '
        'btnDelRoll
        '
        Me.btnDelRoll.Location = New System.Drawing.Point(177, 6)
        Me.btnDelRoll.Name = "btnDelRoll"
        Me.btnDelRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnDelRoll.TabIndex = 458
        Me.btnDelRoll.Text = "Delete Set"
        Me.btnDelRoll.UseVisualStyleBackColor = True
        '
        'btnCopyRoll
        '
        Me.btnCopyRoll.Location = New System.Drawing.Point(95, 6)
        Me.btnCopyRoll.Name = "btnCopyRoll"
        Me.btnCopyRoll.Size = New System.Drawing.Size(75, 23)
        Me.btnCopyRoll.TabIndex = 457
        Me.btnCopyRoll.Text = "Copy Set"
        Me.btnCopyRoll.UseVisualStyleBackColor = True
        '
        'btnnewroll
        '
        Me.btnnewroll.Location = New System.Drawing.Point(14, 6)
        Me.btnnewroll.Name = "btnnewroll"
        Me.btnnewroll.Size = New System.Drawing.Size(75, 23)
        Me.btnnewroll.TabIndex = 455
        Me.btnnewroll.Text = "New Set"
        Me.btnnewroll.UseVisualStyleBackColor = True
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
        Me.GbTotal.Location = New System.Drawing.Point(604, 356)
        Me.GbTotal.Name = "GbTotal"
        Me.GbTotal.Size = New System.Drawing.Size(423, 40)
        Me.GbTotal.TabIndex = 48
        Me.GbTotal.TabStop = False
        Me.GbTotal.Text = "Total"
        '
        'lblSumSecondary_Quantity
        '
        Me.lblSumSecondary_Quantity.AutoSize = True
        Me.lblSumSecondary_Quantity.Location = New System.Drawing.Point(374, 17)
        Me.lblSumSecondary_Quantity.Name = "lblSumSecondary_Quantity"
        Me.lblSumSecondary_Quantity.Size = New System.Drawing.Size(27, 13)
        Me.lblSumSecondary_Quantity.TabIndex = 5
        Me.lblSumSecondary_Quantity.Text = "Mts"
        '
        'txtSumSecondary_Quantity
        '
        Me.txtSumSecondary_Quantity.Location = New System.Drawing.Point(294, 14)
        Me.txtSumSecondary_Quantity.Name = "txtSumSecondary_Quantity"
        Me.txtSumSecondary_Quantity.Size = New System.Drawing.Size(76, 20)
        Me.txtSumSecondary_Quantity.TabIndex = 4
        Me.txtSumSecondary_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSumPrimary_quantity
        '
        Me.lblSumPrimary_quantity.AutoSize = True
        Me.lblSumPrimary_quantity.Location = New System.Drawing.Point(234, 17)
        Me.lblSumPrimary_quantity.Name = "lblSumPrimary_quantity"
        Me.lblSumPrimary_quantity.Size = New System.Drawing.Size(28, 13)
        Me.lblSumPrimary_quantity.TabIndex = 3
        Me.lblSumPrimary_quantity.Text = "Kgs"
        '
        'txtSumprimary_Quantity
        '
        Me.txtSumprimary_Quantity.Location = New System.Drawing.Point(156, 14)
        Me.txtSumprimary_Quantity.Name = "txtSumprimary_Quantity"
        Me.txtSumprimary_Quantity.Size = New System.Drawing.Size(74, 20)
        Me.txtSumprimary_Quantity.TabIndex = 2
        Me.txtSumprimary_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSumRolls
        '
        Me.txtSumRolls.Location = New System.Drawing.Point(35, 14)
        Me.txtSumRolls.Name = "txtSumRolls"
        Me.txtSumRolls.Size = New System.Drawing.Size(48, 20)
        Me.txtSumRolls.TabIndex = 1
        Me.txtSumRolls.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSumRolls
        '
        Me.lblSumRolls.AutoSize = True
        Me.lblSumRolls.Location = New System.Drawing.Point(87, 17)
        Me.lblSumRolls.Name = "lblSumRolls"
        Me.lblSumRolls.Size = New System.Drawing.Size(26, 13)
        Me.lblSumRolls.TabIndex = 0
        Me.lblSumRolls.Text = "Set"
        '
        'btnPrintSticker
        '
        Me.btnPrintSticker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrintSticker.Location = New System.Drawing.Point(22, 328)
        Me.btnPrintSticker.Name = "btnPrintSticker"
        Me.btnPrintSticker.Size = New System.Drawing.Size(75, 23)
        Me.btnPrintSticker.TabIndex = 46
        Me.btnPrintSticker.Text = "Print Sticker"
        Me.btnPrintSticker.UseVisualStyleBackColor = True
        '
        'grdDataLots
        '
        Me.grdDataLots.AllowUserToAddRows = False
        Me.grdDataLots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataLots.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDataLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataLots.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.reservation, Me.yin, Me.item_id, Me.operation_name, Me.system_lot_number, Me.mfg_production_lots_id, Me.custom_lot_number, Me.operator_lot_number, Me.inventory_item_code, Me.lot_grade, Me.lot_delivered_to_inventory, Me.production_order_no, Me.primary_quantity, Me.secondary_quantity, Me.created_by, Me.qc_remarks, Me.beam_length, Me.warped_ends, Me.beams_per_set, Me.cboBeamItem, Me.weight_before_warp, Me.warp_speed, Me.tension_h, Me.tension_per_g, Me.tape_layer, Me.bobbin_weight_before, Me.bobbin_weight_after, Me.bobbin_tear_weight, Me.beam_tear_weight, Me.beam_total_weight, Me.waste_yarn, Me.warping_time, Me.docdt, Me.docno, Me.lotno_sup, Me.lotno_our, Me.kg_gr, Me.actual_cone_weight})
        Me.grdDataLots.Location = New System.Drawing.Point(16, 30)
        Me.grdDataLots.Name = "grdDataLots"
        Me.grdDataLots.Size = New System.Drawing.Size(1014, 292)
        Me.grdDataLots.TabIndex = 45
        '
        'reservation
        '
        Me.reservation.DataPropertyName = "reservation"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Click.."
        Me.reservation.DefaultCellStyle = DataGridViewCellStyle1
        Me.reservation.HeaderText = "Reservation"
        Me.reservation.Name = "reservation"
        Me.reservation.ReadOnly = True
        '
        'yin
        '
        Me.yin.HeaderText = "Yarn In"
        Me.yin.Name = "yin"
        Me.yin.Visible = False
        '
        'item_id
        '
        Me.item_id.DataPropertyName = "item_id"
        Me.item_id.HeaderText = "Item ID"
        Me.item_id.Name = "item_id"
        Me.item_id.Width = 40
        '
        'operation_name
        '
        Me.operation_name.DataPropertyName = "operation_name"
        Me.operation_name.HeaderText = "Operation Step"
        Me.operation_name.Name = "operation_name"
        Me.operation_name.ReadOnly = True
        '
        'system_lot_number
        '
        Me.system_lot_number.DataPropertyName = "system_lot_number"
        Me.system_lot_number.HeaderText = "COMP. SET NO."
        Me.system_lot_number.Name = "system_lot_number"
        Me.system_lot_number.ReadOnly = True
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
        Me.custom_lot_number.HeaderText = "FACT. SET NO"
        Me.custom_lot_number.Name = "custom_lot_number"
        '
        'operator_lot_number
        '
        Me.operator_lot_number.DataPropertyName = "operator_lot_number"
        Me.operator_lot_number.HeaderText = "OPER SET NO."
        Me.operator_lot_number.Name = "operator_lot_number"
        Me.operator_lot_number.Width = 50
        '
        'inventory_item_code
        '
        Me.inventory_item_code.DataPropertyName = "inventory_item_code"
        Me.inventory_item_code.HeaderText = "Item Code"
        Me.inventory_item_code.Name = "inventory_item_code"
        '
        'lot_grade
        '
        Me.lot_grade.DataPropertyName = "lot_grade"
        Me.lot_grade.HeaderText = "GRADE"
        Me.lot_grade.Name = "lot_grade"
        Me.lot_grade.Width = 30
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
        'created_by
        '
        Me.created_by.DataPropertyName = "created_by"
        Me.created_by.HeaderText = "created_by"
        Me.created_by.Name = "created_by"
        Me.created_by.Visible = False
        '
        'qc_remarks
        '
        Me.qc_remarks.DataPropertyName = "qc_remarks"
        Me.qc_remarks.HeaderText = "Q/C REMARKS"
        Me.qc_remarks.Name = "qc_remarks"
        Me.qc_remarks.Width = 300
        '
        'beam_length
        '
        Me.beam_length.DataPropertyName = "beam_length"
        Me.beam_length.HeaderText = "Length (m.)"
        Me.beam_length.Name = "beam_length"
        '
        'warped_ends
        '
        Me.warped_ends.DataPropertyName = "warped_ends"
        Me.warped_ends.HeaderText = "Ends (C)"
        Me.warped_ends.Name = "warped_ends"
        '
        'beams_per_set
        '
        Me.beams_per_set.DataPropertyName = "beams_per_set"
        Me.beams_per_set.HeaderText = "Beams Per Set (D)"
        Me.beams_per_set.Name = "beams_per_set"
        '
        'cboBeamItem
        '
        Me.cboBeamItem.DataPropertyName = "beam_item_id"
        Me.cboBeamItem.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.cboBeamItem.HeaderText = "Beam Item"
        Me.cboBeamItem.Name = "cboBeamItem"
        Me.cboBeamItem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cboBeamItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cboBeamItem.Width = 150
        '
        'weight_before_warp
        '
        Me.weight_before_warp.DataPropertyName = "weight_before_warp"
        Me.weight_before_warp.HeaderText = "Weight Before Warp"
        Me.weight_before_warp.Name = "weight_before_warp"
        '
        'warp_speed
        '
        Me.warp_speed.DataPropertyName = "warp_speed"
        Me.warp_speed.HeaderText = "Warp Speed"
        Me.warp_speed.Name = "warp_speed"
        '
        'tension_h
        '
        Me.tension_h.DataPropertyName = "tension_h"
        Me.tension_h.HeaderText = "H./ Tension / Stretch"
        Me.tension_h.Name = "tension_h"
        '
        'tension_per_g
        '
        Me.tension_per_g.DataPropertyName = "tension_per_g"
        Me.tension_per_g.HeaderText = "Tension (g.)"
        Me.tension_per_g.Name = "tension_per_g"
        '
        'tape_layer
        '
        Me.tape_layer.DataPropertyName = "tape_layer"
        Me.tape_layer.HeaderText = "Tape Layer"
        Me.tape_layer.Name = "tape_layer"
        '
        'bobbin_weight_before
        '
        Me.bobbin_weight_before.DataPropertyName = "bobbin_weight_before"
        Me.bobbin_weight_before.HeaderText = "Weight Before (A)"
        Me.bobbin_weight_before.Name = "bobbin_weight_before"
        '
        'bobbin_weight_after
        '
        Me.bobbin_weight_after.DataPropertyName = "bobbin_weight_after"
        Me.bobbin_weight_after.HeaderText = "Weight After (B)"
        Me.bobbin_weight_after.Name = "bobbin_weight_after"
        '
        'bobbin_tear_weight
        '
        Me.bobbin_tear_weight.DataPropertyName = "bobbin_tear_weight"
        Me.bobbin_tear_weight.HeaderText = "Weight / Bobbins (A-B)"
        Me.bobbin_tear_weight.Name = "bobbin_tear_weight"
        '
        'beam_tear_weight
        '
        Me.beam_tear_weight.DataPropertyName = "beam_tear_weight"
        Me.beam_tear_weight.HeaderText = "Weight / Beam ((A-B)*C)/D"
        Me.beam_tear_weight.Name = "beam_tear_weight"
        '
        'beam_total_weight
        '
        Me.beam_total_weight.DataPropertyName = "beam_total_weight"
        Me.beam_total_weight.HeaderText = "Total Weight  (A-B)*C"
        Me.beam_total_weight.Name = "beam_total_weight"
        '
        'waste_yarn
        '
        Me.waste_yarn.DataPropertyName = "waste_yarn"
        Me.waste_yarn.HeaderText = "Waste"
        Me.waste_yarn.Name = "waste_yarn"
        '
        'warping_time
        '
        Me.warping_time.DataPropertyName = "warping_time"
        Me.warping_time.HeaderText = "Time Warping (Min.)"
        Me.warping_time.Name = "warping_time"
        '
        'docdt
        '
        Me.docdt.DataPropertyName = "docdt"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.docdt.DefaultCellStyle = DataGridViewCellStyle2
        Me.docdt.HeaderText = "YIN Date"
        Me.docdt.Name = "docdt"
        Me.docdt.Width = 80
        '
        'docno
        '
        Me.docno.DataPropertyName = "docno"
        Me.docno.HeaderText = "YIN No."
        Me.docno.Name = "docno"
        '
        'lotno_sup
        '
        Me.lotno_sup.DataPropertyName = "lotno_sup"
        Me.lotno_sup.HeaderText = "Lot No. (Sup)"
        Me.lotno_sup.Name = "lotno_sup"
        '
        'lotno_our
        '
        Me.lotno_our.DataPropertyName = "lotno_our"
        Me.lotno_our.HeaderText = "Lot No. (Our)"
        Me.lotno_our.Name = "lotno_our"
        '
        'kg_gr
        '
        Me.kg_gr.DataPropertyName = "kg_gr"
        Me.kg_gr.HeaderText = "Gross Weight"
        Me.kg_gr.Name = "kg_gr"
        '
        'actual_cone_weight
        '
        Me.actual_cone_weight.DataPropertyName = "actual_cone_weight"
        Me.actual_cone_weight.HeaderText = "Actual Cone Weight"
        Me.actual_cone_weight.Name = "actual_cone_weight"
        '
        'btnViewRolls
        '
        Me.btnViewRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnViewRolls.Location = New System.Drawing.Point(16, 438)
        Me.btnViewRolls.Name = "btnViewRolls"
        Me.btnViewRolls.Size = New System.Drawing.Size(75, 23)
        Me.btnViewRolls.TabIndex = 457
        Me.btnViewRolls.Text = "View Set"
        Me.btnViewRolls.UseVisualStyleBackColor = True
        '
        'grdDataRouting
        '
        Me.grdDataRouting.AllowUserToAddRows = False
        Me.grdDataRouting.AllowUserToDeleteRows = False
        Me.grdDataRouting.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDataRouting.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDataRouting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDataRouting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mfg_production_steps_id, Me.routing_id, Me.step_number, Me.operation_id, Me.step_name, Me.plan_step_qty, Me.actual_step_qty, Me.cbomcno, Me.cbooperator, Me.work_shift, Me.cbostep_status, Me.step_remarks})
        Me.grdDataRouting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.grdDataRouting.Location = New System.Drawing.Point(16, 31)
        Me.grdDataRouting.Name = "grdDataRouting"
        Me.grdDataRouting.Size = New System.Drawing.Size(1020, 400)
        Me.grdDataRouting.TabIndex = 44
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
        'plan_step_qty
        '
        Me.plan_step_qty.DataPropertyName = "plan_step_qty"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.plan_step_qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.plan_step_qty.HeaderText = "PLAN STEP QTY"
        Me.plan_step_qty.Name = "plan_step_qty"
        Me.plan_step_qty.Width = 75
        '
        'actual_step_qty
        '
        Me.actual_step_qty.DataPropertyName = "actual_step_qty"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "0.00"
        Me.actual_step_qty.DefaultCellStyle = DataGridViewCellStyle4
        Me.actual_step_qty.HeaderText = "ACTUAL STEP QTY"
        Me.actual_step_qty.Name = "actual_step_qty"
        Me.actual_step_qty.Width = 75
        '
        'cbomcno
        '
        Me.cbomcno.DataPropertyName = "mcno"
        Me.cbomcno.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
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
        Me.cbostep_status.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
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
        Me.TProunting.Size = New System.Drawing.Size(1042, 473)
        Me.TProunting.TabIndex = 0
        Me.TProunting.Text = "Production Routing"
        Me.TProunting.UseVisualStyleBackColor = True
        '
        'BtnDownStep
        '
        Me.BtnDownStep.Location = New System.Drawing.Point(339, 6)
        Me.BtnDownStep.Name = "BtnDownStep"
        Me.BtnDownStep.Size = New System.Drawing.Size(75, 23)
        Me.BtnDownStep.TabIndex = 455
        Me.BtnDownStep.Text = "Down Step"
        Me.BtnDownStep.UseVisualStyleBackColor = True
        Me.BtnDownStep.Visible = False
        '
        'btnScanRolls
        '
        Me.btnScanRolls.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnScanRolls.Location = New System.Drawing.Point(98, 438)
        Me.btnScanRolls.Name = "btnScanRolls"
        Me.btnScanRolls.Size = New System.Drawing.Size(75, 23)
        Me.btnScanRolls.TabIndex = 458
        Me.btnScanRolls.Text = "Scan Set"
        Me.btnScanRolls.UseVisualStyleBackColor = True
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
        'BtnDeleteStep
        '
        Me.BtnDeleteStep.Location = New System.Drawing.Point(177, 6)
        Me.BtnDeleteStep.Name = "BtnDeleteStep"
        Me.BtnDeleteStep.Size = New System.Drawing.Size(75, 23)
        Me.BtnDeleteStep.TabIndex = 456
        Me.BtnDeleteStep.Text = "Delete Step"
        Me.BtnDeleteStep.UseVisualStyleBackColor = True
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
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnSearch, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1074, 25)
        Me.ToolStrip1.TabIndex = 464
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
        'txtBOM
        '
        Me.txtBOM.Location = New System.Drawing.Point(427, 31)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.ReadOnly = True
        Me.txtBOM.Size = New System.Drawing.Size(125, 22)
        Me.txtBOM.TabIndex = 50
        Me.txtBOM.Tag = "str"
        '
        'lblProdQty
        '
        Me.lblProdQty.AutoSize = True
        Me.lblProdQty.Location = New System.Drawing.Point(289, 13)
        Me.lblProdQty.Name = "lblProdQty"
        Me.lblProdQty.Size = New System.Drawing.Size(79, 13)
        Me.lblProdQty.TabIndex = 42
        Me.lblProdQty.Text = "Prod Qty(Kgs):"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(293, 31)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.ReadOnly = True
        Me.txtqty.Size = New System.Drawing.Size(125, 22)
        Me.txtqty.TabIndex = 48
        Me.txtqty.Tag = "str"
        '
        'txtProdNo
        '
        Me.txtProdNo.Location = New System.Drawing.Point(19, 33)
        Me.txtProdNo.Name = "txtProdNo"
        Me.txtProdNo.ReadOnly = True
        Me.txtProdNo.Size = New System.Drawing.Size(125, 22)
        Me.txtProdNo.TabIndex = 46
        Me.txtProdNo.Tag = "str"
        '
        'lblBom
        '
        Me.lblBom.AutoSize = True
        Me.lblBom.Location = New System.Drawing.Point(424, 13)
        Me.lblBom.Name = "lblBom"
        Me.lblBom.Size = New System.Drawing.Size(39, 13)
        Me.lblBom.TabIndex = 45
        Me.lblBom.Text = "BOM :"
        '
        'lblRoutingNo
        '
        Me.lblRoutingNo.AutoSize = True
        Me.lblRoutingNo.Location = New System.Drawing.Point(12, 32)
        Me.lblRoutingNo.Name = "lblRoutingNo"
        Me.lblRoutingNo.Size = New System.Drawing.Size(76, 13)
        Me.lblRoutingNo.TabIndex = 465
        Me.lblRoutingNo.Text = "Routing No. :"
        '
        'txtrouting_code
        '
        Me.txtrouting_code.Location = New System.Drawing.Point(16, 48)
        Me.txtrouting_code.Name = "txtrouting_code"
        Me.txtrouting_code.Size = New System.Drawing.Size(125, 22)
        Me.txtrouting_code.TabIndex = 466
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblProdNo)
        Me.GroupBox1.Controls.Add(Me.lblProItem)
        Me.GroupBox1.Controls.Add(Me.txtBOM)
        Me.GroupBox1.Controls.Add(Me.lblProdQty)
        Me.GroupBox1.Controls.Add(Me.lblBom)
        Me.GroupBox1.Controls.Add(Me.txtqty)
        Me.GroupBox1.Controls.Add(Me.txtProdNo)
        Me.GroupBox1.Controls.Add(Me.txtDesign_no)
        Me.GroupBox1.Location = New System.Drawing.Point(497, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(565, 72)
        Me.GroupBox1.TabIndex = 468
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRO Information"
        '
        'txtDesign_no
        '
        Me.txtDesign_no.Location = New System.Drawing.Point(158, 31)
        Me.txtDesign_no.Name = "txtDesign_no"
        Me.txtDesign_no.ReadOnly = True
        Me.txtDesign_no.Size = New System.Drawing.Size(125, 22)
        Me.txtDesign_no.TabIndex = 47
        Me.txtDesign_no.Tag = "str"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TProunting)
        Me.TabControl1.Controls.Add(Me.TPlots)
        Me.TabControl1.Location = New System.Drawing.Point(12, 106)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1050, 499)
        Me.TabControl1.TabIndex = 469
        '
        'BtnGenLots
        '
        Me.BtnGenLots.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGenLots.Location = New System.Drawing.Point(193, 48)
        Me.BtnGenLots.Name = "BtnGenLots"
        Me.BtnGenLots.Size = New System.Drawing.Size(75, 22)
        Me.BtnGenLots.TabIndex = 470
        Me.BtnGenLots.Text = "Gen Lots"
        Me.BtnGenLots.UseVisualStyleBackColor = True
        Me.BtnGenLots.Visible = False
        '
        'btnSearchRouting_Code
        '
        Me.btnSearchRouting_Code.Image = CType(resources.GetObject("btnSearchRouting_Code.Image"), System.Drawing.Image)
        Me.btnSearchRouting_Code.Location = New System.Drawing.Point(147, 47)
        Me.btnSearchRouting_Code.Name = "btnSearchRouting_Code"
        Me.btnSearchRouting_Code.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchRouting_Code.TabIndex = 467
        Me.btnSearchRouting_Code.UseVisualStyleBackColor = True
        '
        'btnDirectPrint
        '
        Me.btnDirectPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDirectPrint.Location = New System.Drawing.Point(283, 48)
        Me.btnDirectPrint.Name = "btnDirectPrint"
        Me.btnDirectPrint.Size = New System.Drawing.Size(75, 22)
        Me.btnDirectPrint.TabIndex = 471
        Me.btnDirectPrint.Text = "Print Barcode"
        Me.btnDirectPrint.UseVisualStyleBackColor = True
        Me.btnDirectPrint.Visible = False
        '
        'lblKOClosedFinal
        '
        Me.lblKOClosedFinal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKOClosedFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKOClosedFinal.ForeColor = System.Drawing.Color.Red
        Me.lblKOClosedFinal.Location = New System.Drawing.Point(947, 32)
        Me.lblKOClosedFinal.Name = "lblKOClosedFinal"
        Me.lblKOClosedFinal.Size = New System.Drawing.Size(115, 24)
        Me.lblKOClosedFinal.TabIndex = 474
        Me.lblKOClosedFinal.Text = "Delivered"
        Me.lblKOClosedFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblKOClosedFinal.Visible = False
        '
        'lblKOClosed
        '
        Me.lblKOClosed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKOClosed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblKOClosed.ForeColor = System.Drawing.Color.Red
        Me.lblKOClosed.Location = New System.Drawing.Point(862, 32)
        Me.lblKOClosed.Name = "lblKOClosed"
        Me.lblKOClosed.Size = New System.Drawing.Size(87, 24)
        Me.lblKOClosed.TabIndex = 473
        Me.lblKOClosed.Text = "Closed"
        Me.lblKOClosed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblKOClosed.Visible = False
        '
        'lblCancelled
        '
        Me.lblCancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCancelled.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCancelled.ForeColor = System.Drawing.Color.Red
        Me.lblCancelled.Location = New System.Drawing.Point(744, 32)
        Me.lblCancelled.Name = "lblCancelled"
        Me.lblCancelled.Size = New System.Drawing.Size(121, 24)
        Me.lblCancelled.TabIndex = 472
        Me.lblCancelled.Text = "Cancelled"
        Me.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCancelled.Visible = False
        '
        'frmProductionRoutingWarping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 607)
        Me.Controls.Add(Me.lblKOClosedFinal)
        Me.Controls.Add(Me.lblKOClosed)
        Me.Controls.Add(Me.lblCancelled)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblRoutingNo)
        Me.Controls.Add(Me.txtrouting_code)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BtnGenLots)
        Me.Controls.Add(Me.btnSearchRouting_Code)
        Me.Controls.Add(Me.btnDirectPrint)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmProductionRoutingWarping"
        Me.Text = "Production Routing For Warp"
        Me.TPlots.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbTotal.ResumeLayout(False)
        Me.GbTotal.PerformLayout()
        CType(Me.grdDataLots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDataRouting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TProunting.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProItem As System.Windows.Forms.Label
    Friend WithEvents BtnPrintList As System.Windows.Forms.Button
    Friend WithEvents routing_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents btnNewStep As System.Windows.Forms.Button
    Friend WithEvents operation_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mfg_production_steps_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblProdNo As System.Windows.Forms.Label
    Friend WithEvents step_number As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TPlots As System.Windows.Forms.TabPage
    Friend WithEvents btnDelRoll As System.Windows.Forms.Button
    Friend WithEvents btnCopyRoll As System.Windows.Forms.Button
    Friend WithEvents btnnewroll As System.Windows.Forms.Button
    Friend WithEvents GbTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblSumSecondary_Quantity As System.Windows.Forms.Label
    Friend WithEvents txtSumSecondary_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents lblSumPrimary_quantity As System.Windows.Forms.Label
    Friend WithEvents txtSumprimary_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents txtSumRolls As System.Windows.Forms.TextBox
    Friend WithEvents lblSumRolls As System.Windows.Forms.Label
    Friend WithEvents btnPrintSticker As System.Windows.Forms.Button
    Friend WithEvents grdDataLots As System.Windows.Forms.DataGridView
    Friend WithEvents btnViewRolls As System.Windows.Forms.Button
    Friend WithEvents grdDataRouting As System.Windows.Forms.DataGridView
    Friend WithEvents step_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents plan_step_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actual_step_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbomcno As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cbooperator As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents work_shift As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbostep_status As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents step_remarks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TProunting As System.Windows.Forms.TabPage
    Friend WithEvents BtnDownStep As System.Windows.Forms.Button
    Friend WithEvents btnScanRolls As System.Windows.Forms.Button
    Friend WithEvents BtnUPStep As System.Windows.Forms.Button
    Friend WithEvents BtnDeleteStep As System.Windows.Forms.Button
    Friend WithEvents btnCopyStep As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtBOM As System.Windows.Forms.TextBox
    Friend WithEvents lblProdQty As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents txtProdNo As System.Windows.Forms.TextBox
    Friend WithEvents lblBom As System.Windows.Forms.Label
    Friend WithEvents lblRoutingNo As System.Windows.Forms.Label
    Friend WithEvents txtrouting_code As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDesign_no As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents BtnGenLots As System.Windows.Forms.Button
    Friend WithEvents btnSearchRouting_Code As System.Windows.Forms.Button
    Friend WithEvents btnDirectPrint As System.Windows.Forms.Button
    Friend WithEvents btnProtocolWarp As System.Windows.Forms.Button
    Friend WithEvents btnWO As System.Windows.Forms.Button
    Friend WithEvents BtnPrintQCUI As System.Windows.Forms.Button
    Friend WithEvents btnPrintQCTension As System.Windows.Forms.Button
    Friend WithEvents btnYarnIn As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSumBeamTotalWeight As TextBox
    Friend WithEvents txtYINSumRolls As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblKOClosedFinal As Label
    Friend WithEvents lblKOClosed As Label
    Friend WithEvents lblCancelled As Label
    Friend WithEvents reservation As DataGridViewButtonColumn
    Friend WithEvents yin As DataGridViewButtonColumn
    Friend WithEvents item_id As DataGridViewTextBoxColumn
    Friend WithEvents operation_name As DataGridViewTextBoxColumn
    Friend WithEvents system_lot_number As DataGridViewTextBoxColumn
    Friend WithEvents mfg_production_lots_id As DataGridViewTextBoxColumn
    Friend WithEvents custom_lot_number As DataGridViewTextBoxColumn
    Friend WithEvents operator_lot_number As DataGridViewTextBoxColumn
    Friend WithEvents inventory_item_code As DataGridViewTextBoxColumn
    Friend WithEvents lot_grade As DataGridViewTextBoxColumn
    Friend WithEvents lot_delivered_to_inventory As DataGridViewTextBoxColumn
    Friend WithEvents production_order_no As DataGridViewTextBoxColumn
    Friend WithEvents primary_quantity As DataGridViewTextBoxColumn
    Friend WithEvents secondary_quantity As DataGridViewTextBoxColumn
    Friend WithEvents created_by As DataGridViewTextBoxColumn
    Friend WithEvents qc_remarks As DataGridViewTextBoxColumn
    Friend WithEvents beam_length As DataGridViewTextBoxColumn
    Friend WithEvents warped_ends As DataGridViewTextBoxColumn
    Friend WithEvents beams_per_set As DataGridViewTextBoxColumn
    Friend WithEvents cboBeamItem As DataGridViewComboBoxColumn
    Friend WithEvents weight_before_warp As DataGridViewTextBoxColumn
    Friend WithEvents warp_speed As DataGridViewTextBoxColumn
    Friend WithEvents tension_h As DataGridViewTextBoxColumn
    Friend WithEvents tension_per_g As DataGridViewTextBoxColumn
    Friend WithEvents tape_layer As DataGridViewTextBoxColumn
    Friend WithEvents bobbin_weight_before As DataGridViewTextBoxColumn
    Friend WithEvents bobbin_weight_after As DataGridViewTextBoxColumn
    Friend WithEvents bobbin_tear_weight As DataGridViewTextBoxColumn
    Friend WithEvents beam_tear_weight As DataGridViewTextBoxColumn
    Friend WithEvents beam_total_weight As DataGridViewTextBoxColumn
    Friend WithEvents waste_yarn As DataGridViewTextBoxColumn
    Friend WithEvents warping_time As DataGridViewTextBoxColumn
    Friend WithEvents docdt As DataGridViewTextBoxColumn
    Friend WithEvents docno As DataGridViewTextBoxColumn
    Friend WithEvents lotno_sup As DataGridViewTextBoxColumn
    Friend WithEvents lotno_our As DataGridViewTextBoxColumn
    Friend WithEvents kg_gr As DataGridViewTextBoxColumn
    Friend WithEvents actual_cone_weight As DataGridViewTextBoxColumn
End Class
