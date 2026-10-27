<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKnittingOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKnittingOrder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cboKoNo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnRouting = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.btnMinimized = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPRODNo = New System.Windows.Forms.TextBox()
        Me.dtpKODate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optKS = New System.Windows.Forms.RadioButton()
        Me.optWO = New System.Windows.Forms.RadioButton()
        Me.optKC = New System.Windows.Forms.RadioButton()
        Me.optKP = New System.Windows.Forms.RadioButton()
        Me.optKO = New System.Windows.Forms.RadioButton()
        Me.optKI = New System.Windows.Forms.RadioButton()
        Me.txtGwth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboBOM = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cboMachineNo = New System.Windows.Forms.ComboBox()
        Me.cboDesignNo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboSONo = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRolls = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRepeatWth = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtRepeatLen = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtNob = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtproduction_order_no_cross = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtDesign_cross = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtSketch = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtTotal_Production_lot = New System.Windows.Forms.TextBox()
        Me.btnGenQty = New System.Windows.Forms.Button()
        Me.btnGenKenddt = New System.Windows.Forms.Button()
        Me.txtDailyCapacity = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtSetOut = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNeedle = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtDFBatchSize = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtStandardRollKgs = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSetupDays = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.grdData = New System.Windows.Forms.DataGridView()
        Me.itcd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itdesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ynperc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yarn_use_kgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.chkCationicPoly = New System.Windows.Forms.CheckBox()
        Me.chkRayon = New System.Windows.Forms.CheckBox()
        Me.chkCrossDye = New System.Windows.Forms.CheckBox()
        Me.chkSolid = New System.Windows.Forms.CheckBox()
        Me.chkRigid = New System.Windows.Forms.CheckBox()
        Me.chkElastic = New System.Windows.Forms.CheckBox()
        Me.chkDelivered = New System.Windows.Forms.CheckBox()
        Me.chkClosed = New System.Windows.Forms.CheckBox()
        Me.chkCancelled = New System.Windows.Forms.CheckBox()
        Me.dtpCancelled = New System.Windows.Forms.DateTimePicker()
        Me.dtpClosed = New System.Windows.Forms.DateTimePicker()
        Me.dtpDelivered = New System.Windows.Forms.DateTimePicker()
        Me.txtCancelledRemark = New System.Windows.Forms.TextBox()
        Me.txtClosedRemark = New System.Windows.Forms.TextBox()
        Me.txtDeliveredRemark = New System.Windows.Forms.TextBox()
        Me.grdmfg_production_order_lines = New System.Windows.Forms.DataGridView()
        Me.mfg_production_order_lines_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mfg_production_order_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.item_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.mtl_warehouse_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.source_subinventory_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.line_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_perc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.plan_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actual_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uom_id = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.creation_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.created_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_modified_date = New ProductionSystem.DataGridViewCalendarColumn()
        Me.last_modified_by = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_header_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bom_line_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtsteam_instruction = New System.Windows.Forms.TextBox()
        Me.DataGridViewCalendarColumn1 = New ProductionSystem.DataGridViewCalendarColumn()
        Me.DataGridViewCalendarColumn2 = New ProductionSystem.DataGridViewCalendarColumn()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtdyeding_loss_perc = New System.Windows.Forms.TextBox()
        Me.txtknit_loss_perc = New System.Windows.Forms.TextBox()
        Me.lblsteam_instruction = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.grdmfg_production_order_lines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cboKoNo, Me.ToolStripSeparator1, Me.btnNew, Me.btnSearch, Me.btnSave, Me.btnRouting, Me.btnPrint, Me.btnMinimized, Me.btnExit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1119, 25)
        Me.ToolStrip1.TabIndex = 38
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel1.Text = "PROD. No."
        '
        'cboKoNo
        '
        Me.cboKoNo.Name = "cboKoNo"
        Me.cboKoNo.Size = New System.Drawing.Size(125, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(23, 22)
        Me.btnNew.Text = "New"
        '
        'btnSearch
        '
        Me.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(23, 22)
        Me.btnSearch.Text = "Search"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(23, 22)
        Me.btnSave.Text = "Save"
        '
        'btnRouting
        '
        Me.btnRouting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRouting.Image = CType(resources.GetObject("btnRouting.Image"), System.Drawing.Image)
        Me.btnRouting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRouting.Name = "btnRouting"
        Me.btnRouting.Size = New System.Drawing.Size(23, 22)
        Me.btnRouting.Text = "Routing"
        '
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(23, 22)
        Me.btnPrint.Text = "Print"
        '
        'btnMinimized
        '
        Me.btnMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMinimized.Image = CType(resources.GetObject("btnMinimized.Image"), System.Drawing.Image)
        Me.btnMinimized.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMinimized.Name = "btnMinimized"
        Me.btnMinimized.Size = New System.Drawing.Size(23, 22)
        Me.btnMinimized.Text = "Minimized"
        '
        'btnExit
        '
        Me.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(23, 22)
        Me.btnExit.Text = "Exit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(810, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "PROD. No."
        '
        'txtPRODNo
        '
        Me.txtPRODNo.Location = New System.Drawing.Point(914, 32)
        Me.txtPRODNo.Name = "txtPRODNo"
        Me.txtPRODNo.Size = New System.Drawing.Size(104, 20)
        Me.txtPRODNo.TabIndex = 0
        '
        'dtpKODate
        '
        Me.dtpKODate.CustomFormat = "dd/MM/yyyy"
        Me.dtpKODate.Enabled = False
        Me.dtpKODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpKODate.Location = New System.Drawing.Point(914, 56)
        Me.dtpKODate.Name = "dtpKODate"
        Me.dtpKODate.Size = New System.Drawing.Size(104, 20)
        Me.dtpKODate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(810, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "PROD. Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "SOURCING:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optKS)
        Me.GroupBox1.Controls.Add(Me.optWO)
        Me.GroupBox1.Controls.Add(Me.optKC)
        Me.GroupBox1.Controls.Add(Me.optKP)
        Me.GroupBox1.Controls.Add(Me.optKO)
        Me.GroupBox1.Controls.Add(Me.optKI)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 64)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'optKS
        '
        Me.optKS.AutoSize = True
        Me.optKS.BackColor = System.Drawing.SystemColors.Control
        Me.optKS.Location = New System.Drawing.Point(303, 41)
        Me.optKS.Name = "optKS"
        Me.optKS.Size = New System.Drawing.Size(89, 17)
        Me.optKS.TabIndex = 5
        Me.optKS.Text = "Service (K/S)"
        Me.optKS.UseVisualStyleBackColor = False
        '
        'optWO
        '
        Me.optWO.AutoSize = True
        Me.optWO.BackColor = System.Drawing.Color.Gold
        Me.optWO.Location = New System.Drawing.Point(303, 16)
        Me.optWO.Name = "optWO"
        Me.optWO.Size = New System.Drawing.Size(113, 17)
        Me.optWO.TabIndex = 4
        Me.optWO.Text = "Order Warp(W/O) "
        Me.optWO.UseVisualStyleBackColor = False
        '
        'optKC
        '
        Me.optKC.AutoSize = True
        Me.optKC.BackColor = System.Drawing.Color.Gold
        Me.optKC.Location = New System.Drawing.Point(128, 40)
        Me.optKC.Name = "optKC"
        Me.optKC.Size = New System.Drawing.Size(146, 17)
        Me.optKC.TabIndex = 3
        Me.optKC.Text = "Over Haul(K/C) ล้างเครื่อง"
        Me.optKC.UseVisualStyleBackColor = False
        '
        'optKP
        '
        Me.optKP.AutoSize = True
        Me.optKP.BackColor = System.Drawing.Color.Gold
        Me.optKP.Location = New System.Drawing.Point(8, 40)
        Me.optKP.Name = "optKP"
        Me.optKP.Size = New System.Drawing.Size(98, 17)
        Me.optKP.TabIndex = 2
        Me.optKP.Text = "Purchase (K/P)"
        Me.optKP.UseVisualStyleBackColor = False
        '
        'optKO
        '
        Me.optKO.AutoSize = True
        Me.optKO.BackColor = System.Drawing.Color.Gold
        Me.optKO.Location = New System.Drawing.Point(128, 16)
        Me.optKO.Name = "optKO"
        Me.optKO.Size = New System.Drawing.Size(103, 17)
        Me.optKO.TabIndex = 1
        Me.optKO.Text = "Outsource (K/O)"
        Me.optKO.UseVisualStyleBackColor = False
        '
        'optKI
        '
        Me.optKI.AutoSize = True
        Me.optKI.BackColor = System.Drawing.Color.Gold
        Me.optKI.Checked = True
        Me.optKI.Location = New System.Drawing.Point(8, 16)
        Me.optKI.Name = "optKI"
        Me.optKI.Size = New System.Drawing.Size(84, 17)
        Me.optKI.TabIndex = 0
        Me.optKI.TabStop = True
        Me.optKI.Text = "Internal (K/I)"
        Me.optKI.UseVisualStyleBackColor = False
        '
        'txtGwth
        '
        Me.txtGwth.Location = New System.Drawing.Point(336, 120)
        Me.txtGwth.Name = "txtGwth"
        Me.txtGwth.Size = New System.Drawing.Size(56, 20)
        Me.txtGwth.TabIndex = 5
        Me.txtGwth.Tag = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Greige Width (cms.)"
        '
        'cboBOM
        '
        Me.cboBOM.BackColor = System.Drawing.Color.Gold
        Me.cboBOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBOM.FormattingEnabled = True
        Me.cboBOM.Location = New System.Drawing.Point(589, 19)
        Me.cboBOM.Name = "cboBOM"
        Me.cboBOM.Size = New System.Drawing.Size(64, 21)
        Me.cboBOM.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(532, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 194
        Me.Label5.Text = "BOM No."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 24)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 13)
        Me.Label27.TabIndex = 193
        Me.Label27.Text = "Machine No."
        '
        'cboMachineNo
        '
        Me.cboMachineNo.BackColor = System.Drawing.Color.Gold
        Me.cboMachineNo.FormattingEnabled = True
        Me.cboMachineNo.Location = New System.Drawing.Point(112, 24)
        Me.cboMachineNo.Name = "cboMachineNo"
        Me.cboMachineNo.Size = New System.Drawing.Size(104, 21)
        Me.cboMachineNo.TabIndex = 0
        '
        'cboDesignNo
        '
        Me.cboDesignNo.BackColor = System.Drawing.Color.Gold
        Me.cboDesignNo.FormattingEnabled = True
        Me.cboDesignNo.Location = New System.Drawing.Point(80, 120)
        Me.cboDesignNo.Name = "cboDesignNo"
        Me.cboDesignNo.Size = New System.Drawing.Size(136, 21)
        Me.cboDesignNo.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "Item No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 193
        Me.Label7.Text = "Supplier"
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.Color.Gold
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(80, 24)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(312, 21)
        Me.cboSupplier.TabIndex = 0
        '
        'cboCustomer
        '
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(80, 88)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(312, 21)
        Me.cboCustomer.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 197
        Me.Label9.Text = "S/O No."
        '
        'cboSONo
        '
        Me.cboSONo.BackColor = System.Drawing.Color.Gold
        Me.cboSONo.FormattingEnabled = True
        Me.cboSONo.Location = New System.Drawing.Point(80, 56)
        Me.cboSONo.Name = "cboSONo"
        Me.cboSONo.Size = New System.Drawing.Size(136, 21)
        Me.cboSONo.TabIndex = 1
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Gold
        Me.txtQty.Location = New System.Drawing.Point(336, 56)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(56, 20)
        Me.txtQty.TabIndex = 2
        Me.txtQty.Tag = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(232, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 13)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "Quantity (Kgs.)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 205
        Me.Label13.Text = "Customer"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRolls)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtWidth)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 80)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Allover"
        '
        'txtRolls
        '
        Me.txtRolls.Location = New System.Drawing.Point(96, 48)
        Me.txtRolls.Name = "txtRolls"
        Me.txtRolls.Size = New System.Drawing.Size(56, 20)
        Me.txtRolls.TabIndex = 1
        Me.txtRolls.Tag = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(16, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 207
        Me.Label14.Text = "No. of Rolls"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(96, 24)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(56, 20)
        Me.txtWidth.TabIndex = 0
        Me.txtWidth.Tag = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Width"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtRepeatWth)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtRepeatLen)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtNob)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(186, 314)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(224, 92)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Band"
        '
        'txtRepeatWth
        '
        Me.txtRepeatWth.Location = New System.Drawing.Point(146, 64)
        Me.txtRepeatWth.Name = "txtRepeatWth"
        Me.txtRepeatWth.Size = New System.Drawing.Size(56, 20)
        Me.txtRepeatWth.TabIndex = 2
        Me.txtRepeatWth.Tag = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(18, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 13)
        Me.Label17.TabIndex = 209
        Me.Label17.Text = "Repeat Width (cms.)"
        '
        'txtRepeatLen
        '
        Me.txtRepeatLen.Location = New System.Drawing.Point(146, 40)
        Me.txtRepeatLen.Name = "txtRepeatLen"
        Me.txtRepeatLen.Size = New System.Drawing.Size(56, 20)
        Me.txtRepeatLen.TabIndex = 1
        Me.txtRepeatLen.Tag = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(18, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 13)
        Me.Label15.TabIndex = 207
        Me.Label15.Text = "Repeat Length (cms.)"
        '
        'txtNob
        '
        Me.txtNob.Location = New System.Drawing.Point(146, 16)
        Me.txtNob.Name = "txtNob"
        Me.txtNob.Size = New System.Drawing.Size(56, 20)
        Me.txtNob.TabIndex = 0
        Me.txtNob.Tag = "1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 13)
        Me.Label16.TabIndex = 207
        Me.Label16.Text = "No. of Bands"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(12, 516)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(208, 93)
        Me.txtRemark.TabIndex = 6
        Me.txtRemark.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 495)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 209
        Me.Label10.Text = "Remark"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtproduction_order_no_cross)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtDesign_cross)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.txtSketch)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cboSupplier)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtQty)
        Me.GroupBox4.Controls.Add(Me.cboDesignNo)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cboSONo)
        Me.GroupBox4.Controls.Add(Me.txtGwth)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cboCustomer)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(400, 205)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Order Information"
        '
        'txtproduction_order_no_cross
        '
        Me.txtproduction_order_no_cross.Location = New System.Drawing.Point(296, 179)
        Me.txtproduction_order_no_cross.Name = "txtproduction_order_no_cross"
        Me.txtproduction_order_no_cross.Size = New System.Drawing.Size(96, 20)
        Me.txtproduction_order_no_cross.TabIndex = 213
        Me.txtproduction_order_no_cross.Tag = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(194, 181)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(89, 13)
        Me.Label28.TabIndex = 212
        Me.Label28.Text = "Warp For KO No."
        '
        'txtDesign_cross
        '
        Me.txtDesign_cross.Location = New System.Drawing.Point(296, 151)
        Me.txtDesign_cross.Name = "txtDesign_cross"
        Me.txtDesign_cross.Size = New System.Drawing.Size(96, 20)
        Me.txtDesign_cross.TabIndex = 211
        Me.txtDesign_cross.Tag = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(194, 155)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 13)
        Me.Label26.TabIndex = 210
        Me.Label26.Text = "Warp For Dm No."
        '
        'txtSketch
        '
        Me.txtSketch.Location = New System.Drawing.Point(80, 152)
        Me.txtSketch.Name = "txtSketch"
        Me.txtSketch.Size = New System.Drawing.Size(96, 20)
        Me.txtSketch.TabIndex = 6
        Me.txtSketch.Tag = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(12, 154)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(41, 13)
        Me.Label22.TabIndex = 208
        Me.Label22.Text = "Sketch"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.txtTotal_Production_lot)
        Me.GroupBox5.Controls.Add(Me.btnGenQty)
        Me.GroupBox5.Controls.Add(Me.btnGenKenddt)
        Me.GroupBox5.Controls.Add(Me.txtDailyCapacity)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.txtSetOut)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.txtNeedle)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtDFBatchSize)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.txtStandardRollKgs)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtSetupDays)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.dtpEndDate)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.dtpStartDate)
        Me.GroupBox5.Controls.Add(Me.cboMachineNo)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Location = New System.Drawing.Point(416, 104)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(325, 266)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Planning Information"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 241)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(108, 13)
        Me.Label31.TabIndex = 229
        Me.Label31.Text = "Total Production Lots"
        '
        'txtTotal_Production_lot
        '
        Me.txtTotal_Production_lot.BackColor = System.Drawing.Color.Gold
        Me.txtTotal_Production_lot.Location = New System.Drawing.Point(152, 241)
        Me.txtTotal_Production_lot.Name = "txtTotal_Production_lot"
        Me.txtTotal_Production_lot.Size = New System.Drawing.Size(64, 20)
        Me.txtTotal_Production_lot.TabIndex = 228
        Me.txtTotal_Production_lot.Tag = "0.00"
        '
        'btnGenQty
        '
        Me.btnGenQty.Location = New System.Drawing.Point(234, 98)
        Me.btnGenQty.Name = "btnGenQty"
        Me.btnGenQty.Size = New System.Drawing.Size(75, 44)
        Me.btnGenQty.TabIndex = 227
        Me.btnGenQty.Text = "Generate Quantity"
        Me.btnGenQty.UseVisualStyleBackColor = True
        '
        'btnGenKenddt
        '
        Me.btnGenKenddt.Location = New System.Drawing.Point(234, 48)
        Me.btnGenKenddt.Name = "btnGenKenddt"
        Me.btnGenKenddt.Size = New System.Drawing.Size(75, 44)
        Me.btnGenKenddt.TabIndex = 226
        Me.btnGenKenddt.Text = "Generate End Date"
        Me.btnGenKenddt.UseVisualStyleBackColor = True
        '
        'txtDailyCapacity
        '
        Me.txtDailyCapacity.BackColor = System.Drawing.Color.Gold
        Me.txtDailyCapacity.Location = New System.Drawing.Point(152, 168)
        Me.txtDailyCapacity.Name = "txtDailyCapacity"
        Me.txtDailyCapacity.Size = New System.Drawing.Size(64, 20)
        Me.txtDailyCapacity.TabIndex = 7
        Me.txtDailyCapacity.Tag = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 168)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(104, 13)
        Me.Label25.TabIndex = 210
        Me.Label25.Text = "Daily Capacity (Kgs.)"
        '
        'txtSetOut
        '
        Me.txtSetOut.Location = New System.Drawing.Point(112, 216)
        Me.txtSetOut.Name = "txtSetOut"
        Me.txtSetOut.Size = New System.Drawing.Size(104, 20)
        Me.txtSetOut.TabIndex = 9
        Me.txtSetOut.Tag = "0"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 216)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 208
        Me.Label24.Text = "Set Out"
        '
        'txtNeedle
        '
        Me.txtNeedle.Location = New System.Drawing.Point(112, 192)
        Me.txtNeedle.Name = "txtNeedle"
        Me.txtNeedle.Size = New System.Drawing.Size(104, 20)
        Me.txtNeedle.TabIndex = 8
        Me.txtNeedle.Tag = "0"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 192)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 13)
        Me.Label23.TabIndex = 206
        Me.Label23.Text = "Needle"
        '
        'txtDFBatchSize
        '
        Me.txtDFBatchSize.Location = New System.Drawing.Point(112, 144)
        Me.txtDFBatchSize.Name = "txtDFBatchSize"
        Me.txtDFBatchSize.Size = New System.Drawing.Size(104, 20)
        Me.txtDFBatchSize.TabIndex = 6
        Me.txtDFBatchSize.Tag = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 144)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 202
        Me.Label21.Text = "D/F Batch Size"
        '
        'txtStandardRollKgs
        '
        Me.txtStandardRollKgs.BackColor = System.Drawing.Color.Gold
        Me.txtStandardRollKgs.Location = New System.Drawing.Point(165, 120)
        Me.txtStandardRollKgs.Name = "txtStandardRollKgs"
        Me.txtStandardRollKgs.Size = New System.Drawing.Size(51, 20)
        Me.txtStandardRollKgs.TabIndex = 5
        Me.txtStandardRollKgs.Tag = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 120)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(138, 13)
        Me.Label20.TabIndex = 200
        Me.Label20.Text = "Standard Roll Weight (Kgs.)"
        '
        'txtSetupDays
        '
        Me.txtSetupDays.Location = New System.Drawing.Point(112, 96)
        Me.txtSetupDays.Name = "txtSetupDays"
        Me.txtSetupDays.Size = New System.Drawing.Size(104, 20)
        Me.txtSetupDays.TabIndex = 4
        Me.txtSetupDays.Tag = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 13)
        Me.Label19.TabIndex = 198
        Me.Label19.Text = "Setup Days"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 13)
        Me.Label18.TabIndex = 197
        Me.Label18.Text = "Finished Date"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(112, 72)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpEndDate.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "Start Date"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "dd/MM/yyyy"
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(112, 48)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(104, 20)
        Me.dtpStartDate.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.grdData)
        Me.GroupBox6.Location = New System.Drawing.Point(747, 104)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(360, 278)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Bill of Materials (BOM)"
        Me.GroupBox6.Visible = False
        '
        'grdData
        '
        Me.grdData.AllowUserToAddRows = False
        Me.grdData.AllowUserToDeleteRows = False
        Me.grdData.BackgroundColor = System.Drawing.Color.PeachPuff
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itcd, Me.itdesc, Me.ynperc, Me.yarn_use_kgs})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdData.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdData.Location = New System.Drawing.Point(8, 56)
        Me.grdData.Name = "grdData"
        Me.grdData.ReadOnly = True
        Me.grdData.RowHeadersWidth = 30
        Me.grdData.Size = New System.Drawing.Size(344, 210)
        Me.grdData.TabIndex = 1
        '
        'itcd
        '
        Me.itcd.DataPropertyName = "itcd"
        Me.itcd.HeaderText = "Item Code"
        Me.itcd.Name = "itcd"
        Me.itcd.ReadOnly = True
        Me.itcd.Width = 80
        '
        'itdesc
        '
        Me.itdesc.DataPropertyName = "itdesc"
        Me.itdesc.HeaderText = "Description"
        Me.itdesc.Name = "itdesc"
        Me.itdesc.ReadOnly = True
        Me.itdesc.Width = 120
        '
        'ynperc
        '
        Me.ynperc.DataPropertyName = "ynperc"
        Me.ynperc.HeaderText = "%"
        Me.ynperc.Name = "ynperc"
        Me.ynperc.ReadOnly = True
        Me.ynperc.Width = 50
        '
        'yarn_use_kgs
        '
        Me.yarn_use_kgs.DataPropertyName = "yarn_use_kgs"
        Me.yarn_use_kgs.HeaderText = "Kgs."
        Me.yarn_use_kgs.Name = "yarn_use_kgs"
        Me.yarn_use_kgs.ReadOnly = True
        Me.yarn_use_kgs.Width = 50
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.chkCationicPoly)
        Me.GroupBox7.Controls.Add(Me.chkRayon)
        Me.GroupBox7.Controls.Add(Me.chkCrossDye)
        Me.GroupBox7.Controls.Add(Me.chkSolid)
        Me.GroupBox7.Controls.Add(Me.chkRigid)
        Me.GroupBox7.Controls.Add(Me.chkElastic)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 406)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(360, 72)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Special Instruction"
        '
        'chkCationicPoly
        '
        Me.chkCationicPoly.AutoSize = True
        Me.chkCationicPoly.Location = New System.Drawing.Point(256, 48)
        Me.chkCationicPoly.Name = "chkCationicPoly"
        Me.chkCationicPoly.Size = New System.Drawing.Size(93, 17)
        Me.chkCationicPoly.TabIndex = 5
        Me.chkCationicPoly.Text = "Cationic - Poly"
        Me.chkCationicPoly.UseVisualStyleBackColor = True
        '
        'chkRayon
        '
        Me.chkRayon.AutoSize = True
        Me.chkRayon.Location = New System.Drawing.Point(256, 24)
        Me.chkRayon.Name = "chkRayon"
        Me.chkRayon.Size = New System.Drawing.Size(57, 17)
        Me.chkRayon.TabIndex = 4
        Me.chkRayon.Text = "Rayon"
        Me.chkRayon.UseVisualStyleBackColor = True
        '
        'chkCrossDye
        '
        Me.chkCrossDye.AutoSize = True
        Me.chkCrossDye.Location = New System.Drawing.Point(128, 48)
        Me.chkCrossDye.Name = "chkCrossDye"
        Me.chkCrossDye.Size = New System.Drawing.Size(74, 17)
        Me.chkCrossDye.TabIndex = 3
        Me.chkCrossDye.Text = "Cross Dye"
        Me.chkCrossDye.UseVisualStyleBackColor = True
        '
        'chkSolid
        '
        Me.chkSolid.AutoSize = True
        Me.chkSolid.Location = New System.Drawing.Point(128, 24)
        Me.chkSolid.Name = "chkSolid"
        Me.chkSolid.Size = New System.Drawing.Size(49, 17)
        Me.chkSolid.TabIndex = 2
        Me.chkSolid.Text = "Solid"
        Me.chkSolid.UseVisualStyleBackColor = True
        '
        'chkRigid
        '
        Me.chkRigid.AutoSize = True
        Me.chkRigid.Location = New System.Drawing.Point(16, 48)
        Me.chkRigid.Name = "chkRigid"
        Me.chkRigid.Size = New System.Drawing.Size(50, 17)
        Me.chkRigid.TabIndex = 1
        Me.chkRigid.Text = "Rigid"
        Me.chkRigid.UseVisualStyleBackColor = True
        '
        'chkElastic
        '
        Me.chkElastic.AutoSize = True
        Me.chkElastic.Location = New System.Drawing.Point(16, 24)
        Me.chkElastic.Name = "chkElastic"
        Me.chkElastic.Size = New System.Drawing.Size(57, 17)
        Me.chkElastic.TabIndex = 0
        Me.chkElastic.Text = "Elastic"
        Me.chkElastic.UseVisualStyleBackColor = True
        '
        'chkDelivered
        '
        Me.chkDelivered.AutoSize = True
        Me.chkDelivered.Location = New System.Drawing.Point(12, 663)
        Me.chkDelivered.Name = "chkDelivered"
        Me.chkDelivered.Size = New System.Drawing.Size(71, 17)
        Me.chkDelivered.TabIndex = 13
        Me.chkDelivered.Text = "Delivered"
        Me.chkDelivered.UseVisualStyleBackColor = True
        '
        'chkClosed
        '
        Me.chkClosed.AutoSize = True
        Me.chkClosed.Location = New System.Drawing.Point(12, 639)
        Me.chkClosed.Name = "chkClosed"
        Me.chkClosed.Size = New System.Drawing.Size(58, 17)
        Me.chkClosed.TabIndex = 10
        Me.chkClosed.Text = "Closed"
        Me.chkClosed.UseVisualStyleBackColor = True
        '
        'chkCancelled
        '
        Me.chkCancelled.AutoSize = True
        Me.chkCancelled.Location = New System.Drawing.Point(12, 615)
        Me.chkCancelled.Name = "chkCancelled"
        Me.chkCancelled.Size = New System.Drawing.Size(73, 17)
        Me.chkCancelled.TabIndex = 7
        Me.chkCancelled.Text = "Cancelled"
        Me.chkCancelled.UseVisualStyleBackColor = True
        '
        'dtpCancelled
        '
        Me.dtpCancelled.CustomFormat = "dd/MM/yyyy"
        Me.dtpCancelled.Enabled = False
        Me.dtpCancelled.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCancelled.Location = New System.Drawing.Point(116, 615)
        Me.dtpCancelled.Name = "dtpCancelled"
        Me.dtpCancelled.Size = New System.Drawing.Size(104, 20)
        Me.dtpCancelled.TabIndex = 8
        '
        'dtpClosed
        '
        Me.dtpClosed.CustomFormat = "dd/MM/yyyy"
        Me.dtpClosed.Enabled = False
        Me.dtpClosed.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpClosed.Location = New System.Drawing.Point(116, 639)
        Me.dtpClosed.Name = "dtpClosed"
        Me.dtpClosed.Size = New System.Drawing.Size(104, 20)
        Me.dtpClosed.TabIndex = 11
        '
        'dtpDelivered
        '
        Me.dtpDelivered.CustomFormat = "dd/MM/yyyy"
        Me.dtpDelivered.Enabled = False
        Me.dtpDelivered.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDelivered.Location = New System.Drawing.Point(116, 663)
        Me.dtpDelivered.Name = "dtpDelivered"
        Me.dtpDelivered.Size = New System.Drawing.Size(104, 20)
        Me.dtpDelivered.TabIndex = 14
        '
        'txtCancelledRemark
        '
        Me.txtCancelledRemark.Location = New System.Drawing.Point(236, 615)
        Me.txtCancelledRemark.Name = "txtCancelledRemark"
        Me.txtCancelledRemark.Size = New System.Drawing.Size(204, 20)
        Me.txtCancelledRemark.TabIndex = 9
        '
        'txtClosedRemark
        '
        Me.txtClosedRemark.Location = New System.Drawing.Point(236, 639)
        Me.txtClosedRemark.Name = "txtClosedRemark"
        Me.txtClosedRemark.Size = New System.Drawing.Size(204, 20)
        Me.txtClosedRemark.TabIndex = 12
        '
        'txtDeliveredRemark
        '
        Me.txtDeliveredRemark.Location = New System.Drawing.Point(236, 663)
        Me.txtDeliveredRemark.Name = "txtDeliveredRemark"
        Me.txtDeliveredRemark.Size = New System.Drawing.Size(204, 20)
        Me.txtDeliveredRemark.TabIndex = 15
        '
        'grdmfg_production_order_lines
        '
        Me.grdmfg_production_order_lines.AllowUserToAddRows = False
        Me.grdmfg_production_order_lines.AllowUserToDeleteRows = False
        Me.grdmfg_production_order_lines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdmfg_production_order_lines.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.mfg_production_order_lines_id, Me.mfg_production_order_id, Me.item_id, Me.mtl_warehouse_id, Me.source_subinventory_id, Me.line_type, Me.bom_perc, Me.plan_qty, Me.actual_qty, Me.uom_id, Me.creation_date, Me.created_by, Me.last_modified_date, Me.last_modified_by, Me.bom_header_id, Me.bom_line_id})
        Me.grdmfg_production_order_lines.Location = New System.Drawing.Point(21, 47)
        Me.grdmfg_production_order_lines.Name = "grdmfg_production_order_lines"
        Me.grdmfg_production_order_lines.Size = New System.Drawing.Size(630, 178)
        Me.grdmfg_production_order_lines.TabIndex = 210
        '
        'mfg_production_order_lines_id
        '
        Me.mfg_production_order_lines_id.DataPropertyName = "mfg_production_order_lines_id"
        Me.mfg_production_order_lines_id.HeaderText = "id"
        Me.mfg_production_order_lines_id.Name = "mfg_production_order_lines_id"
        Me.mfg_production_order_lines_id.ReadOnly = True
        Me.mfg_production_order_lines_id.Visible = False
        Me.mfg_production_order_lines_id.Width = 50
        '
        'mfg_production_order_id
        '
        Me.mfg_production_order_id.DataPropertyName = "mfg_production_order_id"
        Me.mfg_production_order_id.HeaderText = "mfg_production_order_id"
        Me.mfg_production_order_id.Name = "mfg_production_order_id"
        Me.mfg_production_order_id.Visible = False
        '
        'item_id
        '
        Me.item_id.DataPropertyName = "item_id"
        Me.item_id.HeaderText = "Item Code"
        Me.item_id.Name = "item_id"
        Me.item_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.item_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'mtl_warehouse_id
        '
        Me.mtl_warehouse_id.DataPropertyName = "mtl_warehouse_id"
        Me.mtl_warehouse_id.HeaderText = "Warehouse"
        Me.mtl_warehouse_id.Name = "mtl_warehouse_id"
        Me.mtl_warehouse_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.mtl_warehouse_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'source_subinventory_id
        '
        Me.source_subinventory_id.DataPropertyName = "source_subinventory_id"
        Me.source_subinventory_id.HeaderText = "Source Subinventory"
        Me.source_subinventory_id.Name = "source_subinventory_id"
        Me.source_subinventory_id.Width = 150
        '
        'line_type
        '
        Me.line_type.DataPropertyName = "line_type"
        Me.line_type.HeaderText = "Type"
        Me.line_type.Name = "line_type"
        Me.line_type.Visible = False
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
        Me.plan_qty.Width = 50
        '
        'actual_qty
        '
        Me.actual_qty.DataPropertyName = "actual_qty"
        Me.actual_qty.HeaderText = "Actual Qty"
        Me.actual_qty.Name = "actual_qty"
        Me.actual_qty.Width = 50
        '
        'uom_id
        '
        Me.uom_id.DataPropertyName = "uom_id"
        Me.uom_id.HeaderText = "UOM"
        Me.uom_id.Name = "uom_id"
        Me.uom_id.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.uom_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.uom_id.Width = 50
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
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.grdmfg_production_order_lines)
        Me.GroupBox8.Controls.Add(Me.cboBOM)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.txtsteam_instruction)
        Me.GroupBox8.Location = New System.Drawing.Point(446, 458)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(661, 231)
        Me.GroupBox8.TabIndex = 211
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Production Line"
        '
        'txtsteam_instruction
        '
        Me.txtsteam_instruction.Location = New System.Drawing.Point(-114, 37)
        Me.txtsteam_instruction.Multiline = True
        Me.txtsteam_instruction.Name = "txtsteam_instruction"
        Me.txtsteam_instruction.Size = New System.Drawing.Size(108, 52)
        Me.txtsteam_instruction.TabIndex = 213
        '
        'DataGridViewCalendarColumn1
        '
        Me.DataGridViewCalendarColumn1.DataPropertyName = "creation_date"
        Me.DataGridViewCalendarColumn1.HeaderText = "creation_date"
        Me.DataGridViewCalendarColumn1.Name = "DataGridViewCalendarColumn1"
        Me.DataGridViewCalendarColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCalendarColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewCalendarColumn2
        '
        Me.DataGridViewCalendarColumn2.DataPropertyName = "last_modified_date"
        Me.DataGridViewCalendarColumn2.HeaderText = "last_modified_date"
        Me.DataGridViewCalendarColumn2.Name = "DataGridViewCalendarColumn2"
        Me.DataGridViewCalendarColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCalendarColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label30)
        Me.GroupBox9.Controls.Add(Me.Label29)
        Me.GroupBox9.Controls.Add(Me.txtdyeding_loss_perc)
        Me.GroupBox9.Controls.Add(Me.txtknit_loss_perc)
        Me.GroupBox9.Location = New System.Drawing.Point(416, 374)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(229, 78)
        Me.GroupBox9.TabIndex = 212
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Process Lost Plan"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 46)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(69, 13)
        Me.Label30.TabIndex = 3
        Me.Label30.Text = "Dyeding Lost"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(11, 23)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(81, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Production Lost"
        '
        'txtdyeding_loss_perc
        '
        Me.txtdyeding_loss_perc.Location = New System.Drawing.Point(112, 43)
        Me.txtdyeding_loss_perc.Name = "txtdyeding_loss_perc"
        Me.txtdyeding_loss_perc.Size = New System.Drawing.Size(100, 20)
        Me.txtdyeding_loss_perc.TabIndex = 1
        Me.txtdyeding_loss_perc.Tag = "0.00"
        '
        'txtknit_loss_perc
        '
        Me.txtknit_loss_perc.Location = New System.Drawing.Point(112, 17)
        Me.txtknit_loss_perc.Name = "txtknit_loss_perc"
        Me.txtknit_loss_perc.Size = New System.Drawing.Size(100, 20)
        Me.txtknit_loss_perc.TabIndex = 0
        Me.txtknit_loss_perc.Tag = "0.00"
        '
        'lblsteam_instruction
        '
        Me.lblsteam_instruction.AutoSize = True
        Me.lblsteam_instruction.Location = New System.Drawing.Point(247, 495)
        Me.lblsteam_instruction.Name = "lblsteam_instruction"
        Me.lblsteam_instruction.Size = New System.Drawing.Size(89, 13)
        Me.lblsteam_instruction.TabIndex = 214
        Me.lblsteam_instruction.Text = "Steam Instruction"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(236, 516)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(204, 93)
        Me.TextBox1.TabIndex = 215
        Me.TextBox1.Tag = ""
        '
        'frmKnittingOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 701)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblsteam_instruction)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.txtDeliveredRemark)
        Me.Controls.Add(Me.txtClosedRemark)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtCancelledRemark)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.dtpDelivered)
        Me.Controls.Add(Me.dtpClosed)
        Me.Controls.Add(Me.dtpCancelled)
        Me.Controls.Add(Me.chkDelivered)
        Me.Controls.Add(Me.chkClosed)
        Me.Controls.Add(Me.chkCancelled)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpKODate)
        Me.Controls.Add(Me.txtPRODNo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKnittingOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Production Order"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.grdData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.grdmfg_production_order_lines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cboKoNo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMinimized As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPRODNo As System.Windows.Forms.TextBox
    Friend WithEvents dtpKODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optKP As System.Windows.Forms.RadioButton
    Friend WithEvents optKO As System.Windows.Forms.RadioButton
    Friend WithEvents optKI As System.Windows.Forms.RadioButton
    Friend WithEvents txtGwth As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboSONo As System.Windows.Forms.ComboBox
    Friend WithEvents cboDesignNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents cboBOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cboMachineNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRepeatWth As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRepeatLen As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtNob As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRolls As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDFBatchSize As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtStandardRollKgs As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtSetupDays As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSetOut As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtNeedle As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents grdData As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCationicPoly As System.Windows.Forms.CheckBox
    Friend WithEvents chkRayon As System.Windows.Forms.CheckBox
    Friend WithEvents chkCrossDye As System.Windows.Forms.CheckBox
    Friend WithEvents chkSolid As System.Windows.Forms.CheckBox
    Friend WithEvents chkRigid As System.Windows.Forms.CheckBox
    Friend WithEvents chkElastic As System.Windows.Forms.CheckBox
    Friend WithEvents chkDelivered As System.Windows.Forms.CheckBox
    Friend WithEvents chkClosed As System.Windows.Forms.CheckBox
    Friend WithEvents chkCancelled As System.Windows.Forms.CheckBox
    Friend WithEvents dtpCancelled As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpClosed As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDelivered As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSketch As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCancelledRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtClosedRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtDeliveredRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtDailyCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents optKC As System.Windows.Forms.RadioButton
    Friend WithEvents itcd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itdesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ynperc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yarn_use_kgs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents optWO As System.Windows.Forms.RadioButton
    Friend WithEvents txtDesign_cross As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnRouting As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGenKenddt As System.Windows.Forms.Button
    Friend WithEvents optKS As System.Windows.Forms.RadioButton
    Friend WithEvents txtproduction_order_no_cross As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents grdmfg_production_order_lines As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewCalendarColumn1 As ProductionSystem.DataGridViewCalendarColumn
    Friend WithEvents DataGridViewCalendarColumn2 As ProductionSystem.DataGridViewCalendarColumn
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtdyeding_loss_perc As System.Windows.Forms.TextBox
    Friend WithEvents txtknit_loss_perc As System.Windows.Forms.TextBox
    Friend WithEvents txtsteam_instruction As System.Windows.Forms.TextBox
    Friend WithEvents lblsteam_instruction As System.Windows.Forms.Label
    Friend WithEvents btnGenQty As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_Production_lot As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents mfg_production_order_lines_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mfg_production_order_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents item_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents mtl_warehouse_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents source_subinventory_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents line_type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bom_perc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents plan_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents actual_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents uom_id As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents creation_date As ProductionSystem.DataGridViewCalendarColumn
    Friend WithEvents created_by As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents last_modified_date As ProductionSystem.DataGridViewCalendarColumn
    Friend WithEvents last_modified_by As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bom_header_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bom_line_id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
