<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStockGIN_KOFromProductionLots
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGIN_KOFromProductionLots))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblrpm = New System.Windows.Forms.Label()
        Me.lblcounter_per_roll = New System.Windows.Forms.Label()
        Me.txtrpm = New System.Windows.Forms.TextBox()
        Me.txtcounter_per_roll = New System.Windows.Forms.TextBox()
        Me.grdDefect = New System.Windows.Forms.DataGridView()
        Me.ColrollNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDefectCode = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColDefectName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColdefectDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColstockCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GbDefect = New System.Windows.Forms.GroupBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lbldefect_details = New System.Windows.Forms.Label()
        Me.txtdefect_details = New System.Windows.Forms.TextBox()
        Me.lblDefect_code = New System.Windows.Forms.Label()
        Me.cbodefect_code = New System.Windows.Forms.ComboBox()
        Me.btnGreigeIn = New System.Windows.Forms.Button()
        Me.dtpProdFinishTime = New System.Windows.Forms.DateTimePicker()
        Me.chkcliped = New System.Windows.Forms.CheckBox()
        Me.lblcliped = New System.Windows.Forms.Label()
        Me.dtpProdFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.chkdyeing_pass = New System.Windows.Forms.CheckBox()
        Me.txtdefect_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldefect_loss_kg = New System.Windows.Forms.Label()
        Me.txtlab_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbllab_loss_kg = New System.Windows.Forms.Label()
        Me.txtdyed_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldyed_loss_kg = New System.Windows.Forms.Label()
        Me.txtqc_loss_kg = New System.Windows.Forms.TextBox()
        Me.lblqc_loss_kg = New System.Windows.Forms.Label()
        Me.lbladjust_loss_kg = New System.Windows.Forms.Label()
        Me.txtadjust_loss_kg = New System.Windows.Forms.TextBox()
        Me.lbldyeing_pass = New System.Windows.Forms.Label()
        Me.lblProdFinishTime = New System.Windows.Forms.Label()
        Me.lblProdFinishDate = New System.Windows.Forms.Label()
        Me.txtgrade_adt = New System.Windows.Forms.TextBox()
        Me.lblgrade_adt = New System.Windows.Forms.Label()
        Me.txtgrade_bdt = New System.Windows.Forms.TextBox()
        Me.lblgrade_bdt = New System.Windows.Forms.Label()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.lbllot = New System.Windows.Forms.Label()
        Me.txtgwth = New System.Windows.Forms.TextBox()
        Me.lblgwth = New System.Windows.Forms.Label()
        Me.txtbar_weight = New System.Windows.Forms.TextBox()
        Me.lblbar_weight = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbSteam = New System.Windows.Forms.GroupBox()
        Me.txtsteam_instruction = New System.Windows.Forms.TextBox()
        Me.lblsteam_instruction = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.lblsystem_lot_number = New System.Windows.Forms.Label()
        Me.lblcustom_lot_number = New System.Windows.Forms.Label()
        Me.txttran_no = New System.Windows.Forms.TextBox()
        Me.txtsecondary_quantity = New System.Windows.Forms.TextBox()
        Me.lblsecondary_quantity = New System.Windows.Forms.Label()
        Me.txtprimary_quantity = New System.Windows.Forms.TextBox()
        Me.lbltran_no = New System.Windows.Forms.Label()
        Me.txtBOM = New System.Windows.Forms.TextBox()
        Me.lblkg = New System.Windows.Forms.Label()
        Me.txtlot_grade = New System.Windows.Forms.TextBox()
        Me.lbltran_dt = New System.Windows.Forms.Label()
        Me.dtptran_dt = New System.Windows.Forms.DateTimePicker()
        Me.cbomfg_production_steps_id = New System.Windows.Forms.ComboBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.cbomcno = New System.Windows.Forms.ComboBox()
        Me.lblynchgcd = New System.Windows.Forms.Label()
        Me.lblStep = New System.Windows.Forms.Label()
        Me.lblmcno = New System.Windows.Forms.Label()
        Me.txtinventory_item_code = New System.Windows.Forms.TextBox()
        Me.txtsystem_lot_number = New System.Windows.Forms.TextBox()
        Me.txtproduction_order_no = New System.Windows.Forms.TextBox()
        Me.cbooperator = New System.Windows.Forms.ComboBox()
        Me.lblPROD = New System.Windows.Forms.Label()
        Me.txtcustom_lot_number = New System.Windows.Forms.TextBox()
        Me.lblDesignNo = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.gbSystemRoll = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblsteam_condition = New System.Windows.Forms.Label()
        Me.txtsteam_condition = New System.Windows.Forms.TextBox()
        Me.lblsteam_date = New System.Windows.Forms.Label()
        Me.dtpsteam_date = New System.Windows.Forms.DateTimePicker()
        Me.dtpsteam_time = New System.Windows.Forms.DateTimePicker()
        Me.gbProduction = New System.Windows.Forms.GroupBox()
        Me.lbloperator = New System.Windows.Forms.Label()
        Me.btnSave_2 = New System.Windows.Forms.Button()
        Me.cbomtl_location = New System.Windows.Forms.ComboBox()
        Me.lblmtl_location = New System.Windows.Forms.Label()
        Me.txtqc_remarks = New System.Windows.Forms.TextBox()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.txtwork_shift = New System.Windows.Forms.TextBox()
        Me.lblwork_shift = New System.Windows.Forms.Label()
        Me.lblqc_remarks = New System.Windows.Forms.Label()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDefect.SuspendLayout()
        Me.gbSteam.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbSystemRoll.SuspendLayout()
        Me.gbProduction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 545)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 586
        Me.Label2.Text = "Sub Inventory"
        '
        'lblrpm
        '
        Me.lblrpm.AutoSize = True
        Me.lblrpm.Location = New System.Drawing.Point(583, 326)
        Me.lblrpm.Name = "lblrpm"
        Me.lblrpm.Size = New System.Drawing.Size(31, 13)
        Me.lblrpm.TabIndex = 585
        Me.lblrpm.Text = "RPM"
        '
        'lblcounter_per_roll
        '
        Me.lblcounter_per_roll.AutoSize = True
        Me.lblcounter_per_roll.Location = New System.Drawing.Point(538, 299)
        Me.lblcounter_per_roll.Name = "lblcounter_per_roll"
        Me.lblcounter_per_roll.Size = New System.Drawing.Size(76, 13)
        Me.lblcounter_per_roll.TabIndex = 584
        Me.lblcounter_per_roll.Text = "Counter / Roll."
        '
        'txtrpm
        '
        Me.txtrpm.Location = New System.Drawing.Point(627, 327)
        Me.txtrpm.Name = "txtrpm"
        Me.txtrpm.Size = New System.Drawing.Size(161, 20)
        Me.txtrpm.TabIndex = 551
        '
        'txtcounter_per_roll
        '
        Me.txtcounter_per_roll.Location = New System.Drawing.Point(627, 299)
        Me.txtcounter_per_roll.Name = "txtcounter_per_roll"
        Me.txtcounter_per_roll.Size = New System.Drawing.Size(161, 20)
        Me.txtcounter_per_roll.TabIndex = 549
        '
        'grdDefect
        '
        Me.grdDefect.AllowUserToAddRows = False
        Me.grdDefect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDefect.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDefect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColrollNo, Me.ColDefectCode, Me.ColDefectName, Me.ColdefectDetails, Me.ColstockCode})
        Me.grdDefect.Location = New System.Drawing.Point(10, 19)
        Me.grdDefect.Name = "grdDefect"
        Me.grdDefect.Size = New System.Drawing.Size(283, 128)
        Me.grdDefect.TabIndex = 432
        Me.grdDefect.TabStop = False
        '
        'ColrollNo
        '
        Me.ColrollNo.DataPropertyName = "roll_no"
        Me.ColrollNo.HeaderText = "Roll No."
        Me.ColrollNo.Name = "ColrollNo"
        Me.ColrollNo.Visible = False
        '
        'ColDefectCode
        '
        Me.ColDefectCode.DataPropertyName = "defect_code"
        Me.ColDefectCode.HeaderText = "Defect Code"
        Me.ColDefectCode.Name = "ColDefectCode"
        Me.ColDefectCode.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDefectCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColDefectCode.Width = 120
        '
        'ColDefectName
        '
        Me.ColDefectName.DataPropertyName = "Defect_name"
        Me.ColDefectName.HeaderText = "Defect Name"
        Me.ColDefectName.Name = "ColDefectName"
        Me.ColDefectName.ReadOnly = True
        Me.ColDefectName.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColDefectName.Visible = False
        '
        'ColdefectDetails
        '
        Me.ColdefectDetails.DataPropertyName = "defect_details"
        Me.ColdefectDetails.HeaderText = "Qty"
        Me.ColdefectDetails.Name = "ColdefectDetails"
        Me.ColdefectDetails.Width = 90
        '
        'ColstockCode
        '
        Me.ColstockCode.DataPropertyName = "stock_code"
        Me.ColstockCode.HeaderText = "Stock Code"
        Me.ColstockCode.Name = "ColstockCode"
        Me.ColstockCode.Visible = False
        '
        'GbDefect
        '
        Me.GbDefect.Controls.Add(Me.btnApply)
        Me.GbDefect.Controls.Add(Me.lbldefect_details)
        Me.GbDefect.Controls.Add(Me.txtdefect_details)
        Me.GbDefect.Controls.Add(Me.lblDefect_code)
        Me.GbDefect.Controls.Add(Me.cbodefect_code)
        Me.GbDefect.Controls.Add(Me.grdDefect)
        Me.GbDefect.Location = New System.Drawing.Point(594, 415)
        Me.GbDefect.Name = "GbDefect"
        Me.GbDefect.Size = New System.Drawing.Size(307, 212)
        Me.GbDefect.TabIndex = 583
        Me.GbDefect.TabStop = False
        Me.GbDefect.Text = "Defect Detail"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(232, 161)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(57, 23)
        Me.btnApply.TabIndex = 437
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lbldefect_details
        '
        Me.lbldefect_details.AutoSize = True
        Me.lbldefect_details.Location = New System.Drawing.Point(171, 162)
        Me.lbldefect_details.Name = "lbldefect_details"
        Me.lbldefect_details.Size = New System.Drawing.Size(23, 13)
        Me.lbldefect_details.TabIndex = 436
        Me.lbldefect_details.Text = "Qty"
        '
        'txtdefect_details
        '
        Me.txtdefect_details.Location = New System.Drawing.Point(200, 163)
        Me.txtdefect_details.Name = "txtdefect_details"
        Me.txtdefect_details.Size = New System.Drawing.Size(21, 20)
        Me.txtdefect_details.TabIndex = 29
        '
        'lblDefect_code
        '
        Me.lblDefect_code.AutoSize = True
        Me.lblDefect_code.Location = New System.Drawing.Point(7, 163)
        Me.lblDefect_code.Name = "lblDefect_code"
        Me.lblDefect_code.Size = New System.Drawing.Size(52, 13)
        Me.lblDefect_code.TabIndex = 434
        Me.lblDefect_code.Text = "Def Code"
        '
        'cbodefect_code
        '
        Me.cbodefect_code.FormattingEnabled = True
        Me.cbodefect_code.Location = New System.Drawing.Point(65, 164)
        Me.cbodefect_code.Name = "cbodefect_code"
        Me.cbodefect_code.Size = New System.Drawing.Size(100, 21)
        Me.cbodefect_code.TabIndex = 28
        '
        'btnGreigeIn
        '
        Me.btnGreigeIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGreigeIn.Location = New System.Drawing.Point(178, 622)
        Me.btnGreigeIn.Name = "btnGreigeIn"
        Me.btnGreigeIn.Size = New System.Drawing.Size(75, 23)
        Me.btnGreigeIn.TabIndex = 582
        Me.btnGreigeIn.Text = "Greige In"
        Me.btnGreigeIn.UseVisualStyleBackColor = True
        '
        'dtpProdFinishTime
        '
        Me.dtpProdFinishTime.Checked = False
        Me.dtpProdFinishTime.CustomFormat = "HH:mm"
        Me.dtpProdFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProdFinishTime.Location = New System.Drawing.Point(407, 266)
        Me.dtpProdFinishTime.Name = "dtpProdFinishTime"
        Me.dtpProdFinishTime.ShowCheckBox = True
        Me.dtpProdFinishTime.ShowUpDown = True
        Me.dtpProdFinishTime.Size = New System.Drawing.Size(119, 20)
        Me.dtpProdFinishTime.TabIndex = 538
        Me.dtpProdFinishTime.Value = New Date(2016, 6, 29, 10, 12, 0, 0)
        '
        'chkcliped
        '
        Me.chkcliped.AutoSize = True
        Me.chkcliped.Location = New System.Drawing.Point(121, 487)
        Me.chkcliped.Name = "chkcliped"
        Me.chkcliped.Size = New System.Drawing.Size(15, 14)
        Me.chkcliped.TabIndex = 532
        Me.chkcliped.UseVisualStyleBackColor = True
        '
        'lblcliped
        '
        Me.lblcliped.AutoSize = True
        Me.lblcliped.Location = New System.Drawing.Point(4, 488)
        Me.lblcliped.Name = "lblcliped"
        Me.lblcliped.Size = New System.Drawing.Size(106, 13)
        Me.lblcliped.TabIndex = 581
        Me.lblcliped.Text = "Open Width ? (ผ่าถุง)"
        '
        'dtpProdFinishDate
        '
        Me.dtpProdFinishDate.Checked = False
        Me.dtpProdFinishDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpProdFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProdFinishDate.Location = New System.Drawing.Point(407, 240)
        Me.dtpProdFinishDate.Name = "dtpProdFinishDate"
        Me.dtpProdFinishDate.ShowCheckBox = True
        Me.dtpProdFinishDate.Size = New System.Drawing.Size(119, 20)
        Me.dtpProdFinishDate.TabIndex = 537
        '
        'chkdyeing_pass
        '
        Me.chkdyeing_pass.AutoSize = True
        Me.chkdyeing_pass.Location = New System.Drawing.Point(407, 303)
        Me.chkdyeing_pass.Name = "chkdyeing_pass"
        Me.chkdyeing_pass.Size = New System.Drawing.Size(15, 14)
        Me.chkdyeing_pass.TabIndex = 539
        Me.chkdyeing_pass.UseVisualStyleBackColor = True
        '
        'txtdefect_loss_kg
        '
        Me.txtdefect_loss_kg.Location = New System.Drawing.Point(407, 431)
        Me.txtdefect_loss_kg.Name = "txtdefect_loss_kg"
        Me.txtdefect_loss_kg.Size = New System.Drawing.Size(119, 20)
        Me.txtdefect_loss_kg.TabIndex = 544
        '
        'lbldefect_loss_kg
        '
        Me.lbldefect_loss_kg.AutoSize = True
        Me.lbldefect_loss_kg.Location = New System.Drawing.Point(302, 433)
        Me.lbldefect_loss_kg.Name = "lbldefect_loss_kg"
        Me.lbldefect_loss_kg.Size = New System.Drawing.Size(94, 13)
        Me.lbldefect_loss_kg.TabIndex = 580
        Me.lbldefect_loss_kg.Text = "Defect Loss (Kgs.)"
        '
        'txtlab_loss_kg
        '
        Me.txtlab_loss_kg.Location = New System.Drawing.Point(407, 402)
        Me.txtlab_loss_kg.Name = "txtlab_loss_kg"
        Me.txtlab_loss_kg.Size = New System.Drawing.Size(119, 20)
        Me.txtlab_loss_kg.TabIndex = 543
        '
        'lbllab_loss_kg
        '
        Me.lbllab_loss_kg.AutoSize = True
        Me.lbllab_loss_kg.Location = New System.Drawing.Point(316, 401)
        Me.lbllab_loss_kg.Name = "lbllab_loss_kg"
        Me.lbllab_loss_kg.Size = New System.Drawing.Size(80, 13)
        Me.lbllab_loss_kg.TabIndex = 579
        Me.lbllab_loss_kg.Text = "Lab Loss (Kgs.)"
        '
        'txtdyed_loss_kg
        '
        Me.txtdyed_loss_kg.Location = New System.Drawing.Point(407, 376)
        Me.txtdyed_loss_kg.Name = "txtdyed_loss_kg"
        Me.txtdyed_loss_kg.Size = New System.Drawing.Size(119, 20)
        Me.txtdyed_loss_kg.TabIndex = 542
        '
        'lbldyed_loss_kg
        '
        Me.lbldyed_loss_kg.AutoSize = True
        Me.lbldyed_loss_kg.Location = New System.Drawing.Point(291, 374)
        Me.lbldyed_loss_kg.Name = "lbldyed_loss_kg"
        Me.lbldyed_loss_kg.Size = New System.Drawing.Size(105, 13)
        Me.lbldyed_loss_kg.TabIndex = 578
        Me.lbldyed_loss_kg.Text = "Dye Test Loss (Kgs.)"
        '
        'txtqc_loss_kg
        '
        Me.txtqc_loss_kg.Location = New System.Drawing.Point(407, 352)
        Me.txtqc_loss_kg.Name = "txtqc_loss_kg"
        Me.txtqc_loss_kg.Size = New System.Drawing.Size(119, 20)
        Me.txtqc_loss_kg.TabIndex = 541
        '
        'lblqc_loss_kg
        '
        Me.lblqc_loss_kg.AutoSize = True
        Me.lblqc_loss_kg.Location = New System.Drawing.Point(319, 353)
        Me.lblqc_loss_kg.Name = "lblqc_loss_kg"
        Me.lblqc_loss_kg.Size = New System.Drawing.Size(77, 13)
        Me.lblqc_loss_kg.TabIndex = 577
        Me.lblqc_loss_kg.Text = "QC Loss (Kgs.)"
        '
        'lbladjust_loss_kg
        '
        Me.lbladjust_loss_kg.AutoSize = True
        Me.lbladjust_loss_kg.Location = New System.Drawing.Point(296, 329)
        Me.lbladjust_loss_kg.Name = "lbladjust_loss_kg"
        Me.lbladjust_loss_kg.Size = New System.Drawing.Size(100, 13)
        Me.lbladjust_loss_kg.TabIndex = 576
        Me.lbladjust_loss_kg.Text = "Process Loss (Kgs.)"
        '
        'txtadjust_loss_kg
        '
        Me.txtadjust_loss_kg.Location = New System.Drawing.Point(407, 326)
        Me.txtadjust_loss_kg.Name = "txtadjust_loss_kg"
        Me.txtadjust_loss_kg.Size = New System.Drawing.Size(119, 20)
        Me.txtadjust_loss_kg.TabIndex = 540
        '
        'lbldyeing_pass
        '
        Me.lbldyeing_pass.AutoSize = True
        Me.lbldyeing_pass.Location = New System.Drawing.Point(320, 300)
        Me.lbldyeing_pass.Name = "lbldyeing_pass"
        Me.lbldyeing_pass.Size = New System.Drawing.Size(76, 13)
        Me.lbldyeing_pass.TabIndex = 575
        Me.lbldyeing_pass.Text = "Pass Dye Test"
        '
        'lblProdFinishTime
        '
        Me.lblProdFinishTime.AutoSize = True
        Me.lblProdFinishTime.Location = New System.Drawing.Point(270, 271)
        Me.lblProdFinishTime.Name = "lblProdFinishTime"
        Me.lblProdFinishTime.Size = New System.Drawing.Size(126, 13)
        Me.lblProdFinishTime.TabIndex = 574
        Me.lblProdFinishTime.Text = "Production Finished Time"
        '
        'lblProdFinishDate
        '
        Me.lblProdFinishDate.AutoSize = True
        Me.lblProdFinishDate.Location = New System.Drawing.Point(270, 240)
        Me.lblProdFinishDate.Name = "lblProdFinishDate"
        Me.lblProdFinishDate.Size = New System.Drawing.Size(126, 13)
        Me.lblProdFinishDate.TabIndex = 573
        Me.lblProdFinishDate.Text = "Production Finished Date"
        '
        'txtgrade_adt
        '
        Me.txtgrade_adt.Location = New System.Drawing.Point(121, 451)
        Me.txtgrade_adt.Name = "txtgrade_adt"
        Me.txtgrade_adt.Size = New System.Drawing.Size(132, 20)
        Me.txtgrade_adt.TabIndex = 531
        '
        'lblgrade_adt
        '
        Me.lblgrade_adt.AutoSize = True
        Me.lblgrade_adt.Location = New System.Drawing.Point(16, 458)
        Me.lblgrade_adt.Name = "lblgrade_adt"
        Me.lblgrade_adt.Size = New System.Drawing.Size(94, 13)
        Me.lblgrade_adt.TabIndex = 572
        Me.lblgrade_adt.Text = "Grade of Dye Test"
        '
        'txtgrade_bdt
        '
        Me.txtgrade_bdt.Location = New System.Drawing.Point(120, 415)
        Me.txtgrade_bdt.Name = "txtgrade_bdt"
        Me.txtgrade_bdt.Size = New System.Drawing.Size(132, 20)
        Me.txtgrade_bdt.TabIndex = 530
        '
        'lblgrade_bdt
        '
        Me.lblgrade_bdt.AutoSize = True
        Me.lblgrade_bdt.Location = New System.Drawing.Point(10, 422)
        Me.lblgrade_bdt.Name = "lblgrade_bdt"
        Me.lblgrade_bdt.Size = New System.Drawing.Size(100, 13)
        Me.lblgrade_bdt.TabIndex = 571
        Me.lblgrade_bdt.Text = "Grade of Inspection"
        '
        'txtlot
        '
        Me.txtlot.Location = New System.Drawing.Point(120, 383)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(132, 20)
        Me.txtlot.TabIndex = 529
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Location = New System.Drawing.Point(62, 383)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(48, 13)
        Me.lbllot.TabIndex = 570
        Me.lbllot.Text = "Yarn Set"
        '
        'txtgwth
        '
        Me.txtgwth.Location = New System.Drawing.Point(120, 357)
        Me.txtgwth.Name = "txtgwth"
        Me.txtgwth.Size = New System.Drawing.Size(132, 20)
        Me.txtgwth.TabIndex = 528
        '
        'lblgwth
        '
        Me.lblgwth.AutoSize = True
        Me.lblgwth.Location = New System.Drawing.Point(10, 354)
        Me.lblgwth.Name = "lblgwth"
        Me.lblgwth.Size = New System.Drawing.Size(100, 13)
        Me.lblgwth.TabIndex = 569
        Me.lblgwth.Text = "Greige Width (cms.)"
        '
        'txtbar_weight
        '
        Me.txtbar_weight.Location = New System.Drawing.Point(120, 322)
        Me.txtbar_weight.Name = "txtbar_weight"
        Me.txtbar_weight.Size = New System.Drawing.Size(132, 20)
        Me.txtbar_weight.TabIndex = 527
        '
        'lblbar_weight
        '
        Me.lblbar_weight.AutoSize = True
        Me.lblbar_weight.Location = New System.Drawing.Point(20, 329)
        Me.lblbar_weight.Name = "lblbar_weight"
        Me.lblbar_weight.Size = New System.Drawing.Size(90, 13)
        Me.lblbar_weight.TabIndex = 568
        Me.lblbar_weight.Text = "Bar Weight (Kgs.)"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Defect_name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Defect Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "defect_details"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Qty"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "stock_code"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Stock Code"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "mfg_production_steps_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "step_number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "step_number"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'gbSteam
        '
        Me.gbSteam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSteam.Controls.Add(Me.txtsteam_instruction)
        Me.gbSteam.Controls.Add(Me.lblsteam_instruction)
        Me.gbSteam.Location = New System.Drawing.Point(12, 153)
        Me.gbSteam.Name = "gbSteam"
        Me.gbSteam.Size = New System.Drawing.Size(1000, 76)
        Me.gbSteam.TabIndex = 567
        Me.gbSteam.TabStop = False
        '
        'txtsteam_instruction
        '
        Me.txtsteam_instruction.Location = New System.Drawing.Point(129, 19)
        Me.txtsteam_instruction.Multiline = True
        Me.txtsteam_instruction.Name = "txtsteam_instruction"
        Me.txtsteam_instruction.ReadOnly = True
        Me.txtsteam_instruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtsteam_instruction.Size = New System.Drawing.Size(853, 48)
        Me.txtsteam_instruction.TabIndex = 69
        '
        'lblsteam_instruction
        '
        Me.lblsteam_instruction.AutoSize = True
        Me.lblsteam_instruction.Location = New System.Drawing.Point(6, 22)
        Me.lblsteam_instruction.Name = "lblsteam_instruction"
        Me.lblsteam_instruction.Size = New System.Drawing.Size(89, 13)
        Me.lblsteam_instruction.TabIndex = 70
        Me.lblsteam_instruction.Text = "Steam Instruction"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1042, 25)
        Me.ToolStrip1.TabIndex = 552
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(62, 22)
        Me.btnSearch.Text = "Search"
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
        'lblsystem_lot_number
        '
        Me.lblsystem_lot_number.AutoSize = True
        Me.lblsystem_lot_number.Location = New System.Drawing.Point(22, 43)
        Me.lblsystem_lot_number.Name = "lblsystem_lot_number"
        Me.lblsystem_lot_number.Size = New System.Drawing.Size(45, 13)
        Me.lblsystem_lot_number.TabIndex = 45
        Me.lblsystem_lot_number.Text = "Roll No."
        '
        'lblcustom_lot_number
        '
        Me.lblcustom_lot_number.AutoSize = True
        Me.lblcustom_lot_number.Location = New System.Drawing.Point(38, 241)
        Me.lblcustom_lot_number.Name = "lblcustom_lot_number"
        Me.lblcustom_lot_number.Size = New System.Drawing.Size(72, 13)
        Me.lblcustom_lot_number.TabIndex = 556
        Me.lblcustom_lot_number.Text = "Fact. Roll No."
        '
        'txttran_no
        '
        Me.txttran_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttran_no.Location = New System.Drawing.Point(578, 11)
        Me.txttran_no.Name = "txttran_no"
        Me.txttran_no.ReadOnly = True
        Me.txttran_no.Size = New System.Drawing.Size(111, 20)
        Me.txttran_no.TabIndex = 311
        '
        'txtsecondary_quantity
        '
        Me.txtsecondary_quantity.Location = New System.Drawing.Point(120, 268)
        Me.txtsecondary_quantity.Name = "txtsecondary_quantity"
        Me.txtsecondary_quantity.Size = New System.Drawing.Size(132, 20)
        Me.txtsecondary_quantity.TabIndex = 525
        '
        'lblsecondary_quantity
        '
        Me.lblsecondary_quantity.AutoSize = True
        Me.lblsecondary_quantity.Location = New System.Drawing.Point(41, 271)
        Me.lblsecondary_quantity.Name = "lblsecondary_quantity"
        Me.lblsecondary_quantity.Size = New System.Drawing.Size(69, 13)
        Me.lblsecondary_quantity.TabIndex = 555
        Me.lblsecondary_quantity.Text = "Length (Mts.)"
        '
        'txtprimary_quantity
        '
        Me.txtprimary_quantity.Location = New System.Drawing.Point(120, 296)
        Me.txtprimary_quantity.Name = "txtprimary_quantity"
        Me.txtprimary_quantity.Size = New System.Drawing.Size(132, 20)
        Me.txtprimary_quantity.TabIndex = 526
        '
        'lbltran_no
        '
        Me.lbltran_no.AutoSize = True
        Me.lbltran_no.Location = New System.Drawing.Point(474, 14)
        Me.lbltran_no.Name = "lbltran_no"
        Me.lbltran_no.Size = New System.Drawing.Size(76, 13)
        Me.lbltran_no.TabIndex = 312
        Me.lbltran_no.Text = "Document No."
        '
        'txtBOM
        '
        Me.txtBOM.Location = New System.Drawing.Point(336, 37)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.ReadOnly = True
        Me.txtBOM.Size = New System.Drawing.Size(131, 20)
        Me.txtBOM.TabIndex = 74
        '
        'lblkg
        '
        Me.lblkg.AutoSize = True
        Me.lblkg.Location = New System.Drawing.Point(39, 296)
        Me.lblkg.Name = "lblkg"
        Me.lblkg.Size = New System.Drawing.Size(71, 13)
        Me.lblkg.TabIndex = 554
        Me.lblkg.Text = "Weight (Kgs.)"
        '
        'txtlot_grade
        '
        Me.txtlot_grade.Location = New System.Drawing.Point(627, 381)
        Me.txtlot_grade.Name = "txtlot_grade"
        Me.txtlot_grade.ReadOnly = True
        Me.txtlot_grade.Size = New System.Drawing.Size(132, 20)
        Me.txtlot_grade.TabIndex = 550
        '
        'lbltran_dt
        '
        Me.lbltran_dt.AutoSize = True
        Me.lbltran_dt.Location = New System.Drawing.Point(473, 40)
        Me.lbltran_dt.Name = "lbltran_dt"
        Me.lbltran_dt.Size = New System.Drawing.Size(82, 13)
        Me.lbltran_dt.TabIndex = 313
        Me.lbltran_dt.Text = "Document Date"
        '
        'dtptran_dt
        '
        Me.dtptran_dt.Checked = False
        Me.dtptran_dt.CustomFormat = "dd/MM/yyyy"
        Me.dtptran_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptran_dt.Location = New System.Drawing.Point(578, 37)
        Me.dtptran_dt.Name = "dtptran_dt"
        Me.dtptran_dt.ShowCheckBox = True
        Me.dtptran_dt.Size = New System.Drawing.Size(111, 20)
        Me.dtptran_dt.TabIndex = 310
        '
        'cbomfg_production_steps_id
        '
        Me.cbomfg_production_steps_id.FormattingEnabled = True
        Me.cbomfg_production_steps_id.Location = New System.Drawing.Point(103, 65)
        Me.cbomfg_production_steps_id.Name = "cbomfg_production_steps_id"
        Me.cbomfg_production_steps_id.Size = New System.Drawing.Size(163, 21)
        Me.cbomfg_production_steps_id.TabIndex = 309
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(575, 385)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(39, 13)
        Me.lblGrade.TabIndex = 553
        Me.lblGrade.Text = "Grade:"
        '
        'cbomcno
        '
        Me.cbomcno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomcno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomcno.FormattingEnabled = True
        Me.cbomcno.Location = New System.Drawing.Point(102, 40)
        Me.cbomcno.Name = "cbomcno"
        Me.cbomcno.Size = New System.Drawing.Size(162, 21)
        Me.cbomcno.TabIndex = 78
        '
        'lblynchgcd
        '
        Me.lblynchgcd.AutoSize = True
        Me.lblynchgcd.Location = New System.Drawing.Point(290, 40)
        Me.lblynchgcd.Name = "lblynchgcd"
        Me.lblynchgcd.Size = New System.Drawing.Size(31, 13)
        Me.lblynchgcd.TabIndex = 308
        Me.lblynchgcd.Text = "BOM"
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Location = New System.Drawing.Point(39, 65)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(35, 13)
        Me.lblStep.TabIndex = 45
        Me.lblStep.Text = "Step :"
        '
        'lblmcno
        '
        Me.lblmcno.AutoSize = True
        Me.lblmcno.Location = New System.Drawing.Point(29, 37)
        Me.lblmcno.Name = "lblmcno"
        Me.lblmcno.Size = New System.Drawing.Size(51, 13)
        Me.lblmcno.TabIndex = 58
        Me.lblmcno.Text = "Machine:"
        '
        'txtinventory_item_code
        '
        Me.txtinventory_item_code.Location = New System.Drawing.Point(336, 14)
        Me.txtinventory_item_code.Name = "txtinventory_item_code"
        Me.txtinventory_item_code.ReadOnly = True
        Me.txtinventory_item_code.Size = New System.Drawing.Size(131, 20)
        Me.txtinventory_item_code.TabIndex = 48
        '
        'txtsystem_lot_number
        '
        Me.txtsystem_lot_number.Location = New System.Drawing.Point(129, 43)
        Me.txtsystem_lot_number.MaxLength = 8
        Me.txtsystem_lot_number.Name = "txtsystem_lot_number"
        Me.txtsystem_lot_number.Size = New System.Drawing.Size(132, 20)
        Me.txtsystem_lot_number.TabIndex = 1
        '
        'txtproduction_order_no
        '
        Me.txtproduction_order_no.Location = New System.Drawing.Point(102, 17)
        Me.txtproduction_order_no.Name = "txtproduction_order_no"
        Me.txtproduction_order_no.ReadOnly = True
        Me.txtproduction_order_no.Size = New System.Drawing.Size(162, 20)
        Me.txtproduction_order_no.TabIndex = 44
        '
        'cbooperator
        '
        Me.cbooperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbooperator.Enabled = False
        Me.cbooperator.FormattingEnabled = True
        Me.cbooperator.Location = New System.Drawing.Point(336, 63)
        Me.cbooperator.Name = "cbooperator"
        Me.cbooperator.Size = New System.Drawing.Size(131, 21)
        Me.cbooperator.TabIndex = 77
        '
        'lblPROD
        '
        Me.lblPROD.AutoSize = True
        Me.lblPROD.Location = New System.Drawing.Point(22, 14)
        Me.lblPROD.Name = "lblPROD"
        Me.lblPROD.Size = New System.Drawing.Size(58, 13)
        Me.lblPROD.TabIndex = 43
        Me.lblPROD.Text = "PROD No:"
        '
        'txtcustom_lot_number
        '
        Me.txtcustom_lot_number.Location = New System.Drawing.Point(120, 240)
        Me.txtcustom_lot_number.Name = "txtcustom_lot_number"
        Me.txtcustom_lot_number.Size = New System.Drawing.Size(132, 20)
        Me.txtcustom_lot_number.TabIndex = 524
        '
        'lblDesignNo
        '
        Me.lblDesignNo.AutoSize = True
        Me.lblDesignNo.Location = New System.Drawing.Point(270, 17)
        Me.lblDesignNo.Name = "lblDesignNo"
        Me.lblDesignNo.Size = New System.Drawing.Size(60, 13)
        Me.lblDesignNo.TabIndex = 47
        Me.lblDesignNo.Text = "Design No:"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(121, 542)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_subinventory.TabIndex = 534
        '
        'gbSystemRoll
        '
        Me.gbSystemRoll.Controls.Add(Me.lblsystem_lot_number)
        Me.gbSystemRoll.Controls.Add(Me.txtsystem_lot_number)
        Me.gbSystemRoll.Location = New System.Drawing.Point(12, 55)
        Me.gbSystemRoll.Name = "gbSystemRoll"
        Me.gbSystemRoll.Size = New System.Drawing.Size(269, 92)
        Me.gbSystemRoll.TabIndex = 523
        Me.gbSystemRoll.TabStop = False
        Me.gbSystemRoll.Text = "Scan Barcode"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(548, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 566
        Me.Label1.Text = "Steam Time:"
        '
        'lblsteam_condition
        '
        Me.lblsteam_condition.AutoSize = True
        Me.lblsteam_condition.Location = New System.Drawing.Point(309, 463)
        Me.lblsteam_condition.Name = "lblsteam_condition"
        Me.lblsteam_condition.Size = New System.Drawing.Size(87, 13)
        Me.lblsteam_condition.TabIndex = 565
        Me.lblsteam_condition.Text = "Steam Condition:"
        '
        'txtsteam_condition
        '
        Me.txtsteam_condition.Location = New System.Drawing.Point(407, 466)
        Me.txtsteam_condition.Name = "txtsteam_condition"
        Me.txtsteam_condition.Size = New System.Drawing.Size(119, 20)
        Me.txtsteam_condition.TabIndex = 545
        '
        'lblsteam_date
        '
        Me.lblsteam_date.AutoSize = True
        Me.lblsteam_date.Location = New System.Drawing.Point(548, 241)
        Me.lblsteam_date.Name = "lblsteam_date"
        Me.lblsteam_date.Size = New System.Drawing.Size(66, 13)
        Me.lblsteam_date.TabIndex = 564
        Me.lblsteam_date.Text = "Steam Date:"
        '
        'dtpsteam_date
        '
        Me.dtpsteam_date.Checked = False
        Me.dtpsteam_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpsteam_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsteam_date.Location = New System.Drawing.Point(627, 241)
        Me.dtpsteam_date.Name = "dtpsteam_date"
        Me.dtpsteam_date.ShowCheckBox = True
        Me.dtpsteam_date.Size = New System.Drawing.Size(161, 20)
        Me.dtpsteam_date.TabIndex = 547
        '
        'dtpsteam_time
        '
        Me.dtpsteam_time.Checked = False
        Me.dtpsteam_time.CustomFormat = "HH:mm"
        Me.dtpsteam_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsteam_time.Location = New System.Drawing.Point(627, 267)
        Me.dtpsteam_time.Name = "dtpsteam_time"
        Me.dtpsteam_time.ShowCheckBox = True
        Me.dtpsteam_time.ShowUpDown = True
        Me.dtpsteam_time.Size = New System.Drawing.Size(161, 20)
        Me.dtpsteam_time.TabIndex = 548
        Me.dtpsteam_time.Value = New Date(2016, 6, 29, 10, 12, 0, 0)
        '
        'gbProduction
        '
        Me.gbProduction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbProduction.Controls.Add(Me.lbltran_no)
        Me.gbProduction.Controls.Add(Me.txttran_no)
        Me.gbProduction.Controls.Add(Me.lbltran_dt)
        Me.gbProduction.Controls.Add(Me.dtptran_dt)
        Me.gbProduction.Controls.Add(Me.cbomfg_production_steps_id)
        Me.gbProduction.Controls.Add(Me.cbomcno)
        Me.gbProduction.Controls.Add(Me.txtBOM)
        Me.gbProduction.Controls.Add(Me.lblynchgcd)
        Me.gbProduction.Controls.Add(Me.txtproduction_order_no)
        Me.gbProduction.Controls.Add(Me.txtinventory_item_code)
        Me.gbProduction.Controls.Add(Me.cbooperator)
        Me.gbProduction.Controls.Add(Me.lblPROD)
        Me.gbProduction.Controls.Add(Me.lblmcno)
        Me.gbProduction.Controls.Add(Me.lblDesignNo)
        Me.gbProduction.Controls.Add(Me.lblStep)
        Me.gbProduction.Controls.Add(Me.lbloperator)
        Me.gbProduction.Location = New System.Drawing.Point(301, 55)
        Me.gbProduction.Name = "gbProduction"
        Me.gbProduction.Size = New System.Drawing.Size(711, 92)
        Me.gbProduction.TabIndex = 563
        Me.gbProduction.TabStop = False
        Me.gbProduction.Text = "Production Information"
        '
        'lbloperator
        '
        Me.lbloperator.AutoSize = True
        Me.lbloperator.Location = New System.Drawing.Point(279, 69)
        Me.lbloperator.Name = "lbloperator"
        Me.lbloperator.Size = New System.Drawing.Size(51, 13)
        Me.lbloperator.TabIndex = 67
        Me.lbloperator.Text = "Operator:"
        '
        'btnSave_2
        '
        Me.btnSave_2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSave_2.Location = New System.Drawing.Point(35, 622)
        Me.btnSave_2.Name = "btnSave_2"
        Me.btnSave_2.Size = New System.Drawing.Size(75, 23)
        Me.btnSave_2.TabIndex = 562
        Me.btnSave_2.Text = "Save"
        Me.btnSave_2.UseVisualStyleBackColor = True
        '
        'cbomtl_location
        '
        Me.cbomtl_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_location.FormattingEnabled = True
        Me.cbomtl_location.Location = New System.Drawing.Point(120, 569)
        Me.cbomtl_location.Name = "cbomtl_location"
        Me.cbomtl_location.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_location.TabIndex = 535
        '
        'lblmtl_location
        '
        Me.lblmtl_location.AutoSize = True
        Me.lblmtl_location.Location = New System.Drawing.Point(59, 574)
        Me.lblmtl_location.Name = "lblmtl_location"
        Me.lblmtl_location.Size = New System.Drawing.Size(51, 13)
        Me.lblmtl_location.TabIndex = 559
        Me.lblmtl_location.Text = "Location:"
        '
        'txtqc_remarks
        '
        Me.txtqc_remarks.Location = New System.Drawing.Point(407, 513)
        Me.txtqc_remarks.Multiline = True
        Me.txtqc_remarks.Name = "txtqc_remarks"
        Me.txtqc_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtqc_remarks.Size = New System.Drawing.Size(117, 92)
        Me.txtqc_remarks.TabIndex = 546
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(45, 520)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(65, 13)
        Me.lblmtl_warehouse_id.TabIndex = 558
        Me.lblmtl_warehouse_id.Text = "Warehouse:"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(120, 515)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(133, 21)
        Me.cbomtl_warehouse.TabIndex = 533
        '
        'txtwork_shift
        '
        Me.txtwork_shift.Location = New System.Drawing.Point(120, 598)
        Me.txtwork_shift.Name = "txtwork_shift"
        Me.txtwork_shift.Size = New System.Drawing.Size(132, 20)
        Me.txtwork_shift.TabIndex = 536
        '
        'lblwork_shift
        '
        Me.lblwork_shift.AutoSize = True
        Me.lblwork_shift.Location = New System.Drawing.Point(79, 603)
        Me.lblwork_shift.Name = "lblwork_shift"
        Me.lblwork_shift.Size = New System.Drawing.Size(31, 13)
        Me.lblwork_shift.TabIndex = 560
        Me.lblwork_shift.Text = "Shift:"
        '
        'lblqc_remarks
        '
        Me.lblqc_remarks.AutoSize = True
        Me.lblqc_remarks.Location = New System.Drawing.Point(321, 508)
        Me.lblqc_remarks.Name = "lblqc_remarks"
        Me.lblqc_remarks.Size = New System.Drawing.Size(75, 13)
        Me.lblqc_remarks.TabIndex = 557
        Me.lblqc_remarks.Text = "Q/C Remarks:"
        '
        'frmStockGIN_KOFromProductionLots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 651)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblrpm)
        Me.Controls.Add(Me.lblcounter_per_roll)
        Me.Controls.Add(Me.txtrpm)
        Me.Controls.Add(Me.txtcounter_per_roll)
        Me.Controls.Add(Me.GbDefect)
        Me.Controls.Add(Me.btnGreigeIn)
        Me.Controls.Add(Me.dtpProdFinishTime)
        Me.Controls.Add(Me.chkcliped)
        Me.Controls.Add(Me.lblcliped)
        Me.Controls.Add(Me.dtpProdFinishDate)
        Me.Controls.Add(Me.chkdyeing_pass)
        Me.Controls.Add(Me.txtdefect_loss_kg)
        Me.Controls.Add(Me.lbldefect_loss_kg)
        Me.Controls.Add(Me.txtlab_loss_kg)
        Me.Controls.Add(Me.lbllab_loss_kg)
        Me.Controls.Add(Me.txtdyed_loss_kg)
        Me.Controls.Add(Me.lbldyed_loss_kg)
        Me.Controls.Add(Me.txtqc_loss_kg)
        Me.Controls.Add(Me.lblqc_loss_kg)
        Me.Controls.Add(Me.lbladjust_loss_kg)
        Me.Controls.Add(Me.txtadjust_loss_kg)
        Me.Controls.Add(Me.lbldyeing_pass)
        Me.Controls.Add(Me.lblProdFinishTime)
        Me.Controls.Add(Me.lblProdFinishDate)
        Me.Controls.Add(Me.txtgrade_adt)
        Me.Controls.Add(Me.lblgrade_adt)
        Me.Controls.Add(Me.txtgrade_bdt)
        Me.Controls.Add(Me.lblgrade_bdt)
        Me.Controls.Add(Me.txtlot)
        Me.Controls.Add(Me.lbllot)
        Me.Controls.Add(Me.txtgwth)
        Me.Controls.Add(Me.lblgwth)
        Me.Controls.Add(Me.txtbar_weight)
        Me.Controls.Add(Me.lblbar_weight)
        Me.Controls.Add(Me.gbSteam)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblcustom_lot_number)
        Me.Controls.Add(Me.txtsecondary_quantity)
        Me.Controls.Add(Me.lblsecondary_quantity)
        Me.Controls.Add(Me.txtprimary_quantity)
        Me.Controls.Add(Me.lblkg)
        Me.Controls.Add(Me.txtlot_grade)
        Me.Controls.Add(Me.lblGrade)
        Me.Controls.Add(Me.txtcustom_lot_number)
        Me.Controls.Add(Me.cbomtl_subinventory)
        Me.Controls.Add(Me.gbSystemRoll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblsteam_condition)
        Me.Controls.Add(Me.txtsteam_condition)
        Me.Controls.Add(Me.lblsteam_date)
        Me.Controls.Add(Me.dtpsteam_date)
        Me.Controls.Add(Me.dtpsteam_time)
        Me.Controls.Add(Me.gbProduction)
        Me.Controls.Add(Me.btnSave_2)
        Me.Controls.Add(Me.cbomtl_location)
        Me.Controls.Add(Me.lblmtl_location)
        Me.Controls.Add(Me.txtqc_remarks)
        Me.Controls.Add(Me.lblmtl_warehouse_id)
        Me.Controls.Add(Me.cbomtl_warehouse)
        Me.Controls.Add(Me.txtwork_shift)
        Me.Controls.Add(Me.lblwork_shift)
        Me.Controls.Add(Me.lblqc_remarks)
        Me.Name = "frmStockGIN_KOFromProductionLots"
        Me.Text = "GIN Knitting From Production Lots"
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDefect.ResumeLayout(False)
        Me.GbDefect.PerformLayout()
        Me.gbSteam.ResumeLayout(False)
        Me.gbSteam.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbSystemRoll.ResumeLayout(False)
        Me.gbSystemRoll.PerformLayout()
        Me.gbProduction.ResumeLayout(False)
        Me.gbProduction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblrpm As System.Windows.Forms.Label
    Friend WithEvents lblcounter_per_roll As System.Windows.Forms.Label
    Friend WithEvents txtrpm As System.Windows.Forms.TextBox
    Friend WithEvents txtcounter_per_roll As System.Windows.Forms.TextBox
    Friend WithEvents grdDefect As System.Windows.Forms.DataGridView
    Friend WithEvents GbDefect As System.Windows.Forms.GroupBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents lbldefect_details As System.Windows.Forms.Label
    Friend WithEvents txtdefect_details As System.Windows.Forms.TextBox
    Friend WithEvents lblDefect_code As System.Windows.Forms.Label
    Friend WithEvents cbodefect_code As System.Windows.Forms.ComboBox
    Friend WithEvents btnGreigeIn As System.Windows.Forms.Button
    Friend WithEvents dtpProdFinishTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkcliped As System.Windows.Forms.CheckBox
    Friend WithEvents lblcliped As System.Windows.Forms.Label
    Friend WithEvents dtpProdFinishDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkdyeing_pass As System.Windows.Forms.CheckBox
    Friend WithEvents txtdefect_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldefect_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtlab_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbllab_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtdyed_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldyed_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtqc_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lblqc_loss_kg As System.Windows.Forms.Label
    Friend WithEvents lbladjust_loss_kg As System.Windows.Forms.Label
    Friend WithEvents txtadjust_loss_kg As System.Windows.Forms.TextBox
    Friend WithEvents lbldyeing_pass As System.Windows.Forms.Label
    Friend WithEvents lblProdFinishTime As System.Windows.Forms.Label
    Friend WithEvents lblProdFinishDate As System.Windows.Forms.Label
    Friend WithEvents txtgrade_adt As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade_adt As System.Windows.Forms.Label
    Friend WithEvents txtgrade_bdt As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade_bdt As System.Windows.Forms.Label
    Friend WithEvents txtlot As System.Windows.Forms.TextBox
    Friend WithEvents lbllot As System.Windows.Forms.Label
    Friend WithEvents txtgwth As System.Windows.Forms.TextBox
    Friend WithEvents lblgwth As System.Windows.Forms.Label
    Friend WithEvents txtbar_weight As System.Windows.Forms.TextBox
    Friend WithEvents lblbar_weight As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gbSteam As System.Windows.Forms.GroupBox
    Friend WithEvents txtsteam_instruction As System.Windows.Forms.TextBox
    Friend WithEvents lblsteam_instruction As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblsystem_lot_number As System.Windows.Forms.Label
    Friend WithEvents lblcustom_lot_number As System.Windows.Forms.Label
    Friend WithEvents txttran_no As System.Windows.Forms.TextBox
    Friend WithEvents txtsecondary_quantity As System.Windows.Forms.TextBox
    Friend WithEvents lblsecondary_quantity As System.Windows.Forms.Label
    Friend WithEvents txtprimary_quantity As System.Windows.Forms.TextBox
    Friend WithEvents lbltran_no As System.Windows.Forms.Label
    Friend WithEvents txtBOM As System.Windows.Forms.TextBox
    Friend WithEvents lblkg As System.Windows.Forms.Label
    Friend WithEvents txtlot_grade As System.Windows.Forms.TextBox
    Friend WithEvents lbltran_dt As System.Windows.Forms.Label
    Friend WithEvents dtptran_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbomfg_production_steps_id As System.Windows.Forms.ComboBox
    Friend WithEvents lblGrade As System.Windows.Forms.Label
    Friend WithEvents cbomcno As System.Windows.Forms.ComboBox
    Friend WithEvents lblynchgcd As System.Windows.Forms.Label
    Friend WithEvents lblStep As System.Windows.Forms.Label
    Friend WithEvents lblmcno As System.Windows.Forms.Label
    Friend WithEvents txtinventory_item_code As System.Windows.Forms.TextBox
    Friend WithEvents txtsystem_lot_number As System.Windows.Forms.TextBox
    Friend WithEvents txtproduction_order_no As System.Windows.Forms.TextBox
    Friend WithEvents cbooperator As System.Windows.Forms.ComboBox
    Friend WithEvents lblPROD As System.Windows.Forms.Label
    Friend WithEvents txtcustom_lot_number As System.Windows.Forms.TextBox
    Friend WithEvents lblDesignNo As System.Windows.Forms.Label
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents gbSystemRoll As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblsteam_condition As System.Windows.Forms.Label
    Friend WithEvents txtsteam_condition As System.Windows.Forms.TextBox
    Friend WithEvents lblsteam_date As System.Windows.Forms.Label
    Friend WithEvents dtpsteam_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpsteam_time As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbProduction As System.Windows.Forms.GroupBox
    Friend WithEvents lbloperator As System.Windows.Forms.Label
    Friend WithEvents btnSave_2 As System.Windows.Forms.Button
    Friend WithEvents cbomtl_location As System.Windows.Forms.ComboBox
    Friend WithEvents lblmtl_location As System.Windows.Forms.Label
    Friend WithEvents txtqc_remarks As System.Windows.Forms.TextBox
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents txtwork_shift As System.Windows.Forms.TextBox
    Friend WithEvents lblwork_shift As System.Windows.Forms.Label
    Friend WithEvents lblqc_remarks As System.Windows.Forms.Label
    Friend WithEvents ColrollNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDefectCode As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ColDefectName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColdefectDetails As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColstockCode As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
