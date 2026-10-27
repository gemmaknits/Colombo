<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOperationWarp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOperationWarp))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.gbSystemRoll = New System.Windows.Forms.GroupBox()
        Me.lblsystem_lot_number = New System.Windows.Forms.Label()
        Me.txtsystem_lot_number = New System.Windows.Forms.TextBox()
        Me.gbProduction = New System.Windows.Forms.GroupBox()
        Me.cbomfg_production_steps_id = New System.Windows.Forms.ComboBox()
        Me.cbomcno = New System.Windows.Forms.ComboBox()
        Me.txtBOM = New System.Windows.Forms.TextBox()
        Me.lblynchgcd = New System.Windows.Forms.Label()
        Me.txtproduction_order_no = New System.Windows.Forms.TextBox()
        Me.txtinventory_item_code = New System.Windows.Forms.TextBox()
        Me.cbooperator = New System.Windows.Forms.ComboBox()
        Me.lblPROD = New System.Windows.Forms.Label()
        Me.lblmcno = New System.Windows.Forms.Label()
        Me.lblDesignNo = New System.Windows.Forms.Label()
        Me.lblStep = New System.Windows.Forms.Label()
        Me.lbloperator = New System.Windows.Forms.Label()
        Me.txtBoxno = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbltran_no = New System.Windows.Forms.Label()
        Me.txtdocno = New System.Windows.Forms.TextBox()
        Me.lbltran_dt = New System.Windows.Forms.Label()
        Me.dtpdocdt = New System.Windows.Forms.DateTimePicker()
        Me.btnYarnIn = New System.Windows.Forms.Button()
        Me.lblWeightBefore = New System.Windows.Forms.Label()
        Me.lblWeightAfter = New System.Windows.Forms.Label()
        Me.lblqc_remarks = New System.Windows.Forms.Label()
        Me.txtbobbin_weight_before = New System.Windows.Forms.TextBox()
        Me.txtbobbin_weight_after = New System.Windows.Forms.TextBox()
        Me.txtBoxRemark = New System.Windows.Forms.TextBox()
        Me.txtbobbin_tear_weight = New System.Windows.Forms.TextBox()
        Me.lblbobbin_tear_weight = New System.Windows.Forms.Label()
        Me.txtbeam_tear_weight = New System.Windows.Forms.TextBox()
        Me.lblbeam_tear_weight = New System.Windows.Forms.Label()
        Me.txtbeam_total_weight = New System.Windows.Forms.TextBox()
        Me.lblbeam_total_weight = New System.Windows.Forms.Label()
        Me.txtwarped_ends = New System.Windows.Forms.TextBox()
        Me.lblwarped_ends = New System.Windows.Forms.Label()
        Me.txtbeams_per_set = New System.Windows.Forms.TextBox()
        Me.lblbeams_per_set = New System.Windows.Forms.Label()
        Me.gbMaterial = New System.Windows.Forms.GroupBox()
        Me.lblmtl_location = New System.Windows.Forms.Label()
        Me.cbomtl_warehouse = New System.Windows.Forms.ComboBox()
        Me.cbomtl_locations = New System.Windows.Forms.ComboBox()
        Me.lblmtl_warehouse_id = New System.Windows.Forms.Label()
        Me.BtnYarnPrintBar = New System.Windows.Forms.Button()
        Me.BtnYarnPrintDoc = New System.Windows.Forms.Button()
        Me.btnLocations = New System.Windows.Forms.Button()
        Me.txtkg_gr = New System.Windows.Forms.TextBox()
        Me.lblKg_gr = New System.Windows.Forms.Label()
        Me.txtactual_cone_weight = New System.Windows.Forms.TextBox()
        Me.lblactual_cone_weight = New System.Windows.Forms.Label()
        Me.chkAutoCalculate = New System.Windows.Forms.CheckBox()
        Me.GbDetail = New System.Windows.Forms.GroupBox()
        Me.txtlotno_our = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtlotno_sup = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboMtlSubinventory = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.gbSystemRoll.SuspendLayout()
        Me.gbProduction.SuspendLayout()
        Me.gbMaterial.SuspendLayout()
        Me.GbDetail.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnSearch, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1042, 25)
        Me.ToolStrip1.TabIndex = 500
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
        'gbSystemRoll
        '
        Me.gbSystemRoll.Controls.Add(Me.lblsystem_lot_number)
        Me.gbSystemRoll.Controls.Add(Me.txtsystem_lot_number)
        Me.gbSystemRoll.Location = New System.Drawing.Point(24, 45)
        Me.gbSystemRoll.Name = "gbSystemRoll"
        Me.gbSystemRoll.Size = New System.Drawing.Size(269, 92)
        Me.gbSystemRoll.TabIndex = 504
        Me.gbSystemRoll.TabStop = False
        Me.gbSystemRoll.Text = "Scan Barcode"
        '
        'lblsystem_lot_number
        '
        Me.lblsystem_lot_number.AutoSize = True
        Me.lblsystem_lot_number.Location = New System.Drawing.Point(22, 43)
        Me.lblsystem_lot_number.Name = "lblsystem_lot_number"
        Me.lblsystem_lot_number.Size = New System.Drawing.Size(44, 13)
        Me.lblsystem_lot_number.TabIndex = 45
        Me.lblsystem_lot_number.Text = "Set No."
        '
        'txtsystem_lot_number
        '
        Me.txtsystem_lot_number.Location = New System.Drawing.Point(110, 43)
        Me.txtsystem_lot_number.Name = "txtsystem_lot_number"
        Me.txtsystem_lot_number.Size = New System.Drawing.Size(132, 22)
        Me.txtsystem_lot_number.TabIndex = 1
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
        Me.gbProduction.Location = New System.Drawing.Point(317, 45)
        Me.gbProduction.Name = "gbProduction"
        Me.gbProduction.Size = New System.Drawing.Size(486, 103)
        Me.gbProduction.TabIndex = 511
        Me.gbProduction.TabStop = False
        Me.gbProduction.Text = "Production Detail"
        '
        'cbomfg_production_steps_id
        '
        Me.cbomfg_production_steps_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbomfg_production_steps_id.FormattingEnabled = True
        Me.cbomfg_production_steps_id.Location = New System.Drawing.Point(103, 65)
        Me.cbomfg_production_steps_id.Name = "cbomfg_production_steps_id"
        Me.cbomfg_production_steps_id.Size = New System.Drawing.Size(163, 21)
        Me.cbomfg_production_steps_id.TabIndex = 309
        '
        'cbomcno
        '
        Me.cbomcno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomcno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomcno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbomcno.FormattingEnabled = True
        Me.cbomcno.Location = New System.Drawing.Point(102, 40)
        Me.cbomcno.Name = "cbomcno"
        Me.cbomcno.Size = New System.Drawing.Size(162, 21)
        Me.cbomcno.TabIndex = 78
        '
        'txtBOM
        '
        Me.txtBOM.Location = New System.Drawing.Point(336, 37)
        Me.txtBOM.Name = "txtBOM"
        Me.txtBOM.ReadOnly = True
        Me.txtBOM.Size = New System.Drawing.Size(131, 22)
        Me.txtBOM.TabIndex = 74
        '
        'lblynchgcd
        '
        Me.lblynchgcd.AutoSize = True
        Me.lblynchgcd.Location = New System.Drawing.Point(297, 40)
        Me.lblynchgcd.Name = "lblynchgcd"
        Me.lblynchgcd.Size = New System.Drawing.Size(36, 13)
        Me.lblynchgcd.TabIndex = 308
        Me.lblynchgcd.Text = "BOM:"
        '
        'txtproduction_order_no
        '
        Me.txtproduction_order_no.Location = New System.Drawing.Point(102, 17)
        Me.txtproduction_order_no.Name = "txtproduction_order_no"
        Me.txtproduction_order_no.ReadOnly = True
        Me.txtproduction_order_no.Size = New System.Drawing.Size(162, 22)
        Me.txtproduction_order_no.TabIndex = 44
        '
        'txtinventory_item_code
        '
        Me.txtinventory_item_code.Location = New System.Drawing.Point(336, 14)
        Me.txtinventory_item_code.Name = "txtinventory_item_code"
        Me.txtinventory_item_code.ReadOnly = True
        Me.txtinventory_item_code.Size = New System.Drawing.Size(131, 22)
        Me.txtinventory_item_code.TabIndex = 48
        '
        'cbooperator
        '
        Me.cbooperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbooperator.Enabled = False
        Me.cbooperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        'lblmcno
        '
        Me.lblmcno.AutoSize = True
        Me.lblmcno.Location = New System.Drawing.Point(29, 37)
        Me.lblmcno.Name = "lblmcno"
        Me.lblmcno.Size = New System.Drawing.Size(54, 13)
        Me.lblmcno.TabIndex = 58
        Me.lblmcno.Text = "Machine:"
        '
        'lblDesignNo
        '
        Me.lblDesignNo.AutoSize = True
        Me.lblDesignNo.Location = New System.Drawing.Point(280, 17)
        Me.lblDesignNo.Name = "lblDesignNo"
        Me.lblDesignNo.Size = New System.Drawing.Size(50, 13)
        Me.lblDesignNo.TabIndex = 47
        Me.lblDesignNo.Text = "Item No:"
        '
        'lblStep
        '
        Me.lblStep.AutoSize = True
        Me.lblStep.Location = New System.Drawing.Point(39, 65)
        Me.lblStep.Name = "lblStep"
        Me.lblStep.Size = New System.Drawing.Size(36, 13)
        Me.lblStep.TabIndex = 45
        Me.lblStep.Text = "Step :"
        '
        'lbloperator
        '
        Me.lbloperator.AutoSize = True
        Me.lbloperator.Location = New System.Drawing.Point(273, 69)
        Me.lbloperator.Name = "lbloperator"
        Me.lbloperator.Size = New System.Drawing.Size(57, 13)
        Me.lbloperator.TabIndex = 67
        Me.lbloperator.Text = "Operator:"
        '
        'txtBoxno
        '
        Me.txtBoxno.Location = New System.Drawing.Point(92, 68)
        Me.txtBoxno.Name = "txtBoxno"
        Me.txtBoxno.ReadOnly = True
        Me.txtBoxno.Size = New System.Drawing.Size(111, 22)
        Me.txtBoxno.TabIndex = 316
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 315
        Me.Label3.Text = "Box / Set No."
        '
        'lbltran_no
        '
        Me.lbltran_no.AutoSize = True
        Me.lbltran_no.Location = New System.Drawing.Point(18, 17)
        Me.lbltran_no.Name = "lbltran_no"
        Me.lbltran_no.Size = New System.Drawing.Size(44, 13)
        Me.lbltran_no.TabIndex = 312
        Me.lbltran_no.Text = "YIN No."
        '
        'txtdocno
        '
        Me.txtdocno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtdocno.Location = New System.Drawing.Point(92, 14)
        Me.txtdocno.Name = "txtdocno"
        Me.txtdocno.ReadOnly = True
        Me.txtdocno.Size = New System.Drawing.Size(111, 20)
        Me.txtdocno.TabIndex = 311
        '
        'lbltran_dt
        '
        Me.lbltran_dt.AutoSize = True
        Me.lbltran_dt.Location = New System.Drawing.Point(17, 43)
        Me.lbltran_dt.Name = "lbltran_dt"
        Me.lbltran_dt.Size = New System.Drawing.Size(31, 13)
        Me.lbltran_dt.TabIndex = 313
        Me.lbltran_dt.Text = "Date"
        '
        'dtpdocdt
        '
        Me.dtpdocdt.Checked = False
        Me.dtpdocdt.CustomFormat = "dd/MM/yyyy"
        Me.dtpdocdt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpdocdt.Location = New System.Drawing.Point(92, 40)
        Me.dtpdocdt.Name = "dtpdocdt"
        Me.dtpdocdt.ShowCheckBox = True
        Me.dtpdocdt.Size = New System.Drawing.Size(111, 22)
        Me.dtpdocdt.TabIndex = 310
        '
        'btnYarnIn
        '
        Me.btnYarnIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnYarnIn.Location = New System.Drawing.Point(360, 244)
        Me.btnYarnIn.Name = "btnYarnIn"
        Me.btnYarnIn.Size = New System.Drawing.Size(124, 34)
        Me.btnYarnIn.TabIndex = 533
        Me.btnYarnIn.Text = "Save Yarn In"
        Me.btnYarnIn.UseVisualStyleBackColor = True
        '
        'lblWeightBefore
        '
        Me.lblWeightBefore.AutoSize = True
        Me.lblWeightBefore.Location = New System.Drawing.Point(2, 47)
        Me.lblWeightBefore.Name = "lblWeightBefore"
        Me.lblWeightBefore.Size = New System.Drawing.Size(134, 13)
        Me.lblWeightBefore.TabIndex = 534
        Me.lblWeightBefore.Text = "Weight Before (Bobbins)"
        '
        'lblWeightAfter
        '
        Me.lblWeightAfter.AutoSize = True
        Me.lblWeightAfter.Location = New System.Drawing.Point(11, 84)
        Me.lblWeightAfter.Name = "lblWeightAfter"
        Me.lblWeightAfter.Size = New System.Drawing.Size(125, 13)
        Me.lblWeightAfter.TabIndex = 535
        Me.lblWeightAfter.Text = "Weight After (Bobbins)"
        '
        'lblqc_remarks
        '
        Me.lblqc_remarks.AutoSize = True
        Me.lblqc_remarks.Location = New System.Drawing.Point(296, 131)
        Me.lblqc_remarks.Name = "lblqc_remarks"
        Me.lblqc_remarks.Size = New System.Drawing.Size(45, 13)
        Me.lblqc_remarks.TabIndex = 536
        Me.lblqc_remarks.Text = "Remark"
        '
        'txtbobbin_weight_before
        '
        Me.txtbobbin_weight_before.Location = New System.Drawing.Point(142, 44)
        Me.txtbobbin_weight_before.Name = "txtbobbin_weight_before"
        Me.txtbobbin_weight_before.Size = New System.Drawing.Size(132, 22)
        Me.txtbobbin_weight_before.TabIndex = 537
        '
        'txtbobbin_weight_after
        '
        Me.txtbobbin_weight_after.Location = New System.Drawing.Point(142, 84)
        Me.txtbobbin_weight_after.Name = "txtbobbin_weight_after"
        Me.txtbobbin_weight_after.Size = New System.Drawing.Size(132, 22)
        Me.txtbobbin_weight_after.TabIndex = 538
        '
        'txtBoxRemark
        '
        Me.txtBoxRemark.Location = New System.Drawing.Point(360, 124)
        Me.txtBoxRemark.Multiline = True
        Me.txtBoxRemark.Name = "txtBoxRemark"
        Me.txtBoxRemark.Size = New System.Drawing.Size(199, 106)
        Me.txtBoxRemark.TabIndex = 539
        '
        'txtbobbin_tear_weight
        '
        Me.txtbobbin_tear_weight.Enabled = False
        Me.txtbobbin_tear_weight.Location = New System.Drawing.Point(142, 124)
        Me.txtbobbin_tear_weight.Name = "txtbobbin_tear_weight"
        Me.txtbobbin_tear_weight.Size = New System.Drawing.Size(132, 22)
        Me.txtbobbin_tear_weight.TabIndex = 541
        '
        'lblbobbin_tear_weight
        '
        Me.lblbobbin_tear_weight.AutoSize = True
        Me.lblbobbin_tear_weight.Location = New System.Drawing.Point(15, 127)
        Me.lblbobbin_tear_weight.Name = "lblbobbin_tear_weight"
        Me.lblbobbin_tear_weight.Size = New System.Drawing.Size(121, 13)
        Me.lblbobbin_tear_weight.TabIndex = 540
        Me.lblbobbin_tear_weight.Text = "Weight Tear (Bobbins)"
        '
        'txtbeam_tear_weight
        '
        Me.txtbeam_tear_weight.Enabled = False
        Me.txtbeam_tear_weight.Location = New System.Drawing.Point(142, 164)
        Me.txtbeam_tear_weight.Name = "txtbeam_tear_weight"
        Me.txtbeam_tear_weight.Size = New System.Drawing.Size(132, 22)
        Me.txtbeam_tear_weight.TabIndex = 543
        '
        'lblbeam_tear_weight
        '
        Me.lblbeam_tear_weight.AutoSize = True
        Me.lblbeam_tear_weight.Location = New System.Drawing.Point(67, 164)
        Me.lblbeam_tear_weight.Name = "lblbeam_tear_weight"
        Me.lblbeam_tear_weight.Size = New System.Drawing.Size(69, 13)
        Me.lblbeam_tear_weight.TabIndex = 542
        Me.lblbeam_tear_weight.Text = "Weight Tear"
        '
        'txtbeam_total_weight
        '
        Me.txtbeam_total_weight.Location = New System.Drawing.Point(142, 204)
        Me.txtbeam_total_weight.Name = "txtbeam_total_weight"
        Me.txtbeam_total_weight.Size = New System.Drawing.Size(132, 22)
        Me.txtbeam_total_weight.TabIndex = 545
        '
        'lblbeam_total_weight
        '
        Me.lblbeam_total_weight.AutoSize = True
        Me.lblbeam_total_weight.Location = New System.Drawing.Point(62, 204)
        Me.lblbeam_total_weight.Name = "lblbeam_total_weight"
        Me.lblbeam_total_weight.Size = New System.Drawing.Size(74, 13)
        Me.lblbeam_total_weight.TabIndex = 544
        Me.lblbeam_total_weight.Text = "ToTal Weight"
        '
        'txtwarped_ends
        '
        Me.txtwarped_ends.Location = New System.Drawing.Point(113, 32)
        Me.txtwarped_ends.Name = "txtwarped_ends"
        Me.txtwarped_ends.ReadOnly = True
        Me.txtwarped_ends.Size = New System.Drawing.Size(100, 22)
        Me.txtwarped_ends.TabIndex = 0
        '
        'lblwarped_ends
        '
        Me.lblwarped_ends.AutoSize = True
        Me.lblwarped_ends.Location = New System.Drawing.Point(44, 32)
        Me.lblwarped_ends.Name = "lblwarped_ends"
        Me.lblwarped_ends.Size = New System.Drawing.Size(32, 13)
        Me.lblwarped_ends.TabIndex = 547
        Me.lblwarped_ends.Text = "Ends"
        '
        'txtbeams_per_set
        '
        Me.txtbeams_per_set.Location = New System.Drawing.Point(293, 32)
        Me.txtbeams_per_set.Name = "txtbeams_per_set"
        Me.txtbeams_per_set.ReadOnly = True
        Me.txtbeams_per_set.Size = New System.Drawing.Size(100, 22)
        Me.txtbeams_per_set.TabIndex = 548
        '
        'lblbeams_per_set
        '
        Me.lblbeams_per_set.AutoSize = True
        Me.lblbeams_per_set.Location = New System.Drawing.Point(247, 32)
        Me.lblbeams_per_set.Name = "lblbeams_per_set"
        Me.lblbeams_per_set.Size = New System.Drawing.Size(35, 13)
        Me.lblbeams_per_set.TabIndex = 549
        Me.lblbeams_per_set.Text = "Beam"
        '
        'gbMaterial
        '
        Me.gbMaterial.Controls.Add(Me.txtbeams_per_set)
        Me.gbMaterial.Controls.Add(Me.lblbeams_per_set)
        Me.gbMaterial.Controls.Add(Me.lblwarped_ends)
        Me.gbMaterial.Controls.Add(Me.txtwarped_ends)
        Me.gbMaterial.Location = New System.Drawing.Point(24, 144)
        Me.gbMaterial.Name = "gbMaterial"
        Me.gbMaterial.Size = New System.Drawing.Size(422, 87)
        Me.gbMaterial.TabIndex = 550
        Me.gbMaterial.TabStop = False
        Me.gbMaterial.Text = "Material"
        '
        'lblmtl_location
        '
        Me.lblmtl_location.AutoSize = True
        Me.lblmtl_location.Location = New System.Drawing.Point(83, 411)
        Me.lblmtl_location.Name = "lblmtl_location"
        Me.lblmtl_location.Size = New System.Drawing.Size(54, 13)
        Me.lblmtl_location.TabIndex = 554
        Me.lblmtl_location.Text = "Location:"
        '
        'cbomtl_warehouse
        '
        Me.cbomtl_warehouse.Enabled = False
        Me.cbomtl_warehouse.FormattingEnabled = True
        Me.cbomtl_warehouse.Location = New System.Drawing.Point(142, 324)
        Me.cbomtl_warehouse.Name = "cbomtl_warehouse"
        Me.cbomtl_warehouse.Size = New System.Drawing.Size(133, 21)
        Me.cbomtl_warehouse.TabIndex = 551
        '
        'cbomtl_locations
        '
        Me.cbomtl_locations.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomtl_locations.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomtl_locations.Enabled = False
        Me.cbomtl_locations.FormattingEnabled = True
        Me.cbomtl_locations.Location = New System.Drawing.Point(142, 409)
        Me.cbomtl_locations.Name = "cbomtl_locations"
        Me.cbomtl_locations.Size = New System.Drawing.Size(132, 21)
        Me.cbomtl_locations.TabIndex = 552
        '
        'lblmtl_warehouse_id
        '
        Me.lblmtl_warehouse_id.AutoSize = True
        Me.lblmtl_warehouse_id.Location = New System.Drawing.Point(68, 327)
        Me.lblmtl_warehouse_id.Name = "lblmtl_warehouse_id"
        Me.lblmtl_warehouse_id.Size = New System.Drawing.Size(69, 13)
        Me.lblmtl_warehouse_id.TabIndex = 553
        Me.lblmtl_warehouse_id.Text = "Warehouse:"
        '
        'BtnYarnPrintBar
        '
        Me.BtnYarnPrintBar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnYarnPrintBar.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintBar.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYarnPrintBar.Location = New System.Drawing.Point(360, 337)
        Me.BtnYarnPrintBar.Name = "BtnYarnPrintBar"
        Me.BtnYarnPrintBar.Size = New System.Drawing.Size(124, 34)
        Me.BtnYarnPrintBar.TabIndex = 550
        Me.BtnYarnPrintBar.Text = "Print Bar Label"
        Me.BtnYarnPrintBar.UseVisualStyleBackColor = False
        '
        'BtnYarnPrintDoc
        '
        Me.BtnYarnPrintDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnYarnPrintDoc.BackColor = System.Drawing.Color.PeachPuff
        Me.BtnYarnPrintDoc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnYarnPrintDoc.Location = New System.Drawing.Point(360, 287)
        Me.BtnYarnPrintDoc.Name = "BtnYarnPrintDoc"
        Me.BtnYarnPrintDoc.Size = New System.Drawing.Size(124, 34)
        Me.BtnYarnPrintDoc.TabIndex = 555
        Me.BtnYarnPrintDoc.Text = "Print YIN document"
        Me.BtnYarnPrintDoc.UseVisualStyleBackColor = False
        '
        'btnLocations
        '
        Me.btnLocations.Location = New System.Drawing.Point(277, 599)
        Me.btnLocations.Name = "btnLocations"
        Me.btnLocations.Size = New System.Drawing.Size(23, 23)
        Me.btnLocations.TabIndex = 556
        Me.btnLocations.Text = "..."
        Me.btnLocations.UseVisualStyleBackColor = True
        '
        'txtkg_gr
        '
        Me.txtkg_gr.Location = New System.Drawing.Point(142, 244)
        Me.txtkg_gr.Name = "txtkg_gr"
        Me.txtkg_gr.Size = New System.Drawing.Size(132, 22)
        Me.txtkg_gr.TabIndex = 558
        '
        'lblKg_gr
        '
        Me.lblKg_gr.AutoSize = True
        Me.lblKg_gr.Location = New System.Drawing.Point(31, 247)
        Me.lblKg_gr.Name = "lblKg_gr"
        Me.lblKg_gr.Size = New System.Drawing.Size(106, 13)
        Me.lblKg_gr.TabIndex = 557
        Me.lblKg_gr.Text = "ToTal Gross Weight"
        '
        'txtactual_cone_weight
        '
        Me.txtactual_cone_weight.Location = New System.Drawing.Point(142, 284)
        Me.txtactual_cone_weight.Name = "txtactual_cone_weight"
        Me.txtactual_cone_weight.Size = New System.Drawing.Size(132, 22)
        Me.txtactual_cone_weight.TabIndex = 560
        '
        'lblactual_cone_weight
        '
        Me.lblactual_cone_weight.AutoSize = True
        Me.lblactual_cone_weight.Location = New System.Drawing.Point(27, 287)
        Me.lblactual_cone_weight.Name = "lblactual_cone_weight"
        Me.lblactual_cone_weight.Size = New System.Drawing.Size(113, 13)
        Me.lblactual_cone_weight.TabIndex = 559
        Me.lblactual_cone_weight.Text = "Actual Cone Weight "
        '
        'chkAutoCalculate
        '
        Me.chkAutoCalculate.Location = New System.Drawing.Point(79, -9)
        Me.chkAutoCalculate.Name = "chkAutoCalculate"
        Me.chkAutoCalculate.Size = New System.Drawing.Size(122, 32)
        Me.chkAutoCalculate.TabIndex = 561
        Me.chkAutoCalculate.Text = "Auto Calculate"
        Me.chkAutoCalculate.UseVisualStyleBackColor = True
        '
        'GbDetail
        '
        Me.GbDetail.Controls.Add(Me.txtlotno_our)
        Me.GbDetail.Controls.Add(Me.Label4)
        Me.GbDetail.Controls.Add(Me.txtlotno_sup)
        Me.GbDetail.Controls.Add(Me.Label2)
        Me.GbDetail.Controls.Add(Me.Label1)
        Me.GbDetail.Controls.Add(Me.CboMtlSubinventory)
        Me.GbDetail.Controls.Add(Me.BtnYarnPrintDoc)
        Me.GbDetail.Controls.Add(Me.txtBoxRemark)
        Me.GbDetail.Controls.Add(Me.BtnYarnPrintBar)
        Me.GbDetail.Controls.Add(Me.txtactual_cone_weight)
        Me.GbDetail.Controls.Add(Me.chkAutoCalculate)
        Me.GbDetail.Controls.Add(Me.btnYarnIn)
        Me.GbDetail.Controls.Add(Me.lblactual_cone_weight)
        Me.GbDetail.Controls.Add(Me.lblqc_remarks)
        Me.GbDetail.Controls.Add(Me.txtkg_gr)
        Me.GbDetail.Controls.Add(Me.cbomtl_locations)
        Me.GbDetail.Controls.Add(Me.lblKg_gr)
        Me.GbDetail.Controls.Add(Me.lblWeightBefore)
        Me.GbDetail.Controls.Add(Me.lblWeightAfter)
        Me.GbDetail.Controls.Add(Me.txtbobbin_weight_before)
        Me.GbDetail.Controls.Add(Me.txtbobbin_weight_after)
        Me.GbDetail.Controls.Add(Me.lblmtl_location)
        Me.GbDetail.Controls.Add(Me.lblbobbin_tear_weight)
        Me.GbDetail.Controls.Add(Me.cbomtl_warehouse)
        Me.GbDetail.Controls.Add(Me.txtbobbin_tear_weight)
        Me.GbDetail.Controls.Add(Me.lblbeam_tear_weight)
        Me.GbDetail.Controls.Add(Me.lblmtl_warehouse_id)
        Me.GbDetail.Controls.Add(Me.txtbeam_tear_weight)
        Me.GbDetail.Controls.Add(Me.lblbeam_total_weight)
        Me.GbDetail.Controls.Add(Me.txtbeam_total_weight)
        Me.GbDetail.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbDetail.Location = New System.Drawing.Point(24, 237)
        Me.GbDetail.Name = "GbDetail"
        Me.GbDetail.Size = New System.Drawing.Size(604, 471)
        Me.GbDetail.TabIndex = 562
        Me.GbDetail.TabStop = False
        Me.GbDetail.Text = "Detail"
        '
        'txtlotno_our
        '
        Me.txtlotno_our.Location = New System.Drawing.Point(360, 87)
        Me.txtlotno_our.Name = "txtlotno_our"
        Me.txtlotno_our.Size = New System.Drawing.Size(199, 22)
        Me.txtlotno_our.TabIndex = 567
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(301, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 566
        Me.Label4.Text = "Lot Our"
        '
        'txtlotno_sup
        '
        Me.txtlotno_sup.Location = New System.Drawing.Point(360, 47)
        Me.txtlotno_sup.Name = "txtlotno_sup"
        Me.txtlotno_sup.Size = New System.Drawing.Size(199, 22)
        Me.txtlotno_sup.TabIndex = 565
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(301, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 564
        Me.Label2.Text = "Lot Supp."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 563
        Me.Label1.Text = "Subinventory"
        '
        'CboMtlSubinventory
        '
        Me.CboMtlSubinventory.Enabled = False
        Me.CboMtlSubinventory.FormattingEnabled = True
        Me.CboMtlSubinventory.Location = New System.Drawing.Point(142, 364)
        Me.CboMtlSubinventory.Name = "CboMtlSubinventory"
        Me.CboMtlSubinventory.Size = New System.Drawing.Size(134, 21)
        Me.CboMtlSubinventory.TabIndex = 562
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoxno)
        Me.GroupBox1.Controls.Add(Me.txtdocno)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpdocdt)
        Me.GroupBox1.Controls.Add(Me.lbltran_dt)
        Me.GroupBox1.Controls.Add(Me.lbltran_no)
        Me.GroupBox1.Location = New System.Drawing.Point(809, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(219, 93)
        Me.GroupBox1.TabIndex = 563
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Document"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmOperationWarp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 736)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbDetail)
        Me.Controls.Add(Me.btnLocations)
        Me.Controls.Add(Me.gbMaterial)
        Me.Controls.Add(Me.gbProduction)
        Me.Controls.Add(Me.gbSystemRoll)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmOperationWarp"
        Me.Text = "Operation Warping"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbSystemRoll.ResumeLayout(False)
        Me.gbSystemRoll.PerformLayout()
        Me.gbProduction.ResumeLayout(False)
        Me.gbProduction.PerformLayout()
        Me.gbMaterial.ResumeLayout(False)
        Me.gbMaterial.PerformLayout()
        Me.GbDetail.ResumeLayout(False)
        Me.GbDetail.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents gbSystemRoll As System.Windows.Forms.GroupBox
    Friend WithEvents lblsystem_lot_number As System.Windows.Forms.Label
    Friend WithEvents txtsystem_lot_number As System.Windows.Forms.TextBox
    Friend WithEvents gbProduction As System.Windows.Forms.GroupBox
    Friend WithEvents lbltran_no As System.Windows.Forms.Label
    Friend WithEvents txtdocno As System.Windows.Forms.TextBox
    Friend WithEvents lbltran_dt As System.Windows.Forms.Label
    Friend WithEvents dtpdocdt As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbomfg_production_steps_id As System.Windows.Forms.ComboBox
    Friend WithEvents cbomcno As System.Windows.Forms.ComboBox
    Friend WithEvents txtBOM As System.Windows.Forms.TextBox
    Friend WithEvents lblynchgcd As System.Windows.Forms.Label
    Friend WithEvents txtproduction_order_no As System.Windows.Forms.TextBox
    Friend WithEvents txtinventory_item_code As System.Windows.Forms.TextBox
    Friend WithEvents lblPROD As System.Windows.Forms.Label
    Friend WithEvents lblmcno As System.Windows.Forms.Label
    Friend WithEvents lblDesignNo As System.Windows.Forms.Label
    Friend WithEvents lblStep As System.Windows.Forms.Label
    Friend WithEvents lbloperator As System.Windows.Forms.Label
    Friend WithEvents btnYarnIn As System.Windows.Forms.Button
    Friend WithEvents lblWeightBefore As System.Windows.Forms.Label
    Friend WithEvents lblWeightAfter As System.Windows.Forms.Label
    Friend WithEvents lblqc_remarks As System.Windows.Forms.Label
    Friend WithEvents txtbobbin_weight_before As System.Windows.Forms.TextBox
    Friend WithEvents txtbobbin_weight_after As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtbobbin_tear_weight As System.Windows.Forms.TextBox
    Friend WithEvents lblbobbin_tear_weight As System.Windows.Forms.Label
    Friend WithEvents txtbeam_tear_weight As System.Windows.Forms.TextBox
    Friend WithEvents lblbeam_tear_weight As System.Windows.Forms.Label
    Friend WithEvents txtbeam_total_weight As System.Windows.Forms.TextBox
    Friend WithEvents lblbeam_total_weight As System.Windows.Forms.Label
    Friend WithEvents txtwarped_ends As System.Windows.Forms.TextBox
    Friend WithEvents lblwarped_ends As System.Windows.Forms.Label
    Friend WithEvents txtbeams_per_set As System.Windows.Forms.TextBox
    Friend WithEvents lblbeams_per_set As System.Windows.Forms.Label
    Friend WithEvents gbMaterial As System.Windows.Forms.GroupBox
    Friend WithEvents lblmtl_location As System.Windows.Forms.Label
    Friend WithEvents cbomtl_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents cbomtl_locations As System.Windows.Forms.ComboBox
    Friend WithEvents lblmtl_warehouse_id As System.Windows.Forms.Label
    Friend WithEvents BtnYarnPrintBar As System.Windows.Forms.Button
    Friend WithEvents BtnYarnPrintDoc As System.Windows.Forms.Button
    Friend WithEvents btnLocations As System.Windows.Forms.Button
    Friend WithEvents txtkg_gr As System.Windows.Forms.TextBox
    Friend WithEvents lblKg_gr As System.Windows.Forms.Label
    Friend WithEvents txtactual_cone_weight As System.Windows.Forms.TextBox
    Friend WithEvents lblactual_cone_weight As System.Windows.Forms.Label
    Friend WithEvents chkAutoCalculate As System.Windows.Forms.CheckBox
    Friend WithEvents GbDetail As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboMtlSubinventory As System.Windows.Forms.ComboBox
    Friend WithEvents txtlotno_sup As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBoxno As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtlotno_our As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbooperator As ComboBox
End Class
