<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperationKnitting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperationKnitting))
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbodefect_code = New System.Windows.Forms.ComboBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblDefect_code = New System.Windows.Forms.Label()
        Me.lbldefect_details = New System.Windows.Forms.Label()
        Me.txtdefect_details = New System.Windows.Forms.TextBox()
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
        Me.dtpsteam_date = New System.Windows.Forms.DateTimePicker()
        Me.lblsteam_instruction = New System.Windows.Forms.Label()
        Me.lblsteam_date = New System.Windows.Forms.Label()
        Me.dtpsteam_time = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtsteam_condition = New System.Windows.Forms.TextBox()
        Me.lblsteam_condition = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.lblsystem_lot_number = New System.Windows.Forms.Label()
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
        Me.gbProduction = New System.Windows.Forms.GroupBox()
        Me.lbloperator = New System.Windows.Forms.Label()
        Me.cbomtl_location = New System.Windows.Forms.ComboBox()
        Me.lblmtl_location = New System.Windows.Forms.Label()
        Me.txtqc_remarks = New System.Windows.Forms.TextBox()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.txtwork_shift = New System.Windows.Forms.TextBox()
        Me.lblwork_shift = New System.Windows.Forms.Label()
        Me.lblqc_remarks = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFactoryRollGMKFomat = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkGMK = New System.Windows.Forms.RadioButton()
        Me.chkEsc = New System.Windows.Forms.RadioButton()
        Me.btnGreigeIn = New System.Windows.Forms.Button()
        Me.btnSave_2 = New System.Windows.Forms.Button()
        Me.GbGINDocuctments = New System.Windows.Forms.GroupBox()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbDefect.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbSteam.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbSystemRoll.SuspendLayout()
        Me.gbProduction.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GbGINDocuctments.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 586
        Me.Label2.Text = "Sub Inventory"
        '
        'lblrpm
        '
        Me.lblrpm.AutoSize = True
        Me.lblrpm.Location = New System.Drawing.Point(411, 301)
        Me.lblrpm.Name = "lblrpm"
        Me.lblrpm.Size = New System.Drawing.Size(30, 13)
        Me.lblrpm.TabIndex = 585
        Me.lblrpm.Text = "RPM"
        '
        'lblcounter_per_roll
        '
        Me.lblcounter_per_roll.AutoSize = True
        Me.lblcounter_per_roll.Location = New System.Drawing.Point(359, 273)
        Me.lblcounter_per_roll.Name = "lblcounter_per_roll"
        Me.lblcounter_per_roll.Size = New System.Drawing.Size(82, 13)
        Me.lblcounter_per_roll.TabIndex = 584
        Me.lblcounter_per_roll.Text = "Counter / Roll."
        '
        'txtrpm
        '
        Me.txtrpm.Location = New System.Drawing.Point(457, 298)
        Me.txtrpm.Name = "txtrpm"
        Me.txtrpm.Size = New System.Drawing.Size(119, 22)
        Me.txtrpm.TabIndex = 25
        '
        'txtcounter_per_roll
        '
        Me.txtcounter_per_roll.Location = New System.Drawing.Point(457, 268)
        Me.txtcounter_per_roll.Name = "txtcounter_per_roll"
        Me.txtcounter_per_roll.Size = New System.Drawing.Size(119, 22)
        Me.txtcounter_per_roll.TabIndex = 24
        '
        'grdDefect
        '
        Me.grdDefect.AllowUserToAddRows = False
        Me.grdDefect.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDefect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColrollNo, Me.ColDefectCode, Me.ColDefectName, Me.ColdefectDetails, Me.ColstockCode})
        Me.grdDefect.Location = New System.Drawing.Point(11, 28)
        Me.grdDefect.Name = "grdDefect"
        Me.grdDefect.Size = New System.Drawing.Size(269, 109)
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
        Me.GbDefect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbDefect.Controls.Add(Me.GroupBox3)
        Me.GbDefect.Controls.Add(Me.grdDefect)
        Me.GbDefect.Location = New System.Drawing.Point(610, 126)
        Me.GbDefect.Name = "GbDefect"
        Me.GbDefect.Size = New System.Drawing.Size(531, 244)
        Me.GbDefect.TabIndex = 583
        Me.GbDefect.TabStop = False
        Me.GbDefect.Text = "Defect Detail"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbodefect_code)
        Me.GroupBox3.Controls.Add(Me.btnApply)
        Me.GroupBox3.Controls.Add(Me.lblDefect_code)
        Me.GroupBox3.Controls.Add(Me.lbldefect_details)
        Me.GroupBox3.Controls.Add(Me.txtdefect_details)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 145)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(502, 85)
        Me.GroupBox3.TabIndex = 438
        Me.GroupBox3.TabStop = False
        '
        'cbodefect_code
        '
        Me.cbodefect_code.FormattingEnabled = True
        Me.cbodefect_code.Location = New System.Drawing.Point(95, 18)
        Me.cbodefect_code.Name = "cbodefect_code"
        Me.cbodefect_code.Size = New System.Drawing.Size(353, 21)
        Me.cbodefect_code.TabIndex = 27
        '
        'btnApply
        '
        Me.btnApply.Image = Global.ProductionSystem.My.Resources.Resources.ApplyCodeChanges_16x
        Me.btnApply.Location = New System.Drawing.Point(178, 45)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(68, 31)
        Me.btnApply.TabIndex = 437
        Me.btnApply.Text = "Apply"
        Me.btnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'lblDefect_code
        '
        Me.lblDefect_code.AutoSize = True
        Me.lblDefect_code.Location = New System.Drawing.Point(15, 21)
        Me.lblDefect_code.Name = "lblDefect_code"
        Me.lblDefect_code.Size = New System.Drawing.Size(70, 13)
        Me.lblDefect_code.TabIndex = 434
        Me.lblDefect_code.Text = "Defect Code"
        '
        'lbldefect_details
        '
        Me.lbldefect_details.AutoSize = True
        Me.lbldefect_details.Location = New System.Drawing.Point(64, 54)
        Me.lbldefect_details.Name = "lbldefect_details"
        Me.lbldefect_details.Size = New System.Drawing.Size(24, 13)
        Me.lbldefect_details.TabIndex = 436
        Me.lbldefect_details.Text = "Qty"
        '
        'txtdefect_details
        '
        Me.txtdefect_details.Location = New System.Drawing.Point(95, 52)
        Me.txtdefect_details.Name = "txtdefect_details"
        Me.txtdefect_details.Size = New System.Drawing.Size(41, 22)
        Me.txtdefect_details.TabIndex = 28
        '
        'dtpProdFinishTime
        '
        Me.dtpProdFinishTime.Checked = False
        Me.dtpProdFinishTime.CustomFormat = "HH:mm"
        Me.dtpProdFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProdFinishTime.Location = New System.Drawing.Point(457, 62)
        Me.dtpProdFinishTime.Name = "dtpProdFinishTime"
        Me.dtpProdFinishTime.ShowCheckBox = True
        Me.dtpProdFinishTime.ShowUpDown = True
        Me.dtpProdFinishTime.Size = New System.Drawing.Size(119, 22)
        Me.dtpProdFinishTime.TabIndex = 17
        Me.dtpProdFinishTime.Value = New Date(2016, 6, 29, 10, 12, 0, 0)
        '
        'chkcliped
        '
        Me.chkcliped.AutoSize = True
        Me.chkcliped.Location = New System.Drawing.Point(141, 328)
        Me.chkcliped.Name = "chkcliped"
        Me.chkcliped.Size = New System.Drawing.Size(15, 14)
        Me.chkcliped.TabIndex = 11
        Me.chkcliped.UseVisualStyleBackColor = True
        '
        'lblcliped
        '
        Me.lblcliped.AutoSize = True
        Me.lblcliped.Location = New System.Drawing.Point(19, 329)
        Me.lblcliped.Name = "lblcliped"
        Me.lblcliped.Size = New System.Drawing.Size(110, 13)
        Me.lblcliped.TabIndex = 581
        Me.lblcliped.Text = "Open Width ? (ผ่าถุง)"
        '
        'dtpProdFinishDate
        '
        Me.dtpProdFinishDate.Checked = False
        Me.dtpProdFinishDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpProdFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpProdFinishDate.Location = New System.Drawing.Point(457, 32)
        Me.dtpProdFinishDate.Name = "dtpProdFinishDate"
        Me.dtpProdFinishDate.ShowCheckBox = True
        Me.dtpProdFinishDate.Size = New System.Drawing.Size(119, 22)
        Me.dtpProdFinishDate.TabIndex = 16
        '
        'chkdyeing_pass
        '
        Me.chkdyeing_pass.AutoSize = True
        Me.chkdyeing_pass.Location = New System.Drawing.Point(457, 99)
        Me.chkdyeing_pass.Name = "chkdyeing_pass"
        Me.chkdyeing_pass.Size = New System.Drawing.Size(15, 14)
        Me.chkdyeing_pass.TabIndex = 18
        Me.chkdyeing_pass.UseVisualStyleBackColor = True
        '
        'txtdefect_loss_kg
        '
        Me.txtdefect_loss_kg.Location = New System.Drawing.Point(457, 239)
        Me.txtdefect_loss_kg.Name = "txtdefect_loss_kg"
        Me.txtdefect_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtdefect_loss_kg.TabIndex = 23
        '
        'lbldefect_loss_kg
        '
        Me.lbldefect_loss_kg.AutoSize = True
        Me.lbldefect_loss_kg.Location = New System.Drawing.Point(346, 243)
        Me.lbldefect_loss_kg.Name = "lbldefect_loss_kg"
        Me.lbldefect_loss_kg.Size = New System.Drawing.Size(95, 13)
        Me.lbldefect_loss_kg.TabIndex = 580
        Me.lbldefect_loss_kg.Text = "Defect Loss (Kgs.)"
        '
        'txtlab_loss_kg
        '
        Me.txtlab_loss_kg.Location = New System.Drawing.Point(457, 211)
        Me.txtlab_loss_kg.Name = "txtlab_loss_kg"
        Me.txtlab_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtlab_loss_kg.TabIndex = 22
        '
        'lbllab_loss_kg
        '
        Me.lbllab_loss_kg.AutoSize = True
        Me.lbllab_loss_kg.Location = New System.Drawing.Point(361, 215)
        Me.lbllab_loss_kg.Name = "lbllab_loss_kg"
        Me.lbllab_loss_kg.Size = New System.Drawing.Size(80, 13)
        Me.lbllab_loss_kg.TabIndex = 579
        Me.lbllab_loss_kg.Text = "Lab Loss (Kgs.)"
        '
        'txtdyed_loss_kg
        '
        Me.txtdyed_loss_kg.Location = New System.Drawing.Point(457, 183)
        Me.txtdyed_loss_kg.Name = "txtdyed_loss_kg"
        Me.txtdyed_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtdyed_loss_kg.TabIndex = 21
        '
        'lbldyed_loss_kg
        '
        Me.lbldyed_loss_kg.AutoSize = True
        Me.lbldyed_loss_kg.Location = New System.Drawing.Point(337, 186)
        Me.lbldyed_loss_kg.Name = "lbldyed_loss_kg"
        Me.lbldyed_loss_kg.Size = New System.Drawing.Size(104, 13)
        Me.lbldyed_loss_kg.TabIndex = 578
        Me.lbldyed_loss_kg.Text = "Dye Test Loss (Kgs.)"
        '
        'txtqc_loss_kg
        '
        Me.txtqc_loss_kg.Location = New System.Drawing.Point(457, 155)
        Me.txtqc_loss_kg.Name = "txtqc_loss_kg"
        Me.txtqc_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtqc_loss_kg.TabIndex = 20
        '
        'lblqc_loss_kg
        '
        Me.lblqc_loss_kg.AutoSize = True
        Me.lblqc_loss_kg.Location = New System.Drawing.Point(364, 158)
        Me.lblqc_loss_kg.Name = "lblqc_loss_kg"
        Me.lblqc_loss_kg.Size = New System.Drawing.Size(77, 13)
        Me.lblqc_loss_kg.TabIndex = 577
        Me.lblqc_loss_kg.Text = "QC Loss (Kgs.)"
        '
        'lbladjust_loss_kg
        '
        Me.lbladjust_loss_kg.AutoSize = True
        Me.lbladjust_loss_kg.Location = New System.Drawing.Point(341, 131)
        Me.lbladjust_loss_kg.Name = "lbladjust_loss_kg"
        Me.lbladjust_loss_kg.Size = New System.Drawing.Size(100, 13)
        Me.lbladjust_loss_kg.TabIndex = 576
        Me.lbladjust_loss_kg.Text = "Process Loss (Kgs.)"
        '
        'txtadjust_loss_kg
        '
        Me.txtadjust_loss_kg.Location = New System.Drawing.Point(457, 127)
        Me.txtadjust_loss_kg.Name = "txtadjust_loss_kg"
        Me.txtadjust_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtadjust_loss_kg.TabIndex = 19
        '
        'lbldyeing_pass
        '
        Me.lbldyeing_pass.AutoSize = True
        Me.lbldyeing_pass.Location = New System.Drawing.Point(367, 102)
        Me.lbldyeing_pass.Name = "lbldyeing_pass"
        Me.lbldyeing_pass.Size = New System.Drawing.Size(74, 13)
        Me.lbldyeing_pass.TabIndex = 575
        Me.lbldyeing_pass.Text = "Pass Dye Test"
        '
        'lblProdFinishTime
        '
        Me.lblProdFinishTime.AutoSize = True
        Me.lblProdFinishTime.Location = New System.Drawing.Point(304, 66)
        Me.lblProdFinishTime.Name = "lblProdFinishTime"
        Me.lblProdFinishTime.Size = New System.Drawing.Size(137, 13)
        Me.lblProdFinishTime.TabIndex = 574
        Me.lblProdFinishTime.Text = "Production Finished Time"
        '
        'lblProdFinishDate
        '
        Me.lblProdFinishDate.AutoSize = True
        Me.lblProdFinishDate.Location = New System.Drawing.Point(303, 36)
        Me.lblProdFinishDate.Name = "lblProdFinishDate"
        Me.lblProdFinishDate.Size = New System.Drawing.Size(138, 13)
        Me.lblProdFinishDate.TabIndex = 573
        Me.lblProdFinishDate.Text = "Production Finished Date"
        '
        'txtgrade_adt
        '
        Me.txtgrade_adt.Location = New System.Drawing.Point(141, 270)
        Me.txtgrade_adt.MaxLength = 1
        Me.txtgrade_adt.Name = "txtgrade_adt"
        Me.txtgrade_adt.Size = New System.Drawing.Size(132, 22)
        Me.txtgrade_adt.TabIndex = 9
        '
        'lblgrade_adt
        '
        Me.lblgrade_adt.AutoSize = True
        Me.lblgrade_adt.Location = New System.Drawing.Point(32, 273)
        Me.lblgrade_adt.Name = "lblgrade_adt"
        Me.lblgrade_adt.Size = New System.Drawing.Size(97, 13)
        Me.lblgrade_adt.TabIndex = 572
        Me.lblgrade_adt.Text = "Grade of Dye Test"
        '
        'txtgrade_bdt
        '
        Me.txtgrade_bdt.Location = New System.Drawing.Point(141, 240)
        Me.txtgrade_bdt.MaxLength = 1
        Me.txtgrade_bdt.Name = "txtgrade_bdt"
        Me.txtgrade_bdt.Size = New System.Drawing.Size(132, 22)
        Me.txtgrade_bdt.TabIndex = 8
        '
        'lblgrade_bdt
        '
        Me.lblgrade_bdt.AutoSize = True
        Me.lblgrade_bdt.Location = New System.Drawing.Point(20, 245)
        Me.lblgrade_bdt.Name = "lblgrade_bdt"
        Me.lblgrade_bdt.Size = New System.Drawing.Size(109, 13)
        Me.lblgrade_bdt.TabIndex = 571
        Me.lblgrade_bdt.Text = "Grade of Inspection"
        '
        'txtlot
        '
        Me.txtlot.Location = New System.Drawing.Point(141, 211)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(132, 22)
        Me.txtlot.TabIndex = 7
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Location = New System.Drawing.Point(81, 215)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(48, 13)
        Me.lbllot.TabIndex = 570
        Me.lbllot.Text = "Yarn Set"
        '
        'txtgwth
        '
        Me.txtgwth.Location = New System.Drawing.Point(141, 183)
        Me.txtgwth.Name = "txtgwth"
        Me.txtgwth.Size = New System.Drawing.Size(132, 22)
        Me.txtgwth.TabIndex = 6
        '
        'lblgwth
        '
        Me.lblgwth.AutoSize = True
        Me.lblgwth.Location = New System.Drawing.Point(22, 187)
        Me.lblgwth.Name = "lblgwth"
        Me.lblgwth.Size = New System.Drawing.Size(107, 13)
        Me.lblgwth.TabIndex = 569
        Me.lblgwth.Text = "Greige Width (cms.)"
        '
        'txtbar_weight
        '
        Me.txtbar_weight.Location = New System.Drawing.Point(141, 155)
        Me.txtbar_weight.Name = "txtbar_weight"
        Me.txtbar_weight.Size = New System.Drawing.Size(132, 22)
        Me.txtbar_weight.TabIndex = 5
        '
        'lblbar_weight
        '
        Me.lblbar_weight.AutoSize = True
        Me.lblbar_weight.Location = New System.Drawing.Point(34, 158)
        Me.lblbar_weight.Name = "lblbar_weight"
        Me.lblbar_weight.Size = New System.Drawing.Size(95, 13)
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
        Me.gbSteam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbSteam.Controls.Add(Me.txtsteam_instruction)
        Me.gbSteam.Controls.Add(Me.dtpsteam_date)
        Me.gbSteam.Controls.Add(Me.lblsteam_instruction)
        Me.gbSteam.Controls.Add(Me.lblsteam_date)
        Me.gbSteam.Controls.Add(Me.dtpsteam_time)
        Me.gbSteam.Controls.Add(Me.Label1)
        Me.gbSteam.Controls.Add(Me.txtsteam_condition)
        Me.gbSteam.Controls.Add(Me.lblsteam_condition)
        Me.gbSteam.Location = New System.Drawing.Point(610, 377)
        Me.gbSteam.Name = "gbSteam"
        Me.gbSteam.Size = New System.Drawing.Size(531, 254)
        Me.gbSteam.TabIndex = 567
        Me.gbSteam.TabStop = False
        Me.gbSteam.Text = "Steam Detail"
        '
        'txtsteam_instruction
        '
        Me.txtsteam_instruction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsteam_instruction.Location = New System.Drawing.Point(132, 117)
        Me.txtsteam_instruction.Multiline = True
        Me.txtsteam_instruction.Name = "txtsteam_instruction"
        Me.txtsteam_instruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtsteam_instruction.Size = New System.Drawing.Size(381, 126)
        Me.txtsteam_instruction.TabIndex = 32
        '
        'dtpsteam_date
        '
        Me.dtpsteam_date.Checked = False
        Me.dtpsteam_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpsteam_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsteam_date.Location = New System.Drawing.Point(132, 28)
        Me.dtpsteam_date.Name = "dtpsteam_date"
        Me.dtpsteam_date.ShowCheckBox = True
        Me.dtpsteam_date.Size = New System.Drawing.Size(119, 22)
        Me.dtpsteam_date.TabIndex = 29
        '
        'lblsteam_instruction
        '
        Me.lblsteam_instruction.AutoSize = True
        Me.lblsteam_instruction.Location = New System.Drawing.Point(16, 117)
        Me.lblsteam_instruction.Name = "lblsteam_instruction"
        Me.lblsteam_instruction.Size = New System.Drawing.Size(97, 13)
        Me.lblsteam_instruction.TabIndex = 70
        Me.lblsteam_instruction.Text = "Steam Instruction"
        '
        'lblsteam_date
        '
        Me.lblsteam_date.AutoSize = True
        Me.lblsteam_date.Location = New System.Drawing.Point(45, 28)
        Me.lblsteam_date.Name = "lblsteam_date"
        Me.lblsteam_date.Size = New System.Drawing.Size(68, 13)
        Me.lblsteam_date.TabIndex = 564
        Me.lblsteam_date.Text = "Steam Date:"
        '
        'dtpsteam_time
        '
        Me.dtpsteam_time.Checked = False
        Me.dtpsteam_time.CustomFormat = "HH:mm"
        Me.dtpsteam_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsteam_time.Location = New System.Drawing.Point(132, 57)
        Me.dtpsteam_time.Name = "dtpsteam_time"
        Me.dtpsteam_time.ShowCheckBox = True
        Me.dtpsteam_time.ShowUpDown = True
        Me.dtpsteam_time.Size = New System.Drawing.Size(119, 22)
        Me.dtpsteam_time.TabIndex = 30
        Me.dtpsteam_time.Value = New Date(2016, 6, 29, 10, 12, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 566
        Me.Label1.Text = "Steam Time:"
        '
        'txtsteam_condition
        '
        Me.txtsteam_condition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsteam_condition.Location = New System.Drawing.Point(132, 86)
        Me.txtsteam_condition.Name = "txtsteam_condition"
        Me.txtsteam_condition.Size = New System.Drawing.Size(381, 22)
        Me.txtsteam_condition.TabIndex = 31
        '
        'lblsteam_condition
        '
        Me.lblsteam_condition.AutoSize = True
        Me.lblsteam_condition.Location = New System.Drawing.Point(17, 89)
        Me.lblsteam_condition.Name = "lblsteam_condition"
        Me.lblsteam_condition.Size = New System.Drawing.Size(96, 13)
        Me.lblsteam_condition.TabIndex = 565
        Me.lblsteam_condition.Text = "Steam Condition:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSearch, Me.btnSave, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1155, 25)
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
        Me.lblsystem_lot_number.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsystem_lot_number.Location = New System.Drawing.Point(8, 31)
        Me.lblsystem_lot_number.Name = "lblsystem_lot_number"
        Me.lblsystem_lot_number.Size = New System.Drawing.Size(87, 30)
        Me.lblsystem_lot_number.TabIndex = 45
        Me.lblsystem_lot_number.Text = "Roll No."
        '
        'txttran_no
        '
        Me.txttran_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttran_no.Location = New System.Drawing.Point(120, 25)
        Me.txttran_no.Name = "txttran_no"
        Me.txttran_no.ReadOnly = True
        Me.txttran_no.Size = New System.Drawing.Size(111, 20)
        Me.txttran_no.TabIndex = 311
        '
        'txtsecondary_quantity
        '
        Me.txtsecondary_quantity.Location = New System.Drawing.Point(141, 99)
        Me.txtsecondary_quantity.Name = "txtsecondary_quantity"
        Me.txtsecondary_quantity.Size = New System.Drawing.Size(132, 22)
        Me.txtsecondary_quantity.TabIndex = 3
        '
        'lblsecondary_quantity
        '
        Me.lblsecondary_quantity.AutoSize = True
        Me.lblsecondary_quantity.Location = New System.Drawing.Point(55, 103)
        Me.lblsecondary_quantity.Name = "lblsecondary_quantity"
        Me.lblsecondary_quantity.Size = New System.Drawing.Size(74, 13)
        Me.lblsecondary_quantity.TabIndex = 555
        Me.lblsecondary_quantity.Text = "Length (Mts.)"
        '
        'txtprimary_quantity
        '
        Me.txtprimary_quantity.Location = New System.Drawing.Point(141, 127)
        Me.txtprimary_quantity.Name = "txtprimary_quantity"
        Me.txtprimary_quantity.Size = New System.Drawing.Size(132, 22)
        Me.txtprimary_quantity.TabIndex = 4
        '
        'lbltran_no
        '
        Me.lbltran_no.AutoSize = True
        Me.lbltran_no.Location = New System.Drawing.Point(16, 29)
        Me.lbltran_no.Name = "lbltran_no"
        Me.lbltran_no.Size = New System.Drawing.Size(47, 13)
        Me.lbltran_no.TabIndex = 312
        Me.lbltran_no.Text = "GIN No."
        '
        'txtBOM
        '
        Me.txtBOM.Location = New System.Drawing.Point(394, 41)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.ReadOnly = True
        Me.txtBOM.Size = New System.Drawing.Size(131, 22)
        Me.txtBOM.TabIndex = 74
        '
        'lblkg
        '
        Me.lblkg.AutoSize = True
        Me.lblkg.Location = New System.Drawing.Point(54, 131)
        Me.lblkg.Name = "lblkg"
        Me.lblkg.Size = New System.Drawing.Size(75, 13)
        Me.lblkg.TabIndex = 554
        Me.lblkg.Text = "Weight (Kgs.)"
        '
        'txtlot_grade
        '
        Me.txtlot_grade.Location = New System.Drawing.Point(141, 298)
        Me.txtlot_grade.Name = "txtlot_grade"
        Me.txtlot_grade.ReadOnly = True
        Me.txtlot_grade.Size = New System.Drawing.Size(132, 22)
        Me.txtlot_grade.TabIndex = 10
        '
        'lbltran_dt
        '
        Me.lbltran_dt.AutoSize = True
        Me.lbltran_dt.Location = New System.Drawing.Point(16, 60)
        Me.lbltran_dt.Name = "lbltran_dt"
        Me.lbltran_dt.Size = New System.Drawing.Size(87, 13)
        Me.lbltran_dt.TabIndex = 313
        Me.lbltran_dt.Text = "Document Date"
        '
        'dtptran_dt
        '
        Me.dtptran_dt.Checked = False
        Me.dtptran_dt.CustomFormat = "dd/MM/yyyy"
        Me.dtptran_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptran_dt.Location = New System.Drawing.Point(120, 55)
        Me.dtptran_dt.Name = "dtptran_dt"
        Me.dtptran_dt.ShowCheckBox = True
        Me.dtptran_dt.Size = New System.Drawing.Size(111, 22)
        Me.dtptran_dt.TabIndex = 310
        '
        'cbomfg_production_steps_id
        '
        Me.cbomfg_production_steps_id.FormattingEnabled = True
        Me.cbomfg_production_steps_id.Location = New System.Drawing.Point(130, 65)
        Me.cbomfg_production_steps_id.Name = "cbomfg_production_steps_id"
        Me.cbomfg_production_steps_id.Size = New System.Drawing.Size(145, 21)
        Me.cbomfg_production_steps_id.TabIndex = 309
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(88, 301)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(41, 13)
        Me.lblGrade.TabIndex = 553
        Me.lblGrade.Text = "Grade:"
        '
        'cbomcno
        '
        Me.cbomcno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomcno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomcno.FormattingEnabled = True
        Me.cbomcno.Location = New System.Drawing.Point(130, 41)
        Me.cbomcno.Name = "cbomcno"
        Me.cbomcno.Size = New System.Drawing.Size(146, 21)
        Me.cbomcno.TabIndex = 78
        '
        'lblynchgcd
        '
        Me.lblynchgcd.AutoSize = True
        Me.lblynchgcd.Location = New System.Drawing.Point(341, 45)
        Me.lblynchgcd.Name = "lblynchgcd"
        Me.lblynchgcd.Size = New System.Drawing.Size(33, 13)
        Me.lblynchgcd.TabIndex = 308
        Me.lblynchgcd.Text = "BOM"
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Location = New System.Drawing.Point(77, 69)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(36, 13)
        Me.lblStep.TabIndex = 45
        Me.lblStep.Text = "Step :"
        '
        'lblmcno
        '
        Me.lblmcno.AutoSize = True
        Me.lblmcno.Location = New System.Drawing.Point(59, 45)
        Me.lblmcno.Name = "lblmcno"
        Me.lblmcno.Size = New System.Drawing.Size(54, 13)
        Me.lblmcno.TabIndex = 58
        Me.lblmcno.Text = "Machine:"
        '
        'txtinventory_item_code
        '
        Me.txtinventory_item_code.Location = New System.Drawing.Point(394, 15)
        Me.txtinventory_item_code.Name = "txtinventory_item_code"
        Me.txtinventory_item_code.ReadOnly = True
        Me.txtinventory_item_code.Size = New System.Drawing.Size(131, 22)
        Me.txtinventory_item_code.TabIndex = 48
        '
        'txtsystem_lot_number
        '
        Me.txtsystem_lot_number.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsystem_lot_number.Location = New System.Drawing.Point(101, 30)
        Me.txtsystem_lot_number.MaxLength = 20
        Me.txtsystem_lot_number.Name = "txtsystem_lot_number"
        Me.txtsystem_lot_number.Size = New System.Drawing.Size(169, 46)
        Me.txtsystem_lot_number.TabIndex = 1
        '
        'txtproduction_order_no
        '
        Me.txtproduction_order_no.Location = New System.Drawing.Point(130, 15)
        Me.txtproduction_order_no.Name = "txtproduction_order_no"
        Me.txtproduction_order_no.ReadOnly = True
        Me.txtproduction_order_no.Size = New System.Drawing.Size(146, 22)
        Me.txtproduction_order_no.TabIndex = 44
        '
        'cbooperator
        '
        Me.cbooperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbooperator.Enabled = False
        Me.cbooperator.FormattingEnabled = True
        Me.cbooperator.Location = New System.Drawing.Point(394, 65)
        Me.cbooperator.Name = "cbooperator"
        Me.cbooperator.Size = New System.Drawing.Size(131, 21)
        Me.cbooperator.TabIndex = 77
        '
        'lblPROD
        '
        Me.lblPROD.AutoSize = True
        Me.lblPROD.Location = New System.Drawing.Point(55, 18)
        Me.lblPROD.Name = "lblPROD"
        Me.lblPROD.Size = New System.Drawing.Size(58, 13)
        Me.lblPROD.TabIndex = 43
        Me.lblPROD.Text = "PROD No:"
        '
        'txtcustom_lot_number
        '
        Me.txtcustom_lot_number.Location = New System.Drawing.Point(125, 40)
        Me.txtcustom_lot_number.Name = "txtcustom_lot_number"
        Me.txtcustom_lot_number.ReadOnly = True
        Me.txtcustom_lot_number.Size = New System.Drawing.Size(134, 22)
        Me.txtcustom_lot_number.TabIndex = 2
        '
        'lblDesignNo
        '
        Me.lblDesignNo.AutoSize = True
        Me.lblDesignNo.Location = New System.Drawing.Point(310, 18)
        Me.lblDesignNo.Name = "lblDesignNo"
        Me.lblDesignNo.Size = New System.Drawing.Size(64, 13)
        Me.lblDesignNo.TabIndex = 47
        Me.lblDesignNo.Text = "Design No:"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(141, 378)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_subinventory.TabIndex = 13
        '
        'gbSystemRoll
        '
        Me.gbSystemRoll.Controls.Add(Me.lblsystem_lot_number)
        Me.gbSystemRoll.Controls.Add(Me.txtsystem_lot_number)
        Me.gbSystemRoll.Location = New System.Drawing.Point(12, 28)
        Me.gbSystemRoll.Name = "gbSystemRoll"
        Me.gbSystemRoll.Size = New System.Drawing.Size(283, 92)
        Me.gbSystemRoll.TabIndex = 523
        Me.gbSystemRoll.TabStop = False
        Me.gbSystemRoll.Text = "Scan Barcode"
        '
        'gbProduction
        '
        Me.gbProduction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.gbProduction.Location = New System.Drawing.Point(301, 28)
        Me.gbProduction.Name = "gbProduction"
        Me.gbProduction.Size = New System.Drawing.Size(566, 92)
        Me.gbProduction.TabIndex = 563
        Me.gbProduction.TabStop = False
        Me.gbProduction.Text = "Production Information"
        '
        'lbloperator
        '
        Me.lbloperator.AutoSize = True
        Me.lbloperator.Location = New System.Drawing.Point(317, 69)
        Me.lbloperator.Name = "lbloperator"
        Me.lbloperator.Size = New System.Drawing.Size(57, 13)
        Me.lbloperator.TabIndex = 67
        Me.lbloperator.Text = "Operator:"
        '
        'cbomtl_location
        '
        Me.cbomtl_location.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_location.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_location.FormattingEnabled = True
        Me.cbomtl_location.Location = New System.Drawing.Point(141, 405)
        Me.cbomtl_location.Name = "cbomtl_location"
        Me.cbomtl_location.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_location.TabIndex = 14
        '
        'lblmtl_location
        '
        Me.lblmtl_location.AutoSize = True
        Me.lblmtl_location.Location = New System.Drawing.Point(75, 409)
        Me.lblmtl_location.Name = "lblmtl_location"
        Me.lblmtl_location.Size = New System.Drawing.Size(54, 13)
        Me.lblmtl_location.TabIndex = 559
        Me.lblmtl_location.Text = "Location:"
        '
        'txtqc_remarks
        '
        Me.txtqc_remarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtqc_remarks.Location = New System.Drawing.Point(306, 350)
        Me.txtqc_remarks.Multiline = True
        Me.txtqc_remarks.Name = "txtqc_remarks"
        Me.txtqc_remarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtqc_remarks.Size = New System.Drawing.Size(270, 143)
        Me.txtqc_remarks.TabIndex = 26
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(60, 353)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(69, 13)
        Me.lblmtl_warehouse_id.TabIndex = 558
        Me.lblmtl_warehouse_id.Text = "Warehouse:"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(141, 350)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(133, 21)
        Me.cbomtl_warehouse.TabIndex = 12
        '
        'txtwork_shift
        '
        Me.txtwork_shift.Location = New System.Drawing.Point(141, 433)
        Me.txtwork_shift.Name = "txtwork_shift"
        Me.txtwork_shift.Size = New System.Drawing.Size(132, 22)
        Me.txtwork_shift.TabIndex = 15
        '
        'lblwork_shift
        '
        Me.lblwork_shift.AutoSize = True
        Me.lblwork_shift.Location = New System.Drawing.Point(95, 438)
        Me.lblwork_shift.Name = "lblwork_shift"
        Me.lblwork_shift.Size = New System.Drawing.Size(34, 13)
        Me.lblwork_shift.TabIndex = 560
        Me.lblwork_shift.Text = "Shift:"
        '
        'lblqc_remarks
        '
        Me.lblqc_remarks.AutoSize = True
        Me.lblqc_remarks.Location = New System.Drawing.Point(303, 329)
        Me.lblqc_remarks.Name = "lblqc_remarks"
        Me.lblqc_remarks.Size = New System.Drawing.Size(75, 13)
        Me.lblqc_remarks.TabIndex = 557
        Me.lblqc_remarks.Text = "Q/C Remarks:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.lblrpm)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblwork_shift)
        Me.GroupBox1.Controls.Add(Me.lblcounter_per_roll)
        Me.GroupBox1.Controls.Add(Me.txtwork_shift)
        Me.GroupBox1.Controls.Add(Me.txtrpm)
        Me.GroupBox1.Controls.Add(Me.cbomtl_warehouse)
        Me.GroupBox1.Controls.Add(Me.txtcounter_per_roll)
        Me.GroupBox1.Controls.Add(Me.lblmtl_warehouse_id)
        Me.GroupBox1.Controls.Add(Me.lblmtl_location)
        Me.GroupBox1.Controls.Add(Me.dtpProdFinishTime)
        Me.GroupBox1.Controls.Add(Me.btnGreigeIn)
        Me.GroupBox1.Controls.Add(Me.dtpProdFinishDate)
        Me.GroupBox1.Controls.Add(Me.chkdyeing_pass)
        Me.GroupBox1.Controls.Add(Me.cbomtl_location)
        Me.GroupBox1.Controls.Add(Me.txtdefect_loss_kg)
        Me.GroupBox1.Controls.Add(Me.cbomtl_subinventory)
        Me.GroupBox1.Controls.Add(Me.lbldefect_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtlab_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lblGrade)
        Me.GroupBox1.Controls.Add(Me.lbllab_loss_kg)
        Me.GroupBox1.Controls.Add(Me.chkcliped)
        Me.GroupBox1.Controls.Add(Me.txtdyed_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtlot_grade)
        Me.GroupBox1.Controls.Add(Me.lbldyed_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lblcliped)
        Me.GroupBox1.Controls.Add(Me.txtqc_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lblkg)
        Me.GroupBox1.Controls.Add(Me.lblqc_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtprimary_quantity)
        Me.GroupBox1.Controls.Add(Me.lbladjust_loss_kg)
        Me.GroupBox1.Controls.Add(Me.lblsecondary_quantity)
        Me.GroupBox1.Controls.Add(Me.txtadjust_loss_kg)
        Me.GroupBox1.Controls.Add(Me.txtsecondary_quantity)
        Me.GroupBox1.Controls.Add(Me.lbldyeing_pass)
        Me.GroupBox1.Controls.Add(Me.lblbar_weight)
        Me.GroupBox1.Controls.Add(Me.lblProdFinishTime)
        Me.GroupBox1.Controls.Add(Me.txtbar_weight)
        Me.GroupBox1.Controls.Add(Me.lblProdFinishDate)
        Me.GroupBox1.Controls.Add(Me.lblgwth)
        Me.GroupBox1.Controls.Add(Me.txtgwth)
        Me.GroupBox1.Controls.Add(Me.lbllot)
        Me.GroupBox1.Controls.Add(Me.txtlot)
        Me.GroupBox1.Controls.Add(Me.txtqc_remarks)
        Me.GroupBox1.Controls.Add(Me.lblgrade_bdt)
        Me.GroupBox1.Controls.Add(Me.lblqc_remarks)
        Me.GroupBox1.Controls.Add(Me.txtgrade_bdt)
        Me.GroupBox1.Controls.Add(Me.lblgrade_adt)
        Me.GroupBox1.Controls.Add(Me.btnSave_2)
        Me.GroupBox1.Controls.Add(Me.txtgrade_adt)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 506)
        Me.GroupBox1.TabIndex = 587
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Greige Detail"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFactoryRollGMKFomat)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtcustom_lot_number)
        Me.GroupBox2.Controls.Add(Me.chkGMK)
        Me.GroupBox2.Controls.Add(Me.chkEsc)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 70)
        Me.GroupBox2.TabIndex = 590
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Factory Roll"
        '
        'chkFactoryRollGMKFomat
        '
        Me.chkFactoryRollGMKFomat.AutoSize = True
        Me.chkFactoryRollGMKFomat.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFactoryRollGMKFomat.Location = New System.Drawing.Point(170, 20)
        Me.chkFactoryRollGMKFomat.Name = "chkFactoryRollGMKFomat"
        Me.chkFactoryRollGMKFomat.Size = New System.Drawing.Size(71, 16)
        Me.chkFactoryRollGMKFomat.TabIndex = 591
        Me.chkFactoryRollGMKFomat.Text = "GMK  Fomat"
        Me.chkFactoryRollGMKFomat.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 590
        Me.Label3.Text = "Factory Roll"
        '
        'chkGMK
        '
        Me.chkGMK.AutoSize = True
        Me.chkGMK.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkGMK.Location = New System.Drawing.Point(105, 20)
        Me.chkGMK.Name = "chkGMK"
        Me.chkGMK.Size = New System.Drawing.Size(42, 16)
        Me.chkGMK.TabIndex = 589
        Me.chkGMK.Text = "GMK"
        Me.chkGMK.UseVisualStyleBackColor = True
        '
        'chkEsc
        '
        Me.chkEsc.AutoSize = True
        Me.chkEsc.Checked = True
        Me.chkEsc.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEsc.Location = New System.Drawing.Point(28, 20)
        Me.chkEsc.Name = "chkEsc"
        Me.chkEsc.Size = New System.Drawing.Size(39, 16)
        Me.chkEsc.TabIndex = 588
        Me.chkEsc.TabStop = True
        Me.chkEsc.Text = "ESH"
        Me.chkEsc.UseVisualStyleBackColor = True
        '
        'btnGreigeIn
        '
        Me.btnGreigeIn.Image = Global.ProductionSystem.My.Resources.Resources.Input_16x
        Me.btnGreigeIn.Location = New System.Drawing.Point(184, 466)
        Me.btnGreigeIn.Name = "btnGreigeIn"
        Me.btnGreigeIn.Size = New System.Drawing.Size(89, 27)
        Me.btnGreigeIn.TabIndex = 582
        Me.btnGreigeIn.Text = "Greige In"
        Me.btnGreigeIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGreigeIn.UseVisualStyleBackColor = True
        '
        'btnSave_2
        '
        Me.btnSave_2.Image = Global.ProductionSystem.My.Resources.Resources.Save_16x
        Me.btnSave_2.Location = New System.Drawing.Point(41, 466)
        Me.btnSave_2.Name = "btnSave_2"
        Me.btnSave_2.Size = New System.Drawing.Size(91, 27)
        Me.btnSave_2.TabIndex = 562
        Me.btnSave_2.Text = "Save"
        Me.btnSave_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSave_2.UseVisualStyleBackColor = True
        '
        'GbGINDocuctments
        '
        Me.GbGINDocuctments.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GbGINDocuctments.Controls.Add(Me.lbltran_no)
        Me.GbGINDocuctments.Controls.Add(Me.txttran_no)
        Me.GbGINDocuctments.Controls.Add(Me.dtptran_dt)
        Me.GbGINDocuctments.Controls.Add(Me.lbltran_dt)
        Me.GbGINDocuctments.Location = New System.Drawing.Point(873, 28)
        Me.GbGINDocuctments.Name = "GbGINDocuctments"
        Me.GbGINDocuctments.Size = New System.Drawing.Size(268, 92)
        Me.GbGINDocuctments.TabIndex = 588
        Me.GbGINDocuctments.TabStop = False
        Me.GbGINDocuctments.Text = "GIN Documents"
        '
        'frmOperationKnitting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 644)
        Me.Controls.Add(Me.GbGINDocuctments)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbSteam)
        Me.Controls.Add(Me.GbDefect)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbSystemRoll)
        Me.Controls.Add(Me.gbProduction)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOperationKnitting"
        Me.Text = "Operation Knitting"
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbDefect.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbSteam.ResumeLayout(False)
        Me.gbSteam.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbSystemRoll.ResumeLayout(False)
        Me.gbSystemRoll.PerformLayout()
        Me.gbProduction.ResumeLayout(False)
        Me.gbProduction.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GbGINDocuctments.ResumeLayout(False)
        Me.GbGINDocuctments.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GbGINDocuctments As GroupBox
    Friend WithEvents chkGMK As RadioButton
    Friend WithEvents chkEsc As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkFactoryRollGMKFomat As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
End Class
