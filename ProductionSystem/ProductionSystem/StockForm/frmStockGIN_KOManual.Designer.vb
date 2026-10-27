<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockGIN_KOManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockGIN_KOManual))
        Me.lblmcno = New System.Windows.Forms.Label()
        Me.btnSearchOutNo = New System.Windows.Forms.Button()
        Me.lblkono = New System.Windows.Forms.Label()
        Me.lbltran_no = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.grdDefect = New System.Windows.Forms.DataGridView()
        Me.id_defect_roll = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_code = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Defect_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.defect_details = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtmcno = New System.Windows.Forms.TextBox()
        Me.txtProdFinishTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbomtl_subinventory = New System.Windows.Forms.ComboBox()
        Me.cbopcv_item_id = New System.Windows.Forms.ComboBox()
        Me.lblbar_weight = New System.Windows.Forms.Label()
        Me.cbomtl_location = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.chkGMK = New System.Windows.Forms.RadioButton()
        Me.chkEsc = New System.Windows.Forms.RadioButton()
        Me.gbDefect = New System.Windows.Forms.GroupBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.txtdefect_details = New System.Windows.Forms.TextBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.cbodefect_code = New System.Windows.Forms.ComboBox()
        Me.lblDefect_code = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.lblmts = New System.Windows.Forms.Label()
        Me.txtmts = New System.Windows.Forms.TextBox()
        Me.lblroll_no_o = New System.Windows.Forms.Label()
        Me.txtroll_no_o = New System.Windows.Forms.TextBox()
        Me.lblroll_no = New System.Windows.Forms.Label()
        Me.txtroll_no = New System.Windows.Forms.TextBox()
        Me.txtkono = New System.Windows.Forms.TextBox()
        Me.dtpProdFinishDate = New System.Windows.Forms.DateTimePicker()
        Me.chkdyeing_pass = New System.Windows.Forms.CheckBox()
        Me.txtrem_qc = New System.Windows.Forms.TextBox()
        Me.lblrem_qc = New System.Windows.Forms.Label()
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
        Me.chkcliped = New System.Windows.Forms.CheckBox()
        Me.txtshift = New System.Windows.Forms.TextBox()
        Me.lblshift = New System.Windows.Forms.Label()
        Me.lblcliped = New System.Windows.Forms.Label()
        Me.txttran_no = New System.Windows.Forms.TextBox()
        Me.txtgrade_adt = New System.Windows.Forms.TextBox()
        Me.lblgrade_adt = New System.Windows.Forms.Label()
        Me.txtgrade_bdt = New System.Windows.Forms.TextBox()
        Me.lblgrade_bdt = New System.Windows.Forms.Label()
        Me.txtlot = New System.Windows.Forms.TextBox()
        Me.lbllot = New System.Windows.Forms.Label()
        Me.txtgwth = New System.Windows.Forms.TextBox()
        Me.lblgwth = New System.Windows.Forms.Label()
        Me.txtbar_weight = New System.Windows.Forms.TextBox()
        Me.lbltran_dt = New System.Windows.Forms.Label()
        Me.txtdesign_no = New System.Windows.Forms.TextBox()
        Me.lbldesign_no = New System.Windows.Forms.Label()
        Me.lblpcv_item_id = New System.Windows.Forms.Label()
        Me.txtynchgcd = New System.Windows.Forms.TextBox()
        Me.lblynchgcd = New System.Windows.Forms.Label()
        Me.txtkg = New System.Windows.Forms.TextBox()
        Me.lblkg = New System.Windows.Forms.Label()
        Me.dtptran_dt = New System.Windows.Forms.DateTimePicker()
        Me.GbProdcutionInformations = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtlot_grade = New System.Windows.Forms.TextBox()
        Me.lblGrade = New System.Windows.Forms.Label()
        Me.lblrpm = New System.Windows.Forms.Label()
        Me.lblcounter_per_roll = New System.Windows.Forms.Label()
        Me.txtrpm = New System.Windows.Forms.TextBox()
        Me.txtcounter_per_roll = New System.Windows.Forms.TextBox()
        Me.GbGreigeDetail = New System.Windows.Forms.GroupBox()
        Me.gbSteam = New System.Windows.Forms.GroupBox()
        Me.txtsteam_instruction = New System.Windows.Forms.TextBox()
        Me.dtpsteam_date = New System.Windows.Forms.DateTimePicker()
        Me.lblsteam_instruction = New System.Windows.Forms.Label()
        Me.lblsteam_date = New System.Windows.Forms.Label()
        Me.dtpsteam_time = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsteam_condition = New System.Windows.Forms.TextBox()
        Me.lblsteam_condition = New System.Windows.Forms.Label()
        Me.GbGINDocuments = New System.Windows.Forms.GroupBox()
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDefect.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GbProdcutionInformations.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbGreigeDetail.SuspendLayout()
        Me.gbSteam.SuspendLayout()
        Me.GbGINDocuments.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblmcno
        '
        Me.lblmcno.AutoSize = True
        Me.lblmcno.Location = New System.Drawing.Point(17, 48)
        Me.lblmcno.Name = "lblmcno"
        Me.lblmcno.Size = New System.Drawing.Size(49, 13)
        Me.lblmcno.TabIndex = 304
        Me.lblmcno.Text = "M/C No."
        '
        'btnSearchOutNo
        '
        Me.btnSearchOutNo.Image = CType(resources.GetObject("btnSearchOutNo.Image"), System.Drawing.Image)
        Me.btnSearchOutNo.Location = New System.Drawing.Point(220, 17)
        Me.btnSearchOutNo.Name = "btnSearchOutNo"
        Me.btnSearchOutNo.Size = New System.Drawing.Size(30, 23)
        Me.btnSearchOutNo.TabIndex = 299
        Me.btnSearchOutNo.UseVisualStyleBackColor = True
        '
        'lblkono
        '
        Me.lblkono.AutoSize = True
        Me.lblkono.Location = New System.Drawing.Point(17, 19)
        Me.lblkono.Name = "lblkono"
        Me.lblkono.Size = New System.Drawing.Size(47, 13)
        Me.lblkono.TabIndex = 1
        Me.lblkono.Text = "K/O No."
        '
        'lbltran_no
        '
        Me.lbltran_no.AutoSize = True
        Me.lbltran_no.Location = New System.Drawing.Point(17, 26)
        Me.lbltran_no.Name = "lbltran_no"
        Me.lbltran_no.Size = New System.Drawing.Size(47, 13)
        Me.lbltran_no.TabIndex = 301
        Me.lbltran_no.Text = "GIN No."
        '
        'btnCancel
        '
        Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Image)
        Me.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(63, 22)
        Me.btnCancel.Text = "Cancel"
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(52, 22)
        Me.btnPrint.Text = "Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'grdDefect
        '
        Me.grdDefect.AllowUserToAddRows = False
        Me.grdDefect.BackgroundColor = System.Drawing.Color.PeachPuff
        Me.grdDefect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDefect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_defect_roll, Me.DataGridViewTextBoxColumn3, Me.defect_code, Me.Defect_name, Me.defect_details, Me.stock_code})
        Me.grdDefect.Location = New System.Drawing.Point(18, 28)
        Me.grdDefect.Name = "grdDefect"
        Me.grdDefect.Size = New System.Drawing.Size(246, 157)
        Me.grdDefect.TabIndex = 360
        Me.grdDefect.TabStop = False
        '
        'id_defect_roll
        '
        Me.id_defect_roll.DataPropertyName = "id_defect_roll"
        Me.id_defect_roll.HeaderText = "ID"
        Me.id_defect_roll.Name = "id_defect_roll"
        Me.id_defect_roll.Visible = False
        Me.id_defect_roll.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "roll_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Roll No."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'defect_code
        '
        Me.defect_code.DataPropertyName = "defect_code"
        Me.defect_code.HeaderText = "Defect Code"
        Me.defect_code.Name = "defect_code"
        Me.defect_code.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.defect_code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Defect_name
        '
        Me.Defect_name.DataPropertyName = "Defect_name"
        Me.Defect_name.HeaderText = "Defect Name"
        Me.Defect_name.Name = "Defect_name"
        Me.Defect_name.ReadOnly = True
        Me.Defect_name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Defect_name.Visible = False
        '
        'defect_details
        '
        Me.defect_details.DataPropertyName = "defect_details"
        Me.defect_details.HeaderText = "Qty"
        Me.defect_details.Name = "defect_details"
        Me.defect_details.Width = 90
        '
        'stock_code
        '
        Me.stock_code.DataPropertyName = "stock_code"
        Me.stock_code.HeaderText = "Stock Code"
        Me.stock_code.Name = "stock_code"
        Me.stock_code.Visible = False
        '
        'txtmcno
        '
        Me.txtmcno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtmcno.Location = New System.Drawing.Point(82, 45)
        Me.txtmcno.Name = "txtmcno"
        Me.txtmcno.ReadOnly = True
        Me.txtmcno.Size = New System.Drawing.Size(132, 20)
        Me.txtmcno.TabIndex = 2
        '
        'txtProdFinishTime
        '
        Me.txtProdFinishTime.CustomFormat = "HH:mm"
        Me.txtProdFinishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtProdFinishTime.Location = New System.Drawing.Point(441, 61)
        Me.txtProdFinishTime.Name = "txtProdFinishTime"
        Me.txtProdFinishTime.ShowCheckBox = True
        Me.txtProdFinishTime.ShowUpDown = True
        Me.txtProdFinishTime.Size = New System.Drawing.Size(120, 22)
        Me.txtProdFinishTime.TabIndex = 479
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 422)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 515
        Me.Label2.Text = "SubInventory"
        '
        'cbomtl_subinventory
        '
        Me.cbomtl_subinventory.FormattingEnabled = True
        Me.cbomtl_subinventory.Location = New System.Drawing.Point(171, 419)
        Me.cbomtl_subinventory.Name = "cbomtl_subinventory"
        Me.cbomtl_subinventory.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_subinventory.TabIndex = 475
        '
        'cbopcv_item_id
        '
        Me.cbopcv_item_id.FormattingEnabled = True
        Me.cbopcv_item_id.Location = New System.Drawing.Point(171, 139)
        Me.cbopcv_item_id.Name = "cbopcv_item_id"
        Me.cbopcv_item_id.Size = New System.Drawing.Size(132, 21)
        Me.cbopcv_item_id.TabIndex = 467
        '
        'lblbar_weight
        '
        Me.lblbar_weight.AutoSize = True
        Me.lblbar_weight.Location = New System.Drawing.Point(66, 169)
        Me.lblbar_weight.Name = "lblbar_weight"
        Me.lblbar_weight.Size = New System.Drawing.Size(95, 13)
        Me.lblbar_weight.TabIndex = 514
        Me.lblbar_weight.Text = "Bar Weight (Kgs.)"
        '
        'cbomtl_location
        '
        Me.cbomtl_location.FormattingEnabled = True
        Me.cbomtl_location.Location = New System.Drawing.Point(171, 453)
        Me.cbomtl_location.Name = "cbomtl_location"
        Me.cbomtl_location.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_location.TabIndex = 476
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 513
        Me.Label1.Text = "Location"
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(94, 394)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(66, 13)
        Me.lblmtl_warehouse_id.TabIndex = 512
        Me.lblmtl_warehouse_id.Text = "Warehouse"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(171, 391)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_warehouse.TabIndex = 474
        '
        'chkGMK
        '
        Me.chkGMK.AutoSize = True
        Me.chkGMK.Location = New System.Drawing.Point(116, 55)
        Me.chkGMK.Name = "chkGMK"
        Me.chkGMK.Size = New System.Drawing.Size(49, 17)
        Me.chkGMK.TabIndex = 511
        Me.chkGMK.Text = "GMK"
        Me.chkGMK.UseVisualStyleBackColor = True
        '
        'chkEsc
        '
        Me.chkEsc.AutoSize = True
        Me.chkEsc.Checked = True
        Me.chkEsc.Location = New System.Drawing.Point(63, 55)
        Me.chkEsc.Name = "chkEsc"
        Me.chkEsc.Size = New System.Drawing.Size(45, 17)
        Me.chkEsc.TabIndex = 510
        Me.chkEsc.TabStop = True
        Me.chkEsc.Text = "ESH"
        Me.chkEsc.UseVisualStyleBackColor = True
        '
        'gbDefect
        '
        Me.gbDefect.Controls.Add(Me.btnApply)
        Me.gbDefect.Controls.Add(Me.txtdefect_details)
        Me.gbDefect.Controls.Add(Me.lblQty)
        Me.gbDefect.Controls.Add(Me.cbodefect_code)
        Me.gbDefect.Controls.Add(Me.lblDefect_code)
        Me.gbDefect.Controls.Add(Me.grdDefect)
        Me.gbDefect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDefect.Location = New System.Drawing.Point(613, 113)
        Me.gbDefect.Name = "gbDefect"
        Me.gbDefect.Size = New System.Drawing.Size(284, 253)
        Me.gbDefect.TabIndex = 509
        Me.gbDefect.TabStop = False
        Me.gbDefect.Text = "Defect Detail"
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(211, 223)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(53, 23)
        Me.btnApply.TabIndex = 365
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'txtdefect_details
        '
        Me.txtdefect_details.Location = New System.Drawing.Point(216, 199)
        Me.txtdefect_details.Name = "txtdefect_details"
        Me.txtdefect_details.Size = New System.Drawing.Size(48, 22)
        Me.txtdefect_details.TabIndex = 364
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(177, 201)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(24, 13)
        Me.lblQty.TabIndex = 363
        Me.lblQty.Text = "Qty"
        '
        'cbodefect_code
        '
        Me.cbodefect_code.FormattingEnabled = True
        Me.cbodefect_code.Location = New System.Drawing.Point(84, 201)
        Me.cbodefect_code.Name = "cbodefect_code"
        Me.cbodefect_code.Size = New System.Drawing.Size(87, 21)
        Me.cbodefect_code.TabIndex = 362
        '
        'lblDefect_code
        '
        Me.lblDefect_code.AutoSize = True
        Me.lblDefect_code.Location = New System.Drawing.Point(18, 204)
        Me.lblDefect_code.Name = "lblDefect_code"
        Me.lblDefect_code.Size = New System.Drawing.Size(55, 13)
        Me.lblDefect_code.TabIndex = 361
        Me.lblDefect_code.Text = "Def Code"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSave, Me.btnPrint, Me.btnCancel, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1062, 25)
        Me.ToolStrip1.TabIndex = 487
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(51, 22)
        Me.btnSave.Text = "Save"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 22)
        Me.btnExit.Text = "Exit"
        '
        'lblmts
        '
        Me.lblmts.AutoSize = True
        Me.lblmts.Location = New System.Drawing.Point(87, 85)
        Me.lblmts.Name = "lblmts"
        Me.lblmts.Size = New System.Drawing.Size(74, 13)
        Me.lblmts.TabIndex = 491
        Me.lblmts.Text = "Length (Mts.)"
        '
        'txtmts
        '
        Me.txtmts.Location = New System.Drawing.Point(171, 81)
        Me.txtmts.Name = "txtmts"
        Me.txtmts.Size = New System.Drawing.Size(132, 22)
        Me.txtmts.TabIndex = 465
        '
        'lblroll_no_o
        '
        Me.lblroll_no_o.AutoSize = True
        Me.lblroll_no_o.Location = New System.Drawing.Point(8, 57)
        Me.lblroll_no_o.Name = "lblroll_no_o"
        Me.lblroll_no_o.Size = New System.Drawing.Size(51, 13)
        Me.lblroll_no_o.TabIndex = 490
        Me.lblroll_no_o.Text = "Fact Roll"
        '
        'txtroll_no_o
        '
        Me.txtroll_no_o.Location = New System.Drawing.Point(171, 54)
        Me.txtroll_no_o.Name = "txtroll_no_o"
        Me.txtroll_no_o.ReadOnly = True
        Me.txtroll_no_o.Size = New System.Drawing.Size(132, 22)
        Me.txtroll_no_o.TabIndex = 464
        '
        'lblroll_no
        '
        Me.lblroll_no.AutoSize = True
        Me.lblroll_no.Location = New System.Drawing.Point(74, 27)
        Me.lblroll_no.Name = "lblroll_no"
        Me.lblroll_no.Size = New System.Drawing.Size(86, 13)
        Me.lblroll_no.TabIndex = 489
        Me.lblroll_no.Text = "System Roll No."
        '
        'txtroll_no
        '
        Me.txtroll_no.Location = New System.Drawing.Point(171, 27)
        Me.txtroll_no.Name = "txtroll_no"
        Me.txtroll_no.ReadOnly = True
        Me.txtroll_no.Size = New System.Drawing.Size(132, 22)
        Me.txtroll_no.TabIndex = 463
        '
        'txtkono
        '
        Me.txtkono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtkono.Location = New System.Drawing.Point(82, 19)
        Me.txtkono.Name = "txtkono"
        Me.txtkono.ReadOnly = True
        Me.txtkono.Size = New System.Drawing.Size(132, 20)
        Me.txtkono.TabIndex = 1
        '
        'dtpProdFinishDate
        '
        Me.dtpProdFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpProdFinishDate.Location = New System.Drawing.Point(441, 30)
        Me.dtpProdFinishDate.Name = "dtpProdFinishDate"
        Me.dtpProdFinishDate.ShowCheckBox = True
        Me.dtpProdFinishDate.Size = New System.Drawing.Size(119, 22)
        Me.dtpProdFinishDate.TabIndex = 478
        '
        'chkdyeing_pass
        '
        Me.chkdyeing_pass.AutoSize = True
        Me.chkdyeing_pass.Location = New System.Drawing.Point(441, 93)
        Me.chkdyeing_pass.Name = "chkdyeing_pass"
        Me.chkdyeing_pass.Size = New System.Drawing.Size(15, 14)
        Me.chkdyeing_pass.TabIndex = 480
        Me.chkdyeing_pass.UseVisualStyleBackColor = True
        '
        'txtrem_qc
        '
        Me.txtrem_qc.Location = New System.Drawing.Point(441, 313)
        Me.txtrem_qc.Multiline = True
        Me.txtrem_qc.Name = "txtrem_qc"
        Me.txtrem_qc.Size = New System.Drawing.Size(120, 183)
        Me.txtrem_qc.TabIndex = 486
        '
        'lblrem_qc
        '
        Me.lblrem_qc.AutoSize = True
        Me.lblrem_qc.Location = New System.Drawing.Point(373, 316)
        Me.lblrem_qc.Name = "lblrem_qc"
        Me.lblrem_qc.Size = New System.Drawing.Size(63, 13)
        Me.lblrem_qc.TabIndex = 508
        Me.lblrem_qc.Text = "QC Remark"
        '
        'txtdefect_loss_kg
        '
        Me.txtdefect_loss_kg.Location = New System.Drawing.Point(441, 224)
        Me.txtdefect_loss_kg.Name = "txtdefect_loss_kg"
        Me.txtdefect_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtdefect_loss_kg.TabIndex = 485
        '
        'lbldefect_loss_kg
        '
        Me.lbldefect_loss_kg.AutoSize = True
        Me.lbldefect_loss_kg.Location = New System.Drawing.Point(341, 226)
        Me.lbldefect_loss_kg.Name = "lbldefect_loss_kg"
        Me.lbldefect_loss_kg.Size = New System.Drawing.Size(95, 13)
        Me.lbldefect_loss_kg.TabIndex = 507
        Me.lbldefect_loss_kg.Text = "Defect Loss (Kgs.)"
        '
        'txtlab_loss_kg
        '
        Me.txtlab_loss_kg.Location = New System.Drawing.Point(441, 195)
        Me.txtlab_loss_kg.Name = "txtlab_loss_kg"
        Me.txtlab_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtlab_loss_kg.TabIndex = 484
        '
        'lbllab_loss_kg
        '
        Me.lbllab_loss_kg.AutoSize = True
        Me.lbllab_loss_kg.Location = New System.Drawing.Point(355, 195)
        Me.lbllab_loss_kg.Name = "lbllab_loss_kg"
        Me.lbllab_loss_kg.Size = New System.Drawing.Size(80, 13)
        Me.lbllab_loss_kg.TabIndex = 506
        Me.lbllab_loss_kg.Text = "Lab Loss (Kgs.)"
        '
        'txtdyed_loss_kg
        '
        Me.txtdyed_loss_kg.Location = New System.Drawing.Point(441, 169)
        Me.txtdyed_loss_kg.Name = "txtdyed_loss_kg"
        Me.txtdyed_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtdyed_loss_kg.TabIndex = 483
        '
        'lbldyed_loss_kg
        '
        Me.lbldyed_loss_kg.AutoSize = True
        Me.lbldyed_loss_kg.Location = New System.Drawing.Point(330, 167)
        Me.lbldyed_loss_kg.Name = "lbldyed_loss_kg"
        Me.lbldyed_loss_kg.Size = New System.Drawing.Size(104, 13)
        Me.lbldyed_loss_kg.TabIndex = 505
        Me.lbldyed_loss_kg.Text = "Dye Test Loss (Kgs.)"
        '
        'txtqc_loss_kg
        '
        Me.txtqc_loss_kg.Location = New System.Drawing.Point(441, 142)
        Me.txtqc_loss_kg.Name = "txtqc_loss_kg"
        Me.txtqc_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtqc_loss_kg.TabIndex = 482
        '
        'lblqc_loss_kg
        '
        Me.lblqc_loss_kg.AutoSize = True
        Me.lblqc_loss_kg.Location = New System.Drawing.Point(358, 143)
        Me.lblqc_loss_kg.Name = "lblqc_loss_kg"
        Me.lblqc_loss_kg.Size = New System.Drawing.Size(77, 13)
        Me.lblqc_loss_kg.TabIndex = 504
        Me.lblqc_loss_kg.Text = "QC Loss (Kgs.)"
        '
        'lbladjust_loss_kg
        '
        Me.lbladjust_loss_kg.AutoSize = True
        Me.lbladjust_loss_kg.Location = New System.Drawing.Point(335, 119)
        Me.lbladjust_loss_kg.Name = "lbladjust_loss_kg"
        Me.lbladjust_loss_kg.Size = New System.Drawing.Size(100, 13)
        Me.lbladjust_loss_kg.TabIndex = 503
        Me.lbladjust_loss_kg.Text = "Process Loss (Kgs.)"
        '
        'txtadjust_loss_kg
        '
        Me.txtadjust_loss_kg.Location = New System.Drawing.Point(441, 116)
        Me.txtadjust_loss_kg.Name = "txtadjust_loss_kg"
        Me.txtadjust_loss_kg.Size = New System.Drawing.Size(119, 22)
        Me.txtadjust_loss_kg.TabIndex = 481
        '
        'lbldyeing_pass
        '
        Me.lbldyeing_pass.AutoSize = True
        Me.lbldyeing_pass.Location = New System.Drawing.Point(359, 90)
        Me.lbldyeing_pass.Name = "lbldyeing_pass"
        Me.lbldyeing_pass.Size = New System.Drawing.Size(74, 13)
        Me.lbldyeing_pass.TabIndex = 502
        Me.lbldyeing_pass.Text = "Pass Dye Test"
        '
        'lblProdFinishTime
        '
        Me.lblProdFinishTime.AutoSize = True
        Me.lblProdFinishTime.Location = New System.Drawing.Point(304, 61)
        Me.lblProdFinishTime.Name = "lblProdFinishTime"
        Me.lblProdFinishTime.Size = New System.Drawing.Size(137, 13)
        Me.lblProdFinishTime.TabIndex = 501
        Me.lblProdFinishTime.Text = "Production Finished Time"
        '
        'lblProdFinishDate
        '
        Me.lblProdFinishDate.AutoSize = True
        Me.lblProdFinishDate.Location = New System.Drawing.Point(304, 30)
        Me.lblProdFinishDate.Name = "lblProdFinishDate"
        Me.lblProdFinishDate.Size = New System.Drawing.Size(138, 13)
        Me.lblProdFinishDate.TabIndex = 500
        Me.lblProdFinishDate.Text = "Production Finished Date"
        '
        'chkcliped
        '
        Me.chkcliped.AutoSize = True
        Me.chkcliped.Location = New System.Drawing.Point(171, 366)
        Me.chkcliped.Name = "chkcliped"
        Me.chkcliped.Size = New System.Drawing.Size(15, 14)
        Me.chkcliped.TabIndex = 473
        Me.chkcliped.UseVisualStyleBackColor = True
        '
        'txtshift
        '
        Me.txtshift.Location = New System.Drawing.Point(171, 480)
        Me.txtshift.Name = "txtshift"
        Me.txtshift.Size = New System.Drawing.Size(132, 22)
        Me.txtshift.TabIndex = 477
        '
        'lblshift
        '
        Me.lblshift.AutoSize = True
        Me.lblshift.Location = New System.Drawing.Point(128, 483)
        Me.lblshift.Name = "lblshift"
        Me.lblshift.Size = New System.Drawing.Size(31, 13)
        Me.lblshift.TabIndex = 499
        Me.lblshift.Text = "Shift"
        '
        'lblcliped
        '
        Me.lblcliped.AutoSize = True
        Me.lblcliped.Location = New System.Drawing.Point(50, 366)
        Me.lblcliped.Name = "lblcliped"
        Me.lblcliped.Size = New System.Drawing.Size(110, 13)
        Me.lblcliped.TabIndex = 498
        Me.lblcliped.Text = "Open Width ? (ผ่าถุง)"
        '
        'txttran_no
        '
        Me.txttran_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txttran_no.Location = New System.Drawing.Point(83, 24)
        Me.txttran_no.Name = "txttran_no"
        Me.txttran_no.ReadOnly = True
        Me.txttran_no.Size = New System.Drawing.Size(132, 20)
        Me.txttran_no.TabIndex = 300
        '
        'txtgrade_adt
        '
        Me.txtgrade_adt.Location = New System.Drawing.Point(171, 300)
        Me.txtgrade_adt.Name = "txtgrade_adt"
        Me.txtgrade_adt.Size = New System.Drawing.Size(132, 22)
        Me.txtgrade_adt.TabIndex = 472
        '
        'lblgrade_adt
        '
        Me.lblgrade_adt.AutoSize = True
        Me.lblgrade_adt.Location = New System.Drawing.Point(62, 303)
        Me.lblgrade_adt.Name = "lblgrade_adt"
        Me.lblgrade_adt.Size = New System.Drawing.Size(97, 13)
        Me.lblgrade_adt.TabIndex = 497
        Me.lblgrade_adt.Text = "Grade of Dye Test"
        '
        'txtgrade_bdt
        '
        Me.txtgrade_bdt.Location = New System.Drawing.Point(171, 261)
        Me.txtgrade_bdt.Name = "txtgrade_bdt"
        Me.txtgrade_bdt.Size = New System.Drawing.Size(132, 22)
        Me.txtgrade_bdt.TabIndex = 471
        '
        'lblgrade_bdt
        '
        Me.lblgrade_bdt.AutoSize = True
        Me.lblgrade_bdt.Location = New System.Drawing.Point(56, 264)
        Me.lblgrade_bdt.Name = "lblgrade_bdt"
        Me.lblgrade_bdt.Size = New System.Drawing.Size(109, 13)
        Me.lblgrade_bdt.TabIndex = 496
        Me.lblgrade_bdt.Text = "Grade of Inspection"
        '
        'txtlot
        '
        Me.txtlot.Location = New System.Drawing.Point(171, 222)
        Me.txtlot.Name = "txtlot"
        Me.txtlot.Size = New System.Drawing.Size(132, 22)
        Me.txtlot.TabIndex = 470
        '
        'lbllot
        '
        Me.lbllot.AutoSize = True
        Me.lbllot.Location = New System.Drawing.Point(108, 225)
        Me.lbllot.Name = "lbllot"
        Me.lbllot.Size = New System.Drawing.Size(48, 13)
        Me.lbllot.TabIndex = 495
        Me.lbllot.Text = "Yarn Set"
        '
        'txtgwth
        '
        Me.txtgwth.Location = New System.Drawing.Point(171, 193)
        Me.txtgwth.Name = "txtgwth"
        Me.txtgwth.Size = New System.Drawing.Size(132, 22)
        Me.txtgwth.TabIndex = 469
        '
        'lblgwth
        '
        Me.lblgwth.AutoSize = True
        Me.lblgwth.Location = New System.Drawing.Point(56, 196)
        Me.lblgwth.Name = "lblgwth"
        Me.lblgwth.Size = New System.Drawing.Size(107, 13)
        Me.lblgwth.TabIndex = 494
        Me.lblgwth.Text = "Greige Width (cms.)"
        '
        'txtbar_weight
        '
        Me.txtbar_weight.Location = New System.Drawing.Point(171, 166)
        Me.txtbar_weight.Name = "txtbar_weight"
        Me.txtbar_weight.Size = New System.Drawing.Size(132, 22)
        Me.txtbar_weight.TabIndex = 468
        '
        'lbltran_dt
        '
        Me.lbltran_dt.AutoSize = True
        Me.lbltran_dt.Location = New System.Drawing.Point(16, 52)
        Me.lbltran_dt.Name = "lbltran_dt"
        Me.lbltran_dt.Size = New System.Drawing.Size(53, 13)
        Me.lbltran_dt.TabIndex = 302
        Me.lbltran_dt.Text = "GIN Date"
        '
        'txtdesign_no
        '
        Me.txtdesign_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtdesign_no.Location = New System.Drawing.Point(344, 20)
        Me.txtdesign_no.Name = "txtdesign_no"
        Me.txtdesign_no.ReadOnly = True
        Me.txtdesign_no.Size = New System.Drawing.Size(132, 20)
        Me.txtdesign_no.TabIndex = 305
        '
        'lbldesign_no
        '
        Me.lbldesign_no.AutoSize = True
        Me.lbldesign_no.Location = New System.Drawing.Point(265, 20)
        Me.lbldesign_no.Name = "lbldesign_no"
        Me.lbldesign_no.Size = New System.Drawing.Size(64, 13)
        Me.lbldesign_no.TabIndex = 306
        Me.lbldesign_no.Text = "Design No."
        '
        'lblpcv_item_id
        '
        Me.lblpcv_item_id.AutoSize = True
        Me.lblpcv_item_id.Location = New System.Drawing.Point(79, 144)
        Me.lblpcv_item_id.Name = "lblpcv_item_id"
        Me.lblpcv_item_id.Size = New System.Drawing.Size(71, 13)
        Me.lblpcv_item_id.TabIndex = 493
        Me.lblpcv_item_id.Text = "Bar  (รหัสแกน)"
        '
        'txtynchgcd
        '
        Me.txtynchgcd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtynchgcd.Location = New System.Drawing.Point(343, 52)
        Me.txtynchgcd.Name = "txtynchgcd"
        Me.txtynchgcd.ReadOnly = True
        Me.txtynchgcd.Size = New System.Drawing.Size(132, 20)
        Me.txtynchgcd.TabIndex = 307
        '
        'lblynchgcd
        '
        Me.lblynchgcd.AutoSize = True
        Me.lblynchgcd.Location = New System.Drawing.Point(271, 56)
        Me.lblynchgcd.Name = "lblynchgcd"
        Me.lblynchgcd.Size = New System.Drawing.Size(33, 13)
        Me.lblynchgcd.TabIndex = 308
        Me.lblynchgcd.Text = "BOM"
        '
        'txtkg
        '
        Me.txtkg.Location = New System.Drawing.Point(171, 115)
        Me.txtkg.Name = "txtkg"
        Me.txtkg.Size = New System.Drawing.Size(132, 22)
        Me.txtkg.TabIndex = 466
        '
        'lblkg
        '
        Me.lblkg.AutoSize = True
        Me.lblkg.Location = New System.Drawing.Point(85, 118)
        Me.lblkg.Name = "lblkg"
        Me.lblkg.Size = New System.Drawing.Size(75, 13)
        Me.lblkg.TabIndex = 492
        Me.lblkg.Text = "Weight (Kgs.)"
        '
        'dtptran_dt
        '
        Me.dtptran_dt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtptran_dt.Location = New System.Drawing.Point(83, 50)
        Me.dtptran_dt.Name = "dtptran_dt"
        Me.dtptran_dt.Size = New System.Drawing.Size(132, 22)
        Me.dtptran_dt.TabIndex = 289
        '
        'GbProdcutionInformations
        '
        Me.GbProdcutionInformations.Controls.Add(Me.lblmcno)
        Me.GbProdcutionInformations.Controls.Add(Me.txtmcno)
        Me.GbProdcutionInformations.Controls.Add(Me.btnSearchOutNo)
        Me.GbProdcutionInformations.Controls.Add(Me.lblkono)
        Me.GbProdcutionInformations.Controls.Add(Me.txtkono)
        Me.GbProdcutionInformations.Controls.Add(Me.txtdesign_no)
        Me.GbProdcutionInformations.Controls.Add(Me.lbldesign_no)
        Me.GbProdcutionInformations.Controls.Add(Me.txtynchgcd)
        Me.GbProdcutionInformations.Controls.Add(Me.lblynchgcd)
        Me.GbProdcutionInformations.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbProdcutionInformations.Location = New System.Drawing.Point(12, 28)
        Me.GbProdcutionInformations.Name = "GbProdcutionInformations"
        Me.GbProdcutionInformations.Size = New System.Drawing.Size(579, 79)
        Me.GbProdcutionInformations.TabIndex = 488
        Me.GbProdcutionInformations.TabStop = False
        Me.GbProdcutionInformations.Text = "Production Information"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txtlot_grade
        '
        Me.txtlot_grade.Location = New System.Drawing.Point(171, 338)
        Me.txtlot_grade.Name = "txtlot_grade"
        Me.txtlot_grade.ReadOnly = True
        Me.txtlot_grade.Size = New System.Drawing.Size(132, 22)
        Me.txtlot_grade.TabIndex = 554
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = True
        Me.lblGrade.Location = New System.Drawing.Point(117, 338)
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(41, 13)
        Me.lblGrade.TabIndex = 555
        Me.lblGrade.Text = "Grade:"
        '
        'lblrpm
        '
        Me.lblrpm.AutoSize = True
        Me.lblrpm.Location = New System.Drawing.Point(404, 289)
        Me.lblrpm.Name = "lblrpm"
        Me.lblrpm.Size = New System.Drawing.Size(30, 13)
        Me.lblrpm.TabIndex = 589
        Me.lblrpm.Text = "RPM"
        '
        'lblcounter_per_roll
        '
        Me.lblcounter_per_roll.AutoSize = True
        Me.lblcounter_per_roll.Location = New System.Drawing.Point(359, 262)
        Me.lblcounter_per_roll.Name = "lblcounter_per_roll"
        Me.lblcounter_per_roll.Size = New System.Drawing.Size(82, 13)
        Me.lblcounter_per_roll.TabIndex = 588
        Me.lblcounter_per_roll.Text = "Counter / Roll."
        '
        'txtrpm
        '
        Me.txtrpm.Location = New System.Drawing.Point(441, 287)
        Me.txtrpm.Name = "txtrpm"
        Me.txtrpm.Size = New System.Drawing.Size(119, 22)
        Me.txtrpm.TabIndex = 587
        '
        'txtcounter_per_roll
        '
        Me.txtcounter_per_roll.Location = New System.Drawing.Point(441, 259)
        Me.txtcounter_per_roll.Name = "txtcounter_per_roll"
        Me.txtcounter_per_roll.Size = New System.Drawing.Size(119, 22)
        Me.txtcounter_per_roll.TabIndex = 586
        '
        'GbGreigeDetail
        '
        Me.GbGreigeDetail.Controls.Add(Me.txtroll_no)
        Me.GbGreigeDetail.Controls.Add(Me.lblrpm)
        Me.GbGreigeDetail.Controls.Add(Me.lblkg)
        Me.GbGreigeDetail.Controls.Add(Me.txtrem_qc)
        Me.GbGreigeDetail.Controls.Add(Me.lblrem_qc)
        Me.GbGreigeDetail.Controls.Add(Me.lblcounter_per_roll)
        Me.GbGreigeDetail.Controls.Add(Me.txtkg)
        Me.GbGreigeDetail.Controls.Add(Me.txtrpm)
        Me.GbGreigeDetail.Controls.Add(Me.lblpcv_item_id)
        Me.GbGreigeDetail.Controls.Add(Me.txtcounter_per_roll)
        Me.GbGreigeDetail.Controls.Add(Me.txtbar_weight)
        Me.GbGreigeDetail.Controls.Add(Me.txtProdFinishTime)
        Me.GbGreigeDetail.Controls.Add(Me.txtlot_grade)
        Me.GbGreigeDetail.Controls.Add(Me.lblgwth)
        Me.GbGreigeDetail.Controls.Add(Me.lblGrade)
        Me.GbGreigeDetail.Controls.Add(Me.dtpProdFinishDate)
        Me.GbGreigeDetail.Controls.Add(Me.txtgwth)
        Me.GbGreigeDetail.Controls.Add(Me.chkdyeing_pass)
        Me.GbGreigeDetail.Controls.Add(Me.lbllot)
        Me.GbGreigeDetail.Controls.Add(Me.Label2)
        Me.GbGreigeDetail.Controls.Add(Me.txtlot)
        Me.GbGreigeDetail.Controls.Add(Me.txtdefect_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.cbomtl_subinventory)
        Me.GbGreigeDetail.Controls.Add(Me.lbldefect_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.lblgrade_bdt)
        Me.GbGreigeDetail.Controls.Add(Me.txtlab_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.cbopcv_item_id)
        Me.GbGreigeDetail.Controls.Add(Me.lbllab_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.txtgrade_bdt)
        Me.GbGreigeDetail.Controls.Add(Me.txtdyed_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.lblbar_weight)
        Me.GbGreigeDetail.Controls.Add(Me.lbldyed_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.lblgrade_adt)
        Me.GbGreigeDetail.Controls.Add(Me.txtqc_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.cbomtl_location)
        Me.GbGreigeDetail.Controls.Add(Me.lblqc_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.txtgrade_adt)
        Me.GbGreigeDetail.Controls.Add(Me.lbladjust_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.Label1)
        Me.GbGreigeDetail.Controls.Add(Me.txtadjust_loss_kg)
        Me.GbGreigeDetail.Controls.Add(Me.lblcliped)
        Me.GbGreigeDetail.Controls.Add(Me.lbldyeing_pass)
        Me.GbGreigeDetail.Controls.Add(Me.lblmtl_warehouse_id)
        Me.GbGreigeDetail.Controls.Add(Me.lblProdFinishTime)
        Me.GbGreigeDetail.Controls.Add(Me.lblshift)
        Me.GbGreigeDetail.Controls.Add(Me.lblProdFinishDate)
        Me.GbGreigeDetail.Controls.Add(Me.cbomtl_warehouse)
        Me.GbGreigeDetail.Controls.Add(Me.txtshift)
        Me.GbGreigeDetail.Controls.Add(Me.chkGMK)
        Me.GbGreigeDetail.Controls.Add(Me.chkcliped)
        Me.GbGreigeDetail.Controls.Add(Me.chkEsc)
        Me.GbGreigeDetail.Controls.Add(Me.lblroll_no)
        Me.GbGreigeDetail.Controls.Add(Me.txtroll_no_o)
        Me.GbGreigeDetail.Controls.Add(Me.lblroll_no_o)
        Me.GbGreigeDetail.Controls.Add(Me.lblmts)
        Me.GbGreigeDetail.Controls.Add(Me.txtmts)
        Me.GbGreigeDetail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbGreigeDetail.Location = New System.Drawing.Point(12, 113)
        Me.GbGreigeDetail.Name = "GbGreigeDetail"
        Me.GbGreigeDetail.Size = New System.Drawing.Size(579, 505)
        Me.GbGreigeDetail.TabIndex = 590
        Me.GbGreigeDetail.TabStop = False
        Me.GbGreigeDetail.Text = "Greige Detail"
        '
        'gbSteam
        '
        Me.gbSteam.Controls.Add(Me.txtsteam_instruction)
        Me.gbSteam.Controls.Add(Me.dtpsteam_date)
        Me.gbSteam.Controls.Add(Me.lblsteam_instruction)
        Me.gbSteam.Controls.Add(Me.lblsteam_date)
        Me.gbSteam.Controls.Add(Me.dtpsteam_time)
        Me.gbSteam.Controls.Add(Me.Label3)
        Me.gbSteam.Controls.Add(Me.txtsteam_condition)
        Me.gbSteam.Controls.Add(Me.lblsteam_condition)
        Me.gbSteam.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbSteam.Location = New System.Drawing.Point(613, 377)
        Me.gbSteam.Name = "gbSteam"
        Me.gbSteam.Size = New System.Drawing.Size(284, 236)
        Me.gbSteam.TabIndex = 591
        Me.gbSteam.TabStop = False
        Me.gbSteam.Text = "Steam Detail"
        '
        'txtsteam_instruction
        '
        Me.txtsteam_instruction.Location = New System.Drawing.Point(112, 109)
        Me.txtsteam_instruction.Multiline = True
        Me.txtsteam_instruction.Name = "txtsteam_instruction"
        Me.txtsteam_instruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtsteam_instruction.Size = New System.Drawing.Size(119, 89)
        Me.txtsteam_instruction.TabIndex = 69
        '
        'dtpsteam_date
        '
        Me.dtpsteam_date.Checked = False
        Me.dtpsteam_date.CustomFormat = "dd/MM/yyyy"
        Me.dtpsteam_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpsteam_date.Location = New System.Drawing.Point(112, 24)
        Me.dtpsteam_date.Name = "dtpsteam_date"
        Me.dtpsteam_date.ShowCheckBox = True
        Me.dtpsteam_date.Size = New System.Drawing.Size(119, 22)
        Me.dtpsteam_date.TabIndex = 547
        '
        'lblsteam_instruction
        '
        Me.lblsteam_instruction.AutoSize = True
        Me.lblsteam_instruction.Location = New System.Drawing.Point(13, 109)
        Me.lblsteam_instruction.Name = "lblsteam_instruction"
        Me.lblsteam_instruction.Size = New System.Drawing.Size(97, 13)
        Me.lblsteam_instruction.TabIndex = 70
        Me.lblsteam_instruction.Text = "Steam Instruction"
        '
        'lblsteam_date
        '
        Me.lblsteam_date.AutoSize = True
        Me.lblsteam_date.Location = New System.Drawing.Point(33, 24)
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
        Me.dtpsteam_time.Location = New System.Drawing.Point(112, 48)
        Me.dtpsteam_time.Name = "dtpsteam_time"
        Me.dtpsteam_time.ShowCheckBox = True
        Me.dtpsteam_time.ShowUpDown = True
        Me.dtpsteam_time.Size = New System.Drawing.Size(119, 22)
        Me.dtpsteam_time.TabIndex = 548
        Me.dtpsteam_time.Value = New Date(2016, 6, 29, 10, 12, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 566
        Me.Label3.Text = "Steam Time:"
        '
        'txtsteam_condition
        '
        Me.txtsteam_condition.Location = New System.Drawing.Point(112, 74)
        Me.txtsteam_condition.Name = "txtsteam_condition"
        Me.txtsteam_condition.Size = New System.Drawing.Size(119, 22)
        Me.txtsteam_condition.TabIndex = 545
        '
        'lblsteam_condition
        '
        Me.lblsteam_condition.AutoSize = True
        Me.lblsteam_condition.Location = New System.Drawing.Point(15, 77)
        Me.lblsteam_condition.Name = "lblsteam_condition"
        Me.lblsteam_condition.Size = New System.Drawing.Size(96, 13)
        Me.lblsteam_condition.TabIndex = 565
        Me.lblsteam_condition.Text = "Steam Condition:"
        '
        'GbGINDocuments
        '
        Me.GbGINDocuments.Controls.Add(Me.txttran_no)
        Me.GbGINDocuments.Controls.Add(Me.lbltran_dt)
        Me.GbGINDocuments.Controls.Add(Me.dtptran_dt)
        Me.GbGINDocuments.Controls.Add(Me.lbltran_no)
        Me.GbGINDocuments.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbGINDocuments.Location = New System.Drawing.Point(669, 21)
        Me.GbGINDocuments.Name = "GbGINDocuments"
        Me.GbGINDocuments.Size = New System.Drawing.Size(228, 79)
        Me.GbGINDocuments.TabIndex = 592
        Me.GbGINDocuments.TabStop = False
        Me.GbGINDocuments.Text = "GIN Documents"
        '
        'frmStockGIN_KOManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 623)
        Me.Controls.Add(Me.GbGINDocuments)
        Me.Controls.Add(Me.gbSteam)
        Me.Controls.Add(Me.GbGreigeDetail)
        Me.Controls.Add(Me.gbDefect)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GbProdcutionInformations)
        Me.Name = "frmStockGIN_KOManual"
        Me.Text = "Greige IN Knitting"
        CType(Me.grdDefect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDefect.ResumeLayout(False)
        Me.gbDefect.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GbProdcutionInformations.ResumeLayout(False)
        Me.GbProdcutionInformations.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbGreigeDetail.ResumeLayout(False)
        Me.GbGreigeDetail.PerformLayout()
        Me.gbSteam.ResumeLayout(False)
        Me.gbSteam.PerformLayout()
        Me.GbGINDocuments.ResumeLayout(False)
        Me.GbGINDocuments.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmcno As System.Windows.Forms.Label
    Friend WithEvents btnSearchOutNo As System.Windows.Forms.Button
    Friend WithEvents lblkono As System.Windows.Forms.Label
    Friend WithEvents lbltran_no As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents grdDefect As System.Windows.Forms.DataGridView
    Friend WithEvents id_defect_roll As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_code As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Defect_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents defect_details As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock_code As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtmcno As System.Windows.Forms.TextBox
    Friend WithEvents txtProdFinishTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbomtl_subinventory As System.Windows.Forms.ComboBox
    Friend WithEvents cbopcv_item_id As System.Windows.Forms.ComboBox
    Friend WithEvents lblbar_weight As System.Windows.Forms.Label
    Friend WithEvents cbomtl_location As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents chkGMK As System.Windows.Forms.RadioButton
    Friend WithEvents chkEsc As System.Windows.Forms.RadioButton
    Friend WithEvents gbDefect As System.Windows.Forms.GroupBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents txtdefect_details As System.Windows.Forms.TextBox
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents cbodefect_code As System.Windows.Forms.ComboBox
    Friend WithEvents lblDefect_code As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblmts As System.Windows.Forms.Label
    Friend WithEvents txtmts As System.Windows.Forms.TextBox
    Friend WithEvents lblroll_no_o As System.Windows.Forms.Label
    Friend WithEvents txtroll_no_o As System.Windows.Forms.TextBox
    Friend WithEvents lblroll_no As System.Windows.Forms.Label
    Friend WithEvents txtroll_no As System.Windows.Forms.TextBox
    Friend WithEvents txtkono As System.Windows.Forms.TextBox
    Friend WithEvents dtpProdFinishDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkdyeing_pass As System.Windows.Forms.CheckBox
    Friend WithEvents txtrem_qc As System.Windows.Forms.TextBox
    Friend WithEvents lblrem_qc As System.Windows.Forms.Label
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
    Friend WithEvents chkcliped As System.Windows.Forms.CheckBox
    Friend WithEvents txtshift As System.Windows.Forms.TextBox
    Friend WithEvents lblshift As System.Windows.Forms.Label
    Friend WithEvents lblcliped As System.Windows.Forms.Label
    Friend WithEvents txttran_no As System.Windows.Forms.TextBox
    Friend WithEvents txtgrade_adt As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade_adt As System.Windows.Forms.Label
    Friend WithEvents txtgrade_bdt As System.Windows.Forms.TextBox
    Friend WithEvents lblgrade_bdt As System.Windows.Forms.Label
    Friend WithEvents txtlot As System.Windows.Forms.TextBox
    Friend WithEvents lbllot As System.Windows.Forms.Label
    Friend WithEvents txtgwth As System.Windows.Forms.TextBox
    Friend WithEvents lblgwth As System.Windows.Forms.Label
    Friend WithEvents txtbar_weight As System.Windows.Forms.TextBox
    Friend WithEvents lbltran_dt As System.Windows.Forms.Label
    Friend WithEvents txtdesign_no As System.Windows.Forms.TextBox
    Friend WithEvents lbldesign_no As System.Windows.Forms.Label
    Friend WithEvents lblpcv_item_id As System.Windows.Forms.Label
    Friend WithEvents txtynchgcd As System.Windows.Forms.TextBox
    Friend WithEvents lblynchgcd As System.Windows.Forms.Label
    Friend WithEvents txtkg As System.Windows.Forms.TextBox
    Friend WithEvents lblkg As System.Windows.Forms.Label
    Friend WithEvents dtptran_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents GbProdcutionInformations As System.Windows.Forms.GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtlot_grade As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblrpm As Label
    Friend WithEvents lblcounter_per_roll As Label
    Friend WithEvents txtrpm As TextBox
    Friend WithEvents txtcounter_per_roll As TextBox
    Friend WithEvents GbGreigeDetail As GroupBox
    Friend WithEvents gbSteam As GroupBox
    Friend WithEvents txtsteam_instruction As TextBox
    Friend WithEvents dtpsteam_date As DateTimePicker
    Friend WithEvents lblsteam_instruction As Label
    Friend WithEvents lblsteam_date As Label
    Friend WithEvents dtpsteam_time As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsteam_condition As TextBox
    Friend WithEvents lblsteam_condition As Label
    Friend WithEvents GbGINDocuments As GroupBox
End Class
